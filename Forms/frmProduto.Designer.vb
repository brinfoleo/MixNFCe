<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduto))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkInativo = New DevExpress.XtraEditors.CheckEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.txtNCM = New System.Windows.Forms.TextBox()
        Me.txtCST = New System.Windows.Forms.TextBox()
        Me.txtCusto = New System.Windows.Forms.TextBox()
        Me.txtVenda = New System.Windows.Forms.TextBox()
        Me.txtICMS = New System.Windows.Forms.TextBox()
        Me.txtIPI = New System.Windows.Forms.TextBox()
        Me.txtCOFINS = New System.Windows.Forms.TextBox()
        Me.txtPIS = New System.Windows.Forms.TextBox()
        Me.cmdLimpar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExcluir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPesquisar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGravar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFabricante = New System.Windows.Forms.TextBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.chkInativo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 265)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 66)
        Me.PictureBox1.TabIndex = 171
        Me.PictureBox1.TabStop = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtFabricante)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtQuantidade)
        Me.GroupControl1.Controls.Add(Me.txtUnidade)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.chkInativo)
        Me.GroupControl1.Controls.Add(Me.GroupBox1)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.txtDescricao)
        Me.GroupControl1.Controls.Add(Me.txtId)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(644, 247)
        Me.GroupControl1.TabIndex = 172
        Me.GroupControl1.Text = "Produto"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(12, 97)
        Me.txtDescricao.MaxLength = 60
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(293, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(13, 48)
        Me.txtId.MaxLength = 10
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(120, 20)
        Me.txtId.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 78)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Descrição"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Unidade"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCOFINS)
        Me.GroupBox1.Controls.Add(Me.txtPIS)
        Me.GroupBox1.Controls.Add(Me.txtIPI)
        Me.GroupBox1.Controls.Add(Me.txtICMS)
        Me.GroupBox1.Controls.Add(Me.txtVenda)
        Me.GroupBox1.Controls.Add(Me.txtCusto)
        Me.GroupBox1.Controls.Add(Me.txtCST)
        Me.GroupBox1.Controls.Add(Me.txtNCM)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(311, 32)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 200)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações Comerciais/Fiscais"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CST/CSOSN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NCM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Preço de Custo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(169, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Preço de Venda"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(122, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ICMS (%)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "IPI (%)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(205, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "COFINS (%)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(207, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "PIS (%)"
        '
        'chkInativo
        '
        Me.chkInativo.Location = New System.Drawing.Point(9, 223)
        Me.chkInativo.Name = "chkInativo"
        Me.chkInativo.Properties.Caption = "Inativo"
        Me.chkInativo.Size = New System.Drawing.Size(83, 19)
        Me.chkInativo.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(86, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Quantidade em Estoque"
        '
        'txtUnidade
        '
        Me.txtUnidade.Location = New System.Drawing.Point(12, 197)
        Me.txtUnidade.MaxLength = 3
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.Size = New System.Drawing.Size(64, 20)
        Me.txtUnidade.TabIndex = 10
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(89, 197)
        Me.txtQuantidade.MaxLength = 15
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(116, 20)
        Me.txtQuantidade.TabIndex = 11
        '
        'txtNCM
        '
        Me.txtNCM.Location = New System.Drawing.Point(16, 46)
        Me.txtNCM.MaxLength = 8
        Me.txtNCM.Name = "txtNCM"
        Me.txtNCM.Size = New System.Drawing.Size(89, 20)
        Me.txtNCM.TabIndex = 14
        '
        'txtCST
        '
        Me.txtCST.Location = New System.Drawing.Point(16, 95)
        Me.txtCST.MaxLength = 5
        Me.txtCST.Name = "txtCST"
        Me.txtCST.Size = New System.Drawing.Size(86, 20)
        Me.txtCST.TabIndex = 15
        '
        'txtCusto
        '
        Me.txtCusto.Location = New System.Drawing.Point(16, 165)
        Me.txtCusto.MaxLength = 15
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Size = New System.Drawing.Size(124, 20)
        Me.txtCusto.TabIndex = 16
        '
        'txtVenda
        '
        Me.txtVenda.Location = New System.Drawing.Point(168, 165)
        Me.txtVenda.MaxLength = 15
        Me.txtVenda.Name = "txtVenda"
        Me.txtVenda.Size = New System.Drawing.Size(124, 20)
        Me.txtVenda.TabIndex = 17
        '
        'txtICMS
        '
        Me.txtICMS.Location = New System.Drawing.Point(125, 46)
        Me.txtICMS.MaxLength = 6
        Me.txtICMS.Name = "txtICMS"
        Me.txtICMS.Size = New System.Drawing.Size(68, 20)
        Me.txtICMS.TabIndex = 18
        '
        'txtIPI
        '
        Me.txtIPI.Location = New System.Drawing.Point(123, 95)
        Me.txtIPI.MaxLength = 6
        Me.txtIPI.Name = "txtIPI"
        Me.txtIPI.Size = New System.Drawing.Size(68, 20)
        Me.txtIPI.TabIndex = 19
        '
        'txtCOFINS
        '
        Me.txtCOFINS.Location = New System.Drawing.Point(208, 95)
        Me.txtCOFINS.MaxLength = 6
        Me.txtCOFINS.Name = "txtCOFINS"
        Me.txtCOFINS.Size = New System.Drawing.Size(68, 20)
        Me.txtCOFINS.TabIndex = 21
        '
        'txtPIS
        '
        Me.txtPIS.Location = New System.Drawing.Point(210, 46)
        Me.txtPIS.MaxLength = 6
        Me.txtPIS.Name = "txtPIS"
        Me.txtPIS.Size = New System.Drawing.Size(68, 20)
        Me.txtPIS.TabIndex = 20
        '
        'cmdLimpar
        '
        Me.cmdLimpar.Image = CType(resources.GetObject("cmdLimpar.Image"), System.Drawing.Image)
        Me.cmdLimpar.Location = New System.Drawing.Point(539, 272)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(115, 59)
        Me.cmdLimpar.TabIndex = 173
        Me.cmdLimpar.Text = "&Limpar"
        '
        'cmdExcluir
        '
        Me.cmdExcluir.Image = CType(resources.GetObject("cmdExcluir.Image"), System.Drawing.Image)
        Me.cmdExcluir.Location = New System.Drawing.Point(418, 272)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(115, 59)
        Me.cmdExcluir.TabIndex = 176
        Me.cmdExcluir.Text = "&Excluir"
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.Image = CType(resources.GetObject("cmdPesquisar.Image"), System.Drawing.Image)
        Me.cmdPesquisar.Location = New System.Drawing.Point(297, 272)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(115, 59)
        Me.cmdPesquisar.TabIndex = 175
        Me.cmdPesquisar.Text = "&Pesquisar"
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = CType(resources.GetObject("cmdGravar.Image"), System.Drawing.Image)
        Me.cmdGravar.Location = New System.Drawing.Point(174, 272)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(117, 59)
        Me.cmdGravar.TabIndex = 174
        Me.cmdGravar.Text = "&Gravar"
        '
        'txtFabricante
        '
        Me.txtFabricante.Location = New System.Drawing.Point(11, 141)
        Me.txtFabricante.MaxLength = 60
        Me.txtFabricante.Name = "txtFabricante"
        Me.txtFabricante.Size = New System.Drawing.Size(293, 20)
        Me.txtFabricante.TabIndex = 13
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(11, 122)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "Fabricante"
        '
        'formProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 337)
        Me.Controls.Add(Me.cmdExcluir)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdLimpar)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.chkInativo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkInativo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidade As System.Windows.Forms.TextBox
    Friend WithEvents txtCOFINS As System.Windows.Forms.TextBox
    Friend WithEvents txtPIS As System.Windows.Forms.TextBox
    Friend WithEvents txtIPI As System.Windows.Forms.TextBox
    Friend WithEvents txtICMS As System.Windows.Forms.TextBox
    Friend WithEvents txtVenda As System.Windows.Forms.TextBox
    Friend WithEvents txtCusto As System.Windows.Forms.TextBox
    Friend WithEvents txtCST As System.Windows.Forms.TextBox
    Friend WithEvents txtNCM As System.Windows.Forms.TextBox
    Friend WithEvents cmdLimpar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExcluir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPesquisar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGravar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFabricante As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
