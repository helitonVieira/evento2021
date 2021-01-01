<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFiltroRelDespesa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFiltroRelDespesa))
        Me.DtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.DtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxbCodEmpresa = New Controles.TxbCodigo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEmpresa = New System.Windows.Forms.Button()
        Me.txbNomEmpresa = New System.Windows.Forms.TextBox()
        Me.TxbCodTipo = New Controles.TxbCodigo()
        Me.TxbCodFavorecido = New Controles.TxbCodigo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnBuscaTipo = New System.Windows.Forms.Button()
        Me.TxbDesTipo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BtnBuscaFavorecido = New System.Windows.Forms.Button()
        Me.TxbNomFavorecido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtpInicio
        '
        Me.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpInicio.Location = New System.Drawing.Point(79, 12)
        Me.DtpInicio.Name = "DtpInicio"
        Me.DtpInicio.Size = New System.Drawing.Size(102, 20)
        Me.DtpInicio.TabIndex = 0
        '
        'DtpFinal
        '
        Me.DtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFinal.Location = New System.Drawing.Point(225, 12)
        Me.DtpFinal.Name = "DtpFinal"
        Me.DtpFinal.Size = New System.Drawing.Size(102, 20)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TxbCodEmpresa)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnEmpresa)
        Me.GroupBox1.Controls.Add(Me.txbNomEmpresa)
        Me.GroupBox1.Controls.Add(Me.TxbCodTipo)
        Me.GroupBox1.Controls.Add(Me.TxbCodFavorecido)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnBuscaTipo)
        Me.GroupBox1.Controls.Add(Me.TxbDesTipo)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.BtnBuscaFavorecido)
        Me.GroupBox1.Controls.Add(Me.TxbNomFavorecido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtpInicio)
        Me.GroupBox1.Controls.Add(Me.DtpFinal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 136)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.DimGray
        Me.Button3.Location = New System.Drawing.Point(172, 107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 22)
        Me.Button3.TabIndex = 12
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
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Confirma"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxbCodEmpresa
        '
        Me.TxbCodEmpresa.Location = New System.Drawing.Point(79, 81)
        Me.TxbCodEmpresa.Name = "TxbCodEmpresa"
        Me.TxbCodEmpresa.Size = New System.Drawing.Size(52, 20)
        Me.TxbCodEmpresa.TabIndex = 8
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
        Me.btnEmpresa.TabIndex = 10
        Me.btnEmpresa.UseVisualStyleBackColor = True
        '
        'txbNomEmpresa
        '
        Me.txbNomEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbNomEmpresa.Location = New System.Drawing.Point(133, 81)
        Me.txbNomEmpresa.Name = "txbNomEmpresa"
        Me.txbNomEmpresa.Size = New System.Drawing.Size(302, 20)
        Me.txbNomEmpresa.TabIndex = 9
        '
        'TxbCodTipo
        '
        Me.TxbCodTipo.Location = New System.Drawing.Point(79, 58)
        Me.TxbCodTipo.Name = "TxbCodTipo"
        Me.TxbCodTipo.Size = New System.Drawing.Size(52, 20)
        Me.TxbCodTipo.TabIndex = 5
        '
        'TxbCodFavorecido
        '
        Me.TxbCodFavorecido.Location = New System.Drawing.Point(79, 35)
        Me.TxbCodFavorecido.Name = "TxbCodFavorecido"
        Me.TxbCodFavorecido.Size = New System.Drawing.Size(52, 20)
        Me.TxbCodFavorecido.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Tipo: Desp."
        '
        'BtnBuscaTipo
        '
        Me.BtnBuscaTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaTipo.ForeColor = System.Drawing.Color.DimGray
        Me.BtnBuscaTipo.Image = CType(resources.GetObject("BtnBuscaTipo.Image"), System.Drawing.Image)
        Me.BtnBuscaTipo.Location = New System.Drawing.Point(437, 58)
        Me.BtnBuscaTipo.Name = "BtnBuscaTipo"
        Me.BtnBuscaTipo.Size = New System.Drawing.Size(23, 20)
        Me.BtnBuscaTipo.TabIndex = 7
        Me.BtnBuscaTipo.UseVisualStyleBackColor = True
        '
        'TxbDesTipo
        '
        Me.TxbDesTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesTipo.Location = New System.Drawing.Point(133, 58)
        Me.TxbDesTipo.Name = "TxbDesTipo"
        Me.TxbDesTipo.Size = New System.Drawing.Size(302, 20)
        Me.TxbDesTipo.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 39)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 13)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "Favorecido:"
        '
        'BtnBuscaFavorecido
        '
        Me.BtnBuscaFavorecido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaFavorecido.ForeColor = System.Drawing.Color.DimGray
        Me.BtnBuscaFavorecido.Image = CType(resources.GetObject("BtnBuscaFavorecido.Image"), System.Drawing.Image)
        Me.BtnBuscaFavorecido.Location = New System.Drawing.Point(437, 35)
        Me.BtnBuscaFavorecido.Name = "BtnBuscaFavorecido"
        Me.BtnBuscaFavorecido.Size = New System.Drawing.Size(23, 20)
        Me.BtnBuscaFavorecido.TabIndex = 4
        Me.BtnBuscaFavorecido.UseVisualStyleBackColor = True
        '
        'TxbNomFavorecido
        '
        Me.TxbNomFavorecido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomFavorecido.Location = New System.Drawing.Point(133, 35)
        Me.TxbNomFavorecido.Name = "TxbNomFavorecido"
        Me.TxbNomFavorecido.Size = New System.Drawing.Size(302, 20)
        Me.TxbNomFavorecido.TabIndex = 3
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
        'FrmFiltroRelDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(489, 146)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmFiltroRelDespesa"
        Me.Text = "FrmFiltroRelDespesa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DtpInicio As DateTimePicker
    Friend WithEvents DtpFinal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbCodEmpresa As Controles.TxbCodigo
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEmpresa As Button
    Friend WithEvents txbNomEmpresa As TextBox
    Friend WithEvents TxbCodTipo As Controles.TxbCodigo
    Friend WithEvents TxbCodFavorecido As Controles.TxbCodigo
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnBuscaTipo As Button
    Friend WithEvents TxbDesTipo As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnBuscaFavorecido As Button
    Friend WithEvents TxbNomFavorecido As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
