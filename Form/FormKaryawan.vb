Public Class FormKaryawan

    Private Sub RefreshGrid()
        DTGrid = KontrolKaryawan.tampilData.ToTable
        DGKaryawan.DataSource = DTGrid
        DGKaryawan.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkSeaGreen
        DGKaryawan.RowHeadersVisible = False

    End Sub

    Private Sub FormKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub
End Class