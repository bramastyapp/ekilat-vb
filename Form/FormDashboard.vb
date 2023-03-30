Public Class FormDashboard
    Private Sub RefreshGrid()
        DTGrid = KontrolDashboard.tampilData.ToTable
        DGDashboard.DataSource = DTGrid
        DGDashboard.Columns(0).Width = 70
        DGDashboard.Columns(1).Width = 160
        DGDashboard.Columns(2).Width = 340
        DGDashboard.Columns(3).Width = 100
        DGDashboard.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkSeaGreen
        DGDashboard.RowHeadersVisible = False

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        MdiParent = FormUtama
    End Sub
End Class