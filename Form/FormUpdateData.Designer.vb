<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdateData))
        Me.DGUpdateData = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BCekData = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.txt_id_paket = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id_agen = New System.Windows.Forms.TextBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.cmb_nama_agen = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.DGUpdateData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGUpdateData
        '
        Me.DGUpdateData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUpdateData.Location = New System.Drawing.Point(14, 273)
        Me.DGUpdateData.Margin = New System.Windows.Forms.Padding(2)
        Me.DGUpdateData.Name = "DGUpdateData"
        Me.DGUpdateData.RowHeadersWidth = 62
        Me.DGUpdateData.RowTemplate.Height = 28
        Me.DGUpdateData.Size = New System.Drawing.Size(614, 263)
        Me.DGUpdateData.TabIndex = 47
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.Controls.Add(Me.BCekData)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 73)
        Me.Panel1.TabIndex = 48
        '
        'BCekData
        '
        Me.BCekData.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BCekData.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCekData.ForeColor = System.Drawing.SystemColors.Control
        Me.BCekData.Location = New System.Drawing.Point(125, 13)
        Me.BCekData.Margin = New System.Windows.Forms.Padding(2)
        Me.BCekData.Name = "BCekData"
        Me.BCekData.Size = New System.Drawing.Size(504, 31)
        Me.BCekData.TabIndex = 18
        Me.BCekData.Text = "Update Data Resi"
        Me.BCekData.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(9, 13)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 31)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Cek Data Paket"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_cari)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 57)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari ID Paket"
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(24, 21)
        Me.txt_cari.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(294, 20)
        Me.txt_cari.TabIndex = 39
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(159, 150)
        Me.txt_status.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(202, 20)
        Me.txt_status.TabIndex = 55
        '
        'txt_id_paket
        '
        Me.txt_id_paket.Location = New System.Drawing.Point(159, 84)
        Me.txt_id_paket.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id_paket.Name = "txt_id_paket"
        Me.txt_id_paket.Size = New System.Drawing.Size(202, 20)
        Me.txt_id_paket.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 118)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Lokasi Agen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "ID Paket"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 151)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Status"
        '
        'txt_id_agen
        '
        Me.txt_id_agen.Location = New System.Drawing.Point(320, 118)
        Me.txt_id_agen.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id_agen.Name = "txt_id_agen"
        Me.txt_id_agen.Size = New System.Drawing.Size(41, 20)
        Me.txt_id_agen.TabIndex = 54
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_update.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_update.Location = New System.Drawing.Point(399, 84)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(231, 37)
        Me.btn_update.TabIndex = 57
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_simpan.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_simpan.Location = New System.Drawing.Point(399, 133)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(231, 37)
        Me.btn_simpan.TabIndex = 58
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'cmb_nama_agen
        '
        Me.cmb_nama_agen.FormattingEnabled = True
        Me.cmb_nama_agen.Location = New System.Drawing.Point(159, 118)
        Me.cmb_nama_agen.Name = "cmb_nama_agen"
        Me.cmb_nama_agen.Size = New System.Drawing.Size(156, 21)
        Me.cmb_nama_agen.TabIndex = 59
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Location = New System.Drawing.Point(399, 183)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(231, 37)
        Me.btnCancel.TabIndex = 60
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'FormUpdateData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 547)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cmb_nama_agen)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.txt_id_agen)
        Me.Controls.Add(Me.txt_id_paket)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGUpdateData)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormUpdateData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateData"
        CType(Me.DGUpdateData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGUpdateData As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents txt_status As TextBox
    Friend WithEvents txt_id_paket As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_id_agen As TextBox
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents cmb_nama_agen As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents BCekData As Button
End Class
