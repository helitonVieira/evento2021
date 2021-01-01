Public Class ClResumoVendaItem
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private seq_venda_ As Integer
    Public Property seq_venda() As Integer
        Get
            Return seq_venda_
        End Get
        Set(ByVal value As Integer)
            seq_venda_ = value
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

    Private cod_item_ As String
    Public Property cod_item() As String
        Get
            Return cod_item_
        End Get
        Set(ByVal value As String)
            cod_item_ = value
        End Set
    End Property

    Private qtd_item_ As Integer
    Public Property qtd_item() As Integer
        Get
            Return qtd_item_
        End Get
        Set(ByVal value As Integer)
            qtd_item_ = value
        End Set
    End Property

    Private val_unitario_ As String
    Public Property val_unitario() As String
        Get
            Return val_unitario_
        End Get
        Set(ByVal value As String)
            val_unitario_ = value
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
    Private val_acrescimo_ As String
    Public Property val_acrescimo() As String
        Get
            Return val_acrescimo_
        End Get
        Set(ByVal value As String)
            val_acrescimo_ = value
        End Set
    End Property

    Private val_liquido_ As String
    Public Property val_liquido() As String
        Get
            Return val_liquido_
        End Get
        Set(ByVal value As String)
            val_liquido_ = value
        End Set
    End Property

    Private ind_tipo_ As String
    Public Property ind_tipo() As String
        Get
            Return ind_tipo_
        End Get
        Set(ByVal value As String)
            ind_tipo_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        zerarSequenciador()
        sql = "Insert Into tab_resumo_venda_item                                      
   
select (select coalesce(max(seq_venda),0)+1 from tab_resumo_venda_item)+ nextval('seq_venda'),
                       " & seq_fechamento & " ,                       
                       b.cod_item,                        
                       COALESCE( sum(b.qtd_item),0) as qtd_item, 
                       b.val_unitario as val_unitario, 
                       COALESCE( sum(b.val_desconto),0)  as val_desconto ,
                       COALESCE( sum(b.val_acrescimo),0)  as  val_acrescimo  ,
                       COALESCE(sum(b.val_bruto_item),0) - COALESCE(sum(b.val_desconto),0) 
                           + COALESCE(sum(b.val_acrescimo),0)  as val_liquido,
                       c.ind_tipo    
               from tab_nota_fiscal_saida a 
               join tab_item_nfs b on (a.seq_nota = b.seq_nota)
               join tab_item c on (c.cod_item = b.cod_item)               
               where  a.seq_fechamento =  " & seq_fechamento & "
                 and c.ind_tipo = 'P'
                 and a.ind_status <> 'C' 
               group by b.cod_item,
                        b.val_unitario,
                        c.ind_tipo"
        con.Operar(sql)
    End Sub
    Private Sub zerarSequenciador()
        sql = "ALTER SEQUENCE seq_venda RESTART WITH 0"
        con.Operar(sql)
    End Sub

    Public Sub Excluir()
        sql = " Delete from tab_movimento_estoque Where seq_fechamento =" & seq_fechamento & ""
        con.Operar(sql)
        sql = " Delete from tab_resumo_venda_item Where seq_fechamento =" & seq_fechamento & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(seq_venda As Integer, seq_fechamento As Integer, des_item As String, cod_item As Double)
        sql = "Select a.seq_venda             ,
                      a.seq_fechamento        ,
                      a.cod_item              ,
                      b.des_item              ,
                      a.qtd_item              ,
                      a.val_unitario          ,
                      a.val_liquido           ,
                      a.val_desconto          ,
                      a.val_acrescimo         ,
                      a.ind_tipo  
             From tab_resumo_venda_item a
             join tab_item b on (a.cod_item = b.cod_item)   
               where ((b.des_item like ('%" & des_item & "%') )or ('' = '" & des_item & "' ))  
                 and ((a.seq_venda = " & seq_venda & " )or (0 = " & seq_venda & "))
                 and ((a.seq_fechamento = " & seq_fechamento & " )or (0 = " & seq_fechamento & "))
                 and ((a.cod_item = " & cod_item & " )or (0 = " & cod_item & "))
              order by a.seq_venda, a.des_item"
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
