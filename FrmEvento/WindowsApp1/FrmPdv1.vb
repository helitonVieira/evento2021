Public Class FrmPdv1
    Dim conectar As New ConexaoSQL
    Dim dsParamSist, dsVenda, dsItem, dsPessoa, dsFormaPgto, ds As New DataSet
    Dim item As New ClItem1
    Dim clVenda As New ClVenda
    Dim evento As New ClEvento
    Dim pessoa As New ClPessoa
    Dim formaPagto As New ClFormaPagtoPdv
    Dim despesa As New ClDespesa
    Dim paramSistem As New ClParametroSistema
    Dim clLicencia As New ClLicencia
    Dim emp As New ClEmpresa
    Dim valTotalItem, valCustoTotal As String
    Public nomEmpresa, nomEvento As String
    Public codEvento As Integer
    Dim linha As Integer = 0
    Dim totalGeral As Double = 0
    Dim troco As Double = 0
    Dim saldoRestante As Double = 0
    Dim cod_item As Integer
    Dim des_item As String
    Dim qtdImpressa As Integer = 0



    Public Sub carregarGropVenda()

            Dim ds1 As New DataSet
            ds1 = emp.ConsultarEmpresa
            Dim linha As DataRow
            linha = ds1.Tables(0).Rows(0)
            nomEmpresa = linha.Item(1).ToString

            Dim tabela As DataTable
        ds = item.ConsultarItemVenda("", "")
        tabela = ds.Tables(0)

            If tabela.Rows.Count > 0 Then
                DgvItemVenda.DataSource = ds.Tables(0)
            End If
            formatarGrid()
            TxtCodItem.Select()
            TxtQtde.Enabled = False
        End Sub
        Public Sub formatarGrid()
            With DgvItemVenda
                .Columns(0).HeaderText = "Código"
                .Columns(1).HeaderText = "Descrição"
                .Columns(2).HeaderText = "Preço Venda"
                .Columns(0).Width = 60
                .Columns(1).Width = 390
                .Columns(2).Width = 60
                DgvItemVenda.Columns.Item(3).Visible = False



            End With
        End Sub

        Private Sub TxtQtde_LostFocus(sender As Object, e As EventArgs) Handles TxtQtde.LostFocus
            If TxtQtde.Text = "" Then
                TxtQtde.Select()
                Exit Sub
            End If

            If LbDescricao.Text = "" Then
                TxtCodItem.Select()
                Exit Sub
            End If
            If TxtCodItem.Text = "" Or LbDescricao.Text = "" Then
                MsgBox("ITEM INVALIDO")
                TxtCodItem.Select()
                Exit Sub
            End If
            If TxtQtde.Text > 10 Then
                If MsgBox("Mais de 10 itens confirma?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.No Then
                    TxtQtde.Text = ""
                    TxtQtde.Select()
                    Exit Sub
                End If
            End If

            salvar()
            TxtCodItem.Select()
        End Sub

    Private Sub FrmPdv1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'TECLA ENTER
        InsereEnter(Me)
    End Sub

    Public Sub salvar()

        qtdImpressa = 0
        '   TxtCodItem.Select()
        Try
            clVenda.cod_evento = LbCodEvento.Text
            clVenda.cod_item = TxtCodItem.Text
            'verificar qtd
            If TxtQtde.Text = "" Then
                clVenda.qtd_item = "1"
            End If
            'verificar valor custo
            If valCustoTotal = "" Then
                valCustoTotal = "0"
            Else
                valCustoTotal = valCustoTotal.Replace(",", ".")
            End If
            'verificar valor venda
            If valTotalItem = "" Then
                valTotalItem = "0"
            Else
                valTotalItem = valTotalItem.Replace(",", ".")
            End If


            clVenda.ind_tipo = "P"

            'Imprimindo os ingressos
            For index As Integer = 1 To TxtQtde.Text
                imprimirLayout()
            Next

            clVenda.qtd_item = qtdImpressa
            clVenda.val_total_item = valTotalItem * clVenda.qtd_item
            clVenda.val_total_custo_item = valCustoTotal * clVenda.qtd_item
            clVenda.InserirVenda()
            limpar()
            TxtCodItem.Select()
        Catch ex As Exception
            If qtdImpressa > 0 Then
                clVenda.qtd_item = qtdImpressa
                clVenda.InserirVenda()
                MsgBox("Devido a erro de impressão foi salvo apenas:" & qtdImpressa & " de itens!" & ex.Message, MsgBoxStyle.Critical, "Erro")
                TxtCodItem.Select()
            Else
                MsgBox("Erro ao salvar as vendas" & ex.Message, MsgBoxStyle.Critical, "Erro")
                TxtCodItem.Select()
            End If

        End Try
            TxtCodItem.Select()
        End Sub

        Public Sub limpar()
            TxtQtde.Text = ""
            LbDescricao.Text = ""
            TxtQtde.Enabled = False
            TxtCodItem.Text = ""
            TxtCodItem.Select()
        End Sub
    Private Sub FrmPdv1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t140102 = False Then
                MsgBox("Usuário sem permissão para acessar o Cadastro PDV!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
        End If

        limpar()
        carregarGropVenda()
        LbNomeUsuario.Text = FrmPrincipal.LbNomeUsuario.Text
        LbPermissaoUsuario.Text = FrmPrincipal.LbPermissaoUsuario.Text


    End Sub
    Private Sub TxtQtde_Focus(sender As Object, e As EventArgs) Handles TxtQtde.GotFocus
        If TxtCodItem.Text = "" Then
            TxtQtde.Enabled = False
            TxtCodItem.Select()
        End If
    End Sub

    Private Sub TxtCodItem_LostFocus(sender As Object, e As EventArgs) Handles TxtCodItem.LostFocus
            If TxtCodItem.Text = "" Then
                TxtCodItem.Select()
                Exit Sub
            End If
            TxtQtde.Enabled = True
            If TxtCodItem.Text = "" Then
                LbDescricao.Text = ""
            End If
            TxtQtde.Select()
        End Sub

        Private Sub TxtCodItem_TextChanged(sender As Object, e As EventArgs) Handles TxtCodItem.TextChanged
            Try

                For Each row In DgvItemVenda.Rows
                    If TxtCodItem.Text = row.Cells(0).Value.ToString Then
                        LbDescricao.Text = row.Cells(1).Value.ToString
                        valTotalItem = row.Cells(2).Value.ToString
                        valCustoTotal = row.Cells(3).Value.ToString
                        Exit For
                    End If
                Next
            Catch ex As Exception
            End Try
        End Sub
        Public Sub imprimirLayout()
            Try
                PrintDocument1.Print()
            Catch ex As Exception

            End Try
        End Sub


    Private Sub PrintDocRelResumoVenda_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocRelResumoVenda.PrintPage
            imprimiRelResumoVenda(e, LbCodEvento.Text, LbNomEvento.Text, "P")
        End Sub
        Public Sub imprimiRelResumoVenda(e As Printing.PrintPageEventArgs, codEvento As String, nomEvento As String, tipo As String)

            Dim reportFont2 As Font = New Drawing.Font("Time New Roman", 8)
            clVenda.cod_evento = codEvento
            Dim tabela As DataTable
            If tipo = "P" Then
                ds = clVenda.ResumoVendas()
            Else
                ds = clVenda.ResumoVendasIngresso()
            End If

            tabela = ds.Tables(0)
            Dim Row As DataRow
            Dim x As Integer = 0
            If tabela.Rows.Count > 0 Then

                e.Graphics.DrawString("RESUMO EVENTO ", reportFont2, Brushes.Black, 90, x)
                x = x + 20
                e.Graphics.DrawString(codEvento & " " & nomEvento, reportFont2, Brushes.Black, 0, x)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmItem.Show()
        FrmItem.WindowState = FormWindowState.Normal
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
            Dim reportFont20 As Font = New Drawing.Font("Time New Roman", DiminuiFontProduto)
            Dim rept As Font
            des_item = LbDescricao.Text

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
            qtdImpressa = qtdImpressa + 1
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
    Private Sub PrintDocument3_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage
        imprimiRelResumoVenda(e, LbCodEvento.Text, LbNomEvento.Text, "I")
    End Sub
    Private Sub DgvItemVenda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItemVenda.CellClick
        Try
            TxtCodItem.Text = DgvItemVenda.CurrentRow.Cells(0).Value
            LbDescricao.Text = DgvItemVenda.CurrentRow.Cells(1).Value
            TxtQtde.Enabled = True
            TxtQtde.Select()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnResumoVenda_Click(sender As Object, e As EventArgs) Handles BtnResumoVenda.Click
        If LbCodEvento.Text = "" Then
            MsgBox("Um evento tem que estar logado")
            Exit Sub
        End If
        '  Form1.Show()
        Try
            PrintDocRelResumoVenda.Print()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnImprimirIngresso_Click(sender As Object, e As EventArgs) Handles BtnImprimirIngresso.Click
        imprimirIngresso()
    End Sub

    Public Sub imprimirIngresso()
        Try
            FrmImprimirIngressos.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class
   