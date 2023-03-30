<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengiriman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPengiriman))
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.txt_alamat_penerima = New System.Windows.Forms.TextBox()
        Me.txt_no_hp_penerima = New System.Windows.Forms.TextBox()
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
        Me.btn_kirim = New System.Windows.Forms.Button()
        Me.txt_id_agen = New System.Windows.Forms.TextBox()
        Me.btn_kosong = New System.Windows.Forms.Button()
        Me.BCekData = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.Controls.Add(Me.BCekData)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 65)
        Me.Panel1.TabIndex = 93
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
        Me.txt_id_paket.Location = New System.Drawing.Point(454, 259)
        Me.txt_id_paket.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id_paket.Name = "txt_id_paket"
        Me.txt_id_paket.Size = New System.Drawing.Size(140, 20)
        Me.txt_id_paket.TabIndex = 92
        '
        'txt_isi
        '
        Me.txt_isi.Location = New System.Drawing.Point(454, 226)
        Me.txt_isi.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_isi.Name = "txt_isi"
        Me.txt_isi.Size = New System.Drawing.Size(140, 20)
        Me.txt_isi.TabIndex = 91
        '
        'txt_berat
        '
        Me.txt_berat.Location = New System.Drawing.Point(454, 192)
        Me.txt_berat.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_berat.Name = "txt_berat"
        Me.txt_berat.Size = New System.Drawing.Size(140, 20)
        Me.txt_berat.TabIndex = 90
        '
        'cmb_nama_agen
        '
        Me.cmb_nama_agen.FormattingEnabled = True
        Me.cmb_nama_agen.Location = New System.Drawing.Point(454, 149)
        Me.cmb_nama_agen.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_nama_agen.Name = "cmb_nama_agen"
        Me.cmb_nama_agen.Size = New System.Drawing.Size(109, 21)
        Me.cmb_nama_agen.TabIndex = 89
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(454, 114)
        Me.txt_status.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(140, 20)
        Me.txt_status.TabIndex = 88
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(348, 257)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 19)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "ID Paket"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(348, 224)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 19)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Isi Barang"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(348, 190)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 19)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Berat Barang"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(348, 150)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 19)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Lokasi Agen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(348, 113)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 19)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Status"
        '
        'txt_alamat_penerima
        '
        Me.txt_alamat_penerima.Location = New System.Drawing.Point(165, 242)
        Me.txt_alamat_penerima.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_alamat_penerima.Name = "txt_alamat_penerima"
        Me.txt_alamat_penerima.Size = New System.Drawing.Size(146, 20)
        Me.txt_alamat_penerima.TabIndex = 81
        '
        'txt_no_hp_penerima
        '
        Me.txt_no_hp_penerima.Location = New System.Drawing.Point(165, 279)
        Me.txt_no_hp_penerima.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_no_hp_penerima.Name = "txt_no_hp_penerima"
        Me.txt_no_hp_penerima.Size = New System.Drawing.Size(146, 20)
        Me.txt_no_hp_penerima.TabIndex = 82
        '
        'txt_nama_penerima
        '
        Me.txt_nama_penerima.Location = New System.Drawing.Point(165, 211)
        Me.txt_nama_penerima.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nama_penerima.Name = "txt_nama_penerima"
        Me.txt_nama_penerima.Size = New System.Drawing.Size(146, 20)
        Me.txt_nama_penerima.TabIndex = 80
        '
        'txt_no_hp_pengirim
        '
        Me.txt_no_hp_pengirim.Location = New System.Drawing.Point(165, 179)
        Me.txt_no_hp_pengirim.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_no_hp_pengirim.Name = "txt_no_hp_pengirim"
        Me.txt_no_hp_pengirim.Size = New System.Drawing.Size(146, 20)
        Me.txt_no_hp_pengirim.TabIndex = 79
        '
        'txt_alamat_pengirim
        '
        Me.txt_alamat_pengirim.Location = New System.Drawing.Point(165, 150)
        Me.txt_alamat_pengirim.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_alamat_pengirim.Name = "txt_alamat_pengirim"
        Me.txt_alamat_pengirim.Size = New System.Drawing.Size(146, 20)
        Me.txt_alamat_pengirim.TabIndex = 78
        '
        'txt_nama_pengirim
        '
        Me.txt_nama_pengirim.Location = New System.Drawing.Point(165, 113)
        Me.txt_nama_pengirim.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nama_pengirim.Name = "txt_nama_pengirim"
        Me.txt_nama_pengirim.Size = New System.Drawing.Size(146, 20)
        Me.txt_nama_pengirim.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 277)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 19)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "No HP Penerima"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 240)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 19)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Alamat Penerima"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 210)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 19)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Nama Penerima"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 178)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 19)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "No HP Pengirim"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 148)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 19)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Alamat Pengirim"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 113)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Nama Pengirim"
        '
        'btn_kirim
        '
        Me.btn_kirim.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_kirim.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kirim.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_kirim.Location = New System.Drawing.Point(38, 335)
        Me.btn_kirim.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kirim.Name = "btn_kirim"
        Me.btn_kirim.Size = New System.Drawing.Size(557, 31)
        Me.btn_kirim.TabIndex = 98
        Me.btn_kirim.Text = "KIRIM"
        Me.btn_kirim.UseVisualStyleBackColor = False
        '
        'txt_id_agen
        '
        Me.txt_id_agen.Location = New System.Drawing.Point(567, 150)
        Me.txt_id_agen.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id_agen.Name = "txt_id_agen"
        Me.txt_id_agen.Size = New System.Drawing.Size(27, 20)
        Me.txt_id_agen.TabIndex = 99
        '
        'btn_kosong
        '
        Me.btn_kosong.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_kosong.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kosong.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_kosong.Location = New System.Drawing.Point(38, 370)
        Me.btn_kosong.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kosong.Name = "btn_kosong"
        Me.btn_kosong.Size = New System.Drawing.Size(557, 31)
        Me.btn_kosong.TabIndex = 100
        Me.btn_kosong.Text = "KOSONGKAN"
        Me.btn_kosong.UseVisualStyleBackColor = False
        '
        'BCekData
        '
        Me.BCekData.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BCekData.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCekData.ForeColor = System.Drawing.SystemColors.Control
        Me.BCekData.Location = New System.Drawing.Point(123, 13)
        Me.BCekData.Margin = New System.Windows.Forms.Padding(2)
        Me.BCekData.Name = "BCekData"
        Me.BCekData.Size = New System.Drawing.Size(504, 31)
        Me.BCekData.TabIndex = 18
        Me.BCekData.Text = "Pengiriman"
        Me.BCekData.UseVisualStyleBackColor = False
        '
        'FormPengiriman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 450)
        Me.Controls.Add(Me.btn_kosong)
        Me.Controls.Add(Me.txt_id_agen)
        Me.Controls.Add(Me.btn_kirim)
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
        Me.Controls.Add(Me.txt_alamat_penerima)
        Me.Controls.Add(Me.txt_no_hp_penerima)
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
        Me.Name = "FormPengiriman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengiriman"
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents txt_alamat_penerima As TextBox
    Friend WithEvents txt_no_hp_penerima As TextBox
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
    Friend WithEvents btn_kirim As Button
    Friend WithEvents txt_id_agen As TextBox
    Friend WithEvents btn_kosong As Button
    Friend WithEvents BCekData As Button
End Class
