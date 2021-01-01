Public Class ClPagamentoBanco
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


    Private cod_banco_ As Integer
    Public Property cod_banco() As Integer
        Get
            Return cod_banco_
        End Get
        Set(ByVal value As Integer)
            cod_banco_ = value
        End Set
    End Property

    Private num_agencia_ As String
    Public Property num_agencia() As String
        Get
            Return num_agencia_
        End Get
        Set(ByVal value As String)
            num_agencia_ = value
        End Set
    End Property

    Private num_conta_ As String
    Public Property num_conta() As String
        Get
            Return num_conta_
        End Get
        Set(ByVal value As String)
            num_conta_ = value
        End Set
    End Property

    Private dta_pre_datado_ As String
    Public Property dta_pre_datado() As String
        Get
            Return dta_pre_datado_
        End Get
        Set(ByVal value As String)
            dta_pre_datado_ = value
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

    Public Sub Cadastrar()

        sql = "Insert Into tab_pagamento_banco(seq_pagamento,
                                              seq_despesa,
                                              seq_titulo,  
                                              cod_banco,
                                              num_agencia,
                                              num_conta,
                                              dta_pre_datado, 
                                              val_pagamento)
                                     Values (" & seq_pagamento & "," & vbCrLf
        If seq_despesa = 0 Then
            sql = sql & "Null ,"
        Else
            sql = sql & " " & seq_despesa & "," & vbCrLf
        End If

        If seq_titulo = 0 Then
            sql = sql & "Null ," & vbCrLf
        Else
            sql = sql & " " & seq_titulo & "," & vbCrLf
        End If

        sql = sql & "    " & cod_banco & ",
                                            '" & num_agencia & "',
                                            '" & num_conta & "', "
        If dta_pre_datado = "" Then
            sql = sql & "Null ,"
        Else
            sql = sql & "'" & dta_pre_datado & "', "
        End If
        sql = sql & "  '" & Replace(Replace(val_pagamento, ".", ""), ",", ".") & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_pagamento_banco Set   cod_banco = '" & cod_banco & "',
                                            num_agencia = " & num_agencia & ",
                                            num_conta = '" & num_conta & "',
                                            dta_pre_datado =  '" & dta_pre_datado & "',
                                            val_pagamento =  '" & val_pagamento & "'
                                      Where seq_pagamento = " & seq_pagamento & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_pagamento_banco Where seq_pagamento =" & seq_pagamento & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, tabela As String)

        If tabela = "tab_despesa" Then
            sql = " Select a.seq_pagamento,
                           a.seq_despesa ,
                           a.cod_banco,
                           b.nom_banco,
                           a.num_agencia,
                           a.num_conta,
                           a.dta_pre_datado,
                           a.val_pagamento,
                           (select sum(r.val_pagamento) from tab_pagamento_banco r
                                  where r.seq_despesa = a.seq_despesa)as val_total  
                    From tab_pagamento_banco a   
                    Join tab_banco b on (a.cod_banco = b.cod_banco)
                    Where seq_despesa = " & cod & "
                    Order By seq_pagamento"

        ElseIf tabela = "tab_titulo_receber" Then
            sql = " Select a.seq_pagamento,
                           a.seq_titulo ,
                           a.cod_banco,
                           b.nom_banco,
                           a.num_agencia,
                           a.num_conta,
                           a.dta_pre_datado,
                           a.val_pagamento,
                           (select sum(r.val_pagamento) from tab_pagamento_banco r
                                  where r.seq_titulo = a.seq_titulo)as val_total  
                   From tab_pagamento_banco a   
                   Join tab_banco b on (a.cod_banco = b.cod_banco)
                   Where seq_titulo = " & cod & "
                   Order By seq_pagamento"

        ElseIf tabela = "tab_titulo_pagar" Then
            sql = " Select a.seq_pagamento,
                           a.seq_titulo_pagar ,
                           a.cod_banco,
                           b.nom_banco,
                           a.num_agencia,
                           a.num_conta,
                           a.dta_pre_datado,
                           a.val_pagamento,
                           (select sum(r.val_pagamento) from tab_pagamento_banco r
                                  where r.seq_titulo_pagar = a.seq_titulo_pagar)as val_total  
                   From tab_pagamento_banco a   
                   Join tab_banco b on (a.cod_banco = b.cod_banco)
                   Where seq_despesa = " & cod & "
                   Order By seq_pagamento"
        End If

        ds = con.Listar(sql)

        Return ds
    End Function
    Public Function CadastradoExistemte(seq_despesa As String)
        sql = "Select  num_conta As existente From tab_pagamento_banco where seq_despesa = '" & seq_despesa & "'"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(seq_pagamento),0)as ultimo From tab_pagamento_banco"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
