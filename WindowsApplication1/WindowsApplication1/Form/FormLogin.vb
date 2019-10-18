Imports System.Data.OleDb
Public Class FormLogin
    Dim a

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        Try
            If txtIdKaryawan.Text = "" Or txtPassword.Text = "" Then
                MsgBox("Harap Input ID Karyawan dan Password !")
            Else
                CMD = New OleDbCommand("select * from Karyawan where idkaryawan='" _
                               & txtIdKaryawan.Text & "' and pswrd='" _
                               & txtPassword.Text & "'", OPENCONNECTION)
                DTR = CMD.ExecuteReader
                DTR.Read()
                If DTR.HasRows Then
                    Me.Hide()
                    If DTR("POSISI").ToString = "Pemilik" Then
                        FormMenu.Show()
                        FormMenu.PictProduk.Enabled = True
                        FormMenu.PictJasa.Enabled = True
                        FormMenu.PictKaryawan.Enabled = True
                        FormMenu.PictTransaksi.Enabled = True
                        FormMenu.PictKeluar.Enabled = True
                        FormMenu.PictLaporan.Enabled = True


                    ElseIf DTR("Posisi").ToString = "Kasir" Then
                        FormMenu.Show()
                        FormMenu.PictTransaksi.Enabled = True
                        FormMenu.PictKeluar.Enabled = True
                    End If
                    Me.Hide()
                Else
                    MsgBox("ID Karyawan atau Password yang Anda Masukkan Salah, Mohon Periksa Kembali")
                    txtIdKaryawan.Text = ""
                    txtPassword.Text = ""

                    a = a + 1
                    If a >= 3 Then
                        MsgBox("Kesempatan Anda Sudah Habis")
                        Me.Close()
                        FormMenu.Close()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call conn()
        a = 0
    End Sub

    'Private Sub txtIdKaryawan_GotFocus(sender As Object, e As EventArgs) Handles txtIdKaryawan.GotFocus
    '    txtIdKaryawan.ForeColor = Color.Black
    '    txtIdKaryawan.Text = ""
    'End Sub

    'Private Sub txtIdKaryawan_LostFocus(sender As Object, e As EventArgs) Handles txtIdKaryawan.LostFocus
    '    txtIdKaryawan.ForeColor = Color.LightGray
    '    txtIdKaryawan.Text = "Username"
    'End Sub

    'Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
    '    txtPassword.ForeColor = Color.Black
    '    txtPassword.Text = ""
    'End Sub

    'Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
    '    txtPassword.ForeColor = Color.LightGray
    '    txtPassword.Text = "Password"
    'End Sub
End Class