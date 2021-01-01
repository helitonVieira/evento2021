Public Class FrmFiltroRelDespesa

    Private Sub BtnBuscaFavorecido_Click(sender As Object, e As EventArgs) Handles BtnBuscaFavorecido.Click
        FrmPesquisa.tabela = "tab_pessoa"
        FrmPesquisa.ShowDialog()
        TxbCodFavorecido.Text = ModVariavelGlobal.pesquisaCodigo
        TxbNomFavorecido.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnBuscaTipo_Click(sender As Object, e As EventArgs) Handles BtnBuscaTipo.Click
        FrmPesquisa.tabela = "tab_tipo_despesa"
        FrmPesquisa.ShowDialog()
        TxbCodTipo.Text = ModVariavelGlobal.pesquisaCodigo
        TxbDesTipo.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEmpresa.Click
        FrmPesquisa.tabela = "tab_empresa"
        FrmPesquisa.ShowDialog()
        TxbCodEmpresa.Text = ModVariavelGlobal.pesquisaCodigo
        txbNomEmpresa.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpar()
        Me.Close()
    End Sub

    Private Sub FrmFiltroRelDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpInicio.Value = Today.ToShortDateString
        DtpFinal.Value = Today.ToShortDateString
        limpar()
    End Sub
    Private Sub limpar()
        TxbCodFavorecido.Text = ""
        TxbCodTipo.Text = ""
        TxbCodEmpresa.Text = ""
        txbNomEmpresa.Text = ""
        TxbNomFavorecido.Text = ""
        TxbDesTipo.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmRelDespesa.dtaInicio = DtpInicio.Value.ToShortDateString.ToString
        FrmRelDespesa.dtaFinal = DtpFinal.Value.ToShortDateString.ToString

        If TxbCodEmpresa.Text = "" Then
            FrmRelDespesa.codEmpresa1 = ModParametroSistema.cod_empresa
        Else
            FrmRelDespesa.codEmpresa1 = TxbCodEmpresa.Text
        End If
        If TxbCodFavorecido.Text = "" Then
            FrmRelDespesa.codPessoa = 0
        Else
            FrmRelDespesa.codPessoa = TxbCodFavorecido.Text
        End If
        If TxbCodTipo.Text = "" Then
            FrmRelDespesa.codTipoDespesa = 0
        Else
            FrmRelDespesa.codTipoDespesa = TxbCodTipo.Text
        End If
        FrmRelDespesa.Show()
    End Sub
End Class
