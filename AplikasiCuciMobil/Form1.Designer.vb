<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.jenis4 = New System.Windows.Forms.RadioButton()
        Me.jenis3 = New System.Windows.Forms.RadioButton()
        Me.jenis2 = New System.Windows.Forms.RadioButton()
        Me.motor1 = New System.Windows.Forms.RadioButton()
        Me.motor2 = New System.Windows.Forms.RadioButton()
        Me.jenis1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtjumlah1 = New System.Windows.Forms.TextBox()
        Me.txtjumlah4 = New System.Windows.Forms.TextBox()
        Me.txtjumlah3 = New System.Windows.Forms.TextBox()
        Me.txtjumlah2 = New System.Windows.Forms.TextBox()
        Me.txtmakan4 = New System.Windows.Forms.TextBox()
        Me.txtmakan3 = New System.Windows.Forms.TextBox()
        Me.txtmakan1 = New System.Windows.Forms.TextBox()
        Me.txtmakan2 = New System.Windows.Forms.TextBox()
        Me.makan4 = New System.Windows.Forms.CheckBox()
        Me.makan3 = New System.Windows.Forms.CheckBox()
        Me.makan2 = New System.Windows.Forms.CheckBox()
        Me.makan1 = New System.Windows.Forms.CheckBox()
        Me.txtkembali = New System.Windows.Forms.TextBox()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.TxtByCuci = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txttambah4 = New System.Windows.Forms.TextBox()
        Me.txttambah3 = New System.Windows.Forms.TextBox()
        Me.txttambah1 = New System.Windows.Forms.TextBox()
        Me.txttambah2 = New System.Windows.Forms.TextBox()
        Me.tambah4 = New System.Windows.Forms.CheckBox()
        Me.tambah3 = New System.Windows.Forms.CheckBox()
        Me.tambah2 = New System.Windows.Forms.CheckBox()
        Me.tambah1 = New System.Windows.Forms.CheckBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.jenis4)
        Me.GroupBox1.Controls.Add(Me.jenis3)
        Me.GroupBox1.Controls.Add(Me.jenis2)
        Me.GroupBox1.Controls.Add(Me.motor1)
        Me.GroupBox1.Controls.Add(Me.motor2)
        Me.GroupBox1.Controls.Add(Me.jenis1)
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(390, 224)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "<< JENIS KENDARAAN >>"
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'jenis4
        '
        Me.jenis4.AutoSize = True
        Me.jenis4.BackColor = System.Drawing.Color.Transparent
        Me.jenis4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jenis4.Location = New System.Drawing.Point(2, 183)
        Me.jenis4.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.jenis4.Name = "jenis4"
        Me.jenis4.Size = New System.Drawing.Size(243, 24)
        Me.jenis4.TabIndex = 0
        Me.jenis4.TabStop = True
        Me.jenis4.Text = "Tidak Cuci Mobil dan Motor"
        Me.jenis4.UseVisualStyleBackColor = False
        '
        'jenis3
        '
        Me.jenis3.AutoSize = True
        Me.jenis3.BackColor = System.Drawing.Color.Transparent
        Me.jenis3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jenis3.Location = New System.Drawing.Point(2, 148)
        Me.jenis3.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.jenis3.Name = "jenis3"
        Me.jenis3.Size = New System.Drawing.Size(136, 24)
        Me.jenis3.TabIndex = 0
        Me.jenis3.TabStop = True
        Me.jenis3.Text = "Bus / MiniBus"
        Me.jenis3.UseVisualStyleBackColor = False
        '
        'jenis2
        '
        Me.jenis2.AutoSize = True
        Me.jenis2.BackColor = System.Drawing.Color.Silver
        Me.jenis2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jenis2.Location = New System.Drawing.Point(2, 118)
        Me.jenis2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.jenis2.Name = "jenis2"
        Me.jenis2.Size = New System.Drawing.Size(265, 24)
        Me.jenis2.TabIndex = 0
        Me.jenis2.TabStop = True
        Me.jenis2.Text = "Mobil Alphard, dan sejenisnya"
        Me.jenis2.UseVisualStyleBackColor = False
        '
        'motor1
        '
        Me.motor1.AutoSize = True
        Me.motor1.BackColor = System.Drawing.Color.Silver
        Me.motor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motor1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.motor1.Location = New System.Drawing.Point(5, 24)
        Me.motor1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.motor1.Name = "motor1"
        Me.motor1.Size = New System.Drawing.Size(121, 24)
        Me.motor1.TabIndex = 0
        Me.motor1.TabStop = True
        Me.motor1.Text = "Motor Matic"
        Me.motor1.UseVisualStyleBackColor = False
        '
        'motor2
        '
        Me.motor2.AutoSize = True
        Me.motor2.BackColor = System.Drawing.Color.Silver
        Me.motor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motor2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.motor2.Location = New System.Drawing.Point(5, 55)
        Me.motor2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.motor2.Name = "motor2"
        Me.motor2.Size = New System.Drawing.Size(122, 24)
        Me.motor2.TabIndex = 0
        Me.motor2.TabStop = True
        Me.motor2.Text = "Motor Sport"
        Me.motor2.UseVisualStyleBackColor = False
        '
        'jenis1
        '
        Me.jenis1.AutoSize = True
        Me.jenis1.BackColor = System.Drawing.Color.Silver
        Me.jenis1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jenis1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.jenis1.Location = New System.Drawing.Point(5, 87)
        Me.jenis1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.jenis1.Name = "jenis1"
        Me.jenis1.Size = New System.Drawing.Size(318, 24)
        Me.jenis1.TabIndex = 0
        Me.jenis1.TabStop = True
        Me.jenis1.Text = "Mobil Avanza, Xenia, dan sejenisnya"
        Me.jenis1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "APLIKASI CUCI MOTOR DAN MOBIL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "BIAYA CUCI"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtjumlah1)
        Me.GroupBox3.Controls.Add(Me.txtjumlah4)
        Me.GroupBox3.Controls.Add(Me.txtjumlah3)
        Me.GroupBox3.Controls.Add(Me.txtjumlah2)
        Me.GroupBox3.Controls.Add(Me.txtmakan4)
        Me.GroupBox3.Controls.Add(Me.txtmakan3)
        Me.GroupBox3.Controls.Add(Me.txtmakan1)
        Me.GroupBox3.Controls.Add(Me.txtmakan2)
        Me.GroupBox3.Controls.Add(Me.makan4)
        Me.GroupBox3.Controls.Add(Me.makan3)
        Me.GroupBox3.Controls.Add(Me.makan2)
        Me.GroupBox3.Controls.Add(Me.makan1)
        Me.GroupBox3.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(436, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(399, 204)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "<< JAJAN dan MINUMAN >>"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Jumlah"
        '
        'txtjumlah1
        '
        Me.txtjumlah1.Location = New System.Drawing.Point(322, 27)
        Me.txtjumlah1.Name = "txtjumlah1"
        Me.txtjumlah1.Size = New System.Drawing.Size(52, 25)
        Me.txtjumlah1.TabIndex = 1
        Me.txtjumlah1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtjumlah4
        '
        Me.txtjumlah4.Location = New System.Drawing.Point(322, 135)
        Me.txtjumlah4.Name = "txtjumlah4"
        Me.txtjumlah4.Size = New System.Drawing.Size(52, 25)
        Me.txtjumlah4.TabIndex = 1
        Me.txtjumlah4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtjumlah3
        '
        Me.txtjumlah3.Location = New System.Drawing.Point(322, 99)
        Me.txtjumlah3.Name = "txtjumlah3"
        Me.txtjumlah3.Size = New System.Drawing.Size(52, 25)
        Me.txtjumlah3.TabIndex = 1
        Me.txtjumlah3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtjumlah2
        '
        Me.txtjumlah2.Location = New System.Drawing.Point(322, 65)
        Me.txtjumlah2.Name = "txtjumlah2"
        Me.txtjumlah2.Size = New System.Drawing.Size(52, 25)
        Me.txtjumlah2.TabIndex = 1
        Me.txtjumlah2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtmakan4
        '
        Me.txtmakan4.Location = New System.Drawing.Point(214, 135)
        Me.txtmakan4.Name = "txtmakan4"
        Me.txtmakan4.Size = New System.Drawing.Size(102, 25)
        Me.txtmakan4.TabIndex = 1
        '
        'txtmakan3
        '
        Me.txtmakan3.Location = New System.Drawing.Point(214, 99)
        Me.txtmakan3.Name = "txtmakan3"
        Me.txtmakan3.Size = New System.Drawing.Size(102, 25)
        Me.txtmakan3.TabIndex = 1
        '
        'txtmakan1
        '
        Me.txtmakan1.Location = New System.Drawing.Point(214, 27)
        Me.txtmakan1.Name = "txtmakan1"
        Me.txtmakan1.Size = New System.Drawing.Size(102, 25)
        Me.txtmakan1.TabIndex = 1
        '
        'txtmakan2
        '
        Me.txtmakan2.Location = New System.Drawing.Point(214, 63)
        Me.txtmakan2.Name = "txtmakan2"
        Me.txtmakan2.Size = New System.Drawing.Size(102, 25)
        Me.txtmakan2.TabIndex = 1
        '
        'makan4
        '
        Me.makan4.AutoSize = True
        Me.makan4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.makan4.Location = New System.Drawing.Point(5, 137)
        Me.makan4.Name = "makan4"
        Me.makan4.Size = New System.Drawing.Size(153, 24)
        Me.makan4.TabIndex = 0
        Me.makan4.Text = "Coca-cola / Sprite"
        Me.makan4.UseVisualStyleBackColor = True
        '
        'makan3
        '
        Me.makan3.AutoSize = True
        Me.makan3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.makan3.Location = New System.Drawing.Point(5, 100)
        Me.makan3.Name = "makan3"
        Me.makan3.Size = New System.Drawing.Size(124, 24)
        Me.makan3.TabIndex = 0
        Me.makan3.Text = "Chitato / Lays"
        Me.makan3.UseVisualStyleBackColor = True
        '
        'makan2
        '
        Me.makan2.AutoSize = True
        Me.makan2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.makan2.Location = New System.Drawing.Point(5, 63)
        Me.makan2.Name = "makan2"
        Me.makan2.Size = New System.Drawing.Size(140, 24)
        Me.makan2.TabIndex = 0
        Me.makan2.Text = "Kacang Garuda"
        Me.makan2.UseVisualStyleBackColor = True
        '
        'makan1
        '
        Me.makan1.AutoSize = True
        Me.makan1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.makan1.Location = New System.Drawing.Point(5, 29)
        Me.makan1.Name = "makan1"
        Me.makan1.Size = New System.Drawing.Size(172, 24)
        Me.makan1.TabIndex = 0
        Me.makan1.Text = "Teh Botol / Freshtea"
        Me.makan1.UseVisualStyleBackColor = True
        '
        'txtkembali
        '
        Me.txtkembali.Location = New System.Drawing.Point(589, 417)
        Me.txtkembali.Name = "txtkembali"
        Me.txtkembali.Size = New System.Drawing.Size(248, 30)
        Me.txtkembali.TabIndex = 2
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(589, 371)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(247, 30)
        Me.txtbayar.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(436, 421)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 32)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Kembali"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(436, 375)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Bayar"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.Aqua
        Me.btnreset.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(708, 465)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(127, 43)
        Me.btnreset.TabIndex = 0
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btnhitung
        '
        Me.btnhitung.BackColor = System.Drawing.Color.Aqua
        Me.btnhitung.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhitung.Location = New System.Drawing.Point(544, 267)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(153, 40)
        Me.btnhitung.TabIndex = 0
        Me.btnhitung.Text = "HITUNG"
        Me.btnhitung.UseVisualStyleBackColor = False
        '
        'TxtByCuci
        '
        Me.TxtByCuci.Location = New System.Drawing.Point(152, 290)
        Me.TxtByCuci.Name = "TxtByCuci"
        Me.TxtByCuci.Size = New System.Drawing.Size(243, 30)
        Me.TxtByCuci.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox2.Controls.Add(Me.txttambah4)
        Me.GroupBox2.Controls.Add(Me.txttambah3)
        Me.GroupBox2.Controls.Add(Me.txttambah1)
        Me.GroupBox2.Controls.Add(Me.txttambah2)
        Me.GroupBox2.Controls.Add(Me.tambah4)
        Me.GroupBox2.Controls.Add(Me.tambah3)
        Me.GroupBox2.Controls.Add(Me.tambah2)
        Me.GroupBox2.Controls.Add(Me.tambah1)
        Me.GroupBox2.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(5, 331)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 177)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "<< Biaya Tambahan  Untuk Mobil >>"
        '
        'txttambah4
        '
        Me.txttambah4.Location = New System.Drawing.Point(266, 135)
        Me.txttambah4.Name = "txttambah4"
        Me.txttambah4.Size = New System.Drawing.Size(118, 25)
        Me.txttambah4.TabIndex = 1
        '
        'txttambah3
        '
        Me.txttambah3.Location = New System.Drawing.Point(266, 99)
        Me.txttambah3.Name = "txttambah3"
        Me.txttambah3.Size = New System.Drawing.Size(118, 25)
        Me.txttambah3.TabIndex = 1
        '
        'txttambah1
        '
        Me.txttambah1.Location = New System.Drawing.Point(266, 27)
        Me.txttambah1.Name = "txttambah1"
        Me.txttambah1.Size = New System.Drawing.Size(118, 25)
        Me.txttambah1.TabIndex = 1
        '
        'txttambah2
        '
        Me.txttambah2.Location = New System.Drawing.Point(266, 63)
        Me.txttambah2.Name = "txttambah2"
        Me.txttambah2.Size = New System.Drawing.Size(118, 25)
        Me.txttambah2.TabIndex = 1
        '
        'tambah4
        '
        Me.tambah4.AutoSize = True
        Me.tambah4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambah4.Location = New System.Drawing.Point(5, 137)
        Me.tambah4.Name = "tambah4"
        Me.tambah4.Size = New System.Drawing.Size(132, 24)
        Me.tambah4.TabIndex = 0
        Me.tambah4.Text = "Vacum Interior"
        Me.tambah4.UseVisualStyleBackColor = True
        '
        'tambah3
        '
        Me.tambah3.AutoSize = True
        Me.tambah3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambah3.Location = New System.Drawing.Point(5, 100)
        Me.tambah3.Name = "tambah3"
        Me.tambah3.Size = New System.Drawing.Size(107, 24)
        Me.tambah3.TabIndex = 0
        Me.tambah3.Text = "Poles Body"
        Me.tambah3.UseVisualStyleBackColor = True
        '
        'tambah2
        '
        Me.tambah2.AutoSize = True
        Me.tambah2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambah2.Location = New System.Drawing.Point(5, 63)
        Me.tambah2.Name = "tambah2"
        Me.tambah2.Size = New System.Drawing.Size(116, 24)
        Me.tambah2.TabIndex = 0
        Me.tambah2.Text = "AC Cleaning"
        Me.tambah2.UseVisualStyleBackColor = True
        '
        'tambah1
        '
        Me.tambah1.AutoSize = True
        Me.tambah1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tambah1.Location = New System.Drawing.Point(5, 29)
        Me.tambah1.Name = "tambah1"
        Me.tambah1.Size = New System.Drawing.Size(166, 24)
        Me.tambah1.TabIndex = 0
        Me.tambah1.Text = "Cuci Mesin / Kolong"
        Me.tambah1.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(588, 323)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(246, 30)
        Me.txttotal.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(436, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total Biaya"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(864, 518)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtkembali)
        Me.Controls.Add(Me.txtbayar)
        Me.Controls.Add(Me.TxtByCuci)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnhitung)
        Me.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents jenis3 As System.Windows.Forms.RadioButton
    Friend WithEvents jenis2 As System.Windows.Forms.RadioButton
    Friend WithEvents jenis1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents makan4 As System.Windows.Forms.CheckBox
    Friend WithEvents makan2 As System.Windows.Forms.CheckBox
    Friend WithEvents makan1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtjumlah1 As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlah4 As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlah3 As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlah2 As System.Windows.Forms.TextBox
    Friend WithEvents txtmakan4 As System.Windows.Forms.TextBox
    Friend WithEvents txtmakan3 As System.Windows.Forms.TextBox
    Friend WithEvents txtmakan2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbayar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnhitung As System.Windows.Forms.Button
    Friend WithEvents txtkembali As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents motor1 As System.Windows.Forms.RadioButton
    Friend WithEvents motor2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtmakan1 As System.Windows.Forms.TextBox
    Friend WithEvents makan3 As System.Windows.Forms.CheckBox
    Friend WithEvents TxtByCuci As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txttambah4 As System.Windows.Forms.TextBox
    Friend WithEvents txttambah3 As System.Windows.Forms.TextBox
    Friend WithEvents txttambah1 As System.Windows.Forms.TextBox
    Friend WithEvents txttambah2 As System.Windows.Forms.TextBox
    Friend WithEvents tambah4 As System.Windows.Forms.CheckBox
    Friend WithEvents tambah3 As System.Windows.Forms.CheckBox
    Friend WithEvents tambah2 As System.Windows.Forms.CheckBox
    Friend WithEvents tambah1 As System.Windows.Forms.CheckBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents jenis4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
