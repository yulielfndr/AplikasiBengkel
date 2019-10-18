Public Class ClsEntTransaksi
    Private kode As String
    Private namap As String
    Private namaj As String
    Private harga As Integer
    Private jumlah As Integer
    Private subtotal As Integer
    Private idtr As String

    Public Property Kodetr As String
        Get
            Return kode
        End Get
        Set(value As String)
            kode = value
        End Set
    End Property

    Public Property NamaPr As String
        Get
            Return namap
        End Get
        Set(value As String)
            namap = value
        End Set
    End Property

    Public Property Hargatr As Integer
        Get
            Return harga
        End Get
        Set(value As Integer)
            harga = value
        End Set
    End Property

    Public Property Jumlahtr As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
        End Set
    End Property

    Public Property Subtotaltr As Integer
        Get
            Return subtotal
        End Get
        Set(value As Integer)
            subtotal = value
        End Set
    End Property

    Public Property Idtransaksi As String
        Get
            Return idtr
        End Get
        Set(value As String)
            idtr = value
        End Set
    End Property

    Public Property NamaJs As String
        Get
            Return namaj
        End Get
        Set(value As String)
            namaj = value
        End Set
    End Property
End Class
