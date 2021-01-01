Public Class ClFechamentoCaixaPdv
    Dim sql As String
    Dim ds, dsRecebimento, dsVendaTipo, dsUltimo As New DataSet
    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private seq_fechamento_ As Integer
    Public Property seq_fechamento() As Integer
        Get
            Return seq_fechamento_
        End Get
        Set(ByVal value As Integer)
            seq_fechamento_ = value
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

    Private cod_operador_ As Integer
    Public Property cod_operador() As Integer
        Get
            Return cod_operador_
        End Get
        Set(ByVal value As Integer)
            cod_operador_ = value
        End Set
    End Property

    Private dta_fechamento_ As String
    Public Property dta_fechamento() As String
        Get
            Return dta_fechamento_
        End Get
        Set(ByVal value As String)
            dta_fechamento_ = value
        End Set
    End Property

    Private num_fechamento_ As Integer
    Public Property num_fechamento() As Integer
        Get
            Return num_fechamento_
        End Get
        Set(ByVal value As Integer)
            num_fechamento_ = value
        End Set
    End Property

    Private hra_abertura_ As String
    Public Property hra_abertura() As String
        Get
            Return hra_abertura_
        End Get
        Set(ByVal value As String)
            hra_abertura_ = value
        End Set
    End Property

    Private hra_fechamento_ As String
    Public Property hra_fechamento() As String
        Get
            Return hra_fechamento_
        End Get
        Set(ByVal value As String)
            hra_fechamento_ = value
        End Set
    End Property

    Private nom_operador_ As String
    Public Property nom_operador() As String
        Get
            Return nom_operador_
        End Get
        Set(ByVal value As String)
            nom_operador_ = value
        End Set
    End Property

    Private val_troco_inicial_ As String
    Public Property val_troco_inicial() As String
        Get
            Return val_troco_inicial_
        End Get
        Set(ByVal value As String)
            val_troco_inicial_ = value
        End Set
    End Property

    Private val_troco_final_ As String
    Public Property val_troco_final() As String
        Get
            Return val_troco_final_
        End Get
        Set(ByVal value As String)
            val_troco_final_ = value
        End Set
    End Property
    Private val_venda_produto_ As String
    Public Property val_venda_produto() As String
        Get
            Return val_venda_produto_
        End Get
        Set(ByVal value As String)
            val_venda_produto_ = value
        End Set
    End Property
    Private val_devolucao_produto_ As String
    Public Property val_devolucao_produto() As String
        Get
            Return val_devolucao_produto_
        End Get
        Set(ByVal value As String)
            val_devolucao_produto_ = value
        End Set
    End Property
    Private val_venda_servico_ As String
    Public Property val_venda_servico() As String
        Get
            Return val_venda_servico_
        End Get
        Set(ByVal value As String)
            val_venda_servico_ = value
        End Set
    End Property
    Private val_especie_ As String
    Public Property val_especie() As String
        Get
            Return val_especie_
        End Get
        Set(ByVal value As String)
            val_especie_ = value
        End Set
    End Property
    Private val_nota_a_prazo_ As String
    Public Property val_nota_a_prazo() As String
        Get
            Return val_nota_a_prazo_
        End Get
        Set(ByVal value As String)
            val_nota_a_prazo_ = value
        End Set
    End Property
    Private val_cartao_debito_ As String
    Public Property val_cartao_debito() As String
        Get
            Return val_cartao_debito_
        End Get
        Set(ByVal value As String)
            val_cartao_debito_ = value
        End Set
    End Property
    Private val_cartao_credito_ As String
    Public Property val_cartao_credito() As String
        Get
            Return val_cartao_credito_
        End Get
        Set(ByVal value As String)
            val_cartao_credito_ = value
        End Set
    End Property

    Private val_cheque_ As String
    Public Property val_cheque() As String
        Get
            Return val_cheque_
        End Get
        Set(ByVal value As String)
            val_cheque_ = value
        End Set
    End Property

    Private val_diferenca_caixa_ As String
    Public Property val_diferenca_caixa() As String
        Get
            Return val_diferenca_caixa_
        End Get
        Set(ByVal value As String)
            val_diferenca_caixa_ = value
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

    Private ind_status_ As String
    Public Property ind_status() As String
        Get
            Return ind_status_
        End Get
        Set(ByVal value As String)
            ind_status_ = value
        End Set
    End Property
    Private val_receitas_ As String
    Public Property val_receitas() As String
        Get
            Return val_receitas_
        End Get
        Set(ByVal value As String)
            val_receitas_ = value
        End Set
    End Property

    Private val_titulos_recebidos_ As String
    Public Property val_titulos_recebidos() As String
        Get
            Return val_titulos_recebidos_
        End Get
        Set(ByVal value As String)
            val_titulos_recebidos_ = value
        End Set
    End Property

    Private val_deposito_ As String
    Public Property val_deposito() As String
        Get
            Return val_deposito_
        End Get
        Set(ByVal value As String)
            val_deposito_ = value
        End Set
    End Property

    Private val_sangria_especie_ As String
    Public Property val_sangria_especie() As String
        Get
            Return val_sangria_especie_
        End Get
        Set(ByVal value As String)
            val_sangria_especie_ = value
        End Set
    End Property

    Public Sub Cadastrar()

        sql = "Insert Into tab_fechamento_caixa_pdv(seq_fechamento,
                                       cod_pdv,
                                       cod_operador,
                                       dta_fechamento,
                                       num_fechamento,
                                       hra_abertura,
                                       hra_fechamento        ,
                                       nom_operador,
                                       val_troco_inicial , 
                                       val_troco_final       ,
                                       val_venda_produto     ,
                                       val_devolucao_produto ,
                                       val_venda_servico     ,
                                       val_especie           ,
                                       val_nota_a_prazo      ,
                                       val_cartao_debito     ,
                                       val_cartao_credito    ,
                                       val_cheque            ,
                                       val_diferenca_caixa   ,
                                       des_observacao        ,
                                       ind_status            ,
                                       val_receitas          ,
                                       val_titulos_recebidos ,
                                       val_deposito          ,
                                       val_sangria_especie )
                Values ((select coalesce(max(seq_fechamento),0)+1 from tab_fechamento_caixa_pdv),
                        " & cod_pdv & ",
                        " & cod_operador & ",
                       '" & dta_fechamento & "',
                        " & num_fechamento & ",
                       '" & hra_abertura & "', Null ,                                            
                       '" & nom_operador & "', 
                       '" & Replace(Replace(val_troco_inicial, ".", ""), ",", ".") & "',
                       0,0,0,0,0,0,0,0,0,0,'','A',0,0,0,0)"
        con.Operar(sql)
    End Sub
    Public Sub fecharCaixa(sequencia As Integer)
        sql = "Update tab_fechamento_caixa_pdv Set ind_status =  '" & ind_status & "' ,
                                                   hra_fechamento = '" & Now.ToShortTimeString & "' ,
                                                   val_troco_final = '" & Replace(Replace(val_troco_final, ".", ""), ",", ".") & "' ,
                                                   des_observacao = '" & des_observacao & "' 
           Where seq_fechamento = " & sequencia & ""
        con.Operar(sql)
    End Sub
    Public Sub Atualizar()
        sql = "Update tab_fechamento_caixa_pdv Set cod_pdv = " & cod_pdv & ",
                      dta_fechamento = '" & dta_fechamento & "',
                      num_fechamento = " & Replace(Replace(num_fechamento.ToString, ".", ""), ",", ".") & ",
                      hra_abertura = " & hra_abertura & ",
                      hra_fechamento = " & hra_fechamento & ",
                      nom_operador = '" & nom_operador & "', "
        If val_troco_inicial = 0 Then
            sql = sql & " val_troco_inicial =  Null  ,"
        Else
            sql = sql & " val_troco_inicial = " & val_troco_inicial & ","
        End If

        sql = sql & " val_troco_final = " & Replace(Replace(val_troco_final, ".", ""), ",", ".") & ",
                      val_venda_produto = " & Replace(Replace(val_venda_produto, ".", ""), ",", ".") & ",
                      val_devolucao_produto = " & Replace(Replace(val_devolucao_produto, ".", ""), ",", ".") & ",
                      val_venda_servico = " & Replace(Replace(val_venda_servico, ".", ""), ",", ".") & ",
                      val_especie = " & Replace(Replace(val_especie, ".", ""), ",", ".") & ",
                      val_nota_a_prazo = " & Replace(Replace(val_nota_a_prazo, ".", ""), ",", ".") & ",
                      val_cartao_debito = " & Replace(Replace(val_cartao_debito, ".", ""), ",", ".") & ",
                      val_cartao_credito = " & Replace(Replace(val_cartao_credito, ".", ""), ",", ".") & ",
                      val_cheque = " & Replace(Replace(val_cheque, ".", ""), ",", ".") & ",
                      val_diferenca_caixa = " & Replace(Replace(val_diferenca_caixa, ".", ""), ",", ".") & "
              Where seq_fechamento = " & seq_fechamento & ""
        con.Operar(sql)
    End Sub
    Public Sub atualizarCaixaConferido()
        sql = "Update tab_fechamento_caixa_pdv Set ind_status = 'C' ,
                     
                      val_venda_produto =  (select COALESCE(sum(b.val_bruto_item),0) - COALESCE(sum(b.val_desconto),0) 
                                                      + COALESCE(sum(b.val_acrescimo),0) 
                                            from tab_nota_fiscal_saida a 
                                            join tab_item_nfs b on (a.seq_nota = b.seq_nota)
                                            join tab_item c on (c.cod_item = b.cod_item)
                                            where  a.seq_fechamento = " & seq_fechamento & "
                                            and c.ind_tipo = 'P'
                                            and a.ind_status <> 'C') , 
                      val_venda_servico = (select COALESCE(sum(b.val_bruto_item),0) - COALESCE(sum(b.val_desconto),0) 
                                                      + COALESCE(sum(b.val_acrescimo),0) 
                                            from tab_nota_fiscal_saida a 
                                            join tab_item_nfs b on (a.seq_nota = b.seq_nota)
                                            join tab_item c on (c.cod_item = b.cod_item)
                                            where  a.seq_fechamento = " & seq_fechamento & "
                                            and c.ind_tipo = 'S'
                                            and a.ind_status <> 'C') ,
                      val_especie =  (select COALESCE( sum(a.val_pagamento),0)- COALESCE(( select  sum(b.val_troco)
		                        					                                        from  tab_nota_fiscal_saida b 
 		                        					                                        where b.seq_fechamento =  " & seq_fechamento & "),0) 
                                 from tab_pagamento_nfs a
                                 join tab_nota_fiscal_saida b ON(a.seq_nota = b.seq_nota)
                                 join tab_forma_pagto_pdv c on (a.cod_forma_pagamento = c.cod_forma_pagto)
                                 where b.seq_fechamento =  " & seq_fechamento & "
                                 and a.cod_forma_pagamento = 1 ),
                      val_nota_a_prazo =coalesce((select COALESCE(sum(a.val_pagamento),0)  
                                         from tab_pagamento_nfs a
                                         join tab_nota_fiscal_saida b ON(a.seq_nota = b.seq_nota)
                                         join tab_forma_pagto_pdv c on (a.cod_forma_pagamento = c.cod_forma_pagto)
                                         where b.seq_fechamento =  " & seq_fechamento & "
                                         and a.cod_forma_pagamento = 4 ),0),
                      val_cartao_debito = coalesce((select COALESCE(sum(a.val_pagamento),0)  
                                         from tab_pagamento_nfs a
                                         join tab_nota_fiscal_saida b ON(a.seq_nota = b.seq_nota)
                                         join tab_forma_pagto_pdv c on (a.cod_forma_pagamento = c.cod_forma_pagto)
                                         where b.seq_fechamento =  " & seq_fechamento & "
                                         and a.cod_forma_pagamento = 3 ),0),
                      val_cartao_credito = coalesce((select COALESCE(sum(a.val_pagamento),0) as val_recebimento
                                         from tab_pagamento_nfs a
                                         join tab_nota_fiscal_saida b ON(a.seq_nota = b.seq_nota)
                                         join tab_forma_pagto_pdv c on (a.cod_forma_pagamento = c.cod_forma_pagto)
                                         where b.seq_fechamento =  " & seq_fechamento & "
                                         and a.cod_forma_pagamento = 2 ),0),         
                      val_sangria_especie = COALESCE((select sum(s.val_sangria) from tab_sangria s
                                               where s.seq_fechamento = " & seq_fechamento & "),0),                   
                      val_diferenca_caixa = " & Replace(Replace(val_diferenca_caixa, ".", ""), ",", ".") & "
                 Where seq_fechamento = " & seq_fechamento & ""
        con.Operar(sql)
    End Sub
    Public Sub atualizarCaixaExtornar()
        sql = "Update tab_fechamento_caixa_pdv Set ind_status = 'F' 
                 Where seq_fechamento = " & seq_fechamento & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_fechamento_caixa_pdv Where seq_fechamento =" & seq_fechamento & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(sequencia As Integer, pdv As Integer, cod_operador As Integer, dtaInicio As String,
                              dtaFinal As String, num_fechamento As Integer, hra_abertura As String, hra_fechamento As String, status As String)
        sql = "Select a.seq_fechamento        ,
                      a.cod_pdv               ,
                      b.des_pdv               ,
                      a.cod_operador          ,
                      a.nom_operador          ,
                      a.dta_fechamento        ,
                      a.num_fechamento        ,
                      a.hra_abertura          ,
                      a.hra_fechamento        ,  
                      a.ind_status            ,
                      a.val_troco_inicial     ,
                      a.val_troco_final       ,
                      a.val_venda_produto     ,
                      a.val_devolucao_produto ,
                      a.val_venda_servico     ,
                      a.val_especie           ,
                      a.val_nota_a_prazo      ,
                      a.val_cartao_debito     ,
                      a.val_cartao_credito    ,
                      a.val_cheque            ,
                      a.val_diferenca_caixa   ,
                      a.des_observacao        ,                    
                      a.val_receitas          ,
                      a.val_titulos_recebidos ,
                      a.val_deposito          ,
                      a.val_sangria_especie
               From tab_fechamento_caixa_pdv  a  
               Join tab_pdv b on (a.cod_pdv = b.cod_pdv)
              Where ((a.seq_fechamento = " & sequencia & ") or( 0 = " & sequencia & "))
                And ((a.cod_pdv = " & pdv & ")or( 0 = " & pdv & "))"
        If dtaInicio <> "" Then
            sql = sql & vbCrLf & " And a.dta_fechamento between '" & dtaInicio & "' and '" & dtaFinal & "'"
        End If
        sql = sql & vbCrLf & " and ((a.num_fechamento = " & num_fechamento & ") or (0 = " & num_fechamento & "))
                 and ((a.cod_operador = " & cod_operador & ") or (0 = " & cod_operador & "))
                 and ((a.hra_abertura  = '" & hra_abertura & "') or ('' = '" & hra_abertura & "'))
                 and ((a.hra_fechamento = '" & hra_fechamento & "') or ('' = '" & hra_fechamento & "'))
                 and ((a.ind_status = '" & status & "') or ('T' = '" & status & "'))
                 and  ind_status <> 'A'
         order by a.seq_fechamento"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarAberto(codPdv As Integer)
        sql = "Select a.seq_fechamento,
                      a.cod_pdv,
                      b.des_pdv,
                      a.cod_operador,
                      a.dta_fechamento,
                      a.num_fechamento,
                      a.hra_abertura ,
                      a.nom_operador
                From tab_fechamento_caixa_pdv a  
                join tab_pdv b on (a.cod_pdv = b.cod_pdv)     
                Where a.cod_pdv = " & codPdv & "
                  And a.ind_status = 'A'"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function vendaProduto(seqFechamento As Integer)
        sql = "select  c.cod_barra,
                       c.des_item ,                       
                       d.sgl_unidade, 
                       b.val_unitario as val_unitario, 
                       COALESCE( sum(b.qtd_item),0) as qtd_item, 
                       COALESCE( sum(b.val_bruto_item),0)  as  val_bruto,
                       COALESCE( sum(b.val_desconto),0)  as val_desconto ,
                       COALESCE( sum(b.val_acrescimo),0)  as  val_acrescimo  ,
                       COALESCE(sum(b.val_bruto_item),0) - COALESCE(sum(b.val_desconto),0) 
                           + COALESCE(sum(b.val_acrescimo),0)  as val_liquido
               from tab_nota_fiscal_saida a 
               join tab_item_nfs b on (a.seq_nota = b.seq_nota)
               join tab_item c on (c.cod_item = b.cod_item)
               join tab_unidade d on (d.cod_unidade = b.cod_unidade)
               where  a.seq_fechamento = " & seqFechamento & "
                 and c.ind_tipo = 'P'
                 and a.ind_status <> 'C' 
               group by 1,2,3,4
               order by 2 "
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function sangria(seqFechamento As Integer)
        Dim dsSangria As New DataSet
        sql = "  select CAST('SANGRIA' AS VARCHAR(15)) AS descricao,  
                        a.val_sangria,
                        a.des_observacao  
                 from tab_sangria a 
                 where a.seq_fechamento = " & seqFechamento & ""
        dsSangria = con.Listar(sql)
        Return dsSangria
    End Function
    Public Function notaFormaPagto(seqFechamento As Integer)
        Dim dsSangria As New DataSet
        sql = " select b.des_forma_pagto,
                       sum(a.val_pagamento) as val_pagamento       
                from tab_pagamento_nfs a 
                join tab_forma_pagto_pdv b on (a.cod_forma_pagamento = b.cod_forma_pagto) 
                join tab_nota_fiscal_saida c on (c.seq_nota = a.seq_nota)
                where c.seq_fechamento = " & seqFechamento & "
                group by 1 
                order by 1 "
        dsSangria = con.Listar(sql)
        Return dsSangria
    End Function
    Public Function Notas(seqFechamento As Integer)
        Dim dsSangria As New DataSet
        sql = " select a.seq_nota,
                       a.num_nota,
                       a.cod_pessoa_cliente,
                       b.nom_pessoa as nom_cliente ,
                       a.dta_emissao,
                       a.hra_emissao,
                       a.val_acrescimo,
                       a.val_desconto,
                       a.val_total_nota        
                from tab_nota_fiscal_saida a 
                join tab_pessoa b on (a.cod_pessoa_cliente = b.cod_pessoa) 
                where a.seq_fechamento =  " & seqFechamento & "
                order by 1 "
        dsSangria = con.Listar(sql)
        Return dsSangria
    End Function
    Public Function vendaServico(seqFechamento As Integer)
        sql = "select  c.cod_barra,
                       c.des_item ,                        
                       d.sgl_unidade, 
                       b.val_unitario as val_unitario, 
                       COALESCE( sum(b.qtd_item),0) as qtd_item, 
                       COALESCE( sum(b.val_bruto_item),0)  as  val_bruto,
                       COALESCE( sum(b.val_desconto),0)  as val_desconto ,
                       COALESCE( sum(b.val_acrescimo),0)  as  val_acrescimo  ,
                       COALESCE(sum(b.val_bruto_item),0) - COALESCE(sum(b.val_desconto),0) 
                           + COALESCE(sum(b.val_acrescimo),0)  as val_liquido
               from tab_nota_fiscal_saida a 
               join tab_item_nfs b on (a.seq_nota = b.seq_nota)
               join tab_item c on (c.cod_item = b.cod_item)
               join tab_unidade d on (d.cod_unidade = b.cod_unidade)
               where  a.seq_fechamento = " & seqFechamento & "
                 and c.ind_tipo = 'S'
                 and a.ind_status <> 'C' 
               group by 1,2,3,4
               order by 2 "
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function Diferenca(seqFechamento As Integer)
        Dim dsDiferenca As New DataSet
        sql = "select  COALESCE((select  sum(a.val_pagamento)                
          from tab_pagamento_nfs a
          join tab_nota_fiscal_saida b ON(a.seq_nota = b.seq_nota)
          join tab_forma_pagto_pdv c on (a.cod_forma_pagamento = c.cod_forma_pagto)
          where b.seq_fechamento =  " & seqFechamento & "),0) -

          COALESCE(( select  sum(b.val_troco) 
                       From tab_nota_fiscal_saida b 
 							Where b.seq_fechamento = " & seqFechamento & "),0)  +         
     
          COALESCE((select sum(s.val_sangria) from tab_sangria s
                     where s.seq_fechamento = " & seqFechamento & "),0) + 
    
          COALESCE((select sum(s.val_troco_final) from tab_fechamento_caixa_pdv s
                     where s.seq_fechamento = " & seqFechamento & "),0) + 

          COALESCE(( select  sum(b.val_desconto)
                       From tab_nota_fiscal_saida b 
         			Where b.seq_fechamento = " & seqFechamento & "),0) -
         
          COALESCE(( select  sum(b.val_acrescimo) 
                       From tab_nota_fiscal_saida b 
 		              Where b.seq_fechamento = " & seqFechamento & "),0)
                            
     -  COALESCE((select a.val_troco_inicial
            from tab_fechamento_caixa_pdv a 
           where a.seq_fechamento = " & seqFechamento & "),0) -  
 
        COALESCE((select SUM(c.val_bruto_item - c.val_desconto + c.val_acrescimo)
					from tab_fechamento_caixa_pdv a 
					join tab_nota_fiscal_saida b on (a.seq_fechamento = b.seq_fechamento)
					join tab_item_nfs c on (c.seq_nota = b.seq_nota)
					where a.seq_fechamento = " & seqFechamento & "),0) as valor"

        dsDiferenca = con.Listar(sql)
        Return dsDiferenca.Tables(0).Rows(0).Item("valor")
    End Function
    Public Function ConsultarRecebimento(seqFechamento As Integer)
        sql = "select c.des_forma_pagto as descricao,
     (select COALESCE( sum(a.val_pagamento),0)- COALESCE(( select  sum(b.val_troco)
							from  tab_nota_fiscal_saida b 
 							where b.seq_fechamento =  " & seqFechamento & "),0) 
          from tab_pagamento_nfs a
          join tab_nota_fiscal_saida b ON(a.seq_nota = b.seq_nota)
          join tab_forma_pagto_pdv c on (a.cod_forma_pagamento = c.cod_forma_pagto)
          where b.seq_fechamento =  " & seqFechamento & "
          and a.cod_forma_pagamento = 1 )as val_recebimento
          from tab_forma_pagto_pdv c where c.cod_forma_pagto = 1  
          
 union all
 select c.des_forma_pagto as descricao,
 (select COALESCE(sum(a.val_pagamento),0) as val_recebimento
      from tab_pagamento_nfs a
      join tab_nota_fiscal_saida b ON(a.seq_nota = b.seq_nota)
      join tab_forma_pagto_pdv c on (a.cod_forma_pagamento = c.cod_forma_pagto)
      where b.seq_fechamento =  " & seqFechamento & "
      and a.cod_forma_pagamento = 2 )
      from tab_forma_pagto_pdv c where c.cod_forma_pagto = 2
 union all
 select c.des_forma_pagto as descricao,
      (select COALESCE(sum(a.val_pagamento),0) as val_recebimento
from tab_pagamento_nfs a
join tab_nota_fiscal_saida b ON(a.seq_nota = b.seq_nota)
join tab_forma_pagto_pdv c on (a.cod_forma_pagamento = c.cod_forma_pagto)
where b.seq_fechamento =  " & seqFechamento & "
and a.cod_forma_pagamento = 3 )
from tab_forma_pagto_pdv c where c.cod_forma_pagto = 3
 union all
 select c.des_forma_pagto as descricao,
  (select  COALESCE(sum(a.val_pagamento),0) as val_recebimento
     from tab_pagamento_nfs a
     join tab_nota_fiscal_saida b ON(a.seq_nota = b.seq_nota)
     join tab_forma_pagto_pdv c on (a.cod_forma_pagamento = c.cod_forma_pagto)
     where b.seq_fechamento = " & seqFechamento & "
     and a.cod_forma_pagamento = 4)
     from tab_forma_pagto_pdv c where c.cod_forma_pagto = 4
