Public Class ClRelEntradaSaidaEstoque
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL
    Public Property cod_item() As Integer
    Public Property des_item() As String
    Public Property cod_subcategoria() As Integer
    Public Property des_subcategoria() As String
    Public Property cod_categoria() As Integer
    Public Property des_categoria() As String
    Public Property qtd_entrada() As Double
    Public Property qtd_vendida() As Double
    Public Property qtd_devolucao() As Double
    Public Property qtd_perda_roubo_consumo() As Double
    Public Property qtd_final() As Double
    Public Property val_entrada() As Double
    Public Property val_vendida() As Double
    Public Property val_devolucao() As Double
    Public Property val_perda_roubo_consumo() As Double
    Public Property val_final() As Double

    Public Sub New()
    End Sub
    Public Sub New(ByVal cod_item As Integer, ByVal des_item As String, ByVal cod_subcategoria As Integer, ByVal des_subcategoria As String,
                   ByVal cod_categoria As Integer, ByVal des_categoria As String,
                   ByVal qtd_entrada As Double, ByVal qtd_vendida As Double, ByVal qtd_devolucao As Double, ByVal qtd_perda_roubo_consumo As Double,
                   ByVal qtd_final As Double, ByVal val_entrada As Double, ByVal val_vendida As Double, ByVal val_devolucao As Double,
                   ByVal val_perda_roubo_consumo As Double, ByVal val_final As Double)
        Me.cod_item = cod_item
        Me.des_item = des_item
        Me.cod_subcategoria = cod_subcategoria
        Me.des_subcategoria = des_subcategoria
        Me.cod_categoria = cod_categoria
        Me.des_categoria = des_categoria
        Me.qtd_entrada = qtd_entrada
        Me.qtd_vendida = qtd_vendida
        Me.qtd_devolucao = qtd_devolucao
        Me.qtd_perda_roubo_consumo = qtd_perda_roubo_consumo
        Me.qtd_final = qtd_final
        Me.val_entrada = val_entrada
        Me.val_vendida = val_vendida
        Me.val_devolucao = val_devolucao
        Me.val_perda_roubo_consumo = val_perda_roubo_consumo
        Me.val_final = val_final

    End Sub
    Public Function ConsultarRel(dtaInicio As String, dtaFinal As String, codEmpresa As Integer, codItem As Integer, codSubcategoria As Integer, codCategoria As Integer)
        sql = " select b.cod_item,
       b.des_item,
       e.cod_subcategoria,
       e.des_subcategoria,
       f.cod_categoria,
       f.des_categoria,
