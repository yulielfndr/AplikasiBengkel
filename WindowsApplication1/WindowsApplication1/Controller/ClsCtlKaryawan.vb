Imports System.Data.OleDb
Imports WindowsApplication1

Public Class ClsCtlKaryawan : Implements InfProses

    Public Function cariData(key As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function DeleteData(key As Object) As OleDbCommand Implements InfProses.DeleteData
        CMD = New OleDbCommand("delete from karyawan " _
            & "where idkaryawan='" & key & "'", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntKaryawan
        data = Ob
        CMD = New OleDbCommand("insert into karyawan values('" & data.idKaryawan & "','" _
                               & data.namaKaryawan & "'," & data.alamatKaryawan & "','" _
                               & data.noTelp & "','" & data.posisi & "','" & data.pssword & ")", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from karyawan", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_karyawan")
            Dim grid As New DataView(DTS.Tables("Tabel_karyawan"))

            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements InfProses.UpdateData
        Dim data As New ClsEntKaryawan
        data = Ob
        CMD = New OleDbCommand("update karyawan set namakaryawan='" _
                               & data.namaKaryawan & "',alamat=" & data.alamatKaryawan _
                               & "',telp=" & data.noTelp & "',posisi=" & data.posisi _
                               & "',pswrd=" & data.pssword _
                               & "where idkaryawan='" & data.idKaryawan & "'", OPENCONNECTION)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", CLOSECONNECTION)
        Return CMD
    End Function
    Function kodeBaru() As String
        Dim baru As String
        Dim akhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(idkaryawan,4)) from karyawan", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            akhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "K" & Strings.Right("000" & akhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function cekKaryawan(key As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(idkaryawan) from karyawan " _
                                       & "where idkaryawan='" & key & "'", OPENCONNECTION)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
            Return cek
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
