Public Class ClsEntDashboard
    Private _id_paket As Integer
    Private _nama_agen As String
    Private _alamat_agen As String
    Private _no_hp As String

    Public Property Id_paket As Integer
        Get
            Return _id_paket
        End Get
        Set(value As Integer)
            _id_paket = value
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

    Public Property Alamat_agen As String
        Get
            Return _alamat_agen
        End Get
        Set(value As String)
            _alamat_agen = value
        End Set
    End Property

    Public Property No_hp As String
        Get
            Return _no_hp
        End Get
        Set(value As String)
            _no_hp = value
        End Set
    End Property
End Class
