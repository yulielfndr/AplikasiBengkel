Public Class ClsEntKasKeluar
    Private _kode As String
    Private _nama As String
    Private _tanggal As String
    Private _jumlah As String

    Public Property Kode As String
        Get
            Return _kode
        End Get
        Set(value As String)
            _kode = value
        End Set
    End Property

    Public Property Nama As String
        Get
            Return _nama
        End Get
        Set(value As String)
            _nama = value
        End Set
    End Property

    Public Property Tanggal As String
        Get
            Return _tanggal
        End Get
        Set(value As String)
            _tanggal = value
        End Set
    End Property

    Public Property Jumlah As String
        Get
            Return _jumlah
        End Get
        Set(value As String)
            _jumlah = value
        End Set
    End Property
End Class
