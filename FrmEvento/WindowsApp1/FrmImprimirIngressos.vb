Public Class FrmImprimirIngressos
    Dim conectar As New ConexaoSQL
    Dim ds As New DataSet
    Dim evento As New ClEvento
    Dim Ingresso As New ClIngresso
    Dim IngressoImpresso, IngressoImpresso2 As New ClIngressoImpresso
    Dim paramSistem As New ClParametroSistema
    Dim emp As New ClEmpresa
    Dim valTotalItem, valCustoTotal As String
    Dim nome1, nome2, nome3, dtaEvento, obs1, obs2, lote As String
    Dim posicaoNome As Integer = 0
    Dim numIngresso As Integer
    Dim cod_evento As Integer
    Dim tamFontIngresso, val_img_ingresso_tamanho_altura, val_img_ingresso_tamanho_largura,
       val_img_ingresso_margem_esquerda, val_img_ingresso_margem_cabecalho As Integer



    Public Sub atribuirNome()

        nome1 = DgvEvento.CurrentRow.Cells(2).Value
        nome2 = DgvEvento.CurrentRow.Cells(3).Value
        nome3 = DgvEvento.CurrentRow.Cells(4).Value

        If nome1 = "Null" Then
            nome1 = ""
        End If
        If nome2 = "Null" Then
            nome2 = ""
        End If
        If nome3 = "Null" Then
            nome3 = ""
        End If
    End Sub
    Public Sub atualizarDados()
        '  conectar.Conectar()
        Dim tabela As DataTable
        ds = Ingresso.ConsultarIngressoEventoAberto()
        tabela = ds.Tables(0)

        If tabela.Rows.Count > 0 Then
            DgvEvento.DataSource = ds.Tables(0)
            formatarGrid()
        End If
        limpar()
    End Sub
    Public Sub formatarGrid()
        With DgvEvento
            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Código"
            .Columns(2).HeaderText = "Nome1"
            .Columns(3).HeaderText = "Nome2"
            .Columns(4).HeaderText = "Nome3"
            .Columns(5).HeaderText = "Valor"
            .Columns(6).HeaderText = "Data"
            .Columns(7).HeaderText = "Lote"
            .Columns(8).HeaderText = "Aberto"
            .Columns(9).HeaderText = "Observação1"
            .Columns(10).HeaderText = "Observação2"

            .Columns(0).Width = 60
            .Columns(1).Width = 80
            .Columns(2).Width = 80
            .Columns(3).Width = 80
            .Columns(4).Width = 60
            .Columns(5).Width = 60
            .Columns(6).Width = 60
            .Columns(7).Width = 60
            .Columns(8).Width = 60
            .Columns(9).Width = 60
            .Columns(10).Width = 60
        End With
    End Sub

    Private Sub TxtQtde_LostFocus(sender As Object, e As EventArgs) Handles TxtQtde.LostFocus
        If TxtQtde.Text = "" Then
            TxtQtde.Select()
            Exit Sub
        End If

        If LbDescricao.Text = "" Then
            TxtCodEvento.Select()
            Exit Sub
        End If
        If TxtCodEvento.Text = "" Or LbDescricao.Text = "" Then
            MsgBox("ITEM INVALIDO")
            TxtCodEvento.Select()
            Exit Sub
        End If

        salvar()
        TxtCodEvento.Select()
    End Sub
    Private Sub FrmImprimirIngresso_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'TECLA ENTER
        InsereEnter(Me)
    End Sub
    Private Sub CbFonte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbFonte.SelectedIndexChanged
        LbFonte.Font = New Font(CbFonte.Text, 16.0F, System.Drawing.FontStyle.Bold)
    End Sub

    Private Sub GroupBoxVendas_Enter(sender As Object, e As EventArgs) Handles GroupBoxVendas.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        TxtCodEvento.Visible = True
        TxtQtde.Enabled = True
        DgvEvento.Enabled = True
        CbFonte.Enabled = False
        BtnOK.Enabled = False
        TxtCodEvento.Select()
    End Sub
    Public Sub salvar()
        carregaParametro()
        Try
            IngressoImpresso.cod_evento = cod_evento

            IngressoImpresso.seq_ingresso = TxtCodEvento.Text

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

            IngressoImpresso.qtd_impressa = "0"

            Dim qtdImpressa As Integer = numIngresso

            'IMPRIMIR OS INGRESSOS
            For index As Integer = 1 To TxtQtde.Text
                If ckbTeste.Checked = True Then
                    imprimirLayout()
                    limpar()
                    TxtCodEvento.Select()
                    Exit Sub
                End If
                numIngresso = qtdImpressa + index
                imprimirLayout()

                IngressoImpresso.qtd_impressa = IngressoImpresso.qtd_impressa + 1
            Next
            Try
                Dim ultimo As New DataSet
                ultimo = IngressoImpresso2.UltimoCadastrado
                Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                IngressoImpresso.seq_impressao = Convert.ToInt16(ult) + 1

                ultimo.Clear()
            Catch ex As Exception
                IngressoImpresso.seq_impressao = 1
            End Try
            IngressoImpresso.val_total_impresso = valTotalItem * IngressoImpresso.qtd_impressa
            IngressoImpresso.InserirIngressoImpresso()
            limpar()
            atualizarDados()
            TxtCodEvento.Select()
        Catch ex As Exception
            If IngressoImpresso.qtd_impressa > 0 Then
                IngressoImpresso.val_total_impresso = valTotalItem * IngressoImpresso.qtd_impressa
                IngressoImpresso.InserirIngressoImpresso()
            End If
            MsgBox("ERRO AO SALVAR EVENTO" & ex.Message, MsgBoxStyle.Critical, "Erro")
            TxtCodEvento.Select()
        End Try
        TxtCodEvento.Select()
    End Sub

    Public Sub limpar()
        TxtQtde.Text = ""
        LbDescricao.Text = ""
        TxtQtde.Enabled = False
        TxtCodEvento.Text = ""
        nome1 = ""
        nome2 = ""
        nome3 = ""
        valTotalItem = ""
        TxtCodEvento.Select()
    End Sub

    Private Sub TxtQtde_TextChanged(sender As Object, e As EventArgs) Handles TxtQtde.TextChanged
        If Not IsNumeric(TxtQtde.Text) Then
            TxtQtde.Text = ""
        End If
    End Sub


    Private Sub DgvEvento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEvento.CellClick
        carregarVariaveis()
    End Sub
    Private Sub carregarVariaveis()
        Try
            TxtCodEvento.Text = DgvEvento.CurrentRow.Cells(0).Value
            cod_evento = DgvEvento.CurrentRow.Cells(1).Value
            LbDescricao.Text = DgvEvento.CurrentRow.Cells(2).Value
            numIngresso = DgvEvento.CurrentRow.Cells(12).Value
            TxtQtde.Enabled = True
            TxtQtde.Select()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t180102 = False Then
                MsgBox("Usuário sem permissão para acessar a Cidade!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
            'BtnSalvar.Enabled = ModPermissaoUsuario.t1801021
            'BtnExcluir.Enabled = ModPermissaoUsuario.t1801022
        End If

        limpar()
        atualizarDados()
        carregaParametro()
        TxtCodEvento.Visible = False
        TxtQtde.Enabled = False
        DgvEvento.Enabled = False
        CbFonte.Enabled = True
        BtnOK.Enabled = True
        CbFonte.Select()
        ckbTeste.Checked = False

    End Sub
    Private Sub carregaParametro()
        Dim tabela As DataRow
        ds = paramSistem.consultarParametro()
        tabela = ds.Tables(0).Rows(0)
        tamFontIngresso = tabela.Item(1)
        val_img_ingresso_tamanho_altura = tabela.Item(2)
        val_img_ingresso_tamanho_largura = tabela.Item(3)
        val_img_ingresso_margem_esquerda = tabela.Item(4)
        val_img_ingresso_margem_cabecalho = tabela.Item(5)
    End Sub

    Private Sub TxtQtde_Focus(sender As Object, e As EventArgs) Handles TxtQtde.GotFocus
        If TxtCodEvento.Text = "" Then
            TxtQtde.Enabled = False
            TxtCodEvento.Select()
        End If
    End Sub

    Private Sub TxtCodEvento_LostFocus(sender As Object, e As EventArgs) Handles TxtCodEvento.LostFocus
        If TxtCodEvento.Text = "" Then
            TxtCodEvento.Select()
            cod_evento = 0
            Exit Sub
        End If
        TxtQtde.Enabled = True
        cod_evento = TxtCodEvento.Text
        carregarVariaveis()

        If TxtCodEvento.Text = "" Then
            LbDescricao.Text = ""
        End If
        TxtQtde.Select()
    End Sub

    Private Sub TxtCodEvento_TextChanged(sender As Object, e As EventArgs) Handles TxtCodEvento.TextChanged
        If Not IsNumeric(TxtCodEvento.Text) Then
            TxtCodEvento.Text = ""
        End If
        Try

            For Each row In DgvEvento.Rows
                If TxtCodEvento.Text = row.Cells(0).Value.ToString Then
                    LbDescricao.Text = row.Cells(2).Value.ToString
                    dtaEvento = row.Cells(6).Value.ToString
                    valTotalItem = row.Cells(5).Value.ToString
                    valCustoTotal = "0"
                    lote = row.Cells(7).Value.ToString
                    obs1 = row.Cells(9).Value.ToString
                    obs2 = row.Cells(10).Value.ToString
                    numIngresso = row.Cells(12).Value.ToString
                    atribuirNome()
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

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try

            Dim nomEmpresa As String = ModParametroSistema.nom_fantasia


            Dim reportFont4 As Font = New Drawing.Font("Time New Roman", 4)
            Dim reportFont6 As Font = New Drawing.Font("Time New Roman", 6)
            Dim reportFont14 As Font = New Drawing.Font("Time New Roman", 14)
            If IsNumeric(tamFontIngresso) = False Then
                tamFontIngresso = 10
            End If
            Dim reportFont20 As Font = New Drawing.Font(CbFonte.Text, tamFontIngresso)
            Dim reportFont8 As Font = New Drawing.Font("Time New Roman", 8)
            Dim reportFont60 As Font = New Drawing.Font("Time New Roman", 60)
            Dim numero As Int16 = 99
            Dim newImageEmpresa As Image
            Try
                newImageEmpresa = Image.FromFile("C:\evento\imagem\logoEmpresa.png")

            Catch ex As Exception
                newImageEmpresa = Image.FromFile("C:\evento\imagem\logoEmpresa.jpg")

            End Try


            ' Draw image to screen.
            e.Graphics.DrawImage(newImageEmpresa, val_img_ingresso_margem_esquerda, val_img_ingresso_margem_cabecalho, val_img_ingresso_tamanho_altura, val_img_ingresso_tamanho_largura)
            e.Graphics.DrawString(numIngresso, reportFont14, Brushes.Black, 230, 0)

            e.Graphics.DrawString(nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa, reportFont6, Brushes.Black, 0, 0)
            e.Graphics.DrawString(nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & " " & nomEmpresa, reportFont6, Brushes.Black, 0, 10)

            If ckbTeste.Checked = True Then
                e.Graphics.DrawString("Teste", reportFont60, Brushes.Black, 0, 0)
                e.Graphics.DrawString("Impressão", reportFont60, Brushes.Black, 0, 150)
            End If
            e.Graphics.DrawString(nome1, reportFont20, Brushes.Black, paramSistem.posicaoTamanho20(nome1.Count), 115)
            e.Graphics.DrawString(nome2, reportFont20, Brushes.Black, paramSistem.posicaoTamanho20(nome2.Count), 145)
            e.Graphics.DrawString(nome3, reportFont20, Brushes.Black, paramSistem.posicaoTamanho20(nome3.Count), 175)
            e.Graphics.DrawString(lote, reportFont14, Brushes.Black, paramSistem.posicaoTamanho14(lote.Count), 225)
            Dim totalIngresso As String = ""
            totalIngresso = "R$ " & valTotalItem & ".00"
            e.Graphics.DrawString(totalIngresso, reportFont14, Brushes.Black, paramSistem.posicaoTamanho14(totalIngresso.Count) + 10, 255)

            e.Graphics.DrawString(obs1, reportFont8, Brushes.Black, 30, 285)
            e.Graphics.DrawString(obs2, reportFont8, Brushes.Black, 30, 305)
            e.Graphics.DrawString("Válido apenas para dia:" & dtaEvento, reportFont8, Brushes.Black, 20, 385)
            Dim newImage As Image = Image.FromFile("C:\evento\imagem\CODBARRA.png")

            ' Create coordinates for upper-left corner

            ' of image and for size of image.
            Dim x As Integer = 40
            Dim y As Integer = 325
            Dim width As Integer = 200
            Dim height As Integer = 50

            ' Draw image to screen.
            e.Graphics.DrawImage(newImage, x, y, width, height)
            e.Graphics.DrawString(nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa, reportFont6, Brushes.Black, 0, 415)
            e.Graphics.DrawString(nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa, reportFont6, Brushes.Black, 0, 425)

            ' e.Graphics.DrawString(" ", reportFont1, Brushes.Black, 100, 160)
        Catch ex As Exception

        End Try
    End Sub

End Class