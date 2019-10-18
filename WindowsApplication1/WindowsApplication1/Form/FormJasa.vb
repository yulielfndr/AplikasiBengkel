Public Class FormJasa
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub RefreshGrid()
        DTGrid = KontrolJasa.tampilData.ToTable
        DGJasa.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGJasa.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGJasa.CurrentCell = DGJasa.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub
    Private Sub AturButton(st As Boolean)
        btnTambahj.Enabled = st
        btnUbahj.Enabled = st
        btnHapusj.Enabled = st
        btnSimpan.Enabled = Not st
        btnBatal.Enabled = Not st
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGJasa.Rows(br)
                txtKdJasa.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtHarga.Text = .Cells(2).Value.ToString
            End With
        End If
    End Sub

    Private Sub btnTambahj_Click(sender As Object, e As EventArgs) Handles btnTambahj.Click
        AturButton(False)
        modeProses = 1
        txtNama.Text = ""
        txtHarga.Text = 0

        txtKdJasa.Text = KontrolJasa.kodeBaru()

        txtNama.Focus()
    End Sub

    Private Sub btnUbahj_Click(sender As Object, e As EventArgs) Handles btnUbahj.Click
        AturButton(False)
        txtNama.Focus()
        modeProses = 2
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasJasa
            .kodeJasa = txtKdJasa.Text
            .namaJasa = txtNama.Text
            .hargaJasa = txtHarga.Text
        End With
        If modeProses = 1 Then
            KontrolJasa.InsertData(EntitasJasa)
        ElseIf modeProses = 2 Then
            KontrolJasa.UpdateData(EntitasJasa)
        End If
        MsgBox("Data Telah Disimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub btnHapusj_Click(sender As Object, e As EventArgs) Handles btnHapusj.Click
        Dim status As Boolean
        status = KontrolJasa.cekJasa(txtKdJasa.Text)
        If status Then
            MsgBox("Data Masih Digunakan, Tidak boleh Dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If
        If MsgBox("Apakah anda yakin akan menghapus " & txtKdJasa.Text & "-" & txtNama.Text & " ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            KontrolJasa.DeleteData(txtKdJasa.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub DGJasa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGJasa.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGJasa.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub FormJasa_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call RefreshGrid()
        txtKdJasa.Enabled = False
    End Sub

    Private Sub PictBack_Click(sender As Object, e As EventArgs) Handles PictBack.Click
        Me.Close()
    End Sub

    Private Sub PictClose_Click(sender As Object, e As EventArgs) Handles PictClose.Click
        Application.Exit()
    End Sub

    'Private Sub txtNama_GotFocus(sender As Object, e As EventArgs) Handles txtNama.GotFocus
    '    txtNama.ForeColor = Color.Black
    '    txtNama.Text = ""
    'End Sub

    'Private Sub txtNama_LostFocus(sender As Object, e As EventArgs) Handles txtNama.LostFocus
    '    txtNama.ForeColor = Color.LightGray
    '    txtNama.Text = "Contoh : Ganti Oli"
    'End Sub

    'Private Sub txtHarga_GotFocus(sender As Object, e As EventArgs) Handles txtHarga.GotFocus
    '    txtHarga.ForeColor = Color.Black
    '    txtHarga.Text = ""
    'End Sub

    'Private Sub txtHarga_LostFocus(sender As Object, e As EventArgs) Handles txtHarga.LostFocus
    '    txtHarga.ForeColor = Color.LightGray
    '    txtHarga.Text = "Contoh : 1000"
    'End Sub
End Class