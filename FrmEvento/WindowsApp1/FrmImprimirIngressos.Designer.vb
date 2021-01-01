<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmImprimirIngressos
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
        Me.DgvEvento = New System.Windows.Forms.DataGridView()
        Me.GroupBoxVendas = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LbFonte = New System.Windows.Forms.Label()
        Me.CbFonte = New System.Windows.Forms.ComboBox()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckbTeste = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodEvento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbDescricao = New System.Windows.Forms.Label()
        Me.TxtQtde = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.DgvEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxVendas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvEvento
        '
        Me.DgvEvento.AllowUserToAddRows = False
        Me.DgvEvento.AllowUserToDeleteRows = False
        Me.DgvEvento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEvento.Location = New System.Drawing.Point(6, 129)
        Me.DgvEvento.Name = "DgvEvento"
        Me.DgvEvento.ReadOnly = True
        Me.DgvEvento.Size = New System.Drawing.Size(740, 201)
        Me.DgvEvento.TabIndex = 0
        '
        'GroupBoxVendas
        '
        Me.GroupBoxVendas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxVendas.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBoxVendas.Controls.Add(Me.GroupBox2)
        Me.GroupBoxVendas.Controls.Add(Me.GroupBox1)
        Me.GroupBoxVendas.Controls.Add(Me.DgvEvento)
        Me.GroupBoxVendas.Location = New System.Drawing.Point(2, 0)
        Me.GroupBoxVendas.Name = "GroupBoxVendas"
        Me.GroupBoxVendas.Size = New System.Drawing.Size(752, 336)
        Me.GroupBoxVendas.TabIndex = 12
        Me.GroupBoxVendas.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LbFonte)
        Me.GroupBox2.Controls.Add(Me.CbFonte)
        Me.GroupBox2.Controls.Add(Me.BtnOK)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(740, 39)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fonte"
        '
        'LbFonte
        '
        Me.LbFonte.AutoSize = True
        Me.LbFonte.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFonte.Location = New System.Drawing.Point(361, 8)
        Me.LbFonte.Name = "LbFonte"
        Me.LbFonte.Size = New System.Drawing.Size(224, 25)
        Me.LbFonte.TabIndex = 28
        Me.LbFonte.Text = "ESCOLHA DA FONTE"
        '
        'CbFonte
        '
        Me.CbFonte.FormattingEnabled = True
        Me.CbFonte.Items.AddRange(New Object() {"Algerian", "Arial", "Arial Rounded MT", "Blackadder ITC", "Cambria Math", "Castellar", "Colonna MT", "Edwardian Script ITC", "Harlow Solid", "Mistral", "Old English Text MT", "Ravie", "Times New Roman", "Vivaldi"})
        Me.CbFonte.Location = New System.Drawing.Point(17, 12)
        Me.CbFonte.Name = "CbFonte"
        Me.CbFonte.Size = New System.Drawing.Size(282, 21)
        Me.CbFonte.TabIndex = 1
        Me.CbFonte.Text = "Time New Roman"
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(305, 12)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(30, 21)
        Me.BtnOK.TabIndex = 2
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ckbTeste)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtCodEvento)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LbDescricao)
        Me.GroupBox1.Controls.Add(Me.TxtQtde)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(740, 78)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingressos"
        '
        'ckbTeste
        '
        Me.ckbTeste.AutoSize = True
        Me.ckbTeste.Location = New System.Drawing.Point(631, 16)
        Me.ckbTeste.Name = "ckbTeste"
        Me.ckbTeste.Size = New System.Drawing.Size(103, 17)
        Me.ckbTeste.TabIndex = 9
        Me.ckbTeste.Text = "testar Impressão"
        Me.ckbTeste.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(441, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = """Configurações da fonte e imagem no parametro do sistema"""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Evento:"
        '
        'TxtCodEvento
        '
        Me.TxtCodEvento.Location = New System.Drawing.Point(158, 16)
        Me.TxtCodEvento.Name = "TxtCodEvento"
        Me.TxtCodEvento.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodEvento.TabIndex = 1
        Me.TxtCodEvento.Tag = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Quantidade:"
        '
        'LbDescricao
        '
        Me.LbDescricao.AutoSize = True
        Me.LbDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDescricao.Location = New System.Drawing.Point(258, 14)
        Me.LbDescricao.Name = "LbDescricao"
        Me.LbDescricao.Size = New System.Drawing.Size(0, 25)
        Me.LbDescricao.TabIndex = 5
        '
        'TxtQtde
        '
        Me.TxtQtde.Location = New System.Drawing.Point(158, 39)
        Me.TxtQtde.Name = "TxtQtde"
        Me.TxtQtde.Size = New System.Drawing.Size(100, 20)
        Me.TxtQtde.TabIndex = 2
        Me.TxtQtde.Tag = "1"
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "///"
        '
        'FrmImprimirIngressos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 337)
        Me.Controls.Add(Me.GroupBoxVendas)
        Me.Name = "FrmImprimirIngressos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmImprimirIngressos"
        CType(Me.DgvEvento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxVendas.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvEvento As DataGridView
    Friend WithEvents GroupBoxVendas As GroupBox
    Friend WithEvents TxtCodEvento As TextBox
    Friend WithEvents LbDescricao As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtQtde As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbFonte As ComboBox
    Friend WithEvents BtnOK As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LbFonte As Label
    Friend WithEvents ckbTeste As CheckBox
End Class
