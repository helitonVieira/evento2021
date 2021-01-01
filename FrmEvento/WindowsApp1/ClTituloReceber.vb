Public Class ClTituloReceber
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private seq_titulo_ As Integer
    Public Property seq_titulo() As Integer
        Get
            Return seq_titulo_
        End Get
        Set(ByVal value As Integer)
            seq_titulo_ = value
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

    Private num_titulo_ As String
    Public Property num_titulo() As String
        Get
            Return num_titulo_
        End Get
        Set(ByVal value As String)
            num_titulo_ = value
        End Set
    End Property

    Private cod_pessoa_sacado_ As Integer
    Public Property cod_pessoa_sacado() As Integer
        Get
            Return cod_pessoa_sacado_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_sacado_ = value
        End Set
    End Property

    Private dta_emissao_ As String
    Public Property dta_emissao() As String
        Get
            Return dta_emissao_
        End Get
        Set(ByVal value As String)
            dta_emissao_ = value
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

    Private dta_liquidacao_ As String
    Public Property dta_liquidacao() As String
        Get
            Return dta_liquidacao_
        End Get
        Set(ByVal value As String)
            dta_liquidacao_ = value
        End Set
    End Property

    Private cod_tipo_cobranca_ As Integer
    Public Property cod_tipo_cobranca() As Integer
        Get
            Return cod_tipo_cobranca_
        End Get
        Set(ByVal value As Integer)
            cod_tipo_cobranca_ = value
        End Set
    End Property

    Private val_original_ As String
    Public Property val_original() As String
        Get
            Return val_original_
        End Get
        Set(ByVal value As String)
            val_original_ = value
        End Set
    End Property

    Private val_juros_original_ As String
    Public Property val_juros_original() As String
        Get
            Return val_juros_original_
        End Get
        Set(ByVal value As String)
            val_juros_original_ = value
        End Set
    End Property

    Private val_liquidado_ As String
    Public Property val_liquidado() As String
        Get
            Return val_liquidado_
        End Get
        Set(ByVal value As String)
            val_liquidado_ = value
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
    Private ind_tipo_titulo_ As String
    Public Property ind_tipo_titulo() As String
        Get
            Return ind_tipo_titulo_
        End Get
        Set(ByVal value As String)
            ind_tipo_titulo_ = value
        End Set
    End Property

    Private ind_status_ As String
    Public Property ind_status() As String
        Get
            Return ind_status_
        End Get
        Set(ByVal value As String)
            ind_status_ = value
        End Set
    End Property

    Private ind_fatura_ As String
    Public Property ind_fatura() As String
        Get
            Return ind_fatura_
        End Get
        Set(ByVal value As String)
            ind_fatura_ = value
        End Set
    End Property

    Private cod_pdv_ As Integer
    Public Property cod_pdv() As Integer
        Get
            Return cod_pdv_
        End Get
        Set(ByVal value As Integer)
            cod_pdv_ = value
        End Set
    End Property

    Private seq_fechamento_ As Integer
    Public Property seq_fechamento() As Integer
        Get
            Return seq_fechamento_
        End Get
        Set(ByVal value As Integer)
            seq_fechamento_ = value
        End Set
    End Property

    Private qtd_parcelas_ As Integer
    Public Property qtd_parcelas() As Integer
        Get
            Return qtd_parcelas_
        End Get
        Set(ByVal value As Integer)
            qtd_parcelas_ = value
        End Set
    End Property

    Private num_parcela_ As Integer
    Public Property num_parcela() As Integer
        Get
            Return num_parcela_
        End Get
        Set(ByVal value As Integer)
            num_parcela_ = value
        End Set
    End Property

    Private seq_titulo_pai_ As Integer
    Public Property seq_titulo_pai() As Integer
        Get
            Return seq_titulo_pai_
        End Get
        Set(ByVal value As Integer)
            seq_titulo_pai_ = value
        End Set
    End Property

    Private seq_titulo_filho_ As Integer
    Public Property seq_titulo_filho() As Integer
        Get
            Return seq_titulo_filho_
        End Get
        Set(ByVal value As Integer)
            seq_titulo_filho_ = value
        End Set
    End Property

    Private seq_titulo_negociado_ As Integer
    Public Property seq_titulo_negociado() As Integer
        Get
            Return seq_titulo_negociado_
        End Get
        Set(ByVal value As Integer)
            seq_titulo_negociado_ = value
        End Set
    End Property

    Private seq_titulo_fatura_ As Integer
    Public Property seq_titulo_fatura() As Integer
        Get
            Return seq_titulo_fatura_
        End Get
        Set(ByVal value As Integer)
            seq_titulo_fatura_ = value
        End Set
    End Property

    Private dta_negociacao_ As String
    Public Property dta_negociacao() As String
        Get
            Return dta_negociacao_
        End Get
        Set(ByVal value As String)
            dta_negociacao_ = value
        End Set
    End Property

    Private val_negociado_ As String
    Public Property val_negociado() As String
        Get
            Return val_negociado_
        End Get
        Set(ByVal value As String)
            val_negociado_ = value
        End Set
    End Property

    Private seq_nota_ As Integer
    Public Property seq_nota() As Integer
        Get
            Return seq_nota_
        End Get
        Set(ByVal value As Integer)
            seq_nota_ = value
        End Set
    End Property

    Private seq_receita_ As Integer
    Public Property seq_receita() As Integer
        Get
            Return seq_receita_
        End Get
        Set(ByVal value As Integer)
            seq_receita_ = value
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

        sql = "Insert Into tab_titulo_receber(seq_titulo          ,
                                       cod_empresa         ,
                                       num_titulo          ,
                                       cod_pessoa_sacado   ,
                                       dta_emissao         ,
                                       dta_vencimento      ,
                                       dta_liquidacao      ,
                                       cod_tipo_cobranca   ,
                                       val_original        ,
                                       val_juros_original  ,
                                       val_liquidado       ,
                                       des_observacao      ,
                                       ind_tipo_titulo     ,
                                       ind_status          ,
                                       ind_fatura          ,
                                       cod_pdv             ,
                                       seq_fechamento      ,
                                       qtd_parcelas        ,
                                       num_parcela         ,
                                       seq_titulo_pai      ,
                                       seq_titulo_filho    ,
                                       seq_titulo_negociado,
                                       seq_titulo_fatura   ,
                                       dta_negociacao      ,
                                       val_negociado       ,
                                       seq_nota            ,
                                       seq_receita         ,
                                       cod_recebimento_especie  ,
                                       val_recebimento_especie  ,
                                       val_total 				,
                                       val_desconto 			,
                                       val_desconto_porcentagem ,
                                       val_despesa_acessoria	,
                                       val_multa				,
                                       val_juros				,
                                       val_juros_porcentagem	,
                                       val_acrescimo)
                                    Values (" & seq_titulo & ",
                                            " & cod_empresa & ",
                                           '" & num_titulo & "',
                                            " & cod_pessoa_sacado & ",                                              
                                           '" & dta_emissao & "',
                                           '" & dta_vencimento & "',"

        If dta_liquidacao = "" Then
            sql = sql & " Null  ,"
        Else
            sql = sql & "'" & dta_liquidacao & "',"
        End If
        sql = sql & "   " & cod_tipo_cobranca & ",
                                           '" & Replace(Replace(val_original.ToString, ".", ""), ",", ".") & "',
                                           '" & Replace(Replace(val_juros_original.ToString, ".", ""), ",", ".") & "',
                                           '" & Replace(Replace(val_liquidado.ToString, ".", ""), ",", ".") & "',
                                           '" & des_observacao & "',
                                           '" & ind_tipo_titulo & "',
                                           '" & ind_status & "',
                                           '" & ind_fatura & "',
                                            " & cod_pdv & ",
                                            Null,
                                            " & qtd_parcelas & ",
                                            " & num_parcela & ", 
                                            Null, 
                                            Null,
                                            Null,
                                            Null,
                                            Null,
                                           '" & 0 & "',
                                            Null,
                                            Null,"

        If cod_recebimento_especie = 0 Then
            sql = sql & " Null  ,"
        End If
        sql = sql & " " & val_recebimento_especie & ",
                                           " & Replace(Replace(val_total, ".", ""), ",", ".") & ",
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
        sql = "Update tab_titulo_receber Set cod_empresa = " & cod_empresa & ",
                      cod_pessoa_sacado = '" & cod_pessoa_sacado & "',
                      dta_emissao = '" & CDate(dta_emissao).ToShortDateString & "',
                      dta_vencimento = '" & CDate(dta_vencimento).ToShortDateString & "',                      
                      cod_tipo_cobranca = '" & cod_tipo_cobranca & "', 
                      val_liquidado = " & Replace(Replace(val_liquidado.ToString, ".", ""), ",", ".") & ","
        If dta_liquidacao = "" Then
            sql = sql & " dta_liquidacao =  Null ,"
        Else
            sql = sql & " dta_liquidacao = '" & CDate(dta_liquidacao).ToShortDateString & "',"
        End If


        sql = sql & " des_observacao = '" & des_observacao & "',
                      ind_tipo_titulo = '" & ind_tipo_titulo & "',
                      ind_status = '" & ind_status & "',
                      ind_fatura = '" & ind_fatura & "',"

        If cod_recebimento_especie = 0 Then
            sql = sql & " cod_recebimento_especie = Null  ,"
        Else
            sql = sql & " cod_recebimento_especie = " & cod_recebimento_especie & " ,"
        End If
        sql = sql & " val_recebimento_especie = " & Replace(Replace(val_recebimento_especie, ".", ""), ",", ".") & ",
                                     val_total = " & Replace(Replace(val_total, ".", ""), ",", ".") & ",
                                     val_desconto = " & Replace(Replace(val_desconto, ".", ""), ",", ".") & ",
                                     val_desconto_porcentagem = " & Replace(Replace(val_desconto_porcentagem, ".", ""), ",", ".") & ",
                                     val_despesa_acessoria = " & Replace(Replace(val_despesa_acessoria, ".", ""), ",", ".") & ",
                                     val_multa = " & Replace(Replace(val_multa, ".", ""), ",", ".") & ",
                                     val_juros = " & Replace(Replace(val_juros, ".", ""), ",", ".") & ",
                                     val_juros_porcentagem = " & Replace(Replace(val_juros_porcentagem, ".", ""), ",", ".") & ",
                                     val_acrescimo = " & Replace(Replace(val_acrescimo, ".", ""), ",", ".") & "                                            
              Where seq_titulo = " & seq_titulo & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_titulo_receber Where seq_titulo =" & seq_titulo & ""
        con.Operar(sql)
    End Sub
    Public Function Consultar(dta_emissao_final As String, dta_vencimento_final As String, dta_liquidacao_final As String,
                              seqTitulo As Integer, codEmpresa As Integer, codTipo As Integer, numTitulo As String, dtaEmissao As String,
dtaVencimento As String, dtaLiquidacao As String, codPessoa As Integer, valOriginal As Double, valLiquidado As Double)
        sql = "Select a.seq_titulo               ,
                      a.cod_empresa              ,    
                      a.num_titulo               ,
                      a.cod_pessoa_sacado        ,
                      c.nom_pessoa As nom_pessoa , 
                      a.dta_emissao              ,
                      a.dta_vencimento           ,
                      a.cod_tipo_cobranca        ,
                      b.des_tipo_cobranca        ,
                      a.val_original             ,
                      a.val_juros_original       ,
                      a.dta_liquidacao           ,
                      a.val_liquidado            ,
                      a.des_observacao           ,
                      a.ind_tipo_titulo          ,
                      a.ind_status               ,
                      a.ind_fatura               ,
                      a.cod_pdv                  ,
                      a.seq_fechamento           ,
                      a.qtd_parcelas             ,
                      a.num_parcela              ,
                      a.seq_titulo_pai           ,
                      a.seq_titulo_filho         ,
                      a.seq_titulo_negociado     ,
                      a.seq_titulo_fatura        ,
                      a.dta_negociacao           ,
                      a.val_negociado            ,
                      a.seq_nota                 ,
                      a.seq_receita              ,
                      a.cod_recebimento_especie  ,
                      a.val_recebimento_especie  ,
                      a.val_total 				 ,
                      a.val_desconto 			 ,
                      a.val_desconto_porcentagem ,
                      a.val_despesa_acessoria	 ,
                      a.val_multa				 ,
                      a.val_juros				 ,
                      a.val_juros_porcentagem    ,
                      a.val_acrescimo ,
                      d.des_especie as des_recebimento_especie                      
     From tab_titulo_receber  a   
     Join tab_tipo_cobranca b on (a.cod_tipo_cobranca = b.cod_tipo_cobranca)
     Join tab_pessoa c on (a.cod_pessoa_sacado = c.cod_pessoa)
     left join tab_especie_caixa d on (a.cod_recebimento_especie = d.cod_especie)
     Where ((a.seq_titulo = " & seqTitulo & ") or( 0 = " & seqTitulo & "))
       And ((a.cod_empresa = " & codEmpresa & ")or(0 = " & codEmpresa & "))
       And ((a.cod_tipo_cobranca = " & codTipo & ")or(0 = " & codTipo & "))
       And ((a.num_titulo = '" & numTitulo & "')or('' = '" & numTitulo & "'))"

        If dtaEmissao <> "" Then
            sql = sql & vbCrLf & " And a.dta_emissao between '" & dtaEmissao & "' and '" & dta_emissao_final & "'"
        End If
        If dtaVencimento <> "" Then
            sql = sql & vbCrLf & " And a.dta_vencimento between '" & dtaVencimento & "' and '" & dta_vencimento_final & "'"
        End If
        If dtaLiquidacao <> "" Then
            sql = sql & vbCrLf & " And a.dta_liquidacao between '" & dtaLiquidacao & "' and '" & dta_liquidacao_final & "'"
        End If
        sql = sql & vbCrLf & " and ((a.cod_pessoa_sacado = " & codPessoa & ") or (0 = " & codPessoa & "))
                 and ((a.val_original =  " & Replace(Replace(valOriginal, ".", ""), ",", ".") & " ) or (0 = " & Replace(Replace(valOriginal, ".", ""), ",", ".") & "))               
                 and ((a.val_liquidado =" & Replace(Replace(valLiquidado, ".", ""), ",", ".") & " ) or (0 = " & Replace(Replace(valLiquidado, ".", ""), ",", ".") & "))               
              order by a.seq_titulo desc"
        ds = con.Listar(sql)

        Return ds
    End Function

    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(seq_titulo),0)as ultimo From tab_titulo_receber"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
