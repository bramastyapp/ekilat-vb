Public Class FormUtama
    Private Sub dashboard_Click(sender As Object, e As EventArgs) Handles dashboard.Click
        FormDashboard.Show()

    End Sub

    Private Sub pengiriman_Click(sender As Object, e As EventArgs) Handles pengiriman.Click
        FormPengiriman.Show()
    End Sub

    Private Sub cek_data_Click(sender As Object, e As EventArgs) Handles cek_data.Click
        FormCekData.Show()
    End Sub

    Private Sub update_data_resi_Click(sender As Object, e As EventArgs) Handles update_data_resi.Click
        FormUpdateData.Show()
    End Sub

    Private Sub edit_data_Click(sender As Object, e As EventArgs) Handles edit_data.Click
        FormEditData.Show()
    End Sub
End Class