Public Class FormKasKeluar
    Dim modeproses As Integer
    Dim baris As Integer

    Private Sub AturText(st As Boolean)
        txtNama.Enabled = st
        txtJumlah.Enabled = st
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
            With DGKasKeluar.Rows(br)
                txtKode.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtJumlah.Text = .Cells(2).Value.ToString
            End With
        End If
    End Sub


    Private Sub FormKasKeluar_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtKode.Enabled = False
    End Sub
End Class