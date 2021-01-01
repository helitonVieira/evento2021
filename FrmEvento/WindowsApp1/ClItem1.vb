Public Class ClItem1
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoSQL
    Dim ultimoItem As Integer

    Private cod_item_ As Integer
    Public Property cod_item() As Integer
        Get
            Return cod_item_
        End Get
        Set(ByVal value As Integer)
            cod_item_ = value
        End Set
    End Property

    Private des_item_ As String
    Public Property des_item() As String
        Get
            Return des_item_
        End Get
        Set(ByVal value As String)
            des_item_ = value
        End Set
    End Property

    Private val_preco_venda_ As String
    Public Property val_preco_venda() As String

        Get
            Return val_preco_venda_
        End Get
        Set(ByVal value As String)
            val_preco_venda_ = value
        End Set
    End Property

    Private val_custo_ As String
    Public Property val_custo() As String
        Get
            Return val_custo_
        End Get
        Set(ByVal value As String)
            val_custo_ = value
        End Set
    End Property

    Private ind_ativo_ As String
    Public Property ind_ativo() As String
        Get
            Return ind_ativo_
        End Get
        Set(ByVal value As String)
            ind_ativo_ = value
        End Set
    End Property

    Private cod_evento_ As String
    Public Property cod_evento() As String
        Get
            Return cod_evento_
        End Get
        Set(ByVal value As String)
            cod_evento_ = value
        End Set
    End Property

    Public Sub CadastrarItem()
        sql = "Insert Into tab_item( des_item, val_preco_venda, val_custo, ind_ativo, cod_evento) Values ('" & des_item & "' , '" & val_preco_venda & "','" & val_custo & "','" & ind_ativo & "','" & cod_evento & "')"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarItem()
        sql = "Update tab_item Set des_item = '" & des_item & "' ,
                                  val_preco_venda = " & val_preco_venda & ",
                                  val_custo =" & val_custo & ",
                                  ind_ativo ='" & ind_ativo & "',
                                  cod_evento =" & cod_evento & " 
                                  Where cod_item = " & cod_item & ""
        con.Operar(sql)
    End Sub
    Public Sub AtualizarItemEvento()
        sql = "Update tab_item Set des_item = '" & des_item & "' ,val_preco_venda = " & val_preco_venda & ",val_custo =" & val_custo & ",ind_ativo ='" & ind_ativo & "',cod_evento =" & cod_evento & " Where cod_evento = " & cod_evento & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirItem()
        sql = " Delete from tab_item Where cod_item =" & cod_item & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarItem()
        sql = "Select * From tab_item"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarItemCodigo()
        sql = "Select * From tab_item Where cod_item =" & cod_item & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarItemVenda(desItem As String, codBarra As String)
        sql = "Select a.cod_barra, 
       a.des_item ,
       COALESCE((select b.val_preco_a from tab_preco_venda b 
         where b.cod_item = a.cod_item
         and b.seq_preco_venda = (select max(bb.seq_preco_venda) from tab_preco_venda bb
                             where bb.cod_item =a.cod_item
                               and bb.cod_empresa = b.cod_empresa
                               and bb.dta_inicio <= 'today')
         and b.dta_inicio = (select max(bb.dta_inicio) from tab_preco_venda bb
                             where bb.cod_item =a.cod_item
                               and bb.cod_empresa = b.cod_empresa
                               and bb.dta_inicio <= 'today')),0) as val_preco_venda, 

      COALESCE((select b.val_preco_b from tab_preco_venda b 
         where b.cod_item = a.cod_item
         and b.seq_preco_venda = (select max(bb.seq_preco_venda) from tab_preco_venda bb
                             where bb.cod_item =a.cod_item
                               and bb.cod_empresa = b.cod_empresa
                               and bb.dta_inicio <= 'today')
         and b.dta_inicio = (select max(bb.dta_inicio) from tab_preco_venda bb
                             where bb.cod_item =a.cod_item
                               and bb.cod_empresa = b.cod_empresa
                               and bb.dta_inicio <= 'today')),0) as val_preco_venda_b,

        COALESCE((select b.val_preco_c from tab_preco_venda b 
         where b.cod_item = a.cod_item
         and b.seq_preco_venda = (select max(bb.seq_preco_venda) from tab_preco_venda bb
                             where bb.cod_item =a.cod_item
                               and bb.cod_empresa = b.cod_empresa
                               and bb.dta_inicio <= 'today')
         and b.dta_inicio = (select max(bb.dta_inicio) from tab_preco_venda bb
                             where bb.cod_item =a.cod_item
                               and bb.cod_empresa = b.cod_empresa
                               and bb.dta_inicio <= 'today')),0) as val_preco_venda_c,

       COALESCE((select b.val_preco_d from tab_preco_venda b 
         where b.cod_item = a.cod_item
         and b.seq_preco_venda = (select max(bb.seq_preco_venda) from tab_preco_venda bb
                             where bb.cod_item =a.cod_item
                               and bb.cod_empresa = b.cod_empresa
                               and bb.dta_inicio <= 'today')
         and b.dta_inicio = (select max(bb.dta_inicio) from tab_preco_venda bb
                             where bb.cod_item =a.cod_item
                               and bb.cod_empresa = b.cod_empresa
                               and bb.dta_inicio <= 'today')),0) as val_preco_venda_d,

       COALESCE((select sum(aa.val_custo_total)/ sum(aa.qtd_item)
          from  tab_inventario_rapido aa
          join tab_tipo_movimento bb on (aa.cod_tipo_movimento = bb.cod_tipo_movimento)
         where aa.cod_item = a.cod_item  
           and bb.ind_entrada = 'E'     
           and aa.dta_inventario = (select max(aaa.dta_inventario)from tab_inventario_rapido aaa
                        join tab_tipo_movimento bbb on (aaa.cod_tipo_movimento = bbb.cod_tipo_movimento)    
                        where aaa.cod_item = aa.cod_item
                        and aaa.cod_empresa = aa.cod_empresa
                        and bbb.ind_entrada = 'E'
                        and aaa.dta_inventario <='today')),0) as val_custo,
      b.cod_unidade,
      b.sgl_unidade ,
      a.cod_item
     
      From tab_item a      
      join tab_unidade b on (a.cod_unidade = b.cod_unidade)
      where a.des_item like ('%" & desItem & "%')
        and a.cod_barra like ('%" & codBarra & "%')
        and ind_ativo = 'S'
      Order by a.des_item"

        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarCodBarra(desItem As String)
        sql = "Select a.cod_barra, 
       a.des_item ,
       COALESCE((select b.val_preco_a from tab_preco_venda b 
         where b.cod_item = a.cod_item
         and b.dta_inicio = (select max(bb.dta_inicio) from tab_preco_venda bb
                             where bb.cod_item =a.cod_item
                               and bb.cod_empresa = b.cod_empresa
                               and bb.dta_inicio <= 'today')),0) as val_preco_venda, 
        COALESCE((select b.val_preco_b from tab_preco_venda b 
         where b.cod_item = a.cod_item
         and b.dta_inicio = (select max(bb.dta_inicio) from tab_preco_venda bb
                             where bb.cod_item =a.cod_item
                               and bb.cod_empresa = b.cod_empresa
                               and bb.dta_inicio <= 'today')),0) as val_preco_venda_b,
        COALESCE((select b.val_preco_c from tab_preco_venda b 
         where b.cod_item = a.cod_item
         and b.dta_inicio = (select max(bb.dta_inicio) from tab_preco_venda bb
                             where bb.cod_item =a.cod_item
                               and bb.cod_empresa = b.cod_empresa
                               and bb.dta_inicio <= 'today')),0) as val_preco_venda_c,
       COALESCE((select b.val_preco_d from tab_preco_venda b 
         where b.cod_item = a.cod_item
         and b.dta_inicio = (select max(bb.dta_inicio) from tab_preco_venda bb
                             where bb.cod_item =a.cod_item
                               and bb.cod_empresa = b.cod_empresa
                               and bb.dta_inicio <= 'today')),0) as val_preco_venda_d,

       COALESCE((select sum(aa.val_custo_total)/ sum(aa.qtd_item)
          from  tab_inventario_rapido aa
          join tab_tipo_movimento bb on (aa.cod_tipo_movimento = bb.cod_tipo_movimento)
         where aa.cod_item = a.cod_item  
           and bb.ind_entrada = 'E'     
           and aa.dta_inventario = (select max(aaa.dta_inventario)from tab_inventario_rapido aaa
                        join tab_tipo_movimento bbb on (aaa.cod_tipo_movimento = bbb.cod_tipo_movimento)    
                        where aaa.cod_item = aa.cod_item
                        and aaa.cod_empresa = aa.cod_empresa
                        and bbb.ind_entrada = 'E'
                        and aaa.dta_inventario <='today')),0) as val_custo,
      b.cod_unidade,
      b.sgl_unidade ,
      a.cod_item
     
      From tab_item a      
      join tab_unidade b on (a.cod_unidade = b.cod_unidade)
      where a.cod_barra like ('%" & desItem & "%')
        and ind_ativo = 'S'
      Order by a.des_item"

        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarItemPesquisa(busca As String)

        sql = "Select * 
              From tab_item
              where des_item like ('%" & busca & "%')
                and ind_ativo = 'S'
              order by des_item"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoItemCadastrado()
        sql = "Select  coalesce(max(cod_item),0) From tab_item"
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
