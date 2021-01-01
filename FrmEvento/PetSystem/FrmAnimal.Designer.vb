<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAnimal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnimal))
        Me.BtnControleParasitario = New System.Windows.Forms.Button()
        Me.BtnVacina = New System.Windows.Forms.Button()
        Me.BtnPrincipal = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxbCodAnimal = New Controles.TxbCodigo()
        Me.TxbCodEspecie = New Controles.TxbCodigo()
        Me.TxbCodPelagem = New Controles.TxbCodigo()
        Me.txbcodRaca = New Controles.TxbCodigo()
        Me.TxbCodProprietario = New Controles.TxbCodigo()
        Me.TxbDtaNasc = New Controles.TxbData()
        Me.BtnPesquisaPelagem = New System.Windows.Forms.Button()
        Me.TxbDesPelagem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RbFemea = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RbMacho = New System.Windows.Forms.RadioButton()
        Me.BtnPesquisaRaca = New System.Windows.Forms.Button()
        Me.TxbDesRaca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPesquisaEspecie = New System.Windows.Forms.Button()
        Me.TxbDesEspecie = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnProprietario = New System.Windows.Forms.Button()
        Me.TxbObservacao = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DtpDtaNasc = New System.Windows.Forms.DateTimePicker()
        Me.TxbNomAnimal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxbNomProprietario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LbSeqVacina = New System.Windows.Forms.Label()
        Me.TxbCodVacina = New Controles.TxbCodigo()
        Me.TxbDtaVacina = New Controles.TxbData()
        Me.DtpDtaVacina = New System.Windows.Forms.DateTimePicker()
        Me.BtnLimpaVacina = New System.Windows.Forms.Button()
        Me.BtnSalvaVacina = New System.Windows.Forms.Button()
        Me.BtnExcluirVacina = New System.Windows.Forms.Button()
        Me.RbVacNao = New System.Windows.Forms.RadioButton()
        Me.RbVacSim = New System.Windows.Forms.RadioButton()
        Me.BtnPesquisaVacina = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxbDesVacina = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DgvVacina = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DgvContParasitario = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxbPesoParasita = New Controles.TxbMonetario()
        Me.TxbDoseParasita = New System.Windows.Forms.TextBox()
        Me.TxbCodParasita = New Controles.TxbCodigo()
        Me.TxbDtaProximaParasita = New Controles.TxbData()
        Me.DtpProximaParasita = New System.Windows.Forms.DateTimePicker()
        Me.TxbDtaParasita = New Controles.TxbData()
        Me.DtpDtaParasita = New System.Windows.Forms.DateTimePicker()
        Me.BtnLimparParasita = New System.Windows.Forms.Button()
        Me.BtnSalvaParasita = New System.Windows.Forms.Button()
        Me.BtnExcluirParasita = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnPesquisaParasita = New System.Windows.Forms.Button()
        Me.TxbDesParasita = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LbSeqParasita = New System.Windows.Forms.Label()
        Me.GbNavegador = New System.Windows.Forms.GroupBox()
        Me.BtnCsv = New System.Windows.Forms.Button()
        Me.BtnUltimoReg = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnProximo = New System.Windows.Forms.Button()
        Me.BtnPrimeiroReg = New System.Windows.Forms.Button()
        Me.BtnGrid = New System.Windows.Forms.Button()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DgvVacina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DgvContParasitario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GbNavegador.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnControleParasitario
        '
        Me.BtnControleParasitario.Location = New System.Drawing.Point(10, 134)
        Me.BtnControleParasitario.Name = "BtnControleParasitario"
        Me.BtnControleParasitario.Size = New System.Drawing.Size(107, 28)
        Me.BtnControleParasitario.TabIndex = 3
        Me.BtnControleParasitario.Text = "Controle Parasitário"
        Me.BtnControleParasitario.UseVisualStyleBackColor = True
        '
        'BtnVacina
        '
        Me.BtnVacina.Location = New System.Drawing.Point(10, 104)
        Me.BtnVacina.Name = "BtnVacina"
        Me.BtnVacina.Size = New System.Drawing.Size(107, 28)
        Me.BtnVacina.TabIndex = 2
        Me.BtnVacina.Text = "Vacina"
        Me.BtnVacina.UseVisualStyleBackColor = True
        '
        'BtnPrincipal
        '
        Me.BtnPrincipal.Location = New System.Drawing.Point(10, 74)
        Me.BtnPrincipal.Name = "BtnPrincipal"
        Me.BtnPrincipal.Size = New System.Drawing.Size(107, 28)
        Me.BtnPrincipal.TabIndex = 1
        Me.BtnPrincipal.Text = "Principal"
        Me.BtnPrincipal.UseVisualStyleBackColor = True
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
        Me.TabControl1.Location = New System.Drawing.Point(123, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(465, 243)
        Me.TabControl1.TabIndex = 24
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(457, 217)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Principal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxbCodAnimal)
        Me.GroupBox1.Controls.Add(Me.TxbCodEspecie)
        Me.GroupBox1.Controls.Add(Me.TxbCodPelagem)
        Me.GroupBox1.Controls.Add(Me.txbcodRaca)
        Me.GroupBox1.Controls.Add(Me.TxbCodProprietario)
        Me.GroupBox1.Controls.Add(Me.TxbDtaNasc)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisaPelagem)
        Me.GroupBox1.Controls.Add(Me.TxbDesPelagem)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RbFemea)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RbMacho)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisaRaca)
        Me.GroupBox1.Controls.Add(Me.TxbDesRaca)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisaEspecie)
        Me.GroupBox1.Controls.Add(Me.TxbDesEspecie)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.BtnProprietario)
        Me.GroupBox1.Controls.Add(Me.TxbObservacao)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.DtpDtaNasc)
        Me.GroupBox1.Controls.Add(Me.TxbNomAnimal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxbNomProprietario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 209)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Principal"
        '
        'TxbCodAnimal
        '
        Me.TxbCodAnimal.Location = New System.Drawing.Point(77, 12)
        Me.TxbCodAnimal.Name = "TxbCodAnimal"
        Me.TxbCodAnimal.Size = New System.Drawing.Size(55, 20)
        Me.TxbCodAnimal.TabIndex = 57
        '
        'TxbCodEspecie
        '
        Me.TxbCodEspecie.Location = New System.Drawing.Point(77, 81)
        Me.TxbCodEspecie.Name = "TxbCodEspecie"
        Me.TxbCodEspecie.Size = New System.Drawing.Size(55, 20)
        Me.TxbCodEspecie.TabIndex = 56
        '
        'TxbCodPelagem
        '
        Me.TxbCodPelagem.Location = New System.Drawing.Point(77, 127)
        Me.TxbCodPelagem.Name = "TxbCodPelagem"
        Me.TxbCodPelagem.Size = New System.Drawing.Size(55, 20)
        Me.TxbCodPelagem.TabIndex = 15
        '
        'txbcodRaca
        '
        Me.txbcodRaca.Location = New System.Drawing.Point(77, 104)
        Me.txbcodRaca.Name = "txbcodRaca"
        Me.txbcodRaca.Size = New System.Drawing.Size(55, 20)
        Me.txbcodRaca.TabIndex = 12
        '
        'TxbCodProprietario
        '
        Me.TxbCodProprietario.Location = New System.Drawing.Point(77, 35)
        Me.TxbCodProprietario.Name = "TxbCodProprietario"
        Me.TxbCodProprietario.Size = New System.Drawing.Size(55, 20)
        Me.TxbCodProprietario.TabIndex = 55
        '
        'TxbDtaNasc
        '
        Me.TxbDtaNasc.Location = New System.Drawing.Point(355, 58)
        Me.TxbDtaNasc.MaxLength = 10
        Me.TxbDtaNasc.Name = "TxbDtaNasc"
        Me.TxbDtaNasc.Size = New System.Drawing.Size(66, 20)
        Me.TxbDtaNasc.TabIndex = 7
        '
        'BtnPesquisaPelagem
        '
        Me.BtnPesquisaPelagem.Image = CType(resources.GetObject("BtnPesquisaPelagem.Image"), System.Drawing.Image)
        Me.BtnPesquisaPelagem.Location = New System.Drawing.Point(412, 126)
        Me.BtnPesquisaPelagem.Name = "BtnPesquisaPelagem"
        Me.BtnPesquisaPelagem.Size = New System.Drawing.Size(25, 22)
        Me.BtnPesquisaPelagem.TabIndex = 17
        Me.BtnPesquisaPelagem.UseVisualStyleBackColor = True
        '
        'TxbDesPelagem
        '
        Me.TxbDesPelagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesPelagem.Location = New System.Drawing.Point(138, 127)
        Me.TxbDesPelagem.Name = "TxbDesPelagem"
        Me.TxbDesPelagem.Size = New System.Drawing.Size(273, 20)
        Me.TxbDesPelagem.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Pelagem:"
        '
        'RbFemea
        '
        Me.RbFemea.AutoSize = True
        Me.RbFemea.Location = New System.Drawing.Point(154, 60)
        Me.RbFemea.Name = "RbFemea"
        Me.RbFemea.Size = New System.Drawing.Size(57, 17)
        Me.RbFemea.TabIndex = 6
        Me.RbFemea.TabStop = True
        Me.RbFemea.Text = "Fêmea"
        Me.RbFemea.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Sexo:"
        '
        'RbMacho
        '
        Me.RbMacho.AutoSize = True
        Me.RbMacho.Location = New System.Drawing.Point(77, 60)
        Me.RbMacho.Name = "RbMacho"
        Me.RbMacho.Size = New System.Drawing.Size(58, 17)
        Me.RbMacho.TabIndex = 5
        Me.RbMacho.TabStop = True
        Me.RbMacho.Text = "Macho"
        Me.RbMacho.UseVisualStyleBackColor = True
        '
        'BtnPesquisaRaca
        '
        Me.BtnPesquisaRaca.Image = CType(resources.GetObject("BtnPesquisaRaca.Image"), System.Drawing.Image)
        Me.BtnPesquisaRaca.Location = New System.Drawing.Point(412, 103)
        Me.BtnPesquisaRaca.Name = "BtnPesquisaRaca"
        Me.BtnPesquisaRaca.Size = New System.Drawing.Size(25, 22)
        Me.BtnPesquisaRaca.TabIndex = 14
        Me.BtnPesquisaRaca.UseVisualStyleBackColor = True
        '
        'TxbDesRaca
        '
        Me.TxbDesRaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesRaca.Location = New System.Drawing.Point(138, 104)
        Me.TxbDesRaca.Name = "TxbDesRaca"
        Me.TxbDesRaca.Size = New System.Drawing.Size(273, 20)
        Me.TxbDesRaca.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Raça:"
        '
        'BtnPesquisaEspecie
        '
        Me.BtnPesquisaEspecie.Image = CType(resources.GetObject("BtnPesquisaEspecie.Image"), System.Drawing.Image)
        Me.BtnPesquisaEspecie.Location = New System.Drawing.Point(412, 80)
        Me.BtnPesquisaEspecie.Name = "BtnPesquisaEspecie"
        Me.BtnPesquisaEspecie.Size = New System.Drawing.Size(25, 22)
        Me.BtnPesquisaEspecie.TabIndex = 11
        Me.BtnPesquisaEspecie.UseVisualStyleBackColor = True
        '
        'TxbDesEspecie
        '
        Me.TxbDesEspecie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesEspecie.Location = New System.Drawing.Point(138, 81)
        Me.TxbDesEspecie.Name = "TxbDesEspecie"
        Me.TxbDesEspecie.Size = New System.Drawing.Size(273, 20)
        Me.TxbDesEspecie.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Espécie:"
        '
        'BtnProprietario
        '
        Me.BtnProprietario.Image = CType(resources.GetObject("BtnProprietario.Image"), System.Drawing.Image)
        Me.BtnProprietario.Location = New System.Drawing.Point(412, 34)
        Me.BtnProprietario.Name = "BtnProprietario"
        Me.BtnProprietario.Size = New System.Drawing.Size(25, 22)
        Me.BtnProprietario.TabIndex = 3
        Me.BtnProprietario.UseVisualStyleBackColor = True
        '
        'TxbObservacao
        '
        Me.TxbObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbObservacao.Location = New System.Drawing.Point(77, 150)
        Me.TxbObservacao.Multiline = True
        Me.TxbObservacao.Name = "TxbObservacao"
        Me.TxbObservacao.Size = New System.Drawing.Size(360, 53)
        Me.TxbObservacao.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 154)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Observação:"
        '
        'DtpDtaNasc
        '
        Me.DtpDtaNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaNasc.Location = New System.Drawing.Point(423, 58)
        Me.DtpDtaNasc.Name = "DtpDtaNasc"
        Me.DtpDtaNasc.Size = New System.Drawing.Size(14, 20)
        Me.DtpDtaNasc.TabIndex = 8
        Me.DtpDtaNasc.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'TxbNomAnimal
        '
        Me.TxbNomAnimal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomAnimal.Location = New System.Drawing.Point(138, 12)
        Me.TxbNomAnimal.Name = "TxbNomAnimal"
        Me.TxbNomAnimal.Size = New System.Drawing.Size(299, 20)
        Me.TxbNomAnimal.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Animal:"
        '
        'TxbNomProprietario
        '
        Me.TxbNomProprietario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomProprietario.Location = New System.Drawing.Point(138, 35)
        Me.TxbNomProprietario.Name = "TxbNomProprietario"
        Me.TxbNomProprietario.Size = New System.Drawing.Size(273, 20)
        Me.TxbNomProprietario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Proprietário:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(303, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Dta.Nasc:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Dgv)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(457, 217)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Grid"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Dgv
        '
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Location = New System.Drawing.Point(3, 3)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(451, 211)
        Me.Dgv.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(457, 217)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Vacina"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.DgvVacina)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(451, 211)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Vacina"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LbSeqVacina)
        Me.GroupBox5.Controls.Add(Me.TxbCodVacina)
        Me.GroupBox5.Controls.Add(Me.TxbDtaVacina)
        Me.GroupBox5.Controls.Add(Me.DtpDtaVacina)
        Me.GroupBox5.Controls.Add(Me.BtnLimpaVacina)
        Me.GroupBox5.Controls.Add(Me.BtnSalvaVacina)
        Me.GroupBox5.Controls.Add(Me.BtnExcluirVacina)
        Me.GroupBox5.Controls.Add(Me.RbVacNao)
        Me.GroupBox5.Controls.Add(Me.RbVacSim)
        Me.GroupBox5.Controls.Add(Me.BtnPesquisaVacina)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.TxbDesVacina)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(438, 71)
        Me.GroupBox5.TabIndex = 55
        Me.GroupBox5.TabStop = False
        '
        'LbSeqVacina
        '
        Me.LbSeqVacina.AutoSize = True
        Me.LbSeqVacina.Location = New System.Drawing.Point(144, 55)
        Me.LbSeqVacina.Name = "LbSeqVacina"
        Me.LbSeqVacina.Size = New System.Drawing.Size(57, 13)
        Me.LbSeqVacina.TabIndex = 55
        Me.LbSeqVacina.Text = "seqVacina"
        Me.LbSeqVacina.Visible = False
        '
        'TxbCodVacina
        '
        Me.TxbCodVacina.Location = New System.Drawing.Point(56, 15)
        Me.TxbCodVacina.Name = "TxbCodVacina"
        Me.TxbCodVacina.Size = New System.Drawing.Size(59, 20)
        Me.TxbCodVacina.TabIndex = 54
        '
        'TxbDtaVacina
        '
        Me.TxbDtaVacina.Location = New System.Drawing.Point(56, 38)
        Me.TxbDtaVacina.MaxLength = 10
        Me.TxbDtaVacina.Name = "TxbDtaVacina"
        Me.TxbDtaVacina.Size = New System.Drawing.Size(66, 20)
        Me.TxbDtaVacina.TabIndex = 4
        '
        'DtpDtaVacina
        '
        Me.DtpDtaVacina.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaVacina.Location = New System.Drawing.Point(124, 38)
        Me.DtpDtaVacina.Name = "DtpDtaVacina"
        Me.DtpDtaVacina.Size = New System.Drawing.Size(14, 20)
        Me.DtpDtaVacina.TabIndex = 5
        Me.DtpDtaVacina.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'BtnLimpaVacina
        '
        Me.BtnLimpaVacina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpaVacina.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLimpaVacina.Image = CType(resources.GetObject("BtnLimpaVacina.Image"), System.Drawing.Image)
        Me.BtnLimpaVacina.Location = New System.Drawing.Point(402, 38)
        Me.BtnLimpaVacina.Name = "BtnLimpaVacina"
        Me.BtnLimpaVacina.Size = New System.Drawing.Size(30, 31)
        Me.BtnLimpaVacina.TabIndex = 10
        Me.BtnLimpaVacina.UseVisualStyleBackColor = True
        '
        'BtnSalvaVacina
        '
        Me.BtnSalvaVacina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvaVacina.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvaVacina.Image = CType(resources.GetObject("BtnSalvaVacina.Image"), System.Drawing.Image)
        Me.BtnSalvaVacina.Location = New System.Drawing.Point(340, 38)
        Me.BtnSalvaVacina.Name = "BtnSalvaVacina"
        Me.BtnSalvaVacina.Size = New System.Drawing.Size(30, 31)
        Me.BtnSalvaVacina.TabIndex = 8
        Me.BtnSalvaVacina.UseVisualStyleBackColor = True
        '
        'BtnExcluirVacina
        '
        Me.BtnExcluirVacina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluirVacina.ForeColor = System.Drawing.Color.Transparent
        Me.BtnExcluirVacina.Image = CType(resources.GetObject("BtnExcluirVacina.Image"), System.Drawing.Image)
        Me.BtnExcluirVacina.Location = New System.Drawing.Point(372, 38)
        Me.BtnExcluirVacina.Name = "BtnExcluirVacina"
        Me.BtnExcluirVacina.Size = New System.Drawing.Size(30, 31)
        Me.BtnExcluirVacina.TabIndex = 9
        Me.BtnExcluirVacina.UseVisualStyleBackColor = True
        '
        'RbVacNao
        '
        Me.RbVacNao.AutoSize = True
        Me.RbVacNao.Location = New System.Drawing.Point(282, 40)
        Me.RbVacNao.Name = "RbVacNao"
        Me.RbVacNao.Size = New System.Drawing.Size(45, 17)
        Me.RbVacNao.TabIndex = 7
        Me.RbVacNao.TabStop = True
        Me.RbVacNao.Text = "Não"
        Me.RbVacNao.UseVisualStyleBackColor = True
        '
        'RbVacSim
        '
        Me.RbVacSim.AutoSize = True
        Me.RbVacSim.Location = New System.Drawing.Point(240, 40)
        Me.RbVacSim.Name = "RbVacSim"
        Me.RbVacSim.Size = New System.Drawing.Size(42, 17)
        Me.RbVacSim.TabIndex = 6
        Me.RbVacSim.TabStop = True
        Me.RbVacSim.Text = "Sim"
        Me.RbVacSim.UseVisualStyleBackColor = True
        '
        'BtnPesquisaVacina
        '
        Me.BtnPesquisaVacina.Image = CType(resources.GetObject("BtnPesquisaVacina.Image"), System.Drawing.Image)
        Me.BtnPesquisaVacina.Location = New System.Drawing.Point(401, 14)
        Me.BtnPesquisaVacina.Name = "BtnPesquisaVacina"
        Me.BtnPesquisaVacina.Size = New System.Drawing.Size(25, 22)
        Me.BtnPesquisaVacina.TabIndex = 3
        Me.BtnPesquisaVacina.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Data:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(178, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Vacinado:"
        '
        'TxbDesVacina
        '
        Me.TxbDesVacina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesVacina.Location = New System.Drawing.Point(118, 15)
        Me.TxbDesVacina.Name = "TxbDesVacina"
        Me.TxbDesVacina.Size = New System.Drawing.Size(281, 20)
        Me.TxbDesVacina.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Vacina:"
        '
        'DgvVacina
        '
        Me.DgvVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVacina.Location = New System.Drawing.Point(4, 82)
        Me.DgvVacina.Name = "DgvVacina"
        Me.DgvVacina.Size = New System.Drawing.Size(441, 123)
        Me.DgvVacina.TabIndex = 45
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DgvContParasitario)
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(457, 217)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Contr.Parasitário"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DgvContParasitario
        '
        Me.DgvContParasitario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContParasitario.Location = New System.Drawing.Point(3, 94)
        Me.DgvContParasitario.Name = "DgvContParasitario"
        Me.DgvContParasitario.Size = New System.Drawing.Size(448, 118)
        Me.DgvContParasitario.TabIndex = 46
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxbPesoParasita)
        Me.GroupBox4.Controls.Add(Me.TxbDoseParasita)
        Me.GroupBox4.Controls.Add(Me.TxbCodParasita)
        Me.GroupBox4.Controls.Add(Me.TxbDtaProximaParasita)
        Me.GroupBox4.Controls.Add(Me.DtpProximaParasita)
        Me.GroupBox4.Controls.Add(Me.TxbDtaParasita)
        Me.GroupBox4.Controls.Add(Me.DtpDtaParasita)
        Me.GroupBox4.Controls.Add(Me.BtnLimparParasita)
        Me.GroupBox4.Controls.Add(Me.BtnSalvaParasita)
        Me.GroupBox4.Controls.Add(Me.BtnExcluirParasita)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.BtnPesquisaParasita)
        Me.GroupBox4.Controls.Add(Me.TxbDesParasita)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.LbSeqParasita)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(451, 85)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Controle Parasitário"
        '
        'TxbPesoParasita
        '
        Me.TxbPesoParasita.Location = New System.Drawing.Point(212, 37)
        Me.TxbPesoParasita.Name = "TxbPesoParasita"
        Me.TxbPesoParasita.Size = New System.Drawing.Size(120, 20)
        Me.TxbPesoParasita.TabIndex = 7
        '
        'TxbDoseParasita
        '
        Me.TxbDoseParasita.Location = New System.Drawing.Point(212, 59)
        Me.TxbDoseParasita.Name = "TxbDoseParasita"
        Me.TxbDoseParasita.Size = New System.Drawing.Size(120, 20)
        Me.TxbDoseParasita.TabIndex = 8
        '
        'TxbCodParasita
        '
        Me.TxbCodParasita.Location = New System.Drawing.Point(56, 15)
        Me.TxbCodParasita.Name = "TxbCodParasita"
        Me.TxbCodParasita.Size = New System.Drawing.Size(58, 20)
        Me.TxbCodParasita.TabIndex = 0
        '
        'TxbDtaProximaParasita
        '
        Me.TxbDtaProximaParasita.Location = New System.Drawing.Point(56, 59)
        Me.TxbDtaProximaParasita.MaxLength = 10
        Me.TxbDtaProximaParasita.Name = "TxbDtaProximaParasita"
        Me.TxbDtaProximaParasita.Size = New System.Drawing.Size(66, 20)
        Me.TxbDtaProximaParasita.TabIndex = 5
        '
        'DtpProximaParasita
        '
        Me.DtpProximaParasita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpProximaParasita.Location = New System.Drawing.Point(124, 59)
        Me.DtpProximaParasita.Name = "DtpProximaParasita"
        Me.DtpProximaParasita.Size = New System.Drawing.Size(14, 20)
        Me.DtpProximaParasita.TabIndex = 6
        Me.DtpProximaParasita.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'TxbDtaParasita
        '
        Me.TxbDtaParasita.Location = New System.Drawing.Point(56, 37)
        Me.TxbDtaParasita.MaxLength = 10
        Me.TxbDtaParasita.Name = "TxbDtaParasita"
        Me.TxbDtaParasita.Size = New System.Drawing.Size(66, 20)
        Me.TxbDtaParasita.TabIndex = 3
        '
        'DtpDtaParasita
        '
        Me.DtpDtaParasita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaParasita.Location = New System.Drawing.Point(124, 37)
        Me.DtpDtaParasita.Name = "DtpDtaParasita"
        Me.DtpDtaParasita.Size = New System.Drawing.Size(14, 20)
        Me.DtpDtaParasita.TabIndex = 4
        Me.DtpDtaParasita.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'BtnLimparParasita
        '
        Me.BtnLimparParasita.Image = CType(resources.GetObject("BtnLimparParasita.Image"), System.Drawing.Image)
        Me.BtnLimparParasita.Location = New System.Drawing.Point(418, 48)
        Me.BtnLimparParasita.Name = "BtnLimparParasita"
        Me.BtnLimparParasita.Size = New System.Drawing.Size(30, 31)
        Me.BtnLimparParasita.TabIndex = 11
        Me.BtnLimparParasita.UseVisualStyleBackColor = True
        '
        'BtnSalvaParasita
        '
        Me.BtnSalvaParasita.Image = CType(resources.GetObject("BtnSalvaParasita.Image"), System.Drawing.Image)
        Me.BtnSalvaParasita.Location = New System.Drawing.Point(357, 48)
        Me.BtnSalvaParasita.Name = "BtnSalvaParasita"
        Me.BtnSalvaParasita.Size = New System.Drawing.Size(30, 31)
        Me.BtnSalvaParasita.TabIndex = 9
        Me.BtnSalvaParasita.UseVisualStyleBackColor = True
        '
        'BtnExcluirParasita
        '
        Me.BtnExcluirParasita.Image = CType(resources.GetObject("BtnExcluirParasita.Image"), System.Drawing.Image)
        Me.BtnExcluirParasita.Location = New System.Drawing.Point(388, 48)
        Me.BtnExcluirParasita.Name = "BtnExcluirParasita"
        Me.BtnExcluirParasita.Size = New System.Drawing.Size(30, 31)
        Me.BtnExcluirParasita.TabIndex = 10
        Me.BtnExcluirParasita.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(179, 41)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Peso:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(178, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Dose:"
        '
        'BtnPesquisaParasita
        '
        Me.BtnPesquisaParasita.Image = CType(resources.GetObject("BtnPesquisaParasita.Image"), System.Drawing.Image)
        Me.BtnPesquisaParasita.Location = New System.Drawing.Point(423, 14)
        Me.BtnPesquisaParasita.Name = "BtnPesquisaParasita"
        Me.BtnPesquisaParasita.Size = New System.Drawing.Size(25, 22)
        Me.BtnPesquisaParasita.TabIndex = 2
        Me.BtnPesquisaParasita.UseVisualStyleBackColor = True
        '
        'TxbDesParasita
        '
        Me.TxbDesParasita.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesParasita.Location = New System.Drawing.Point(118, 15)
        Me.TxbDesParasita.Name = "TxbDesParasita"
        Me.TxbDesParasita.Size = New System.Drawing.Size(302, 20)
        Me.TxbDesParasita.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(0, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Descrição:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(0, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Data:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(0, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Próxima:"
        '
        'LbSeqParasita
        '
        Me.LbSeqParasita.AutoSize = True
        Me.LbSeqParasita.Location = New System.Drawing.Point(336, 37)
        Me.LbSeqParasita.Name = "LbSeqParasita"
        Me.LbSeqParasita.Size = New System.Drawing.Size(76, 13)
        Me.LbSeqParasita.TabIndex = 58
        Me.LbSeqParasita.Text = "LbSeqParasita"
        Me.LbSeqParasita.Visible = False
        '
        'GbNavegador
        '
        Me.GbNavegador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbNavegador.BackColor = System.Drawing.Color.White
        Me.GbNavegador.Controls.Add(Me.BtnCsv)
        Me.GbNavegador.Controls.Add(Me.BtnUltimoReg)
        Me.GbNavegador.Controls.Add(Me.BtnAnterior)
        Me.GbNavegador.Controls.Add(Me.BtnProximo)
        Me.GbNavegador.Controls.Add(Me.BtnPrimeiroReg)
        Me.GbNavegador.Controls.Add(Me.BtnGrid)
        Me.GbNavegador.Controls.Add(Me.BtnPesquisa)
        Me.GbNavegador.Controls.Add(Me.BtnLimpar)
        Me.GbNavegador.Controls.Add(Me.BtnSalvar)
        Me.GbNavegador.Controls.Add(Me.BtnExcluir)
        Me.GbNavegador.Location = New System.Drawing.Point(0, 0)
        Me.GbNavegador.Name = "GbNavegador"
        Me.GbNavegador.Size = New System.Drawing.Size(589, 46)
        Me.GbNavegador.TabIndex = 27
        Me.GbNavegador.TabStop = False
        '
        'BtnCsv
        '
        Me.BtnCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCsv.Location = New System.Drawing.Point(176, 10)
        Me.BtnCsv.Name = "BtnCsv"
        Me.BtnCsv.Size = New System.Drawing.Size(31, 31)
        Me.BtnCsv.TabIndex = 7
        Me.BtnCsv.Text = "CSV"
        Me.BtnCsv.UseVisualStyleBackColor = True
        '
        'BtnUltimoReg
        '
        Me.BtnUltimoReg.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnUltimoReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnUltimoReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUltimoReg.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUltimoReg.Image = CType(resources.GetObject("BtnUltimoReg.Image"), System.Drawing.Image)
        Me.BtnUltimoReg.Location = New System.Drawing.Point(312, 10)
        Me.BtnUltimoReg.Name = "BtnUltimoReg"
        Me.BtnUltimoReg.Size = New System.Drawing.Size(31, 31)
        Me.BtnUltimoReg.TabIndex = 11
        Me.BtnUltimoReg.UseVisualStyleBackColor = True
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
        'BtnProximo
        '
        Me.BtnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProximo.ForeColor = System.Drawing.Color.Transparent
        Me.BtnProximo.Image = CType(resources.GetObject("BtnProximo.Image"), System.Drawing.Image)
        Me.BtnProximo.Location = New System.Drawing.Point(278, 10)
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
        Me.BtnPrimeiroReg.Location = New System.Drawing.Point(210, 10)
        Me.BtnPrimeiroReg.Name = "BtnPrimeiroReg"
        Me.BtnPrimeiroReg.Size = New System.Drawing.Size(31, 31)
        Me.BtnPrimeiroReg.TabIndex = 8
        Me.BtnPrimeiroReg.UseVisualStyleBackColor = True
        '
        'BtnGrid
        '
        Me.BtnGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrid.ForeColor = System.Drawing.Color.Transparent
        Me.BtnGrid.Image = CType(resources.GetObject("BtnGrid.Image"), System.Drawing.Image)
        Me.BtnGrid.Location = New System.Drawing.Point(142, 10)
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
        Me.BtnPesquisa.Location = New System.Drawing.Point(74, 10)
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
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(6, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(31, 31)
        Me.BtnSalvar.TabIndex = 2
        Me.BtnSalvar.UseVisualStyleBackColor = True
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
        'FrmAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(591, 265)
        Me.Controls.Add(Me.GbNavegador)
        Me.Controls.Add(Me.BtnControleParasitario)
        Me.Controls.Add(Me.BtnVacina)
        Me.Controls.Add(Me.BtnPrincipal)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAnimal"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DgvVacina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DgvContParasitario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GbNavegador.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnControleParasitario As Windows.Forms.Button
    Friend WithEvents BtnVacina As Windows.Forms.Button
    Friend WithEvents BtnPrincipal As Windows.Forms.Button
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents BtnPesquisaPelagem As Windows.Forms.Button
    Friend WithEvents TxbDesPelagem As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents RbFemea As Windows.Forms.RadioButton
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents RbMacho As Windows.Forms.RadioButton
    Friend WithEvents BtnPesquisaRaca As Windows.Forms.Button
    Friend WithEvents TxbDesRaca As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents BtnPesquisaEspecie As Windows.Forms.Button
    Friend WithEvents TxbDesEspecie As Windows.Forms.TextBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents BtnProprietario As Windows.Forms.Button
    Friend WithEvents TxbObservacao As Windows.Forms.TextBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents DtpDtaNasc As Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents TxbNomAnimal As Windows.Forms.TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents TxbNomProprietario As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents Dgv As Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Friend WithEvents BtnLimpaVacina As Windows.Forms.Button
    Friend WithEvents BtnSalvaVacina As Windows.Forms.Button
    Friend WithEvents BtnExcluirVacina As Windows.Forms.Button
    Friend WithEvents RbVacNao As Windows.Forms.RadioButton
    Friend WithEvents RbVacSim As Windows.Forms.RadioButton
    Friend WithEvents BtnPesquisaVacina As Windows.Forms.Button
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents TxbDesVacina As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents DgvVacina As Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As Windows.Forms.TabPage
    Friend WithEvents DgvContParasitario As Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents BtnLimparParasita As Windows.Forms.Button
    Friend WithEvents BtnSalvaParasita As Windows.Forms.Button
    Friend WithEvents BtnExcluirParasita As Windows.Forms.Button
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents TxbDoseParasita As Windows.Forms.TextBox
    Friend WithEvents BtnPesquisaParasita As Windows.Forms.Button
    Friend WithEvents TxbDesParasita As Windows.Forms.TextBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Protected WithEvents GbNavegador As Windows.Forms.GroupBox
    Protected WithEvents BtnCsv As Windows.Forms.Button
    Protected WithEvents BtnUltimoReg As Windows.Forms.Button
    Protected WithEvents BtnAnterior As Windows.Forms.Button
    Protected WithEvents BtnProximo As Windows.Forms.Button
    Protected WithEvents BtnPrimeiroReg As Windows.Forms.Button
    Protected WithEvents BtnGrid As Windows.Forms.Button
    Protected WithEvents BtnPesquisa As Windows.Forms.Button
    Protected WithEvents BtnLimpar As Windows.Forms.Button
    Protected WithEvents BtnSalvar As Windows.Forms.Button
    Protected WithEvents BtnExcluir As Windows.Forms.Button
    Friend WithEvents TxbDtaNasc As Controles.TxbData
    Friend WithEvents TxbPesoParasita As Controles.TxbMonetario
    Friend WithEvents TxbCodParasita As Controles.TxbCodigo
    Friend WithEvents TxbDtaProximaParasita As Controles.TxbData
    Friend WithEvents DtpProximaParasita As Windows.Forms.DateTimePicker
    Friend WithEvents TxbDtaParasita As Controles.TxbData
    Friend WithEvents DtpDtaParasita As Windows.Forms.DateTimePicker
    Friend WithEvents TxbCodPelagem As Controles.TxbCodigo
    Friend WithEvents txbcodRaca As Controles.TxbCodigo
    Friend WithEvents TxbCodProprietario As Controles.TxbCodigo
    Friend WithEvents TxbDtaVacina As Controles.TxbData
    Friend WithEvents DtpDtaVacina As Windows.Forms.DateTimePicker
    Friend WithEvents TxbCodEspecie As Controles.TxbCodigo
    Friend WithEvents TxbCodAnimal As Controles.TxbCodigo
    Friend WithEvents TxbCodVacina As Controles.TxbCodigo
    Friend WithEvents LbSeqVacina As Windows.Forms.Label
    Friend WithEvents LbSeqParasita As Windows.Forms.Label
End Class
