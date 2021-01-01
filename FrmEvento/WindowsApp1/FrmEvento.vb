Public Class FrmEvento
    Dim conectar As New ConexaoSQL
    Dim ds, ds1, ds2 As New DataSet
    Dim evento, evento2 As New ClEvento
    Dim ingresso, ingresso2 As New ClIngresso
    Dim ingressoPessoa, ingressoPessoa2 As New ClIngressoPessoa
    Dim item As New ClItem1
    Dim venda As New ClVenda
    Dim atualizar As Integer = 1
    Dim atualizarIngresso As Integer = 1
    Dim atualizarIngPessoa As Integer = 1
    Dim pesquisa As New FrmPesquisa
    Dim qtdEntrequeOld As Integer 

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtPresquisa.Click
        atualizarDados()
        atualizarDadosIngresso()
        atualizarIngressoPessoa()
        limpar()
        limparIngresso()

    End Sub
    Public Sub atualizarDados()
        '  conectar.Conectar()
        Dim tabela As DataTable
        ds = evento.ConsultarEvento()
        tabela = ds.Tables(0)

        If tabela.Rows.Count > 0 Then
            DgvEvento.DataSource = ds.Tables(0)
            formatarGrid()
            atualizarDadosIngresso()
        End If

    End Sub
    Public Sub atualizarDadosIngresso()
        '  conectar.Conectar()
        If TxtCodEvento.Text = "" Then
            Exit Sub
        End If
        ingresso.cod_evento = TxtCodEvento.Text
        Dim tabela As DataTable
        ds2 = ingresso.ConsultarIngresso()
        tabela = ds2.Tables(0)

        If tabela.Rows.Count > 0 Then
            DgvIngresso.DataSource = ds2.Tables(0)
            formatarGridIngresso()
        End If
        ' limparIngresso()
    End Sub

    Public Sub atualizarIngressoPessoa()
        '  conectar.Conectar()
        If TxtCodEvento.Text = "" Then
            Exit Sub
        End If
        ingressoPessoa.cod_evento = TxtCodEvento.Text
        Dim tabela As DataTable
        ds2 = ingressoPessoa.ConsultarIngressoPessoa()
        tabela = ds2.Tables(0)

        If tabela.Rows.Count > 0 Then
            DgvIngressoPessoa.DataSource = ds2.Tables(0)
            formatarGridIngressoPessoa()
        End If
        ' limparIngresso()
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaEvento()
    End Sub
    Private Sub salvaEvento()
        Try
            If TxtNome1.Text = "" Then
                MsgBox("Um nome para o evento deve ser informado", MsgBoxStyle.Information, "Informação")
                Exit Sub
            End If


            evento.nom_evento = TxtNome1.Text
            evento.dta_evento = DtpDtaEvento.Value.ToShortDateString
            'ds1 = evento.UltimoEventoCadastrado
            'Dim linha As DataRow
            'linha = ds1.Tables(0).Rows(0)

            If CbIndAberto.Text = "NAO" Then
                evento.ind_aberto = "N"
            Else
                evento.ind_aberto = "S"
            End If

            If atualizar = 1 Then
                Try
                    Dim ultimo As New DataSet
                    ultimo = evento2.UltimoEventoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    evento.cod_evento = Convert.ToInt16(ult)
                    TxtCodEvento.Text = evento.cod_evento
                    ultimo.Clear()
                Catch ex As Exception
                    evento.cod_evento = 1
                End Try
                evento.CadastrarEvento()
                ' item.CadastrarItem()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox("Evento cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizarDados()
            Else
                evento.cod_evento = TxtCodEvento.Text
                evento.AtualizarEvento()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox("Evento Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizarDados()
            End If


        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If MsgBox("Deseja excluir o evento" & TxtNome1.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                evento.cod_evento = TxtCodEvento.Text
                evento.ExcluirEvento()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox("Evento excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizarDados()
                limpar()
            Catch ex As Exception
                MsgBox("Erro ao excluir Evento, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtLimpar.Click
        limpar()
        limparIngresso()
        TabControl1.TabPages.Remove(TabPage2)
        TabControl1.TabPages.Remove(TabPage3)


    End Sub
    Public Sub limpar()
        TxtCodEvento.Text = ""
        TxtNome1.Text = ""
        CbIndAberto.Text = ""
        atualizar = 1

    End Sub
    Public Sub limparIngresso()
        TxtNome2.Text = ""
        TxtNome3.Text = ""
        TxtValEntrada.Text = ""
        TxtDesLote.Text = ""
        Txt_observacao1.Text = ""
        Txt_observacao2.Text = ""
        atualizarIngresso = 1
        LbSequenciaIngresso.Text = ""
        LbQtdDisponivel.Text = "0"
    End Sub
    Public Sub limparIngressoPessoa()
        TxbCodigoIP.Text = ""
        TxbCodImpressaoIP.Text = ""
        TxbDesImpressaoIP.Text = ""
        TxbCodPessoaIP.Text = ""
        TxbNomPessoaIP.Text = ""
        TxbObsIP.Text = ""
        TxbQtdDevolvIP.Text = ""
        TxbQtdEntregueIP.Text = ""
        atualizarIngPessoa = 1

    End Sub
    Public Sub formatarGrid()
        With DgvEvento
            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Nome"
            .Columns(2).HeaderText = "Data"
            .Columns(3).HeaderText = "Aberto"

            .Columns(0).Width = 60
            .Columns(1).Width = 180
            .Columns(2).Width = 60
            .Columns(3).Width = 60
        End With


    End Sub
    Public Sub formatarGridIngresso()
        With DgvIngresso
            .Columns(0).HeaderText = "Sequencia"
            .Columns(1).HeaderText = "Código"
            .Columns(2).HeaderText = "Descrição"
            .Columns(3).HeaderText = "Descrição1"
            .Columns(4).HeaderText = "Val.Entrada"
            .Columns(5).HeaderText = "Lote"
            .Columns(6).HeaderText = "Observação1"
            .Columns(7).HeaderText = "Observação2"

            .Columns(0).Width = 60
            .Columns(1).Width = 60
            .Columns(2).Width = 80
            .Columns(3).Width = 80
            .Columns(4).Width = 60
            .Columns(5).Width = 60
            .Columns(6).Width = 60
            .Columns(7).Width = 60

        End With
    End Sub
    Public Sub formatarGridIngressoPessoa()
        With DgvIngressoPessoa
            .Columns(0).HeaderText = "Lançamento"
            .Columns(1).HeaderText = "Cód.Impressão"
            .Columns(2).HeaderText = "Des.Impressão"
            .Columns(3).HeaderText = "Cód.Pessoa"
            .Columns(4).HeaderText = "Nom.Pessoa"
            .Columns(5).HeaderText = "Qtd.Entregue"
            .Columns(6).HeaderText = "Qtd.Devolvida"
            .Columns(7).HeaderText = "Observação"
            .Columns(8).HeaderText = "Dta.Entrega"

            .Columns(0).Width = 70
            .Columns(1).Width = 70
            .Columns(2).Width = 90
            .Columns(3).Width = 70
            .Columns(4).Width = 90
            .Columns(5).Width = 70
            .Columns(6).Width = 70
            .Columns(7).Width = 70
            .Columns(8).Width = 70

        End With
    End Sub


    Private Sub TxtNome2_TextChanged(sender As Object, e As EventArgs) Handles TxtNome2.TextChanged

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btRelatorio.Click
        If TxtCodEvento.Text = "" Then
            MsgBox("selecione um evento para busca")
            Exit Sub
        End If
        '  Form1.Show()
        Try

            PrintDocument1.Print()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim pdv2 As New FrmPDV2
        pdv2.imprimiRelResumoVenda(e, TxtCodEvento.Text, TxtNome1.Text & " " & TxtNome2.Text & " " & TxtNome3.Text, "P")
        Exit Sub

        Dim reportFont2 As Font = New Drawing.Font("Time New Roman", 8)
        venda.cod_evento = TxtCodEvento.Text
        Dim tabela As DataTable
        ds = venda.ResumoVendas()
        tabela = ds.Tables(0)
        Dim Row As DataRow
        Dim x As Integer = 0
        If tabela.Rows.Count > 0 Then

            e.Graphics.DrawString("RESUMO EVENTO ", reportFont2, Brushes.Black, 90, x)
            x = x + 20
            e.Graphics.DrawString(TxtCodEvento.Text & " " & TxtNome1.Text, reportFont2, Brushes.Black, 0, x)
            x = 60
            For Each Row In ds.Tables(0).Rows

                If x = 60 Then
                    e.Graphics.DrawString("ITEM", reportFont2, Brushes.Black, 0, x)
                    e.Graphics.DrawString("QTDE", reportFont2, Brushes.Black, 190, x)
                    e.Graphics.DrawString("VALOR", reportFont2, Brushes.Black, 240, x)
                    x = x + 15
                End If
                x = x + 20
                e.Graphics.DrawString(Row.Item(1), reportFont2, Brushes.Black, 0, x)
                e.Graphics.DrawString(Row.Item(2), reportFont2, Brushes.Black, 190, x)
                e.Graphics.DrawString(Row.Item(3), reportFont2, Brushes.Black, 240, x)

            Next
            x = x + 40
            e.Graphics.DrawString("TOTAL:", reportFont2, Brushes.Black, 0, x)
            e.Graphics.DrawString(Row.Item(4), reportFont2, Brushes.Black, 190, x)
            e.Graphics.DrawString(Row.Item(5), reportFont2, Brushes.Black, 240, x)
        End If

    End Sub

    Private Sub FrmEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t180101 = False Then
                MsgBox("Usuário sem permissão para acessar a Cidade!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
            BtnSalvar.Enabled = ModPermissaoUsuario.t1801011
            BtnExcluir.Enabled = ModPermissaoUsuario.t1801012
        End If

        TabControl1.SelectedIndex = 0
        limpar()
        TabControl1.TabPages.Remove(TabPage2)
        TabControl1.TabPages.Remove(TabPage3)
        DtpDtaEvento.Value = Today
    End Sub

    Private Sub BtRelLucro_Click(sender As Object, e As EventArgs) Handles BtIngresso.Click
        If TxtCodEvento.Text = "" Then
            MsgBox("selecione um evento para busca")
            Exit Sub
        End If
        '  Form1.Show()
        Try
            PrintDocumentLucro.Print()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub PrintDocumentLucro_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentLucro.PrintPage
        relMargemLucro(e, TxtCodEvento.Text, TxtNome1.Text)
    End Sub

    Public Sub relMargemLucro(e As Printing.PrintPageEventArgs, codEvento As String, nomEvento As String)
        Dim reportFont2 As Font = New Drawing.Font("Time New Roman", 6)
        Dim reportFont8 As Font = New Drawing.Font("Time New Roman", 8)
        venda.cod_evento = codEvento
        Dim tabela As DataTable
        ds = venda.margemLucro()
        tabela = ds.Tables(0)
        Dim Row As DataRow
        Dim x As Integer = 0
        If tabela.Rows.Count > 0 Then

            e.Graphics.DrawString("RELATORIO MARGEM DE LUCRO ", reportFont8, Brushes.Black, 60, x)
            x = x + 20
            e.Graphics.DrawString(codEvento & " " & nomEvento, reportFont8, Brushes.Black, 0, x)
            x = 60
            For Each Row In ds.Tables(0).Rows

                If x = 60 Then
                    e.Graphics.DrawString("ITEM", reportFont2, Brushes.Black, 0, x)
                    e.Graphics.DrawString("CUSTO", reportFont2, Brushes.Black, 150, x)
                    e.Graphics.DrawString("VENDA", reportFont2, Brushes.Black, 195, x)
                    e.Graphics.DrawString("LUCRO", reportFont2, Brushes.Black, 240, x)
                    x = x + 15
                End If
                x = x + 20
                e.Graphics.DrawString(Row.Item(1), reportFont2, Brushes.Black, 0, x)
                e.Graphics.DrawString(Row.Item(2), reportFont2, Brushes.Black, 160, x)
                e.Graphics.DrawString(Row.Item(3), reportFont2, Brushes.Black, 200, x)
                e.Graphics.DrawString(Row.Item(4), reportFont2, Brushes.Black, 240, x)

            Next
            x = x + 40
            e.Graphics.DrawString("TOTAL:", reportFont2, Brushes.Black, 0, x)
            e.Graphics.DrawString(Row.Item(5), reportFont2, Brushes.Black, 160, x)
            e.Graphics.DrawString(Row.Item(6), reportFont2, Brushes.Black, 200, x)
            e.Graphics.DrawString(Row.Item(7), reportFont2, Brushes.Black, 240, x)
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub BtSalvaIngresso_Click(sender As Object, e As EventArgs) Handles BtSalvaIngresso.Click
        Try
            If TxtNome1.Text <> "" And TxtCodEvento.Text = "" And atualizar = 1 Then
                salvaEvento()
            End If
            If TxtNome2.Text = "" Then
                MsgBox("Para melhor impressão do ingresso preencha as descrições", MsgBoxStyle.Information, "Informação")
                TxtNome2.Select()
                Exit Sub
            End If
            If TxtNome3.Text = "" And TxtNome3.Text = "" Then
                MsgBox("Para melhor impressão do ingresso preencha as descrições", MsgBoxStyle.Information, "Informação")
                TxtNome3.Select()
                Exit Sub
            End If

            If TxtValEntrada.Text = "" Then
                TxtValEntrada.Text = "0"
            End If

            ingresso.des_ingresso = TxtNome2.Text
            ingresso.des_ingresso1 = TxtNome3.Text
            ingresso.val_entrada = TxtValEntrada.Text.Replace(",", ".")
            ingresso.des_lote = TxtDesLote.Text
            ingresso.des_observacao1 = Txt_observacao1.Text
            ingresso.des_observacao2 = Txt_observacao2.Text

            'ds1 = evento.UltimoEventoCadastrado
            '' Dim linha As DataRow
            '  linha = ds1.Tables(0).Rows(0)


            If CbIndAberto.Text = "NAO" Then
                evento.ind_aberto = "N"
            Else
                evento.ind_aberto = "S"
            End If

            If atualizarIngresso = 1 Then
                Try
                    Dim ultimo As New DataSet
                    ultimo = ingresso2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    ingresso.seq_ingresso = Convert.ToInt16(ult)

                    ultimo.Clear()
                Catch ex As Exception
                    ingresso.seq_ingresso = 1
                End Try

                ingresso.CadastrarIngresso()
                MsgBox("Ingresso cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")

            Else

                ingresso.cod_evento = TxtCodEvento.Text
                ingresso.seq_ingresso = LbSequenciaIngresso.Text
                ingresso.AtualizarIngresso()

                MsgBox("Ingresso Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")

            End If
            atualizarDadosIngresso()
            limparIngresso()

        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try

    End Sub

    Private Sub BtLimparIngresso_Click(sender As Object, e As EventArgs) Handles BtLimparIngresso.Click
        limparIngresso()
    End Sub

    Private Sub DgvEvento_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEvento.CellEnter
        Try
            limpar()
            atualizar = 2
            TxtCodEvento.Text = DgvEvento.CurrentRow.Cells(0).Value
            TxtNome1.Text = DgvEvento.CurrentRow.Cells(1).Value
            DtpDtaEvento.Value = DgvEvento.CurrentRow.Cells(2).Value
            Dim ativo As String
            ativo = DgvEvento.CurrentRow.Cells(3).Value
            If ativo = "S" Then
                CbIndAberto.Text = "SIM"
            Else
                CbIndAberto.Text = "NAO"
            End If
            atualizarDadosIngresso()
            atualizarIngressoPessoa()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles BtExcluirIngPessoa.Click
        If MsgBox("Deseja excluir o ingresso" & TxbCodigoIP.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                ingressoPessoa.seq_lancamento = TxbCodigoIP.Text
                ingressoPessoa.ExcluirIngressoPessoa()
                MsgBox("Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizarIngressoPessoa()
            Catch ex As Exception
                MsgBox("Erro ao excluir Ingresso, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub BtSalvaIngPessoa_Click(sender As Object, e As EventArgs) Handles BtSalvaIngPessoa.Click

        Try
            If TxbCodImpressaoIP.Text = "" Then
                MsgBox("Informe a Impressão corespondente", MsgBoxStyle.Information, "Informação")
                TxbCodImpressaoIP.Select()
                Exit Sub
            End If

            If TxbCodPessoaIP.Text = "" Then
                MsgBox("Informe a Pessoa ", MsgBoxStyle.Information, "Informação")
                TxbCodPessoaIP.Select()
                Exit Sub
            End If

            ' If TxbQtdeImpressa.Text = "" Then
            'MsgBox("Informe a Quantidade ", MsgBoxStyle.Information, "Informação")
            'TxbQtdeImpressa.Select()
            'Exit Sub
            'End If

            If DtpDtaEntIngPessoa.Value = Now Then
                MsgBox("Data não pode ser maior que a atual", MsgBoxStyle.Information, "Informação")
                DtpDtaEntIngPessoa.Select()
                Exit Sub
            End If

            If Convert.ToInt16(LbQtdDisponivel.Text) < Convert.ToInt16(TxbQtdEntregueIP.Text) Then
                If atualizarIngPessoa = 1 Then
                    MsgBox("Valor e maior que Qtde Impressa")
                    TxbQtdEntregueIP.Select()
                    Exit Sub
                Else
                    If (qtdEntrequeOld + Convert.ToInt16(LbQtdDisponivel.Text) + Convert.ToInt16(TxbQtdDevolvIP.Text)) < Convert.ToInt16(TxbQtdEntregueIP.Text) Then
                        MsgBox("Valor e maior que Qtde Impressa")
                        TxbQtdEntregueIP.Select()
                        Exit Sub
                    End If
                End If
            End If

            If TxbQtdDevolvIP.Text = "" Then
                TxbQtdDevolvIP.Text = "0"
            End If

            ingressoPessoa.seq_impressao = TxbCodImpressaoIP.Text
            ingressoPessoa.cod_pessoa = TxbCodPessoaIP.Text
            ingressoPessoa.qtd_entregue = TxbQtdEntregueIP.Text
            ingressoPessoa.qtd_devolvida = TxbQtdDevolvIP.Text
            ingressoPessoa.des_observacao = TxbObsIP.Text
            ingressoPessoa.dta_entrega = DtpDtaEntIngPessoa.Value.ToShortDateString

            If atualizarIngPessoa = 1 Then
                Try
                    Dim ultimo As New DataSet
                    ultimo = ingressoPessoa2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    ingressoPessoa.seq_lancamento = Convert.ToInt16(ult) + 1

                    ultimo.Clear()
                Catch ex As Exception
                    ingressoPessoa.seq_lancamento = 1
                End Try

                ingressoPessoa.CadastrarIngressoPessoa()


                MsgBox("Cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                limparIngressoPessoa()
                atualizarIngressoPessoa()
            Else
                ingressoPessoa.seq_lancamento = TxbCodigoIP.Text
                ingressoPessoa.AtualizarIngressoPessoa()

                MsgBox("Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizarIngressoPessoa()
            End If

        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try

    End Sub

    Private Sub BtLimpaIngPessoa_Click(sender As Object, e As EventArgs) Handles BtLimpaIngPessoa.Click
        limparIngressoPessoa()
    End Sub

    Private Sub DgvIngressoPessoa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvIngressoPessoa.CellClick
        Try
            limparIngressoPessoa()
            atualizarIngPessoa = 2
            TxbCodigoIP.Text = DgvIngressoPessoa.CurrentRow.Cells(0).Value
            TxbDesImpressaoIP.Text = DgvIngressoPessoa.CurrentRow.Cells(2).Value
            TxbCodPessoaIP.Text = DgvIngressoPessoa.CurrentRow.Cells(3).Value
            TxbNomPessoaIP.Text = DgvIngressoPessoa.CurrentRow.Cells(4).Value
            TxbQtdEntregueIP.Text = DgvIngressoPessoa.CurrentRow.Cells(5).Value
            qtdEntrequeOld = DgvIngressoPessoa.CurrentRow.Cells(5).Value
            TxbQtdDevolvIP.Text = DgvIngressoPessoa.CurrentRow.Cells(6).Value
            TxbObsIP.Text = DgvIngressoPessoa.CurrentRow.Cells(7).Value
            DtpDtaEntIngPessoa.Value = DgvIngressoPessoa.CurrentRow.Cells(8).Value
            TxbCodImpressaoIP.Text = DgvIngressoPessoa.CurrentRow.Cells(1).Value
            carregarQtdDisponivel()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btBuscaIngressoIP_Click(sender As Object, e As EventArgs) Handles btBuscaIngressoIP.Click
        If TxtCodEvento.Text = "" Then
            MsgBox("selecione um Evento")
            TxtCodEvento.Select()
            Exit Sub
        End If
        FrmPesquisa.cod_evento = TxtCodEvento.Text
        FrmPesquisa.tabela = "tab_ingresso_impresso"
        FrmPesquisa.ShowDialog()
        TxbCodImpressaoIP.Text = ModVariavelGlobal.pesquisaCodigo
        TxbDesImpressaoIP.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtBuscaPessoaIP_Click(sender As Object, e As EventArgs) Handles BtBuscaPessoaIP.Click
        FrmPesquisa.tabela = "tab_pessoa"
        FrmPesquisa.ShowDialog()
        TxbCodPessoaIP.Text = ModVariavelGlobal.pesquisaCodigo
        TxbNomPessoaIP.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub TxbCodImpressaoIP_TextChanged(sender As Object, e As EventArgs) Handles TxbCodImpressaoIP.TextChanged
        If Not IsNumeric(TxbCodImpressaoIP.Text) Then
            TxbCodImpressaoIP.Text = ""
        End If
        carregarQtdDisponivel()
    End Sub
    Public Sub carregarQtdDisponivel()
        If TxbCodImpressaoIP.Text = "" Then
            lbDesQtdDisponivel.Visible = False
            LbQtdDisponivel.Visible = False
        Else
            Try
                lbDesQtdDisponivel.Visible = True
                LbQtdDisponivel.Visible = True
                ingressoPessoa.seq_impressao = TxbCodImpressaoIP.Text
                ingressoPessoa.cod_evento = TxtCodEvento.Text
                Dim ds6 As New DataSet
                Dim tabela6 As DataTable
                ds6 = ingressoPessoa.ConsultarQtdDisponivel()
                tabela6 = ds6.Tables(0)
                LbQtdDisponivel.Text = tabela6.Rows(0)("qtd_disponivel").ToString
                atualizarIngressoPessoa()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub BtnRelIngresso_Click_3(sender As Object, e As EventArgs) Handles BtRelIngresso.Click
        If TxtCodEvento.Text = "" Then
            MsgBox("Um evento tem que estar selecionado")
            Exit Sub
        End If
        Try
            PrintDocRelIngresso.Print()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PrintDocRelIngresso_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocRelIngresso.PrintPage
        imprimiRelResumoIngresso(e, TxtCodEvento.Text)
    End Sub
    Public Sub imprimiRelResumoIngresso(e As Printing.PrintPageEventArgs, codEvento As String)

        Dim reportFont2 As Font = New Drawing.Font("Time New Roman", 8)
        Dim reportFont10 As Font = New Drawing.Font("Time New Roman", 10)
        Dim reportFont12 As Font = New Drawing.Font("Time New Roman", 12)
        ingressoPessoa.cod_evento = codEvento
        Dim tabela As DataTable
        ds = ingressoPessoa.ConsultaGeralIngPessoa()

        tabela = ds.Tables(0)
        Dim Row As DataRow
        Dim x As Integer = 0
        If tabela.Rows.Count > 0 Then

            e.Graphics.DrawString("RESUMO INGRESSO VENDIDO ", reportFont12, Brushes.Black, 0, x)
            x = x + 20

            x = 40
            Dim nome As String = ""
            Dim qtd_pessoa, qtd_total, val_pessoa, val_total As Double
            qtd_pessoa = 0
            qtd_total = 0
            val_pessoa = 0
            val_total = 0
            For Each Row In ds.Tables(0).Rows

                If x = 40 Then
                    e.Graphics.DrawString("LOTE", reportFont2, Brushes.Black, 0, x)
                    e.Graphics.DrawString("DATA", reportFont2, Brushes.Black, 90, x)
                    e.Graphics.DrawString("LEVOU", reportFont2, Brushes.Black, 140, x)
                    e.Graphics.DrawString("VOLTOU", reportFont2, Brushes.Black, 190, x)
                    e.Graphics.DrawString("VALOR", reportFont2, Brushes.Black, 245, x)
                    x = x + 15
                End If

                If nome <> Row.Item(4) Then
                    If qtd_pessoa <> 0 Then
                        x = x + 20
                        e.Graphics.DrawString("TOTAL PESSOA:", reportFont10, Brushes.Black, 0, x)
                        e.Graphics.DrawString(qtd_pessoa, reportFont10, Brushes.Black, 180, x)
                        e.Graphics.DrawString(val_pessoa, reportFont10, Brushes.Black, 240, x)
                        qtd_pessoa = 0
                        val_pessoa = 0
                    End If
                    x = x + 20
                    e.Graphics.DrawString(Row.Item(4), reportFont12, Brushes.Black, 90, x)
                    nome = Row.Item(4)
                End If


                x = x + 20
                e.Graphics.DrawString(Row.Item(2), reportFont2, Brushes.Black, 0, x) ' lote
                e.Graphics.DrawString(Row.Item(8), reportFont2, Brushes.Black, 90, x) ' data
                e.Graphics.DrawString(Row.Item(5), reportFont2, Brushes.Black, 160, x) 'qtd entregue
                e.Graphics.DrawString(Row.Item(6), reportFont2, Brushes.Black, 210, x) 'qtd devolvida
                e.Graphics.DrawString(Row.Item(9), reportFont2, Brushes.Black, 250, x) 'valor total
                qtd_pessoa = qtd_pessoa + Row.Item(5) - Row.Item(6)
                qtd_total = qtd_total + Row.Item(5) - Row.Item(6)
                val_pessoa = val_pessoa + Row.Item(9)
                val_total = val_total + Row.Item(9)

            Next
            x = x + 20
            e.Graphics.DrawString("TOTAL PESSOA:", reportFont2, Brushes.Black, 0, x)
            e.Graphics.DrawString(qtd_pessoa, reportFont10, Brushes.Black, 180, x)
            e.Graphics.DrawString(val_pessoa, reportFont10, Brushes.Black, 240, x)

            x = x + 40
            e.Graphics.DrawString("TOTAL GERAL:", reportFont10, Brushes.Black, 0, x)
            e.Graphics.DrawString(qtd_total, reportFont10, Brushes.Black, 180, x)
            e.Graphics.DrawString(val_total, reportFont10, Brushes.Black, 240, x)
        End If
    End Sub

    Private Sub BtImprimirIngresso_Click_3(sender As Object, e As EventArgs) Handles BtImprimirIngresso.Click
        FrmPrincipal.imprimirIngresso()
    End Sub

    Private Sub BtCadPessoa_Click(sender As Object, e As EventArgs) Handles BtCadPessoa.Click
        FrmPessoa.ShowDialog()

    End Sub

    Private Sub TxtCodEvento_TextChanged(sender As Object, e As EventArgs) Handles TxtCodEvento.TextChanged
        If Not IsNumeric(TxtCodEvento.Text) Then
            TxtCodEvento.Text = ""
        End If
        If TxtCodEvento.Text <> "" Then
            If Not TabControl1.TabPages.Contains(TabPage2) Then
                TabControl1.TabPages.Add(TabPage2)
                TabControl1.TabPages.Add(TabPage3)
            End If
        Else
                TabControl1.TabPages.Remove(TabPage2)
                TabControl1.TabPages.Remove(TabPage3)

            End If



    End Sub

    Private Sub TxbQtdeImpressa_TextChanged(sender As Object, e As EventArgs) Handles TxbQtdeImpressa.TextChanged
        If Not IsNumeric(TxbQtdeImpressa.Text) Then
            TxbQtdeImpressa.Text = ""
        End If
    End Sub

    Private Sub TxtValEntrada_TextChanged(sender As Object, e As EventArgs) Handles TxtValEntrada.TextChanged
        If Not IsNumeric(TxtValEntrada.Text) Then
            TxtValEntrada.Text = ""
        End If
    End Sub

    Private Sub TxbCodigoIP_TextChanged(sender As Object, e As EventArgs) Handles TxbCodigoIP.TextChanged
        If Not IsNumeric(TxbCodigoIP.Text) Then
            TxbCodigoIP.Text = ""
        End If
    End Sub

    Private Sub TxbCodPessoaIP_TextChanged(sender As Object, e As EventArgs) Handles TxbCodPessoaIP.TextChanged
        If Not IsNumeric(TxbCodPessoaIP.Text) Then
            TxbCodPessoaIP.Text = ""
        End If
    End Sub

    Private Sub TxbQtdEntregueIP_TextChanged(sender As Object, e As EventArgs) Handles TxbQtdEntregueIP.TextChanged
        If Not IsNumeric(TxbQtdEntregueIP.Text) Then
            TxbQtdEntregueIP.Text = ""
        End If
    End Sub

    Private Sub TxbQtdDevolvIP_TextChanged(sender As Object, e As EventArgs) Handles TxbQtdDevolvIP.TextChanged
        If Not IsNumeric(TxbQtdDevolvIP.Text) Then
            TxbQtdDevolvIP.Text = ""
        End If
    End Sub

    Private Sub DgvIngresso_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvIngresso.CellClick
        Try
            limparIngresso()
            atualizarIngresso = 2
            LbSequenciaIngresso.Text = DgvIngresso.CurrentRow.Cells(0).Value
            TxtNome2.Text = DgvIngresso.CurrentRow.Cells(2).Value
            TxtNome3.Text = DgvIngresso.CurrentRow.Cells(3).Value
            TxtValEntrada.Text = DgvIngresso.CurrentRow.Cells(4).Value
            TxtDesLote.Text = DgvIngresso.CurrentRow.Cells(5).Value
            Txt_observacao1.Text = DgvIngresso.CurrentRow.Cells(6).Value
            Txt_observacao2.Text = DgvIngresso.CurrentRow.Cells(7).Value
        Catch ex As Exception

        End Try
    End Sub


    Private Sub BtExcluirIngresso_Click(sender As Object, e As EventArgs) Handles BtExcluirIngresso.Click
        If MsgBox("Deseja excluir o ingresso" & TxtNome2.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                ingresso.seq_ingresso = TxtCodEvento.Text
                ingresso.ExcluirIngresso()
                MsgBox("Ingresso excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizarDadosIngresso()
            Catch ex As Exception
                MsgBox("Erro ao excluir Ingresso, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub


End Class