Public Class FrmDataFinal
    Private tela_ As String
    Public Property tela() As String
        Get
            Return tela_
        End Get
        Set(ByVal value As String)
            tela_ = value
        End Set
    End Property
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        ModVariavelGlobal.dtaFinal = TxbDtaFinal.Text
        Me.Close()
    End Sub

    Private Sub DtpDtaFinal_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaFinal.ValueChanged
        TxbDtaFinal.Text = DtpDtaFinal.Value.ToShortDateString
    End Sub

End Class
