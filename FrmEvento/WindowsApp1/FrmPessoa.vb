Public Class FrmPessoa
    Dim conectar As New ConexaoSQL
    Dim ds, dsDependente As New DataSet
    Dim pessoa, pessoa2 As New ClPessoa
    Dim geral As New ClGeral
    Dim dependente As New ClPessoaDependente
    Dim funcionario As New ClPessoaFuncionario
    Dim atualizar As Integer = 1
    Dim atualizarDependente As Integer = 1
    Dim atualizarFunc As Integer = 1
    Dim i As Integer = 0
    Dim cod_pessoa_old, nom_pessoa_old, nom_fantasia_old, num_cnpj_cpf_old, num_ie_rg_old,
        dta_nascimento_old, des_logradouro_old, des_complemento_old, cod_cidade_old, nom_cidade_old,
        nom_bairro_old, num_cep_old, num_telefone_1_old, num_telefone_2_old, num_telefone_3_old,
        des_observacao_old, dta_cadastro_old, ind_cliente_old, ind_fornecedor_old,
        ind_funcionario_old, ind_ativo_old, des_email_old, ind_pe_old, ind_preco_venda_old As String
    Dim cod_dependente_old, nom_dependente_old, num_fone_depte_old, nom_apelido_old,
        dta_nascimento_depte_old, des_observacao_depte_old As String
    Dim cod_funcao_old, des_funcao_old, val_salario_old, val_custo_hora_old, ind_tipo_salario_old,
        dta_admissao_old, dta_demissao_old, dta_ultimo_reajuste_old, des_observacao_func_old, cod_funcao_funcionario_old, ind_agenda_servico_old As String

    Private Sub DtpDtaNasc_TextChanged(sender As Object, e As EventArgs) Handles DtpDtaNasc.TextChanged
        TxbDtaNasc.Text = DtpDtaNasc.Value.ToShortDateString
    End Sub

    Private Sub DtpAdmissaoFunc_TextChanged(sender As Object, e As EventArgs) Handles DtpAdmissaoFunc.TextChanged
        TxbDtaAdmissaoFunc.Text = DtpAdmissaoFunc.Value.ToShortDateString
    End Sub
    Private Sub DtpDtaDemissaoFunc_TextChanged(sender As Object, e As EventArgs) Handles DtpDtaDemissaoFunc.TextChanged
        TxbDtaDemissaoFunc.Text = DtpDtaDemissaoFunc.Value.ToShortDateString
    End Sub

    Private Sub BtCidade_Click(sender As Object, e As EventArgs) Handles BtnCidade.Click
        FrmPesquisa.tabela = "tab_cidade"
        FrmPesquisa.ShowDialog()
        TxbCodCidade.Text = ModVariavelGlobal.pesquisaCodigo
        TxbNomCidade.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub DtpDtaNasc_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaNasc.ValueChanged
        TxbDtaNasc.Text = DtpDtaNasc.Value.ToShortDateString.ToString
    End Sub

    Private Sub BtnFuncaoFuncionario_Click(sender As Object, e As EventArgs) Handles BtnCadFuncaoFuncionario.Click
        FrmFuncaoFuncionario.Show()
    End Sub

    Private Sub DtpAdmissaoFunc_ValueChanged(sender As Object, e As EventArgs) Handles DtpAdmissaoFunc.ValueChanged
        TxbDtaAdmissaoFunc.Text = DtpAdmissaoFunc.Value.ToShortDateString.ToString
    End Sub

    Private Sub DtpDtaDemissaoFunc_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaDemissaoFunc.ValueChanged
        TxbDtaDemissaoFunc.Text = DtpDtaDemissaoFunc.Value.ToShortDateString.ToString
    End Sub

    Private Sub DtpDtaReajusteFunc_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaReajusteFunc.ValueChanged
        TxbDtaReajusteFunc.Text = DtpDtaReajusteFunc.Value.ToShortDateString.ToString
    End Sub

    Private Sub DtpDtaNascDept_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaNascDept.ValueChanged
        TxbDtaNascDept.Text = DtpDtaNascDept.Value.ToShortDateString.ToString
    End Sub

    Private Sub CbPrecoVenda_LostFocus(sender As Object, e As EventArgs) Handles CbPrecoVenda.LostFocus
        If CbPrecoVenda.Text = "" Then
            CbPrecoVenda.Text = "A"
        End If
    End Sub

    Private Sub BtnCadCidade_Click(sender As Object, e As EventArgs) Handles BtnCadCidade.Click
        'Permissao acesso cidade
        FrmCidade.Show()
    End Sub

    Private Sub DtpDtaReajusteFunc_TextChanged(sender As Object, e As EventArgs) Handles DtpDtaReajusteFunc.TextChanged
        TxbDtaReajusteFunc.Text = DtpDtaReajusteFunc.Value.ToShortDateString
    End Sub

    Private Sub BtnBuscaFuncaoFunc_Click(sender As Object, e As EventArgs) Handles BtnBuscaFuncaoFunc.Click
        FrmPesquisa.tabela = "tab_funcao_funcionario"
        FrmPesquisa.ShowDialog()
        TxbCodFuncaoFunc.Text = ModVariavelGlobal.pesquisaCodigo
        txbDesFuncaoFunc.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click


        If TxbCodPessoa.Text = "" Then
            cod_pessoa_old = 0
        Else
            cod_pessoa_old = TxbCodPessoa.Text
        End If

        carregaPessoaOLd()
        atualizaDados()
        carregaFormulario()


    End Sub
    Public Sub atualizaDados()
        Try
            Dim tabela As DataTable
            If cod_pessoa_old = "" Then
                cod_pessoa_old = "0"
            End If
            ds = pessoa.ConsultarPessoaBusca(cod_pessoa_old, nom_pessoa_old, nom_fantasia_old, TxbDtaNasc.Text, num_cnpj_cpf_old, num_ie_rg_old,
                                             des_logradouro_old, cod_cidade_old, nom_bairro_old, num_cep_old, num_telefone_1_old,
                                             num_telefone_2_old, num_telefone_3_old, des_observacao_old, ind_cliente_old,
                                            ind_fornecedor_old, ind_funcionario_old, ind_ativo_old, des_email_old, ind_pe_old, cod_funcao_funcionario_old)
            tabela = ds.Tables(0)

            If tabela.Rows.Count > 0 Then
                DgvPessoa.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub atualizaDadosDependente()
        Try
            Dim tabela As DataTable
            dsDependente = dependente.ConsultarDependente(cod_pessoa_old)
            tabela = dsDependente.Tables(0)

            If tabela.Rows.Count > 0 Then
                DgvDependente.DataSource = Nothing
                DgvDependente.DataSource = dsDependente.Tables(0)
                formatarGridDependente()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnCsv_Click(sender As Object, e As EventArgs) Handles BtnCsv.Click
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



        nomArquivo = "Pessoa_" & dataAtual & "_" & horaMin

        Dim CSV As System.IO.StreamWriter = New System.IO.StreamWriter(nomPasta & "\Pessoa_" & nomArquivo & ".csv"
                                                                           )
        Dim i As Integer, x As Integer

        Dim QtdColunas As Integer = DgvPessoa.ColumnCount - 1

        For i = 0 To QtdColunas
            If DgvPessoa.Columns(i).HeaderText.Substring(0, 6) <> "Column" Then
                CSV.Write(DgvPessoa.Columns(i).HeaderText)

                If (i < QtdColunas) Then

                    CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                End If

            End If
        Next i

        ' CSV.Write(CSV.NewLine)

        Dim QtdRows As Integer = DgvPessoa.Rows.Count - 1

        For i = 0 To QtdRows

            For x = 0 To QtdColunas

                If (Not DgvPessoa.Rows(i).Cells(x).Value Is Nothing) Then
                    CSV.Write(DgvPessoa.Rows(i).Cells(x).Value.ToString())

                End If

                If (x < QtdColunas) Then
                    CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                End If

            Next x
            CSV.Write(CSV.NewLine)
        Next i
        MsgBox("Arquivo criado com sucesso em   " & nomPasta & "\" & nomArquivo)

        CSV.Close()
    End Sub
    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaRegistro()
    End Sub
    Public Sub salvaRegistro()
        Try

            If TxbNomPessoa.Text = "" Then
                MsgBox("INFORME NOME")
                TxbNomPessoa.Select()
                Exit Sub
            End If

            pessoa.nom_pessoa = TxbNomPessoa.Text
            pessoa.nom_fantasia = TxbNomFantasia.Text
            pessoa.num_cnpj_cpf = TxbCnpjCpf.Text
            pessoa.num_ie_rg = TxbIeRg.Text
            pessoa.dta_nascimento = TxbDtaNasc.Text
            pessoa.des_logradouro = TxbRua.Text
            pessoa.des_complemento = TxbComplemento.Text
            If TxbCodCidade.Text = "" Then
                pessoa.cod_cidade = 5002
            Else
                pessoa.cod_cidade = TxbCodCidade.Text
            End If

            pessoa.nom_bairro = TxbBairro.Text
            pessoa.num_cep = TxbCep.Text
            pessoa.num_fone_1 = TxbFone1.Text
            pessoa.num_fone_2 = TxbFone2.Text
            pessoa.num_fone_3 = TxbFone3.Text
            pessoa.des_observacao = TxbObservacao.Text
            pessoa.dta_cadastro = Now

            nom_pessoa_old = TxbNomPessoa.Text

            If CkbCliente.Checked = True Then
                pessoa.ind_cliente = "S"
            Else
                pessoa.ind_cliente = "N"
            End If

            If CkbFornecedor.Checked = True Then
                pessoa.ind_fornecedor = "S"
            Else
                pessoa.ind_fornecedor = "N"
            End If

            If CkbFuncionario.Checked = True Then
                pessoa.ind_funcionario = "S"
            Else
                pessoa.ind_funcionario = "N"
            End If

            If CkbAtivo.Checked = True Or atualizar = 1 Then
                pessoa.ind_ativo = "S"
            Else
                pessoa.ind_ativo = "N"
            End If
            pessoa.des_email = TxbEmail.Text
            pessoa.ind_preco_venda = CbPrecoVenda.Text
            ind_pe_old = "N"
            If atualizar = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                ultimo = pessoa2.UltimaPessoaCadastrado
                Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                pessoa.cod_pessoa = Convert.ToInt16(ult) + 1

                pessoa.CadastrarPessoa()
                TxbCodPessoa.Text = pessoa.cod_pessoa
                'SALVAR FUNCIONARIO
                If CkbFuncionario.Checked = True Then
                    salvaFuncionario(Convert.ToInt16(ult) + 1)
                    atualizarFunc = 1
                End If
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox("Cadastrado com Sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
                carregaFormulario()
            Else
                pessoa.cod_pessoa = TxbCodPessoa.Text
                pessoa.AtualizarPessoa()
                'ATUALIZAR FUNCIONARIO
                salvaFuncionario(TxbCodPessoa.Text)
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox("Alterado com Sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
                carregaFormulario()
            End If
            i = 0
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Public Sub salvaFuncionario(cod_pessoa As Integer)

        If CkbFuncionario.Checked = False Then
            Exit Sub
        End If

        funcionario.cod_pessoa = cod_pessoa
        If TxbCodFuncaoFunc.Text = "" Then
            funcionario.cod_funcao_funcionario = 0
        Else
            funcionario.cod_funcao_funcionario = TxbCodFuncaoFunc.Text
        End If
        If TxbSalarioFunc.Text = "" Then
            funcionario.val_salario = "0"
        Else
            funcionario.val_salario = TxbSalarioFunc.Text
        End If
        If TxbCustoHrFunc.Text = "" Then
            funcionario.Val_custo_hora = "0"
        Else
            funcionario.Val_custo_hora = TxbCustoHrFunc.Text
        End If


        If RbHoraFunc.Checked = True Then
            funcionario.ind_tipo_salario = "H"
        ElseIf RbDiaFunc.Checked = True Then
            funcionario.ind_tipo_salario = "D"
        ElseIf RbSemanaFunc.Checked = True Then
            funcionario.ind_tipo_salario = "S"
        ElseIf RbQuinzenaFunc.Checked = True Then
            funcionario.ind_tipo_salario = "Q"
        ElseIf RbMesFunc.Checked = True Then
            funcionario.ind_tipo_salario = "M"
        End If
        funcionario.dta_admissao = TxbDtaAdmissaoFunc.Text
        funcionario.dta_demissao = TxbDtaDemissaoFunc.Text
        funcionario.dta_ultimo_reajuste = TxbDtaReajusteFunc.Text

        funcionario.des_observacao = TxbObsFunc.Text
        If CkbAgendaServico.Checked = True Then
            funcionario.ind_agenda_servico = "S"
        Else
            funcionario.ind_agenda_servico = "N"
        End If
        If CkbOperadorCaixa.Checked = True Then
            funcionario.ind_operador_caixa = "S"
        Else
            funcionario.ind_operador_caixa = "N"
        End If
        Try
            Dim clGeral As New ClGeral
            If IsNumeric(clGeral.sqlBuscaDescricao("cod_pessoa", "tab_pessoa_funcionario", "cod_pessoa", pessoa.cod_pessoa)) = False Then
                funcionario.CadastrarFuncionario()
            Else
                funcionario.AtualizarFuncionario()
            End If
        Catch ex As Exception
            funcionario.CadastrarFuncionario()
        End Try



    End Sub
    Private Sub FrmPessoa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim count As Integer
        For count = 1 To 100
            Beep()
        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbCodPessoa.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir:  " & vbCrLf & TxbNomPessoa.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                pessoa.cod_pessoa = TxbCodPessoa.Text
                pessoa.ExcluirPessoa()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox("Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()
                limpar()
            Catch ex As Exception
                MsgBox("Erro ao tentar excluir Pessoa , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        verificarAuteracaoPessoa()
        limpar()
        DgvPessoa.DataSource = Nothing
        TxbCodPessoa.Enabled = True
        TabControl1.SelectedIndex = 0
        BtnDependente.Visible = False

    End Sub

    Private Sub BtnLimpaDept_Click(sender As Object, e As EventArgs) Handles BtnLimpaDept.Click
        verificarAuteracaoDependente()
        limparDependente()
    End Sub

    Private Sub DgvDependente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDependente.CellClick
        carregaFormularioDepte()
    End Sub
    Public Sub carregaFormularioDepte()
        Try
            limparDependente()
            atualizarDependente = 2
            txbCodDepte.Text = DgvDependente.CurrentRow.Cells(0).Value
            txbNomDepte.Text = DgvDependente.CurrentRow.Cells(1).Value
            txbApelidoDepte.Text = DgvDependente.CurrentRow.Cells(3).Value
            txbFoneDepte.Text = DgvDependente.CurrentRow.Cells(4).Value
            DtpDtaNascDept.Value = DgvDependente.CurrentRow.Cells(5).Value
            txbObsDepte.Text = DgvDependente.CurrentRow.Cells(6).Value

            cod_dependente_old = txbCodDepte.Text
            nom_dependente_old = txbNomDepte.Text
            nom_apelido_old = txbApelidoDepte.Text
            num_fone_depte_old = txbFoneDepte.Text
            dta_nascimento_depte_old = DgvDependente.CurrentRow.Cells(5).Value
            des_observacao_depte_old = txbObsDepte.Text

            txbCodDepte.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Public Sub limparDependente()
        txbCodDepte.Text = ""
        txbNomDepte.Text = ""
        txbApelidoDepte.Text = ""
        txbFoneDepte.Text = ""
        txbObsDepte.Text = ""

        cod_dependente_old = ""
        nom_dependente_old = ""
        nom_apelido_old = ""
        num_fone_depte_old = ""
        dta_nascimento_depte_old = ""
        des_observacao_depte_old = ""

        txbCodDepte.Enabled = True
        atualizarDependente = 1
    End Sub
    Private Sub BtnExcluiDept_Click(sender As Object, e As EventArgs) Handles BtnExcluiDept.Click
        If txbCodDepte.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir o Dependente :" & vbCrLf & txbNomDepte.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                dependente.cod_dependente = txbCodDepte.Text
                dependente.ExcluirDependente()
                MsgBox("Dependente excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()

            Catch ex As Exception
                MsgBox("Erro ao excluir Dependente, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub CkbFuncionario_CheckedChanged(sender As Object, e As EventArgs) Handles CkbFuncionario.CheckedChanged
        If CkbFuncionario.Checked = True Then
            BtnFuncionario.Enabled = True
        Else
            BtnFuncionario.Enabled = False
        End If
    End Sub

    Private Sub BtnSalvaDepte_Click(sender As Object, e As EventArgs) Handles BtnSalvaDepte.Click
        salvarDependente()
    End Sub
    Public Sub salvarDependente()
        Try
            If txbNomDepte.Text = "" Then
                MsgBox("INFORME NOME DO ITEM")
                txbNomDepte.Select()
                Exit Sub
            End If

            dependente.nom_dependente = txbNomDepte.Text
            dependente.cod_pessoa = TxbCodPessoa.Text
            dependente.nom_apelido = txbApelidoDepte.Text
            dependente.dta_nascimento = DtpDtaNascDept.Value.ToShortDateString
            dependente.des_observacao = txbObsDepte.Text
            dependente.num_telefone = txbFoneDepte.Text

            If atualizarDependente = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                ultimo = dependente.UltimoDependenteCadastrado
                Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                dependente.cod_dependente = Convert.ToInt16(ult) + 1

                dependente.CadastrarDependente()
                ultimo.Clear()
                MsgBox("Dependente cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDadosDependente()
            Else
                dependente.cod_dependente = txbCodDepte.Text
                dependente.AtualizarDependente()
                MsgBox("Pelagem Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDadosDependente()
            End If

            limparDependente()
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Public Sub limpar()
        TxbCodPessoa.Text = ""
        TxbNomPessoa.Text = ""
        TxbNomFantasia.Text = ""
        TxbCnpjCpf.Text = ""
        TxbIeRg.Text = ""
        TxbDtaNasc.Text = ""
        TxbRua.Text = ""
        TxbComplemento.Text = ""
        TxbCodCidade.Text = ""
        TxbNomCidade.Text = ""
        TxbBairro.Text = ""
        TxbCep.Text = ""
        TxbFone1.Text = ""
        TxbFone2.Text = ""
        TxbFone3.Text = ""
        TxbObservacao.Text = ""
        CkbCliente.Checked = False
        CkbFornecedor.Checked = False
        CkbFuncionario.Checked = False
        CkbAtivo.Checked = True
        TxbEmail.Text = ""
        CbPrecoVenda.Text = "A"
        '       DgvPessoa.Rows.Clear()

        cod_pessoa_old = ""
        nom_pessoa_old = ""
        nom_fantasia_old = ""
        num_cnpj_cpf_old = ""
        num_ie_rg_old = ""
        des_complemento_old = ""
        dta_nascimento_old = ""
        des_logradouro_old = ""
        des_complemento_old = ""
        cod_cidade_old = ""
        nom_bairro_old = ""
        num_cep_old = ""
        num_telefone_1_old = ""
        num_telefone_2_old = ""
        num_telefone_3_old = ""
        des_observacao_old = ""
        ind_cliente_old = ""
        ind_fornecedor_old = ""
        ind_funcionario_old = ""
        ind_ativo_old = ""
        des_email_old = ""

        'limpar funcionario
        TxbCodFuncaoFunc.Text = ""
        txbDesFuncaoFunc.Text = ""
        TxbSalarioFunc.Text = ""
        TxbCustoHrFunc.Text = ""
        TxbDtaAdmissaoFunc.Text = ""
        TxbDtaDemissaoFunc.Text = ""
        TxbDtaReajusteFunc.Text = ""
        TxbObsFunc.Text = ""
        CkbAgendaServico.Checked = False
        CkbOperadorCaixa.Checked = False

        cod_funcao_old = ""
        val_salario_old = ""
        val_custo_hora_old = ""
        ind_tipo_salario_old = "M"
        RbMesFunc.Checked = True
        dta_admissao_old = ""
        dta_demissao_old = ""
        dta_ultimo_reajuste_old = ""
        des_observacao_func_old = ""


        'DgvPessoa.DataSource = Nothing
        'DgvDependente.DataSource = Nothing

        atualizar = 1

    End Sub
    Public Sub formatarGrid()
        With DgvPessoa
            .Columns(0).HeaderText = "COD"
            .Columns(1).HeaderText = "NOME"
            .Columns(2).HeaderText = "NOME.FANTASIA"
            .Columns(3).HeaderText = "CNPJ/CPF"
            .Columns(4).HeaderText = "IE/RG"
            .Columns(5).HeaderText = "NASCIMENTO"
            .Columns(6).HeaderText = "LOGRADOURO"
            .Columns(7).HeaderText = "COMPLEMENTO"
            .Columns(8).HeaderText = "COD.CIDADE"
            .Columns(9).HeaderText = "NOM.CIDADE"
            .Columns(10).HeaderText = "BAIRRO"
            .Columns(11).HeaderText = "CEP"
            .Columns(12).HeaderText = "TELEFONE_1"
            .Columns(13).HeaderText = "TELEFONE_2"
            .Columns(14).HeaderText = "TELEFONE_3"
            .Columns(15).HeaderText = "CONTATO"
            .Columns(16).HeaderText = "OBSERVACAO"
            .Columns(17).HeaderText = "DTA.CADASTRO"
            .Columns(18).HeaderText = "CLIENTE"
            .Columns(19).HeaderText = "FORNECEDOR"
            .Columns(20).HeaderText = "FUNCIONARIO"
            .Columns(21).HeaderText = "ATIVO"
            .Columns(22).HeaderText = "EMAIL"
            .Columns(0).Width = 40
            .Columns(1).Width = 200
            .Columns(2).Width = 60
            .Columns(3).Width = 60
            .Columns(4).Width = 60
            .Columns(5).Width = 60
            .Columns(6).Width = 60
            .Columns(7).Width = 60
            .Columns(8).Width = 60
            .Columns(9).Width = 60
            .Columns(10).Width = 60
            .Columns(11).Width = 60
            .Columns(12).Width = 60
            .Columns(13).Width = 60
            .Columns(14).Width = 60
            .Columns(15).Width = 60
            .Columns(16).Width = 60
            .Columns(17).Width = 60
            .Columns(18).Width = 60
            .Columns(19).Width = 60
            .Columns(20).Width = 60
            .Columns(21).Width = 60
            .Columns(22).Width = 60
        End With
    End Sub

    Public Sub formatarGridDependente()
        With DgvDependente
            .Columns(0).HeaderText = "COD"
            .Columns(1).HeaderText = "DEPENDENTE"
            .Columns(2).HeaderText = "COD.CLIENTE"
            .Columns(3).HeaderText = "APELIDO"
            .Columns(4).HeaderText = "FONE"
            .Columns(5).HeaderText = "NASCIMENTO"
            .Columns(6).HeaderText = "OBSERVAÇÃO"
            .Columns(0).Width = 40
            .Columns(1).Width = 200
            .Columns(2).Width = 0
            .Columns(3).Width = 100
            .Columns(4).Width = 60
            .Columns(5).Width = 60
            .Columns(6).Width = 200
        End With
    End Sub
    Public Sub carregaFormulario()
        Try
            limpar()
            atualizar = 2
            BtnDependente.Visible = True
            If ds.Tables(0).Rows.Count - 1 < i Then
                i = 0
            End If
            TxbCodPessoa.Text = ds.Tables(0).Rows(i)("cod_pessoa").ToString
            TxbNomPessoa.Text = ds.Tables(0).Rows(i)("nom_pessoa").ToString
            TxbNomFantasia.Text = ds.Tables(0).Rows(i)("nom_fantasia").ToString
            TxbCnpjCpf.Text = ds.Tables(0).Rows(i)("num_cnpj_cpf").ToString
            TxbIeRg.Text = ds.Tables(0).Rows(i)("num_ie_rg").ToString

            Try
                TxbDtaNasc.Text = ds.Tables(0).Rows(i)("dta_nascimento").ToString
                TxbDtaNasc.Text = TxbDtaNasc.Text.Substring(0, 10)
                If TxbDtaNasc.Text = "01/01/1900" Then
                    TxbDtaNasc.Text = ""
                    dta_nascimento_old = ""
                Else
                    dta_nascimento_old = TxbDtaNasc.Text
                End If
            Catch ex As Exception
                TxbDtaDemissaoFunc.Text = ""
                dta_nascimento_old = ""
            End Try


            TxbRua.Text = ds.Tables(0).Rows(i)("des_logradouro").ToString
            TxbComplemento.Text = ds.Tables(0).Rows(i)("des_complemento").ToString
            TxbCodCidade.Text = ds.Tables(0).Rows(i)("cod_cidade").ToString
            TxbNomCidade.Text = ds.Tables(0).Rows(i)("nom_cidade").ToString
            TxbBairro.Text = ds.Tables(0).Rows(i)("nom_bairro").ToString
            TxbCep.Text = ds.Tables(0).Rows(i)("num_cep").ToString
            TxbFone1.Text = ds.Tables(0).Rows(i)("num_telefone_1").ToString
            TxbFone2.Text = ds.Tables(0).Rows(i)("num_telefone_2").ToString
            TxbFone3.Text = ds.Tables(0).Rows(i)("num_telefone_3").ToString

            TxbObservacao.Text = ds.Tables(0).Rows(i)("des_observacao").ToString
            If ds.Tables(0).Rows(i)("ind_cliente").ToString = "S" Then
                CkbCliente.Checked = True
            Else
                CkbCliente.Checked = False
            End If
            If ds.Tables(0).Rows(i)("ind_fornecedor").ToString = "S" Then
                CkbFornecedor.Checked = True
                'btnFornecedor.enable = true
            Else
                CkbFornecedor.Checked = False
                'btnFornecedor.enable = False
            End If
            If ds.Tables(0).Rows(i)("ind_funcionario").ToString = "S" Then
                CkbFuncionario.Checked = True
                BtnFuncionario.Enabled = True
            Else
                CkbFuncionario.Checked = False
                BtnFuncionario.Enabled = False
            End If
            If ds.Tables(0).Rows(i)("ind_ativo").ToString = "S" Then
                CkbAtivo.Checked = True
            Else
                CkbAtivo.Checked = False
            End If
            TxbEmail.Text = ds.Tables(0).Rows(i)("des_email").ToString
            CbPrecoVenda.Text = ds.Tables(0).Rows(i)("ind_preco_venda").ToString

            carregaPessoaOLd()

            '**************************************
            'FUNCIONARIO
            '***************************************
            If CkbFuncionario.Checked = True Then

                TxbCodFuncaoFunc.Text = ds.Tables(0).Rows(i)("cod_funcao_funcionario").ToString
                txbDesFuncaoFunc.Text = ds.Tables(0).Rows(i)("des_funcao_funcionario").ToString
                TxbSalarioFunc.Text = ds.Tables(0).Rows(i)("val_salario").ToString
                TxbCustoHrFunc.Text = ds.Tables(0).Rows(i)("val_custo_hora").ToString
                TxbDtaAdmissaoFunc.Text = ds.Tables(0).Rows(i)("dta_admissao").ToString
                If TxbDtaAdmissaoFunc.Text <> "" Then
                    TxbDtaAdmissaoFunc.Text = TxbDtaAdmissaoFunc.Text.Substring(0, 10)
                    If TxbDtaAdmissaoFunc.Text = "01/01/1900" Then
                        TxbDtaAdmissaoFunc.Text = ""
                        dta_admissao_old = ""
                    Else
                        dta_admissao_old = TxbDtaAdmissaoFunc.Text
                    End If
                End If
                Try
                    TxbDtaDemissaoFunc.Text = ds.Tables(0).Rows(i)("dta_demissao").ToString
                    If TxbDtaDemissaoFunc.Text <> "" Then
                        TxbDtaDemissaoFunc.Text = TxbDtaDemissaoFunc.Text.Substring(0, 10)
                        If TxbDtaDemissaoFunc.Text = "01/01/1900" Then
                            TxbDtaDemissaoFunc.Text = ""
                            dta_demissao_old = ""
                        Else
                            dta_demissao_old = TxbDtaDemissaoFunc.Text
                        End If
                    End If
                Catch ex As Exception
                    TxbDtaDemissaoFunc.Text = ""
                    dta_demissao_old = ""
                End Try

                Try
                    TxbDtaReajusteFunc.Text = ds.Tables(0).Rows(i)("dta_ultimo_reajuste").ToString
                    If TxbDtaReajusteFunc.Text <> "" Then
                        TxbDtaReajusteFunc.Text = TxbDtaReajusteFunc.Text.Substring(0, 10)
                        If TxbDtaReajusteFunc.Text = "01/01/1900" Then
                            TxbDtaReajusteFunc.Text = ""
                            dta_ultimo_reajuste_old = ""
                        Else
                            dta_ultimo_reajuste_old = TxbDtaReajusteFunc.Text
                        End If
                    End If
                Catch ex As Exception
                    TxbDtaReajusteFunc.Text = ""
                    dta_ultimo_reajuste_old = ""
                End Try


                TxbObsFunc.Text = ds.Tables(0).Rows(i)("des_observacao_func").ToString

                If ds.Tables(0).Rows(i)("ind_agenda_servico").ToString = "S" Then
                    CkbAgendaServico.Checked = True
                Else
                    CkbAgendaServico.Checked = False
                End If

                If ds.Tables(0).Rows(i)("ind_operador_caixa").ToString = "S" Then
                    CkbOperadorCaixa.Checked = True
                Else
                    CkbOperadorCaixa.Checked = False
                End If

                If ds.Tables(0).Rows(i)("ind_tipo_salario").ToString = "H" Then
                    RbHoraFunc.Checked = True
                ElseIf ds.Tables(0).Rows(i)("ind_tipo_salario").ToString = "D" Then
                    RbDiaFunc.Checked = True
                ElseIf ds.Tables(0).Rows(i)("ind_tipo_salario").ToString = "S" Then
                    RbSemanaFunc.Checked = True
                ElseIf ds.Tables(0).Rows(i)("ind_tipo_salario").ToString = "Q" Then
                    RbQuinzenaFunc.Checked = True
                ElseIf ds.Tables(0).Rows(i)("ind_tipo_salario").ToString = "M" Then
                    RbMesFunc.Checked = True
                End If

                cod_funcao_old = TxbCodFuncaoFunc.Text
                des_funcao_old = txbDesFuncaoFunc.Text
                val_salario_old = TxbSalarioFunc.Text
                val_custo_hora_old = TxbCustoHrFunc.Text
                ind_tipo_salario_old = ds.Tables(0).Rows(i)("ind_tipo_salario").ToString
                des_observacao_func_old = TxbObsFunc.Text
                If ds.Tables(0).Rows(i)("ind_agenda_servico").ToString.Trim = "S" Then
                    CkbAgendaServico.Checked = True
                Else
                    CkbAgendaServico.Checked = False
                End If
                If ds.Tables(0).Rows(i)("ind_operador_caixa").ToString.Trim = "S" Then
                    CkbOperadorCaixa.Checked = True
                Else
                    CkbOperadorCaixa.Checked = False
                End If
            End If
            If TxbCodPessoa.Text <> "" Then
                BtnDependente.Enabled = True
            End If
            Ckb_pe.Checked = False
            TxbCodPessoa.Enabled = False

            TabControl1.SelectedIndex = 0
        Catch ex As Exception
            '     MessageBox("Erro carregar campos " & ex,)
        End Try
    End Sub

    Private Sub carregaPessoaOLd()
        cod_pessoa_old = TxbCodPessoa.Text
        nom_pessoa_old = TxbNomPessoa.Text
        nom_fantasia_old = TxbNomFantasia.Text
        num_cnpj_cpf_old = TxbCnpjCpf.Text
        num_ie_rg_old = TxbIeRg.Text
        des_logradouro_old = TxbRua.Text
        des_complemento_old = TxbComplemento.Text
        cod_cidade_old = TxbCodCidade.Text
        nom_cidade_old = TxbNomCidade.Text
        nom_bairro_old = TxbBairro.Text
        num_cep_old = TxbCep.Text
        num_telefone_1_old = TxbFone1.Text
        num_telefone_2_old = TxbFone2.Text
        num_telefone_3_old = TxbFone3.Text
        des_observacao_old = TxbObservacao.Text
        If CkbFornecedor.Checked = True Then
            ind_fornecedor_old = True
        Else
            ind_fornecedor_old = False
        End If
        If CkbFuncionario.Checked = True Then
            ind_funcionario_old = True
        Else
            ind_funcionario_old = False
        End If
        If CkbAtivo.Checked = True Then
            ind_ativo_old = True
        Else
            ind_ativo_old = False
        End If
        des_email_old = TxbEmail.Text
        ind_preco_venda_old = CbPrecoVenda.Text
    End Sub

    Private Sub FrmItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t110101 = False Then
                MsgBox("Usuário sem permissão para acessar Pessoa!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
            BtnSalvar.Enabled = ModPermissaoUsuario.t1101011
            BtnExcluir.Enabled = ModPermissaoUsuario.t1101012
        End If
        limpar()
        BtnPrincipal.Enabled = False
        BtnDependente.Enabled = False
        BtnFuncionario.Enabled = False
        TabControl1.SelectedIndex = 0
        TxbCodPessoa.Select()
    End Sub

    Private Sub DgvPessoa_DoubleClick(sender As Object, e As EventArgs) Handles DgvPessoa.DoubleClick
        Try
            TxbCodPessoa.Text = DgvPessoa.CurrentRow.Cells(0).Value
            TxbNomPessoa.Text = DgvPessoa.CurrentRow.Cells(1).Value
            TxbNomFantasia.Text = DgvPessoa.CurrentRow.Cells(2).Value
            TxbCnpjCpf.Text = DgvPessoa.CurrentRow.Cells(3).Value
            TxbIeRg.Text = DgvPessoa.CurrentRow.Cells(4).Value

            Try
                TxbDtaNasc.Text = DgvPessoa.CurrentRow.Cells(5).Value
                TxbDtaNasc.Text = TxbDtaNasc.Text.Substring(0, 10)
                If TxbDtaNasc.Text = "01/01/1900" Then
                    TxbDtaNasc.Text = ""
                    dta_nascimento_old = ""
                Else
                    dta_nascimento_old = TxbDtaNasc.Text
                End If
            Catch ex As Exception
                TxbDtaDemissaoFunc.Text = ""
                dta_nascimento_old = ""
            End Try


            TxbRua.Text = DgvPessoa.CurrentRow.Cells(6).Value
            TxbComplemento.Text = DgvPessoa.CurrentRow.Cells(7).Value
            TxbCodCidade.Text = DgvPessoa.CurrentRow.Cells(8).Value
            TxbNomCidade.Text = DgvPessoa.CurrentRow.Cells(9).Value
            TxbBairro.Text = DgvPessoa.CurrentRow.Cells(10).Value
            TxbCep.Text = DgvPessoa.CurrentRow.Cells(11).Value
            TxbFone1.Text = DgvPessoa.CurrentRow.Cells(12).Value
            TxbFone2.Text = DgvPessoa.CurrentRow.Cells(13).Value
            TxbFone3.Text = DgvPessoa.CurrentRow.Cells(14).Value
            TxbObservacao.Text = DgvPessoa.CurrentRow.Cells(15).Value
            If DgvPessoa.CurrentRow.Cells(0).Value = "S" Then
                CkbCliente.Checked = True
            Else
                CkbCliente.Checked = False
            End If
            If DgvPessoa.CurrentRow.Cells(0).Value = "S" Then
                CkbFornecedor.Checked = True
                'btnFornecedor.enable = true
            Else
                CkbFornecedor.Checked = False
                'btnFornecedor.enable = False
            End If
            If DgvPessoa.CurrentRow.Cells(16).Value = "S" Then
                CkbFuncionario.Checked = True
                BtnFuncionario.Enabled = True
            Else
                CkbFuncionario.Checked = False
                BtnFuncionario.Enabled = False
            End If
            If DgvPessoa.CurrentRow.Cells(17).Value = "S" Then
                CkbAtivo.Checked = True
            Else
                CkbAtivo.Checked = False
            End If
            TxbEmail.Text = DgvPessoa.CurrentRow.Cells(18).Value
            CbPrecoVenda.Text = DgvPessoa.CurrentRow.Cells(19).Value

        Catch ex As Exception
        End Try
        TxbNomPessoa.Select()
        TabControl1.SelectedIndex = 0
        carregaPessoaOLd()

    End Sub
    Private Sub TxbCodCidade_LostFocus(sender As Object, e As EventArgs) Handles TxbCodCidade.LostFocus
        If TxbCodCidade.Text <> "" And IsNumeric(TxbCodCidade.Text) Then
            TxbNomCidade.Text = geral.sqlBuscaDescricao("nom_cidade", "tab_cidade", "cod_cidade", TxbCodCidade.Text)
        End If
    End Sub
    Private Sub TxbCodPessoa_LostFocus(sender As Object, e As EventArgs) Handles TxbCodPessoa.LostFocus
        If TxbCodPessoa.Text <> "" And IsNumeric(TxbCodPessoa.Text) Then
            TxbNomPessoa.Text = geral.sqlBuscaDescricao("nom_pessoa", "tab_pessoa", "cod_pessoa", TxbCodPessoa.Text)
        End If
    End Sub

    Private Sub TxbCodPessoa_TextChanged(sender As Object, e As EventArgs) Handles TxbCodPessoa.TextChanged
        If Not IsNumeric(TxbCodPessoa.Text) Then
            TxbCodPessoa.Text = ""
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnGrid.Click
        If TabControl1.SelectedIndex = 1 Then
            TabControl1.SelectedIndex = 0
        Else
            TabControl1.SelectedIndex = 1
        End If

    End Sub

    Private Sub BtnDependente_Click_2(sender As Object, e As EventArgs) Handles BtnDependente.Click
        TabControl1.SelectedIndex = 2
        GbNavegador.Enabled = False
        BtnDependente.Enabled = False
        BtnPrincipal.Enabled = True
        cod_pessoa_old = TxbCodPessoa.Text
        If CkbFuncionario.Checked = True Then
            BtnFuncionario.Enabled = True
        Else
            BtnFuncionario.Enabled = False
        End If
        atualizarDependente = 1
        limparDependente()
        atualizaDadosDependente()
        txbCodDepte.Select()
    End Sub

    Private Sub BtnFuncionario_Click(sender As Object, e As EventArgs) Handles BtnFuncionario.Click
        If TabControl1.SelectedIndex = 2 Then
            verificarAuteracaoDependente()
        End If
        TabControl1.SelectedIndex = 3
        GbNavegador.Enabled = True
        BtnFuncionario.Enabled = False
        BtnPrincipal.Enabled = True
        If TxbCodPessoa.Text <> "" Then
            BtnDependente.Enabled = True
        End If

        TxbCodFuncaoFunc.Select()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles BtnPrincipal.Click
        verificarAuteracaoDependente()
        TabControl1.SelectedIndex = 0
        GbNavegador.Enabled = True
        BtnPrincipal.Enabled = False
        If TxbCodPessoa.Text <> "" Then
            BtnDependente.Enabled = True
            If CkbFuncionario.Checked = True Then
                BtnFuncionario.Enabled = True
            End If
        End If
    End Sub

    Public Sub verificarAuteracaoPessoa()
        Dim msg As String = ""
        If TxbCodPessoa.Text = "" Or atualizar = 1 Then
            Exit Sub
        End If
        If nom_pessoa_old <> TxbNomPessoa.Text Then
            msg = "Nome" & vbCrLf & "Anterior: " & nom_pessoa_old & vbCrLf & " Nova : " & TxbNomPessoa.Text
        End If

        If nom_fantasia_old <> TxbNomFantasia.Text Then
            msg = msg & vbCrLf & "Nome Fantasia" & vbCrLf & "Anterior: " & nom_fantasia_old & vbCrLf & " Nova : " & TxbNomFantasia.Text
        End If
        If num_cnpj_cpf_old <> TxbCnpjCpf.Text Then
            msg = msg & vbCrLf & "CNPJ CPF" & vbCrLf & "Anterior: " & num_cnpj_cpf_old & vbCrLf & " Nova : " & TxbCnpjCpf.Text
        End If
        If num_ie_rg_old <> TxbIeRg.Text Then
            msg = msg & vbCrLf & "IE RG" & vbCrLf & "Anterior: " & num_ie_rg_old & vbCrLf & " Nova : " & TxbIeRg.Text
        End If
        If dta_nascimento_old <> TxbDtaNasc.Text Then
            msg = msg & vbCrLf & "Data Nascimento" & vbCrLf & "Anterior: " & dta_nascimento_old & vbCrLf & " Nova : " & TxbDtaNasc.Text
        End If


        If des_logradouro_old <> TxbRua.Text Then
            msg = msg & vbCrLf & "Rua" & vbCrLf & "Anterior: " & des_logradouro_old & vbCrLf & " Nova : " & TxbRua.Text
        End If
        If des_complemento_old <> TxbComplemento.Text Then
            msg = msg & vbCrLf & "Complemento" & vbCrLf & "Anterior: " & des_complemento_old & vbCrLf & " Nova : " & TxbComplemento.Text
        End If
        If cod_cidade_old <> TxbCodCidade.Text Then
            msg = msg & vbCrLf & "Cidade" & vbCrLf & "Anterior: " & cod_cidade_old & vbCrLf & " Nova : " & TxbCodCidade.Text
        End If
        If nom_bairro_old <> TxbBairro.Text Then
            msg = msg & vbCrLf & "Bairro" & vbCrLf & "Anterior: " & nom_bairro_old & vbCrLf & " Nova : " & TxbBairro.Text
        End If
        If num_cep_old <> TxbCep.Text Then
            msg = msg & vbCrLf & "Cep" & vbCrLf & "Anterior: " & num_cep_old & vbCrLf & " Nova : " & TxbCep.Text
        End If
        If num_telefone_1_old <> TxbFone1.Text Then
            msg = msg & vbCrLf & "Fone" & vbCrLf & "Anterior: " & num_telefone_1_old & vbCrLf & " Nova : " & TxbFone1.Text
        End If
        If num_telefone_2_old <> TxbFone2.Text Then
            msg = msg & vbCrLf & "Fone" & vbCrLf & "Anterior: " & num_telefone_2_old & vbCrLf & " Nova : " & TxbFone2.Text
        End If
        If num_telefone_3_old <> TxbFone3.Text Then
            msg = msg & vbCrLf & "Fone" & vbCrLf & "Anterior: " & num_telefone_3_old & vbCrLf & " Nova : " & TxbFone3.Text
        End If
        If des_observacao_old <> TxbObservacao.Text Then
            msg = msg & vbCrLf & "Observação" & vbCrLf & "Anterior: " & des_observacao_old & vbCrLf & " Nova : " & TxbObservacao.Text
        End If

        '*******************************************************
        'FUNCIONARIO
        '*******************************************************
        If cod_funcao_old <> TxbCodFuncaoFunc.Text Then
            msg = msg & vbCrLf & "Função Funcionario" & vbCrLf & "Anterior: " & des_funcao_old & vbCrLf & " Nova : " & txbDesFuncaoFunc.Text
        End If

        If val_salario_old <> TxbSalarioFunc.Text And CDbl(Replace(TxbSalarioFunc.Text, "", "0")) > 0 Then
            If IsNumeric(val_salario_old) And IsNumeric(TxbSalarioFunc.Text) Then
                If CDbl(val_salario_old) <> CDbl(TxbSalarioFunc.Text) Then
                    msg = msg & vbCrLf & "Salario Funcionario" & vbCrLf & "Anterior: " & val_salario_old & vbCrLf & " Nova : " & TxbSalarioFunc.Text
                End If
            End If
        End If
        If val_custo_hora_old <> TxbCustoHrFunc.Text And CDbl(Replace(TxbCustoHrFunc.Text, "", "0")) > 0 Then
            If IsNumeric(val_custo_hora_old) And IsNumeric(TxbCustoHrFunc.Text) Then
                If CDbl(val_custo_hora_old) <> CDbl(TxbCustoHrFunc.Text) Then
                    msg = msg & vbCrLf & "Custo Hora Funcionario" & vbCrLf & "Anterior: " & val_custo_hora_old & vbCrLf & " Nova : " & TxbCustoHrFunc.Text
                End If
            End If
        End If

        If dta_admissao_old <> TxbDtaAdmissaoFunc.Text Then
            msg = msg & vbCrLf & "Data Admissão Funcionario" & vbCrLf & "Anterior: " & dta_admissao_old & vbCrLf & " Nova : " & TxbDtaAdmissaoFunc.Text
        End If
        If dta_demissao_old <> TxbDtaDemissaoFunc.Text Then
            msg = msg & vbCrLf & "Data Demissão Funcionario" & vbCrLf & "Anterior: " & dta_nascimento_old & vbCrLf & " Nova : " & TxbDtaDemissaoFunc.Text
        End If
        If dta_ultimo_reajuste_old <> TxbDtaReajusteFunc.Text Then
            msg = msg & vbCrLf & "Data Ultimo Reajuste" & vbCrLf & "Anterior: " & dta_ultimo_reajuste_old & vbCrLf & " Nova : " & TxbDtaReajusteFunc.Text
        End If
        If des_observacao_func_old <> TxbObsFunc.Text Then
            msg = msg & vbCrLf & "Observação Funcionario" & vbCrLf & "Anterior: " & des_observacao_func_old & vbCrLf & " Nova : " & TxbObsFunc.Text
        End If


        If msg <> "" Then
            If MsgBox("Deseja salvar a alteraçã em:" & vbCrLf & msg & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                salvaRegistro()
            End If
        End If
    End Sub
    Public Sub verificarAuteracaoDependente()
        Dim msg As String = ""
        If txbCodDepte.Text = "" Then
            Exit Sub
        End If
        If nom_dependente_old <> txbNomDepte.Text Then
            msg = "Nome" & vbCrLf & "Anterior: " & nom_dependente_old & vbCrLf & " Nova : " & txbNomDepte.Text
        End If

        If nom_apelido_old <> txbApelidoDepte.Text Then
            msg = msg & vbCrLf & "Apelido" & vbCrLf & "Anterior: " & nom_apelido_old & vbCrLf & " Nova : " & txbApelidoDepte.Text
        End If
        If num_fone_depte_old <> txbFoneDepte.Text Then
            msg = msg & vbCrLf & "Fone" & vbCrLf & "Anterior: " & num_fone_depte_old & vbCrLf & " Nova : " & txbFoneDepte.Text
        End If
        If des_observacao_depte_old <> txbObsDepte.Text Then
            msg = msg & vbCrLf & "Observação" & vbCrLf & "Anterior: " & des_observacao_depte_old & vbCrLf & " Nova : " & txbObsDepte.Text
        End If
        If dta_nascimento_depte_old <> DtpDtaNascDept.Value.ToShortDateString Then
            msg = msg & vbCrLf & "Data Nascimento" & vbCrLf & "Anterior: " & dta_nascimento_depte_old & vbCrLf & " Nova : " & DtpDtaNascDept.Value.ToShortDateString
        End If

        If msg <> "" Then
            If MsgBox("Deseja salvar a alteraçã em:" & vbCrLf & msg & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                salvarDependente()
            End If
        End If
    End Sub

    Private Sub BtnPrimeiroReg_Click(sender As Object, e As EventArgs) Handles BtnPrimeiroReg.Click
        verificarAuteracaoPessoa()
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                i = 0
                carregaFormulario()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        verificarAuteracaoPessoa()
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                If i = 0 Then
                    i = ds.Tables(0).Rows.Count - 1
                Else
                    i = i - 1
                End If
            End If
        Catch ex As Exception
        End Try
        carregaFormulario()

    End Sub

    Private Sub BtnUltimoReg_Click(sender As Object, e As EventArgs) Handles BtnUltimoReg.Click
        verificarAuteracaoPessoa()
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                i = ds.Tables(0).Rows.Count - 1
            End If
        Catch ex As Exception
        End Try
        carregaFormulario()
    End Sub

    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        verificarAuteracaoPessoa()
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                If i < ds.Tables(0).Rows.Count - 1 Then
                    i = i + 1
                Else
                    i = 0
                End If
            End If
        Catch ex As Exception
        End Try
        carregaFormulario()
    End Sub


End Class