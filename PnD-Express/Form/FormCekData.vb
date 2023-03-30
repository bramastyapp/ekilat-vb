Imports System.Data.Odbc

Public Class FormCekData
    Private Sub RefreshGrid()
        DTGrid = KontrolCekData.tampilData.ToTable
        DGCekData.DataSource = DTGrid
        DGCekData.Columns(0).Width = 150
        DGCekData.Columns(1).Width = 150
        DGCekData.Columns(2).Width = 160
        DGCekData.Columns(3).Width = 160
        DGCekData.Columns(4).Width = 160
        DGCekData.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkSeaGreen
        DGCekData.RowHeadersVisible = False

    End Sub
    Private Sub CekData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        MdiParent = FormUtama
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        CMD = New OdbcCommand("select * from detail_paket where id_paket Like '%" & TextBox3.Text & "%'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            DTA = New OdbcDataAdapter("select * from detail_paket where id_paket Like '%" & TextBox3.Text & "%'", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "KetemuData")
            DGCekData.DataSource = DTS.Tables("KetemuData")
            DGCekData.ReadOnly = True
        Else
            MsgBox("Tidak Terdaftar")
        End If
    End Sub
End Class