<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaModal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaJual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimasiUntung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TambahExcel = New System.Windows.Forms.Button()
        Me.TotalAll = New System.Windows.Forms.TextBox()
        Me.TabelBeli = New System.Windows.Forms.DataGridView()
        Me.KodeBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalHargaBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarangB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.JumlahBeliB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HargaBarangB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalHargaB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StokB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DiskonB = New System.Windows.Forms.TextBox()
        Me.TambahBeli = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.KodeBarangS = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NamaBarangS = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.HargaBeliS = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.HargaJualS = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.StokS = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DiskonS = New System.Windows.Forms.TextBox()
        Me.TambahS = New System.Windows.Forms.Button()
        Me.Riwayat = New System.Windows.Forms.DataGridView()
        Me.DateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.UntungRugi = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.UntungS = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.NamaBarangB = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.EstUntung = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.UangDiterima = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Kembalian = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelBeli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Riwayat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button2.Location = New System.Drawing.Point(500, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(281, 43)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Download Tamplate Excel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode, Me.Nama, Me.HargaModal, Me.HargaJual, Me.Stok, Me.DiskonBarang, Me.EstimasiUntung})
        Me.DataGridView1.Location = New System.Drawing.Point(-3, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(784, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'Kode
        '
        Me.Kode.HeaderText = "Kode"
        Me.Kode.Name = "Kode"
        Me.Kode.ReadOnly = True
        Me.Kode.Width = 60
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.ReadOnly = True
        Me.Nama.Width = 180
        '
        'HargaModal
        '
        Me.HargaModal.HeaderText = "Harga Modal"
        Me.HargaModal.Name = "HargaModal"
        Me.HargaModal.ReadOnly = True
        '
        'HargaJual
        '
        Me.HargaJual.HeaderText = "Harga Jual"
        Me.HargaJual.Name = "HargaJual"
        Me.HargaJual.ReadOnly = True
        '
        'Stok
        '
        Me.Stok.HeaderText = "Stok"
        Me.Stok.Name = "Stok"
        Me.Stok.ReadOnly = True
        Me.Stok.Width = 40
        '
        'DiskonBarang
        '
        Me.DiskonBarang.HeaderText = "Diskon"
        Me.DiskonBarang.Name = "DiskonBarang"
        Me.DiskonBarang.ReadOnly = True
        '
        'EstimasiUntung
        '
        Me.EstimasiUntung.HeaderText = "Estimasi Keuntungan"
        Me.EstimasiUntung.Name = "EstimasiUntung"
        Me.EstimasiUntung.ReadOnly = True
        Me.EstimasiUntung.Width = 160
        '
        'TambahExcel
        '
        Me.TambahExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TambahExcel.Location = New System.Drawing.Point(-3, 199)
        Me.TambahExcel.Name = "TambahExcel"
        Me.TambahExcel.Size = New System.Drawing.Size(295, 43)
        Me.TambahExcel.TabIndex = 3
        Me.TambahExcel.Text = "Tambah Barang Dengan Excel"
        Me.TambahExcel.UseVisualStyleBackColor = True
        '
        'TotalAll
        '
        Me.TotalAll.Enabled = False
        Me.TotalAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold)
        Me.TotalAll.Location = New System.Drawing.Point(1192, 2)
        Me.TotalAll.Name = "TotalAll"
        Me.TotalAll.Size = New System.Drawing.Size(711, 98)
        Me.TotalAll.TabIndex = 7
        Me.TotalAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabelBeli
        '
        Me.TabelBeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelBeli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBeli, Me.NamaBarang, Me.Harga, Me.Qty, Me.Diskon, Me.TotalHargaBeli})
        Me.TabelBeli.Location = New System.Drawing.Point(861, 105)
        Me.TabelBeli.Name = "TabelBeli"
        Me.TabelBeli.Size = New System.Drawing.Size(1042, 287)
        Me.TabelBeli.TabIndex = 9
        '
        'KodeBeli
        '
        Me.KodeBeli.HeaderText = "Kode"
        Me.KodeBeli.Name = "KodeBeli"
        Me.KodeBeli.ReadOnly = True
        Me.KodeBeli.Width = 150
        '
        'NamaBarang
        '
        Me.NamaBarang.HeaderText = "Nama Barang"
        Me.NamaBarang.Name = "NamaBarang"
        Me.NamaBarang.ReadOnly = True
        Me.NamaBarang.Width = 283
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.Name = "Harga"
        Me.Harga.ReadOnly = True
        Me.Harga.Width = 150
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        '
        'Diskon
        '
        Me.Diskon.HeaderText = "Diskon"
        Me.Diskon.Name = "Diskon"
        Me.Diskon.ReadOnly = True
        Me.Diskon.Width = 150
        '
        'TotalHargaBeli
        '
        Me.TotalHargaBeli.HeaderText = "Total Harga"
        Me.TotalHargaBeli.Name = "TotalHargaBeli"
        Me.TotalHargaBeli.ReadOnly = True
        Me.TotalHargaBeli.Width = 160
        '
        'KodeBarangB
        '
        Me.KodeBarangB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.KodeBarangB.Location = New System.Drawing.Point(1049, 414)
        Me.KodeBarangB.Name = "KodeBarangB"
        Me.KodeBarangB.Size = New System.Drawing.Size(162, 38)
        Me.KodeBarangB.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(855, 421)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 31)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(871, 528)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 31)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Jumlah Beli"
        '
        'JumlahBeliB
        '
        Me.JumlahBeliB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.JumlahBeliB.Location = New System.Drawing.Point(1036, 525)
        Me.JumlahBeliB.Name = "JumlahBeliB"
        Me.JumlahBeliB.Size = New System.Drawing.Size(109, 38)
        Me.JumlahBeliB.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(855, 472)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 31)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Harga Barang"
        '
        'HargaBarangB
        '
        Me.HargaBarangB.Enabled = False
        Me.HargaBarangB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.HargaBarangB.Location = New System.Drawing.Point(1049, 465)
        Me.HargaBarangB.Name = "HargaBarangB"
        Me.HargaBarangB.Size = New System.Drawing.Size(162, 38)
        Me.HargaBarangB.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(1422, 528)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 31)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Total Harga"
        '
        'TotalHargaB
        '
        Me.TotalHargaB.Enabled = False
        Me.TotalHargaB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TotalHargaB.Location = New System.Drawing.Point(1602, 525)
        Me.TotalHargaB.Name = "TotalHargaB"
        Me.TotalHargaB.Size = New System.Drawing.Size(250, 38)
        Me.TotalHargaB.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(1227, 468)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 31)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Stok"
        '
        'StokB
        '
        Me.StokB.Enabled = False
        Me.StokB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.StokB.Location = New System.Drawing.Point(1331, 465)
        Me.StokB.Name = "StokB"
        Me.StokB.Size = New System.Drawing.Size(162, 38)
        Me.StokB.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label6.Location = New System.Drawing.Point(1151, 528)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 31)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Diskon"
        '
        'DiskonB
        '
        Me.DiskonB.Enabled = False
        Me.DiskonB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DiskonB.Location = New System.Drawing.Point(1255, 525)
        Me.DiskonB.Name = "DiskonB"
        Me.DiskonB.Size = New System.Drawing.Size(162, 38)
        Me.DiskonB.TabIndex = 20
        '
        'TambahBeli
        '
        Me.TambahBeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TambahBeli.Location = New System.Drawing.Point(861, 569)
        Me.TambahBeli.Name = "TambahBeli"
        Me.TambahBeli.Size = New System.Drawing.Size(1003, 47)
        Me.TambahBeli.TabIndex = 22
        Me.TambahBeli.Text = "Tambah Barang"
        Me.TambahBeli.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(236, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 31)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "LIST BARANG"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(861, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(301, 91)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "TOTAL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label9.Location = New System.Drawing.Point(3, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 31)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Kode Barang"
        '
        'KodeBarangS
        '
        Me.KodeBarangS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.KodeBarangS.Location = New System.Drawing.Point(197, 251)
        Me.KodeBarangS.Name = "KodeBarangS"
        Me.KodeBarangS.Size = New System.Drawing.Size(162, 38)
        Me.KodeBarangS.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label10.Location = New System.Drawing.Point(3, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(180, 31)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Nama Barang"
        '
        'NamaBarangS
        '
        Me.NamaBarangS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.NamaBarangS.Location = New System.Drawing.Point(197, 297)
        Me.NamaBarangS.Name = "NamaBarangS"
        Me.NamaBarangS.Size = New System.Drawing.Size(312, 38)
        Me.NamaBarangS.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label11.Location = New System.Drawing.Point(3, 357)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 31)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Harga Beli"
        '
        'HargaBeliS
        '
        Me.HargaBeliS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.HargaBeliS.Location = New System.Drawing.Point(197, 350)
        Me.HargaBeliS.Name = "HargaBeliS"
        Me.HargaBeliS.Size = New System.Drawing.Size(244, 38)
        Me.HargaBeliS.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label12.Location = New System.Drawing.Point(3, 414)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 31)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Harga Jual"
        '
        'HargaJualS
        '
        Me.HargaJualS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.HargaJualS.Location = New System.Drawing.Point(197, 407)
        Me.HargaJualS.Name = "HargaJualS"
        Me.HargaJualS.Size = New System.Drawing.Size(244, 38)
        Me.HargaJualS.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label13.Location = New System.Drawing.Point(3, 465)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 31)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Stok"
        '
        'StokS
        '
        Me.StokS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.StokS.Location = New System.Drawing.Point(197, 458)
        Me.StokS.Name = "StokS"
        Me.StokS.Size = New System.Drawing.Size(244, 38)
        Me.StokS.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label14.Location = New System.Drawing.Point(3, 519)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(164, 25)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Diskon(Opsional)"
        '
        'DiskonS
        '
        Me.DiskonS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DiskonS.Location = New System.Drawing.Point(197, 512)
        Me.DiskonS.Name = "DiskonS"
        Me.DiskonS.Size = New System.Drawing.Size(244, 38)
        Me.DiskonS.TabIndex = 35
        Me.DiskonS.Text = "0"
        '
        'TambahS
        '
        Me.TambahS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TambahS.Location = New System.Drawing.Point(5, 623)
        Me.TambahS.Name = "TambahS"
        Me.TambahS.Size = New System.Drawing.Size(776, 39)
        Me.TambahS.TabIndex = 37
        Me.TambahS.Text = "Tambah Stok Barang"
        Me.TambahS.UseVisualStyleBackColor = True
        '
        'Riwayat
        '
        Me.Riwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Riwayat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateTime, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn5})
        Me.Riwayat.Location = New System.Drawing.Point(861, 747)
        Me.Riwayat.Name = "Riwayat"
        Me.Riwayat.Size = New System.Drawing.Size(1042, 247)
        Me.Riwayat.TabIndex = 38
        '
        'DateTime
        '
        Me.DateTime.HeaderText = "DateTime"
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Width = 116
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Barang"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 283
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Harga"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Diskon"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 124
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total Harga"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 160
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1276, 713)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(255, 31)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Riwayat Transaksi"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label17.Location = New System.Drawing.Point(535, 763)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(180, 31)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Untung / Rugi"
        '
        'UntungRugi
        '
        Me.UntungRugi.Enabled = False
        Me.UntungRugi.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.UntungRugi.Location = New System.Drawing.Point(489, 806)
        Me.UntungRugi.Name = "UntungRugi"
        Me.UntungRugi.Size = New System.Drawing.Size(292, 53)
        Me.UntungRugi.TabIndex = 42
        Me.UntungRugi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label18.Location = New System.Drawing.Point(3, 576)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(187, 24)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Estimasi Keuntungan"
        '
        'UntungS
        '
        Me.UntungS.Enabled = False
        Me.UntungS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.UntungS.Location = New System.Drawing.Point(197, 569)
        Me.UntungS.Name = "UntungS"
        Me.UntungS.Size = New System.Drawing.Size(244, 38)
        Me.UntungS.TabIndex = 44
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label19.Location = New System.Drawing.Point(1232, 421)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(180, 31)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "Nama Barang"
        '
        'NamaBarangB
        '
        Me.NamaBarangB.Enabled = False
        Me.NamaBarangB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.NamaBarangB.Location = New System.Drawing.Point(1418, 418)
        Me.NamaBarangB.Name = "NamaBarangB"
        Me.NamaBarangB.Size = New System.Drawing.Size(439, 38)
        Me.NamaBarangB.TabIndex = 46
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label20.Location = New System.Drawing.Point(6, 763)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(270, 31)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Estimasi Keuntungan"
        '
        'EstUntung
        '
        Me.EstUntung.Enabled = False
        Me.EstUntung.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.EstUntung.Location = New System.Drawing.Point(12, 806)
        Me.EstUntung.Name = "EstUntung"
        Me.EstUntung.Size = New System.Drawing.Size(250, 53)
        Me.EstUntung.TabIndex = 48
        Me.EstUntung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.label.Location = New System.Drawing.Point(856, 642)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(187, 31)
        Me.label.TabIndex = 51
        Me.label.Text = "Uang Diterima"
        '
        'UangDiterima
        '
        Me.UangDiterima.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.UangDiterima.Location = New System.Drawing.Point(1049, 639)
        Me.UangDiterima.Name = "UangDiterima"
        Me.UangDiterima.Size = New System.Drawing.Size(250, 38)
        Me.UangDiterima.TabIndex = 50
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label21.Location = New System.Drawing.Point(1320, 642)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(141, 31)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "Kembalian"
        '
        'Kembalian
        '
        Me.Kembalian.Enabled = False
        Me.Kembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Kembalian.Location = New System.Drawing.Point(1467, 639)
        Me.Kembalian.Name = "Kembalian"
        Me.Kembalian.Size = New System.Drawing.Size(250, 38)
        Me.Kembalian.TabIndex = 52
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1733, 630)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 47)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 992)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Kembalian)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.UangDiterima)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.EstUntung)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.NamaBarangB)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.UntungS)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.UntungRugi)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Riwayat)
        Me.Controls.Add(Me.TambahS)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DiskonS)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.StokS)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.HargaJualS)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.HargaBeliS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NamaBarangS)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.KodeBarangS)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TambahBeli)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DiskonB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StokB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TotalHargaB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HargaBarangB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.JumlahBeliB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KodeBarangB)
        Me.Controls.Add(Me.TabelBeli)
        Me.Controls.Add(Me.TotalAll)
        Me.Controls.Add(Me.TambahExcel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelBeli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Riwayat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TambahExcel As Button
    Friend WithEvents TotalAll As TextBox
    Friend WithEvents TabelBeli As DataGridView
    Friend WithEvents KodeBarangB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents JumlahBeliB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents HargaBarangB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TotalHargaB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents StokB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DiskonB As TextBox
    Friend WithEvents TambahBeli As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents KodeBarangS As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents NamaBarangS As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents HargaBeliS As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents HargaJualS As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents StokS As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DiskonS As TextBox
    Friend WithEvents TambahS As Button
    Friend WithEvents Riwayat As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents UntungRugi As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents UntungS As TextBox
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents HargaModal As DataGridViewTextBoxColumn
    Friend WithEvents HargaJual As DataGridViewTextBoxColumn
    Friend WithEvents Stok As DataGridViewTextBoxColumn
    Friend WithEvents DiskonBarang As DataGridViewTextBoxColumn
    Friend WithEvents EstimasiUntung As DataGridViewTextBoxColumn
    Friend WithEvents Label19 As Label
    Friend WithEvents NamaBarangB As TextBox
    Friend WithEvents KodeBeli As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Diskon As DataGridViewTextBoxColumn
    Friend WithEvents TotalHargaBeli As DataGridViewTextBoxColumn
    Friend WithEvents DateTime As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Label20 As Label
    Friend WithEvents EstUntung As TextBox
    Friend WithEvents label As Label
    Friend WithEvents UangDiterima As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Kembalian As TextBox
    Friend WithEvents Button1 As Button
End Class
