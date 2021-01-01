<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItem))
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DgvPrecoVenda = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LbSeqPrecoVenda = New System.Windows.Forms.Label()
        Me.BtnLimpaVenda = New System.Windows.Forms.Button()
        Me.BtnSalvaPreco = New System.Windows.Forms.Button()
        Me.TxbPrecoD = New Controles.TxbMonetario()
        Me.BtnExcluirVenda = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxbPrecoC = New Controles.TxbMonetario()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxbPrecoB = New Controles.TxbMonetario()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxbPrecoA = New Controles.TxbMonetario()
        Me.TxbDtaInicio = New Controles.TxbData()
        Me.DtpDtaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TxbEstoqueMax = New Controles.TxbMonetario()
        Me.TxbEstoqueMin = New Controles.TxbMonetario()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BtnCadFornecedor = New System.Windows.Forms.Button()
        Me.LbSeqFornecedor = New System.Windows.Forms.Label()
        Me.TxbReferenciaForn = New System.Windows.Forms.TextBox()
        Me.TxbNomFornecedor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxbCodBarraForn = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnLimpaForn = New System.Windows.Forms.Button()
        Me.BtnSalvaForn = New System.Windows.Forms.Button()
        Me.BtnExcluiForn = New System.Windows.Forms.Button()
        Me.TxbCodFornecedor = New Controles.TxbCodigo()
        Me.BtnPesquisaFornecedor = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DgvFornecedor = New System.Windows.Forms.DataGridView()
        Me.txbCodSubcategoria = New Controles.TxbCodigo()
        Me.BtnPesquisaSubcategoria = New System.Windows.Forms.Button()
        Me.TxbDesSubcategoria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CkbAtivo = New System.Windows.Forms.CheckBox()
        Me.TxbCodUnidade = New Controles.TxbCodigo()
        Me.BtnPesquisaUnidade = New System.Windows.Forms.Button()
        Me.TxbDesUnidade = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxbCodMarca = New Controles.TxbCodigo()
        Me.TxbPesquisaMarca = New System.Windows.Forms.Button()
        Me.TxbDesMarca = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbTipoItem = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.BtnLimparBarra = New System.Windows.Forms.Button()
        Me.TxbReferenciaBarra = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxbDesItemBarra = New System.Windows.Forms.TextBox()
        Me.TxbUnidadeBarra = New Controles.TxbCodigo()
        Me.BtnPesquisaUnidadeBarra = New System.Windows.Forms.Button()
        Me.TxbDesUnidadeBarra = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxbCodBarraBarra = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnSalvaBarra = New System.Windows.Forms.Button()
        Me.BtnExcluiBarra = New System.Windows.Forms.Button()
        Me.DgvCodBarra = New System.Windows.Forms.DataGridView()
        Me.txbCodBarra = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txbReferencia = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnPlanejamento = New System.Windows.Forms.Button()
        Me.BtnPrecoVenda = New System.Windows.Forms.Button()
        Me.BtnPrincipal = New System.Windows.Forms.Button()
        Me.BtnFornecedor = New System.Windows.Forms.Button()
        Me.BtnCodBarra = New System.Windows.Forms.Button()
        Me.BtnCadUnidade = New System.Windows.Forms.Button()
        Me.BtnCadMarca = New System.Windows.Forms.Button()
        Me.BtnCadSubCategoria = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvPrecoVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DgvFornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DgvCodBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(552, 46)
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
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(115, 21)
        Me.TabControl1.Size = New System.Drawing.Size(443, 273)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage6, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage5, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage4, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage3, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Size = New System.Drawing.Size(435, 247)
        Me.TabPage1.Text = "Principal"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(6, 172)
        Me.GroupBox1.Size = New System.Drawing.Size(423, 44)
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.BtnCadSubCategoria)
        Me.GroupBox4.Controls.Add(Me.BtnCadMarca)
        Me.GroupBox4.Controls.Add(Me.BtnCadUnidade)
        Me.GroupBox4.Controls.Add(Me.txbReferencia)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txbCodBarra)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.CbTipoItem)
        Me.GroupBox4.Controls.Add(Me.TxbCodMarca)
        Me.GroupBox4.Controls.Add(Me.TxbPesquisaMarca)
        Me.GroupBox4.Controls.Add(Me.TxbDesMarca)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TxbCodUnidade)
        Me.GroupBox4.Controls.Add(Me.BtnPesquisaUnidade)
        Me.GroupBox4.Controls.Add(Me.TxbDesUnidade)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.CkbAtivo)
        Me.GroupBox4.Controls.Add(Me.txbCodSubcategoria)
        Me.GroupBox4.Controls.Add(Me.BtnPesquisaSubcategoria)
        Me.GroupBox4.Controls.Add(Me.TxbDesSubcategoria)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(423, 161)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label5, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDesSubcategoria, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnPesquisaSubcategoria, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txbCodSubcategoria, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.CkbAtivo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label6, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDesUnidade, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnPesquisaUnidade, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodUnidade, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label7, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDesMarca, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbPesquisaMarca, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodMarca, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.CbTipoItem, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label9, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label17, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txbCodBarra, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label19, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txbReferencia, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnCadUnidade, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodigo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label18, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDescricao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnCadMarca, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnCadSubCategoria, 0)
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(1, 20)
        '
        'TabPage2
        '
        Me.TabPage2.Size = New System.Drawing.Size(435, 247)
        Me.TabPage2.Text = "Grid"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv)
        Me.GroupBox3.Size = New System.Drawing.Size(429, 247)
        '
        'TxbDescricao
        '
        Me.TxbDescricao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxbDescricao.Location = New System.Drawing.Point(140, 16)
        Me.TxbDescricao.Size = New System.Drawing.Size(266, 20)
        '
        'TxbCodigo
        '
        Me.TxbCodigo.Location = New System.Drawing.Point(76, 16)
        '
        'Dgv
        '
        Me.Dgv.AllowUserToOrderColumns = True
        Me.Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Location = New System.Drawing.Point(0, 9)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(429, 238)
        Me.Dgv.TabIndex = 3
        Me.Dgv.VirtualMode = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DgvPrecoVenda)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(435, 247)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "PrecoVenda"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DgvPrecoVenda
        '
        Me.DgvPrecoVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPrecoVenda.Location = New System.Drawing.Point(6, 101)
        Me.DgvPrecoVenda.Name = "DgvPrecoVenda"
        Me.DgvPrecoVenda.Size = New System.Drawing.Size(423, 132)
        Me.DgvPrecoVenda.TabIndex = 6
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LbSeqPrecoVenda)
        Me.GroupBox5.Controls.Add(Me.BtnLimpaVenda)
        Me.GroupBox5.Controls.Add(Me.BtnSalvaPreco)
        Me.GroupBox5.Controls.Add(Me.TxbPrecoD)
        Me.GroupBox5.Controls.Add(Me.BtnExcluirVenda)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.TxbPrecoC)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.TxbPrecoB)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.TxbPrecoA)
        Me.GroupBox5.Controls.Add(Me.TxbDtaInicio)
        Me.GroupBox5.Controls.Add(Me.DtpDtaInicio)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(422, 88)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Preço Venda"
        '
        'LbSeqPrecoVenda
        '
        Me.LbSeqPrecoVenda.AutoSize = True
        Me.LbSeqPrecoVenda.Location = New System.Drawing.Point(270, 16)
        Me.LbSeqPrecoVenda.Name = "LbSeqPrecoVenda"
        Me.LbSeqPrecoVenda.Size = New System.Drawing.Size(97, 13)
        Me.LbSeqPrecoVenda.TabIndex = 28
        Me.LbSeqPrecoVenda.Text = "LbSeqPrecoVenda"
        '
        'BtnLimpaVenda
        '
        Me.BtnLimpaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpaVenda.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLimpaVenda.Image = CType(resources.GetObject("BtnLimpaVenda.Image"), System.Drawing.Image)
        Me.BtnLimpaVenda.Location = New System.Drawing.Point(387, 52)
        Me.BtnLimpaVenda.Name = "BtnLimpaVenda"
        Me.BtnLimpaVenda.Size = New System.Drawing.Size(30, 31)
        Me.BtnLimpaVenda.TabIndex = 13
        Me.BtnLimpaVenda.UseVisualStyleBackColor = True
        '
        'BtnSalvaPreco
        '
        Me.BtnSalvaPreco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvaPreco.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvaPreco.Image = CType(resources.GetObject("BtnSalvaPreco.Image"), System.Drawing.Image)
        Me.BtnSalvaPreco.Location = New System.Drawing.Point(330, 52)
        Me.BtnSalvaPreco.Name = "BtnSalvaPreco"
        Me.BtnSalvaPreco.Size = New System.Drawing.Size(30, 31)
        Me.BtnSalvaPreco.TabIndex = 11
        Me.BtnSalvaPreco.UseVisualStyleBackColor = True
        '
        'TxbPrecoD
        '
        Me.TxbPrecoD.Location = New System.Drawing.Point(208, 63)
        Me.TxbPrecoD.Name = "TxbPrecoD"
        Me.TxbPrecoD.Size = New System.Drawing.Size(100, 20)
        Me.TxbPrecoD.TabIndex = 6
        Me.TxbPrecoD.Text = "0,00"
        Me.TxbPrecoD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnExcluirVenda
        '
        Me.BtnExcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluirVenda.ForeColor = System.Drawing.Color.Transparent
        Me.BtnExcluirVenda.Image = CType(resources.GetObject("BtnExcluirVenda.Image"), System.Drawing.Image)
        Me.BtnExcluirVenda.Location = New System.Drawing.Point(359, 52)
        Me.BtnExcluirVenda.Name = "BtnExcluirVenda"
        Me.BtnExcluirVenda.Size = New System.Drawing.Size(30, 31)
        Me.BtnExcluirVenda.TabIndex = 12
        Me.BtnExcluirVenda.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Preço D:"
        '
        'TxbPrecoC
        '
        Me.TxbPrecoC.Location = New System.Drawing.Point(208, 40)
        Me.TxbPrecoC.Name = "TxbPrecoC"
        Me.TxbPrecoC.Size = New System.Drawing.Size(100, 20)
        Me.TxbPrecoC.TabIndex = 5
        Me.TxbPrecoC.Text = "0,00"
        Me.TxbPrecoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Preço C:"
        '
        'TxbPrecoB
        '
        Me.TxbPrecoB.Location = New System.Drawing.Point(51, 62)
        Me.TxbPrecoB.Name = "TxbPrecoB"
        Me.TxbPrecoB.Size = New System.Drawing.Size(100, 20)
        Me.TxbPrecoB.TabIndex = 4
        Me.TxbPrecoB.Text = "0,00"
        Me.TxbPrecoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Preço B:"
        '
        'TxbPrecoA
        '
        Me.TxbPrecoA.Location = New System.Drawing.Point(51, 39)
        Me.TxbPrecoA.Name = "TxbPrecoA"
        Me.TxbPrecoA.Size = New System.Drawing.Size(100, 20)
        Me.TxbPrecoA.TabIndex = 3
        Me.TxbPrecoA.Text = "0,00"
        Me.TxbPrecoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbDtaInicio
        '
        Me.TxbDtaInicio.Location = New System.Drawing.Point(51, 16)
        Me.TxbDtaInicio.MaxLength = 10
        Me.TxbDtaInicio.Name = "TxbDtaInicio"
        Me.TxbDtaInicio.Size = New System.Drawing.Size(66, 20)
        Me.TxbDtaInicio.TabIndex = 1
        '
        'DtpDtaInicio
        '
        Me.DtpDtaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaInicio.Location = New System.Drawing.Point(119, 16)
        Me.DtpDtaInicio.Name = "DtpDtaInicio"
        Me.DtpDtaInicio.Size = New System.Drawing.Size(14, 20)
        Me.DtpDtaInicio.TabIndex = 2
        Me.DtpDtaInicio.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Inicio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Preço A:"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox9)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(435, 247)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Planejamento"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TxbEstoqueMax)
        Me.GroupBox9.Controls.Add(Me.TxbEstoqueMin)
        Me.GroupBox9.Controls.Add(Me.Label11)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(426, 88)
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Planejamento"
        '
        'TxbEstoqueMax
        '
        Me.TxbEstoqueMax.Location = New System.Drawing.Point(99, 50)
        Me.TxbEstoqueMax.Name = "TxbEstoqueMax"
        Me.TxbEstoqueMax.Size = New System.Drawing.Size(100, 20)
        Me.TxbEstoqueMax.TabIndex = 8
        Me.TxbEstoqueMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbEstoqueMin
        '
        Me.TxbEstoqueMin.Location = New System.Drawing.Point(99, 26)
        Me.TxbEstoqueMin.Name = "TxbEstoqueMin"
        Me.TxbEstoqueMin.Size = New System.Drawing.Size(100, 20)
        Me.TxbEstoqueMin.TabIndex = 7
        Me.TxbEstoqueMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Estoque Máximo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Estoque Mínimo:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox6)
        Me.TabPage5.Controls.Add(Me.DgvFornecedor)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(435, 247)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Fornecedor"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BtnCadFornecedor)
        Me.GroupBox6.Controls.Add(Me.LbSeqFornecedor)
        Me.GroupBox6.Controls.Add(Me.TxbReferenciaForn)
        Me.GroupBox6.Controls.Add(Me.TxbNomFornecedor)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.TxbCodBarraForn)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.BtnLimpaForn)
        Me.GroupBox6.Controls.Add(Me.BtnSalvaForn)
        Me.GroupBox6.Controls.Add(Me.BtnExcluiForn)
        Me.GroupBox6.Controls.Add(Me.TxbCodFornecedor)
        Me.GroupBox6.Controls.Add(Me.BtnPesquisaFornecedor)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(423, 97)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Fornecedor"
        '
        'BtnCadFornecedor
        '
        Me.BtnCadFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadFornecedor.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCadFornecedor.Location = New System.Drawing.Point(392, 10)
        Me.BtnCadFornecedor.Name = "BtnCadFornecedor"
        Me.BtnCadFornecedor.Size = New System.Drawing.Size(25, 20)
        Me.BtnCadFornecedor.TabIndex = 91
        Me.BtnCadFornecedor.Text = "C"
        Me.BtnCadFornecedor.UseVisualStyleBackColor = True
        '
        'LbSeqFornecedor
        '
        Me.LbSeqFornecedor.AutoSize = True
        Me.LbSeqFornecedor.Location = New System.Drawing.Point(77, 65)
        Me.LbSeqFornecedor.Name = "LbSeqFornecedor"
        Me.LbSeqFornecedor.Size = New System.Drawing.Size(92, 13)
        Me.LbSeqFornecedor.TabIndex = 90
        Me.LbSeqFornecedor.Text = "LbSeqFornecedor"
        Me.LbSeqFornecedor.Visible = False
        '
        'TxbReferenciaForn
        '
        Me.TxbReferenciaForn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbReferenciaForn.Location = New System.Drawing.Point(312, 33)
        Me.TxbReferenciaForn.Name = "TxbReferenciaForn"
        Me.TxbReferenciaForn.Size = New System.Drawing.Size(105, 20)
        Me.TxbReferenciaForn.TabIndex = 83
        '
        'TxbNomFornecedor
        '
        Me.TxbNomFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomFornecedor.Location = New System.Drawing.Point(132, 10)
        Me.TxbNomFornecedor.Name = "TxbNomFornecedor"
        Me.TxbNomFornecedor.Size = New System.Drawing.Size(229, 20)
        Me.TxbNomFornecedor.TabIndex = 80
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(252, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Referência:"
        '
        'TxbCodBarraForn
        '
        Me.TxbCodBarraForn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbCodBarraForn.Location = New System.Drawing.Point(70, 33)
        Me.TxbCodBarraForn.Name = "TxbCodBarraForn"
        Me.TxbCodBarraForn.Size = New System.Drawing.Size(149, 20)
        Me.TxbCodBarraForn.TabIndex = 82
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "Cód.Barra:"
        '
        'BtnLimpaForn
        '
        Me.BtnLimpaForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpaForn.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLimpaForn.Image = CType(resources.GetObject("BtnLimpaForn.Image"), System.Drawing.Image)
        Me.BtnLimpaForn.Location = New System.Drawing.Point(385, 56)
        Me.BtnLimpaForn.Name = "BtnLimpaForn"
        Me.BtnLimpaForn.Size = New System.Drawing.Size(30, 31)
        Me.BtnLimpaForn.TabIndex = 86
        Me.BtnLimpaForn.UseVisualStyleBackColor = True
        '
        'BtnSalvaForn
        '
        Me.BtnSalvaForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvaForn.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvaForn.Image = CType(resources.GetObject("BtnSalvaForn.Image"), System.Drawing.Image)
        Me.BtnSalvaForn.Location = New System.Drawing.Point(331, 56)
        Me.BtnSalvaForn.Name = "BtnSalvaForn"
        Me.BtnSalvaForn.Size = New System.Drawing.Size(30, 31)
        Me.BtnSalvaForn.TabIndex = 84
        Me.BtnSalvaForn.UseVisualStyleBackColor = True
        '
        'BtnExcluiForn
        '
        Me.BtnExcluiForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluiForn.ForeColor = System.Drawing.Color.Transparent
        Me.BtnExcluiForn.Image = CType(resources.GetObject("BtnExcluiForn.Image"), System.Drawing.Image)
        Me.BtnExcluiForn.Location = New System.Drawing.Point(358, 56)
        Me.BtnExcluiForn.Name = "BtnExcluiForn"
        Me.BtnExcluiForn.Size = New System.Drawing.Size(30, 31)
        Me.BtnExcluiForn.TabIndex = 85
        Me.BtnExcluiForn.UseVisualStyleBackColor = True
        '
        'TxbCodFornecedor
        '
        Me.TxbCodFornecedor.Location = New System.Drawing.Point(70, 10)
        Me.TxbCodFornecedor.Name = "TxbCodFornecedor"
        Me.TxbCodFornecedor.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodFornecedor.TabIndex = 79
        '
        'BtnPesquisaFornecedor
        '
        Me.BtnPesquisaFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisaFornecedor.ForeColor = System.Drawing.Color.DimGray
        Me.BtnPesquisaFornecedor.Image = CType(resources.GetObject("BtnPesquisaFornecedor.Image"), System.Drawing.Image)
        Me.BtnPesquisaFornecedor.Location = New System.Drawing.Point(364, 10)
        Me.BtnPesquisaFornecedor.Name = "BtnPesquisaFornecedor"
        Me.BtnPesquisaFornecedor.Size = New System.Drawing.Size(25, 20)
        Me.BtnPesquisaFornecedor.TabIndex = 81
        Me.BtnPesquisaFornecedor.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 13)
        Me.Label16.TabIndex = 87
        Me.Label16.Text = "Nome:"
        '
        'DgvFornecedor
        '
        Me.DgvFornecedor.AllowUserToOrderColumns = True
        Me.DgvFornecedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFornecedor.Location = New System.Drawing.Point(6, 105)
        Me.DgvFornecedor.Name = "DgvFornecedor"
        Me.DgvFornecedor.Size = New System.Drawing.Size(388, 104)
        Me.DgvFornecedor.TabIndex = 5
        Me.DgvFornecedor.VirtualMode = True
        '
        'txbCodSubcategoria
        '
        Me.txbCodSubcategoria.Location = New System.Drawing.Point(76, 62)
        Me.txbCodSubcategoria.Name = "txbCodSubcategoria"
        Me.txbCodSubcategoria.Size = New System.Drawing.Size(60, 20)
        Me.txbCodSubcategoria.TabIndex = 4
        '
        'BtnPesquisaSubcategoria
        '
        Me.BtnPesquisaSubcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisaSubcategoria.ForeColor = System.Drawing.Color.DimGray
        Me.BtnPesquisaSubcategoria.Image = CType(resources.GetObject("BtnPesquisaSubcategoria.Image"), System.Drawing.Image)
        Me.BtnPesquisaSubcategoria.Location = New System.Drawing.Point(354, 62)
        Me.BtnPesquisaSubcategoria.Name = "BtnPesquisaSubcategoria"
        Me.BtnPesquisaSubcategoria.Size = New System.Drawing.Size(25, 20)
        Me.BtnPesquisaSubcategoria.TabIndex = 6
        Me.BtnPesquisaSubcategoria.UseVisualStyleBackColor = True
        '
        'TxbDesSubcategoria
        '
        Me.TxbDesSubcategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesSubcategoria.Location = New System.Drawing.Point(140, 62)
        Me.TxbDesSubcategoria.Name = "TxbDesSubcategoria"
        Me.TxbDesSubcategoria.Size = New System.Drawing.Size(212, 20)
        Me.TxbDesSubcategoria.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "SubCategoria:"
        '
        'CkbAtivo
        '
        Me.CkbAtivo.AutoSize = True
        Me.CkbAtivo.Location = New System.Drawing.Point(356, 133)
        Me.CkbAtivo.Name = "CkbAtivo"
        Me.CkbAtivo.Size = New System.Drawing.Size(50, 17)
        Me.CkbAtivo.TabIndex = 13
        Me.CkbAtivo.Text = "Ativo"
        Me.CkbAtivo.UseVisualStyleBackColor = True
        '
        'TxbCodUnidade
        '
        Me.TxbCodUnidade.Location = New System.Drawing.Point(76, 85)
        Me.TxbCodUnidade.Name = "TxbCodUnidade"
        Me.TxbCodUnidade.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodUnidade.TabIndex = 7
        '
        'BtnPesquisaUnidade
        '
        Me.BtnPesquisaUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisaUnidade.ForeColor = System.Drawing.Color.DimGray
        Me.BtnPesquisaUnidade.Image = CType(resources.GetObject("BtnPesquisaUnidade.Image"), System.Drawing.Image)
        Me.BtnPesquisaUnidade.Location = New System.Drawing.Point(354, 85)
        Me.BtnPesquisaUnidade.Name = "BtnPesquisaUnidade"
        Me.BtnPesquisaUnidade.Size = New System.Drawing.Size(25, 20)
        Me.BtnPesquisaUnidade.TabIndex = 9
        Me.BtnPesquisaUnidade.UseVisualStyleBackColor = True
        '
        'TxbDesUnidade
        '
        Me.TxbDesUnidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesUnidade.Location = New System.Drawing.Point(140, 85)
        Me.TxbDesUnidade.Name = "TxbDesUnidade"
        Me.TxbDesUnidade.Size = New System.Drawing.Size(212, 20)
        Me.TxbDesUnidade.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Unidade"
        '
        'TxbCodMarca
        '
        Me.TxbCodMarca.Location = New System.Drawing.Point(76, 108)
        Me.TxbCodMarca.Name = "TxbCodMarca"
        Me.TxbCodMarca.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodMarca.TabIndex = 10
        '
        'TxbPesquisaMarca
        '
        Me.TxbPesquisaMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TxbPesquisaMarca.ForeColor = System.Drawing.Color.DimGray
        Me.TxbPesquisaMarca.Image = CType(resources.GetObject("TxbPesquisaMarca.Image"), System.Drawing.Image)
        Me.TxbPesquisaMarca.Location = New System.Drawing.Point(354, 108)
        Me.TxbPesquisaMarca.Name = "TxbPesquisaMarca"
        Me.TxbPesquisaMarca.Size = New System.Drawing.Size(25, 20)
        Me.TxbPesquisaMarca.TabIndex = 12
        Me.TxbPesquisaMarca.UseVisualStyleBackColor = True
        '
        'TxbDesMarca
        '
        Me.TxbDesMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesMarca.Location = New System.Drawing.Point(140, 108)
        Me.TxbDesMarca.Name = "TxbDesMarca"
        Me.TxbDesMarca.Size = New System.Drawing.Size(212, 20)
        Me.TxbDesMarca.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Marca:"
        '
        'CbTipoItem
        '
        Me.CbTipoItem.FormattingEnabled = True
        Me.CbTipoItem.Items.AddRange(New Object() {"", "PRODUTO", "SERVICO", "INSUMO"})
        Me.CbTipoItem.Location = New System.Drawing.Point(76, 131)
        Me.CbTipoItem.Name = "CbTipoItem"
        Me.CbTipoItem.Size = New System.Drawing.Size(121, 21)
        Me.CbTipoItem.TabIndex = 12
        Me.CbTipoItem.Text = "PRODUTO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Tipo Item:"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox7)
        Me.TabPage6.Controls.Add(Me.DgvCodBarra)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(435, 247)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "CodBarra"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.BtnLimparBarra)
        Me.GroupBox7.Controls.Add(Me.TxbReferenciaBarra)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.TxbDesItemBarra)
        Me.GroupBox7.Controls.Add(Me.TxbUnidadeBarra)
        Me.GroupBox7.Controls.Add(Me.BtnPesquisaUnidadeBarra)
        Me.GroupBox7.Controls.Add(Me.TxbDesUnidadeBarra)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.TxbCodBarraBarra)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.BtnSalvaBarra)
        Me.GroupBox7.Controls.Add(Me.BtnExcluiBarra)
        Me.GroupBox7.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(422, 88)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Código de Barras"
        '
        'BtnLimparBarra
        '
        Me.BtnLimparBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimparBarra.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLimparBarra.Image = CType(resources.GetObject("BtnLimparBarra.Image"), System.Drawing.Image)
        Me.BtnLimparBarra.Location = New System.Drawing.Point(385, 55)
        Me.BtnLimparBarra.Name = "BtnLimparBarra"
        Me.BtnLimparBarra.Size = New System.Drawing.Size(30, 31)
        Me.BtnLimparBarra.TabIndex = 101
        Me.BtnLimparBarra.UseVisualStyleBackColor = True
        '
        'TxbReferenciaBarra
        '
        Me.TxbReferenciaBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbReferenciaBarra.Location = New System.Drawing.Point(310, 12)
        Me.TxbReferenciaBarra.Name = "TxbReferenciaBarra"
        Me.TxbReferenciaBarra.Size = New System.Drawing.Size(105, 20)
        Me.TxbReferenciaBarra.TabIndex = 90
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 62)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 13)
        Me.Label21.TabIndex = 100
        Me.Label21.Text = "Descrição:"
        '
        'TxbDesItemBarra
        '
        Me.TxbDesItemBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesItemBarra.Location = New System.Drawing.Point(84, 58)
        Me.TxbDesItemBarra.Name = "TxbDesItemBarra"
        Me.TxbDesItemBarra.Size = New System.Drawing.Size(223, 20)
        Me.TxbDesItemBarra.TabIndex = 94
        '
        'TxbUnidadeBarra
        '
        Me.TxbUnidadeBarra.Location = New System.Drawing.Point(84, 35)
        Me.TxbUnidadeBarra.Name = "TxbUnidadeBarra"
        Me.TxbUnidadeBarra.Size = New System.Drawing.Size(60, 20)
        Me.TxbUnidadeBarra.TabIndex = 91
        '
        'BtnPesquisaUnidadeBarra
        '
        Me.BtnPesquisaUnidadeBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisaUnidadeBarra.Image = CType(resources.GetObject("BtnPesquisaUnidadeBarra.Image"), System.Drawing.Image)
        Me.BtnPesquisaUnidadeBarra.Location = New System.Drawing.Point(391, 35)
        Me.BtnPesquisaUnidadeBarra.Name = "BtnPesquisaUnidadeBarra"
        Me.BtnPesquisaUnidadeBarra.Size = New System.Drawing.Size(24, 20)
        Me.BtnPesquisaUnidadeBarra.TabIndex = 93
        Me.BtnPesquisaUnidadeBarra.UseVisualStyleBackColor = True
        '
        'TxbDesUnidadeBarra
        '
        Me.TxbDesUnidadeBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesUnidadeBarra.Location = New System.Drawing.Point(150, 35)
        Me.TxbDesUnidadeBarra.Name = "TxbDesUnidadeBarra"
        Me.TxbDesUnidadeBarra.Size = New System.Drawing.Size(239, 20)
        Me.TxbDesUnidadeBarra.TabIndex = 92
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 39)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 13)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "Unidade"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(250, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "Referência:"
        '
        'TxbCodBarraBarra
        '
        Me.TxbCodBarraBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbCodBarraBarra.Location = New System.Drawing.Point(84, 12)
        Me.TxbCodBarraBarra.Name = "TxbCodBarraBarra"
        Me.TxbCodBarraBarra.Size = New System.Drawing.Size(145, 20)
        Me.TxbCodBarraBarra.TabIndex = 89
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 97
        Me.Label15.Text = "Cód.Barra:"
        '
        'BtnSalvaBarra
        '
        Me.BtnSalvaBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvaBarra.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvaBarra.Image = CType(resources.GetObject("BtnSalvaBarra.Image"), System.Drawing.Image)
        Me.BtnSalvaBarra.Location = New System.Drawing.Point(327, 55)
        Me.BtnSalvaBarra.Name = "BtnSalvaBarra"
        Me.BtnSalvaBarra.Size = New System.Drawing.Size(30, 31)
        Me.BtnSalvaBarra.TabIndex = 95
        Me.BtnSalvaBarra.UseVisualStyleBackColor = True
        '
        'BtnExcluiBarra
        '
        Me.BtnExcluiBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluiBarra.ForeColor = System.Drawing.Color.Transparent
        Me.BtnExcluiBarra.Image = CType(resources.GetObject("BtnExcluiBarra.Image"), System.Drawing.Image)
        Me.BtnExcluiBarra.Location = New System.Drawing.Point(359, 55)
        Me.BtnExcluiBarra.Name = "BtnExcluiBarra"
        Me.BtnExcluiBarra.Size = New System.Drawing.Size(30, 31)
        Me.BtnExcluiBarra.TabIndex = 96
        Me.BtnExcluiBarra.UseVisualStyleBackColor = True
        '
        'DgvCodBarra
        '
        Me.DgvCodBarra.AllowUserToOrderColumns = True
        Me.DgvCodBarra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCodBarra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCodBarra.Location = New System.Drawing.Point(9, 101)
        Me.DgvCodBarra.Name = "DgvCodBarra"
        Me.DgvCodBarra.Size = New System.Drawing.Size(213, 0)
        Me.DgvCodBarra.TabIndex = 5
        Me.DgvCodBarra.VirtualMode = True
        '
        'txbCodBarra
        '
        Me.txbCodBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbCodBarra.Location = New System.Drawing.Point(76, 39)
        Me.txbCodBarra.Name = "txbCodBarra"
        Me.txbCodBarra.Size = New System.Drawing.Size(105, 20)
        Me.txbCodBarra.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 71
        Me.Label17.Text = "Cód.Barra:"
        '
        'txbReferencia
        '
        Me.txbReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbReferencia.Location = New System.Drawing.Point(301, 39)
        Me.txbReferencia.Name = "txbReferencia"
        Me.txbReferencia.Size = New System.Drawing.Size(105, 20)
        Me.txbReferencia.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(238, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 73
        Me.Label19.Text = "Referência:"
        '
        'BtnPlanejamento
        '
        Me.BtnPlanejamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlanejamento.Location = New System.Drawing.Point(5, 114)
        Me.BtnPlanejamento.Name = "BtnPlanejamento"
        Me.BtnPlanejamento.Size = New System.Drawing.Size(107, 28)
        Me.BtnPlanejamento.TabIndex = 3
        Me.BtnPlanejamento.Text = "Planejamento"
        Me.BtnPlanejamento.UseVisualStyleBackColor = True
        '
        'BtnPrecoVenda
        '
        Me.BtnPrecoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrecoVenda.Location = New System.Drawing.Point(5, 84)
        Me.BtnPrecoVenda.Name = "BtnPrecoVenda"
        Me.BtnPrecoVenda.Size = New System.Drawing.Size(107, 28)
        Me.BtnPrecoVenda.TabIndex = 2
        Me.BtnPrecoVenda.Text = "Preço Venda"
        Me.BtnPrecoVenda.UseVisualStyleBackColor = True
        '
        'BtnPrincipal
        '
        Me.BtnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrincipal.Location = New System.Drawing.Point(5, 54)
        Me.BtnPrincipal.Name = "BtnPrincipal"
        Me.BtnPrincipal.Size = New System.Drawing.Size(107, 28)
        Me.BtnPrincipal.TabIndex = 1
        Me.BtnPrincipal.Text = "Principal"
        Me.BtnPrincipal.UseVisualStyleBackColor = True
        '
        'BtnFornecedor
        '
        Me.BtnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFornecedor.Location = New System.Drawing.Point(5, 145)
        Me.BtnFornecedor.Name = "BtnFornecedor"
        Me.BtnFornecedor.Size = New System.Drawing.Size(107, 28)
        Me.BtnFornecedor.TabIndex = 4
        Me.BtnFornecedor.Text = "Fornecedores"
        Me.BtnFornecedor.UseVisualStyleBackColor = True
        '
        'BtnCodBarra
        '
        Me.BtnCodBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCodBarra.Location = New System.Drawing.Point(5, 177)
        Me.BtnCodBarra.Name = "BtnCodBarra"
        Me.BtnCodBarra.Size = New System.Drawing.Size(107, 28)
        Me.BtnCodBarra.TabIndex = 5
        Me.BtnCodBarra.Text = "Cod.Barras"
        Me.BtnCodBarra.UseVisualStyleBackColor = True
        '
        'BtnCadUnidade
        '
        Me.BtnCadUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadUnidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadUnidade.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCadUnidade.Location = New System.Drawing.Point(381, 85)
        Me.BtnCadUnidade.Name = "BtnCadUnidade"
        Me.BtnCadUnidade.Size = New System.Drawing.Size(25, 20)
        Me.BtnCadUnidade.TabIndex = 74
        Me.BtnCadUnidade.Text = "C"
        Me.BtnCadUnidade.UseVisualStyleBackColor = True
        '
        'BtnCadMarca
        '
        Me.BtnCadMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadMarca.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCadMarca.Location = New System.Drawing.Point(381, 108)
        Me.BtnCadMarca.Name = "BtnCadMarca"
        Me.BtnCadMarca.Size = New System.Drawing.Size(25, 20)
        Me.BtnCadMarca.TabIndex = 75
        Me.BtnCadMarca.Text = "C"
        Me.BtnCadMarca.UseVisualStyleBackColor = True
        '
        'BtnCadSubCategoria
        '
        Me.BtnCadSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadSubCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadSubCategoria.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCadSubCategoria.Location = New System.Drawing.Point(381, 62)
        Me.BtnCadSubCategoria.Name = "BtnCadSubCategoria"
        Me.BtnCadSubCategoria.Size = New System.Drawing.Size(25, 20)
        Me.BtnCadSubCategoria.TabIndex = 76
        Me.BtnCadSubCategoria.Text = "C"
        Me.BtnCadSubCategoria.UseVisualStyleBackColor = True
        '
        'FrmItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(560, 294)
        Me.Controls.Add(Me.BtnCodBarra)
        Me.Controls.Add(Me.BtnFornecedor)
        Me.Controls.Add(Me.BtnPlanejamento)
        Me.Controls.Add(Me.BtnPrecoVenda)
        Me.Controls.Add(Me.BtnPrincipal)
        Me.Name = "FrmItem"
        Me.Text = "FrmItem"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.BtnPrincipal, 0)
        Me.Controls.SetChildIndex(Me.BtnPrecoVenda, 0)
        Me.Controls.SetChildIndex(Me.BtnPlanejamento, 0)
        Me.Controls.SetChildIndex(Me.BtnFornecedor, 0)
        Me.Controls.SetChildIndex(Me.BtnCodBarra, 0)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DgvPrecoVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DgvFornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.DgvCodBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Dgv As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TxbPrecoD As Controles.TxbMonetario
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbPrecoC As Controles.TxbMonetario
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbPrecoB As Controles.TxbMonetario
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbPrecoA As Controles.TxbMonetario
    Friend WithEvents TxbDtaInicio As Controles.TxbData
    Friend WithEvents DtpDtaInicio As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnLimpaVenda As Button
    Friend WithEvents BtnSalvaPreco As Button
    Friend WithEvents BtnExcluirVenda As Button
    Friend WithEvents txbCodSubcategoria As Controles.TxbCodigo
    Friend WithEvents BtnPesquisaSubcategoria As Button
    Friend WithEvents TxbDesSubcategoria As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents txbReferencia As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txbCodBarra As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CbTipoItem As ComboBox
    Friend WithEvents TxbCodMarca As Controles.TxbCodigo
    Friend WithEvents TxbPesquisaMarca As Button
    Friend WithEvents TxbDesMarca As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxbCodUnidade As Controles.TxbCodigo
    Friend WithEvents BtnPesquisaUnidade As Button
    Friend WithEvents TxbDesUnidade As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CkbAtivo As CheckBox
    Public WithEvents DgvFornecedor As DataGridView
    Public WithEvents DgvCodBarra As DataGridView
    Friend WithEvents BtnPlanejamento As Button
    Friend WithEvents BtnPrecoVenda As Button
    Friend WithEvents BtnPrincipal As Button
    Friend WithEvents BtnFornecedor As Button
    Friend WithEvents BtnCodBarra As Button
    Friend WithEvents DgvPrecoVenda As DataGridView
    Friend WithEvents LbSeqPrecoVenda As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents TxbEstoqueMax As Controles.TxbMonetario
    Friend WithEvents TxbEstoqueMin As Controles.TxbMonetario
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LbSeqFornecedor As Label
    Friend WithEvents TxbReferenciaForn As TextBox
    Friend WithEvents TxbNomFornecedor As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxbCodBarraForn As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnLimpaForn As Button
    Friend WithEvents BtnSalvaForn As Button
    Friend WithEvents BtnExcluiForn As Button
    Friend WithEvents TxbCodFornecedor As Controles.TxbCodigo
    Friend WithEvents BtnPesquisaFornecedor As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents BtnLimparBarra As Button
    Friend WithEvents TxbReferenciaBarra As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxbDesItemBarra As TextBox
    Friend WithEvents TxbUnidadeBarra As Controles.TxbCodigo
    Friend WithEvents BtnPesquisaUnidadeBarra As Button
    Friend WithEvents TxbDesUnidadeBarra As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxbCodBarraBarra As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnSalvaBarra As Button
    Friend WithEvents BtnExcluiBarra As Button
    Friend WithEvents BtnCadSubCategoria As Button
    Friend WithEvents BtnCadMarca As Button
    Friend WithEvents BtnCadUnidade As Button
    Friend WithEvents BtnCadFornecedor As Button
End Class
