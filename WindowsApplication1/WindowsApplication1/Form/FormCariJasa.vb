Public Class FormCariJasa
    Sub TabelCari()
        LVCari.Columns.Add("KodeJasa", 155, HorizontalAlignment.Center)
        LVCari.Columns.Add("Nama Jasa", 157, HorizontalAlignment.Center)
        LVCari.Columns.Add("Harga", 155, HorizontalAlignment.Center)

        LVCari.View = View.Details
        LVCari.GridLines = True
        LVCari.FullRowSelect = True
    End Sub

    Private Sub FormCariJasa_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TabelCari()
    End Sub

    Private Sub LVCari_DoubleClick(sender As Object, e As EventArgs) Handles LVCari.DoubleClick
        With FormTransaksi
            .txtKdJasa.Text = LVCari.SelectedItems(0).SubItems(0).Text
            .txtNamaJasa.Text = LVCari.SelectedItems(0).SubItems(1).Text
            .txtHarga.Text = LVCari.SelectedItems(0).SubItems(2).Text
            Me.Close()
            .txtHarga.Focus()
        End With
    End Sub

    Private Sub PictBack_Click(sender As Object, e As EventArgs) Handles PictBack.Click
        Me.Close()
    End Sub

    Private Sub PictCari_Click(sender As Object, e As EventArgs) Handles PictCari.Click
        DTGrid = KontrolJasa.cariData(txtNamaJasa.Text).ToTable
        LVCari.Items.Clear()
        Dim stritem(2) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                stritem(0) = DTGrid.Rows(i).Item(0).ToString
                stritem(1) = DTGrid.Rows(i).Item(1).ToString
                stritem(2) = DTGrid.Rows(i).Item(2).ToString
            Next
            LVCari.Items.Add(New ListViewItem(stritem))
        Else
            MsgBox("Maaf Data tidak ditemukan")
        End If
    End Sub

    Private Sub PictClose_Click(sender As Object, e As EventArgs) Handles PictClose.Click
        Application.Exit()
    End Sub

    Private Sub txtNamaJasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaJasa.KeyPress
        DTGrid = KontrolJasa.cariData(txtNamaJasa.Text).ToTable
        LVCari.Items.Clear()
        Dim stritem(2) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                stritem(0) = DTGrid.Rows(i).Item(0).ToString
                stritem(1) = DTGrid.Rows(i).Item(1).ToString
                stritem(2) = DTGrid.Rows(i).Item(2).ToString
            Next
            LVCari.Items.Add(New ListViewItem(stritem))
        Else
            MsgBox("Maaf Data tidak ditemukan")
        End If
    End Sub
End Class