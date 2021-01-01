Public Class ClGrupoUsuario
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

    Private des_grupo_usuario_ As String
    Public Property des_grupo_usuario() As String
        Get
            Return des_grupo_usuario_
        End Get
        Set(ByVal value As String)
            des_grupo_usuario_ = value
        End Set
    End Property

    Private ind_ativo_ As String
    Public Property ind_ativo() As String
        Get
            Return ind_ativo_
        End Get
        Set(ByVal value As String)
            ind_ativo_ = value
        End Set
    End Property

    Public Sub Cadastrar()
        sql = "Insert Into tab_grupo_usuario( cod_grupo_usuario ,des_grupo_usuario,ind_ativo) 
                    Values (" & cod_grupo_usuario & ",'" & des_grupo_usuario & "','" & ind_ativo & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_grupo_usuario Set des_grupo_usuario = '" & des_grupo_usuario & "' , 
                                  ind_ativo = '" & ind_ativo & "'
                                    Where cod_grupo_usuario = " & cod_grupo_usuario
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_grupo_usuario Where cod_grupo_usuario =" & cod_grupo_usuario & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String, ind_ativo As String, pe As Boolean)
        sql = "Select a.cod_grupo_usuario,
                      a.des_grupo_usuario,
                      a.ind_ativo                      
               From tab_grupo_usuario a
               where ((a.des_grupo_usuario like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((a.cod_grupo_usuario = " & cod & " )or (0 = " & cod & "))"
        If pe Then
            sql = sql & vbCrLf & "  And ((a.ind_ativo = '" & ind_ativo & "' )or ('' = '" & ind_ativo & "')) "
        End If
        sql = sql & vbCrLf & "order by a.des_grupo_usuario"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_grupo_usuario Where cod_grupo_usuario =" & cod_grupo_usuario & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_grupo_usuario,
                      des_grupo_usuario 
              From tab_grupo_usuario
              where des_grupo_usuario like ('%" & busca & "%')               
              order by des_grupo_usuario"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(cod_grupo_usuario) ,0)as ultimo From tab_grupo_usuario"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
