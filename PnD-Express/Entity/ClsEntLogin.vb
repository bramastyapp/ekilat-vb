Public Class ClsEntLogin
    Private _id_karyawan As Integer
    Private _password As String
    Private _username As String
    Private _level As String

    Public Property Id_karyawan As Integer
        Get
            Return _id_karyawan
        End Get
        Set(value As Integer)
            _id_karyawan = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Level As String
        Get
            Return _level
        End Get
        Set(value As String)
            _level = value
        End Set
    End Property
End Class
