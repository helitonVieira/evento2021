<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUnidade
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
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.TxbNumFatorConv = New Controles.TxbCodigo()
        Me.TxbSigla = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(6, 111)
        Me.GroupBox1.Size = New System.Drawing.Size(406, 115)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxbNumFatorConv)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TxbSigla)
        Me.GroupBox4.Size = New System.Drawing.Size(403, 63)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodigo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label18, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDescricao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbSigla, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label1, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label2, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbNumFatorConv, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv)
        Me.GroupBox3.Size = New System.Drawing.Size(410, 227)
        '
        'Dgv
        '
        Me.Dgv.AllowUserToOrderColumns = True
        Me.Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Location = New System.Drawing.Point(-1, 4)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(412, 218)
        Me.Dgv.TabIndex = 2
        Me.Dgv.VirtualMode = True
        '
        'TxbNumFatorConv
        '
        Me.TxbNumFatorConv.Location = New System.Drawing.Point(280, 35)
        Me.TxbNumFatorConv.Name = "TxbNumFatorConv"
        Me.TxbNumFatorConv.Size = New System.Drawing.Size(116, 20)
        Me.TxbNumFatorConv.TabIndex = 35
        '
        'TxbSigla
        '
        Me.TxbSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbSigla.Location = New System.Drawing.Point(64, 35)
        Me.TxbSigla.Name = "TxbSigla"
        Me.TxbSigla.Size = New System.Drawing.Size(116, 20)
        Me.TxbSigla.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Sigla:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Fator Conversão:"
        '
        'FrmUnidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(439, 283)
        Me.Name = "FrmUnidade"
        Me.Text = "FrmUnidade"
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Dgv As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxbSigla As TextBox
    Friend WithEvents TxbNumFatorConv As Controles.TxbCodigo
End Class
