Imports System.Windows.Forms
Public Class TxbCodigo
    Inherits TextBox

    Public Sub TxbCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = CChar(ChrW(Asc(","))) Then
            e.Handled = True
        ElseIf e.KeyChar = CChar(ChrW(Asc("."))) Then
            e.Handled = True
        ElseIf e.KeyChar = CChar(ChrW(Asc("-"))) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Public Sub TxbCodigo_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        If Me.Text <> "" Then
            If IsNumeric(Me.Text) = False Then
                MessageBox.Show("Formato incorreto de número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Text = ""
                Me.Select()
            End If
        End If
    End Sub
End Class
