<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictTransaksi = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictLaporan = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictKeluar = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictKaryawan = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictJasa = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictProduk = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictClose = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictTransaksi.SuspendLayout()
        Me.PictLaporan.SuspendLayout()
        Me.PictKeluar.SuspendLayout()
        Me.PictKaryawan.SuspendLayout()
        Me.PictJasa.SuspendLayout()
        Me.PictProduk.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictTransaksi
        '
        Me.PictTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.PictTransaksi.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.transaksi
        Me.PictTransaksi.Controls.Add(Me.Label5)
        Me.PictTransaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictTransaksi.Location = New System.Drawing.Point(27, 281)
        Me.PictTransaksi.Name = "PictTransaksi"
        Me.PictTransaksi.Size = New System.Drawing.Size(175, 175)
        Me.PictTransaksi.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(42, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "TRANSAKSI"
        '
        'PictLaporan
        '
        Me.PictLaporan.BackColor = System.Drawing.Color.Transparent
        Me.PictLaporan.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.laporan
        Me.PictLaporan.Controls.Add(Me.Label8)
        Me.PictLaporan.Controls.Add(Me.Label6)
        Me.PictLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictLaporan.Location = New System.Drawing.Point(213, 281)
        Me.PictLaporan.Name = "PictLaporan"
        Me.PictLaporan.Size = New System.Drawing.Size(175, 175)
        Me.PictLaporan.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(47, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "LAPORAN"
        '
        'PictKeluar
        '
        Me.PictKeluar.BackColor = System.Drawing.Color.Transparent
        Me.PictKeluar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.keluar
        Me.PictKeluar.Controls.Add(Me.Label7)
        Me.PictKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictKeluar.Location = New System.Drawing.Point(398, 281)
        Me.PictKeluar.Name = "PictKeluar"
        Me.PictKeluar.Size = New System.Drawing.Size(175, 175)
        Me.PictKeluar.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(54, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "KELUAR"
        '
        'PictKaryawan
        '
        Me.PictKaryawan.BackColor = System.Drawing.Color.Transparent
        Me.PictKaryawan.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.montir
        Me.PictKaryawan.Controls.Add(Me.Label4)
        Me.PictKaryawan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictKaryawan.Location = New System.Drawing.Point(398, 96)
        Me.PictKaryawan.Name = "PictKaryawan"
        Me.PictKaryawan.Size = New System.Drawing.Size(175, 175)
        Me.PictKaryawan.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(40, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "KARYAWAN"
        '
        'PictJasa
        '
        Me.PictJasa.BackColor = System.Drawing.Color.Transparent
        Me.PictJasa.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.jasa
        Me.PictJasa.Controls.Add(Me.Label3)
        Me.PictJasa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictJasa.Location = New System.Drawing.Point(213, 96)
        Me.PictJasa.Name = "PictJasa"
        Me.PictJasa.Size = New System.Drawing.Size(175, 175)
        Me.PictJasa.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(63, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "JASA"
        '
        'PictProduk
        '
        Me.PictProduk.BackColor = System.Drawing.Color.Transparent
        Me.PictProduk.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.produk
        Me.PictProduk.Controls.Add(Me.Label2)
        Me.PictProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictProduk.Location = New System.Drawing.Point(27, 96)
        Me.PictProduk.Name = "PictProduk"
        Me.PictProduk.Size = New System.Drawing.Size(175, 175)
        Me.PictProduk.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(51, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PRODUK"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.header_background
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictClose)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 161)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gilroy ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(238, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DASBOR ADMIN"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Gilroy ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(2, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "OLAH DATA AKUNTANSI"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 483)
        Me.Controls.Add(Me.PictTransaksi)
        Me.Controls.Add(Me.PictLaporan)
        Me.Controls.Add(Me.PictKeluar)
        Me.Controls.Add(Me.PictKaryawan)
        Me.Controls.Add(Me.PictJasa)
        Me.Controls.Add(Me.PictProduk)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beranda"
        Me.PictTransaksi.ResumeLayout(False)
        Me.PictTransaksi.PerformLayout()
        Me.PictLaporan.ResumeLayout(False)
        Me.PictLaporan.PerformLayout()
        Me.PictKeluar.ResumeLayout(False)
        Me.PictKeluar.PerformLayout()
        Me.PictKaryawan.ResumeLayout(False)
        Me.PictKaryawan.PerformLayout()
        Me.PictJasa.ResumeLayout(False)
        Me.PictJasa.PerformLayout()
        Me.PictProduk.ResumeLayout(False)
        Me.PictProduk.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictClose As PictureBox
    Friend WithEvents PictProduk As Panel
    Friend WithEvents PictJasa As Panel
    Friend WithEvents PictKaryawan As Panel
    Friend WithEvents PictKeluar As Panel
    Friend WithEvents PictLaporan As Panel
    Friend WithEvents PictTransaksi As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
End Class
