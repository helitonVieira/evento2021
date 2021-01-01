<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSubCategoria))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtCategoria = New System.Windows.Forms.Button()
        Me.txbDesCategoria = New System.Windows.Forms.TextBox()
        Me.TxbCodCategoria = New Controles.TxbCodigo()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.BtnCadSubCategoria = New System.Windows.Forms.Button()
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 121)
        Me.GroupBox1.Size = New System.Drawing.Size(407, 105)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnCadSubCategoria)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.BtCategoria)
        Me.GroupBox4.Controls.Add(Me.txbDesCategoria)
        Me.GroupBox4.Controls.Add(Me.TxbCodCategoria)
        Me.GroupBox4.Size = New System.Drawing.Size(404, 71)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodigo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label18, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDescricao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodCategoria, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txbDesCategoria, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtCategoria, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label1, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnCadSubCategoria, 0)
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(0, 25)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv)
        '
        'TxbDescricao
        '
        Me.TxbDescricao.Location = New System.Drawing.Point(144, 21)
        Me.TxbDescricao.Size = New System.Drawing.Size(253, 20)
        '
        'TxbCodigo
        '
        Me.TxbCodigo.Location = New System.Drawing.Point(78, 21)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Categoria:"
        '
        'BtCategoria
        '
        Me.BtCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCategoria.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtCategoria.Image = CType(resources.GetObject("BtCategoria.Image"), System.Drawing.Image)
        Me.BtCategoria.Location = New System.Drawing.Point(347, 45)
        Me.BtCategoria.Name = "BtCategoria"
        Me.BtCategoria.Size = New System.Drawing.Size(25, 21)
        Me.BtCategoria.TabIndex = 45
        Me.BtCategoria.UseVisualStyleBackColor = True
        '
        'txbDesCategoria
        '
        Me.txbDesCategoria.Location = New System.Drawing.Point(144, 45)
        Me.txbDesCategoria.Name = "txbDesCategoria"
        Me.txbDesCategoria.Size = New System.Drawing.Size(201, 20)
        Me.txbDesCategoria.TabIndex = 44
        '
        'TxbCodCategoria
        '
        Me.TxbCodCategoria.Location = New System.Drawing.Point(78, 45)
        Me.TxbCodCategoria.Name = "TxbCodCategoria"
        Me.TxbCodCategoria.Size = New System.Drawing.Size(61, 20)
        Me.TxbCodCategoria.TabIndex = 43
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
        Me.Dgv.TabIndex = 1
        Me.Dgv.VirtualMode = True
        '
        'BtnCadSubCategoria
        '
        Me.BtnCadSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadSubCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadSubCategoria.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCadSubCategoria.Location = New System.Drawing.Point(374, 45)
        Me.BtnCadSubCategoria.Name = "BtnCadSubCategoria"
        Me.BtnCadSubCategoria.Size = New System.Drawing.Size(23, 21)
        Me.BtnCadSubCategoria.TabIndex = 78
        Me.BtnCadSubCategoria.Text = "C"
        Me.BtnCadSubCategoria.UseVisualStyleBackColor = True
        '
        'FrmSubCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(439, 283)
        Me.Name = "FrmSubCategoria"
        Me.Text = "FrmSubCategoria"
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

    Friend WithEvents Label1 As Label
    Friend WithEvents BtCategoria As Button
    Friend WithEvents txbDesCategoria As TextBox
    Friend WithEvents TxbCodCategoria As Controles.TxbCodigo
    Public WithEvents Dgv As DataGridView
    Friend WithEvents BtnCadSubCategoria As Button
End Class
