Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmGrupoUsuario

    Dim conectar As New ConexaoSQL
    Dim ds, dsUltimo As New DataSet
    Dim grupoUsuario, grupoUsuario2 As New ClGrupoUsuario
    Dim atualizar As Integer = 1
    Dim cod As Integer
    Dim desc, ind_ativo_old As String
    Dim i As Integer = 0

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click

        carregaOld()
        atualizaDados()
    End Sub
    Public Sub atualizaDados()
        Dim pe As Boolean
        If CkbPE.Checked Then
            pe = True
        Else
            pe = False
        End If
        Try
            Dim tabela As DataTable
            ds = grupoUsuario.Consultar(cod, desc, ind_ativo_old, pe)
            tabela = ds.Tables(0)

            If tabela.Rows.Count > 0 Then
                Dgv.DataSource = Nothing
                Dgv.DataSource = ds.Tables(0)
                formatarGrid()
                carregaFormulario()
            End If
        Catch ex As Exception
            MsgBox("Erro tentar atualizar dados!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
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

            grupoUsuario.des_grupo_usuario = TxbDescricao.Text
            If CkbAtivo.Checked Then
                grupoUsuario.ind_ativo = "S"
            Else
                grupoUsuario.ind_ativo = "N"
            End If
            desc = TxbDescricao.Text

            If atualizar = 1 Then
                'pegar o ultimo registro
                Try
                    Dim ultimo As New DataSet
                    ultimo = grupoUsuario2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    grupoUsuario.cod_grupo_usuario = Convert.ToInt16(ult) + 1

                    grupoUsuario.Cadastrar()
                    TxbCodigo.Text = grupoUsuario.cod_grupo_usuario
                    ultimo.Clear()
                Catch ex As Exception
                    grupoUsuario.cod_grupo_usuario = 1
                End Try
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            Else
                grupoUsuario.cod_grupo_usuario = TxbCodigo.Text
                grupoUsuario.Atualizar()
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
                grupoUsuario.cod_grupo_usuario = TxbCodigo.Text
                grupoUsuario.Excluir()
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
        Dgv.DataSource = Nothing
        TxbCodigo.Enabled = True
        TabControl1.SelectedIndex = 0
        Me.Height = 170

    End Sub
    Public Sub limpar()
        TxbCodigo.Text = ""
        TxbDescricao.Text = ""
        CkbAtivo.Checked = True
        CkbPE.Checked = False
        atualizar = 1
        carregaOld()
    End Sub
    Public Sub carregaOld()
        If TxbCodigo.Text = "" Then
            cod = 0
        Else
            cod = TxbCodigo.Text
        End If
        desc = TxbDescricao.Text

        If CkbAtivo.Checked Then
            ind_ativo_old = "S"
        Else
            ind_ativo_old = "N"
        End If
    End Sub
    Public Sub formatarGrid()
        Try
            With Dgv
                .Columns(0).HeaderText = "Código"
                .Columns(1).HeaderText = "Descrição"
                .Columns(2).HeaderText = "Ativo"
                .Columns(0).Width = 60
                .Columns(1).Width = 249
                .Columns(2).Width = 53
            End With
        Catch ex As Exception
        End Try
    End Sub
    Public Sub carregaFormulario()
        Try
            limpar()
            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows.Count = 1 Then
                    i = 0
                End If
                atualizar = 2
                TxbCodigo.Text = ds.Tables(0).Rows(i)("cod_grupo_usuario").ToString
                TxbDescricao.Text = ds.Tables(0).Rows(i)("des_grupo_usuario").ToString
                If ds.Tables(0).Rows(i)("ind_ativo").ToString.Trim = "S" Then
                    CkbAtivo.Checked = True
                Else
                    CkbAtivo.Checked = False
                End If
                TxbCodigo.Enabled = False
            Else
                atualizar = 1
                TxbCodigo.Enabled = True
            End If
            cod = TxbCodigo.Text
            desc = TxbDescricao.Text
        Catch ex As Exception

        End Try
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
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t100101 = False Then
                MsgBox("Usuário sem permissão de acesso ao Grupo Usuário!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
            BtnSalvar.Enabled = ModPermissaoUsuario.t1001011
            BtnExcluir.Enabled = ModPermissaoUsuario.t1001012
        End If
        limpar()
        'Me.Width = Me.Width + 200
        TabControl1.SelectedIndex = 0
        Me.Height = 170
        Dgv.DataSource = Nothing
    End Sub

    Private Sub BtnGrid_Click(sender As Object, e As EventArgs) Handles BtnGrid.Click
        If TabControl1.SelectedIndex = 1 Then
            TabControl1.SelectedIndex = 0
            Me.Height = 170
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

    Private Sub Dgv_CellClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        Me.TxbCodigo.Text = Dgv.CurrentRow.Cells(0).Value
        Me.TxbDescricao.Text = Dgv.CurrentRow.Cells(1).Value
        If Dgv.CurrentRow.Cells(2).Value.ToString.Trim = "S" Then
            CkbAtivo.Checked = True
        Else
            CkbAtivo.Checked = False
        End If
        TabControl1.SelectedIndex = 0
        Me.Height = 145
        Me.TxbDescricao.Select()
        carregaOld()
    End Sub

End Class
