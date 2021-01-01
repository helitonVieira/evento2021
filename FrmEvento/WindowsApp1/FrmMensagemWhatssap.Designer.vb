<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMensagemWhatssap
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
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.TxbTo = New System.Windows.Forms.TextBox()
        Me.TxbMensage = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxbStatus = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxbNome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxbFone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxbPassoword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnSend
        '
        Me.BtnSend.Location = New System.Drawing.Point(389, 127)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(75, 23)
        Me.BtnSend.TabIndex = 0
        Me.BtnSend.Text = "&Send"
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'TxbTo
        '
        Me.TxbTo.Location = New System.Drawing.Point(136, 49)
        Me.TxbTo.Name = "TxbTo"
        Me.TxbTo.Size = New System.Drawing.Size(100, 20)
        Me.TxbTo.TabIndex = 1
        '
        'TxbMensage
        '
        Me.TxbMensage.Location = New System.Drawing.Point(136, 75)
        Me.TxbMensage.Multiline = True
        Me.TxbMensage.Name = "TxbMensage"
        Me.TxbMensage.Size = New System.Drawing.Size(328, 46)
        Me.TxbMensage.TabIndex = 2
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(389, 208)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 3
        Me.BtnLogin.Text = "&Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mensagem"
        '
        'TxbStatus
        '
        Me.TxbStatus.Location = New System.Drawing.Point(136, 156)
        Me.TxbStatus.Multiline = True
        Me.TxbStatus.Name = "TxbStatus"
        Me.TxbStatus.Size = New System.Drawing.Size(328, 46)
        Me.TxbStatus.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Status"
        '
        'TxbNome
        '
        Me.TxbNome.Location = New System.Drawing.Point(136, 237)
        Me.TxbNome.Name = "TxbNome"
        Me.TxbNome.Size = New System.Drawing.Size(100, 20)
        Me.TxbNome.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nome"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(250, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fone"
        '
        'TxbFone
        '
        Me.TxbFone.Location = New System.Drawing.Point(293, 241)
        Me.TxbFone.Name = "TxbFone"
        Me.TxbFone.Size = New System.Drawing.Size(100, 20)
        Me.TxbFone.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(405, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Passoword"
        '
        'TxbPassoword
        '
        Me.TxbPassoword.Location = New System.Drawing.Point(470, 241)
        Me.TxbPassoword.Name = "TxbPassoword"
        Me.TxbPassoword.Size = New System.Drawing.Size(100, 20)
        Me.TxbPassoword.TabIndex = 12
        '
        'FrmMensagemWhatssap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(613, 298)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxbPassoword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxbFone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxbNome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxbStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxbMensage)
        Me.Controls.Add(Me.TxbTo)
        Me.Controls.Add(Me.BtnSend)
        Me.Name = "FrmMensagemWhatssap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSend As Button
    Friend WithEvents TxbTo As TextBox
    Friend WithEvents TxbMensage As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbStatus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbNome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbFone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxbPassoword As TextBox
End Class
