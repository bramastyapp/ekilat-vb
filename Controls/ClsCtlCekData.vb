Imports System.Data.Odbc

Public Class ClsCtlCekData : Implements InfProses

    Public Function insertData(Ob As Object) As OdbcCommand Implements InfProses.insertData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("SELECT d.id_paket, d.nama_penerima, d.alamat_penerima, a.nama_agen, d.status
            FROM detail_paket d JOIN agen a ON a.id_agen=d.id_agen ", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "cek_data")
            Dim grid As New DataView(DTS.Tables("cek_data"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
End Class
