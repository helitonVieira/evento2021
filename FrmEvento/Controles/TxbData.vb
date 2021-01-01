Imports System.Windows.Forms
Public Class TxbData
    Inherits TextBox
    Dim apagar As Boolean = True
    Public Sub TxbData_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = CChar(ChrW(Asc(","))) Then
            e.Handled = True
        ElseIf e.KeyChar = CChar(ChrW(Asc("."))) Then
            e.Handled = True
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        ElseIf e.KeyChar = vbBack Then
            apagar = False
        End If

    End Sub

    Public Sub TxbData_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        If Me.Text <> "" And Len(Me.Text) >= 10 Then
            If Not IsDate(Me.Text) Then
                MessageBox.Show("Formato Data incorreto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Select()
            Else
                Format(Me.Text, "MM/mm/yyyy")
            End If
        End If
        If Me.Text <> "" And Len(Me.Text) <> 10 Then
            Me.Select()
        End If
    End Sub

    Private Sub TxbData_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
        Dim Cursor As Integer = 0
        Dim Mask As String = ""
        sender.MaxLength = 10
        If apagar = False Then
            apagar = True
            Exit Sub
        End If

        If AscW(sender.SelectionStart) <> 6 Then

            '----- Definindo a posição que o cursor esta no momento

            Cursor = sender.SelectionStart

            '----- Redefinindo a nova posição do cursor caso necessario

            If Len(sender.text) = 2 Or Len(sender.text) = 5 Then

                Cursor = Cursor + 1

            End If

            '----- Retirando as barras

            Mask = Replace(sender.text, "/", "")
            '----- Recolocando as barras

            If Len(Mask) < 5 And Len(Mask) >= 2 Then

                Mask = Mask.Insert(2, "/")
                Cursor = Len(Mask) + 1

            End If
            If Len(Mask) >= 5 Then

                '----- Retirando as barras

                Mask = Replace(sender.text, "/", "")

                '----- Recolocando as barras

                Mask = Mask.Insert(2, "/")

                Mask = Mask.Insert(5, "/")

            End If

            '----- Passando a mascara criada para a caixa de texto e definindo a posição em que cursor deverá estar

            Me.Text = Mask

            sender.SelectionStart = Cursor
        Else
            If sender.text = "/" Then
                SendKeys.Send("{BACKSPACE}")
            End If
        End If
    End Sub
End Class
