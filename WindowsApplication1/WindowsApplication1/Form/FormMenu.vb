Public Class FormMenu
    Private Sub PictClose_Click(sender As Object, e As EventArgs) Handles PictClose.Click
        Application.Exit()
    End Sub

    Private Sub PictJasa_Click(sender As Object, e As EventArgs) Handles PictJasa.Click
        FormJasa.Show()
    End Sub

    Private Sub PictKaryawan_Click(sender As Object, e As EventArgs) Handles PictKaryawan.Click
        FormKaryawan.Show()
    End Sub

    Private Sub PictKeluar_Click(sender As Object, e As EventArgs) Handles PictKeluar.Click
        If MsgBox("Apakah anda yakin ingin keluar  ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            Me.Close()
            FormLogin.Show()
        End If

    End Sub

    Private Sub PictProduk_Click(sender As Object, e As EventArgs) Handles PictProduk.Click
        FormProduk.Show()
    End Sub

    Private Sub PictTransaksi_Click(sender As Object, e As EventArgs) Handles PictTransaksi.Click
        FormTransaksi.Show()
    End Sub





    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictProduk.Enabled = False
        PictJasa.Enabled = False
        PictKaryawan.Enabled = False
        PictTransaksi.Enabled = False
        PictKeluar.Enabled = False
        PictLaporan.Enabled = False
    End Sub

    Private Sub PictLaporan_Click(sender As Object, e As EventArgs) Handles PictLaporan.Click
        FormKategoriLaporan.Show()
    End Sub
End Class