<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgendaServico
    Inherits Controles.FrmPadrao

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgendaServico))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxbValServico = New Controles.TxbMonetario()
        Me.TxbCodFuncionario = New Controles.TxbCodigo()
        Me.LbValservico = New System.Windows.Forms.Label()
        Me.CkbExecutado = New System.Windows.Forms.CheckBox()
        Me.TxbObservacao = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxbSeqAgenda = New Controles.TxbCodigo()
        Me.BtnCadFuncionario = New System.Windows.Forms.Button()
        Me.BtnCadCliente = New System.Windows.Forms.Button()
        Me.cbHora = New System.Windows.Forms.ComboBox()
        Me.TxbDtaAgenda = New Controles.TxbData()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbMinuto = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.TxbNomCliente = New System.Windows.Forms.TextBox()
        Me.TxbCodCliente = New Controles.TxbCodigo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnFuncionario = New System.Windows.Forms.Button()
        Me.TxbNomFuncionario = New System.Windows.Forms.TextBox()
        Me.BtnRelatorio = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnGrid = New System.Windows.Forms.Button()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Dgv1 = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DgvHora = New System.Windows.Forms.DataGridView()
        Me.MCDataAgenda = New System.Windows.Forms.MonthCalendar()
        Me.BtnGridPrincipal = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ClRelAgendaServicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DgvHora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClRelAgendaServicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TxbValServico)
        Me.GroupBox1.Controls.Add(Me.TxbCodFuncionario)
        Me.GroupBox1.Controls.Add(Me.LbValservico)
        Me.GroupBox1.Controls.Add(Me.CkbExecutado)
        Me.GroupBox1.Controls.Add(Me.TxbObservacao)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxbSeqAgenda)
        Me.GroupBox1.Controls.Add(Me.BtnCadFuncionario)
        Me.GroupBox1.Controls.Add(Me.BtnCadCliente)
        Me.GroupBox1.Controls.Add(Me.cbHora)
        Me.GroupBox1.Controls.Add(Me.TxbDtaAgenda)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CbMinuto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnCliente)
        Me.GroupBox1.Controls.Add(Me.TxbNomCliente)
        Me.GroupBox1.Controls.Add(Me.TxbCodCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnFuncionario)
        Me.GroupBox1.Controls.Add(Me.TxbNomFuncionario)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agenda"
        '
        'TxbValServico
        '
        Me.TxbValServico.Location = New System.Drawing.Point(357, 84)
        Me.TxbValServico.Name = "TxbValServico"
        Me.TxbValServico.Size = New System.Drawing.Size(82, 20)
        Me.TxbValServico.TabIndex = 72
        Me.TxbValServico.Text = "0,00"
        Me.TxbValServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbCodFuncionario
        '
        Me.TxbCodFuncionario.Location = New System.Drawing.Point(70, 60)
        Me.TxbCodFuncionario.Name = "TxbCodFuncionario"
        Me.TxbCodFuncionario.Size = New System.Drawing.Size(61, 20)
        Me.TxbCodFuncionario.TabIndex = 9
        '
        'LbValservico
        '
        Me.LbValservico.AutoSize = True
        Me.LbValservico.Location = New System.Drawing.Point(287, 87)
        Me.LbValservico.Name = "LbValservico"
        Me.LbValservico.Size = New System.Drawing.Size(73, 13)
        Me.LbValservico.TabIndex = 12
        Me.LbValservico.Text = "Valor Serviço:"
        '
        'CkbExecutado
        '
        Me.CkbExecutado.AutoSize = True
        Me.CkbExecutado.Location = New System.Drawing.Point(517, 87)
        Me.CkbExecutado.Name = "CkbExecutado"
        Me.CkbExecutado.Size = New System.Drawing.Size(129, 17)
        Me.CkbExecutado.TabIndex = 14
        Me.CkbExecutado.Text = "Executado/Finalizado"
        Me.CkbExecutado.UseVisualStyleBackColor = True
        '
        'TxbObservacao
        '
        Me.TxbObservacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxbObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbObservacao.Location = New System.Drawing.Point(517, 14)
        Me.TxbObservacao.Multiline = True
        Me.TxbObservacao.Name = "TxbObservacao"
        Me.TxbObservacao.Size = New System.Drawing.Size(225, 63)
        Me.TxbObservacao.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Sequencia:"
        Me.Label7.Visible = False
        '
        'TxbSeqAgenda
        '
        Me.TxbSeqAgenda.Location = New System.Drawing.Point(70, 83)
        Me.TxbSeqAgenda.Name = "TxbSeqAgenda"
        Me.TxbSeqAgenda.Size = New System.Drawing.Size(61, 20)
        Me.TxbSeqAgenda.TabIndex = 0
        Me.TxbSeqAgenda.Visible = False
        '
        'BtnCadFuncionario
        '
        Me.BtnCadFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadFuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadFuncionario.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnCadFuncionario.Location = New System.Drawing.Point(414, 60)
        Me.BtnCadFuncionario.Name = "BtnCadFuncionario"
        Me.BtnCadFuncionario.Size = New System.Drawing.Size(25, 20)
        Me.BtnCadFuncionario.TabIndex = 12
        Me.BtnCadFuncionario.Text = "C"
        Me.BtnCadFuncionario.UseVisualStyleBackColor = True
        '
        'BtnCadCliente
        '
        Me.BtnCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadCliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnCadCliente.Location = New System.Drawing.Point(414, 37)
        Me.BtnCadCliente.Name = "BtnCadCliente"
        Me.BtnCadCliente.Size = New System.Drawing.Size(25, 20)
        Me.BtnCadCliente.TabIndex = 8
        Me.BtnCadCliente.Text = "C"
        Me.BtnCadCliente.UseVisualStyleBackColor = True
        '
        'cbHora
        '
        Me.cbHora.FormatString = "N0"
        Me.cbHora.FormattingEnabled = True
        Me.cbHora.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbHora.Location = New System.Drawing.Point(357, 13)
        Me.cbHora.MaxLength = 2
        Me.cbHora.Name = "cbHora"
        Me.cbHora.Size = New System.Drawing.Size(37, 21)
        Me.cbHora.TabIndex = 3
        '
        'TxbDtaAgenda
        '
        Me.TxbDtaAgenda.Location = New System.Drawing.Point(70, 14)
        Me.TxbDtaAgenda.MaxLength = 10
        Me.TxbDtaAgenda.Name = "TxbDtaAgenda"
        Me.TxbDtaAgenda.Size = New System.Drawing.Size(96, 20)
        Me.TxbDtaAgenda.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(450, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Observação:"
        '
        'CbMinuto
        '
        Me.CbMinuto.FormatString = "N0"
        Me.CbMinuto.FormattingEnabled = True
        Me.CbMinuto.Items.AddRange(New Object() {"00", "30"})
        Me.CbMinuto.Location = New System.Drawing.Point(402, 13)
        Me.CbMinuto.MaxLength = 2
        Me.CbMinuto.Name = "CbMinuto"
        Me.CbMinuto.Size = New System.Drawing.Size(37, 21)
        Me.CbMinuto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(391, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 19)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(327, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Hora:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Data:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Cliente:"
        '
        'BtnCliente
        '
        Me.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnCliente.Image = CType(resources.GetObject("BtnCliente.Image"), System.Drawing.Image)
        Me.BtnCliente.Location = New System.Drawing.Point(387, 37)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(25, 20)
        Me.BtnCliente.TabIndex = 7
        Me.BtnCliente.UseVisualStyleBackColor = True
        '
        'TxbNomCliente
        '
        Me.TxbNomCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomCliente.Location = New System.Drawing.Point(133, 37)
        Me.TxbNomCliente.Name = "TxbNomCliente"
        Me.TxbNomCliente.Size = New System.Drawing.Size(252, 20)
        Me.TxbNomCliente.TabIndex = 6
        '
        'TxbCodCliente
        '
        Me.TxbCodCliente.Location = New System.Drawing.Point(70, 37)
        Me.TxbCodCliente.Name = "TxbCodCliente"
        Me.TxbCodCliente.Size = New System.Drawing.Size(61, 20)
        Me.TxbCodCliente.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Funcionario:"
        '
        'BtnFuncionario
        '
        Me.BtnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFuncionario.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnFuncionario.Image = CType(resources.GetObject("BtnFuncionario.Image"), System.Drawing.Image)
        Me.BtnFuncionario.Location = New System.Drawing.Point(387, 60)
        Me.BtnFuncionario.Name = "BtnFuncionario"
        Me.BtnFuncionario.Size = New System.Drawing.Size(25, 20)
        Me.BtnFuncionario.TabIndex = 11
        Me.BtnFuncionario.UseVisualStyleBackColor = True
        '
        'TxbNomFuncionario
        '
        Me.TxbNomFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomFuncionario.Location = New System.Drawing.Point(133, 60)
        Me.TxbNomFuncionario.Name = "TxbNomFuncionario"
        Me.TxbNomFuncionario.Size = New System.Drawing.Size(252, 20)
        Me.TxbNomFuncionario.TabIndex = 10
        '
        'BtnRelatorio
        '
        Me.BtnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRelatorio.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnRelatorio.Location = New System.Drawing.Point(4, 258)
        Me.BtnRelatorio.Name = "BtnRelatorio"
        Me.BtnRelatorio.Size = New System.Drawing.Size(227, 35)
        Me.BtnRelatorio.TabIndex = 73
        Me.BtnRelatorio.Text = "Relatório Agenda"
        Me.BtnRelatorio.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.BtnGrid)
        Me.GroupBox2.Controls.Add(Me.BtnPesquisa)
        Me.GroupBox2.Controls.Add(Me.BtnLimpar)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.Controls.Add(Me.BtnExcluir)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(233, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(771, 46)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
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
        'Dgv
        '
        Me.Dgv.BackgroundColor = System.Drawing.Color.White
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv.Location = New System.Drawing.Point(3, 3)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(758, 397)
        Me.Dgv.TabIndex = 22
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(233, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(772, 429)
        Me.TabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Dgv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(764, 403)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(764, 403)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsRel"
        ReportDataSource1.Value = Me.ClRelAgendaServicoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApp1.RelAgendaServico.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(758, 397)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Dgv1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(764, 403)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Dgv1
        '
        Me.Dgv1.AllowUserToAddRows = False
        Me.Dgv1.AllowUserToDeleteRows = False
        Me.Dgv1.BackgroundColor = System.Drawing.Color.White
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv1.Location = New System.Drawing.Point(3, 3)
        Me.Dgv1.MultiSelect = False
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.ReadOnly = True
        Me.Dgv1.Size = New System.Drawing.Size(758, 397)
        Me.Dgv1.TabIndex = 23
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DgvHora)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(764, 403)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DgvHora
        '
        Me.DgvHora.AllowUserToAddRows = False
        Me.DgvHora.AllowUserToDeleteRows = False
        Me.DgvHora.BackgroundColor = System.Drawing.Color.White
        Me.DgvHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHora.GridColor = System.Drawing.Color.White
        Me.DgvHora.Location = New System.Drawing.Point(6, 135)
        Me.DgvHora.Name = "DgvHora"
        Me.DgvHora.Size = New System.Drawing.Size(439, 158)
        Me.DgvHora.TabIndex = 1
        '
        'MCDataAgenda
        '
        Me.MCDataAgenda.Location = New System.Drawing.Point(4, 8)
        Me.MCDataAgenda.Name = "MCDataAgenda"
        Me.MCDataAgenda.TabIndex = 74
        '
        'BtnGridPrincipal
        '
        Me.BtnGridPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGridPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGridPrincipal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnGridPrincipal.Location = New System.Drawing.Point(4, 176)
        Me.BtnGridPrincipal.Name = "BtnGridPrincipal"
        Me.BtnGridPrincipal.Size = New System.Drawing.Size(227, 35)
        Me.BtnGridPrincipal.TabIndex = 75
        Me.BtnGridPrincipal.Text = "Grid Principal"
        Me.BtnGridPrincipal.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button2.Location = New System.Drawing.Point(4, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(227, 35)
        Me.Button2.TabIndex = 76
        Me.Button2.Text = "Cadastro"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ClRelAgendaServicoBindingSource
        '
        Me.ClRelAgendaServicoBindingSource.DataSource = GetType(WindowsApp1.ClRelAgendaServico)
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.Location = New System.Drawing.Point(4, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 35)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Relatório Comissão"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmAgendaServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1006, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnGridPrincipal)
        Me.Controls.Add(Me.BtnRelatorio)
        Me.Controls.Add(Me.MCDataAgenda)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmAgendaServico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DgvHora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClRelAgendaServicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCliente As Button
    Friend WithEvents TxbNomCliente As TextBox
    Friend WithEvents TxbCodCliente As Controles.TxbCodigo
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnFuncionario As Button
    Friend WithEvents TxbNomFuncionario As TextBox
    Friend WithEvents TxbCodFuncionario As Controles.TxbCodigo
    Friend WithEvents TxbDtaAgenda As Controles.TxbData
    Friend WithEvents Label8 As Label
    Friend WithEvents CbMinuto As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbHora As ComboBox
    Friend WithEvents Label3 As Label
    Protected WithEvents GroupBox2 As GroupBox
    Protected WithEvents BtnGrid As Button
    Protected WithEvents BtnPesquisa As Button
    Protected WithEvents BtnLimpar As Button
    Protected WithEvents BtnSalvar As Button
    Protected WithEvents BtnExcluir As Button
    Friend WithEvents Dgv As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbObservacao As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxbSeqAgenda As Controles.TxbCodigo
    Friend WithEvents BtnCadFuncionario As Button
    Friend WithEvents BtnCadCliente As Button
    Friend WithEvents CkbExecutado As CheckBox
    Friend WithEvents LbValservico As Label
    Friend WithEvents BtnRelatorio As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClRelAgendaServicoBindingSource As BindingSource
    Friend WithEvents MCDataAgenda As MonthCalendar
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Dgv1 As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents BtnGridPrincipal As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TxbValServico As Controles.TxbMonetario
    Friend WithEvents DgvHora As DataGridView
    Friend WithEvents Button1 As Button
End Class
