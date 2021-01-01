Public Class ClIngressoPessoa

    Dim sql As String
    Dim ds, dsUtimo As New DataSet
    Dim con As New ConexaoSQL
    Dim ultimoEvento As Integer

    Private seq_lancamento_ As Integer
    Public Property seq_lancamento() As Integer
        Get
            Return seq_lancamento_
        End Get
        Set(ByVal value As Integer)
            seq_lancamento_ = value
        End Set
    End Property

    Private cod_evento_ As Integer
    Public Property cod_evento() As Integer
        Get
            Return cod_evento_
        End Get
        Set(ByVal value As Integer)
            cod_evento_ = value
        End Set
    End Property

    Private seq_impressao_ As Integer
    Public Property seq_impressao() As Integer
        Get
            Return seq_impressao_
        End Get
        Set(ByVal value As Integer)
            seq_impressao_ = value
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

    Private qtd_entregue_ As String
    Public Property qtd_entregue() As String
        Get
            Return qtd_entregue_
        End Get
        Set(ByVal value As String)
            qtd_entregue_ = value
        End Set
    End Property

    Private qtd_devolvida_ As String
    Public Property qtd_devolvida() As String
        Get
            Return qtd_devolvida_
        End Get
        Set(ByVal value As String)
            qtd_devolvida_ = value
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

    Private dta_entrega_ As String
    Public Property dta_entrega() As String
        Get
            Return dta_entrega_
        End Get
        Set(ByVal value As String)
            dta_entrega_ = value
        End Set
    End Property

    Public Sub CadastrarIngressoPessoa()
        sql = "Insert Into tab_ingresso_pessoa(seq_lancamento,
                                         seq_impressao   ,
                                         cod_pessoa     ,
                                         qtd_entregue   ,
                                         qtd_devolvida  ,
                                         des_observacao ,
                                         dta_entrega) Values (" & seq_lancamento & ",
                                                              '" & seq_impressao & "' ,
                                                              '" & cod_pessoa & "' ,
                                                              '" & qtd_entregue & "' ,
                                                              '" & qtd_devolvida & "',
                                                              '" & des_observacao & "' ,
                                                              '" & dta_entrega & "' )"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarIngressoPessoa()
        sql = "Update tab_ingresso_pessoa Set seq_impressao =   " & seq_impressao & " ,
                                       cod_pessoa =     " & cod_pessoa & ",
                                       qtd_entregue =   '" & qtd_entregue & "',
                                       qtd_devolvida =  '" & qtd_devolvida & "',
                                       des_observacao = '" & des_observacao & "',
                                       dta_entrega =    '" & dta_entrega & "'
                                       Where seq_lancamento = " & seq_lancamento & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirIngressoPessoa()
        sql = " Delete from tab_ingresso_pessoa Where seq_lancamento =" & seq_lancamento & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarIngressoPessoa()
        sql = "Select a.seq_lancamento,
                  a.seq_impressao,
	        	  concat(c.des_ingresso, ' - ' ,c.des_lote )  as des_impressao ,
	        	  a.cod_pessoa ,
	        	  d.NOM_PESSOA ,
	        	  a.qtd_entregue ,
	        	  a.qtd_devolvida ,
	        	  a.des_observacao ,
	        	  a.dta_entrega 		
	           From tab_ingresso_pessoa a
               inner join tab_ingresso_impresso b on (a.seq_impressao = b.seq_impressao)
               inner join tab_ingresso c on (b.seq_ingresso = c.seq_ingresso )
               inner join tab_pessoa d on (d.cod_pessoa = a.cod_pessoa)
                 where b.cod_evento  =" & cod_evento & ""
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarIngressoEventoAberto()
        sql = "Select b.seq_ingresso,
               a.cod_evento,
               a.nom_evento,
               b.des_ingresso,
               b.des_ingresso1,
               b.val_entrada,
               a.dta_evento,
               b.des_lote,
               a.ind_aberto,
               b.des_observacao1,
               b.des_observacao2 ,
			   coalesce((SELECT sum(i.qtd_impressa) from tab_ingresso_impresso i 
			   where i.cod_evento = a.cod_evento
			     and i.seq_ingresso = b.seq_ingresso ),0) as qtd_impressa,
			   coalesce((SELECT sum(i.qtd_impressa) from tab_ingresso_impresso i 
			   where i.cod_evento = a.cod_evento ),0) as qtd_total_impressa

               From tab_evento a  
               Join tab_ingresso b  on (a.cod_evento = b.cod_evento)
               where b.ind_aberto = 'S'"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultaringressoCodigo()
        sql = "Select * From tab_ingresso where  cod_evento =" & cod_evento & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarQtdDisponivel()
        sql = "  Select coalesce(b.qtd_impressa,0) -
                        coalesce(sum(a.qtd_entregue) ,0) +
                        coalesce(sum(a.qtd_devolvida) ,0) as qtd_disponivel        
		         From tab_ingresso_impresso b
                 left join  tab_ingresso_pessoa a on (a.seq_impressao = b.seq_impressao)
                 where b.cod_evento =" & cod_evento & "
	               and b.seq_impressao = " & seq_impressao & "
	             group by b.qtd_impressa "
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultaGeralIngPessoa()
        sql = " Select d.COD_PESSOA,
                       d.NOM_PESSOA ,
		               c.des_lote   as des_impressao ,
		               a.dta_entrega,
                      coalesce( sum(a.qtd_entregue),0) as qtd_entregue,
                      coalesce( sum(a.qtd_devolvida),0) as qtd_devolvida,
		               ( coalesce(sum(a.qtd_entregue),0)-coalesce(sum(a.qtd_devolvida),0)) * coalesce(c.val_entrada,0)  as val_total        
                From tab_ingresso_pessoa a
                inner join tab_ingresso_impresso b on (a.seq_impressao = b.seq_impressao)
                inner join tab_ingresso c on (c.seq_ingresso = b.seq_ingresso  )
                inner join tab_pessoa d on (d.cod_pessoa = a.cod_pessoa)
                where b.cod_evento  = " & cod_evento & "
	            group by b.qtd_impressa,
	                     d.COD_PESSOA,
                         d.NOM_PESSOA ,
	          		     c.des_ingresso,
	          		    c.des_lote,
	          		    a.dta_entrega,
	          		    c.val_entrada  
                order by 2,3,4 "

        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarEventoCodNom()
        sql = "Select a.cod_evento, a.nom_evento, b.des_ingresso, b.des_ingresso1
                 From tab_evento a
                 Join tab_ingresso b on(a.cod_evento = b.cod_evento
                 Where ind_aberto = 'S'"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select max(seq_lancamento) as ultimo From tab_ingresso_pessoa"
        dsUtimo = con.Listar(sql)
        Return dsUtimo
    End Function
End Class
