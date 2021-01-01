<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPdv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPdv))
        Me.BtnCadEmpresa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtEmpresa = New System.Windows.Forms.Button()
        Me.txbNomEmpresa = New System.Windows.Forms.TextBox()
        Me.TxbCodEmpresa = New Controles.TxbCodigo()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.CkbAtivo = New System.Windows.Forms.CheckBox()
        Me.CkbPE = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxbHostName = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 153)
        Me.GroupBox1.Size = New System.Drawing.Size(406, 74)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxbHostName)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.BtnCadEmpresa)
        Me.GroupBox4.Controls.Add(Me.BtEmpresa)
        Me.GroupBox4.Controls.Add(Me.txbNomEmpresa)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TxbCodEmpresa)
        Me.GroupBox4.Size = New System.Drawing.Size(403, 85)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodigo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label18, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDescricao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodEmpresa, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label1, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.GroupBox5, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txbNomEmpresa, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtEmpresa, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtnCadEmpresa, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label2, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbHostName, 0)
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(0, 16)
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.Text = "PDV:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv)
        '
        'BtnCadEmpresa
        '
        Me.BtnCadEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadEmpresa.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCadEmpresa.Location = New System.Drawing.Point(373, 35)
        Me.BtnCadEmpresa.Name = "BtnCadEmpresa"
        Me.BtnCadEmpresa.Size = New System.Drawing.Size(23, 20)
        Me.BtnCadEmpresa.TabIndex = 82
        Me.BtnCadEmpresa.Text = "C"
        Me.BtnCadEmpresa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Empresa:"
        '
        'BtEmpresa
        '
        Me.BtEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEmpresa.ForeColor = System.Drawing.Color.Gray
        Me.BtEmpresa.Image = CType(resources.GetObject("BtEmpresa.Image"), System.Drawing.Image)
        Me.BtEmpresa.Location = New System.Drawing.Point(348, 35)
        Me.BtEmpresa.Name = "BtEmpresa"
        Me.BtEmpresa.Size = New System.Drawing.Size(23, 20)
        Me.BtEmpresa.TabIndex = 81
        Me.BtEmpresa.UseVisualStyleBackColor = True
        '
        'txbNomEmpresa
        '
        Me.txbNomEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbNomEmpresa.Location = New System.Drawing.Point(131, 35)
        Me.txbNomEmpresa.Name = "txbNomEmpresa"
        Me.txbNomEmpresa.Size = New System.Drawing.Size(215, 20)
        Me.txbNomEmpresa.TabIndex = 80
        '
        'TxbCodEmpresa
        '
        Me.TxbCodEmpresa.Location = New System.Drawing.Point(65, 35)
        Me.TxbCodEmpresa.Name = "TxbCodEmpresa"
        Me.TxbCodEmpresa.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodEmpresa.TabIndex = 79
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
        'CkbAtivo
        '
        Me.CkbAtivo.AutoSize = True
        Me.CkbAtivo.Location = New System.Drawing.Point(6, 8)
        Me.CkbAtivo.Name = "CkbAtivo"
        Me.CkbAtivo.Size = New System.Drawing.Size(50, 17)
        Me.CkbAtivo.TabIndex = 83
        Me.CkbAtivo.Text = "Ativo"
        Me.CkbAtivo.UseVisualStyleBackColor = True
        '
        'CkbPE
        '
        Me.CkbPE.AutoSize = True
        Me.CkbPE.Location = New System.Drawing.Point(65, 8)
        Me.CkbPE.Name = "CkbPE"
        Me.CkbPE.Size = New System.Drawing.Size(43, 17)
        Me.CkbPE.TabIndex = 84
        Me.CkbPE.Text = "P.E"
        Me.CkbPE.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CkbAtivo)
        Me.GroupBox5.Controls.Add(Me.CkbPE)
        Me.GroupBox5.Location = New System.Drawing.Point(290, 53)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(106, 26)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Host Name:"
        '
        'TxbHostName
        '
        Me.TxbHostName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbHostName.Location = New System.Drawing.Point(65, 58)
        Me.TxbHostName.Name = "TxbHostName"
        Me.TxbHostName.Size = New System.Drawing.Size(215, 20)
        Me.TxbHostName.TabIndex = 84
        '
        'FrmPdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(439, 283)
        Me.Name = "FrmPdv"
        Me.Text = "FrmPDV"
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCadEmpresa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtEmpresa As Button
    Friend WithEvents txbNomEmpresa As TextBox
    Friend WithEvents TxbCodEmpresa As Controles.TxbCodigo
    Friend WithEvents CkbAtivo As CheckBox
    Public WithEvents Dgv As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CkbPE As CheckBox
    Friend WithEvents TxbHostName As TextBox
    Friend WithEvents Label2 As Label
End Class
