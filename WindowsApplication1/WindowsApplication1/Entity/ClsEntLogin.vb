Public Class ClsEntLogin
    Private username As String
    Private password As String

    Public Property idKaryawan() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property Pswrd() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property
End Class
