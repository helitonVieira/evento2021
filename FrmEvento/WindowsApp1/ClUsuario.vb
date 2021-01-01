Public Class ClUsuario
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL

    Private cod_usuario_ As Integer
    Public Property cod_usuario() As Integer
        Get
            Return cod_usuario_
        End Get
        Set(ByVal value As Integer)
            cod_usuario_ = value
        End Set
    End Property
    Private nom_usuario_ As String
    Public Property nom_usuario() As String
        Get
            Return nom_usuario_
        End Get
        Set(ByVal value As String)
            nom_usuario_ = value
        End Set
    End Property
    Private des_senha_ As String
    Public Property des_senha() As String
        Get
            Return des_senha_
        End Get
        Set(ByVal value As String)
            des_senha_ = value
        End Set
    End Property
    Private des_permissao_usuario_ As String
    Public Property des_permissao_usuario() As String
        Get
            Return des_permissao_usuario_
        End Get
        Set(ByVal value As String)
            des_permissao_usuario_ = value
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

    Private cod_grupo_usuario_ As Integer
    Public Property cod_grupo_usuario() As Integer
        Get
            Return cod_grupo_usuario_
        End Get
        Set(ByVal value As Integer)
            cod_grupo_usuario_ = value
        End Set
    End Property

    Public Sub Cadastrar()
        sql = "Insert Into tab_usuario(cod_usuario,nom_usuario, des_senha, des_permissao_usuario, ind_ativo, cod_grupo_usuario) 
         Values ((select coalesce(max(cod_usuario),0) + 1 from tab_usuario),'" & nom_usuario & "' , '" & des_senha & "',
                  '" & des_permissao_usuario & "','" & ind_ativo & "'," & cod_grupo_usuario & ")"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_usuario Set nom_usuario = '" & nom_usuario & "' ,
                                      des_senha = '" & des_senha & "',
                                      des_permissao_usuario ='" & des_permissao_usuario & "',
                                      ind_ativo ='" & ind_ativo & "',
                                      cod_grupo_usuario = " & cod_grupo_usuario & "
                                      Where cod_usuario = " & cod_usuario & "
                                      and cod_usuario > 1"
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_usuario Where cod_usuario =" & cod_usuario & "and cod_usuario > 1"
        con.Operar(sql)
    End Sub

    Public Function Consultar(ByVal cod As Integer, ByVal desc As String, ByVal ind_ativo As String, ByVal codGrupo As Integer, ByVal pe As Boolean)
        sql = "Select a.cod_usuario,
                      a.nom_usuario,
                      a.des_senha,
                      a.des_permissao_usuario,
                      a.ind_ativo ,
                      a.cod_grupo_usuario,
                      b.des_grupo_usuario
              From tab_usuario a
              Left join tab_grupo_usuario b on (a.cod_grupo_usuario = b.cod_grupo_usuario)
              where  a.nom_usuario like ('%" & desc & "%')   
                 and ((a.cod_usuario = " & cod & " )or (0 = " & cod & "))
                 and ((a.cod_grupo_usuario = " & codGrupo & " )or (0 = " & codGrupo & "))"
        If pe Then
            sql = sql & vbCrLf & "  And ((a.ind_ativo = '" & ind_ativo & "' )or ('' = '" & ind_ativo & "')) "
        End If
        sql = sql & vbCrLf & " and cod_usuario > 1"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarGeral()
        sql = "Select * From tab_usuario where ind_ativo = 'S'"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarControleAcesso()
        sql = "Select   a.cod_usuario,
                        a.nom_usuario,   
                        a.cod_grupo_usuario,  
                        b.des_grupo_usuario,
                        a.ind_ativo 
              From tab_usuario a
              Left join tab_grupo_usuario b on (a.cod_grupo_usuario = b.cod_grupo_usuario)
               where a.cod_usuario > 1 
               and a.ind_ativo = 'S'"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_usuario,
                      nom_usuario 
              From tab_usuario
              where nom_usuario like ('%" & busca & "%') 
              and ind_ativo = 'S'
              and cod_usuario > 1
              order by nom_usuario"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarUsuarioExpecifico1()
        sql = "Select * From tab_usuario 
              Where nom_usuario ='" & nom_usuario & "' 
                and des_senha = '" & des_senha & "'
                and cod_usuario > 1"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(cod_usuario) ,0)as ultimo From tab_usuario"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
