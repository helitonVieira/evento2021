<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadPadrao
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    Public components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadPadrao))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnCsv = New System.Windows.Forms.Button()
        Me.BtnUltimoReg = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnProximo = New System.Windows.Forms.Button()
        Me.BtnPrimeiroReg = New System.Windows.Forms.Button()
        Me.BtnGrid = New System.Windows.Forms.Button()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxbDescricao = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxbCodigo = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.BtnCsv)
        Me.GroupBox2.Controls.Add(Me.BtnUltimoReg)
        Me.GroupBox2.Controls.Add(Me.BtnAnterior)
        Me.GroupBox2.Controls.Add(Me.BtnProximo)
        Me.GroupBox2.Controls.Add(Me.BtnPrimeiroReg)
        Me.GroupBox2.Controls.Add(Me.BtnGrid)
        Me.GroupBox2.Controls.Add(Me.BtnPesquisa)
        Me.GroupBox2.Controls.Add(Me.BtnLimpar)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.Controls.Add(Me.BtnExcluir)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 46)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'BtnCsv
        '
        Me.BtnCsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCsv.Location = New System.Drawing.Point(176, 10)
        Me.BtnCsv.Name = "BtnCsv"
        Me.BtnCsv.Size = New System.Drawing.Size(31, 31)
        Me.BtnCsv.TabIndex = 7
        Me.BtnCsv.Text = "CSV"
        Me.BtnCsv.UseVisualStyleBackColor = True
        '
        'BtnUltimoReg
        '
        Me.BtnUltimoReg.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnUltimoReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnUltimoReg.Image = CType(resources.GetObject("BtnUltimoReg.Image"), System.Drawing.Image)
        Me.BtnUltimoReg.Location = New System.Drawing.Point(312, 10)
        Me.BtnUltimoReg.Name = "BtnUltimoReg"
        Me.BtnUltimoReg.Size = New System.Drawing.Size(31, 31)
        Me.BtnUltimoReg.TabIndex = 11
        Me.BtnUltimoReg.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.Image = CType(resources.GetObject("BtnAnterior.Image"), System.Drawing.Image)
        Me.BtnAnterior.Location = New System.Drawing.Point(244, 10)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(31, 31)
        Me.BtnAnterior.TabIndex = 9
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnProximo
        '
        Me.BtnProximo.Image = CType(resources.GetObject("BtnProximo.Image"), System.Drawing.Image)
        Me.BtnProximo.Location = New System.Drawing.Point(278, 10)
        Me.BtnProximo.Name = "BtnProximo"
        Me.BtnProximo.Size = New System.Drawing.Size(31, 31)
        Me.BtnProximo.TabIndex = 10
        Me.BtnProximo.UseVisualStyleBackColor = True
        '
        'BtnPrimeiroReg
        '
        Me.BtnPrimeiroReg.Image = CType(resources.GetObject("BtnPrimeiroReg.Image"), System.Drawing.Image)
        Me.BtnPrimeiroReg.Location = New System.Drawing.Point(210, 10)
        Me.BtnPrimeiroReg.Name = "BtnPrimeiroReg"
        Me.BtnPrimeiroReg.Size = New System.Drawing.Size(31, 31)
        Me.BtnPrimeiroReg.TabIndex = 8
        Me.BtnPrimeiroReg.UseVisualStyleBackColor = True
        '
        'BtnGrid
        '
        Me.BtnGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnGrid.Image = CType(resources.GetObject("BtnGrid.Image"), System.Drawing.Image)
        Me.BtnGrid.Location = New System.Drawing.Point(142, 10)
        Me.BtnGrid.Name = "BtnGrid"
        Me.BtnGrid.Size = New System.Drawing.Size(31, 31)
        Me.BtnGrid.TabIndex = 6
        Me.BtnGrid.UseVisualStyleBackColor = True
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.Image = CType(resources.GetObject("BtnPesquisa.Image"), System.Drawing.Image)
        Me.BtnPesquisa.Location = New System.Drawing.Point(74, 10)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(31, 31)
        Me.BtnPesquisa.TabIndex = 4
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Image = CType(resources.GetObject("BtnLimpar.Image"), System.Drawing.Image)
        Me.BtnLimpar.Location = New System.Drawing.Point(108, 10)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(31, 31)
        Me.BtnLimpar.TabIndex = 5
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(6, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(31, 31)
        Me.BtnSalvar.TabIndex = 2
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.Location = New System.Drawing.Point(40, 10)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(31, 31)
        Me.BtnExcluir.TabIndex = 3
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(7, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(425, 256)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(417, 230)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 163)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.TxbDescricao)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.TxbCodigo)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(404, 54)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Espécie"
        '
        'TxbDescricao
        '
        Me.TxbDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxbDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDescricao.Location = New System.Drawing.Point(131, 21)
        Me.TxbDescricao.Name = "TxbDescricao"
        Me.TxbDescricao.Size = New System.Drawing.Size(266, 20)
        Me.TxbDescricao.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Descrição:"
        '
        'TxbCodigo
        '
        Me.TxbCodigo.Location = New System.Drawing.Point(65, 21)
        Me.TxbCodigo.Name = "TxbCodigo"
        Me.TxbCodigo.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodigo.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(417, 230)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Location = New System.Drawing.Point(3, -3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(411, 227)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'FrmCadPadrao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 283)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCadPadrao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCadPadrao"
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxbCodigo As TextBox
    Friend WithEvents TxbDescricao As TextBox
    Protected WithEvents BtnExcluir As Button
    Protected WithEvents GroupBox2 As GroupBox
    Public WithEvents GroupBox4 As GroupBox
    Protected WithEvents BtnCsv As Button
    Protected WithEvents BtnUltimoReg As Button
    Protected WithEvents BtnAnterior As Button
    Protected WithEvents BtnProximo As Button
    Protected WithEvents BtnPrimeiroReg As Button
    Protected WithEvents BtnGrid As Button
    Protected WithEvents BtnLimpar As Button
    Public WithEvents TabPage1 As TabPage
    Protected WithEvents BtnPesquisa As Button
    Protected WithEvents BtnSalvar As Button
    Protected WithEvents TabControl1 As TabControl
    Public WithEvents TabPage2 As TabPage
    Protected WithEvents GroupBox1 As GroupBox
    Protected WithEvents GroupBox3 As GroupBox
    Protected WithEvents Label18 As Label
End Class
