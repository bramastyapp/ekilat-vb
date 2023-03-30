Public Class ClsEntPendaftaran
    Private _id_karyawan As Integer
    Private _id_agen As Integer
    Private _nama_karyawan As String
    Private _alamat_karyawan As String
    Private _no_hp_karyawan As String
    Private _password As String

    Public Property Id_karyawan As Integer
        Get
            Return _id_karyawan
        End Get
        Set(value As Integer)
            _id_karyawan = value
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

    Public Property Nama_karyawan As String
        Get
            Return _nama_karyawan
        End Get
        Set(value As String)
            _nama_karyawan = value
        End Set
    End Property

    Public Property Alamat_karyawan As String
        Get
            Return _alamat_karyawan
        End Get
        Set(value As String)
            _alamat_karyawan = value
        End Set
    End Property

    Public Property No_hp_karyawan As String
        Get
            Return _no_hp_karyawan
        End Get
        Set(value As String)
            _no_hp_karyawan = value
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
