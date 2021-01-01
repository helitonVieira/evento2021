Public Class ClGrupoUsuarioTela
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_grupo_usuario_ As Integer
    Public Property cod_grupo_usuario() As Integer
        Get
            Return cod_grupo_usuario_
        End Get
        Set(ByVal value As Integer)
            cod_grupo_usuario_ = value
        End Set
    End Property
    Private cod_tela_acesso_ As Integer
    Public Property cod_tela_acesso() As Integer
        Get
            Return cod_tela_acesso_
        End Get
        Set(ByVal value As Integer)
            cod_tela_acesso_ = value
        End Set
    End Property

    Public Sub Cadastrar()
        sql = "Insert Into tab_grupo_usuario_tela(cod_grupo_usuario, cod_tela_acesso ) 
                    Values (" & cod_grupo_usuario & "," & cod_tela_acesso & ")"
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_grupo_usuario_tela Where cod_tela_acesso =" & cod_tela_acesso & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirTodos()
        sql = " Delete from tab_grupo_usuario_tela Where cod_grupo_usuario =" & cod_grupo_usuario & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirTodosGrupo()
        sql = " Delete from tab_grupo_usuario_tela Where cod_grupo_usuario =" & cod_grupo_usuario & ""
        con.Operar(sql)
    End Sub
    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_grupo_usuario,
                      cod_tela_acesso                      
              From tab_grupo_usuario_tela
              where cod_grupo_usuario = " & busca & ""
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
