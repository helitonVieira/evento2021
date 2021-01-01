<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPDV2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPDV2))
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnTelaPagamento = New System.Windows.Forms.Button()
        Me.btnTelaVenda = New System.Windows.Forms.Button()
        Me.BtnTelaPessoa = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.GbBotaoAtalho = New System.Windows.Forms.GroupBox()
        Me.BtnFecharCaixa = New System.Windows.Forms.Button()
        Me.BtnSangria = New System.Windows.Forms.Button()
        Me.BtnCadPessoa = New System.Windows.Forms.Button()
        Me.BtnCadItem = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnDescAcresc = New System.Windows.Forms.Button()
        Me.BtnTelaItem = New System.Windows.Forms.Button()
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.PrintDocumentDespesa = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocRelResumoVenda = New System.Drawing.Printing.PrintDocument()
        Me.GbCabecalho = New System.Windows.Forms.GroupBox()
        Me.LbSeqFechamento = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.LbTurno = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LbCodCliente = New System.Windows.Forms.Label()
        Me.LbNomCliente = New System.Windows.Forms.Label()
        Me.LbCodPdv = New System.Windows.Forms.Label()
        Me.LbDesPdv = New System.Windows.Forms.Label()
        Me.LbNomOperador = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.LbTotalAcrescItem = New System.Windows.Forms.Label()
        Me.LbPorcAcresc = New System.Windows.Forms.Label()
        Me.LbValAcresc = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.LbTotalDescItem = New System.Windows.Forms.Label()
        Me.LbPorcDesc = New System.Windows.Forms.Label()
        Me.LbValDesc = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TxbCodItem = New System.Windows.Forms.TextBox()
        Me.LbDescricaoItem = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxbTotalGeral = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxbQtde = New System.Windows.Forms.TextBox()
        Me.TxbValorTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxbValorUnitario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvVenda = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxbBuscaNomPessoa = New System.Windows.Forms.TextBox()
        Me.DgvPessoa = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.TxbSaldoRestante = New Controles.TxbMonetario()
        Me.TxbTotalGeralPg = New Controles.TxbMonetario()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxbCodFormaPagto = New Controles.TxbCodigo()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.DgvPagamento = New System.Windows.Forms.DataGridView()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.txbTroco = New Controles.TxbMonetario()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.DgvFormaPagto = New System.Windows.Forms.DataGridView()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.LbPorcAcrescPg = New System.Windows.Forms.Label()
        Me.LbValAcrescPg = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.LbPorcDescPg = New System.Windows.Forms.Label()
        Me.LbValDescPg = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.LbDesFormaPagto = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxbValorPagto = New Controles.TxbMonetario()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelaNotaPrazo = New System.Windows.Forms.Button()
        Me.GbClienteNotaPrazo = New System.Windows.Forms.GroupBox()
        Me.TxbNomClienteNotaPrazo = New System.Windows.Forms.TextBox()
        Me.BtnBuscaClienteNotaPrazo = New System.Windows.Forms.Button()
        Me.TxbCodClienteNotaPrazo = New Controles.TxbCodigo()
        Me.BtnCadPessoNotaPrazo = New System.Windows.Forms.Button()
        Me.BtnConfirmaNotaPrazo = New System.Windows.Forms.Button()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.TxbDta1Vecto = New Controles.TxbData()
        Me.TxbQtdParcNotaPrazo = New Controles.TxbCodigo()
        Me.DtpDta1Vencto = New System.Windows.Forms.DateTimePicker()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelaCartao = New System.Windows.Forms.Button()
        Me.BtnConfirmaCartao = New System.Windows.Forms.Button()
        Me.TxbQtdParcCartao = New Controles.TxbCodigo()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxbCodBarra = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txbBuscaDesItem = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.BtnConfirmaDescAcresc = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxbPorcAcrescimo = New Controles.TxbMonetario()
        Me.TxbValAcrescimo = New Controles.TxbMonetario()
        Me.TxbPorcDesconto = New Controles.TxbMonetario()
        Me.TxbValDesconto = New Controles.TxbMonetario()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.BtnSangriaCancela = New System.Windows.Forms.Button()
        Me.BtnSangriaConfirma = New System.Windows.Forms.Button()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxbSangriaValor = New Controles.TxbMonetario()
        Me.TxbSangriaObs = New Controles.TxbDescricao()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.BtnFechaCxCancela = New System.Windows.Forms.Button()
        Me.BtnFechaCxConfirmar = New System.Windows.Forms.Button()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TxbFechaCxSaldoFinal = New Controles.TxbMonetario()
        Me.TxbFechaCxObs = New Controles.TxbDescricao()
        Me.PrintDocument4 = New System.Drawing.Printing.PrintDocument()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GbBotaoAtalho.SuspendLayout()
        Me.GbCabecalho.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvPessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        CType(Me.DgvPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.DgvFormaPagto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.GbClienteNotaPrazo.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnTelaPagamento
        '
        Me.BtnTelaPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnTelaPagamento.BackColor = System.Drawing.Color.Violet
        Me.BtnTelaPagamento.ForeColor = System.Drawing.Color.White
        Me.BtnTelaPagamento.Location = New System.Drawing.Point(261, 10)
        Me.BtnTelaPagamento.Name = "BtnTelaPagamento"
        Me.BtnTelaPagamento.Size = New System.Drawing.Size(85, 44)
        Me.BtnTelaPagamento.TabIndex = 34
        Me.BtnTelaPagamento.Text = "Pagamento - F5"
        Me.BtnTelaPagamento.UseVisualStyleBackColor = False
        '
        'btnTelaVenda
        '
        Me.btnTelaVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTelaVenda.BackColor = System.Drawing.Color.Violet
        Me.btnTelaVenda.ForeColor = System.Drawing.Color.White
        Me.btnTelaVenda.Location = New System.Drawing.Point(0, 10)
        Me.btnTelaVenda.Name = "btnTelaVenda"
        Me.btnTelaVenda.Size = New System.Drawing.Size(85, 44)
        Me.btnTelaVenda.TabIndex = 30
        Me.btnTelaVenda.Text = "Vendas - F1"
        Me.btnTelaVenda.UseVisualStyleBackColor = False
        '
        'BtnTelaPessoa
        '
        Me.BtnTelaPessoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnTelaPessoa.BackColor = System.Drawing.Color.Violet
        Me.BtnTelaPessoa.ForeColor = System.Drawing.Color.White
        Me.BtnTelaPessoa.Location = New System.Drawing.Point(348, 10)
        Me.BtnTelaPessoa.Name = "BtnTelaPessoa"
        Me.BtnTelaPessoa.Size = New System.Drawing.Size(85, 44)
        Me.BtnTelaPessoa.TabIndex = 33
        Me.BtnTelaPessoa.Text = "Pesquisa Cliente - F6"
        Me.BtnTelaPessoa.UseVisualStyleBackColor = False
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnExcluir.BackColor = System.Drawing.Color.Violet
        Me.BtnExcluir.ForeColor = System.Drawing.Color.White
        Me.BtnExcluir.Location = New System.Drawing.Point(435, 10)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(85, 44)
        Me.BtnExcluir.TabIndex = 29
        Me.BtnExcluir.Text = "Excluir - F8"
        Me.BtnExcluir.UseVisualStyleBackColor = False
        '
        'GbBotaoAtalho
        '
        Me.GbBotaoAtalho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbBotaoAtalho.BackColor = System.Drawing.Color.Transparent
        Me.GbBotaoAtalho.Controls.Add(Me.BtnFecharCaixa)
        Me.GbBotaoAtalho.Controls.Add(Me.BtnSangria)
        Me.GbBotaoAtalho.Controls.Add(Me.BtnCadPessoa)
        Me.GbBotaoAtalho.Controls.Add(Me.BtnCadItem)
        Me.GbBotaoAtalho.Controls.Add(Me.Button1)
        Me.GbBotaoAtalho.Controls.Add(Me.BtnDescAcresc)
        Me.GbBotaoAtalho.Controls.Add(Me.BtnTelaItem)
        Me.GbBotaoAtalho.Controls.Add(Me.BtnFinalizar)
        Me.GbBotaoAtalho.Controls.Add(Me.btnTelaVenda)
        Me.GbBotaoAtalho.Controls.Add(Me.BtnExcluir)
        Me.GbBotaoAtalho.Controls.Add(Me.BtnTelaPagamento)
        Me.GbBotaoAtalho.Controls.Add(Me.BtnTelaPessoa)
        Me.GbBotaoAtalho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GbBotaoAtalho.Location = New System.Drawing.Point(2, 556)
        Me.GbBotaoAtalho.Name = "GbBotaoAtalho"
        Me.GbBotaoAtalho.Size = New System.Drawing.Size(1107, 54)
        Me.GbBotaoAtalho.TabIndex = 36
        Me.GbBotaoAtalho.TabStop = False
        '
        'BtnFecharCaixa
        '
        Me.BtnFecharCaixa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnFecharCaixa.BackColor = System.Drawing.Color.Violet
        Me.BtnFecharCaixa.ForeColor = System.Drawing.Color.White
        Me.BtnFecharCaixa.Location = New System.Drawing.Point(971, 10)
        Me.BtnFecharCaixa.Name = "BtnFecharCaixa"
        Me.BtnFecharCaixa.Size = New System.Drawing.Size(85, 44)
        Me.BtnFecharCaixa.TabIndex = 42
        Me.BtnFecharCaixa.Text = "Fechar Caixa"
        Me.BtnFecharCaixa.UseVisualStyleBackColor = False
        '
        'BtnSangria
        '
        Me.BtnSangria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSangria.BackColor = System.Drawing.Color.Violet
        Me.BtnSangria.ForeColor = System.Drawing.Color.White
        Me.BtnSangria.Location = New System.Drawing.Point(880, 10)
        Me.BtnSangria.Name = "BtnSangria"
        Me.BtnSangria.Size = New System.Drawing.Size(85, 44)
        Me.BtnSangria.TabIndex = 41
        Me.BtnSangria.Text = "Sangria"
        Me.BtnSangria.UseVisualStyleBackColor = False
        '
        'BtnCadPessoa
        '
        Me.BtnCadPessoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCadPessoa.BackColor = System.Drawing.Color.Violet
        Me.BtnCadPessoa.ForeColor = System.Drawing.Color.White
        Me.BtnCadPessoa.Location = New System.Drawing.Point(789, 10)
        Me.BtnCadPessoa.Name = "BtnCadPessoa"
        Me.BtnCadPessoa.Size = New System.Drawing.Size(85, 44)
        Me.BtnCadPessoa.TabIndex = 40
        Me.BtnCadPessoa.Text = "Cadastro Pessoa"
        Me.BtnCadPessoa.UseVisualStyleBackColor = False
        '
        'BtnCadItem
        '
        Me.BtnCadItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCadItem.BackColor = System.Drawing.Color.Violet
        Me.BtnCadItem.ForeColor = System.Drawing.Color.White
        Me.BtnCadItem.Location = New System.Drawing.Point(702, 10)
        Me.BtnCadItem.Name = "BtnCadItem"
        Me.BtnCadItem.Size = New System.Drawing.Size(85, 44)
        Me.BtnCadItem.TabIndex = 39
        Me.BtnCadItem.Text = "Cadastro Item"
        Me.BtnCadItem.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Violet
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(611, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 44)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Cancelar - F3"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnDescAcresc
        '
        Me.BtnDescAcresc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDescAcresc.BackColor = System.Drawing.Color.Violet
        Me.BtnDescAcresc.ForeColor = System.Drawing.Color.White
        Me.BtnDescAcresc.Location = New System.Drawing.Point(87, 10)
        Me.BtnDescAcresc.Name = "BtnDescAcresc"
        Me.BtnDescAcresc.Size = New System.Drawing.Size(85, 44)
        Me.BtnDescAcresc.TabIndex = 37
        Me.BtnDescAcresc.Text = "Desconto/Acrescimo - F7"
        Me.BtnDescAcresc.UseVisualStyleBackColor = False
        '
        'BtnTelaItem
        '
        Me.BtnTelaItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnTelaItem.BackColor = System.Drawing.Color.Violet
        Me.BtnTelaItem.ForeColor = System.Drawing.Color.White
        Me.BtnTelaItem.Location = New System.Drawing.Point(174, 10)
        Me.BtnTelaItem.Name = "BtnTelaItem"
        Me.BtnTelaItem.Size = New System.Drawing.Size(85, 44)
        Me.BtnTelaItem.TabIndex = 36
        Me.BtnTelaItem.Text = "Pesquisa Itens - F2"
        Me.BtnTelaItem.UseVisualStyleBackColor = False
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnFinalizar.BackColor = System.Drawing.Color.Violet
        Me.BtnFinalizar.ForeColor = System.Drawing.Color.White
        Me.BtnFinalizar.Location = New System.Drawing.Point(522, 10)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(85, 44)
        Me.BtnFinalizar.TabIndex = 35
        Me.BtnFinalizar.Text = "Finalizar - F10"
        Me.BtnFinalizar.UseVisualStyleBackColor = False
        '
        'PrintDocument3
        '
        '
        'PrintDocument1
        '
        '
        'PrintDocRelResumoVenda
        '
        '
        'GbCabecalho
        '
        Me.GbCabecalho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbCabecalho.BackColor = System.Drawing.Color.Violet
        Me.GbCabecalho.Controls.Add(Me.LbSeqFechamento)
        Me.GbCabecalho.Controls.Add(Me.Label31)
        Me.GbCabecalho.Controls.Add(Me.LbTurno)
        Me.GbCabecalho.Controls.Add(Me.Label26)
        Me.GbCabecalho.Controls.Add(Me.Label17)
        Me.GbCabecalho.Controls.Add(Me.Label18)
        Me.GbCabecalho.Controls.Add(Me.LbCodCliente)
        Me.GbCabecalho.Controls.Add(Me.LbNomCliente)
        Me.GbCabecalho.Controls.Add(Me.LbCodPdv)
        Me.GbCabecalho.Controls.Add(Me.LbDesPdv)
        Me.GbCabecalho.Controls.Add(Me.LbNomOperador)
        Me.GbCabecalho.Location = New System.Drawing.Point(2, 0)
        Me.GbCabecalho.Margin = New System.Windows.Forms.Padding(0)
        Me.GbCabecalho.Name = "GbCabecalho"
        Me.GbCabecalho.Size = New System.Drawing.Size(1109, 36)
        Me.GbCabecalho.TabIndex = 37
        Me.GbCabecalho.TabStop = False
        '
        'LbSeqFechamento
        '
        Me.LbSeqFechamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbSeqFechamento.AutoSize = True
        Me.LbSeqFechamento.BackColor = System.Drawing.Color.Transparent
        Me.LbSeqFechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LbSeqFechamento.ForeColor = System.Drawing.Color.White
        Me.LbSeqFechamento.Location = New System.Drawing.Point(1053, 20)
        Me.LbSeqFechamento.Name = "LbSeqFechamento"
        Me.LbSeqFechamento.Size = New System.Drawing.Size(31, 13)
        Me.LbSeqFechamento.TabIndex = 22
        Me.LbSeqFechamento.Text = "0000"
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(956, 20)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(91, 13)
        Me.Label31.TabIndex = 21
        Me.Label31.Text = "Seq.Fechamento:"
        '
        'LbTurno
        '
        Me.LbTurno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbTurno.AutoSize = True
        Me.LbTurno.BackColor = System.Drawing.Color.Transparent
        Me.LbTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LbTurno.ForeColor = System.Drawing.Color.White
        Me.LbTurno.Location = New System.Drawing.Point(1053, 7)
        Me.LbTurno.Name = "LbTurno"
        Me.LbTurno.Size = New System.Drawing.Size(31, 13)
        Me.LbTurno.TabIndex = 20
        Me.LbTurno.Text = "0000"
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(1009, 7)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(38, 13)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "Turno:"
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(276, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 16)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Operador:"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(543, 10)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 20)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Cliente:"
        '
        'LbCodCliente
        '
        Me.LbCodCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbCodCliente.AutoSize = True
        Me.LbCodCliente.BackColor = System.Drawing.Color.Transparent
        Me.LbCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodCliente.ForeColor = System.Drawing.Color.White
        Me.LbCodCliente.Location = New System.Drawing.Point(610, 10)
        Me.LbCodCliente.Name = "LbCodCliente"
        Me.LbCodCliente.Size = New System.Drawing.Size(29, 20)
        Me.LbCodCliente.TabIndex = 14
        Me.LbCodCliente.Text = "Cli"
        '
        'LbNomCliente
        '
        Me.LbNomCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNomCliente.AutoSize = True
        Me.LbNomCliente.BackColor = System.Drawing.Color.Transparent
        Me.LbNomCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCliente.ForeColor = System.Drawing.Color.White
        Me.LbNomCliente.Location = New System.Drawing.Point(645, 10)
        Me.LbNomCliente.Name = "LbNomCliente"
        Me.LbNomCliente.Size = New System.Drawing.Size(63, 20)
        Me.LbNomCliente.TabIndex = 15
        Me.LbNomCliente.Text = "nomCli"
        '
        'LbCodPdv
        '
        Me.LbCodPdv.AutoSize = True
        Me.LbCodPdv.BackColor = System.Drawing.Color.Transparent
        Me.LbCodPdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodPdv.ForeColor = System.Drawing.Color.White
        Me.LbCodPdv.Location = New System.Drawing.Point(12, 12)
        Me.LbCodPdv.Name = "LbCodPdv"
        Me.LbCodPdv.Size = New System.Drawing.Size(35, 16)
        Me.LbCodPdv.TabIndex = 8
        Me.LbCodPdv.Text = "Pdv"
        '
        'LbDesPdv
        '
        Me.LbDesPdv.AutoSize = True
        Me.LbDesPdv.BackColor = System.Drawing.Color.Transparent
        Me.LbDesPdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesPdv.ForeColor = System.Drawing.Color.White
        Me.LbDesPdv.Location = New System.Drawing.Point(48, 12)
        Me.LbDesPdv.Name = "LbDesPdv"
        Me.LbDesPdv.Size = New System.Drawing.Size(67, 16)
        Me.LbDesPdv.TabIndex = 9
        Me.LbDesPdv.Text = "DesPDV"
        '
        'LbNomOperador
        '
        Me.LbNomOperador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNomOperador.AutoSize = True
        Me.LbNomOperador.BackColor = System.Drawing.Color.Transparent
        Me.LbNomOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomOperador.ForeColor = System.Drawing.Color.White
        Me.LbNomOperador.Location = New System.Drawing.Point(360, 12)
        Me.LbNomOperador.Name = "LbNomOperador"
        Me.LbNomOperador.Size = New System.Drawing.Size(119, 16)
        Me.LbNomOperador.TabIndex = 12
        Me.LbNomOperador.Text = "Nome Operador"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.DgvVenda)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1101, 517)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "VendaItem"
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.GroupBox11)
        Me.GroupBox8.Controls.Add(Me.LbPorcAcresc)
        Me.GroupBox8.Controls.Add(Me.LbValAcresc)
        Me.GroupBox8.Controls.Add(Me.Label23)
        Me.GroupBox8.Controls.Add(Me.Label24)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox8.Location = New System.Drawing.Point(401, 426)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(297, 63)
        Me.GroupBox8.TabIndex = 50
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Acrescimo"
        '
        'GroupBox11
        '
        Me.GroupBox11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox11.Controls.Add(Me.LbTotalAcrescItem)
        Me.GroupBox11.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox11.Location = New System.Drawing.Point(194, 10)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(97, 46)
        Me.GroupBox11.TabIndex = 51
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Total Acrescimo"
        '
        'LbTotalAcrescItem
        '
        Me.LbTotalAcrescItem.AutoSize = True
        Me.LbTotalAcrescItem.BackColor = System.Drawing.Color.Transparent
        Me.LbTotalAcrescItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalAcrescItem.ForeColor = System.Drawing.Color.Purple
        Me.LbTotalAcrescItem.Location = New System.Drawing.Point(45, 16)
        Me.LbTotalAcrescItem.Name = "LbTotalAcrescItem"
        Me.LbTotalAcrescItem.Size = New System.Drawing.Size(54, 25)
        Me.LbTotalAcrescItem.TabIndex = 47
        Me.LbTotalAcrescItem.Text = "0,00"
        Me.LbTotalAcrescItem.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbPorcAcresc
        '
        Me.LbPorcAcresc.AutoSize = True
        Me.LbPorcAcresc.BackColor = System.Drawing.Color.Transparent
        Me.LbPorcAcresc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPorcAcresc.ForeColor = System.Drawing.Color.Purple
        Me.LbPorcAcresc.Location = New System.Drawing.Point(140, 10)
        Me.LbPorcAcresc.Name = "LbPorcAcresc"
        Me.LbPorcAcresc.Size = New System.Drawing.Size(54, 25)
        Me.LbPorcAcresc.TabIndex = 47
        Me.LbPorcAcresc.Text = "0,00"
        Me.LbPorcAcresc.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbValAcresc
        '
        Me.LbValAcresc.AutoSize = True
        Me.LbValAcresc.BackColor = System.Drawing.Color.Transparent
        Me.LbValAcresc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValAcresc.ForeColor = System.Drawing.Color.Purple
        Me.LbValAcresc.Location = New System.Drawing.Point(140, 35)
        Me.LbValAcresc.Name = "LbValAcresc"
        Me.LbValAcresc.Size = New System.Drawing.Size(54, 25)
        Me.LbValAcresc.TabIndex = 48
        Me.LbValAcresc.Text = "0,00"
        Me.LbValAcresc.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Purple
        Me.Label23.Location = New System.Drawing.Point(6, 10)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 24)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Porcentagem:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Purple
        Me.Label24.Location = New System.Drawing.Point(6, 35)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 24)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Valor:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.GroupBox12)
        Me.GroupBox7.Controls.Add(Me.LbPorcDesc)
        Me.GroupBox7.Controls.Add(Me.LbValDesc)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox7.Location = New System.Drawing.Point(401, 361)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(297, 63)
        Me.GroupBox7.TabIndex = 49
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Desconto"
        '
        'GroupBox12
        '
        Me.GroupBox12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox12.Controls.Add(Me.LbTotalDescItem)
        Me.GroupBox12.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox12.Location = New System.Drawing.Point(194, 11)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(97, 46)
        Me.GroupBox12.TabIndex = 52
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Total Desconto"
        '
        'LbTotalDescItem
        '
        Me.LbTotalDescItem.AutoSize = True
        Me.LbTotalDescItem.BackColor = System.Drawing.Color.Transparent
        Me.LbTotalDescItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalDescItem.ForeColor = System.Drawing.Color.Purple
        Me.LbTotalDescItem.Location = New System.Drawing.Point(45, 16)
        Me.LbTotalDescItem.Name = "LbTotalDescItem"
        Me.LbTotalDescItem.Size = New System.Drawing.Size(54, 25)
        Me.LbTotalDescItem.TabIndex = 47
        Me.LbTotalDescItem.Text = "0,00"
        Me.LbTotalDescItem.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbPorcDesc
        '
        Me.LbPorcDesc.AutoSize = True
        Me.LbPorcDesc.BackColor = System.Drawing.Color.Transparent
        Me.LbPorcDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPorcDesc.ForeColor = System.Drawing.Color.Purple
        Me.LbPorcDesc.Location = New System.Drawing.Point(140, 10)
        Me.LbPorcDesc.Name = "LbPorcDesc"
        Me.LbPorcDesc.Size = New System.Drawing.Size(54, 25)
        Me.LbPorcDesc.TabIndex = 47
        Me.LbPorcDesc.Text = "0,00"
        Me.LbPorcDesc.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbValDesc
        '
        Me.LbValDesc.AutoSize = True
        Me.LbValDesc.BackColor = System.Drawing.Color.Transparent
        Me.LbValDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValDesc.ForeColor = System.Drawing.Color.Purple
        Me.LbValDesc.Location = New System.Drawing.Point(140, 35)
        Me.LbValDesc.Name = "LbValDesc"
        Me.LbValDesc.Size = New System.Drawing.Size(54, 25)
        Me.LbValDesc.TabIndex = 48
        Me.LbValDesc.Text = "0,00"
        Me.LbValDesc.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Purple
        Me.Label15.Location = New System.Drawing.Point(6, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 24)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Porcentagem:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Purple
        Me.Label16.Location = New System.Drawing.Point(6, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 24)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Valor:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxbCodItem)
        Me.GroupBox6.Controls.Add(Me.LbDescricaoItem)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Location = New System.Drawing.Point(61, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(637, 124)
        Me.GroupBox6.TabIndex = 45
        Me.GroupBox6.TabStop = False
        '
        'TxbCodItem
        '
        Me.TxbCodItem.BackColor = System.Drawing.Color.Pink
        Me.TxbCodItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxbCodItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbCodItem.ForeColor = System.Drawing.Color.Purple
        Me.TxbCodItem.Location = New System.Drawing.Point(7, 46)
        Me.TxbCodItem.Name = "TxbCodItem"
        Me.TxbCodItem.Size = New System.Drawing.Size(319, 73)
        Me.TxbCodItem.TabIndex = 1
        Me.TxbCodItem.Tag = "0"
        '
        'LbDescricaoItem
        '
        Me.LbDescricaoItem.AutoSize = True
        Me.LbDescricaoItem.BackColor = System.Drawing.Color.Transparent
        Me.LbDescricaoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDescricaoItem.ForeColor = System.Drawing.Color.Purple
        Me.LbDescricaoItem.Location = New System.Drawing.Point(120, 6)
        Me.LbDescricaoItem.Name = "LbDescricaoItem"
        Me.LbDescricaoItem.Size = New System.Drawing.Size(168, 37)
        Me.LbDescricaoItem.TabIndex = 5
        Me.LbDescricaoItem.Text = "Descrição"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Código"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.TxbTotalGeral)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(704, 361)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(389, 136)
        Me.GroupBox5.TabIndex = 44
        Me.GroupBox5.TabStop = False
        '
        'TxbTotalGeral
        '
        Me.TxbTotalGeral.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxbTotalGeral.BackColor = System.Drawing.Color.Pink
        Me.TxbTotalGeral.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxbTotalGeral.Enabled = False
        Me.TxbTotalGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbTotalGeral.ForeColor = System.Drawing.Color.Purple
        Me.TxbTotalGeral.Location = New System.Drawing.Point(6, 50)
        Me.TxbTotalGeral.Name = "TxbTotalGeral"
        Me.TxbTotalGeral.ReadOnly = True
        Me.TxbTotalGeral.Size = New System.Drawing.Size(377, 73)
        Me.TxbTotalGeral.TabIndex = 20
        Me.TxbTotalGeral.Tag = "1"
        Me.TxbTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Purple
        Me.Label5.Location = New System.Drawing.Point(6, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 33)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Total Geral"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(401, 125)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(297, 230)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TxbQtde)
        Me.GroupBox3.Controls.Add(Me.TxbValorTotal)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxbValorUnitario)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(61, 125)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 371)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        '
        'TxbQtde
        '
        Me.TxbQtde.BackColor = System.Drawing.Color.Pink
        Me.TxbQtde.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxbQtde.Enabled = False
        Me.TxbQtde.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbQtde.ForeColor = System.Drawing.Color.Purple
        Me.TxbQtde.Location = New System.Drawing.Point(7, 48)
        Me.TxbQtde.Name = "TxbQtde"
        Me.TxbQtde.ReadOnly = True
        Me.TxbQtde.Size = New System.Drawing.Size(319, 73)
        Me.TxbQtde.TabIndex = 2
        Me.TxbQtde.Tag = "1"
        Me.TxbQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbValorTotal
        '
        Me.TxbValorTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxbValorTotal.BackColor = System.Drawing.Color.Pink
        Me.TxbValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxbValorTotal.Enabled = False
        Me.TxbValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbValorTotal.ForeColor = System.Drawing.Color.Purple
        Me.TxbValorTotal.Location = New System.Drawing.Point(7, 286)
        Me.TxbValorTotal.Name = "TxbValorTotal"
        Me.TxbValorTotal.ReadOnly = True
        Me.TxbValorTotal.Size = New System.Drawing.Size(319, 73)
        Me.TxbValorTotal.TabIndex = 17
        Me.TxbValorTotal.Tag = "1"
        Me.TxbValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(7, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 33)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Valor Unitário"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Purple
        Me.Label4.Location = New System.Drawing.Point(7, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 33)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Total Item"
        '
        'TxbValorUnitario
        '
        Me.TxbValorUnitario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxbValorUnitario.BackColor = System.Drawing.Color.Pink
        Me.TxbValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxbValorUnitario.Enabled = False
        Me.TxbValorUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbValorUnitario.ForeColor = System.Drawing.Color.Purple
        Me.TxbValorUnitario.Location = New System.Drawing.Point(7, 167)
        Me.TxbValorUnitario.Name = "TxbValorUnitario"
        Me.TxbValorUnitario.ReadOnly = True
        Me.TxbValorUnitario.Size = New System.Drawing.Size(319, 73)
        Me.TxbValorUnitario.TabIndex = 15
        Me.TxbValorUnitario.Tag = "1"
        Me.TxbValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Purple
        Me.Label2.Location = New System.Drawing.Point(7, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 33)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Quantidade"
        '
        'DgvVenda
        '
        Me.DgvVenda.AllowUserToAddRows = False
        Me.DgvVenda.AllowUserToDeleteRows = False
        Me.DgvVenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvVenda.BackgroundColor = System.Drawing.Color.White
        Me.DgvVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvVenda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.DgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvVenda.DefaultCellStyle = DataGridViewCellStyle26
        Me.DgvVenda.Enabled = False
        Me.DgvVenda.GridColor = System.Drawing.Color.White
        Me.DgvVenda.Location = New System.Drawing.Point(704, 6)
        Me.DgvVenda.Name = "DgvVenda"
        Me.DgvVenda.ReadOnly = True
        Me.DgvVenda.Size = New System.Drawing.Size(393, 349)
        Me.DgvVenda.TabIndex = 19
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.DgvPessoa)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1101, 517)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "BuscaPessoa"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.TxbBuscaNomPessoa)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(889, 43)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(11, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 16)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Nome:"
        '
        'TxbBuscaNomPessoa
        '
        Me.TxbBuscaNomPessoa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbBuscaNomPessoa.Location = New System.Drawing.Point(70, 16)
        Me.TxbBuscaNomPessoa.Name = "TxbBuscaNomPessoa"
        Me.TxbBuscaNomPessoa.Size = New System.Drawing.Size(287, 22)
        Me.TxbBuscaNomPessoa.TabIndex = 0
        '
        'DgvPessoa
        '
        Me.DgvPessoa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPessoa.BackgroundColor = System.Drawing.Color.Purple
        Me.DgvPessoa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvPessoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPessoa.GridColor = System.Drawing.Color.White
        Me.DgvPessoa.Location = New System.Drawing.Point(6, 55)
        Me.DgvPessoa.Name = "DgvPessoa"
        Me.DgvPessoa.Size = New System.Drawing.Size(883, 425)
        Me.DgvPessoa.TabIndex = 20
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.GroupBox15)
        Me.TabPage3.Controls.Add(Me.GroupBox17)
        Me.TabPage3.Controls.Add(Me.GroupBox16)
        Me.TabPage3.Controls.Add(Me.GroupBox14)
        Me.TabPage3.Controls.Add(Me.GroupBox13)
        Me.TabPage3.Controls.Add(Me.LbDesFormaPagto)
        Me.TabPage3.Controls.Add(Me.TabControl2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1101, 517)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Pagamento"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.TxbSaldoRestante)
        Me.GroupBox15.Controls.Add(Me.TxbTotalGeralPg)
        Me.GroupBox15.Controls.Add(Me.Label6)
        Me.GroupBox15.Controls.Add(Me.Label9)
        Me.GroupBox15.Controls.Add(Me.Label10)
        Me.GroupBox15.Controls.Add(Me.TxbCodFormaPagto)
        Me.GroupBox15.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox15.Location = New System.Drawing.Point(410, 0)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(325, 366)
        Me.GroupBox15.TabIndex = 54
        Me.GroupBox15.TabStop = False
        '
        'TxbSaldoRestante
        '
        Me.TxbSaldoRestante.BackColor = System.Drawing.Color.Pink
        Me.TxbSaldoRestante.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!)
        Me.TxbSaldoRestante.ForeColor = System.Drawing.Color.Purple
        Me.TxbSaldoRestante.Location = New System.Drawing.Point(6, 165)
        Me.TxbSaldoRestante.Name = "TxbSaldoRestante"
        Me.TxbSaldoRestante.ReadOnly = True
        Me.TxbSaldoRestante.Size = New System.Drawing.Size(314, 80)
        Me.TxbSaldoRestante.TabIndex = 37
        Me.TxbSaldoRestante.Text = "0,00"
        Me.TxbSaldoRestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbTotalGeralPg
        '
        Me.TxbTotalGeralPg.BackColor = System.Drawing.Color.Pink
        Me.TxbTotalGeralPg.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!)
        Me.TxbTotalGeralPg.ForeColor = System.Drawing.Color.Purple
        Me.TxbTotalGeralPg.Location = New System.Drawing.Point(6, 47)
        Me.TxbTotalGeralPg.Name = "TxbTotalGeralPg"
        Me.TxbTotalGeralPg.ReadOnly = True
        Me.TxbTotalGeralPg.Size = New System.Drawing.Size(314, 80)
        Me.TxbTotalGeralPg.TabIndex = 38
        Me.TxbTotalGeralPg.Text = "0,00"
        Me.TxbTotalGeralPg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Purple
        Me.Label6.Location = New System.Drawing.Point(7, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(256, 33)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Forma Pagamento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Purple
        Me.Label9.Location = New System.Drawing.Point(6, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 33)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Total Venda"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Purple
        Me.Label10.Location = New System.Drawing.Point(6, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(213, 33)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Saldo Restante"
        '
        'TxbCodFormaPagto
        '
        Me.TxbCodFormaPagto.BackColor = System.Drawing.Color.Pink
        Me.TxbCodFormaPagto.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!)
        Me.TxbCodFormaPagto.ForeColor = System.Drawing.Color.Purple
        Me.TxbCodFormaPagto.Location = New System.Drawing.Point(6, 282)
        Me.TxbCodFormaPagto.Name = "TxbCodFormaPagto"
        Me.TxbCodFormaPagto.Size = New System.Drawing.Size(314, 80)
        Me.TxbCodFormaPagto.TabIndex = 39
        Me.TxbCodFormaPagto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.DgvPagamento)
        Me.GroupBox17.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox17.Location = New System.Drawing.Point(738, 0)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(360, 290)
        Me.GroupBox17.TabIndex = 56
        Me.GroupBox17.TabStop = False
        '
        'DgvPagamento
        '
        Me.DgvPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvPagamento.BackgroundColor = System.Drawing.Color.Pink
        Me.DgvPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvPagamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPagamento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.DgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvPagamento.DefaultCellStyle = DataGridViewCellStyle28
        Me.DgvPagamento.GridColor = System.Drawing.Color.White
        Me.DgvPagamento.Location = New System.Drawing.Point(6, 11)
        Me.DgvPagamento.Name = "DgvPagamento"
        Me.DgvPagamento.Size = New System.Drawing.Size(351, 273)
        Me.DgvPagamento.TabIndex = 27
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.txbTroco)
        Me.GroupBox16.Controls.Add(Me.Label7)
        Me.GroupBox16.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox16.Location = New System.Drawing.Point(738, 359)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(355, 130)
        Me.GroupBox16.TabIndex = 55
        Me.GroupBox16.TabStop = False
        '
        'txbTroco
        '
        Me.txbTroco.BackColor = System.Drawing.Color.Pink
        Me.txbTroco.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!)
        Me.txbTroco.ForeColor = System.Drawing.Color.Purple
        Me.txbTroco.Location = New System.Drawing.Point(6, 44)
        Me.txbTroco.Name = "txbTroco"
        Me.txbTroco.ReadOnly = True
        Me.txbTroco.Size = New System.Drawing.Size(314, 80)
        Me.txbTroco.TabIndex = 34
        Me.txbTroco.Text = "0,00"
        Me.txbTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Purple
        Me.Label7.Location = New System.Drawing.Point(6, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 33)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Troco"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.DgvFormaPagto)
        Me.GroupBox14.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox14.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(400, 290)
        Me.GroupBox14.TabIndex = 53
        Me.GroupBox14.TabStop = False
        '
        'DgvFormaPagto
        '
        Me.DgvFormaPagto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvFormaPagto.BackgroundColor = System.Drawing.Color.Pink
        Me.DgvFormaPagto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvFormaPagto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvFormaPagto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.DgvFormaPagto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvFormaPagto.DefaultCellStyle = DataGridViewCellStyle30
        Me.DgvFormaPagto.GridColor = System.Drawing.Color.White
        Me.DgvFormaPagto.Location = New System.Drawing.Point(4, 10)
        Me.DgvFormaPagto.Name = "DgvFormaPagto"
        Me.DgvFormaPagto.ReadOnly = True
        Me.DgvFormaPagto.Size = New System.Drawing.Size(391, 274)
        Me.DgvFormaPagto.TabIndex = 26
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.GroupBox9)
        Me.GroupBox13.Controls.Add(Me.GroupBox10)
        Me.GroupBox13.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox13.Location = New System.Drawing.Point(5, 348)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(400, 141)
        Me.GroupBox13.TabIndex = 52
        Me.GroupBox13.TabStop = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.LbPorcAcrescPg)
        Me.GroupBox9.Controls.Add(Me.LbValAcrescPg)
        Me.GroupBox9.Controls.Add(Me.Label21)
        Me.GroupBox9.Controls.Add(Me.Label22)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox9.Location = New System.Drawing.Point(5, 71)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(389, 63)
        Me.GroupBox9.TabIndex = 52
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Acrescimo"
        '
        'LbPorcAcrescPg
        '
        Me.LbPorcAcrescPg.AutoSize = True
        Me.LbPorcAcrescPg.BackColor = System.Drawing.Color.Transparent
        Me.LbPorcAcrescPg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPorcAcrescPg.ForeColor = System.Drawing.Color.Purple
        Me.LbPorcAcrescPg.Location = New System.Drawing.Point(205, 10)
        Me.LbPorcAcrescPg.Name = "LbPorcAcrescPg"
        Me.LbPorcAcrescPg.Size = New System.Drawing.Size(54, 25)
        Me.LbPorcAcrescPg.TabIndex = 47
        Me.LbPorcAcrescPg.Text = "0,00"
        Me.LbPorcAcrescPg.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbValAcrescPg
        '
        Me.LbValAcrescPg.AutoSize = True
        Me.LbValAcrescPg.BackColor = System.Drawing.Color.Transparent
        Me.LbValAcrescPg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValAcrescPg.ForeColor = System.Drawing.Color.Purple
        Me.LbValAcrescPg.Location = New System.Drawing.Point(205, 35)
        Me.LbValAcrescPg.Name = "LbValAcrescPg"
        Me.LbValAcrescPg.Size = New System.Drawing.Size(54, 25)
        Me.LbValAcrescPg.TabIndex = 48
        Me.LbValAcrescPg.Text = "0,00"
        Me.LbValAcrescPg.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Purple
        Me.Label21.Location = New System.Drawing.Point(6, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(145, 25)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Porcentagem:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Purple
        Me.Label22.Location = New System.Drawing.Point(6, 35)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 25)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "Valor:"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.LbPorcDescPg)
        Me.GroupBox10.Controls.Add(Me.LbValDescPg)
        Me.GroupBox10.Controls.Add(Me.Label27)
        Me.GroupBox10.Controls.Add(Me.Label28)
        Me.GroupBox10.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox10.Location = New System.Drawing.Point(5, 8)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(389, 63)
        Me.GroupBox10.TabIndex = 51
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Desconto"
        '
        'LbPorcDescPg
        '
        Me.LbPorcDescPg.AutoSize = True
        Me.LbPorcDescPg.BackColor = System.Drawing.Color.Transparent
        Me.LbPorcDescPg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPorcDescPg.ForeColor = System.Drawing.Color.Purple
        Me.LbPorcDescPg.Location = New System.Drawing.Point(205, 10)
        Me.LbPorcDescPg.Name = "LbPorcDescPg"
        Me.LbPorcDescPg.Size = New System.Drawing.Size(54, 25)
        Me.LbPorcDescPg.TabIndex = 47
        Me.LbPorcDescPg.Text = "0,00"
        Me.LbPorcDescPg.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbValDescPg
        '
        Me.LbValDescPg.AutoSize = True
        Me.LbValDescPg.BackColor = System.Drawing.Color.Transparent
        Me.LbValDescPg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbValDescPg.ForeColor = System.Drawing.Color.Purple
        Me.LbValDescPg.Location = New System.Drawing.Point(205, 35)
        Me.LbValDescPg.Name = "LbValDescPg"
        Me.LbValDescPg.Size = New System.Drawing.Size(54, 25)
        Me.LbValDescPg.TabIndex = 48
        Me.LbValDescPg.Text = "0,00"
        Me.LbValDescPg.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Purple
        Me.Label27.Location = New System.Drawing.Point(6, 10)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(145, 25)
        Me.Label27.TabIndex = 22
        Me.Label27.Text = "Porcentagem:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Purple
        Me.Label28.Location = New System.Drawing.Point(6, 35)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(68, 25)
        Me.Label28.TabIndex = 46
        Me.Label28.Text = "Valor:"
        '
        'LbDesFormaPagto
        '
        Me.LbDesFormaPagto.AutoSize = True
        Me.LbDesFormaPagto.BackColor = System.Drawing.Color.Transparent
        Me.LbDesFormaPagto.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesFormaPagto.ForeColor = System.Drawing.Color.Purple
        Me.LbDesFormaPagto.Location = New System.Drawing.Point(747, 293)
        Me.LbDesFormaPagto.Name = "LbDesFormaPagto"
        Me.LbDesFormaPagto.Size = New System.Drawing.Size(0, 33)
        Me.LbDesFormaPagto.TabIndex = 29
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Controls.Add(Me.TabPage10)
        Me.TabControl2.Location = New System.Drawing.Point(410, 321)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(327, 168)
        Me.TabControl2.TabIndex = 57
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.Label8)
        Me.TabPage8.Controls.Add(Me.TxbValorPagto)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(319, 142)
        Me.TabPage8.TabIndex = 0
        Me.TabPage8.Text = "TabTotalPagto"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Purple
        Me.Label8.Location = New System.Drawing.Point(8, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(239, 33)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Valor Pagamento"
        '
        'TxbValorPagto
        '
        Me.TxbValorPagto.BackColor = System.Drawing.Color.Pink
        Me.TxbValorPagto.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!)
        Me.TxbValorPagto.ForeColor = System.Drawing.Color.Purple
        Me.TxbValorPagto.Location = New System.Drawing.Point(3, 58)
        Me.TxbValorPagto.Name = "TxbValorPagto"
        Me.TxbValorPagto.Size = New System.Drawing.Size(311, 80)
        Me.TxbValorPagto.TabIndex = 36
        Me.TxbValorPagto.Text = "0,00"
        Me.TxbValorPagto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.GroupBox23)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(319, 142)
        Me.TabPage9.TabIndex = 1
        Me.TabPage9.Text = "TabNotaPrazo"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.BtnCancelaNotaPrazo)
        Me.GroupBox23.Controls.Add(Me.GbClienteNotaPrazo)
        Me.GroupBox23.Controls.Add(Me.BtnConfirmaNotaPrazo)
        Me.GroupBox23.Controls.Add(Me.GroupBox22)
        Me.GroupBox23.Location = New System.Drawing.Point(3, 25)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(313, 116)
        Me.GroupBox23.TabIndex = 65
        Me.GroupBox23.TabStop = False
        '
        'BtnCancelaNotaPrazo
        '
        Me.BtnCancelaNotaPrazo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCancelaNotaPrazo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelaNotaPrazo.Location = New System.Drawing.Point(159, 87)
        Me.BtnCancelaNotaPrazo.Name = "BtnCancelaNotaPrazo"
        Me.BtnCancelaNotaPrazo.Size = New System.Drawing.Size(145, 23)
        Me.BtnCancelaNotaPrazo.TabIndex = 8
        Me.BtnCancelaNotaPrazo.Text = "Cancelar"
        Me.BtnCancelaNotaPrazo.UseVisualStyleBackColor = False
        '
        'GbClienteNotaPrazo
        '
        Me.GbClienteNotaPrazo.Controls.Add(Me.TxbNomClienteNotaPrazo)
        Me.GbClienteNotaPrazo.Controls.Add(Me.BtnBuscaClienteNotaPrazo)
        Me.GbClienteNotaPrazo.Controls.Add(Me.TxbCodClienteNotaPrazo)
        Me.GbClienteNotaPrazo.Controls.Add(Me.BtnCadPessoNotaPrazo)
        Me.GbClienteNotaPrazo.Location = New System.Drawing.Point(4, 4)
        Me.GbClienteNotaPrazo.Name = "GbClienteNotaPrazo"
        Me.GbClienteNotaPrazo.Size = New System.Drawing.Size(303, 37)
        Me.GbClienteNotaPrazo.TabIndex = 64
        Me.GbClienteNotaPrazo.TabStop = False
        Me.GbClienteNotaPrazo.Text = "Cliente"
        '
        'TxbNomClienteNotaPrazo
        '
        Me.TxbNomClienteNotaPrazo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomClienteNotaPrazo.Location = New System.Drawing.Point(50, 12)
        Me.TxbNomClienteNotaPrazo.Name = "TxbNomClienteNotaPrazo"
        Me.TxbNomClienteNotaPrazo.Size = New System.Drawing.Size(201, 20)
        Me.TxbNomClienteNotaPrazo.TabIndex = 2
        '
        'BtnBuscaClienteNotaPrazo
        '
        Me.BtnBuscaClienteNotaPrazo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaClienteNotaPrazo.ForeColor = System.Drawing.Color.DimGray
        Me.BtnBuscaClienteNotaPrazo.Image = CType(resources.GetObject("BtnBuscaClienteNotaPrazo.Image"), System.Drawing.Image)
        Me.BtnBuscaClienteNotaPrazo.Location = New System.Drawing.Point(252, 12)
        Me.BtnBuscaClienteNotaPrazo.Name = "BtnBuscaClienteNotaPrazo"
        Me.BtnBuscaClienteNotaPrazo.Size = New System.Drawing.Size(23, 20)
        Me.BtnBuscaClienteNotaPrazo.TabIndex = 3
        Me.BtnBuscaClienteNotaPrazo.UseVisualStyleBackColor = True
        '
        'TxbCodClienteNotaPrazo
        '
        Me.TxbCodClienteNotaPrazo.Location = New System.Drawing.Point(4, 12)
        Me.TxbCodClienteNotaPrazo.Name = "TxbCodClienteNotaPrazo"
        Me.TxbCodClienteNotaPrazo.Size = New System.Drawing.Size(45, 20)
        Me.TxbCodClienteNotaPrazo.TabIndex = 1
        '
        'BtnCadPessoNotaPrazo
        '
        Me.BtnCadPessoNotaPrazo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadPessoNotaPrazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadPessoNotaPrazo.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCadPessoNotaPrazo.Location = New System.Drawing.Point(276, 12)
        Me.BtnCadPessoNotaPrazo.Name = "BtnCadPessoNotaPrazo"
        Me.BtnCadPessoNotaPrazo.Size = New System.Drawing.Size(23, 20)
        Me.BtnCadPessoNotaPrazo.TabIndex = 4
        Me.BtnCadPessoNotaPrazo.Tag = ""
        Me.BtnCadPessoNotaPrazo.Text = "C"
        Me.BtnCadPessoNotaPrazo.UseVisualStyleBackColor = True
        '
        'BtnConfirmaNotaPrazo
        '
        Me.BtnConfirmaNotaPrazo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnConfirmaNotaPrazo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmaNotaPrazo.Location = New System.Drawing.Point(6, 87)
        Me.BtnConfirmaNotaPrazo.Name = "BtnConfirmaNotaPrazo"
        Me.BtnConfirmaNotaPrazo.Size = New System.Drawing.Size(145, 23)
        Me.BtnConfirmaNotaPrazo.TabIndex = 7
        Me.BtnConfirmaNotaPrazo.Text = "Confirmar"
        Me.BtnConfirmaNotaPrazo.UseVisualStyleBackColor = False
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.TxbDta1Vecto)
        Me.GroupBox22.Controls.Add(Me.TxbQtdParcNotaPrazo)
        Me.GroupBox22.Controls.Add(Me.DtpDta1Vencto)
        Me.GroupBox22.Controls.Add(Me.Label35)
        Me.GroupBox22.Controls.Add(Me.Label34)
        Me.GroupBox22.Location = New System.Drawing.Point(5, 43)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(303, 38)
        Me.GroupBox22.TabIndex = 63
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "Parcela"
        '
        'TxbDta1Vecto
        '
        Me.TxbDta1Vecto.Location = New System.Drawing.Point(216, 12)
        Me.TxbDta1Vecto.MaxLength = 10
        Me.TxbDta1Vecto.Name = "TxbDta1Vecto"
        Me.TxbDta1Vecto.Size = New System.Drawing.Size(66, 20)
        Me.TxbDta1Vecto.TabIndex = 6
        '
        'TxbQtdParcNotaPrazo
        '
        Me.TxbQtdParcNotaPrazo.Location = New System.Drawing.Point(67, 12)
        Me.TxbQtdParcNotaPrazo.Name = "TxbQtdParcNotaPrazo"
        Me.TxbQtdParcNotaPrazo.Size = New System.Drawing.Size(66, 20)
        Me.TxbQtdParcNotaPrazo.TabIndex = 5
        Me.TxbQtdParcNotaPrazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DtpDta1Vencto
        '
        Me.DtpDta1Vencto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDta1Vencto.Location = New System.Drawing.Point(284, 12)
        Me.DtpDta1Vencto.Name = "DtpDta1Vencto"
        Me.DtpDta1Vencto.Size = New System.Drawing.Size(14, 20)
        Me.DtpDta1Vencto.TabIndex = 10
        Me.DtpDta1Vencto.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(139, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(79, 13)
        Me.Label35.TabIndex = 67
        Me.Label35.Text = "1º Vencimento:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(3, 16)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(65, 13)
        Me.Label34.TabIndex = 64
        Me.Label34.Text = "Quantidade:"
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.GroupBox24)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(319, 142)
        Me.TabPage10.TabIndex = 2
        Me.TabPage10.Text = "TabCartaoCredito"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.BtnCancelaCartao)
        Me.GroupBox24.Controls.Add(Me.BtnConfirmaCartao)
        Me.GroupBox24.Controls.Add(Me.TxbQtdParcCartao)
        Me.GroupBox24.Controls.Add(Me.Label37)
        Me.GroupBox24.Location = New System.Drawing.Point(8, 66)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(305, 70)
        Me.GroupBox24.TabIndex = 64
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "Parcela"
        '
        'BtnCancelaCartao
        '
        Me.BtnCancelaCartao.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCancelaCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelaCartao.Location = New System.Drawing.Point(156, 36)
        Me.BtnCancelaCartao.Name = "BtnCancelaCartao"
        Me.BtnCancelaCartao.Size = New System.Drawing.Size(145, 23)
        Me.BtnCancelaCartao.TabIndex = 3
        Me.BtnCancelaCartao.Text = "Cancelar"
        Me.BtnCancelaCartao.UseVisualStyleBackColor = False
        '
        'BtnConfirmaCartao
        '
        Me.BtnConfirmaCartao.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnConfirmaCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmaCartao.Location = New System.Drawing.Point(4, 36)
        Me.BtnConfirmaCartao.Name = "BtnConfirmaCartao"
        Me.BtnConfirmaCartao.Size = New System.Drawing.Size(145, 23)
        Me.BtnConfirmaCartao.TabIndex = 2
        Me.BtnConfirmaCartao.Text = "Confirmar"
        Me.BtnConfirmaCartao.UseVisualStyleBackColor = False
        '
        'TxbQtdParcCartao
        '
        Me.TxbQtdParcCartao.Location = New System.Drawing.Point(67, 12)
        Me.TxbQtdParcCartao.Name = "TxbQtdParcCartao"
        Me.TxbQtdParcCartao.Size = New System.Drawing.Size(82, 20)
        Me.TxbQtdParcCartao.TabIndex = 1
        Me.TxbQtdParcCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(3, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(65, 13)
        Me.Label37.TabIndex = 64
        Me.Label37.Text = "Quantidade:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.DgvItem)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1101, 517)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BuscaItem"
        '
        'DgvItem
        '
        Me.DgvItem.AllowUserToAddRows = False
        Me.DgvItem.AllowUserToDeleteRows = False
        Me.DgvItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvItem.BackgroundColor = System.Drawing.Color.Purple
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.DgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvItem.DefaultCellStyle = DataGridViewCellStyle32
        Me.DgvItem.Location = New System.Drawing.Point(9, 55)
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.ReadOnly = True
        Me.DgvItem.Size = New System.Drawing.Size(880, 447)
        Me.DgvItem.StandardTab = True
        Me.DgvItem.TabIndex = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TxbCodBarra)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txbBuscaDesItem)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(889, 43)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'TxbCodBarra
        '
        Me.TxbCodBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbCodBarra.Location = New System.Drawing.Point(495, 16)
        Me.TxbCodBarra.Name = "TxbCodBarra"
        Me.TxbCodBarra.Size = New System.Drawing.Size(160, 20)
        Me.TxbCodBarra.TabIndex = 20
        '
        'Label25
        '
        Me.Label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(6, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(83, 16)
        Me.Label25.TabIndex = 22
        Me.Label25.Text = "Descrição:"
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(417, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 16)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Cód.Barra:"
        '
        'txbBuscaDesItem
        '
        Me.txbBuscaDesItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbBuscaDesItem.Location = New System.Drawing.Point(88, 16)
        Me.txbBuscaDesItem.Name = "txbBuscaDesItem"
        Me.txbBuscaDesItem.Size = New System.Drawing.Size(300, 20)
        Me.txbBuscaDesItem.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Location = New System.Drawing.Point(2, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1109, 543)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.BtnConfirmaDescAcresc)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Controls.Add(Me.Label14)
        Me.TabPage5.Controls.Add(Me.Label11)
        Me.TabPage5.Controls.Add(Me.Label12)
        Me.TabPage5.Controls.Add(Me.TxbPorcAcrescimo)
        Me.TabPage5.Controls.Add(Me.TxbValAcrescimo)
        Me.TabPage5.Controls.Add(Me.TxbPorcDesconto)
        Me.TabPage5.Controls.Add(Me.TxbValDesconto)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1101, 517)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "DescontoAcresc"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'BtnConfirmaDescAcresc
        '
        Me.BtnConfirmaDescAcresc.BackColor = System.Drawing.Color.Violet
        Me.BtnConfirmaDescAcresc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmaDescAcresc.ForeColor = System.Drawing.Color.White
        Me.BtnConfirmaDescAcresc.Location = New System.Drawing.Point(159, 396)
        Me.BtnConfirmaDescAcresc.Name = "BtnConfirmaDescAcresc"
        Me.BtnConfirmaDescAcresc.Size = New System.Drawing.Size(711, 81)
        Me.BtnConfirmaDescAcresc.TabIndex = 4
        Me.BtnConfirmaDescAcresc.Text = "Confirmar"
        Me.BtnConfirmaDescAcresc.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Purple
        Me.Label13.Location = New System.Drawing.Point(6, 316)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(229, 33)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Valor Acrescimo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Purple
        Me.Label14.Location = New System.Drawing.Point(6, 230)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(334, 33)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Acrescimo Porcentagem"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Purple
        Me.Label11.Location = New System.Drawing.Point(6, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(214, 33)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Valor Desconto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Purple
        Me.Label12.Location = New System.Drawing.Point(6, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(319, 33)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Desconto Porcentagem"
        '
        'TxbPorcAcrescimo
        '
        Me.TxbPorcAcrescimo.BackColor = System.Drawing.Color.Pink
        Me.TxbPorcAcrescimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!)
        Me.TxbPorcAcrescimo.ForeColor = System.Drawing.Color.Purple
        Me.TxbPorcAcrescimo.Location = New System.Drawing.Point(353, 206)
        Me.TxbPorcAcrescimo.Name = "TxbPorcAcrescimo"
        Me.TxbPorcAcrescimo.Size = New System.Drawing.Size(314, 80)
        Me.TxbPorcAcrescimo.TabIndex = 2
        Me.TxbPorcAcrescimo.Text = "0,00"
        Me.TxbPorcAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbValAcrescimo
        '
        Me.TxbValAcrescimo.BackColor = System.Drawing.Color.Pink
        Me.TxbValAcrescimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!)
        Me.TxbValAcrescimo.ForeColor = System.Drawing.Color.Purple
        Me.TxbValAcrescimo.Location = New System.Drawing.Point(353, 292)
        Me.TxbValAcrescimo.Name = "TxbValAcrescimo"
        Me.TxbValAcrescimo.Size = New System.Drawing.Size(314, 80)
        Me.TxbValAcrescimo.TabIndex = 3
        Me.TxbValAcrescimo.Text = "0,00"
        Me.TxbValAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbPorcDesconto
        '
        Me.TxbPorcDesconto.BackColor = System.Drawing.Color.Pink
        Me.TxbPorcDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!)
        Me.TxbPorcDesconto.ForeColor = System.Drawing.Color.Purple
        Me.TxbPorcDesconto.Location = New System.Drawing.Point(353, 34)
        Me.TxbPorcDesconto.Name = "TxbPorcDesconto"
        Me.TxbPorcDesconto.Size = New System.Drawing.Size(314, 80)
        Me.TxbPorcDesconto.TabIndex = 0
        Me.TxbPorcDesconto.Text = "0,00"
        Me.TxbPorcDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbValDesconto
        '
        Me.TxbValDesconto.BackColor = System.Drawing.Color.Pink
        Me.TxbValDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!)
        Me.TxbValDesconto.ForeColor = System.Drawing.Color.Purple
        Me.TxbValDesconto.Location = New System.Drawing.Point(353, 120)
        Me.TxbValDesconto.Name = "TxbValDesconto"
        Me.TxbValDesconto.Size = New System.Drawing.Size(314, 80)
        Me.TxbValDesconto.TabIndex = 1
        Me.TxbValDesconto.Text = "0,00"
        Me.TxbValDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox18)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1101, 517)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Sangria"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.BtnSangriaCancela)
        Me.GroupBox18.Controls.Add(Me.BtnSangriaConfirma)
        Me.GroupBox18.Controls.Add(Me.GroupBox19)
        Me.GroupBox18.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(496, 141)
        Me.GroupBox18.TabIndex = 0
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Sangria"
        '
        'BtnSangriaCancela
        '
        Me.BtnSangriaCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSangriaCancela.Location = New System.Drawing.Point(286, 110)
        Me.BtnSangriaCancela.Name = "BtnSangriaCancela"
        Me.BtnSangriaCancela.Size = New System.Drawing.Size(192, 23)
        Me.BtnSangriaCancela.TabIndex = 3
        Me.BtnSangriaCancela.Text = "Cancelar Sangria"
        Me.BtnSangriaCancela.UseVisualStyleBackColor = True
        '
        'BtnSangriaConfirma
        '
        Me.BtnSangriaConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSangriaConfirma.Location = New System.Drawing.Point(87, 110)
        Me.BtnSangriaConfirma.Name = "BtnSangriaConfirma"
        Me.BtnSangriaConfirma.Size = New System.Drawing.Size(192, 23)
        Me.BtnSangriaConfirma.TabIndex = 2
        Me.BtnSangriaConfirma.Text = "Confirmar Sangria"
        Me.BtnSangriaConfirma.UseVisualStyleBackColor = True
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.Label30)
        Me.GroupBox19.Controls.Add(Me.Label29)
        Me.GroupBox19.Controls.Add(Me.TxbSangriaValor)
        Me.GroupBox19.Controls.Add(Me.TxbSangriaObs)
        Me.GroupBox19.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(484, 85)
        Me.GroupBox19.TabIndex = 1
        Me.GroupBox19.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(7, 49)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(68, 13)
        Me.Label30.TabIndex = 3
        Me.Label30.Text = "Observação:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(7, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 13)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Valor:"
        '
        'TxbSangriaValor
        '
        Me.TxbSangriaValor.Location = New System.Drawing.Point(81, 12)
        Me.TxbSangriaValor.Name = "TxbSangriaValor"
        Me.TxbSangriaValor.Size = New System.Drawing.Size(100, 20)
        Me.TxbSangriaValor.TabIndex = 1
        Me.TxbSangriaValor.Text = "0,00"
        Me.TxbSangriaValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbSangriaObs
        '
        Me.TxbSangriaObs.Location = New System.Drawing.Point(81, 35)
        Me.TxbSangriaObs.Multiline = True
        Me.TxbSangriaObs.Name = "TxbSangriaObs"
        Me.TxbSangriaObs.Size = New System.Drawing.Size(397, 45)
        Me.TxbSangriaObs.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.GroupBox20)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1101, 517)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Fechar Cx"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.BtnFechaCxCancela)
        Me.GroupBox20.Controls.Add(Me.BtnFechaCxConfirmar)
        Me.GroupBox20.Controls.Add(Me.GroupBox21)
        Me.GroupBox20.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(496, 141)
        Me.GroupBox20.TabIndex = 1
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Fechar o Caixa"
        '
        'BtnFechaCxCancela
        '
        Me.BtnFechaCxCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFechaCxCancela.Location = New System.Drawing.Point(292, 110)
        Me.BtnFechaCxCancela.Name = "BtnFechaCxCancela"
        Me.BtnFechaCxCancela.Size = New System.Drawing.Size(192, 23)
        Me.BtnFechaCxCancela.TabIndex = 4
        Me.BtnFechaCxCancela.Text = "Cancelar "
        Me.BtnFechaCxCancela.UseVisualStyleBackColor = True
        '
        'BtnFechaCxConfirmar
        '
        Me.BtnFechaCxConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFechaCxConfirmar.Location = New System.Drawing.Point(87, 110)
        Me.BtnFechaCxConfirmar.Name = "BtnFechaCxConfirmar"
        Me.BtnFechaCxConfirmar.Size = New System.Drawing.Size(192, 23)
        Me.BtnFechaCxConfirmar.TabIndex = 2
        Me.BtnFechaCxConfirmar.Text = "Confirmar Fechamento Caixa"
        Me.BtnFechaCxConfirmar.UseVisualStyleBackColor = True
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.Label32)
        Me.GroupBox21.Controls.Add(Me.Label33)
        Me.GroupBox21.Controls.Add(Me.TxbFechaCxSaldoFinal)
        Me.GroupBox21.Controls.Add(Me.TxbFechaCxObs)
        Me.GroupBox21.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(484, 85)
        Me.GroupBox21.TabIndex = 1
        Me.GroupBox21.TabStop = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(7, 49)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(68, 13)
        Me.Label32.TabIndex = 3
        Me.Label32.Text = "Observação:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(7, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(63, 13)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "Troco Final:"
        '
        'TxbFechaCxSaldoFinal
        '
        Me.TxbFechaCxSaldoFinal.Location = New System.Drawing.Point(81, 12)
        Me.TxbFechaCxSaldoFinal.Name = "TxbFechaCxSaldoFinal"
        Me.TxbFechaCxSaldoFinal.Size = New System.Drawing.Size(100, 20)
        Me.TxbFechaCxSaldoFinal.TabIndex = 1
        Me.TxbFechaCxSaldoFinal.Text = "0,00"
        Me.TxbFechaCxSaldoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbFechaCxObs
        '
        Me.TxbFechaCxObs.Location = New System.Drawing.Point(81, 35)
        Me.TxbFechaCxObs.Multiline = True
        Me.TxbFechaCxObs.Name = "TxbFechaCxObs"
        Me.TxbFechaCxObs.Size = New System.Drawing.Size(397, 45)
        Me.TxbFechaCxObs.TabIndex = 0
        '
        'FrmPDV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1111, 611)
        Me.Controls.Add(Me.GbCabecalho)
        Me.Controls.Add(Me.GbBotaoAtalho)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPDV2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPDV2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbBotaoAtalho.ResumeLayout(False)
        Me.GbCabecalho.ResumeLayout(False)
        Me.GbCabecalho.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DgvVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvPessoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        CType(Me.DgvPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        CType(Me.DgvFormaPagto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.GroupBox23.ResumeLayout(False)
        Me.GbClienteNotaPrazo.ResumeLayout(False)
        Me.GbClienteNotaPrazo.PerformLayout()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.GroupBox24.ResumeLayout(False)
        Me.GroupBox24.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnTelaPagamento As Button
    Friend WithEvents btnTelaVenda As Button
    Friend WithEvents BtnTelaPessoa As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents GbBotaoAtalho As GroupBox
    Friend WithEvents PrintDocumentDespesa As Printing.PrintDocument
    Friend WithEvents PrintDocument3 As Printing.PrintDocument
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDocRelResumoVenda As Printing.PrintDocument
    Friend WithEvents GbCabecalho As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents LbCodCliente As Label
    Friend WithEvents LbNomCliente As Label
    Friend WithEvents LbCodPdv As Label
    Friend WithEvents LbDesPdv As Label
    Friend WithEvents LbNomOperador As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents BtnFinalizar As Button
    Friend WithEvents BtnTelaItem As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TxbCodItem As TextBox
    Friend WithEvents LbDescricaoItem As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TxbTotalGeral As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxbQtde As TextBox
    Friend WithEvents TxbValorTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbValorUnitario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvVenda As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxbBuscaNomPessoa As TextBox
    Friend WithEvents DgvPessoa As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TxbCodFormaPagto As Controles.TxbCodigo
    Friend WithEvents TxbTotalGeralPg As Controles.TxbMonetario
    Friend WithEvents TxbSaldoRestante As Controles.TxbMonetario
    Friend WithEvents TxbValorPagto As Controles.TxbMonetario
    Friend WithEvents txbTroco As Controles.TxbMonetario
    Friend WithEvents DgvFormaPagto As DataGridView
    Friend WithEvents DgvPagamento As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LbDesFormaPagto As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DgvItem As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txbBuscaDesItem As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PrintDocument4 As Printing.PrintDocument
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TxbPorcAcrescimo As Controles.TxbMonetario
    Friend WithEvents TxbValAcrescimo As Controles.TxbMonetario
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxbPorcDesconto As Controles.TxbMonetario
    Friend WithEvents TxbValDesconto As Controles.TxbMonetario
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnDescAcresc As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents LbPorcDesc As Label
    Friend WithEvents LbValDesc As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents LbPorcAcresc As Label
    Friend WithEvents LbValAcresc As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents BtnConfirmaDescAcresc As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents LbPorcAcrescPg As Label
    Friend WithEvents LbValAcrescPg As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents LbPorcDescPg As Label
    Friend WithEvents LbValDescPg As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents LbTotalAcrescItem As Label
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents LbTotalDescItem As Label
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxbCodBarra As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnSangria As Button
    Friend WithEvents BtnCadPessoa As Button
    Friend WithEvents BtnCadItem As Button
    Friend WithEvents LbSeqFechamento As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents LbTurno As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents BtnFecharCaixa As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents BtnSangriaConfirma As Button
    Friend WithEvents GroupBox19 As GroupBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents TxbSangriaValor As Controles.TxbMonetario
    Friend WithEvents TxbSangriaObs As Controles.TxbDescricao
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents BtnFechaCxConfirmar As Button
    Friend WithEvents GroupBox21 As GroupBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents TxbFechaCxSaldoFinal As Controles.TxbMonetario
    Friend WithEvents TxbFechaCxObs As Controles.TxbDescricao
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnSangriaCancela As Button
    Friend WithEvents BtnFechaCxCancela As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents BtnCadPessoNotaPrazo As Button
    Friend WithEvents BtnBuscaClienteNotaPrazo As Button
    Friend WithEvents GbClienteNotaPrazo As GroupBox
    Friend WithEvents TxbNomClienteNotaPrazo As TextBox
    Friend WithEvents TxbCodClienteNotaPrazo As Controles.TxbCodigo
    Friend WithEvents GroupBox22 As GroupBox
    Friend WithEvents TxbQtdParcNotaPrazo As Controles.TxbCodigo
    Friend WithEvents Label34 As Label
    Friend WithEvents TxbDta1Vecto As Controles.TxbData
    Friend WithEvents DtpDta1Vencto As DateTimePicker
    Friend WithEvents Label35 As Label
    Friend WithEvents BtnCancelaNotaPrazo As Button
    Friend WithEvents BtnConfirmaNotaPrazo As Button
    Friend WithEvents GroupBox23 As GroupBox
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents GroupBox24 As GroupBox
    Friend WithEvents BtnCancelaCartao As Button
    Friend WithEvents BtnConfirmaCartao As Button
    Friend WithEvents TxbQtdParcCartao As Controles.TxbCodigo
    Friend WithEvents Label37 As Label
End Class
