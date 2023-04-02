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
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 390)
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
End Class
