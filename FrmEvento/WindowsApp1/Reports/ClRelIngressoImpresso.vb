Public Class ClRelIngressoImpresso
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL

    Public Property cod_evento() As Integer
    Public Property nom_evento() As String
    Public Property dta_evento() As String
    Public Property ind_aberto() As String
    Public Property des_ingresso() As String
    Public Property des_lote() As String
    Public Property val_entrada() As Double
    Public Property val_total_impresso() As Double
    Public Property qtd_impressa() As Double
    Public Property cod_pessoa() As Integer
    Public Property nom_pessoa() As String
    Public Property qtd_entregue() As Double
    Public Property qtd_devolvida() As Double
    Public Property qtd_total_pessoa() As Double
    Public Property val_total_pessoa() As Double
    Public Property des_observacao() As String
    Public Property dta_entrega() As String
    Public Sub New()
    End Sub
    Public Sub New(ByVal cod_evento As Integer, ByVal nom_evento As String, ByVal dta_evento As String, ByVal ind_aberto As String,
ByVal des_ingresso As String, ByVal des_lote As String, ByVal val_entrada As Double, ByVal val_total_impresso As Double,
ByVal qtd_impressa As Double, ByVal cod_pessoa As Integer, ByVal nom_pessoa As String, ByVal qtd_entregue As Double,
ByVal qtd_devolvida As Double, ByVal qtd_total_pessoa As Double, ByVal val_total_pessoa As Double, ByVal des_observacao As String, ByVal dta_entrega As String)
        Me.cod_evento = cod_evento
        Me.nom_evento = nom_evento
        Me.dta_evento = dta_evento
        Me.ind_aberto = ind_aberto
        Me.des_ingresso = des_ingresso
        Me.des_lote = des_lote
        Me.val_entrada = val_entrada
        Me.val_total_impresso = val_total_impresso
        Me.qtd_impressa = qtd_impressa
        Me.cod_pessoa = cod_pessoa
        Me.nom_pessoa = nom_pessoa
        Me.qtd_entregue = qtd_entregue
        Me.qtd_devolvida = qtd_devolvida
        Me.qtd_total_pessoa = qtd_total_pessoa
        Me.val_total_pessoa = val_total_pessoa
        Me.des_observacao = des_observacao
        Me.dta_entrega = dta_entrega
    End Sub
    Public Function ConsultarRel(codEvento As Integer)
        sql = " select a.cod_evento,
       a.nom_evento,
       a.dta_evento,
       a.ind_aberto,
       b.des_ingresso||' - '|| b.des_ingresso1 as des_ingresso,         
       b.des_lote,
       b.val_entrada, 
       c.val_total_impresso,
       c.qtd_impressa,
       d.cod_pessoa,
       e.nom_pessoa,
       d.qtd_entregue,
       d.qtd_devolvida,
       d.qtd_entregue - d.qtd_devolvida as qtd_total_pessoa,
       ( d.qtd_entregue - d.qtd_devolvida) * b.val_entrada as val_total_pessoa,
       d.des_observacao,
       d.dta_entrega    
       
from tab_evento a 
left join tab_ingresso b on (a.cod_evento = b.cod_evento)
left join tab_ingresso_impresso c on (c.seq_ingresso = b.seq_ingresso)
left join tab_ingresso_pessoa d on (d.seq_impressao = c.seq_impressao)
left join tab_pessoa e on (e.cod_pessoa = d.cod_pessoa)
where a.cod_evento = " & codEvento & "
order by d.cod_pessoa,b.des_lote"
        ds = con.Listar(sql)
        Return ds
    End Function


End Class
