<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagamentoRecebimento
    Inherits Controles.FrmPadrao

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagamentoRecebimento))
        Me.TxbValPendente = New Controles.TxbMonetario()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxbValLiquidado = New Controles.TxbMonetario()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxbValOriginal = New Controles.TxbMonetario()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxbDesTipoParcela = New System.Windows.Forms.TextBox()
        Me.LbTotalParcela = New System.Windows.Forms.Label()
        Me.TxbValJurosParc = New Controles.TxbMonetario()
        Me.TxbValJurosParcPorc = New Controles.TxbMonetario()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnTipoParcelamento = New System.Windows.Forms.Button()
        Me.TxbCodTipoParcela = New Controles.TxbCodigo()
        Me.DtpDtaVenctoParc = New System.Windows.Forms.DateTimePicker()
        Me.GbParcelaAutomatica = New System.Windows.Forms.GroupBox()
        Me.TxbQtdParcela = New Controles.TxbCodigo()
        Me.ckbParcelaAutomatica = New System.Windows.Forms.CheckBox()
        Me.LbSeqParcelamento = New System.Windows.Forms.Label()
        Me.TxbIntervalVencto = New Controles.TxbCodigo()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CkbDiaFixo = New System.Windows.Forms.CheckBox()
        Me.BtnLimpaParcela = New System.Windows.Forms.Button()
        Me.BtnSalvaParcela = New System.Windows.Forms.Button()
        Me.BtnExcluiParcela = New System.Windows.Forms.Button()
        Me.DgvParcela = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnValParc = New System.Windows.Forms.Button()
        Me.TxbValParcela = New Controles.TxbMonetario()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxbDtaVencimentoParc = New Controles.TxbData()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LbTotalBanco = New System.Windows.Forms.Label()
        Me.lbSeqPagamento = New System.Windows.Forms.Label()
        Me.TxbDtaPredatado = New Controles.TxbData()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DtpDtaPredatado = New System.Windows.Forms.DateTimePicker()
        Me.TxbValBanco = New Controles.TxbMonetario()
        Me.BtnLimpaBanco = New System.Windows.Forms.Button()
        Me.BtnSalvaBanco = New System.Windows.Forms.Button()
        Me.BtnExcluiBanco = New System.Windows.Forms.Button()
        Me.DgvBanco = New System.Windows.Forms.DataGridView()
        Me.BtnValBanco = New System.Windows.Forms.Button()
        Me.TxbConta = New System.Windows.Forms.TextBox()
        Me.txbAgencia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnMenmonico = New System.Windows.Forms.Button()
        Me.TxbNomBanco = New System.Windows.Forms.TextBox()
        Me.TxbCodBanco = New Controles.TxbCodigo()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxbValEspecie = New Controles.TxbMonetario()
        Me.BtnValEspecie = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscaEspecie = New System.Windows.Forms.Button()
        Me.txbDesEspecie = New System.Windows.Forms.TextBox()
        Me.TxbCodEspecie = New Controles.TxbCodigo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxbValJuroPrincPorc = New Controles.TxbMonetario3casa()
        Me.TxbValDescPorc = New Controles.TxbMonetario3casa()
        Me.TxbDtaLiquidacao = New Controles.TxbData()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxbValAcrescimo = New Controles.TxbMonetario()
        Me.DtpDtaLiquidacao = New System.Windows.Forms.DateTimePicker()
        Me.TxbValMulta = New Controles.TxbMonetario()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxbValDespAcess = New Controles.TxbMonetario()
        Me.TxbValJurosPrinc = New Controles.TxbMonetario()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxbValDesconto = New Controles.TxbMonetario()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TxbValTotal = New Controles.TxbMonetario()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnExtornaPagto = New System.Windows.Forms.Button()
        Me.BtnConfirmaPagto = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GbParcelaAutomatica.SuspendLayout()
        CType(Me.DgvParcela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxbValPendente
        '
        Me.TxbValPendente.Location = New System.Drawing.Point(459, 9)
        Me.TxbValPendente.Name = "TxbValPendente"
        Me.TxbValPendente.ReadOnly = True
        Me.TxbValPendente.Size = New System.Drawing.Size(87, 20)
        Me.TxbValPendente.TabIndex = 62
        Me.TxbValPendente.Text = "0,00"
        Me.TxbValPendente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(406, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "Pendênte:"
        '
        'TxbValLiquidado
        '
        Me.TxbValLiquidado.Location = New System.Drawing.Point(305, 9)
        Me.TxbValLiquidado.Name = "TxbValLiquidado"
        Me.TxbValLiquidado.ReadOnly = True
        Me.TxbValLiquidado.Size = New System.Drawing.Size(87, 20)
        Me.TxbValLiquidado.TabIndex = 60
        Me.TxbValLiquidado.Text = "0,00"
        Me.TxbValLiquidado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(252, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Liquidado:"
        '
        'TxbValOriginal
        '
        Me.TxbValOriginal.Location = New System.Drawing.Point(55, 9)
        Me.TxbValOriginal.Name = "TxbValOriginal"
        Me.TxbValOriginal.ReadOnly = True
        Me.TxbValOriginal.Size = New System.Drawing.Size(72, 20)
        Me.TxbValOriginal.TabIndex = 58
        Me.TxbValOriginal.Text = "0,00"
        Me.TxbValOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Original:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxbDesTipoParcela)
        Me.GroupBox3.Controls.Add(Me.LbTotalParcela)
        Me.GroupBox3.Controls.Add(Me.TxbValJurosParc)
        Me.GroupBox3.Controls.Add(Me.TxbValJurosParcPorc)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.BtnTipoParcelamento)
        Me.GroupBox3.Controls.Add(Me.TxbCodTipoParcela)
        Me.GroupBox3.Controls.Add(Me.DtpDtaVenctoParc)
        Me.GroupBox3.Controls.Add(Me.GbParcelaAutomatica)
        Me.GroupBox3.Controls.Add(Me.BtnLimpaParcela)
        Me.GroupBox3.Controls.Add(Me.BtnSalvaParcela)
        Me.GroupBox3.Controls.Add(Me.BtnExcluiParcela)
        Me.GroupBox3.Controls.Add(Me.DgvParcela)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.BtnValParc)
        Me.GroupBox3.Controls.Add(Me.TxbValParcela)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxbDtaVencimentoParc)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 347)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(550, 237)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parcelamento:"
        '
        'TxbDesTipoParcela
        '
        Me.TxbDesTipoParcela.Location = New System.Drawing.Point(129, 13)
        Me.TxbDesTipoParcela.Name = "TxbDesTipoParcela"
        Me.TxbDesTipoParcela.Size = New System.Drawing.Size(390, 20)
        Me.TxbDesTipoParcela.TabIndex = 28
        '
        'LbTotalParcela
        '
        Me.LbTotalParcela.AutoSize = True
        Me.LbTotalParcela.Location = New System.Drawing.Point(289, 139)
        Me.LbTotalParcela.Name = "LbTotalParcela"
        Me.LbTotalParcela.Size = New System.Drawing.Size(45, 13)
        Me.LbTotalParcela.TabIndex = 68
        Me.LbTotalParcela.Text = "Label32"
        Me.LbTotalParcela.Visible = False
        '
        'TxbValJurosParc
        '
        Me.TxbValJurosParc.Location = New System.Drawing.Point(385, 36)
        Me.TxbValJurosParc.Name = "TxbValJurosParc"
        Me.TxbValJurosParc.Size = New System.Drawing.Size(87, 20)
        Me.TxbValJurosParc.TabIndex = 34
        Me.TxbValJurosParc.Text = "0,00"
        Me.TxbValJurosParc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbValJurosParcPorc
        '
        Me.TxbValJurosParcPorc.Location = New System.Drawing.Point(488, 36)
        Me.TxbValJurosParcPorc.Name = "TxbValJurosParcPorc"
        Me.TxbValJurosParcPorc.Size = New System.Drawing.Size(58, 20)
        Me.TxbValJurosParcPorc.TabIndex = 35
        Me.TxbValJurosParcPorc.Text = "0,00"
        Me.TxbValJurosParcPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(471, 38)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(20, 16)
        Me.Label30.TabIndex = 71
        Me.Label30.Text = "%"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(4, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "Tipo:"
        '
        'BtnTipoParcelamento
        '
        Me.BtnTipoParcelamento.BackColor = System.Drawing.Color.Transparent
        Me.BtnTipoParcelamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTipoParcelamento.ForeColor = System.Drawing.Color.DimGray
        Me.BtnTipoParcelamento.Image = CType(resources.GetObject("BtnTipoParcelamento.Image"), System.Drawing.Image)
        Me.BtnTipoParcelamento.Location = New System.Drawing.Point(522, 13)
        Me.BtnTipoParcelamento.Name = "BtnTipoParcelamento"
        Me.BtnTipoParcelamento.Size = New System.Drawing.Size(24, 20)
        Me.BtnTipoParcelamento.TabIndex = 29
        Me.BtnTipoParcelamento.UseVisualStyleBackColor = False
        '
        'TxbCodTipoParcela
        '
        Me.TxbCodTipoParcela.Location = New System.Drawing.Point(75, 13)
        Me.TxbCodTipoParcela.Name = "TxbCodTipoParcela"
        Me.TxbCodTipoParcela.Size = New System.Drawing.Size(52, 20)
        Me.TxbCodTipoParcela.TabIndex = 27
        '
        'DtpDtaVenctoParc
        '
        Me.DtpDtaVenctoParc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaVenctoParc.Location = New System.Drawing.Point(163, 36)
        Me.DtpDtaVenctoParc.Name = "DtpDtaVenctoParc"
        Me.DtpDtaVenctoParc.Size = New System.Drawing.Size(14, 20)
        Me.DtpDtaVenctoParc.TabIndex = 31
        Me.DtpDtaVenctoParc.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'GbParcelaAutomatica
        '
        Me.GbParcelaAutomatica.Controls.Add(Me.TxbQtdParcela)
        Me.GbParcelaAutomatica.Controls.Add(Me.ckbParcelaAutomatica)
        Me.GbParcelaAutomatica.Controls.Add(Me.LbSeqParcelamento)
        Me.GbParcelaAutomatica.Controls.Add(Me.TxbIntervalVencto)
        Me.GbParcelaAutomatica.Controls.Add(Me.Label13)
        Me.GbParcelaAutomatica.Controls.Add(Me.Label12)
        Me.GbParcelaAutomatica.Controls.Add(Me.CkbDiaFixo)
        Me.GbParcelaAutomatica.Location = New System.Drawing.Point(7, 62)
        Me.GbParcelaAutomatica.Name = "GbParcelaAutomatica"
        Me.GbParcelaAutomatica.Size = New System.Drawing.Size(537, 51)
        Me.GbParcelaAutomatica.TabIndex = 58
        Me.GbParcelaAutomatica.TabStop = False
        Me.GbParcelaAutomatica.Text = "Gerar Parcelas Automaticas"
        '
        'TxbQtdParcela
        '
        Me.TxbQtdParcela.Location = New System.Drawing.Point(475, 17)
        Me.TxbQtdParcela.Name = "TxbQtdParcela"
        Me.TxbQtdParcela.Size = New System.Drawing.Size(58, 20)
        Me.TxbQtdParcela.TabIndex = 39
        '
        'ckbParcelaAutomatica
        '
        Me.ckbParcelaAutomatica.AutoSize = True
        Me.ckbParcelaAutomatica.Location = New System.Drawing.Point(145, 0)
        Me.ckbParcelaAutomatica.Name = "ckbParcelaAutomatica"
        Me.ckbParcelaAutomatica.Size = New System.Drawing.Size(15, 14)
        Me.ckbParcelaAutomatica.TabIndex = 36
        Me.ckbParcelaAutomatica.UseVisualStyleBackColor = True
        '
        'LbSeqParcelamento
        '
        Me.LbSeqParcelamento.AutoSize = True
        Me.LbSeqParcelamento.Location = New System.Drawing.Point(304, 0)
        Me.LbSeqParcelamento.Name = "LbSeqParcelamento"
        Me.LbSeqParcelamento.Size = New System.Drawing.Size(103, 13)
        Me.LbSeqParcelamento.TabIndex = 67
        Me.LbSeqParcelamento.Text = "LbSeqParcelamento"
        Me.LbSeqParcelamento.Visible = False
        '
        'TxbIntervalVencto
        '
        Me.TxbIntervalVencto.Location = New System.Drawing.Point(278, 17)
        Me.TxbIntervalVencto.Name = "TxbIntervalVencto"
        Me.TxbIntervalVencto.Size = New System.Drawing.Size(87, 20)
        Me.TxbIntervalVencto.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(169, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 13)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Intervalo Vencimento:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(404, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Qtde Parcela:"
        '
        'CkbDiaFixo
        '
        Me.CkbDiaFixo.AutoSize = True
        Me.CkbDiaFixo.Location = New System.Drawing.Point(68, 19)
        Me.CkbDiaFixo.Name = "CkbDiaFixo"
        Me.CkbDiaFixo.Size = New System.Drawing.Size(64, 17)
        Me.CkbDiaFixo.TabIndex = 37
        Me.CkbDiaFixo.Text = "Dia Fixo"
        Me.CkbDiaFixo.UseVisualStyleBackColor = True
        '
        'BtnLimpaParcela
        '
        Me.BtnLimpaParcela.BackColor = System.Drawing.Color.Transparent
        Me.BtnLimpaParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpaParcela.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLimpaParcela.Image = CType(resources.GetObject("BtnLimpaParcela.Image"), System.Drawing.Image)
        Me.BtnLimpaParcela.Location = New System.Drawing.Point(516, 179)
        Me.BtnLimpaParcela.Name = "BtnLimpaParcela"
        Me.BtnLimpaParcela.Size = New System.Drawing.Size(30, 28)
        Me.BtnLimpaParcela.TabIndex = 42
        Me.BtnLimpaParcela.UseVisualStyleBackColor = False
        '
        'BtnSalvaParcela
        '
        Me.BtnSalvaParcela.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalvaParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvaParcela.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvaParcela.Image = CType(resources.GetObject("BtnSalvaParcela.Image"), System.Drawing.Image)
        Me.BtnSalvaParcela.Location = New System.Drawing.Point(516, 125)
        Me.BtnSalvaParcela.Name = "BtnSalvaParcela"
        Me.BtnSalvaParcela.Size = New System.Drawing.Size(30, 27)
        Me.BtnSalvaParcela.TabIndex = 40
        Me.BtnSalvaParcela.UseVisualStyleBackColor = False
        '
        'BtnExcluiParcela
        '
        Me.BtnExcluiParcela.BackColor = System.Drawing.Color.Transparent
        Me.BtnExcluiParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluiParcela.ForeColor = System.Drawing.Color.Transparent
        Me.BtnExcluiParcela.Image = CType(resources.GetObject("BtnExcluiParcela.Image"), System.Drawing.Image)
        Me.BtnExcluiParcela.Location = New System.Drawing.Point(516, 152)
        Me.BtnExcluiParcela.Name = "BtnExcluiParcela"
        Me.BtnExcluiParcela.Size = New System.Drawing.Size(30, 27)
        Me.BtnExcluiParcela.TabIndex = 41
        Me.BtnExcluiParcela.UseVisualStyleBackColor = False
        '
        'DgvParcela
        '
        Me.DgvParcela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvParcela.Location = New System.Drawing.Point(8, 119)
        Me.DgvParcela.Name = "DgvParcela"
        Me.DgvParcela.Size = New System.Drawing.Size(504, 112)
        Me.DgvParcela.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(348, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Juros:"
        '
        'BtnValParc
        '
        Me.BtnValParc.BackColor = System.Drawing.Color.Transparent
        Me.BtnValParc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnValParc.ForeColor = System.Drawing.Color.DimGray
        Me.BtnValParc.Image = CType(resources.GetObject("BtnValParc.Image"), System.Drawing.Image)
        Me.BtnValParc.Location = New System.Drawing.Point(321, 36)
        Me.BtnValParc.Name = "BtnValParc"
        Me.BtnValParc.Size = New System.Drawing.Size(24, 20)
        Me.BtnValParc.TabIndex = 33
        Me.BtnValParc.UseVisualStyleBackColor = False
        '
        'TxbValParcela
        '
        Me.TxbValParcela.Location = New System.Drawing.Point(232, 36)
        Me.TxbValParcela.Name = "TxbValParcela"
        Me.TxbValParcela.Size = New System.Drawing.Size(87, 20)
        Me.TxbValParcela.TabIndex = 32
        Me.TxbValParcela.Text = "0,00"
        Me.TxbValParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(200, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Valor"
        '
        'TxbDtaVencimentoParc
        '
        Me.TxbDtaVencimentoParc.Location = New System.Drawing.Point(75, 36)
        Me.TxbDtaVencimentoParc.MaxLength = 10
        Me.TxbDtaVencimentoParc.Name = "TxbDtaVencimentoParc"
        Me.TxbDtaVencimentoParc.Size = New System.Drawing.Size(87, 20)
        Me.TxbDtaVencimentoParc.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Vencimento:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(200, 47)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(31, 13)
        Me.Label32.TabIndex = 73
        Me.Label32.Text = "Total"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.LbTotalBanco)
        Me.GroupBox2.Controls.Add(Me.lbSeqPagamento)
        Me.GroupBox2.Controls.Add(Me.TxbDtaPredatado)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.DtpDtaPredatado)
        Me.GroupBox2.Controls.Add(Me.TxbValBanco)
        Me.GroupBox2.Controls.Add(Me.BtnLimpaBanco)
        Me.GroupBox2.Controls.Add(Me.BtnSalvaBanco)
        Me.GroupBox2.Controls.Add(Me.BtnExcluiBanco)
        Me.GroupBox2.Controls.Add(Me.DgvBanco)
        Me.GroupBox2.Controls.Add(Me.BtnValBanco)
        Me.GroupBox2.Controls.Add(Me.TxbConta)
        Me.GroupBox2.Controls.Add(Me.txbAgencia)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BtnMenmonico)
        Me.GroupBox2.Controls.Add(Me.TxbNomBanco)
        Me.GroupBox2.Controls.Add(Me.TxbCodBanco)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(550, 180)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Banco"
        '
        'LbTotalBanco
        '
        Me.LbTotalBanco.AutoSize = True
        Me.LbTotalBanco.Location = New System.Drawing.Point(287, 100)
        Me.LbTotalBanco.Name = "LbTotalBanco"
        Me.LbTotalBanco.Size = New System.Drawing.Size(45, 13)
        Me.LbTotalBanco.TabIndex = 67
        Me.LbTotalBanco.Text = "Label32"
        Me.LbTotalBanco.Visible = False
        '
        'lbSeqPagamento
        '
        Me.lbSeqPagamento.AutoSize = True
        Me.lbSeqPagamento.Location = New System.Drawing.Point(72, 74)
        Me.lbSeqPagamento.Name = "lbSeqPagamento"
        Me.lbSeqPagamento.Size = New System.Drawing.Size(88, 13)
        Me.lbSeqPagamento.TabIndex = 66
        Me.lbSeqPagamento.Text = "lbSeqPagamento"
        Me.lbSeqPagamento.Visible = False
        '
        'TxbDtaPredatado
        '
        Me.TxbDtaPredatado.Location = New System.Drawing.Point(317, 39)
        Me.TxbDtaPredatado.MaxLength = 10
        Me.TxbDtaPredatado.Name = "TxbDtaPredatado"
        Me.TxbDtaPredatado.Size = New System.Drawing.Size(66, 20)
        Me.TxbDtaPredatado.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(260, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "Prédatado:"
        '
        'DtpDtaPredatado
        '
        Me.DtpDtaPredatado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaPredatado.Location = New System.Drawing.Point(385, 39)
        Me.DtpDtaPredatado.Name = "DtpDtaPredatado"
        Me.DtpDtaPredatado.Size = New System.Drawing.Size(14, 20)
        Me.DtpDtaPredatado.TabIndex = 21
        Me.DtpDtaPredatado.Value = New Date(2020, 1, 9, 15, 53, 3, 0)
        '
        'TxbValBanco
        '
        Me.TxbValBanco.Location = New System.Drawing.Point(432, 39)
        Me.TxbValBanco.Name = "TxbValBanco"
        Me.TxbValBanco.Size = New System.Drawing.Size(87, 20)
        Me.TxbValBanco.TabIndex = 22
        Me.TxbValBanco.Text = "0,00"
        Me.TxbValBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnLimpaBanco
        '
        Me.BtnLimpaBanco.BackColor = System.Drawing.Color.Transparent
        Me.BtnLimpaBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpaBanco.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLimpaBanco.Image = CType(resources.GetObject("BtnLimpaBanco.Image"), System.Drawing.Image)
        Me.BtnLimpaBanco.Location = New System.Drawing.Point(516, 120)
        Me.BtnLimpaBanco.Name = "BtnLimpaBanco"
        Me.BtnLimpaBanco.Size = New System.Drawing.Size(30, 31)
        Me.BtnLimpaBanco.TabIndex = 26
        Me.BtnLimpaBanco.UseVisualStyleBackColor = False
        '
        'BtnSalvaBanco
        '
        Me.BtnSalvaBanco.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalvaBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvaBanco.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvaBanco.Image = CType(resources.GetObject("BtnSalvaBanco.Image"), System.Drawing.Image)
        Me.BtnSalvaBanco.Location = New System.Drawing.Point(516, 65)
        Me.BtnSalvaBanco.Name = "BtnSalvaBanco"
        Me.BtnSalvaBanco.Size = New System.Drawing.Size(30, 31)
        Me.BtnSalvaBanco.TabIndex = 24
        Me.BtnSalvaBanco.UseVisualStyleBackColor = False
        '
        'BtnExcluiBanco
        '
        Me.BtnExcluiBanco.BackColor = System.Drawing.Color.Transparent
        Me.BtnExcluiBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluiBanco.ForeColor = System.Drawing.Color.Transparent
        Me.BtnExcluiBanco.Image = CType(resources.GetObject("BtnExcluiBanco.Image"), System.Drawing.Image)
        Me.BtnExcluiBanco.Location = New System.Drawing.Point(516, 92)
        Me.BtnExcluiBanco.Name = "BtnExcluiBanco"
        Me.BtnExcluiBanco.Size = New System.Drawing.Size(30, 31)
        Me.BtnExcluiBanco.TabIndex = 25
        Me.BtnExcluiBanco.UseVisualStyleBackColor = False
        '
        'DgvBanco
        '
        Me.DgvBanco.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBanco.Location = New System.Drawing.Point(7, 65)
        Me.DgvBanco.Name = "DgvBanco"
        Me.DgvBanco.Size = New System.Drawing.Size(505, 110)
        Me.DgvBanco.TabIndex = 59
        '
        'BtnValBanco
        '
        Me.BtnValBanco.BackColor = System.Drawing.Color.Transparent
        Me.BtnValBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnValBanco.ForeColor = System.Drawing.Color.DimGray
        Me.BtnValBanco.Image = CType(resources.GetObject("BtnValBanco.Image"), System.Drawing.Image)
        Me.BtnValBanco.Location = New System.Drawing.Point(522, 39)
        Me.BtnValBanco.Name = "BtnValBanco"
        Me.BtnValBanco.Size = New System.Drawing.Size(24, 20)
        Me.BtnValBanco.TabIndex = 23
        Me.BtnValBanco.UseVisualStyleBackColor = False
        '
        'TxbConta
        '
        Me.TxbConta.Location = New System.Drawing.Point(184, 39)
        Me.TxbConta.Name = "TxbConta"
        Me.TxbConta.Size = New System.Drawing.Size(66, 20)
        Me.TxbConta.TabIndex = 19
        '
        'txbAgencia
        '
        Me.txbAgencia.Location = New System.Drawing.Point(75, 39)
        Me.txbAgencia.Name = "txbAgencia"
        Me.txbAgencia.Size = New System.Drawing.Size(66, 20)
        Me.txbAgencia.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Agencia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Mnemônico:"
        '
        'BtnMenmonico
        '
        Me.BtnMenmonico.BackColor = System.Drawing.Color.Transparent
        Me.BtnMenmonico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenmonico.ForeColor = System.Drawing.Color.DimGray
        Me.BtnMenmonico.Image = CType(resources.GetObject("BtnMenmonico.Image"), System.Drawing.Image)
        Me.BtnMenmonico.Location = New System.Drawing.Point(522, 16)
        Me.BtnMenmonico.Name = "BtnMenmonico"
        Me.BtnMenmonico.Size = New System.Drawing.Size(24, 20)
        Me.BtnMenmonico.TabIndex = 17
        Me.BtnMenmonico.UseVisualStyleBackColor = False
        '
        'TxbNomBanco
        '
        Me.TxbNomBanco.Location = New System.Drawing.Point(129, 16)
        Me.TxbNomBanco.Name = "TxbNomBanco"
        Me.TxbNomBanco.Size = New System.Drawing.Size(390, 20)
        Me.TxbNomBanco.TabIndex = 16
        '
        'TxbCodBanco
        '
        Me.TxbCodBanco.Location = New System.Drawing.Point(75, 16)
        Me.TxbCodBanco.Name = "TxbCodBanco"
        Me.TxbCodBanco.Size = New System.Drawing.Size(52, 20)
        Me.TxbCodBanco.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(147, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Conta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(400, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Valor:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TxbValEspecie)
        Me.GroupBox1.Controls.Add(Me.BtnValEspecie)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnBuscaEspecie)
        Me.GroupBox1.Controls.Add(Me.txbDesEspecie)
        Me.GroupBox1.Controls.Add(Me.TxbCodEspecie)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 48)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caixa"
        '
        'TxbValEspecie
        '
        Me.TxbValEspecie.Location = New System.Drawing.Point(432, 16)
        Me.TxbValEspecie.Name = "TxbValEspecie"
        Me.TxbValEspecie.Size = New System.Drawing.Size(87, 20)
        Me.TxbValEspecie.TabIndex = 13
        Me.TxbValEspecie.Text = "0,00"
        Me.TxbValEspecie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnValEspecie
        '
        Me.BtnValEspecie.BackColor = System.Drawing.Color.Transparent
        Me.BtnValEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnValEspecie.ForeColor = System.Drawing.Color.DimGray
        Me.BtnValEspecie.Image = CType(resources.GetObject("BtnValEspecie.Image"), System.Drawing.Image)
        Me.BtnValEspecie.Location = New System.Drawing.Point(522, 16)
        Me.BtnValEspecie.Name = "BtnValEspecie"
        Me.BtnValEspecie.Size = New System.Drawing.Size(24, 20)
        Me.BtnValEspecie.TabIndex = 14
        Me.BtnValEspecie.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Espécie:"
        '
        'BtnBuscaEspecie
        '
        Me.BtnBuscaEspecie.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscaEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaEspecie.ForeColor = System.Drawing.Color.DimGray
        Me.BtnBuscaEspecie.Image = CType(resources.GetObject("BtnBuscaEspecie.Image"), System.Drawing.Image)
        Me.BtnBuscaEspecie.Location = New System.Drawing.Point(368, 16)
        Me.BtnBuscaEspecie.Name = "BtnBuscaEspecie"
        Me.BtnBuscaEspecie.Size = New System.Drawing.Size(24, 20)
        Me.BtnBuscaEspecie.TabIndex = 12
        Me.BtnBuscaEspecie.UseVisualStyleBackColor = False
        '
        'txbDesEspecie
        '
        Me.txbDesEspecie.Location = New System.Drawing.Point(137, 16)
        Me.txbDesEspecie.Name = "txbDesEspecie"
        Me.txbDesEspecie.Size = New System.Drawing.Size(229, 20)
        Me.txbDesEspecie.TabIndex = 11
        '
        'TxbCodEspecie
        '
        Me.TxbCodEspecie.Location = New System.Drawing.Point(75, 16)
        Me.TxbCodEspecie.Name = "TxbCodEspecie"
        Me.TxbCodEspecie.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodEspecie.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Valor:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.TxbValJuroPrincPorc)
        Me.GroupBox5.Controls.Add(Me.TxbValDescPorc)
        Me.GroupBox5.Controls.Add(Me.TxbDtaLiquidacao)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Controls.Add(Me.TxbValAcrescimo)
        Me.GroupBox5.Controls.Add(Me.DtpDtaLiquidacao)
        Me.GroupBox5.Controls.Add(Me.TxbValMulta)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.TxbValDespAcess)
        Me.GroupBox5.Controls.Add(Me.TxbValJurosPrinc)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.TxbValPendente)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.TxbValDesconto)
        Me.GroupBox5.Controls.Add(Me.TxbValLiquidado)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.TxbValOriginal)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 38)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(550, 87)
        Me.GroupBox5.TabIndex = 56
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Caixa"
        '
        'TxbValJuroPrincPorc
        '
        Me.TxbValJuroPrincPorc.Location = New System.Drawing.Point(159, 60)
        Me.TxbValJuroPrincPorc.Name = "TxbValJuroPrincPorc"
        Me.TxbValJuroPrincPorc.Size = New System.Drawing.Size(58, 20)
        Me.TxbValJuroPrincPorc.TabIndex = 78
        Me.TxbValJuroPrincPorc.Text = "0,000"
        Me.TxbValJuroPrincPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbValDescPorc
        '
        Me.TxbValDescPorc.Location = New System.Drawing.Point(159, 37)
        Me.TxbValDescPorc.Name = "TxbValDescPorc"
        Me.TxbValDescPorc.Size = New System.Drawing.Size(58, 20)
        Me.TxbValDescPorc.TabIndex = 77
        Me.TxbValDescPorc.Text = "0,000"
        Me.TxbValDescPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbDtaLiquidacao
        '
        Me.TxbDtaLiquidacao.Location = New System.Drawing.Point(459, 60)
        Me.TxbDtaLiquidacao.MaxLength = 10
        Me.TxbDtaLiquidacao.Name = "TxbDtaLiquidacao"
        Me.TxbDtaLiquidacao.Size = New System.Drawing.Size(71, 20)
        Me.TxbDtaLiquidacao.TabIndex = 8
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(400, 64)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 13)
        Me.Label28.TabIndex = 68
        Me.Label28.Text = "Liquidação:"
        '
        'TxbValAcrescimo
        '
        Me.TxbValAcrescimo.Location = New System.Drawing.Point(305, 60)
        Me.TxbValAcrescimo.Name = "TxbValAcrescimo"
        Me.TxbValAcrescimo.Size = New System.Drawing.Size(87, 20)
        Me.TxbValAcrescimo.TabIndex = 7
        Me.TxbValAcrescimo.Text = "0,00"
        Me.TxbValAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DtpDtaLiquidacao
        '
        Me.DtpDtaLiquidacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaLiquidacao.Location = New System.Drawing.Point(532, 60)
        Me.DtpDtaLiquidacao.Name = "DtpDtaLiquidacao"
        Me.DtpDtaLiquidacao.Size = New System.Drawing.Size(14, 20)
        Me.DtpDtaLiquidacao.TabIndex = 9
        Me.DtpDtaLiquidacao.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'TxbValMulta
        '
        Me.TxbValMulta.Location = New System.Drawing.Point(459, 37)
        Me.TxbValMulta.Name = "TxbValMulta"
        Me.TxbValMulta.Size = New System.Drawing.Size(87, 20)
        Me.TxbValMulta.TabIndex = 4
        Me.TxbValMulta.Text = "0,00"
        Me.TxbValMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(426, 39)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(36, 13)
        Me.Label26.TabIndex = 73
        Me.Label26.Text = "Multa:"
        '
        'TxbValDespAcess
        '
        Me.TxbValDespAcess.Location = New System.Drawing.Point(305, 37)
        Me.TxbValDespAcess.Name = "TxbValDespAcess"
        Me.TxbValDespAcess.Size = New System.Drawing.Size(87, 20)
        Me.TxbValDespAcess.TabIndex = 3
        Me.TxbValDespAcess.Text = "0,00"
        Me.TxbValDespAcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbValJurosPrinc
        '
        Me.TxbValJurosPrinc.Location = New System.Drawing.Point(75, 60)
        Me.TxbValJurosPrinc.Name = "TxbValJurosPrinc"
        Me.TxbValJurosPrinc.Size = New System.Drawing.Size(70, 20)
        Me.TxbValJurosPrinc.TabIndex = 5
        Me.TxbValJurosPrinc.Text = "0,00"
        Me.TxbValJurosPrinc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(4, 64)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 13)
        Me.Label23.TabIndex = 67
        Me.Label23.Text = "Vlr Juros:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(143, 62)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(20, 16)
        Me.Label24.TabIndex = 68
        Me.Label24.Text = "%"
        '
        'TxbValDesconto
        '
        Me.TxbValDesconto.Location = New System.Drawing.Point(75, 37)
        Me.TxbValDesconto.Name = "TxbValDesconto"
        Me.TxbValDesconto.Size = New System.Drawing.Size(70, 20)
        Me.TxbValDesconto.TabIndex = 1
        Me.TxbValDesconto.Text = "0,00"
        Me.TxbValDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(4, 41)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 13)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Desconto:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(143, 39)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(20, 16)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "%"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(242, 64)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 13)
        Me.Label27.TabIndex = 75
        Me.Label27.Text = "Acréscimos:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(222, 41)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 13)
        Me.Label25.TabIndex = 71
        Me.Label25.Text = "Desp.Acessória:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxbValTotal)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(550, 34)
        Me.GroupBox6.TabIndex = 76
        Me.GroupBox6.TabStop = False
        '
        'TxbValTotal
        '
        Me.TxbValTotal.Location = New System.Drawing.Point(159, 8)
        Me.TxbValTotal.Name = "TxbValTotal"
        Me.TxbValTotal.ReadOnly = True
        Me.TxbValTotal.Size = New System.Drawing.Size(87, 20)
        Me.TxbValTotal.TabIndex = 77
        Me.TxbValTotal.Text = "0,00"
        Me.TxbValTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(127, 12)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 13)
        Me.Label29.TabIndex = 78
        Me.Label29.Text = "Total:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnExtornaPagto)
        Me.GroupBox4.Controls.Add(Me.BtnConfirmaPagto)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(10, -3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(550, 46)
        Me.GroupBox4.TabIndex = 67
        Me.GroupBox4.TabStop = False
        '
        'BtnExtornaPagto
        '
        Me.BtnExtornaPagto.BackColor = System.Drawing.Color.Transparent
        Me.BtnExtornaPagto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExtornaPagto.ForeColor = System.Drawing.Color.Black
        Me.BtnExtornaPagto.Image = Global.WindowsApp1.My.Resources.Resources.sair
        Me.BtnExtornaPagto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExtornaPagto.Location = New System.Drawing.Point(97, 10)
        Me.BtnExtornaPagto.Name = "BtnExtornaPagto"
        Me.BtnExtornaPagto.Size = New System.Drawing.Size(83, 31)
        Me.BtnExtornaPagto.TabIndex = 1
        Me.BtnExtornaPagto.Text = "Extornar"
        Me.BtnExtornaPagto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExtornaPagto.UseVisualStyleBackColor = False
        '
        'BtnConfirmaPagto
        '
        Me.BtnConfirmaPagto.BackColor = System.Drawing.Color.Transparent
        Me.BtnConfirmaPagto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmaPagto.ForeColor = System.Drawing.Color.Black
        Me.BtnConfirmaPagto.Image = Global.WindowsApp1.My.Resources.Resources.img_salva_pb
        Me.BtnConfirmaPagto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConfirmaPagto.Location = New System.Drawing.Point(9, 10)
        Me.BtnConfirmaPagto.Name = "BtnConfirmaPagto"
        Me.BtnConfirmaPagto.Size = New System.Drawing.Size(83, 31)
        Me.BtnConfirmaPagto.TabIndex = 0
        Me.BtnConfirmaPagto.Text = "  Confirmar"
        Me.BtnConfirmaPagto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConfirmaPagto.UseVisualStyleBackColor = False
        '
        'FrmPagamentoRecebimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(569, 589)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "FrmPagamentoRecebimento"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GbParcelaAutomatica.ResumeLayout(False)
        Me.GbParcelaAutomatica.PerformLayout()
        CType(Me.DgvParcela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxbValPendente As Controles.TxbMonetario
    Friend WithEvents Label17 As Label
    Friend WithEvents TxbValLiquidado As Controles.TxbMonetario
    Friend WithEvents Label16 As Label
    Friend WithEvents TxbValOriginal As Controles.TxbMonetario
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GbParcelaAutomatica As GroupBox
    Friend WithEvents TxbQtdParcela As Controles.TxbCodigo
    Friend WithEvents TxbIntervalVencto As Controles.TxbCodigo
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CkbDiaFixo As CheckBox
    Friend WithEvents BtnLimpaParcela As Button
    Friend WithEvents BtnSalvaParcela As Button
    Friend WithEvents BtnExcluiParcela As Button
    Friend WithEvents DgvParcela As DataGridView
    Friend WithEvents TxbValJurosParc As Controles.TxbMonetario
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnValParc As Button
    Friend WithEvents TxbValParcela As Controles.TxbMonetario
    Friend WithEvents Label7 As Label
    Friend WithEvents TxbDtaVencimentoParc As Controles.TxbData
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnLimpaBanco As Button
    Friend WithEvents BtnSalvaBanco As Button
    Friend WithEvents BtnExcluiBanco As Button
    Friend WithEvents DgvBanco As DataGridView
    Friend WithEvents BtnValBanco As Button
    Friend WithEvents TxbValBanco As Controles.TxbMonetario
    Friend WithEvents TxbConta As TextBox
    Friend WithEvents txbAgencia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnMenmonico As Button
    Friend WithEvents TxbNomBanco As TextBox
    Friend WithEvents TxbCodBanco As Controles.TxbCodigo
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnValEspecie As Button
    Friend WithEvents TxbValEspecie As Controles.TxbMonetario
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBuscaEspecie As Button
    Friend WithEvents txbDesEspecie As TextBox
    Friend WithEvents TxbCodEspecie As Controles.TxbCodigo
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpDtaVenctoParc As DateTimePicker
    Friend WithEvents TxbDtaPredatado As Controles.TxbData
    Friend WithEvents Label18 As Label
    Friend WithEvents DtpDtaPredatado As DateTimePicker
    Friend WithEvents lbSeqPagamento As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnTipoParcelamento As Button
    Friend WithEvents TxbDesTipoParcela As TextBox
    Friend WithEvents TxbCodTipoParcela As Controles.TxbCodigo
    Friend WithEvents LbSeqParcelamento As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TxbDtaLiquidacao As Controles.TxbData
    Friend WithEvents Label28 As Label
    Friend WithEvents TxbValAcrescimo As Controles.TxbMonetario
    Friend WithEvents DtpDtaLiquidacao As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents TxbValMulta As Controles.TxbMonetario
    Friend WithEvents Label26 As Label
    Friend WithEvents TxbValDespAcess As Controles.TxbMonetario
    Friend WithEvents Label25 As Label
    Friend WithEvents TxbValJurosPrinc As Controles.TxbMonetario
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents TxbValDesconto As Controles.TxbMonetario
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TxbValTotal As Controles.TxbMonetario
    Friend WithEvents Label29 As Label
    Friend WithEvents TxbValJurosParcPorc As Controles.TxbMonetario
    Friend WithEvents Label30 As Label
    Friend WithEvents ckbParcelaAutomatica As CheckBox
    Friend WithEvents LbTotalParcela As Label
    Friend WithEvents LbTotalBanco As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents TxbValDescPorc As Controles.TxbMonetario3casa
    Friend WithEvents TxbValJuroPrincPorc As Controles.TxbMonetario3casa
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnExtornaPagto As Button
    Friend WithEvents BtnConfirmaPagto As Button
End Class
