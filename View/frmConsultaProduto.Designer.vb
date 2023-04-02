<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaProduto))
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblPrecoVenda = New System.Windows.Forms.Label()
        Me.txtCodProduto = New System.Windows.Forms.TextBox()
        Me.lblNaocadastrado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDescricao
        '
        Me.lblDescricao.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescricao.BackColor = System.Drawing.Color.Transparent
        Me.lblDescricao.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescricao.ForeColor = System.Drawing.Color.White
        Me.lblDescricao.Location = New System.Drawing.Point(0, 239)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(1024, 78)
        Me.lblDescricao.TabIndex = 174
        Me.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrecoVenda
        '
        Me.lblPrecoVenda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrecoVenda.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecoVenda.Font = New System.Drawing.Font("Arial Black", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecoVenda.ForeColor = System.Drawing.Color.Maroon
        Me.lblPrecoVenda.Location = New System.Drawing.Point(0, 351)
        Me.lblPrecoVenda.Name = "lblPrecoVenda"
        Me.lblPrecoVenda.Size = New System.Drawing.Size(1024, 172)
        Me.lblPrecoVenda.TabIndex = 175
        Me.lblPrecoVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodProduto
        '
        Me.txtCodProduto.Location = New System.Drawing.Point(84, -28)
        Me.txtCodProduto.Name = "txtCodProduto"
        Me.txtCodProduto.Size = New System.Drawing.Size(170, 20)
        Me.txtCodProduto.TabIndex = 176
        '
        'lblNaocadastrado
        '
        Me.lblNaocadastrado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNaocadastrado.BackColor = System.Drawing.Color.Transparent
        Me.lblNaocadastrado.Font = New System.Drawing.Font("Arial Black", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblNaocadastrado.ForeColor = System.Drawing.Color.Maroon
        Me.lblNaocadastrado.Location = New System.Drawing.Point(23, 302)
        Me.lblNaocadastrado.Name = "lblNaocadastrado"
        Me.lblNaocadastrado.Size = New System.Drawing.Size(977, 166)
        Me.lblNaocadastrado.TabIndex = 177
        Me.lblNaocadastrado.Text = "PRODUTO NÃO CADASTRADO"
        Me.lblNaocadastrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNaocadastrado.Visible = False
        '
        'frmConsultaProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lblNaocadastrado)
        Me.Controls.Add(Me.txtCodProduto)
        Me.Controls.Add(Me.lblPrecoVenda)
        Me.Controls.Add(Me.lblDescricao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultaProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaProduto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblPrecoVenda As System.Windows.Forms.Label
    Friend WithEvents txtCodProduto As System.Windows.Forms.TextBox
    Friend WithEvents lblNaocadastrado As System.Windows.Forms.Label
End Class
