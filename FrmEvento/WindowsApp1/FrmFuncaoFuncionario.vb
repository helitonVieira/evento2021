Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmFuncaoFuncionario
    Dim conectar As New ConexaoSQL
    Dim ds, dsUltimo As New DataSet
    Dim funcao, funcao2 As New ClFuncaoFuncionario
    Dim atualizar As Integer = 1
    Dim cod As Integer
    Dim desc As String
    Dim i As Integer = 0

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click


        If TxbCodigo.Text = "" Then
            cod = 0
        Else
            cod = TxbCodigo.Text
        End If
        desc = TxbDescricao.Text
        atualizaDados()

    End Sub
    Public Sub atualizaDados()
        Dim tabela As DataTable
        ds = funcao.ConsultarFuncaoFuncionario(cod, desc)
        tabela = ds.Tables(0)

        If tabela.Rows.Count > 0 Then
            Dgv.DataSource = Nothing
            Dgv.DataSource = ds.Tables(0)
            formatarGrid()
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

            funcao.des_funcao_funcionario = TxbDescricao.Text
            desc = TxbDescricao.Text

            If atualizar = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                ultimo = funcao2.UltimoFuncaoFuncionarioCadastrado
                Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                funcao.cod_funcao_funcionario = Convert.ToInt16(ult) + 1

                funcao.CadastrarFuncaoFuncionario()
                ultimo.Clear()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox("Função Funcionario cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            Else
                funcao.cod_funcao_funcionario = TxbCodigo.Text
                funcao.AtualizarFuncaoFuncionario()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox("Função Funcionario Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                i = 0
                atualizaDados()
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a Função Funcionario:   " & TxbDescricao.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                funcao.cod_funcao_funcionario = TxbCodigo.Text
                funcao.ExcluirFuncaoFuncionario()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox("Função Funcionario excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()
                limpar()

            Catch ex As Exception
                MsgBox("Erro ao excluir Função Funcionario, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        verificarAutefuncaoo()
        limpar()
        Dgv.DataSource = Nothing
        TxbCodigo.Enabled = True
        TabControl1.SelectedIndex = 0
        Me.Height = 155
    End Sub
    Public Sub limpar()
        TxbCodigo.Text = ""
        TxbDescricao.Text = ""
        atualizar = 1
    End Sub
    Public Sub formatarGrid()
        Try
            With Dgv
                .Columns(0).HeaderText = "Código"
                .Columns(1).HeaderText = "Descrição"
                .Columns(0).Width = 60
                .Columns(1).Width = 309
            End With
        Catch ex As Exception
        End Try
    End Sub
    Public Sub carregaFormulario()
        Try
            limpar()
            atualizar = 2
            TxbCodigo.Text = ds.Tables(0).Rows(i)("cod_funcao_funcionario").ToString
            TxbDescricao.Text = ds.Tables(0).Rows(i)("des_funcao_funcionario").ToString
            desc = TxbDescricao.Text
            TxbCodigo.Enabled = False
        Catch ex As Exception
        End Try
    End Sub
    Public Sub verificarAutefuncaoo()
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        If desc <> TxbDescricao.Text Then
            If MsgBox("Descrição foi alterada deseja salvar alteração?       Anterior: " & desc & "     Nova Descrição: " & TxbDescricao.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                salvaRegistro()
            End If
        End If
    End Sub

    Private Sub FrmFuncaoFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t110102 = False Then
                MsgBox("Usuário sem permissão para acessar a Grupo Funcionario!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
            BtnSalvar.Enabled = ModPermissaoUsuario.t1101021
            BtnExcluir.Enabled = ModPermissaoUsuario.t1101022
        End If
        Me.Height = 145
        limpar()
    End Sub

    Private Sub BtnGrid_Click(sender As Object, e As EventArgs) Handles BtnGrid.Click
        If TabControl1.SelectedIndex = 1 Then
            TabControl1.SelectedIndex = 0
            Me.Height = 145
        Else
            TabControl1.SelectedIndex = 1
            Me.Height = 360
        End If
    End Sub
    Private Sub BtnPrimeiroReg_Click(sender As Object, e As EventArgs) Handles BtnPrimeiroReg.Click
        verificarAutefuncaoo()
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                i = 0
                carregaFormulario()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        verificarAutefuncaoo()
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
        verificarAutefuncaoo()
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                i = ds.Tables(0).Rows.Count - 1
            End If
        Catch ex As Exception
        End Try
        carregaFormulario()
    End Sub
    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        verificarAutefuncaoo()
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
    Private Sub TxbCodigo_TextChanged_1(sender As Object, e As EventArgs) Handles TxbCodigo.TextChanged
        If Not IsNumeric(TxbCodigo.Text) Then
            TxbCodigo.Text = ""
        End If
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

        nomArquivo = "FuncaoFuncionario_" & dataAtual & "_" & horaMin

        Dim CSV As System.IO.StreamWriter = New System.IO.StreamWriter(nomPasta & "\FuncaoFuncionario_" & nomArquivo & ".csv"
                                                                               )
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
    End Sub
    Private Overloads Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        Me.TxbCodigo.Text = Dgv.CurrentRow.Cells(0).Value
        Me.TxbDescricao.Text = Dgv.CurrentRow.Cells(1).Value
        TabControl1.SelectedIndex = 0
        Me.Height = 145
        Me.TxbDescricao.Select()
    End Sub
    Private Overloads Sub Dgv_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellEnter
        i = Dgv.CurrentRow.Index
        carregaFormulario()
    End Sub
End Class
