Public Class ClRelSubCategoria
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL

    Public Property cod_subcategoria() As Integer
    Public Property des_subcategoria() As String
    Public Property cod_categoria() As Integer
    Public Property des_categoria() As String
    Public Property cod_item() As Integer
    Public Property des_item() As String
    Public Property val_unitario() As Double
    Public Property qtd_venda() As Double
    Public Property val_venda() As Double
    Public Property val_acrescimo() As Double
    Public Property val_desconto() As Double
    Public Property val_total() As Double
    Public Sub New()
    End Sub
    Public Sub New(ByVal cod_subcategoria As Integer, ByVal des_subcategoria As String, ByVal cod_categoria As Integer, ByVal des_categoria As String,
                    ByVal cod_item As Integer, ByVal des_item As String, ByVal val_unitario As Double, ByVal qtd_venda As Double,
                   ByVal val_venda As Double, ByVal val_acrescimo As Double, ByVal val_desconto As Double, ByVal val_total As Double)
        Me.cod_subcategoria = cod_subcategoria
        Me.des_subcategoria = des_subcategoria
        Me.cod_categoria = cod_categoria
        Me.des_categoria = des_categoria
        Me.cod_item = cod_item
        Me.des_item = des_item
        Me.val_unitario = val_unitario
        Me.qtd_venda = qtd_venda
        Me.val_venda = val_venda
        Me.val_acrescimo = val_acrescimo
        Me.val_desconto = val_desconto
        Me.val_total = val_total
    End Sub
    Public Function ConsultarRel(ByVal codEmpresa As Integer,
                                 ByVal codSubcategoria As Integer,
                                 ByVal codCategoria As Integer,
                                 ByVal codItem As Integer,
                                 ByVal dtaInicio As String,
                                 ByVal dtaFinal As String)
        sql = "Select a.cod_subcategoria,
        a.des_subcategoria,
        a.cod_categoria,
        b.des_categoria,
        c.cod_item,
        c.des_item , 
        sum(v.val_total_item / case when coalesce( v.qtd_item,0) = 0 then 1 else v.qtd_item end)as val_unitario,
        COALESCE(sum(v.qtd_item),0)  as qtd_venda,
        COALESCE(sum(v.val_total_item ),0)   as val_venda ,
        0 as val_acrescimo,
        0 as val_desconto ,
        COALESCE(sum(v.val_total_item ),0)   as val_total      
From tab_venda v
join tab_item c on (  v.cod_item = c.cod_item)  
join tab_subcategoria_item a on (c.cod_subcategoria = a.cod_subcategoria)  
join tab_categoria_item b on (a.cod_categoria = b.cod_categoria)
 
where ((v.cod_empresa =" & codEmpresa & ")OR(" & codEmpresa & " = 0))
  and ((a.cod_categoria =" & codCategoria & ")or(" & codEmpresa & " = 0))
  and ((a.cod_subcategoria =" & codSubcategoria & ")or(" & codSubcategoria & " = 0))
  and ((c.cod_item =" & codItem & ")or(" & codItem & " = 0))  
  and v.dta_venda between '" & dtaInicio & "' and '" & dtaFinal & "'
group by a.cod_subcategoria,
         a.des_subcategoria,
         a.cod_categoria,
         b.des_categoria,
         c.cod_item,
         c.des_item 
union all

 Select a.cod_subcategoria,
        a.des_subcategoria,
        a.cod_categoria,
        b.des_categoria,
        c.cod_item,
        c.des_item , 
        v.val_unitario,
        COALESCE(sum(v.qtd_item_convertido),0) as qtd_venda,
        COALESCE(sum(v.val_bruto_item),0) as val_venda, 
        COALESCE(sum(v.val_acrescimo),0) as val_acrescimo,
        COALESCE(sum(v.val_desconto),0) as val_desconto,
        COALESCE(sum(v.val_bruto_item),0)+ COALESCE(sum(v.val_acrescimo),0)- COALESCE(sum(v.val_desconto),0)  as val_total        
From tab_nota_fiscal_saida i
join tab_item_nfs v on (v.seq_nota = i.seq_nota)
join tab_item c on (v.cod_item = c.cod_item)  
join tab_subcategoria_item a on (c.cod_subcategoria = a.cod_subcategoria)  
join tab_categoria_item b on (a.cod_categoria = b.cod_categoria)
 
where ((i.cod_empresa =" & codEmpresa & ")OR(" & codEmpresa & " = 0))
  and ((a.cod_categoria =" & codCategoria & ")or(" & codEmpresa & " = 0))
  and ((a.cod_subcategoria =" & codSubcategoria & ")or(" & codSubcategoria & " = 0))
  and ((c.cod_item =" & codItem & ")or(" & codItem & " = 0))  
  and i.dta_emissao between '" & dtaInicio & "' and '" & dtaFinal & "'
group by a.cod_subcategoria,
         a.des_subcategoria,
         a.cod_categoria,
         b.des_categoria,
         c.cod_item,
         c.des_item ,
         v.val_unitario                        
Order by 4,2,6"
        ds = con.Listar(sql)
        Return ds
    End Function


End Class
