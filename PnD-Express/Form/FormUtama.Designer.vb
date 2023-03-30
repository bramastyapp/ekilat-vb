<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.dashboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.pengiriman = New System.Windows.Forms.ToolStripMenuItem()
        Me.cek_data = New System.Windows.Forms.ToolStripMenuItem()
        Me.update_data_resi = New System.Windows.Forms.ToolStripMenuItem()
        Me.edit_data = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dashboard, Me.pengiriman, Me.cek_data, Me.update_data_resi, Me.edit_data})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.dashboard
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(849, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'dashboard
        '
        Me.dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dashboard.Name = "dashboard"
        Me.dashboard.Size = New System.Drawing.Size(76, 20)
        Me.dashboard.Text = "Dashboard"
        '
        'pengiriman
        '
        Me.pengiriman.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pengiriman.Name = "pengiriman"
        Me.pengiriman.Size = New System.Drawing.Size(80, 20)
        Me.pengiriman.Text = "Pengiriman"
        '
        'cek_data
        '
        Me.cek_data.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cek_data.Name = "cek_data"
        Me.cek_data.Size = New System.Drawing.Size(66, 20)
        Me.cek_data.Text = "Cek Data"
        '
        'update_data_resi
        '
        Me.update_data_resi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.update_data_resi.Name = "update_data_resi"
        Me.update_data_resi.Size = New System.Drawing.Size(108, 20)
        Me.update_data_resi.Text = "Update Data Resi"
        '
        'edit_data
        '
        Me.edit_data.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.edit_data.Name = "edit_data"
        Me.edit_data.Size = New System.Drawing.Size(66, 20)
        Me.edit_data.Text = "Edit Data"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 583)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FormUtama"
        Me.Text = "FormUtama"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents dashboard As ToolStripMenuItem
    Friend WithEvents pengiriman As ToolStripMenuItem
    Friend WithEvents cek_data As ToolStripMenuItem
    Friend WithEvents update_data_resi As ToolStripMenuItem
    Friend WithEvents edit_data As ToolStripMenuItem
End Class
