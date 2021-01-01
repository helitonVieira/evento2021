Imports System.Windows.Forms
Public Class TxbDescricao
    Inherits TextBox
    Public Sub TxbCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Me.CharacterCasing = CharacterCasing.Upper
    End Sub
End Class
