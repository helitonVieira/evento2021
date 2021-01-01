<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGrupoUsuario
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
        Me.CkbAtivo = New System.Windows.Forms.CheckBox()
        Me.CkbPE = New System.Windows.Forms.CheckBox()
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 151)
        Me.GroupBox1.Size = New System.Drawing.Size(406, 76)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CkbPE)
        Me.GroupBox4.Controls.Add(Me.CkbAtivo)
        Me.GroupBox4.Size = New System.Drawing.Size(403, 61)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodigo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label18, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDescricao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.CkbAtivo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.CkbPE, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv)
        '
        'TxbDescricao
        '
        Me.TxbDescricao.TabIndex = 2
        '
        'Dgv
        '
        Me.Dgv.AllowUserToOrderColumns = True
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv.Location = New System.Drawing.Point(3, 16)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(405, 208)
        Me.Dgv.TabIndex = 3
        Me.Dgv.VirtualMode = True
        '
        'CkbAtivo
        '
        Me.CkbAtivo.AutoSize = True
        Me.CkbAtivo.Location = New System.Drawing.Point(297, 38)
        Me.CkbAtivo.Name = "CkbAtivo"
        Me.CkbAtivo.Size = New System.Drawing.Size(50, 17)
        Me.CkbAtivo.TabIndex = 3
        Me.CkbAtivo.Text = "Ativo"
        Me.CkbAtivo.UseVisualStyleBackColor = True
        '
        'CkbPE
        '
        Me.CkbPE.AutoSize = True
        Me.CkbPE.Location = New System.Drawing.Point(353, 38)
        Me.CkbPE.Name = "CkbPE"
        Me.CkbPE.Size = New System.Drawing.Size(43, 17)
        Me.CkbPE.TabIndex = 4
        Me.CkbPE.Text = "P.E"
        Me.CkbPE.UseVisualStyleBackColor = True
        '
        'FrmGrupoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(439, 283)
        Me.Name = "FrmGrupoUsuario"
        Me.Text = "FrmGrupoUsuário"
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
    Friend WithEvents CkbAtivo As CheckBox
    Friend WithEvents CkbPE As CheckBox
End Class
