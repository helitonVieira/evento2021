Public Class ClUsuarioTela
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_usuario_ As Integer
    Public Property cod_usuario() As Integer
        Get
            Return cod_usuario_
        End Get
        Set(ByVal value As Integer)
            cod_usuario_ = value
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
        sql = "Insert Into tab_usuario_tela(cod_usuario, cod_tela_acesso) 
                    Values (" & cod_usuario & "," & cod_tela_acesso & ")"
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_usuario_tela Where cod_tela_acesso =" & cod_tela_acesso & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirTodos()
        sql = " Delete from tab_usuario_tela Where cod_usuario =" & cod_usuario & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirTodosUsuario()
        sql = " Delete from tab_usuario_tela Where cod_usuario =" & cod_usuario & ""
        con.Operar(sql)
    End Sub
    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_usuario,
                      cod_tela_acesso
              From tab_usuario_tela
              where cod_usuario =" & busca & ""
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
