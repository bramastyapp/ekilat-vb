Imports System.Data.Odbc
Public Class ClsCtlPendaftaran : Implements InfProses

    Public Function insertData(Ob As Object) As OdbcCommand Implements InfProses.insertData
        Dim data As New ClsEntPendaftaran
        data = Ob
        CMD = New OdbcCommand("insert into karyawan (`id_agen`, `nama_karyawan`, `alamat_karyawan`, `no_hp_karyawan`, `password`, `username`, `level`) values (" & data.Id_agen & ", '" & data.Nama_karyawan & "', '" & data.Alamat_karyawan & "', '" & data.No_hp_karyawan & "', '" & data.Password & "', '" & data.Username & "', 'AG');", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Throw New NotImplementedException()
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
End Class
