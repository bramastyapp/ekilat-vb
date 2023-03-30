Imports System.Data.Odbc

Public Class ClsCtlEditData : Implements InfProses

    Public Function insertData(Ob As Object) As OdbcCommand Implements InfProses.insertData
        Dim data As New ClsEntEditData
        data = Ob
        CMD = New OdbcCommand("insert into detail_paket (`nama_pengirim`, `alamat_pengirim`, `no_hp_pengirim`, `nama_penerima`, `alamat_penerima`, `no_hp_penerima`, `id_agen`, `id_paket`, `berat`, `isi`, `status`) values ('" & data.Nama_pengirim & "', '" & data.Alamat_pengirim & "', '" & data.No_hp_pengirim & "', '" & data.Nama_penerima & "', '" & data.Alamat_penerima & "', '" & data.No_hp_penerima & "', " & data.Id_agen & ", '" & data.Id_paket & "', '" & data.Berat & "', '" & data.Isi & "', '" & data.Status & "');", BUKAKONEKSI)

        'CMD1 = New OdbcCommand("insert into paket () values ('" & data.Id_paket & "', '" & data.Berat & "', '" & data.Isi & "', '" & data.Status & "');", BUKAKONEKSI)

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
        Dim data As New ClsEntEditData
        data = Ob
        CMD = New OdbcCommand("update detail_paket set nama_pengirim = '" & data.Nama_pengirim & "', alamat_pengirim = '" & data.Alamat_pengirim & "', no_hp_pengirim = '" & data.No_hp_pengirim & "', nama_penerima = '" & data.Nama_penerima & "', alamat_penerima = '" & data.Alamat_penerima & "', no_hp_penerima = '" & data.No_hp_penerima & "', id_agen = " & data.Id_agen & ", berat =  '" & data.Berat & "', isi = '" & data.Isi & "', status = '" & data.Status & "' where id_paket = '" & data.Id_paket & "'", BUKAKONEKSI)

        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD

    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProses.deleteData
        CMD = New OdbcCommand("delete from detail_paket " & "where id_paket= '" & kunci & "'", BUKAKONEKSI)

        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD

    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("SELECT d.id_paket, d.nama_pengirim, d.alamat_pengirim, d.no_hp_pengirim,
            d.nama_penerima, d.alamat_penerima, d.no_hp_penerima, a.nama_agen, a.id_agen, d.berat, d.isi, d.status
            FROM detail_paket d JOIN agen a ON a.id_agen=d.id_agen ", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "update_data")
            Dim grid As New DataView(DTS.Tables("update_data"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function CekEditDataDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OdbcDataAdapter("select count(id_paket) from detail_paket " & "where id_paket = '" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
End Class
