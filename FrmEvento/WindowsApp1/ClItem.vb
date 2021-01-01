Public Class ClItem
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private cod_item_ As Integer
    Public Property cod_item() As Integer
        Get
            Return cod_item_
        End Get
        Set(ByVal value As Integer)
            cod_item_ = value
        End Set
    End Property

    Private des_item_ As String
    Public Property des_item() As String
        Get
            Return des_item_
        End Get
        Set(ByVal value As String)
            des_item_ = value
        End Set
    End Property

    Private cod_subcategoria_ As Integer
    Public Property cod_subcategoria() As Integer
        Get
            Return cod_subcategoria_
        End Get
        Set(ByVal value As Integer)
            cod_subcategoria_ = value
        End Set
    End Property

    Private cod_barra_ As String
    Public Property cod_barra() As String
        Get
            Return cod_barra_
        End Get
        Set(ByVal value As String)
            cod_barra_ = value
        End Set
    End Property

    Private cod_referencia_ As String
    Public Property cod_referencia() As String
        Get
            Return cod_referencia_
        End Get
        Set(ByVal value As String)
            cod_referencia_ = value
        End Set
    End Property

    Private cod_unidade_ As Integer
    Public Property cod_unidade() As Integer
        Get
            Return cod_unidade_
        End Get
        Set(ByVal value As Integer)
            cod_unidade_ = value
        End Set
    End Property

    Private ind_tipo_ As String
    Public Property ind_tipo() As String
        Get
            Return ind_tipo_
        End Get
        Set(ByVal value As String)
            ind_tipo_ = value
        End Set
    End Property

    Private qtd_estoque_minimo_ As String
    Public Property qtd_estoque_minimo() As String
        Get
            Return qtd_estoque_minimo_
        End Get
        Set(ByVal value As String)
            qtd_estoque_minimo_ = value
        End Set
    End Property

    Private qtd_estoque_maximo_ As String
    Public Property qtd_estoque_maximo() As String
        Get
            Return qtd_estoque_maximo_
        End Get
        Set(ByVal value As String)
            qtd_estoque_maximo_ = value
        End Set
    End Property

    Private cod_marca_ As Integer
    Public Property cod_marca() As Integer
        Get
            Return cod_marca_
        End Get
        Set(ByVal value As Integer)
            cod_marca_ = value
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
        sql = "Insert Into tab_item( cod_item ,
                                       des_item,
                                       cod_subcategoria,
                                       cod_barra,cod_referencia,
                                       cod_unidade,
                                       ind_tipo, 
                                       qtd_estoque_minimo,  
                                       qtd_estoque_maximo,
                                       cod_marca,
                                       ind_ativo)
                               Values (" & cod_item & ",
                                        '" & des_item & "',
                                         " & cod_subcategoria & ",
                                        '" & cod_barra & "',
                                        '" & cod_referencia & "',
                                         " & cod_unidade & ",
                                        '" & ind_tipo & "',
                                         " & Replace(Replace(qtd_estoque_minimo, ".", ""), ",", ".") & ",
                                         " & Replace(Replace(qtd_estoque_maximo, ".", ""), ",", ".") & ",
                                        " & vbCrLf
        If cod_marca = 0 Then
            sql = sql & "null ,"
        Else
            sql = sql & cod_marca & ","
        End If
        sql = sql & "                  '" & ind_ativo & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_item Set des_item = '" & des_item & "' , 
                                cod_subcategoria = " & cod_subcategoria & ",
                                cod_barra = '" & cod_barra & "',
                                cod_referencia = '" & cod_referencia & "',
                                cod_unidade = " & cod_unidade & ",
                                ind_tipo = '" & ind_tipo & "',
                                qtd_estoque_minimo = '" & Replace(Replace(qtd_estoque_minimo, ".", ""), ",", ".") & "',
                                qtd_estoque_maximo = '" & Replace(Replace(qtd_estoque_maximo, ".", ""), ",", ".") & "',
                                 " & vbCrLf 
        If cod_marca = 0 Then
            sql = sql & "cod_marca =  null ,"
        Else
            sql = sql & " cod_marca = " & cod_marca & ","
        End If
        sql = sql & "      ind_ativo = '" & ind_ativo & "' 
                               Where cod_item = " & cod_item & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from  tab_item_cod_barra Where cod_item = " & cod_item & ""
        con.Operar(sql)
        sql = " Delete from tab_item Where cod_item = " & cod_item & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod_item_old As String, des_item_old As String, cod_subcategoria_old As String, cod_barra_old As String,
                               cod_referencia_old As String, cod_unidade_old As String, ind_tipo_old As String, qtd_estoque_minimo As String,
                              qtd_estoque_maximo As String, cod_marca_old As String, ind_ativo_old As String)

        If cod_item_old = "" Then
            cod_item_old = "0"
        End If
        If cod_subcategoria_old = "" Then
            cod_subcategoria_old = "0"
        End If
        If cod_unidade_old = "" Then
            cod_unidade_old = "0"
        End If

        If cod_marca_old = "" Then
            cod_marca_old = "0"
        End If
        sql = "Select a.cod_item ,
                   a.des_item,
                   a.cod_subcategoria,
            	   b.des_subcategoria,
                   a.cod_barra,
            	   a.cod_referencia,
                   a.cod_unidade,
            	   c.des_unidade ,
                   a.ind_tipo, 
                   a.qtd_estoque_minimo,
                   a.qtd_estoque_maximo,
            	   a.cod_marca,
            	   e.des_marca ,
                   a.ind_ativo
            From tab_item a
            join tab_subcategoria_item b on (a.cod_subcategoria = b.cod_subcategoria)
            join tab_unidade c on (c.cod_unidade = a.cod_unidade )
            left join tab_marca e on (e.cod_marca = a.cod_marca )
               where ((a.des_item like ('%" & des_item_old & "%') )or ('' = '" & des_item_old & "' ))  
                 and ((a.cod_item = " & cod_item_old & " )or (0 = " & cod_item_old & "))
                 and ((b.cod_subcategoria = " & cod_subcategoria_old & " )or (0 = " & cod_subcategoria_old & "))
                 and ((cod_barra = '" & cod_barra_old & "')or('' = '" & cod_barra_old & "'))
                 and ((a.cod_referencia = '" & cod_referencia_old & "')or('' = '" & cod_referencia_old & "'))
                 and ((a.cod_unidade = " & cod_unidade_old & " )or (0 = " & cod_unidade_old & "))
                 and ((a.ind_tipo = '" & ind_tipo_old & "' )or ('' = '" & ind_tipo_old & "'))
                 and ((a.cod_marca = " & cod_marca_old & " )or (0 = " & cod_marca_old & ")) 
              order by des_item"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_item Where cod_item =" & cod_item & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_item,
                      des_item 
              From tab_item
              where des_item like ('%" & busca & "%')               
              order by des_item"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(cod_item),0)as ultimo From tab_item"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function

End Class
