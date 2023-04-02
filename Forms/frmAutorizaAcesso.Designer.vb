<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutorizaAcesso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutorizaAcesso))
        Me.cbUsuarios = New System.Windows.Forms.ComboBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.pcbAberto = New System.Windows.Forms.PictureBox()
        Me.pcbFechado = New System.Windows.Forms.PictureBox()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.pcbAberto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbFechado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbUsuarios
        '
        Me.cbUsuarios.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbUsuarios.FormattingEnabled = True
        Me.cbUsuarios.Location = New System.Drawing.Point(131, 43)
        Me.cbUsuarios.Name = "cbUsuarios"
        Me.cbUsuarios.Size = New System.Drawing.Size(186, 24)
        Me.cbUsuarios.TabIndex = 10
        '
        'txtSenha
        '
        Me.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSenha.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(131, 89)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtSenha.Size = New System.Drawing.Size(186, 23)
        Me.txtSenha.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 14)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "USUÁRIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "SENHA"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.pcbAberto)
        Me.GroupControl1.Controls.Add(Me.pcbFechado)
        Me.GroupControl1.Controls.Add(Me.cbUsuarios)
        Me.GroupControl1.Controls.Add(Me.txtSenha)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(329, 131)
        Me.GroupControl1.TabIndex = 14
        Me.GroupControl1.Text = "Senha Solicitada"
        '
        'pcbAberto
        '
        Me.pcbAberto.BackgroundImage = CType(resources.GetObject("pcbAberto.BackgroundImage"), System.Drawing.Image)
        Me.pcbAberto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbAberto.Location = New System.Drawing.Point(24, 43)
        Me.pcbAberto.Name = "pcbAberto"
        Me.pcbAberto.Size = New System.Drawing.Size(79, 69)
        Me.pcbAberto.TabIndex = 15
        Me.pcbAberto.TabStop = False
        Me.pcbAberto.Visible = False
        '
        'pcbFechado
        '
        Me.pcbFechado.BackgroundImage = CType(resources.GetObject("pcbFechado.BackgroundImage"), System.Drawing.Image)
        Me.pcbFechado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbFechado.Location = New System.Drawing.Point(24, 43)
        Me.pcbFechado.Name = "pcbFechado"
        Me.pcbFechado.Size = New System.Drawing.Size(79, 69)
        Me.pcbFechado.TabIndex = 14
        Me.pcbFechado.TabStop = False
        '
        'frmAutorizaAcesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 134)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAutorizaAcesso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mix NFCe -Autorização"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.pcbAberto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbFechado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbUsuarios As System.Windows.Forms.ComboBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pcbAberto As System.Windows.Forms.PictureBox
    Friend WithEvents pcbFechado As System.Windows.Forms.PictureBox
End Class
