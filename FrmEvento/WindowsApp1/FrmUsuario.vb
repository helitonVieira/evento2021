Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmUsuario

    Dim conectar As New ConexaoSQL
    Dim ds, dsUltimo As New DataSet
    Dim usuario, usuario2 As New ClUsuario
    Dim atualizar As Integer = 1
    Dim cod_old, desc_old, cod_grupo_usuario_old, des_senha_old, ind_ativo_old As String
    Dim i As Integer = 0
    Private Sub Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t100102 = False Then
                MsgBox("Usuário sem permissão para acessar ao Usuario!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
            BtnSalvar.Enabled = ModPermissaoUsuario.t1001021
            BtnExcluir.Enabled = ModPermissaoUsuario.t1001022
        End If
        limpar()
        Label18.Text = "Usuario:"
        Dgv.DataSource = Nothing
    End Sub
    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click

        If TxbCodigo.Text = "" Then
            cod_old = 0
        Else
            cod_old = TxbCodigo.Text
        End If
        If TxbCodGrupo.Text = "" Then
            cod_grupo_usuario_old = 0
        Else
            cod_grupo_usuario_old = TxbCodGrupo.Text
        End If
        desc_old = TxbDescricao.Text
        des_senha_old = txbSenha.Text
        If CkbAtivo.Checked Then
            ind_ativo_old = "S"
        Else
            ind_ativo_old = "N"
        End If

        atualizaDados()

    End Sub
    Public Sub atualizaDados()
        Dim pe As Boolean
        If CkbPE.Checked Then
            pe = True
        Else
            pe = False
        End If
        If cod_grupo_usuario_old = "" Then
            cod_grupo_usuario_old = 0
        End If
        If cod_old = "" Then
            cod_old = 0
        End If
        Try
            Dim tabela As DataTable
            ds = usuario.Consultar(CUInt(cod_old), desc_old, ind_ativo_old, CUInt(cod_grupo_usuario_old), pe)
            tabela = ds.Tables(0)

            If tabela.Rows.Count > 0 Then
                Dgv.DataSource = Nothing
                Dgv.DataSource = ds.Tables(0)
                formatarGrid()
                carregaFormulario()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaRegistro()

    End Sub
    Public Sub salvaRegistro()
        Try
            If TxbDescricao.Text = "" Then
                MsgBox("INFORME NOME DO USUÁRIO")
                TxbDescricao.Select()
                Exit Sub
            End If
            If TxbCodigo.Text = "1" Then
                Exit Sub
            End If

            usuario.nom_usuario = TxbDescricao.Text
            If TxbCodGrupo.Text = "" Then
                usuario.cod_grupo_usuario = Nothing
            Else
                usuario.cod_grupo_usuario = TxbCodGrupo.Text
            End If
            If CkbAtivo.Checked Then
                usuario.ind_ativo = "S"
            Else
                usuario.ind_ativo = "N"
            End If
            usuario.des_permissao_usuario = "USUARIO"
            usuario.des_senha = txbSenha.Text
            desc_old = TxbDescricao.Text

            If atualizar = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                Dim ult As String
                Try
                    ultimo = usuario2.UltimoCadastrado
                    ult = ultimo.Tables(0).Rows(0)("ultimo")
                Catch ex As Exception
                    usuario.cod_usuario = 1
                End Try
                usuario.Cadastrar()
                TxbCodigo.Text = Convert.ToInt16(ult) + 1
                ultimo.Clear()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            Else
                usuario.cod_usuario = TxbCodigo.Text
                usuario.Atualizar()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            End If
            i = 0
            carregaOld()
            atualizaDados()
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
                usuario.cod_usuario = TxbCodigo.Text
                usuario.Excluir()
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
    End Sub
    Public Sub limpar()
        TxbCodigo.Text = ""
        TxbDescricao.Text = ""
        TxbCodGrupo.Text = ""
        TxbDesGrupo.Text = ""
        txbSenha.Text = ""
        CkbAtivo.Checked = True
        CkbPE.Checked = False
        carregaOld()
        atualizar = 1
        TabControl1.SelectedIndex = 0
        Me.Height = 180
    End Sub
    Public Sub carregaOld()
        cod_old = TxbCodigo.Text
        desc_old = TxbDescricao.Text
        des_senha_old = txbSenha.Text
        cod_grupo_usuario_old = TxbCodGrupo.Text

    End Sub
    Public Sub formatarGrid()
        Try
            With Dgv
                .Columns(0).HeaderText = "Cód"
                .Columns(1).HeaderText = "Nome"
                .Columns(2).Visible = False
                .Columns(3).HeaderText = False
                .Columns(4).HeaderText = "Ativo"
                .Columns(5).HeaderText = "Grupo"
                .Columns(6).HeaderText = ""
                .Columns(0).Width = 40
                .Columns(1).Width = 150
                .Columns(4).Width = 40
                .Columns(5).Width = 40
                .Columns(6).Width = 150

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
                TxbCodigo.Text = ds.Tables(0).Rows(i)("cod_usuario").ToString
                TxbDescricao.Text = ds.Tables(0).Rows(i)("nom_usuario").ToString
                txbSenha.Text = ds.Tables(0).Rows(i)("des_senha").ToString
                If ds.Tables(0).Rows(i)("cod_grupo_usuario").ToString.Trim = "0" Then
                    TxbCodGrupo.Text = ""
                Else
                    TxbCodGrupo.Text = ds.Tables(0).Rows(i)("cod_grupo_usuario").ToString
                End If
                TxbDesGrupo.Text = ds.Tables(0).Rows(i)("des_grupo_usuario").ToString
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
            carregaOld()

        Catch ex As Exception

        End Try
    End Sub
    Public Sub verificarAuteracao()
        Dim msg As String = ""
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        If desc_old <> TxbDescricao.Text Then
            msg = "Nome Usuário" & vbCrLf & "Anterior: " & desc_old & vbCrLf & " Nova : " & TxbDescricao.Text
        End If
        If des_senha_old <> txbSenha.Text Then
            msg = "Senha foi Alterada"
        End If
        If cod_grupo_usuario_old <> TxbCodGrupo.Text Then
            msg = msg & vbCrLf & "Grupo" & vbCrLf & "Anterior: " & cod_grupo_usuario_old & vbCrLf & " Nova : " & TxbCodGrupo.Text & " " & TxbDesGrupo.Text
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
            Me.Height = 180
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
    Private Sub BtnCadGrupo_Click(sender As Object, e As EventArgs) Handles BtnCadGrupo.Click
        FrmGrupoUsuario.Show()
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
    Private Sub BtnGrupo_Click(sender As Object, e As EventArgs) Handles BtnGrupo.Click
        FrmPesquisa.tabela = "tab_grupo_usuario"
        FrmPesquisa.ShowDialog()
        TxbCodGrupo.Text = ModVariavelGlobal.pesquisaCodigo
        TxbDesGrupo.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub
    Private Overloads Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        Try
            TxbCodigo.Text = Dgv.CurrentRow.Cells(0).Value.ToString
            TxbDescricao.Text = Dgv.CurrentRow.Cells(1).Value.ToString
            txbSenha.Text = Dgv.CurrentRow.Cells(2).Value.ToString
            If Dgv.CurrentRow.Cells(4).Value.ToString.Trim = "S" Then
                CkbAtivo.Checked = True
            Else
                CkbAtivo.Checked = False
            End If
            If Dgv.CurrentRow.Cells(5).Value.ToString = "0" Then
                TxbCodGrupo.Text = ""
            Else
                TxbCodGrupo.Text = Dgv.CurrentRow.Cells(5).Value.ToString
            End If

            TxbDesGrupo.Text = Dgv.CurrentRow.Cells(6).Value.ToString
            carregaOld()
            TabControl1.SelectedIndex = 0
            Me.Height = 190
            Me.TxbCodigo.Select()
        Catch ex As Exception
        End Try
    End Sub

End Class
