Imports System.Data.Odbc
Public Class ClsCtlKaryawan : Implements InfProses

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
            DTA = New OdbcDataAdapter("SELECT k.id_karyawan, k.nama_karyawan, k.alamat_karyawan, k.no_hp_karyawan, a.nama_agen
            FROM karyawan k JOIN agen a ON a.id_agen=k.id_agen ", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "tampilKaryawan")
            Dim grid As New DataView(DTS.Tables("tampilKaryawan"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
End Class
