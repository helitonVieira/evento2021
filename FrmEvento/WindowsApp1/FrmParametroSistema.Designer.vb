<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmParametroSistema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmParametroSistema))
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxbHraIniAgendaServico = New Controles.TxbCodigo()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbFontProduto = New Controles.TxbCodigo()
        Me.GbIngresso = New System.Windows.Forms.GroupBox()
        Me.txb_fontIngresso = New Controles.TxbCodigo()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxbImgIngMargCabecalho = New Controles.TxbCodigo()
        Me.TxbImgIngMargEsquerda = New Controles.TxbCodigo()
        Me.TxbImgIngLargura = New Controles.TxbCodigo()
        Me.TxbImgIngAltura = New Controles.TxbCodigo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GbIngresso.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(500, 242)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Venda"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxbHraIniAgendaServico)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(497, 80)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agenda Serviço"
        '
        'TxbHraIniAgendaServico
        '
        Me.TxbHraIniAgendaServico.Location = New System.Drawing.Point(139, 37)
        Me.TxbHraIniAgendaServico.Name = "TxbHraIniAgendaServico"
        Me.TxbHraIniAgendaServico.Size = New System.Drawing.Size(100, 20)
        Me.TxbHraIniAgendaServico.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Exibir Grid apartir da hora:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(500, 242)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Eventos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txbFontProduto)
        Me.GroupBox1.Controls.Add(Me.GbIngresso)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txbFontProduto
        '
        Me.txbFontProduto.Location = New System.Drawing.Point(172, 14)
        Me.txbFontProduto.Name = "txbFontProduto"
        Me.txbFontProduto.Size = New System.Drawing.Size(100, 20)
        Me.txbFontProduto.TabIndex = 12
        '
        'GbIngresso
        '
        Me.GbIngresso.Controls.Add(Me.txb_fontIngresso)
        Me.GbIngresso.Controls.Add(Me.GroupBox3)
        Me.GbIngresso.Controls.Add(Me.Label2)
        Me.GbIngresso.Location = New System.Drawing.Point(6, 77)
        Me.GbIngresso.Name = "GbIngresso"
        Me.GbIngresso.Size = New System.Drawing.Size(476, 153)
        Me.GbIngresso.TabIndex = 11
        Me.GbIngresso.TabStop = False
        Me.GbIngresso.Text = "Ingresso"
        '
        'txb_fontIngresso
        '
        Me.txb_fontIngresso.Location = New System.Drawing.Point(172, 16)
        Me.txb_fontIngresso.Name = "txb_fontIngresso"
        Me.txb_fontIngresso.Size = New System.Drawing.Size(100, 20)
        Me.txb_fontIngresso.TabIndex = 22
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxbImgIngMargCabecalho)
        Me.GroupBox3.Controls.Add(Me.TxbImgIngMargEsquerda)
        Me.GroupBox3.Controls.Add(Me.TxbImgIngLargura)
        Me.GroupBox3.Controls.Add(Me.TxbImgIngAltura)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 35)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(276, 109)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Imagem"
        '
        'TxbImgIngMargCabecalho
        '
        Me.TxbImgIngMargCabecalho.Location = New System.Drawing.Point(161, 82)
        Me.TxbImgIngMargCabecalho.Name = "TxbImgIngMargCabecalho"
        Me.TxbImgIngMargCabecalho.Size = New System.Drawing.Size(100, 20)
        Me.TxbImgIngMargCabecalho.TabIndex = 26
        '
        'TxbImgIngMargEsquerda
        '
        Me.TxbImgIngMargEsquerda.Location = New System.Drawing.Point(161, 59)
        Me.TxbImgIngMargEsquerda.Name = "TxbImgIngMargEsquerda"
        Me.TxbImgIngMargEsquerda.Size = New System.Drawing.Size(100, 20)
        Me.TxbImgIngMargEsquerda.TabIndex = 25
        '
        'TxbImgIngLargura
        '
        Me.TxbImgIngLargura.Location = New System.Drawing.Point(161, 36)
        Me.TxbImgIngLargura.Name = "TxbImgIngLargura"
        Me.TxbImgIngLargura.Size = New System.Drawing.Size(100, 20)
        Me.TxbImgIngLargura.TabIndex = 24
        '
        'TxbImgIngAltura
        '
        Me.TxbImgIngAltura.Location = New System.Drawing.Point(161, 13)
        Me.TxbImgIngAltura.Name = "TxbImgIngAltura"
        Me.TxbImgIngAltura.Size = New System.Drawing.Size(100, 20)
        Me.TxbImgIngAltura.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Altura:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Largura:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Margem Cabeçalho:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Margem Esquerda:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tamanho Fonte Ingressos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alterar tamanho fonte Produtos:"
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(478, 0)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(31, 31)
        Me.BtnSalvar.TabIndex = 13
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(508, 268)
        Me.TabControl1.TabIndex = 1
        '
        'FrmParametroSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 280)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmParametroSistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametros Sistema"
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbIngresso.ResumeLayout(False)
        Me.GbIngresso.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Protected WithEvents BtnSalvar As Button
    Friend WithEvents txbFontProduto As Controles.TxbCodigo
    Friend WithEvents GbIngresso As GroupBox
    Friend WithEvents txb_fontIngresso As Controles.TxbCodigo
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxbImgIngMargCabecalho As Controles.TxbCodigo
    Friend WithEvents TxbImgIngMargEsquerda As Controles.TxbCodigo
    Friend WithEvents TxbImgIngLargura As Controles.TxbCodigo
    Friend WithEvents TxbImgIngAltura As Controles.TxbCodigo
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxbHraIniAgendaServico As Controles.TxbCodigo
    Friend WithEvents Label7 As Label
End Class
