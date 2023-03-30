Public Class ClsEntEditData
    Private _nama_pengirim As String
    Private _alamat_pengirim As String
    Private _no_hp_pengirim As String
    Private _nama_penerima As String
    Private _alamat_penerima As String
    Private _no_hp_penerima As String
    Private _nama_agen As String
    Private _id_agen As Integer
    Private _berat As String
    Private _isi As String
    Private _id_paket As String
    Private _status As String

    Public Property Nama_pengirim As String
        Get
            Return _nama_pengirim
        End Get
        Set(value As String)
            _nama_pengirim = value
        End Set
    End Property

    Public Property Alamat_pengirim As String
        Get
            Return _alamat_pengirim
        End Get
        Set(value As String)
            _alamat_pengirim = value
        End Set
    End Property

    Public Property No_hp_pengirim As String
        Get
            Return _no_hp_pengirim
        End Get
        Set(value As String)
            _no_hp_pengirim = value
        End Set
    End Property

    Public Property Nama_penerima As String
        Get
            Return _nama_penerima
        End Get
        Set(value As String)
            _nama_penerima = value
        End Set
    End Property

    Public Property Alamat_penerima As String
        Get
            Return _alamat_penerima
        End Get
        Set(value As String)
            _alamat_penerima = value
        End Set
    End Property

    Public Property No_hp_penerima As String
        Get
            Return _no_hp_penerima
        End Get
        Set(value As String)
            _no_hp_penerima = value
        End Set
    End Property

    Public Property Nama_agen As String
        Get
            Return _nama_agen
        End Get
        Set(value As String)
            _nama_agen = value
        End Set
    End Property

    Public Property Berat As String
        Get
            Return _berat
        End Get
        Set(value As String)
            _berat = value
        End Set
    End Property

    Public Property Isi As String
        Get
            Return _isi
        End Get
        Set(value As String)
            _isi = value
        End Set
    End Property

    Public Property Id_paket As String
        Get
            Return _id_paket
        End Get
        Set(value As String)
            _id_paket = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Public Property Id_agen As Integer
        Get
            Return _id_agen
        End Get
        Set(value As Integer)
            _id_agen = value
        End Set
    End Property
End Class
