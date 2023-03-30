Imports System.Data.Odbc

Public Class ClsCtlUpdateData : Implements InfProses

    Public Function insertData(Ob As Object) As OdbcCommand Implements InfProses.insertData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Dim data As New ClsEntUpdateData
        data = Ob
        CMD = New OdbcCommand("update detail_paket set id_agen = '" & data.Id_agen &
                              "', status = '" & data.Status & "' where id_paket = '" & data.Id_paket & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("SELECT id_paket, d.id_agen, a.nama_agen, d.alamat_penerima, d.nama_penerima, d.status
            FROM detail_paket d JOIN agen a ON a.id_agen=d.id_agen ", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "update_data")
            Dim grid As New DataView(DTS.Tables("update_data"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OdbcDataAdapter("SELECT d.id_paket, a.nama_agen, d.status
            FROM detail_paket d JOIN agen a ON a.id_agen=d.id_agen where d.id_paket " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cari_paket")
            Dim grid As New DataView(DTS.Tables("cari_paket"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
