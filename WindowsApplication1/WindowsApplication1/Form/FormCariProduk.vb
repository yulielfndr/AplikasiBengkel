Public Class FormCariProduk
    Sub TabelCari()
        LVCari.Columns.Add("KodeProduk", 155, HorizontalAlignment.Center)
        LVCari.Columns.Add("Nama Produk", 157, HorizontalAlignment.Center)
        LVCari.Columns.Add("Harga", 155, HorizontalAlignment.Center)
        ' LVCari.Columns.Add("KodeProduk", 80, HorizontalAlignment.Center)

        LVCari.View = View.Details
        LVCari.GridLines = True
        LVCari.FullRowSelect = True
    End Sub
    Private Sub FormCariProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TabelCari()
    End Sub

    Private Sub LVCari_DoubleClick(sender As Object, e As EventArgs) Handles LVCari.DoubleClick
        With FormTransaksi
            .txtKdProduk.Text = LVCari.SelectedItems(0).SubItems(0).Text
            .namaProduk.Text = LVCari.SelectedItems(0).SubItems(1).Text
            .HargaP.Text = LVCari.SelectedItems(0).SubItems(2).Text
            Me.Close()
            .Jumlah.Focus()
        End With
    End Sub

    Private Sub PictBack_Click(sender As Object, e As EventArgs) Handles PictBack.Click
        Me.Close()
    End Sub

    Private Sub PictCari_Click(sender As Object, e As EventArgs) Handles PictCari.Click
        DTGrid = KontrolProduk.cariData(txtNamaProduk.Text).ToTable
        LVCari.Items.Clear()
        Dim stritem(3) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                stritem(0) = DTGrid.Rows(i).Item(0).ToString
                stritem(1) = DTGrid.Rows(i).Item(1).ToString
                stritem(2) = DTGrid.Rows(i).Item(2).ToString
                stritem(3) = DTGrid.Rows(i).Item(3).ToString

            Next
            LVCari.Items.Add(New ListViewItem(stritem))
        Else
            MsgBox("Maaf Data tidak ditemukan")
        End If
    End Sub

    Private Sub PictClose_Click(sender As Object, e As EventArgs) Handles PictClose.Click
        Application.Exit()
    End Sub

    Private Sub txtNamaProduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaProduk.KeyPress
        DTGrid = KontrolProduk.cariData(txtNamaProduk.Text).ToTable
        LVCari.Items.Clear()
        Dim stritem(3) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                stritem(0) = DTGrid.Rows(i).Item(0).ToString
                stritem(1) = DTGrid.Rows(i).Item(1).ToString
                stritem(2) = DTGrid.Rows(i).Item(2).ToString
                stritem(3) = DTGrid.Rows(i).Item(3).ToString

            Next
            LVCari.Items.Add(New ListViewItem(stritem))
        Else
            MsgBox("Maaf Data tidak ditemukan")
        End If
    End Sub
End Class