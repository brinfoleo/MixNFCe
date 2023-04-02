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
        Me.cmdGravar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.txtData_cadastro = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.txtEndereco = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodigo = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkBloqueado = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.cmdAplicar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExcluir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdLimpar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdGravar
        '
        Me.cmdGravar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmdGravar.Image = CType(resources.GetObject("cmdGravar.Image"), System.Drawing.Image)
        Me.cmdGravar.Location = New System.Drawing.Point(143, 322)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(126, 59)
        Me.cmdGravar.TabIndex = 182
        Me.cmdGravar.Text = "&Gravar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cmdGravar)
        Me.GroupControl1.Controls.Add(Me.TabControl1)
        Me.GroupControl1.Controls.Add(Me.cmdAplicar)
        Me.GroupControl1.Controls.Add(Me.cmdExcluir)
        Me.GroupControl1.Controls.Add(Me.cmdLimpar)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(549, 391)
        Me.GroupControl1.TabIndex = 186
        Me.GroupControl1.Text = "Cadastro de Cliente"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(539, 292)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
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
        Me.TabPage1.Controls.Add(Me.txtData_cadastro)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.txtTelefone)
        Me.TabPage1.Controls.Add(Me.txtCep)
        Me.TabPage1.Controls.Add(Me.txtEndereco)
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.chkBloqueado)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(531, 266)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label28.Location = New System.Drawing.Point(67, 87)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(71, 13)
        Me.Label28.TabIndex = 228
        Me.Label28.Text = "Complemento"
        '
        'txtCompl
        '
        Me.txtCompl.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCompl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCompl.Location = New System.Drawing.Point(67, 102)
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.Size = New System.Drawing.Size(211, 20)
        Me.txtCompl.TabIndex = 5
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.Location = New System.Drawing.Point(353, 126)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(59, 13)
        Me.Label27.TabIndex = 227
        Me.Label27.Text = "CNPJ/CPF"
        '
        'txtCnpj
        '
        Me.txtCnpj.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCnpj.Location = New System.Drawing.Point(350, 142)
        Me.txtCnpj.Name = "txtCnpj"
        Me.txtCnpj.Size = New System.Drawing.Size(172, 20)
        Me.txtCnpj.TabIndex = 10
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label26.Location = New System.Drawing.Point(191, 126)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 13)
        Me.Label26.TabIndex = 226
        Me.Label26.Text = "Cód.Município"
        '
        'txtCodmun
        '
        Me.txtCodmun.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodmun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodmun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCodmun.Location = New System.Drawing.Point(191, 142)
        Me.txtCodmun.Name = "txtCodmun"
        Me.txtCodmun.Size = New System.Drawing.Size(155, 20)
        Me.txtCodmun.TabIndex = 9
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label25.Location = New System.Drawing.Point(150, 126)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(21, 13)
        Me.Label25.TabIndex = 225
        Me.Label25.Text = "UF"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label24.Location = New System.Drawing.Point(5, 126)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 13)
        Me.Label24.TabIndex = 224
        Me.Label24.Text = "Cidade"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label23.Location = New System.Drawing.Point(285, 87)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 13)
        Me.Label23.TabIndex = 223
        Me.Label23.Text = "Bairro"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label22.Location = New System.Drawing.Point(5, 87)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 13)
        Me.Label22.TabIndex = 222
        Me.Label22.Text = "Número"
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtEstado.Location = New System.Drawing.Point(147, 142)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(30, 20)
        Me.txtEstado.TabIndex = 8
        '
        'txtCidade
        '
        Me.txtCidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCidade.Location = New System.Drawing.Point(5, 142)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(133, 20)
        Me.txtCidade.TabIndex = 7
        '
        'txtBairro
        '
        Me.txtBairro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtBairro.Location = New System.Drawing.Point(284, 102)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(238, 20)
        Me.txtBairro.TabIndex = 6
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNumero.Location = New System.Drawing.Point(5, 102)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(56, 20)
        Me.txtNumero.TabIndex = 4
        '
        'cmdBuscaCep
        '
        Me.cmdBuscaCep.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmdBuscaCep.Image = CType(resources.GetObject("cmdBuscaCep.Image"), System.Drawing.Image)
        Me.cmdBuscaCep.Location = New System.Drawing.Point(90, 63)
        Me.cmdBuscaCep.Name = "cmdBuscaCep"
        Me.cmdBuscaCep.Size = New System.Drawing.Size(24, 20)
        Me.cmdBuscaCep.TabIndex = 21
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNome.Location = New System.Drawing.Point(65, 25)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(457, 20)
        Me.txtNome.TabIndex = 1
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtObs.Location = New System.Drawing.Point(5, 225)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(517, 31)
        Me.txtObs.TabIndex = 19
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label21.Location = New System.Drawing.Point(5, 209)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 13)
        Me.Label21.TabIndex = 88
        Me.Label21.Text = "Observação"
        '
        'txtData_cadastro
        '
        Me.txtData_cadastro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtData_cadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData_cadastro.Enabled = False
        Me.txtData_cadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtData_cadastro.Location = New System.Drawing.Point(430, 182)
        Me.txtData_cadastro.Mask = "00/00/0000"
        Me.txtData_cadastro.Name = "txtData_cadastro"
        Me.txtData_cadastro.Size = New System.Drawing.Size(92, 20)
        Me.txtData_cadastro.TabIndex = 16
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtEmail.Location = New System.Drawing.Point(5, 185)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(230, 20)
        Me.txtEmail.TabIndex = 15
        '
        'txtTelefone
        '
        Me.txtTelefone.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTelefone.Location = New System.Drawing.Point(271, 182)
        Me.txtTelefone.Mask = "(00) 0000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(125, 20)
        Me.txtTelefone.TabIndex = 13
        '
        'txtCep
        '
        Me.txtCep.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCep.Location = New System.Drawing.Point(5, 63)
        Me.txtCep.Mask = "00000-000"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(84, 20)
        Me.txtCep.TabIndex = 3
        '
        'txtEndereco
        '
        Me.txtEndereco.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtEndereco.Location = New System.Drawing.Point(118, 63)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(404, 20)
        Me.txtEndereco.TabIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCodigo.Location = New System.Drawing.Point(5, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(5, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "E-Mail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(5, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "CEP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Código"
        '
        'chkBloqueado
        '
        Me.chkBloqueado.AutoSize = True
        Me.chkBloqueado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.chkBloqueado.Location = New System.Drawing.Point(445, 7)
        Me.chkBloqueado.Name = "chkBloqueado"
        Me.chkBloqueado.Size = New System.Drawing.Size(77, 17)
        Me.chkBloqueado.TabIndex = 20
        Me.chkBloqueado.Text = "Bloqueado"
        Me.chkBloqueado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(62, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(118, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Endereço"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(268, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Telefone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(428, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Data Cadastro"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.GroupControl2)
        Me.TabPage2.Controls.Add(Me.txtPesquisa)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(531, 266)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pesquisa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(3, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 184
        Me.Label4.Text = "Código"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.dgvLista)
        Me.GroupControl2.Location = New System.Drawing.Point(3, 46)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(525, 218)
        Me.GroupControl2.TabIndex = 179
        Me.GroupControl2.Text = "&Listagem de Clientes"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLista.GridColor = System.Drawing.Color.Black
        Me.dgvLista.Location = New System.Drawing.Point(2, 21)
        Me.dgvLista.Name = "dgvLista"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista.Size = New System.Drawing.Size(521, 195)
        Me.dgvLista.TabIndex = 182
        '
        'txtPesquisa
        '
        Me.txtPesquisa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtPesquisa.Location = New System.Drawing.Point(5, 20)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(521, 20)
        Me.txtPesquisa.TabIndex = 183
        '
        'cmdAplicar
        '
        Me.cmdAplicar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmdAplicar.Image = CType(resources.GetObject("cmdAplicar.Image"), System.Drawing.Image)
        Me.cmdAplicar.Location = New System.Drawing.Point(6, 322)
        Me.cmdAplicar.Name = "cmdAplicar"
        Me.cmdAplicar.Size = New System.Drawing.Size(126, 59)
        Me.cmdAplicar.TabIndex = 183
        Me.cmdAplicar.Text = "&Aplicar"
        '
        'cmdExcluir
        '
        Me.cmdExcluir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmdExcluir.Image = CType(resources.GetObject("cmdExcluir.Image"), System.Drawing.Image)
        Me.cmdExcluir.Location = New System.Drawing.Point(280, 322)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(126, 59)
        Me.cmdExcluir.TabIndex = 184
        Me.cmdExcluir.Text = "&Excluir"
        '
        'cmdLimpar
        '
        Me.cmdLimpar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmdLimpar.Image = CType(resources.GetObject("cmdLimpar.Image"), System.Drawing.Image)
        Me.cmdLimpar.Location = New System.Drawing.Point(416, 322)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(126, 59)
        Me.cmdLimpar.TabIndex = 185
        Me.cmdLimpar.Text = "&Limpar"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(549, 391)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(175, 150)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MIXPDV"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdGravar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
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
    Friend WithEvents cmdBuscaCep As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtData_cadastro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmail As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkBloqueado As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents cmdExcluir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAplicar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdLimpar As DevExpress.XtraEditors.SimpleButton

End Class
