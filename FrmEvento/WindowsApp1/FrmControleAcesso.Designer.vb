<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControleAcesso
    Inherits Controles.FrmPadrao

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmControleAcesso))
        Me.DgvUsuario = New System.Windows.Forms.DataGridView()
        Me.DgvGrupo = New System.Windows.Forms.DataGridView()
        Me.BtnCadUsuario = New System.Windows.Forms.Button()
        Me.BtnUsuarioAcesso = New System.Windows.Forms.Button()
        Me.BtnGrupoAcesso = New System.Windows.Forms.Button()
        Me.BtnCadGrupo = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TrvAcesso = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnCopiaOutroUser = New System.Windows.Forms.Button()
        Me.TxbUsuarioCopia = New Controles.TxbDescricao()
        Me.BtnBuscaOutroUser = New System.Windows.Forms.Button()
        Me.BtnVoltarTelaPrinc = New System.Windows.Forms.Button()
        Me.TxbDesFiltroTela = New Controles.TxbDescricao()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnFiltroTela = New System.Windows.Forms.Button()
        Me.BtnRemoverTodos = New System.Windows.Forms.Button()
        Me.BtnLiberarTodos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvUsuario
        '
        Me.DgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsuario.Location = New System.Drawing.Point(3, 35)
        Me.DgvUsuario.Name = "DgvUsuario"
        Me.DgvUsuario.Size = New System.Drawing.Size(374, 150)
        Me.DgvUsuario.TabIndex = 0
        '
        'DgvGrupo
        '
        Me.DgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvGrupo.Location = New System.Drawing.Point(3, 217)
        Me.DgvGrupo.Name = "DgvGrupo"
        Me.DgvGrupo.Size = New System.Drawing.Size(374, 150)
        Me.DgvGrupo.TabIndex = 1
        '
        'BtnCadUsuario
        '
        Me.BtnCadUsuario.Image = CType(resources.GetObject("BtnCadUsuario.Image"), System.Drawing.Image)
        Me.BtnCadUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCadUsuario.Location = New System.Drawing.Point(3, 6)
        Me.BtnCadUsuario.Name = "BtnCadUsuario"
        Me.BtnCadUsuario.Size = New System.Drawing.Size(187, 23)
        Me.BtnCadUsuario.TabIndex = 2
        Me.BtnCadUsuario.Text = "Cadastro Usuário"
        Me.BtnCadUsuario.UseVisualStyleBackColor = True
        '
        'BtnUsuarioAcesso
        '
        Me.BtnUsuarioAcesso.Image = CType(resources.GetObject("BtnUsuarioAcesso.Image"), System.Drawing.Image)
        Me.BtnUsuarioAcesso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUsuarioAcesso.Location = New System.Drawing.Point(190, 6)
        Me.BtnUsuarioAcesso.Name = "BtnUsuarioAcesso"
        Me.BtnUsuarioAcesso.Size = New System.Drawing.Size(187, 23)
        Me.BtnUsuarioAcesso.TabIndex = 3
        Me.BtnUsuarioAcesso.Text = "Permissão Acesso"
        Me.BtnUsuarioAcesso.UseVisualStyleBackColor = True
        '
        'BtnGrupoAcesso
        '
        Me.BtnGrupoAcesso.Image = CType(resources.GetObject("BtnGrupoAcesso.Image"), System.Drawing.Image)
        Me.BtnGrupoAcesso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrupoAcesso.Location = New System.Drawing.Point(190, 191)
        Me.BtnGrupoAcesso.Name = "BtnGrupoAcesso"
        Me.BtnGrupoAcesso.Size = New System.Drawing.Size(187, 23)
        Me.BtnGrupoAcesso.TabIndex = 5
        Me.BtnGrupoAcesso.Text = "Acesso"
        Me.BtnGrupoAcesso.UseVisualStyleBackColor = True
        '
        'BtnCadGrupo
        '
        Me.BtnCadGrupo.Image = CType(resources.GetObject("BtnCadGrupo.Image"), System.Drawing.Image)
        Me.BtnCadGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCadGrupo.Location = New System.Drawing.Point(3, 191)
        Me.BtnCadGrupo.Name = "BtnCadGrupo"
        Me.BtnCadGrupo.Size = New System.Drawing.Size(187, 23)
        Me.BtnCadGrupo.TabIndex = 4
        Me.BtnCadGrupo.Text = "Cadastro Grupo"
        Me.BtnCadGrupo.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(387, 399)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DgvUsuario)
        Me.TabPage1.Controls.Add(Me.BtnGrupoAcesso)
        Me.TabPage1.Controls.Add(Me.DgvGrupo)
        Me.TabPage1.Controls.Add(Me.BtnCadGrupo)
        Me.TabPage1.Controls.Add(Me.BtnCadUsuario)
        Me.TabPage1.Controls.Add(Me.BtnUsuarioAcesso)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(379, 373)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TrvAcesso)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(379, 373)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TrvAcesso
        '
        Me.TrvAcesso.ImageIndex = 0
        Me.TrvAcesso.ImageList = Me.ImageList1
        Me.TrvAcesso.Location = New System.Drawing.Point(3, 3)
        Me.TrvAcesso.Name = "TrvAcesso"
        Me.TrvAcesso.SelectedImageIndex = 0
        Me.TrvAcesso.Size = New System.Drawing.Size(373, 263)
        Me.TrvAcesso.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "pasta fechada.png")
        Me.ImageList1.Images.SetKeyName(1, "pasta aberta.png")
        Me.ImageList1.Images.SetKeyName(2, "Não validado.png")
        Me.ImageList1.Images.SetKeyName(3, "validado.png")
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.BtnVoltarTelaPrinc)
        Me.GroupBox2.Controls.Add(Me.TxbDesFiltroTela)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BtnFiltroTela)
        Me.GroupBox2.Controls.Add(Me.BtnRemoverTodos)
        Me.GroupBox2.Controls.Add(Me.BtnLiberarTodos)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 268)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(367, 100)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnCopiaOutroUser)
        Me.GroupBox3.Controls.Add(Me.TxbUsuarioCopia)
        Me.GroupBox3.Controls.Add(Me.BtnBuscaOutroUser)
        Me.GroupBox3.Location = New System.Drawing.Point(190, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(173, 61)
        Me.GroupBox3.TabIndex = 52
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Copíar de outro Usuário/Grupo"
        '
        'BtnCopiaOutroUser
        '
        Me.BtnCopiaOutroUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopiaOutroUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCopiaOutroUser.Location = New System.Drawing.Point(6, 36)
        Me.BtnCopiaOutroUser.Name = "BtnCopiaOutroUser"
        Me.BtnCopiaOutroUser.Size = New System.Drawing.Size(165, 23)
        Me.BtnCopiaOutroUser.TabIndex = 48
        Me.BtnCopiaOutroUser.Text = "Copiar de outro Usuário"
        Me.BtnCopiaOutroUser.UseVisualStyleBackColor = True
        '
        'TxbUsuarioCopia
        '
        Me.TxbUsuarioCopia.Location = New System.Drawing.Point(6, 14)
        Me.TxbUsuarioCopia.Name = "TxbUsuarioCopia"
        Me.TxbUsuarioCopia.Size = New System.Drawing.Size(142, 20)
        Me.TxbUsuarioCopia.TabIndex = 50
        '
        'BtnBuscaOutroUser
        '
        Me.BtnBuscaOutroUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaOutroUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnBuscaOutroUser.Image = CType(resources.GetObject("BtnBuscaOutroUser.Image"), System.Drawing.Image)
        Me.BtnBuscaOutroUser.Location = New System.Drawing.Point(151, 14)
        Me.BtnBuscaOutroUser.Name = "BtnBuscaOutroUser"
        Me.BtnBuscaOutroUser.Size = New System.Drawing.Size(20, 20)
        Me.BtnBuscaOutroUser.TabIndex = 51
        Me.BtnBuscaOutroUser.UseVisualStyleBackColor = True
        '
        'BtnVoltarTelaPrinc
        '
        Me.BtnVoltarTelaPrinc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVoltarTelaPrinc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVoltarTelaPrinc.Location = New System.Drawing.Point(0, 9)
        Me.BtnVoltarTelaPrinc.Name = "BtnVoltarTelaPrinc"
        Me.BtnVoltarTelaPrinc.Size = New System.Drawing.Size(162, 23)
        Me.BtnVoltarTelaPrinc.TabIndex = 48
        Me.BtnVoltarTelaPrinc.Text = "Voltar Tela Principal"
        Me.BtnVoltarTelaPrinc.UseVisualStyleBackColor = True
        '
        'TxbDesFiltroTela
        '
        Me.TxbDesFiltroTela.Location = New System.Drawing.Point(198, 12)
        Me.TxbDesFiltroTela.Name = "TxbDesFiltroTela"
        Me.TxbDesFiltroTela.Size = New System.Drawing.Size(142, 20)
        Me.TxbDesFiltroTela.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filtro:"
        '
        'BtnFiltroTela
        '
        Me.BtnFiltroTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFiltroTela.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnFiltroTela.Image = CType(resources.GetObject("BtnFiltroTela.Image"), System.Drawing.Image)
        Me.BtnFiltroTela.Location = New System.Drawing.Point(343, 12)
        Me.BtnFiltroTela.Name = "BtnFiltroTela"
        Me.BtnFiltroTela.Size = New System.Drawing.Size(20, 20)
        Me.BtnFiltroTela.TabIndex = 47
        Me.BtnFiltroTela.UseVisualStyleBackColor = True
        '
        'BtnRemoverTodos
        '
        Me.BtnRemoverTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoverTodos.Image = Global.WindowsApp1.My.Resources.Resources.Não_validado
        Me.BtnRemoverTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRemoverTodos.Location = New System.Drawing.Point(0, 72)
        Me.BtnRemoverTodos.Name = "BtnRemoverTodos"
        Me.BtnRemoverTodos.Size = New System.Drawing.Size(162, 23)
        Me.BtnRemoverTodos.TabIndex = 4
        Me.BtnRemoverTodos.Text = "Remover todos Acesso"
        Me.BtnRemoverTodos.UseVisualStyleBackColor = True
        '
        'BtnLiberarTodos
        '
        Me.BtnLiberarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLiberarTodos.Image = Global.WindowsApp1.My.Resources.Resources.validado
        Me.BtnLiberarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLiberarTodos.Location = New System.Drawing.Point(0, 40)
        Me.BtnLiberarTodos.Name = "BtnLiberarTodos"
        Me.BtnLiberarTodos.Size = New System.Drawing.Size(162, 23)
        Me.BtnLiberarTodos.TabIndex = 3
        Me.BtnLiberarTodos.Text = "Liberar todos Acesso"
        Me.BtnLiberarTodos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 33)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User"
        '
        'FrmControleAcesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(389, 415)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmControleAcesso"
        Me.Text = "FrmControleAcesso"
        CType(Me.DgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvUsuario As DataGridView
    Friend WithEvents DgvGrupo As DataGridView
    Friend WithEvents BtnCadUsuario As Button
    Friend WithEvents BtnUsuarioAcesso As Button
    Friend WithEvents BtnGrupoAcesso As Button
    Friend WithEvents BtnCadGrupo As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TrvAcesso As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnRemoverTodos As Button
    Friend WithEvents BtnLiberarTodos As Button
    Friend WithEvents TxbDesFiltroTela As Controles.TxbDescricao
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnFiltroTela As Button
    Friend WithEvents BtnCopiaOutroUser As Button
    Friend WithEvents TxbUsuarioCopia As Controles.TxbDescricao
    Friend WithEvents BtnBuscaOutroUser As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnVoltarTelaPrinc As Button
End Class
