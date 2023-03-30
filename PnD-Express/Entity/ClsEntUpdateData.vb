Public Class ClsEntUpdateData
    Private _id_paket As String
    Private _nama_agen As String
    Private _status As String
    Private _id_agen As Integer

    Public Property Id_paket As String
        Get
            Return _id_paket
        End Get
        Set(value As String)
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
