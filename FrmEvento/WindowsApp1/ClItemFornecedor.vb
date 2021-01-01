Public Class ClItemFornecedor
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private seq_item_fornecedor_ As Integer
    Public Property seq_item_fornecedor() As Integer
        Get
            Return seq_item_fornecedor_
        End Get
        Set(ByVal value As Integer)
            seq_item_fornecedor_ = value
        End Set
    End Property

    Private cod_item_ As Integer
    Public Property cod_item() As Integer
        Get
            Return cod_item_
        End Get
        Set(ByVal value As Integer)
            cod_item_ = value
        End Set
    End Property

    Private cod_pessoa_fornecedor_ As Integer
    Public Property cod_pessoa_fornecedor() As Integer
        Get
            Return cod_pessoa_fornecedor_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_fornecedor_ = value
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
    Public Sub Cadastrar()
        sql = "Insert Into tab_item_fornecedor( seq_item_fornecedor,
                                              cod_pessoa_fornecedor,
                                              cod_item,
                                              cod_barra,
                                              cod_referencia)
                                     Values (" & seq_item_fornecedor & ",
                                             " & cod_pessoa_fornecedor & ",
                                             " & cod_item & ",
                                            '" & cod_barra & "',
                                            '" & cod_referencia & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_item_fornecedor Set cod_pessoa_fornecedor = " & cod_pessoa_fornecedor & ",
                                            cod_barra = '" & cod_barra & "',
                                            cod_referencia = '" & cod_referencia & "'
                                      Where seq_item_fornecedor = " & seq_item_fornecedor & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_item_fornecedor Where seq_item_fornecedor =" & seq_item_fornecedor & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer)
        sql = "Select a.seq_item_fornecedor,
                      a.cod_pessoa_fornecedor,
                      b.nom_pessoa,
                      a.cod_barra,
                      a.cod_referencia
               From tab_item_fornecedor a 
               join tab_pessoa b on (a.cod_pessoa_fornecedor = b.cod_pessoa)     
               where cod_item = " & cod & " 
              order by b.nom_pessoa"
        ds = con.Listar(sql)

        Return ds
    End Function

    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(seq_item_fornecedor),0)as ultimo From tab_item_fornecedor"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
