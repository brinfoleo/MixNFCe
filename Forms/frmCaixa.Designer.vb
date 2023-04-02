<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaixa))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.lbldescricaoSuperior = New System.Windows.Forms.Label()
        Me.lblValorUnitario = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTotalGeral = New System.Windows.Forms.Label()
        Me.txtQtd = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.bsCNPJ = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bsRazao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bsLoja = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bsPDV = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bsAtivacao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bsExpira = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gpMenu = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdFinalizadores = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCliente = New DevExpress.XtraEditors.SimpleButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblCaixalivre = New System.Windows.Forms.Label()
        Me.pnCupom = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCupomLinha4 = New System.Windows.Forms.Label()
        Me.lblCupomLinha3 = New System.Windows.Forms.Label()
        Me.lblCupomLinha2 = New System.Windows.Forms.Label()
        Me.lblCupomLinha1 = New System.Windows.Forms.Label()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.un = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vlun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vltotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tmrRelogio = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnNaoCadastrado = New System.Windows.Forms.Panel()
        Me.lblNaoCadastrado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblAcesso = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.gpMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpMenu.SuspendLayout()
        Me.pnCupom.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnNaoCadastrado.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCod
        '
        Me.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCod.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.ForeColor = System.Drawing.Color.Black
        Me.txtCod.Location = New System.Drawing.Point(129, 136)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(421, 53)
        Me.txtCod.TabIndex = 0
        Me.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbldescricaoSuperior
        '
        Me.lbldescricaoSuperior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbldescricaoSuperior.BackColor = System.Drawing.Color.Transparent
        Me.lbldescricaoSuperior.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescricaoSuperior.Location = New System.Drawing.Point(144, 39)
        Me.lbldescricaoSuperior.Name = "lbldescricaoSuperior"
        Me.lbldescricaoSuperior.Size = New System.Drawing.Size(866, 57)
        Me.lbldescricaoSuperior.TabIndex = 4
        Me.lbldescricaoSuperior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValorUnitario
        '
        Me.lblValorUnitario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblValorUnitario.BackColor = System.Drawing.Color.Transparent
        Me.lblValorUnitario.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold)
        Me.lblValorUnitario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblValorUnitario.Location = New System.Drawing.Point(752, 561)
        Me.lblValorUnitario.Name = "lblValorUnitario"
        Me.lblValorUnitario.Size = New System.Drawing.Size(258, 55)
        Me.lblValorUnitario.TabIndex = 7
        Me.lblValorUnitario.Text = "R$ 0,00"
        Me.lblValorUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSubTotal.Location = New System.Drawing.Point(578, 639)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(431, 69)
        Me.lblSubTotal.TabIndex = 8
        Me.lblSubTotal.Text = "R$ 0,00"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalGeral
        '
        Me.lblTotalGeral.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalGeral.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalGeral.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGeral.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalGeral.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalGeral.Location = New System.Drawing.Point(190, 638)
        Me.lblTotalGeral.Name = "lblTotalGeral"
        Me.lblTotalGeral.Size = New System.Drawing.Size(364, 70)
        Me.lblTotalGeral.TabIndex = 9
        Me.lblTotalGeral.Text = "R$ 0,00"
        Me.lblTotalGeral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQtd
        '
        Me.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQtd.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtd.ForeColor = System.Drawing.Color.Black
        Me.txtQtd.Location = New System.Drawing.Point(581, 561)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(156, 53)
        Me.txtQtd.TabIndex = 160
        Me.txtQtd.Text = "1"
        Me.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.StatusStrip1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bsCNPJ, Me.bsRazao, Me.bsLoja, Me.bsPDV, Me.bsAtivacao, Me.bsExpira})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 746)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1024, 22)
        Me.StatusStrip1.TabIndex = 161
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'bsCNPJ
        '
        Me.bsCNPJ.Name = "bsCNPJ"
        Me.bsCNPJ.Size = New System.Drawing.Size(0, 17)
        '
        'bsRazao
        '
        Me.bsRazao.Name = "bsRazao"
        Me.bsRazao.Size = New System.Drawing.Size(0, 17)
        '
        'bsLoja
        '
        Me.bsLoja.Name = "bsLoja"
        Me.bsLoja.Size = New System.Drawing.Size(0, 17)
        '
        'bsPDV
        '
        Me.bsPDV.Name = "bsPDV"
        Me.bsPDV.Size = New System.Drawing.Size(0, 17)
        '
        'bsAtivacao
        '
        Me.bsAtivacao.Name = "bsAtivacao"
        Me.bsAtivacao.Size = New System.Drawing.Size(0, 17)
        '
        'bsExpira
        '
        Me.bsExpira.Name = "bsExpira"
        Me.bsExpira.Size = New System.Drawing.Size(0, 17)
        '
        'gpMenu
        '
        Me.gpMenu.CaptionLocation = DevExpress.Utils.Locations.Bottom
        Me.gpMenu.Controls.Add(Me.SimpleButton9)
        Me.gpMenu.Controls.Add(Me.SimpleButton8)
        Me.gpMenu.Controls.Add(Me.SimpleButton6)
        Me.gpMenu.Controls.Add(Me.cmdFinalizadores)
        Me.gpMenu.Controls.Add(Me.cmdCliente)
        Me.gpMenu.Controls.Add(Me.ShapeContainer1)
        Me.gpMenu.Location = New System.Drawing.Point(0, -95)
        Me.gpMenu.Name = "gpMenu"
        Me.gpMenu.Size = New System.Drawing.Size(1024, 96)
        Me.gpMenu.TabIndex = 165
        Me.gpMenu.Text = "MENU DO SISTEMA"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton9.Appearance.Options.UseFont = True
        Me.SimpleButton9.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton9.Image = CType(resources.GetObject("SimpleButton9.Image"), System.Drawing.Image)
        Me.SimpleButton9.Location = New System.Drawing.Point(702, 5)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(149, 67)
        Me.SimpleButton9.TabIndex = 6
        Me.SimpleButton9.Text = "Sair (Esc)"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton8.Appearance.Options.UseFont = True
        Me.SimpleButton8.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton8.Image = CType(resources.GetObject("SimpleButton8.Image"), System.Drawing.Image)
        Me.SimpleButton8.Location = New System.Drawing.Point(529, 5)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(149, 67)
        Me.SimpleButton8.TabIndex = 5
        Me.SimpleButton8.Text = "Ajuda"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(356, 5)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(149, 67)
        Me.SimpleButton6.TabIndex = 4
        Me.SimpleButton6.Text = "Configurações"
        '
        'cmdFinalizadores
        '
        Me.cmdFinalizadores.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFinalizadores.Appearance.Options.UseFont = True
        Me.cmdFinalizadores.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.cmdFinalizadores.Image = CType(resources.GetObject("cmdFinalizadores.Image"), System.Drawing.Image)
        Me.cmdFinalizadores.Location = New System.Drawing.Point(172, 5)
        Me.cmdFinalizadores.Name = "cmdFinalizadores"
        Me.cmdFinalizadores.Size = New System.Drawing.Size(167, 67)
        Me.cmdFinalizadores.TabIndex = 1
        Me.cmdFinalizadores.Text = "Recebimento"
        '
        'cmdCliente
        '
        Me.cmdCliente.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCliente.Appearance.Options.UseFont = True
        Me.cmdCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdCliente.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.cmdCliente.Image = CType(resources.GetObject("cmdCliente.Image"), System.Drawing.Image)
        Me.cmdCliente.Location = New System.Drawing.Point(5, 5)
        Me.cmdCliente.Name = "cmdCliente"
        Me.cmdCliente.Size = New System.Drawing.Size(149, 67)
        Me.cmdCliente.TabIndex = 0
        Me.cmdCliente.Text = "Clientes (F4)"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(2, 2)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1020, 73)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 511
        Me.LineShape4.X2 = 511
        Me.LineShape4.Y1 = 13
        Me.LineShape4.Y2 = 60
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 690
        Me.LineShape3.X2 = 690
        Me.LineShape3.Y1 = 13
        Me.LineShape3.Y2 = 60
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 342
        Me.LineShape2.X2 = 342
        Me.LineShape2.Y1 = 13
        Me.LineShape2.Y2 = 60
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 157
        Me.LineShape1.X2 = 157
        Me.LineShape1.Y1 = 13
        Me.LineShape1.Y2 = 60
        '
        'lblCaixalivre
        '
        Me.lblCaixalivre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCaixalivre.BackColor = System.Drawing.Color.Transparent
        Me.lblCaixalivre.Font = New System.Drawing.Font("Arial Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaixalivre.ForeColor = System.Drawing.Color.Silver
        Me.lblCaixalivre.Location = New System.Drawing.Point(17, 315)
        Me.lblCaixalivre.Name = "lblCaixalivre"
        Me.lblCaixalivre.Size = New System.Drawing.Size(548, 57)
        Me.lblCaixalivre.TabIndex = 166
        Me.lblCaixalivre.Text = "CAIXA LIVRE"
        Me.lblCaixalivre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnCupom
        '
        Me.pnCupom.BackColor = System.Drawing.Color.Transparent
        Me.pnCupom.BackgroundImage = CType(resources.GetObject("pnCupom.BackgroundImage"), System.Drawing.Image)
        Me.pnCupom.Controls.Add(Me.Panel1)
        Me.pnCupom.Controls.Add(Me.dgvProdutos)
        Me.pnCupom.Location = New System.Drawing.Point(15, 500)
        Me.pnCupom.Name = "pnCupom"
        Me.pnCupom.Size = New System.Drawing.Size(550, 20)
        Me.pnCupom.TabIndex = 169
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblCupomLinha4)
        Me.Panel1.Controls.Add(Me.lblCupomLinha3)
        Me.Panel1.Controls.Add(Me.lblCupomLinha2)
        Me.Panel1.Controls.Add(Me.lblCupomLinha1)
        Me.Panel1.Location = New System.Drawing.Point(4, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(542, 93)
        Me.Panel1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(541, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ITEM   CÓDIGO                DESCRIÇÃO                                           " & _
    "         QTD      UN    VL.UN          VL.TOTAL"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCupomLinha4
        '
        Me.lblCupomLinha4.BackColor = System.Drawing.Color.Transparent
        Me.lblCupomLinha4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCupomLinha4.Location = New System.Drawing.Point(4, 54)
        Me.lblCupomLinha4.Name = "lblCupomLinha4"
        Me.lblCupomLinha4.Size = New System.Drawing.Size(535, 23)
        Me.lblCupomLinha4.TabIndex = 3
        Me.lblCupomLinha4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCupomLinha3
        '
        Me.lblCupomLinha3.BackColor = System.Drawing.Color.Transparent
        Me.lblCupomLinha3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCupomLinha3.Location = New System.Drawing.Point(3, 36)
        Me.lblCupomLinha3.Name = "lblCupomLinha3"
        Me.lblCupomLinha3.Size = New System.Drawing.Size(535, 23)
        Me.lblCupomLinha3.TabIndex = 2
        Me.lblCupomLinha3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCupomLinha2
        '
        Me.lblCupomLinha2.BackColor = System.Drawing.Color.Transparent
        Me.lblCupomLinha2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCupomLinha2.Location = New System.Drawing.Point(4, 20)
        Me.lblCupomLinha2.Name = "lblCupomLinha2"
        Me.lblCupomLinha2.Size = New System.Drawing.Size(535, 23)
        Me.lblCupomLinha2.TabIndex = 1
        Me.lblCupomLinha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCupomLinha1
        '
        Me.lblCupomLinha1.BackColor = System.Drawing.Color.Transparent
        Me.lblCupomLinha1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCupomLinha1.Location = New System.Drawing.Point(4, 3)
        Me.lblCupomLinha1.Name = "lblCupomLinha1"
        Me.lblCupomLinha1.Size = New System.Drawing.Size(535, 23)
        Me.lblCupomLinha1.TabIndex = 0
        Me.lblCupomLinha1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AllowUserToAddRows = False
        Me.dgvProdutos.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvProdutos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvProdutos.BackgroundColor = System.Drawing.Color.White
        Me.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.ColumnHeadersVisible = False
        Me.dgvProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM, Me.Cod, Me.Descricao, Me.QTD, Me.un, Me.vlun, Me.vltotal})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProdutos.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvProdutos.GridColor = System.Drawing.Color.Black
        Me.dgvProdutos.Location = New System.Drawing.Point(4, 105)
        Me.dgvProdutos.Name = "dgvProdutos"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProdutos.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvProdutos.RowHeadersVisible = False
        Me.dgvProdutos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProdutos.Size = New System.Drawing.Size(543, 197)
        Me.dgvProdutos.TabIndex = 159
        '
        'ITEM
        '
        Me.ITEM.HeaderText = "Item"
        Me.ITEM.Name = "ITEM"
        Me.ITEM.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ITEM.Width = 40
        '
        'Cod
        '
        Me.Cod.HeaderText = "Código"
        Me.Cod.Name = "Cod"
        Me.Cod.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cod.Width = 90
        '
        'Descricao
        '
        Me.Descricao.HeaderText = "Descrição"
        Me.Descricao.Name = "Descricao"
        Me.Descricao.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Descricao.Width = 220
        '
        'QTD
        '
        Me.QTD.HeaderText = "Qtde"
        Me.QTD.Name = "QTD"
        Me.QTD.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.QTD.Width = 40
        '
        'un
        '
        Me.un.HeaderText = "Un"
        Me.un.Name = "un"
        Me.un.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.un.Width = 30
        '
        'vlun
        '
        Me.vlun.HeaderText = "Vl.Un."
        Me.vlun.Name = "vlun"
        Me.vlun.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.vlun.Width = 60
        '
        'vltotal
        '
        Me.vltotal.HeaderText = "Vl.Total"
        Me.vltotal.Name = "vltotal"
        Me.vltotal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.vltotal.Width = 60
        '
        'tmrRelogio
        '
        Me.tmrRelogio.Enabled = True
        Me.tmrRelogio.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(26, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 79)
        Me.PictureBox1.TabIndex = 170
        Me.PictureBox1.TabStop = False
        '
        'pnNaoCadastrado
        '
        Me.pnNaoCadastrado.BackColor = System.Drawing.Color.DarkRed
        Me.pnNaoCadastrado.Controls.Add(Me.lblNaoCadastrado)
        Me.pnNaoCadastrado.Location = New System.Drawing.Point(1, 320)
        Me.pnNaoCadastrado.Name = "pnNaoCadastrado"
        Me.pnNaoCadastrado.Size = New System.Drawing.Size(1024, 100)
        Me.pnNaoCadastrado.TabIndex = 171
        Me.pnNaoCadastrado.Visible = False
        '
        'lblNaoCadastrado
        '
        Me.lblNaoCadastrado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNaoCadastrado.BackColor = System.Drawing.Color.Transparent
        Me.lblNaoCadastrado.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaoCadastrado.ForeColor = System.Drawing.Color.White
        Me.lblNaoCadastrado.Location = New System.Drawing.Point(37, 17)
        Me.lblNaoCadastrado.Name = "lblNaoCadastrado"
        Me.lblNaoCadastrado.Size = New System.Drawing.Size(945, 57)
        Me.lblNaoCadastrado.TabIndex = 172
        Me.lblNaoCadastrado.Text = "PRODUTO NAO CADASTRADO"
        Me.lblNaoCadastrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 538)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 14)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "Finalizar Venda . . . . . . F1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 554)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 14)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "Delivery  . . . . . . . . . . . F2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 570)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 14)
        Me.Label3.TabIndex = 174
        Me.Label3.Text = "Venda Rápida  . . . . . . F3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 586)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 14)
        Me.Label4.TabIndex = 175
        Me.Label4.Text = "Clientes . . . . . . . . . . . F4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(189, 570)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 14)
        Me.Label6.TabIndex = 179
        Me.Label6.Text = "Sangria/Suprimento . . . .F8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(189, 554)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 14)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "Desconto . . . . . . . . . . . . F7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(189, 538)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 14)
        Me.Label8.TabIndex = 177
        Me.Label8.Text = "Cancelar Item . . . . . . . . . F6"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 602)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 14)
        Me.Label9.TabIndex = 176
        Me.Label9.Text = "Controle de Mesa  . . . F5"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(377, 587)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 14)
        Me.Label10.TabIndex = 183
        Me.Label10.Text = "Pesquisa Produto . .  Espaço"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(189, 602)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(183, 14)
        Me.Label12.TabIndex = 181
        Me.Label12.Text = "MENU. . . . . . . . . . . . . . . F10"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(189, 586)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(179, 14)
        Me.Label13.TabIndex = 180
        Me.Label13.Text = "Cancelar Cupom . . . . . . . F9"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(377, 553)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(137, 14)
        Me.Label15.TabIndex = 185
        Me.Label15.Text = "XXXXXXXXXXX . . F12"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(377, 537)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(186, 14)
        Me.Label16.TabIndex = 184
        Me.Label16.Text = "Consulta Produto  . . . . . F11"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(377, 570)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 14)
        Me.Label11.TabIndex = 182
        Me.Label11.Text = "Sair do Sistema . . . . . . . Esc"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 635)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 19)
        Me.Label14.TabIndex = 186
        Me.Label14.Text = "Total Venda"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(577, 635)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 19)
        Me.Label17.TabIndex = 187
        Me.Label17.Text = "Sub-Total"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(757, 538)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 19)
        Me.Label18.TabIndex = 188
        Me.Label18.Text = "Valor Un."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(20, 136)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(148, 19)
        Me.Label19.TabIndex = 189
        Me.Label19.Text = "Código de Barras"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(577, 539)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 19)
        Me.Label20.TabIndex = 190
        Me.Label20.Text = "Qtd."
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(16, 726)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(56, 14)
        Me.lblUsuario.TabIndex = 191
        Me.lblUsuario.Text = "Usuário:"
        '
        'lblAcesso
        '
        Me.lblAcesso.AutoSize = True
        Me.lblAcesso.BackColor = System.Drawing.Color.Transparent
        Me.lblAcesso.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcesso.ForeColor = System.Drawing.Color.White
        Me.lblAcesso.Location = New System.Drawing.Point(169, 726)
        Me.lblAcesso.Name = "lblAcesso"
        Me.lblAcesso.Size = New System.Drawing.Size(53, 14)
        Me.lblAcesso.TabIndex = 192
        Me.lblAcesso.Text = "Acesso:"
        '
        'frmCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lblAcesso)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnNaoCadastrado)
        Me.Controls.Add(Me.gpMenu)
        Me.Controls.Add(Me.pnCupom)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtQtd)
        Me.Controls.Add(Me.lblTotalGeral)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblValorUnitario)
        Me.Controls.Add(Me.lbldescricaoSuperior)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.lblCaixalivre)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.gpMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpMenu.ResumeLayout(False)
        Me.pnCupom.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnNaoCadastrado.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents lbldescricaoSuperior As System.Windows.Forms.Label
    Friend WithEvents lblValorUnitario As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalGeral As System.Windows.Forms.Label
    Friend WithEvents txtQtd As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents gpMenu As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblCaixalivre As System.Windows.Forms.Label
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdFinalizadores As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents bsCNPJ As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bsRazao As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bsLoja As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bsPDV As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bsAtivacao As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bsExpira As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnCupom As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCupomLinha1 As System.Windows.Forms.Label
    Friend WithEvents lblCupomLinha2 As System.Windows.Forms.Label
    Friend WithEvents lblCupomLinha3 As System.Windows.Forms.Label
    Friend WithEvents lblCupomLinha4 As System.Windows.Forms.Label
    Friend WithEvents dgvProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descricao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents un As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vlun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vltotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tmrRelogio As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnNaoCadastrado As System.Windows.Forms.Panel
    Friend WithEvents lblNaoCadastrado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblAcesso As System.Windows.Forms.Label

End Class
