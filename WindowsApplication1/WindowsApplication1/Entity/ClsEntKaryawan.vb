Public Class ClsEntKaryawan
    Private id As String
    Private nama As String
    Private alamat As String
    Private telp As String
    Private status As String
    Private pswrd As String
    Public Property idKaryawan() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property
    Public Property namaKaryawan() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property alamatKaryawan() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property
    Public Property noTelp() As String
        Get
            Return telp
        End Get
        Set(value As String)
            telp = value
        End Set
    End Property
    Public Property posisi() As String
        Get
            Return status
        End Get
        Set(value As String)
            status = value
        End Set
    End Property
    Public Property pssword() As String
        Get
            Return pswrd
        End Get
        Set(value As String)
            pswrd = value
        End Set
    End Property
End Class
