<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCariProduk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictClose = New System.Windows.Forms.PictureBox()
        Me.PictBack = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaProduk = New System.Windows.Forms.TextBox()
        Me.LVCari = New System.Windows.Forms.ListView()
        Me.PictCari = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictCari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.header_background
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictClose)
        Me.Panel1.Controls.Add(Me.PictBack)
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
        Me.Label1.Location = New System.Drawing.Point(273, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CARI"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(66, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(467, 94)
        Me.Panel2.TabIndex = 1
        '
        'PictClose
        '
        Me.PictClose.BackColor = System.Drawing.Color.Transparent
        Me.PictClose.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.close
        Me.PictClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictClose.Location = New System.Drawing.Point(543, 31)
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
        Me.PictBack.Location = New System.Drawing.Point(31, 31)
        Me.PictBack.Name = "PictBack"
        Me.PictBack.Size = New System.Drawing.Size(28, 28)
        Me.PictBack.TabIndex = 3
        Me.PictBack.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Gilroy ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(95, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Produk"
        '
        'txtNamaProduk
        '
        Me.txtNamaProduk.Location = New System.Drawing.Point(200, 165)
        Me.txtNamaProduk.Name = "txtNamaProduk"
        Me.txtNamaProduk.Size = New System.Drawing.Size(247, 20)
        Me.txtNamaProduk.TabIndex = 5
        '
        'LVCari
        '
        Me.LVCari.Location = New System.Drawing.Point(66, 244)
        Me.LVCari.Name = "LVCari"
        Me.LVCari.Size = New System.Drawing.Size(467, 207)
        Me.LVCari.TabIndex = 6
        Me.LVCari.UseCompatibleStateImageBehavior = False
        '
        'PictCari
        '
        Me.PictCari.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.load_icon
        Me.PictCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictCari.Location = New System.Drawing.Point(482, 163)
        Me.PictCari.Name = "PictCari"
        Me.PictCari.Size = New System.Drawing.Size(22, 22)
        Me.PictCari.TabIndex = 7
        Me.PictCari.TabStop = False
        '
        'FormCariProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 481)
        Me.Controls.Add(Me.PictCari)
        Me.Controls.Add(Me.LVCari)
        Me.Controls.Add(Me.txtNamaProduk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormCariProduk"
        Me.Text = "FormCariProduk"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictCari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictBack As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictClose As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNamaProduk As TextBox
    Friend WithEvents LVCari As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictCari As PictureBox
End Class
