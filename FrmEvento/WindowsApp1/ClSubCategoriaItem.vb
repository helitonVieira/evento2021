Public Class ClSubCategoriaItem
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_subcategoria_ As Integer
    Public Property cod_subcategoria() As Integer
        Get
            Return cod_subcategoria_
        End Get
        Set(ByVal value As Integer)
            cod_subcategoria_ = value
        End Set
    End Property

    Private des_subcategoria_ As String
    Public Property des_subcategoria() As String
        Get
            Return des_subcategoria_
        End Get
        Set(ByVal value As String)
            des_subcategoria_ = value
        End Set
    End Property

    Private cod_categoria_ As Integer
    Public Property cod_categoria() As Integer
        Get
            Return cod_categoria_
        End Get
        Set(ByVal value As Integer)
            cod_categoria_ = value
        End Set
    End Property

    Public Sub Cadastrar()
        sql = "Insert Into tab_subcategoria_item( cod_subcategoria ,des_subcategoria,cod_categoria) 
                    Values (" & cod_subcategoria & ",'" & des_subcategoria & "'," & cod_categoria & ")"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_subcategoria_item Set des_subcategoria = '" & des_subcategoria & "' , 
                                  cod_categoria = " & cod_categoria & "
                                    Where cod_subcategoria = " & cod_subcategoria
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_subcategoria_item Where cod_subcategoria =" & cod_subcategoria & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String, cod_categoria As Integer)
        sql = "Select a.cod_subcategoria,
                      a.des_subcategoria,
                      a.cod_categoria,
                      b.des_categoria
               From tab_subcategoria_item a
               Join tab_categoria_item b on (a.cod_categoria = b.cod_categoria)
               where ((a.des_subcategoria like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((a.cod_subcategoria = " & cod & " )or (0 = " & cod & "))
                 and ((a.cod_categoria = " & cod_categoria & " )or (0 = " & cod_categoria & "))
              order by a.des_subcategoria"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarRel()
        sql = "Select a.cod_subcategoria,
                      a.des_subcategoria,
                      a.cod_categoria,
                      b.des_categoria
               From tab_subcategoria_item a
                join tab_categoria_item b on (a.cod_categoria = b.cod_categoria)
                Order by 4,2"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_subcategoria,
                      des_subcategoria 
              From tab_subcategoria_item
              where des_subcategoria like ('%" & busca & "%')               
              order by des_subcategoria"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(cod_subcategoria),0)as ultimo From tab_subcategoria_item"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
