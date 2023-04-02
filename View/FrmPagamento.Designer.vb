<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagamento
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagamento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValorEntrada = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtApagar = New System.Windows.Forms.MaskedTextBox()
        Me.txtvSaldo = New System.Windows.Forms.MaskedTextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvRecebimentos = New System.Windows.Forms.DataGridView()
        Me.formapgto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pdocPagamento = New System.Drawing.Printing.PrintDocument()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTroco = New System.Windows.Forms.MaskedTextBox()
        Me.txtPago = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btnF2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnF3 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnF4 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnF7 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnF6 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnF5 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnF8 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnF9 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpaForm = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dgvRecebimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(884, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Forma Pgto."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(5, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Valor R$"
        '
        'txtValorEntrada
        '
        Me.txtValorEntrada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorEntrada.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorEntrada.Location = New System.Drawing.Point(172, 22)
        Me.txtValorEntrada.Name = "txtValorEntrada"
        Me.txtValorEntrada.Size = New System.Drawing.Size(231, 40)
        Me.txtValorEntrada.TabIndex = 3
        Me.txtValorEntrada.Text = "R$ 0,00"
        Me.txtValorEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(25, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "A Pagar:"
        '
        'txtApagar
        '
        Me.txtApagar.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtApagar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApagar.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApagar.ForeColor = System.Drawing.Color.White
        Me.txtApagar.Location = New System.Drawing.Point(29, 222)
        Me.txtApagar.Name = "txtApagar"
        Me.txtApagar.ReadOnly = True
        Me.txtApagar.Size = New System.Drawing.Size(156, 33)
        Me.txtApagar.TabIndex = 6
        Me.txtApagar.Text = "R$ 0,00"
        '
        'txtvSaldo
        '
        Me.txtvSaldo.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtvSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtvSaldo.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvSaldo.ForeColor = System.Drawing.Color.White
        Me.txtvSaldo.Location = New System.Drawing.Point(223, 222)
        Me.txtvSaldo.Name = "txtvSaldo"
        Me.txtvSaldo.ReadOnly = True
        Me.txtvSaldo.Size = New System.Drawing.Size(153, 33)
        Me.txtvSaldo.TabIndex = 8
        Me.txtvSaldo.Text = "R$ 0,00"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.txtValorEntrada)
        Me.GroupControl1.Location = New System.Drawing.Point(394, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(408, 68)
        Me.GroupControl1.TabIndex = 247
        Me.GroupControl1.Text = "FORMA DE PAGAMENTO"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.dgvRecebimentos)
        Me.GroupControl2.Location = New System.Drawing.Point(10, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(378, 180)
        Me.GroupControl2.TabIndex = 248
        Me.GroupControl2.Text = "LISTA DE PAGAMENTOS"
        '
        'dgvRecebimentos
        '
        Me.dgvRecebimentos.AllowUserToAddRows = False
        Me.dgvRecebimentos.AllowUserToDeleteRows = False
        Me.dgvRecebimentos.AllowUserToResizeColumns = False
        Me.dgvRecebimentos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRecebimentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRecebimentos.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvRecebimentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRecebimentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecebimentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRecebimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecebimentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.formapgto, Me.valor, Me.id})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRecebimentos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRecebimentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRecebimentos.GridColor = System.Drawing.Color.Black
        Me.dgvRecebimentos.Location = New System.Drawing.Point(2, 21)
        Me.dgvRecebimentos.Name = "dgvRecebimentos"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecebimentos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRecebimentos.RowHeadersVisible = False
        Me.dgvRecebimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecebimentos.Size = New System.Drawing.Size(374, 157)
        Me.dgvRecebimentos.TabIndex = 259
        '
        'formapgto
        '
        Me.formapgto.HeaderText = "FORMA DE PAGAMENTO"
        Me.formapgto.Name = "formapgto"
        Me.formapgto.Width = 250
        '
        'valor
        '
        Me.valor.HeaderText = "VALOR"
        Me.valor.Name = "valor"
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.RoyalBlue
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RectangleShape1.Location = New System.Drawing.Point(10, 196)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(377, 123)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(220, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 16)
        Me.Label9.TabIndex = 250
        Me.Label9.Text = "Saldo:"
        '
        'pdocPagamento
        '
        Me.pdocPagamento.DocumentName = "DocumentName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(220, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 252
        Me.Label3.Text = "Troco:"
        '
        'txtTroco
        '
        Me.txtTroco.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTroco.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTroco.ForeColor = System.Drawing.Color.White
        Me.txtTroco.Location = New System.Drawing.Point(223, 278)
        Me.txtTroco.Name = "txtTroco"
        Me.txtTroco.ReadOnly = True
        Me.txtTroco.Size = New System.Drawing.Size(153, 33)
        Me.txtTroco.TabIndex = 251
        Me.txtTroco.Text = "R$ 0,00"
        '
        'txtPago
        '
        Me.txtPago.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtPago.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPago.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.ForeColor = System.Drawing.Color.White
        Me.txtPago.Location = New System.Drawing.Point(28, 278)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.ReadOnly = True
        Me.txtPago.Size = New System.Drawing.Size(156, 33)
        Me.txtPago.TabIndex = 254
        Me.txtPago.Text = "R$ 0,00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 253
        Me.Label4.Text = "Pago:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(812, 331)
        Me.ShapeContainer1.TabIndex = 249
        Me.ShapeContainer1.TabStop = False
        '
        'btnF2
        '
        Me.btnF2.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnF2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF2.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnF2.Appearance.Options.UseBackColor = True
        Me.btnF2.Appearance.Options.UseFont = True
        Me.btnF2.Appearance.Options.UseForeColor = True
        Me.btnF2.Appearance.Options.UseTextOptions = True
        Me.btnF2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnF2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnF2.Location = New System.Drawing.Point(394, 86)
        Me.btnF2.Name = "btnF2"
        Me.btnF2.Size = New System.Drawing.Size(132, 74)
        Me.btnF2.TabIndex = 255
        Me.btnF2.Text = "F2-Dinheiro"
        '
        'btnF3
        '
        Me.btnF3.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnF3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnF3.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnF3.Appearance.Options.UseBackColor = True
        Me.btnF3.Appearance.Options.UseFont = True
        Me.btnF3.Appearance.Options.UseForeColor = True
        Me.btnF3.Appearance.Options.UseTextOptions = True
        Me.btnF3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnF3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnF3.Location = New System.Drawing.Point(532, 86)
        Me.btnF3.Name = "btnF3"
        Me.btnF3.Size = New System.Drawing.Size(132, 74)
        Me.btnF3.TabIndex = 256
        Me.btnF3.Text = "F3-Cheque"
        '
        'btnF4
        '
        Me.btnF4.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnF4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnF4.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnF4.Appearance.Options.UseBackColor = True
        Me.btnF4.Appearance.Options.UseFont = True
        Me.btnF4.Appearance.Options.UseForeColor = True
        Me.btnF4.Appearance.Options.UseTextOptions = True
        Me.btnF4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnF4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnF4.Location = New System.Drawing.Point(670, 86)
        Me.btnF4.Name = "btnF4"
        Me.btnF4.Size = New System.Drawing.Size(132, 74)
        Me.btnF4.TabIndex = 257
        Me.btnF4.Text = "F4-Cartão de Crédito"
        '
        'btnF7
        '
        Me.btnF7.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnF7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnF7.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnF7.Appearance.Options.UseBackColor = True
        Me.btnF7.Appearance.Options.UseFont = True
        Me.btnF7.Appearance.Options.UseForeColor = True
        Me.btnF7.Appearance.Options.UseTextOptions = True
        Me.btnF7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnF7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnF7.Location = New System.Drawing.Point(670, 166)
        Me.btnF7.Name = "btnF7"
        Me.btnF7.Size = New System.Drawing.Size(132, 74)
        Me.btnF7.TabIndex = 260
        Me.btnF7.Text = "F7-Vale Alimentação"
        '
        'btnF6
        '
        Me.btnF6.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnF6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnF6.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnF6.Appearance.Options.UseBackColor = True
        Me.btnF6.Appearance.Options.UseFont = True
        Me.btnF6.Appearance.Options.UseForeColor = True
        Me.btnF6.Appearance.Options.UseTextOptions = True
        Me.btnF6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnF6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnF6.Location = New System.Drawing.Point(532, 166)
        Me.btnF6.Name = "btnF6"
        Me.btnF6.Size = New System.Drawing.Size(132, 74)
        Me.btnF6.TabIndex = 259
        Me.btnF6.Text = "F6-Crédito Loja"
        '
        'btnF5
        '
        Me.btnF5.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnF5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnF5.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnF5.Appearance.Options.UseBackColor = True
        Me.btnF5.Appearance.Options.UseFont = True
        Me.btnF5.Appearance.Options.UseForeColor = True
        Me.btnF5.Appearance.Options.UseTextOptions = True
        Me.btnF5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnF5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnF5.Location = New System.Drawing.Point(394, 166)
        Me.btnF5.Name = "btnF5"
        Me.btnF5.Size = New System.Drawing.Size(132, 74)
        Me.btnF5.TabIndex = 258
        Me.btnF5.Text = "F5-Cartão de Débito"
        '
        'btnF8
        '
        Me.btnF8.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnF8.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnF8.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnF8.Appearance.Options.UseBackColor = True
        Me.btnF8.Appearance.Options.UseFont = True
        Me.btnF8.Appearance.Options.UseForeColor = True
        Me.btnF8.Appearance.Options.UseTextOptions = True
        Me.btnF8.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnF8.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnF8.Location = New System.Drawing.Point(394, 246)
        Me.btnF8.Name = "btnF8"
        Me.btnF8.Size = New System.Drawing.Size(132, 74)
        Me.btnF8.TabIndex = 261
        Me.btnF8.Text = "F8-Vale Refeição"
        '
        'btnF9
        '
        Me.btnF9.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnF9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnF9.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnF9.Appearance.Options.UseBackColor = True
        Me.btnF9.Appearance.Options.UseFont = True
        Me.btnF9.Appearance.Options.UseForeColor = True
        Me.btnF9.Appearance.Options.UseTextOptions = True
        Me.btnF9.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnF9.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnF9.Location = New System.Drawing.Point(532, 246)
        Me.btnF9.Name = "btnF9"
        Me.btnF9.Size = New System.Drawing.Size(132, 74)
        Me.btnF9.TabIndex = 264
        Me.btnF9.Text = "F9-Outros"
        '
        'btnLimpaForm
        '
        Me.btnLimpaForm.Appearance.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLimpaForm.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpaForm.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnLimpaForm.Appearance.Options.UseBackColor = True
        Me.btnLimpaForm.Appearance.Options.UseFont = True
        Me.btnLimpaForm.Appearance.Options.UseForeColor = True
        Me.btnLimpaForm.Appearance.Options.UseTextOptions = True
        Me.btnLimpaForm.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnLimpaForm.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnLimpaForm.Location = New System.Drawing.Point(670, 246)
        Me.btnLimpaForm.Name = "btnLimpaForm"
        Me.btnLimpaForm.Size = New System.Drawing.Size(132, 74)
        Me.btnLimpaForm.TabIndex = 265
        Me.btnLimpaForm.Text = "ESC - Limpar Recebimentos"
        '
        'FrmPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(812, 331)
        Me.Controls.Add(Me.btnLimpaForm)
        Me.Controls.Add(Me.btnF9)
        Me.Controls.Add(Me.btnF8)
        Me.Controls.Add(Me.btnF7)
        Me.Controls.Add(Me.btnF6)
        Me.Controls.Add(Me.btnF5)
        Me.Controls.Add(Me.btnF4)
        Me.Controls.Add(Me.btnF3)
        Me.Controls.Add(Me.btnF2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTroco)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtvSaldo)
        Me.Controls.Add(Me.txtApagar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPagamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mix NFCe - Recebimentos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.dgvRecebimentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtValorEntrada As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtApagar As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtvSaldo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pdocPagamento As System.Drawing.Printing.PrintDocument
    Friend WithEvents dgvRecebimentos As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTroco As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPago As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents formapgto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btnF2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnF3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnF4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnF7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnF6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnF5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnF8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnF9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpaForm As DevExpress.XtraEditors.SimpleButton
End Class
