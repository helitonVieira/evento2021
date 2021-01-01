Public Class FrmFiltroVendaSubCategoria
    Private Sub BtnBuscaFavorecido_Click(sender As Object, e As EventArgs) Handles BtnCategoria.Click
        FrmPesquisa.tabela = "tab_categoria_item"
        FrmPesquisa.ShowDialog()
        TxbCodCategoria.Text = ModVariavelGlobal.pesquisaCodigo
        TxbDesCategoria.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnBuscaTipo_Click(sender As Object, e As EventArgs) Handles BtnSubCategoria.Click
            FrmPesquisa.tabela = "tab_subcategoria_item"
            FrmPesquisa.ShowDialog()
            TxbCodSubCategoria.Text = ModVariavelGlobal.pesquisaCodigo
            TxbDesSubCategoria.Text = ModVariavelGlobal.pesquisaNome
            ModVariavelGlobal.pesquisaCodigo = ""
            ModVariavelGlobal.pesquisaNome = ""
        End Sub
        Private Sub BtnItem_Click(sender As Object, e As EventArgs) Handles BtnItem.Click
            FrmPesquisa.tabela = "tab_item"
            FrmPesquisa.ShowDialog()
        TxbCodItem.Text = ModVariavelGlobal.pesquisaCodigo
        TxbDesItem.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
            ModVariavelGlobal.pesquisaNome = ""
        End Sub
        Private Sub BtnEmpresa_Click(sender As Object, e As EventArgs) Handles btnEmpresa.Click
            FrmPesquisa.tabela = "tab_empresa"
            FrmPesquisa.ShowDialog()
            TxbCodEmpresa.Text = ModVariavelGlobal.pesquisaCodigo
            txbNomEmpresa.Text = ModVariavelGlobal.pesquisaNome
            ModVariavelGlobal.pesquisaCodigo = ""
            ModVariavelGlobal.pesquisaNome = ""
        End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnCancela.Click
        limpar()
        Me.Close()
    End Sub

    Private Sub FrmFiltroRelDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            DtpInicio.Value = Today.ToShortDateString
            DtpFinal.Value = Today.ToShortDateString
            limpar()
        End Sub
        Private Sub limpar()
            TxbCodItem.Text = ""
            TxbCodItem.Text = ""
            TxbCodCategoria.Text = ""
            TxbCodSubCategoria.Text = ""
            TxbCodEmpresa.Text = ""
            txbNomEmpresa.Text = ""
            TxbDesCategoria.Text = ""
            TxbDesSubCategoria.Text = ""
        End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        FrmRelVendaSubCategoria.dtaInicio = DtpInicio.Value.ToShortDateString.ToString
        FrmRelVendaSubCategoria.dtaFinal = DtpFinal.Value.ToShortDateString.ToString

        If TxbCodEmpresa.Text = "" Then
            FrmRelVendaSubCategoria.codEmpresa1 = ModParametroSistema.cod_empresa
        Else
            FrmRelVendaSubCategoria.codEmpresa1 = TxbCodEmpresa.Text
        End If
        If TxbCodCategoria.Text = "" Then
            FrmRelVendaSubCategoria.codCategoria = 0
        Else
            FrmRelVendaSubCategoria.codCategoria = TxbCodCategoria.Text
        End If
        If TxbCodSubCategoria.Text = "" Then
            FrmRelVendaSubCategoria.codSubcategoria = 0
        Else
            FrmRelVendaSubCategoria.codSubcategoria = TxbCodSubCategoria.Text
        End If
        If TxbCodItem.Text = "" Then
            FrmRelVendaSubCategoria.codItem = 0
        Else
            FrmRelVendaSubCategoria.codItem = TxbCodItem.Text
        End If

        FrmRelVendaSubCategoria.Show()

    End Sub
End Class
