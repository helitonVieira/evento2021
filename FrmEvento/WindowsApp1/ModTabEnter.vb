Module ModTabEnter
    Private Sub TabEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Public Sub InsereEnter(ByVal controle As Control)
        For Each elemento In controle.Controls
            If elemento.GetType.Name().ToString = "GroupBox" Or
                    elemento.GetType.Name().ToString = "Panel" Then
                InsereEnter(elemento)
            Else
                AddHandler CType(elemento, Control).KeyDown, AddressOf TabEnter
            End If

        Next
    End Sub
End Module
