<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAtivacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAtivacao))
        Me.cmdValidarAtivacao = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSair = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btCodigoOnline = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtserial = New System.Windows.Forms.MaskedTextBox()
        Me.lblRazao = New System.Windows.Forms.Label()
        Me.lblRazaoAtivacao = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCnpj = New System.Windows.Forms.Label()
        Me.lblcnpjLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdValidarAtivacao
        '
        Me.cmdValidarAtivacao.Image = CType(resources.GetObject("cmdValidarAtivacao.Image"), System.Drawing.Image)
        Me.cmdValidarAtivacao.Location = New System.Drawing.Point(308, 191)
        Me.cmdValidarAtivacao.Name = "cmdValidarAtivacao"
        Me.cmdValidarAtivacao.Size = New System.Drawing.Size(115, 53)
        Me.cmdValidarAtivacao.TabIndex = 3
        Me.cmdValidarAtivacao.Text = "Gr&avar"
        '
        'cmdSair
        '
        Me.cmdSair.Image = CType(resources.GetObject("cmdSair.Image"), System.Drawing.Image)
        Me.cmdSair.Location = New System.Drawing.Point(184, 191)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(115, 53)
        Me.cmdSair.TabIndex = 4
        Me.cmdSair.Text = "&Sair"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(458, 132)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(9, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Liberação do Sistema."
        '
        'btCodigoOnline
        '
        Me.btCodigoOnline.Image = CType(resources.GetObject("btCodigoOnline.Image"), System.Drawing.Image)
        Me.btCodigoOnline.Location = New System.Drawing.Point(58, 191)
        Me.btCodigoOnline.Name = "btCodigoOnline"
        Me.btCodigoOnline.Size = New System.Drawing.Size(115, 53)
        Me.btCodigoOnline.TabIndex = 13
        Me.btCodigoOnline.Text = "&On-Line"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtserial)
        Me.GroupBox1.Controls.Add(Me.lblRazao)
        Me.GroupBox1.Controls.Add(Me.lblRazaoAtivacao)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblCnpj)
        Me.GroupBox1.Controls.Add(Me.lblcnpjLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(-3, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 105)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'txtserial
        '
        Me.txtserial.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtserial.Location = New System.Drawing.Point(144, 67)
        Me.txtserial.Name = "txtserial"
        Me.txtserial.Size = New System.Drawing.Size(280, 21)
        Me.txtserial.TabIndex = 19
        '
        'lblRazao
        '
        Me.lblRazao.AutoSize = True
        Me.lblRazao.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRazao.Location = New System.Drawing.Point(141, 18)
        Me.lblRazao.Name = "lblRazao"
        Me.lblRazao.Size = New System.Drawing.Size(16, 15)
        Me.lblRazao.TabIndex = 18
        Me.lblRazao.Text = "..."
        '
        'lblRazaoAtivacao
        '
        Me.lblRazaoAtivacao.AutoSize = True
        Me.lblRazaoAtivacao.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazaoAtivacao.Location = New System.Drawing.Point(13, 18)
        Me.lblRazaoAtivacao.Name = "lblRazaoAtivacao"
        Me.lblRazaoAtivacao.Size = New System.Drawing.Size(83, 15)
        Me.lblRazaoAtivacao.TabIndex = 17
        Me.lblRazaoAtivacao.Text = "Razão Social:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Código de Ativação:"
        '
        'lblCnpj
        '
        Me.lblCnpj.AutoSize = True
        Me.lblCnpj.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCnpj.Location = New System.Drawing.Point(141, 41)
        Me.lblCnpj.Name = "lblCnpj"
        Me.lblCnpj.Size = New System.Drawing.Size(16, 15)
        Me.lblCnpj.TabIndex = 14
        Me.lblCnpj.Text = "..."
        '
        'lblcnpjLabel
        '
        Me.lblcnpjLabel.AutoSize = True
        Me.lblcnpjLabel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcnpjLabel.Location = New System.Drawing.Point(13, 41)
        Me.lblcnpjLabel.Name = "lblcnpjLabel"
        Me.lblcnpjLabel.Size = New System.Drawing.Size(41, 15)
        Me.lblcnpjLabel.TabIndex = 13
        Me.lblcnpjLabel.Text = "CNPJ:"
        '
        'frmAtivacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(435, 254)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btCodigoOnline)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdValidarAtivacao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAtivacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "| | MIXPDV | | - Ativação"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdValidarAtivacao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSair As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btCodigoOnline As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRazao As System.Windows.Forms.Label
    Friend WithEvents lblRazaoAtivacao As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCnpj As System.Windows.Forms.Label
    Friend WithEvents lblcnpjLabel As System.Windows.Forms.Label
    Friend WithEvents txtserial As System.Windows.Forms.MaskedTextBox
End Class
