Public Class ClPessoaFuncionario
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimoFuncionario As Integer

    Private cod_pessoa_ As Integer
    Public Property cod_pessoa() As Integer
        Get
            Return cod_pessoa_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_ = value
        End Set
    End Property

    Private cod_funcao_funcionario_ As Integer
    Public Property cod_funcao_funcionario() As Integer
        Get
            Return cod_funcao_funcionario_
        End Get
        Set(ByVal value As Integer)
            cod_funcao_funcionario_ = value
        End Set
    End Property


    Private val_salario_ As String
    Public Property val_salario() As String
        Get
            Return val_salario_
        End Get
        Set(ByVal value As String)
            val_salario_ = value
        End Set
    End Property

    Private Val_custo_hora_ As String
    Public Property Val_custo_hora() As String
        Get
            Return Val_custo_hora_
        End Get
        Set(ByVal value As String)
            Val_custo_hora_ = value
        End Set
    End Property

    Private ind_tipo_salario_ As String
    Public Property ind_tipo_salario() As String
        Get
            Return ind_tipo_salario_
        End Get
        Set(ByVal value As String)
            ind_tipo_salario_ = value
        End Set
    End Property

    Private dta_admissao_ As String
    Public Property dta_admissao() As String
        Get
            Return dta_admissao_
        End Get
        Set(ByVal value As String)
            dta_admissao_ = value
        End Set
    End Property

    Private dta_demissao_ As String
    Public Property dta_demissao() As String
        Get
            Return dta_demissao_
        End Get
        Set(ByVal value As String)
            dta_demissao_ = value
        End Set
    End Property

    Private dta_ultimo_reajuste_ As String
    Public Property dta_ultimo_reajuste() As String
        Get
            Return dta_ultimo_reajuste_
        End Get
        Set(ByVal value As String)
            dta_ultimo_reajuste_ = value
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

    Private ind_agenda_servico_ As String
    Public Property ind_agenda_servico() As String
        Get
            Return ind_agenda_servico_
        End Get
        Set(ByVal value As String)
            ind_agenda_servico_ = value
        End Set
    End Property

    Private ind_operador_caixa_ As String
    Public Property ind_operador_caixa() As String
        Get
            Return ind_operador_caixa_
        End Get
        Set(ByVal value As String)
            ind_operador_caixa_ = value
        End Set
    End Property
    Public Sub CadastrarFuncionario()
        If val_salario = "" Then
            val_salario = "0"
        End If
        If Val_custo_hora = "" Then
            Val_custo_hora = "0"
        End If

        sql = "Insert Into tab_pessoa_funcionario( cod_pessoa ,
                                                  cod_funcao_funcionario,
                                                  val_salario,
                                                  Val_custo_hora,
                                                  ind_tipo_salario,
                                                  dta_admissao,
                                                  dta_demissao,
                                                  dta_ultimo_reajuste,
                                                  des_observacao,
                                                  ind_agenda_servico,
                                                  ind_operador_caixa) 
                                        Values (" & cod_pessoa & "," & vbCrLf
        If cod_funcao_funcionario = 0 Then
            sql = sql & "1 ,"
        Else
            sql = sql & " " & cod_funcao_funcionario & "," & vbCrLf
        End If

        sql = sql & CDbl(val_salario) & ",
        " & CDbl(Val_custo_hora) & ", 
        '" & ind_tipo_salario & "', " & vbCrLf
        If dta_admissao = "" Then
            sql = sql & "Null ,"
        Else
            sql = sql & " '" & dta_admissao & ",'" & vbCrLf
        End If
        If dta_demissao = "" Then
            sql = sql & "Null ,"
        Else
            sql = sql & " '" & dta_demissao & ",'" & vbCrLf
        End If
        If dta_ultimo_reajuste = "" Then
            sql = sql & "Null ,"
        Else
            sql = sql & " '" & dta_ultimo_reajuste & ",'" & vbCrLf
        End If

        sql = sql & "'" & des_observacao & "',
                     '" & ind_agenda_servico & "',
                     '" & ind_operador_caixa & "')"
        con.Operar(sql)
    End Sub

    Private Function IsDBNull() As String
        Throw New NotImplementedException()
    End Function

    Public Sub AtualizarFuncionario()
        sql = "Update tab_pessoa_funcionario Set  
                                      cod_funcao_funcionario ='" & cod_funcao_funcionario & "',
                                      val_salario ='" & Replace(Replace(val_salario, ".", ""), ",", ".") & "' ,
                                      val_custo_hora ='" & Replace(Replace(Val_custo_hora, ".", ""), ",", ".") & "',
                                      ind_tipo_salario ='" & ind_tipo_salario & "', 
                                      dta_admissao =" & vbCrLf
        If dta_admissao = "" Then
            sql = sql & "Null ,"
        Else
            sql = sql & " '" & CDate(dta_admissao).ToShortDateString & "'," & vbCrLf
        End If
        sql = sql & "                 dta_demissao =" & vbCrLf
        If dta_demissao = "" Then
            sql = sql & "Null ,"
        Else
            sql = sql & " '" & CDate(dta_demissao).ToShortDateString & "'," & vbCrLf
        End If
        sql = sql & "                 dta_ultimo_reajuste =" & vbCrLf
        If dta_ultimo_reajuste = "" Then
            sql = sql & "Null ,"
        Else
            sql = sql & " '" & CDate(dta_ultimo_reajuste).ToShortDateString & "'," & vbCrLf
        End If
        sql = sql & "                des_observacao ='" & des_observacao & "',
                                      ind_agenda_servico = '" & ind_agenda_servico & "',
                                       ind_operador_caixa = '" & ind_operador_caixa & "'
                                Where cod_pessoa =" & cod_pessoa & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirFuncionario()
        sql = " Delete from tab_pessoa_funcionario Where cod_pessoa =" & cod_pessoa & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarFuncionario(cod As Integer)
        sql = "SELECT *
               FROM tab_pessoa_funcionario 
               WHERE cod_pessoa = " & cod
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarOperador(nome As String)
        sql = "select a.cod_pessoa,
                      a.nom_pessoa   
               from tab_pessoa a 
               join tab_pessoa_funcionario b on (a.cod_pessoa = b.cod_pessoa)
               where b.ind_operador_caixa = 'S'
               and a.ind_ativo = 'S' 
               and a.nom_pessoa like ('%" & nome & "%')"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoFuncionarioCadastrado()
        sql = "Select coalesce(max(cod_pessoa),0)as ultimo From tab_pessoa_funcionario"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
