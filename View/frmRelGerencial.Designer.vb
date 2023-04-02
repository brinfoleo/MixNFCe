<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelGerencial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelGerencial))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lblObsImpressao = New System.Windows.Forms.Label()
        Me.txtFinal = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabFechamento = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grdVendas = New System.Windows.Forms.DataGridView()
        Me.grdVendasPorFormaDePagamento = New System.Windows.Forms.DataGridView()
        Me.rtbVendas = New System.Windows.Forms.RichTextBox()
        Me.tabStatusNFCe = New System.Windows.Forms.TabPage()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.rbI = New System.Windows.Forms.RadioButton()
        Me.rbC = New System.Windows.Forms.RadioButton()
        Me.rbA = New System.Windows.Forms.RadioButton()
        Me.rbT = New System.Windows.Forms.RadioButton()
        Me.lblStatusQtd = New System.Windows.Forms.Label()
        Me.dgvSituacaoNFCe = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdFechar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnListar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtInicial = New System.Windows.Forms.DateTimePicker()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cbousuarios = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabFechamento.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.grdVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdVendasPorFormaDePagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabStatusNFCe.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dgvSituacaoNFCe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lblObsImpressao)
        Me.GroupControl1.Controls.Add(Me.txtFinal)
        Me.GroupControl1.Controls.Add(Me.TabControl1)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.cmdFechar)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.btnListar)
        Me.GroupControl1.Controls.Add(Me.txtInicial)
        Me.GroupControl1.Controls.Add(Me.btnImprimir)
        Me.GroupControl1.Controls.Add(Me.cbousuarios)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(610, 562)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Relatório Gerencial "
        '
        'lblObsImpressao
        '
        Me.lblObsImpressao.AutoSize = True
        Me.lblObsImpressao.BackColor = System.Drawing.Color.Transparent
        Me.lblObsImpressao.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObsImpressao.ForeColor = System.Drawing.Color.Black
        Me.lblObsImpressao.Location = New System.Drawing.Point(329, 3)
        Me.lblObsImpressao.Name = "lblObsImpressao"
        Me.lblObsImpressao.Size = New System.Drawing.Size(283, 13)
        Me.lblObsImpressao.TabIndex = 137
        Me.lblObsImpressao.Text = "(Selecione a nota e tecle enter para imprimir segunda via)"
        Me.lblObsImpressao.Visible = False
        '
        'txtFinal
        '
        Me.txtFinal.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFinal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtFinal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFinal.Location = New System.Drawing.Point(464, 39)
        Me.txtFinal.MinDate = New Date(2009, 1, 1, 0, 0, 0, 0)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(124, 26)
        Me.txtFinal.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabFechamento)
        Me.TabControl1.Controls.Add(Me.tabStatusNFCe)
        Me.TabControl1.Location = New System.Drawing.Point(10, 71)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(591, 412)
        Me.TabControl1.TabIndex = 138
        '
        'tabFechamento
        '
        Me.tabFechamento.Controls.Add(Me.Panel2)
        Me.tabFechamento.Location = New System.Drawing.Point(4, 22)
        Me.tabFechamento.Name = "tabFechamento"
        Me.tabFechamento.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFechamento.Size = New System.Drawing.Size(583, 386)
        Me.tabFechamento.TabIndex = 0
        Me.tabFechamento.Text = "Fechamento de Caixa"
        Me.tabFechamento.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.grdVendas)
        Me.Panel2.Controls.Add(Me.grdVendasPorFormaDePagamento)
        Me.Panel2.Controls.Add(Me.rtbVendas)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(577, 380)
        Me.Panel2.TabIndex = 134
        '
        'grdVendas
        '
        Me.grdVendas.AllowUserToAddRows = False
        Me.grdVendas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.grdVendas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdVendas.BackgroundColor = System.Drawing.Color.White
        Me.grdVendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdVendas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdVendas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdVendas.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdVendas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grdVendas.GridColor = System.Drawing.Color.Black
        Me.grdVendas.Location = New System.Drawing.Point(0, 181)
        Me.grdVendas.Name = "grdVendas"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdVendas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdVendas.Size = New System.Drawing.Size(577, 199)
        Me.grdVendas.TabIndex = 184
        '
        'grdVendasPorFormaDePagamento
        '
        Me.grdVendasPorFormaDePagamento.AllowUserToAddRows = False
        Me.grdVendasPorFormaDePagamento.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.grdVendasPorFormaDePagamento.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.grdVendasPorFormaDePagamento.BackgroundColor = System.Drawing.Color.White
        Me.grdVendasPorFormaDePagamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdVendasPorFormaDePagamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdVendasPorFormaDePagamento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdVendasPorFormaDePagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdVendasPorFormaDePagamento.DefaultCellStyle = DataGridViewCellStyle7
        Me.grdVendasPorFormaDePagamento.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdVendasPorFormaDePagamento.GridColor = System.Drawing.Color.Black
        Me.grdVendasPorFormaDePagamento.Location = New System.Drawing.Point(0, 0)
        Me.grdVendasPorFormaDePagamento.Name = "grdVendasPorFormaDePagamento"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdVendasPorFormaDePagamento.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdVendasPorFormaDePagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdVendasPorFormaDePagamento.Size = New System.Drawing.Size(577, 175)
        Me.grdVendasPorFormaDePagamento.TabIndex = 183
        '
        'rtbVendas
        '
        Me.rtbVendas.BackColor = System.Drawing.Color.Silver
        Me.rtbVendas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbVendas.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbVendas.ForeColor = System.Drawing.Color.Black
        Me.rtbVendas.Location = New System.Drawing.Point(152, 231)
        Me.rtbVendas.Name = "rtbVendas"
        Me.rtbVendas.ReadOnly = True
        Me.rtbVendas.Size = New System.Drawing.Size(10, 19)
        Me.rtbVendas.TabIndex = 0
        Me.rtbVendas.Text = ""
        Me.rtbVendas.Visible = False
        '
        'tabStatusNFCe
        '
        Me.tabStatusNFCe.Controls.Add(Me.GroupControl2)
        Me.tabStatusNFCe.Controls.Add(Me.dgvSituacaoNFCe)
        Me.tabStatusNFCe.Location = New System.Drawing.Point(4, 22)
        Me.tabStatusNFCe.Name = "tabStatusNFCe"
        Me.tabStatusNFCe.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStatusNFCe.Size = New System.Drawing.Size(583, 386)
        Me.tabStatusNFCe.TabIndex = 1
        Me.tabStatusNFCe.Text = "Situação NFC-e"
        Me.tabStatusNFCe.UseVisualStyleBackColor = True
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.rbI)
        Me.GroupControl2.Controls.Add(Me.rbC)
        Me.GroupControl2.Controls.Add(Me.rbA)
        Me.GroupControl2.Controls.Add(Me.rbT)
        Me.GroupControl2.Controls.Add(Me.lblStatusQtd)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl2.Location = New System.Drawing.Point(3, 330)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(577, 53)
        Me.GroupControl2.TabIndex = 185
        Me.GroupControl2.Text = "RESUMO"
        '
        'rbI
        '
        Me.rbI.AutoSize = True
        Me.rbI.BackColor = System.Drawing.Color.Transparent
        Me.rbI.Location = New System.Drawing.Point(492, 0)
        Me.rbI.Name = "rbI"
        Me.rbI.Size = New System.Drawing.Size(77, 17)
        Me.rbI.TabIndex = 136
        Me.rbI.TabStop = True
        Me.rbI.Text = "Inutili&zados"
        Me.rbI.UseVisualStyleBackColor = False
        Me.rbI.Visible = False
        '
        'rbC
        '
        Me.rbC.AutoSize = True
        Me.rbC.BackColor = System.Drawing.Color.Transparent
        Me.rbC.Location = New System.Drawing.Point(406, 0)
        Me.rbC.Name = "rbC"
        Me.rbC.Size = New System.Drawing.Size(81, 17)
        Me.rbC.TabIndex = 135
        Me.rbC.TabStop = True
        Me.rbC.Text = "&Cancelados"
        Me.rbC.UseVisualStyleBackColor = False
        Me.rbC.Visible = False
        '
        'rbA
        '
        Me.rbA.AutoSize = True
        Me.rbA.BackColor = System.Drawing.Color.Transparent
        Me.rbA.Location = New System.Drawing.Point(320, 0)
        Me.rbA.Name = "rbA"
        Me.rbA.Size = New System.Drawing.Size(80, 17)
        Me.rbA.TabIndex = 134
        Me.rbA.TabStop = True
        Me.rbA.Text = "&Autorizados"
        Me.rbA.UseVisualStyleBackColor = False
        Me.rbA.Visible = False
        '
        'rbT
        '
        Me.rbT.AutoSize = True
        Me.rbT.BackColor = System.Drawing.Color.Transparent
        Me.rbT.Location = New System.Drawing.Point(259, 0)
        Me.rbT.Name = "rbT"
        Me.rbT.Size = New System.Drawing.Size(55, 17)
        Me.rbT.TabIndex = 133
        Me.rbT.TabStop = True
        Me.rbT.Text = "&Todos"
        Me.rbT.UseVisualStyleBackColor = False
        Me.rbT.Visible = False
        '
        'lblStatusQtd
        '
        Me.lblStatusQtd.BackColor = System.Drawing.Color.Transparent
        Me.lblStatusQtd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatusQtd.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusQtd.ForeColor = System.Drawing.Color.Black
        Me.lblStatusQtd.Location = New System.Drawing.Point(2, 21)
        Me.lblStatusQtd.Name = "lblStatusQtd"
        Me.lblStatusQtd.Size = New System.Drawing.Size(573, 30)
        Me.lblStatusQtd.TabIndex = 132
        Me.lblStatusQtd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvSituacaoNFCe
        '
        Me.dgvSituacaoNFCe.AllowUserToAddRows = False
        Me.dgvSituacaoNFCe.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgvSituacaoNFCe.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvSituacaoNFCe.BackgroundColor = System.Drawing.Color.White
        Me.dgvSituacaoNFCe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSituacaoNFCe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSituacaoNFCe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvSituacaoNFCe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSituacaoNFCe.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvSituacaoNFCe.GridColor = System.Drawing.Color.Black
        Me.dgvSituacaoNFCe.Location = New System.Drawing.Point(3, 3)
        Me.dgvSituacaoNFCe.Name = "dgvSituacaoNFCe"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSituacaoNFCe.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvSituacaoNFCe.RowHeadersVisible = False
        Me.dgvSituacaoNFCe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSituacaoNFCe.Size = New System.Drawing.Size(577, 326)
        Me.dgvSituacaoNFCe.TabIndex = 184
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(461, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fim:"
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = CType(resources.GetObject("cmdFechar.Image"), System.Drawing.Image)
        Me.cmdFechar.Location = New System.Drawing.Point(494, 503)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(107, 47)
        Me.cmdFechar.TabIndex = 137
        Me.cmdFechar.Text = "&Fechar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(322, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Inicio:"
        '
        'btnListar
        '
        Me.btnListar.Image = CType(resources.GetObject("btnListar.Image"), System.Drawing.Image)
        Me.btnListar.Location = New System.Drawing.Point(381, 503)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(107, 47)
        Me.btnListar.TabIndex = 136
        Me.btnListar.Text = "&Listar"
        '
        'txtInicial
        '
        Me.txtInicial.CalendarTitleBackColor = System.Drawing.Color.Gainsboro
        Me.txtInicial.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtInicial.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtInicial.Location = New System.Drawing.Point(325, 39)
        Me.txtInicial.MinDate = New Date(2009, 1, 1, 0, 0, 0, 0)
        Me.txtInicial.Name = "txtInicial"
        Me.txtInicial.Size = New System.Drawing.Size(124, 26)
        Me.txtInicial.TabIndex = 2
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(269, 503)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(107, 47)
        Me.btnImprimir.TabIndex = 135
        Me.btnImprimir.Text = "&Imprimir"
        '
        'cbousuarios
        '
        Me.cbousuarios.BackColor = System.Drawing.Color.White
        Me.cbousuarios.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbousuarios.FormattingEnabled = True
        Me.cbousuarios.Location = New System.Drawing.Point(12, 39)
        Me.cbousuarios.Name = "cbousuarios"
        Me.cbousuarios.Size = New System.Drawing.Size(305, 26)
        Me.cbousuarios.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 14)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "OPERADOR:"
        '
        'frmRelGerencial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(610, 562)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(175, 150)
        Me.Name = "frmRelGerencial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MIXPDV - Atalhos:  ""I"" Imprimir | ""T"" Todos  | ""A"" Autorizados | ""C"" Cancelados |" & _
    " ""Z"" Inutilizados"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabFechamento.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.grdVendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdVendasPorFormaDePagamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabStatusNFCe.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.dgvSituacaoNFCe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdFechar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnListar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rtbVendas As System.Windows.Forms.RichTextBox
    Friend WithEvents txtFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbousuarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grdVendasPorFormaDePagamento As System.Windows.Forms.DataGridView
    Friend WithEvents grdVendas As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabFechamento As System.Windows.Forms.TabPage
    Friend WithEvents tabStatusNFCe As System.Windows.Forms.TabPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvSituacaoNFCe As System.Windows.Forms.DataGridView
    Friend WithEvents lblStatusQtd As System.Windows.Forms.Label
    Friend WithEvents rbI As System.Windows.Forms.RadioButton
    Friend WithEvents rbC As System.Windows.Forms.RadioButton
    Friend WithEvents rbA As System.Windows.Forms.RadioButton
    Friend WithEvents rbT As System.Windows.Forms.RadioButton
    Friend WithEvents lblObsImpressao As System.Windows.Forms.Label

End Class
