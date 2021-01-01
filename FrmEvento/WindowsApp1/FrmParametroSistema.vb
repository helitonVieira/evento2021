Public Class FrmParametroSistema
    Dim conectar As New ConexaoSQL
    Dim ds As New DataSet
    Dim paramSistem As New ClParametroSistema

    Private Sub btGravar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        If txbFontProduto.Text = "" Then
            txbFontProduto.Text = "0"
        End If

        If txb_fontIngresso.Text = "" Then
            txb_fontIngresso.Text = "0"
        End If
        If TxbImgIngAltura.Text = "" Then
            TxbImgIngAltura.Text = "0"
        End If
        If TxbImgIngLargura.Text = "" Then
            TxbImgIngLargura.Text = "0"
        End If
        If TxbImgIngMargCabecalho.Text = "" Then
            TxbImgIngMargCabecalho.Text = "0"
        End If
        If TxbImgIngMargEsquerda.Text = "" Then
            TxbImgIngMargEsquerda.Text = "0"
        End If
        If TxbHraIniAgendaServico.Text = "" Then
            TxbHraIniAgendaServico.Text = "0"
        End If
        Try
            paramSistem.dimFontIngresso = txb_fontIngresso.Text
            paramSistem.dimFontProduto = txbFontProduto.Text
            paramSistem.val_img_ingresso_tamanho_altura = TxbImgIngAltura.Text
            paramSistem.val_img_ingresso_tamanho_largura = TxbImgIngLargura.Text
            paramSistem.val_img_ingresso_margem_esquerda = TxbImgIngMargEsquerda.Text
            paramSistem.val_img_ingresso_margem_cabecalho = TxbImgIngMargCabecalho.Text
            paramSistem.hra_inicio_agenda_servico = TxbHraIniAgendaServico.Text
            paramSistem.Atualizar()
            MsgBox("Parametros atualizados com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
        Catch ex As Exception
            MsgBox("Erro ao tentar atualizar", MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub FrmParametroSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            BtnSalvar.Enabled = ModPermissaoUsuario.t10021
        End If

        Try
            Dim tabela As DataRow
            ds = paramSistem.consultarParametro()
            tabela = ds.Tables(0).Rows(0)

            txbFontProduto.Text = tabela.Item(0).ToString
            txb_fontIngresso.Text = tabela.Item(1).ToString
            TxbImgIngAltura.Text = tabela.Item(2).ToString
            TxbImgIngLargura.Text = tabela.Item(3).ToString
            TxbImgIngMargEsquerda.Text = tabela.Item(4).ToString
            TxbImgIngMargCabecalho.Text = tabela.Item(5).ToString
            TxbHraIniAgendaServico.Text = tabela.Item(6).ToString
        Catch ex As Exception

        End Try
    End Sub
End Class