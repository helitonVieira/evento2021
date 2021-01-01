Public Class ClIngressoImpresso
    Dim sql As String
    Dim ds, dsUtimo As New DataSet
    Dim con As New ConexaoSQL

    Private seq_impressao_ As Integer
    Public Property seq_impressao() As Integer
        Get
            Return seq_impressao_
        End Get
        Set(ByVal value As Integer)
            seq_impressao_ = value
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

    Private seq_ingresso_ As Integer
    Public Property seq_ingresso() As Integer
        Get
            Return seq_ingresso_
        End Get
        Set(ByVal value As Integer)
            seq_ingresso_ = value
        End Set
    End Property

    Private qtd_impressa_ As String
    Public Property qtd_impressa() As String
        Get
            Return qtd_impressa_
        End Get
        Set(ByVal value As String)
            qtd_impressa_ = value
        End Set
    End Property

    Private val_total_impresso_ As String
    Public Property val_total_impresso() As String
        Get
            Return val_total_impresso_
        End Get
        Set(ByVal value As String)
            val_total_impresso_ = value
        End Set
    End Property

    Public Sub InserirIngressoImpresso()
        sql = "Insert Into tab_ingresso_impresso Values (" & seq_impressao & ",'" & cod_evento & "' ,'" & seq_ingresso & "' ,'" & qtd_impressa & "' , '" & val_total_impresso & "')"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarIngresso()
        sql = "Update tab_ingresso Set cod_evento = '" & cod_evento & "' ,seq_ingresso = '" & seq_ingresso & "',  qtd_impressa = " & qtd_impressa & ",val_total_impresso = '" & val_total_impresso & "' Where seq_ingresso = " & seq_impressao & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirIngressoImpresso()
        sql = " Delete from tab_ingresso_impresso Where seq_impressao =" & seq_impressao & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarIngressoImpresso()
        sql = "Select * From tab_ingresso_impresso where cod_evento =" & cod_evento & ""
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarIngressoImpressoAberto()
        sql = " Select b.seq_impressao,
	                   concat(c.des_ingresso, ' - ' ,c.des_lote )  as des_impressao 
	             From  tab_ingresso_impresso b
                 inner join tab_ingresso c on (c.seq_ingresso = b.seq_ingresso)
                 inner join tab_evento e on (e.cod_evento = c.cod_evento )
                      where e.ind_aberto = 'S'
                      and coalesce(b.qtd_impressa,0) -
                              (Select coalesce(sum(aa.qtd_entregue) ,0) -
                                  coalesce(sum(aa.qtd_devolvida) ,0)     
		                     From tab_ingresso_impresso bb
                             left join  tab_ingresso_pessoa aa on (aa.seq_impressao = bb.seq_impressao)
                             where bb.cod_evento = b.cod_evento
	                          and bb.seq_impressao = b.seq_impressao) > 0
                	  and b.cod_evento  =  " & cod_evento & ""
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select max(seq_impressao)  as ultimo From tab_ingresso_impresso"
        dsUtimo = con.Listar(sql)
        Return dsUtimo
    End Function

End Class
