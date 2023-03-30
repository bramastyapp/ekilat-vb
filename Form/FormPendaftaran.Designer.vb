<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPendaftaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPendaftaran))
        Me.btnDaftar = New System.Windows.Forms.Button()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_nama_karyawan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogoLogin = New System.Windows.Forms.Button()
        Me.txt_id_agen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_no_hp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_nama_agen = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnDaftar
        '
        Me.btnDaftar.AllowDrop = True
        Me.btnDaftar.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnDaftar.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaftar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDaftar.Location = New System.Drawing.Point(24, 331)
        Me.btnDaftar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDaftar.Name = "btnDaftar"
        Me.btnDaftar.Size = New System.Drawing.Size(300, 38)
        Me.btnDaftar.TabIndex = 13
        Me.btnDaftar.Text = "Daftar"
        Me.btnDaftar.UseVisualStyleBackColor = False
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(117, 295)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(207, 20)
        Me.txt_pass.TabIndex = 12
        '
        'txt_nama_karyawan
        '
        Me.txt_nama_karyawan.Location = New System.Drawing.Point(117, 163)
        Me.txt_nama_karyawan.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nama_karyawan.Name = "txt_nama_karyawan"
        Me.txt_nama_karyawan.Size = New System.Drawing.Size(207, 20)
        Me.txt_nama_karyawan.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 298)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 164)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama Lengkap"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 120)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "PENDAFTARAN"
        '
        'LogoLogin
        '
        Me.LogoLogin.Image = CType(resources.GetObject("LogoLogin.Image"), System.Drawing.Image)
        Me.LogoLogin.Location = New System.Drawing.Point(11, 11)
        Me.LogoLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.LogoLogin.Name = "LogoLogin"
        Me.LogoLogin.Size = New System.Drawing.Size(341, 98)
        Me.LogoLogin.TabIndex = 7
        Me.LogoLogin.UseVisualStyleBackColor = True
        '
        'txt_id_agen
        '
        Me.txt_id_agen.Location = New System.Drawing.Point(283, 192)
        Me.txt_id_agen.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id_agen.Name = "txt_id_agen"
        Me.txt_id_agen.Size = New System.Drawing.Size(41, 20)
        Me.txt_id_agen.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 194)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Domisili Agen"
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(117, 225)
        Me.txt_alamat.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(207, 20)
        Me.txt_alamat.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 226)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Alamat"
        '
        'txt_no_hp
        '
        Me.txt_no_hp.Location = New System.Drawing.Point(117, 260)
        Me.txt_no_hp.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_no_hp.Name = "txt_no_hp"
        Me.txt_no_hp.Size = New System.Drawing.Size(207, 20)
        Me.txt_no_hp.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 261)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "No Hp"
        '
        'cmb_nama_agen
        '
        Me.cmb_nama_agen.FormattingEnabled = True
        Me.cmb_nama_agen.Location = New System.Drawing.Point(117, 191)
        Me.cmb_nama_agen.Name = "cmb_nama_agen"
        Me.cmb_nama_agen.Size = New System.Drawing.Size(161, 21)
        Me.cmb_nama_agen.TabIndex = 20
        '
        'FormPendaftaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 450)
        Me.Controls.Add(Me.cmb_nama_agen)
        Me.Controls.Add(Me.txt_no_hp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_id_agen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDaftar)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_nama_karyawan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogoLogin)
        Me.Name = "FormPendaftaran"
        Me.Text = "FormPendaftaran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDaftar As Button
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_nama_karyawan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LogoLogin As Button
    Friend WithEvents txt_id_agen As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_no_hp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_nama_agen As ComboBox
End Class
