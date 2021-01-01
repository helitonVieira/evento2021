<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesquisa
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvBusca = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbBusca = New System.Windows.Forms.ComboBox()
        Me.txbBusca = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvBusca)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 187)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'dgvBusca
        '
        Me.dgvBusca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusca.Location = New System.Drawing.Point(6, 13)
        Me.dgvBusca.Name = "dgvBusca"
        Me.dgvBusca.Size = New System.Drawing.Size(328, 166)
        Me.dgvBusca.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbBusca)
        Me.GroupBox1.Controls.Add(Me.txbBusca)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 36)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'cbBusca
        '
        Me.cbBusca.FormattingEnabled = True
        Me.cbBusca.Location = New System.Drawing.Point(6, 10)
        Me.cbBusca.Name = "cbBusca"
        Me.cbBusca.Size = New System.Drawing.Size(88, 21)
        Me.cbBusca.TabIndex = 1
        '
        'txbBusca
        '
        Me.txbBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbBusca.Location = New System.Drawing.Point(100, 10)
        Me.txbBusca.Name = "txbBusca"
        Me.txbBusca.Size = New System.Drawing.Size(234, 20)
        Me.txbBusca.TabIndex = 0
        '
        'FrmPesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 230)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmPesquisa"
        Me.Text = "FrmPesquisa"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvBusca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents dgvBusca As Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents cbBusca As Windows.Forms.ComboBox
    Friend WithEvents txbBusca As Windows.Forms.TextBox
End Class
