Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmControleAcesso
    Dim conectar As New ConexaoSQL
    Dim dsUsuario, dsGrupo, dsTela, dsUsuarioTela, dsGrupoTela As New DataSet
    Dim usuario As New ClUsuario
    Dim grupo As New ClGrupoUsuario
    Dim tela As New ClTelaAcesso
    Dim usuarioTela As New ClUsuarioTela
    Dim grupoUsuarioTela As New ClGrupoUsuarioTela
    Dim fechado As Integer = 2
    Dim aberto As Integer = 3
    Dim PastaFechado As Integer = 0
    Dim PastaAberta As Integer = 1
    Dim codUsuario, codGrupo As Integer
    Dim user As Boolean
    Dim filtroTela As String = ""
    Private Sub FrmControleAcesso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t100103 = False Then
                MsgBox("Usuário sem permissão para acessar o Controle de Acesso!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
        End If
        limpar()
        carregaGrid()
    End Sub
    Private Sub FrmControleAcesso_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        ModPermissaoUsuario.limparPermissaoAcesso()
        ModPermissaoUsuario.permissaoAcesso("usuario")
        ModPermissaoUsuario.permissaoAcesso("grupo")

    End Sub
    Private Sub limpar()
        codUsuario = 0
        user = True
        filtroTela = ""
        TabControl1.SelectedIndex = 0
    End Sub
    Private Sub carregaGrid()
        Try
            Dim tabela As DataTable
            'GRID DOS GRUPOS DE USUARIOS
            dsGrupo = grupo.ConsultarPesquisa("")
            tabela = dsGrupo.Tables(0)

            If tabela.Rows.Count > 0 Then
                DgvGrupo.DataSource = Nothing
                DgvGrupo.DataSource = dsGrupo.Tables(0)
            End If

            'GRID DE USUARIOS

            dsUsuario = usuario.ConsultarControleAcesso()
            tabela = dsUsuario.Tables(0)

            If tabela.Rows.Count > 0 Then
                DgvUsuario.DataSource = Nothing
                DgvUsuario.DataSource = dsUsuario.Tables(0)
                'If Label1.Text = "User" Then
                Label1.Text = "Usuario: " & tabela.Rows(0).Item("nom_usuario")
                codUsuario = tabela.Rows(0).Item("cod_usuario")
                If IsNothing(tabela.Rows(0).Item("cod_grupo_usuario")) Then
                    codGrupo = 0
                Else
                    codGrupo = tabela.Rows(0).Item("cod_grupo_usuario")
                End If

                user = True
                    'End If
                End If


                carregarNodesTela()

            formatarGridUsuario()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub carregarNodesTela()
        Dim nivel As Integer
        Dim erro As String
        Dim tabela As DataTable
        'CRIAR OS NOS DE TODAS AS TELAS 
        dsTela = tela.ConsultarPesquisa(filtroTela)
        tabela = dsTela.Tables(0)
        Try
            If tabela.Rows.Count > 0 Then
                'LIMPANDO OS NODES
                TrvAcesso.Nodes.Clear()

                For Each x As DataRow In tabela.Rows

                    nivel = x.Item("cod_tela_acesso").ToString.Length
                    erro = x.Item("cod_tela_acesso").ToString
                    If x.Item("ind_pasta").ToString = "S" Then
                        If nivel = 2 Then
                            criarPasta(x.Item("cod_tela_acesso").ToString, x.Item("des_tela_acesso").ToString)
                        ElseIf nivel = 4 Then
                            criarPasta(x.Item("cod_tela_acesso").ToString.Substring(0, 2), x.Item("cod_tela_acesso").ToString.Substring(2, 2), x.Item("des_tela_acesso").ToString)
                        ElseIf nivel = 6 Then
                            criarPasta(x.Item("cod_tela_acesso").ToString.Substring(0, 2), x.Item("cod_tela_acesso").ToString.Substring(2, 2), x.Item("cod_tela_acesso").ToString.Substring(4, 2), x.Item("des_tela_acesso").ToString)
                        ElseIf nivel = 8 Then
                            criarPasta(x.Item("cod_tela_acesso").ToString.Substring(0, 2), x.Item("cod_tela_acesso").ToString.Substring(2, 2), x.Item("cod_tela_acesso").ToString.Substring(4, 2), x.Item("cod_tela_acesso").ToString.Substring(6, 2), x.Item("des_tela_acesso").ToString)
                        ElseIf nivel = 10 Then
                            criarPasta(x.Item("cod_tela_acesso").ToString.Substring(0, 2), x.Item("cod_tela_acesso").ToString.Substring(2, 2), x.Item("cod_tela_acesso").ToString.Substring(4, 2), x.Item("cod_tela_acesso").ToString.Substring(6, 2), x.Item("cod_tela_acesso").ToString.Substring(8, 2), x.Item("des_tela_acesso").ToString)
                        End If
                    Else
                        If nivel = 2 Then
                            criarPasta(x.Item("cod_tela_acesso").ToString, x.Item("des_tela_acesso").ToString)
                            criarNodes(x.Item("cod_tela_acesso").ToString)
                        ElseIf nivel = 4 Then
                            criarPasta(x.Item("cod_tela_acesso").ToString.Substring(0, 2), x.Item("cod_tela_acesso").ToString.Substring(2, 2), x.Item("des_tela_acesso").ToString)
                            criarNodes(x.Item("cod_tela_acesso").ToString.Substring(0, 2), x.Item("cod_tela_acesso").ToString.Substring(2, 2))
                        ElseIf nivel = 6 Then
                            criarPasta(x.Item("cod_tela_acesso").ToString.Substring(0, 2), x.Item("cod_tela_acesso").ToString.Substring(2, 2), x.Item("cod_tela_acesso").ToString.Substring(4, 2), x.Item("des_tela_acesso").ToString)
                            criarNodes(x.Item("cod_tela_acesso").ToString.Substring(0, 2), x.Item("cod_tela_acesso").ToString.Substring(2, 2), x.Item("cod_tela_acesso").ToString.Substring(4, 2))
                        ElseIf nivel = 8 Then
                            criarPasta(x.Item("cod_tela_acesso").ToString.Substring(0, 2), x.Item("cod_tela_acesso").ToString.Substring(2, 2), x.Item("cod_tela_acesso").ToString.Substring(4, 2), x.Item("cod_tela_acesso").ToString.Substring(6, 2), x.Item("des_tela_acesso").ToString)
                            criarNodes(x.Item("cod_tela_acesso").ToString.Substring(0, 2), x.Item("cod_tela_acesso").ToString.Substring(2, 2), x.Item("cod_tela_acesso").ToString.Substring(4, 2), x.Item("cod_tela_acesso").ToString.Substring(6, 2))
                        ElseIf nivel = 10 Then
                            criarPasta(x.Item("cod_tela_acesso").ToString.Substring(0, 2), x.Item("cod_tela_acesso").ToString.Substring(2, 2), x.Item("cod_tela_acesso").ToString.Substring(4, 2), x.Item("cod_tela_acesso").ToString.Substring(6, 2), x.Item("cod_tela_acesso").ToString.Substring(8, 2), x.Item("des_tela_acesso").ToString)
                            criarNodes(x.Item("cod_tela_acesso").ToString.Substring(0, 2), x.Item("cod_tela_acesso").ToString.Substring(2, 2), x.Item("cod_tela_acesso").ToString.Substring(4, 2), x.Item("cod_tela_acesso").ToString.Substring(6, 2), x.Item("cod_tela_acesso").ToString.Substring(8, 2))
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox("erro    " & ex.Message)

        End Try
    End Sub
    Private Sub criarPasta(ByVal codigo As String, ByVal nome As String)
        TrvAcesso.Nodes.Add(codigo, nome, PastaFechado, PastaAberta)
    End Sub
    Private Sub criarPasta(ByVal node1 As String, ByVal codigo As String, ByVal nome As String)
        TrvAcesso.Nodes(node1).Nodes.Add(codigo, nome, PastaFechado, PastaAberta)
    End Sub
    Private Sub criarPasta(ByVal node1 As String, ByVal node2 As String, ByVal codigo As String, ByVal nome As String)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes.Add(codigo, nome, PastaFechado, PastaAberta)
    End Sub
    Private Sub criarPasta(ByVal node1 As String, ByVal node2 As String, ByVal node3 As String, ByVal codigo As String, ByVal nome As String)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes(node3).Nodes.Add(codigo, nome, PastaFechado, PastaAberta)
    End Sub
    Private Sub criarPasta(ByVal node1 As String, ByVal node2 As String, ByVal node3 As String, ByVal node4 As String, ByVal codigo As String, ByVal nome As String)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes(node3).Nodes(node4).Nodes.Add(codigo, nome, PastaFechado, PastaAberta)
    End Sub
    Private Sub criarNodes(ByVal node1 As String)
        TrvAcesso.Nodes(node1).Nodes.Add(node1 & "0", "Acesso", fechado, fechado)
        TrvAcesso.Nodes(node1).Nodes.Add(node1 & "1", "Incluir/Alterar", fechado, fechado)
        TrvAcesso.Nodes(node1).Nodes.Add(node1 & "2", "Excluir", fechado, fechado)
    End Sub
    Private Sub criarNodes(ByVal node1 As String, ByVal node2 As String)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes.Add(node1 & node2 & "0", "Acesso", fechado, fechado)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes.Add(node1 & node2 & "1", "Incluir/Alterar", fechado, fechado)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes.Add(node1 & node2 & "2", "Excluir", fechado, fechado)
    End Sub
    Private Sub criarNodes(ByVal node1 As String, ByVal node2 As String, ByVal node3 As String)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes(node3).Nodes.Add(node1 & node2 & node3 & "0", "Acesso", fechado, fechado)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes(node3).Nodes.Add(node1 & node2 & node3 & "1", "Incluir/Alterar", fechado, fechado)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes(node3).Nodes.Add(node1 & node2 & node3 & "2", "Excluir", fechado, fechado)
    End Sub
    Private Sub criarNodes(ByVal node1 As String, ByVal node2 As String, ByVal node3 As String, ByVal node4 As String)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes(node3).Nodes.Add(node1 & node2 & node3 & node4 & "0", "Acesso", fechado, fechado)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes(node3).Nodes.Add(node1 & node2 & node3 & node4 & "1", "Incluir/Alterar", fechado, fechado)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes(node3).Nodes.Add(node1 & node2 & node3 & node4 & "2", "Excluir", fechado, fechado)
    End Sub
    Private Sub criarNodes(ByVal node1 As String, ByVal node2 As String, ByVal node3 As String, ByVal node4 As String, ByVal node5 As String)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes(node3).Nodes.Add(node1 & node2 & node3 & node4 & node5 & "0", "Acesso", fechado, fechado)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes(node3).Nodes.Add(node1 & node2 & node3 & node4 & node5 & "1", "Incluir/Alterar", fechado, fechado)
        TrvAcesso.Nodes(node1).Nodes(node2).Nodes(node3).Nodes.Add(node1 & node2 & node3 & node4 & node5 & "2", "Excluir", fechado, fechado)
    End Sub
    Private Sub TrvAcesso_DoubleClick(sender As Object, e As EventArgs) Handles TrvAcesso.DoubleClick
        'If TrvAcesso.SelectedNode Is Nothing Then
        Try
            If TrvAcesso.SelectedNode.ImageIndex = PastaFechado Or TrvAcesso.SelectedNode.ImageIndex = PastaAberta Then
                Exit Sub
            Else
                If TrvAcesso.SelectedNode.ImageIndex = fechado Then
                    TrvAcesso.SelectedNode.ImageIndex = aberto
                    salvaRegistro(TrvAcesso.SelectedNode.Name)
                Else
                    TrvAcesso.SelectedNode.ImageIndex = fechado
                    excluirRegistro(TrvAcesso.SelectedNode.Name)
                End If
            End If
        Catch ex As Exception
        End Try
        'TrvAcesso.BeginUpdate()
    End Sub
    Private Sub salvaRegistro(codigo As String)
        Try

            If user Then
                usuarioTela.cod_usuario = codUsuario
                usuarioTela.cod_tela_acesso = codigo
                usuarioTela.Cadastrar()
            Else
                grupoUsuarioTela.cod_grupo_usuario = codUsuario
                grupoUsuarioTela.cod_tela_acesso = codigo
                grupoUsuarioTela.Cadastrar()
            End If

            'CARREGAR IMAGEM
            If codigo.Length = 3 Then
                'TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo).ImageIndex = aberto
                TrvAcesso.SelectedNode.SelectedImageIndex = aberto
            ElseIf codigo.Length = 5 Then
                'TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(2, 2)).Nodes(codigo).ImageIndex = aberto
                TrvAcesso.SelectedNode.SelectedImageIndex = aberto
            ElseIf codigo.Length = 7 Then
                'TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(2, 2)).Nodes(codigo.Substring(4, 2)).Nodes(codigo).ImageIndex = aberto
                TrvAcesso.SelectedNode.SelectedImageIndex = aberto
            ElseIf codigo.Length = 9 Then
                ' TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(0, 4)).Nodes(codigo.Substring(0, 6)).Nodes(codigo.Substring(0, 8)).Nodes(codigo).ImageIndex = aberto
                TrvAcesso.SelectedNode.SelectedImageIndex = aberto
            ElseIf codigo.Length = 11 Then
                'TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(2, 2)).Nodes(codigo.Substring(4, 2)).Nodes(codigo.Substring(6, 2)).Nodes(codigo.Substring(8, 2)).Nodes(codigo).ImageIndex = aberto
                TrvAcesso.SelectedNode.SelectedImageIndex = aberto
            ElseIf codigo.Length = 13 Then
                'TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(2, 2)).Nodes(codigo.Substring(4, 2)).Nodes(codigo.Substring(6, 2)).Nodes(codigo.Substring(8, 2)).Nodes(codigo.Substring(10, 2)).Nodes(codigo).ImageIndex = aberto
                TrvAcesso.SelectedNode.SelectedImageIndex = aberto
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub carregarImagem()
        Dim codigo As String
        Try
            'CARREGAR IMAGEM
            Dim tabela As DataTable
            If user Then
                dsUsuarioTela = usuarioTela.ConsultarPesquisa(codUsuario)
                tabela = dsUsuarioTela.Tables(0)
            Else
                dsGrupoTela = grupoUsuarioTela.ConsultarPesquisa(codGrupo)
                tabela = dsGrupoTela.Tables(0)
            End If
            If tabela.Rows.Count > 0 Then
                For Each row As DataRow In tabela.Rows
                    Try
                        codigo = row.Item("cod_tela_acesso").ToString

                        If codigo.Length = 3 Then
                            TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo).ImageIndex = aberto
                        ElseIf codigo.Length = 5 Then
                            TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(2, 2)).Nodes(codigo).ImageIndex = aberto
                        ElseIf codigo.Length = 7 Then
                            TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(2, 2)).Nodes(codigo.Substring(4, 2)).Nodes(codigo).ImageIndex = aberto
                        ElseIf codigo.Length = 9 Then
                            TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(2, 2)).Nodes(codigo.Substring(4, 2)).Nodes(codigo.Substring(6, 2)).Nodes(codigo).ImageIndex = aberto
                        ElseIf codigo.Length = 11 Then
                            TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(2, 2)).Nodes(codigo.Substring(4, 2)).Nodes(codigo.Substring(6, 2)).Nodes(codigo.Substring(8, 2)).Nodes(codigo).ImageIndex = aberto
                        ElseIf codigo.Length = 13 Then
                            TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(2, 2)).Nodes(codigo.Substring(4, 2)).Nodes(codigo.Substring(6, 2)).Nodes(codigo.Substring(8, 2)).Nodes(codigo.Substring(10, 2)).Nodes(codigo).ImageIndex = aberto
                        End If
                    Catch ex As Exception

                    End Try
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub excluirRegistro(codigo As String)
        If user Then
            usuarioTela.cod_tela_acesso = codigo
            usuarioTela.cod_usuario = codUsuario
            usuarioTela.Excluir()
        Else
            grupoUsuarioTela.cod_tela_acesso = codigo
            grupoUsuarioTela.cod_grupo_usuario = codUsuario
            grupoUsuarioTela.Excluir()
        End If

        'CARREGAR IMAGEM
        If codigo.Length = 3 Then
            TrvAcesso.Nodes(codigo).ImageIndex = fechado
            TrvAcesso.SelectedNode.SelectedImageIndex = fechado
        ElseIf codigo.Length = 5 Then
            TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo).ImageIndex = fechado
            TrvAcesso.SelectedNode.SelectedImageIndex = fechado
        ElseIf codigo.Length = 7 Then
            TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(2, 2)).Nodes(codigo).ImageIndex = fechado
            TrvAcesso.SelectedNode.SelectedImageIndex = fechado
        ElseIf codigo.Length = 9 Then
            TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(2, 2)).Nodes(codigo.Substring(4, 2)).Nodes(codigo).ImageIndex = fechado
            TrvAcesso.SelectedNode.SelectedImageIndex = fechado
        ElseIf codigo.Length = 11 Then
            TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(2, 2)).Nodes(codigo.Substring(4, 2)).Nodes(codigo.Substring(6, 2)).Nodes(codigo).ImageIndex = fechado
            TrvAcesso.SelectedNode.SelectedImageIndex = fechado
        ElseIf codigo.Length = 13 Then
            TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(2, 2)).Nodes(codigo.Substring(4, 2)).Nodes(codigo.Substring(6, 2)).Nodes(codigo.Substring(8, 2)).Nodes(codigo).ImageIndex = fechado
            TrvAcesso.SelectedNode.SelectedImageIndex = fechado
        ElseIf codigo.Length = 15 Then
            TrvAcesso.Nodes(codigo.Substring(0, 2)).Nodes(codigo.Substring(2, 2)).Nodes(codigo.Substring(4, 2)).Nodes(codigo.Substring(6, 2)).Nodes(codigo.Substring(8, 2)).Nodes(codigo.Substring(10, 2)).Nodes(codigo).ImageIndex = fechado
            TrvAcesso.SelectedNode.SelectedImageIndex = fechado
        End If
    End Sub
    Private Function abertoFechado()
        Dim x As Integer
        If IsNothing(TrvAcesso.SelectedNode) Then
            x = fechado
            Return x
            Exit Function
        End If
        If TrvAcesso.SelectedNode.ImageIndex = fechado Then
            x = aberto
        Else
            x = fechado
        End If
        Return x
    End Function
    Private Sub DgvUsuario_DoubleClick(sender As Object, e As EventArgs) Handles DgvUsuario.DoubleClick
        permissaoUsuario()
    End Sub

    Private Sub BtnUsuarioAcesso_DoubleClick(sender As Object, e As EventArgs) Handles BtnUsuarioAcesso.Click
        permissaoUsuario()
    End Sub
    Private Sub permissaoUsuario()
        Label1.Text = "Usuario: " & DgvUsuario.CurrentRow.Cells(1).Value.ToString
        codUsuario = DgvUsuario.CurrentRow.Cells(0).Value.ToString

        user = True
        carregarNodesTela()
        carregarImagem()
        If IsNothing(DgvUsuario.CurrentRow.Cells(2).Value.ToString) Then
            codGrupo = 0
        Else
            codGrupo = DgvUsuario.CurrentRow.Cells(2).Value.ToString
            user = False
            carregarImagem()
            user = True
        End If

        TabControl1.SelectedIndex = 1
        'If codGrupo > 0 Then
        '   dsGrupoTela = grupoUsuarioTela.ConsultarPesquisa(codGrupo)
        'End If
    End Sub
    Private Sub DgvGrupo_DoubleClick(sender As Object, e As EventArgs) Handles DgvGrupo.DoubleClick
        permissaoGrupoUsuario()
    End Sub
    Private Sub BtnGrupoAcesso_Click(sender As Object, e As EventArgs) Handles BtnGrupoAcesso.Click
        permissaoGrupoUsuario()
    End Sub
    Private Sub permissaoGrupoUsuario()
        Label1.Text = "Grupo Usuario: " & DgvGrupo.CurrentRow.Cells(1).Value.ToString
        codUsuario = DgvGrupo.CurrentRow.Cells(0).Value.ToString
        codGrupo = DgvGrupo.CurrentRow.Cells(0).Value.ToString
        codGrupo = 0
        user = False
        carregarImagem()
        TabControl1.SelectedIndex = 1
    End Sub
    Private Sub BtnCadUsuario_Click(sender As Object, e As EventArgs) Handles BtnCadUsuario.Click
        FrmUsuario.ShowDialog()
    End Sub
    Private Sub BtnLiberarTodos_Click(sender As Object, e As EventArgs) Handles BtnLiberarTodos.Click
        Dim tabela As DataTable
        Try
            dsTela = tela.ConsultarPesquisa("")
            tabela = dsTela.Tables(0)
            If tabela.Rows.Count <= 0 Then
                Exit Sub
            End If
            If user Then
                usuarioTela.cod_usuario = codUsuario
                usuarioTela.ExcluirTodos()
            Else
                grupoUsuarioTela.cod_grupo_usuario = codUsuario
                grupoUsuarioTela.ExcluirTodos()
            End If

            For Each row As DataRow In tabela.Rows
                If user Then
                    usuarioTela.cod_tela_acesso = row.Item("cod_tela_acesso")
                    usuarioTela.Cadastrar()
                Else
                    grupoUsuarioTela.cod_tela_acesso = row.Item("cod_tela_acesso")
                    grupoUsuarioTela.Cadastrar()
                End If
            Next
            carregarImagem()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnRemoverTodos_Click(sender As Object, e As EventArgs) Handles BtnRemoverTodos.Click
        Try
            If user Then
                usuarioTela.cod_usuario = codUsuario
                usuarioTela.ExcluirTodosUsuario()
            Else
                grupoUsuarioTela.cod_grupo_usuario = codUsuario
                grupoUsuarioTela.ExcluirTodosGrupo()
            End If
            carregarImagem()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCadGrupo_Click(sender As Object, e As EventArgs) Handles BtnCadGrupo.Click
        FrmGrupoUsuario.ShowDialog()
    End Sub

    Private Sub BtnFiltroTela_Click(sender As Object, e As EventArgs) Handles BtnFiltroTela.Click
        filtroTela = TxbDesFiltroTela.Text
        carregarImagem()
        filtroTela = ""
    End Sub
    Private Sub BtnBuscaOutroUser_Click(sender As Object, e As EventArgs) Handles BtnBuscaOutroUser.Click
        If user Then
            FrmPesquisa.tabela = "tab_usuario"
        Else
            FrmPesquisa.tabela = "tab_grupo_usuario"
        End If

        FrmPesquisa.ShowDialog()
        TxbUsuarioCopia.Tag = ModVariavelGlobal.pesquisaCodigo
        TxbUsuarioCopia.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnCopiaOutroUser_Click(sender As Object, e As EventArgs) Handles BtnCopiaOutroUser.Click
        If IsNothing(TxbUsuarioCopia.Tag) Then
            MsgBox("Informe o Usuário valido de Origem para fazer a copía", MsgBoxStyle.Information, "Informação")
            TxbUsuarioCopia.Select()
            Exit Sub
        End If
        Dim dsCopia As New DataSet
        Dim tabela As DataTable
        Try
            dsCopia = usuarioTela.ConsultarPesquisa(TxbUsuarioCopia.Tag)
            tabela = dsCopia.Tables(0)
            If tabela.Rows.Count <= 0 Then
                Exit Sub
            End If
            If user Then
                usuarioTela.cod_usuario = codUsuario
                usuarioTela.ExcluirTodosUsuario()
            Else
                grupoUsuarioTela.cod_grupo_usuario = codUsuario
                grupoUsuarioTela.ExcluirTodosGrupo()
            End If
            For Each row As DataRow In tabela.Rows
                If user Then
                    usuarioTela.cod_tela_acesso = row.Item("cod_tela_acesso")
                    usuarioTela.Cadastrar()
                Else
                    grupoUsuarioTela.cod_tela_acesso = row.Item("cod_tela_acesso")
                    grupoUsuarioTela.Cadastrar()
                End If
            Next
            carregarImagem()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnVoltarTelaPrinc_Click(sender As Object, e As EventArgs) Handles BtnVoltarTelaPrinc.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub formatarGridUsuario()
        Try
            With DgvUsuario
                .Columns(0).Visible = False
                .Columns(1).HeaderText = "Usuário"
                .Columns(2).Visible = False
                .Columns(3).HeaderText = "Grupo"
                .Columns(4).HeaderText = "Ativo"

                .Columns(1).Width = 140
                .Columns(3).Width = 140
                .Columns(4).Width = 50
            End With

            With DgvGrupo
                .Columns(0).Visible = False
                .Columns(1).HeaderText = "Grupo"
                .Columns(1).Width = 330
            End With

        Catch ex As Exception

        End Try
    End Sub

End Class
