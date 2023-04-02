<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkBloqueado = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rdbjud = New System.Windows.Forms.RadioButton()
        Me.rdbfis = New System.Windows.Forms.RadioButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtCompl = New System.Windows.Forms.MaskedTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtCnpj = New System.Windows.Forms.MaskedTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtCodmun = New System.Windows.Forms.MaskedTextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.MaskedTextBox()
        Me.txtCidade = New System.Windows.Forms.MaskedTextBox()
        Me.txtBairro = New System.Windows.Forms.MaskedTextBox()
        Me.txtNumero = New System.Windows.Forms.MaskedTextBox()
        Me.cmdBuscaCep = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDebito = New System.Windows.Forms.MaskedTextBox()
        Me.txtLim_debito = New System.Windows.Forms.MaskedTextBox()
        Me.txtData_cadastro = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtRg = New System.Windows.Forms.MaskedTextBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.txtEndereco = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodigo = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtDt_final = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDt_inicial = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Rdbtodos = New System.Windows.Forms.RadioButton()
        Me.Rdbquitado = New System.Windows.Forms.RadioButton()
        Me.Rdbaberto = New System.Windows.Forms.RadioButton()
        Me.cmdPesquisarD = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdQuitarD = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExcluirD = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdIncluirD = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNovoDebito = New DevExpress.XtraEditors.SimpleButton()
        Me.pnDebito = New System.Windows.Forms.Panel()
        Me.txtDt_pag = New System.Windows.Forms.MaskedTextBox()
        Me.txtDt_venc = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.MaskedTextBox()
        Me.txtResponsavel = New System.Windows.Forms.MaskedTextBox()
        Me.txtDescricao = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DgvDebito = New System.Windows.Forms.DataGridView()
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.cmdGravar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPesquisar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExcluir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdLimpar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnDebito.SuspendLayout()
        CType(Me.DgvDebito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(116, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 13)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "RG"
        '
        'chkBloqueado
        '
        Me.chkBloqueado.AutoSize = True
        Me.chkBloqueado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkBloqueado.Location = New System.Drawing.Point(459, 11)
        Me.chkBloqueado.Name = "chkBloqueado"
        Me.chkBloqueado.Size = New System.Drawing.Size(77, 17)
        Me.chkBloqueado.TabIndex = 20
        Me.chkBloqueado.Text = "Bloqueado"
        Me.chkBloqueado.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(446, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Débito $"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(350, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Limite de Debito $"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(251, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Data Cadastro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(282, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Telefone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(19, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(140, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Endereço"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(76, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Código"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(566, 387)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.rdbjud)
        Me.TabPage1.Controls.Add(Me.rdbfis)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.txtCompl)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.txtCnpj)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.txtCodmun)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.txtEstado)
        Me.TabPage1.Controls.Add(Me.txtCidade)
        Me.TabPage1.Controls.Add(Me.txtBairro)
        Me.TabPage1.Controls.Add(Me.txtNumero)
        Me.TabPage1.Controls.Add(Me.cmdBuscaCep)
        Me.TabPage1.Controls.Add(Me.txtNome)
        Me.TabPage1.Controls.Add(Me.txtObs)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.txtDebito)
        Me.TabPage1.Controls.Add(Me.txtLim_debito)
        Me.TabPage1.Controls.Add(Me.txtData_cadastro)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.txtCelular)
        Me.TabPage1.Controls.Add(Me.txtTelefone)
        Me.TabPage1.Controls.Add(Me.txtRg)
        Me.TabPage1.Controls.Add(Me.txtCpf)
        Me.TabPage1.Controls.Add(Me.txtCep)
        Me.TabPage1.Controls.Add(Me.txtEndereco)
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.chkBloqueado)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(558, 361)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro"
        '
        'rdbjud
        '
        Me.rdbjud.AutoSize = True
        Me.rdbjud.Location = New System.Drawing.Point(391, 11)
        Me.rdbjud.Name = "rdbjud"
        Me.rdbjud.Size = New System.Drawing.Size(61, 17)
        Me.rdbjud.TabIndex = 1
        Me.rdbjud.Text = "Júridica"
        Me.rdbjud.UseVisualStyleBackColor = True
        '
        'rdbfis
        '
        Me.rdbfis.AutoSize = True
        Me.rdbfis.Checked = True
        Me.rdbfis.Location = New System.Drawing.Point(311, 11)
        Me.rdbfis.Name = "rdbfis"
        Me.rdbfis.Size = New System.Drawing.Size(54, 17)
        Me.rdbfis.TabIndex = 0
        Me.rdbfis.TabStop = True
        Me.rdbfis.Text = "Física"
        Me.rdbfis.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label28.Location = New System.Drawing.Point(81, 96)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(71, 13)
        Me.Label28.TabIndex = 228
        Me.Label28.Text = "Complemento"
        '
        'txtCompl
        '
        Me.txtCompl.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCompl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCompl.Location = New System.Drawing.Point(81, 111)
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.Size = New System.Drawing.Size(211, 20)
        Me.txtCompl.TabIndex = 5
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.Location = New System.Drawing.Point(367, 135)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(28, 13)
        Me.Label27.TabIndex = 227
        Me.Label27.Text = "Cnpj"
        '
        'txtCnpj
        '
        Me.txtCnpj.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCnpj.Location = New System.Drawing.Point(364, 151)
        Me.txtCnpj.Mask = "00,000,000/0000-00"
        Me.txtCnpj.Name = "txtCnpj"
        Me.txtCnpj.Size = New System.Drawing.Size(172, 20)
        Me.txtCnpj.TabIndex = 10
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label26.Location = New System.Drawing.Point(205, 135)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 13)
        Me.Label26.TabIndex = 226
        Me.Label26.Text = "Cód.Município"
        '
        'txtCodmun
        '
        Me.txtCodmun.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodmun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCodmun.Location = New System.Drawing.Point(205, 151)
        Me.txtCodmun.Name = "txtCodmun"
        Me.txtCodmun.Size = New System.Drawing.Size(155, 20)
        Me.txtCodmun.TabIndex = 9
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label25.Location = New System.Drawing.Point(165, 135)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(21, 13)
        Me.Label25.TabIndex = 225
        Me.Label25.Text = "UF"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label24.Location = New System.Drawing.Point(19, 135)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 13)
        Me.Label24.TabIndex = 224
        Me.Label24.Text = "Cidade"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label23.Location = New System.Drawing.Point(299, 96)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 13)
        Me.Label23.TabIndex = 223
        Me.Label23.Text = "Bairro"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label22.Location = New System.Drawing.Point(19, 96)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 13)
        Me.Label22.TabIndex = 222
        Me.Label22.Text = "Número"
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtEstado.Location = New System.Drawing.Point(161, 151)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(30, 20)
        Me.txtEstado.TabIndex = 8
        '
        'txtCidade
        '
        Me.txtCidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCidade.Location = New System.Drawing.Point(19, 151)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(133, 20)
        Me.txtCidade.TabIndex = 7
        '
        'txtBairro
        '
        Me.txtBairro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtBairro.Location = New System.Drawing.Point(298, 111)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(238, 20)
        Me.txtBairro.TabIndex = 6
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNumero.Location = New System.Drawing.Point(19, 111)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(56, 20)
        Me.txtNumero.TabIndex = 4
        '
        'cmdBuscaCep
        '
        Me.cmdBuscaCep.Image = CType(resources.GetObject("cmdBuscaCep.Image"), System.Drawing.Image)
        Me.cmdBuscaCep.Location = New System.Drawing.Point(107, 71)
        Me.cmdBuscaCep.Name = "cmdBuscaCep"
        Me.cmdBuscaCep.Size = New System.Drawing.Size(25, 23)
        Me.cmdBuscaCep.TabIndex = 21
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNome.Location = New System.Drawing.Point(79, 34)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(457, 20)
        Me.txtNome.TabIndex = 1
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtObs.Location = New System.Drawing.Point(19, 287)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(517, 54)
        Me.txtObs.TabIndex = 19
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label21.Location = New System.Drawing.Point(19, 271)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 13)
        Me.Label21.TabIndex = 88
        Me.Label21.Text = "Observação"
        '
        'txtDebito
        '
        Me.txtDebito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDebito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDebito.Location = New System.Drawing.Point(446, 237)
        Me.txtDebito.Name = "txtDebito"
        Me.txtDebito.Size = New System.Drawing.Size(88, 20)
        Me.txtDebito.TabIndex = 18
        Me.txtDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLim_debito
        '
        Me.txtLim_debito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLim_debito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtLim_debito.Location = New System.Drawing.Point(353, 237)
        Me.txtLim_debito.Name = "txtLim_debito"
        Me.txtLim_debito.Size = New System.Drawing.Size(89, 20)
        Me.txtLim_debito.TabIndex = 17
        Me.txtLim_debito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtData_cadastro
        '
        Me.txtData_cadastro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtData_cadastro.Enabled = False
        Me.txtData_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtData_cadastro.Location = New System.Drawing.Point(253, 237)
        Me.txtData_cadastro.Mask = "00/00/0000"
        Me.txtData_cadastro.Name = "txtData_cadastro"
        Me.txtData_cadastro.Size = New System.Drawing.Size(92, 20)
        Me.txtData_cadastro.TabIndex = 16
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtEmail.Location = New System.Drawing.Point(19, 237)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(230, 20)
        Me.txtEmail.TabIndex = 15
        '
        'txtCelular
        '
        Me.txtCelular.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCelular.Location = New System.Drawing.Point(418, 191)
        Me.txtCelular.Mask = "(00) 0000-0000"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(117, 20)
        Me.txtCelular.TabIndex = 14
        '
        'txtTelefone
        '
        Me.txtTelefone.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTelefone.Location = New System.Drawing.Point(285, 191)
        Me.txtTelefone.Mask = "(00) 0000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(125, 20)
        Me.txtTelefone.TabIndex = 13
        '
        'txtRg
        '
        Me.txtRg.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtRg.Location = New System.Drawing.Point(117, 191)
        Me.txtRg.Name = "txtRg"
        Me.txtRg.Size = New System.Drawing.Size(132, 20)
        Me.txtRg.TabIndex = 12
        '
        'txtCpf
        '
        Me.txtCpf.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCpf.Location = New System.Drawing.Point(19, 191)
        Me.txtCpf.Mask = "000,000,000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(92, 20)
        Me.txtCpf.TabIndex = 11
        '
        'txtCep
        '
        Me.txtCep.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCep.Location = New System.Drawing.Point(19, 72)
        Me.txtCep.Mask = "00000-000"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(84, 20)
        Me.txtCep.TabIndex = 3
        '
        'txtEndereco
        '
        Me.txtEndereco.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtEndereco.Location = New System.Drawing.Point(140, 72)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(396, 20)
        Me.txtEndereco.TabIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCodigo.Location = New System.Drawing.Point(19, 34)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(418, 176)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 13)
        Me.Label17.TabIndex = 75
        Me.Label17.Text = "Celular"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(19, 217)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "E-Mail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(19, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "CEP"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.GroupControl2)
        Me.TabPage2.Controls.Add(Me.cmdQuitarD)
        Me.TabPage2.Controls.Add(Me.cmdExcluirD)
        Me.TabPage2.Controls.Add(Me.cmdIncluirD)
        Me.TabPage2.Controls.Add(Me.cmdNovoDebito)
        Me.TabPage2.Controls.Add(Me.pnDebito)
        Me.TabPage2.Controls.Add(Me.DgvDebito)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(558, 361)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Débito"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtDt_final)
        Me.GroupControl2.Controls.Add(Me.Label13)
        Me.GroupControl2.Controls.Add(Me.Label18)
        Me.GroupControl2.Controls.Add(Me.txtDt_inicial)
        Me.GroupControl2.Controls.Add(Me.Panel1)
        Me.GroupControl2.Controls.Add(Me.cmdPesquisarD)
        Me.GroupControl2.Location = New System.Drawing.Point(9, 256)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(539, 98)
        Me.GroupControl2.TabIndex = 97
        Me.GroupControl2.Text = "Filtro de Pesquisa"
        '
        'txtDt_final
        '
        Me.txtDt_final.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDt_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDt_final.Location = New System.Drawing.Point(157, 41)
        Me.txtDt_final.Mask = "00/00/0000"
        Me.txtDt_final.Name = "txtDt_final"
        Me.txtDt_final.Size = New System.Drawing.Size(98, 20)
        Me.txtDt_final.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(14, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Data Inicial"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.Location = New System.Drawing.Point(157, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 82
        Me.Label18.Text = "Data Final"
        '
        'txtDt_inicial
        '
        Me.txtDt_inicial.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDt_inicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDt_inicial.Location = New System.Drawing.Point(14, 41)
        Me.txtDt_inicial.Mask = "00/00/0000"
        Me.txtDt_inicial.Name = "txtDt_inicial"
        Me.txtDt_inicial.Size = New System.Drawing.Size(98, 20)
        Me.txtDt_inicial.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Rdbtodos)
        Me.Panel1.Controls.Add(Me.Rdbquitado)
        Me.Panel1.Controls.Add(Me.Rdbaberto)
        Me.Panel1.Location = New System.Drawing.Point(17, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 24)
        Me.Panel1.TabIndex = 88
        '
        'Rdbtodos
        '
        Me.Rdbtodos.AutoSize = True
        Me.Rdbtodos.Location = New System.Drawing.Point(172, 4)
        Me.Rdbtodos.Name = "Rdbtodos"
        Me.Rdbtodos.Size = New System.Drawing.Size(55, 17)
        Me.Rdbtodos.TabIndex = 2
        Me.Rdbtodos.TabStop = True
        Me.Rdbtodos.Text = "Todos"
        Me.Rdbtodos.UseVisualStyleBackColor = True
        '
        'Rdbquitado
        '
        Me.Rdbquitado.AutoSize = True
        Me.Rdbquitado.Location = New System.Drawing.Point(87, 3)
        Me.Rdbquitado.Name = "Rdbquitado"
        Me.Rdbquitado.Size = New System.Drawing.Size(67, 17)
        Me.Rdbquitado.TabIndex = 1
        Me.Rdbquitado.TabStop = True
        Me.Rdbquitado.Text = "Quitados"
        Me.Rdbquitado.UseVisualStyleBackColor = True
        '
        'Rdbaberto
        '
        Me.Rdbaberto.AutoSize = True
        Me.Rdbaberto.Location = New System.Drawing.Point(3, 4)
        Me.Rdbaberto.Name = "Rdbaberto"
        Me.Rdbaberto.Size = New System.Drawing.Size(74, 17)
        Me.Rdbaberto.TabIndex = 18
        Me.Rdbaberto.TabStop = True
        Me.Rdbaberto.Text = "Em Aberto"
        Me.Rdbaberto.UseVisualStyleBackColor = True
        '
        'cmdPesquisarD
        '
        Me.cmdPesquisarD.Image = CType(resources.GetObject("cmdPesquisarD.Image"), System.Drawing.Image)
        Me.cmdPesquisarD.Location = New System.Drawing.Point(392, 37)
        Me.cmdPesquisarD.Name = "cmdPesquisarD"
        Me.cmdPesquisarD.Size = New System.Drawing.Size(137, 49)
        Me.cmdPesquisarD.TabIndex = 92
        Me.cmdPesquisarD.Text = "&Pesquisar Débito"
        '
        'cmdQuitarD
        '
        Me.cmdQuitarD.Image = CType(resources.GetObject("cmdQuitarD.Image"), System.Drawing.Image)
        Me.cmdQuitarD.Location = New System.Drawing.Point(437, 103)
        Me.cmdQuitarD.Name = "cmdQuitarD"
        Me.cmdQuitarD.Size = New System.Drawing.Size(111, 32)
        Me.cmdQuitarD.TabIndex = 96
        Me.cmdQuitarD.Text = "&Quitar"
        '
        'cmdExcluirD
        '
        Me.cmdExcluirD.Image = CType(resources.GetObject("cmdExcluirD.Image"), System.Drawing.Image)
        Me.cmdExcluirD.Location = New System.Drawing.Point(323, 103)
        Me.cmdExcluirD.Name = "cmdExcluirD"
        Me.cmdExcluirD.Size = New System.Drawing.Size(112, 33)
        Me.cmdExcluirD.TabIndex = 95
        Me.cmdExcluirD.Text = "&Excluir"
        '
        'cmdIncluirD
        '
        Me.cmdIncluirD.Image = CType(resources.GetObject("cmdIncluirD.Image"), System.Drawing.Image)
        Me.cmdIncluirD.Location = New System.Drawing.Point(209, 103)
        Me.cmdIncluirD.Name = "cmdIncluirD"
        Me.cmdIncluirD.Size = New System.Drawing.Size(112, 34)
        Me.cmdIncluirD.TabIndex = 94
        Me.cmdIncluirD.Text = "Incluir &Débito"
        '
        'cmdNovoDebito
        '
        Me.cmdNovoDebito.Image = CType(resources.GetObject("cmdNovoDebito.Image"), System.Drawing.Image)
        Me.cmdNovoDebito.Location = New System.Drawing.Point(9, 101)
        Me.cmdNovoDebito.Name = "cmdNovoDebito"
        Me.cmdNovoDebito.Size = New System.Drawing.Size(106, 34)
        Me.cmdNovoDebito.TabIndex = 93
        Me.cmdNovoDebito.Text = "&Alterar"
        '
        'pnDebito
        '
        Me.pnDebito.Controls.Add(Me.txtDt_pag)
        Me.pnDebito.Controls.Add(Me.txtDt_venc)
        Me.pnDebito.Controls.Add(Me.Label19)
        Me.pnDebito.Controls.Add(Me.Label20)
        Me.pnDebito.Controls.Add(Me.txtValor)
        Me.pnDebito.Controls.Add(Me.txtResponsavel)
        Me.pnDebito.Controls.Add(Me.txtDescricao)
        Me.pnDebito.Controls.Add(Me.Label16)
        Me.pnDebito.Controls.Add(Me.Label15)
        Me.pnDebito.Controls.Add(Me.Label14)
        Me.pnDebito.Enabled = False
        Me.pnDebito.Location = New System.Drawing.Point(-2, 5)
        Me.pnDebito.Name = "pnDebito"
        Me.pnDebito.Size = New System.Drawing.Size(560, 87)
        Me.pnDebito.TabIndex = 89
        '
        'txtDt_pag
        '
        Me.txtDt_pag.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDt_pag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDt_pag.Location = New System.Drawing.Point(485, 59)
        Me.txtDt_pag.Mask = "00/00/0000"
        Me.txtDt_pag.Name = "txtDt_pag"
        Me.txtDt_pag.Size = New System.Drawing.Size(65, 20)
        Me.txtDt_pag.TabIndex = 14
        '
        'txtDt_venc
        '
        Me.txtDt_venc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDt_venc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDt_venc.Location = New System.Drawing.Point(412, 59)
        Me.txtDt_venc.Mask = "00/00/0000"
        Me.txtDt_venc.Name = "txtDt_venc"
        Me.txtDt_venc.Size = New System.Drawing.Size(65, 20)
        Me.txtDt_venc.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(485, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 13)
        Me.Label19.TabIndex = 96
        Me.Label19.Text = "Data Pag."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(412, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 13)
        Me.Label20.TabIndex = 95
        Me.Label20.Text = "Data Venc."
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtValor.Location = New System.Drawing.Point(339, 59)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(69, 20)
        Me.txtValor.TabIndex = 15
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtResponsavel
        '
        Me.txtResponsavel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtResponsavel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtResponsavel.Location = New System.Drawing.Point(11, 60)
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.Size = New System.Drawing.Size(322, 20)
        Me.txtResponsavel.TabIndex = 12
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDescricao.Location = New System.Drawing.Point(11, 21)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(539, 20)
        Me.txtDescricao.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(338, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "Valor $"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(11, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 13)
        Me.Label15.TabIndex = 93
        Me.Label15.Text = "Responsável Pelo Débito"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(11, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "Descrição "
        '
        'DgvDebito
        '
        Me.DgvDebito.AllowUserToAddRows = False
        Me.DgvDebito.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DgvDebito.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDebito.BackgroundColor = System.Drawing.Color.Silver
        Me.DgvDebito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvDebito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDebito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvDebito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDebito.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvDebito.GridColor = System.Drawing.Color.Black
        Me.DgvDebito.Location = New System.Drawing.Point(9, 146)
        Me.DgvDebito.Name = "DgvDebito"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDebito.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvDebito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDebito.Size = New System.Drawing.Size(539, 104)
        Me.DgvDebito.TabIndex = 11
        '
        'lblMensagem
        '
        Me.lblMensagem.AutoSize = True
        Me.lblMensagem.Location = New System.Drawing.Point(221, 133)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(39, 13)
        Me.lblMensagem.TabIndex = 88
        Me.lblMensagem.Text = "Label8"
        Me.lblMensagem.Visible = False
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = CType(resources.GetObject("cmdGravar.Image"), System.Drawing.Image)
        Me.cmdGravar.Location = New System.Drawing.Point(6, 442)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(140, 59)
        Me.cmdGravar.TabIndex = 89
        Me.cmdGravar.Text = "&Gravar"
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.Image = CType(resources.GetObject("cmdPesquisar.Image"), System.Drawing.Image)
        Me.cmdPesquisar.Location = New System.Drawing.Point(154, 442)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(140, 59)
        Me.cmdPesquisar.TabIndex = 90
        Me.cmdPesquisar.Text = "&Pesquisar"
        '
        'cmdExcluir
        '
        Me.cmdExcluir.Image = CType(resources.GetObject("cmdExcluir.Image"), System.Drawing.Image)
        Me.cmdExcluir.Location = New System.Drawing.Point(302, 442)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(140, 59)
        Me.cmdExcluir.TabIndex = 91
        Me.cmdExcluir.Text = "&Excluir"
        '
        'cmdLimpar
        '
        Me.cmdLimpar.Image = CType(resources.GetObject("cmdLimpar.Image"), System.Drawing.Image)
        Me.cmdLimpar.Location = New System.Drawing.Point(450, 442)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(140, 59)
        Me.cmdLimpar.TabIndex = 92
        Me.cmdLimpar.Text = "&Limpar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TabControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(4, 10)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(589, 417)
        Me.GroupControl1.TabIndex = 94
        Me.GroupControl1.Text = "Cadastro de Cliente"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(601, 507)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.cmdLimpar)
        Me.Controls.Add(Me.cmdExcluir)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.lblMensagem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "| | Express - PDVControl | |"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnDebito.ResumeLayout(False)
        Me.pnDebito.PerformLayout()
        CType(Me.DgvDebito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkBloqueado As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DgvDebito As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmail As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtRg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDebito As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtLim_debito As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtData_cadastro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDt_final As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDt_inicial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblMensagem As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Rdbtodos As System.Windows.Forms.RadioButton
    Friend WithEvents Rdbquitado As System.Windows.Forms.RadioButton
    Friend WithEvents Rdbaberto As System.Windows.Forms.RadioButton
    Friend WithEvents pnDebito As System.Windows.Forms.Panel
    Friend WithEvents txtDt_pag As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDt_venc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtResponsavel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDescricao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscaCep As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPesquisarD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNovoDebito As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdIncluirD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExcluirD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdQuitarD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGravar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPesquisar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExcluir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdLimpar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtCompl As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtCnpj As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtCodmun As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCidade As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtBairro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNumero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rdbjud As System.Windows.Forms.RadioButton
    Friend WithEvents rdbfis As System.Windows.Forms.RadioButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
