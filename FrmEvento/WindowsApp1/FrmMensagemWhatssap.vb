Imports System.Threading
Imports WhatsAppApi
Imports WhatsAppApi.ApiBase
Imports WhatsAppApi.Helper

Public Class FrmMensagemWhatssap
    Private wa As WhatsApp
    Private Delegate Sub UpdateTextBox(ByVal textbox As TextBox, ByVal value As String)
    Public Sub UpdateDataTextBox(ByVal textbox As TextBox, ByVal value As String)
        Dim box As TextBox = textbox
        box.Text = (box.Text & value)
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        If ((Not String.IsNullOrEmpty(Me.TxbMensage.Text) AndAlso (Not Me.wa Is Nothing)) AndAlso (Me.wa.ConnectionStatus = CONNECTION_STATUS.LOGGEDIN)) Then
            Me.wa.SendMessage(Me.TxbTo.Text, Me.TxbMensage.Text)
            Dim txbStatus As TextBox = Me.TxbStatus
            txbStatus.Text = (txbStatus.Text & String.Format(Environment.NewLine & "{0}:{1}", TxbNome.Text, Me.TxbMensage.Text))
            Me.TxbMensage.Clear()
            Me.TxbMensage.Focus()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim thread = New Thread(AddressOf ThreadTask)
        thread.IsBackground = True
        thread.Start()
    End Sub

    Private Sub ThreadTask()
        Dim textbox As UpdateTextBox = New UpdateTextBox(AddressOf Me.UpdateDataTextBox)
        Me.wa = New WhatsApp(Me.TxbFone.Text, Me.TxbPassoword.Text, Me.TxbNome.Text, True, False)
        AddHandler Me.wa.OnConnectSuccess, Sub()
                                               If Me.TxbStatus.InvokeRequired Then
                                                   Dim objArray1 As Object() = New Object() {Me.TxbStatus, "Connected..."}
                                                   Me.Invoke(textbox, objArray1)
                                               End If
                                               AddHandler Me.wa.OnLoginSuccess, Sub(ByVal phone As String, ByVal data As Byte())
                                                                                    If Me.TxbStatus.InvokeRequired Then
                                                                                        Dim args As Object() = New Object() {Me.TxbStatus, Environment.NewLine & "Login success !"}
                                                                                        Me.Invoke(textbox, args)
                                                                                    End If
                                                                                    While Me.wa IsNot Nothing
                                                                                        Me.wa.PollMessages()
                                                                                        Thread.Sleep(200)
                                                                                        Continue While
                                                                                    End While
                                                                                End Sub

                                               AddHandler Me.wa.OnLoginFailed, Sub(ByVal data As String)
                                                                                   If Me.TxbStatus.InvokeRequired Then
                                                                                       Dim args As Object() = New Object() {Me.TxbStatus, String.Format(Environment.NewLine & "Login failed: {0}", data)}
                                                                                       Me.Invoke(textbox, args)
                                                                                   End If
                                                                               End Sub

                                               AddHandler Me.wa.OnGetMessage, Sub(ByVal node As ProtocolTreeNode, ByVal from As String, ByVal id As String, ByVal name As String, ByVal message As String, ByVal receipt_sent As Boolean)
                                                                                  If Me.TxbStatus.InvokeRequired Then
                                                                                      Dim args As Object() = New Object() {Me.TxbStatus, String.Format(Environment.NewLine & "{0}:{1}", name, message)}
                                                                                      Me.Invoke(textbox, args)
                                                                                  End If
                                                                              End Sub
                                               Me.wa.Login(Nothing)
                                           End Sub
        AddHandler Me.wa.OnConnectFailed, Sub(ByVal ex As Exception)
                                              If Me.TxbStatus.InvokeRequired Then
                                                  Dim args As Object() = New Object() {Me.TxbStatus, String.Format(Environment.NewLine & "Connect failed: {0}", ex.StackTrace)}
                                                  Me.Invoke(textbox, args)
                                              End If
                                          End Sub
        Me.wa.Connect()
    End Sub

    Private Sub FrmMensagemWhatssap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class