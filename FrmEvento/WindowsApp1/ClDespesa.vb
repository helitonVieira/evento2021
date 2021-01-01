Public Class ClDespesa
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private seq_despesa_ As Integer
    Public Property seq_despesa() As Integer
        Get
            Return seq_despesa_
        End Get
        Set(ByVal value As Integer)
            seq_despesa_ = value
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

    Private dta_despesa_ As String
    Public Property dta_despesa() As String
        Get
            Return dta_despesa_
        End Get
        Set(ByVal value As String)
            dta_despesa_ = value
        End Set
    End Property

    Private num_documento_ As String
    Public Property num_documento() As String
        Get
            Return num_documento_
        End Get
        Set(ByVal value As String)
            num_documento_ = value
        End Set
    End Property

    Private val_despesa_ As String
    Public Property val_despesa() As String
        Get
            Return val_despesa_
        End Get
        Set(ByVal value As String)
            val_despesa_ = value
        End Set
    End Property

    Private cod_tipo_despesa_ As Integer
    Public Property cod_tipo_despesa() As Integer
        Get
            Return cod_tipo_despesa_
        End Get
        Set(ByVal value As Integer)
            cod_tipo_despesa_ = value
        End Set
    End Property

    Private cod_pessoa_favorecido_ As Integer
    Public Property cod_pessoa_favorecido() As Integer
        Get
            Return cod_pessoa_favorecido_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_favorecido_ = value
        End Set
    End Property

    Private des_observacao_ As String
    Public Property des_observacao() As String
        Get
            Return des_observacao_
        End Get
        Set(ByVal value As String)
            des_observacao_ = value
        End Set
    End Property

    Private cod_recebimento_especie_ As Integer
    Public Property cod_recebimento_especie() As Integer
        Get
            Return cod_recebimento_especie_
        End Get
        Set(ByVal value As Integer)
            cod_recebimento_especie_ = value
        End Set
    End Property

    Private val_recebimento_especie_ As String
    Public Property val_recebimento_especie() As String
        Get
            Return val_recebimento_especie_
        End Get
        Set(ByVal value As String)
            val_recebimento_especie_ = value
        End Set
    End Property
    Private dta_liquidacao_ As String
    Public Property dta_liquidacao() As String
        Get
            Return dta_liquidacao_
        End Get
        Set(ByVal value As String)
            dta_liquidacao_ = value
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
     Private val_desconto_ As String
    Public Property val_desconto() As String
        Get
            Return val_desconto_
        End Get
        Set(ByVal value As String)
            val_desconto_ = value
        End Set
    End Property
     Private val_desconto_porcentagem_ As String
    Public Property val_desconto_porcentagem() As String
        Get
            Return val_desconto_porcentagem_
        End Get
        Set(ByVal value As String)
            val_desconto_porcentagem_ = value
        End Set
    End Property
     Private val_despesa_acessoria_ As String
    Public Property val_despesa_acessoria() As String
        Get
            Return val_despesa_acessoria_
        End Get
        Set(ByVal value As String)
            val_despesa_acessoria_ = value
        End Set
    End Property
     Private val_multa_ As String
    Public Property val_multa() As String
        Get
            Return val_multa_
        End Get
        Set(ByVal value As String)
            val_multa_ = value
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
    
    Private val_acrescimo_ As String
    Public Property val_acrescimo() As String
        Get
            Return val_acrescimo_
        End Get
        Set(ByVal value As String)
            val_acrescimo_ = value
        End Set
    End Property

    Public Sub Cadastrar()

        sql = "Insert Into tab_despesa Values (" & seq_despesa & ",
                                             " & cod_empresa & ",
                                             '" & dta_despesa & "',
                                             '" & num_documento & "',
                                            " & Replace(Replace(val_despesa.ToString, ".", ""), ",", ".") & ",
                                             " & cod_tipo_despesa & ",
                                             " & cod_pessoa_favorecido & ",
                                            '" & des_observacao & "',"

        If cod_recebimento_especie = 0 Then
            sql = sql & " Null  ,"
        End If
        sql = sql & " " & val_recebimento_especie & ","

        If dta_liquidacao = "" Then
            sql = sql & " Null  ,"
        Else
            sql = sql & "'" & dta_liquidacao & "',"
        End If
        sql = sql & "                      " & Replace(Replace(val_total, ".", ""), ",", ".") & ",
                                           " & Replace(Replace(val_desconto, ".", ""), ",", ".") & ",
                                           " & Replace(Replace(val_desconto_porcentagem, ".", ""), ",", ".") & ",
                                           " & Replace(Replace(val_despesa_acessoria, ".", ""), ",", ".") & ",
                                           " & Replace(Replace(val_multa, ".", ""), ",", ".") & ",
                                           " & Replace(Replace(val_juros, ".", ""), ",", ".") & ",
                                           " & Replace(Replace(val_juros_porcentagem, ".", ""), ",", ".") & ",
                                           " & Replace(Replace(val_acrescimo, ".", ""), ",", ".") & ")"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_despesa Set cod_empresa = " & cod_empresa & ",
                      num_documento = '" & num_documento & "',
                      val_despesa = " & Replace(Replace(val_despesa.ToString, ".", ""), ",", ".") & ",
                      cod_tipo_despesa = " & cod_tipo_despesa & ",
                      cod_pessoa_favorecido = " & cod_pessoa_favorecido & ",
                      des_observacao = '" & des_observacao & "', "
        If cod_recebimento_especie = 0 Then
            sql = sql & " cod_recebimento_especie =  Null  ,"
        Else
            sql = sql & " cod_recebimento_especie = " & cod_recebimento_especie & ","
        End If
        sql = sql & " val_recebimento_especie = " & Replace(Replace(val_recebimento_especie.ToString, ".", ""), ",", ".") & ","
        If dta_liquidacao = "" Then
            sql = sql & " dta_liquidacao =  Null ,"
        Else
            sql = sql & " dta_liquidacao = '" & dta_liquidacao & "',"
            End If


        sql = sql & " val_total = " & Replace(Replace(val_total, ".", ""), ",", ".") & ",
                      val_desconto = " & Replace(Replace(val_desconto, ".", ""), ",", ".") & ",
                      val_desconto_porcentagem = " & Replace(Replace(val_desconto_porcentagem, ".", ""), ",", ".") & ",
                      val_despesa_acessoria = " & Replace(Replace(val_despesa_acessoria, ".", ""), ",", ".") & ",
                      val_multa = " & Replace(Replace(val_multa, ".", ""), ",", ".") & ",
                      val_juros = " & Replace(Replace(val_juros, ".", ""), ",", ".") & ",
                      val_juros_porcentagem = " & Replace(Replace(val_juros_porcentagem, ".", ""), ",", ".") & ",
                      val_acrescimo = " & Replace(Replace(val_acrescimo, ".", ""), ",", ".") & "
              Where seq_despesa = " & seq_despesa & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_despesa Where seq_despesa =" & seq_despesa & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, empresa As Integer, dta_despesa As String, dta_final As String, num_documento As String,
                            val_despesa As String, cod_tipo_despesa As Integer, cod_pessoa_favorecido As Integer, des_observacao As String)
        sql = "Select a.seq_despesa,
                      a.cod_empresa,
                      a.dta_despesa,
                      a.num_documento,
                      a.val_despesa,
                      a.cod_tipo_despesa,
                      b.des_tipo_despesa,
                      a.cod_pessoa_favorecido,
                      c.nom_pessoa As nom_pessoa_favorecido, 
                      a.des_observacao,
                      a.cod_recebimento_especie,
                      a.val_recebimento_especie,
                      d.des_especie as des_recebimento_especie,
                      a.dta_liquidacao,
                      a.val_total,
                      a.val_desconto,
                      a.val_desconto_porcentagem,
                      a.val_despesa_acessoria,
                      a.val_multa,
                      a.val_juros,
                      a.val_juros_porcentagem,
                      a.val_acrescimo
     From tab_despesa  a   
     Join tab_tipo_despesa b on (a.cod_tipo_despesa = b.cod_tipo_despesa)
     Join tab_pessoa c on (a.cod_pessoa_favorecido = c.cod_pessoa)
     left join tab_especie_caixa d on (d.cod_especie = a.cod_recebimento_especie)
     Where ((a.seq_despesa = " & cod & ") or( 0 = " & cod & "))
       And   a.cod_empresa = " & empresa & " "
        If dta_despesa <> "" Then
            sql = sql & vbCrLf & " And a.dta_despesa between '" & dta_despesa & "' and '" & dta_final & "'"
        End If

        sql = sql & vbCrLf & " and ((a.num_documento = '" & num_documento & "') or ('' = '" & num_documento & "'))
                 and ((a.val_despesa =  " & Replace(Replace(val_despesa, ".", ""), ",", ".") & " ) or (0 = " & Replace(Replace(val_despesa, ".", ""), ",", ".") & "))               
                 and ((a.cod_tipo_despesa  = " & cod_tipo_despesa & ") or (0 = " & cod_tipo_despesa & "))
                 and ((a.cod_pessoa_favorecido = " & cod_pessoa_favorecido & ") or (0 = " & cod_pessoa_favorecido & "))
                 and a.des_observacao like ('%" & des_observacao & "%') 
              order by a.dta_despesa desc"
        ds = con.Listar(sql)

        Return ds
    End Function

    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(seq_despesa),0)as ultimo From tab_despesa"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
