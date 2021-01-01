Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmFechamentoCaixaPdv
    Dim conectar As New ConexaoSQL
    Dim ds, dsRecebimento, dsVendaTipo As New DataSet
    Dim fechaCaixa As New ClFechamentoCaixaPdv
    Dim frmDtaFinal As New FrmDataFinal
    Dim resumoVenda As New ClResumoVendaItem
    Dim atualizar As Integer = 1
    Dim dta_fechamento_old, dtaFinal, hra_abertura_old, hra_fechamento_old As String
    Dim seq_fechamento_old, cod_pdv_old, cod_operador_old, num_fechamento_old As Integer
    Private Sub FrmFechamentoCaixaPdv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpDtaFechamento.Value = Today.ToShortDateString
        TxbDtaFechamento.Text = ""
    End Sub
    Private Sub DtpDtaFechamento_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaFechamento.ValueChanged
        TxbDtaFechamento.Text = DtpDtaFechamento.Value.ToShortDateString
    End Sub
    Private Sub BtnDtaFinal_Click(sender As Object, e As EventArgs) Handles BtnDtaFinal.Click
        frmDtaFinal.tela = "dtaFechamentoCx"
        frmDtaFinal.DtpDtaFinal.Value = CDate(TxbDtaFechamento.Text)
        frmDtaFinal.TxbDtaFinal.Text = ""
        frmDtaFinal.ShowDialog()
        dtaFinal = ModVariavelGlobal.dtaFinal
    End Sub
    Dim i As Integer = 0
    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        carregaOld()
        atualizaDados()
    End Sub
    Private Sub carregaOld()
        If TxbDtaFechamento.Text <> "" Then
            dta_fechamento_old = TxbDtaFechamento.Text
            If dtaFinal = "" Then
                dtaFinal = TxbDtaFechamento.Text
            End If
        End If
        hra_abertura_old = TxbhraAbertura.Text
        hra_fechamento_old = TxbHraFechamento.Text
        If TxbSeqFechamento.Text = "" Then
            seq_fechamento_old = 0
        Else
            seq_fechamento_old = TxbSeqFechamento.Text
        End If
        If TxbCodigo.Text = "" Then
            cod_pdv_old = 0
        Else
            cod_pdv_old = TxbCodigo.Text
        End If
        If TxbCodOperador.Text = "" Then
            cod_operador_old = 0
        Else
            cod_operador_old = TxbCodOperador.Text
        End If
        If TxbNumFechamento.Text = "" Then
            num_fechamento_old = 0
        Else
            num_fechamento_old = TxbNumFechamento.Text
        End If
    End Sub
    Public Sub atualizaDados()
        Try
            Dim status As String
            If CkbPe.Checked = True Then
                If RbAberto.Checked = True Then
                    status = "A"
                ElseIf RbConferido.Checked = True Then
                    status = "C"
                ElseIf RbFechado.Checked = True Then
                    status = "F"
                End If
            Else
                status = "T"

            End If
            Dim tabela As DataTable
            ds = fechaCaixa.Consultar(seq_fechamento_old, cod_pdv_old, cod_operador_old, dta_fechamento_old, dtaFinal,
                                      num_fechamento_old, hra_abertura_old, hra_fechamento_old, status)
            tabela = ds.Tables(0)

            If tabela.Rows.Count > 0 Then
                Dgv.DataSource = Nothing
                Dgv.DataSource = ds.Tables(0)
                'formatarGrid()
            End If
            carregaFormulario()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub BtnGrid_Click(sender As Object, e As EventArgs) Handles BtnGrid.Click
        If TabControl1.SelectedIndex = 1 Then
            TabControl1.SelectedIndex = 0
        Else
            TabControl1.SelectedIndex = 1
        End If
    End Sub
    Private Sub BtnPrimeiroReg_Click(sender As Object, e As EventArgs) Handles BtnPrimeiroReg.Click
        'verificarAuteracao()
        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            carregaFormulario()
        End If

    End Sub
    Private Sub readOnlyTrue()
        TxbSeqFechamento.ReadOnly = True
        TxbCodigo.ReadOnly = True
        TxbDescricao.ReadOnly = True
        TxbCodOperador.ReadOnly = True
        TxbNomOperador.ReadOnly = True
        TxbDtaFechamento.ReadOnly = True
        TxbNumFechamento.ReadOnly = True
        TxbhraAbertura.ReadOnly = True
        TxbHraFechamento.ReadOnly = True
        TxbDiferenca.ReadOnly = True
        BtnDtaFinal.Enabled = False
        DtpDtaFechamento.Enabled = False
    End Sub
    Private Sub readOnlyFalse()
        TxbSeqFechamento.ReadOnly = False
        TxbCodigo.ReadOnly = False
        TxbDescricao.ReadOnly = False
        TxbCodOperador.ReadOnly = False
        TxbNomOperador.ReadOnly = False
        TxbDtaFechamento.ReadOnly = False
        TxbNumFechamento.ReadOnly = False
        TxbhraAbertura.ReadOnly = False
        TxbHraFechamento.ReadOnly = False
        TxbDiferenca.ReadOnly = False
        BtnDtaFinal.Enabled = True
        DtpDtaFechamento.Enabled = True
    End Sub
    Private Sub limpar()
        TxbSeqFechamento.Text = ""
        TxbCodigo.Text = ""
        TxbDescricao.Text = ""
        TxbCodOperador.Text = ""
        TxbNomOperador.Text = ""
        TxbDtaFechamento.Text = ""
        TxbNumFechamento.Text = ""
        TxbhraAbertura.Text = ""
        TxbHraFechamento.Text = ""
        TxbDiferenca.Text = ""

        dta_fechamento_old = ""
        dtaFinal = ""
        hra_abertura_old = ""
        hra_fechamento_old = ""
        seq_fechamento_old = 0
        cod_pdv_old = 0
        cod_operador_old = 0
        num_fechamento_old = 0
        BtnConferido.Enabled = False
        BtnExtornar.Enabled = False
        Dgv.DataSource = Nothing
        DgvNotas.DataSource = Nothing
        DgvPagNota.DataSource = Nothing
        DgvProdutos.DataSource = Nothing
        DgvRecebimento.DataSource = Nothing
        DgvSangria.DataSource = Nothing
        DgvServico.DataSource = Nothing
        DgvVenda.DataSource = Nothing
        readOnlyFalse()
        TabControl1.SelectedIndex = 0
    End Sub
    Public Sub carregaFormulario()
        Try

            If ds.Tables(0).Rows.Count > 0 Then
                readOnlyTrue()
                TxbSeqFechamento.Text = ds.Tables(0).Rows(i)("seq_fechamento").ToString
                TxbCodigo.Text = ds.Tables(0).Rows(i)("cod_pdv").ToString
                TxbDescricao.Text = ds.Tables(0).Rows(i)("des_pdv").ToString
                TxbCodOperador.Text = ds.Tables(0).Rows(i)("cod_operador").ToString
                TxbNomOperador.Text = ds.Tables(0).Rows(i)("nom_operador").ToString
                TxbDtaFechamento.Text = ds.Tables(0).Rows(i)("dta_fechamento").ToString
                TxbNumFechamento.Text = ds.Tables(0).Rows(i)("num_fechamento").ToString
                TxbhraAbertura.Text = ds.Tables(0).Rows(i)("hra_abertura").ToString
                TxbHraFechamento.Text = ds.Tables(0).Rows(i)("hra_fechamento").ToString
                If ds.Tables(0).Rows(i)("ind_status").ToString = "A" Then
                    carregaAberto()
                ElseIf ds.Tables(0).Rows(i)("ind_status").ToString = "F" Then
                    carregaFechado()
                ElseIf ds.Tables(0).Rows(i)("ind_status").ToString = "C" Then
                    carregaConferido()
                End If
            End If
            carregaPrincipal()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub carregaPrincipal()
        carregaRecebimento()
        carregaVendaTipo()
        calculaDiferenca()
    End Sub
    Private Sub carregaAberto()
        RbAberto.Checked = True
        BtnConferido.Enabled = False
        BtnExtornar.Enabled = False
    End Sub
    Private Sub carregaFechado()
        RbFechado.Checked = True
        BtnConferido.Enabled = True
        BtnExtornar.Enabled = False
    End Sub
    Private Sub carregaConferido()
        RbConferido.Checked = True
        BtnConferido.Enabled = False
        BtnExtornar.Enabled = True
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TrvFechamento.AfterSelect
        If TrvFechamento.SelectedNode.Name = "principal" Then
            TabControl1.SelectedIndex = 0
        ElseIf TrvFechamento.SelectedNode.Name = "produto" Then
            carregaProduto()
        ElseIf TrvFechamento.SelectedNode.Name = "servico" Then
            carregaServico()
        ElseIf TrvFechamento.SelectedNode.Name = "sangria" Then
            carregaSangria()
            If RbAberto.Checked = True Or RbFechado.Checked = True Then
                GroupBox6.Enabled = True
            ElseIf RbConferido.Checked = True Then
                GroupBox6.Enabled = False
            End If
        ElseIf TrvFechamento.SelectedNode.Name = "nota" Then
            carregaNotas()
        ElseIf TrvFechamento.SelectedNode.Name = "formaPagamento" Then
            carregaPagNota()
        End If
    End Sub

    Private Sub carregaPagNota()
        Dim ds As New DataSet
        Dim table As New DataTable
        Dim cls As New ClFechamentoCaixaPdv

        If TxbSeqFechamento.Text = "" Then
            Exit Sub
        End If
        Try
            ds = cls.notaFormaPagto(TxbSeqFechamento.Text)
            table = ds.Tables(0)
            If table.Rows.Count > 0 Then
                DgvPagNota.DataSource = ds.Tables(0)
            End If
            DgvPagNota.Columns(0).HeaderText = "Descrição"
            DgvPagNota.Columns(1).HeaderText = "Valor"
            DgvPagNota.Columns(0).Width = 200
            DgvPagNota.Columns(1).Width = 80
            DgvPagNota.Columns(1).DefaultCellStyle.Format = "N2"
            DgvPagNota.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Catch ex As Exception
        End Try
        TabControl1.SelectedIndex = 6
    End Sub
    Private Sub carregaNotas()

        Dim ds As New DataSet
        Dim table As New DataTable
        Dim cls As New ClFechamentoCaixaPdv

        If TxbSeqFechamento.Text = "" Then
            Exit Sub
        End If
        Try
            ds = cls.Notas(TxbSeqFechamento.Text)
            table = ds.Tables(0)
            If table.Rows.Count > 0 Then
                DgvNotas.DataSource = ds.Tables(0)
            End If

            DgvNotas.Columns(0).HeaderText = "Sequencia"
            DgvNotas.Columns(1).HeaderText = "Número"
            DgvNotas.Columns(2).HeaderText = "Cliente"
            DgvNotas.Columns(3).HeaderText = ""
            DgvNotas.Columns(4).HeaderText = "Emissão"
            DgvNotas.Columns(5).HeaderText = "Hora"
            DgvNotas.Columns(6).HeaderText = "Acrescimo"
            DgvNotas.Columns(7).HeaderText = "Desconto"
            DgvNotas.Columns(8).HeaderText = "Total"
            DgvNotas.Columns(0).Width = 60
            DgvNotas.Columns(1).Width = 60
            DgvNotas.Columns(2).Width = 40
            DgvNotas.Columns(3).Width = 100
            DgvNotas.Columns(4).Width = 60
            DgvNotas.Columns(5).Width = 50
            DgvNotas.Columns(6).Width = 60
            DgvNotas.Columns(7).Width = 60
            DgvNotas.Columns(8).Width = 60
            DgvNotas.Columns(6).DefaultCellStyle.Format = "N2"
            DgvNotas.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvNotas.Columns(7).DefaultCellStyle.Format = "N2"
            DgvNotas.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvNotas.Columns(8).DefaultCellStyle.Format = "N2"
            DgvNotas.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Catch ex As Exception

        End Try

        TabControl1.SelectedIndex = 5
    End Sub

    Private Sub carregaSangria()
        Dim ds As New DataSet
        Dim table As New DataTable
        Dim cls As New ClFechamentoCaixaPdv
        TxbSangriaValor.Text = ""
        TxbSangriaObs.Text = ""
        If TxbSeqFechamento.Text = "" Then
            Exit Sub
        End If
        Try
            ds = cls.sangria(TxbSeqFechamento.Text)
            table = ds.Tables(0)
            If table.Rows.Count > 0 Then
                DgvSangria.DataSource = ds.Tables(0)
            End If
            DgvSangria.Columns(0).HeaderText = "Descrição"
            DgvSangria.Columns(1).HeaderText = "Valor"
            DgvSangria.Columns(2).HeaderText = "Observação"
            DgvSangria.Columns(0).Width = 100
            DgvSangria.Columns(1).Width = 60
            DgvSangria.Columns(2).Width = 300
            DgvSangria.Columns(1).DefaultCellStyle.Format = "N2"
            DgvSangria.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Catch ex As Exception
        End Try
        TabControl1.SelectedIndex = 4
    End Sub
    Private Sub carregaProduto()

        Dim ds As New DataSet
        Dim table As New DataTable
        Dim cls As New ClFechamentoCaixaPdv

        If TxbSeqFechamento.Text = "" Then
            Exit Sub
        End If
        Try
            ds = cls.vendaProduto(TxbSeqFechamento.Text)
            table = ds.Tables(0)
            If table.Rows.Count > 0 Then
                DgvProdutos.DataSource = ds.Tables(0)
            End If

            DgvProdutos.Columns(0).HeaderText = "Cod.Barra"
            DgvProdutos.Columns(1).HeaderText = "Descrição"
            DgvProdutos.Columns(2).HeaderText = "Un."
            DgvProdutos.Columns(3).HeaderText = "Vl.Unitário"
            DgvProdutos.Columns(4).HeaderText = "Quantidade"
            DgvProdutos.Columns(5).HeaderText = "Vl.Bruto"
            DgvProdutos.Columns(6).HeaderText = "Vl.Desconto"
            DgvProdutos.Columns(7).HeaderText = "Vl.Acrescimo"
            DgvProdutos.Columns(8).HeaderText = "Vl.Liquido"
            DgvProdutos.Columns(0).Width = 50
            DgvProdutos.Columns(1).Width = 90
            DgvProdutos.Columns(2).Width = 30
            DgvProdutos.Columns(3).Width = 60
            DgvProdutos.Columns(4).Width = 60
            DgvProdutos.Columns(5).Width = 60
            DgvProdutos.Columns(6).Width = 60
            DgvProdutos.Columns(7).Width = 60
            DgvProdutos.Columns(8).Width = 60
            DgvProdutos.Columns(3).DefaultCellStyle.Format = "N2"
            DgvProdutos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvProdutos.Columns(4).DefaultCellStyle.Format = "N2"
            DgvProdutos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvProdutos.Columns(5).DefaultCellStyle.Format = "N2"
            DgvProdutos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvProdutos.Columns(6).DefaultCellStyle.Format = "N2"
            DgvProdutos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvProdutos.Columns(7).DefaultCellStyle.Format = "N2"
            DgvProdutos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvProdutos.Columns(8).DefaultCellStyle.Format = "N2"
            DgvProdutos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception

        End Try

        TabControl1.SelectedIndex = 2
    End Sub
    Private Sub carregaServico()
        Dim ds As New DataSet
        Dim table As New DataTable
        Dim cls As New ClFechamentoCaixaPdv

        TabControl1.SelectedIndex = 3
        If TxbSeqFechamento.Text = "" Then
            Exit Sub
        End If
        Try
            ds = cls.vendaServico(TxbSeqFechamento.Text)
            table = ds.Tables(0)
            If table.Rows.Count > 0 Then
                DgvServico.DataSource = ds.Tables(0)
            End If
            DgvServico.Columns(0).HeaderText = "Cod.Barra"
            DgvServico.Columns(1).HeaderText = "Descrição"
            DgvServico.Columns(2).HeaderText = "Un."
            DgvServico.Columns(3).HeaderText = "Vl.Unitário"
            DgvServico.Columns(4).HeaderText = "Quantidade"
            DgvServico.Columns(5).HeaderText = "Vl.Bruto"
            DgvServico.Columns(6).HeaderText = "Vl.Desconto"
            DgvServico.Columns(7).HeaderText = "Vl.Acrescimo"
            DgvServico.Columns(8).HeaderText = "Vl.Liquido"
            DgvServico.Columns(0).Width = 50
            DgvServico.Columns(1).Width = 90
            DgvServico.Columns(2).Width = 30
            DgvServico.Columns(3).Width = 60
            DgvServico.Columns(4).Width = 60
            DgvServico.Columns(5).Width = 60
            DgvServico.Columns(6).Width = 60
            DgvServico.Columns(7).Width = 60
            DgvServico.Columns(8).Width = 60
            DgvServico.Columns(3).DefaultCellStyle.Format = "N2"
            DgvServico.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvServico.Columns(4).DefaultCellStyle.Format = "N2"
            DgvServico.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvServico.Columns(5).DefaultCellStyle.Format = "N2"
            DgvServico.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvServico.Columns(6).DefaultCellStyle.Format = "N2"
            DgvServico.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvServico.Columns(7).DefaultCellStyle.Format = "N2"
            DgvServico.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvServico.Columns(8).DefaultCellStyle.Format = "N2"
            DgvServico.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception

        End Try
        TabControl1.SelectedIndex = 3
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        limpar()

    End Sub

    Private Sub BtnSangriaSalvar_Click(sender As Object, e As EventArgs) Handles BtnSangriaSalvar.Click
        If TxbSangriaValor.Text = "" Then
            MsgBox("Informe o valor da sangria!", MsgBoxStyle.Information, "Informação")
            TxbSangriaValor.Select()
            Exit Sub
        End If
        Dim sangria As New ClSangria
        sangria.val_sangria = TxbSangriaValor.Text
        sangria.des_observacao = TxbSangriaObs.Text
        sangria.seq_fechamento = TxbSeqFechamento.Text
        sangria.Cadastrar()
        If ModParametroSistema.erro Then
            ModParametroSistema.erro = False
            Exit Sub
        End If
        MsgBox("Sangria efetuada com sucesso!", MsgBoxStyle.OkOnly, "Sucesso")
        carregaSangria()
        carregaPrincipal()
        TxbSangriaObs.Text = ""
        TxbSangriaValor.Text = ""
    End Sub

    Private Sub BtnConferido_Click(sender As Object, e As EventArgs) Handles BtnConferido.Click
        resumoVenda.seq_fechamento = TxbSeqFechamento.Text
        fechaCaixa.seq_fechamento = TxbSeqFechamento.Text
        fechaCaixa.val_diferenca_caixa = TxbDiferenca.Text
        resumoVenda.Cadastrar()
        fechaCaixa.atualizarCaixaConferido()
        carregaConferido()
        If ModParametroSistema.erro Then
            ModParametroSistema.erro = False
            Exit Sub
        End If
        MsgBox(" Caixa confirmado com sucesso", MsgBoxStyle.Information, "Sucesso")
    End Sub

    Private Sub BtnExtornar_Click(sender As Object, e As EventArgs) Handles BtnExtornar.Click
        If MsgBox("Deseja extornar o caixa de sequencia:   " & TxbSeqFechamento.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                resumoVenda.seq_fechamento = TxbSeqFechamento.Text
                resumoVenda.Excluir()
                fechaCaixa.atualizarCaixaExtornar()
                carregaFechado()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Extornado com sucesso", MsgBoxStyle.Information, "Informação")
            Catch ex As Exception
                MsgBox("Erro ao extornar Caixa , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub calculaDiferenca()
        Try
            Dim fechaDif As New ClFechamentoCaixaPdv
            TxbDiferenca.Text = FormatNumber(fechaDif.Diferenca(TxbSeqFechamento.Text), 2).ToString
        Catch ex As Exception
        End Try
    End Sub
    Private Sub carregaRecebimento()
        Try
            Dim dsRecebimento As DataSet
            Dim tab As DataTable
            Dim fecha As New ClFechamentoCaixaPdv
            dsRecebimento = fecha.ConsultarRecebimento(TxbSeqFechamento.Text)
            tab = dsRecebimento.Tables(0)

            If tab.Rows.Count > 0 Then
                DgvRecebimento.DataSource = Nothing
                DgvRecebimento.DataSource = dsRecebimento.Tables(0)

            End If
            DgvRecebimento.Columns(0).HeaderText = "Descrição"
            DgvRecebimento.Columns(1).HeaderText = "Valor"
            DgvRecebimento.Columns(0).Width = 150
            DgvRecebimento.Columns(1).Width = 75
            DgvRecebimento.Columns(1).DefaultCellStyle.Format = "N2"
            DgvRecebimento.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception

        End Try
    End Sub
    Private Sub carregaVendaTipo()
        Try
            Dim dsVendaTipo As New DataSet
            Dim tab As DataTable
            Dim fecha As New ClFechamentoCaixaPdv
            dsVendaTipo = fecha.ConsultarVendaTipo(TxbSeqFechamento.Text)
            tab = dsVendaTipo.Tables(0)

            If tab.Rows.Count > 0 Then
                DgvVenda.DataSource = Nothing
                DgvVenda.DataSource = dsVendaTipo.Tables(0)

            End If
            DgvVenda.Columns(0).HeaderText = "Descrição"
            DgvVenda.Columns(1).HeaderText = "Valor"
            DgvVenda.Columns(0).Width = 150
            DgvVenda.Columns(1).Width = 75
            DgvVenda.Columns(1).DefaultCellStyle.Format = "N2"
            DgvVenda.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick

        Try
            TxbSeqFechamento.Text = Dgv.CurrentRow.Cells(0).Value
            TxbCodigo.Text = Dgv.CurrentRow.Cells(1).Value
            TxbDescricao.Text = Dgv.CurrentRow.Cells(2).Value
            TxbCodOperador.Text = Dgv.CurrentRow.Cells(3).Value
            TxbNomOperador.Text = Dgv.CurrentRow.Cells(4).Value
            TxbDtaFechamento.Text = Dgv.CurrentRow.Cells(5).Value
            TxbNumFechamento.Text = Dgv.CurrentRow.Cells(6).Value
            TxbhraAbertura.Text = Dgv.CurrentRow.Cells(7).Value
            TxbHraFechamento.Text = Dgv.CurrentRow.Cells(8).Value
            If (Dgv.CurrentRow.Cells(9).Value) = "A" Then
                RbAberto.Checked = True
                BtnConferido.Enabled = False
                BtnExtornar.Enabled = False
            ElseIf (Dgv.CurrentRow.Cells(9).Value) = "F" Then
                RbFechado.Checked = True
                BtnConferido.Enabled = True
                BtnExtornar.Enabled = False
            ElseIf (Dgv.CurrentRow.Cells(9).Value) = "C" Then
                RbConferido.Checked = True
                BtnConferido.Enabled = False
                BtnExtornar.Enabled = True
            End If
            TabControl1.SelectedIndex = 0
            carregaRecebimento()
            carregaVendaTipo()
            calculaDiferenca()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        'verificarAuteracao()

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
        ' verificarAuteracao()

        If ds.Tables(0).Rows.Count > 0 Then
            i = ds.Tables(0).Rows.Count - 1
        End If
        carregaFormulario()
    End Sub
    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        '  verificarAuteracao()

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
End Class
