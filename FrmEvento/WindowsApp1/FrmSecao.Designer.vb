<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSecao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSecao))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtAlmoxarifado = New System.Windows.Forms.Button()
        Me.txbDesAlmoxarifado = New System.Windows.Forms.TextBox()
        Me.TxbCodAlmoxarifado = New Controles.TxbCodigo()
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 103)
        Me.GroupBox1.Size = New System.Drawing.Size(407, 123)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnCadSubCategoria)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.BtAlmoxarifado)
        Me.GroupBox4.Controls.Add(Me.txbDesAlmoxarifado)
        Me.GroupBox4.Controls.Add(Me.TxbCodAlmoxarifado)
        Me.GroupBox4.Size = New System.Drawing.Size(404, 72)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodigo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label18, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDescricao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodAlmoxarifado, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txbDesAlmoxarifado, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtAlmoxarifado, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label1, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnCadSubCategoria, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv)
        '
        'TxbDescricao
        '
        Me.TxbDescricao.Location = New System.Drawing.Point(144, 21)
        Me.TxbDescricao.Size = New System.Drawing.Size(254, 20)
        '
        'TxbCodigo
        '
        Me.TxbCodigo.Location = New System.Drawing.Point(78, 21)
        Me.TxbCodigo.Size = New System.Drawing.Size(61, 20)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Almoxarifado:"
        '
        'BtAlmoxarifado
        '
        Me.BtAlmoxarifado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtAlmoxarifado.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtAlmoxarifado.Image = CType(resources.GetObject("BtAlmoxarifado.Image"), System.Drawing.Image)
        Me.BtAlmoxarifado.Location = New System.Drawing.Point(349, 45)
        Me.BtAlmoxarifado.Name = "BtAlmoxarifado"
        Me.BtAlmoxarifado.Size = New System.Drawing.Size(23, 20)
        Me.BtAlmoxarifado.TabIndex = 49
        Me.BtAlmoxarifado.UseVisualStyleBackColor = True
        '
        'txbDesAlmoxarifado
        '
        Me.txbDesAlmoxarifado.Location = New System.Drawing.Point(144, 45)
        Me.txbDesAlmoxarifado.Name = "txbDesAlmoxarifado"
        Me.txbDesAlmoxarifado.Size = New System.Drawing.Size(202, 20)
        Me.txbDesAlmoxarifado.TabIndex = 48
        '
        'TxbCodAlmoxarifado
        '
        Me.TxbCodAlmoxarifado.Location = New System.Drawing.Point(78, 45)
        Me.TxbCodAlmoxarifado.Name = "TxbCodAlmoxarifado"
        Me.TxbCodAlmoxarifado.Size = New System.Drawing.Size(61, 20)
        Me.TxbCodAlmoxarifado.TabIndex = 47
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
        'BtnCadSubCategoria
        '
        Me.BtnCadSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadSubCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadSubCategoria.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCadSubCategoria.Location = New System.Drawing.Point(375, 45)
        Me.BtnCadSubCategoria.Name = "BtnCadSubCategoria"
        Me.BtnCadSubCategoria.Size = New System.Drawing.Size(23, 20)
        Me.BtnCadSubCategoria.TabIndex = 78
        Me.BtnCadSubCategoria.Text = "C"
        Me.BtnCadSubCategoria.UseVisualStyleBackColor = True
        '
        'FrmSecao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(439, 283)
        Me.Name = "FrmSecao"
        Me.Text = "FrmSecao"
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
    Friend WithEvents BtAlmoxarifado As Button
    Friend WithEvents txbDesAlmoxarifado As TextBox
    Friend WithEvents TxbCodAlmoxarifado As Controles.TxbCodigo
    Public WithEvents Dgv As DataGridView
    Friend WithEvents BtnCadSubCategoria As Button
End Class
