Public Class ClsEntCekData
    Private _id_paket As Integer
    Private _nama_penerima As String
    Private _alamat_penerima As String
    Private _nama_agen As String
    Private _status As String

    Public Property Id_paket As Integer
        Get
            Return _id_paket
        End Get
        Set(value As Integer)
            _id_paket = value
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

    Public Property Nama_agen As String
        Get
            Return _nama_agen
        End Get
        Set(value As String)
            _nama_agen = value
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
End Class
