<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCad1Padrao
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
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCad1Padrao))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnUltimoReg = New System.Windows.Forms.Button()
        Me.BtnProximo = New System.Windows.Forms.Button()
        Me.BtnPrimeiroReg = New System.Windows.Forms.Button()
        Me.BtnCsv = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnGrid = New System.Windows.Forms.Button()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxbDescricao = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxbCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.BtnUltimoReg)
        Me.GroupBox2.Controls.Add(Me.BtnProximo)
        Me.GroupBox2.Controls.Add(Me.BtnPrimeiroReg)
        Me.GroupBox2.Controls.Add(Me.BtnCsv)
        Me.GroupBox2.Controls.Add(Me.BtnAnterior)
        Me.GroupBox2.Controls.Add(Me.BtnGrid)
        Me.GroupBox2.Controls.Add(Me.BtnPesquisa)
        Me.GroupBox2.Controls.Add(Me.BtnLimpar)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.Controls.Add(Me.BtnExcluir)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(7, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 46)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'BtnUltimoReg
        '
        Me.BtnUltimoReg.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnUltimoReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnUltimoReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUltimoReg.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUltimoReg.Image = CType(resources.GetObject("BtnUltimoReg.Image"), System.Drawing.Image)
        Me.BtnUltimoReg.Location = New System.Drawing.Point(294, 10)
        Me.BtnUltimoReg.Name = "BtnUltimoReg"
        Me.BtnUltimoReg.Size = New System.Drawing.Size(31, 31)
        Me.BtnUltimoReg.TabIndex = 11
        Me.BtnUltimoReg.UseVisualStyleBackColor = True
        '
        'BtnProximo
        '
        Me.BtnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProximo.ForeColor = System.Drawing.Color.Transparent
        Me.BtnProximo.Image = CType(resources.GetObject("BtnProximo.Image"), System.Drawing.Image)
        Me.BtnProximo.Location = New System.Drawing.Point(273, 11)
        Me.BtnProximo.Name = "BtnProximo"
        Me.BtnProximo.Size = New System.Drawing.Size(31, 31)
        Me.BtnProximo.TabIndex = 10
        Me.BtnProximo.UseVisualStyleBackColor = True
        '
        'BtnPrimeiroReg
        '
        Me.BtnPrimeiroReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrimeiroReg.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPrimeiroReg.Image = CType(resources.GetObject("BtnPrimeiroReg.Image"), System.Drawing.Image)
        Me.BtnPrimeiroReg.Location = New System.Drawing.Point(223, 10)
        Me.BtnPrimeiroReg.Name = "BtnPrimeiroReg"
        Me.BtnPrimeiroReg.Size = New System.Drawing.Size(31, 31)
        Me.BtnPrimeiroReg.TabIndex = 8
        Me.BtnPrimeiroReg.UseVisualStyleBackColor = True
        '
        'BtnCsv
        '
        Me.BtnCsv.BackColor = System.Drawing.Color.Transparent
        Me.BtnCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCsv.ForeColor = System.Drawing.Color.Black
        Me.BtnCsv.Location = New System.Drawing.Point(185, 15)
        Me.BtnCsv.Name = "BtnCsv"
        Me.BtnCsv.Size = New System.Drawing.Size(32, 23)
        Me.BtnCsv.TabIndex = 7
        Me.BtnCsv.Text = "CSV"
        Me.BtnCsv.UseVisualStyleBackColor = False
        '
        'BtnAnterior
        '
        Me.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnterior.ForeColor = System.Drawing.Color.Transparent
        Me.BtnAnterior.Image = CType(resources.GetObject("BtnAnterior.Image"), System.Drawing.Image)
        Me.BtnAnterior.Location = New System.Drawing.Point(244, 10)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(31, 31)
        Me.BtnAnterior.TabIndex = 9
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnGrid
        '
        Me.BtnGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrid.ForeColor = System.Drawing.Color.Transparent
        Me.BtnGrid.Image = CType(resources.GetObject("BtnGrid.Image"), System.Drawing.Image)
        Me.BtnGrid.Location = New System.Drawing.Point(148, 10)
        Me.BtnGrid.Name = "BtnGrid"
        Me.BtnGrid.Size = New System.Drawing.Size(31, 31)
        Me.BtnGrid.TabIndex = 6
        Me.BtnGrid.UseVisualStyleBackColor = True
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisa.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesquisa.Image = CType(resources.GetObject("BtnPesquisa.Image"), System.Drawing.Image)
        Me.BtnPesquisa.Location = New System.Drawing.Point(74, 8)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(31, 31)
        Me.BtnPesquisa.TabIndex = 4
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLimpar.Image = CType(resources.GetObject("BtnLimpar.Image"), System.Drawing.Image)
        Me.BtnLimpar.Location = New System.Drawing.Point(108, 10)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(31, 31)
        Me.BtnLimpar.TabIndex = 5
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.White
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(6, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(31, 31)
        Me.BtnSalvar.TabIndex = 2
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'BtnExcluir
        '
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluir.ForeColor = System.Drawing.Color.Transparent
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
        Me.TabControl1.Size = New System.Drawing.Size(424, 257)
        Me.TabControl1.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(416, 231)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.TxbDescricao)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.TxbCodigo)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(403, 41)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        '
        'TxbDescricao
        '
        Me.TxbDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxbDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDescricao.Location = New System.Drawing.Point(131, 12)
        Me.TxbDescricao.Name = "TxbDescricao"
        Me.TxbDescricao.Size = New System.Drawing.Size(265, 20)
        Me.TxbDescricao.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Descrição:"
        '
        'TxbCodigo
        '
        Me.TxbCodigo.Location = New System.Drawing.Point(65, 12)
        Me.TxbCodigo.Name = "TxbCodigo"
        Me.TxbCodigo.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodigo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 134)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(416, 231)
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
        'FrmCad1Padrao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(439, 283)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCad1Padrao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCad1Padrao"
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Protected WithEvents GroupBox2 As Windows.Forms.GroupBox
    Protected WithEvents BtnCsv As Windows.Forms.Button
    Protected WithEvents BtnUltimoReg As Windows.Forms.Button
    Protected WithEvents BtnAnterior As Windows.Forms.Button
    Protected WithEvents BtnProximo As Windows.Forms.Button
    Protected WithEvents BtnPrimeiroReg As Windows.Forms.Button
    Protected WithEvents BtnGrid As Windows.Forms.Button
    Protected WithEvents BtnPesquisa As Windows.Forms.Button
    Protected WithEvents BtnLimpar As Windows.Forms.Button
    Protected WithEvents BtnSalvar As Windows.Forms.Button
    Protected WithEvents BtnExcluir As Windows.Forms.Button
    Protected WithEvents TabControl1 As Windows.Forms.TabControl
    Public WithEvents TabPage1 As Windows.Forms.TabPage
    Protected WithEvents GroupBox1 As Windows.Forms.GroupBox
    Public WithEvents GroupBox4 As Windows.Forms.GroupBox
    Protected WithEvents Label18 As Windows.Forms.Label
    Public WithEvents TabPage2 As Windows.Forms.TabPage
    Protected WithEvents GroupBox3 As Windows.Forms.GroupBox
    Protected WithEvents TxbDescricao As Windows.Forms.TextBox
    Protected WithEvents TxbCodigo As Windows.Forms.TextBox
End Class
