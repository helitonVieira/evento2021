Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmSecao

    Dim conectar As New ConexaoSQL
    Dim ds, dsUltimo As New DataSet
    Dim secao, secao2 As New ClSecaoItem
    Dim atualizar As Integer = 1
    Dim cod_old, desc_old, cod_almoxarifado_old As String
    Dim i As Integer = 0
    Private Sub Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t120102 = False Then
                MsgBox("Usuário sem permissão para acessar a Seção!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
            BtnSalvar.Enabled = ModPermissaoUsuario.t1201021
            BtnExcluir.Enabled = ModPermissaoUsuario.t1201022
        End If
        limpar()
        Label18.Text = "Seção:"
        'Me.Width = Me.Width + 200
        tab_control1Selelct()
        Dgv.DataSource = Nothing
    End Sub
    Public Sub tab_control1Selelct()
        TabControl1.SelectedIndex = 0
        Me.Height = 165
    End Sub
    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click


        If TxbCodigo.Text = "" Then
            cod_old = 0
        Else
            cod_old = TxbCodigo.Text
        End If
        If TxbCodAlmoxarifado.Text = "" Then
            cod_almoxarifado_old = 0
        Else
            cod_almoxarifado_old = TxbCodAlmoxarifado.Text
        End If
        desc_old = TxbDescricao.Text
        atualizaDados()

    End Sub
    Public Sub atualizaDados()
        If cod_almoxarifado_old = "" Then
            cod_almoxarifado_old = "0"
        End If
        If cod_old = "" Then
            cod_old = 0
        End If
        Dim tabela As DataTable
        ds = secao.Consultar(cod_old, desc_old, cod_almoxarifado_old)
        tabela = ds.Tables(0)

        If tabela.Rows.Count > 0 Then
            Dgv.DataSource = Nothing
            Dgv.DataSource = ds.Tables(0)
            formatarGrid()
            carregaFormulario()
        End If
    End Sub
    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaRegistro()
    End Sub
    Public Sub salvaRegistro()
        Try
            If TxbDescricao.Text = "" Then
                MsgBox("INFORME NOME DO ITEM")
                TxbDescricao.Select()
                Exit Sub
            End If
            If TxbCodAlmoxarifado.Text = "" Then
                MsgBox("INFORME O ALMOXARIFADO")
                TxbCodAlmoxarifado.Select()
                Exit Sub
            End If

            secao.des_secao = TxbDescricao.Text
            secao.cod_almoxarifado = TxbCodAlmoxarifado.Text
            desc_old = TxbDescricao.Text

            If atualizar = 1 Then
                'pegar o ultimo registro
                Try
                    Dim ultimo As New DataSet
                    ultimo = secao2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    secao.cod_secao = Convert.ToInt16(ult) + 1

                    ultimo.Clear()
                Catch ex As Exception
                    secao.cod_secao = 1
                End Try
                secao.Cadastrar()
                TxbCodigo.Text = secao.cod_secao
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            Else
                secao.cod_secao = TxbCodigo.Text
                secao.Atualizar()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                i = 0

            End If
            atualizaDados()
            carregaOld()
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a :   " & TxbDescricao.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                secao.cod_secao = TxbCodigo.Text
                secao.Excluir()
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        verificarAuteracao()
        limpar()
        Dgv.DataSource = Nothing
        TxbCodigo.Enabled = True
        TabControl1.SelectedIndex = 0
        Me.Height = 165
    End Sub
    Public Sub limpar()
        TxbCodigo.Text = ""
        TxbDescricao.Text = ""
        TxbCodAlmoxarifado.Text = ""
        txbDesAlmoxarifado.Text = ""
        cod_old = 0
        desc_old = ""
        cod_almoxarifado_old = ""
        atualizar = 1

    End Sub
    Public Sub formatarGrid()
        Try
            With Dgv
                .Columns(0).HeaderText = "Cód.Seção"
                .Columns(1).HeaderText = "Des.Seção"
                .Columns(2).HeaderText = "Cód.Almoxarifado"
                .Columns(3).HeaderText = "Des.almoxarifado"
                .Columns(0).Width = 40
                .Columns(1).Width = 150
                .Columns(2).Width = 40
                .Columns(3).Width = 150
            End With

        Catch ex As Exception
        End Try
    End Sub
    Public Sub carregaFormulario()
        Try
            limpar()
            If ds.Tables(0).Rows.Count > 0 Then
                atualizar = 2
                TxbCodigo.Text = ds.Tables(0).Rows(i)("cod_secao").ToString
                TxbDescricao.Text = ds.Tables(0).Rows(i)("des_secao").ToString
                TxbCodAlmoxarifado.Text = ds.Tables(0).Rows(i)("cod_almoxarifado").ToString
                txbDesAlmoxarifado.Text = ds.Tables(0).Rows(i)("des_almoxarifado").ToString

                TxbCodigo.Enabled = False
            Else
                atualizar = 1
                TxbCodigo.Enabled = True
            End If
            carregaOld()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub carregaOld()
        cod_old = TxbCodigo.Text
        desc_old = TxbDescricao.Text
        cod_almoxarifado_old = TxbCodAlmoxarifado.Text
    End Sub
    Public Sub verificarAuteracao()
        Dim msg As String = ""
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        If desc_old <> TxbDescricao.Text Then
            msg = "Descrição Seção" & vbCrLf & "Anterior: " & desc_old & vbCrLf & " Nova : " & TxbDescricao.Text
        End If
        If cod_almoxarifado_old <> TxbCodAlmoxarifado.Text Then
            msg = msg & vbCrLf & "Almoxarifado" & vbCrLf & "Anterior: " & cod_almoxarifado_old & vbCrLf & " Nova : " & TxbCodAlmoxarifado.Text & " " & txbDesAlmoxarifado.Text
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
            Me.Height = 165
        Else
            TabControl1.SelectedIndex = 1
            Me.Height = 322
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
    Private Sub BtnCadSubCategoria_Click(sender As Object, e As EventArgs) Handles BtnCadSubCategoria.Click
        FrmAlmoxarifado.Show()
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
    Private Sub BtEvento_Click(sender As Object, e As EventArgs) Handles BtAlmoxarifado.Click
        FrmPesquisa.tabela = "tab_almoxarifado"
        FrmPesquisa.ShowDialog()
        TxbCodAlmoxarifado.Text = ModVariavelGlobal.pesquisaCodigo
        txbDesAlmoxarifado.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub
    Private Overloads Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        Me.TxbCodigo.Text = Dgv.CurrentRow.Cells(0).Value
        Me.TxbDescricao.Text = Dgv.CurrentRow.Cells(1).Value
        Me.TxbCodAlmoxarifado.Text = Dgv.CurrentRow.Cells(2).Value
        Me.txbDesAlmoxarifado.Text = Dgv.CurrentRow.Cells(3).Value
        TabControl1.SelectedIndex = 0
        Me.Height = 165
        carregaOld()
        Me.TxbDescricao.Select()
    End Sub
End Class
