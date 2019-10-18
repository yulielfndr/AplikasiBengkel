Imports System.Data.OleDb
Imports WindowsApplication1

Public Class ClsCtlJasa : Implements InfProses

    Public Function cariData(key As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from Jasa where namajasa " _
                                       & "like '%" & key & "%'", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Jasa")
            Dim grid As New DataView(DTS.Tables("Cari_Jasa"))
            Return grid
        Catch ex As Exception
            Throw New NotImplementedException()
        End Try
    End Function

    Public Function DeleteData(key As Object) As OleDbCommand Implements InfProses.DeleteData
        CMD = New OleDbCommand("delete from jasa " _
            & "where kodejasa='" & key & "'", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntJasa
        data = Ob
        CMD = New OleDbCommand("insert into jasa values('" & data.kodeJasa & "','" _
                               & data.namaJasa & "'," & data.hargaJasa & ")", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from jasa", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_jasa")
            Dim grid As New DataView(DTS.Tables("Tabel_jasa"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InfProses.UpdateData
        Dim data As New ClsEntJasa
        data = Ob
        CMD = New OleDbCommand("update jasa set namaJasa='" _
                               & data.namaJasa & "',harga=" & data.hargaJasa _
                               & "where kodejasa='" & data.kodeJasa & "'", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function
    Function kodeBaru() As String
        Dim baru As String
        Dim akhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kodejasa,4)) from jasa", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            akhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "S" & Strings.Right("000" & akhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function cekJasa(key As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(kodejasa) from notajasa " _
                                       & "where kodejasa='" & key & "'", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
            Return cek
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
