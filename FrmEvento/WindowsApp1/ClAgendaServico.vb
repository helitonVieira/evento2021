Public Class ClAgendaServico

    Dim sql As String
    Dim ds, dsUtimo As New DataSet
    Dim con As New ConexaoSQL
    Dim ultimoEvento As Integer

    Private seq_agenda_ As Integer
    Public Property seq_agenda() As Integer
        Get
            Return seq_agenda_
        End Get
        Set(ByVal value As Integer)
            seq_agenda_ = value
        End Set
    End Property

    Private cod_pessoa_cliente_ As Integer
    Public Property cod_pessoa_cliente() As Integer
        Get
            Return cod_pessoa_cliente_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_cliente_ = value
        End Set
    End Property

    Private cod_pessoa_funcionario_ As Integer
    Public Property cod_pessoa_funcionario() As Integer
        Get
            Return cod_pessoa_funcionario_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_funcionario_ = value
        End Set
    End Property

    Private dta_agenda_ As String
    Public Property dta_agenda() As String
        Get
            Return dta_agenda_
        End Get
        Set(ByVal value As String)
            dta_agenda_ = value
        End Set
    End Property

    Private hra_agenda_ As Integer
    Public Property hra_agenda() As Integer
        Get
            Return hra_agenda_
        End Get
        Set(ByVal value As Integer)
            hra_agenda_ = value
        End Set
    End Property

    Private min_agenda_ As Integer
    Public Property min_agenda() As Integer
        Get
            Return min_agenda_
        End Get
        Set(ByVal value As Integer)
            min_agenda_ = value
        End Set
    End Property

    Private val_servico_ As String
    Public Property val_servico() As String
        Get
            Return val_servico_
        End Get
        Set(ByVal value As String)
            val_servico_ = value
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

    Private ind_executado_ As String
    Public Property ind_executado() As String
        Get
            Return ind_executado_
        End Get
        Set(ByVal value As String)
            ind_executado_ = value
        End Set
    End Property

    Public Sub Cadastrar()
        sql = "Insert Into tab_agenda_servico(seq_agenda,
                                         cod_pessoa_cliente,
                                         cod_pessoa_funcionario   ,
                                         dta_agenda,
                                         hra_agenda,
                                         min_agenda,
                                         val_servico,
                                         des_observacao  ,
                                         ind_executado 
                                         ) Values (" & seq_agenda & ",
                                          '" & cod_pessoa_cliente & "' ,
                                          '" & cod_pessoa_funcionario & "' ,
                                          '" & dta_agenda & "' ,
                                          " & hra_agenda & " ,
                                          " & min_agenda & " ,
                                          '" & Replace(Replace(val_servico, ".", "",), ",", ".") & "' ,
                                          '" & des_observacao & "',
                                          '" & ind_executado & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_agenda_servico Set 
                                       cod_pessoa_cliente =   " & cod_pessoa_cliente & " , 
                                       cod_pessoa_funcionario =   " & cod_pessoa_funcionario & " ,
                                       dta_agenda =     '" & dta_agenda & "',
                                       hra_agenda =     " & hra_agenda & ",
                                       min_agenda =     " & min_agenda & ",
                                       val_servico =   '" & Replace(Replace(val_servico, ".", "",), ",", ".") & "',
                                       des_observacao =  '" & des_observacao & "',
                                       ind_executado = '" & ind_executado & "'
                                       Where seq_agenda = " & seq_agenda & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_agenda_servico Where seq_agenda =" & seq_agenda & ""
        con.Operar(sql)
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
	        	  a.ind_executado 	        	 		
	           From tab_agenda_servico a
               inner join tab_pessoa b on (a.cod_pessoa_funcionario = b.cod_pessoa)
               inner join tab_pessoa c on (a.cod_pessoa_cliente = c.cod_pessoa)
                 where  a.dta_agenda  = '" & dta_agenda & "'
               order by dta_agenda"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarHora(dta_agenda As String, hora As String, codFuncionario As Integer, minuto As String)
        Dim dsHora As New DataSet
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
	        	  a.ind_executado 	        	 		
	           From tab_agenda_servico a
               inner join tab_pessoa b on (a.cod_pessoa_funcionario = b.cod_pessoa)
               inner join tab_pessoa c on (a.cod_pessoa_cliente = c.cod_pessoa)
                 where  a.dta_agenda  = '" & dta_agenda & "'
                   and  a.hra_agenda = '" & hora & "'
                   and  a.min_agenda = '" & minuto & "'
                   and  a.cod_pessoa_funcionario = " & codFuncionario & " 
               order by dta_agenda"
        dsHora = con.Listar(sql)
        Return dsHora
    End Function
    Public Function ConsultarFuncionario()
        sql = "select b.cod_pessoa,
                      b.nom_pessoa
               from tab_pessoa_funcionario a 
               join tab_pessoa b on (a.cod_pessoa = b.cod_pessoa)
                order by b.nom_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarFuncionarioAgendaServico()
        sql = "select b.cod_pessoa,
                      b.nom_pessoa
               from tab_pessoa_funcionario a 
               join tab_pessoa b on (a.cod_pessoa = b.cod_pessoa)
               where a.ind_agenda_servico = 'S'  
               order by b.nom_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(seq_agenda),0) as ultimo From tab_agenda_servico"
        dsUtimo = con.Listar(sql)
        Return dsUtimo
    End Function
End Class
