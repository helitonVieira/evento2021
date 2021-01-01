<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFiltroRelComissaoAgendaServ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFiltroRelComissaoAgendaServ))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxbPerComissao = New Controles.TxbMonetario()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxbCodEmpresa = New Controles.TxbCodigo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEmpresa = New System.Windows.Forms.Button()
        Me.txbNomEmpresa = New System.Windows.Forms.TextBox()
        Me.TxbCodCliente = New Controles.TxbCodigo()
        Me.TxbCodFuncionario = New Controles.TxbCodigo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.TxbNomCliente = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BtnFuncionario = New System.Windows.Forms.Button()
        Me.TxbNomFuncionario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.DtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxbPerComissao)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TxbCodEmpresa)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnEmpresa)
        Me.GroupBox1.Controls.Add(Me.txbNomEmpresa)
        Me.GroupBox1.Controls.Add(Me.TxbCodCliente)
        Me.GroupBox1.Controls.Add(Me.TxbCodFuncionario)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnCliente)
        Me.GroupBox1.Controls.Add(Me.TxbNomCliente)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.BtnFuncionario)
        Me.GroupBox1.Controls.Add(Me.TxbNomFuncionario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtpInicio)
        Me.GroupBox1.Controls.Add(Me.DtpFinal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 136)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'TxbPerComissao
        '
        Me.TxbPerComissao.Location = New System.Drawing.Point(391, 12)
        Me.TxbPerComissao.Name = "TxbPerComissao"
        Me.TxbPerComissao.Size = New System.Drawing.Size(69, 20)
        Me.TxbPerComissao.TabIndex = 2
        Me.TxbPerComissao.Text = "0,00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "% Comissão:"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.DimGray
        Me.Button3.Location = New System.Drawing.Point(172, 107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 22)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Cancela"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(79, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 22)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Confirma"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxbCodEmpresa
        '
        Me.TxbCodEmpresa.Location = New System.Drawing.Point(79, 81)
        Me.TxbCodEmpresa.Name = "TxbCodEmpresa"
        Me.TxbCodEmpresa.Size = New System.Drawing.Size(52, 20)
        Me.TxbCodEmpresa.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Empresa:"
        '
        'btnEmpresa
        '
        Me.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpresa.ForeColor = System.Drawing.Color.DimGray
        Me.btnEmpresa.Image = CType(resources.GetObject("btnEmpresa.Image"), System.Drawing.Image)
        Me.btnEmpresa.Location = New System.Drawing.Point(437, 81)
        Me.btnEmpresa.Name = "btnEmpresa"
        Me.btnEmpresa.Size = New System.Drawing.Size(23, 20)
        Me.btnEmpresa.TabIndex = 11
        Me.btnEmpresa.UseVisualStyleBackColor = True
        '
        'txbNomEmpresa
        '
        Me.txbNomEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbNomEmpresa.Location = New System.Drawing.Point(133, 81)
        Me.txbNomEmpresa.Name = "txbNomEmpresa"
        Me.txbNomEmpresa.Size = New System.Drawing.Size(302, 20)
        Me.txbNomEmpresa.TabIndex = 10
        '
        'TxbCodCliente
        '
        Me.TxbCodCliente.Location = New System.Drawing.Point(79, 58)
        Me.TxbCodCliente.Name = "TxbCodCliente"
        Me.TxbCodCliente.Size = New System.Drawing.Size(52, 20)
        Me.TxbCodCliente.TabIndex = 6
        '
        'TxbCodFuncionario
        '
        Me.TxbCodFuncionario.Location = New System.Drawing.Point(79, 35)
        Me.TxbCodFuncionario.Name = "TxbCodFuncionario"
        Me.TxbCodFuncionario.Size = New System.Drawing.Size(52, 20)
        Me.TxbCodFuncionario.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Cliente:"
        '
        'BtnCliente
        '
        Me.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCliente.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCliente.Image = CType(resources.GetObject("BtnCliente.Image"), System.Drawing.Image)
        Me.BtnCliente.Location = New System.Drawing.Point(437, 58)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(23, 20)
        Me.BtnCliente.TabIndex = 8
        Me.BtnCliente.UseVisualStyleBackColor = True
        '
        'TxbNomCliente
        '
        Me.TxbNomCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomCliente.Location = New System.Drawing.Point(133, 58)
        Me.TxbNomCliente.Name = "TxbNomCliente"
        Me.TxbNomCliente.Size = New System.Drawing.Size(302, 20)
        Me.TxbNomCliente.TabIndex = 7
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 39)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 13)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "Funcionário:"
        '
        'BtnFuncionario
        '
        Me.BtnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFuncionario.ForeColor = System.Drawing.Color.DimGray
        Me.BtnFuncionario.Image = CType(resources.GetObject("BtnFuncionario.Image"), System.Drawing.Image)
        Me.BtnFuncionario.Location = New System.Drawing.Point(437, 35)
        Me.BtnFuncionario.Name = "BtnFuncionario"
        Me.BtnFuncionario.Size = New System.Drawing.Size(23, 20)
        Me.BtnFuncionario.TabIndex = 5
        Me.BtnFuncionario.UseVisualStyleBackColor = True
        '
        'TxbNomFuncionario
        '
        Me.TxbNomFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomFuncionario.Location = New System.Drawing.Point(133, 35)
        Me.TxbNomFuncionario.Name = "TxbNomFuncionario"
        Me.TxbNomFuncionario.Size = New System.Drawing.Size(302, 20)
        Me.TxbNomFuncionario.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Final:"
        '
        'DtpInicio
        '
        Me.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpInicio.Location = New System.Drawing.Point(79, 12)
        Me.DtpInicio.Name = "DtpInicio"
        Me.DtpInicio.Size = New System.Drawing.Size(95, 20)
        Me.DtpInicio.TabIndex = 0
        '
        'DtpFinal
        '
        Me.DtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFinal.Location = New System.Drawing.Point(225, 12)
        Me.DtpFinal.Name = "DtpFinal"
        Me.DtpFinal.Size = New System.Drawing.Size(95, 20)
        Me.DtpFinal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Inicio:"
        '
        'FrmFiltroRelComissaoAgendaServ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(477, 142)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmFiltroRelComissaoAgendaServ"
        Me.Text = "FrmComissaoAgenda"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TxbCodEmpresa As Controles.TxbCodigo
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEmpresa As Button
    Friend WithEvents txbNomEmpresa As TextBox
    Friend WithEvents TxbCodCliente As Controles.TxbCodigo
    Friend WithEvents TxbCodFuncionario As Controles.TxbCodigo
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCliente As Button
    Friend WithEvents TxbNomCliente As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnFuncionario As Button
    Friend WithEvents TxbNomFuncionario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpInicio As DateTimePicker
    Friend WithEvents DtpFinal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TxbPerComissao As Controles.TxbMonetario
    Friend WithEvents Label5 As Label
End Class
