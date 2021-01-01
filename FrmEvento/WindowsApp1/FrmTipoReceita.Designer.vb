<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoReceita
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
        Me.CkbPe = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RbImpostoVenda = New System.Windows.Forms.RadioButton()
        Me.RbFinanceira = New System.Windows.Forms.RadioButton()
        Me.RbAdministrativa = New System.Windows.Forms.RadioButton()
        Me.CkbAtivo = New System.Windows.Forms.CheckBox()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 145)
        Me.GroupBox1.Size = New System.Drawing.Size(406, 82)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CkbPe)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.CkbAtivo)
        Me.GroupBox4.Size = New System.Drawing.Size(403, 86)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label18, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.CkbAtivo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.GroupBox5, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.CkbPe, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDescricao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodigo, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv)
        '
        'CkbPe
        '
        Me.CkbPe.AutoSize = True
        Me.CkbPe.Location = New System.Drawing.Point(349, 58)
        Me.CkbPe.Name = "CkbPe"
        Me.CkbPe.Size = New System.Drawing.Size(43, 17)
        Me.CkbPe.TabIndex = 38
        Me.CkbPe.Text = "P.E"
        Me.CkbPe.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RbImpostoVenda)
        Me.GroupBox5.Controls.Add(Me.RbFinanceira)
        Me.GroupBox5.Controls.Add(Me.RbAdministrativa)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 32)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(334, 48)
        Me.GroupBox5.TabIndex = 36
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo"
        '
        'RbImpostoVenda
        '
        Me.RbImpostoVenda.AutoSize = True
        Me.RbImpostoVenda.Location = New System.Drawing.Point(185, 19)
        Me.RbImpostoVenda.Name = "RbImpostoVenda"
        Me.RbImpostoVenda.Size = New System.Drawing.Size(127, 17)
        Me.RbImpostoVenda.TabIndex = 2
        Me.RbImpostoVenda.TabStop = True
        Me.RbImpostoVenda.Text = "Imposto Sobre Venda"
        Me.RbImpostoVenda.UseVisualStyleBackColor = True
        '
        'RbFinanceira
        '
        Me.RbFinanceira.AutoSize = True
        Me.RbFinanceira.Location = New System.Drawing.Point(105, 19)
        Me.RbFinanceira.Name = "RbFinanceira"
        Me.RbFinanceira.Size = New System.Drawing.Size(74, 17)
        Me.RbFinanceira.TabIndex = 1
        Me.RbFinanceira.TabStop = True
        Me.RbFinanceira.Text = "Financeira"
        Me.RbFinanceira.UseVisualStyleBackColor = True
        '
        'RbAdministrativa
        '
        Me.RbAdministrativa.AutoSize = True
        Me.RbAdministrativa.Location = New System.Drawing.Point(9, 19)
        Me.RbAdministrativa.Name = "RbAdministrativa"
        Me.RbAdministrativa.Size = New System.Drawing.Size(90, 17)
        Me.RbAdministrativa.TabIndex = 0
        Me.RbAdministrativa.TabStop = True
        Me.RbAdministrativa.Text = "Administrativa"
        Me.RbAdministrativa.UseVisualStyleBackColor = True
        '
        'CkbAtivo
        '
        Me.CkbAtivo.AutoSize = True
        Me.CkbAtivo.Location = New System.Drawing.Point(349, 38)
        Me.CkbAtivo.Name = "CkbAtivo"
        Me.CkbAtivo.Size = New System.Drawing.Size(50, 17)
        Me.CkbAtivo.TabIndex = 37
        Me.CkbAtivo.Text = "Ativo"
        Me.CkbAtivo.UseVisualStyleBackColor = True
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
        Me.Dgv.TabIndex = 4
        Me.Dgv.VirtualMode = True
        '
        'FrmTipoReceita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(439, 283)
        Me.Name = "FrmTipoReceita"
        Me.Text = "FrmTipoReceita"
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CkbPe As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RbImpostoVenda As RadioButton
    Friend WithEvents RbFinanceira As RadioButton
    Friend WithEvents RbAdministrativa As RadioButton
    Friend WithEvents CkbAtivo As CheckBox
    Public WithEvents Dgv As DataGridView
End Class