union all
 select CAST('SANGRIA' AS VARCHAR(60)) AS descricao,
     COALESCE((select sum(s.val_sangria) from tab_sangria s
       where s.seq_fechamento = " & seqFechamento & "),0) as valor
     union all
 select CAST('TOTAL ESPECIE' AS VARCHAR(60)) AS descricao,
     COALESCE((select sum(s.val_troco_final) from tab_fechamento_caixa_pdv s
       where s.seq_fechamento = " & seqFechamento & "),0) as valor
 union all 
       select CAST('DESCONTOS' AS VARCHAR(60)) AS descricao,
                 COALESCE(( select  sum(b.val_desconto)
							from  tab_nota_fiscal_saida b 
 							where b.seq_fechamento =  " & seqFechamento & "),0) as valor
       union all 
       select CAST('ACRESCIMOS' AS VARCHAR(60)) AS descricao,
                 COALESCE(( select  sum(b.val_acrescimo)
							from  tab_nota_fiscal_saida b 
 							where b.seq_fechamento =  " & seqFechamento & "),0) as valor"

        dsRecebimento = con.Listar(sql)
        Return dsRecebimento
    End Function
    Public Function ConsultarVendaTipo(seqFechamento As Integer)
        sql = "select cast('TROCO INICIAL' AS VARCHAR(60)) AS descricao,
