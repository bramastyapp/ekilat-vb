Imports System.Data.Odbc
Public Class ClsCtlLogin
    Public Function Login(username As String) As DataView
        Try

            DTA = New OdbcDataAdapter("select * from karyawan where id_karyawan= '" & username & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cari_karyawan")
            Dim grid As New DataView(DTS.Tables("cari_karyawan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

End Class
