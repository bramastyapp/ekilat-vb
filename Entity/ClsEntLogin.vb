Public Class ClsEntLogin
    Private _id_karyawan As Integer
    Private _password As String

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
End Class
