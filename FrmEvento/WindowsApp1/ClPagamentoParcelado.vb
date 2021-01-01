Public Class ClPagamentoParcelado
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private seq_pagamento_ As Integer
    Public Property seq_pagamento() As Integer
        Get
            Return seq_pagamento_
        End Get
        Set(ByVal value As Integer)
            seq_pagamento_ = value
        End Set
    End Property

    Private seq_despesa_ As Integer
    Public Property seq_despesa() As Integer
        Get
            Return seq_despesa_
        End Get
        Set(ByVal value As Integer)
            seq_despesa_ = value
        End Set
    End Property

    Private seq_titulo_ As Integer
    Public Property seq_titulo() As Integer
        Get
            Return seq_titulo_
        End Get
        Set(ByVal value As Integer)
            seq_titulo_ = value
        End Set
    End Property

    Private cod_tipo_parcela_ As Integer
    Public Property cod_tipo_parcela() As Integer
        Get
            Return cod_tipo_parcela_
        End Get
        Set(ByVal value As Integer)
            cod_tipo_parcela_ = value
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

    Private val_pagamento_ As String
    Public Property val_pagamento() As String
        Get
            Return val_pagamento_
        End Get
        Set(ByVal value As String)
            val_pagamento_ = value
        End Set
    End Property

    Private val_juros_ As String
    Public Property val_juros() As String
        Get
            Return val_juros_
        End Get
        Set(ByVal value As String)
            val_juros_ = value
        End Set
    End Property

    Private val_juros_porcentagem_ As String
    Public Property val_juros_porcentagem() As String
        Get
            Return val_juros_porcentagem_
        End Get
        Set(ByVal value As String)
            val_juros_porcentagem_ = value
        End Set
    End Property
    Private val_total_ As String
    Public Property val_total() As String
        Get
            Return val_total_
        End Get
        Set(ByVal value As String)
            val_total_ = value
        End Set
    End Property
    Public Sub Cadastrar()

        sql = "Insert Into tab_pagamento_parcelado(seq_pagamento,
                                              seq_despesa,
                                              seq_titulo,  
                                              cod_tipo_parcela,
                                              dta_vencimento,
                                              val_pagamento,
                                              val_juros,
                                              val_juros_porcentagem,
                                              val_total)
                                     Values (" & seq_pagamento & ","
        If seq_despesa = 0 Then
            sql = sql & "Null ,"
        Else
            sql = sql & " " & seq_despesa & ","
        End If

        If seq_titulo = 0 Then
            sql = sql & "Null ,"
        Else
            sql = sql & " " & seq_titulo & ","
        End If

        sql = sql & "                       " & cod_tipo_parcela & ",
                                            '" & dta_vencimento & "',
                                            '" & Replace(Replace(val_pagamento, ".", ""), ",", ".") & "',
                                            '" & Replace(Replace(val_juros, ".", ""), ",", ".") & "', 
                                            '" & Replace(Replace(val_juros_porcentagem, ".", ""), ",", ".") & "',
                                            '" & Replace(Replace(val_total, ".", ""), ",", ".") & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_pagamento_parcelado Set cod_tipo_parcela = '" & cod_tipo_parcela & "',  
                                            dta_vencimento = '" & dta_vencimento & "',
                                            val_pagamento = " & val_pagamento & ",
                                            val_juros = " & val_juros & ",
                                            val_juros_porcentagem =  " & val_juros_porcentagem & ",
                                            val_total =  " & val_total & "'
                                      Where seq_pagamento = " & seq_pagamento & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_pagamento_parcelado Where seq_pagamento =" & seq_pagamento & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, tabela As String)
        If tabela = "tab_despesa" Then
            sql = "Select a.seq_pagamento,
                          a.seq_despesa ,  
                          a.cod_tipo_parcela,
                          b.des_tipo_parcela,  
                          a.dta_vencimento,                     
                          a.val_pagamento,
                          a.val_juros,
                          a.val_juros_porcentagem,
                          a.val_total,
                         (select sum(r.val_total) from tab_pagamento_parcelado r
                                 where r.seq_despesa = a.seq_despesa)as val_total_geral 
                   From tab_pagamento_parcelado a   
                   Join tab_tipo_parcela b on (a.cod_tipo_parcela = b.cod_tipo_parcela)
                   Where seq_despesa = " & cod & "
                   Order By seq_pagamento "
        ElseIf tabela = "tab_titulo_receber" Then
            sql = "Select a.seq_pagamento,
                          a.seq_titulo ,  
                          a.cod_tipo_parcela,
                          b.des_tipo_parcela,  
                          a.dta_vencimento,                     
                          a.val_pagamento,
                          a.val_juros,
                          a.val_juros_porcentagem,
                          a.val_total,
                         (select sum(r.val_total) from tab_pagamento_parcelado r
                                 where r.seq_titulo = a.seq_titulo)as val_total_geral 
                   From tab_pagamento_parcelado a   
                   Join tab_tipo_parcela b on (a.cod_tipo_parcela = b.cod_tipo_parcela)
                   Where seq_titulo = " & cod & "
                   Order By seq_pagamento "
        ElseIf tabela = "tab_titulo_pagar" Then
            sql = "Select a.seq_pagamento,
                          a.seq_titulo_pagar ,  
                          a.cod_tipo_parcela,
                          b.des_tipo_parcela,  
                          a.dta_vencimento,                     
                          a.val_pagamento,
                          a.val_juros,
                          a.val_juros_porcentagem,
                          a.val_total,
                         (select sum(r.val_total) from tab_pagamento_parcelado r
                                 where r.seq_titulo_pagar = a.seq_titulo_pagar)as val_total_geral 
                   From tab_pagamento_parcelado a   
                   Join tab_tipo_parcela b on (a.cod_tipo_parcela = b.cod_tipo_parcela)
                   Where seq_titulo_pagar = " & cod & "
                   Order By seq_pagamento "
        End If
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function CadastradoExistemte(seq_despesa As String)
        sql = "Select  val_juros As existente From tab_pagamento_parcelado where seq_despesa = '" & seq_despesa & "'"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(seq_pagamento),0)as ultimo From tab_pagamento_parcelado"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
