Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class FrmTituloReceber
    Dim conectar As New ConexaoSQL
    Dim ds, dsUltimo As New DataSet
    Dim tituloReceber, tituloReceber2 As New ClTituloReceber
    Dim frmDtaFinal As New FrmDataFinal
    Dim frmPagamento As New FrmPagamentoRecebimento
    Dim atualizar As Integer = 1
    Dim i As Integer = 0
    Dim geral As New ClGeral
    Dim cod_empresa_old As Integer = ModParametroSistema.cod_empresa
    Dim seq_titulo_old, dta_emissao_old, dta_vencimento_old, num_titulo_old, val_original_old, cod_tipo_cobranca_old,
        cod_pessoa_sacado_old, val_juros_original_old, des_observacao_old, ind_tipo_titulo_old,
        ind_fatura_old, cod_pdv_old, seq_fechamento_old, qtd_parcelas_old, num_parcela_old,
        seq_titulo_pai_old, seq_titulo_filho_old, seq_titulo_negociado_old, seq_titulo_fatura_old, dta_negociacao_old,
        val_negociado_old, seq_nota_old, seq_receita_old As String
    Public dta_emissao_final, dta_vecto_final, dta_liquidacao_final As String
    Public cod_recebimento_especie_old, val_recebimento_especie_old, des_recebimento_especie_old, dta_liquidacao_old,
        val_liquidado_old, val_total_old, val_desconto_old, val_desconto_porcentagem_old, val_despesa_acessoria_old,
        val_multa_old, val_juros_old, val_juros_porcentagem_old, val_acrescimo_old, ind_status_old, newDta_vencimento As String

    Private Sub Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t150501 = False Then
                MsgBox("Usuário sem permissão para acessar a Cidade!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
            BtnSalvar.Enabled = ModPermissaoUsuario.t1505011
            BtnExcluir.Enabled = ModPermissaoUsuario.t1505012
        End If
        limpar()
        Dgv.DataSource = Nothing
        BtnLiquidacao.Enabled = False
        DtpDtaEmissao.Value = Today.AddDays(-5)
        DtpDtaLiquidacao.Value = Today.AddDays(-5)
        DtpDtaVecto.Value = Today.AddDays(-5)
        TxbDtaEmissao.Text = ""
        TxbDtaLiquidacao.Text = ""
        TxbDtaVecto.Text = ""
        cod_pdv_old = ModParametroSistema.cod_pdv
    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        carregaOld()
        atualizaDados()
        carregaOld()
    End Sub
    Private Sub carregaOld()
        If TxbCodigo.Text = "" Then
            seq_titulo_old = 0
        Else
            seq_titulo_old = TxbCodigo.Text
        End If
        dta_emissao_old = TxbDtaEmissao.Text
        dta_vencimento_old = TxbDtaVecto.Text
        dta_liquidacao_old = TxbDtaLiquidacao.Text
        val_liquidado_old = TxbValLiquidado.Text
        num_titulo_old = TxbDescricao.Text
        val_original_old = TxbValOriginal.Text
        cod_tipo_cobranca_old = TxbCodTipoCobranca.Text
        cod_pessoa_sacado_old = TxbCodSacado.Text
        des_observacao_old = TxbObservacao.Text
        If CkbTipoAdiantaFunc.Checked = True Then
            ind_tipo_titulo_old = "AF"
        ElseIf CkbTipoCartaoCredito.Checked = True Then
            ind_tipo_titulo_old = "CC"
        ElseIf CkbTipoManual.Checked = True Then
            ind_tipo_titulo_old = "MA"
        ElseIf CkbTipoNotaFiscal.Checked = True Then
            ind_tipo_titulo_old = "NF"
        ElseIf CkbTipoReceita.Checked = True Then
            ind_tipo_titulo_old = "RE"
        Else
            ind_tipo_titulo_old = ""
        End If

        If RbStatusAberto.Checked = True Then
            ind_status_old = "A"
        ElseIf RbStatusFaturado.Checked = True Then
            ind_status_old = "F"
        ElseIf RbStatusLiquidado.Checked = True Then
            ind_status_old = "L"
        ElseIf RbStatusNegociado.Checked = True Then
            ind_status_old = "N"
        ElseIf RbStatusProtesto.Checked = True Then
            ind_status_old = "P"
        Else
            ind_status_old = ""
        End If

        If RbFaturaNao.Checked = True Then
            ind_fatura_old = "N"
        ElseIf RbFaturaSim.Checked = True Then
            ind_fatura_old = "S"
        Else
            ind_fatura_old = ""
        End If

        seq_fechamento_old = "0"
        qtd_parcelas_old = "0"
        num_parcela_old = "0"
        seq_titulo_pai_old = "0"
        seq_titulo_filho_old = "0"
        seq_titulo_negociado_old = "0"
        seq_titulo_fatura_old = "0"
        dta_negociacao_old = Nothing
        val_negociado_old = "0"
        seq_nota_old = "0"
        seq_receita_old = "0"
    End Sub
    Public Sub atualizaDados()

        Dim seqTitulo, codEmpresa, codTipo, codPessoa As Integer
        Dim valOriginal, valLiquidado As Double

        If TxbCodigo.Text = "" Then
            seqTitulo = 0
        Else
            seqTitulo = TxbCodigo.Text
        End If

        If CkbTodasEmpresa.Checked = True Then
            codEmpresa = ModParametroSistema.cod_empresa
        Else
            codEmpresa = 0
        End If
        If TxbCodTipoCobranca.Text = "" Then
            codTipo = 0
        Else
            codTipo = TxbCodTipoCobranca.Text
        End If

        If dta_emissao_final = "" Then
            dta_emissao_final = dta_emissao_old
        End If
        If dta_vecto_final = "" Then
            dta_vecto_final = dta_vencimento_old
        End If
        If dta_liquidacao_final = "" Then
            dta_liquidacao_final = dta_liquidacao_old
        End If

        If TxbCodSacado.Text = "" Then
            codPessoa = 0
        Else
            codPessoa = TxbCodSacado.Text
        End If
        If TxbValOriginal.Text = "" Then
            valOriginal = 0
        Else
            valOriginal = TxbValOriginal.Text
        End If
        If TxbValLiquidado.Text = "" Then
            valLiquidado = 0
        Else
            valLiquidado = TxbValLiquidado.Text
        End If

        Try

            Dim tabela As DataTable
            ds = tituloReceber.Consultar(dta_emissao_final, dta_vecto_final, dta_liquidacao_final, seqTitulo, codEmpresa,
                               codTipo, TxbDescricao.Text, TxbDtaEmissao.Text, TxbDtaVecto.Text,
                                TxbDtaLiquidacao.Text, codPessoa, valOriginal, valLiquidado)

            tabela = ds.Tables(0)

            If tabela.Rows.Count > 0 Then
                Dgv.DataSource = Nothing
                Dgv.DataSource = ds.Tables(0)
                formatarGrid()
                carregaFormulario()

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaRegistro()
    End Sub

    Private Sub TxbCodSacado_LostFocus(sender As Object, e As EventArgs) Handles TxbCodSacado.LostFocus
        Try
            If IsNumeric(TxbCodSacado.Text) = True Then
                TxbNomSacado.Text = geral.sqlBuscaDescricao("nom_pessoa", "tab_pessoa", "cod_pessoa", TxbCodSacado.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxbNomSacado_textChanged(sender As Object, e As EventArgs) Handles TxbNomSacado.TextChanged
        If TxbCodSacado.Text <> "" Then
            Exit Sub
        End If
        If Len(TxbNomSacado.Text) >= 2 Then
            FrmPesquisa.tabela = "tab_pessoa"
            FrmPesquisa.txbBusca.Text = TxbNomSacado.Text
            FrmPesquisa.ShowDialog()
        End If
    End Sub

    Private Sub BtnCadSacado_Click(sender As Object, e As EventArgs) Handles BtnCadSacado.Click
        If FrmPessoa.WindowState = FormWindowState.Minimized Then
            FrmPessoa.WindowState = FormWindowState.Normal
            FrmPessoa.Activate()
        Else
            FrmPessoa.Show()
        End If
    End Sub

    Private Sub BtnCadTipoCobranca_Click(sender As Object, e As EventArgs) Handles BtnCadTipoCobranca.Click
        If FrmTipoCobranca.WindowState = FormWindowState.Minimized Then
            FrmTipoCobranca.WindowState = FormWindowState.Normal
            FrmTipoCobranca.Activate()
        Else
            FrmTipoCobranca.Show()
        End If
    End Sub

    Public Sub salvaRegistro()
        Try
            If TxbDtaEmissao.Text = "" Then
                MsgBox("Informe a data emissao", MsgBoxStyle.Information, "Informação")
                TxbDtaEmissao.Select()
                Exit Sub
            End If
            If TxbDtaVecto.Text = "" Then
                MsgBox("Informe a data vencimento", MsgBoxStyle.Information, "Informação")
                TxbDtaVecto.Select()
                Exit Sub
            End If
            If CDate(TxbDtaVecto.Text) < CDate(TxbDtaEmissao.Text) Then
                MsgBox("Data de vencimento não pode ser menor que data de emissão", MsgBoxStyle.Information, "Informação")
                TxbDtaVecto.Select()
                Exit Sub
            End If
            If IsNumeric(TxbValOriginal.Text) = False Or CDbl(TxbValOriginal.Text) = 0 Then
                MsgBox("Informe o valor", MsgBoxStyle.Information, "Informação")
                TxbValOriginal.Select()
                Exit Sub
            End If
            If TxbCodTipoCobranca.Text = "" Then
                MsgBox("Informe tipo Cobranca", MsgBoxStyle.Information, "Informação")
                TxbCodTipoCobranca.Select()
                Exit Sub
            End If
            If TxbCodSacado.Text = "" Then
                MsgBox("Informe Sacado", MsgBoxStyle.Information, "Informação")
                TxbCodSacado.Select()
                Exit Sub
            End If
            If cod_recebimento_especie_old = "" Then
                tituloReceber.cod_recebimento_especie = Nothing
            Else
                tituloReceber.cod_recebimento_especie = cod_recebimento_especie_old
            End If

            If cod_recebimento_especie_old = "" Then
                tituloReceber.val_recebimento_especie = "0"
            Else
                tituloReceber.val_recebimento_especie = val_recebimento_especie_old
            End If

            If val_total_old = "" Then
                tituloReceber.val_total = "0"
            Else

                tituloReceber.val_total = val_total_old
            End If
            If val_desconto_old = "" Then
                tituloReceber.val_desconto = "0"
            Else
                tituloReceber.val_desconto = val_desconto_old
            End If
            If val_desconto_porcentagem_old = "" Then
                tituloReceber.val_desconto_porcentagem = "0"
            Else
                tituloReceber.val_desconto_porcentagem = val_desconto_porcentagem_old
            End If
            If val_despesa_acessoria_old = "" Then
                tituloReceber.val_despesa_acessoria = "0"
            Else
                tituloReceber.val_despesa_acessoria = val_despesa_acessoria_old
            End If
            If val_multa_old = "" Then
                tituloReceber.val_multa = "0"
            Else
                tituloReceber.val_multa = val_multa_old
            End If
            If val_juros_old = "" Then
                tituloReceber.val_juros = "0"
            Else
                tituloReceber.val_juros = val_juros_old
            End If
            If val_juros_porcentagem_old = "" Then
                tituloReceber.val_juros_porcentagem = "0"
            Else
                tituloReceber.val_juros_porcentagem = val_juros_porcentagem_old
            End If
            If val_acrescimo_old = "" Then
                tituloReceber.val_acrescimo = "0"
            Else
                tituloReceber.val_acrescimo = val_acrescimo_old
            End If

            'carregaOld()

            tituloReceber.cod_empresa = cod_empresa_old
            tituloReceber.dta_emissao = dta_emissao_old
            tituloReceber.num_titulo = num_titulo_old
            tituloReceber.val_original = val_original_old
            tituloReceber.cod_tipo_cobranca = cod_tipo_cobranca_old
            tituloReceber.cod_pessoa_sacado = cod_pessoa_sacado_old
            tituloReceber.des_observacao = des_observacao_old
            tituloReceber.dta_vencimento = dta_vencimento_old
            tituloReceber.dta_liquidacao = dta_liquidacao_old
            tituloReceber.val_liquidado = val_liquidado_old
            tituloReceber.val_juros_original = 0 ' configurar no parametro empresa 
            tituloReceber.val_liquidado = val_liquidado_old
            tituloReceber.ind_tipo_titulo = ind_tipo_titulo_old
            tituloReceber.ind_status = ind_status_old
            tituloReceber.ind_fatura = ind_fatura_old
            tituloReceber.cod_pdv = ModParametroSistema.cod_pdv
            tituloReceber.seq_fechamento = 0
            tituloReceber.qtd_parcelas = 1
            tituloReceber.num_parcela = 1


            If atualizar = 1 Then
                'pegar o ultimo registro
                Try
                    Dim ultimo As New DataSet
                    ultimo = tituloReceber2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    tituloReceber.seq_titulo = Convert.ToInt16(ult) + 1

                    tituloReceber.Cadastrar()
                    If ModParametroSistema.erro Then
                        ModParametroSistema.erro = False
                        Exit Sub
                    End If
                    MsgBox(" cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                    TxbCodigo.Text = tituloReceber.seq_titulo
                    ultimo.Clear()
                Catch ex As Exception
                    tituloReceber.seq_titulo = 1
                End Try

            Else
                tituloReceber.seq_titulo = TxbCodigo.Text
                tituloReceber.Atualizar()
                If atualizar = 2 Then
                    If ModParametroSistema.erro Then
                        ModParametroSistema.erro = False
                        Exit Sub
                    End If
                    MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                Else
                    atualizar = 2
                End If
            End If
            i = 0
            atualizaDados()
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a :   " & TxbCodigo.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                tituloReceber.seq_titulo = TxbCodigo.Text
                tituloReceber.Excluir()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()
                limpar()
            Catch ex As Exception
                MsgBox("Erro ao excluir , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        verificarAuteracao()
        limpar()

        Dgv.DataSource = Nothing
        TxbCodigo.Enabled = True
        TabControl1.SelectedIndex = 0

    End Sub
    Private Sub readOnlyTrue()
        TxbCodigo.ReadOnly = True
        TxbDescricao.ReadOnly = True
        TxbCodSacado.ReadOnly = True
        TxbNomSacado.ReadOnly = True
        TxbDtaEmissao.ReadOnly = True
        TxbDtaVecto.ReadOnly = True
        TxbCodTipoCobranca.ReadOnly = True
        TxbDesTipoCobranca.ReadOnly = True
        TxbValOriginal.ReadOnly = True
        TxbValJurosOriginal.ReadOnly = True
        TxbDtaLiquidacao.ReadOnly = True
        TxbValLiquidado.ReadOnly = True
        TxbObservacao.ReadOnly = True
        CkbPeFatura.Enabled = False
        CkbPeStatus.Enabled = False
        CkbPeTipo.Enabled = False
        CkbTipoAdiantaFunc.Enabled = False
        CkbTipoCartaoCredito.Enabled = False
        CkbTipoManual.Enabled = False
        CkbTipoNotaFiscal.Enabled = False
        CkbTipoReceita.Enabled = False
        CkbTodasEmpresa.Enabled = False
        RbFaturaNao.Enabled = False
        RbFaturaSim.Enabled = False
        RbStatusAberto.Enabled = False
        RbStatusFaturado.Enabled = False
        RbStatusLiquidado.Enabled = False
        RbStatusNegociado.Enabled = False
        RbStatusProtesto.Enabled = False
        BtnBuscaSacado.Enabled = False
        BtnBuscaTipoCobranca.Enabled = False
        BtnCadSacado.Enabled = False
        BtnCadTipoCobranca.Enabled = False
        BtnDtaFinalLiquidacao.Enabled = False
        BtnDtaVenctoFinal.Enabled = False
        BtnEmissaoFinal.Enabled = False
        BtnLiquidacao.Enabled = True
        DtpDtaEmissao.Enabled = False
        DtpDtaLiquidacao.Enabled = False
        DtpDtaVecto.Enabled = False

    End Sub
    Private Sub readOnlyFalse()
        TxbCodigo.ReadOnly = False
        TxbDescricao.ReadOnly = False
        TxbCodSacado.ReadOnly = False
        TxbNomSacado.ReadOnly = False
        TxbDtaEmissao.ReadOnly = False
        TxbDtaVecto.ReadOnly = False
        TxbCodTipoCobranca.ReadOnly = False
        TxbDesTipoCobranca.ReadOnly = False
        TxbValOriginal.ReadOnly = False
        TxbValJurosOriginal.ReadOnly = False
        TxbDtaLiquidacao.ReadOnly = False
        TxbValLiquidado.ReadOnly = False
        TxbObservacao.ReadOnly = False
        CkbPeFatura.Enabled = True
        CkbPeStatus.Enabled = True
        CkbPeTipo.Enabled = True
        CkbTipoAdiantaFunc.Enabled = True
        CkbTipoCartaoCredito.Enabled = True
        CkbTipoManual.Enabled = True
        CkbTipoNotaFiscal.Enabled = True
        CkbTipoReceita.Enabled = True
        CkbTodasEmpresa.Enabled = True
        RbFaturaNao.Enabled = True
        RbFaturaSim.Enabled = True
        RbStatusAberto.Enabled = True
        RbStatusFaturado.Enabled = True
        RbStatusLiquidado.Enabled = True
        RbStatusNegociado.Enabled = True
        RbStatusProtesto.Enabled = True
        BtnBuscaSacado.Enabled = True
        BtnBuscaTipoCobranca.Enabled = True
        BtnCadSacado.Enabled = True
        BtnCadTipoCobranca.Enabled = True
        BtnDtaFinalLiquidacao.Enabled = True
        BtnDtaVenctoFinal.Enabled = True
        BtnEmissaoFinal.Enabled = True
        BtnLiquidacao.Enabled = False
        DtpDtaEmissao.Enabled = True
        DtpDtaLiquidacao.Enabled = True
        DtpDtaVecto.Enabled = True
    End Sub

    Private Sub limpar()
        DtpDtaEmissao.Value = Today.AddDays(-5).ToShortDateString

        TxbCodigo.Text = ""
        CkbTodasEmpresa.Checked = False
        TxbDescricao.Text = ""
        TxbCodSacado.Text = ""
        TxbNomSacado.Text = ""
        TxbDtaEmissao.Text = ""
        TxbDtaVecto.Text = ""
        TxbCodTipoCobranca.Text = ""
        TxbDesTipoCobranca.Text = ""
        TxbValOriginal.Text = "0,00"
        TxbValJurosOriginal.Text = ""
        TxbDtaLiquidacao.Text = ""
        TxbValLiquidado.Text = ""
        TxbObservacao.Text = ""
        CkbTipoAdiantaFunc.Checked = False
        CkbTipoCartaoCredito.Checked = False
        CkbTipoManual.Checked = False
        CkbTipoNotaFiscal.Checked = False
        CkbTipoReceita.Checked = False
        RbStatusAberto.Checked = True
        RbFaturaNao.Checked = True
        seq_titulo_old = ""

        num_titulo_old = ""
        cod_pessoa_sacado_old = ""
        dta_emissao_old = ""
        dta_vencimento_old = ""
        cod_tipo_cobranca_old = ""
        val_original_old = ""
        val_juros_original_old = ""
        dta_liquidacao_old = ""
        val_liquidado_old = ""
        des_observacao_old = ""
        ind_tipo_titulo_old = ""
        ind_status_old = ""
        ind_fatura_old = ""
        cod_pdv_old = ""
        seq_fechamento_old = ""
        qtd_parcelas_old = ""
        num_parcela_old = ""
        seq_titulo_pai_old = ""
        seq_titulo_filho_old = ""
        seq_titulo_negociado_old = ""
        seq_titulo_fatura_old = ""
        dta_negociacao_old = ""
        val_negociado_old = ""
        seq_nota_old = ""
        seq_receita_old = ""
        cod_recebimento_especie_old = ""
        val_recebimento_especie_old = ""
        val_total_old = ""
        val_desconto_old = ""
        val_desconto_porcentagem_old = ""
        val_despesa_acessoria_old = ""
        val_multa_old = ""
        val_juros_old = ""
        val_juros_porcentagem_old = ""
        val_acrescimo_old = ""

        dta_emissao_final = ""
        dta_vecto_final = ""
        dta_liquidacao_final = ""

        atualizar = 1
        TxbCodigo.Enabled = True
        BtnLiquidacao.Enabled = False
        TxbCodigo.Select()
        readOnlyFalse()
    End Sub
    Public Sub formatarGrid()
        Try
            With Dgv
                .Columns(0).HeaderText = "Sequencia"
                .Columns(1).HeaderText = "Empresa"
                .Columns(2).HeaderText = "Numero"
                .Columns(3).HeaderText = "Sacado"
                .Columns(4).HeaderText = ""
                .Columns(5).HeaderText = "Emissao"
                .Columns(6).HeaderText = "Vencimento"
                .Columns(7).HeaderText = "Tipo Cobranca"
                .Columns(8).HeaderText = ""
                .Columns(9).HeaderText = "R$ Original"
                .Columns(9).DefaultCellStyle.Format = "N2"
                .Columns(10).HeaderText = "R$ Juros Original"
                .Columns(10).DefaultCellStyle.Format = "N2"
                .Columns(11).HeaderText = "Liquidacao"
                .Columns(12).HeaderText = "R$ Liquidado"
                .Columns(12).DefaultCellStyle.Format = "N2"
                .Columns(13).HeaderText = "Observacao"
                .Columns(14).HeaderText = "Tipo"
                .Columns(15).HeaderText = "Status"
                .Columns(16).HeaderText = "Fatura"
                .Columns(17).HeaderText = "Pdv"
                .Columns(18).HeaderText = "Fechamento Caixa"
                .Columns(19).HeaderText = "Qtd.Parcelas"
                .Columns(20).HeaderText = "Num Parcela"
                .Columns(21).HeaderText = "Titulo Pai"
                .Columns(22).HeaderText = "Titulo Filho"
                .Columns(23).HeaderText = "Titulo Negociado"
                .Columns(24).HeaderText = "Titulo Faturado"
                .Columns(25).HeaderText = "Negociação"
                .Columns(26).HeaderText = "R$ Negociado"
                .Columns(26).DefaultCellStyle.Format = "N2"
                .Columns(27).HeaderText = "Seq. Nota"
                .Columns(28).HeaderText = "Seq. Receita"
                .Columns(29).Visible = False
                .Columns(30).HeaderText = "R$ Especie"
                .Columns(30).DefaultCellStyle.Format = "N2"
                .Columns(31).HeaderText = "Total"
                .Columns(31).DefaultCellStyle.Format = "N2"
                .Columns(32).HeaderText = "R$ Desconto"
                .Columns(32).DefaultCellStyle.Format = "N2"
                .Columns(33).HeaderText = "% Desconto"
                .Columns(33).DefaultCellStyle.Format = "N2"
                .Columns(34).HeaderText = "Desp. Acessoria	"
                .Columns(34).DefaultCellStyle.Format = "N2"
                .Columns(35).HeaderText = "R$ Multa"
                .Columns(35).DefaultCellStyle.Format = "N2"
                .Columns(36).HeaderText = "R$ Juros"
                .Columns(36).DefaultCellStyle.Format = "N2"
                .Columns(37).HeaderText = "% Juros"
                .Columns(37).DefaultCellStyle.Format = "N2"
                .Columns(38).HeaderText = "R$ Acrescimo"
                .Columns(38).DefaultCellStyle.Format = "N2"
                .Columns(39).Visible = False
                .Columns(0).Width = 55
                .Columns(1).Width = 55
                .Columns(2).Width = 50
                .Columns(3).Width = 50
                .Columns(4).Width = 100
                .Columns(5).Width = 70
                .Columns(6).Width = 70
                .Columns(7).Width = 60
                .Columns(8).Width = 100
                .Columns(9).Width = 60
                .Columns(10).Width = 60
                .Columns(11).Width = 70
                .Columns(12).Width = 60
                .Columns(13).Width = 100
                .Columns(14).Width = 50
                .Columns(15).Width = 50
                .Columns(16).Width = 50
                .Columns(17).Width = 50
                .Columns(18).Width = 50
                .Columns(19).Width = 50
                .Columns(20).Width = 50
                .Columns(21).Width = 50
                .Columns(22).Width = 50
                .Columns(23).Width = 50
                .Columns(24).Width = 50
                .Columns(25).Width = 50
                .Columns(26).Width = 50
                .Columns(27).Width = 50
                .Columns(28).Width = 50
                .Columns(29).Width = 50
                .Columns(30).Width = 50
                .Columns(31).Width = 50
                .Columns(32).Width = 50
                .Columns(33).Width = 50
                .Columns(34).Width = 50
                .Columns(35).Width = 50
                .Columns(36).Width = 50
                .Columns(37).Width = 50
                .Columns(38).Width = 50
                .Columns(39).Width = 50

            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnEmissaoFinal_Click(sender As Object, e As EventArgs) Handles BtnEmissaoFinal.Click
        frmDtaFinal.tela = "dtaTRecEmissao"
        frmDtaFinal.DtpDtaFinal.Value = CDate(TxbDtaEmissao.Text)
        frmDtaFinal.TxbDtaFinal.Text = ""
        frmDtaFinal.ShowDialog()
        dta_emissao_final = ModVariavelGlobal.dtaFinal
        ModVariavelGlobal.dtaFinal = ""
    End Sub
    Private Sub BtnBuscaSacado_Click(sender As Object, e As EventArgs) Handles BtnBuscaSacado.Click
        FrmPesquisa.tabela = "tab_pessoa"
        FrmPesquisa.ShowDialog()
        TxbCodSacado.Text = ModVariavelGlobal.pesquisaCodigo
        TxbNomSacado.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub
    Private Sub BtnBuscaTipo_Click(sender As Object, e As EventArgs) Handles BtnBuscaTipoCobranca.Click
        FrmPesquisa.tabela = "tab_tipo_cobranca"
        FrmPesquisa.ShowDialog()
        TxbCodTipoCobranca.Text = ModVariavelGlobal.pesquisaCodigo
        TxbDesTipoCobranca.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub
    Private Sub BtnLiquidacao_Click(sender As Object, e As EventArgs) Handles BtnLiquidacao.Click
        frmPagamento.Text = "Liquidação Titulo a Receber"
        frmPagamento.TxbValOriginal.Text = TxbValOriginal.Text
        frmPagamento.sequencia = TxbCodigo.Text
        frmPagamento.TxbValLiquidado.Text = val_liquidado_old
        frmPagamento.TxbValTotal.Text = val_total_old
        frmPagamento.TxbValDesconto.Text = val_desconto_old
        frmPagamento.TxbValDescPorc.Text = val_desconto_porcentagem_old
        frmPagamento.TxbValDespAcess.Text = val_despesa_acessoria_old
        frmPagamento.TxbValMulta.Text = val_multa_old
        frmPagamento.TxbValJurosPrinc.Text = val_juros_old
        frmPagamento.TxbValJuroPrincPorc.Text = val_juros_porcentagem_old
        frmPagamento.TxbValAcrescimo.Text = val_acrescimo_old
        frmPagamento.ind_status = ind_status_old
        frmPagamento.DtpDtaLiquidacao.Value = dta_liquidacao_old
        If IsNumeric(val_recebimento_especie_old) = True And CDbl(val_recebimento_especie_old) > 0 Then
            frmPagamento.TxbValEspecie.Text = val_recebimento_especie_old
            frmPagamento.TxbCodEspecie.Text = cod_recebimento_especie_old
            frmPagamento.txbDesEspecie.Text = des_recebimento_especie_old
        End If
        frmPagamento.tabela = "tab_titulo_receber"
        frmPagamento.ShowDialog()
        atualizar = 3
        salvaRegistro()
    End Sub
    Public Sub carregaFormulario()
        Try
            limpar()
            If ds.Tables(0).Rows.Count > 0 Then
                atualizar = 2
                TxbCodigo.Text = ds.Tables(0).Rows(i)("seq_titulo").ToString
                TxbDescricao.Text = ds.Tables(0).Rows(i)("num_titulo").ToString
                TxbCodSacado.Text = ds.Tables(0).Rows(i)("cod_pessoa_sacado").ToString
                TxbNomSacado.Text = ds.Tables(0).Rows(i)("nom_pessoa").ToString
                TxbDtaEmissao.Text = ds.Tables(0).Rows(i)("dta_emissao").ToString
                TxbDtaVecto.Text = ds.Tables(0).Rows(i)("dta_vencimento").ToString
                TxbCodTipoCobranca.Text = ds.Tables(0).Rows(i)("cod_tipo_cobranca").ToString
                TxbDesTipoCobranca.Text = ds.Tables(0).Rows(i)("des_tipo_cobranca").ToString
                TxbValOriginal.Text = FormatNumber(ds.Tables(0).Rows(i)("val_original"), 2).ToString
                TxbValJurosOriginal.Text = FormatNumber(ds.Tables(0).Rows(i)("val_juros_original"), 2).ToString
                TxbDtaLiquidacao.Text = ds.Tables(0).Rows(i)("dta_liquidacao").ToString
                TxbValLiquidado.Text = FormatNumber(ds.Tables(0).Rows(i)("val_liquidado"), 2).ToString
                TxbObservacao.Text = ds.Tables(0).Rows(i)("des_observacao").ToString

                If ds.Tables(0).Rows(i)("ind_tipo_titulo").ToString = "AF" Then
                    CkbTipoAdiantaFunc.Checked = True
                ElseIf ds.Tables(0).Rows(i)("ind_tipo_titulo").ToString = "CC" Then
                    CkbTipoCartaoCredito.Checked = True
                ElseIf ds.Tables(0).Rows(i)("ind_tipo_titulo").ToString = "MA" Then
                    CkbTipoManual.Checked = True
                ElseIf ds.Tables(0).Rows(i)("ind_tipo_titulo").ToString = "NF" Then
                    CkbTipoNotaFiscal.Checked = True
                ElseIf ds.Tables(0).Rows(i)("ind_tipo_titulo").ToString = "RE" Then
                    CkbTipoReceita.Checked = True
                End If

                If ds.Tables(0).Rows(i)("ind_status").ToString = "A" Then
                    RbStatusAberto.Checked = True
                ElseIf ds.Tables(0).Rows(i)("ind_status").ToString = "F" Then
                    RbStatusFaturado.Checked = True
                ElseIf ds.Tables(0).Rows(i)("ind_status").ToString = "N" Then
                    RbStatusNegociado.Checked = True
                ElseIf ds.Tables(0).Rows(i)("ind_status").ToString = "P" Then
                    RbStatusProtesto.Checked = True
                ElseIf ds.Tables(0).Rows(i)("ind_status").ToString = "L" Then
                    RbStatusLiquidado.Checked = True
                End If

                If ds.Tables(0).Rows(i)("ind_fatura").ToString = "S" Then
                    RbFaturaSim.Checked = True
                Else
                    RbFaturaNao.Checked = True
                End If


                cod_recebimento_especie_old = ds.Tables(0).Rows(i)("cod_recebimento_especie").ToString
                    val_recebimento_especie_old = ds.Tables(0).Rows(i)("val_recebimento_especie").ToString
                    des_recebimento_especie_old = ds.Tables(0).Rows(i)("des_recebimento_especie").ToString
                If ds.Tables(0).Rows(i)("dta_liquidacao").ToString <> "" Then
                    dta_liquidacao_old = ds.Tables(0).Rows(i)("dta_liquidacao").ToString.Substring(0, 10)
                End If
                val_liquidado_old = ds.Tables(0).Rows(i)("val_liquidado").ToString
                val_total_old = ds.Tables(0).Rows(i)("val_total").ToString
                    val_desconto_old = ds.Tables(0).Rows(i)("val_desconto").ToString
                    val_desconto_porcentagem_old = ds.Tables(0).Rows(i)("val_desconto_porcentagem").ToString
                    val_despesa_acessoria_old = ds.Tables(0).Rows(i)("val_despesa_acessoria").ToString
                    val_multa_old = ds.Tables(0).Rows(i)("val_multa").ToString
                    val_juros_old = ds.Tables(0).Rows(i)("val_juros").ToString
                    val_juros_porcentagem_old = ds.Tables(0).Rows(i)("val_juros_porcentagem").ToString
                    val_acrescimo_old = ds.Tables(0).Rows(i)("val_acrescimo").ToString
                    carregaOld()
                    TxbCodigo.Enabled = False
                BtnLiquidacao.Enabled = True
                readOnlyTrue()
            Else
                    atualizar = 1

            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub verificarAuteracao()
        Dim msg As String = ""
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        If dta_emissao_old <> TxbDtaEmissao.Text Then
            msg = "Deseja salvar alteração data" & vbCrLf & "Anterior: " & dta_emissao_old & vbCrLf & " Nova : " & TxbDtaEmissao.Text
        End If
        If num_titulo_old <> TxbDescricao.Text Then
            msg = msg & vbCrLf & "Deseja salvar alteração num Doc" & vbCrLf & "Anterior: " & num_titulo_old & vbCrLf & " Nova : " & TxbDescricao.Text & "?"
        End If

        If val_original_old <> TxbValOriginal.Text Then
            msg = msg & vbCrLf & "Deseja salvar alteração Valor" & vbCrLf & "Anterior: " & val_original_old & vbCrLf & " Nova : " & TxbValOriginal.Text
        End If
        If cod_tipo_cobranca_old <> TxbCodTipoCobranca.Text Then
            msg = msg & vbCrLf & "Deseja salvar alteração Tipo Despesa" & vbCrLf & "Anterior: " & cod_tipo_cobranca_old & vbCrLf & " Nova : " & TxbCodTipoCobranca.Text
        End If
        If cod_pessoa_sacado_old <> TxbCodSacado.Text Then
            msg = msg & vbCrLf & "Deseja salvar alteração Favorecido" & vbCrLf & "Anterior: " & cod_pessoa_sacado_old & vbCrLf & " Nova : " & TxbCodSacado.Text
        End If
        If des_observacao_old <> TxbObservacao.Text Then
            msg = msg & vbCrLf & "Deseja salvar alteração Observação" & vbCrLf & "Anterior: " & des_observacao_old & vbCrLf & " Nova : " & TxbObservacao.Text
        End If
        If msg <> "" Then
            If MsgBox("Deseja salvar a alteraçã em:" & vbCrLf & msg & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                salvaRegistro()
            End If
        End If

    End Sub
    Private Sub BtnGrid_Click(sender As Object, e As EventArgs) Handles BtnGrid.Click
        If TabControl1.SelectedIndex = 1 Then
            TabControl1.SelectedIndex = 0
        Else
            TabControl1.SelectedIndex = 1
        End If
    End Sub
    Private Sub BtnPrimeiroReg_Click(sender As Object, e As EventArgs) Handles BtnPrimeiroReg.Click
        verificarAuteracao()
        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            carregaFormulario()
        End If

    End Sub


    Private Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        Try
            TxbCodigo.Text = Dgv.CurrentRow.Cells(0).Value
            TxbCodigo.Text = Dgv.CurrentRow.Cells(1).Value
            TxbDescricao.Text = Dgv.CurrentRow.Cells(2).Value
            TxbCodSacado.Text = Dgv.CurrentRow.Cells(3).Value
            TxbNomSacado.Text = Dgv.CurrentRow.Cells(4).Value
            TxbDtaEmissao.Text = Dgv.CurrentRow.Cells(5).Value
            TxbDtaVecto.Text = Dgv.CurrentRow.Cells(6).Value
            TxbCodTipoCobranca.Text = Dgv.CurrentRow.Cells(7).Value
            TxbDesTipoCobranca.Text = Dgv.CurrentRow.Cells(8).Value
            TxbValOriginal.Text = FormatNumber(Dgv.CurrentRow.Cells(9).Value, 2).ToString
            TxbValJurosOriginal.Text = FormatNumber(Dgv.CurrentRow.Cells(10).Value, 2).ToString
            If IsDate(Dgv.CurrentRow.Cells(11).Value) Then
                TxbDtaLiquidacao.Text = Dgv.CurrentRow.Cells(11).Value
            Else
                TxbDtaLiquidacao.Text = ""
            End If

            TxbValLiquidado.Text = FormatNumber(Dgv.CurrentRow.Cells(12).Value, 2).ToString
            TxbObservacao.Text = Dgv.CurrentRow.Cells(13).Value
            If Dgv.CurrentRow.Cells(14).Value = "AF" Then
                CkbTipoAdiantaFunc.Checked = True
            ElseIf Dgv.CurrentRow.Cells(14).Value = "CC" Then
                CkbTipoCartaoCredito.Checked = True
            ElseIf Dgv.CurrentRow.Cells(14).Value = "MA" Then
                CkbTipoManual.Checked = True
            ElseIf Dgv.CurrentRow.Cells(14).Value = "NF" Then
                CkbTipoNotaFiscal.Checked = True
            ElseIf Dgv.CurrentRow.Cells(14).Value = "RE" Then
                CkbTipoReceita.Checked = True
            End If

            If Dgv.CurrentRow.Cells(15).Value = "A" Then
                RbStatusAberto.Checked = True
            ElseIf Dgv.CurrentRow.Cells(15).Value = "F" Then
                RbStatusFaturado.Checked = True
            ElseIf Dgv.CurrentRow.Cells(15).Value = "N" Then
                RbStatusNegociado.Checked = True
            ElseIf Dgv.CurrentRow.Cells(15).Value = "P" Then
                RbStatusProtesto.Checked = True
            ElseIf Dgv.CurrentRow.Cells(15).Value = "L" Then
                RbStatusLiquidado.Checked = True
            End If

            If Dgv.CurrentRow.Cells(16).Value = "S" Then
                RbFaturaSim.Checked = True
            Else
                RbFaturaNao.Checked = True
            End If
            seq_titulo_old = ""

            If IsDBNull(Dgv.CurrentRow.Cells(29).Value) = True Then
                cod_recebimento_especie_old = ""
            Else
                cod_recebimento_especie_old = Dgv.CurrentRow.Cells(29).Value
            End If

            val_recebimento_especie_old = Dgv.CurrentRow.Cells(30).Value
            If IsDBNull(Dgv.CurrentRow.Cells(31).Value) = True Then
                dta_liquidacao_old = ""
            Else
                dta_liquidacao_old = Dgv.CurrentRow.Cells(31).Value
            End If
            val_liquidado_old = Dgv.CurrentRow.Cells(32).Value


            val_desconto_old = Dgv.CurrentRow.Cells(32).Value
            val_desconto_porcentagem_old = Dgv.CurrentRow.Cells(33).Value
            val_despesa_acessoria_old = Dgv.CurrentRow.Cells(34).Value
            val_multa_old = Dgv.CurrentRow.Cells(35).Value
            val_juros_old = Dgv.CurrentRow.Cells(36).Value
            val_juros_porcentagem_old = Dgv.CurrentRow.Cells(37).Value
            val_acrescimo_old = Dgv.CurrentRow.Cells(38).Value
            TabControl1.SelectedIndex = 0
            Me.TxbCodigo.Select()
            readOnlyTrue()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        verificarAuteracao()

        If ds.Tables(0).Rows.Count > 0 Then
            If i = 0 Then
                i = ds.Tables(0).Rows.Count - 1
            Else
                i = i - 1
            End If
        End If
        carregaFormulario()
    End Sub
    Private Sub BtnUltimoReg_Click(sender As Object, e As EventArgs) Handles BtnUltimoReg.Click
        verificarAuteracao()

        If ds.Tables(0).Rows.Count > 0 Then
            i = ds.Tables(0).Rows.Count - 1
        End If
        carregaFormulario()
    End Sub
    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        verificarAuteracao()

        If ds.Tables(0).Rows.Count > 0 Then
            If i < ds.Tables(0).Rows.Count - 1 Then
                i = i + 1
            Else
                i = 0
            End If
        End If
        carregaFormulario()
    End Sub
    Private Sub BtnCsv_Click(sender As Object, e As EventArgs) Handles BtnCsv.Click
        Try
            If ds.Tables(0).Rows.Count < 1 Then
                Exit Sub
            End If

            'My.Computer.FileSystem.CreateDirectory("C:\\CashMonitor")
            Dim nomArquivo As String
            Dim dataAtual As String
            Dim nomPasta As String

            'localizar a pasta
            Dim pasta As New FolderBrowserDialog
            Dim dr As DialogResult = pasta.ShowDialog()
            If dr = System.Windows.Forms.DialogResult.OK Then
                nomPasta = pasta.SelectedPath
            End If

            Dim horaMin As String
            dataAtual = Format(Today, "ddmmyyyy")
            dataAtual = Replace(dataAtual, "00", "10")
            horaMin = Format(Now, "hhmm")

            nomArquivo = Me.Text & "_" & dataAtual & "_" & horaMin

            Dim CSV As System.IO.StreamWriter = New System.IO.StreamWriter(nomPasta & nomArquivo & ".csv")
            Dim i As Integer, x As Integer

            Dim QtdColunas As Integer = Dgv.ColumnCount - 1

            For i = 0 To QtdColunas
                If Dgv.Columns(i).HeaderText.Substring(0, 6) <> "Column" Then
                    CSV.Write(Dgv.Columns(i).HeaderText)

                    If (i < QtdColunas) Then

                        CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                    End If
                End If
            Next i

            ' CSV.Write(CSV.NewLine)

            Dim QtdRows As Integer = Dgv.Rows.Count - 1

            For i = 0 To QtdRows

                For x = 0 To QtdColunas

                    If (Not Dgv.Rows(i).Cells(x).Value Is Nothing) Then
                        CSV.Write(Dgv.Rows(i).Cells(x).Value.ToString())

                    End If

                    If (x < QtdColunas) Then
                        CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                    End If

                Next x
                CSV.Write(CSV.NewLine)
            Next i
            MsgBox("Arquivo criado com sucesso em   " & nomPasta & "\" & nomArquivo)

            CSV.Close()
        Catch ex As Exception
            MsgBox("Erro ao Salvar o arquivo " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Sub DtpDtaEmissao_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaEmissao.ValueChanged

        TxbDtaEmissao.Text = DtpDtaEmissao.Value.ToShortDateString
    End Sub
    Private Sub BtnDtaFinalLiquidacao_Click(sender As Object, e As EventArgs) Handles BtnDtaFinalLiquidacao.Click
        frmDtaFinal.tela = "dtaTRecEmissao"
        frmDtaFinal.DtpDtaFinal.Value = Today
        frmDtaFinal.TxbDtaFinal.Text = ""
        frmDtaFinal.ShowDialog()
        dta_liquidacao_final = ModVariavelGlobal.dtaFinal
        ModVariavelGlobal.dtaFinal = ""
    End Sub
    Private Sub BtnDtaVenctoFinal_Click(sender As Object, e As EventArgs) Handles BtnDtaVenctoFinal.Click
        frmDtaFinal.tela = "dtaTRecEmissao"
        frmDtaFinal.DtpDtaFinal.Value = Today
        frmDtaFinal.TxbDtaFinal.Text = ""
        frmDtaFinal.ShowDialog()
        dta_vecto_final = ModVariavelGlobal.dtaFinal
        ModVariavelGlobal.dtaFinal = ""
    End Sub
    Private Sub DtpDtaLiquidacao_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaLiquidacao.ValueChanged
        TxbDtaLiquidacao.Text = DtpDtaLiquidacao.Value.ToShortDateString
    End Sub
    Private Sub DtpDtaVecto_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaVecto.ValueChanged
        TxbDtaVecto.Text = DtpDtaVecto.Value.ToShortDateString
    End Sub
End Class
