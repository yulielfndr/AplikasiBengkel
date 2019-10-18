Public Class FormKaryawan
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub RefreshGrid()
        DTGrid = KontrolKaryawan.tampilData.ToTable
        DGKaryawan.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKaryawan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGKaryawan.CurrentCell = DGKaryawan.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub
    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUbah.Enabled = st
        btnHapus.Enabled = st
        txtsimpan.Enabled = Not st
        btnBatal.Enabled = Not st
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGKaryawan.Rows(br)
                txtIdKarywn.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtAlamat.Text = .Cells(2).Value.ToString
                txtTelp.Text = .Cells(3).Value.ToString
            End With
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTelp.Text = ""

        txtIdKarywn.Text = KontrolKaryawan.kodeBaru()

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

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasKaryawan
            .idKaryawan = txtIdKarywn.Text
            .namaKaryawan = txtNama.Text
            .alamatKaryawan = txtAlamat.Text
            .noTelp = txtTelp.Text

        End With
        If modeProses = 1 Then
            KontrolKaryawan.InsertData(EntitasKaryawan)
        ElseIf modeProses = 2 Then
            KontrolKaryawan.UpdateData(EntitasKaryawan)
        End If
        MsgBox("Data Telah Disimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status As Boolean
        status = KontrolKaryawan.cekKaryawan(txtIdKarywn.Text)
        If status Then
            MsgBox("Data Masih Digunakan, Tidak boleh Dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If
        If MsgBox("Apakah anda yakin akan menghapus " & txtNama.Text & " ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            KontrolKaryawan.DeleteData(txtIdKarywn.Text)
        End If
    End Sub

    Private Sub DGKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGKaryawan.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGKaryawan.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub FormKaryawan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call RefreshGrid()
        txtIdKarywn.Enabled = False
    End Sub

    Private Sub PictBack_Click(sender As Object, e As EventArgs) Handles PictBack.Click
        Me.Close()
    End Sub

    Private Sub PictClose_Click(sender As Object, e As EventArgs) Handles PictClose.Click
        Application.Exit()
    End Sub
End Class