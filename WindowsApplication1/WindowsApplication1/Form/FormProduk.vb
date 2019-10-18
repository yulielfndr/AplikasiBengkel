Public Class FormProduk
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub FormProduk_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call RefreshGrid()
        txtKdProduk.Enabled = False
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolProduk.tampilData.ToTable
        DGProduk.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGProduk.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGProduk.CurrentCell = DGProduk.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub
    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUbah.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnBatal.Enabled = Not st
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGProduk.Rows(br)
                txtKdProduk.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtHarga.Text = .Cells(2).Value.ToString
                txtStok.Text = .Cells(3).Value.ToString
            End With
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1
        txtNama.Text = ""
        txtHarga.Text = 0
        txtStok.Text = 0

        txtKdProduk.Text = KontrolProduk.kodeBaru()

        txtNama.Focus()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        txtNama.Focus()
        modeProses = 2
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub DGProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProduk.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGProduk.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasProduk
            .kodeProduk = txtKdProduk.Text
            .namaProduk = txtNama.Text
            .hargaProduk = txtHarga.Text
            .stokProduk = txtStok.Text
        End With
        If modeProses = 1 Then
            KontrolProduk.InsertData(EntitasProduk)
        ElseIf modeProses = 2 Then
            KontrolProduk.UpdateData(EntitasProduk)
        End If
        MsgBox("Data Telah Disimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status As Boolean
        status = KontrolProduk.cekProduk(txtKdProduk.Text)
        If status Then
            MsgBox("Data Masih Digunakan, Tidak boleh Dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If
        If MsgBox("Apakah anda yakin akan menghapus " & txtKdProduk.Text & "-" & txtNama.Text & " ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            KontrolProduk.DeleteData(txtKdProduk.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub PictClose_Click(sender As Object, e As EventArgs) Handles PictClose.Click
        Application.Exit()
    End Sub

    Private Sub PictBack_Click(sender As Object, e As EventArgs) Handles PictBack.Click
        Me.Close()
    End Sub
End Class