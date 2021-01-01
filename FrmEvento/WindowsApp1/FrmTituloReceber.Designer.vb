<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTituloReceber
    Inherits Controles.FrmCad1Padrao

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTituloReceber))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCadSacado = New System.Windows.Forms.Button()
        Me.TxbCodSacado = New Controles.TxbCodigo()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BtnBuscaSacado = New System.Windows.Forms.Button()
        Me.TxbNomSacado = New System.Windows.Forms.TextBox()
        Me.BtnCadTipoCobranca = New System.Windows.Forms.Button()
        Me.TxbCodTipoCobranca = New Controles.TxbCodigo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnBuscaTipoCobranca = New System.Windows.Forms.Button()
        Me.TxbDesTipoCobranca = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BtnDtaFinalLiquidacao = New System.Windows.Forms.Button()
        Me.DtpDtaLiquidacao = New System.Windows.Forms.DateTimePicker()
        Me.TxbDtaLiquidacao = New Controles.TxbData()
        Me.TxbValLiquidado = New Controles.TxbMonetario()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnDtaVenctoFinal = New System.Windows.Forms.Button()
        Me.TxbDtaVecto = New Controles.TxbData()
        Me.DtpDtaVecto = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxbObservacao = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TxbValOriginal = New Controles.TxbMonetario()
        Me.TxbValJurosOriginal = New Controles.TxbMonetario()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnEmissaoFinal = New System.Windows.Forms.Button()
        Me.TxbDtaEmissao = New Controles.TxbData()
        Me.DtpDtaEmissao = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CkbTodasEmpresa = New System.Windows.Forms.CheckBox()
        Me.CkbTipoManual = New System.Windows.Forms.CheckBox()
        Me.CkbTipoNotaFiscal = New System.Windows.Forms.CheckBox()
        Me.CkbTipoCartaoCredito = New System.Windows.Forms.CheckBox()
        Me.CkbTipoReceita = New System.Windows.Forms.CheckBox()
        Me.CkbTipoAdiantaFunc = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.CkbPeStatus = New System.Windows.Forms.CheckBox()
        Me.RbStatusLiquidado = New System.Windows.Forms.RadioButton()
        Me.RbStatusProtesto = New System.Windows.Forms.RadioButton()
        Me.RbStatusNegociado = New System.Windows.Forms.RadioButton()
        Me.RbStatusFaturado = New System.Windows.Forms.RadioButton()
        Me.RbStatusAberto = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.RbFaturaNao = New System.Windows.Forms.RadioButton()
        Me.RbFaturaSim = New System.Windows.Forms.RadioButton()
        Me.CkbPeFatura = New System.Windows.Forms.CheckBox()
        Me.BtnPrincipal = New System.Windows.Forms.Button()
        Me.BtnLiquidacao = New System.Windows.Forms.Button()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.CkbPeTipo = New System.Windows.Forms.CheckBox()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Size = New System.Drawing.Size(618, 46)
        '
        'BtnCsv
        '
        '
        'BtnUltimoReg
        '
        Me.BtnUltimoReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        '
        'BtnAnterior
        '
        '
        'BtnProximo
        '
        '
        'BtnPrimeiroReg
        '
        '
        'BtnGrid
        '
        Me.BtnGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        '
        'BtnPesquisa
        '
        '
        'BtnLimpar
        '
        '
        'BtnSalvar
        '
        '
        'BtnExcluir
        '
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(133, 24)
        Me.TabControl1.Size = New System.Drawing.Size(492, 319)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TxbObservacao)
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Size = New System.Drawing.Size(484, 293)
        Me.TabPage1.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.TabPage1.Controls.SetChildIndex(Me.GroupBox5, 0)
        Me.TabPage1.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.TabPage1.Controls.SetChildIndex(Me.GroupBox6, 0)
        Me.TabPage1.Controls.SetChildIndex(Me.GroupBox7, 0)
        Me.TabPage1.Controls.SetChildIndex(Me.Label11, 0)
        Me.TabPage1.Controls.SetChildIndex(Me.GroupBox8, 0)
        Me.TabPage1.Controls.SetChildIndex(Me.TxbObservacao, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CkbPeTipo)
        Me.GroupBox1.Controls.Add(Me.CkbTipoAdiantaFunc)
        Me.GroupBox1.Controls.Add(Me.CkbTipoCartaoCredito)
        Me.GroupBox1.Controls.Add(Me.CkbTipoReceita)
        Me.GroupBox1.Controls.Add(Me.CkbTipoNotaFiscal)
        Me.GroupBox1.Controls.Add(Me.CkbTipoManual)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 184)
        Me.GroupBox1.Size = New System.Drawing.Size(265, 66)
        Me.GroupBox1.Text = "Tipo"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.CkbTodasEmpresa)
        Me.GroupBox4.Controls.Add(Me.BtnCadTipoCobranca)
        Me.GroupBox4.Controls.Add(Me.TxbCodTipoCobranca)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.BtnBuscaTipoCobranca)
        Me.GroupBox4.Controls.Add(Me.TxbDesTipoCobranca)
        Me.GroupBox4.Controls.Add(Me.BtnCadSacado)
        Me.GroupBox4.Controls.Add(Me.TxbCodSacado)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.BtnBuscaSacado)
        Me.GroupBox4.Controls.Add(Me.TxbNomSacado)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Size = New System.Drawing.Size(472, 84)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodigo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label18, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label1, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDescricao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbNomSacado, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnBuscaSacado, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label20, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodSacado, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnCadSacado, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDesTipoCobranca, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnBuscaTipoCobranca, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label2, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodTipoCobranca, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnCadTipoCobranca, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.CkbTodasEmpresa, 0)
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(0, 16)
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.Text = "Sequencia:"
        '
        'TabPage2
        '
        Me.TabPage2.Size = New System.Drawing.Size(484, 293)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(480, 314)
        '
        'TxbDescricao
        '
        Me.TxbDescricao.Location = New System.Drawing.Point(218, 12)
        Me.TxbDescricao.Size = New System.Drawing.Size(104, 20)
        '
        'TxbCodigo
        '
        Me.TxbCodigo.Location = New System.Drawing.Point(77, 12)
        Me.TxbCodigo.Size = New System.Drawing.Size(66, 20)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Numero:"
        '
        'BtnCadSacado
        '
        Me.BtnCadSacado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadSacado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadSacado.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCadSacado.Location = New System.Drawing.Point(444, 35)
        Me.BtnCadSacado.Name = "BtnCadSacado"
        Me.BtnCadSacado.Size = New System.Drawing.Size(23, 20)
        Me.BtnCadSacado.TabIndex = 63
        Me.BtnCadSacado.Tag = ""
        Me.BtnCadSacado.Text = "C"
        Me.BtnCadSacado.UseVisualStyleBackColor = True
        '
        'TxbCodSacado
        '
        Me.TxbCodSacado.Location = New System.Drawing.Point(77, 35)
        Me.TxbCodSacado.Name = "TxbCodSacado"
        Me.TxbCodSacado.Size = New System.Drawing.Size(66, 20)
        Me.TxbCodSacado.TabIndex = 59
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(0, 35)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 13)
        Me.Label20.TabIndex = 62
        Me.Label20.Text = "Sacado:"
        '
        'BtnBuscaSacado
        '
        Me.BtnBuscaSacado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaSacado.ForeColor = System.Drawing.Color.DimGray
        Me.BtnBuscaSacado.Image = CType(resources.GetObject("BtnBuscaSacado.Image"), System.Drawing.Image)
        Me.BtnBuscaSacado.Location = New System.Drawing.Point(418, 35)
        Me.BtnBuscaSacado.Name = "BtnBuscaSacado"
        Me.BtnBuscaSacado.Size = New System.Drawing.Size(23, 20)
        Me.BtnBuscaSacado.TabIndex = 61
        Me.BtnBuscaSacado.UseVisualStyleBackColor = True
        '
        'TxbNomSacado
        '
        Me.TxbNomSacado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomSacado.Location = New System.Drawing.Point(145, 35)
        Me.TxbNomSacado.Name = "TxbNomSacado"
        Me.TxbNomSacado.Size = New System.Drawing.Size(270, 20)
        Me.TxbNomSacado.TabIndex = 60
        '
        'BtnCadTipoCobranca
        '
        Me.BtnCadTipoCobranca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadTipoCobranca.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadTipoCobranca.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCadTipoCobranca.Location = New System.Drawing.Point(444, 58)
        Me.BtnCadTipoCobranca.Name = "BtnCadTipoCobranca"
        Me.BtnCadTipoCobranca.Size = New System.Drawing.Size(23, 20)
        Me.BtnCadTipoCobranca.TabIndex = 68
        Me.BtnCadTipoCobranca.Tag = ""
        Me.BtnCadTipoCobranca.Text = "C"
        Me.BtnCadTipoCobranca.UseVisualStyleBackColor = True
        '
        'TxbCodTipoCobranca
        '
        Me.TxbCodTipoCobranca.Location = New System.Drawing.Point(77, 58)
        Me.TxbCodTipoCobranca.Name = "TxbCodTipoCobranca"
        Me.TxbCodTipoCobranca.Size = New System.Drawing.Size(66, 20)
        Me.TxbCodTipoCobranca.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Tipo Cobrança:"
        '
        'BtnBuscaTipoCobranca
        '
        Me.BtnBuscaTipoCobranca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaTipoCobranca.ForeColor = System.Drawing.Color.DimGray
        Me.BtnBuscaTipoCobranca.Image = CType(resources.GetObject("BtnBuscaTipoCobranca.Image"), System.Drawing.Image)
        Me.BtnBuscaTipoCobranca.Location = New System.Drawing.Point(418, 58)
        Me.BtnBuscaTipoCobranca.Name = "BtnBuscaTipoCobranca"
        Me.BtnBuscaTipoCobranca.Size = New System.Drawing.Size(23, 20)
        Me.BtnBuscaTipoCobranca.TabIndex = 66
        Me.BtnBuscaTipoCobranca.UseVisualStyleBackColor = True
        '
        'TxbDesTipoCobranca
        '
        Me.TxbDesTipoCobranca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesTipoCobranca.Location = New System.Drawing.Point(145, 58)
        Me.TxbDesTipoCobranca.Name = "TxbDesTipoCobranca"
        Me.TxbDesTipoCobranca.Size = New System.Drawing.Size(270, 20)
        Me.TxbDesTipoCobranca.TabIndex = 65
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnDtaFinalLiquidacao)
        Me.GroupBox5.Controls.Add(Me.DtpDtaLiquidacao)
        Me.GroupBox5.Controls.Add(Me.TxbDtaLiquidacao)
        Me.GroupBox5.Controls.Add(Me.TxbValLiquidado)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.BtnDtaVenctoFinal)
        Me.GroupBox5.Controls.Add(Me.TxbDtaVecto)
        Me.GroupBox5.Controls.Add(Me.DtpDtaVecto)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 119)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(472, 38)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        '
        'BtnDtaFinalLiquidacao
        '
        Me.BtnDtaFinalLiquidacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDtaFinalLiquidacao.Font = New System.Drawing.Font("Bernard MT Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDtaFinalLiquidacao.ForeColor = System.Drawing.Color.DimGray
        Me.BtnDtaFinalLiquidacao.Location = New System.Drawing.Point(317, 12)
        Me.BtnDtaFinalLiquidacao.Name = "BtnDtaFinalLiquidacao"
        Me.BtnDtaFinalLiquidacao.Size = New System.Drawing.Size(14, 20)
        Me.BtnDtaFinalLiquidacao.TabIndex = 72
        Me.BtnDtaFinalLiquidacao.Text = "F"
        Me.BtnDtaFinalLiquidacao.UseVisualStyleBackColor = True
        '
        'DtpDtaLiquidacao
        '
        Me.DtpDtaLiquidacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaLiquidacao.Location = New System.Drawing.Point(301, 12)
        Me.DtpDtaLiquidacao.Name = "DtpDtaLiquidacao"
        Me.DtpDtaLiquidacao.Size = New System.Drawing.Size(14, 20)
        Me.DtpDtaLiquidacao.TabIndex = 71
        Me.DtpDtaLiquidacao.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'TxbDtaLiquidacao
        '
        Me.TxbDtaLiquidacao.Location = New System.Drawing.Point(233, 12)
        Me.TxbDtaLiquidacao.MaxLength = 10
        Me.TxbDtaLiquidacao.Name = "TxbDtaLiquidacao"
        Me.TxbDtaLiquidacao.Size = New System.Drawing.Size(66, 20)
        Me.TxbDtaLiquidacao.TabIndex = 69
        '
        'TxbValLiquidado
        '
        Me.TxbValLiquidado.Location = New System.Drawing.Point(400, 11)
        Me.TxbValLiquidado.Name = "TxbValLiquidado"
        Me.TxbValLiquidado.Size = New System.Drawing.Size(66, 20)
        Me.TxbValLiquidado.TabIndex = 65
        Me.TxbValLiquidado.Text = "0,00"
        Me.TxbValLiquidado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(329, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "R$ Liquidado:"
        '
        'BtnDtaVenctoFinal
        '
        Me.BtnDtaVenctoFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDtaVenctoFinal.Font = New System.Drawing.Font("Bernard MT Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDtaVenctoFinal.ForeColor = System.Drawing.Color.DimGray
        Me.BtnDtaVenctoFinal.Location = New System.Drawing.Point(161, 11)
        Me.BtnDtaVenctoFinal.Name = "BtnDtaVenctoFinal"
        Me.BtnDtaVenctoFinal.Size = New System.Drawing.Size(14, 20)
        Me.BtnDtaVenctoFinal.TabIndex = 63
        Me.BtnDtaVenctoFinal.Text = "F"
        Me.BtnDtaVenctoFinal.UseVisualStyleBackColor = True
        '
        'TxbDtaVecto
        '
        Me.TxbDtaVecto.Location = New System.Drawing.Point(77, 11)
        Me.TxbDtaVecto.MaxLength = 10
        Me.TxbDtaVecto.Name = "TxbDtaVecto"
        Me.TxbDtaVecto.Size = New System.Drawing.Size(66, 20)
        Me.TxbDtaVecto.TabIndex = 61
        '
        'DtpDtaVecto
        '
        Me.DtpDtaVecto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaVecto.Location = New System.Drawing.Point(145, 11)
        Me.DtpDtaVecto.Name = "DtpDtaVecto"
        Me.DtpDtaVecto.Size = New System.Drawing.Size(14, 20)
        Me.DtpDtaVecto.TabIndex = 62
        Me.DtpDtaVecto.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(0, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Vencimento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(175, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Liquidação:"
        '
        'TxbObservacao
        '
        Me.TxbObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbObservacao.Location = New System.Drawing.Point(83, 163)
        Me.TxbObservacao.Name = "TxbObservacao"
        Me.TxbObservacao.Size = New System.Drawing.Size(389, 20)
        Me.TxbObservacao.TabIndex = 71
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Observação:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxbValOriginal)
        Me.GroupBox6.Controls.Add(Me.TxbValJurosOriginal)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.BtnEmissaoFinal)
        Me.GroupBox6.Controls.Add(Me.TxbDtaEmissao)
        Me.GroupBox6.Controls.Add(Me.DtpDtaEmissao)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 83)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(472, 37)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        '
        'TxbValOriginal
        '
        Me.TxbValOriginal.Location = New System.Drawing.Point(237, 11)
        Me.TxbValOriginal.Name = "TxbValOriginal"
        Me.TxbValOriginal.Size = New System.Drawing.Size(94, 20)
        Me.TxbValOriginal.TabIndex = 65
        Me.TxbValOriginal.Text = "0,00"
        Me.TxbValOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbValJurosOriginal
        '
        Me.TxbValJurosOriginal.Location = New System.Drawing.Point(401, 11)
        Me.TxbValJurosOriginal.Name = "TxbValJurosOriginal"
        Me.TxbValJurosOriginal.Size = New System.Drawing.Size(66, 20)
        Me.TxbValJurosOriginal.TabIndex = 67
        Me.TxbValJurosOriginal.Text = "0,00"
        Me.TxbValJurosOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(348, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "R$ Juros:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(175, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "R$ Original:"
        '
        'BtnEmissaoFinal
        '
        Me.BtnEmissaoFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmissaoFinal.Font = New System.Drawing.Font("Bernard MT Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmissaoFinal.ForeColor = System.Drawing.Color.DimGray
        Me.BtnEmissaoFinal.Location = New System.Drawing.Point(161, 11)
        Me.BtnEmissaoFinal.Name = "BtnEmissaoFinal"
        Me.BtnEmissaoFinal.Size = New System.Drawing.Size(14, 20)
        Me.BtnEmissaoFinal.TabIndex = 63
        Me.BtnEmissaoFinal.Text = "F"
        Me.BtnEmissaoFinal.UseVisualStyleBackColor = True
        '
        'TxbDtaEmissao
        '
        Me.TxbDtaEmissao.Location = New System.Drawing.Point(77, 11)
        Me.TxbDtaEmissao.MaxLength = 10
        Me.TxbDtaEmissao.Name = "TxbDtaEmissao"
        Me.TxbDtaEmissao.Size = New System.Drawing.Size(66, 20)
        Me.TxbDtaEmissao.TabIndex = 61
        '
        'DtpDtaEmissao
        '
        Me.DtpDtaEmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaEmissao.Location = New System.Drawing.Point(145, 11)
        Me.DtpDtaEmissao.Name = "DtpDtaEmissao"
        Me.DtpDtaEmissao.Size = New System.Drawing.Size(14, 20)
        Me.DtpDtaEmissao.TabIndex = 62
        Me.DtpDtaEmissao.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(0, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Emissao:"
        '
        'CkbTodasEmpresa
        '
        Me.CkbTodasEmpresa.AutoSize = True
        Me.CkbTodasEmpresa.Location = New System.Drawing.Point(362, 14)
        Me.CkbTodasEmpresa.Name = "CkbTodasEmpresa"
        Me.CkbTodasEmpresa.Size = New System.Drawing.Size(105, 17)
        Me.CkbTodasEmpresa.TabIndex = 69
        Me.CkbTodasEmpresa.Text = "Todas Empresas"
        Me.CkbTodasEmpresa.UseVisualStyleBackColor = True
        '
        'CkbTipoManual
        '
        Me.CkbTipoManual.AutoSize = True
        Me.CkbTipoManual.Location = New System.Drawing.Point(6, 15)
        Me.CkbTipoManual.Name = "CkbTipoManual"
        Me.CkbTipoManual.Size = New System.Drawing.Size(61, 17)
        Me.CkbTipoManual.TabIndex = 70
        Me.CkbTipoManual.Text = "Manual"
        Me.CkbTipoManual.UseVisualStyleBackColor = True
        '
        'CkbTipoNotaFiscal
        '
        Me.CkbTipoNotaFiscal.AutoSize = True
        Me.CkbTipoNotaFiscal.Location = New System.Drawing.Point(6, 30)
        Me.CkbTipoNotaFiscal.Name = "CkbTipoNotaFiscal"
        Me.CkbTipoNotaFiscal.Size = New System.Drawing.Size(79, 17)
        Me.CkbTipoNotaFiscal.TabIndex = 71
        Me.CkbTipoNotaFiscal.Text = "Nota Fiscal"
        Me.CkbTipoNotaFiscal.UseVisualStyleBackColor = True
        '
        'CkbTipoCartaoCredito
        '
        Me.CkbTipoCartaoCredito.AutoSize = True
        Me.CkbTipoCartaoCredito.Location = New System.Drawing.Point(6, 45)
        Me.CkbTipoCartaoCredito.Name = "CkbTipoCartaoCredito"
        Me.CkbTipoCartaoCredito.Size = New System.Drawing.Size(93, 17)
        Me.CkbTipoCartaoCredito.TabIndex = 73
        Me.CkbTipoCartaoCredito.Text = "Cartão Crédito"
        Me.CkbTipoCartaoCredito.UseVisualStyleBackColor = True
        '
        'CkbTipoReceita
        '
        Me.CkbTipoReceita.AutoSize = True
        Me.CkbTipoReceita.Location = New System.Drawing.Point(104, 15)
        Me.CkbTipoReceita.Name = "CkbTipoReceita"
        Me.CkbTipoReceita.Size = New System.Drawing.Size(63, 17)
        Me.CkbTipoReceita.TabIndex = 72
        Me.CkbTipoReceita.Text = "Receita"
        Me.CkbTipoReceita.UseVisualStyleBackColor = True
        '
        'CkbTipoAdiantaFunc
        '
        Me.CkbTipoAdiantaFunc.AutoSize = True
        Me.CkbTipoAdiantaFunc.Location = New System.Drawing.Point(104, 30)
        Me.CkbTipoAdiantaFunc.Name = "CkbTipoAdiantaFunc"
        Me.CkbTipoAdiantaFunc.Size = New System.Drawing.Size(158, 17)
        Me.CkbTipoAdiantaFunc.TabIndex = 74
        Me.CkbTipoAdiantaFunc.Text = "Adiantamento a Funcionário"
        Me.CkbTipoAdiantaFunc.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.CkbPeStatus)
        Me.GroupBox7.Controls.Add(Me.RbStatusLiquidado)
        Me.GroupBox7.Controls.Add(Me.RbStatusProtesto)
        Me.GroupBox7.Controls.Add(Me.RbStatusNegociado)
        Me.GroupBox7.Controls.Add(Me.RbStatusFaturado)
        Me.GroupBox7.Controls.Add(Me.RbStatusAberto)
        Me.GroupBox7.Location = New System.Drawing.Point(277, 184)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(201, 104)
        Me.GroupBox7.TabIndex = 18
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Status"
        '
        'CkbPeStatus
        '
        Me.CkbPeStatus.AutoSize = True
        Me.CkbPeStatus.Location = New System.Drawing.Point(152, 83)
        Me.CkbPeStatus.Name = "CkbPeStatus"
        Me.CkbPeStatus.Size = New System.Drawing.Size(43, 17)
        Me.CkbPeStatus.TabIndex = 70
        Me.CkbPeStatus.Text = "P.E"
        Me.CkbPeStatus.UseVisualStyleBackColor = True
        '
        'RbStatusLiquidado
        '
        Me.RbStatusLiquidado.AutoSize = True
        Me.RbStatusLiquidado.Location = New System.Drawing.Point(6, 83)
        Me.RbStatusLiquidado.Name = "RbStatusLiquidado"
        Me.RbStatusLiquidado.Size = New System.Drawing.Size(71, 17)
        Me.RbStatusLiquidado.TabIndex = 4
        Me.RbStatusLiquidado.TabStop = True
        Me.RbStatusLiquidado.Text = "Liquidado"
        Me.RbStatusLiquidado.UseVisualStyleBackColor = True
        '
        'RbStatusProtesto
        '
        Me.RbStatusProtesto.AutoSize = True
        Me.RbStatusProtesto.Location = New System.Drawing.Point(6, 66)
        Me.RbStatusProtesto.Name = "RbStatusProtesto"
        Me.RbStatusProtesto.Size = New System.Drawing.Size(82, 17)
        Me.RbStatusProtesto.TabIndex = 3
        Me.RbStatusProtesto.TabStop = True
        Me.RbStatusProtesto.Text = "Em Protesto"
        Me.RbStatusProtesto.UseVisualStyleBackColor = True
        '
        'RbStatusNegociado
        '
        Me.RbStatusNegociado.AutoSize = True
        Me.RbStatusNegociado.Location = New System.Drawing.Point(6, 49)
        Me.RbStatusNegociado.Name = "RbStatusNegociado"
        Me.RbStatusNegociado.Size = New System.Drawing.Size(77, 17)
        Me.RbStatusNegociado.TabIndex = 2
        Me.RbStatusNegociado.TabStop = True
        Me.RbStatusNegociado.Text = "Negociado"
        Me.RbStatusNegociado.UseVisualStyleBackColor = True
        '
        'RbStatusFaturado
        '
        Me.RbStatusFaturado.AutoSize = True
        Me.RbStatusFaturado.Location = New System.Drawing.Point(6, 32)
        Me.RbStatusFaturado.Name = "RbStatusFaturado"
        Me.RbStatusFaturado.Size = New System.Drawing.Size(67, 17)
        Me.RbStatusFaturado.TabIndex = 1
        Me.RbStatusFaturado.TabStop = True
        Me.RbStatusFaturado.Text = "Faturado"
        Me.RbStatusFaturado.UseVisualStyleBackColor = True
        '
        'RbStatusAberto
        '
        Me.RbStatusAberto.AutoSize = True
        Me.RbStatusAberto.Location = New System.Drawing.Point(6, 15)
        Me.RbStatusAberto.Name = "RbStatusAberto"
        Me.RbStatusAberto.Size = New System.Drawing.Size(56, 17)
        Me.RbStatusAberto.TabIndex = 0
        Me.RbStatusAberto.TabStop = True
        Me.RbStatusAberto.Text = "Aberto"
        Me.RbStatusAberto.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.RbFaturaNao)
        Me.GroupBox8.Controls.Add(Me.RbFaturaSim)
        Me.GroupBox8.Controls.Add(Me.CkbPeFatura)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 252)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(265, 37)
        Me.GroupBox8.TabIndex = 19
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Fatura"
        '
        'RbFaturaNao
        '
        Me.RbFaturaNao.AutoSize = True
        Me.RbFaturaNao.Location = New System.Drawing.Point(111, 13)
        Me.RbFaturaNao.Name = "RbFaturaNao"
        Me.RbFaturaNao.Size = New System.Drawing.Size(45, 17)
        Me.RbFaturaNao.TabIndex = 73
        Me.RbFaturaNao.TabStop = True
        Me.RbFaturaNao.Text = "Não"
        Me.RbFaturaNao.UseVisualStyleBackColor = True
        '
        'RbFaturaSim
        '
        Me.RbFaturaSim.AutoSize = True
        Me.RbFaturaSim.Location = New System.Drawing.Point(7, 13)
        Me.RbFaturaSim.Name = "RbFaturaSim"
        Me.RbFaturaSim.Size = New System.Drawing.Size(42, 17)
        Me.RbFaturaSim.TabIndex = 72
        Me.RbFaturaSim.TabStop = True
        Me.RbFaturaSim.Text = "Sim"
        Me.RbFaturaSim.UseVisualStyleBackColor = True
        '
        'CkbPeFatura
        '
        Me.CkbPeFatura.AutoSize = True
        Me.CkbPeFatura.Location = New System.Drawing.Point(216, 13)
        Me.CkbPeFatura.Name = "CkbPeFatura"
        Me.CkbPeFatura.Size = New System.Drawing.Size(43, 17)
        Me.CkbPeFatura.TabIndex = 71
        Me.CkbPeFatura.Text = "P.E"
        Me.CkbPeFatura.UseVisualStyleBackColor = True
        '
        'BtnPrincipal
        '
        Me.BtnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrincipal.ForeColor = System.Drawing.Color.Black
        Me.BtnPrincipal.Location = New System.Drawing.Point(7, 54)
        Me.BtnPrincipal.Name = "BtnPrincipal"
        Me.BtnPrincipal.Size = New System.Drawing.Size(120, 26)
        Me.BtnPrincipal.TabIndex = 22
        Me.BtnPrincipal.Text = "Principal"
        Me.BtnPrincipal.UseVisualStyleBackColor = True
        '
        'BtnLiquidacao
        '
        Me.BtnLiquidacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLiquidacao.ForeColor = System.Drawing.Color.Black
        Me.BtnLiquidacao.Location = New System.Drawing.Point(7, 81)
        Me.BtnLiquidacao.Name = "BtnLiquidacao"
        Me.BtnLiquidacao.Size = New System.Drawing.Size(120, 26)
        Me.BtnLiquidacao.TabIndex = 23
        Me.BtnLiquidacao.Text = "Liquidação"
        Me.BtnLiquidacao.UseVisualStyleBackColor = True
        '
        'Dgv
        '
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv.Location = New System.Drawing.Point(3, 16)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(474, 295)
        Me.Dgv.TabIndex = 11
        '
        'CkbPeTipo
        '
        Me.CkbPeTipo.AutoSize = True
        Me.CkbPeTipo.Location = New System.Drawing.Point(216, 45)
        Me.CkbPeTipo.Name = "CkbPeTipo"
        Me.CkbPeTipo.Size = New System.Drawing.Size(43, 17)
        Me.CkbPeTipo.TabIndex = 75
        Me.CkbPeTipo.Text = "P.E"
        Me.CkbPeTipo.UseVisualStyleBackColor = True
        '
        'FrmTituloReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(627, 345)
        Me.Controls.Add(Me.BtnPrincipal)
        Me.Controls.Add(Me.BtnLiquidacao)
        Me.Name = "FrmTituloReceber"
        Me.Text = "Titulo Receber"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.BtnLiquidacao, 0)
        Me.Controls.SetChildIndex(Me.BtnPrincipal, 0)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCadSacado As Button
    Friend WithEvents TxbCodSacado As Controles.TxbCodigo
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnBuscaSacado As Button
    Friend WithEvents TxbNomSacado As TextBox
    Friend WithEvents BtnCadTipoCobranca As Button
    Friend WithEvents TxbCodTipoCobranca As Controles.TxbCodigo
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnBuscaTipoCobranca As Button
    Friend WithEvents TxbDesTipoCobranca As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxbObservacao As TextBox
    Friend WithEvents TxbDtaLiquidacao As Controles.TxbData
    Friend WithEvents Label10 As Label
    Friend WithEvents TxbValLiquidado As Controles.TxbMonetario
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnDtaVenctoFinal As Button
    Friend WithEvents TxbDtaVecto As Controles.TxbData
    Friend WithEvents DtpDtaVecto As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents RbFaturaNao As RadioButton
    Friend WithEvents RbFaturaSim As RadioButton
    Friend WithEvents CkbPeFatura As CheckBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents CkbPeStatus As CheckBox
    Friend WithEvents RbStatusLiquidado As RadioButton
    Friend WithEvents RbStatusProtesto As RadioButton
    Friend WithEvents RbStatusNegociado As RadioButton
    Friend WithEvents RbStatusFaturado As RadioButton
    Friend WithEvents RbStatusAberto As RadioButton
    Friend WithEvents TxbValOriginal As Controles.TxbMonetario
    Friend WithEvents TxbValJurosOriginal As Controles.TxbMonetario
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnEmissaoFinal As Button
    Friend WithEvents TxbDtaEmissao As Controles.TxbData
    Friend WithEvents DtpDtaEmissao As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents CkbTodasEmpresa As CheckBox
    Friend WithEvents CkbTipoAdiantaFunc As CheckBox
    Friend WithEvents CkbTipoCartaoCredito As CheckBox
    Friend WithEvents CkbTipoReceita As CheckBox
    Friend WithEvents CkbTipoNotaFiscal As CheckBox
    Friend WithEvents CkbTipoManual As CheckBox
    Friend WithEvents BtnPrincipal As Button
    Friend WithEvents BtnLiquidacao As Button
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents BtnDtaFinalLiquidacao As Button
    Friend WithEvents DtpDtaLiquidacao As DateTimePicker
    Friend WithEvents CkbPeTipo As CheckBox
End Class
