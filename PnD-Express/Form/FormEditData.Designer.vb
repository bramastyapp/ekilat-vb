<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditData))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BCekData = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_id_paket = New System.Windows.Forms.TextBox()
        Me.txt_isi = New System.Windows.Forms.TextBox()
        Me.txt_berat = New System.Windows.Forms.TextBox()
        Me.cmb_nama_agen = New System.Windows.Forms.ComboBox()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_no_hp_penerima = New System.Windows.Forms.TextBox()
        Me.txt_alamat_penerima = New System.Windows.Forms.TextBox()
        Me.txt_nama_penerima = New System.Windows.Forms.TextBox()
        Me.txt_no_hp_pengirim = New System.Windows.Forms.TextBox()
        Me.txt_alamat_pengirim = New System.Windows.Forms.TextBox()
        Me.txt_nama_pengirim = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.DGEditData = New System.Windows.Forms.DataGridView()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_id_agen = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DGEditData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.Controls.Add(Me.BCekData)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 65)
        Me.Panel1.TabIndex = 62
        '
        'BCekData
        '
        Me.BCekData.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BCekData.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCekData.ForeColor = System.Drawing.SystemColors.Control
        Me.BCekData.Location = New System.Drawing.Point(161, 13)
        Me.BCekData.Margin = New System.Windows.Forms.Padding(2)
        Me.BCekData.Name = "BCekData"
        Me.BCekData.Size = New System.Drawing.Size(504, 31)
        Me.BCekData.TabIndex = 18
        Me.BCekData.Text = "Edit Data"
        Me.BCekData.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(9, 13)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 31)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txt_id_paket
        '
        Me.txt_id_paket.Location = New System.Drawing.Point(172, 119)
        Me.txt_id_paket.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id_paket.Name = "txt_id_paket"
        Me.txt_id_paket.Size = New System.Drawing.Size(117, 20)
        Me.txt_id_paket.TabIndex = 60
        '
        'txt_isi
        '
        Me.txt_isi.Location = New System.Drawing.Point(455, 225)
        Me.txt_isi.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_isi.Name = "txt_isi"
        Me.txt_isi.Size = New System.Drawing.Size(117, 20)
        Me.txt_isi.TabIndex = 59
        '
        'txt_berat
        '
        Me.txt_berat.Location = New System.Drawing.Point(455, 191)
        Me.txt_berat.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_berat.Name = "txt_berat"
        Me.txt_berat.Size = New System.Drawing.Size(117, 20)
        Me.txt_berat.TabIndex = 58
        '
        'cmb_nama_agen
        '
        Me.cmb_nama_agen.FormattingEnabled = True
        Me.cmb_nama_agen.Location = New System.Drawing.Point(455, 148)
        Me.cmb_nama_agen.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_nama_agen.Name = "cmb_nama_agen"
        Me.cmb_nama_agen.Size = New System.Drawing.Size(90, 21)
        Me.cmb_nama_agen.TabIndex = 57
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(455, 113)
        Me.txt_status.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(117, 20)
        Me.txt_status.TabIndex = 56
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(41, 120)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 19)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "ID Paket"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(349, 223)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 19)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Isi Barang"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(349, 189)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 19)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Berat Barang"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(349, 149)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 19)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Lokasi Agen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(349, 112)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 19)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Status"
        '
        'txt_no_hp_penerima
        '
        Me.txt_no_hp_penerima.Location = New System.Drawing.Point(172, 318)
        Me.txt_no_hp_penerima.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_no_hp_penerima.Name = "txt_no_hp_penerima"
        Me.txt_no_hp_penerima.Size = New System.Drawing.Size(117, 20)
        Me.txt_no_hp_penerima.TabIndex = 50
        '
        'txt_alamat_penerima
        '
        Me.txt_alamat_penerima.Location = New System.Drawing.Point(172, 281)
        Me.txt_alamat_penerima.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_alamat_penerima.Name = "txt_alamat_penerima"
        Me.txt_alamat_penerima.Size = New System.Drawing.Size(117, 20)
        Me.txt_alamat_penerima.TabIndex = 49
        '
        'txt_nama_penerima
        '
        Me.txt_nama_penerima.Location = New System.Drawing.Point(172, 250)
        Me.txt_nama_penerima.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nama_penerima.Name = "txt_nama_penerima"
        Me.txt_nama_penerima.Size = New System.Drawing.Size(117, 20)
        Me.txt_nama_penerima.TabIndex = 48
        '
        'txt_no_hp_pengirim
        '
        Me.txt_no_hp_pengirim.Location = New System.Drawing.Point(172, 218)
        Me.txt_no_hp_pengirim.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_no_hp_pengirim.Name = "txt_no_hp_pengirim"
        Me.txt_no_hp_pengirim.Size = New System.Drawing.Size(117, 20)
        Me.txt_no_hp_pengirim.TabIndex = 47
        '
        'txt_alamat_pengirim
        '
        Me.txt_alamat_pengirim.Location = New System.Drawing.Point(172, 189)
        Me.txt_alamat_pengirim.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_alamat_pengirim.Name = "txt_alamat_pengirim"
        Me.txt_alamat_pengirim.Size = New System.Drawing.Size(117, 20)
        Me.txt_alamat_pengirim.TabIndex = 46
        '
        'txt_nama_pengirim
        '
        Me.txt_nama_pengirim.Location = New System.Drawing.Point(172, 152)
        Me.txt_nama_pengirim.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nama_pengirim.Name = "txt_nama_pengirim"
        Me.txt_nama_pengirim.Size = New System.Drawing.Size(117, 20)
        Me.txt_nama_pengirim.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 316)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 19)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "No HP Penerima"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 279)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 19)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Alamat Penerima"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 249)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 19)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Nama Penerima"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 217)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 19)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "No HP Pengirim"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 187)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 19)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Alamat Pengirim"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 152)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Nama Pengirim"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Edit Data"
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnTambah.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTambah.Location = New System.Drawing.Point(587, 108)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(112, 31)
        Me.btnTambah.TabIndex = 22
        Me.btnTambah.Text = "Tambah Data"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnUpdate.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.Location = New System.Drawing.Point(587, 143)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(112, 31)
        Me.btnUpdate.TabIndex = 63
        Me.btnUpdate.Text = "Update Data"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSimpan.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSimpan.Location = New System.Drawing.Point(587, 178)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(112, 31)
        Me.btnSimpan.TabIndex = 64
        Me.btnSimpan.Text = "Simpan Data"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnHapus.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHapus.Location = New System.Drawing.Point(587, 214)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(112, 31)
        Me.btnHapus.TabIndex = 65
        Me.btnHapus.Text = "Hapus Data"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Location = New System.Drawing.Point(587, 249)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 31)
        Me.btnCancel.TabIndex = 66
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'DGEditData
        '
        Me.DGEditData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGEditData.Location = New System.Drawing.Point(12, 352)
        Me.DGEditData.Name = "DGEditData"
        Me.DGEditData.Size = New System.Drawing.Size(687, 179)
        Me.DGEditData.TabIndex = 67
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(5, 18)
        Me.txt_cari.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(305, 20)
        Me.txt_cari.TabIndex = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_cari)
        Me.GroupBox1.Location = New System.Drawing.Point(384, 300)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 47)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari berdasarkan ID Paket"
        '
        'txt_id_agen
        '
        Me.txt_id_agen.Location = New System.Drawing.Point(549, 148)
        Me.txt_id_agen.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id_agen.Name = "txt_id_agen"
        Me.txt_id_agen.Size = New System.Drawing.Size(23, 20)
        Me.txt_id_agen.TabIndex = 68
        '
        'FormEditData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 543)
        Me.Controls.Add(Me.txt_id_agen)
        Me.Controls.Add(Me.DGEditData)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_id_paket)
        Me.Controls.Add(Me.txt_isi)
        Me.Controls.Add(Me.txt_berat)
        Me.Controls.Add(Me.cmb_nama_agen)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_no_hp_penerima)
        Me.Controls.Add(Me.txt_alamat_penerima)
        Me.Controls.Add(Me.txt_nama_penerima)
        Me.Controls.Add(Me.txt_no_hp_pengirim)
        Me.Controls.Add(Me.txt_alamat_pengirim)
        Me.Controls.Add(Me.txt_nama_pengirim)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormEditData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditData"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGEditData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents txt_id_paket As TextBox
    Friend WithEvents txt_isi As TextBox
    Friend WithEvents txt_berat As TextBox
    Friend WithEvents cmb_nama_agen As ComboBox
    Friend WithEvents txt_status As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_no_hp_penerima As TextBox
    Friend WithEvents txt_alamat_penerima As TextBox
    Friend WithEvents txt_nama_penerima As TextBox
    Friend WithEvents txt_no_hp_pengirim As TextBox
    Friend WithEvents txt_alamat_pengirim As TextBox
    Friend WithEvents txt_nama_pengirim As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents DGEditData As DataGridView
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_id_agen As TextBox
    Friend WithEvents BCekData As Button
End Class
