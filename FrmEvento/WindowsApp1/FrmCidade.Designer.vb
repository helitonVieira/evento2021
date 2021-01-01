<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCidade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCidade))
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEstado = New System.Windows.Forms.Button()
        Me.txbNomEstado = New System.Windows.Forms.TextBox()
        Me.TxbCodEstado = New Controles.TxbCodigo()
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 156)
        Me.GroupBox1.Size = New System.Drawing.Size(406, 71)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.BtnEstado)
        Me.GroupBox4.Controls.Add(Me.txbNomEstado)
        Me.GroupBox4.Controls.Add(Me.TxbCodEstado)
        Me.GroupBox4.Size = New System.Drawing.Size(403, 58)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodigo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label18, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDescricao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodEstado, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txbNomEstado, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnEstado, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label1, 0)
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(7, 12)
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.Text = "Cidade:"
        '
        'TabPage2
        '
        Me.TabPage2.Size = New System.Drawing.Size(416, 231)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv)
        Me.GroupBox3.Size = New System.Drawing.Size(411, 228)
        '
        'TxbDescricao
        '
        Me.TxbDescricao.Location = New System.Drawing.Point(132, 8)
        '
        'TxbCodigo
        '
        Me.TxbCodigo.Location = New System.Drawing.Point(66, 8)
        '
        'Dgv
        '
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv.Location = New System.Drawing.Point(3, 16)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(405, 209)
        Me.Dgv.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Estado:"
        '
        'BtnEstado
        '
        Me.BtnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEstado.ForeColor = System.Drawing.Color.Gray
        Me.BtnEstado.Image = CType(resources.GetObject("BtnEstado.Image"), System.Drawing.Image)
        Me.BtnEstado.Location = New System.Drawing.Point(374, 31)
        Me.BtnEstado.Name = "BtnEstado"
        Me.BtnEstado.Size = New System.Drawing.Size(23, 20)
        Me.BtnEstado.TabIndex = 45
        Me.BtnEstado.UseVisualStyleBackColor = True
        '
        'txbNomEstado
        '
        Me.txbNomEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbNomEstado.Location = New System.Drawing.Point(132, 31)
        Me.txbNomEstado.Name = "txbNomEstado"
        Me.txbNomEstado.Size = New System.Drawing.Size(240, 20)
        Me.txbNomEstado.TabIndex = 44
        '
        'TxbCodEstado
        '
        Me.TxbCodEstado.Location = New System.Drawing.Point(66, 31)
        Me.TxbCodEstado.Name = "TxbCodEstado"
        Me.TxbCodEstado.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodEstado.TabIndex = 43
        '
        'FrmCidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(439, 283)
        Me.Name = "FrmCidade"
        Me.Text = "FrmCidade"
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

    Friend WithEvents Dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEstado As Button
    Friend WithEvents txbNomEstado As TextBox
    Friend WithEvents TxbCodEstado As Controles.TxbCodigo
End Class
