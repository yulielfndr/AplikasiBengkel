Public Class FormKategoriLaporan
    Private Sub PictClose_Click(sender As Object, e As EventArgs) Handles PictClose.Click
        Application.Exit()
    End Sub

    Private Sub PictBack_Click(sender As Object, e As EventArgs) Handles PictBack.Click
        Me.Hide()
    End Sub

    Private Sub PictProduk_Click(sender As Object, e As EventArgs) Handles PictProduk.Click
        FormLaporanProduk.Show()
    End Sub

    Private Sub PictOlahData_Click(sender As Object, e As EventArgs) Handles PictOlahData.Click
        FormOlahDataRekAkun.Show()
    End Sub

    Private Sub PicKMasuk_Click(sender As Object, e As EventArgs) Handles PicKMasuk.Click
        FormKasMasuk.Show()
    End Sub

    Private Sub PicKKeluar_Click(sender As Object, e As EventArgs) Handles PicKKeluar.Click
        FormKasKeluar.Show()
    End Sub

    Private Sub PictKaryawan_Click(sender As Object, e As EventArgs) Handles PictKaryawan.Click
        FormLaporanKaryawan.Show()
    End Sub

    Private Sub PictTransaksi_Click(sender As Object, e As EventArgs) Handles PictTransaksi.Click

    End Sub
End Class