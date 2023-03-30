Imports System.Data.Odbc

Public Class FormPengiriman
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub AturButton(st As Boolean)
        btn_kirim.Enabled = Not st
    End Sub

    Private Sub Pengiriman_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TampilAgen()
        MdiParent = FormUtama
    End Sub

    Private Sub btn_kirim_Click(sender As Object, e As EventArgs) Handles btn_kirim.Click
        With EntitasPengiriman
            .Nama_pengirim = txt_nama_pengirim.Text
            .Alamat_pengirim = txt_alamat_pengirim.Text
            .No_hp_pengirim = txt_no_hp_pengirim.Text
            .Nama_penerima = txt_nama_penerima.Text
            .Alamat_penerima = txt_alamat_penerima.Text
            .No_hp_penerima = txt_no_hp_penerima.Text
            .Id_agen = txt_id_agen.Text
            .Berat = txt_berat.Text
            .Isi = txt_isi.Text
            .Id_paket = txt_id_paket.Text
            .Status = txt_status.Text
        End With

        KontrolPengiriman.insertData(EntitasPengiriman)

            MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")

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

    Private Sub btn_kosong_Click(sender As Object, e As EventArgs) Handles btn_kosong.Click
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then

                Control.Text = String.Empty

            ElseIf TypeOf Control Is ComboBox Then

                Control.Text = String.Empty

            End If
        Next
    End Sub
End Class