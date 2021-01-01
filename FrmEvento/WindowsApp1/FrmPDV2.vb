Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmPDV2

    Dim conectar As New ConexaoSQL
    Dim dsParamSist, dsVenda, dsItem, dsPessoa, dsFormaPgto As New DataSet
    Dim item As New ClItem1
    Dim clVenda As New ClVenda
    Dim evento As New ClEvento
    Dim pessoa As New ClPessoa
    Dim formaPagto As New ClFormaPagtoPdv
    Dim paramSistem As New ClParametroSistema
    Dim clLicencia As New ClLicencia
    Dim clNota As New ClNotaFiscalSaida
    Dim clItemNfs As New ClItemNfs
    Dim clPagamento As New ClPagamentoNfs
    Dim emp As New ClEmpresa
    Dim geral As New ClGeral
    Dim valTotalItem, valCustoTotal As String
    Public nomEmpresa, nomEvento As String
    Public codEvento As Integer
    Dim linha As Integer = 0
    Dim totalGeral As Double = 0
    Dim totalGeralLiquido As Double = 0
    Dim troco As Double = 0
    Dim totalDescontoItem As Double = 0
    Dim totalAcrescimoItem As Double = 0
    Dim codUsuario As Integer
    Dim contValPagamento As Integer = 0
    Dim valPago As Double = 0
    Dim cod_item As Integer
    Dim des_item, codUnidade, sglUnidade, valUnitario, desItemNew As String
    Dim seqNota As Integer
    Dim tela As String = "venda"
    Dim ind_tipo_preco As String
    Dim qtdParcela, dta1Vencto, codPessoSacado As String
    Public Sub carregarGropVenda()

        nomEmpresa = ModParametroSistema.nom_fantasia
        buscaItem()
        formatarGridItem()
        buscaPessoa(TxbBuscaNomPessoa.Text)
        LbCodCliente.Text = "1"
        LbNomCliente.Text = "CONSUMIDOR PADRAO"
        ind_tipo_preco = "A"
        buscaFormaPagto()
        formatarGridPagto()
        TxbCodItem.Select()
        carregaTelaVenda()
    End Sub
    Public Sub formatarGridItem()
        With DgvItem
            .Columns(0).HeaderText = "Cód.Barra"
            .Columns(1).HeaderText = "Descrição"
            .Columns(2).HeaderText = "Preço A"
            .Columns(3).HeaderText = "Preço B"
            .Columns(4).HeaderText = "Preço C"
            .Columns(5).HeaderText = "Preço D"
            .Columns(8).HeaderText = "Unidade"
            .Columns(9).HeaderText = "Código"
            .Columns(0).Width = 80
            .Columns(1).Width = 505
            .Columns(2).Width = 80
            .Columns(3).Width = 80
            .Columns(4).Width = 80
            .Columns(5).Width = 80
            .Columns(8).Width = 80
            .Columns(9).Width = 80
            DgvItem.Columns.Item(6).Visible = False
            DgvItem.Columns.Item(7).Visible = False
            'DgvItem.Columns.Item(5).Visible = False
        End With
        formatarGridVenda()
    End Sub

    Public Sub salvarBancoImprimirFicha()

        Try
            For Each linha As DataGridViewRow In DgvVenda.Rows
                If Not linha.IsNewRow Then

                    clVenda.cod_evento = LbCodPdv.Text
                    clVenda.cod_item = linha.Cells(0).Value.ToString
                    des_item = linha.Cells(1).Value.ToString
                    clVenda.qtd_item = linha.Cells(2).Value.ToString.Replace(",", ".")
                    valTotalItem = linha.Cells(4).Value.ToString.Replace(",", ".")
                    valCustoTotal = linha.Cells(5).Value.ToString * clVenda.qtd_item
                    clVenda.val_total_item = valTotalItem
                    clVenda.val_total_custo_item = valCustoTotal.Replace(",", ".")
                    clVenda.ind_tipo = "P"
                    clVenda.InserirVenda()

                    For index As Integer = 1 To linha.Cells(2).Value
                        '    imprimirFicha()
                    Next
                End If
            Next
            DgvVenda.Rows.Clear()
            DgvVenda.Refresh()
            valTotalItem = 0
            valCustoTotal = 0
            totalGeral = 0
            totalGeralLiquido = 0
            limparGeral()
            TxbCodItem.Select()
        Catch ex As Exception
            MsgBox("ITEM NAO ESTA CADASTRADO NO BANCO" & ex.Message, MsgBoxStyle.Critical, "Erro")
            TxbCodItem.Select()
        End Try
        TxbCodItem.Select()
    End Sub

    Public Sub limpar()
        TxbQtde.Text = ""
        LbDescricaoItem.Text = ""

        TxbCodItem.Text = ""
        TxbValorUnitario.Text = ""
        TxbValorTotal.Text = ""

        TxbCodItem.Select()
    End Sub

    Public Sub limparGeral()
        TxbQtde.Text = ""
        LbDescricaoItem.Text = ""

        TxbCodItem.Text = ""
        TxbValorUnitario.Text = ""
        TxbValorTotal.Text = ""
        TxbTotalGeral.Text = ""
        LbCodCliente.Text = "1"
        LbNomCliente.Text = "CONSUMIDOR PADRAO"
        ind_tipo_preco = "A"
        TxbCodItem.Select()
        DgvVenda.Rows.Clear()
        valTotalItem = ""
        valCustoTotal = ""
        valUnitario = ""
        codUnidade = ""
        sglUnidade = ""
        desItemNew = ""
        des_item = ""
        seqNota = 0
        totalGeral = 0
        totalGeralLiquido = 0
        totalDescontoItem = 0
        totalAcrescimoItem = 0
        LbTotalAcrescItem.Text = "0,00"
        LbTotalDescItem.Text = "0,00"
        troco = 0
        valPago = 0
        limparpagamento()
        limparDescontoAcrescimo()
        TxbTotalGeralPg.Text = ""
        DgvPagamento.Rows.Clear()

        carregaLogoEmpresa()

    End Sub
    Private Sub carregaLogoEmpresa()
        Try
            PictureBox1.Image = Image.FromFile("c:\evento\imagemItem\logoEmpresa.png")
        Catch ex As Exception
            Try
                PictureBox1.Image = Image.FromFile("c:\evento\imagemItem\logoEmpresa.jpg")
            Catch ex1 As Exception
            End Try
        End Try
    End Sub
    Private Sub FrmPrincipal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'TECLA ENTER
        InsereEnter(Me)
    End Sub

    Private Sub FrmPDV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '      DescarregarTelaVenda()
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t140103 = False Then
                MsgBox("Usuário sem permissão para acessar o PDV!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
        End If
        Dim licencia As Boolean
        licencia = clLicencia.verificarLicencia()
        If licencia = False Then
            Me.Close()
            Exit Sub
        End If
        limpar()
        limparGeral()
        carregarGropVenda()

        Try
            PictureBox1.Image = Image.FromFile("c:\evento\imagemItem\logoEmpresa.png")
        Catch ex As Exception
            Try
                PictureBox1.Image = Image.FromFile("c:\evento\imagemItem\logoEmpresa.jpg")
            Catch ex1 As Exception
            End Try
        End Try
        codUsuario = ModParametroSistema.codUsuario
        LbNomOperador.Text = ModParametroSistema.nom_usuario
        Try
            LbCodPdv.Text = geral.sqlBuscaDescricao("cod_pdv", "tab_pdv", "des_hostname = '" & System.Net.Dns.GetHostName & "' and 0", 0)
            carregaFechamentoCaixa()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub carregaFechamentoCaixa()
        Dim clFecha As New ClFechamentoCaixaPdv
        Dim dsFechamento As New DataSet
        Dim tab As New DataTable
        Try
            dsFechamento = clFecha.ConsultarAberto(LbCodPdv.Text)
            tab = dsFechamento.Tables(0)
            If tab.Rows.Count > 0 Then
                LbSeqFechamento.Text = tab.Rows(0).Item("seq_fechamento")
                LbTurno.Text = tab.Rows(0).Item("num_fechamento")
                LbDesPdv.Text = tab.Rows(0).Item("des_pdv")
                LbNomOperador.Text = tab.Rows(0).Item("nom_operador")
                TxbCodItem.Enabled = True
                LbNomCliente.Text = "CONSUMIDOR PADRAO"
            Else
                TxbCodItem.Enabled = False
                LbNomCliente.Text = "CAIXA FECHADO"
                MsgBox("Nenhum caixa aberto para efetuar venda deve abrir caixa!", MsgBoxStyle.Information, "Abertura de Caixa")
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub formatarGridVenda()
        With DgvVenda
            .Rows.Clear()
            .Columns.Clear()
            .Columns.Add("codigo", "Código")
            .Columns.Add("descrição", "Descrição")
            .Columns.Add("quantidade", "Qtde")
            .Columns.Add("Un", "Un")
            .Columns.Add("Desconto", "Desconto")
            .Columns.Add("Acrescimo", "Acrescimo")
            .Columns.Add("Vl.Unitário", "Vl.Unitário")
            .Columns.Add("Total", "Total")
            .Columns.Add("Custo", "Custo")
            .Columns.Add("cod_unidade", "cod_unidade")

            .Columns(0).Width = 50
            .Columns(1).Width = 180
            .Columns(2).Width = 60
            .Columns(3).Width = 40
            .Columns(4).Width = 70
            .Columns(5).Width = 70
            .Columns(6).Width = 70
            .Columns(7).Width = 70
            .Columns(8).Visible = False
            .Columns(9).Visible = False 'cod_unidade
            .AllowUserToAddRows = False
        End With
    End Sub
    Public Sub carregaGridVenda(codItem As Integer)
        Dim totalLiqItem As Double
        totalLiqItem = CDbl(TxbValorTotal.Text) - CDbl(LbValDesc.Text) + CDbl(LbValAcresc.Text)
        Try
            DgvVenda.Rows.Add(codItem, LbDescricaoItem.Text, FormatNumber(TxbQtde.Text, 2), sglUnidade, FormatNumber(LbValDesc.Text, 2).ToString,
                             FormatNumber(LbValAcresc.Text, 2).ToString, TxbValorUnitario.Text, FormatNumber(totalLiqItem.ToString, 2), Convert.ToString(valCustoTotal), codUnidade)

            calculaTotalGeralBrutoItem(CDbl(TxbValorTotal.Text))
            calculaTotalGeralLiquidoItem(CDbl(TxbValorTotal.Text) - CDbl(LbValDesc.Text) + CDbl(LbValAcresc.Text))

            TxbCodItem.Select()
            linha = linha + 1

        Catch ex As Exception
            MsgBox("Erro carregar grid")
        End Try
    End Sub
    Private Sub calculaTotalGeralLiquidoItem(ByVal valor As Double)
        totalGeralLiquido = totalGeralLiquido + (valor)
        TxbTotalGeral.Text = Convert.ToString(FormatNumber(totalGeralLiquido, 2))
    End Sub
    Private Sub calculaTotalGeralBrutoItem(ByVal valor As Double)
        totalGeral = totalGeral + (valor)
    End Sub
    Private Sub TxtCodItem_LostFocus(sender As Object, e As EventArgs) Handles TxbCodItem.LostFocus
        If TxbCodItem.Text = "" Then

            TxbCodItem.Select()
            Exit Sub
        End If

        Dim qtdItem As String = ""
        Dim codItem As String = ""
        Dim qtdOK As Boolean = False

        'SEPARAR A QTD DO ITEM  QTD*ITEM
        For index = 0 To Len(TxbCodItem.Text) - 1
            If TxbCodItem.Text.Substring(index, 1).ToString = "*" Then
                qtdOK = True
            Else
                If qtdOK = False Then
                    qtdItem = qtdItem & TxbCodItem.Text.Substring(index, 1)
                Else
                    codItem = codItem & TxbCodItem.Text.Substring(index, 1)
                End If
            End If
        Next
        If codItem = "" Then
            codItem = qtdItem
            qtdItem = 1
        End If
        If qtdItem = 0 Then
            qtdItem = 1
        End If

        '############ este uso com muitos dados pode causar uma lentidao no sistema melhor fazer uma verificação direta pelo modulo
        'VERIFICAR SE ITEM E VALIDO 
        desItemNew = ""
        Try
            For Each row In DgvItem.Rows
                If codItem = row.Cells(0).Value.ToString Then
                    desItemNew = row.Cells(1).Value.ToString
                    If ind_tipo_preco = "A" Then
                        valUnitario = FormatNumber(row.Cells(2).Value, 2).ToString
                    ElseIf ind_tipo_preco = "B" Then
                        valUnitario = FormatNumber(row.Cells(3).Value, 2).ToString
                    ElseIf ind_tipo_preco = "C" Then
                        valUnitario = FormatNumber(row.Cells(4).Value, 2).ToString
                    ElseIf ind_tipo_preco = "D" Then
                        valUnitario = FormatNumber(row.Cells(5).Value, 2).ToString
                    Else
                        valUnitario = FormatNumber(row.Cells(2).Value, 2).ToString
                    End If
                    codUnidade = row.Cells(7).Value.ToString
                    sglUnidade = row.Cells(8).Value.ToString
                    valTotalItem = (CDbl(valUnitario) * CDbl(qtdItem)).ToString
                    valCustoTotal = (CDbl(row.Cells(7).Value.ToString) * CUInt(qtdItem)).ToString
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If desItemNew = "" Then
            MsgBox("Item não cadastrado ou desativado", MsgBoxStyle.Information, "Código Invalido")
            Exit Sub
        End If

        'COLOCAR AS INFORMACOES NO GRID 

        LbDescricaoItem.Text = desItemNew
        TxbValorUnitario.Text = valUnitario
        TxbQtde.Text = FormatNumber(qtdItem, 2).ToString
        TxbValorTotal.Text = FormatNumber(CDbl(valTotalItem).ToString, 2)
        calculaPorcentagemDescontoAcrescimo(CDbl(valTotalItem))
        calculaTotalDescontoItem(CDbl(LbValDesc.Text))
        calculaTotalAcrescimoItem(CDbl(LbValAcresc.Text))

        If qtdItem > 10 Then
            If MsgBox("Mais de 10 itens confirma?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.No Then
                TxbQtde.Text = ""
                TxbQtde.Select()
                Exit Sub
            End If
        End If

        carregaGridVenda(codItem)
        Try
            PictureBox1.Image = Image.FromFile("c:\evento\imagemItem\" & codItem & ".png")
        Catch ex As Exception
            Try
                PictureBox1.Image = Image.FromFile("c:\evento\imagemItem\" & codItem & ".jpg")
            Catch ex1 As Exception
                PictureBox1.Image = Image.FromFile("c:\evento\imagemItem\logoEmpresa.png")
            End Try

        End Try

        TxbCodItem.Text = ""
        limparDescontoAcrescimo()

        TxbCodItem.Select()

    End Sub
    Private Sub calculaTotalDescontoItem(ByVal valor As Double)
        totalDescontoItem = totalDescontoItem + (valor)
        LbTotalDescItem.Text = FormatNumber(totalDescontoItem.ToString, 2)
    End Sub
    Private Sub calculaTotalAcrescimoItem(ByVal valor As Double)
        totalAcrescimoItem = totalAcrescimoItem + (valor)
        LbTotalAcrescItem.Text = FormatNumber(totalAcrescimoItem.ToString, 2)
    End Sub
    Public Sub imprimirFicha()
        Try
            PrintDocument1.Print()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub PrintDocument3_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage
        imprimiRelResumoVenda(e, LbCodPdv.Text, LbDesPdv.Text, "I")
    End Sub

    Private Sub PrintDocRelResumoVenda_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocRelResumoVenda.PrintPage
        imprimiRelResumoVenda(e, LbCodPdv.Text, LbDesPdv.Text, "P")
    End Sub
    Public Sub imprimiRelResumoVenda(e As Printing.PrintPageEventArgs, codEvento As String, nomEvento As String, tipo As String)

        Dim reportFont8 As Font = New Drawing.Font("Time New Roman", 7.5)
        Dim reportFont7 As Font = New Drawing.Font("Time New Roman", 7)
        Dim reportFont6 As Font = New Drawing.Font("Time New Roman", 6)
        Dim reportFont5 As Font = New Drawing.Font("Time New Roman", 5.5)

        clNota.seq_nota = seqNota
        Dim tabela As DataTable
        If tipo = "P" Then
            dsVenda = clNota.Consultar()
        Else
            dsVenda = clVenda.ResumoVendasIngresso()
        End If

        tabela = dsVenda.Tables(0)
        Dim Row As DataRow
        Dim x As Integer = 0
        If tabela.Rows.Count > 0 Then

            e.Graphics.DrawString(tabela.Rows(0).Item("nom_fantasia").ToString, reportFont8, Brushes.Black, 110, x)
            x = x + 10
            e.Graphics.DrawString("CNPJ: " & tabela.Rows(0).Item("num_cnpj").ToString & " - IE: " & tabela.Rows(0).Item("num_ie").ToString, reportFont8, Brushes.Black, 0, x)
            x = x + 10
            e.Graphics.DrawString(tabela.Rows(0).Item("des_logradouro").ToString & " - : " & tabela.Rows(0).Item("nom_bairro").ToString, reportFont8, Brushes.Black, 0, x)
            x = x + 7
            e.Graphics.DrawString("______________________________________________________________________________", reportFont6, Brushes.Black, 0, x)
            x = x + 10
            e.Graphics.DrawString(tabela.Rows(0).Item("des_documento").ToString, reportFont8, Brushes.Black, 0, x)
            x = x + 7
            e.Graphics.DrawString("______________________________________________________________________________", reportFont6, Brushes.Black, 0, x)

            x = 55
            For Each Row In dsVenda.Tables(0).Rows

                If x = 55 Then

                    e.Graphics.DrawString("CÓDIGO", reportFont6, Brushes.Black, 0, x)
                    e.Graphics.DrawString("DESCRIÇAO", reportFont6, Brushes.Black, 40, x)
                    e.Graphics.DrawString("QTD", reportFont6, Brushes.Black, 160, x)
                    e.Graphics.DrawString("UN", reportFont6, Brushes.Black, 190, x)
                    e.Graphics.DrawString("VL.UN", reportFont6, Brushes.Black, 210, x)
                    e.Graphics.DrawString("TOTAL", reportFont6, Brushes.Black, 240, x)
                    x = x + 5
                    e.Graphics.DrawString("______________________________________________________________________________", reportFont6, Brushes.Black, 0, x)

                    x = x + 10
                End If
                x = x + 10
                e.Graphics.DrawString(Row.Item(7).ToString, reportFont5, Brushes.Black, 0, x)
                If Len(Row.Item(8).ToString) > 25 Then
                    e.Graphics.DrawString(Row.Item(8).ToString.Substring(0, 24), reportFont5, Brushes.Black, 40, x)
                Else
                    e.Graphics.DrawString(Row.Item(8).ToString, reportFont5, Brushes.Black, 40, x)
                End If
                e.Graphics.DrawString(Format(Row.Item(9), "0.00").ToString, reportFont5, Brushes.Black, 160, x)
                e.Graphics.DrawString(Row.Item(11).ToString, reportFont5, Brushes.Black, 190, x)
                e.Graphics.DrawString(Format(Row.Item(12), "0.00").ToString, reportFont5, Brushes.Black, 210, x)
                e.Graphics.DrawString(Format(Row.Item(13), "0.00").ToString, reportFont5, Brushes.Black, 240, x)

            Next
            x = x + 5
            e.Graphics.DrawString("______________________________________________________________________________", reportFont6, Brushes.Black, 0, x)

            x = x + 10
            e.Graphics.DrawString("QTD TOTAL DE ITENS:", reportFont5, Brushes.Black, 0, x)
            e.Graphics.DrawString(tabela.Rows(0).Item("qtd_total").ToString, reportFont6, Brushes.Black, 240, x)
            x = x + 10
            e.Graphics.DrawString("VALOR PRODUTOS:", reportFont5, Brushes.Black, 0, x)
            e.Graphics.DrawString(Format(tabela.Rows(0).Item("val_total"), "0.00").ToString, reportFont6, Brushes.Black, 240, x)
            x = x + 10
            e.Graphics.DrawString("DESCONTOS:", reportFont5, Brushes.Black, 0, x)
            e.Graphics.DrawString(Format(tabela.Rows(0).Item("val_desconto"), "0.00").ToString, reportFont6, Brushes.Black, 240, x)
            x = x + 10
            e.Graphics.DrawString("ACRESCIMOS:", reportFont5, Brushes.Black, 0, x)
            e.Graphics.DrawString(Format(tabela.Rows(0).Item("val_acrescimo"), "0.00").ToString, reportFont6, Brushes.Black, 240, x)
            x = x + 10
            e.Graphics.DrawString("VALOR A PAGAR:", reportFont5, Brushes.Black, 0, x)
            e.Graphics.DrawString(Format(tabela.Rows(0).Item("val_pagar"), "0.00").ToString, reportFont6, Brushes.Black, 240, x)

            x = x + 5
            e.Graphics.DrawString("______________________________________________________________________________", reportFont6, Brushes.Black, 0, x)
            x = x + 10
            Dim t As Integer
            t = x
            Dim totalPagamento As Double = 0
            For Each linha As DataGridViewRow In DgvPagamento.Rows

                If x = t Then
                    e.Graphics.DrawString("FORMA PAGAMENTO", reportFont6, Brushes.Black, 0, x)
                    e.Graphics.DrawString("TOTAL", reportFont6, Brushes.Black, 240, x)
                    x = x + 5
                    e.Graphics.DrawString("______________________________________________________________________________", reportFont6, Brushes.Black, 0, x)

                    x = x + 10
                End If
                x = x + 10
                e.Graphics.DrawString(linha.Cells(1).Value.ToString, reportFont5, Brushes.Black, 0, x)
                e.Graphics.DrawString(linha.Cells(2).Value.ToString, reportFont5, Brushes.Black, 240, x)
                totalPagamento = totalPagamento + CDbl(linha.Cells(2).Value.ToString)
            Next
            x = x + 10
            e.Graphics.DrawString("Total Recebido", reportFont6, Brushes.Black, 0, x)
            e.Graphics.DrawString(FormatNumber(totalPagamento.ToString, 2).ToString, reportFont6, Brushes.Black, 240, x)

            x = x + 7
            e.Graphics.DrawString("______________________________________________________________________________", reportFont6, Brushes.Black, 0, x)
            x = x + 10
            e.Graphics.DrawString("Valor Troco", reportFont6, Brushes.Black, 0, x)
            e.Graphics.DrawString(Format(tabela.Rows(0).Item("val_troco"), "0.00").ToString, reportFont6, Brushes.Black, 240, x)
            x = x + 5
            e.Graphics.DrawString("______________________________________________________________________________", reportFont6, Brushes.Black, 0, x)
            x = x + 10
            e.Graphics.DrawString("ÁREA DE MENSAGEM", reportFont7, Brushes.Black, 90, x)
            x = x + 15
            e.Graphics.DrawString("NÚMERO: " & tabela.Rows(0).Item("num_nota").ToString, reportFont6, Brushes.Black, 100, x)
            x = x + 10
            e.Graphics.DrawString("Emissão: " & tabela.Rows(0).Item("dta_emissao").ToString.Substring(0, 10) & "  " & tabela.Rows(0).Item("hra_emissao").ToString, reportFont6, Brushes.Black, 70, x)

            x = x + 5
            e.Graphics.DrawString("______________________________________________________________________________", reportFont6, Brushes.Black, 0, x)
            x = x + 10
            e.Graphics.DrawString("CONSUMIDOR " & tabela.Rows(0).Item("num_nota").ToString, reportFont7, Brushes.Black, 110, x)
            x = x + 15
            e.Graphics.DrawString(tabela.Rows(0).Item("nom_pessoa").ToString, reportFont6, Brushes.Black, 100, x)

            x = x + 5
            e.Graphics.DrawString("______________________________________________________________________________", reportFont6, Brushes.Black, 0, x)

        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim tabela As DataRow
            dsParamSist = paramSistem.consultarParametro()
            tabela = dsParamSist.Tables(0).Rows(0)
            Dim DiminuiFontProduto As Integer = tabela.Item(0)

            Dim reportFont6 As Font = New Drawing.Font("Time New Roman", 6)
            Dim reportFont8 As Font = New Drawing.Font("Time New Roman", 8)
            Dim reportFont12 As Font = New Drawing.Font("Time New Roman", 12)
            Dim reportFont14 As Font = New Drawing.Font("Time New Roman", 14)
            Dim reportFont16 As Font = New Drawing.Font("Time New Roman", 16)
            Dim reportFont18 As Font = New Drawing.Font("Time New Roman", 18)
            Dim reportFont20 As Font = New Drawing.Font("Time New Roman", 20 - (DiminuiFontProduto))
            Dim rept As Font
            If des_item.Count <= 17 Then
                rept = reportFont20
            ElseIf des_item.Count <= 20 Then
                rept = reportFont18
            ElseIf des_item.Count <= 21 Then
                rept = reportFont16
            ElseIf des_item.Count < 27 Then
                rept = reportFont14
            ElseIf des_item.Count > 28 Then
                rept = reportFont12
            End If
            Dim newImageEmpresa As Image
            Try
                newImageEmpresa = Image.FromFile("C:\evento\imagem\logoEmpresa.png")

            Catch ex As Exception
                newImageEmpresa = Image.FromFile("C:\evento\imagem\logoEmpresa.jpg")

            End Try
            ' Create coordinates for upper-left corner
            ' of image and for size of image.
            Dim x1 As Integer = 0
            Dim y1 As Integer = 0
            Dim width1 As Integer = 50
            Dim height1 As Integer = 50

            ' Draw image to screen.
            e.Graphics.DrawImage(newImageEmpresa, x1, y1, width1, height1)
            e.Graphics.DrawString(nomEmpresa, reportFont14, Brushes.Black, paramSistem.posicaoTamanho14(nomEmpresa.Count), 0)

            e.Graphics.DrawString(des_item, rept, Brushes.Black, paramSistem.posicaoTamanho20(des_item.Count), 45)
            e.Graphics.DrawString(nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa, reportFont6, Brushes.Black, 0, 80)
            e.Graphics.DrawString(nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa, reportFont6, Brushes.Black, 0, 90)

            e.Graphics.DrawString("Válido apenas para dia:" & Today, reportFont8, Brushes.Black, 50, 100)
            ' e.Graphics.DrawString(" ", reportFont1, Brushes.Black, 100, 160)
        Catch ex As Exception

        End Try
    End Sub
    Public Function posicaoTamanho20(ByVal x As Integer) As Integer
        If x <= 3 Then
            Return 100
        ElseIf x <= 6 Then
            Return 85
        ElseIf x <= 9 Then
            Return 65
        ElseIf x <= 12 Then
            Return 40
        ElseIf x <= 15 Then
            Return 10
        Else
            Return 0
        End If
    End Function
    Private Sub DgvItem_DoubleClick(sender As Object, e As EventArgs) Handles DgvItem.DoubleClick
        Try
            TxbCodItem.Text = DgvItem.CurrentRow.Cells(0).Value
            LbDescricaoItem.Text = DgvItem.CurrentRow.Cells(1).Value
            txbBuscaDesItem.Text = ""
            TxbCodBarra.Text = ""
            carregaTelaVenda()
            buscaItem()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub buscaItem()
        Try
            Dim tab As DataTable
            dsItem = item.ConsultarItemVenda(txbBuscaDesItem.Text, TxbCodBarra.Text)
            tab = dsItem.Tables(0)
            If tab.Rows.Count > 0 Then
                DgvItem.DataSource = dsItem.Tables(0)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TxtQtde_TextChanged(sender As Object, e As EventArgs) Handles TxbQtde.TextChanged
        If Not IsNumeric(TxbQtde.Text) Then
            TxbQtde.Text = ""
        End If
        If TxbQtde.Text = "" Then
            TxbValorTotal.Text = FormatNumber(0, 2)
            Exit Sub
        End If
        Dim total As Double
        total = TxbQtde.Text * TxbValorUnitario.Text
        TxbValorTotal.Text = Convert.ToString(FormatNumber(total, 2))

    End Sub
    Private Sub BtnImprimirFicha_Click(sender As Object, e As EventArgs)
        salvarBancoImprimirFicha()
    End Sub
    Private Sub btItemVenda_Click(sender As Object, e As EventArgs) Handles btnTelaVenda.Click
        carregaTelaVenda()
    End Sub
    Private Sub txbBuscaDesItem_TextChanged(sender As Object, e As EventArgs) Handles txbBuscaDesItem.TextChanged
        buscaItem()
    End Sub
    Private Sub BtBuscaPessoa_Click(sender As Object, e As EventArgs) Handles BtnTelaPessoa.Click
        carregaTelaPessoa()
    End Sub

    Public Sub buscaPessoa(nome As String)

        Dim tab As DataTable
        dsPessoa = pessoa.ConsultarPessoaCliente(nome)
        tab = dsPessoa.Tables(0)
        If tab.Rows.Count > 0 Then
            DgvPessoa.DataSource = dsPessoa.Tables(0)
            With DgvPessoa
                .Columns(0).HeaderText = "Código"
                .Columns(1).HeaderText = "Nome"
                .Columns(2).HeaderText = "ind_preco_venda"
                .Columns(0).Width = 100
                .Columns(1).Width = 555
                .Columns(2).Visible = False
            End With
        End If
    End Sub

    Private Sub TxbCodFormaPagto_TextChanged(sender As Object, e As EventArgs) Handles TxbCodFormaPagto.TextChanged
        If CDbl(TxbSaldoRestante.Text) = 0 Then
            If MsgBox("Deseja finalizar a venda? ", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                finalizarVenda()
                Exit Sub
            End If
        End If
        If Not IsNumeric(TxbCodFormaPagto.Text) Then
            TxbCodFormaPagto.Text = ""
            Exit Sub
        End If
        Try

            For Each row In DgvFormaPagto.Rows
                If TxbCodFormaPagto.Text = row.Cells(0).Value.ToString Then
                    LbDesFormaPagto.Text = row.Cells(1).Value.ToString
                    Exit For
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TxbCodFormaPagto_LostFocus(sender As Object, e As EventArgs) Handles TxbCodFormaPagto.LostFocus
        If TxbCodFormaPagto.Text = "" Then
            TxbCodFormaPagto.Select()
            Exit Sub
        End If
        Try
            Dim validar As Boolean = False
            For Each row In DgvFormaPagto.Rows
                If TxbCodFormaPagto.Text = row.Cells(0).Value.ToString Then

                    validar = True
                    Exit For
                End If

            Next
            If validar = False Then
                TxbCodFormaPagto.Text = ""
                TxbCodFormaPagto.Select()
                Exit Sub
            End If
        Catch ex As Exception
            TxbCodFormaPagto.Text = ""
            TxbCodFormaPagto.Select()
            Exit Sub
        End Try
        If TxbCodFormaPagto.Text = "2" Then 'cartao de credito
            DgvFormaPagto.Enabled = False
            GbBotaoAtalho.Enabled = False
            TxbQtdParcCartao.Text = ""
            TabControl2.SelectedIndex = 2
            TxbQtdParcCartao.Select()
            Exit Sub
        ElseIf TxbCodFormaPagto.Text = "4" Then  'nota a prazo
            DgvFormaPagto.Enabled = False
            GbBotaoAtalho.Enabled = False
            TabControl2.SelectedIndex = 1
            DtpDta1Vencto.Value = Today.AddDays(30)
            If LbCodCliente.Text > 1 Then
                TxbCodClienteNotaPrazo.Text = LbCodCliente.Text
                TxbNomClienteNotaPrazo.Text = LbNomCliente.Text
                TxbQtdParcNotaPrazo.Text = ""
                GbClienteNotaPrazo.Enabled = False
                TxbQtdParcNotaPrazo.Select()
            Else
                TxbCodClienteNotaPrazo.Text = ""
                TxbNomClienteNotaPrazo.Text = ""
                TxbQtdParcNotaPrazo.Text = ""
                GbClienteNotaPrazo.Enabled = True
                TxbCodClienteNotaPrazo.Select()
            End If
        Else
            TabControl2.SelectedIndex = 0
            TxbValorPagto.Select()
        End If
    End Sub
    Private Sub TxbValorPagto_LostFocus(sender As Object, e As EventArgs) Handles TxbValorPagto.LostFocus
        If TxbCodFormaPagto.Text = "" Then
            TxbCodFormaPagto.Select()
            Exit Sub
        End If
        If LbDesFormaPagto.Text <> "" And CDbl(TxbValorPagto.Text) <> 0 Then
            carregaGridPagto()
            contValPagamento = 0
        Else
            If LbDesFormaPagto.Text <> "" Then
                TxbValorPagto.Select()
                Exit Sub
            End If
        End If
        TxbCodFormaPagto.Select()
    End Sub

    Private Sub BtPagamento_Click_1(sender As Object, e As EventArgs) Handles BtnTelaPagamento.Click
        carregaTelaPagamento()
    End Sub
    Public Sub formatarGridPagto()
        With DgvPagamento
            .Columns.Add("Código", "Código")
            .Columns.Add("Descrição", "Descrição")
            .Columns.Add("Valor", "Valor")
            .Columns.Add("QtdParcela", "QtdParcela")
            .Columns.Add("DtaVencto", "DtaVencto")
            .Columns.Add("Cliente", "Cliente")
            .Columns(0).Width = 50
            .Columns(1).Width = 190
            .Columns(2).Width = 80
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False

            .AllowUserToAddRows = False
        End With
    End Sub

    Private Sub TxbBuscaDesItem_KeyUp(sender As Object, e As KeyEventArgs) Handles txbBuscaDesItem.KeyUp
        voltaPrincipal(e)
    End Sub
    Private Sub DgvItem_KeyUp(sender As Object, e As KeyEventArgs) Handles DgvItem.KeyUp
        voltaPrincipal(e)
    End Sub
    Private Sub TxbBuscaNomPessoa_KeyUp(sender As Object, e As KeyEventArgs) Handles TxbBuscaNomPessoa.KeyUp
        voltaPrincipal(e)
    End Sub
    Private Sub DgvPessoa_KeyUp(sender As Object, e As KeyEventArgs) Handles DgvPessoa.KeyUp
        voltaPrincipal(e)
    End Sub
    Private Sub voltaPrincipal(e As KeyEventArgs)
        Select Case e.KeyCode
            Case 112
                txbBuscaDesItem.Text = ""
                carregaTelaVenda()
                TxbCodItem.Select()
        End Select
    End Sub
    Private Sub TxbBuscaNomPessoa_TextChanged(sender As Object, e As EventArgs) Handles TxbBuscaNomPessoa.TextChanged
        buscaPessoa(TxbBuscaNomPessoa.Text)
    End Sub
    Private Sub DgvPessoa_DoubleClick(sender As Object, e As EventArgs) Handles DgvPessoa.DoubleClick
        Me.LbCodCliente.Text = DgvPessoa.CurrentRow.Cells(0).Value
        Me.LbNomCliente.Text = DgvPessoa.CurrentRow.Cells(1).Value
        ind_tipo_preco = DgvPessoa.CurrentRow.Cells(2).Value
        TxbBuscaNomPessoa.Text = ""
        carregaTelaVenda()
    End Sub
    Private Sub TxbValorPagto_TextChanged_1(sender As Object, e As EventArgs) Handles TxbValorPagto.TextChanged
        If Not IsNumeric(TxbValorPagto.Text) Then
            TxbValorPagto.Text = ""
        End If
    End Sub

    Private Sub BtnTelaItem_Click(sender As Object, e As EventArgs) Handles BtnTelaItem.Click
        carregaTelaItem()
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        DgvVenda.Enabled = True
        DgvPagamento.Enabled = True
    End Sub
    Private Sub excluirItemVenda()
        '/ Remover linha selecionada
        '/se não tem linhas então sai
        If DgvVenda.RowCount = 0 Then
            TxbCodItem.Select()
            DgvVenda.Enabled = False
            Exit Sub
        End If
        '//remove a linha atual selecionada
        calculaTotalGeralLiquidoItem(DgvVenda.CurrentRow.Cells(7).Value * (-1))
        calculaTotalGeralBrutoItem((CDbl(DgvVenda.CurrentRow.Cells(7).Value.ToString) + CDbl(DgvVenda.CurrentRow.Cells(4).Value.ToString) - CDbl(DgvVenda.CurrentRow.Cells(5).Value.ToString)) * (-1))
        calculaTotalDescontoItem(CDbl(DgvVenda.CurrentRow.Cells(4).Value.ToString) * (-1))
        calculaTotalAcrescimoItem(CDbl(DgvVenda.CurrentRow.Cells(5).Value.ToString) * (-1))

        DgvVenda.Rows.Remove(DgvVenda.CurrentRow)
        DgvVenda.Refresh()
        DgvVenda.Enabled = False
        TxbCodItem.Select()

    End Sub

    Private Sub DgvVenda_DoubleClick(sender As Object, e As EventArgs) Handles DgvVenda.DoubleClick
        If MsgBox("Deseja excluir o Item:   " & DgvVenda.CurrentRow.Cells(1).Value.ToString & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                excluirItemVenda()
                TxbValorTotal.Text = ""
                TxbValorUnitario.Text = ""
                TxbQtde.Text = ""
                carregaLogoEmpresa()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Public Sub buscaFormaPagto()
        Dim tab As DataTable
        dsFormaPgto = formaPagto.ConsultarFormaPagtoPdv()
        tab = dsFormaPgto.Tables(0)
        If tab.Rows.Count > 0 Then
            DgvFormaPagto.DataSource = dsFormaPgto.Tables(0)
            With DgvFormaPagto
                .Columns(0).HeaderText = "Código"
                .Columns(1).HeaderText = "Descrição"
                .Columns(0).Width = 60
                .Columns(1).Width = 300
            End With
        End If
    End Sub
    Private Sub DgvFormaPagto_DoubleClick(sender As Object, e As EventArgs) Handles DgvFormaPagto.DoubleClick
        Me.TxbCodFormaPagto.Text = DgvFormaPagto.CurrentRow.Cells(0).Value
        Me.LbDesFormaPagto.Text = DgvFormaPagto.CurrentRow.Cells(1).Value

        TxbValorPagto.Select()
        'valor troco zero ai volta para principal e finaliza tudo  TabControl1.SelectedIndex = 0
    End Sub
    Public Sub carregaGridPagto()
        If LbDesFormaPagto.Text = "" Then
            TxbCodFormaPagto.Select()
            Exit Sub
        End If
        If TxbValorPagto.Text = "" Then
            TxbValorPagto.Select()
            Exit Sub
        End If
        If TxbCodFormaPagto.Text = "2" Then
            qtdParcela = TxbQtdParcCartao.Text
            dta1Vencto = ""
            codPessoSacado = "0"
        ElseIf TxbCodFormaPagto.Text = "4" Then
            qtdParcela = TxbQtdParcNotaPrazo.Text
            dta1Vencto = TxbDta1Vecto.Text
            codPessoSacado = TxbCodClienteNotaPrazo.Text
        Else
            qtdParcela = "0"
            dta1Vencto = ""
            codPessoSacado = "0"
        End If
        Try
            calculaSaldoRestante(CDbl(TxbValorPagto.Text))
            DgvPagamento.Rows.Add(TxbCodFormaPagto.Text, LbDesFormaPagto.Text, TxbValorPagto.Text, qtdParcela, dta1Vencto, codPessoSacado)

            limparpagamento()
            TxbCodFormaPagto.Select()
        Catch ex As Exception
            MsgBox("Erro carregar gridPgto")
        End Try
    End Sub
    Private Sub calculaSaldoRestante(valor As Double)
        valPago = valPago + (valor)
        TxbSaldoRestante.Text = Convert.ToString(FormatNumber(totalGeralLiquido - valPago - CDbl(LbValDescPg.Text) + CDbl(LbValAcrescPg.Text), 2))
        If CDbl(valPago) > (totalGeralLiquido - CDbl(LbValDescPg.Text) + CDbl(LbValAcrescPg.Text)) Then
            txbTroco.Text = FormatNumber((totalGeralLiquido - CDbl(LbValDescPg.Text) + CDbl(LbValAcrescPg.Text) - valPago) * (-1), 2)
            TxbSaldoRestante.Text = "0,00"
        Else
            txbTroco.Text = "0,00"
        End If
    End Sub

    Private Sub calculaTroco(x As Double)
        troco = troco - (x)
        If troco > 0 Then
            txbTroco.Text = "0,00"
        Else
            txbTroco.Text = FormatNumber(Convert.ToString(troco * (-1)), 2)
        End If
    End Sub
    Public Sub limparpagamento()

        TxbCodFormaPagto.Text = ""
        TxbValorPagto.Text = ""
        LbDesFormaPagto.Text = ""
    End Sub

    Private Sub FrmPDV2_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        teclaFuncaoF(e)
    End Sub
    Private Sub teclaFuncaoF(e As KeyEventArgs)
        Select Case e.KeyCode
            Case 112
                carregaTelaVenda()  'F1 Tela de venda
            Case 113
                carregaTelaItem()  'F2 busca item
            Case 114
                limparGeral()  'F3 Cancelar venda
            Case 116
                carregaTelaPagamento()  'F5 pagamento
            Case 117
                carregaTelaPessoa()  'F6 cliente
            Case 118
                carregaTelaDescontoAcrescimo()  'F7 Desconto
            Case 119
                'F8 Excluir
                If tela = "venda" Then
                    DgvVenda.Enabled = True
                Else
                    DgvPagamento.Enabled = True
                End If
            Case 121
                finalizarVenda()  'F10 Finalizar
        End Select
    End Sub
    Private Sub TxbCodItem_KeyUp(sender As Object, e As KeyEventArgs) Handles TxbCodItem.KeyUp

        teclaFuncaoF(e)
    End Sub

    Private Sub TxbCodFormaPagto_KeyUp(sender As Object, e As KeyEventArgs) Handles TxbCodFormaPagto.KeyUp
        teclaFuncaoF(e)
    End Sub
    Private Sub limparDescontoAcrescimo()
        TxbPorcAcrescimo.Text = "0"
        TxbPorcDesconto.Text = "0"
        TxbValAcrescimo.Text = "0"
        TxbValDesconto.Text = "0"
        LbValAcresc.Text = "0,00"
        LbValDesc.Text = "0,00"
        LbPorcDesc.Text = "0,00"
        LbPorcAcresc.Text = "0,00"
        LbValAcrescPg.Text = "0,00"
        LbValDescPg.Text = "0,00"
        LbPorcDescPg.Text = "0,00"
        LbPorcAcrescPg.Text = "0,00"
    End Sub
    Private Sub BtnDescAcresc_Click(sender As Object, e As EventArgs) Handles BtnDescAcresc.Click
        carregaTelaDescontoAcrescimo()
    End Sub
    Private Sub TxbPorcDesconto_LostFocus(sender As Object, e As EventArgs) Handles TxbPorcDesconto.LostFocus
        If CDbl(TxbPorcDesconto.Text) > 0 Then
            TxbValDesconto.Text = "0"
        End If
    End Sub
    Private Sub TxbValDesconto_LostFocus(sender As Object, e As EventArgs) Handles TxbValDesconto.LostFocus
        If CDbl(TxbValDesconto.Text) > 0 Then
            TxbPorcDesconto.Text = "0"
        End If
    End Sub
    Private Sub TxbPorcAcrescimo_LostFocus(sender As Object, e As EventArgs) Handles TxbPorcAcrescimo.LostFocus
        If CDbl(TxbPorcAcrescimo.Text) > 0 Then
            TxbValAcrescimo.Text = "0"
        End If
    End Sub
    Private Sub TxbValAcrescimo_LostFocus(sender As Object, e As EventArgs) Handles TxbValAcrescimo.LostFocus
        If CDbl(TxbValAcrescimo.Text) > 0 Then
            TxbPorcAcrescimo.Text = "0"
        End If
    End Sub
    Public Sub calculaPorcentagemDescontoAcrescimo(valor As Double)
        If tela = "venda" Then
            If CDbl(LbPorcAcresc.Text) > 0 Then
                LbValAcresc.Text = valor / 100 * CDbl(LbPorcAcresc.Text)
            End If
            If CDbl(LbPorcDesc.Text) > 0 Then
                LbValDesc.Text = valor / 100 * CDbl(LbPorcDesc.Text)
            End If
        Else
            If CDbl(LbPorcAcrescPg.Text) > 0 Then
                LbValAcrescPg.Text = valor / 100 * CDbl(LbPorcAcrescPg.Text)
            End If
            If CDbl(LbPorcDescPg.Text) > 0 Then
                LbValDescPg.Text = valor / 100 * CDbl(LbPorcDescPg.Text)
            End If
        End If
    End Sub

    Private Sub DgvPagamento_DoubleClick(sender As Object, e As EventArgs) Handles DgvPagamento.DoubleClick
        If MsgBox("Deseja excluir o Pagamento :   " & DgvPagamento.CurrentRow.Cells(1).Value.ToString & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            excluirPagamento()
        End If
    End Sub
    Private Sub excluirPagamento()
        '/ Remover linha selecionada
        '/se não tem linhas então sai
        Try
            If DgvPagamento.RowCount = 0 Then
                TxbCodFormaPagto.Select()
                DgvPagamento.Enabled = False
                Exit Sub
            End If
            '//remove a linha atual selecionada
            Me.calculaSaldoRestante(CDbl(DgvPagamento.CurrentRow.Cells(2).Value.ToString) * (-1))
            DgvPagamento.Rows.Remove(DgvPagamento.CurrentRow)
            DgvPagamento.Refresh()
            DgvPagamento.Enabled = False
            TxbCodFormaPagto.Select()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxbCodBarra_TextChanged(sender As Object, e As EventArgs) Handles TxbCodBarra.TextChanged
        buscaItem()
    End Sub
    Private Sub TxbValorPagto_KeyUp(sender As Object, e As KeyEventArgs) Handles TxbValorPagto.KeyUp
        If e.KeyCode = 121 Then
            finalizarVenda()
        End If
        If TxbValorPagto.Text = "0,00" And e.KeyCode = 9 And CDbl(TxbSaldoRestante.Text) > 0 Then
            If contValPagamento = 2 Then
                If MsgBox("liquidar pagamento restante?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                    TxbValorPagto.Text = TxbSaldoRestante.Text
                End If
                contValPagamento = 0
            End If
            contValPagamento = contValPagamento + 1
        End If

    End Sub

    Private Sub BtnCadItem_Click(sender As Object, e As EventArgs) Handles BtnCadItem.Click
        If FrmItem.WindowState = FormWindowState.Minimized Then
            FrmItem.WindowState = FormWindowState.Normal
            FrmItem.Activate()
        Else
            FrmItem.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnFecharCaixa.Click
        If MsgBox("Deseja Fechar o caixa ?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            TabControl1.SelectedIndex = 6
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConfirmaDescAcresc.Click
        If tela = "venda" Then
            LbPorcAcresc.Text = TxbPorcAcrescimo.Text
            LbPorcDesc.Text = TxbPorcDesconto.Text
            LbValAcresc.Text = TxbValAcrescimo.Text
            LbValDesc.Text = TxbValDesconto.Text
            carregaTelaVenda()
        Else
            LbPorcAcrescPg.Text = TxbPorcAcrescimo.Text
            LbPorcDescPg.Text = TxbPorcDesconto.Text
            LbValAcrescPg.Text = TxbValAcrescimo.Text
            LbValDescPg.Text = TxbValDesconto.Text
            carregaTelaPagamento()
        End If
    End Sub

    Private Sub BtnSangriaConfirma_Click(sender As Object, e As EventArgs) Handles BtnSangriaConfirma.Click
        If TxbSangriaValor.Text = "" Then
            MsgBox("Informe o valor da sangria!", MsgBoxStyle.Information, "Informação")
            TxbSangriaValor.Select()
            Exit Sub
        End If
        Dim sangria As New ClSangria
        sangria.val_sangria = TxbSangriaValor.Text
        sangria.des_observacao = TxbSangriaObs.Text
        sangria.seq_fechamento = LbSeqFechamento.Text
        sangria.Cadastrar()
        If ModParametroSistema.erro Then
            ModParametroSistema.erro = False
            Exit Sub
        End If
        MsgBox("Sangria efetuada com sucesso!", MsgBoxStyle.OkOnly, "Sucesso")
        carregaTelaVenda()
    End Sub

    Private Sub BtnSangriaCancela_Click(sender As Object, e As EventArgs) Handles BtnSangriaCancela.Click
        carregaTelaVenda()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles BtnFechaCxCancela.Click
        carregaTelaVenda()
    End Sub

    Private Sub BtnFechaCxConfirmar_Click(sender As Object, e As EventArgs) Handles BtnFechaCxConfirmar.Click
        Try
            Dim fecha As New ClFechamentoCaixaPdv
            fecha.des_observacao = TxbFechaCxObs.Text
            fecha.val_troco_final = TxbFechaCxSaldoFinal.Text
            fecha.ind_status = "F"
            fecha.fecharCaixa(LbSeqFechamento.Text)
            limparGeral()
            LbNomCliente.Text = "Caixa Fechado"
            LbSeqFechamento.Text = 0
            LbTurno.Text = 0
            TxbCodItem.Enabled = False
            LbNomOperador.Text = "Sem Operador Definido"
            carregaTelaVenda()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnSangria_Click(sender As Object, e As EventArgs) Handles BtnSangria.Click
        carregaTelaSangria()
    End Sub

    Private Sub DtpDta_ValueChanged(sender As Object, e As EventArgs) Handles DtpDta1Vencto.ValueChanged
        TxbDta1Vecto.Text = DtpDta1Vencto.Value.ToShortDateString
    End Sub

    Private Sub BtnConfirmaNotaPrazo_Click(sender As Object, e As EventArgs) Handles BtnConfirmaNotaPrazo.Click
        If TxbCodClienteNotaPrazo.Text = "" Then
            MsgBox("Informe o cliente!", MsgBoxStyle.Information, "Informação")
            TxbCodClienteNotaPrazo.Select()
            Exit Sub
        End If
        If TxbDta1Vecto.Text = "" Then
            MsgBox("Informe Data 1° Vencimento!", MsgBoxStyle.Information, "Informação")
            TxbDta1Vecto.Select()
            Exit Sub
        End If
        If TxbQtdParcNotaPrazo.Text = "" Then
            TxbQtdParcNotaPrazo.Text = "1"
        End If
        DgvFormaPagto.Enabled = True
        GbBotaoAtalho.Enabled = True
        TabControl2.SelectedIndex = 0
        TxbValorPagto.Select()
    End Sub

    Private Sub BtnCancelaNotaPrazo_Click(sender As Object, e As EventArgs) Handles BtnCancelaNotaPrazo.Click
        TabControl2.SelectedIndex = 0
        DgvFormaPagto.Enabled = True
        GbBotaoAtalho.Enabled = True
        TxbCodFormaPagto.Text = ""
        TxbCodFormaPagto.Select()
    End Sub

    Private Sub BtnBuscaClienteNotaPrazo_Click(sender As Object, e As EventArgs) Handles BtnBuscaClienteNotaPrazo.Click
        FrmPesquisa.tabela = "tab_pessoa"
        FrmPesquisa.ShowDialog()
        TxbCodClienteNotaPrazo.Text = ModVariavelGlobal.pesquisaCodigo
        TxbNomClienteNotaPrazo.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
        TxbQtdParcNotaPrazo.Select()
    End Sub

    Private Sub BtnCadPessoNotaPrazo_Click(sender As Object, e As EventArgs) Handles BtnCadPessoNotaPrazo.Click
        If FrmPessoa.WindowState = FormWindowState.Minimized Then
            FrmPessoa.WindowState = FormWindowState.Normal
            FrmPessoa.Activate()
        Else
            FrmPessoa.Show()
        End If
    End Sub

    Private Sub TxbQtdParcCartao_LostFocus(sender As Object, e As EventArgs) Handles TxbQtdParcCartao.LostFocus
        BtnConfirmaCartao.Select()
    End Sub

    Private Sub BtnConfirmaCartao_Click(sender As Object, e As EventArgs) Handles BtnConfirmaCartao.Click
        If TxbQtdParcCartao.Text = "" Then
            TxbQtdParcCartao.Text = "1"
        End If
        DgvFormaPagto.Enabled = True
        GbBotaoAtalho.Enabled = True
        TabControl2.SelectedIndex = 0
        TxbValorPagto.Select()
    End Sub

    Private Sub BtnCancelaCartao_Click(sender As Object, e As EventArgs) Handles BtnCancelaCartao.Click
        TabControl2.SelectedIndex = 0
        DgvFormaPagto.Enabled = True
        GbBotaoAtalho.Enabled = True
        TxbCodFormaPagto.Text = ""
        TxbCodFormaPagto.Select()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        limparGeral()
        carregaTelaVenda()
    End Sub

    Private Sub carregaTelaDescontoAcrescimo()
        TxbCodItem.Text = ""
        TxbCodFormaPagto.Text = ""
        BtnTelaItem.Enabled = False
        BtnTelaPagamento.Enabled = False
        BtnTelaPessoa.Enabled = False
        btnTelaVenda.Enabled = True
        BtnExcluir.Enabled = False
        BtnFinalizar.Enabled = False
        BtnDescAcresc.Enabled = False
        limparDescontoAcrescimo()
        TabControl1.SelectedIndex = 4
        TxbPorcDesconto.Select()
    End Sub
    Private Sub carregaTelaVenda()
        BtnTelaItem.Enabled = True
        BtnTelaPagamento.Enabled = True
        BtnTelaPessoa.Enabled = True
        btnTelaVenda.Enabled = False
        BtnExcluir.Enabled = True
        BtnFinalizar.Enabled = False
        BtnDescAcresc.Enabled = True
        DgvVenda.Enabled = False

        tela = "venda"

        TabControl1.SelectedIndex = 0
        TxbCodItem.Select()
    End Sub
    Private Sub carregaTelaSangria()
        BtnTelaItem.Enabled = False
        BtnTelaPagamento.Enabled = False
        BtnTelaPessoa.Enabled = False
        btnTelaVenda.Enabled = True
        BtnExcluir.Enabled = False
        BtnFinalizar.Enabled = False
        BtnDescAcresc.Enabled = False
        BtnFecharCaixa.Enabled = False
        BtnCadItem.Enabled = False
        BtnCadPessoa.Enabled = False

        TxbSangriaObs.Text = ""
        TxbSangriaValor.Text = ""
        TabControl1.SelectedIndex = 5
        TxbSangriaValor.Select()
    End Sub
    Private Sub carregaTelaItem()
        BtnTelaItem.Enabled = False
        BtnTelaPagamento.Enabled = False
        BtnTelaPessoa.Enabled = False
        btnTelaVenda.Enabled = True
        BtnExcluir.Enabled = False
        BtnFinalizar.Enabled = False
        BtnDescAcresc.Enabled = False

        TxbCodBarra.Text = ""
        txbBuscaDesItem.Text = ""
        TabControl1.SelectedIndex = 3
        txbBuscaDesItem.Select()
    End Sub
    Private Sub carregaTelaPessoa()
        If DgvVenda.Rows.Count > 0 Then
            MsgBox("Cliente deve ser informado antes do lançamento dos item", MsgBoxStyle.Information, "Informação")
            Exit Sub
        End If
        BtnTelaItem.Enabled = False
        BtnTelaPagamento.Enabled = False
        BtnTelaPessoa.Enabled = False
        btnTelaVenda.Enabled = True
        BtnExcluir.Enabled = False
        BtnFinalizar.Enabled = False
        BtnDescAcresc.Enabled = False

        TxbBuscaNomPessoa.Text = ""

        buscaPessoa(TxbBuscaNomPessoa.Text)
        TabControl1.SelectedIndex = 2
        TxbBuscaNomPessoa.Select()
    End Sub
    Private Sub carregaTelaPagamento()
        If DgvVenda.Rows.Count = 0 Then
            Exit Sub
        End If
        BtnTelaItem.Enabled = True
        BtnTelaPagamento.Enabled = False
        BtnTelaPessoa.Enabled = True
        btnTelaVenda.Enabled = True
        BtnExcluir.Enabled = True
        BtnFinalizar.Enabled = True
        BtnDescAcresc.Enabled = True
        DgvPagamento.Enabled = False

        tela = "pagamento"

        If totalGeral = 0 Then
            Exit Sub
        End If
        TabControl2.SelectedIndex = 0
        TabControl1.SelectedIndex = 1

        TxbTotalGeralPg.Text = Convert.ToString(FormatNumber(totalGeralLiquido, 2))
        calculaPorcentagemDescontoAcrescimo(totalGeralLiquido)
        calculaSaldoRestante(CDbl(TxbValorPagto.Text))

        TxbCodFormaPagto.Select()
    End Sub
    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
        finalizarVenda()
    End Sub
    Private Sub finalizarVenda()
        If DgvVenda.RowCount <= 0 Then
            MsgBox("Informe os itens da venda", MsgBoxStyle.Information, "Informação")
            carregaTelaVenda()
            Exit Sub
        End If
        If DgvPagamento.RowCount <= 0 Then
            MsgBox("Informe os Pagamentos da venda", MsgBoxStyle.Information, "Informação")
            Exit Sub
        End If
        If CDbl(TxbSaldoRestante.Text) > 0 Then
            MsgBox("Valor pendente para liquidar de: " & TxbSaldoRestante.Text & "!", MsgBoxStyle.Information, "Informação")
            Exit Sub
        End If
        'calculaPorcentagemDescontoAcrescimo(CDbl(0))
        salvar()
        limparGeral()

        carregaTelaVenda()
    End Sub
    Private Sub salvar()
        Try
            Dim ultimo As New DataSet
            ultimo = clNota.UltimaCadastrado
            Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
            clNota.seq_nota = Convert.ToInt16(ult) + 1

            ultimo.Clear()
        Catch ex As Exception
        End Try
        'Nota fiscal
        clNota.cod_empresa = ModParametroSistema.cod_empresa
        clNota.num_nota = clNota.seq_nota
        clNota.dta_emissao = Today.ToShortDateString
        clNota.dta_saida = Today.ToShortDateString
        clNota.hra_emissao = Now.ToShortTimeString
        clNota.cod_pessoa_cliente = CUInt(LbCodCliente.Text)
        clNota.cod_pessoa_representante = 1
        clNota.cod_usuario = ModPermissaoUsuario.codUsuario
        clNota.val_desconto_produto = FormatNumber(totalDescontoItem, 2)
        clNota.val_acrescimo_produto = FormatNumber(totalAcrescimoItem, 2)
        clNota.val_acrescimo = CDbl(FormatNumber(LbValAcrescPg.Text, 2))
        clNota.val_desconto = CDbl(FormatNumber(LbValDescPg.Text, 2))
        clNota.val_total_produto = FormatNumber(CDbl(TxbTotalGeralPg.Text).ToString, 2)
        clNota.val_total_servico = "0"
        clNota.val_total_nota = FormatNumber(TxbTotalGeralPg.Text, 2)
        clNota.val_troco = FormatNumber(txbTroco.Text, 2)
        clNota.des_observacao = ""
        clNota.ind_status = "I"
        clNota.cod_usuario_cancelamento = 0
        clNota.dta_cancelamento = Nothing
        clNota.seq_fechamento = LbSeqFechamento.Text
        clNota.cod_pdv = LbCodPdv.Text
        clNota.seq_turno = LbTurno.Text
        Try
            clNota.Cadastrar()
            'If ModParametroSistema.erro Then
            'ModParametroSistema.erro = False
            'Exit Sub
            'End If

        Catch ex As Exception
        End Try
        'ITENS DA NOTA FISCA 
        For x As Integer = 0 To DgvVenda.RowCount - 1
            clItemNfs.seq_nota = clNota.seq_nota
            clItemNfs.seq_item_nota = x + 1
            clItemNfs.cod_item = DgvVenda.Rows(x).Cells(0).Value
            clItemNfs.des_item = DgvVenda.Rows(x).Cells(1).Value
            clItemNfs.qtd_item = DgvVenda.Rows(x).Cells(2).Value
            clItemNfs.cod_unidade = DgvVenda.Rows(x).Cells(9).Value
            clItemNfs.qtd_item_convertido = FormatNumber(DgvVenda.Rows(x).Cells(2).Value.ToString, 2)
            clItemNfs.val_unitario = FormatNumber(DgvVenda.Rows(x).Cells(6).Value.ToString, 2)
            clItemNfs.val_desconto = FormatNumber(DgvVenda.Rows(x).Cells(4).Value.ToString, 2)
            clItemNfs.val_acrescimo = FormatNumber(DgvVenda.Rows(x).Cells(5).Value.ToString, 2)
            clItemNfs.val_bruto_item = FormatNumber(CDbl(DgvVenda.Rows(x).Cells(7).Value.ToString) + CDbl(DgvVenda.Rows(x).Cells(4).Value.ToString) - CDbl(DgvVenda.Rows(x).Cells(5).Value.ToString), 2)

            Try
                clItemNfs.Cadastrar()
            Catch ex As Exception
            End Try
        Next

        'pagamento nfs
        For x As Integer = 0 To DgvPagamento.RowCount - 1
            clPagamento.seq_nota = clNota.seq_nota
            clPagamento.seq_pagamento = x + 1
            clPagamento.cod_forma_pagamento = DgvPagamento.Rows(x).Cells(0).Value
            clPagamento.val_pagamento = DgvPagamento.Rows(x).Cells(2).Value
            clPagamento.qtd_parcela = DgvPagamento.Rows(x).Cells(3).Value
            clPagamento.dta_vencimento = DgvPagamento.Rows(x).Cells(4).Value
            clPagamento.cod_pessoa = DgvPagamento.Rows(x).Cells(5).Value
            Try
                clPagamento.Cadastrar()
            Catch ex As Exception
            End Try
        Next
        Try
            seqNota = clNota.seq_nota
            PrintDocRelResumoVenda.Print()
        Catch ex As Exception
        End Try

    End Sub

End Class