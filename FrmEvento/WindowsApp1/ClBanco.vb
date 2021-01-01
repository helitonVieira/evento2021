Public Class ClBanco
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_banco_ As Integer
    Public Property cod_banco() As Integer
        Get
            Return cod_banco_
        End Get
        Set(ByVal value As Integer)
            cod_banco_ = value
        End Set
    End Property

    Private nom_banco_ As String
    Public Property nom_banco() As String
        Get
            Return nom_banco_
        End Get
        Set(ByVal value As String)
            nom_banco_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_banco( cod_banco ,nom_banco) Values (" & cod_banco & ",'" & nom_banco & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_banco Set nom_banco = '" & nom_banco & "'  Where cod_banco = " & cod_banco & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_banco Where cod_banco =" & cod_banco & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String)
        sql = "Select cod_banco,
                      nom_banco
               From tab_banco
               where ((nom_banco like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((cod_banco = " & cod & " )or (0 = " & cod & "))
              order by nom_banco"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_banco Where cod_banco =" & cod_banco & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select * 
              From tab_banco
              where nom_banco like ('%" & busca & "%')               
              order by nom_banco"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(cast( max(cod_banco) as varchar(5)),0)as ultimo From tab_banco"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
