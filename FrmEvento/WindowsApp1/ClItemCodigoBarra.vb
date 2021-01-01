Public Class ClItemCodigoBarra
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

    Private cod_unidade_ As String
    Public Property cod_unidade() As String
        Get
            Return cod_unidade_
        End Get
        Set(ByVal value As String)
            cod_unidade_ = value
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

    Private val_preco_d_ As String

    Public Sub Cadastrar()

        sql = "Insert Into tab_item_cod_barra(   cod_item,
                                              cod_barra,
                                              cod_referencia,
                                              cod_unidade,
                                              des_item)
                                     Values (" & cod_item & ",
                                             '" & cod_barra & "',
                                            '" & cod_referencia & "',
                                            " & cod_unidade & ",
                                            '" & des_item & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_item_cod_barra Set   cod_barra = '" & cod_barra & "'
                                            cod_referencia = '" & cod_referencia & "',
                                            cod_unidade = " & cod_unidade & ",
                                            des_item = '" & des_item & "'
                                      Where cod_barra = " & cod_barra & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_item_cod_barra Where cod_barra =" & cod_barra & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer)
        sql = "Select a.cod_barra,
                      a.des_item,
                      a.cod_referencia,
                      a.cod_unidade,
                      b.des_unidade   
                      
               From tab_item_cod_barra a   
               join tab_unidade b on (a.cod_unidade = b.cod_unidade)
               where cod_item = " & cod & " 
              order by des_item "
        ds = con.Listar(sql)

        Return ds
    End Function
    Public Function CadastradoExistemte(cod_barra As String)
        sql = "Select  des_item as existente From tab_item_cod_barra where cod_barra = '" & cod_barra & "'"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(cod_barra),0)as ultimo From tab_item_cod_barra"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
