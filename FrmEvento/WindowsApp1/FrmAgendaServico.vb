Public Class FrmAgendaServico
    Dim conectar As New ConexaoSQL
    Dim ds, dsUltimo, dsFuncionario As New DataSet
    Dim agenda, agenda2 As New ClAgendaServico
    Dim atualizar As Integer = 1
    Dim seq_agenda_old, cod_pessoa_cliente_old, nom_pessoa_cliente_old, cod_pessoa_funcionario_old, nom_pessoa_funcionario_old,
        dta_agenda_old, hra_agenda_old, min_agenda_old, val_servico_old, des_observacao_old, ind_executado_old As String
    Dim i As Integer = 0
    'relatorio
    Dim relAgenda As New ClRelAgendaServico
    Dim tabRel As New DataTable
    Dim dsRel As New DataSet
    Dim qtdFuncionario As New Integer
    Dim tabFuncionario As DataTable
    Dim cod_pessoa_funcionario_coluna(100) As String
    Dim nom_pessoa_funcionario_coluna(100) As String
    Dim numColunaFuncionario(100) As Integer
    Dim geral As New ClGeral


    Dim seq_agenda_Celula(100, 100), cod_pessoa_cliente_Celula(100, 100), nom_pessoa_cliente_Celula(100, 100), cod_pessoa_funcionario_Celula(100, 100), nom_pessoa_funcionario_Celula(100, 100),
        dta_agenda_Celula(100, 100), hra_agenda_Celula(100, 100), min_agenda_Celula(100, 100), val_servico_Celula(100, 100), des_observacao_Celula(100, 100), ind_executado_Celula(100, 100) As String

    Private Sub initializeDgv1()
        Try
            dsFuncionario = agenda.ConsultarFuncionarioAgendaServico()
            tabFuncionario = dsFuncionario.Tables(0)
            If tabFuncionario.Rows.Count > 0 Then
                qtdFuncionario = tabFuncionario.Rows.Count
                For index = 0 To tabFuncionario.Rows.Count + 1
                    'inserindo nome cabecalho
                    Dgv1.Columns.Add("index", "index")                   '// Col = 0
                    Dgv1.Columns("index").ValueType = GetType(String)
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmAgendaServico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim licencia As Boolean
            Dim ClLicencia As New ClLicencia
            licencia = ClLicencia.verificarLicencia()
            If licencia = False Then
                Me.Close()
                Exit Sub
            End If
            initializeDgv1()
            limpar()
            ' DtpDtaAgenda.Value = Today.AddDays(-1)
            ' Dgv.DataSource = Nothing
            ' Me.RpvAgendaServico.RefreshReport()
            MCDataAgenda.MinDate = Today.AddDays(-30)
            TabControl1.SelectedIndex = 2
            carregaPrincipal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub carregaPrincipal()
        'Limpar os array 
        Erase seq_agenda_Celula
        Erase cod_pessoa_cliente_Celula
        Erase nom_pessoa_cliente_Celula
        Erase cod_pessoa_funcionario_Celula
        Erase nom_pessoa_funcionario_Celula
        Erase dta_agenda_Celula
        Erase hra_agenda_Celula
        Erase min_agenda_Celula
        Erase val_servico_Celula
        Erase des_observacao_Celula
        Erase ind_executado_Celula
        ReDim seq_agenda_Celula(100, 100), cod_pessoa_cliente_Celula(100, 100), nom_pessoa_cliente_Celula(100, 100), cod_pessoa_funcionario_Celula(100, 100), nom_pessoa_funcionario_Celula(100, 100),
        dta_agenda_Celula(100, 100), hra_agenda_Celula(100, 100), min_agenda_Celula(100, 100), val_servico_Celula(100, 100), des_observacao_Celula(100, 100), ind_executado_Celula(100, 100)

        If dta_agenda_old = "" Then
            dta_agenda_old = Today
        End If
        dsFuncionario = agenda.ConsultarFuncionarioAgendaServico()
        tabFuncionario = dsFuncionario.Tables(0)
        If tabFuncionario.Rows.Count > 0 Then
            Try
                With Dgv1
                    .Rows.Clear()
                    .DataSource = Nothing
                    .Columns(0).HeaderText = "Hora"
                    .Columns(1).HeaderText = "Minuto"
                    .Columns(0).Width = 40
                    .Columns(1).Width = 40

                    For index = 2 To qtdFuncionario + 1
                        'inserindo nome cabecalho
                        .Columns(index).HeaderText = tabFuncionario.Rows(index - 2).Item("nom_pessoa").ToString
                        .Columns(index).Width = 200
                        cod_pessoa_funcionario_coluna(index) = tabFuncionario.Rows(index - 2).Item("cod_pessoa").ToString
                        nom_pessoa_funcionario_coluna(index) = tabFuncionario.Rows(index - 2).Item("nom_pessoa").ToString
                        numColunaFuncionario(100) = index
                    Next

                    'criar as linhas das horas 
                    For index = 0 To 23
                        Dim hora As String

                        If (CStr(index).Length) = 1 Then
                            hora = "0" & CStr(index)
                        Else
                            hora = CStr(index)
                        End If
                        .Rows.Add(hora, "00")
                        .Rows.Add(hora, "30")
                    Next

                    atualizaDados()

                    Dim tabInformacao As DataTable
                    tabInformacao = ds.Tables(0)
                    If ds.Tables(0).Rows.Count > 0 Then
                        Dim mesmaLinha As Integer = 0
                        For Each row As DataRow In tabInformacao.Rows
                            'INSERINDO DADOS NO GRID PESSOA
                            Dim linha As Integer = CUInt(row.Item("hra_agenda").ToString) * 2

                            If CUInt(row.Item("min_agenda").ToString) > 0 Then
                                linha = linha + 1
                            End If
                            Dim coluna As String = row.Item("nom_pessoa_funcionario").ToString
                            Dim indexColuna As Integer

                            For x As Integer = 2 To qtdFuncionario + 2

                                If nom_pessoa_funcionario_coluna(x) = coluna Then
                                    indexColuna = x
                                    Exit For
                                End If
                            Next
                            'jogar no datagrid
                            If .Rows(linha).Cells(indexColuna).Value <> "" Then
                                .Rows(linha).Cells(indexColuna).Value = .Rows(linha).Cells(indexColuna).Value & vbCrLf & row.Item("nom_pessoa_cliente").ToString
                            Else
                                .Rows(linha).Cells(indexColuna).Value = row.Item("nom_pessoa_cliente").ToString
                            End If

                            seq_agenda_Celula(linha, indexColuna) = row.Item("seq_agenda").ToString
                            cod_pessoa_cliente_Celula(linha, indexColuna) = row.Item("cod_pessoa_cliente").ToString
                            nom_pessoa_cliente_Celula(linha, indexColuna) = row.Item("nom_pessoa_cliente").ToString
                            cod_pessoa_funcionario_Celula(linha, indexColuna) = row.Item("cod_pessoa_funcionario").ToString
                            nom_pessoa_funcionario_Celula(linha, indexColuna) = row.Item("nom_pessoa_funcionario").ToString
                            dta_agenda_Celula(linha, indexColuna) = row.Item("dta_agenda").ToString
                            hra_agenda_Celula(linha, indexColuna) = row.Item("hra_agenda").ToString
                            min_agenda_Celula(linha, indexColuna) = row.Item("min_agenda").ToString
                            val_servico_Celula(linha, indexColuna) = row.Item("val_servico").ToString
                            des_observacao_Celula(linha, indexColuna) = row.Item("des_observacao").ToString
                            ind_executado_Celula(linha, indexColuna) = row.Item("ind_executado").ToString

                        Next
                    End If
                End With
                'Apagar as linhas de acordo com hora inicio parametro sistema
                For index = 0 To geral.sqlBuscaDescricao("hra_inicio_agenda_servico", "tab_parametro_sistema", "0", 0) * 2 - 1
                    Dgv1.Rows(index).Visible = False
                Next


            Catch ex As Exception
                '      MsgBox("Erro , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")
            End Try
        End If

    End Sub

    Private Sub Dgv1_DoubleClick(sender As Object, e As EventArgs) Handles Dgv1.DoubleClick
        Try
            If Dgv1.CurrentCell.ColumnIndex < 2 Then
                Exit Sub
            End If
            Me.TxbSeqAgenda.Text = seq_agenda_Celula(Dgv1.CurrentRow.Index, Dgv1.CurrentCell.ColumnIndex)
            Me.TxbCodCliente.Text = cod_pessoa_cliente_Celula(Dgv1.CurrentRow.Index, Dgv1.CurrentCell.ColumnIndex)
            Me.TxbNomCliente.Text = nom_pessoa_cliente_Celula(Dgv1.CurrentRow.Index, Dgv1.CurrentCell.ColumnIndex)
            Me.TxbCodFuncionario.Text = cod_pessoa_funcionario_coluna(Dgv1.CurrentCell.ColumnIndex)
            Me.TxbNomFuncionario.Text = nom_pessoa_funcionario_coluna(Dgv1.CurrentCell.ColumnIndex)
            ' Me.TxbDtaAgenda.Text = dta_agenda_Celula(Dgv1.CurrentRow.Index, Dgv1.CurrentCell.ColumnIndex)

            Me.TxbValServico.Text = val_servico_Celula(Dgv1.CurrentRow.Index, Dgv1.CurrentCell.ColumnIndex)
            Me.TxbObservacao.Text = des_observacao_Celula(Dgv1.CurrentRow.Index, Dgv1.CurrentCell.ColumnIndex)
            Try
                If ind_executado_Celula(Dgv1.CurrentRow.Index, Dgv1.CurrentCell.ColumnIndex).Trim.ToString = "" Or ind_executado_Celula(Dgv1.CurrentRow.Index, Dgv1.CurrentCell.ColumnIndex).Trim.ToString = "N" Then
                    CkbExecutado.Checked = False
                Else
                    CkbExecutado.Checked = True
                End If
            Catch ex As Exception
                CkbExecutado.Checked = False
            End Try


            TabControl1.SelectedIndex = 3
            If CUInt(Dgv1.CurrentRow.Index) Mod 2 = 1 Then
                Me.cbHora.Text = CStr((CUInt(Dgv1.CurrentRow.Index) - 1) / 2)
                CbMinuto.Text = "30"
            Else
                Me.cbHora.Text = CStr(CUInt(Dgv1.CurrentRow.Index) / 2)
                CbMinuto.Text = "00"
            End If


            If (CStr(cbHora.Text).Length) = 1 Then
                cbHora.Text = "0" & CStr(cbHora.Text)
            Else
                cbHora.Text = CStr(cbHora.Text)
            End If

            If (CStr(CbMinuto.Text).Length) = 1 Then
                CbMinuto.Text = "0" & CStr(CbMinuto.Text)
            Else
                CbMinuto.Text = CStr(CbMinuto.Text)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxbCodCliente_LostFocus(sender As Object, e As EventArgs) Handles TxbCodCliente.LostFocus
        Try
            If IsNumeric(TxbCodCliente.Text) = True Then
                TxbNomCliente.Text = geral.sqlBuscaDescricao("nom_pessoa", "tab_pessoa", "cod_pessoa", TxbCodCliente.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxbCodFuncionario_LostFocus(sender As Object, e As EventArgs) Handles TxbCodFuncionario.LostFocus
        Try
            If IsNumeric(TxbCodFuncionario.Text) = True Then
                TxbNomFuncionario.Text = geral.sqlBuscaDescricao("nom_pessoa", "tab_pessoa", "cod_pessoa", TxbCodFuncionario.Text & " and exists (select 1 from tab_pessoa_funcionario z where z.cod_pessoa = tab_pessoa.cod_pessoa and z.ind_agenda_servico = 'S')and ind_funcionario = 'S')")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbHora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHora.SelectedIndexChanged
        carregaGridHora()
    End Sub
    Private Sub carregaGridHora()
        If TxbDtaAgenda.Text = "" Or TxbCodFuncionario.Text = "" Or cbHora.Text = "" Then
            DgvHora.Visible = False
            Exit Sub
        End If

        Dim dsHora As New DataSet
        Dim tabela As DataTable
        Dim agenda As New ClAgendaServico
        dsHora = agenda.ConsultarHora(TxbDtaAgenda.Text, cbHora.Text, TxbCodFuncionario.Text, CbMinuto.Text)
        tabela = dsHora.Tables(0)

        If tabela.Rows.Count > 1 Then
            DgvHora.Visible = True

            DgvHora.DataSource = Nothing
            DgvHora.DataSource = dsHora.Tables(0)
            formataGridHora()
        Else
            DgvHora.Visible = False
            '      carregaFormulario()
        End If
    End Sub
    Private Sub formataGridHora()
        Try
            With DgvHora
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "Cliente mesmo horario e mesmo atendente"
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                .Columns(10).Visible = False

                .Columns(2).Width = 395

            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DgvHora_CellContentClick(sender As Object, e As EventArgs) Handles DgvHora.DoubleClick

        TxbSeqAgenda.Text = DgvHora.CurrentRow.Cells(0).Value
            TxbCodCliente.Text = DgvHora.CurrentRow.Cells(1).Value
            TxbNomCliente.Text = DgvHora.CurrentRow.Cells(2).Value
            TxbCodFuncionario.Text = DgvHora.CurrentRow.Cells(3).Value
            TxbNomFuncionario.Text = DgvHora.CurrentRow.Cells(4).Value
            TxbDtaAgenda.Text = DgvHora.CurrentRow.Cells(5).Value
            cbHora.Text = DgvHora.CurrentRow.Cells(6).Value
            CbMinuto.Text = DgvHora.CurrentRow.Cells(7).Value
            TxbValServico.Text = DgvHora.CurrentRow.Cells(8).Value
            TxbObservacao.Text = DgvHora.CurrentRow.Cells(9).Value
            If DgvHora.CurrentRow.Cells(10).Value = "N" Then
                CkbExecutado.Checked = False
            Else
                CkbExecutado.Checked = True
            End If

        TxbSeqAgenda.Enabled = False
        seq_agenda_old = TxbSeqAgenda.Text
    End Sub

    Private Sub CbMinuto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMinuto.SelectedIndexChanged
        carregaGridHora()
    End Sub

    Private Sub TxbCodFuncionario_TextChanged(sender As Object, e As EventArgs) Handles TxbCodFuncionario.TextChanged
        carregaGridHora()
    End Sub

    Private Sub TxbDtaAgenda_TextChanged(sender As Object, e As EventArgs) Handles TxbDtaAgenda.TextChanged
        carregaGridHora()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FrmFiltroRelComissaoAgendaServ.WindowState = FormWindowState.Minimized Then
            FrmFiltroRelComissaoAgendaServ.WindowState = FormWindowState.Normal
            FrmFiltroRelComissaoAgendaServ.Activate()
        Else
            FrmFiltroRelComissaoAgendaServ.Show()
        End If
    End Sub

    Private Sub BtnGrid_Click(sender As Object, e As EventArgs) Handles BtnGrid.Click
        If TabControl1.SelectedIndex = 3 Then
            TabControl1.SelectedIndex = 2
        Else
            TabControl1.SelectedIndex = 3
        End If
        carregaPrincipal()
    End Sub
    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        carregarOld()
        carregaPrincipal()
        TabControl1.SelectedIndex = 2
    End Sub
    Private Sub carregarOld()
        seq_agenda_old = TxbSeqAgenda.Text
        cod_pessoa_cliente_old = TxbCodCliente.Text
        nom_pessoa_cliente_old = TxbNomCliente.Text
        cod_pessoa_funcionario_old = TxbCodFuncionario.Text
        nom_pessoa_funcionario_old = TxbNomFuncionario.Text
        dta_agenda_old = TxbDtaAgenda.Text
        hra_agenda_old = cbHora.Text
        min_agenda_old = CbMinuto.Text
        val_servico_old = TxbValServico.Text
        des_observacao_old = TxbObservacao.Text
        If CkbExecutado.Checked = True Then
            ind_executado_old = "S"
        Else
            ind_executado_old = "N"
        End If
    End Sub
    Public Sub atualizaDados()
        If TxbDtaAgenda.Text = "" Then
            TxbDtaAgenda.Text = Today.ToShortDateString.ToString
        End If

        Dim tabela As DataTable
        ds = agenda.Consultar(TxbDtaAgenda.Text)
        tabela = ds.Tables(0)

        If tabela.Rows.Count > 0 Then
            Dgv.DataSource = Nothing
            Dgv.DataSource = ds.Tables(0)
            formatarGrid()
            '      carregaFormulario()

        End If
    End Sub

    Private Sub BtnCliente_Click_1(sender As Object, e As EventArgs) Handles BtnCliente.Click
        FrmPesquisa.tabela = "tab_pessoa"
        FrmPesquisa.ShowDialog()
        TxbCodCliente.Text = ModVariavelGlobal.pesquisaCodigo
        TxbNomCliente.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub
    Private Sub BtnFuncionario_Click(sender As Object, e As EventArgs) Handles BtnFuncionario.Click
        FrmPesquisa.tabela = "tab_pessoa_funcionario_agenda"
        FrmPesquisa.ShowDialog()
        TxbCodFuncionario.Text = ModVariavelGlobal.pesquisaCodigo
        TxbNomFuncionario.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub
    Private Sub cbHora_lostFocus(sender As Object, e As EventArgs) Handles cbHora.LostFocus
        If IsNumeric(cbHora.Text) = True Then
            If CUInt(cbHora.Text) > 24 Or CUInt(cbHora.Text) < 0 Then
                MsgBox("Hora invalida! ", MsgBoxStyle.Critical, "Erro")
                cbHora.Text = ""
                cbHora.Select()
            End If
        End If
    End Sub

    Private Sub BtnRelatorio_Click(sender As Object, e As EventArgs) Handles BtnRelatorio.Click
        TabControl1.SelectedIndex = 1
        Try
            dsRel = relAgenda.Consultar(TxbDtaAgenda.Text)
            tabRel = dsRel.Tables(0)
            If tabRel Is Nothing Then
                MsgBox("Não existe dados para gerar o relatório!")
                Exit Sub
            End If
            Dim x As Integer = 0
            Dim linhas = New List(Of ClRelAgendaServico)()
            For index = 0 To tabRel.Rows.Count - 1
                linhas.Add(New ClRelAgendaServico(tabRel.Rows(x).Item("seq_agenda"),
                tabRel.Rows(x).Item("cod_pessoa_cliente"),
                tabRel.Rows(x).Item("nom_pessoa_cliente"),
                tabRel.Rows(x).Item("cod_pessoa_funcionario"),
                tabRel.Rows(x).Item("nom_pessoa_funcionario"),
                tabRel.Rows(x).Item("dta_agenda"),
                tabRel.Rows(x).Item("hra_agenda"),
                tabRel.Rows(x).Item("min_agenda"),
                tabRel.Rows(x).Item("val_servico"),
                tabRel.Rows(x).Item("des_observacao"),
                tabRel.Rows(x).Item("ind_executado"),
                tabRel.Rows(x).Item("val_comissao")))
                x = x + 1
            Next
            Dim empresa As String = ModParametroSistema.nom_empresa
            Dim dSource As New Microsoft.Reporting.WinForms.ReportDataSource("dsRel", linhas)
            Me.ReportViewer1.LocalReport.ReportPath = "RelAgendaServico.rdlc"
            Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("codEmpresa", ModParametroSistema.nom_fantasia))
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(dSource)
            dSource.Value = linhas

            Me.ReportViewer1.LocalReport.Refresh()
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
        End Try
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnGridPrincipal.Click
        carregaPrincipal()

        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedIndex = 3
    End Sub
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MCDataAgenda.DateChanged
        TxbDtaAgenda.Text = MCDataAgenda.SelectionRange.Start
        carregaPrincipal()
        TabControl1.SelectedIndex = 2
    End Sub
    Private Sub CbMinuto_lostFocus(sender As Object, e As EventArgs) Handles CbMinuto.LostFocus
        If IsNumeric(CbMinuto.Text) = True Then
            If CUInt(CbMinuto.Text) > 60 Or CUInt(CbMinuto.Text) < 0 Then
                MsgBox("Minuto invalida! ", MsgBoxStyle.Critical, "Erro")
                CbMinuto.Text = ""
                CbMinuto.Select()
            End If
        End If
    End Sub

    Private Sub BtnCadFuncionario_Click(sender As Object, e As EventArgs) Handles BtnCadFuncionario.Click

        FrmPessoa.CkbFuncionario.Checked = True
        If FrmPessoa.WindowState = FormWindowState.Minimized Then
            FrmPessoa.WindowState = FormWindowState.Normal
            FrmPessoa.Activate()
        Else
            FrmPessoa.Show()
        End If
        FrmPessoa.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaRegistro()
    End Sub
    Public Sub salvaRegistro()
        Try
            If TxbDtaAgenda.Text = "" Then
                MsgBox("INFOME A DATA")
                TxbDtaAgenda.Select()
                Exit Sub
            End If
            If cbHora.Text = "" Then
                MsgBox("INFORME A HORA")
                cbHora.Select()
                Exit Sub
            End If
            If CbMinuto.Text = "" Then
                MsgBox("INFORME A MINUTO")
                CbMinuto.Select()
                Exit Sub
            End If
            If TxbCodCliente.Text = "" Then
                MsgBox("INFORME O CLIENTE")
                TxbCodCliente.Select()
                Exit Sub
            End If
            If TxbValServico.Text = "" Then
                TxbValServico.Text = 0
            End If

            agenda.cod_pessoa_cliente = TxbCodCliente.Text

            If TxbCodFuncionario.Text = "" Then
                agenda.cod_pessoa_funcionario = 0
            Else
                agenda.cod_pessoa_funcionario = TxbCodFuncionario.Text
            End If
            agenda.dta_agenda = TxbDtaAgenda.Text
            agenda.hra_agenda = cbHora.Text
            agenda.min_agenda = CbMinuto.Text
            agenda.val_servico = TxbValServico.Text
            agenda.des_observacao = TxbObservacao.Text
            If CkbExecutado.Checked = True Then
                agenda.ind_executado = "S"
            Else
                agenda.ind_executado = "N"
            End If


            If TxbSeqAgenda.Text = "" Then
                'pegar o ultimo registro
                Try
                    Dim ultimo As New DataSet
                    ultimo = agenda2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    agenda.seq_agenda = Convert.ToInt16(ult) + 1

                    ultimo.Clear()
                Catch ex As Exception
                    agenda.seq_agenda = 1
                End Try
                agenda.Cadastrar()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                TabControl1.SelectedIndex = 2
            Else
                agenda.seq_agenda = TxbSeqAgenda.Text
                agenda.Atualizar()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                TabControl1.SelectedIndex = 2
            End If
            carregaPrincipal()
            limpar()

        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbSeqAgenda.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a o agendamento:   " & TxbSeqAgenda.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                agenda.seq_agenda = TxbSeqAgenda.Text
                agenda.Excluir()
                MsgBox(" Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()
                limpar()
            Catch ex As Exception
                MsgBox("Erro ao excluir , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click

        limpar()
        Dgv.DataSource = Nothing
        TxbSeqAgenda.Enabled = True
    End Sub
    Public Sub limpar()
        TxbSeqAgenda.Text = ""
        TxbCodCliente.Text = ""
        TxbNomCliente.Text = ""
        TxbCodFuncionario.Text = ""
        TxbNomFuncionario.Text = ""
        ' TxbDtaAgenda.Text = Today
        cbHora.Text = "00"
        CbMinuto.Text = "00"
        TxbObservacao.Text = ""
        TxbValServico.Text = ""
        CkbExecutado.Checked = False
        carregarOld()
        atualizar = 1
    End Sub
    Public Sub formatarGrid()
        Try
            With Dgv
                .Columns(0).HeaderText = "Sequencia"
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "Cliente"
                .Columns(3).Visible = False
                .Columns(4).HeaderText = "Funcionario"
                .Columns(5).HeaderText = "Data"
                .Columns(6).HeaderText = "Hora"
                .Columns(7).HeaderText = "Minuto"
                .Columns(8).HeaderText = "Total"
                .Columns(9).HeaderText = "Observação"
                .Columns(10).HeaderText = "Executado"
                .Columns(0).Width = 10
                .Columns(2).Width = 150
                .Columns(4).Width = 150
                .Columns(5).Width = 60
                .Columns(6).Width = 60
                .Columns(7).Width = 60
                .Columns(9).Width = 300
                .Columns(10).Width = 60
            End With
        Catch ex As Exception
        End Try
    End Sub
    Public Sub carregaFormulario()
        Try
            limpar()
            If ds.Tables(0).Rows.Count > 0 Then
                atualizar = 2
                TxbSeqAgenda.Text = ds.Tables(0).Rows(i)("seq_agenda").ToString
                TxbCodCliente.Text = ds.Tables(0).Rows(i)("cod_pessoa_cliente").ToString
                TxbNomCliente.Text = ds.Tables(0).Rows(i)("nom_pessoa_cliente").ToString
                TxbCodFuncionario.Text = ds.Tables(0).Rows(i)("cod_pessoa_funcionario").ToString
                TxbNomFuncionario.Text = ds.Tables(0).Rows(i)("nom_pessoa_funcionario").ToString
                TxbDtaAgenda.Text = ds.Tables(0).Rows(i)("dta_agenda").ToString
                cbHora.Text = ds.Tables(0).Rows(i)("hra_agenda").ToString
                CbMinuto.Text = ds.Tables(0).Rows(i)("min_agenda").ToString
                TxbValServico.Text = ds.Tables(0).Rows(i)("val_servico").ToString
                TxbObservacao.Text = ds.Tables(0).Rows(i)("des_observacao").ToString
                If ds.Tables(0).Rows(i)("ind_executado").ToString = "N" Then
                    CkbExecutado.Checked = False
                Else
                    CkbExecutado.Checked = True
                End If

                TxbSeqAgenda.Enabled = False
            Else
                atualizar = 1
                TxbSeqAgenda.Enabled = True
            End If
            seq_agenda_old = TxbSeqAgenda.Text
            carregarOld()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnCsv_Click(sender As Object, e As EventArgs)
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
    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles BtnCadCliente.Click

        FrmPessoa.CkbCliente.Checked = True

        If FrmPessoa.WindowState = FormWindowState.Minimized Then
            FrmPessoa.WindowState = FormWindowState.Normal
            FrmPessoa.Activate()
        Else
            FrmPessoa.Show()
        End If
        FrmPessoa.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Overloads Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        If Dgv.CurrentRow.Index = 0 Then
            MsgBox("")
        End If

        Me.TxbSeqAgenda.Text = Dgv.CurrentRow.Cells(0).Value
        Me.TxbCodCliente.Text = Dgv.CurrentRow.Cells(1).Value
        Me.TxbNomCliente.Text = Dgv.CurrentRow.Cells(2).Value
        Me.TxbCodFuncionario.Text = Dgv.CurrentRow.Cells(3).Value
        Me.TxbNomFuncionario.Text = Dgv.CurrentRow.Cells(4).Value
        Me.TxbDtaAgenda.Text = Dgv.CurrentRow.Cells(5).Value
        Me.cbHora.Text = Dgv.CurrentRow.Cells(6).Value
        Me.CbMinuto.Text = Dgv.CurrentRow.Cells(7).Value
        Me.TxbValServico.Text = Dgv.CurrentRow.Cells(8).Value
        Me.TxbObservacao.Text = Dgv.CurrentRow.Cells(9).Value
        If Dgv.CurrentRow.Cells(10).Value = "S" Then
            CkbExecutado.Checked = True
        Else
            CkbExecutado.Checked = False
        End If
        Me.TxbDtaAgenda.Select()
        atualizar = 2
    End Sub


End Class
