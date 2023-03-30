Imports System.Data.Odbc

Public Class ClsCtlDashboard : Implements InfProses

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
            DTA = New OdbcDataAdapter("select * from agen", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "tabel_agen")
            Dim grid As New DataView(DTS.Tables("tabel_agen"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
End Class
