Imports System.Data.Odbc
Public Class FormUpdateData

    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub AturButton(st As Boolean)
        btn_update.Enabled = st
        GroupBox1.Enabled = st
    End Sub


    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGUpdateData.Rows(br)
                txt_id_paket.Text = .Cells(0).Value.ToString
                cmb_nama_agen.Text = .Cells(2).Value.ToString
                txt_id_agen.Text = .Cells(1).Value.ToString
                txt_status.Text = .Cells(5).Value.ToString
            End With
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolUpdateData.tampilData.ToTable
        DGUpdateData.DataSource = DTGrid
        DGUpdateData.Columns(0).Width = 150
        DGUpdateData.Columns(1).Width = 70
        DGUpdateData.Columns(2).Width = 150
        DGUpdateData.Columns(3).Width = 100
        DGUpdateData.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkSeaGreen
        DGUpdateData.RowHeadersVisible = False

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGUpdateData.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGUpdateData.CurrentCell = DGUpdateData.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub AturTextBox(st As Boolean)
        txt_status.Enabled = Not st
        txt_id_agen.Enabled = Not st
        cmb_nama_agen.Enabled = Not st
    End Sub

    Private Sub UpdateData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilAgen()
        RefreshGrid()
        AturTextBox(True)
        txt_id_paket.Enabled = False
        MdiParent = FormUtama
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolUpdateData.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGUpdateData.DataSource = DTGrid
            DGUpdateData.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGUpdateData.CurrentCell = DGUpdateData.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        AturButton(False)
        modeProses = 2
        txt_status.Enabled = True
        txt_id_agen.Enabled = True
        cmb_nama_agen.Enabled = True
        txt_id_agen.Focus()
        txt_status.Focus()
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs)
        If txt_cari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txt_cari.Text)
            txt_cari.Focus()
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        With EntitasUpdateData
            .Id_paket = txt_id_paket.Text
            .Id_agen = txt_id_agen.Text
            .Status = txt_status.Text
        End With

        If modeProses = 1 Then
            KontrolUpdateData.insertData(EntitasUpdateData)
        ElseIf modeProses = 2 Then
            KontrolUpdateData.updateData(EntitasUpdateData)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()

    End Sub

    Private Sub DGUpdateData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUpdateData.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGUpdateData.Rows(baris).Selected = True
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

    Sub TampilAgen()
        CMD = New OdbcCommand("Select * from agen", BUKAKONEKSI)
        cmb_nama_agen.Items.Clear()
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            cmb_nama_agen.Items.Add(DTR.Item(1))
        Loop
        BUKAKONEKSI.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        RefreshGrid()
        AturTextBox(True)
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        CMD = New OdbcCommand("select * from detail_paket where id_paket Like '%" & txt_cari.Text & "%'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            DTA = New OdbcDataAdapter("select * from detail_paket where id_paket Like '%" & txt_cari.Text & "%'", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "KetemuData")
            DGUpdateData.DataSource = DTS.Tables("KetemuData")
            DGUpdateData.ReadOnly = True
        Else
            MsgBox("Tidak Terdaftar")
        End If
    End Sub
End Class