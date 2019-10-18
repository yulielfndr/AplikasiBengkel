<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKasMasuk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictClose = New System.Windows.Forms.PictureBox()
        Me.PictBack = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGKasKeluar = New System.Windows.Forms.DataGridView()
        Me.btnBatal = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnUbah = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtTanggal = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DGKasKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnBatal.SuspendLayout()
        Me.btnHapus.SuspendLayout()
        Me.btnUbah.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.btnTambah.SuspendLayout()
        Me.btnSimpan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background_transaction
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictClose)
        Me.Panel1.Controls.Add(Me.PictBack)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(749, 161)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(326, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "KAS MASUK"
        '
        'PictClose
        '
        Me.PictClose.BackColor = System.Drawing.Color.Transparent
        Me.PictClose.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.close
        Me.PictClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictClose.Location = New System.Drawing.Point(693, 31)
        Me.PictClose.Name = "PictClose"
        Me.PictClose.Size = New System.Drawing.Size(28, 28)
        Me.PictClose.TabIndex = 4
        Me.PictClose.TabStop = False
        '
        'PictBack
        '
        Me.PictBack.BackColor = System.Drawing.Color.Transparent
        Me.PictBack.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back
        Me.PictBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictBack.Location = New System.Drawing.Point(20, 31)
        Me.PictBack.Name = "PictBack"
        Me.PictBack.Size = New System.Drawing.Size(28, 28)
        Me.PictBack.TabIndex = 3
        Me.PictBack.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.DGKasKeluar)
        Me.Panel2.Controls.Add(Me.btnBatal)
        Me.Panel2.Controls.Add(Me.btnHapus)
        Me.Panel2.Controls.Add(Me.btnUbah)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnTambah)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Location = New System.Drawing.Point(21, 87)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(701, 469)
        Me.Panel2.TabIndex = 9
        '
        'DGKasKeluar
        '
        Me.DGKasKeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKasKeluar.Location = New System.Drawing.Point(42, 235)
        Me.DGKasKeluar.Name = "DGKasKeluar"
        Me.DGKasKeluar.Size = New System.Drawing.Size(609, 201)
        Me.DGKasKeluar.TabIndex = 20
        '
        'btnBatal
        '
        Me.btnBatal.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button_col_md_4
        Me.btnBatal.Controls.Add(Me.Label11)
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.Location = New System.Drawing.Point(541, 166)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(110, 42)
        Me.btnBatal.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(28, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 19)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "BATAL"
        '
        'btnHapus
        '
        Me.btnHapus.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button_col_md_4
        Me.btnHapus.Controls.Add(Me.Label10)
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Location = New System.Drawing.Point(289, 166)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(110, 42)
        Me.btnHapus.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(28, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 19)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "HAPUS"
        '
        'btnUbah
        '
        Me.btnUbah.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button_col_md_4
        Me.btnUbah.Controls.Add(Me.Label9)
        Me.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUbah.Location = New System.Drawing.Point(165, 166)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(110, 42)
        Me.btnUbah.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(32, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 19)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "UBAH"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(389, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Nama"
        '
        'Panel7
        '
        Me.Panel7.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.input_col_md_4
        Me.Panel7.Controls.Add(Me.txtJumlah)
        Me.Panel7.Location = New System.Drawing.Point(472, 78)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(179, 42)
        Me.Panel7.TabIndex = 15
        '
        'txtJumlah
        '
        Me.txtJumlah.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJumlah.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlah.ForeColor = System.Drawing.Color.DimGray
        Me.txtJumlah.Location = New System.Drawing.Point(20, 13)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(142, 16)
        Me.txtJumlah.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.input_col_md_4
        Me.Panel6.Controls.Add(Me.txtNama)
        Me.Panel6.Location = New System.Drawing.Point(472, 23)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(179, 42)
        Me.Panel6.TabIndex = 14
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNama.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.ForeColor = System.Drawing.Color.DimGray
        Me.txtNama.Location = New System.Drawing.Point(20, 13)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(142, 16)
        Me.txtNama.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.input_col_md_4
        Me.Panel5.Controls.Add(Me.txtTanggal)
        Me.Panel5.Location = New System.Drawing.Point(136, 78)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(179, 42)
        Me.Panel5.TabIndex = 13
        '
        'txtTanggal
        '
        Me.txtTanggal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTanggal.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTanggal.ForeColor = System.Drawing.Color.DimGray
        Me.txtTanggal.Location = New System.Drawing.Point(20, 13)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(142, 16)
        Me.txtTanggal.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.input_col_md_4
        Me.Panel4.Controls.Add(Me.txtKode)
        Me.Panel4.Location = New System.Drawing.Point(136, 23)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(179, 42)
        Me.Panel4.TabIndex = 12
        '
        'txtKode
        '
        Me.txtKode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKode.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKode.ForeColor = System.Drawing.Color.DimGray
        Me.txtKode.Location = New System.Drawing.Point(20, 13)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(142, 16)
        Me.txtKode.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(39, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Tanggal "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(389, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(39, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(39, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Kode "
        '
        'btnTambah
        '
        Me.btnTambah.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button_col_md_4
        Me.btnTambah.Controls.Add(Me.Label6)
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.Location = New System.Drawing.Point(42, 166)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(110, 42)
        Me.btnTambah.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(19, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TAMBAH"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button_col_md_4
        Me.btnSimpan.Controls.Add(Me.Label3)
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.Location = New System.Drawing.Point(415, 166)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(110, 42)
        Me.btnSimpan.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SIMPAN"
        '
        'FormKasMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 577)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormKasMasuk"
        Me.Text = "FormKasMasuk"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGKasKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnBatal.ResumeLayout(False)
        Me.btnBatal.PerformLayout()
        Me.btnHapus.ResumeLayout(False)
        Me.btnHapus.PerformLayout()
        Me.btnUbah.ResumeLayout(False)
        Me.btnUbah.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.btnTambah.ResumeLayout(False)
        Me.btnTambah.PerformLayout()
        Me.btnSimpan.ResumeLayout(False)
        Me.btnSimpan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictClose As PictureBox
    Friend WithEvents PictBack As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGKasKeluar As DataGridView
    Friend WithEvents btnBatal As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents btnHapus As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnUbah As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtTanggal As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtKode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTambah As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSimpan As Panel
    Friend WithEvents Label3 As Label
End Class