COALESCE(a.val_troco_inicial,0) as valor
from tab_fechamento_caixa_pdv a 
where a.seq_fechamento = " & seqFechamento & "
 
union 
select cast('VENDA PRODUTO' AS VARCHAR(60)) AS descricao,
COALESCE((select SUM(c.val_bruto_item - c.val_desconto + c.val_acrescimo)
from tab_fechamento_caixa_pdv a 
 join tab_nota_fiscal_saida b on (a.seq_fechamento = b.seq_fechamento)
 join tab_item_nfs c on (c.seq_nota = b.seq_nota)
 join tab_item d on (d.cod_item = c.cod_item  and d.ind_tipo = 'P')
where a.seq_fechamento = " & seqFechamento & "),0) as valor

union 

select cast('VENDA SERVICO' AS VARCHAR(60)) AS descricao,
COALESCE((select SUM(c.val_bruto_item - c.val_desconto + c.val_acrescimo)
from tab_fechamento_caixa_pdv a 
 join tab_nota_fiscal_saida b on (a.seq_fechamento = b.seq_fechamento)
 join tab_item_nfs c on (c.seq_nota = b.seq_nota)
 join tab_item d on (d.cod_item = c.cod_item  and d.ind_tipo = 'S')
where a.seq_fechamento = " & seqFechamento & "),0) as valor"
        dsVendaTipo = con.Listar(sql)
        Return dsVendaTipo
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(seq_fechamento),0)as ultimo From tab_fechamento_caixa_pdv"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
