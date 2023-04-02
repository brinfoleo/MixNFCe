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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cmdSair = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGravar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdLimpar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExcluir = New DevExpress.XtraEditors.SimpleButton()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.txtVenda = New System.Windows.Forms.TextBox()
        Me.txtCusto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFabricante = New System.Windows.Forms.TextBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.cboCFOP = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboCST = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboOrigem = New System.Windows.Forms.ComboBox()
        Me.txtCOFINS = New System.Windows.Forms.TextBox()
        Me.txtPIS = New System.Windows.Forms.TextBox()
        Me.txtICMS = New System.Windows.Forms.TextBox()
        Me.txtNCM = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cmdSair)
        Me.GroupControl1.Controls.Add(Me.cmdGravar)
        Me.GroupControl1.Controls.Add(Me.cmdLimpar)
        Me.GroupControl1.Controls.Add(Me.cmdExcluir)
        Me.GroupControl1.Controls.Add(Me.TabControl2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(572, 445)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Cadastro de Produtos"
        '
        'cmdSair
        '
        Me.cmdSair.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmdSair.Image = CType(resources.GetObject("cmdSair.Image"), System.Drawing.Image)
        Me.cmdSair.Location = New System.Drawing.Point(68, 383)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(118, 47)
        Me.cmdSair.TabIndex = 192
        Me.cmdSair.Text = "&Sair"
        '
        'cmdGravar
        '
        Me.cmdGravar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmdGravar.Image = CType(resources.GetObject("cmdGravar.Image"), System.Drawing.Image)
        Me.cmdGravar.Location = New System.Drawing.Point(194, 383)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(118, 47)
        Me.cmdGravar.TabIndex = 189
        Me.cmdGravar.Text = "&Gravar"
        '
        'cmdLimpar
        '
        Me.cmdLimpar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmdLimpar.Image = CType(resources.GetObject("cmdLimpar.Image"), System.Drawing.Image)
        Me.cmdLimpar.Location = New System.Drawing.Point(444, 383)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(116, 47)
        Me.cmdLimpar.TabIndex = 188
        Me.cmdLimpar.Text = "&Limpar"
        '
        'cmdExcluir
        '
        Me.cmdExcluir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmdExcluir.Image = CType(resources.GetObject("cmdExcluir.Image"), System.Drawing.Image)
        Me.cmdExcluir.Location = New System.Drawing.Point(320, 383)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(116, 47)
        Me.cmdExcluir.TabIndex = 190
        Me.cmdExcluir.Text = "&Excluir"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(5, 24)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(558, 353)
        Me.TabControl2.TabIndex = 191
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TabControl1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(550, 326)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Principal"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(6, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(540, 317)
        Me.TabControl1.TabIndex = 179
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.GroupControl2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(532, 291)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Cadastrais"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.GroupControl4)
        Me.GroupControl2.Controls.Add(Me.txtCodigoBarras)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.txtFabricante)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.txtQuantidade)
        Me.GroupControl2.Controls.Add(Me.txtUnidade)
        Me.GroupControl2.Controls.Add(Me.Label10)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.txtDescricao)
        Me.GroupControl2.Controls.Add(Me.txtId)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(526, 285)
        Me.GroupControl2.TabIndex = 173
        Me.GroupControl2.Text = "Informações do Produto"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.txtVenda)
        Me.GroupControl4.Controls.Add(Me.txtCusto)
        Me.GroupControl4.Controls.Add(Me.Label4)
        Me.GroupControl4.Controls.Add(Me.Label5)
        Me.GroupControl4.Location = New System.Drawing.Point(253, 179)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(253, 87)
        Me.GroupControl4.TabIndex = 17
        Me.GroupControl4.Text = "Precificação"
        '
        'txtVenda
        '
        Me.txtVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVenda.ForeColor = System.Drawing.Color.Blue
        Me.txtVenda.Location = New System.Drawing.Point(131, 49)
        Me.txtVenda.MaxLength = 15
        Me.txtVenda.Name = "txtVenda"
        Me.txtVenda.Size = New System.Drawing.Size(112, 23)
        Me.txtVenda.TabIndex = 21
        '
        'txtCusto
        '
        Me.txtCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCusto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusto.ForeColor = System.Drawing.Color.Red
        Me.txtCusto.Location = New System.Drawing.Point(13, 49)
        Me.txtCusto.MaxLength = 15
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Size = New System.Drawing.Size(112, 23)
        Me.txtCusto.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Preço de Custo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(131, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Preço de Venda"
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoBarras.Location = New System.Drawing.Point(109, 48)
        Me.txtCodigoBarras.MaxLength = 14
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(195, 20)
        Me.txtCodigoBarras.TabIndex = 15
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(108, 32)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(161, 15)
        Me.LabelControl4.TabIndex = 14
        Me.LabelControl4.Text = "Código de Barras (EAN/GTIN)"
        '
        'txtFabricante
        '
        Me.txtFabricante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFabricante.Location = New System.Drawing.Point(11, 141)
        Me.txtFabricante.MaxLength = 60
        Me.txtFabricante.Name = "txtFabricante"
        Me.txtFabricante.Size = New System.Drawing.Size(495, 20)
        Me.txtFabricante.TabIndex = 13
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(11, 122)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 15)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "Fabricante"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantidade.Location = New System.Drawing.Point(11, 244)
        Me.txtQuantidade.MaxLength = 15
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(214, 20)
        Me.txtQuantidade.TabIndex = 11
        '
        'txtUnidade
        '
        Me.txtUnidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnidade.Location = New System.Drawing.Point(11, 197)
        Me.txtUnidade.MaxLength = 3
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.Size = New System.Drawing.Size(214, 20)
        Me.txtUnidade.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Quantidade em Estoque"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Unidade"
        '
        'txtDescricao
        '
        Me.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescricao.Location = New System.Drawing.Point(11, 97)
        Me.txtDescricao.MaxLength = 60
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(495, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Location = New System.Drawing.Point(11, 48)
        Me.txtId.MaxLength = 10
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(79, 20)
        Me.txtId.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(11, 78)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 15)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Descrição"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(11, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 15)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.GroupControl3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(532, 291)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dados Fiscais"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.cboCFOP)
        Me.GroupControl3.Controls.Add(Me.Label12)
        Me.GroupControl3.Controls.Add(Me.cboCST)
        Me.GroupControl3.Controls.Add(Me.Label11)
        Me.GroupControl3.Controls.Add(Me.cboOrigem)
        Me.GroupControl3.Controls.Add(Me.txtCOFINS)
        Me.GroupControl3.Controls.Add(Me.txtPIS)
        Me.GroupControl3.Controls.Add(Me.txtICMS)
        Me.GroupControl3.Controls.Add(Me.txtNCM)
        Me.GroupControl3.Controls.Add(Me.Label8)
        Me.GroupControl3.Controls.Add(Me.Label9)
        Me.GroupControl3.Controls.Add(Me.Label6)
        Me.GroupControl3.Controls.Add(Me.Label2)
        Me.GroupControl3.Controls.Add(Me.Label1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(526, 285)
        Me.GroupControl3.TabIndex = 11
        Me.GroupControl3.Text = "Informações Fiscais"
        '
        'cboCFOP
        '
        Me.cboCFOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCFOP.FormattingEnabled = True
        Me.cboCFOP.Location = New System.Drawing.Point(6, 188)
        Me.cboCFOP.Name = "cboCFOP"
        Me.cboCFOP.Size = New System.Drawing.Size(515, 21)
        Me.cboCFOP.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "CFOP"
        '
        'cboCST
        '
        Me.cboCST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCST.FormattingEnabled = True
        Me.cboCST.Location = New System.Drawing.Point(6, 139)
        Me.cboCST.Name = "cboCST"
        Me.cboCST.Size = New System.Drawing.Size(515, 21)
        Me.cboCST.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "CST/CSOSN"
        '
        'cboOrigem
        '
        Me.cboOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrigem.FormattingEnabled = True
        Me.cboOrigem.Location = New System.Drawing.Point(6, 91)
        Me.cboOrigem.Name = "cboOrigem"
        Me.cboOrigem.Size = New System.Drawing.Size(515, 21)
        Me.cboOrigem.TabIndex = 36
        '
        'txtCOFINS
        '
        Me.txtCOFINS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCOFINS.Location = New System.Drawing.Point(213, 44)
        Me.txtCOFINS.MaxLength = 6
        Me.txtCOFINS.Name = "txtCOFINS"
        Me.txtCOFINS.Size = New System.Drawing.Size(63, 20)
        Me.txtCOFINS.TabIndex = 35
        '
        'txtPIS
        '
        Me.txtPIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPIS.Location = New System.Drawing.Point(144, 44)
        Me.txtPIS.MaxLength = 6
        Me.txtPIS.Name = "txtPIS"
        Me.txtPIS.Size = New System.Drawing.Size(63, 20)
        Me.txtPIS.TabIndex = 34
        '
        'txtICMS
        '
        Me.txtICMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtICMS.Location = New System.Drawing.Point(78, 44)
        Me.txtICMS.MaxLength = 6
        Me.txtICMS.Name = "txtICMS"
        Me.txtICMS.Size = New System.Drawing.Size(63, 20)
        Me.txtICMS.TabIndex = 33
        '
        'txtNCM
        '
        Me.txtNCM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNCM.Location = New System.Drawing.Point(6, 44)
        Me.txtNCM.MaxLength = 8
        Me.txtNCM.Name = "txtNCM"
        Me.txtNCM.Size = New System.Drawing.Size(63, 20)
        Me.txtNCM.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(213, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "COFINS (%)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(144, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "PIS (%)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "ICMS (%)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "ORIGEM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "NCM"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupControl5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(550, 326)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Pesquisa"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupControl5
        '
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.Controls.Add(Me.GroupControl6)
        Me.GroupControl5.Controls.Add(Me.txtPesquisa)
        Me.GroupControl5.Controls.Add(Me.Label7)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(544, 320)
        Me.GroupControl5.TabIndex = 177
        Me.GroupControl5.Text = "Listagem de Produtos"
        '
        'GroupControl6
        '
        Me.GroupControl6.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl6.AppearanceCaption.Options.UseFont = True
        Me.GroupControl6.Controls.Add(Me.dgvProdutos)
        Me.GroupControl6.Location = New System.Drawing.Point(9, 63)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(529, 252)
        Me.GroupControl6.TabIndex = 184
        Me.GroupControl6.Text = "&Listagem de Clientes"
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AllowUserToAddRows = False
        Me.dgvProdutos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProdutos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProdutos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProdutos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProdutos.GridColor = System.Drawing.Color.Black
        Me.dgvProdutos.Location = New System.Drawing.Point(2, 21)
        Me.dgvProdutos.Name = "dgvProdutos"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProdutos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProdutos.Size = New System.Drawing.Size(525, 229)
        Me.dgvProdutos.TabIndex = 182
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPesquisa.Location = New System.Drawing.Point(7, 37)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(532, 20)
        Me.txtPesquisa.TabIndex = 183
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(7, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 182
        Me.Label7.Text = "Pesquisa:"
        '
        'frmProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 445)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(175, 150)
        Me.Name = "frmProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MIXPDV"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdSair As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGravar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdLimpar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExcluir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtVenda As System.Windows.Forms.TextBox
    Friend WithEvents txtCusto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoBarras As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFabricante As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidade As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboCFOP As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboCST As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboOrigem As System.Windows.Forms.ComboBox
    Friend WithEvents txtCOFINS As System.Windows.Forms.TextBox
    Friend WithEvents txtPIS As System.Windows.Forms.TextBox
    Friend WithEvents txtICMS As System.Windows.Forms.TextBox
    Friend WithEvents txtNCM As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
