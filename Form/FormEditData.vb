Imports System.Data.Odbc
Public Class FormEditData

    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUpdate.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        'btnCancel.Enabled = st

        GroupBox1.Enabled = st
    End Sub

    Private Sub AturTextbox(st As Boolean)

        txt_nama_pengirim.Enabled = Not st
        txt_alamat_pengirim.Enabled = Not st
        txt_no_hp_pengirim.Enabled = Not st
        txt_nama_penerima.Enabled = Not st
        txt_alamat_penerima.Enabled = Not st
        txt_no_hp_penerima.Enabled = Not st
        txt_status.Enabled = Not st
        cmb_nama_agen.Enabled = Not st
        txt_id_agen.Enabled = Not st
        txt_berat.Enabled = Not st
        txt_isi.Enabled = Not st


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

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGEditData.Rows(br)
                txt_id_paket.Text = .Cells(0).Value.ToString
                txt_nama_pengirim.Text = .Cells(1).Value.ToString
                txt_alamat_pengirim.Text = .Cells(2).Value.ToString
                txt_no_hp_pengirim.Text = .Cells(3).Value.ToString
                txt_nama_penerima.Text = .Cells(4).Value.ToString
                txt_alamat_penerima.Text = .Cells(5).Value.ToString
                txt_no_hp_penerima.Text = .Cells(6).Value.ToString
                cmb_nama_agen.Text = .Cells(7).Value.ToString
                txt_id_agen.Text = .Cells(8).Value.ToString
                txt_berat.Text = .Cells(9).Value.ToString
                txt_isi.Text = .Cells(10).Value.ToString
                txt_status.Text = .Cells(11).Value.ToString
            End With
        End If

    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolEditData.tampilData.ToTable
        DGEditData.DataSource = DTGrid
        DGEditData.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkSeaGreen
        DGEditData.RowHeadersVisible = False

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGEditData.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGEditData.CurrentCell = DGEditData.Item(1, baris)
            AturTextbox(True)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolEditData.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGEditData.DataSource = DTGrid
            DGEditData.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGEditData.CurrentCell = DGEditData.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Sub Buattabel()
        'DGEditData.Columns.Add("ID Paket", 70, HorizontalAlignment.Center)
        'DGEditData.Columns.Add("Nama Pengirim", 150)
    End Sub

    Private Sub EditData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Buattabel()
        RefreshGrid()
        txt_id_paket.Enabled = False
        TampilAgen()
        MdiParent = FormUtama
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturTextbox(False)
        AturButton(False)
        txt_id_paket.Enabled = True
        modeProses = 1

        txt_id_paket.Focus()
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then

                Control.Text = String.Empty

            ElseIf TypeOf Control Is ComboBox Then

                Control.Text = String.Empty

            End If
        Next
        txt_id_paket.Text = "EK"
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        AturTextbox(False)
        AturButton(False)
        txt_nama_pengirim.Focus()
        modeProses = 2
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasEditData
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

        If modeProses = 1 Then
            KontrolEditData.insertData(EntitasEditData)
        ElseIf modeProses = 2 Then
            KontrolEditData.updateData(EntitasEditData)
        End If


        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
        txt_id_paket.Enabled = False
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        'Dim status_referensi As Boolean
        'status_referensi = KontrolEditData.CekEditDataDireferensi(txt_id_paket.Text)
        'If status_referensi Then
        'MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
        'Exit Sub
        'End If

        If MsgBox("Apakah anda yakin akan menghapus " & txt_id_paket.Text & "-" & txt_nama_pengirim.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolEditData.deleteData(txt_id_paket.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        RefreshGrid()
        AturButton(True)
        txt_id_paket.Enabled = False
        modeProses = 0
    End Sub



    Private Sub btnCari_Click(sender As Object, e As EventArgs)
        If txt_cari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txt_cari.Text)
            txt_cari.Focus()
        End If
    End Sub


    Private Sub DGEditData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGEditData.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGEditData.Rows(baris).Selected = True
            IsiBox(baris)
        End If
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

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        CMD = New OdbcCommand("select * from detail_paket where id_paket Like '%" & txt_cari.Text & "%'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            DTA = New OdbcDataAdapter("select * from detail_paket where id_paket Like '%" & txt_cari.Text & "%'", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "KetemuData")
            DGEditData.DataSource = DTS.Tables("KetemuData")
            DGEditData.ReadOnly = True
        Else
            MsgBox("Tidak Terdaftar")
        End If
    End Sub
End Class