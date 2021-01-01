<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAberturaCaixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAberturaCaixa))
        Me.BtnOperador = New System.Windows.Forms.Button()
        Me.txbNomOperador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxbCodOperador = New Controles.TxbCodigo()
        Me.BtnPdv = New System.Windows.Forms.Button()
        Me.TxbDesPdv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxbCodPdv = New Controles.TxbCodigo()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxbSaldo = New Controles.TxbMonetario()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnOperador
        '
        Me.BtnOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOperador.ForeColor = System.Drawing.Color.Gray
        Me.BtnOperador.Image = CType(resources.GetObject("BtnOperador.Image"), System.Drawing.Image)
        Me.BtnOperador.Location = New System.Drawing.Point(354, 35)
        Me.BtnOperador.Name = "BtnOperador"
        Me.BtnOperador.Size = New System.Drawing.Size(23, 20)
        Me.BtnOperador.TabIndex = 85
        Me.BtnOperador.UseVisualStyleBackColor = True
        '
        'txbNomOperador
        '
        Me.txbNomOperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbNomOperador.Location = New System.Drawing.Point(137, 35)
        Me.txbNomOperador.Name = "txbNomOperador"
        Me.txbNomOperador.Size = New System.Drawing.Size(215, 20)
        Me.txbNomOperador.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Operador:"
        '
        'TxbCodOperador
        '
        Me.TxbCodOperador.Location = New System.Drawing.Point(73, 35)
        Me.TxbCodOperador.Name = "TxbCodOperador"
        Me.TxbCodOperador.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodOperador.TabIndex = 83
        '
        'BtnPdv
        '
        Me.BtnPdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPdv.ForeColor = System.Drawing.Color.Gray
        Me.BtnPdv.Image = CType(resources.GetObject("BtnPdv.Image"), System.Drawing.Image)
        Me.BtnPdv.Location = New System.Drawing.Point(354, 12)
        Me.BtnPdv.Name = "BtnPdv"
        Me.BtnPdv.Size = New System.Drawing.Size(23, 20)
        Me.BtnPdv.TabIndex = 89
        Me.BtnPdv.UseVisualStyleBackColor = True
        '
        'TxbDesPdv
        '
        Me.TxbDesPdv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesPdv.Location = New System.Drawing.Point(137, 12)
        Me.TxbDesPdv.Name = "TxbDesPdv"
        Me.TxbDesPdv.Size = New System.Drawing.Size(215, 20)
        Me.TxbDesPdv.TabIndex = 88
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "PDV:"
        '
        'TxbCodPdv
        '
        Me.TxbCodPdv.Location = New System.Drawing.Point(73, 12)
        Me.TxbCodPdv.Name = "TxbCodPdv"
        Me.TxbCodPdv.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodPdv.TabIndex = 87
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.BtnLimpar)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(3, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 41)
        Me.GroupBox2.TabIndex = 90
        Me.GroupBox2.TabStop = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLimpar.Image = CType(resources.GetObject("BtnLimpar.Image"), System.Drawing.Image)
        Me.BtnLimpar.Location = New System.Drawing.Point(35, 7)
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
        Me.BtnSalvar.Location = New System.Drawing.Point(6, 7)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(31, 31)
        Me.BtnSalvar.TabIndex = 2
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxbSaldo)
        Me.GroupBox1.Controls.Add(Me.TxbDesPdv)
        Me.GroupBox1.Controls.Add(Me.TxbCodOperador)
        Me.GroupBox1.Controls.Add(Me.BtnPdv)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txbNomOperador)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnOperador)
        Me.GroupBox1.Controls.Add(Me.TxbCodPdv)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 86)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        '
        'TxbSaldo
        '
        Me.TxbSaldo.Location = New System.Drawing.Point(73, 58)
        Me.TxbSaldo.Name = "TxbSaldo"
        Me.TxbSaldo.Size = New System.Drawing.Size(100, 20)
        Me.TxbSaldo.TabIndex = 90
        Me.TxbSaldo.Text = "0,00"
        Me.TxbSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Troco Inicio:"
        '
        'FrmAberturaCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(387, 128)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Location = New System.Drawing.Point(2, -3)
        Me.Name = "FrmAberturaCaixa"
        Me.Text = "FrmAberturaCaixa"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnOperador As Button
    Friend WithEvents txbNomOperador As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxbCodOperador As Controles.TxbCodigo
    Friend WithEvents BtnPdv As Button
    Friend WithEvents TxbDesPdv As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbCodPdv As Controles.TxbCodigo
    Protected WithEvents GroupBox2 As GroupBox
    Protected WithEvents BtnLimpar As Button
    Protected WithEvents BtnSalvar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbSaldo As Controles.TxbMonetario
End Class
