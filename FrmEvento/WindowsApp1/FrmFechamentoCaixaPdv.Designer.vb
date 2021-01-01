<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFechamentoCaixaPdv
    Inherits Controles.FrmCad1Padrao

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Princípal")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Produtos")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Serviços")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vendas", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sangria")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Notas")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Forma Pagamento")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Notas Fiscais", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFechamentoCaixaPdv))
        Me.TxbCodOperador = New Controles.TxbCodigo()
        Me.TxbNomOperador = New Controles.TxbDescricao()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxbNumFechamento = New Controles.TxbCodigo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxbhraAbertura = New Controles.TxbCodigo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxbHraFechamento = New Controles.TxbCodigo()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxbSeqFechamento = New Controles.TxbCodigo()
        Me.BtnDtaFinal = New System.Windows.Forms.Button()
        Me.TxbDtaFechamento = New Controles.TxbData()
        Me.DtpDtaFechamento = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TrvFechamento = New System.Windows.Forms.TreeView()
        Me.DgvRecebimento = New System.Windows.Forms.DataGridView()
        Me.RbAberto = New System.Windows.Forms.RadioButton()
        Me.RbConferido = New System.Windows.Forms.RadioButton()
        Me.RbFechado = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CkbPe = New System.Windows.Forms.CheckBox()
        Me.TxbDiferenca = New Controles.TxbMonetario()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.DgvVenda = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DgvProdutos = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DgvServico = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TxbSangriaObs = New Controles.TxbDescricao()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxbSangriaValor = New Controles.TxbMonetario()
        Me.BtnSangriaSalvar = New System.Windows.Forms.Button()
        Me.DgvSangria = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DgvNotas = New System.Windows.Forms.DataGridView()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.DgvPagNota = New System.Windows.Forms.DataGridView()
        Me.BtnConferido = New System.Windows.Forms.Button()
        Me.BtnExtornar = New System.Windows.Forms.Button()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvRecebimento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DgvServico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DgvSangria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.DgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.DgvPagNota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Size = New System.Drawing.Size(621, 46)
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Location = New System.Drawing.Point(151, 26)
        Me.TabControl1.Size = New System.Drawing.Size(478, 441)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage8, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage7, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage6, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage5, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage4, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage3, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabPage1, 0)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DgvVenda)
        Me.TabPage1.Controls.Add(Me.DgvRecebimento)
        Me.TabPage1.Size = New System.Drawing.Size(470, 415)
        Me.TabPage1.Text = "Principal"
        Me.TabPage1.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.TabPage1.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.TabPage1.Controls.SetChildIndex(Me.DgvRecebimento, 0)
        Me.TabPage1.Controls.SetChildIndex(Me.DgvVenda, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnExtornar)
        Me.GroupBox1.Controls.Add(Me.BtnConferido)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxbDiferenca)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 318)
        Me.GroupBox1.Size = New System.Drawing.Size(458, 91)
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.TxbSeqFechamento)
        Me.GroupBox4.Controls.Add(Me.TxbHraFechamento)
        Me.GroupBox4.Controls.Add(Me.TxbNumFechamento)
        Me.GroupBox4.Controls.Add(Me.BtnDtaFinal)
        Me.GroupBox4.Controls.Add(Me.TxbDtaFechamento)
        Me.GroupBox4.Controls.Add(Me.DtpDtaFechamento)
        Me.GroupBox4.Controls.Add(Me.TxbhraAbertura)
        Me.GroupBox4.Controls.Add(Me.TxbNomOperador)
        Me.GroupBox4.Controls.Add(Me.TxbCodOperador)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(458, 91)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label18, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label1, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label2, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label3, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label4, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label5, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label8, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodigo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDescricao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodOperador, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbNomOperador, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbhraAbertura, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.DtpDtaFechamento, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDtaFechamento, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnDtaFinal, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbNumFechamento, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbHraFechamento, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbSeqFechamento, 0)
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(2, 16)
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.Text = "PDV:"
        '
        'TabPage2
        '
        Me.TabPage2.Size = New System.Drawing.Size(470, 415)
        Me.TabPage2.Text = "Grid Principla"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv)
        Me.GroupBox3.Size = New System.Drawing.Size(464, 399)
        '
        'TxbDescricao
        '
        Me.TxbDescricao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxbDescricao.Location = New System.Drawing.Point(120, 12)
        Me.TxbDescricao.Size = New System.Drawing.Size(178, 20)
        '
        'TxbCodigo
        '
        Me.TxbCodigo.Location = New System.Drawing.Point(58, 12)
        '
        'TxbCodOperador
        '
        Me.TxbCodOperador.Location = New System.Drawing.Point(58, 35)
        Me.TxbCodOperador.Name = "TxbCodOperador"
        Me.TxbCodOperador.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodOperador.TabIndex = 35
        '
        'TxbNomOperador
        '
        Me.TxbNomOperador.Location = New System.Drawing.Point(120, 35)
        Me.TxbNomOperador.Name = "TxbNomOperador"
        Me.TxbNomOperador.Size = New System.Drawing.Size(178, 20)
        Me.TxbNomOperador.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Operador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Núm.Fechamento:"
        '
        'TxbNumFechamento
        '
        Me.TxbNumFechamento.Location = New System.Drawing.Point(392, 12)
        Me.TxbNumFechamento.Name = "TxbNumFechamento"
        Me.TxbNumFechamento.Size = New System.Drawing.Size(60, 20)
        Me.TxbNumFechamento.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Hora Abertura:"
        '
        'TxbhraAbertura
        '
        Me.TxbhraAbertura.Location = New System.Drawing.Point(238, 58)
        Me.TxbhraAbertura.MaxLength = 5
        Me.TxbhraAbertura.Name = "TxbhraAbertura"
        Me.TxbhraAbertura.Size = New System.Drawing.Size(60, 20)
        Me.TxbhraAbertura.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Hora Fechamento:"
        '
        'TxbHraFechamento
        '
        Me.TxbHraFechamento.Location = New System.Drawing.Point(392, 58)
        Me.TxbHraFechamento.MaxLength = 5
        Me.TxbHraFechamento.Name = "TxbHraFechamento"
        Me.TxbHraFechamento.Size = New System.Drawing.Size(60, 20)
        Me.TxbHraFechamento.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(303, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Seq.Fechamento:"
        '
        'TxbSeqFechamento
        '
        Me.TxbSeqFechamento.Location = New System.Drawing.Point(392, 35)
        Me.TxbSeqFechamento.Name = "TxbSeqFechamento"
        Me.TxbSeqFechamento.Size = New System.Drawing.Size(60, 20)
        Me.TxbSeqFechamento.TabIndex = 44
        '
        'BtnDtaFinal
        '
        Me.BtnDtaFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDtaFinal.Font = New System.Drawing.Font("Bernard MT Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDtaFinal.ForeColor = System.Drawing.Color.DimGray
        Me.BtnDtaFinal.Location = New System.Drawing.Point(142, 58)
        Me.BtnDtaFinal.Name = "BtnDtaFinal"
        Me.BtnDtaFinal.Size = New System.Drawing.Size(23, 20)
        Me.BtnDtaFinal.TabIndex = 51
        Me.BtnDtaFinal.Text = "F"
        Me.BtnDtaFinal.UseVisualStyleBackColor = True
        '
        'TxbDtaFechamento
        '
        Me.TxbDtaFechamento.Location = New System.Drawing.Point(58, 58)
        Me.TxbDtaFechamento.MaxLength = 10
        Me.TxbDtaFechamento.Name = "TxbDtaFechamento"
        Me.TxbDtaFechamento.Size = New System.Drawing.Size(66, 20)
        Me.TxbDtaFechamento.TabIndex = 49
        '
        'DtpDtaFechamento
        '
        Me.DtpDtaFechamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaFechamento.Location = New System.Drawing.Point(126, 58)
        Me.DtpDtaFechamento.Name = "DtpDtaFechamento"
        Me.DtpDtaFechamento.Size = New System.Drawing.Size(14, 20)
        Me.DtpDtaFechamento.TabIndex = 50
        Me.DtpDtaFechamento.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Data:"
        '
        'TrvFechamento
        '
        Me.TrvFechamento.Location = New System.Drawing.Point(7, 49)
        Me.TrvFechamento.Name = "TrvFechamento"
        TreeNode1.Name = "principal"
        TreeNode1.Text = "Princípal"
        TreeNode2.Name = "produto"
        TreeNode2.Text = "Produtos"
        TreeNode3.Name = "servico"
        TreeNode3.Text = "Serviços"
        TreeNode4.Name = "Nó0"
        TreeNode4.Text = "Vendas"
        TreeNode5.Name = "sangria"
        TreeNode5.Text = "Sangria"
        TreeNode6.Name = "nota"
        TreeNode6.Text = "Notas"
        TreeNode7.Name = "formaPagamento"
        TreeNode7.Text = "Forma Pagamento"
        TreeNode8.Name = "Nó4"
        TreeNode8.Text = "Notas Fiscais"
        Me.TrvFechamento.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode4, TreeNode5, TreeNode8})
        Me.TrvFechamento.Size = New System.Drawing.Size(140, 418)
        Me.TrvFechamento.TabIndex = 16
        '
        'DgvRecebimento
        '
        Me.DgvRecebimento.AllowUserToAddRows = False
        Me.DgvRecebimento.AllowUserToDeleteRows = False
        Me.DgvRecebimento.AllowUserToResizeColumns = False
        Me.DgvRecebimento.AllowUserToResizeRows = False
        Me.DgvRecebimento.BackgroundColor = System.Drawing.Color.White
        Me.DgvRecebimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvRecebimento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvRecebimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecebimento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvRecebimento.Location = New System.Drawing.Point(5, 97)
        Me.DgvRecebimento.Name = "DgvRecebimento"
        Me.DgvRecebimento.ReadOnly = True
        Me.DgvRecebimento.RowHeadersVisible = False
        Me.DgvRecebimento.Size = New System.Drawing.Size(227, 224)
        Me.DgvRecebimento.TabIndex = 17
        '
        'RbAberto
        '
        Me.RbAberto.AutoSize = True
        Me.RbAberto.Location = New System.Drawing.Point(6, 12)
        Me.RbAberto.Name = "RbAberto"
        Me.RbAberto.Size = New System.Drawing.Size(56, 17)
        Me.RbAberto.TabIndex = 0
        Me.RbAberto.TabStop = True
        Me.RbAberto.Text = "Aberto"
        Me.RbAberto.UseVisualStyleBackColor = True
        '
        'RbConferido
        '
        Me.RbConferido.AutoSize = True
        Me.RbConferido.Location = New System.Drawing.Point(140, 12)
        Me.RbConferido.Name = "RbConferido"
        Me.RbConferido.Size = New System.Drawing.Size(70, 17)
        Me.RbConferido.TabIndex = 1
        Me.RbConferido.TabStop = True
        Me.RbConferido.Text = "Conferido"
        Me.RbConferido.UseVisualStyleBackColor = True
        '
        'RbFechado
        '
        Me.RbFechado.AutoSize = True
        Me.RbFechado.Location = New System.Drawing.Point(67, 12)
        Me.RbFechado.Name = "RbFechado"
        Me.RbFechado.Size = New System.Drawing.Size(67, 17)
        Me.RbFechado.TabIndex = 2
        Me.RbFechado.TabStop = True
        Me.RbFechado.Text = "Fechado"
        Me.RbFechado.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CkbPe)
        Me.GroupBox5.Controls.Add(Me.RbAberto)
        Me.GroupBox5.Controls.Add(Me.RbFechado)
        Me.GroupBox5.Controls.Add(Me.RbConferido)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(292, 34)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Status"
        '
        'CkbPe
        '
        Me.CkbPe.AutoSize = True
        Me.CkbPe.Location = New System.Drawing.Point(243, 12)
        Me.CkbPe.Name = "CkbPe"
        Me.CkbPe.Size = New System.Drawing.Size(43, 17)
        Me.CkbPe.TabIndex = 3
        Me.CkbPe.Text = "P.E"
        Me.CkbPe.UseVisualStyleBackColor = True
        '
        'TxbDiferenca
        '
        Me.TxbDiferenca.Location = New System.Drawing.Point(372, 13)
        Me.TxbDiferenca.Name = "TxbDiferenca"
        Me.TxbDiferenca.Size = New System.Drawing.Size(80, 20)
        Me.TxbDiferenca.TabIndex = 4
        Me.TxbDiferenca.Text = "0,00"
        Me.TxbDiferenca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(315, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Diferença:"
        '
        'Dgv
        '
        Me.Dgv.BackgroundColor = System.Drawing.Color.White
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv.Location = New System.Drawing.Point(3, 16)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(458, 380)
        Me.Dgv.TabIndex = 18
        '
        'DgvVenda
        '
        Me.DgvVenda.AllowUserToAddRows = False
        Me.DgvVenda.AllowUserToDeleteRows = False
        Me.DgvVenda.AllowUserToResizeColumns = False
        Me.DgvVenda.AllowUserToResizeRows = False
        Me.DgvVenda.BackgroundColor = System.Drawing.Color.White
        Me.DgvVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvVenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVenda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvVenda.Location = New System.Drawing.Point(236, 97)
        Me.DgvVenda.Name = "DgvVenda"
        Me.DgvVenda.ReadOnly = True
        Me.DgvVenda.RowHeadersVisible = False
        Me.DgvVenda.Size = New System.Drawing.Size(227, 224)
        Me.DgvVenda.TabIndex = 18
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DgvProdutos)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(470, 415)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Produtos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DgvProdutos
        '
        Me.DgvProdutos.AllowUserToAddRows = False
        Me.DgvProdutos.AllowUserToDeleteRows = False
        Me.DgvProdutos.AllowUserToResizeRows = False
        Me.DgvProdutos.BackgroundColor = System.Drawing.Color.White
        Me.DgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvProdutos.Location = New System.Drawing.Point(3, 3)
        Me.DgvProdutos.Name = "DgvProdutos"
        Me.DgvProdutos.ReadOnly = True
        Me.DgvProdutos.RowHeadersVisible = False
        Me.DgvProdutos.Size = New System.Drawing.Size(464, 409)
        Me.DgvProdutos.TabIndex = 18
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DgvServico)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(470, 415)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Servico"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DgvServico
        '
        Me.DgvServico.AllowUserToAddRows = False
        Me.DgvServico.AllowUserToDeleteRows = False
        Me.DgvServico.AllowUserToResizeRows = False
        Me.DgvServico.BackgroundColor = System.Drawing.Color.White
        Me.DgvServico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvServico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvServico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvServico.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvServico.Location = New System.Drawing.Point(3, 3)
        Me.DgvServico.Name = "DgvServico"
        Me.DgvServico.ReadOnly = True
        Me.DgvServico.RowHeadersVisible = False
        Me.DgvServico.Size = New System.Drawing.Size(464, 409)
        Me.DgvServico.TabIndex = 19
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox6)
        Me.TabPage5.Controls.Add(Me.DgvSangria)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(470, 415)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Sangria"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TxbSangriaObs)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Controls.Add(Me.TxbSangriaValor)
        Me.GroupBox6.Controls.Add(Me.BtnSangriaSalvar)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(464, 61)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Sangria"
        '
        'TxbSangriaObs
        '
        Me.TxbSangriaObs.Location = New System.Drawing.Point(74, 35)
        Me.TxbSangriaObs.Multiline = True
        Me.TxbSangriaObs.Name = "TxbSangriaObs"
        Me.TxbSangriaObs.Size = New System.Drawing.Size(384, 20)
        Me.TxbSangriaObs.TabIndex = 2
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(6, 39)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(68, 13)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "Observação:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 13)
        Me.Label29.TabIndex = 6
        Me.Label29.Text = "Valor:"
        '
        'TxbSangriaValor
        '
        Me.TxbSangriaValor.Location = New System.Drawing.Point(74, 12)
        Me.TxbSangriaValor.Name = "TxbSangriaValor"
        Me.TxbSangriaValor.Size = New System.Drawing.Size(100, 20)
        Me.TxbSangriaValor.TabIndex = 1
        Me.TxbSangriaValor.Text = "0,00"
        Me.TxbSangriaValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnSangriaSalvar
        '
        Me.BtnSangriaSalvar.BackColor = System.Drawing.Color.White
        Me.BtnSangriaSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSangriaSalvar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSangriaSalvar.Image = CType(resources.GetObject("BtnSangriaSalvar.Image"), System.Drawing.Image)
        Me.BtnSangriaSalvar.Location = New System.Drawing.Point(427, 8)
        Me.BtnSangriaSalvar.Name = "BtnSangriaSalvar"
        Me.BtnSangriaSalvar.Size = New System.Drawing.Size(31, 24)
        Me.BtnSangriaSalvar.TabIndex = 3
        Me.BtnSangriaSalvar.UseVisualStyleBackColor = False
        '
        'DgvSangria
        '
        Me.DgvSangria.AllowUserToAddRows = False
        Me.DgvSangria.AllowUserToDeleteRows = False
        Me.DgvSangria.AllowUserToResizeRows = False
        Me.DgvSangria.BackgroundColor = System.Drawing.Color.White
        Me.DgvSangria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvSangria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvSangria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSangria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvSangria.Location = New System.Drawing.Point(3, 70)
        Me.DgvSangria.Name = "DgvSangria"
        Me.DgvSangria.ReadOnly = True
        Me.DgvSangria.RowHeadersVisible = False
        Me.DgvSangria.Size = New System.Drawing.Size(464, 342)
        Me.DgvSangria.TabIndex = 20
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DgvNotas)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(470, 415)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Notas"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DgvNotas
        '
        Me.DgvNotas.AllowUserToAddRows = False
        Me.DgvNotas.AllowUserToDeleteRows = False
        Me.DgvNotas.AllowUserToResizeRows = False
        Me.DgvNotas.BackgroundColor = System.Drawing.Color.White
        Me.DgvNotas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvNotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvNotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvNotas.Location = New System.Drawing.Point(0, 0)
        Me.DgvNotas.Name = "DgvNotas"
        Me.DgvNotas.ReadOnly = True
        Me.DgvNotas.RowHeadersVisible = False
        Me.DgvNotas.Size = New System.Drawing.Size(470, 415)
        Me.DgvNotas.TabIndex = 20
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.DgvPagNota)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(470, 415)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "pagamentoNotas"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'DgvPagNota
        '
        Me.DgvPagNota.AllowUserToAddRows = False
        Me.DgvPagNota.AllowUserToDeleteRows = False
        Me.DgvPagNota.AllowUserToResizeRows = False
        Me.DgvPagNota.BackgroundColor = System.Drawing.Color.White
        Me.DgvPagNota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvPagNota.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvPagNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPagNota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPagNota.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvPagNota.Location = New System.Drawing.Point(0, 0)
        Me.DgvPagNota.Name = "DgvPagNota"
        Me.DgvPagNota.ReadOnly = True
        Me.DgvPagNota.RowHeadersVisible = False
        Me.DgvPagNota.Size = New System.Drawing.Size(470, 415)
        Me.DgvPagNota.TabIndex = 21
        '
        'BtnConferido
        '
        Me.BtnConferido.Location = New System.Drawing.Point(6, 46)
        Me.BtnConferido.Name = "BtnConferido"
        Me.BtnConferido.Size = New System.Drawing.Size(137, 25)
        Me.BtnConferido.TabIndex = 8
        Me.BtnConferido.Text = "Conferido"
        Me.BtnConferido.UseVisualStyleBackColor = True
        '
        'BtnExtornar
        '
        Me.BtnExtornar.Location = New System.Drawing.Point(161, 46)
        Me.BtnExtornar.Name = "BtnExtornar"
        Me.BtnExtornar.Size = New System.Drawing.Size(137, 25)
        Me.BtnExtornar.TabIndex = 9
        Me.BtnExtornar.Text = "Extornar"
        Me.BtnExtornar.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(470, 415)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Duplicata"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'FrmFechamentoCaixaPdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(632, 472)
        Me.Controls.Add(Me.TrvFechamento)
        Me.Name = "FrmFechamentoCaixaPdv"
        Me.Text = "FrmFechamentoCaixaPdv"
        Me.Controls.SetChildIndex(Me.TrvFechamento, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvRecebimento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DgvServico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DgvSangria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        CType(Me.DgvPagNota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxbCodOperador As Controles.TxbCodigo
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbSeqFechamento As Controles.TxbCodigo
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbHraFechamento As Controles.TxbCodigo
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbhraAbertura As Controles.TxbCodigo
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbNumFechamento As Controles.TxbCodigo
    Friend WithEvents Label1 As Label
    Friend WithEvents TxbNomOperador As Controles.TxbDescricao
    Friend WithEvents DgvRecebimento As DataGridView
    Friend WithEvents TrvFechamento As TreeView
    Friend WithEvents BtnDtaFinal As Button
    Friend WithEvents TxbDtaFechamento As Controles.TxbData
    Friend WithEvents DtpDtaFechamento As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxbDiferenca As Controles.TxbMonetario
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CkbPe As CheckBox
    Friend WithEvents RbAberto As RadioButton
    Friend WithEvents RbFechado As RadioButton
    Friend WithEvents RbConferido As RadioButton
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents DgvVenda As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DgvProdutos As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DgvServico As DataGridView
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents DgvSangria As DataGridView
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents DgvNotas As DataGridView
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents DgvPagNota As DataGridView
    Friend WithEvents BtnExtornar As Button
    Friend WithEvents BtnConferido As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents TxbSangriaObs As Controles.TxbDescricao
    Friend WithEvents TxbSangriaValor As Controles.TxbMonetario
    Protected WithEvents BtnSangriaSalvar As Button
    Friend WithEvents TabPage8 As TabPage
End Class
