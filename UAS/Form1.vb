Imports System.IO
Imports ExcelDataReader
Imports System.Drawing.Printing


Public Class Form1
    Dim TotalHarga As Integer = 0
    Dim Modal As Integer = 0
    Dim Untung As Integer = 0
    Dim EstiUntung As Integer = 0

    Sub Hitung()
        Modal = 0
        EstiUntung = 0
        Untung = 0
        For Each rows As DataGridViewRow In DataGridView1.Rows
            If Not rows.IsNewRow Then
                Modal += Integer.Parse(rows.Cells(2).Value) * Integer.Parse(rows.Cells(4).Value)
                Untung -= Integer.Parse(rows.Cells(2).Value) * Integer.Parse(rows.Cells(4).Value)
                EstiUntung += Integer.Parse(rows.Cells(6).Value)
            End If
        Next
        EstUntung.Text = EstiUntung
        UntungRugi.Text = Untung
    End Sub
    Sub InitValueStok()
        HargaBeliS.Text = ""
        HargaJualS.Text = ""
        StokS.Text = ""
        DiskonS.Text = "0"
        UntungS.Text = ""
    End Sub

    Sub InitValueBeli()
        KodeBarangB.Text = ""
        NamaBarangB.Text = ""
        HargaBarangB.Text = ""
        StokB.Text = ""
        JumlahBeliB.Text = ""
        DiskonB.Text = ""
        TotalHargaB.Text = ""
        TotalHarga = 0
        TotalAll.Text = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sourceFilePath As String = "test.xlsx" ' Lokasi file sumber 
        Dim saveFileDialog As New SaveFileDialog()

        ' Konfigurasi SaveFileDialog
        saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx|All Files|*.*"
        saveFileDialog.Title = "Save File"
        saveFileDialog.FileName = Path.GetFileName(sourceFilePath) ' Mengatur nama default file
        saveFileDialog.InitialDirectory = "C:\" ' Lokasi awal untuk dialog

        ' Menampilkan dialog dan menunggu sampai pengguna memilih lokasi penyimpanan
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim destinationFilePath As String = saveFileDialog.FileName

            Try
                ' Memeriksa apakah file sumber ada
                If File.Exists(sourceFilePath) Then
                    ' Menyalin file dari lokasi sumber ke lokasi tujuan yang dipilih pengguna
                    File.Copy(sourceFilePath, destinationFilePath, True)

                    MessageBox.Show("File berhasil diunduh ke lokasi: " & destinationFilePath, "Unduh Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("File sumber tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat mengunduh file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub TambahExcel_Click(sender As Object, e As EventArgs) Handles TambahExcel.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx|All Files|*.*"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = openFileDialog.FileName

                Try
                    ' Baca data dari file Excel
                    Using stream As FileStream = File.Open(filePath, FileMode.Open, FileAccess.Read)
                        Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)

                            ' Baca data ke DataSet
                            Dim result As DataSet = reader.AsDataSet()

                            ' Ambil tabel pertama dari DataSet
                            Dim dataTable As DataTable = result.Tables(0)

                            ' Pastikan ada setidaknya satu baris
                            If dataTable.Rows.Count > 0 Then
                                ' Tambahkan data dari baris kedua dan seterusnya ke DataGridView
                                For i As Integer = 1 To dataTable.Rows.Count - 1
                                    Dim row As DataRow = dataTable.Rows(i)

                                    Dim IndexRow As Integer = -1
                                    For Each rows As DataGridViewRow In DataGridView1.Rows
                                        If Not rows.IsNewRow Then
                                            If (rows.Cells(0).Value = row.ItemArray(0)) Then
                                                IndexRow = rows.Index
                                            End If
                                        End If
                                    Next
                                    ' Tambahkan kolom ke DataGridView
                                    If (IndexRow <> -1) Then
                                        DataGridView1.Rows(IndexRow).Cells(1).Value = row.ItemArray(1)
                                        DataGridView1.Rows(IndexRow).Cells(2).Value = row.ItemArray(2)
                                        DataGridView1.Rows(IndexRow).Cells(3).Value = row.ItemArray(3)
                                        DataGridView1.Rows(IndexRow).Cells(4).Value = row.ItemArray(4)
                                        DataGridView1.Rows(IndexRow).Cells(5).Value = row.ItemArray(5)
                                        DataGridView1.Rows(IndexRow).Cells(6).Value = row.ItemArray(6)
                                    Else
                                        DataGridView1.Rows.Add(row.ItemArray)
                                    End If
                                    Hitung()
                                    InitValueStok()
                                Next
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan saat membaca file Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub TambahS_Click(sender As Object, e As EventArgs) Handles TambahS.Click
        Dim IndexRow As Integer = -1
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                If (row.Cells(0).Value = KodeBarangS.Text) Then
                    IndexRow = row.Index
                End If
            End If
        Next
        ' Tambahkan kolom ke DataGridView
        If (IndexRow <> -1) Then
            DataGridView1.Rows(IndexRow).Cells(1).Value = NamaBarangS.Text
            DataGridView1.Rows(IndexRow).Cells(2).Value = HargaBeliS.Text
            DataGridView1.Rows(IndexRow).Cells(3).Value = HargaJualS.Text
            DataGridView1.Rows(IndexRow).Cells(4).Value = StokS.Text
            DataGridView1.Rows(IndexRow).Cells(5).Value = DiskonS.Text
            DataGridView1.Rows(IndexRow).Cells(6).Value = UntungS.Text
        Else
            DataGridView1.Rows.Add(KodeBarangS.Text, NamaBarangS.Text, HargaBeliS.Text, HargaJualS.Text, StokS.Text, DiskonS.Text, UntungS.Text)
        End If
        Hitung()
        InitValueStok()
    End Sub

    Private Sub HargaJualS_TextChanged(sender As Object, e As EventArgs) Handles HargaJualS.TextChanged
        If (HargaJualS.Text <> "" And HargaBeliS.Text <> "") Then
            UntungS.Text = (Integer.Parse(HargaJualS.Text) - Integer.Parse(HargaBeliS.Text))
        End If
    End Sub

    Private Sub StokS_TextChanged(sender As Object, e As EventArgs) Handles StokS.TextChanged
        If (HargaJualS.Text <> "" And HargaBeliS.Text <> "" And StokS.Text <> "") Then
            UntungS.Text = (Integer.Parse(HargaJualS.Text) - Integer.Parse(HargaBeliS.Text)) * Integer.Parse(StokS.Text)
        End If
    End Sub

    Private Sub DiskonS_TextChanged(sender As Object, e As EventArgs) Handles DiskonS.TextChanged
        If (HargaJualS.Text <> "" And HargaBeliS.Text <> "" And StokS.Text <> "" And DiskonS.Text <> "") Then
            UntungS.Text = (Integer.Parse(HargaJualS.Text) - Integer.Parse(HargaBeliS.Text) - Integer.Parse(DiskonS.Text)) * Integer.Parse(StokS.Text)
        End If
    End Sub

    Private Sub KodeBarangS_TextChanged(sender As Object, e As EventArgs) Handles KodeBarangS.TextChanged
        For Each row As DataGridViewRow In DataGridView1.Rows
            'For Each cell As DataGridViewCell In row.Cells
            If Not row.IsNewRow Then
                If (row.Cells(0).Value = KodeBarangS.Text) Then
                    NamaBarangS.Text = row.Cells(1).Value
                    HargaBeliS.Text = row.Cells(2).Value
                    HargaJualS.Text = row.Cells(3).Value
                    StokS.Text = row.Cells(4).Value
                    DiskonS.Text = row.Cells(5).Value
                    UntungS.Text = row.Cells(6).Value
                End If
            End If
            'Next
        Next
    End Sub

    Private Sub KodeBarangB_TextChanged(sender As Object, e As EventArgs) Handles KodeBarangB.TextChanged
        If (KodeBarangB.Text <> "") Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    If (row.Cells(0).Value = KodeBarangB.Text) Then
                        NamaBarangB.Text = row.Cells(1).Value
                        HargaBarangB.Text = row.Cells(3).Value
                        StokB.Text = row.Cells(4).Value
                        Dim Diskon = 0
                        If (Integer.Parse(row.Cells(5).Value) > 0) Then
                            Diskon = row.Cells(5).Value
                        End If
                        DiskonB.Text = Diskon
                    End If
                End If
            Next
        Else
            NamaBarangB.Text = ""
            HargaBarangB.Text = ""
            StokB.Text = ""
            DiskonB.Text = ""
        End If
    End Sub

    Private Sub JumlahBeliB_TextChanged(sender As Object, e As EventArgs) Handles JumlahBeliB.TextChanged
        If (JumlahBeliB.Text <> "") Then
            If (Integer.Parse(JumlahBeliB.Text) > Integer.Parse(StokB.Text)) Then
                MessageBox.Show("Jumlah Beli Melebihi Stok Barang")
                JumlahBeliB.Text = StokB.Text
            Else
                TotalHargaB.Text = (Integer.Parse(JumlahBeliB.Text) * Integer.Parse(HargaBarangB.Text)) - (Integer.Parse(JumlahBeliB.Text) * Integer.Parse(DiskonB.Text))
            End If
        Else
            TotalHargaB.Text = 0
        End If
    End Sub

    Private Sub TambahBeli_Click(sender As Object, e As EventArgs) Handles TambahBeli.Click

        TotalHarga += Integer.Parse(TotalHargaB.Text)
        TotalAll.Text = TotalHarga
        Dim DateTime As DateTime = DateTime.Now


        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                If (row.Cells(0).Value = KodeBarangB.Text) Then
                    Dim Stok As Integer = Integer.Parse(row.Cells(4).Value) - Integer.Parse(JumlahBeliB.Text)
                    If (Stok >= 0) Then
                        Dim IndexRow As Integer = row.Index
                        'Dim Stok As Integer = Integer.Parse(row.Cells(4).Value) - Integer.Parse(JumlahBeliB.Text)
                        Dim UntungR As Integer = Integer.Parse(row.Cells(6).Value) - Integer.Parse(row.Cells(3).Value) - Integer.Parse(DiskonB.Text)
                        DataGridView1.Rows(IndexRow).Cells(4).Value = Stok
                        'DataGridView1.Rows(IndexRow).Cells(6).Value = UntungR
                        Untung += Integer.Parse(TotalHargaB.Text)
                        UntungRugi.Text = Untung
                        TabelBeli.Rows.Add(KodeBarangB.Text, NamaBarangB.Text, HargaBarangB.Text, JumlahBeliB.Text, DiskonB.Text, TotalHargaB.Text)
                        Riwayat.Rows.Add(DateTime, KodeBarangB.Text, NamaBarangB.Text, HargaBarangB.Text, JumlahBeliB.Text, DiskonB.Text, TotalHargaB.Text)
                    Else
                        MessageBox.Show("Jumlah Beli Melebihi Stok Barang")
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabelBeli.Rows.Clear()
        InitValueBeli()
    End Sub

    Private Sub UangDiterima_TextChanged(sender As Object, e As EventArgs) Handles UangDiterima.TextChanged
        If (UangDiterima.Text <> "") Then
            Kembalian.Text = Integer.Parse(UangDiterima.Text) - TotalHarga
        End If
    End Sub
End Class
