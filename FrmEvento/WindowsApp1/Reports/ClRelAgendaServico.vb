Public Class ClRelAgendaServico
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL

    Public Property seq_agenda As Integer
    Public Property cod_pessoa_cliente As Integer
    Public Property nom_pessoa_cliente As String
    Public Property cod_pessoa_funcionario As Integer
    Public Property nom_pessoa_funcionario As String
    Public Property dta_agenda As String
    Public Property hra_agenda As Integer
    Public Property min_agenda As Integer
    Public Property val_servico As Double
    Public Property des_observacao As String
    Public Property ind_executado As String
    Public Property val_comissao As Double
    Public Sub New()
    End Sub
    Public Sub New(ByVal seq_agenda As Integer, ByVal cod_pessoa_cliente As Integer, ByVal nom_pessoa_cliente As String,
                   ByVal cod_pessoa_funcionario As String, ByVal nom_pessoa_funcionario As String, ByVal dta_agenda As String,
                   ByVal hra_agenda As Integer, ByVal min_agenda As Integer, ByVal val_servico As Double,
                   ByVal des_observacao As String, ByVal ind_executado As String, ByVal val_comissao As Double)
        Me.seq_agenda = seq_agenda
        Me.cod_pessoa_cliente = cod_pessoa_cliente
        Me.nom_pessoa_cliente = nom_pessoa_cliente
        Me.cod_pessoa_funcionario = cod_pessoa_funcionario
        Me.nom_pessoa_funcionario = nom_pessoa_funcionario
        Me.dta_agenda = dta_agenda
        Me.hra_agenda = hra_agenda
        Me.min_agenda = min_agenda
        Me.val_servico = val_servico
        Me.des_observacao = des_observacao
        Me.ind_executado = ind_executado
        Me.val_comissao = val_comissao
    End Sub
    Public Function Consultar(dta_agenda As String)
        sql = "Select a.seq_agenda,
                  a.cod_pessoa_cliente,
                  c.nom_pessoa as nom_pessoa_cliente,
                  a.cod_pessoa_funcionario,
                  b.nom_pessoa as nom_pessoa_funcionario,
	        	  a.dta_agenda ,
                  a.hra_agenda ,
                  a.min_agenda ,
	        	  a.val_servico ,
	        	  a.des_observacao ,
	        	  a.ind_executado ,
                  (a.val_servico * 30 )/100 as val_comissao
	           From tab_agenda_servico a
               inner join tab_pessoa b on (a.cod_pessoa_funcionario = b.cod_pessoa)
               inner join tab_pessoa c on (a.cod_pessoa_cliente = c.cod_pessoa)
                 where  a.dta_agenda  >= '" & dta_agenda & "'
               order by dta_agenda,nom_pessoa_funcionario,hra_agenda"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarComissao(dtaInicio As String, dtaFinal As String, perComissao As Double, codFuncionario As Integer,
                                       codCliente As Integer)
        sql = "Select a.seq_agenda,
                  a.cod_pessoa_cliente,
                  c.nom_pessoa as nom_pessoa_cliente,
                  a.cod_pessoa_funcionario,
                  b.nom_pessoa as nom_pessoa_funcionario,
	        	  a.dta_agenda ,
                  a.hra_agenda ,
                  a.min_agenda ,
	        	  a.val_servico ,
	        	  a.des_observacao ,
	        	  a.ind_executado,
                  (a.val_servico * " & perComissao & " ) / 100 as val_comissao
	           From tab_agenda_servico a
               inner join tab_pessoa b on (a.cod_pessoa_funcionario = b.cod_pessoa)
               inner join tab_pessoa c on (a.cod_pessoa_cliente = c.cod_pessoa)
                 where  a.dta_agenda  between '" & dtaInicio & "'  and '" & dtaFinal & "'
                   and  ((b.cod_pessoa = " & codFuncionario & "  )or(0 = " & codFuncionario & "))
                   and  ((c.cod_pessoa = " & codCliente & "  )or(0 = " & codCliente & "))
               order by nom_pessoa_funcionario,
                        dta_agenda,
                        hra_agenda"
        ds = con.Listar(sql)
        Return ds
    End Function

End Class
