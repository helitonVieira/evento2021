Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms
Public Class FrmItem

    Dim conectar As New Controles.ConexaoSQL
    Dim ds, dsUltimo, dsItemFornecedor, dsPrecoVenda, dsCodigoBarra As New DataSet
    Dim item, item2 As New ClItem
    Dim itemFornecedor, itemFornecedor2 As New ClItemFornecedor
    Dim itemPrecoVenda, itemPrecoVenda2 As New ClItemPrecoVenda
    Dim itemCodigoBarra, itemCodigoBarra2 As New ClItemCodigoBarra
    Dim geral As New ClGeral
    Dim atualizar As Integer = 1
    Dim atualizarFornecedor As Integer = 1
    Dim atualizarPrecoVenda As Integer = 1
    Dim atualizarCodigoBarra As Integer = 1
    Dim cod_item_old, nom_item_old, cod_subcategoria_old, des_subcategoria_old,
            cod_barra_old, cod_referencia_old, cod_unidade_old, des_unidade_old,
            ind_tipo_old, qtd_estoque_minimo_old, qtd_estoque_maximo_old, cod_marca_old, des_marca_old, ind_ativo_old As String
    Dim i As Integer = 0
    Dim frmPesquisa As New FrmPesquisa

    Private Sub BtnPesquisaSubcategoria_Click(sender As Object, e As EventArgs) Handles BtnPesquisaSubcategoria.Click
        frmPesquisa.tabela = "tab_subcategoria_item"
        frmPesquisa.ShowDialog()
        txbCodSubcategoria.Text = ModVariavelGlobal.pesquisaCodigo
        TxbDesSubcategoria.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnPesquisaUnidade_Click(sender As Object, e As EventArgs) Handles BtnPesquisaUnidade.Click
        frmPesquisa.tabela = "tab_unidade"
        frmPesquisa.ShowDialog()
        TxbCodUnidade.Text = ModVariavelGlobal.pesquisaCodigo
        TxbDesUnidade.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub TxbPesquisaMarca_Click(sender As Object, e As EventArgs) Handles TxbPesquisaMarca.Click
        frmPesquisa.tabela = "tab_marca"
        frmPesquisa.ShowDialog()
        TxbCodMarca.Text = ModVariavelGlobal.pesquisaCodigo
        TxbDesMarca.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub
    Private Sub BtnPrincipal_Click(sender As Object, e As EventArgs) Handles BtnPrincipal.Click
        TabControl1.SelectedIndex = 0
        TxbCodigo.Select()
        BloqueiaBotaoSalvaPrincipal(True)
    End Sub
    Private Sub BloqueiaBotaoSalvaPrincipal(habilita As String)
        If habilita = False Then
            BtnExcluir.Enabled = False
            BtnSalvar.Enabled = False
            'BtnLimpar.Enabled = False
            BtnPesquisa.Enabled = False
        Else
            BtnExcluir.Enabled = True
            BtnSalvar.Enabled = True
            'BtnLimpar.Enabled = True
            BtnPesquisa.Enabled = True
        End If
    End Sub
    Private Sub BtnFornecedor_Click(sender As Object, e As EventArgs) Handles BtnFornecedor.Click
        TabControl1.SelectedIndex = 4
        DgvFornecedor.DataSource = Nothing
        TxbCodFornecedor.Select()
        BloqueiaBotaoSalvaPrincipal(False)
        atualizaDadosFornecedor()
        limparFornecedor()
        BtnPrincipal.Enabled = True
    End Sub
    Private Sub BtnPlanejamento_Click(sender As Object, e As EventArgs) Handles BtnPlanejamento.Click
        TabControl1.SelectedIndex = 3
        TxbEstoqueMin.Select()
        BtnPrincipal.Enabled = True
        BloqueiaBotaoSalvaPrincipal(True)
    End Sub

    Private Sub BtnCodBarra_Click(sender As Object, e As EventArgs) Handles BtnCodBarra.Click
        TabControl1.SelectedIndex = 5
        DgvCodBarra.DataSource = Nothing
        TxbCodBarraBarra.Select()
        BloqueiaBotaoSalvaPrincipal(False)
        atualizaDadosCodigoBarra()
        limparCodigoBarra()
        BtnPrincipal.Enabled = True
    End Sub

    Private Sub BtnPrecoVenda_Click(sender As Object, e As EventArgs) Handles BtnPrecoVenda.Click
        TabControl1.SelectedIndex = 2
        DgvPrecoVenda.DataSource = Nothing
        TxbDtaInicio.Select()
        BloqueiaBotaoSalvaPrincipal(False)
        BtnPrincipal.Enabled = True
        atualizaDadosPrecoVendario()
        limparPrecoVenda()
    End Sub

    Private Sub DtpDtaNasc_TextChanged(sender As Object, e As EventArgs) Handles DtpDtaInicio.TextChanged
        TxbDtaInicio.Text = DtpDtaInicio.Value
    End Sub

    Private Sub Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t120105 = False Then
                MsgBox("Usuário sem permissão para acessar a Item!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
            BtnSalvar.Enabled = ModPermissaoUsuario.t1201051
            BtnExcluir.Enabled = ModPermissaoUsuario.t1201052
        End If
        limpar()
        'Me.Width = Me.Width + 200
        tab_control1Selelct()
        Dgv.DataSource = Nothing
        CkbAtivo.Checked = True
        GroupBox2.Enabled = True
        BtnFornecedor.Enabled = False
        BtnPrecoVenda.Enabled = False
        BtnPrincipal.Enabled = False
        BtnCodBarra.Enabled = False
        BtnPlanejamento.Enabled = False
    End Sub
    Public Sub tab_control1Selelct()
        TabControl1.SelectedIndex = 0
        'Me.Height = 320
        TxbDescricao.Select()
    End Sub
    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click

        carrega_old()
        atualizaDados()

    End Sub

    Public Sub carrega_old()

        cod_item_old = TxbCodigo.Text
        nom_item_old = TxbDescricao.Text
        cod_subcategoria_old = txbCodSubcategoria.Text
        des_subcategoria_old = TxbDesSubcategoria.Text
        cod_barra_old = txbCodBarra.Text
        cod_referencia_old = txbReferencia.Text
        cod_referencia_old = txbReferencia.Text
        cod_unidade_old = TxbCodUnidade.Text
        des_unidade_old = TxbDesUnidade.Text

        If CbTipoItem.Text = "PRODUTO" Then
            ind_tipo_old = "P"
        ElseIf CbTipoItem.Text = "SERVICO" Then
            ind_tipo_old = "S"
        ElseIf CbTipoItem.Text = "INSUMO" Then
            ind_tipo_old = "I"
        Else
            ind_tipo_old = ""
        End If

        qtd_estoque_minimo_old = TxbEstoqueMin.Text
        qtd_estoque_maximo_old = TxbEstoqueMax.Text
        cod_marca_old = TxbCodMarca.Text
        des_marca_old = TxbDesMarca.Text
        If CkbAtivo.Checked = True Then
            ind_ativo_old = "S"
        Else
            ind_ativo_old = "N"
        End If

    End Sub
    Public Sub atualizaDados()
        Try

            Dim tabela As DataTable
            ds = item.Consultar(cod_item_old, nom_item_old, cod_subcategoria_old, cod_barra_old,
                                       cod_referencia_old, cod_unidade_old, ind_tipo_old, qtd_estoque_minimo_old,
                                      qtd_estoque_maximo_old, cod_marca_old, ind_ativo_old)
            tabela = ds.Tables(0)

            If tabela.Rows.Count > 0 Then
                Dgv.DataSource = Nothing
                Dgv.DataSource = ds.Tables(0)
                formatarGrid()
                carregaFormulario()


            End If
        Catch ex As Exception
            MsgBox(" Erro", ex.Message & " " & MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaRegistro()
    End Sub
    Public Sub salvaRegistro()
        Try
            If TxbDescricao.Text = "" Then
                MsgBox("INFORME DESCRIÇÃO")
                TxbDescricao.Select()
                Exit Sub
            End If
            If txbCodSubcategoria.Text = "" Then
                MsgBox("INFORME SUBCATEGORIA")
                txbCodSubcategoria.Select()
                Exit Sub
            End If

            If TxbCodUnidade.Text = "" Then
                MsgBox("INFORME UNIDADE")
                TxbCodUnidade.Select()
                Exit Sub
            End If
            'P PRODUTO, I INSUMO , S SERVICO
            If CbTipoItem.Text = "" Then
                ind_tipo_old = "P"
            End If
            If TxbCodMarca.Text = "" Then
                item.cod_marca = Nothing
            Else
                item.cod_marca = TxbCodMarca.Text
            End If
            carrega_old()

            item.des_item = nom_item_old
            item.cod_subcategoria = cod_subcategoria_old

            item.cod_referencia = cod_referencia_old
            item.cod_unidade = cod_unidade_old
            item.ind_tipo = ind_tipo_old
            If qtd_estoque_minimo_old = "" Then
                item.qtd_estoque_minimo = "0"
            Else
                item.qtd_estoque_minimo = qtd_estoque_minimo_old
            End If
            If qtd_estoque_maximo_old = "" Then
                item.qtd_estoque_maximo = "0"
            Else
                item.qtd_estoque_maximo = qtd_estoque_maximo_old
            End If


            item.ind_ativo = ind_ativo_old


            If atualizar = 1 Then
                'pegar o ultimo registro
                Try
                    Dim ultimo As New DataSet
                    ultimo = item2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    item.cod_item = Convert.ToInt16(ult) + 1

                    ultimo.Clear()
                Catch ex As Exception
                    item.cod_item = 1
                End Try
                If txbCodBarra.Text = "" Then
                    item.cod_barra = item.cod_item
                Else
                    item.cod_barra = cod_barra_old
                End If
                Try
                    item.Cadastrar()
                    TxbCodigo.Text = item.cod_item
                    If ModParametroSistema.erro Then
                        ModParametroSistema.erro = False
                        Exit Sub
                    End If
                    MsgBox(" cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                Catch ex As Exception
                    MsgBox(" Erro ao cadastrado", ex.Message &" "& MsgBoxStyle.Critical, "Erro")
                    Exit Sub
                End Try


            Else
                item.cod_item = TxbCodigo.Text
                If txbCodBarra.Text = "" Then
                    item.cod_barra = item.cod_item
                Else
                    item.cod_barra = cod_barra_old
                End If
                i = 0
                item.Atualizar()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            End If
            i = 0
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
            Exit Sub
        End Try
        atualizaDados()
    End Sub

    Private Sub BtnExcluir_Click_1(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir o item:   " & TxbCodigo.Text & "  " & TxbDescricao.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                item.cod_item = TxbCodigo.Text
                item.Excluir()
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
        BloqueiaBotaoSalvaPrincipal("True")
        Dgv.DataSource = Nothing
        TxbCodigo.Enabled = True
        TabControl1.SelectedIndex = 0
        TxbCodigo.Select()
        BtnFornecedor.Enabled = False
        BtnPrecoVenda.Enabled = False
        BtnPrincipal.Enabled = False
        BtnCodBarra.Enabled = False
        BtnPlanejamento.Enabled = False
    End Sub
    Public Sub limpar()
        TxbCodigo.Text = ""
        TxbDescricao.Text = ""
        txbCodSubcategoria.Text = ""
        TxbDesSubcategoria.Text = ""
        txbCodBarra.Text = ""
        txbReferencia.Text = ""
        TxbCodUnidade.Text = ""
        TxbDesUnidade.Text = ""
        CbTipoItem.Text = "PRODUTO"
        TxbEstoqueMin.Text = ""
        TxbEstoqueMax.Text = ""
        TxbCodMarca.Text = ""
        TxbDesMarca.Text = ""
        CkbAtivo.Checked = True
        carrega_old()

        atualizar = 1
    End Sub
    Public Sub formatarGrid()
        Try
            With Dgv
                .Columns(0).HeaderText = "Código"
                .Columns(1).HeaderText = "Descrição"
                .Columns(2).HeaderText = "Cód.SubCategoria"
                .Columns(3).HeaderText = "Subcategoria"
                .Columns(4).HeaderText = "Cód.Barra"
                .Columns(5).HeaderText = "Referência"
                .Columns(6).HeaderText = "Cód.Unidade"
                .Columns(7).HeaderText = "Des.Unidade"
                .Columns(8).HeaderText = "Tipo"
                .Columns(9).HeaderText = "Estoque Mínimo"
                .Columns(10).HeaderText = "Estoque Máximo"
                .Columns(11).HeaderText = "Cód.Marca"
                .Columns(12).HeaderText = "Marca"
                .Columns(13).HeaderText = "Ativo"
                .Columns(0).Width = 40
                .Columns(1).Width = 150
                .Columns(2).Width = 40
                .Columns(3).Width = 150
                .Columns(4).Width = 40
                .Columns(5).Width = 150
                .Columns(6).Width = 40
                .Columns(7).Width = 150
                .Columns(8).Width = 40
                .Columns(9).Width = 150
                .Columns(10).Width = 40
                .Columns(11).Width = 150
                .Columns(12).Width = 150
                .Columns(13).Width = 30

            End With

        Catch ex As Exception

        End Try
    End Sub


    Public Sub carregaFormulario()
        Try
            limpar()
            If ds.Tables(0).Rows.Count > 0 Then
                atualizar = 2
                TxbCodigo.Text = ds.Tables(0).Rows(i)("cod_item").ToString
                TxbDescricao.Text = ds.Tables(0).Rows(i)("des_item").ToString
                txbCodSubcategoria.Text = ds.Tables(0).Rows(i)("cod_subcategoria").ToString
                TxbDesSubcategoria.Text = ds.Tables(0).Rows(i)("des_subcategoria").ToString
                txbCodBarra.Text = ds.Tables(0).Rows(i)("cod_barra").ToString

                txbReferencia.Text = ds.Tables(0).Rows(i)("cod_referencia").ToString
                TxbCodUnidade.Text = ds.Tables(0).Rows(i)("cod_unidade").ToString
                TxbDesUnidade.Text = ds.Tables(0).Rows(i)("des_unidade").ToString
                If ds.Tables(0).Rows(i)("ind_tipo").ToString = "P" Then
                    CbTipoItem.Text = "PRODUTO"
                ElseIf ds.Tables(0).Rows(i)("ind_tipo").ToString = "S" Then
                    CbTipoItem.Text = "SERVICO"
                ElseIf ds.Tables(0).Rows(i)("ind_tipo").ToString = "I" Then
                    CbTipoItem.Text = "INSUMO"
                End If
                TxbEstoqueMin.Text = FormatNumber(Convert.ToDouble(ds.Tables(0).Rows(i)("qtd_estoque_minimo").ToString), 2)
                TxbEstoqueMax.Text = FormatNumber(Convert.ToDouble(ds.Tables(0).Rows(i)("qtd_estoque_maximo").ToString), 2)
                If ds.Tables(0).Rows(i)("cod_marca").ToString <> "0" Then
                    TxbCodMarca.Text = ds.Tables(0).Rows(i)("cod_marca").ToString
                    TxbDesMarca.Text = ds.Tables(0).Rows(i)("des_marca").ToString
                End If
                If ds.Tables(0).Rows(i)("ind_ativo").ToString = "S" Then
                    CkbAtivo.Checked = True
                Else
                    CkbAtivo.Checked = False
                End If

                TxbCodigo.Enabled = False
            Else
                atualizar = 1
                TxbCodigo.Enabled = True
            End If

            carrega_old()

            BtnFornecedor.Enabled = True
            BtnPrecoVenda.Enabled = True
            BtnCodBarra.Enabled = True
            BtnPlanejamento.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub verificarAuteracao()
        Dim msg As String = ""
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        If nom_item_old <> TxbDescricao.Text Then
            msg = "Descrição Seção" & vbCrLf & "Anterior: " & nom_item_old & vbCrLf & " Nova : " & TxbDescricao.Text
        End If
        If cod_subcategoria_old <> txbCodSubcategoria.Text Then
            msg = msg & vbCrLf & "Almoxarifado" & vbCrLf & "Anterior: " & cod_subcategoria_old & vbCrLf & " Nova : " & txbCodSubcategoria.Text & " " & TxbDesSubcategoria.Text
        End If
        If cod_referencia_old <> txbReferencia.Text Then
            msg = "Cod.Referência" & vbCrLf & "Anterior: " & cod_referencia_old & vbCrLf & " Nova : " & txbReferencia.Text
        End If
        If cod_unidade_old <> TxbCodUnidade.Text Then
            msg = msg & vbCrLf & "Especie" & vbCrLf & "Anterior: " & cod_unidade_old & vbCrLf & " Nova : " & TxbCodUnidade.Text & " " & TxbDesUnidade.Text
        End If
        Dim tipo As String
        If CbTipoItem.Text = "PRODUTO" Then
            tipo = "P"
        ElseIf CbTipoItem.Text = "INSUMO" Then
            tipo = "I"
        ElseIf CbTipoItem.Text = "SERVICO" Then
            tipo = "S"

        End If
        If ind_tipo_old <> tipo Then
            msg = msg & vbCrLf & "Tipo Item" & vbCrLf & "Anterior: " & ind_tipo_old & vbCrLf & " Nova : " & CbTipoItem.Text
        End If
        If qtd_estoque_minimo_old <> "" Then
            If FormatNumber(Convert.ToDouble(qtd_estoque_minimo_old), 2) <> FormatNumber(Convert.ToDouble(TxbEstoqueMin.Text), 2) Then
                msg = msg & vbCrLf & "Estoque Mínimo" & vbCrLf & "Anterior: " & qtd_estoque_minimo_old & vbCrLf & " Nova : " & TxbEstoqueMin.Text
            End If
        End If
        If qtd_estoque_maximo_old <> "" Then
            If FormatNumber(Convert.ToDouble(qtd_estoque_maximo_old), 2) <> FormatNumber(Convert.ToDouble(TxbEstoqueMax.Text), 2) Then
                msg = msg & vbCrLf & "Estoque Máximo" & vbCrLf & "Anterior: " & qtd_estoque_maximo_old & vbCrLf & " Nova : " & TxbEstoqueMax.Text
            End If
        End If
        If (cod_marca_old <> TxbCodMarca.Text) And (TxbCodMarca.Text = "" And cod_marca_old <> "0") Then
            msg = msg & vbCrLf & "Marca" & vbCrLf & "Anterior: " & cod_marca_old & vbCrLf & " Nova : " & TxbCodMarca.Text
        End If
        If (ind_ativo_old = "S" And CkbAtivo.Checked = False) Or (ind_ativo_old = "N" And CkbAtivo.Checked = True) Then
            msg = msg & vbCrLf & "Ind.Ativo"
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
            ' Me.Height = 162
        Else
            TabControl1.SelectedIndex = 1
            '  Me.Height = 322
        End If
    End Sub
    Private Sub BtnPrimeiroReg_Click(sender As Object, e As EventArgs) Handles BtnPrimeiroReg.Click
        verificarAuteracao()
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                i = 0
                carregaFormulario()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        verificarAuteracao()
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
        verificarAuteracao()
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                i = ds.Tables(0).Rows.Count - 1
            End If
        Catch ex As Exception
        End Try
        carregaFormulario()
    End Sub
    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        verificarAuteracao()
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

    Private Sub Dgv_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellEnter
        i = Dgv.CurrentRow.Index
        carregaFormulario()
    End Sub
    '#####################################################
    'FORNECEDOR
    '####################################################

    Private Sub DgvFornecedor_DoubleClick(sender As Object, e As EventArgs) Handles DgvFornecedor.DoubleClick
        Try
            LbSeqFornecedor.Text = DgvFornecedor.CurrentRow.Cells(0).Value
            Me.TxbCodFornecedor.Text = DgvFornecedor.CurrentRow.Cells(1).Value
            Me.TxbNomFornecedor.Text = DgvFornecedor.CurrentRow.Cells(2).Value
            Me.TxbCodBarraForn.Text = DgvFornecedor.CurrentRow.Cells(3).Value
            Me.TxbReferenciaForn.Text = DgvFornecedor.CurrentRow.Cells(4).Value.ToString
            Me.TxbCodFornecedor.Select()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub BtnPesquisaFornecedor_Click(sender As Object, e As EventArgs) Handles BtnPesquisaFornecedor.Click
        frmPesquisa.tabela = "tab_pessoa_fornecedor"
        frmPesquisa.ShowDialog()
        TxbCodFornecedor.Text = ModVariavelGlobal.pesquisaCodigo
        TxbNomFornecedor.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Public Sub atualizaDadosFornecedor()
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        Try
            Dim tabela As DataTable
            dsItemFornecedor = itemFornecedor.Consultar(TxbCodigo.Text)
            tabela = dsItemFornecedor.Tables(0)

            If tabela.Rows.Count > 0 Then
                DgvFornecedor.DataSource = Nothing
                DgvFornecedor.DataSource = dsItemFornecedor.Tables(0)
                formatarGridFornecedor()
                carregaFormularioFornecedor()

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnSalvaFornecedor_Click(sender As Object, e As EventArgs) Handles BtnSalvaForn.Click
        salvaRegistroFornecedor()
        limparFornecedor()
    End Sub
    Public Sub salvaRegistroFornecedor()
        Try
            If TxbCodigo.Text = "" Then
                MsgBox("CODIGO DO ITEM INVALIDO")
                TabControl1.SelectedIndex = 0
                TxbCodigo.Select()
                Exit Sub
            End If

            If TxbCodFornecedor.Text = "" Then
                MsgBox("INFORME FORNECEDOR")
                TxbCodFornecedor.Select()
                Exit Sub
            End If

            itemFornecedor.cod_pessoa_fornecedor = TxbCodFornecedor.Text
            itemFornecedor.cod_item = TxbCodigo.Text
            itemFornecedor.cod_barra = TxbCodBarraForn.Text
            itemFornecedor.cod_referencia = TxbReferenciaForn.Text


            If atualizarFornecedor = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                Try
                    ultimo = itemFornecedor2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    itemFornecedor.seq_item_fornecedor = Convert.ToInt16(ult) + 1

                    itemFornecedor.Cadastrar()
                    ultimo.Clear()
                Catch ex As Exception
                    itemFornecedor.seq_item_fornecedor = 1
                End Try
                MsgBox(" Cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            Else
                itemFornecedor.seq_item_fornecedor = LbSeqFornecedor.Text
                itemFornecedor.Atualizar()
                MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
        atualizaDadosFornecedor()
    End Sub
    Private Sub BtnExcluirFornecedor_Click(sender As Object, e As EventArgs) Handles BtnExcluiForn.Click
        If LbSeqFornecedor.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a :   " & TxbCodFornecedor.Text & " Data:" & TxbCodBarraForn.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                itemFornecedor.seq_item_fornecedor = LbSeqFornecedor.Text
                itemFornecedor.Excluir()
                MsgBox(" Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDadosFornecedor()
                limparFornecedor()
            Catch ex As Exception
                MsgBox("Erro ao excluir , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub
    Public Sub limparFornecedor()
        TxbCodFornecedor.Text = ""
        TxbNomFornecedor.Text = ""
        TxbCodBarraForn.Text = ""
        TxbReferenciaForn.Text = ""
        LbSeqFornecedor.Text = ""

        atualizarFornecedor = 1
    End Sub
    Private Sub BtnLimpaFornecedor_Click(sender As Object, e As EventArgs) Handles BtnLimpaForn.Click
        limparFornecedor()
    End Sub

    Private Sub BtnPesquisaUnidadeBarra_Click(sender As Object, e As EventArgs) Handles BtnPesquisaUnidadeBarra.Click
        frmPesquisa.tabela = "tab_unidade"
        frmPesquisa.ShowDialog()
        TxbUnidadeBarra.Text = ModVariavelGlobal.pesquisaCodigo
        TxbDesUnidadeBarra.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnCadSubCategoria_Click(sender As Object, e As EventArgs) Handles BtnCadSubCategoria.Click
        FrmSubCategoria.Show()
        FrmSubCategoria.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BtnCadUnidade_Click(sender As Object, e As EventArgs) Handles BtnCadUnidade.Click
        FrmUnidade.Show()
        FrmUnidade.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BtnCadMarca_Click(sender As Object, e As EventArgs) Handles BtnCadMarca.Click
        FrmMarca.Show()
        FrmMarca.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BtnCadFornecedor_Click(sender As Object, e As EventArgs) Handles BtnCadFornecedor.Click
        FrmPessoa.Show()
        FrmPessoa.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        Try
            Me.TxbCodigo.Text = Dgv.CurrentRow.Cells(0).Value
            Me.TxbDescricao.Text = Dgv.CurrentRow.Cells(1).Value
            Me.txbCodSubcategoria.Text = Dgv.CurrentRow.Cells(2).Value
            Me.TxbDesSubcategoria.Text = Dgv.CurrentRow.Cells(3).Value
            Me.txbCodBarra.Text = Dgv.CurrentRow.Cells(4).Value


            txbReferencia.Text = Dgv.CurrentRow.Cells(5).Value
            TxbCodUnidade.Text = Dgv.CurrentRow.Cells(6).Value
            TxbDesUnidade.Text = Dgv.CurrentRow.Cells(7).Value
            If Dgv.CurrentRow.Cells(8).Value = "P" Then
                CbTipoItem.Text = "PRODUTO"
            ElseIf Dgv.CurrentRow.Cells(8).Value = "S" Then
                CbTipoItem.Text = "SERVICO"
            ElseIf Dgv.CurrentRow.Cells(8).Value = "I" Then
                CbTipoItem.Text = "INSUMO"
            End If
            CbTipoItem.Text = Dgv.CurrentRow.Cells(8).Value
            TxbEstoqueMin.Text = Dgv.CurrentRow.Cells(9).Value
            TxbEstoqueMax.Text = Dgv.CurrentRow.Cells(10).Value
            If IsNumeric(Dgv.CurrentRow.Cells(11).Value) = False Then
                TxbCodMarca.Text = ""
            Else
                TxbCodMarca.Text = Dgv.CurrentRow.Cells(11).Value
            End If

            If IsDBNull(Dgv.CurrentRow.Cells(12).Value) = True Then
                TxbDesMarca.Text = ""
            Else
                TxbDesMarca.Text = Dgv.CurrentRow.Cells(12).Value
            End If

            If Dgv.CurrentRow.Cells(13).Value.ToString = "S" Then
                CkbAtivo.Checked = True
            Else
                CkbAtivo.Checked = False
            End If
            carrega_old()
            TabControl1.SelectedIndex = 0

            Me.TxbDescricao.Select()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub TxbCodigo_LostFocus(sender As Object, e As EventArgs) Handles TxbCodigo.LostFocus
        If TxbCodigo.Text <> "" And IsNumeric(TxbCodigo.Text) Then
            carrega_old()
            atualizaDados()
            'TxbDescricao.Text = geral.sqlBuscaDescricao("des_item", "tab_item", "cod_item", TxbCodigo.Text)
        End If
    End Sub
    Private Sub txbCodSubcategoria_LostFocus(sender As Object, e As EventArgs) Handles txbCodSubcategoria.LostFocus
        If txbCodSubcategoria.Text <> "" And IsNumeric(txbCodSubcategoria.Text) Then
            TxbDesSubcategoria.Text = geral.sqlBuscaDescricao("des_subcategoria", "tab_subcategoria_item", "cod_subcategoria", txbCodSubcategoria.Text)
        End If
    End Sub
    Private Sub TxbCodUnidade_LostFocus(sender As Object, e As EventArgs) Handles TxbCodUnidade.LostFocus
        If TxbCodUnidade.Text <> "" And IsNumeric(TxbCodUnidade.Text) Then
            TxbDesUnidade.Text = geral.sqlBuscaDescricao("des_unidade", "tab_unidade", "cod_unidade", TxbCodUnidade.Text)
        End If
    End Sub
    Private Sub TxbCodMarca_LostFocus(sender As Object, e As EventArgs) Handles TxbCodMarca.LostFocus
        If TxbCodMarca.Text <> "" And IsNumeric(TxbCodMarca.Text) Then
            TxbDesMarca.Text = geral.sqlBuscaDescricao("des_marca", "tab_marca", "cod_marca", TxbCodMarca.Text)
        End If
    End Sub

    Public Sub formatarGridFornecedor()
        Try
            With DgvFornecedor
                .Columns(0).HeaderText = "Seq."
                .Columns(1).HeaderText = "Cod."
                .Columns(2).HeaderText = "Nome"
                .Columns(3).HeaderText = "Cód.Barra"
                .Columns(4).HeaderText = "Referência"

                .Columns(0).Width = 40
                .Columns(1).Width = 50
                .Columns(2).Width = 180
                .Columns(3).Width = 75
                .Columns(4).Width = 75
                .Columns(0).Visible = False
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub carregaFormularioFornecedor()
        Try
            limparFornecedor()
            If dsItemFornecedor.Tables(0).Rows.Count > 0 Then
                atualizarFornecedor = 2
                LbSeqFornecedor.Text = dsItemFornecedor.Tables(0).Rows(i)("seq_item_fornecedor").ToString
                TxbCodFornecedor.Text = dsItemFornecedor.Tables(0).Rows(i)("cod_pessoa_fornecedor").ToString
                TxbNomFornecedor.Text = dsItemFornecedor.Tables(0).Rows(i)("nom_pessoa").ToString
                TxbCodBarraForn.Text = dsItemFornecedor.Tables(0).Rows(i)("cod_barra").ToString
                TxbReferenciaForn.Text = dsItemFornecedor.Tables(0).Rows(i)("cod_referencia").ToString
            Else
                atualizar = 1
            End If
        Catch ex As Exception
        End Try
    End Sub
    '****************************************************
    'PRECO DE VENDA
    '****************************************************
    Private Sub DgvPrecoVenda_DoubleClick(sender As Object, e As EventArgs) Handles DgvPrecoVenda.DoubleClick
        Try
            LbSeqPrecoVenda.Text = DgvPrecoVenda.CurrentRow.Cells(0).Value
            Me.TxbDtaInicio.Text = DgvPrecoVenda.CurrentRow.Cells(1).Value
            Me.TxbPrecoA.Text = DgvPrecoVenda.CurrentRow.Cells(2).Value
            Me.TxbPrecoB.Text = DgvPrecoVenda.CurrentRow.Cells(3).Value
            Me.TxbPrecoC.Text = DgvPrecoVenda.CurrentRow.Cells(4).Value
            Me.TxbPrecoD.Text = DgvPrecoVenda.CurrentRow.Cells(5).Value
            Me.TxbDtaInicio.Select()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DtpDtaInicio_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaInicio.ValueChanged
        TxbDtaInicio.Text = DtpDtaInicio.Value.ToShortDateString
    End Sub

    Public Sub atualizaDadosPrecoVendario()
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        Try
            Dim tabela As DataTable
            dsPrecoVenda = itemPrecoVenda.Consultar(TxbCodigo.Text)
            tabela = dsPrecoVenda.Tables(0)

            If tabela.Rows.Count > 0 Then
                DgvPrecoVenda.DataSource = Nothing
                DgvPrecoVenda.DataSource = dsPrecoVenda.Tables(0)
                formatarGridPrecoVendario()
                carregaFormularioPrecoVendario()

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnSalvaPrecoVenda_Click(sender As Object, e As EventArgs) Handles BtnSalvaPreco.Click
        salvaRegistroPrecoVendario()
        limparPrecoVenda()
    End Sub
    Public Sub salvaRegistroPrecoVendario()
        Try
            If TxbCodigo.Text = "" Then
                MsgBox("CODIGO DO ITEM INVALIDO")
                Exit Sub
            End If
            If TxbPrecoA.Text = "" Then
                MsgBox("INFORME PREÇO A")
                TxbPrecoA.Select()
                Exit Sub
            End If
            If TxbDtaInicio.Text = "" Then
                MsgBox("INFORME DATA")
                TxbDtaInicio.Select()
                Exit Sub
            End If
            itemPrecoVenda.cod_empresa = ModParametroSistema.cod_empresa
            itemPrecoVenda.cod_item = TxbCodigo.Text
            itemPrecoVenda.dta_inicio = TxbDtaInicio.Text
            itemPrecoVenda.val_preco_a = TxbPrecoA.Text
            If TxbPrecoB.Text = "" Then
                itemPrecoVenda.val_preco_b = "0"
            Else
                itemPrecoVenda.val_preco_b = TxbPrecoB.Text
            End If

            If TxbPrecoC.Text = "" Then
                itemPrecoVenda.val_preco_c = "0"
            Else
                itemPrecoVenda.val_preco_c = TxbPrecoC.Text
            End If
            If TxbPrecoD.Text = "" Then
                itemPrecoVenda.val_preco_d = "0"
            Else
                itemPrecoVenda.val_preco_d = TxbPrecoD.Text
            End If
            itemPrecoVenda.cod_pessoa = Nothing
            itemPrecoVenda.cod_forma_pagamento = Nothing
            If atualizarPrecoVenda = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                Try
                    ultimo = itemPrecoVenda2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    itemPrecoVenda.seq_preco_venda = Convert.ToInt16(ult) + 1
                Catch ex As Exception
                    itemPrecoVenda.seq_preco_venda = 1
                End Try
                itemPrecoVenda.Cadastrar()
                ultimo.Clear()
                MsgBox(" Preço Venda Cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            Else
                itemPrecoVenda.seq_preco_venda = LbSeqPrecoVenda.Text
                itemPrecoVenda.Atualizar()
                MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
        atualizaDadosPrecoVendario()
    End Sub
    Private Sub BtnExcluirVenda_Click(sender As Object, e As EventArgs) Handles BtnExcluirVenda.Click
        If LbSeqPrecoVenda.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir  :   " & LbSeqPrecoVenda.Text & " Data:" & TxbDtaInicio.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                itemPrecoVenda.seq_preco_venda = LbSeqPrecoVenda.Text
                itemPrecoVenda.Excluir()
                MsgBox(" Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDadosPrecoVendario()
                limparPrecoVenda()
            Catch ex As Exception
                MsgBox("Erro ao excluir , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub
    Public Sub limparPrecoVenda()

        DtpDtaInicio.Value = Today.AddDays(-3).ToShortDateString
        TxbDtaInicio.Text = ""
        TxbPrecoA.Text = ""
        TxbPrecoB.Text = ""
        TxbPrecoC.Text = ""
        TxbPrecoD.Text = ""
        LbSeqPrecoVenda.Text = ""

        atualizarPrecoVenda = 1
    End Sub
    Private Sub BtnLimparVenda_Click(sender As Object, e As EventArgs) Handles BtnLimpaVenda.Click
        limparPrecoVenda()
    End Sub
    Public Sub formatarGridPrecoVendario()
        Try
            With DgvPrecoVenda
                .Columns(0).HeaderText = "Seq."
                .Columns(1).HeaderText = "Inicio."
                .Columns(2).HeaderText = "Preço A"
                .Columns(3).HeaderText = "Preço B"
                .Columns(4).HeaderText = "Preço C"
                .Columns(5).HeaderText = "Preço D"
                .Columns(2).DefaultCellStyle.Format = "N2"
                .Columns(3).DefaultCellStyle.Format = "N2"
                .Columns(4).DefaultCellStyle.Format = "N2"
                .Columns(5).DefaultCellStyle.Format = "N2"
                .Columns(0).Width = 36
                .Columns(1).Width = 76
                .Columns(2).Width = 76
                .Columns(3).Width = 76
                .Columns(4).Width = 76
                .Columns(5).Width = 76

                .Columns(0).Visible = False
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub carregaFormularioPrecoVendario()
        Try
            limparPrecoVenda()
            If dsPrecoVenda.Tables(0).Rows.Count > 0 Then
                atualizarPrecoVenda = 2
                LbSeqPrecoVenda.Text = dsPrecoVenda.Tables(0).Rows(i)("seq_preco_venda").ToString
                TxbDtaInicio.Text = dsPrecoVenda.Tables(0).Rows(i)("dta_inicio").ToString
                TxbPrecoA.Text = dsPrecoVenda.Tables(0).Rows(i)("val_preco_a").ToString
                TxbPrecoB.Text = dsPrecoVenda.Tables(0).Rows(i)("val_preco_b").ToString
                TxbPrecoC.Text = dsPrecoVenda.Tables(0).Rows(i)("val_preco_c").ToString
                TxbPrecoD.Text = dsPrecoVenda.Tables(0).Rows(i)("val_preco_d").ToString

            Else
                atualizar = 1
            End If
        Catch ex As Exception
        End Try
    End Sub

    '****************************************************
    ' Codigo Barra
    '****************************************************
    Private Sub DgvCodBarra_DoubleClick(sender As Object, e As EventArgs) Handles DgvCodBarra.DoubleClick
        Try
            TxbCodBarraBarra.Text = DgvCodBarra.CurrentRow.Cells(0).Value
            Me.TxbReferenciaBarra.Text = DgvCodBarra.CurrentRow.Cells(2).Value
            Me.TxbUnidadeBarra.Text = DgvCodBarra.CurrentRow.Cells(3).Value
            Me.TxbDesUnidadeBarra.Text = DgvCodBarra.CurrentRow.Cells(4).Value
            Me.TxbDesItemBarra.Text = DgvCodBarra.CurrentRow.Cells(1).Value
            Me.TxbCodBarraBarra.Select()
        Catch ex As Exception

        End Try
    End Sub


    Public Sub atualizaDadosCodigoBarra()
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        Try
            Dim tabela As DataTable
            dsCodigoBarra = itemCodigoBarra.Consultar(TxbCodigo.Text)
            tabela = dsCodigoBarra.Tables(0)

            If tabela.Rows.Count > 0 Then
                DgvCodBarra.DataSource = Nothing
                DgvCodBarra.DataSource = dsCodigoBarra.Tables(0)
                formatarGridCodigoBarrario()
                carregaFormularioCodigoBarra()

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnSalvaCodigoBarra_Click(sender As Object, e As EventArgs) Handles BtnSalvaBarra.Click
        salvaRegistroCodigoBarra()
        limparCodigoBarra()
    End Sub
    Public Sub salvaRegistroCodigoBarra()
        Try
            If TxbCodigo.Text = "" Then
                MsgBox("CODIGO DO ITEM INVALIDO")
                Exit Sub
            End If

            If TxbCodBarraBarra.Text = "" Then
                MsgBox("INFORME CODIGOO DE BARRA")
                TxbCodBarraBarra.Select()
                Exit Sub
            Else
                itemCodigoBarra.cod_barra = TxbCodBarraBarra.Text
            End If
            Try
                Dim ultimo As New DataSet

                ultimo = itemCodigoBarra.CadastradoExistemte(TxbCodBarraBarra.Text)
                Dim ult As String = ultimo.Tables(0).Rows(0)("existente")
                If ult <> "" Then
                    MsgBox("Codigo barra " & TxbCodBarraBarra.Text & " já esta cadastrado no item " & ult, MsgBoxStyle.Information, "Existente")
                    atualizaDadosCodigoBarra()
                    Exit Sub
                End If
                ultimo.Clear()

            Catch ex As Exception

            End Try
            itemCodigoBarra.cod_item = TxbCodigo.Text
            itemCodigoBarra.cod_referencia = TxbReferenciaBarra.Text
            If TxbUnidadeBarra.Text = "" Then
                MsgBox("Unidade deve ser preenchida")
                TxbUnidadeBarra.Select()
                Exit Sub
            Else
                itemCodigoBarra.cod_unidade = TxbUnidadeBarra.Text
            End If

            If TxbDesItemBarra.Text = "" Then
                MsgBox("Descrição deve ser preenchida")
                TxbDesItemBarra.Select()
                Exit Sub
            Else
                itemCodigoBarra.des_item = TxbDesItemBarra.Text
            End If


            If atualizarCodigoBarra = 1 Then
                'pegar o ultimo registro

                itemCodigoBarra.Cadastrar()

                MsgBox(" Cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            Else
                itemCodigoBarra.cod_barra = TxbCodBarraBarra.Text
                itemCodigoBarra.Atualizar()
                MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
        atualizaDadosCodigoBarra()
    End Sub
    Private Sub BtnExcluirCodBarra_Click(sender As Object, e As EventArgs) Handles BtnExcluiBarra.Click
        If TxbCodBarraBarra.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir  :   " & TxbCodBarraBarra.Text & " Data:" & TxbReferenciaBarra.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                itemCodigoBarra.cod_barra = TxbCodBarraBarra.Text
                itemCodigoBarra.Excluir()
                MsgBox(" Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDadosCodigoBarra()
                limparCodigoBarra()
            Catch ex As Exception
                MsgBox("Erro ao excluir , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub
    Public Sub limparCodigoBarra()
        TxbReferenciaBarra.Text = ""
        TxbUnidadeBarra.Text = ""
        TxbDesUnidadeBarra.Text = ""
        TxbDesItemBarra.Text = ""
        TxbCodBarraBarra.Text = ""
        atualizarCodigoBarra = 1
    End Sub
    Private Sub BtnLimparBarra_Click(sender As Object, e As EventArgs) Handles BtnLimparBarra.Click
        limparCodigoBarra()
    End Sub
    Public Sub formatarGridCodigoBarrario()
        Try
            With DgvCodBarra
                .Columns(0).HeaderText = "Cód.Barra"
                .Columns(1).HeaderText = "Descrição"
                .Columns(2).HeaderText = "Referência"
                .Columns(3).HeaderText = "Unidade"
                .Columns(4).HeaderText = ""

                .Columns(0).Width = 60
                .Columns(1).Width = 170
                .Columns(2).Width = 70
                .Columns(3).Width = 70
                .Columns(4).Width = 130

            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub carregaFormularioCodigoBarra()
        Try
            limparCodigoBarra()
            If dsCodigoBarra.Tables(0).Rows.Count > 0 Then
                atualizarCodigoBarra = 2
                TxbCodBarraBarra.Text = dsCodigoBarra.Tables(0).Rows(i)("seq_Barra_venda").ToString
                TxbReferenciaBarra.Text = dsCodigoBarra.Tables(0).Rows(i)("dta_inicio").ToString
                TxbUnidadeBarra.Text = dsCodigoBarra.Tables(0).Rows(i)("val_Barra_a").ToString
                TxbDesUnidadeBarra.Text = dsCodigoBarra.Tables(0).Rows(i)("val_Barra_b").ToString
                TxbDesItemBarra.Text = dsCodigoBarra.Tables(0).Rows(i)("val_Barra_c").ToString
            Else
                atualizar = 1
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
