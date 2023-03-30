Public Class FormLogin

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        DTGrid = KontrolLogin.Login(txt_id_karyawan.Text).ToTable
        If txt_id_karyawan.Text = "" And txt_password.Text = "" Then
            MsgBox("Silahkan isikan id karyawan dan password anda")
        ElseIf txt_id_karyawan.Text = "" Then
            MsgBox("Silahkan isikan id_karyawan anda")
        ElseIf txt_password.Text = "" Then
            MsgBox("Silahkan isikan password anda")
        Else
            If DTGrid.Rows.Count > 0 Then
                EntitasLogin.Id_karyawan = DTGrid.Rows(0).Item(0)
                EntitasLogin.Password = DTGrid.Rows(0).ItemArray(5)

                KODELOG = EntitasLogin.Id_karyawan

                If txt_password.Text = EntitasLogin.Password Then
                    FormUtama.Show()
                    FormDashboard.Show()
                    txt_id_karyawan.Text = ""
                    txt_password.Text = ""
                    Me.Hide()
                Else
                    MessageBox.Show("ID tidak dikenali", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txt_password.Text = ""
                    txt_id_karyawan.Focus()
                End If
            Else
                MessageBox.Show("ID tidak dikenali", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_password.Text = ""
                txt_id_karyawan.Text = ""
                txt_id_karyawan.Focus()
            End If
        End If
    End Sub

    Private Sub daftar_Click(sender As Object, e As EventArgs) Handles daftar.Click
        FormPendaftaran.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        FormKaryawan.Show()
    End Sub
End Class