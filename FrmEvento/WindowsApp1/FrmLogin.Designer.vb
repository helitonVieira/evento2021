<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbExibirSenha = New System.Windows.Forms.CheckBox()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.BtEntrar = New System.Windows.Forms.Button()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbExibirSenha)
        Me.GroupBox1.Controls.Add(Me.BtCancelar)
        Me.GroupBox1.Controls.Add(Me.TxtSenha)
        Me.GroupBox1.Controls.Add(Me.BtEntrar)
        Me.GroupBox1.Controls.Add(Me.TxtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 98)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CbExibirSenha
        '
        Me.CbExibirSenha.AutoSize = True
        Me.CbExibirSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbExibirSenha.ForeColor = System.Drawing.Color.Black
        Me.CbExibirSenha.Location = New System.Drawing.Point(186, 64)
        Me.CbExibirSenha.Name = "CbExibirSenha"
        Me.CbExibirSenha.Size = New System.Drawing.Size(75, 16)
        Me.CbExibirSenha.TabIndex = 6
        Me.CbExibirSenha.Text = "Exibir Senha"
        Me.CbExibirSenha.UseVisualStyleBackColor = True
        '
        'BtCancelar
        '
        Me.BtCancelar.BackColor = System.Drawing.Color.White
        Me.BtCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCancelar.ForeColor = System.Drawing.Color.White
        Me.BtCancelar.Image = CType(resources.GetObject("BtCancelar.Image"), System.Drawing.Image)
        Me.BtCancelar.Location = New System.Drawing.Point(45, 64)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(29, 29)
        Me.BtCancelar.TabIndex = 5
        Me.BtCancelar.UseVisualStyleBackColor = False
        '
        'TxtSenha
        '
        Me.TxtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSenha.Location = New System.Drawing.Point(57, 39)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenha.Size = New System.Drawing.Size(204, 20)
        Me.TxtSenha.TabIndex = 2
        '
        'BtEntrar
        '
        Me.BtEntrar.BackColor = System.Drawing.Color.Transparent
        Me.BtEntrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEntrar.ForeColor = System.Drawing.Color.Transparent
        Me.BtEntrar.Image = CType(resources.GetObject("BtEntrar.Image"), System.Drawing.Image)
        Me.BtEntrar.Location = New System.Drawing.Point(10, 64)
        Me.BtEntrar.Name = "BtEntrar"
        Me.BtEntrar.Size = New System.Drawing.Size(29, 29)
        Me.BtEntrar.TabIndex = 4
        Me.BtEntrar.UseVisualStyleBackColor = False
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(57, 13)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(204, 20)
        Me.TxtUsuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(285, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "(34)99645-1318"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(275, -24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(387, 107)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbExibirSenha As CheckBox
    Friend WithEvents BtCancelar As Button
    Friend WithEvents BtEntrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
