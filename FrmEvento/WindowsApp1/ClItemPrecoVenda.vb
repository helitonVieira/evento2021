Public Class ClItemPrecoVenda
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private seq_preco_venda_ As Integer
    Public Property seq_preco_venda() As Integer
        Get
            Return seq_preco_venda_
        End Get
        Set(ByVal value As Integer)
            seq_preco_venda_ = value
        End Set
    End Property

    Private cod_empresa_ As Integer
    Public Property cod_empresa() As Integer
        Get
            Return cod_empresa_
        End Get
        Set(ByVal value As Integer)
            cod_empresa_ = value
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

    Private dta_inicio_ As String
    Public Property dta_inicio() As String
        Get
            Return dta_inicio_
        End Get
        Set(ByVal value As String)
            dta_inicio_ = value
        End Set
    End Property

    Private val_preco_a_ As String
    Public Property val_preco_a() As String
        Get
            Return val_preco_a_
        End Get
        Set(ByVal value As String)
            val_preco_a_ = value
        End Set
    End Property

    Private val_preco_b_ As String
    Public Property val_preco_b() As String
        Get
            Return val_preco_b_
        End Get
        Set(ByVal value As String)
            val_preco_b_ = value
        End Set
    End Property

    Private val_preco_c_ As String
    Public Property val_preco_c() As String
        Get
            Return val_preco_c_
        End Get
        Set(ByVal value As String)
            val_preco_c_ = value
        End Set
    End Property

    Private val_preco_d_ As String
    Public Property val_preco_d() As String
        Get
            Return val_preco_d_
        End Get
        Set(ByVal value As String)
            val_preco_d_ = value
        End Set
    End Property

    Private cod_pessoa_ As Integer
    Public Property cod_pessoa() As Integer
        Get
            Return cod_pessoa_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_ = value
        End Set
    End Property

    Private cod_forma_pagamento_ As Integer
    Public Property cod_forma_pagamento() As Integer
        Get
            Return cod_forma_pagamento_
        End Get
        Set(ByVal value As Integer)
            cod_forma_pagamento_ = value
        End Set
    End Property
    Public Sub Cadastrar()

        sql = "Insert Into tab_preco_venda( seq_preco_venda,
                                              cod_empresa,
                                              cod_item,
                                              dta_inicio,
                                              val_preco_a,
                                              val_preco_b,
                                              val_preco_c,
                                              val_preco_d,
                                              cod_pessoa,
                                              cod_forma_pagamento)
                                     Values (" & seq_preco_venda & ",
                                             " & cod_empresa & ",
                                             " & cod_item & ",
                                             '" & dta_inicio & "',
                                            '" & Replace(val_preco_a, ",", ".") & "',
                                            '" & Replace(val_preco_b, ",", ".") & "',
                                            '" & Replace(val_preco_c, ",", ".") & "',
                                            '" & Replace(val_preco_d, ",", ".") & "',
                                            " & "Null" & ",
                                            " & "Null" & ")"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_preco_venda Set cod_empresa = " & cod_empresa & ",
                                            dta_inicio = '" & dta_inicio & "'
                                            val_preco_a = '" & val_preco_a & "',
                                            val_preco_b = '" & val_preco_b & "',
                                            val_preco_c = '" & val_preco_c & "',
                                            val_preco_d = '" & val_preco_d & "',
                                            cod_pessoa = " & cod_pessoa & ",
                                            cod_forma_pagamento = " & cod_forma_pagamento & "
                                      Where seq_preco_venda = " & seq_preco_venda & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_preco_venda Where seq_preco_venda =" & seq_preco_venda & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer)
        sql = "Select seq_preco_venda,
                      dta_inicio,
                      val_preco_a,
                      val_preco_b,
                      val_preco_c,
                      val_preco_d
               From tab_preco_venda a               
               where cod_item = " & cod & " 
              order by a.dta_inicio desc"
        ds = con.Listar(sql)

        Return ds
    End Function

    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(seq_preco_venda),0)as ultimo From tab_preco_venda"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
