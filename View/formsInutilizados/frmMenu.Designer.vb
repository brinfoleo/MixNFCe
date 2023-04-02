<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.cmdCadastroProduto = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSair = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCliente = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'cmdCadastroProduto
        '
        Me.cmdCadastroProduto.Location = New System.Drawing.Point(12, 12)
        Me.cmdCadastroProduto.Name = "cmdCadastroProduto"
        Me.cmdCadastroProduto.Size = New System.Drawing.Size(254, 45)
        Me.cmdCadastroProduto.TabIndex = 0
        Me.cmdCadastroProduto.Text = "Cadastro de Produto"
        '
        'cmdSair
        '
        Me.cmdSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSair.Location = New System.Drawing.Point(12, 333)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(254, 45)
        Me.cmdSair.TabIndex = 1
        Me.cmdSair.Text = "Sair"
        '
        'cmdCliente
        '
        Me.cmdCliente.Location = New System.Drawing.Point(12, 63)
        Me.cmdCliente.Name = "cmdCliente"
        Me.cmdCliente.Size = New System.Drawing.Size(254, 45)
        Me.cmdCliente.TabIndex = 2
        Me.cmdCliente.Text = "Cadastro de Cliente"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 278)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(254, 45)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Atualiza Database"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 114)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(254, 45)
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "Cadastro de Usuário"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(12, 173)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(254, 45)
        Me.SimpleButton3.TabIndex = 5
        Me.SimpleButton3.Text = "Pesquisa"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(12, 224)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(254, 45)
        Me.SimpleButton4.TabIndex = 6
        Me.SimpleButton4.Text = "Relatorio Gerencial"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSair
        Me.ClientSize = New System.Drawing.Size(278, 390)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmdCliente)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdCadastroProduto)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCadastroProduto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSair As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
End Class
