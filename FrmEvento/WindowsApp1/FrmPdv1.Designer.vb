<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPdv1
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
        Me.LbNomeUsuario = New System.Windows.Forms.Label()
        Me.lbLicencia = New System.Windows.Forms.Label()
        Me.LbPermissaoUsuario = New System.Windows.Forms.Label()
        Me.LbNomEvento = New System.Windows.Forms.Label()
        Me.LbCodEvento = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LbDescricao = New System.Windows.Forms.Label()
        Me.TxtCodItem = New System.Windows.Forms.TextBox()
        Me.TxtQtde = New System.Windows.Forms.TextBox()
        Me.DgvItemVenda = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PrintDocRelResumoVenda = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.BtnResumoVenda = New System.Windows.Forms.Button()
        Me.BtnImprimirIngresso = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DgvItemVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbNomeUsuario
        '
        Me.LbNomeUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNomeUsuario.AutoSize = True
        Me.LbNomeUsuario.Location = New System.Drawing.Point(662, 15)
        Me.LbNomeUsuario.Name = "LbNomeUsuario"
        Me.LbNomeUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LbNomeUsuario.TabIndex = 0
        Me.LbNomeUsuario.Text = "Usuário"
        '
        'lbLicencia
        '
        Me.lbLicencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbLicencia.AutoSize = True
        Me.lbLicencia.Location = New System.Drawing.Point(674, 523)
        Me.lbLicencia.Name = "lbLicencia"
        Me.lbLicencia.Size = New System.Drawing.Size(39, 13)
        Me.lbLicencia.TabIndex = 1
        Me.lbLicencia.Text = "Label2"
        '
        'LbPermissaoUsuario
        '
        Me.LbPermissaoUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbPermissaoUsuario.AutoSize = True
        Me.LbPermissaoUsuario.Location = New System.Drawing.Point(662, 28)
        Me.LbPermissaoUsuario.Name = "LbPermissaoUsuario"
        Me.LbPermissaoUsuario.Size = New System.Drawing.Size(55, 13)
        Me.LbPermissaoUsuario.TabIndex = 2
        Me.LbPermissaoUsuario.Text = "Permissão"
        '
        'LbNomEvento
        '
        Me.LbNomEvento.AutoSize = True
        Me.LbNomEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomEvento.Location = New System.Drawing.Point(74, 15)
        Me.LbNomEvento.Name = "LbNomEvento"
        Me.LbNomEvento.Size = New System.Drawing.Size(69, 24)
        Me.LbNomEvento.TabIndex = 4
        Me.LbNomEvento.Text = "Evento"
        '
        'LbCodEvento
        '
        Me.LbCodEvento.AutoSize = True
        Me.LbCodEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodEvento.Location = New System.Drawing.Point(6, 15)
        Me.LbCodEvento.Name = "LbCodEvento"
        Me.LbCodEvento.Size = New System.Drawing.Size(42, 24)
        Me.LbCodEvento.TabIndex = 3
        Me.LbCodEvento.Text = "cod"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 31)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Quantidade:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 31)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Item:"
        '
        'LbDescricao
        '
        Me.LbDescricao.AutoSize = True
        Me.LbDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDescricao.Location = New System.Drawing.Point(381, 12)
        Me.LbDescricao.Name = "LbDescricao"
        Me.LbDescricao.Size = New System.Drawing.Size(0, 31)
        Me.LbDescricao.TabIndex = 7
        '
        'TxtCodItem
        '
        Me.TxtCodItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodItem.Location = New System.Drawing.Point(176, 9)
        Me.TxtCodItem.Name = "TxtCodItem"
        Me.TxtCodItem.Size = New System.Drawing.Size(199, 38)
        Me.TxtCodItem.TabIndex = 8
        '
        'TxtQtde
        '
        Me.TxtQtde.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQtde.Location = New System.Drawing.Point(176, 63)
        Me.TxtQtde.Name = "TxtQtde"
        Me.TxtQtde.Size = New System.Drawing.Size(199, 38)
        Me.TxtQtde.TabIndex = 9
        '
        'DgvItemVenda
        '
        Me.DgvItemVenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItemVenda.Location = New System.Drawing.Point(12, 175)
        Me.DgvItemVenda.Name = "DgvItemVenda"
        Me.DgvItemVenda.Size = New System.Drawing.Size(575, 361)
        Me.DgvItemVenda.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LbNomEvento)
        Me.GroupBox1.Controls.Add(Me.LbCodEvento)
        Me.GroupBox1.Controls.Add(Me.LbNomeUsuario)
        Me.GroupBox1.Controls.Add(Me.LbPermissaoUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 45)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'PrintDocRelResumoVenda
        '
        '
        'PrintDocument1
        '
        '
        'PrintDocument3
        '
        '
        'BtnResumoVenda
        '
        Me.BtnResumoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnResumoVenda.Location = New System.Drawing.Point(652, 439)
        Me.BtnResumoVenda.Name = "BtnResumoVenda"
        Me.BtnResumoVenda.Size = New System.Drawing.Size(136, 29)
        Me.BtnResumoVenda.TabIndex = 12
        Me.BtnResumoVenda.Text = "Rel. Resumo Venda"
        Me.BtnResumoVenda.UseVisualStyleBackColor = True
        '
        'BtnImprimirIngresso
        '
        Me.BtnImprimirIngresso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImprimirIngresso.Location = New System.Drawing.Point(652, 474)
        Me.BtnImprimirIngresso.Name = "BtnImprimirIngresso"
        Me.BtnImprimirIngresso.Size = New System.Drawing.Size(136, 29)
        Me.BtnImprimirIngresso.TabIndex = 13
        Me.BtnImprimirIngresso.Text = "Imprimir Ingresso"
        Me.BtnImprimirIngresso.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TxtCodItem)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LbDescricao)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtQtde)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 112)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 539)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "VieiraSystem Fone:  (034)99645-1318"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(652, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 29)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Cadastro de Item"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmPdv1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 554)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnImprimirIngresso)
        Me.Controls.Add(Me.BtnResumoVenda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvItemVenda)
        Me.Controls.Add(Me.lbLicencia)
        Me.Name = "FrmPdv1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPdv1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvItemVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbNomeUsuario As Label
    Friend WithEvents lbLicencia As Label
    Friend WithEvents LbPermissaoUsuario As Label
    Friend WithEvents LbNomEvento As Label
    Friend WithEvents LbCodEvento As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LbDescricao As Label
    Friend WithEvents TxtCodItem As TextBox
    Friend WithEvents TxtQtde As TextBox
    Friend WithEvents DgvItemVenda As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PrintDocRelResumoVenda As Printing.PrintDocument
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintDocument3 As Printing.PrintDocument
    Friend WithEvents BtnResumoVenda As Button
    Friend WithEvents BtnImprimirIngresso As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
