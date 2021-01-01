<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuario))
        Me.txbSenha = New Controles.TxbDescricao()
        Me.CkbAtivo = New System.Windows.Forms.CheckBox()
        Me.BtnCadGrupo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGrupo = New System.Windows.Forms.Button()
        Me.TxbDesGrupo = New System.Windows.Forms.TextBox()
        Me.TxbCodGrupo = New Controles.TxbCodigo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dgv = New System.Windows.Forms.DataGridView()
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 163)
        Me.GroupBox1.Size = New System.Drawing.Size(406, 64)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CkbPE)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.BtnCadGrupo)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.BtnGrupo)
        Me.GroupBox4.Controls.Add(Me.TxbDesGrupo)
        Me.GroupBox4.Controls.Add(Me.TxbCodGrupo)
        Me.GroupBox4.Controls.Add(Me.CkbAtivo)
        Me.GroupBox4.Controls.Add(Me.txbSenha)
        Me.GroupBox4.Size = New System.Drawing.Size(403, 84)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodigo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label18, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDescricao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txbSenha, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.CkbAtivo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodGrupo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDesGrupo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnGrupo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label1, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnCadGrupo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label2, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.CkbPE, 0)
        '
        'Label18
        '
        Me.Label18.Size = New System.Drawing.Size(46, 13)
        Me.Label18.Text = "Usuário:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv)
        '
        'TxbDescricao
        '
        Me.TxbDescricao.Size = New System.Drawing.Size(267, 20)
        '
        'txbSenha
        '
        Me.txbSenha.Location = New System.Drawing.Point(65, 58)
        Me.txbSenha.Name = "txbSenha"
        Me.txbSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbSenha.Size = New System.Drawing.Size(142, 20)
        Me.txbSenha.TabIndex = 6
        '
        'CkbAtivo
        '
        Me.CkbAtivo.AutoSize = True
        Me.CkbAtivo.Location = New System.Drawing.Point(299, 60)
        Me.CkbAtivo.Name = "CkbAtivo"
        Me.CkbAtivo.Size = New System.Drawing.Size(50, 17)
        Me.CkbAtivo.TabIndex = 7
        Me.CkbAtivo.Text = "Ativo"
        Me.CkbAtivo.UseVisualStyleBackColor = True
        '
        'BtnCadGrupo
        '
        Me.BtnCadGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadGrupo.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCadGrupo.Location = New System.Drawing.Point(378, 35)
        Me.BtnCadGrupo.Name = "BtnCadGrupo"
        Me.BtnCadGrupo.Size = New System.Drawing.Size(20, 20)
        Me.BtnCadGrupo.TabIndex = 5
        Me.BtnCadGrupo.Text = "C"
        Me.BtnCadGrupo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Grupo:"
        '
        'BtnGrupo
        '
        Me.BtnGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrupo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnGrupo.Image = CType(resources.GetObject("BtnGrupo.Image"), System.Drawing.Image)
        Me.BtnGrupo.Location = New System.Drawing.Point(355, 35)
        Me.BtnGrupo.Name = "BtnGrupo"
        Me.BtnGrupo.Size = New System.Drawing.Size(20, 20)
        Me.BtnGrupo.TabIndex = 4
        Me.BtnGrupo.UseVisualStyleBackColor = True
        '
        'TxbDesGrupo
        '
        Me.TxbDesGrupo.Location = New System.Drawing.Point(131, 35)
        Me.TxbDesGrupo.Name = "TxbDesGrupo"
        Me.TxbDesGrupo.Size = New System.Drawing.Size(221, 20)
        Me.TxbDesGrupo.TabIndex = 3
        '
        'TxbCodGrupo
        '
        Me.TxbCodGrupo.Location = New System.Drawing.Point(65, 35)
        Me.TxbCodGrupo.Name = "TxbCodGrupo"
        Me.TxbCodGrupo.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodGrupo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Senha:"
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
        'CkbPE
        '
        Me.CkbPE.AutoSize = True
        Me.CkbPE.Location = New System.Drawing.Point(355, 60)
        Me.CkbPE.Name = "CkbPE"
        Me.CkbPE.Size = New System.Drawing.Size(43, 17)
        Me.CkbPE.TabIndex = 8
        Me.CkbPE.Text = "P.E"
        Me.CkbPE.UseVisualStyleBackColor = True
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(439, 283)
        Me.Name = "FrmUsuario"
        Me.Text = "FrmUsuario"
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

    Friend WithEvents CkbAtivo As CheckBox
    Friend WithEvents txbSenha As Controles.TxbDescricao
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCadGrupo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnGrupo As Button
    Friend WithEvents TxbDesGrupo As TextBox
    Friend WithEvents TxbCodGrupo As Controles.TxbCodigo
    Public WithEvents Dgv As DataGridView
    Friend WithEvents CkbPE As CheckBox
End Class
