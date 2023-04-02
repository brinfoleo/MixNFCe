<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement9 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement10 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement11 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.cmdClientes = New DevExpress.XtraEditors.TileItem()
        Me.cmdrecebimentos = New DevExpress.XtraEditors.TileItem()
        Me.cmdCadProdutos = New DevExpress.XtraEditors.TileItem()
        Me.cmdUsuarios = New DevExpress.XtraEditors.TileItem()
        Me.TileGroup3 = New DevExpress.XtraEditors.TileGroup()
        Me.cmdFechamentoCaixa = New DevExpress.XtraEditors.TileItem()
        Me.cmdAtualizaBanco = New DevExpress.XtraEditors.TileItem()
        Me.cmdLocalizarProdutos = New DevExpress.XtraEditors.TileItem()
        Me.cmdConfig = New DevExpress.XtraEditors.TileItem()
        Me.TileGroup4 = New DevExpress.XtraEditors.TileGroup()
        Me.cmdSangriaSuprimento = New DevExpress.XtraEditors.TileItem()
        Me.cmdVoltarPDV = New DevExpress.XtraEditors.TileItem()
        Me.cmdSair = New DevExpress.XtraEditors.TileItem()
        Me.SuspendLayout()
        '
        'TileControl1
        '
        Me.TileControl1.AppearanceText.ForeColor = System.Drawing.Color.Silver
        Me.TileControl1.AppearanceText.Options.UseForeColor = True
        Me.TileControl1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.Groups.Add(Me.TileGroup3)
        Me.TileControl1.Groups.Add(Me.TileGroup4)
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.MaxId = 19
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.SelectionColor = System.Drawing.Color.Maroon
        Me.TileControl1.ShowText = True
        Me.TileControl1.Size = New System.Drawing.Size(1024, 768)
        Me.TileControl1.TabIndex = 0
        Me.TileControl1.Text = "Menu do Sistema"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.cmdClientes)
        Me.TileGroup2.Items.Add(Me.cmdrecebimentos)
        Me.TileGroup2.Items.Add(Me.cmdCadProdutos)
        Me.TileGroup2.Items.Add(Me.cmdUsuarios)
        Me.TileGroup2.Name = "TileGroup2"
        Me.TileGroup2.Text = Nothing
        '
        'cmdClientes
        '
        Me.cmdClientes.AppearanceItem.Hovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdClientes.AppearanceItem.Hovered.Options.UseForeColor = True
        Me.cmdClientes.AppearanceItem.Normal.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdClientes.AppearanceItem.Normal.BorderColor = System.Drawing.Color.RoyalBlue
        Me.cmdClientes.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White
        Me.cmdClientes.AppearanceItem.Normal.Options.UseBackColor = True
        Me.cmdClientes.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.cmdClientes.AppearanceItem.Normal.Options.UseForeColor = True
        TileItemElement1.Image = CType(resources.GetObject("TileItemElement1.Image"), System.Drawing.Image)
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement1.Text = "Clientes"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.cmdClientes.Elements.Add(TileItemElement1)
        Me.cmdClientes.Id = 0
        Me.cmdClientes.Name = "cmdClientes"
        '
        'cmdrecebimentos
        '
        Me.cmdrecebimentos.AppearanceItem.Normal.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdrecebimentos.AppearanceItem.Normal.BorderColor = System.Drawing.Color.RoyalBlue
        Me.cmdrecebimentos.AppearanceItem.Normal.Options.UseBackColor = True
        Me.cmdrecebimentos.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement2.Image = CType(resources.GetObject("TileItemElement2.Image"), System.Drawing.Image)
        TileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement2.Text = "Tipo Recebimento"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.cmdrecebimentos.Elements.Add(TileItemElement2)
        Me.cmdrecebimentos.Id = 1
        Me.cmdrecebimentos.Name = "cmdrecebimentos"
        '
        'cmdCadProdutos
        '
        Me.cmdCadProdutos.AppearanceItem.Normal.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdCadProdutos.AppearanceItem.Normal.BorderColor = System.Drawing.Color.RoyalBlue
        Me.cmdCadProdutos.AppearanceItem.Normal.Options.UseBackColor = True
        Me.cmdCadProdutos.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement3.Image = CType(resources.GetObject("TileItemElement3.Image"), System.Drawing.Image)
        TileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileItemElement3.Text = "Produtos"
        Me.cmdCadProdutos.Elements.Add(TileItemElement3)
        Me.cmdCadProdutos.Id = 2
        Me.cmdCadProdutos.Name = "cmdCadProdutos"
        '
        'cmdUsuarios
        '
        Me.cmdUsuarios.AppearanceItem.Normal.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdUsuarios.AppearanceItem.Normal.BorderColor = System.Drawing.Color.RoyalBlue
        Me.cmdUsuarios.AppearanceItem.Normal.Options.UseBackColor = True
        Me.cmdUsuarios.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement4.Image = CType(resources.GetObject("TileItemElement4.Image"), System.Drawing.Image)
        TileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement4.Text = "Usuários"
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.cmdUsuarios.Elements.Add(TileItemElement4)
        Me.cmdUsuarios.Id = 3
        Me.cmdUsuarios.Name = "cmdUsuarios"
        '
        'TileGroup3
        '
        Me.TileGroup3.Items.Add(Me.cmdFechamentoCaixa)
        Me.TileGroup3.Items.Add(Me.cmdAtualizaBanco)
        Me.TileGroup3.Items.Add(Me.cmdLocalizarProdutos)
        Me.TileGroup3.Items.Add(Me.cmdConfig)
        Me.TileGroup3.Name = "TileGroup3"
        Me.TileGroup3.Text = Nothing
        '
        'cmdFechamentoCaixa
        '
        Me.cmdFechamentoCaixa.AppearanceItem.Normal.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdFechamentoCaixa.AppearanceItem.Normal.BorderColor = System.Drawing.Color.RoyalBlue
        Me.cmdFechamentoCaixa.AppearanceItem.Normal.Options.UseBackColor = True
        Me.cmdFechamentoCaixa.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement5.Image = CType(resources.GetObject("TileItemElement5.Image"), System.Drawing.Image)
        TileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement5.Text = "Fechar Caixa"
        TileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.cmdFechamentoCaixa.Elements.Add(TileItemElement5)
        Me.cmdFechamentoCaixa.Id = 9
        Me.cmdFechamentoCaixa.Name = "cmdFechamentoCaixa"
        '
        'cmdAtualizaBanco
        '
        Me.cmdAtualizaBanco.AppearanceItem.Normal.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdAtualizaBanco.AppearanceItem.Normal.BorderColor = System.Drawing.Color.RoyalBlue
        Me.cmdAtualizaBanco.AppearanceItem.Normal.Options.UseBackColor = True
        Me.cmdAtualizaBanco.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement6.Image = CType(resources.GetObject("TileItemElement6.Image"), System.Drawing.Image)
        TileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement6.Text = "Atualiza Banco"
        TileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.cmdAtualizaBanco.Elements.Add(TileItemElement6)
        Me.cmdAtualizaBanco.Id = 10
        Me.cmdAtualizaBanco.Name = "cmdAtualizaBanco"
        '
        'cmdLocalizarProdutos
        '
        Me.cmdLocalizarProdutos.AppearanceItem.Normal.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdLocalizarProdutos.AppearanceItem.Normal.BorderColor = System.Drawing.Color.RoyalBlue
        Me.cmdLocalizarProdutos.AppearanceItem.Normal.Options.UseBackColor = True
        Me.cmdLocalizarProdutos.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement7.Image = CType(resources.GetObject("TileItemElement7.Image"), System.Drawing.Image)
        TileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement7.Text = "SEM USO"
        TileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.cmdLocalizarProdutos.Elements.Add(TileItemElement7)
        Me.cmdLocalizarProdutos.Id = 11
        Me.cmdLocalizarProdutos.Name = "cmdLocalizarProdutos"
        '
        'cmdConfig
        '
        Me.cmdConfig.AppearanceItem.Normal.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdConfig.AppearanceItem.Normal.BorderColor = System.Drawing.Color.RoyalBlue
        Me.cmdConfig.AppearanceItem.Normal.Options.UseBackColor = True
        Me.cmdConfig.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement8.Image = CType(resources.GetObject("TileItemElement8.Image"), System.Drawing.Image)
        TileItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement8.Text = "Configuração"
        TileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.cmdConfig.Elements.Add(TileItemElement8)
        Me.cmdConfig.Id = 12
        Me.cmdConfig.Name = "cmdConfig"
        '
        'TileGroup4
        '
        Me.TileGroup4.Items.Add(Me.cmdSangriaSuprimento)
        Me.TileGroup4.Items.Add(Me.cmdVoltarPDV)
        Me.TileGroup4.Items.Add(Me.cmdSair)
        Me.TileGroup4.Name = "TileGroup4"
        Me.TileGroup4.Text = Nothing
        '
        'cmdSangriaSuprimento
        '
        Me.cmdSangriaSuprimento.AppearanceItem.Normal.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdSangriaSuprimento.AppearanceItem.Normal.BorderColor = System.Drawing.Color.RoyalBlue
        Me.cmdSangriaSuprimento.AppearanceItem.Normal.Options.UseBackColor = True
        Me.cmdSangriaSuprimento.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement9.Image = CType(resources.GetObject("TileItemElement9.Image"), System.Drawing.Image)
        TileItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement9.Text = "Sangria / Suprimento"
        TileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.cmdSangriaSuprimento.Elements.Add(TileItemElement9)
        Me.cmdSangriaSuprimento.Id = 13
        Me.cmdSangriaSuprimento.Name = "cmdSangriaSuprimento"
        '
        'cmdVoltarPDV
        '
        Me.cmdVoltarPDV.AppearanceItem.Normal.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdVoltarPDV.AppearanceItem.Normal.BorderColor = System.Drawing.Color.RoyalBlue
        Me.cmdVoltarPDV.AppearanceItem.Normal.Options.UseBackColor = True
        Me.cmdVoltarPDV.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement10.Image = CType(resources.GetObject("TileItemElement10.Image"), System.Drawing.Image)
        TileItemElement10.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement10.Text = "Voltar PDV"
        TileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.cmdVoltarPDV.Elements.Add(TileItemElement10)
        Me.cmdVoltarPDV.Id = 17
        Me.cmdVoltarPDV.Name = "cmdVoltarPDV"
        '
        'cmdSair
        '
        Me.cmdSair.AppearanceItem.Normal.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdSair.AppearanceItem.Normal.BorderColor = System.Drawing.Color.RoyalBlue
        Me.cmdSair.AppearanceItem.Normal.Options.UseBackColor = True
        Me.cmdSair.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement11.Image = CType(resources.GetObject("TileItemElement11.Image"), System.Drawing.Image)
        TileItemElement11.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileItemElement11.Text = "Sair do Sistema"
        TileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        Me.cmdSair.Elements.Add(TileItemElement11)
        Me.cmdSair.Id = 14
        Me.cmdSair.IsLarge = True
        Me.cmdSair.Name = "cmdSair"
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.TileControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenuPrincipal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents cmdClientes As DevExpress.XtraEditors.TileItem
    Friend WithEvents cmdrecebimentos As DevExpress.XtraEditors.TileItem
    Friend WithEvents cmdCadProdutos As DevExpress.XtraEditors.TileItem
    Friend WithEvents cmdUsuarios As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileGroup3 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents cmdFechamentoCaixa As DevExpress.XtraEditors.TileItem
    Friend WithEvents cmdAtualizaBanco As DevExpress.XtraEditors.TileItem
    Friend WithEvents cmdLocalizarProdutos As DevExpress.XtraEditors.TileItem
    Friend WithEvents cmdConfig As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileGroup4 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents cmdSangriaSuprimento As DevExpress.XtraEditors.TileItem
    Friend WithEvents cmdSair As DevExpress.XtraEditors.TileItem
    Friend WithEvents cmdVoltarPDV As DevExpress.XtraEditors.TileItem
End Class
