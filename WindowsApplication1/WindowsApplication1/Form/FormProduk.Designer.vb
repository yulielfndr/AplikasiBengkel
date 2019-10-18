<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduk
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.DGProduk = New System.Windows.Forms.DataGridView()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtKdProduk = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.btnBatal = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnUbah = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictBack = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictClose = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.DGProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.btnSimpan.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.btnBatal.SuspendLayout()
        Me.btnHapus.SuspendLayout()
        Me.btnUbah.SuspendLayout()
        Me.btnTambah.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.btnBatal)
        Me.Panel2.Controls.Add(Me.btnHapus)
        Me.Panel2.Controls.Add(Me.btnUbah)
        Me.Panel2.Controls.Add(Me.btnTambah)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(27, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(545, 385)
        Me.Panel2.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(26, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Stok Produk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(26, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Harga Produk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(26, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Produk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(26, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kode Produk"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.Controls.Add(Me.DGProduk)
        Me.Panel12.Location = New System.Drawing.Point(27, 458)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(545, 223)
        Me.Panel12.TabIndex = 5
        '
        'DGProduk
        '
        Me.DGProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProduk.Location = New System.Drawing.Point(26, 26)
        Me.DGProduk.Name = "DGProduk"
        Me.DGProduk.Size = New System.Drawing.Size(494, 173)
        Me.DGProduk.TabIndex = 1
        '
        'Panel11
        '
        Me.Panel11.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.input_data
        Me.Panel11.Controls.Add(Me.txtStok)
        Me.Panel11.Location = New System.Drawing.Point(154, 201)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(366, 42)
        Me.Panel11.TabIndex = 8
        '
        'txtStok
        '
        Me.txtStok.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStok.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.ForeColor = System.Drawing.Color.LightGray
        Me.txtStok.Location = New System.Drawing.Point(20, 13)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(326, 16)
        Me.txtStok.TabIndex = 2
        '
        'btnSimpan
        '
        Me.btnSimpan.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button_col_md_12
        Me.btnSimpan.Controls.Add(Me.Label5)
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.Location = New System.Drawing.Point(26, 318)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(494, 42)
        Me.btnSimpan.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(214, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "SIMPAN"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.input_data
        Me.Panel4.Controls.Add(Me.txtKdProduk)
        Me.Panel4.Location = New System.Drawing.Point(154, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(366, 42)
        Me.Panel4.TabIndex = 7
        '
        'txtKdProduk
        '
        Me.txtKdProduk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKdProduk.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdProduk.ForeColor = System.Drawing.Color.LightGray
        Me.txtKdProduk.Location = New System.Drawing.Point(20, 13)
        Me.txtKdProduk.Name = "txtKdProduk"
        Me.txtKdProduk.Size = New System.Drawing.Size(326, 16)
        Me.txtKdProduk.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.input_data
        Me.Panel3.Controls.Add(Me.txtNama)
        Me.Panel3.Location = New System.Drawing.Point(154, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(366, 42)
        Me.Panel3.TabIndex = 7
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNama.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.ForeColor = System.Drawing.Color.LightGray
        Me.txtNama.Location = New System.Drawing.Point(20, 13)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(326, 16)
        Me.txtNama.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.input_data
        Me.Panel5.Controls.Add(Me.txtHarga)
        Me.Panel5.Location = New System.Drawing.Point(154, 142)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(366, 42)
        Me.Panel5.TabIndex = 6
        '
        'txtHarga
        '
        Me.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHarga.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.ForeColor = System.Drawing.Color.LightGray
        Me.txtHarga.Location = New System.Drawing.Point(20, 13)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(326, 16)
        Me.txtHarga.TabIndex = 2
        '
        'btnBatal
        '
        Me.btnBatal.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button_col_md_4
        Me.btnBatal.Controls.Add(Me.Label9)
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.Location = New System.Drawing.Point(410, 259)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(110, 42)
        Me.btnBatal.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(27, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "BATAL"
        '
        'btnHapus
        '
        Me.btnHapus.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button_col_md_4
        Me.btnHapus.Controls.Add(Me.Label8)
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Location = New System.Drawing.Point(281, 259)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(110, 42)
        Me.btnHapus.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(26, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "HAPUS"
        '
        'btnUbah
        '
        Me.btnUbah.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button_col_md_4
        Me.btnUbah.Controls.Add(Me.Label7)
        Me.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUbah.Location = New System.Drawing.Point(154, 259)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(110, 42)
        Me.btnUbah.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(30, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "UBAH"
        '
        'btnTambah
        '
        Me.btnTambah.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button_col_md_4
        Me.btnTambah.Controls.Add(Me.Label6)
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.Location = New System.Drawing.Point(26, 259)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(110, 42)
        Me.btnTambah.TabIndex = 5
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
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.header_background
        Me.Panel1.Controls.Add(Me.PictBack)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictClose)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 161)
        Me.Panel1.TabIndex = 1
        '
        'PictBack
        '
        Me.PictBack.BackColor = System.Drawing.Color.Transparent
        Me.PictBack.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.back
        Me.PictBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictBack.Location = New System.Drawing.Point(27, 34)
        Me.PictBack.Name = "PictBack"
        Me.PictBack.Size = New System.Drawing.Size(28, 28)
        Me.PictBack.TabIndex = 2
        Me.PictBack.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(242, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATA PRODUK"
        '
        'PictClose
        '
        Me.PictClose.BackColor = System.Drawing.Color.Transparent
        Me.PictClose.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.close
        Me.PictClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictClose.Location = New System.Drawing.Point(544, 34)
        Me.PictClose.Name = "PictClose"
        Me.PictClose.Size = New System.Drawing.Size(28, 28)
        Me.PictClose.TabIndex = 0
        Me.PictClose.TabStop = False
        '
        'FormProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 682)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormProduk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Produk"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        CType(Me.DGProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.btnSimpan.ResumeLayout(False)
        Me.btnSimpan.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.btnBatal.ResumeLayout(False)
        Me.btnBatal.PerformLayout()
        Me.btnHapus.ResumeLayout(False)
        Me.btnHapus.PerformLayout()
        Me.btnUbah.ResumeLayout(False)
        Me.btnUbah.PerformLayout()
        Me.btnTambah.ResumeLayout(False)
        Me.btnTambah.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictClose As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictBack As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSimpan As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtKdProduk As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents btnBatal As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents btnHapus As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents btnUbah As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents btnTambah As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txtStok As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents DGProduk As DataGridView
End Class
