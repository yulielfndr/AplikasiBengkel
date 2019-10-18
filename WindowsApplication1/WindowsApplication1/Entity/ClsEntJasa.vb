Public Class ClsEntJasa
    Private kode As String
    Private nama As String
    Private harga As Integer
    Public Property kodeJasa() As String
        Get
            Return kode
        End Get
        Set(value As String)
            kode = value
        End Set
    End Property
    Public Property namaJasa() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property hargaJasa() As String
        Get
            Return harga
        End Get
        Set(value As String)
            harga = value
        End Set
    End Property
End Class
