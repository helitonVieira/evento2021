<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataFinal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDataFinal))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxbDtaFinal = New Controles.TxbData()
        Me.DtpDtaFinal = New System.Windows.Forms.DateTimePicker()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxbDtaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpDtaFinal)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Final"
        '
        'TxbDtaFinal
        '
        Me.TxbDtaFinal.Location = New System.Drawing.Point(6, 19)
        Me.TxbDtaFinal.MaxLength = 10
        Me.TxbDtaFinal.Name = "TxbDtaFinal"
        Me.TxbDtaFinal.Size = New System.Drawing.Size(104, 20)
        Me.TxbDtaFinal.TabIndex = 50
        '
        'DtpDtaFinal
        '
        Me.DtpDtaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaFinal.Location = New System.Drawing.Point(112, 19)
        Me.DtpDtaFinal.Name = "DtpDtaFinal"
        Me.DtpDtaFinal.Size = New System.Drawing.Size(20, 20)
        Me.DtpDtaFinal.TabIndex = 51
        Me.DtpDtaFinal.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.White
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(152, 25)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(31, 31)
        Me.BtnSalvar.TabIndex = 3
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'FrmDataFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(198, 80)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDataFinal"
        Me.Text = "Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxbDtaFinal As Controles.TxbData
    Friend WithEvents DtpDtaFinal As DateTimePicker
    Protected WithEvents BtnSalvar As Button
End Class
