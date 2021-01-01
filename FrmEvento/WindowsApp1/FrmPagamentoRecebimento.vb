Public Class FrmPagamentoRecebimento
    Dim conectar As New Controles.ConexaoSQL
    Dim ds, dsUltimo, dsBanco, dsParcela As New DataSet
    Dim atualizarBanco As Integer = 1
    Dim atualizarParcela As Integer = 1
    Public tabela, ind_status As String
    Public sequencia As Integer
    Dim banco, banco2 As New ClPagamentoBanco
    Dim parcela, parcela2 As New ClPagamentoParcelado
    Dim i As Integer = 0
    Dim val_liquidado As Double = 0
    Dim clGeral As ClGeral
    Dim val_desconto_old, val_juros_old As Double
    Dim dtaVencimento As New FrmDataFinal
    Dim newDtaVencimento As String
    Private Sub calculaValorLiquidado()

        If TxbValEspecie.Text = "" Or IsNumeric(TxbValEspecie.Text) = False Then
            TxbValEspecie.Text = "0,00"
        End If
        If LbTotalBanco.Text = "" Or IsNumeric(LbTotalBanco.Text) = False Then
            LbTotalBanco.Text = "0,00"
        End If
        If LbTotalParcela.Text = "" Or IsNumeric(LbTotalParcela.Text) = False Then
            LbTotalParcela.Text = "0,00"
        End If
        val_liquidado = CDbl(TxbValEspecie.Text) + CDbl(LbTotalBanco.Text) + CDbl(LbTotalParcela.Text)
        TxbValLiquidado.Text = CStr(FormatNumber(val_liquidado, 2))
        calculaValorPendente()
    End Sub
    Private Sub calculaValorPendente()
        TxbValPendente.Text = CStr(FormatNumber(CDbl(TxbValTotal.Text) - CDbl(TxbValLiquidado.Text), 2))
    End Sub
    Private Sub calculaValorTotal()
        Try
            Dim total As Double = 0
            total = CDbl(TxbValOriginal.Text)
            If TxbValDesconto.Text <> "" Then
                total = total - CDbl(TxbValDesconto.Text)
            End If

            If TxbValDespAcess.Text <> "" Then
                total = total + CDbl(TxbValDespAcess.Text)
            End If
            If TxbValAcrescimo.Text <> "" Then
                total = total + CDbl(TxbValAcrescimo.Text)
            End If
            If TxbValMulta.Text <> "" Then
                total = total + CDbl(TxbValMulta.Text)
            End If
            If TxbValJurosPrinc.Text <> "" Then
                total = total + CDbl(TxbValJurosPrinc.Text)
            End If

            TxbValTotal.Text = CStr(total)
            calculaValorPendente()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TxbValDesconto_LostFocus(sender As Object, e As EventArgs) Handles TxbValDesconto.LostFocus
        If IsNumeric(TxbValDesconto.Text) = True And CDbl(TxbValDesconto.Text) > 0 Then
            TxbValDescPorc.Text = CStr(FormatNumber((CDbl(TxbValDesconto.Text) * 100) / (TxbValTotal.Text + val_desconto_old), 3))
        Else
            TxbValDescPorc.Text = "0,00"
        End If
        TxbValDespAcess.Select()
        calculaValorTotal()
        val_desconto_old = TxbValDesconto.Text
    End Sub
    Private Sub TxbValDescPorc_LostFocus(sender As Object, e As EventArgs) Handles TxbValDescPorc.LostFocus
        TxbValDesconto.Text = FormatNumber(((CDbl(TxbValTotal.Text + val_desconto_old) * (1 + ((CDbl(TxbValDescPorc.Text) / 100) * 1))) - CDbl(TxbValTotal.Text + val_desconto_old)), 2)
        val_desconto_old = TxbValDesconto.Text
        calculaValorTotal()
    End Sub
    Private Sub TxbValDespAcess_LostFocus(sender As Object, e As EventArgs) Handles TxbValDespAcess.LostFocus
        calculaValorTotal()
    End Sub
    Private Sub TxbValMulta_LostFocus(sender As Object, e As EventArgs) Handles TxbValMulta.LostFocus
        calculaValorTotal()
    End Sub
    Private Sub TxbValJurosPrinc_LostFocus(sender As Object, e As EventArgs) Handles TxbValJurosPrinc.LostFocus
        If IsNumeric(TxbValJurosPrinc.Text) = True And CDbl(TxbValJurosPrinc.Text) > 0 Then
            TxbValJuroPrincPorc.Text = CStr((CDbl(TxbValJurosPrinc.Text) * 100) / (TxbValTotal.Text - val_juros_old))
        Else
            TxbValJuroPrincPorc.Text = "0,00"
        End If
        TxbValAcrescimo.Select()
        calculaValorTotal()
        val_juros_old = TxbValJurosPrinc.Text
    End Sub
    Private Sub TxbValJuroPrincPorc_LostFocus(sender As Object, e As EventArgs) Handles TxbValJuroPrincPorc.LostFocus
        TxbValJurosPrinc.Text = FormatNumber(((CDbl(TxbValTotal.Text - val_juros_old) * (1 + ((CDbl(TxbValJuroPrincPorc.Text) / 100) * 1))) - CDbl(TxbValTotal.Text - val_juros_old)), 2)
        calculaValorTotal()
        val_juros_old = TxbValJurosPrinc.Text
    End Sub
    Private Sub TxbValAcrescimo_LostFocus(sender As Object, e As EventArgs) Handles TxbValAcrescimo.LostFocus
        calculaValorTotal()
    End Sub
    Private Sub FrmPagamentoRecebimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpDtaLiquidacao.Value = Today.AddDays(-5).ToShortDateString
        DtpDtaPredatado.Value = Today.AddDays(-5).ToShortDateString
        DtpDtaVenctoParc.Value = Today.AddDays(-5).ToShortDateString
        TxbDtaLiquidacao.Text = ""
        TxbDtaPredatado.Text = ""
        TxbDtaVencimentoParc.Text = ""

        atualizaDadosBanco()
        atualizaDadosParcela()
        calculaValorTotal()
        limparParcela()
        limparBanco()
        calculaValorLiquidado()
        TxbCodEspecie.Select()
        If ind_status = "A" Then
            readOnlyFalse()
            BtnConfirmaPagto.Enabled = True
            BtnExtornaPagto.Enabled = False
        Else
            readOnlyTrue()
            BtnConfirmaPagto.Enabled = False
            BtnExtornaPagto.Enabled = True
        End If
    End Sub
    Private Sub FrmPagamentoRecebimento_Closed(sender As Object, e As EventArgs) Handles MyBase.Closing
        If ind_status = "L" Or CDbl(TxbValLiquidado.Text) = 0 Then
            Exit Sub
        End If

        If MsgBox("Deseja salvar as alterações?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            finalizarPagamento()
        End If
    End Sub
    Private Sub finalizarPagamento()
        If TxbValEspecie.Text <> "" And TxbCodEspecie.Text = "" Then
            TxbCodEspecie.Select()
            Exit Sub
        End If

        If CDbl(TxbValLiquidado.Text) > 0 And TxbDtaLiquidacao.Text = "" Then
            MsgBox("Informe a data de liquidação!", MsgBoxStyle.Information, "Data Liquidação Invalida")
            TxbDtaLiquidacao.Select()
            Exit Sub
        End If
        If CDbl(TxbValTotal.Text) > CDbl(TxbValLiquidado.Text) Then
            If MsgBox("Deseja realizar a liquidação parcial?", MsgBoxStyle.YesNo, "Liquidação Parcial") = MsgBoxResult.Yes Then
                dtaVencimento.Text = "Data vencimento"
                dtaVencimento.DtpDtaFinal.MinDate = Today
                dtaVencimento.TxbDtaFinal.Text = ""
                dtaVencimento.ShowDialog()
                If CDate(ModVariavelGlobal.dtaFinal) < Today Then
                    MsgBox("Data não pode ser menor que hoje", MsgBoxStyle.Information, "Informação")
                    dtaVencimento.ShowDialog()
                End If
                newDtaVencimento = ModVariavelGlobal.dtaFinal
                    ModVariavelGlobal.dtaFinal = ""
                Else
                    Exit Sub
            End If
        End If
        If tabela = "tab_despesa" Then
            FrmDespesas.val_recebimento_especie_old = TxbValEspecie.Text
            FrmDespesas.cod_recebimento_especie_old = TxbCodEspecie.Text
            FrmDespesas.dta_liquidacao_old = TxbDtaLiquidacao.Text
            FrmDespesas.val_total_old = TxbValTotal.Text
            FrmDespesas.val_desconto_old = TxbValDesconto.Text
            FrmDespesas.val_desconto_porcentagem_old = TxbValDescPorc.Text
            FrmDespesas.val_despesa_acessoria_old = TxbValDespAcess.Text
            FrmDespesas.val_multa_old = TxbValMulta.Text
            FrmDespesas.val_juros_old = TxbValJurosPrinc.Text
            FrmDespesas.val_juros_porcentagem_old = TxbValJuroPrincPorc.Text
            FrmDespesas.val_acrescimo_old = TxbValAcrescimo.Text

        ElseIf tabela = "tab_titulo_receber" Then
            FrmTituloReceber.val_recebimento_especie_old = TxbValEspecie.Text
            FrmTituloReceber.cod_recebimento_especie_old = TxbCodEspecie.Text
            FrmTituloReceber.dta_liquidacao_old = TxbDtaLiquidacao.Text
            FrmTituloReceber.val_liquidado_old = TxbValLiquidado.Text
            FrmTituloReceber.val_total_old = TxbValTotal.Text
            FrmTituloReceber.val_desconto_old = TxbValDesconto.Text
            FrmTituloReceber.val_desconto_porcentagem_old = TxbValDescPorc.Text
            FrmTituloReceber.val_despesa_acessoria_old = TxbValDespAcess.Text
            FrmTituloReceber.val_multa_old = TxbValMulta.Text
            FrmTituloReceber.val_juros_old = TxbValJurosPrinc.Text
            FrmTituloReceber.val_juros_porcentagem_old = TxbValJuroPrincPorc.Text
            FrmTituloReceber.val_acrescimo_old = TxbValAcrescimo.Text
            FrmTituloReceber.ind_status_old = "L"

        End If
    End Sub

    Private Sub BtnBuscaEspecie_Click(sender As Object, e As EventArgs) Handles BtnBuscaEspecie.Click
        FrmPesquisa.tabela = "tab_especie_caixa"
        FrmPesquisa.ShowDialog()
        TxbCodEspecie.Text = ModVariavelGlobal.pesquisaCodigo
        txbDesEspecie.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnValEspecie_Click(sender As Object, e As EventArgs) Handles BtnValEspecie.Click
        If TxbValEspecie.Text = "" Then
            TxbValEspecie.Text = "0,00"
        End If
        TxbValEspecie.Text = CStr(CDbl(TxbValEspecie.Text) + CDbl(TxbValPendente.Text))
        calculaValorLiquidado()
    End Sub
    Private Sub TxbValEspecie_lostFocus(sender As Object, e As EventArgs) Handles TxbValEspecie.LostFocus
        calculaValorLiquidado()
        If IsNumeric(TxbValEspecie.Text) = False Or CDbl(TxbValEspecie.Text) = 0 Then
            TxbValEspecie.Text = "0,00"

        End If
        If TxbValPendente.Text < 0 Then
            MsgBox("Valor maior soma total")
            TxbValEspecie.Text = ""
            TxbValEspecie.Select()
            Exit Sub
        End If
        If TxbValEspecie.Text <> "" And IsNumeric(TxbValEspecie.Text) = True Then
            calculaValorLiquidado()
        End If
        If txbDesEspecie.Text = "" Then

            MsgBox("Informe especíe do pagamento")
            txbDesEspecie.Select()
            Exit Sub
        End If

    End Sub
    '#####################################################
    'Banco
    '####################################################

    Private Sub DgvBanco_DoubleClick(sender As Object, e As EventArgs) Handles DgvBanco.DoubleClick
        Try
            lbSeqPagamento.Text = DgvBanco.CurrentRow.Cells(0).Value
            TxbCodBanco.Text = DgvBanco.CurrentRow.Cells(2).Value
            Me.TxbNomBanco.Text = DgvBanco.CurrentRow.Cells(3).Value
            Me.txbAgencia.Text = DgvBanco.CurrentRow.Cells(4).Value
            Me.TxbConta.Text = DgvBanco.CurrentRow.Cells(5).Value
            Me.TxbDtaPredatado.Text = DgvBanco.CurrentRow.Cells(6).Value
            Me.TxbValBanco.Text = FormatNumber(DgvBanco.CurrentRow.Cells(7).Value, 2)

            Me.TxbCodBanco.Select()
        Catch ex As Exception
        End Try

    End Sub
    Public Sub atualizaDadosBanco()
        If IsNumeric(sequencia) = False Then
            Exit Sub
        End If
        Try
            Dim tab As DataTable
            dsBanco = banco.Consultar(sequencia, tabela)
            tab = dsBanco.Tables(0)

            If tab.Rows.Count > 0 Then
                DgvBanco.DataSource = Nothing
                DgvBanco.DataSource = dsBanco.Tables(0)
                formatarGridBanco()
                carregaFormularioBanco()
                If dsBanco.Tables(0).Rows.Count > 0 Then
                    LbTotalBanco.Text = dsBanco.Tables(0).Rows(0)("val_total").ToString
                    calculaValorLiquidado()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnSalvaBanco_Click(sender As Object, e As EventArgs) Handles BtnSalvaBanco.Click

        If TxbValBanco.Text = "" Or IsNumeric(TxbValBanco.Text) = False Or CDbl(TxbValBanco.Text) = 0 Then
            Exit Sub
        End If
        If TxbDtaPredatado.Text <> "" Then
            If CDate(TxbDtaPredatado.Text) < Now Then
                MsgBox("Data Pre-datado não pode ser menor que hoje", MsgBoxStyle.Information, "Informação")
                TxbDtaPredatado.Select()
                Exit Sub
            End If
        End If
        If CDbl(TxbValBanco.Text) > CDbl(TxbValPendente.Text) Then
            MsgBox("Valor não pode ser maior que valor pendênte")
            TxbValBanco.Select()
            Exit Sub
        End If

        If TxbCodBanco.Text = "" Then
            MsgBox("Informe Banco!", MsgBoxStyle.Information, "Informação")
            Exit Sub
            TxbCodBanco.Select()
        End If
        If txbAgencia.Text = "" Then
            MsgBox("Informe Agência!")
            Exit Sub
            txbAgencia.Select()
        End If
        If TxbConta.Text = "" Then
            MsgBox("Informe Conta!")
            Exit Sub
            TxbConta.Select()
        End If
        salvaRegistroBanco()
        calculaValorLiquidado()
        limparBanco()
    End Sub
    Public Sub salvaRegistroBanco()
        Try

            If tabela = "tab_despesa" Then
                banco.seq_despesa = sequencia
                banco.seq_titulo = 0
            ElseIf tabela = "tab_titulo_receber" Then
                banco.seq_despesa = 0
                banco.seq_titulo = sequencia
            End If
            banco.cod_banco = TxbCodBanco.Text
            banco.num_conta = TxbConta.Text
            banco.num_agencia = txbAgencia.Text
            banco.dta_pre_datado = TxbDtaPredatado.Text
            banco.val_pagamento = FormatNumber(TxbValBanco.Text, 2)


            If atualizarBanco = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                Try
                    ultimo = banco2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    banco.seq_pagamento = Convert.ToInt16(ult) + 1

                    banco.Cadastrar()
                    ultimo.Clear()
                Catch ex As Exception
                    banco.seq_pagamento = 1
                End Try
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            Else
                banco.seq_pagamento = lbSeqPagamento.Text
                banco.Atualizar()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            End If
            i = 0
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
        atualizaDadosBanco()
    End Sub
    Private Sub BtnExcluirBanco_Click(sender As Object, e As EventArgs) Handles BtnExcluiBanco.Click
        If lbSeqPagamento.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a :   " & TxbNomBanco.Text & " Valor:" & TxbValBanco.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                banco.seq_pagamento = lbSeqPagamento.Text
                banco.Excluir()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDadosBanco()
                limparBanco()
            Catch ex As Exception
                MsgBox("Erro ao excluir , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub
    Private Sub BtnBanco_Click(sender As Object, e As EventArgs) Handles BtnMenmonico.Click
        FrmPesquisa.tabela = "tab_banco"
        FrmPesquisa.ShowDialog()
        TxbCodBanco.Text = ModVariavelGlobal.pesquisaCodigo
        TxbNomBanco.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub DtpDtaPredatado_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaPredatado.ValueChanged
        TxbDtaPredatado.Text = DtpDtaPredatado.Value.ToShortDateString
    End Sub

    Private Sub BtnValBanco_Click(sender As Object, e As EventArgs) Handles BtnValBanco.Click
        TxbValBanco.Text = TxbValPendente.Text
    End Sub

    Private Sub BtnLimpaBanco_Click(sender As Object, e As EventArgs) Handles BtnLimpaBanco.Click
        limparBanco()
    End Sub
    Private Sub limparBanco()
        txbAgencia.Text = ""
        TxbCodBanco.Text = ""
        TxbNomBanco.Text = ""
        TxbConta.Text = ""
        TxbValBanco.Text = "0,00"
        TxbDtaPredatado.Text = ""
        atualizarBanco = 1
    End Sub
    Public Sub formatarGridBanco()
        Try
            With DgvBanco
                .Columns(0).HeaderText = "Seq."
                .Columns(1).HeaderText = "Despesa."
                .Columns(2).HeaderText = "Banco"
                .Columns(3).HeaderText = "Banco"
                .Columns(4).HeaderText = "Agencia"
                .Columns(5).HeaderText = "Conta."
                .Columns(6).HeaderText = "Pré-Datado"
                .Columns(7).HeaderText = "Valor"
                .Columns(8).HeaderText = "Total"
                .Columns(7).DefaultCellStyle.Format = "N2"
                .Columns(8).DefaultCellStyle.Format = "N2"
                .Columns(3).Width = 140
                .Columns(4).Width = 57
                .Columns(5).Width = 60
                .Columns(6).Width = 65
                .Columns(7).Width = 70
                .Columns(8).Width = 70
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Visible = False
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub carregaFormularioBanco()
        Try
            limparBanco()
            If dsBanco.Tables(0).Rows.Count > 0 Then
                atualizarBanco = 2
                lbSeqPagamento.Text = dsBanco.Tables(0).Rows(i)("seq_pagamento").ToString
                TxbCodBanco.Text = dsBanco.Tables(0).Rows(i)("cod_banco").ToString
                TxbNomBanco.Text = dsBanco.Tables(0).Rows(i)("nom_banco").ToString
                TxbConta.Text = dsBanco.Tables(0).Rows(i)("num_conta").ToString
                txbAgencia.Text = dsBanco.Tables(0).Rows(i)("num_agencia").ToString
                TxbDtaPredatado.Text = dsBanco.Tables(0).Rows(i)("dta_pre_datado").ToString
                TxbValBanco.Text = FormatNumber(dsBanco.Tables(0).Rows(i)("val_pagamento").ToString, 2)

            Else
                atualizarBanco = 1
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DtpDtaLiquidacao_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaLiquidacao.ValueChanged
        TxbDtaLiquidacao.Text = DtpDtaLiquidacao.Value.ToShortDateString
    End Sub

    '******************************************
    'Parcelamento
    '*****************************************
    Private Sub BtnLimpaParcela_Click(sender As Object, e As EventArgs) Handles BtnLimpaParcela.Click
        limparParcela()
    End Sub
    Private Sub limparParcela()
        TxbCodTipoParcela.Text = ""
        TxbDesTipoParcela.Text = ""
        DtpDtaLiquidacao.Value = Today
        TxbDtaVencimentoParc.Text = ""
        TxbValParcela.Text = "0,00"
        TxbValJurosParc.Text = "0,00"
        TxbValJurosParcPorc.Text = "0,00"
        CkbDiaFixo.Checked = False
        TxbIntervalVencto.Text = ""
        TxbValJurosParc.Text = "0,00"
        TxbValJurosParcPorc.Text = "0,00"
        TxbQtdParcela.Text = ""
        desabilitaParcelaAutomatica()
    End Sub
    Private Sub BtnSalvaParcela_Click(sender As Object, e As EventArgs) Handles BtnSalvaParcela.Click
        salvaRegistroParcela()
    End Sub
    Public Sub salvaRegistroParcela()
        Try
            If TxbCodTipoParcela.Text = "" Then
                MsgBox("Informe Tipo Parcela", MsgBoxStyle.Information, "Informação")
                TxbCodTipoParcela.Select()
                Exit Sub
            End If
            If TxbDtaVencimentoParc.Text = "" Then

                MsgBox("Informe Data Vencimento ", MsgBoxStyle.Information, "Informação")
                TxbDtaVencimentoParc.Select()
                Exit Sub
            Else
                If CDate(TxbDtaVencimentoParc.Text) < Today.ToShortDateString Then
                    MsgBox("Data Vencimento não pode ser menor que hoje", MsgBoxStyle.Information, "Informação")
                    TxbDtaVencimentoParc.Select()
                    Exit Sub
                End If

            End If
            If TxbValParcela.Text = "" Then
                MsgBox("Informe Valor Parcela", MsgBoxStyle.Information, "Informação")
                TxbValParcela.Select()
                Exit Sub
            End If
            If TxbValParcela.Text > TxbValPendente.Text Then
                MsgBox("Valor não pode ser maior que o valor pendente", MsgBoxStyle.Information, "Informação")
                TxbValParcela.Select()
                Exit Sub
            End If

            If tabela = "tab_despesa" Then
                parcela.seq_despesa = sequencia
                parcela.seq_titulo = 0
            ElseIf tabela = "tab_titulo_receber" Then
                parcela.seq_despesa = 0
                parcela.seq_titulo = sequencia
            End If

            If ckbParcelaAutomatica.Checked = True Then
                If TxbQtdParcela.Text = "" Or IsNumeric(TxbQtdParcela.Text) = False Then
                    MsgBox("Informe a quantidade de Parcelas", MsgBoxStyle.Information, "Informação")
                    TxbQtdParcela.Select()
                    Exit Sub
                End If
                If IsNumeric(TxbIntervalVencto.Text) = False And CkbDiaFixo.Checked = False Then
                    MsgBox("Dia fixo deve ser marcado" & vbCrLf & " 'OU' " & vbCrLf & "Intervalo de dia deve ser preenchido", MsgBoxStyle.Information, "Informação")
                    TxbIntervalVencto.Select()
                    Exit Sub
                End If
            End If
            parcela.cod_tipo_parcela = TxbCodTipoParcela.Text
            parcela.dta_vencimento = TxbDtaVencimentoParc.Text
            parcela.val_pagamento = TxbValParcela.Text
            parcela.val_juros = TxbValJurosParc.Text
            parcela.val_juros_porcentagem = TxbValJurosParcPorc.Text
            parcela.val_total = FormatNumber(CStr(CDbl(TxbValParcela.Text) + CDbl(TxbValJurosParc.Text)), 2)

            'pegar o ultimo registro
            Dim ultimo As New DataSet
            Try
                ultimo = parcela2.UltimoCadastrado
                Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                parcela.seq_pagamento = Convert.ToInt16(ult) + 1
                If ckbParcelaAutomatica.Checked = True Then
                    parcela.val_pagamento = FormatNumber(CStr(CDbl(TxbValParcela.Text / CUInt(TxbQtdParcela.Text))), 2)
                    If TxbValJurosParcPorc.Text > 0 Then
                        parcela.val_total = FormatNumber(CStr(CDbl(TxbValParcela.Text / CUInt(TxbQtdParcela.Text)) + CDbl(TxbValJurosParcPorc.Text)), 2)
                    End If
                    For x As Integer = 1 To CUInt(TxbQtdParcela.Text)

                        parcela.Cadastrar()
                        parcela.seq_pagamento = parcela.seq_pagamento + 1
                        If CkbDiaFixo.Checked = False Then
                            parcela.dta_vencimento = CDate(parcela.dta_vencimento).AddDays(CUInt(TxbIntervalVencto.Text))
                        Else
                            parcela.dta_vencimento = CDate(parcela.dta_vencimento).AddMonths(1)
                        End If
                    Next
                Else
                    parcela.Cadastrar()
                End If

                ultimo.Clear()
            Catch ex As Exception
                parcela.seq_pagamento = 1
            End Try
            MsgBox(" Cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")

        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no parcela" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
        atualizaDadosParcela()
        desabilitaParcelaAutomatica()
        limparParcela()
    End Sub
    Private Sub habilitaParcelaAutomatica()
        CkbDiaFixo.Enabled = True
        TxbIntervalVencto.Enabled = True
        TxbQtdParcela.Enabled = True
    End Sub
    Private Sub desabilitaParcelaAutomatica()
        CkbDiaFixo.Enabled = False
        TxbIntervalVencto.Enabled = False
        TxbQtdParcela.Enabled = False
        ckbParcelaAutomatica.Checked = False
    End Sub
    Private Sub ckbParcelaAutomatica_CheckedChanged(sender As Object, e As EventArgs) Handles ckbParcelaAutomatica.CheckedChanged
        If ckbParcelaAutomatica.Checked = True Then
            habilitaParcelaAutomatica()
        Else
            desabilitaParcelaAutomatica()
        End If
    End Sub

    Private Sub BtnExcluiParcela_Click(sender As Object, e As EventArgs) Handles BtnExcluiParcela.Click
        If LbSeqParcelamento.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a :   " & TxbDesTipoParcela.Text & " Data:" & TxbDtaVencimentoParc.Text & " Valor:" & TxbValParcela.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                parcela.seq_pagamento = LbSeqParcelamento.Text
                parcela.Excluir()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDadosParcela()
                limparParcela()
                desabilitaParcelaAutomatica()
            Catch ex As Exception
                MsgBox("Erro ao excluir , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub BtnTipoParcelamento_Click(sender As Object, e As EventArgs) Handles BtnTipoParcelamento.Click
        FrmPesquisa.tabela = "tab_tipo_parcela"
        FrmPesquisa.ShowDialog()
        TxbCodTipoParcela.Text = ModVariavelGlobal.pesquisaCodigo
        TxbDesTipoParcela.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub DtpDtaVenctoParc_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaVenctoParc.ValueChanged
        TxbDtaVencimentoParc.Text = DtpDtaVenctoParc.Value.ToShortDateString
    End Sub

    Private Sub CkbDiaFixo_CheckedChanged(sender As Object, e As EventArgs) Handles CkbDiaFixo.CheckedChanged
        If CkbDiaFixo.Checked = True Then
            TxbIntervalVencto.Enabled = False
        Else
            TxbIntervalVencto.Enabled = True
        End If
    End Sub
    Private Sub TxbIntervalVencto_TextChanged(sender As Object, e As EventArgs) Handles TxbIntervalVencto.TextChanged
        If TxbIntervalVencto.Text <> "" Then
            CkbDiaFixo.Checked = False
        End If
    End Sub

    Private Sub TxbValJurosParc_lostFocus(sender As Object, e As EventArgs) Handles TxbValJurosParc.LostFocus
        If CDbl(TxbValParcela.Text) = 0 Then
            MsgBox("Informe o valor Parcela", MsgBoxStyle.Information, "Informação")
            TxbValParcela.Select()
            Exit Sub
        End If
        If IsNumeric(TxbValJurosParc.Text) = True And CDbl(TxbValJurosParc.Text) > 0 Then
            TxbValJurosParcPorc.Text = CStr((CDbl(TxbValJurosParc.Text) * 100) / TxbValParcela.Text)
        End If
    End Sub

    Private Sub BtnConfirmarPagto_Click(sender As Object, e As EventArgs) Handles BtnConfirmaPagto.Click
        finalizarPagamento()
    End Sub
    Private Sub BtnExtornaPagto_Click(sender As Object, e As EventArgs) Handles BtnExtornaPagto.Click
        MsgBox("precisa ser configurado")
    End Sub

    Private Sub TxbValJurosParcPorc_LostFocus(sender As Object, e As EventArgs) Handles TxbValJurosParcPorc.LostFocus
        If CDbl(TxbValParcela.Text) = 0 Then
            MsgBox("Informe o valor Parcela", MsgBoxStyle.Information, "Informação")
            TxbValParcela.Select()
            Exit Sub
        End If
        If IsNumeric(TxbValJurosParcPorc.Text) = True And CDbl(TxbValJurosParcPorc.Text) > 0 Then

            TxbValJurosParc.Text = FormatNumber(((CDbl(TxbValParcela.Text) * (1 + ((CDbl(TxbValJurosParcPorc.Text) / 100) * 1))) - CDbl(TxbValParcela.Text)), 2)
        End If
    End Sub

    Private Sub BtnValParc_Click(sender As Object, e As EventArgs) Handles BtnValParc.Click
        TxbValParcela.Text = TxbValPendente.Text
    End Sub
    Public Sub formatarGridParcela()
        Try
            With DgvParcela
                .Columns(0).HeaderText = "Seq."
                .Columns(1).HeaderText = "despesa."
                .Columns(2).HeaderText = "Tipo"
                .Columns(3).HeaderText = "Tipo"
                .Columns(4).HeaderText = "Vencimento"
                .Columns(5).HeaderText = "Valor"
                .Columns(6).HeaderText = "Val.Juros"
                .Columns(7).HeaderText = "% Juros"
                .Columns(8).HeaderText = "Total"
                .Columns(9).HeaderText = "Total Geral"
                .Columns(5).DefaultCellStyle.Format = "N2"
                .Columns(6).DefaultCellStyle.Format = "N2"
                .Columns(7).DefaultCellStyle.Format = "N2"
                .Columns(8).DefaultCellStyle.Format = "N2"
                .Columns(9).DefaultCellStyle.Format = "N2"
                .Columns(3).Width = 100
                .Columns(4).Width = 70
                .Columns(5).Width = 61
                .Columns(6).Width = 55
                .Columns(7).Width = 55
                .Columns(8).Width = 70
                .Columns(9).Width = 70
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Visible = False
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub carregaFormularioParcela()
        Try
            limparParcela()
            If dsParcela.Tables(0).Rows.Count > 0 Then
                atualizarParcela = 2
                LbSeqParcelamento.Text = dsParcela.Tables(0).Rows(i)("seq_pagamento").ToString
                TxbCodTipoParcela.Text = dsParcela.Tables(0).Rows(i)("cod_tipo_parcela").ToString
                TxbDesTipoParcela.Text = dsParcela.Tables(0).Rows(i)("des_tipo_parcela").ToString
                TxbDtaVencimentoParc.Text = dsParcela.Tables(0).Rows(i)("dta_vencimento").ToString
                TxbValParcela.Text = FormatNumber(dsParcela.Tables(0).Rows(i)("val_pagamento").ToString, 2)
                TxbValJurosParc.Text = FormatNumber(dsParcela.Tables(0).Rows(i)("val_juros").ToString, 2)
                TxbValJurosParcPorc.Text = FormatNumber(dsParcela.Tables(0).Rows(i)("val_juros_porcentagem").ToString, 2)

            Else
                atualizarParcela = 1
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub atualizaDadosParcela()
        If IsNumeric(sequencia) = False Then
            Exit Sub
        End If
        Try
            Dim tab As DataTable
            dsParcela = parcela.Consultar(sequencia, tabela)
            tab = dsParcela.Tables(0)

            If tab.Rows.Count > 0 Then
                DgvParcela.DataSource = Nothing
                DgvParcela.DataSource = dsParcela.Tables(0)
                formatarGridParcela()
                carregaFormularioParcela()
                If dsParcela.Tables(0).Rows.Count > 0 Then
                    LbTotalParcela.Text = dsParcela.Tables(0).Rows(0)("val_total_geral").ToString
                    calculaValorLiquidado()
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DgvParcela_DoubleClick(sender As Object, e As EventArgs) Handles DgvParcela.DoubleClick
        Try
            LbSeqParcelamento.Text = DgvParcela.CurrentRow.Cells(0).Value
            TxbCodTipoParcela.Text = DgvParcela.CurrentRow.Cells(2).Value
            Me.TxbDesTipoParcela.Text = DgvParcela.CurrentRow.Cells(3).Value
            Me.TxbDtaVencimentoParc.Text = DgvParcela.CurrentRow.Cells(4).Value
            Me.TxbValParcela.Text = DgvParcela.CurrentRow.Cells(5).Value
            Me.TxbValJurosParc.Text = DgvParcela.CurrentRow.Cells(6).Value
            Me.TxbValJurosParcPorc.Text = DgvParcela.CurrentRow.Cells(7).Value

            Me.TxbCodTipoParcela.Select()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub readOnlyTrue()

        TxbValDesconto.ReadOnly = True
        TxbValDescPorc.ReadOnly = True
        TxbValDespAcess.ReadOnly = True
        TxbValMulta.ReadOnly = True
        TxbValJurosPrinc.ReadOnly = True
        TxbValJuroPrincPorc.ReadOnly = True
        TxbValAcrescimo.ReadOnly = True
        TxbDtaLiquidacao.ReadOnly = True
        DtpDtaLiquidacao.Enabled = False

        TxbValEspecie.ReadOnly = True
        TxbCodEspecie.ReadOnly = True
        txbDesEspecie.ReadOnly = True
        BtnBuscaEspecie.Enabled = True
        BtnValEspecie.Enabled = True

        txbAgencia.ReadOnly = True
        TxbCodBanco.ReadOnly = True
        TxbNomBanco.ReadOnly = True
        TxbConta.ReadOnly = True
        TxbValBanco.ReadOnly = True
        TxbDtaPredatado.ReadOnly = True
        BtnMenmonico.Enabled = False
        BtnValBanco.Enabled = False
        DtpDtaPredatado.Enabled = False

        TxbCodTipoParcela.ReadOnly = True
        TxbDesTipoParcela.ReadOnly = True
        BtnTipoParcelamento.Enabled = False
        TxbDtaVencimentoParc.ReadOnly = True
        DtpDtaVenctoParc.Enabled = False
        TxbValParcela.ReadOnly = True
        BtnValParc.Enabled = False
        TxbValJurosParc.ReadOnly = True
        TxbValJurosParcPorc.ReadOnly = True
        ckbParcelaAutomatica.Enabled = False
        CkbDiaFixo.Enabled = False
        TxbIntervalVencto.ReadOnly = True
        TxbValJurosParc.ReadOnly = True
        TxbQtdParcela.ReadOnly = True
    End Sub
    Private Sub readOnlyFalse()

        TxbValDesconto.ReadOnly = False
        TxbValDescPorc.ReadOnly = False
        TxbValDespAcess.ReadOnly = False
        TxbValMulta.ReadOnly = False
        TxbValJurosPrinc.ReadOnly = False
        TxbValJuroPrincPorc.ReadOnly = False
        TxbValAcrescimo.ReadOnly = False
        TxbDtaLiquidacao.ReadOnly = False
        DtpDtaLiquidacao.Enabled = True

        TxbValEspecie.ReadOnly = False
        TxbCodEspecie.ReadOnly = False
        txbDesEspecie.ReadOnly = False
        BtnBuscaEspecie.Enabled = True
        BtnValEspecie.Enabled = True

        txbAgencia.ReadOnly = False
        TxbCodBanco.ReadOnly = False
        TxbNomBanco.ReadOnly = False
        TxbConta.ReadOnly = False
        TxbValBanco.ReadOnly = False
        TxbDtaPredatado.ReadOnly = False
        BtnMenmonico.Enabled = True
        BtnValBanco.Enabled = True
        DtpDtaPredatado.Enabled = True

        TxbCodTipoParcela.ReadOnly = False
        TxbDesTipoParcela.ReadOnly = False
        BtnTipoParcelamento.Enabled = True
        TxbDtaVencimentoParc.ReadOnly = False
        DtpDtaVenctoParc.Enabled = True
        TxbValParcela.ReadOnly = False
        BtnValParc.Enabled = True
        TxbValJurosParc.ReadOnly = False
        TxbValJurosParcPorc.ReadOnly = False
        ckbParcelaAutomatica.Enabled = True
        CkbDiaFixo.Enabled = True
        TxbIntervalVencto.ReadOnly = False
        TxbValJurosParc.ReadOnly = False
        TxbQtdParcela.ReadOnly = False
    End Sub


End Class
