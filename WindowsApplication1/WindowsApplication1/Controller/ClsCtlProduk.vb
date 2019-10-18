Imports System.Data.OleDb
Imports WindowsApplication1

Public Class ClsCtlProduk : Implements InfProses

    Public Function cariData(key As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from Produk where namaproduk " _
                                       & "like '%" & key & "%'", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Produk")
            Dim grid As New DataView(DTS.Tables("Cari_Produk"))
            Return grid
        Catch ex As Exception
            Throw New NotImplementedException()
        End Try
    End Function

    Public Function DeleteData(key As Object) As OleDbCommand Implements InfProses.DeleteData
        CMD = New OleDbCommand("delete from produk " _
                               & "where kodeproduk='" & key & "'", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntProduk
        data = Ob
        CMD = New OleDbCommand("insert into produk values('" & data.kodeProduk & "','" _
                               & data.namaProduk & "'," & data.hargaProduk & "," _
                               & data.stokProduk & ")", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from Produk", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Produk")
            Dim grid As New DataView(DTS.Tables("Tabel_Produk"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InfProses.UpdateData
        Dim data As New ClsEntProduk
        data = Ob
        CMD = New OleDbCommand("update produk set namaproduk='" _
                               & data.namaProduk & "',harga=" & data.hargaProduk _
                               & ",stok=" & data.stokProduk _
                               & "where kodeproduk='" & data.kodeProduk & "'", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function
    Function kodeBaru() As String
        Dim baru As String
        Dim akhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kodeproduk,4)) from produk", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            akhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "P" & Strings.Right("000" & akhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function cekProduk(key As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(kodeproduk) from notaproduk " _
                                       & "where kodeproduk='" & key & "'", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
            Return cek
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
