Public Class ClsEntAkun
    Private _KodeAkun As String
    Private _namaAkun As String
    Private _jnsSaldo As String
    Private _saldo As Double

    Public Property KodeAkun As String
        Get
            Return _KodeAkun
        End Get
        Set(value As String)
            _KodeAkun = value
        End Set
    End Property

    Public Property NamaAkun As String
        Get
            Return _namaAkun
        End Get
        Set(value As String)
            _namaAkun = value
        End Set
    End Property

    Public Property JnsSaldo As String
        Get
            Return _jnsSaldo
        End Get
        Set(value As String)
            _jnsSaldo = value
        End Set
    End Property

    Public Property Saldo As Double
        Get
            Return _saldo
        End Get
        Set(value As Double)
            _saldo = value
        End Set
    End Property
End Class
