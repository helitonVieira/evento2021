<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFiltroVendaSubCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFiltroVendaSubCategoria))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxbCodSubCategoria = New Controles.TxbCodigo()
        Me.TxbCodItem = New Controles.TxbCodigo()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnItem = New System.Windows.Forms.Button()
        Me.TxbDesItem = New System.Windows.Forms.TextBox()
        Me.BtnCancela = New System.Windows.Forms.Button()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.TxbCodEmpresa = New Controles.TxbCodigo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEmpresa = New System.Windows.Forms.Button()
        Me.txbNomEmpresa = New System.Windows.Forms.TextBox()
        Me.TxbCodCategoria = New Controles.TxbCodigo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSubCategoria = New System.Windows.Forms.Button()
        Me.TxbDesSubCategoria = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BtnCategoria = New System.Windows.Forms.Button()
        Me.TxbDesCategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.DtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxbCodSubCategoria)
        Me.GroupBox1.Controls.Add(Me.TxbCodItem)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.BtnItem)
        Me.GroupBox1.Controls.Add(Me.TxbDesItem)
        Me.GroupBox1.Controls.Add(Me.BtnCancela)
        Me.GroupBox1.Controls.Add(Me.BtnConfirmar)
        Me.GroupBox1.Controls.Add(Me.TxbCodEmpresa)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnEmpresa)
        Me.GroupBox1.Controls.Add(Me.txbNomEmpresa)
        Me.GroupBox1.Controls.Add(Me.TxbCodCategoria)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnSubCategoria)
        Me.GroupBox1.Controls.Add(Me.TxbDesSubCategoria)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.BtnCategoria)
        Me.GroupBox1.Controls.Add(Me.TxbDesCategoria)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtpInicio)
        Me.GroupBox1.Controls.Add(Me.DtpFinal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 156)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'TxbCodSubCategoria
        '
        Me.TxbCodSubCategoria.Location = New System.Drawing.Point(79, 58)
        Me.TxbCodSubCategoria.Name = "TxbCodSubCategoria"
        Me.TxbCodSubCategoria.Size = New System.Drawing.Size(52, 20)
        Me.TxbCodSubCategoria.TabIndex = 6
        '
        'TxbCodItem
        '
        Me.TxbCodItem.Location = New System.Drawing.Point(79, 81)
        Me.TxbCodItem.Name = "TxbCodItem"
        Me.TxbCodItem.Size = New System.Drawing.Size(52, 20)
        Me.TxbCodItem.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Item:"
        '
        'BtnItem
        '
        Me.BtnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnItem.ForeColor = System.Drawing.Color.DimGray
        Me.BtnItem.Image = CType(resources.GetObject("BtnItem.Image"), System.Drawing.Image)
        Me.BtnItem.Location = New System.Drawing.Point(437, 81)
        Me.BtnItem.Name = "BtnItem"
        Me.BtnItem.Size = New System.Drawing.Size(23, 20)
        Me.BtnItem.TabIndex = 73
        Me.BtnItem.UseVisualStyleBackColor = True
        '
        'TxbDesItem
        '
        Me.TxbDesItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesItem.Location = New System.Drawing.Point(133, 81)
        Me.TxbDesItem.Name = "TxbDesItem"
        Me.TxbDesItem.Size = New System.Drawing.Size(302, 20)
        Me.TxbDesItem.TabIndex = 72
        '
        'BtnCancela
        '
        Me.BtnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancela.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCancela.Location = New System.Drawing.Point(172, 127)
        Me.BtnCancela.Name = "BtnCancela"
        Me.BtnCancela.Size = New System.Drawing.Size(87, 22)
        Me.BtnCancela.TabIndex = 13
        Me.BtnCancela.Text = "Cancela"
        Me.BtnCancela.UseVisualStyleBackColor = True
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmar.ForeColor = System.Drawing.Color.DimGray
        Me.BtnConfirmar.Location = New System.Drawing.Point(79, 127)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(87, 22)
        Me.BtnConfirmar.TabIndex = 12
        Me.BtnConfirmar.Text = "Confirma"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'TxbCodEmpresa
        '
        Me.TxbCodEmpresa.Location = New System.Drawing.Point(79, 104)
        Me.TxbCodEmpresa.Name = "TxbCodEmpresa"
        Me.TxbCodEmpresa.Size = New System.Drawing.Size(52, 20)
        Me.TxbCodEmpresa.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 108)
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
        Me.btnEmpresa.Location = New System.Drawing.Point(437, 104)
        Me.btnEmpresa.Name = "btnEmpresa"
        Me.btnEmpresa.Size = New System.Drawing.Size(23, 20)
        Me.btnEmpresa.TabIndex = 11
        Me.btnEmpresa.UseVisualStyleBackColor = True
        '
        'txbNomEmpresa
        '
        Me.txbNomEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbNomEmpresa.Location = New System.Drawing.Point(133, 104)
        Me.txbNomEmpresa.Name = "txbNomEmpresa"
        Me.txbNomEmpresa.Size = New System.Drawing.Size(302, 20)
        Me.txbNomEmpresa.TabIndex = 10
        '
        'TxbCodCategoria
        '
        Me.TxbCodCategoria.Location = New System.Drawing.Point(79, 35)
        Me.TxbCodCategoria.Name = "TxbCodCategoria"
        Me.TxbCodCategoria.Size = New System.Drawing.Size(52, 20)
        Me.TxbCodCategoria.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "SubCategoria:"
        '
        'BtnSubCategoria
        '
        Me.BtnSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubCategoria.ForeColor = System.Drawing.Color.DimGray
        Me.BtnSubCategoria.Image = CType(resources.GetObject("BtnSubCategoria.Image"), System.Drawing.Image)
        Me.BtnSubCategoria.Location = New System.Drawing.Point(437, 58)
        Me.BtnSubCategoria.Name = "BtnSubCategoria"
        Me.BtnSubCategoria.Size = New System.Drawing.Size(23, 20)
        Me.BtnSubCategoria.TabIndex = 8
        Me.BtnSubCategoria.UseVisualStyleBackColor = True
        '
        'TxbDesSubCategoria
        '
        Me.TxbDesSubCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesSubCategoria.Location = New System.Drawing.Point(133, 58)
        Me.TxbDesSubCategoria.Name = "TxbDesSubCategoria"
        Me.TxbDesSubCategoria.Size = New System.Drawing.Size(302, 20)
        Me.TxbDesSubCategoria.TabIndex = 7
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 39)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 13)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "Categoria:"
        '
        'BtnCategoria
        '
        Me.BtnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCategoria.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCategoria.Image = CType(resources.GetObject("BtnCategoria.Image"), System.Drawing.Image)
        Me.BtnCategoria.Location = New System.Drawing.Point(437, 35)
        Me.BtnCategoria.Name = "BtnCategoria"
        Me.BtnCategoria.Size = New System.Drawing.Size(23, 20)
        Me.BtnCategoria.TabIndex = 5
        Me.BtnCategoria.UseVisualStyleBackColor = True
        '
        'TxbDesCategoria
        '
        Me.TxbDesCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesCategoria.Location = New System.Drawing.Point(133, 35)
        Me.TxbDesCategoria.Name = "TxbDesCategoria"
        Me.TxbDesCategoria.Size = New System.Drawing.Size(302, 20)
        Me.TxbDesCategoria.TabIndex = 4
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
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Inicio:"
        '
        'FrmFiltroVendaSubCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(480, 165)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmFiltroVendaSubCategoria"
        Me.Text = "FrmFiltroVendaSub-Categoria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxbCodSubCategoria As Controles.TxbCodigo
    Friend WithEvents TxbCodItem As Controles.TxbCodigo
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnItem As Button
    Friend WithEvents TxbDesItem As TextBox
    Friend WithEvents BtnCancela As Button
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents TxbCodEmpresa As Controles.TxbCodigo
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEmpresa As Button
    Friend WithEvents txbNomEmpresa As TextBox
    Friend WithEvents TxbCodCategoria As Controles.TxbCodigo
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSubCategoria As Button
    Friend WithEvents TxbDesSubCategoria As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnCategoria As Button
    Friend WithEvents TxbDesCategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpInicio As DateTimePicker
    Friend WithEvents DtpFinal As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
