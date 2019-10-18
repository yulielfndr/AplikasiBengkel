Public Class FormTransaksi
    Dim baris As Integer

    Sub SubTotalProduk()
        Dim jumProduk As Integer = 0
        Dim jumHarga As Integer = 0
        Dim total As Double = 0
        For baris As Integer = 0 To LVProduk.Items.Count - 1
            jumProduk = jumProduk + LVProduk.Items(baris).SubItems(3).Text
            total = total + (HargaP.Text * Jumlah.Text)
            jumHarga = jumHarga + LVProduk.Items(baris).SubItems(4).Text
        Next
        txtTotalProduk.Text = jumHarga
        lblJumlahP.Text = jumProduk
    End Sub

    Sub SubTotalJasa()

    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles cbPasang.CheckedChanged

    End Sub

    Private Sub PictCariProduk_Click(sender As Object, e As EventArgs) Handles PictCariProduk.Click
        FormCariProduk.Show()
    End Sub

    Private Sub PictClose_Click(sender As Object, e As EventArgs) Handles PictClose.Click
        Application.Exit()
    End Sub

    Private Sub PictBack_Click(sender As Object, e As EventArgs) Handles PictBack.Click
        Me.Close()
    End Sub

    Sub TabelViewProduk()
        LVProduk.Columns.Add("KodeProduk", 80, HorizontalAlignment.Center)
        LVProduk.Columns.Add("NamaProduk", 108, HorizontalAlignment.Center)
        LVProduk.Columns.Add("Harga", 80, HorizontalAlignment.Center)
        LVProduk.Columns.Add("Qty", 80, HorizontalAlignment.Center)
        LVProduk.Columns.Add("Subtotal", 80, HorizontalAlignment.Center)

        LVProduk.View = View.Details
        LVProduk.GridLines = True
        LVProduk.FullRowSelect = True
    End Sub

    Sub TabelViewJasa()
        LVJasa.Columns.Add("KodeJasa", 100, HorizontalAlignment.Center)
        LVJasa.Columns.Add("NamaJasa", 119, HorizontalAlignment.Center)
        LVJasa.Columns.Add("Harga", 100, HorizontalAlignment.Center)
        LVJasa.Columns.Add("Subtotal", 100, HorizontalAlignment.Center)

        LVJasa.View = View.Details
        LVJasa.GridLines = True
        LVJasa.FullRowSelect = True
    End Sub

    Private Sub cbService_Click(sender As Object, e As EventArgs) Handles cbService.Click
        kdJasa.Enabled = True
        namaJasa.Enabled = True
        Harga.Enabled = True

    End Sub

    Private Sub cbPenjualan_Click(sender As Object, e As EventArgs) Handles cbPenjualan.Click
        kdProduk.Enabled = True
        namaProduk.Enabled = True
        HargaP.Enabled = True
        Jumlah.Enabled = True
    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TabelViewProduk()
        Call TabelViewJasa()
        kdJasa.Enabled = False
        namaJasa.Enabled = False
        Harga.Enabled = False
        kdProduk.Enabled = False
        namaProduk.Enabled = False
        HargaP.Enabled = False
        Jumlah.Enabled = False
    End Sub

    Sub IdTransaksi()
        CMD = New OleDb.OleDbCommand("Select * from transaksi where idtransaksi in(select max(idtransaksi) order by idtransaksi desc", OPENCONNECTION)
        DTR = CMD.ExecuteReader

        If Not DTR.HasRows Then
            txtTransaksi.Text = Format(Now, "yyMMdd" + "0001")
        Else
            If Microsoft.VisualBasic.Left(DTR.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                txtTransaksi.Text = DTR.GetString(0) + 1
            End If

        End If
    End Sub

    Private Sub PicTambahP_Click(sender As Object, e As EventArgs) Handles PicTambahP.Click
        Dim strProduk(4) As String

        strProduk(0) = txtKdProduk.Text
        strProduk(1) = namaProduk.Text
        strProduk(2) = HargaP.Text
        strProduk(3) = Jumlah.Text
        strProduk(4) = HargaP.Text * Jumlah.Text

        LVProduk.Items.Add(New ListViewItem(strProduk))
        Call SubTotalProduk()
    End Sub
End Class