coalesce((select sum(aa.qtd_item) from tab_inventario_rapido aa 		 
  join tab_tipo_movimento cc on (cc.cod_tipo_movimento = aa.cod_tipo_movimento)
  where aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'
    and cc.ind_entrada = 'E'
    and aa.cod_item = b.cod_item
    and ((aa.cod_empresa = " & codEmpresa & " )or(" & codEmpresa & " = 0))
    and aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'),0) as qtd_entrada,

coalesce((select sum(aa.qtd_item) from tab_venda aa 
  where aa.cod_item = b.cod_item
  and ((aa.cod_empresa = " & codEmpresa & " )or(" & codEmpresa & " = 0))
  and aa.dta_venda BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'),0) as qtd_vendida,

coalesce((select sum(aa.qtd_item) from tab_inventario_rapido aa 		 
  join tab_tipo_movimento cc on (cc.cod_tipo_movimento = aa.cod_tipo_movimento)
  where aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'
    and cc.ind_entrada = 'S'
    and aa.cod_item = b.cod_item
    and cc.cod_tipo_movimento = 5
    and ((aa.cod_empresa = " & codEmpresa & " )or(" & codEmpresa & " = 0))
    and aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'),0) as qtd_devolucao,

coalesce((select sum(aa.qtd_item) from tab_inventario_rapido aa 		 
  join tab_tipo_movimento cc on (cc.cod_tipo_movimento = aa.cod_tipo_movimento)
  where aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'
    and cc.ind_entrada = 'S'
    and aa.cod_item = b.cod_item
    and cc.cod_tipo_movimento in (3,4,6)
    and ((aa.cod_empresa = " & codEmpresa & " )or(" & codEmpresa & " = 0))
    and aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'),0) as qtd_perda_roubo_consumo, 

   -- qtd entrada menos saida do inventario menos as vendas caixa

coalesce((select sum(aa.qtd_item * (POSITION ('E' IN cc.ind_entrada)*2 -1))
         from tab_inventario_rapido aa
         inner join tab_tipo_movimento cc on (aa.cod_tipo_movimento = cc.cod_tipo_movimento)
         where  aa.cod_item = b.cod_item
         and ((aa.cod_empresa = " & codEmpresa & " )or(" & codEmpresa & " = 0))
         and aa.dta_inventario between '" & dtaInicio & "' and '" & dtaFinal & "'),0)-   
            coalesce((select sum(aa.qtd_item) from tab_venda aa 
  					where aa.cod_item = b.cod_item
                    and ((aa.cod_empresa = " & codEmpresa & " )or(" & codEmpresa & " = 0))
  					and aa.dta_venda BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'),0) as qtd_final,
                        
coalesce((select sum(aa.val_custo_total) from tab_inventario_rapido aa 		 
  join tab_tipo_movimento cc on (cc.cod_tipo_movimento = aa.cod_tipo_movimento)
  where aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'
    and cc.ind_entrada = 'E'
    and ((aa.cod_empresa = " & codEmpresa & " )or(" & codEmpresa & " = 0))
    and aa.cod_item = b.cod_item
    and aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'),0) as val_entrada,

coalesce((select sum(aa.val_total_item) from tab_venda aa 
  where aa.cod_item = b.cod_item
  and ((aa.cod_empresa = " & codEmpresa & " )or(" & codEmpresa & " = 0))
  and aa.dta_venda BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'),0) as val_vendida,

coalesce((select sum(aa.val_custo_total) from tab_inventario_rapido aa 		 
  join tab_tipo_movimento cc on (cc.cod_tipo_movimento = aa.cod_tipo_movimento)
  where aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'
    and cc.ind_entrada = 'S'
    and aa.cod_item = b.cod_item
    and cc.cod_tipo_movimento = 5
    and ((aa.cod_empresa = " & codEmpresa & " )or(" & codEmpresa & " = 0))
    and aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'),0) as val_devolucao,

coalesce((select sum(aa.val_custo_total) from tab_inventario_rapido aa 		 
  join tab_tipo_movimento cc on (cc.cod_tipo_movimento = aa.cod_tipo_movimento)
  where aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'
    and ((aa.cod_empresa = " & codEmpresa & " )or(" & codEmpresa & " = 0))
    and cc.ind_entrada = 'S'
    and aa.cod_item = b.cod_item
    and cc.cod_tipo_movimento in (3,4,6)
    and aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'),0) as val_perda_roubo_consumo, 

   -- qtd entrada menos saida do inventario menos as vendas caixa
   coalesce((select sum(aa.val_total_item) from tab_venda aa 
  					where aa.cod_item = b.cod_item
                    and ((aa.cod_empresa = " & codEmpresa & " )or(" & codEmpresa & " = 0))
  					and aa.dta_venda BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'),0) -

                    coalesce((select sum(aa.val_custo_total) from tab_inventario_rapido aa 		 
                   join tab_tipo_movimento cc on (cc.cod_tipo_movimento = aa.cod_tipo_movimento)
                   where aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'
                     and ((aa.cod_empresa = " & codEmpresa & " )or(" & codEmpresa & " = 0))
                     and cc.ind_entrada = 'S'
                     and aa.cod_item = b.cod_item
                     and cc.cod_tipo_movimento in (3,4,6)
                     and aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'),0) +
   
          coalesce((select sum(aa.val_custo_total) from tab_inventario_rapido aa 		 
                  join tab_tipo_movimento cc on (cc.cod_tipo_movimento = aa.cod_tipo_movimento)
                  where aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'
                    and cc.ind_entrada = 'S'
                    and aa.cod_item = b.cod_item
                    and cc.cod_tipo_movimento = 5
                    and ((aa.cod_empresa = " & codEmpresa & " )or(" & codEmpresa & " = 0))
                    and aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'),0) - 
                    
        coalesce((select sum(aa.val_custo_total) from tab_inventario_rapido aa 		 
          join tab_tipo_movimento cc on (cc.cod_tipo_movimento = aa.cod_tipo_movimento)
          where aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'
            and cc.ind_entrada = 'E'
            and ((aa.cod_empresa = " & codEmpresa & " )or(" & codEmpresa & " = 0))
            and aa.cod_item = b.cod_item
            and aa.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'),0)as val_final  
                    
from tab_item b 
join tab_subcategoria_item e on (e.cod_subcategoria = b.cod_subcategoria)
join tab_categoria_item f on (e.cod_categoria = f.cod_categoria)
where ((b.cod_item = " & codItem & " )or(" & codItem & " = 0)) 
  and  ((e.cod_subcategoria = " & codSubcategoria & " )or(" & codSubcategoria & " = 0))
  and  ((f.cod_categoria = " & codCategoria & " )or(" & codCategoria & " = 0))
  and (exists (select 1 from tab_inventario_rapido a 
               where b.cod_item = a.cod_item 
                 and a.dta_inventario between '" & dtaInicio & "' and '" & dtaFinal & "' ) OR
              (exists (select 1 from tab_venda c 
                         where c.cod_item = b.cod_item
                         and c.dta_venda between '" & dtaInicio & "' and '" & dtaFinal & "')))   

group by b.cod_item,
       b.des_item,
       e.cod_subcategoria,
       e.des_subcategoria,
       f.cod_categoria,
       f.des_categoria
       
order by 6,4,2"
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
