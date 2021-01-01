Public Class FrmFiltroEntradaSaidaEstoque
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
        TxbCodItem.Text = ""
        TxbCodItem.Text = ""
        TxbCodCategoria.Text = ""
        TxbCodSubCategoria.Text = ""
        TxbCodEmpresa.Text = ""
        txbNomEmpresa.Text = ""
        TxbDesCategoria.Text = ""
        TxbDesSubCategoria.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmRelEntradaSaidaEstoque.dtaInicio = DtpInicio.Value.ToShortDateString.ToString
        FrmRelEntradaSaidaEstoque.dtaFinal = DtpFinal.Value.ToShortDateString.ToString

        If TxbCodEmpresa.Text = "" Then
            FrmRelEntradaSaidaEstoque.codEmpresa1 = ModParametroSistema.cod_empresa
        Else
            FrmRelEntradaSaidaEstoque.codEmpresa1 = TxbCodEmpresa.Text
        End If
        If TxbCodCategoria.Text = "" Then
            FrmRelEntradaSaidaEstoque.codCategoria = 0
        Else
            FrmRelEntradaSaidaEstoque.codCategoria = TxbCodCategoria.Text
        End If
        If TxbCodSubCategoria.Text = "" Then
            FrmRelEntradaSaidaEstoque.codSubcategoria = 0
        Else
            FrmRelEntradaSaidaEstoque.codSubcategoria = TxbCodSubCategoria.Text
        End If
        If TxbCodItem.Text = "" Then
            FrmRelEntradaSaidaEstoque.codItem = 0
        Else
            FrmRelEntradaSaidaEstoque.codItem = TxbCodItem.Text
        End If

        FrmRelEntradaSaidaEstoque.Show()
    End Sub


End Class
