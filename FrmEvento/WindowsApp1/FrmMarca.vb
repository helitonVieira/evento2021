Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmMarca

    Dim conectar As New ConexaoSQL
        Dim ds, dsUltimo As New DataSet
    Dim marca, marca2 As New ClMarca
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
        ds = marca.Consultar(cod, desc)
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

            marca.des_marca = TxbDescricao.Text
            desc = TxbDescricao.Text

            If atualizar = 1 Then
                'pegar o ultimo registro
                Try
                    Dim ultimo As New DataSet
                    ultimo = marca2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    marca.cod_marca = Convert.ToInt16(ult) + 1

                    marca.Cadastrar()
                    TxbCodigo.Text = marca.cod_marca
                    ultimo.Clear()
                Catch ex As Exception
                    marca.cod_marca = 1
                End Try
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            Else
                marca.cod_marca = TxbCodigo.Text
                marca.Atualizar()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
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
        If MsgBox("Deseja excluir a :   " & TxbDescricao.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                marca.cod_marca = TxbCodigo.Text
                marca.Excluir()
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
                .Columns(1).Width = 294

            End With

        Catch ex As Exception

        End Try
    End Sub


    Public Sub carregaFormulario()
        Try
            limpar()
            If ds.Tables(0).Rows.Count > 0 Then
                atualizar = 2
                TxbCodigo.Text = ds.Tables(0).Rows(i)("cod_marca").ToString
                TxbDescricao.Text = ds.Tables(0).Rows(i)("des_marca").ToString
                TxbCodigo.Enabled = False
            Else
                atualizar = 1
                TxbCodigo.Enabled = True
            End If
            carregaOld
        Catch ex As Exception

        End Try
    End Sub
    Private Sub carregaOld()
        cod = TxbCodigo.Text
        desc = TxbDescricao.Text
    End Sub
    Public Sub verificarAuteracao()
            If TxbCodigo.Text = "" Then
                Exit Sub
            End If
            If desc <> TxbDescricao.Text Then
                If MsgBox("Descrição foi alterada deseja salvar alteração?       Anterior: " & desc & "     Nova Descrição: " & TxbDescricao.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                    salvaRegistro()
                End If
            End If
        End Sub

    Private Sub Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t120107 = False Then
                MsgBox("Usuário sem permissão para acessar a Marca!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
            BtnSalvar.Enabled = ModPermissaoUsuario.t1201071
            BtnExcluir.Enabled = ModPermissaoUsuario.t1201072
        End If
        limpar()
        'Me.Width = Me.Width + 200
        TabControl1.SelectedIndex = 0
        Me.Height = 145
        Dgv.DataSource = Nothing


    End Sub

    Private Sub BtnGrid_Click(sender As Object, e As EventArgs) Handles BtnGrid.Click
            If TabControl1.SelectedIndex = 1 Then
                TabControl1.SelectedIndex = 0
                Me.Height = 158
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

    Private Sub TxbCodigo_TextChanged(sender As Object, e As EventArgs)
            If Not IsNumeric(TxbCodigo.Text) Then
                TxbCodigo.Text = ""
            End If
        End Sub
    Private Overloads Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        Me.TxbCodigo.Text = Dgv.CurrentRow.Cells(0).Value
        Me.TxbDescricao.Text = Dgv.CurrentRow.Cells(1).Value
        carregaOld()
        TabControl1.SelectedIndex = 0
        Me.Height = 145
        Me.TxbDescricao.Select()
    End Sub
    Private Overloads Sub Dgv_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellEnter
            i = Dgv.CurrentRow.Index
            carregaFormulario()
        End Sub
    End Class
