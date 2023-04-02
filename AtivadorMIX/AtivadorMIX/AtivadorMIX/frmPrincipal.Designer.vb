<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.XtraUserControl1 = New DevExpress.XtraEditors.XtraUserControl()
        Me.txtChave2 = New DevExpress.XtraEditors.TextEdit()
        Me.cmdGerar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSair = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCnpj = New DevExpress.XtraEditors.LabelControl()
        Me.lblData = New DevExpress.XtraEditors.LabelControl()
        Me.txtDataExpiracao = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCnpj = New DevExpress.XtraEditors.TextEdit()
        Me.lblbloqueio = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtChave2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataExpiracao.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataExpiracao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCnpj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraUserControl1
        '
        Me.XtraUserControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.XtraUserControl1.Appearance.Options.UseBackColor = True
        Me.XtraUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.XtraUserControl1.Location = New System.Drawing.Point(0, 162)
        Me.XtraUserControl1.Name = "XtraUserControl1"
        Me.XtraUserControl1.Size = New System.Drawing.Size(268, 37)
        Me.XtraUserControl1.TabIndex = 3
        '
        'txtChave2
        '
        Me.txtChave2.Location = New System.Drawing.Point(5, 116)
        Me.txtChave2.Name = "txtChave2"
        Me.txtChave2.Size = New System.Drawing.Size(259, 20)
        Me.txtChave2.TabIndex = 6
        '
        'cmdGerar
        '
        Me.cmdGerar.Location = New System.Drawing.Point(196, 169)
        Me.cmdGerar.Name = "cmdGerar"
        Me.cmdGerar.Size = New System.Drawing.Size(68, 23)
        Me.cmdGerar.TabIndex = 9
        Me.cmdGerar.Text = "&Gerar"
        '
        'cmdSair
        '
        Me.cmdSair.Location = New System.Drawing.Point(121, 169)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(69, 23)
        Me.cmdSair.TabIndex = 8
        Me.cmdSair.Text = "&Sair"
        '
        'lblCnpj
        '
        Me.lblCnpj.Location = New System.Drawing.Point(5, 96)
        Me.lblCnpj.Name = "lblCnpj"
        Me.lblCnpj.Size = New System.Drawing.Size(33, 13)
        Me.lblCnpj.TabIndex = 10
        Me.lblCnpj.Text = "CHAVE"
        '
        'lblData
        '
        Me.lblData.Location = New System.Drawing.Point(5, 52)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(73, 13)
        Me.lblData.TabIndex = 11
        Me.lblData.Text = "Data Expiração"
        '
        'txtDataExpiracao
        '
        Me.txtDataExpiracao.EditValue = Nothing
        Me.txtDataExpiracao.Location = New System.Drawing.Point(5, 69)
        Me.txtDataExpiracao.Name = "txtDataExpiracao"
        Me.txtDataExpiracao.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDataExpiracao.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDataExpiracao.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.txtDataExpiracao.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.txtDataExpiracao.Properties.Mask.EditMask = ""
        Me.txtDataExpiracao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtDataExpiracao.Size = New System.Drawing.Size(259, 20)
        Me.txtDataExpiracao.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl1.Location = New System.Drawing.Point(5, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "CNPJ (Clique aqui depois.)"
        '
        'txtCnpj
        '
        Me.txtCnpj.Location = New System.Drawing.Point(5, 26)
        Me.txtCnpj.Name = "txtCnpj"
        Me.txtCnpj.Size = New System.Drawing.Size(259, 20)
        Me.txtCnpj.TabIndex = 12
        '
        'lblbloqueio
        '
        Me.lblbloqueio.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbloqueio.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblbloqueio.Location = New System.Drawing.Point(5, 143)
        Me.lblbloqueio.Name = "lblbloqueio"
        Me.lblbloqueio.Size = New System.Drawing.Size(0, 13)
        Me.lblbloqueio.TabIndex = 14
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 199)
        Me.Controls.Add(Me.lblbloqueio)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtCnpj)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblCnpj)
        Me.Controls.Add(Me.cmdGerar)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.txtChave2)
        Me.Controls.Add(Me.XtraUserControl1)
        Me.Controls.Add(Me.txtDataExpiracao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MIXPDV - ATIVADOR"
        CType(Me.txtChave2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataExpiracao.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataExpiracao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCnpj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XtraUserControl1 As DevExpress.XtraEditors.XtraUserControl
    Friend WithEvents txtChave2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdGerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSair As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCnpj As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDataExpiracao As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCnpj As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblbloqueio As DevExpress.XtraEditors.LabelControl

End Class
