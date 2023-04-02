<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigurarBotao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigurarBotao))
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.lblCod = New DevExpress.XtraEditors.LabelControl()
        Me.lblNome = New DevExpress.XtraEditors.LabelControl()
        Me.txtNome = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCaminhoIMG = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBotaoAtual = New System.Windows.Forms.Label()
        Me.cmdVoltar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGravar = New DevExpress.XtraEditors.SimpleButton()
        Me.btEditado = New DevExpress.XtraEditors.SimpleButton()
        Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaminhoIMG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.EditValue = ""
        Me.txtCodigo.Location = New System.Drawing.Point(115, 23)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Properties.Appearance.Options.UseFont = True
        Me.txtCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCodigo.Size = New System.Drawing.Size(98, 22)
        Me.txtCodigo.TabIndex = 12
        '
        'lblCod
        '
        Me.lblCod.Location = New System.Drawing.Point(116, 7)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(41, 13)
        Me.lblCod.TabIndex = 13
        Me.lblCod.Text = "CÓDIGO"
        '
        'lblNome
        '
        Me.lblNome.Location = New System.Drawing.Point(218, 7)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(29, 13)
        Me.lblNome.TabIndex = 15
        Me.lblNome.Text = "NOME"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(217, 23)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Properties.Appearance.Options.UseFont = True
        Me.txtNome.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtNome.Size = New System.Drawing.Size(208, 22)
        Me.txtNome.TabIndex = 14
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(116, 53)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "CAMINHO DA IMAGEM"
        '
        'txtCaminhoIMG
        '
        Me.txtCaminhoIMG.Location = New System.Drawing.Point(115, 69)
        Me.txtCaminhoIMG.Name = "txtCaminhoIMG"
        Me.txtCaminhoIMG.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaminhoIMG.Properties.Appearance.Options.UseFont = True
        Me.txtCaminhoIMG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCaminhoIMG.Size = New System.Drawing.Size(355, 22)
        Me.txtCaminhoIMG.TabIndex = 16
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(470, 69)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(22, 22)
        Me.SimpleButton1.TabIndex = 18
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.lblBotaoAtual)
        Me.PanelControl1.Controls.Add(Me.cmdVoltar)
        Me.PanelControl1.Controls.Add(Me.cmdGravar)
        Me.PanelControl1.Location = New System.Drawing.Point(-2, 103)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(511, 53)
        Me.PanelControl1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Botão Atual :"
        '
        'lblBotaoAtual
        '
        Me.lblBotaoAtual.AutoSize = True
        Me.lblBotaoAtual.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotaoAtual.Location = New System.Drawing.Point(93, 21)
        Me.lblBotaoAtual.Name = "lblBotaoAtual"
        Me.lblBotaoAtual.Size = New System.Drawing.Size(16, 13)
        Me.lblBotaoAtual.TabIndex = 22
        Me.lblBotaoAtual.Text = "..."
        '
        'cmdVoltar
        '
        Me.cmdVoltar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVoltar.Appearance.Options.UseFont = True
        Me.cmdVoltar.Image = CType(resources.GetObject("cmdVoltar.Image"), System.Drawing.Image)
        Me.cmdVoltar.Location = New System.Drawing.Point(267, 7)
        Me.cmdVoltar.Name = "cmdVoltar"
        Me.cmdVoltar.Size = New System.Drawing.Size(115, 40)
        Me.cmdVoltar.TabIndex = 21
        Me.cmdVoltar.Text = "&Voltar"
        '
        'cmdGravar
        '
        Me.cmdGravar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGravar.Appearance.Options.UseFont = True
        Me.cmdGravar.Image = CType(resources.GetObject("cmdGravar.Image"), System.Drawing.Image)
        Me.cmdGravar.Location = New System.Drawing.Point(388, 7)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(115, 40)
        Me.cmdGravar.TabIndex = 20
        Me.cmdGravar.Text = "&Gravar"
        '
        'btEditado
        '
        Me.btEditado.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btEditado.Image = CType(resources.GetObject("btEditado.Image"), System.Drawing.Image)
        Me.btEditado.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btEditado.Location = New System.Drawing.Point(5, 7)
        Me.btEditado.Name = "btEditado"
        Me.btEditado.Size = New System.Drawing.Size(106, 84)
        Me.btEditado.TabIndex = 20
        Me.btEditado.Text = "NULL"
        '
        'ofd1
        '
        Me.ofd1.DefaultExt = """jpg"""
        Me.ofd1.InitialDirectory = "C:\NextDig\"
        Me.ofd1.RestoreDirectory = True
        Me.ofd1.Title = "Imagem Explorer"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(429, 7)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 22
        Me.LabelControl2.Text = "VALOR"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(428, 23)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit1.Size = New System.Drawing.Size(64, 22)
        Me.TextEdit1.TabIndex = 21
        '
        'frmConfigurarBotao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 154)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.btEditado)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtCaminhoIMG)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.txtCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfigurarBotao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MIXPDV - CONFIGURAÇÃO DO BOTÃO"
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaminhoIMG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCaminhoIMG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdVoltar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGravar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btEditado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblBotaoAtual As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ofd1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
End Class
