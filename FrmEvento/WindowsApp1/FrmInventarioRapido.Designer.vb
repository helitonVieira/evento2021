<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventarioRapido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventarioRapido))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtPresquisa = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.txtCodItem = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txbObservacao = New System.Windows.Forms.TextBox()
        Me.txbCustoTotal = New Controles.TxbMonetario()
        Me.TxbQtde = New Controles.TxbMonetario()
        Me.txbCustoUn = New Controles.TxbMonetario()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalvar2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btBuscaItem = New System.Windows.Forms.Button()
        Me.txtDesItem = New System.Windows.Forms.TextBox()
        Me.LbSeq = New System.Windows.Forms.Label()
        Me.lbData = New System.Windows.Forms.Label()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.Evento = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbTotal = New System.Windows.Forms.RadioButton()
        Me.rbParcial = New System.Windows.Forms.RadioButton()
        Me.TxbNumero = New Controles.TxbDescricao()
        Me.BtnDtaFinal = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxbDtaInventario = New Controles.TxbData()
        Me.DtpDta = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btMovimento = New System.Windows.Forms.Button()
        Me.txtDesTipoMovimento = New System.Windows.Forms.TextBox()
        Me.txtCodTipoMovimento = New System.Windows.Forms.TextBox()
        Me.btnAlmoxarifado = New System.Windows.Forms.Button()
        Me.txtDesAlmoxarifado = New System.Windows.Forms.TextBox()
        Me.txtCodAlmoxarifado = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Evento.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtPresquisa)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.Controls.Add(Me.BtnExcluir)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(538, 40)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'BtPresquisa
        '
        Me.BtPresquisa.BackColor = System.Drawing.Color.Transparent
        Me.BtPresquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtPresquisa.ForeColor = System.Drawing.Color.Transparent
        Me.BtPresquisa.Image = Global.WindowsApp1.My.Resources.Resources.pesquisa_pb
        Me.BtPresquisa.Location = New System.Drawing.Point(85, 7)
        Me.BtPresquisa.Name = "BtPresquisa"
        Me.BtPresquisa.Size = New System.Drawing.Size(31, 31)
        Me.BtPresquisa.TabIndex = 14
        Me.BtPresquisa.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Image = Global.WindowsApp1.My.Resources.Resources.limpar_min
        Me.Button2.Location = New System.Drawing.Point(56, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 31)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvar.Image = Global.WindowsApp1.My.Resources.Resources.img_salva_pb1
        Me.BtnSalvar.Location = New System.Drawing.Point(4, 7)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(31, 31)
        Me.BtnSalvar.TabIndex = 11
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluir.ForeColor = System.Drawing.Color.Transparent
        Me.BtnExcluir.Image = Global.WindowsApp1.My.Resources.Resources.lixo_pb
        Me.BtnExcluir.Location = New System.Drawing.Point(32, 7)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(31, 31)
        Me.BtnExcluir.TabIndex = 12
        Me.BtnExcluir.UseVisualStyleBackColor = False
        '
        'txtCodItem
        '
        Me.txtCodItem.Location = New System.Drawing.Point(103, 11)
        Me.txtCodItem.Name = "txtCodItem"
        Me.txtCodItem.Size = New System.Drawing.Size(54, 20)
        Me.txtCodItem.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txbObservacao)
        Me.GroupBox1.Controls.Add(Me.txbCustoTotal)
        Me.GroupBox1.Controls.Add(Me.TxbQtde)
        Me.GroupBox1.Controls.Add(Me.txbCustoUn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnSalvar2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btBuscaItem)
        Me.GroupBox1.Controls.Add(Me.txtDesItem)
        Me.GroupBox1.Controls.Add(Me.txtCodItem)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 83)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Observação"
        '
        'txbObservacao
        '
        Me.txbObservacao.Location = New System.Drawing.Point(103, 57)
        Me.txbObservacao.Name = "txbObservacao"
        Me.txbObservacao.Size = New System.Drawing.Size(357, 20)
        Me.txbObservacao.TabIndex = 23
        '
        'txbCustoTotal
        '
        Me.txbCustoTotal.Location = New System.Drawing.Point(384, 34)
        Me.txbCustoTotal.Name = "txbCustoTotal"
        Me.txbCustoTotal.Size = New System.Drawing.Size(76, 20)
        Me.txbCustoTotal.TabIndex = 17
        Me.txbCustoTotal.Text = "0,00"
        Me.txbCustoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxbQtde
        '
        Me.TxbQtde.Location = New System.Drawing.Point(103, 34)
        Me.TxbQtde.Name = "TxbQtde"
        Me.TxbQtde.Size = New System.Drawing.Size(76, 20)
        Me.TxbQtde.TabIndex = 15
        Me.TxbQtde.Text = "0,00"
        Me.TxbQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txbCustoUn
        '
        Me.txbCustoUn.Location = New System.Drawing.Point(262, 34)
        Me.txbCustoUn.Name = "txbCustoUn"
        Me.txbCustoUn.Size = New System.Drawing.Size(76, 20)
        Me.txbCustoUn.TabIndex = 16
        Me.txbCustoUn.Text = "0,00"
        Me.txbCustoUn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Item:"
        '
        'BtnSalvar2
        '
        Me.BtnSalvar2.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalvar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar2.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvar2.Image = Global.WindowsApp1.My.Resources.Resources.img_salva_pb1
        Me.BtnSalvar2.Location = New System.Drawing.Point(466, 50)
        Me.BtnSalvar2.Name = "BtnSalvar2"
        Me.BtnSalvar2.Size = New System.Drawing.Size(31, 31)
        Me.BtnSalvar2.TabIndex = 18
        Me.BtnSalvar2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "C.Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Custo Unitário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Quantidade:"
        '
        'btBuscaItem
        '
        Me.btBuscaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscaItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btBuscaItem.Image = CType(resources.GetObject("btBuscaItem.Image"), System.Drawing.Image)
        Me.btBuscaItem.Location = New System.Drawing.Point(440, 11)
        Me.btBuscaItem.Name = "btBuscaItem"
        Me.btBuscaItem.Size = New System.Drawing.Size(20, 20)
        Me.btBuscaItem.TabIndex = 14
        Me.btBuscaItem.UseVisualStyleBackColor = True
        '
        'txtDesItem
        '
        Me.txtDesItem.Location = New System.Drawing.Point(160, 11)
        Me.txtDesItem.Name = "txtDesItem"
        Me.txtDesItem.Size = New System.Drawing.Size(277, 20)
        Me.txtDesItem.TabIndex = 13
        '
        'LbSeq
        '
        Me.LbSeq.AutoSize = True
        Me.LbSeq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSeq.Location = New System.Drawing.Point(252, 11)
        Me.LbSeq.Name = "LbSeq"
        Me.LbSeq.Size = New System.Drawing.Size(32, 13)
        Me.LbSeq.TabIndex = 14
        Me.LbSeq.Text = "Sequ"
        Me.LbSeq.Visible = False
        '
        'lbData
        '
        Me.lbData.AutoSize = True
        Me.lbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbData.Location = New System.Drawing.Point(216, 11)
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(30, 13)
        Me.lbData.TabIndex = 12
        Me.lbData.Text = "Data"
        '
        'dgvInventario
        '
        Me.dgvInventario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventario.Location = New System.Drawing.Point(3, 217)
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.Size = New System.Drawing.Size(538, 182)
        Me.dgvInventario.TabIndex = 12
        '
        'Evento
        '
        Me.Evento.Controls.Add(Me.GroupBox3)
        Me.Evento.Controls.Add(Me.lbData)
        Me.Evento.Controls.Add(Me.TxbNumero)
        Me.Evento.Controls.Add(Me.BtnDtaFinal)
        Me.Evento.Controls.Add(Me.Label7)
        Me.Evento.Controls.Add(Me.TxbDtaInventario)
        Me.Evento.Controls.Add(Me.LbSeq)
        Me.Evento.Controls.Add(Me.DtpDta)
        Me.Evento.Controls.Add(Me.Label6)
        Me.Evento.Controls.Add(Me.Label8)
        Me.Evento.Controls.Add(Me.Label5)
        Me.Evento.Controls.Add(Me.btMovimento)
        Me.Evento.Controls.Add(Me.txtDesTipoMovimento)
        Me.Evento.Controls.Add(Me.txtCodTipoMovimento)
        Me.Evento.Controls.Add(Me.btnAlmoxarifado)
        Me.Evento.Controls.Add(Me.txtDesAlmoxarifado)
        Me.Evento.Controls.Add(Me.txtCodAlmoxarifado)
        Me.Evento.Location = New System.Drawing.Point(3, 49)
        Me.Evento.Name = "Evento"
        Me.Evento.Size = New System.Drawing.Size(538, 84)
        Me.Evento.TabIndex = 13
        Me.Evento.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbTotal)
        Me.GroupBox3.Controls.Add(Me.rbParcial)
        Me.GroupBox3.Location = New System.Drawing.Point(466, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(65, 64)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo"
        '
        'rbTotal
        '
        Me.rbTotal.AutoSize = True
        Me.rbTotal.Location = New System.Drawing.Point(4, 41)
        Me.rbTotal.Name = "rbTotal"
        Me.rbTotal.Size = New System.Drawing.Size(49, 17)
        Me.rbTotal.TabIndex = 11
        Me.rbTotal.TabStop = True
        Me.rbTotal.Text = "Total"
        Me.rbTotal.UseVisualStyleBackColor = True
        '
        'rbParcial
        '
        Me.rbParcial.AutoSize = True
        Me.rbParcial.Location = New System.Drawing.Point(4, 19)
        Me.rbParcial.Name = "rbParcial"
        Me.rbParcial.Size = New System.Drawing.Size(57, 17)
        Me.rbParcial.TabIndex = 10
        Me.rbParcial.TabStop = True
        Me.rbParcial.Text = "Parcial"
        Me.rbParcial.UseVisualStyleBackColor = True
        '
        'TxbNumero
        '
        Me.TxbNumero.Location = New System.Drawing.Point(360, 11)
        Me.TxbNumero.Name = "TxbNumero"
        Me.TxbNumero.Size = New System.Drawing.Size(100, 20)
        Me.TxbNumero.TabIndex = 3
        '
        'BtnDtaFinal
        '
        Me.BtnDtaFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDtaFinal.Font = New System.Drawing.Font("Bernard MT Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDtaFinal.ForeColor = System.Drawing.Color.DimGray
        Me.BtnDtaFinal.Location = New System.Drawing.Point(187, 11)
        Me.BtnDtaFinal.Name = "BtnDtaFinal"
        Me.BtnDtaFinal.Size = New System.Drawing.Size(23, 20)
        Me.BtnDtaFinal.TabIndex = 2
        Me.BtnDtaFinal.Text = "F"
        Me.BtnDtaFinal.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Almoxarifado:"
        '
        'TxbDtaInventario
        '
        Me.TxbDtaInventario.Location = New System.Drawing.Point(103, 11)
        Me.TxbDtaInventario.MaxLength = 10
        Me.TxbDtaInventario.Name = "TxbDtaInventario"
        Me.TxbDtaInventario.Size = New System.Drawing.Size(66, 20)
        Me.TxbDtaInventario.TabIndex = 0
        '
        'DtpDta
        '
        Me.DtpDta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDta.Location = New System.Drawing.Point(171, 11)
        Me.DtpDta.Name = "DtpDta"
        Me.DtpDta.Size = New System.Drawing.Size(14, 20)
        Me.DtpDta.TabIndex = 1
        Me.DtpDta.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(316, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Número:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Data:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Tipo Movimento:"
        '
        'btMovimento
        '
        Me.btMovimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMovimento.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btMovimento.Image = CType(resources.GetObject("btMovimento.Image"), System.Drawing.Image)
        Me.btMovimento.Location = New System.Drawing.Point(440, 57)
        Me.btMovimento.Name = "btMovimento"
        Me.btMovimento.Size = New System.Drawing.Size(20, 20)
        Me.btMovimento.TabIndex = 9
        Me.btMovimento.UseVisualStyleBackColor = True
        '
        'txtDesTipoMovimento
        '
        Me.txtDesTipoMovimento.Location = New System.Drawing.Point(160, 57)
        Me.txtDesTipoMovimento.Name = "txtDesTipoMovimento"
        Me.txtDesTipoMovimento.Size = New System.Drawing.Size(277, 20)
        Me.txtDesTipoMovimento.TabIndex = 8
        '
        'txtCodTipoMovimento
        '
        Me.txtCodTipoMovimento.Location = New System.Drawing.Point(103, 57)
        Me.txtCodTipoMovimento.Name = "txtCodTipoMovimento"
        Me.txtCodTipoMovimento.Size = New System.Drawing.Size(54, 20)
        Me.txtCodTipoMovimento.TabIndex = 7
        '
        'btnAlmoxarifado
        '
        Me.btnAlmoxarifado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlmoxarifado.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAlmoxarifado.Image = CType(resources.GetObject("btnAlmoxarifado.Image"), System.Drawing.Image)
        Me.btnAlmoxarifado.Location = New System.Drawing.Point(440, 34)
        Me.btnAlmoxarifado.Name = "btnAlmoxarifado"
        Me.btnAlmoxarifado.Size = New System.Drawing.Size(20, 20)
        Me.btnAlmoxarifado.TabIndex = 6
        Me.btnAlmoxarifado.UseVisualStyleBackColor = True
        '
        'txtDesAlmoxarifado
        '
        Me.txtDesAlmoxarifado.Location = New System.Drawing.Point(160, 34)
        Me.txtDesAlmoxarifado.Name = "txtDesAlmoxarifado"
        Me.txtDesAlmoxarifado.Size = New System.Drawing.Size(277, 20)
        Me.txtDesAlmoxarifado.TabIndex = 5
        '
        'txtCodAlmoxarifado
        '
        Me.txtCodAlmoxarifado.Location = New System.Drawing.Point(103, 34)
        Me.txtCodAlmoxarifado.Name = "txtCodAlmoxarifado"
        Me.txtCodAlmoxarifado.Size = New System.Drawing.Size(54, 20)
        Me.txtCodAlmoxarifado.TabIndex = 4
        '
        'FrmInventarioRapido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(545, 404)
        Me.Controls.Add(Me.Evento)
        Me.Controls.Add(Me.dgvInventario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInventarioRapido"
        Me.Text = "FrmInventarioRapido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Evento.ResumeLayout(False)
        Me.Evento.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtPresquisa As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents txtCodItem As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDesItem As TextBox
    Friend WithEvents lbData As Label
    Friend WithEvents btBuscaItem As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvInventario As DataGridView
    Friend WithEvents Evento As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btMovimento As Button
    Friend WithEvents txtDesTipoMovimento As TextBox
    Friend WithEvents txtCodTipoMovimento As TextBox
    Friend WithEvents LbSeq As Label
    Friend WithEvents BtnSalvar2 As Button
    Friend WithEvents BtnDtaFinal As Button
    Friend WithEvents TxbDtaInventario As Controles.TxbData
    Friend WithEvents DtpDta As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAlmoxarifado As Button
    Friend WithEvents txtDesAlmoxarifado As TextBox
    Friend WithEvents txtCodAlmoxarifado As TextBox
    Friend WithEvents TxbNumero As Controles.TxbDescricao
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txbCustoUn As Controles.TxbMonetario
    Friend WithEvents txbCustoTotal As Controles.TxbMonetario
    Friend WithEvents TxbQtde As Controles.TxbMonetario
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbTotal As RadioButton
    Friend WithEvents rbParcial As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents txbObservacao As TextBox
End Class
