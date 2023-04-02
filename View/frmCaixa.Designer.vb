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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.lblCaixalivre = New System.Windows.Forms.Label()
        Me.pnCupom = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCupomLinha4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCupomLinha3 = New System.Windows.Forms.Label()
        Me.lblCupomLinha2 = New System.Windows.Forms.Label()
        Me.lblCupomLinha1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.un = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vlun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vltotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tmrRelogio = New System.Windows.Forms.Timer(Me.components)
        Me.PC_System = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblAcesso = New System.Windows.Forms.Label()
        Me.lblVersao = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.PC_Loja = New System.Windows.Forms.PictureBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.pnCupom.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PC_System, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PC_Loja, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnCupom.Location = New System.Drawing.Point(15, 402)
        Me.pnCupom.Name = "pnCupom"
        Me.pnCupom.Size = New System.Drawing.Size(550, 118)
        Me.pnCupom.TabIndex = 169
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblCupomLinha4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblCupomLinha3)
        Me.Panel1.Controls.Add(Me.lblCupomLinha2)
        Me.Panel1.Controls.Add(Me.lblCupomLinha1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(4, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(542, 93)
        Me.Panel1.TabIndex = 1
        '
        'lblCupomLinha4
        '
        Me.lblCupomLinha4.BackColor = System.Drawing.Color.Transparent
        Me.lblCupomLinha4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCupomLinha4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCupomLinha4.Location = New System.Drawing.Point(135, 54)
        Me.lblCupomLinha4.Name = "lblCupomLinha4"
        Me.lblCupomLinha4.Size = New System.Drawing.Size(404, 14)
        Me.lblCupomLinha4.TabIndex = 3
        Me.lblCupomLinha4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
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
        'lblCupomLinha3
        '
        Me.lblCupomLinha3.BackColor = System.Drawing.Color.Transparent
        Me.lblCupomLinha3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCupomLinha3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCupomLinha3.Location = New System.Drawing.Point(135, 36)
        Me.lblCupomLinha3.Name = "lblCupomLinha3"
        Me.lblCupomLinha3.Size = New System.Drawing.Size(404, 20)
        Me.lblCupomLinha3.TabIndex = 2
        Me.lblCupomLinha3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCupomLinha2
        '
        Me.lblCupomLinha2.BackColor = System.Drawing.Color.Transparent
        Me.lblCupomLinha2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCupomLinha2.Location = New System.Drawing.Point(135, 20)
        Me.lblCupomLinha2.Name = "lblCupomLinha2"
        Me.lblCupomLinha2.Size = New System.Drawing.Size(405, 22)
        Me.lblCupomLinha2.TabIndex = 1
        Me.lblCupomLinha2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCupomLinha1
        '
        Me.lblCupomLinha1.BackColor = System.Drawing.Color.Transparent
        Me.lblCupomLinha1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCupomLinha1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCupomLinha1.Location = New System.Drawing.Point(135, 5)
        Me.lblCupomLinha1.Name = "lblCupomLinha1"
        Me.lblCupomLinha1.Size = New System.Drawing.Size(404, 19)
        Me.lblCupomLinha1.TabIndex = 0
        Me.lblCupomLinha1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(542, 93)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 4
        Me.LineShape1.X2 = 547
        Me.LineShape1.Y1 = 73
        Me.LineShape1.Y2 = 73
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AllowUserToAddRows = False
        Me.dgvProdutos.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvProdutos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProdutos.BackgroundColor = System.Drawing.Color.White
        Me.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.ColumnHeadersVisible = False
        Me.dgvProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM, Me.Cod, Me.Descricao, Me.QTD, Me.un, Me.vlun, Me.vltotal})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProdutos.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvProdutos.GridColor = System.Drawing.Color.Black
        Me.dgvProdutos.Location = New System.Drawing.Point(4, 105)
        Me.dgvProdutos.Name = "dgvProdutos"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProdutos.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
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
        'PC_System
        '
        Me.PC_System.BackColor = System.Drawing.Color.Transparent
        Me.PC_System.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PC_System.Location = New System.Drawing.Point(16, 13)
        Me.PC_System.Name = "PC_System"
        Me.PC_System.Size = New System.Drawing.Size(122, 109)
        Me.PC_System.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PC_System.TabIndex = 170
        Me.PC_System.TabStop = False
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
        'lblVersao
        '
        Me.lblVersao.BackColor = System.Drawing.Color.Transparent
        Me.lblVersao.ForeColor = System.Drawing.Color.Yellow
        Me.lblVersao.Location = New System.Drawing.Point(929, 726)
        Me.lblVersao.Name = "lblVersao"
        Me.lblVersao.Size = New System.Drawing.Size(82, 16)
        Me.lblVersao.TabIndex = 193
        Me.lblVersao.Text = "Versão: 0.0.000"
        '
        'lblCliente
        '
        Me.lblCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCliente.Location = New System.Drawing.Point(572, 725)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(315, 16)
        Me.lblCliente.TabIndex = 194
        '
        'PC_Loja
        '
        Me.PC_Loja.BackColor = System.Drawing.Color.Transparent
        Me.PC_Loja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PC_Loja.Location = New System.Drawing.Point(575, 134)
        Me.PC_Loja.Name = "PC_Loja"
        Me.PC_Loja.Size = New System.Drawing.Size(434, 386)
        Me.PC_Loja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PC_Loja.TabIndex = 195
        Me.PC_Loja.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(18, 538)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(179, 78)
        Me.SimpleButton1.TabIndex = 197
        Me.SimpleButton1.Text = "Dinheiro(F5)"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.White
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(200, 538)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(179, 78)
        Me.SimpleButton2.TabIndex = 198
        Me.SimpleButton2.Text = "Cartão " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Crédito(F6)"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.ForeColor = System.Drawing.Color.White
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Appearance.Options.UseForeColor = True
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(382, 538)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(179, 78)
        Me.SimpleButton3.TabIndex = 199
        Me.SimpleButton3.Text = "Cartão " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Débito(F7)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(377, 571)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 14)
        Me.Label10.TabIndex = 196
        Me.Label10.Text = "P - Peso da balanca"
        '
        'frmCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PC_Loja)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblVersao)
        Me.Controls.Add(Me.lblAcesso)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.pnCupom)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtQtd)
        Me.Controls.Add(Me.lblTotalGeral)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblValorUnitario)
        Me.Controls.Add(Me.lbldescricaoSuperior)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.lblCaixalivre)
        Me.Controls.Add(Me.PC_System)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnCupom.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PC_System, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PC_Loja, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblCaixalivre As System.Windows.Forms.Label
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
    Friend WithEvents PC_System As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblAcesso As System.Windows.Forms.Label
    Friend WithEvents lblVersao As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents PC_Loja As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton

    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
