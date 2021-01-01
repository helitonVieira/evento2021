Public Class ClPagamentoNfs
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private seq_nota_ As Integer
    Public Property seq_nota() As Integer
        Get
            Return seq_nota_
        End Get
        Set(ByVal value As Integer)
            seq_nota_ = value
        End Set
    End Property

    Private seq_pagamento_ As Integer
    Public Property seq_pagamento() As Integer
        Get
            Return seq_pagamento_
        End Get
        Set(ByVal value As Integer)
            seq_pagamento_ = value
        End Set
    End Property

    Private cod_forma_pagamento_ As String
    Public Property cod_forma_pagamento() As String
        Get
            Return cod_forma_pagamento_
        End Get
        Set(ByVal value As String)
            cod_forma_pagamento_ = value
        End Set
    End Property

    Private val_pagamento_ As String
    Public Property val_pagamento() As String
        Get
            Return val_pagamento_
        End Get
        Set(ByVal value As String)
            val_pagamento_ = value
        End Set
    End Property

    Private qtd_parcela_ As String
    Public Property qtd_parcela() As String
        Get
            Return qtd_parcela_
        End Get
        Set(ByVal value As String)
            qtd_parcela_ = value
        End Set
    End Property

    Private dta_vencimento_ As String
    Public Property dta_vencimento() As String
        Get
            Return dta_vencimento_
        End Get
        Set(ByVal value As String)
            dta_vencimento_ = value
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
    Public Sub Cadastrar()
        sql = "Insert Into tab_pagamento_nfs( seq_nota ,
                                              seq_pagamento,
                                              cod_forma_pagamento,
                                              val_pagamento,
                                              qtd_parcela, 
                                              dta_vencimento, 
                                              cod_pessoa) 
                    Values (" & seq_nota & ",
                           " & seq_pagamento & ",
                           " & cod_forma_pagamento & ",
                           '" & Replace(Replace(val_pagamento, ".", ""), ",", ".") & "', "
        If qtd_parcela = 0 Then
            sql = sql & "Null,"
        Else
            sql = sql & qtd_parcela & ","
        End If

         If dta_vencimento = "" Then
            sql = sql & "Null,"
        Else
            sql = sql & "'" & dta_vencimento & "',"
        End If

        If cod_pessoa = 0 Then
            sql = sql & "Null  )"
        Else
            sql = sql & cod_pessoa & ")"
        End If

        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_pagamento_nfs Set seq_pagamento = " & seq_pagamento & " , 
                                           cod_forma_pagamento = " & cod_forma_pagamento & " ,
                                           val_pagamento = '" & val_pagamento & "'
                                     Where seq_nota = " & seq_nota
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_pagamento_nfs Where seq_nota =" & seq_nota & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String, cod_forma_pagamento As String, val_pagamento As Double)
        sql = "Select a.seq_nota,
                      a.seq_pagamento,
                      a.cod_forma_pagamento,
                      a.val_pagamento
               From tab_pagamento_nfs a
               where ((a.seq_pagamento like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((a.seq_nota = " & cod & " )or (0 = " & cod & "))
                 and ((a.cod_forma_pagamento = " & cod_forma_pagamento & " )or ('' = " & cod_forma_pagamento & "))
                 and ((a.val_pagamento = " & val_pagamento & " )or (0 = " & val_pagamento & "))
              order by a.seq_pagamento"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_pagamento_nfs Where seq_nota =" & seq_nota & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select seq_nota,
                      seq_pagamento 
              From tab_pagamento_nfs
              where seq_pagamento like ('%" & busca & "%')               
              order by seq_pagamento"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(seq_nota) ,0)as ultimo From tab_pagamento_nfs"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
