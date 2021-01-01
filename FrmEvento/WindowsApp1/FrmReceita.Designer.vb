<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReceita))
        Me.BtnPrincipal = New System.Windows.Forms.Button()
        Me.BtnPagamento = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnUltimoReg = New System.Windows.Forms.Button()
        Me.BtnProximo = New System.Windows.Forms.Button()
        Me.BtnPrimeiroReg = New System.Windows.Forms.Button()
        Me.BtnCsv = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnGrid = New System.Windows.Forms.Button()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxbSeq = New Controles.TxbCodigo()
        Me.txbNumero = New Controles.TxbCodigo()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnBuscaTipo = New System.Windows.Forms.Button()
        Me.TxbDesTipo = New System.Windows.Forms.TextBox()
        Me.TxbCodTipo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BtnBuscaCliente = New System.Windows.Forms.Button()
        Me.TxbNomCliente = New System.Windows.Forms.TextBox()
        Me.TxbCodCliente = New System.Windows.Forms.TextBox()
        Me.TxbDta = New Controles.TxbData()
        Me.DtpDta = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxbValor = New Controles.TxbMonetario()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxbObservacao = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxbNumNfs = New Controles.TxbCodigo()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxbCodigoNfs = New Controles.TxbCodigo()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnPrincipal
        '
        Me.BtnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrincipal.Location = New System.Drawing.Point(6, 52)
        Me.BtnPrincipal.Name = "BtnPrincipal"
        Me.BtnPrincipal.Size = New System.Drawing.Size(120, 26)
        Me.BtnPrincipal.TabIndex = 37
        Me.BtnPrincipal.Text = "Principal"
        Me.BtnPrincipal.UseVisualStyleBackColor = True
        '
        'BtnPagamento
        '
        Me.BtnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagamento.Location = New System.Drawing.Point(6, 79)
        Me.BtnPagamento.Name = "BtnPagamento"
        Me.BtnPagamento.Size = New System.Drawing.Size(120, 26)
        Me.BtnPagamento.TabIndex = 38
        Me.BtnPagamento.Text = "Pagamento"
        Me.BtnPagamento.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.BtnUltimoReg)
        Me.GroupBox2.Controls.Add(Me.BtnProximo)
        Me.GroupBox2.Controls.Add(Me.BtnPrimeiroReg)
        Me.GroupBox2.Controls.Add(Me.BtnCsv)
        Me.GroupBox2.Controls.Add(Me.BtnAnterior)
        Me.GroupBox2.Controls.Add(Me.BtnGrid)
        Me.GroupBox2.Controls.Add(Me.BtnPesquisa)
        Me.GroupBox2.Controls.Add(Me.BtnLimpar)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.Controls.Add(Me.BtnExcluir)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(2, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(638, 46)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'BtnUltimoReg
        '
        Me.BtnUltimoReg.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnUltimoReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnUltimoReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUltimoReg.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUltimoReg.Image = CType(resources.GetObject("BtnUltimoReg.Image"), System.Drawing.Image)
        Me.BtnUltimoReg.Location = New System.Drawing.Point(294, 10)
        Me.BtnUltimoReg.Name = "BtnUltimoReg"
        Me.BtnUltimoReg.Size = New System.Drawing.Size(31, 31)
        Me.BtnUltimoReg.TabIndex = 11
        Me.BtnUltimoReg.UseVisualStyleBackColor = True
        '
        'BtnProximo
        '
        Me.BtnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProximo.ForeColor = System.Drawing.Color.Transparent
        Me.BtnProximo.Image = CType(resources.GetObject("BtnProximo.Image"), System.Drawing.Image)
        Me.BtnProximo.Location = New System.Drawing.Point(273, 11)
        Me.BtnProximo.Name = "BtnProximo"
        Me.BtnProximo.Size = New System.Drawing.Size(31, 31)
        Me.BtnProximo.TabIndex = 10
        Me.BtnProximo.UseVisualStyleBackColor = True
        '
        'BtnPrimeiroReg
        '
        Me.BtnPrimeiroReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrimeiroReg.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPrimeiroReg.Image = CType(resources.GetObject("BtnPrimeiroReg.Image"), System.Drawing.Image)
        Me.BtnPrimeiroReg.Location = New System.Drawing.Point(223, 10)
        Me.BtnPrimeiroReg.Name = "BtnPrimeiroReg"
        Me.BtnPrimeiroReg.Size = New System.Drawing.Size(31, 31)
        Me.BtnPrimeiroReg.TabIndex = 8
        Me.BtnPrimeiroReg.UseVisualStyleBackColor = True
        '
        'BtnCsv
        '
        Me.BtnCsv.BackColor = System.Drawing.Color.Transparent
        Me.BtnCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCsv.ForeColor = System.Drawing.Color.Black
        Me.BtnCsv.Location = New System.Drawing.Point(185, 15)
        Me.BtnCsv.Name = "BtnCsv"
        Me.BtnCsv.Size = New System.Drawing.Size(32, 23)
        Me.BtnCsv.TabIndex = 7
        Me.BtnCsv.Text = "CSV"
        Me.BtnCsv.UseVisualStyleBackColor = False
        '
        'BtnAnterior
        '
        Me.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnterior.ForeColor = System.Drawing.Color.Transparent
        Me.BtnAnterior.Image = CType(resources.GetObject("BtnAnterior.Image"), System.Drawing.Image)
        Me.BtnAnterior.Location = New System.Drawing.Point(244, 10)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(31, 31)
        Me.BtnAnterior.TabIndex = 9
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnGrid
        '
        Me.BtnGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrid.ForeColor = System.Drawing.Color.Transparent
        Me.BtnGrid.Image = CType(resources.GetObject("BtnGrid.Image"), System.Drawing.Image)
        Me.BtnGrid.Location = New System.Drawing.Point(148, 10)
        Me.BtnGrid.Name = "BtnGrid"
        Me.BtnGrid.Size = New System.Drawing.Size(31, 31)
        Me.BtnGrid.TabIndex = 6
        Me.BtnGrid.UseVisualStyleBackColor = True
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisa.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesquisa.Image = CType(resources.GetObject("BtnPesquisa.Image"), System.Drawing.Image)
        Me.BtnPesquisa.Location = New System.Drawing.Point(74, 8)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(31, 31)
        Me.BtnPesquisa.TabIndex = 4
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLimpar.Image = CType(resources.GetObject("BtnLimpar.Image"), System.Drawing.Image)
        Me.BtnLimpar.Location = New System.Drawing.Point(108, 10)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(31, 31)
        Me.BtnLimpar.TabIndex = 5
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.White
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(6, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(31, 31)
        Me.BtnSalvar.TabIndex = 2
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'BtnExcluir
        '
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluir.ForeColor = System.Drawing.Color.Transparent
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.Location = New System.Drawing.Point(40, 10)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(31, 31)
        Me.BtnExcluir.TabIndex = 3
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(128, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(513, 190)
        Me.TabControl1.TabIndex = 36
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(505, 164)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.TxbSeq)
        Me.GroupBox4.Controls.Add(Me.txbNumero)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.BtnBuscaTipo)
        Me.GroupBox4.Controls.Add(Me.TxbDesTipo)
        Me.GroupBox4.Controls.Add(Me.TxbCodTipo)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.BtnBuscaCliente)
        Me.GroupBox4.Controls.Add(Me.TxbNomCliente)
        Me.GroupBox4.Controls.Add(Me.TxbCodCliente)
        Me.GroupBox4.Controls.Add(Me.TxbDta)
        Me.GroupBox4.Controls.Add(Me.DtpDta)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.TxbValor)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TxbObservacao)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(492, 112)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        '
        'TxbSeq
        '
        Me.TxbSeq.Location = New System.Drawing.Point(76, 16)
        Me.TxbSeq.Name = "TxbSeq"
        Me.TxbSeq.Size = New System.Drawing.Size(52, 20)
        Me.TxbSeq.TabIndex = 41
        '
        'txbNumero
        '
        Me.txbNumero.Location = New System.Drawing.Point(323, 16)
        Me.txbNumero.Name = "txbNumero"
        Me.txbNumero.Size = New System.Drawing.Size(66, 20)
        Me.txbNumero.TabIndex = 43
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bernard MT Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Location = New System.Drawing.Point(247, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 20)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "F"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(460, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(23, 20)
        Me.Button2.TabIndex = 61
        Me.Button2.Tag = ""
        Me.Button2.Text = "C"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DimGray
        Me.Button3.Location = New System.Drawing.Point(460, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(23, 20)
        Me.Button3.TabIndex = 60
        Me.Button3.Tag = ""
        Me.Button3.Text = "C"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Tipo:"
        '
        'BtnBuscaTipo
        '
        Me.BtnBuscaTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaTipo.ForeColor = System.Drawing.Color.DimGray
        Me.BtnBuscaTipo.Image = CType(resources.GetObject("BtnBuscaTipo.Image"), System.Drawing.Image)
        Me.BtnBuscaTipo.Location = New System.Drawing.Point(434, 62)
        Me.BtnBuscaTipo.Name = "BtnBuscaTipo"
        Me.BtnBuscaTipo.Size = New System.Drawing.Size(23, 20)
        Me.BtnBuscaTipo.TabIndex = 56
        Me.BtnBuscaTipo.UseVisualStyleBackColor = True
        '
        'TxbDesTipo
        '
        Me.TxbDesTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesTipo.Location = New System.Drawing.Point(134, 62)
        Me.TxbDesTipo.Name = "TxbDesTipo"
        Me.TxbDesTipo.Size = New System.Drawing.Size(297, 20)
        Me.TxbDesTipo.TabIndex = 55
        '
        'TxbCodTipo
        '
        Me.TxbCodTipo.Location = New System.Drawing.Point(76, 62)
        Me.TxbCodTipo.Name = "TxbCodTipo"
        Me.TxbCodTipo.Size = New System.Drawing.Size(52, 20)
        Me.TxbCodTipo.TabIndex = 54
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 13)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "Cliente:"
        '
        'BtnBuscaCliente
        '
        Me.BtnBuscaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaCliente.ForeColor = System.Drawing.Color.DimGray
        Me.BtnBuscaCliente.Image = CType(resources.GetObject("BtnBuscaCliente.Image"), System.Drawing.Image)
        Me.BtnBuscaCliente.Location = New System.Drawing.Point(434, 39)
        Me.BtnBuscaCliente.Name = "BtnBuscaCliente"
        Me.BtnBuscaCliente.Size = New System.Drawing.Size(23, 20)
        Me.BtnBuscaCliente.TabIndex = 52
        Me.BtnBuscaCliente.UseVisualStyleBackColor = True
        '
        'TxbNomCliente
        '
        Me.TxbNomCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomCliente.Location = New System.Drawing.Point(134, 39)
        Me.TxbNomCliente.Name = "TxbNomCliente"
        Me.TxbNomCliente.Size = New System.Drawing.Size(297, 20)
        Me.TxbNomCliente.TabIndex = 51
        '
        'TxbCodCliente
        '
        Me.TxbCodCliente.Location = New System.Drawing.Point(76, 39)
        Me.TxbCodCliente.Name = "TxbCodCliente"
        Me.TxbCodCliente.Size = New System.Drawing.Size(52, 20)
        Me.TxbCodCliente.TabIndex = 50
        '
        'TxbDta
        '
        Me.TxbDta.Location = New System.Drawing.Point(163, 16)
        Me.TxbDta.MaxLength = 10
        Me.TxbDta.Name = "TxbDta"
        Me.TxbDta.Size = New System.Drawing.Size(66, 20)
        Me.TxbDta.TabIndex = 47
        '
        'DtpDta
        '
        Me.DtpDta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDta.Location = New System.Drawing.Point(231, 16)
        Me.DtpDta.Name = "DtpDta"
        Me.DtpDta.Size = New System.Drawing.Size(14, 20)
        Me.DtpDta.TabIndex = 49
        Me.DtpDta.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(131, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Data:"
        '
        'TxbValor
        '
        Me.TxbValor.Location = New System.Drawing.Point(423, 16)
        Me.TxbValor.Name = "TxbValor"
        Me.TxbValor.Size = New System.Drawing.Size(60, 20)
        Me.TxbValor.TabIndex = 46
        Me.TxbValor.Text = "0,00"
        Me.TxbValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(390, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Valor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Número:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Sequência:"
        '
        'TxbObservacao
        '
        Me.TxbObservacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxbObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbObservacao.Location = New System.Drawing.Point(76, 85)
        Me.TxbObservacao.Name = "TxbObservacao"
        Me.TxbObservacao.Size = New System.Drawing.Size(407, 20)
        Me.TxbObservacao.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 89)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Observação:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxbNumNfs)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxbCodigoNfs)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 43)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nota Fiscal Saída"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Número:"
        '
        'TxbNumNfs
        '
        Me.TxbNumNfs.Location = New System.Drawing.Point(207, 19)
        Me.TxbNumNfs.Name = "TxbNumNfs"
        Me.TxbNumNfs.Size = New System.Drawing.Size(66, 20)
        Me.TxbNumNfs.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Sequência:"
        '
        'TxbCodigoNfs
        '
        Me.TxbCodigoNfs.Location = New System.Drawing.Point(78, 19)
        Me.TxbCodigoNfs.Name = "TxbCodigoNfs"
        Me.TxbCodigoNfs.Size = New System.Drawing.Size(66, 20)
        Me.TxbCodigoNfs.TabIndex = 45
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(505, 164)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Dgv)
        Me.GroupBox3.Location = New System.Drawing.Point(3, -3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(499, 163)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'Dgv
        '
        Me.Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Location = New System.Drawing.Point(0, 9)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(498, 149)
        Me.Dgv.TabIndex = 10
        '
        'FrmReceita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(646, 215)
        Me.Controls.Add(Me.BtnPrincipal)
        Me.Controls.Add(Me.BtnPagamento)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmReceita"
        Me.Text = "FrmReceita"
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnPrincipal As Button
    Friend WithEvents BtnPagamento As Button
    Protected WithEvents GroupBox2 As GroupBox
    Protected WithEvents BtnUltimoReg As Button
    Protected WithEvents BtnProximo As Button
    Protected WithEvents BtnPrimeiroReg As Button
    Protected WithEvents BtnCsv As Button
    Protected WithEvents BtnAnterior As Button
    Protected WithEvents BtnGrid As Button
    Protected WithEvents BtnPesquisa As Button
    Protected WithEvents BtnLimpar As Button
    Protected WithEvents BtnSalvar As Button
    Protected WithEvents BtnExcluir As Button
    Protected WithEvents TabControl1 As TabControl
    Public WithEvents TabPage1 As TabPage
    Public WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnBuscaTipo As Button
    Friend WithEvents TxbDesTipo As TextBox
    Friend WithEvents TxbCodTipo As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnBuscaCliente As Button
    Friend WithEvents TxbNomCliente As TextBox
    Friend WithEvents TxbCodCliente As TextBox
    Friend WithEvents TxbDta As Controles.TxbData
    Friend WithEvents DtpDta As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TxbValor As Controles.TxbMonetario
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txbNumero As Controles.TxbCodigo
    Friend WithEvents Label1 As Label
    Friend WithEvents TxbSeq As Controles.TxbCodigo
    Protected WithEvents TxbObservacao As TextBox
    Protected WithEvents Label18 As Label
    Protected WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbNumNfs As Controles.TxbCodigo
    Friend WithEvents Label6 As Label
    Friend WithEvents TxbCodigoNfs As Controles.TxbCodigo
    Public WithEvents TabPage2 As TabPage
    Protected WithEvents GroupBox3 As GroupBox
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
End Class
