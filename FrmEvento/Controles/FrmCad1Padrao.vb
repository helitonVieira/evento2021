Imports System.Windows.Forms

Public Class FrmCad1Padrao


    Private Sub FrmCad1Padrao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedIndex = 0
        TxbCodigo.Select()
    End Sub
End Class