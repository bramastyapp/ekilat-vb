Imports System.Data.Odbc

Public Class ClsCtlPengiriman : Implements InfProses

    Public Function insertData(Ob As Object) As OdbcCommand Implements InfProses.insertData
        Dim data As New ClsEntPengiriman
        data = Ob
        CMD = New OdbcCommand("insert into detail_paket (`nama_pengirim`, `alamat_pengirim`, `no_hp_pengirim`, `nama_penerima`, `alamat_penerima`, `no_hp_penerima`, `id_agen`, `id_paket`, `berat`, `isi`, `status`) values ('" & data.Nama_pengirim & "', '" & data.Alamat_pengirim & "', '" & data.No_hp_pengirim & "', '" & data.Nama_penerima & "', '" & data.Alamat_penerima & "', '" & data.No_hp_penerima & "', " & data.Id_agen & ", '" & data.Id_paket & "', '" & data.Berat & "', '" & data.Isi & "', '" & data.Status & "');", BUKAKONEKSI)
        'CMD1 = New OdbcCommand("insert into paket (`id_paket`, `berat`, `isi`, `status`) values ('" & data.Id_paket & "', '" & data.Berat & "', '" & data.Isi & "', '" & data.Status & "');", BUKAKONEKSI)

        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD

        'CMD1.CommandType = CommandType.Text
        'CMD1.ExecuteNonQuery()
        'CMD1 = New OdbcCommand("", TUTUPKONEKSI)
        'Return CMD1
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
