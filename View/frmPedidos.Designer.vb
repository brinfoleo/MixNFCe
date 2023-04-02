<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidos))
        Me.txtCriterio = New System.Windows.Forms.TextBox()
        Me.dgvResultado = New System.Windows.Forms.DataGridView()
        Me.gcTop = New DevExpress.XtraEditors.GroupControl()
        Me.txtFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInicial = New System.Windows.Forms.DateTimePicker()
        Me.btnListar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCriterio
        '
        Me.txtCriterio.BackColor = System.Drawing.Color.White
        Me.txtCriterio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriterio.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriterio.Location = New System.Drawing.Point(12, 30)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(263, 40)
        Me.txtCriterio.TabIndex = 0
        '
        'dgvResultado
        '
        Me.dgvResultado.AllowUserToAddRows = False
        Me.dgvResultado.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvResultado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResultado.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvResultado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvResultado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 18.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 18.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResultado.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvResultado.GridColor = System.Drawing.Color.Black
        Me.dgvResultado.Location = New System.Drawing.Point(0, 88)
        Me.dgvResultado.Name = "dgvResultado"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 14.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultado.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvResultado.RowHeadersWidth = 45
        Me.dgvResultado.RowTemplate.Height = 33
        Me.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultado.Size = New System.Drawing.Size(1017, 660)
        Me.dgvResultado.TabIndex = 183
        '
        'gcTop
        '
        Me.gcTop.Controls.Add(Me.btnListar)
        Me.gcTop.Controls.Add(Me.txtFinal)
        Me.gcTop.Controls.Add(Me.Label2)
        Me.gcTop.Controls.Add(Me.Label1)
        Me.gcTop.Controls.Add(Me.txtInicial)
        Me.gcTop.Controls.Add(Me.txtCriterio)
        Me.gcTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.gcTop.Location = New System.Drawing.Point(0, 0)
        Me.gcTop.Name = "gcTop"
        Me.gcTop.Size = New System.Drawing.Size(1018, 82)
        Me.gcTop.TabIndex = 184
        Me.gcTop.Text = "Pesquisa de Produtos (INFORME O TEXTO PARA PESQUISA)"
        '
        'txtFinal
        '
        Me.txtFinal.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFinal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtFinal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFinal.Location = New System.Drawing.Point(863, 38)
        Me.txtFinal.MinDate = New Date(2009, 1, 1, 0, 0, 0, 0)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(124, 26)
        Me.txtFinal.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(860, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fim:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(721, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Inicio:"
        '
        'txtInicial
        '
        Me.txtInicial.CalendarTitleBackColor = System.Drawing.Color.Gainsboro
        Me.txtInicial.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtInicial.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtInicial.Location = New System.Drawing.Point(724, 38)
        Me.txtInicial.MinDate = New Date(2009, 1, 1, 0, 0, 0, 0)
        Me.txtInicial.Name = "txtInicial"
        Me.txtInicial.Size = New System.Drawing.Size(124, 26)
        Me.txtInicial.TabIndex = 6
        '
        'btnListar
        '
        Me.btnListar.Image = CType(resources.GetObject("btnListar.Image"), System.Drawing.Image)
        Me.btnListar.Location = New System.Drawing.Point(512, 24)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(107, 47)
        Me.btnListar.TabIndex = 137
        Me.btnListar.Text = "&Listar"
        '
        'frmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 740)
        Me.Controls.Add(Me.gcTop)
        Me.Controls.Add(Me.dgvResultado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcTop.ResumeLayout(False)
        Me.gcTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents dgvResultado As System.Windows.Forms.DataGridView
    Friend WithEvents gcTop As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnListar As DevExpress.XtraEditors.SimpleButton
End Class
