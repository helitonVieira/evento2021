Public Class ClRelVendaPorCliente
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL

    Public Property cod_pessoa() As Integer
    Public Property nom_pessoa() As String
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
    Public Property dta_emissao() As Date
    Public Sub New()
    End Sub
    Public Sub New(ByVal cod_pessoa As Integer, ByVal nom_pessoa As String, ByVal cod_subcategoria As Integer, ByVal des_subcategoria As String, ByVal cod_categoria As Integer, ByVal des_categoria As String,
                    ByVal cod_item As Integer, ByVal des_item As String, ByVal val_unitario As Double, ByVal qtd_venda As Double,
                   ByVal val_venda As Double, ByVal val_acrescimo As Double, ByVal val_desconto As Double, ByVal val_total As Double,
                   ByVal dta_emissao As Date)
        Me.cod_pessoa = cod_pessoa
        Me.nom_pessoa = nom_pessoa
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
        Me.dta_emissao = dta_emissao
    End Sub
    Public Function ConsultarRel(ByVal codPessoa As Integer,
                                 ByVal codEmpresa As Integer,
                                 ByVal codSubcategoria As Integer,
                                 ByVal codCategoria As Integer,
                                 ByVal codItem As Integer,
                                 ByVal dtaInicio As String,
                                 ByVal dtaFinal As String)
        sql = " Select a.cod_subcategoria,
        a.des_subcategoria,
        a.cod_categoria,
        b.des_categoria,
        c.cod_item,
        c.des_item , 
        p.cod_pessoa,
        p.nom_pessoa,
        v.val_unitario,
        i.dta_emissao,
        COALESCE(sum(v.qtd_item_convertido),0) as qtd_venda,
        COALESCE(sum(v.val_bruto_item),0) as val_venda, 
        COALESCE(sum(v.val_acrescimo),0) as val_acrescimo,
        COALESCE(sum(v.val_desconto),0) as val_desconto,
        COALESCE(sum(v.val_bruto_item),0)+ COALESCE(sum(v.val_acrescimo),0)- COALESCE(sum(v.val_desconto),0)  as val_total        
From tab_nota_fiscal_saida i
join tab_pessoa p on (p.cod_pessoa = i.cod_pessoa_cliente)
join tab_item_nfs v on (v.seq_nota = i.seq_nota)
join tab_item c on (v.cod_item = c.cod_item)  
join tab_subcategoria_item a on (c.cod_subcategoria = a.cod_subcategoria)  
join tab_categoria_item b on (a.cod_categoria = b.cod_categoria)
 
where ((i.cod_empresa =" & codEmpresa & ")OR(" & codEmpresa & " = 0))
  and ((p.cod_pessoa =" & codPessoa & ")or(" & codPessoa & " = 0))
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
         v.val_unitario ,
         p.cod_pessoa,
         i.dta_emissao,
         p.nom_pessoa
Order by 8,10,6"
        ds = con.Listar(sql)
        Return ds
    End Function


End Class
