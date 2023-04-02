<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsPC = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsDiv1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsIP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsDiv2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsVersao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdSair = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEntrar = New DevExpress.XtraEditors.SimpleButton()
        Me.CrystalClearListbox1 = New MixPDV.CrystalClearListbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbUsuarios = New System.Windows.Forms.ComboBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.StatusStrip1)
        Me.GroupControl1.Controls.Add(Me.cmdSair)
        Me.GroupControl1.Controls.Add(Me.cmdEntrar)
        Me.GroupControl1.Controls.Add(Me.CrystalClearListbox1)
        Me.GroupControl1.Controls.Add(Me.PictureBox1)
        Me.GroupControl1.Controls.Add(Me.cbUsuarios)
        Me.GroupControl1.Controls.Add(Me.txtSenha)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(338, 213)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Login"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsPC, Me.tsDiv1, Me.tsIP, Me.tsDiv2, Me.tsVersao})
        Me.StatusStrip1.Location = New System.Drawing.Point(2, 189)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(334, 22)
        Me.StatusStrip1.TabIndex = 194
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsPC
        '
        Me.tsPC.Name = "tsPC"
        Me.tsPC.Size = New System.Drawing.Size(31, 17)
        Me.tsPC.Text = "tsPC"
        '
        'tsDiv1
        '
        Me.tsDiv1.Name = "tsDiv1"
        Me.tsDiv1.Size = New System.Drawing.Size(10, 17)
        Me.tsDiv1.Text = "|"
        '
        'tsIP
        '
        Me.tsIP.Name = "tsIP"
        Me.tsIP.Size = New System.Drawing.Size(26, 17)
        Me.tsIP.Text = "tsIP"
        '
        'tsDiv2
        '
        Me.tsDiv2.Name = "tsDiv2"
        Me.tsDiv2.Size = New System.Drawing.Size(10, 17)
        Me.tsDiv2.Text = "|"
        '
        'tsVersao
        '
        Me.tsVersao.Name = "tsVersao"
        Me.tsVersao.Size = New System.Drawing.Size(67, 17)
        Me.tsVersao.Text = "tsDataTime"
        '
        'cmdSair
        '
        Me.cmdSair.Image = CType(resources.GetObject("cmdSair.Image"), System.Drawing.Image)
        Me.cmdSair.Location = New System.Drawing.Point(11, 130)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(141, 45)
        Me.cmdSair.TabIndex = 193
        Me.cmdSair.Text = "Sair"
        '
        'cmdEntrar
        '
        Me.cmdEntrar.Image = CType(resources.GetObject("cmdEntrar.Image"), System.Drawing.Image)
        Me.cmdEntrar.Location = New System.Drawing.Point(184, 130)
        Me.cmdEntrar.Name = "cmdEntrar"
        Me.cmdEntrar.Size = New System.Drawing.Size(141, 45)
        Me.cmdEntrar.TabIndex = 192
        Me.cmdEntrar.Text = "Entrar"
        '
        'CrystalClearListbox1
        '
        Me.CrystalClearListbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CrystalClearListbox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CrystalClearListbox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CrystalClearListbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CrystalClearListbox1.ForeColor = System.Drawing.Color.Black
        Me.CrystalClearListbox1.FormattingEnabled = True
        Me.CrystalClearListbox1.IntegralHeight = False
        Me.CrystalClearListbox1.ItemHeight = 21
        Me.CrystalClearListbox1.ItemImage = Nothing
        Me.CrystalClearListbox1.Location = New System.Drawing.Point(6, 125)
        Me.CrystalClearListbox1.Name = "CrystalClearListbox1"
        Me.CrystalClearListbox1.Size = New System.Drawing.Size(323, 56)
        Me.CrystalClearListbox1.TabIndex = 191
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 103)
        Me.PictureBox1.TabIndex = 190
        Me.PictureBox1.TabStop = False
        '
        'cbUsuarios
        '
        Me.cbUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbUsuarios.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUsuarios.FormattingEnabled = True
        Me.cbUsuarios.Location = New System.Drawing.Point(137, 42)
        Me.cbUsuarios.Name = "cbUsuarios"
        Me.cbUsuarios.Size = New System.Drawing.Size(191, 27)
        Me.cbUsuarios.TabIndex = 186
        '
        'txtSenha
        '
        Me.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSenha.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(137, 91)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(191, 27)
        Me.txtSenha.TabIndex = 187
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 14)
        Me.Label2.TabIndex = 188
        Me.Label2.Text = "USUÁRIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "SENHA"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 213)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(175, 150)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MIXPDV"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsPC As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsDiv1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsIP As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsDiv2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsVersao As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdSair As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEntrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CrystalClearListbox1 As MixPDV.CrystalClearListbox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cbUsuarios As System.Windows.Forms.ComboBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
