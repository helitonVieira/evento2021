<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEvento
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEvento))
        Me.BtLimpar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.DtpDtaEvento = New System.Windows.Forms.DateTimePicker()
        Me.TxtDesLote = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNome3 = New System.Windows.Forms.TextBox()
        Me.TxtNome2 = New System.Windows.Forms.TextBox()
        Me.Txt_observacao2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_observacao1 = New System.Windows.Forms.TextBox()
        Me.lb_observacao = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbIndAberto = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtValEntrada = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNome1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodEvento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.DgvEvento = New System.Windows.Forms.DataGridView()
        Me.BtPresquisa = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.BtIngresso = New System.Windows.Forms.Button()
        Me.PrintDocumentLucro = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btRelatorio = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxbQtdeImpressa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtImprimirIngresso = New System.Windows.Forms.Button()
        Me.LbSequenciaIngresso = New System.Windows.Forms.Label()
        Me.BtSalvaIngresso = New System.Windows.Forms.Button()
        Me.BtExcluirIngresso = New System.Windows.Forms.Button()
        Me.BtLimparIngresso = New System.Windows.Forms.Button()
        Me.DgvIngresso = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BtCadPessoa = New System.Windows.Forms.Button()
        Me.BtRelIngresso = New System.Windows.Forms.Button()
        Me.LbQtdDisponivel = New System.Windows.Forms.Label()
        Me.lbDesQtdDisponivel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxbQtdDevolvIP = New System.Windows.Forms.TextBox()
        Me.DtpDtaEntIngPessoa = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtBuscaPessoaIP = New System.Windows.Forms.Button()
        Me.btBuscaIngressoIP = New System.Windows.Forms.Button()
        Me.TxbNomPessoaIP = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxbCodPessoaIP = New System.Windows.Forms.TextBox()
        Me.TxbDesImpressaoIP = New System.Windows.Forms.TextBox()
        Me.TxbObsIP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxbCodImpressaoIP = New System.Windows.Forms.TextBox()
        Me.TxbCodigoIP = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxbQtdEntregueIP = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DgvIngressoPessoa = New System.Windows.Forms.DataGridView()
        Me.BtSalvaIngPessoa = New System.Windows.Forms.Button()
        Me.BtExcluirIngPessoa = New System.Windows.Forms.Button()
        Me.BtLimpaIngPessoa = New System.Windows.Forms.Button()
        Me.PrintDocRelIngresso = New System.Drawing.Printing.PrintDocument()
        CType(Me.DgvEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvIngresso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvIngressoPessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtLimpar
        '
        Me.BtLimpar.Image = CType(resources.GetObject("BtLimpar.Image"), System.Drawing.Image)
        Me.BtLimpar.Location = New System.Drawing.Point(122, 11)
        Me.BtLimpar.Name = "BtLimpar"
        Me.BtLimpar.Size = New System.Drawing.Size(48, 50)
        Me.BtLimpar.TabIndex = 14
        Me.BtLimpar.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.Location = New System.Drawing.Point(64, 11)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(48, 50)
        Me.BtnExcluir.TabIndex = 13
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'DtpDtaEvento
        '
        Me.DtpDtaEvento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpDtaEvento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaEvento.Location = New System.Drawing.Point(67, 74)
        Me.DtpDtaEvento.Name = "DtpDtaEvento"
        Me.DtpDtaEvento.Size = New System.Drawing.Size(80, 20)
        Me.DtpDtaEvento.TabIndex = 3
        Me.DtpDtaEvento.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'TxtDesLote
        '
        Me.TxtDesLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDesLote.Location = New System.Drawing.Point(209, 71)
        Me.TxtDesLote.Name = "TxtDesLote"
        Me.TxtDesLote.Size = New System.Drawing.Size(108, 20)
        Me.TxtDesLote.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(175, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Lote"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Descrição 3 "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Nome"
        '
        'TxtNome3
        '
        Me.TxtNome3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNome3.Location = New System.Drawing.Point(91, 45)
        Me.TxtNome3.MaxLength = 18
        Me.TxtNome3.Name = "TxtNome3"
        Me.TxtNome3.Size = New System.Drawing.Size(226, 20)
        Me.TxtNome3.TabIndex = 6
        '
        'TxtNome2
        '
        Me.TxtNome2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNome2.Location = New System.Drawing.Point(91, 19)
        Me.TxtNome2.MaxLength = 18
        Me.TxtNome2.Name = "TxtNome2"
        Me.TxtNome2.Size = New System.Drawing.Size(226, 20)
        Me.TxtNome2.TabIndex = 5
        '
        'Txt_observacao2
        '
        Me.Txt_observacao2.Location = New System.Drawing.Point(91, 122)
        Me.Txt_observacao2.MaxLength = 40
        Me.Txt_observacao2.Name = "Txt_observacao2"
        Me.Txt_observacao2.Size = New System.Drawing.Size(226, 20)
        Me.Txt_observacao2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Observação 2"
        '
        'Txt_observacao1
        '
        Me.Txt_observacao1.Location = New System.Drawing.Point(91, 96)
        Me.Txt_observacao1.MaxLength = 40
        Me.Txt_observacao1.Name = "Txt_observacao1"
        Me.Txt_observacao1.Size = New System.Drawing.Size(226, 20)
        Me.Txt_observacao1.TabIndex = 9
        '
        'lb_observacao
        '
        Me.lb_observacao.AutoSize = True
        Me.lb_observacao.Location = New System.Drawing.Point(8, 99)
        Me.lb_observacao.Name = "lb_observacao"
        Me.lb_observacao.Size = New System.Drawing.Size(74, 13)
        Me.lb_observacao.TabIndex = 15
        Me.lb_observacao.Text = "Observação 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Aberto"
        '
        'CbIndAberto
        '
        Me.CbIndAberto.FormattingEnabled = True
        Me.CbIndAberto.Items.AddRange(New Object() {"SIM", "NAO"})
        Me.CbIndAberto.Location = New System.Drawing.Point(67, 100)
        Me.CbIndAberto.Name = "CbIndAberto"
        Me.CbIndAberto.Size = New System.Drawing.Size(80, 21)
        Me.CbIndAberto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Data"
        '
        'TxtValEntrada
        '
        Me.TxtValEntrada.Location = New System.Drawing.Point(91, 71)
        Me.TxtValEntrada.Name = "TxtValEntrada"
        Me.TxtValEntrada.Size = New System.Drawing.Size(80, 20)
        Me.TxtValEntrada.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Val. Entrada"
        '
        'TxtNome1
        '
        Me.TxtNome1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNome1.Location = New System.Drawing.Point(67, 46)
        Me.TxtNome1.MaxLength = 18
        Me.TxtNome1.Name = "TxtNome1"
        Me.TxtNome1.Size = New System.Drawing.Size(256, 20)
        Me.TxtNome1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descrição 2"
        '
        'TxtCodEvento
        '
        Me.TxtCodEvento.Enabled = False
        Me.TxtCodEvento.Location = New System.Drawing.Point(67, 19)
        Me.TxtCodEvento.Name = "TxtCodEvento"
        Me.TxtCodEvento.Size = New System.Drawing.Size(55, 20)
        Me.TxtCodEvento.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código"
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(6, 11)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(48, 50)
        Me.BtnSalvar.TabIndex = 11
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'DgvEvento
        '
        Me.DgvEvento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEvento.Location = New System.Drawing.Point(6, 152)
        Me.DgvEvento.Name = "DgvEvento"
        Me.DgvEvento.Size = New System.Drawing.Size(350, 193)
        Me.DgvEvento.TabIndex = 10
        '
        'BtPresquisa
        '
        Me.BtPresquisa.Image = CType(resources.GetObject("BtPresquisa.Image"), System.Drawing.Image)
        Me.BtPresquisa.Location = New System.Drawing.Point(183, 11)
        Me.BtPresquisa.Name = "BtPresquisa"
        Me.BtPresquisa.Size = New System.Drawing.Size(48, 50)
        Me.BtPresquisa.TabIndex = 9
        Me.BtPresquisa.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'BtIngresso
        '
        Me.BtIngresso.Image = CType(resources.GetObject("BtIngresso.Image"), System.Drawing.Image)
        Me.BtIngresso.Location = New System.Drawing.Point(296, 11)
        Me.BtIngresso.Name = "BtIngresso"
        Me.BtIngresso.Size = New System.Drawing.Size(48, 50)
        Me.BtIngresso.TabIndex = 16
        Me.BtIngresso.UseVisualStyleBackColor = True
        '
        'PrintDocumentLucro
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtPresquisa)
        Me.GroupBox2.Controls.Add(Me.BtIngresso)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.Controls.Add(Me.btRelatorio)
        Me.GroupBox2.Controls.Add(Me.BtnExcluir)
        Me.GroupBox2.Controls.Add(Me.BtLimpar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 67)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'btRelatorio
        '
        Me.btRelatorio.Image = CType(resources.GetObject("btRelatorio.Image"), System.Drawing.Image)
        Me.btRelatorio.Location = New System.Drawing.Point(238, 11)
        Me.btRelatorio.Name = "btRelatorio"
        Me.btRelatorio.Size = New System.Drawing.Size(48, 50)
        Me.btRelatorio.TabIndex = 15
        Me.btRelatorio.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 74)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(370, 378)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.DgvEvento)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(362, 352)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Evento"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxbQtdeImpressa)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.DtpDtaEvento)
        Me.GroupBox3.Controls.Add(Me.TxtCodEvento)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtNome1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.CbIndAberto)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(349, 140)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Eventos"
        '
        'TxbQtdeImpressa
        '
        Me.TxbQtdeImpressa.Enabled = False
        Me.TxbQtdeImpressa.Location = New System.Drawing.Point(268, 16)
        Me.TxbQtdeImpressa.Name = "TxbQtdeImpressa"
        Me.TxbQtdeImpressa.Size = New System.Drawing.Size(55, 20)
        Me.TxbQtdeImpressa.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(187, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Qtde Impressa"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtImprimirIngresso)
        Me.TabPage2.Controls.Add(Me.LbSequenciaIngresso)
        Me.TabPage2.Controls.Add(Me.BtSalvaIngresso)
        Me.TabPage2.Controls.Add(Me.BtExcluirIngresso)
        Me.TabPage2.Controls.Add(Me.BtLimparIngresso)
        Me.TabPage2.Controls.Add(Me.DgvIngresso)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(362, 352)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingresso"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtImprimirIngresso
        '
        Me.BtImprimirIngresso.Image = CType(resources.GetObject("BtImprimirIngresso.Image"), System.Drawing.Image)
        Me.BtImprimirIngresso.Location = New System.Drawing.Point(234, 10)
        Me.BtImprimirIngresso.Name = "BtImprimirIngresso"
        Me.BtImprimirIngresso.Size = New System.Drawing.Size(48, 50)
        Me.BtImprimirIngresso.TabIndex = 25
        Me.BtImprimirIngresso.UseVisualStyleBackColor = True
        '
        'LbSequenciaIngresso
        '
        Me.LbSequenciaIngresso.AutoSize = True
        Me.LbSequenciaIngresso.Location = New System.Drawing.Point(295, 10)
        Me.LbSequenciaIngresso.Name = "LbSequenciaIngresso"
        Me.LbSequenciaIngresso.Size = New System.Drawing.Size(58, 13)
        Me.LbSequenciaIngresso.TabIndex = 24
        Me.LbSequenciaIngresso.Text = "Sequencia"
        '
        'BtSalvaIngresso
        '
        Me.BtSalvaIngresso.Image = CType(resources.GetObject("BtSalvaIngresso.Image"), System.Drawing.Image)
        Me.BtSalvaIngresso.Location = New System.Drawing.Point(6, 10)
        Me.BtSalvaIngresso.Name = "BtSalvaIngresso"
        Me.BtSalvaIngresso.Size = New System.Drawing.Size(48, 50)
        Me.BtSalvaIngresso.TabIndex = 15
        Me.BtSalvaIngresso.UseVisualStyleBackColor = True
        '
        'BtExcluirIngresso
        '
        Me.BtExcluirIngresso.Image = CType(resources.GetObject("BtExcluirIngresso.Image"), System.Drawing.Image)
        Me.BtExcluirIngresso.Location = New System.Drawing.Point(64, 10)
        Me.BtExcluirIngresso.Name = "BtExcluirIngresso"
        Me.BtExcluirIngresso.Size = New System.Drawing.Size(48, 50)
        Me.BtExcluirIngresso.TabIndex = 16
        Me.BtExcluirIngresso.UseVisualStyleBackColor = True
        '
        'BtLimparIngresso
        '
        Me.BtLimparIngresso.Image = CType(resources.GetObject("BtLimparIngresso.Image"), System.Drawing.Image)
        Me.BtLimparIngresso.Location = New System.Drawing.Point(122, 10)
        Me.BtLimparIngresso.Name = "BtLimparIngresso"
        Me.BtLimparIngresso.Size = New System.Drawing.Size(48, 50)
        Me.BtLimparIngresso.TabIndex = 17
        Me.BtLimparIngresso.UseVisualStyleBackColor = True
        '
        'DgvIngresso
        '
        Me.DgvIngresso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvIngresso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvIngresso.Location = New System.Drawing.Point(6, 223)
        Me.DgvIngresso.Name = "DgvIngresso"
        Me.DgvIngresso.Size = New System.Drawing.Size(347, 122)
        Me.DgvIngresso.TabIndex = 11
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtDesLote)
        Me.GroupBox4.Controls.Add(Me.Txt_observacao2)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.TxtNome3)
        Me.GroupBox4.Controls.Add(Me.TxtValEntrada)
        Me.GroupBox4.Controls.Add(Me.TxtNome2)
        Me.GroupBox4.Controls.Add(Me.lb_observacao)
        Me.GroupBox4.Controls.Add(Me.Txt_observacao1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 66)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(350, 151)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ingressos"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.BtCadPessoa)
        Me.TabPage3.Controls.Add(Me.BtRelIngresso)
        Me.TabPage3.Controls.Add(Me.LbQtdDisponivel)
        Me.TabPage3.Controls.Add(Me.lbDesQtdDisponivel)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.DgvIngressoPessoa)
        Me.TabPage3.Controls.Add(Me.BtSalvaIngPessoa)
        Me.TabPage3.Controls.Add(Me.BtExcluirIngPessoa)
        Me.TabPage3.Controls.Add(Me.BtLimpaIngPessoa)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(362, 352)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ingresso/Pessoa"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BtCadPessoa
        '
        Me.BtCadPessoa.Image = CType(resources.GetObject("BtCadPessoa.Image"), System.Drawing.Image)
        Me.BtCadPessoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtCadPessoa.Location = New System.Drawing.Point(311, 6)
        Me.BtCadPessoa.Name = "BtCadPessoa"
        Me.BtCadPessoa.Size = New System.Drawing.Size(48, 50)
        Me.BtCadPessoa.TabIndex = 115
        Me.BtCadPessoa.UseVisualStyleBackColor = True
        '
        'BtRelIngresso
        '
        Me.BtRelIngresso.Image = CType(resources.GetObject("BtRelIngresso.Image"), System.Drawing.Image)
        Me.BtRelIngresso.Location = New System.Drawing.Point(180, 6)
        Me.BtRelIngresso.Name = "BtRelIngresso"
        Me.BtRelIngresso.Size = New System.Drawing.Size(48, 50)
        Me.BtRelIngresso.TabIndex = 114
        Me.BtRelIngresso.UseVisualStyleBackColor = True
        '
        'LbQtdDisponivel
        '
        Me.LbQtdDisponivel.AutoSize = True
        Me.LbQtdDisponivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbQtdDisponivel.Location = New System.Drawing.Point(258, 31)
        Me.LbQtdDisponivel.Name = "LbQtdDisponivel"
        Me.LbQtdDisponivel.Size = New System.Drawing.Size(24, 25)
        Me.LbQtdDisponivel.TabIndex = 113
        Me.LbQtdDisponivel.Text = "0"
        Me.LbQtdDisponivel.Visible = False
        '
        'lbDesQtdDisponivel
        '
        Me.lbDesQtdDisponivel.AutoSize = True
        Me.lbDesQtdDisponivel.Location = New System.Drawing.Point(234, 6)
        Me.lbDesQtdDisponivel.Name = "lbDesQtdDisponivel"
        Me.lbDesQtdDisponivel.Size = New System.Drawing.Size(78, 13)
        Me.lbDesQtdDisponivel.TabIndex = 112
        Me.lbDesQtdDisponivel.Text = "Qtd Disponível"
        Me.lbDesQtdDisponivel.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TxbQtdDevolvIP)
        Me.GroupBox1.Controls.Add(Me.DtpDtaEntIngPessoa)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.BtBuscaPessoaIP)
        Me.GroupBox1.Controls.Add(Me.btBuscaIngressoIP)
        Me.GroupBox1.Controls.Add(Me.TxbNomPessoaIP)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxbCodPessoaIP)
        Me.GroupBox1.Controls.Add(Me.TxbDesImpressaoIP)
        Me.GroupBox1.Controls.Add(Me.TxbObsIP)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxbCodImpressaoIP)
        Me.GroupBox1.Controls.Add(Me.TxbCodigoIP)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TxbQtdEntregueIP)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 151)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresso/Pessoa"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(180, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Qtd.Devolvida"
        '
        'TxbQtdDevolvIP
        '
        Me.TxbQtdDevolvIP.Location = New System.Drawing.Point(261, 97)
        Me.TxbQtdDevolvIP.MaxLength = 40
        Me.TxbQtdDevolvIP.Name = "TxbQtdDevolvIP"
        Me.TxbQtdDevolvIP.Size = New System.Drawing.Size(83, 20)
        Me.TxbQtdDevolvIP.TabIndex = 19
        '
        'DtpDtaEntIngPessoa
        '
        Me.DtpDtaEntIngPessoa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpDtaEntIngPessoa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaEntIngPessoa.Location = New System.Drawing.Point(264, 19)
        Me.DtpDtaEntIngPessoa.Name = "DtpDtaEntIngPessoa"
        Me.DtpDtaEntIngPessoa.Size = New System.Drawing.Size(80, 20)
        Me.DtpDtaEntIngPessoa.TabIndex = 11
        Me.DtpDtaEntIngPessoa.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(228, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Data"
        '
        'BtBuscaPessoaIP
        '
        Me.BtBuscaPessoaIP.Image = CType(resources.GetObject("BtBuscaPessoaIP.Image"), System.Drawing.Image)
        Me.BtBuscaPessoaIP.Location = New System.Drawing.Point(319, 70)
        Me.BtBuscaPessoaIP.Name = "BtBuscaPessoaIP"
        Me.BtBuscaPessoaIP.Size = New System.Drawing.Size(25, 21)
        Me.BtBuscaPessoaIP.TabIndex = 17
        Me.BtBuscaPessoaIP.UseVisualStyleBackColor = True
        '
        'btBuscaIngressoIP
        '
        Me.btBuscaIngressoIP.Image = CType(resources.GetObject("btBuscaIngressoIP.Image"), System.Drawing.Image)
        Me.btBuscaIngressoIP.Location = New System.Drawing.Point(319, 44)
        Me.btBuscaIngressoIP.Name = "btBuscaIngressoIP"
        Me.btBuscaIngressoIP.Size = New System.Drawing.Size(25, 21)
        Me.btBuscaIngressoIP.TabIndex = 14
        Me.btBuscaIngressoIP.UseVisualStyleBackColor = True
        '
        'TxbNomPessoaIP
        '
        Me.TxbNomPessoaIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomPessoaIP.Location = New System.Drawing.Point(137, 70)
        Me.TxbNomPessoaIP.MaxLength = 18
        Me.TxbNomPessoaIP.Name = "TxbNomPessoaIP"
        Me.TxbNomPessoaIP.Size = New System.Drawing.Size(180, 20)
        Me.TxbNomPessoaIP.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Pessoa"
        '
        'TxbCodPessoaIP
        '
        Me.TxbCodPessoaIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbCodPessoaIP.Location = New System.Drawing.Point(72, 70)
        Me.TxbCodPessoaIP.MaxLength = 18
        Me.TxbCodPessoaIP.Name = "TxbCodPessoaIP"
        Me.TxbCodPessoaIP.Size = New System.Drawing.Size(59, 20)
        Me.TxbCodPessoaIP.TabIndex = 15
        '
        'TxbDesImpressaoIP
        '
        Me.TxbDesImpressaoIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesImpressaoIP.Location = New System.Drawing.Point(137, 45)
        Me.TxbDesImpressaoIP.MaxLength = 18
        Me.TxbDesImpressaoIP.Name = "TxbDesImpressaoIP"
        Me.TxbDesImpressaoIP.Size = New System.Drawing.Size(180, 20)
        Me.TxbDesImpressaoIP.TabIndex = 13
        '
        'TxbObsIP
        '
        Me.TxbObsIP.Location = New System.Drawing.Point(72, 122)
        Me.TxbObsIP.MaxLength = 40
        Me.TxbObsIP.Name = "TxbObsIP"
        Me.TxbObsIP.Size = New System.Drawing.Size(272, 20)
        Me.TxbObsIP.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(2, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Sequencia"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(2, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Impressão"
        '
        'TxbCodImpressaoIP
        '
        Me.TxbCodImpressaoIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbCodImpressaoIP.Location = New System.Drawing.Point(72, 45)
        Me.TxbCodImpressaoIP.MaxLength = 18
        Me.TxbCodImpressaoIP.Name = "TxbCodImpressaoIP"
        Me.TxbCodImpressaoIP.Size = New System.Drawing.Size(59, 20)
        Me.TxbCodImpressaoIP.TabIndex = 12
        '
        'TxbCodigoIP
        '
        Me.TxbCodigoIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbCodigoIP.Enabled = False
        Me.TxbCodigoIP.Location = New System.Drawing.Point(72, 19)
        Me.TxbCodigoIP.MaxLength = 18
        Me.TxbCodigoIP.Name = "TxbCodigoIP"
        Me.TxbCodigoIP.Size = New System.Drawing.Size(59, 20)
        Me.TxbCodigoIP.TabIndex = 111
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(2, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Qtd.Entregue"
        '
        'TxbQtdEntregueIP
        '
        Me.TxbQtdEntregueIP.Location = New System.Drawing.Point(72, 96)
        Me.TxbQtdEntregueIP.MaxLength = 40
        Me.TxbQtdEntregueIP.Name = "TxbQtdEntregueIP"
        Me.TxbQtdEntregueIP.Size = New System.Drawing.Size(86, 20)
        Me.TxbQtdEntregueIP.TabIndex = 18
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(2, 125)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Observação"
        '
        'DgvIngressoPessoa
        '
        Me.DgvIngressoPessoa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvIngressoPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvIngressoPessoa.Location = New System.Drawing.Point(8, 224)
        Me.DgvIngressoPessoa.Name = "DgvIngressoPessoa"
        Me.DgvIngressoPessoa.Size = New System.Drawing.Size(347, 122)
        Me.DgvIngressoPessoa.TabIndex = 21
        '
        'BtSalvaIngPessoa
        '
        Me.BtSalvaIngPessoa.Image = CType(resources.GetObject("BtSalvaIngPessoa.Image"), System.Drawing.Image)
        Me.BtSalvaIngPessoa.Location = New System.Drawing.Point(6, 6)
        Me.BtSalvaIngPessoa.Name = "BtSalvaIngPessoa"
        Me.BtSalvaIngPessoa.Size = New System.Drawing.Size(48, 50)
        Me.BtSalvaIngPessoa.TabIndex = 18
        Me.BtSalvaIngPessoa.UseVisualStyleBackColor = True
        '
        'BtExcluirIngPessoa
        '
        Me.BtExcluirIngPessoa.Image = CType(resources.GetObject("BtExcluirIngPessoa.Image"), System.Drawing.Image)
        Me.BtExcluirIngPessoa.Location = New System.Drawing.Point(64, 6)
        Me.BtExcluirIngPessoa.Name = "BtExcluirIngPessoa"
        Me.BtExcluirIngPessoa.Size = New System.Drawing.Size(48, 50)
        Me.BtExcluirIngPessoa.TabIndex = 19
        Me.BtExcluirIngPessoa.UseVisualStyleBackColor = True
        '
        'BtLimpaIngPessoa
        '
        Me.BtLimpaIngPessoa.Image = CType(resources.GetObject("BtLimpaIngPessoa.Image"), System.Drawing.Image)
        Me.BtLimpaIngPessoa.Location = New System.Drawing.Point(122, 6)
        Me.BtLimpaIngPessoa.Name = "BtLimpaIngPessoa"
        Me.BtLimpaIngPessoa.Size = New System.Drawing.Size(48, 50)
        Me.BtLimpaIngPessoa.TabIndex = 20
        Me.BtLimpaIngPessoa.UseVisualStyleBackColor = True
        '
        'PrintDocRelIngresso
        '
        '
        'FrmEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 464)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmEvento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEvento_"
        CType(Me.DgvEvento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DgvIngresso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvIngressoPessoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtLimpar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CbIndAberto As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtValEntrada As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNome1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodEvento As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents DgvEvento As DataGridView
    Friend WithEvents Txt_observacao1 As TextBox
    Friend WithEvents lb_observacao As Label
    Friend WithEvents TxtNome2 As TextBox
    Friend WithEvents Txt_observacao2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNome3 As TextBox
    Friend WithEvents TxtDesLote As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DtpDtaEvento As DateTimePicker
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents BtIngresso As Button
    Friend WithEvents PrintDocumentLucro As Printing.PrintDocument
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtPresquisa As Button
    Friend WithEvents btRelatorio As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtSalvaIngresso As Button
    Friend WithEvents BtExcluirIngresso As Button
    Friend WithEvents BtLimparIngresso As Button
    Friend WithEvents DgvIngresso As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LbSequenciaIngresso As Label
    Friend WithEvents TxbQtdeImpressa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxbNomPessoaIP As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxbCodPessoaIP As TextBox
    Friend WithEvents TxbDesImpressaoIP As TextBox
    Friend WithEvents TxbObsIP As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxbCodImpressaoIP As TextBox
    Friend WithEvents TxbCodigoIP As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxbQtdEntregueIP As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents DgvIngressoPessoa As DataGridView
    Friend WithEvents BtSalvaIngPessoa As Button
    Friend WithEvents BtExcluirIngPessoa As Button
    Friend WithEvents BtLimpaIngPessoa As Button
    Friend WithEvents DtpDtaEntIngPessoa As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents BtBuscaPessoaIP As Button
    Friend WithEvents btBuscaIngressoIP As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents TxbQtdDevolvIP As TextBox
    Friend WithEvents LbQtdDisponivel As Label
    Friend WithEvents lbDesQtdDisponivel As Label
    Friend WithEvents BtRelIngresso As Button
    Friend WithEvents PrintDocRelIngresso As Printing.PrintDocument
    Friend WithEvents BtImprimirIngresso As Button
    Friend WithEvents BtCadPessoa As Button
End Class
