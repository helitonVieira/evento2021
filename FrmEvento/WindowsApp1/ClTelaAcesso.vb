Public Class ClTelaAcesso
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_tela_acesso_ As Integer
    Public Property cod_tela_acesso() As Integer
        Get
            Return cod_tela_acesso_
        End Get
        Set(ByVal value As Integer)
            cod_tela_acesso_ = value
        End Set
    End Property

    Private des_tela_acesso_ As String
    Public Property des_tela_acesso() As String
        Get
            Return des_tela_acesso_
        End Get
        Set(ByVal value As String)
            des_tela_acesso_ = value
        End Set
    End Property

    Private ind_pasta_ As String
    Public Property ind_pasta() As String
        Get
            Return ind_pasta_
        End Get
        Set(ByVal value As String)
            ind_pasta_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_tela_acesso( cod_tela_acesso ,des_tela_acesso, ind_pasta) 
                    Values (" & cod_tela_acesso & ",'" & des_tela_acesso & "','" & ind_pasta & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_tela_acesso Set des_tela_acesso = '" & des_tela_acesso & "',
                                          ind_pasta = '" & ind_pasta & "'  
                                    Where cod_tela_acesso = " & cod_tela_acesso
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_tela_acesso Where cod_tela_acesso =" & cod_tela_acesso & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String, cod_estado As Integer)
        sql = "Select a.cod_tela_acesso,
                      a.des_tela_acesso,
                      a.ind_pasta 
               From tab_tela_acesso a
               where ((a.des_tela_acesso like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((a.cod_tela_acesso = " & cod & " )or (0 = " & cod & "))                
              order by a.des_tela_acesso"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_tela_acesso Where cod_tela_acesso =" & cod_tela_acesso & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select a.cod_tela_acesso,
                      a.des_tela_acesso ,
                      a.ind_pasta
              From tab_tela_acesso a
              where upper(a.des_tela_acesso) like ('%" & busca & "%')
              OR a.cod_tela_acesso IN 
(select cast(SUBSTRING( CAST(aa.cod_tela_acesso as varchar(20)),0,3)as INTEGER)
    From tab_tela_acesso aa
    where upper(aa.des_tela_acesso) like ('%" & busca & "%'))
OR a.cod_tela_acesso IN 
(select cast(SUBSTRING( CAST(aa.cod_tela_acesso as varchar(20)),0,5)as INTEGER)
    From tab_tela_acesso aa
    where upper(aa.des_tela_acesso) like ('%" & busca & "%'))
OR a.cod_tela_acesso IN 
(select cast(SUBSTRING( CAST(aa.cod_tela_acesso as varchar(20)),0,7)as INTEGER)
    From tab_tela_acesso aa
    where upper(aa.des_tela_acesso) like ('%" & busca & "%'))
OR a.cod_tela_acesso IN
(select cast(SUBSTRING( CAST(aa.cod_tela_acesso as varchar(20)),0,9)as INTEGER)
    From tab_tela_acesso aa
    where upper(aa.des_tela_acesso) like ('%" & busca & "%'))
    order by cod_tela_acesso"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(cod_tela_acesso) ,0)as ultimo From tab_tela_acesso"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
