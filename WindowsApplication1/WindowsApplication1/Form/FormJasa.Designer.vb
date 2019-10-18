<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJasa
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
        Me.btnSimpan = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtKdJasa = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.btnBatal = New System.Windows.Forms.Panel()
        Me.btnBatalj = New System.Windows.Forms.Label()
        Me.btnHapusj = New System.Windows.Forms.Panel()
        Me.btnHapus = New System.Windows.Forms.Label()
        Me.btnUbahj = New System.Windows.Forms.Panel()
        Me.btnUbah = New System.Windows.Forms.Label()
        Me.btnTambahj = New System.Windows.Forms.Panel()
        Me.btnTambah = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.DGJasa = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictBack = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictClose = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.btnSimpan.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.btnBatal.SuspendLayout()
        Me.btnHapusj.SuspendLayout()
        Me.btnUbahj.SuspendLayout()
        Me.btnTambahj.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.DGJasa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.btnBatal)
        Me.Panel2.Controls.Add(Me.btnHapusj)
        Me.Panel2.Controls.Add(Me.btnUbahj)
        Me.Panel2.Controls.Add(Me.btnTambahj)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(27, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(545, 326)
        Me.Panel2.TabIndex = 3
        '
        'btnSimpan
        '
        Me.btnSimpan.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button_col_md_12
        Me.btnSimpan.Controls.Add(Me.Label5)
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.Location = New System.Drawing.Point(26, 259)
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
        Me.Panel4.Controls.Add(Me.txtKdJasa)
        Me.Panel4.Location = New System.Drawing.Point(154, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(366, 42)
        Me.Panel4.TabIndex = 7
        '
        'txtKdJasa
        '
        Me.txtKdJasa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKdJasa.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKdJasa.ForeColor = System.Drawing.Color.LightGray
        Me.txtKdJasa.Location = New System.Drawing.Point(20, 13)
        Me.txtKdJasa.Name = "txtKdJasa"
        Me.txtKdJasa.Size = New System.Drawing.Size(326, 16)
        Me.txtKdJasa.TabIndex = 2
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
        Me.btnBatal.Controls.Add(Me.btnBatalj)
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.Location = New System.Drawing.Point(410, 203)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(110, 42)
        Me.btnBatal.TabIndex = 5
        '
        'btnBatalj
        '
        Me.btnBatalj.AutoSize = True
        Me.btnBatalj.BackColor = System.Drawing.Color.Transparent
        Me.btnBatalj.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatalj.ForeColor = System.Drawing.Color.White
        Me.btnBatalj.Location = New System.Drawing.Point(27, 11)
        Me.btnBatalj.Name = "btnBatalj"
        Me.btnBatalj.Size = New System.Drawing.Size(56, 19)
        Me.btnBatalj.TabIndex = 8
        Me.btnBatalj.Text = "BATAL"
        '
        'btnHapusj
        '
        Me.btnHapusj.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button_col_md_4
        Me.btnHapusj.Controls.Add(Me.btnHapus)
        Me.btnHapusj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapusj.Location = New System.Drawing.Point(281, 203)
        Me.btnHapusj.Name = "btnHapusj"
        Me.btnHapusj.Size = New System.Drawing.Size(110, 42)
        Me.btnHapusj.TabIndex = 5
        '
        'btnHapus
        '
        Me.btnHapus.AutoSize = True
        Me.btnHapus.BackColor = System.Drawing.Color.Transparent
        Me.btnHapus.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(26, 11)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(59, 19)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "HAPUS"
        '
        'btnUbahj
        '
        Me.btnUbahj.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button_col_md_4
        Me.btnUbahj.Controls.Add(Me.btnUbah)
        Me.btnUbahj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUbahj.Location = New System.Drawing.Point(154, 203)
        Me.btnUbahj.Name = "btnUbahj"
        Me.btnUbahj.Size = New System.Drawing.Size(110, 42)
        Me.btnUbahj.TabIndex = 5
        '
        'btnUbah
        '
        Me.btnUbah.AutoSize = True
        Me.btnUbah.BackColor = System.Drawing.Color.Transparent
        Me.btnUbah.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Location = New System.Drawing.Point(30, 11)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(51, 19)
        Me.btnUbah.TabIndex = 7
        Me.btnUbah.Text = "UBAH"
        '
        'btnTambahj
        '
        Me.btnTambahj.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.button_col_md_4
        Me.btnTambahj.Controls.Add(Me.btnTambah)
        Me.btnTambahj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambahj.Location = New System.Drawing.Point(26, 203)
        Me.btnTambahj.Name = "btnTambahj"
        Me.btnTambahj.Size = New System.Drawing.Size(110, 42)
        Me.btnTambahj.TabIndex = 5
        '
        'btnTambah
        '
        Me.btnTambah.AutoSize = True
        Me.btnTambah.BackColor = System.Drawing.Color.Transparent
        Me.btnTambah.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(19, 11)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(73, 19)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "TAMBAH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(26, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Harga Jasa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(26, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Jasa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(26, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kode Jasa"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Controls.Add(Me.DGJasa)
        Me.Panel11.Location = New System.Drawing.Point(27, 449)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(545, 223)
        Me.Panel11.TabIndex = 4
        '
        'DGJasa
        '
        Me.DGJasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGJasa.Location = New System.Drawing.Point(29, 21)
        Me.DGJasa.Name = "DGJasa"
        Me.DGJasa.Size = New System.Drawing.Size(491, 150)
        Me.DGJasa.TabIndex = 5
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
        Me.Panel1.TabIndex = 2
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
        Me.Label1.Location = New System.Drawing.Point(254, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATA JASA"
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
        'FormJasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 682)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormJasa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Jasa"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
        Me.btnHapusj.ResumeLayout(False)
        Me.btnHapusj.PerformLayout()
        Me.btnUbahj.ResumeLayout(False)
        Me.btnUbahj.PerformLayout()
        Me.btnTambahj.ResumeLayout(False)
        Me.btnTambahj.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        CType(Me.DGJasa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictBack As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictClose As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBatal As Panel
    Friend WithEvents btnHapusj As Panel
    Friend WithEvents btnUbahj As Panel
    Friend WithEvents btnTambahj As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtKdJasa As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnSimpan As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBatalj As Label
    Friend WithEvents btnHapus As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnUbah As Label
    Friend WithEvents btnTambah As Label
    Friend WithEvents DGJasa As DataGridView
End Class
