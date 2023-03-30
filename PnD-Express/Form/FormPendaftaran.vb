Imports System.Data.Odbc
Public Class FormPendaftaran
    Private Sub FormPendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilAgen()
    End Sub

    Sub TampilAgen()
        CMD = New OdbcCommand("Select * from agen", BUKAKONEKSI)
        cmb_nama_agen.Items.Clear()
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            cmb_nama_agen.Items.Add(DTR.Item(1))
        Loop
        BUKAKONEKSI.Close()
    End Sub

    Private Sub cmb_nama_agen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_nama_agen.SelectedIndexChanged
        CMD = New OdbcCommand("select * from agen where nama_agen = '" & cmb_nama_agen.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txt_id_agen.Text = DTR.Item("id_agen")
        Else
            MsgBox("Tidak Terdaftar")
        End If
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        With EntitasPendaftaran
            .Nama_karyawan = txt_nama_karyawan.Text
            .Id_agen = txt_id_agen.Text
            .Alamat_karyawan = txt_alamat.Text
            .No_hp_karyawan = txt_no_hp.Text
            .Password = txt_pass.Text
            .Username = txt_username.Text
        End With

        KontrolPendaftaran.insertData(EntitasPendaftaran)

        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
    End Sub
End Class