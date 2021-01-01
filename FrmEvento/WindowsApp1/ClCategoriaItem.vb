Public Class ClCategoriaItem
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_categoria_ As Integer
    Public Property cod_categoria() As Integer
        Get
            Return cod_categoria_
        End Get
        Set(ByVal value As Integer)
            cod_categoria_ = value
        End Set
    End Property

    Private des_categoria_ As String
    Public Property des_categoria() As String
        Get
            Return des_categoria_
        End Get
        Set(ByVal value As String)
            des_categoria_ = value
        End Set
    End Property

    Private cod_secao_ As Integer
    Public Property cod_secao() As Integer
        Get
            Return cod_secao_
        End Get
        Set(ByVal value As Integer)
            cod_secao_ = value
        End Set
    End Property

    Public Sub Cadastrar()
        sql = "Insert Into tab_categoria_item( cod_categoria ,des_categoria,cod_secao) 
                    Values (" & cod_categoria & ",'" & des_categoria & "'," & cod_secao & ")"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_categoria_item Set des_categoria = '" & des_categoria & "' , 
                                  cod_secao = " & cod_secao & "
                                    Where cod_categoria = " & cod_categoria
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_categoria_item Where cod_categoria =" & cod_categoria & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String, cod_secao As Integer)
        sql = "Select a.cod_categoria,
                      a.des_categoria,
                      a.cod_secao,
                      b.des_secao
               From tab_categoria_item a
               Join tab_secao_item b on (a.cod_secao = b.cod_secao)
               where ((a.des_categoria like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((a.cod_categoria = " & cod & " )or (0 = " & cod & "))
                 and ((a.cod_secao = " & cod_secao & " )or (0 = " & cod_secao & "))
              order by a.des_categoria"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_categoria_item Where cod_categoria =" & cod_categoria & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_categoria,
                      des_categoria 
              From tab_categoria_item
              where des_categoria like ('%" & busca & "%')               
              order by des_categoria"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(cod_categoria),0)as ultimo From tab_categoria_item"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
