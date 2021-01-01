Public Class FrmFiltroRelComissaoAgendaServ
    Private Sub BtnBuscaFavorecido_Click(sender As Object, e As EventArgs) Handles BtnFuncionario.Click
        FrmPesquisa.tabela = "tab_pessoa_funcionario"
        FrmPesquisa.ShowDialog()
        TxbCodFuncionario.Text = ModVariavelGlobal.pesquisaCodigo
        TxbNomFuncionario.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnBuscaTipo_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        FrmPesquisa.tabela = "tab_pessoa"
        FrmPesquisa.ShowDialog()
        TxbCodCliente.Text = ModVariavelGlobal.pesquisaCodigo
        TxbNomCliente.Text = ModVariavelGlobal.pesquisaNome
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
        TxbCodFuncionario.Text = ""
        TxbCodCliente.Text = ""
        TxbCodEmpresa.Text = ""
        txbNomEmpresa.Text = ""
        TxbNomFuncionario.Text = ""
        TxbNomCliente.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmRelComissaoServ.dtaInicio = DtpInicio.Value.ToShortDateString.ToString
        FrmRelComissaoServ.dtaFinal = DtpFinal.Value.ToShortDateString.ToString

        If TxbCodEmpresa.Text = "" Then
            FrmRelComissaoServ.codEmpresa1 = ModParametroSistema.cod_empresa
        Else
            FrmRelComissaoServ.codEmpresa1 = TxbCodEmpresa.Text
        End If
        If TxbCodFuncionario.Text = "" Then
            FrmRelComissaoServ.codFuncionario = 0
        Else
            FrmRelComissaoServ.codFuncionario = TxbCodFuncionario.Text
        End If
        If TxbCodCliente.Text = "" Then
            FrmRelComissaoServ.codCliente = 0
        Else
            FrmRelComissaoServ.codCliente = TxbCodCliente.Text
        End If
        If TxbPerComissao.Text = "" Then
            FrmRelComissaoServ.perComissao = "0"
        Else
            FrmRelComissaoServ.perComissao = TxbPerComissao.Text
        End If
        FrmRelComissaoServ.Show()
    End Sub
End Class
