<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboard))
        Me.BLogoMain = New System.Windows.Forms.Button()
        Me.DGDashboard = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BCekData = New System.Windows.Forms.Button()
        CType(Me.DGDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BLogoMain
        '
        Me.BLogoMain.Image = CType(resources.GetObject("BLogoMain.Image"), System.Drawing.Image)
        Me.BLogoMain.Location = New System.Drawing.Point(2, 13)
        Me.BLogoMain.Margin = New System.Windows.Forms.Padding(2)
        Me.BLogoMain.Name = "BLogoMain"
        Me.BLogoMain.Size = New System.Drawing.Size(109, 31)
        Me.BLogoMain.TabIndex = 0
        Me.BLogoMain.UseVisualStyleBackColor = True
        '
        'DGDashboard
        '
        Me.DGDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDashboard.Location = New System.Drawing.Point(8, 88)
        Me.DGDashboard.Margin = New System.Windows.Forms.Padding(2)
        Me.DGDashboard.Name = "DGDashboard"
        Me.DGDashboard.RowHeadersWidth = 62
        Me.DGDashboard.RowTemplate.Height = 28
        Me.DGDashboard.Size = New System.Drawing.Size(669, 294)
        Me.DGDashboard.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.Controls.Add(Me.BCekData)
        Me.Panel1.Controls.Add(Me.BLogoMain)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 65)
        Me.Panel1.TabIndex = 6
        '
        'BCekData
        '
        Me.BCekData.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BCekData.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCekData.ForeColor = System.Drawing.SystemColors.Control
        Me.BCekData.Location = New System.Drawing.Point(130, 13)
        Me.BCekData.Margin = New System.Windows.Forms.Padding(2)
        Me.BCekData.Name = "BCekData"
        Me.BCekData.Size = New System.Drawing.Size(504, 31)
        Me.BCekData.TabIndex = 18
        Me.BCekData.Text = "Dashboard"
        Me.BCekData.UseVisualStyleBackColor = False
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 390)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGDashboard)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.DGDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BLogoMain As Button
    Friend WithEvents DGDashboard As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BCekData As Button
End Class
