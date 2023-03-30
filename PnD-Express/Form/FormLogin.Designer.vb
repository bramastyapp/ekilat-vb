<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.LogoLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id_karyawan = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.daftar = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LogoLogin
        '
        Me.LogoLogin.Image = CType(resources.GetObject("LogoLogin.Image"), System.Drawing.Image)
        Me.LogoLogin.Location = New System.Drawing.Point(11, 4)
        Me.LogoLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.LogoLogin.Name = "LogoLogin"
        Me.LogoLogin.Size = New System.Drawing.Size(341, 98)
        Me.LogoLogin.TabIndex = 0
        Me.LogoLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Silahkan Masuk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 190)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'txt_id_karyawan
        '
        Me.txt_id_karyawan.Location = New System.Drawing.Point(123, 148)
        Me.txt_id_karyawan.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id_karyawan.Name = "txt_id_karyawan"
        Me.txt_id_karyawan.Size = New System.Drawing.Size(207, 20)
        Me.txt_id_karyawan.TabIndex = 4
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(123, 187)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(207, 20)
        Me.txt_password.TabIndex = 5
        '
        'btnMasuk
        '
        Me.btnMasuk.AllowDrop = True
        Me.btnMasuk.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnMasuk.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasuk.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMasuk.Location = New System.Drawing.Point(30, 226)
        Me.btnMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(300, 38)
        Me.btnMasuk.TabIndex = 6
        Me.btnMasuk.Text = "Masuk"
        Me.btnMasuk.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tidak punya akun?"
        '
        'daftar
        '
        Me.daftar.AutoSize = True
        Me.daftar.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.daftar.Location = New System.Drawing.Point(208, 269)
        Me.daftar.Name = "daftar"
        Me.daftar.Size = New System.Drawing.Size(42, 13)
        Me.daftar.TabIndex = 8
        Me.daftar.Text = "Daftar !"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Lupa ID karyawan?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label6.Location = New System.Drawing.Point(183, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Lihat ID Karyawan"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 337)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.daftar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnMasuk)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_id_karyawan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogoLogin)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_id_karyawan As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btnMasuk As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents daftar As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
