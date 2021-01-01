Public Class ClVenda
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoSQL

    Private cod_evento_ As String
    Public Property cod_evento() As Integer
        Get
            Return cod_evento_
        End Get
        Set(ByVal value As Integer)
            cod_evento_ = value
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

    Private cod_item_ As Integer
    Public Property cod_item() As Integer
        Get
            Return cod_item_
        End Get
        Set(ByVal value As Integer)
            cod_item_ = value
        End Set
    End Property

    Private qtd_item_ As String
    Public Property qtd_item() As String
        Get
            Return qtd_item_
        End Get
        Set(ByVal value As String)
            qtd_item_ = value
        End Set
    End Property

    Private val_total_item_ As String
    Public Property val_total_item() As String
        Get
            Return val_total_item_
        End Get
        Set(ByVal value As String)
            val_total_item_ = value
        End Set
    End Property

    Private val_total_custo_item_ As String
    Public Property val_total_custo_item() As String
        Get
            Return val_total_custo_item_
        End Get
        Set(ByVal value As String)
            val_total_custo_item_ = value
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

    Private dta_venda_ As String
    Public Property dta_venda() As String
        Get
            Return dta_venda_
        End Get
        Set(ByVal value As String)
            dta_venda_ = value
        End Set
    End Property

    Public Sub InserirVenda()
        sql = "Insert Into tab_venda(seq_venda,cod_evento,cod_empresa, cod_item,qtd_item,val_total_item,val_total_custo_item,ind_tipo,dta_venda )
               Values (coalesce ((select max(seq_venda) from tab_venda),0)+1,'" & cod_evento & "'," & ModParametroSistema.cod_empresa & " ,
               '" & cod_item & "','" & qtd_item & "','" & val_total_item & "','" & val_total_custo_item & "','" & ind_tipo & "',
               '" & Today.ToShortDateString.ToString & "')"
        con.Operar(sql)
    End Sub
    Public Function ResumoVendas()
        sql = " SELECT B.COD_ITEM, 
                       B.DES_ITEM ,
                       SUM(A.QTD_ITEM)AS QTDE,
                      SUM(A.QTD_ITEM) * (select t.val_preco_venda from tab_item t 
						    where t.cod_item = b.cod_item) as VAL_TOTAL, 
                       (SELECT SUM(AA.QTD_ITEM)
                          FROM  TAB_VENDA AA 
                          WHERE AA.cod_evento =  A.COD_EVENTO
                          and AA.IND_TIPO = 'P') AS QTDE_TOTAL,
                       (SELECT SUM(AA.VAL_TOTAL_ITEM)
                          FROM  TAB_VENDA AA 
                          WHERE AA.COD_EVENTO =  A.COD_EVENTO
                          AND AA.IND_TIPO = 'P' ) AS VAL_TOTAL  
                FROM  TAB_VENDA A 
                INNER JOIN TAB_ITEM B ON (A.COD_ITEM = B.COD_ITEM)
                WHERE A.cod_evento =  " & cod_evento & "
                  AND a.ind_tipo = 'P'

               GROUP BY B.COD_ITEM, B.DES_ITEM,A.COD_EVENTO
                HAVING SUM(A.QTD_ITEM) > 0 "
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ResumoVendasIngresso()
        sql = "  SELECT a.cod_evento , 
                       CONCAT ( CAST('INGRESSO 'AS VARCHAR(30)) ,  b.des_lote )  AS des_item ,
                       SUM(A.QTD_ITEM)AS QTDE,
                       SUM(A.VAL_TOTAL_ITEM) AS VAL_TOTAL ,
                       (SELECT SUM(A.QTD_ITEM)
                          FROM  TAB_VENDA A 
                          WHERE A.cod_evento =  " & cod_evento & " 
                          AND A.IND_TIPO = 'I') AS QTDE_TOTAL,
                       (SELECT SUM(A.VAL_TOTAL_ITEM)
                          FROM  TAB_VENDA A 
                          WHERE A.cod_evento =  " & cod_evento & " 
                          AND A.IND_TIPO = 'I') AS VAL_TOTAL  
                FROM  TAB_VENDA A 
                INNER JOIN TAB_EVENTO B ON (A.cod_evento  = B.cod_evento )
                WHERE A.cod_evento =  " & cod_evento & "
                  AND a.ind_tipo = 'I'
               GROUP BY a.cod_evento, B.DES_LOTE "
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function margemLucro()
        sql = " SELECT B.COD_ITEM, 
                       B.DES_ITEM ,
                       SUM(A.val_total_custo_item)AS val_custo,
                       SUM(A.VAL_TOTAL_ITEM) AS VAL_TOTAL ,
                       SUM(A.VAL_TOTAL_ITEM) -  SUM(A.val_total_custo_item) as lucro , 
                      (SELECT  CAST(SUM(A.val_total_custo_item) AS NUMERIC(15,2))
                          FROM  TAB_VENDA A 
                          INNER JOIN TAB_ITEM B ON (A.COD_ITEM = B.COD_ITEM)
                          WHERE A.cod_evento =  " & cod_evento & " 
                          AND ind_tipo = 'P') AS custo_TOTAL,
                       (SELECT SUM(A.VAL_TOTAL_ITEM)
                          FROM  TAB_VENDA A 
                          INNER JOIN TAB_ITEM B ON (A.COD_ITEM = B.COD_ITEM)
                          WHERE A.cod_evento =  " & cod_evento & " 
                           AND ind_tipo = 'P') AS VAL_TOTAL  ,
                       (SELECT SUM(A.VAL_TOTAL_ITEM)
                          FROM  TAB_VENDA A 
                          INNER JOIN TAB_ITEM B ON (A.COD_ITEM = B.COD_ITEM)
                          WHERE A.cod_evento =  " & cod_evento & " 
                           AND ind_tipo = 'P') - (SELECT  CAST(SUM(A.val_total_custo_item) AS NUMERIC(15,2))
                                                                         FROM  TAB_VENDA A 
                                                                         INNER JOIN TAB_ITEM B ON (A.COD_ITEM = B.COD_ITEM)
                                                                         WHERE A.cod_evento =  " & cod_evento & "
                                                                           AND ind_tipo = 'P') AS LUCRO_TOTAL
                FROM  TAB_VENDA A 
                INNER JOIN TAB_ITEM B ON (A.COD_ITEM = B.COD_ITEM)
                WHERE A.cod_evento =  " & cod_evento & "
                AND a.ind_tipo = 'P'
               GROUP BY B.COD_ITEM, B.DES_ITEM"
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
