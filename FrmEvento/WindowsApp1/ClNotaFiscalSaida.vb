Public Class ClNotaFiscalSaida
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL
    Dim ultimoItem As Integer

    Private seq_nota_ As Integer
    Public Property seq_nota() As Integer
        Get
            Return seq_nota_
        End Get
        Set(ByVal value As Integer)
            seq_nota_ = value
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

    Private num_nota_ As String
    Public Property num_nota() As String

        Get
            Return num_nota_
        End Get
        Set(ByVal value As String)
            num_nota_ = value
        End Set
    End Property

    Private dta_emissao_ As String
    Public Property dta_emissao() As String
        Get
            Return dta_emissao_
        End Get
        Set(ByVal value As String)
            dta_emissao_ = value
        End Set
    End Property

    Private dta_saida_ As String
    Public Property dta_saida() As String
        Get
            Return dta_saida_
        End Get
        Set(ByVal value As String)
            dta_saida_ = value
        End Set
    End Property

    Private hra_emissao_ As String
    Public Property hra_emissao() As String
        Get
            Return hra_emissao_
        End Get
        Set(ByVal value As String)
            hra_emissao_ = value
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

    Private cod_pessoa_representante_ As Integer
    Public Property cod_pessoa_representante() As Integer

        Get
            Return cod_pessoa_representante_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_representante_ = value
        End Set
    End Property

    Private cod_usuario_ As Integer
    Public Property cod_usuario() As Integer
        Get
            Return cod_usuario_
        End Get
        Set(ByVal value As Integer)
            cod_usuario_ = value
        End Set
    End Property

    Private val_desconto_produto_ As String
    Public Property val_desconto_produto() As String
        Get
            Return val_desconto_produto_
        End Get
        Set(ByVal value As String)
            val_desconto_produto_ = value
        End Set
    End Property

    Private val_acrescimo_produto_ As String
    Public Property val_acrescimo_produto() As String
        Get
            Return val_acrescimo_produto_
        End Get
        Set(ByVal value As String)
            val_acrescimo_produto_ = value
        End Set
    End Property
    Private val_total_produto_ As String
    Public Property val_total_produto() As String
        Get
            Return val_total_produto_
        End Get
        Set(ByVal value As String)
            val_total_produto_ = value
        End Set
    End Property
    Private val_total_servico_ As String
    Public Property val_total_servico() As String
        Get
            Return val_total_servico_
        End Get
        Set(ByVal value As String)
            val_total_servico_ = value
        End Set
    End Property

    Private val_total_nota_ As String
    Public Property val_total_nota() As String
        Get
            Return val_total_nota_
        End Get
        Set(ByVal value As String)
            val_total_nota_ = value
        End Set
    End Property

    Private val_troco_ As String
    Public Property val_troco() As String
        Get
            Return val_troco_
        End Get
        Set(ByVal value As String)
            val_troco_ = value
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

    Private ind_status_ As String
    Public Property ind_status() As String
        Get
            Return ind_status_
        End Get
        Set(ByVal value As String)
            ind_status_ = value
        End Set
    End Property

    Private cod_usuario_cancelamento_ As Integer
    Public Property cod_usuario_cancelamento() As Integer
        Get
            Return cod_usuario_cancelamento_
        End Get
        Set(ByVal value As Integer)
            cod_usuario_cancelamento_ = value
        End Set
    End Property

    Private dta_cancelamento_ As String
    Public Property dta_cancelamento() As String
        Get
            Return dta_cancelamento_
        End Get
        Set(ByVal value As String)
            dta_cancelamento_ = value
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

    Private cod_pdv_ As Integer
    Public Property cod_pdv() As Integer
        Get
            Return cod_pdv_
        End Get
        Set(ByVal value As Integer)
            cod_pdv_ = value
        End Set
    End Property

    Private seq_turno_ As Integer
    Public Property seq_turno() As Integer
        Get
            Return seq_turno_
        End Get
        Set(ByVal value As Integer)
            seq_turno_ = value
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


    Public Sub Cadastrar()

        sql = "Insert Into tab_nota_fiscal_saida(
                               seq_nota        ,   
                               cod_empresa        ,    
                               num_nota      ,    
                               dta_emissao      ,    
                               dta_saida         ,    
                               hra_emissao    ,    
                               cod_pessoa_cliente    ,    
                               cod_pessoa_representante   ,    
                               cod_usuario        ,    
                               val_desconto_produto        , 
                               val_acrescimo_produto       ,   
                               val_total_produto           ,    
                               val_total_servico    ,    
                               val_total_nota    ,    
                               val_troco    ,    
                               des_observacao    ,    
                               ind_status      ,    
                               cod_usuario_cancelamento       ,    
                               dta_cancelamento    ,    
                               seq_fechamento   ,    
                               cod_pdv         ,
                               seq_turno ,
                               val_desconto,
                               val_acrescimo)
               Values (" & seq_nota & ",
                       " & cod_empresa & " , 
                      '" & num_nota & "',
                      '" & CDate(dta_emissao).ToShortDateString.ToString & "',
                      '" & dta_saida & "',
                      '" & hra_emissao & "',
                       " & cod_pessoa_cliente & ",
                       " & cod_pessoa_representante & ",
                       " & cod_usuario & ",
                      '" & Replace(Replace(val_desconto_produto, ".", ""), ",", ".") & "', 
                      '" & Replace(Replace(val_acrescimo_produto, ".", ""), ",", ".") & "', 
                      '" & Replace(Replace(val_total_produto, ".", ""), ",", ".") & "',
                      '" & Replace(Replace(val_total_servico, ".", ""), ",", ".") & "',
                      '" & Replace(Replace(val_total_nota, ".", ""), ",", ".") & "',
                      '" & Replace(Replace(val_troco, ".", ""), ",", ".") & "', 
                      '" & des_observacao & "',
                      '" & ind_status & "',
                      '" & cod_usuario_cancelamento & "'," & vbCrLf
        If dta_cancelamento = "" Then
            sql = sql & "Null ,"
        Else
            sql = sql & " '" & dta_cancelamento & "'," & vbCrLf
        End If
        sql = sql & "'" & seq_fechamento & "',
                      " & cod_pdv & ",
                      " & seq_turno & ",
                      " & Replace(Replace(val_desconto, ".", ""), ",", ".") & ",
                      " & Replace(Replace(val_acrescimo, ".", ""), ",", ".") & ")"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_nota_fiscal_saida Set  cod_empresa    =" & cod_empresa & " ,
                                    num_nota    ='" & num_nota & "',
                                    dta_emissao    ='" & dta_emissao & "',
                                    dta_saida       ='" & dta_saida & "',"
        If hra_emissao = "" Then
            sql = sql & "hra_emissao  = null,"
        Else
            sql = sql & "hra_emissao  ='" & hra_emissao & "' ,"
        End If

        sql = sql & "  cod_pessoa_cliente  =" & cod_pessoa_cliente & ",
                                    cod_cod_pessoa_representante =" & cod_pessoa_representante & ",                                   
                                    val_desconto_produto      ='" & val_desconto_produto & "' ,
                                     val_acrescimo_produto      ='" & val_acrescimo_produto & "' ,
                                    val_total_produto         ='" & val_total_produto & "',
                                    val_total_servico  ='" & val_total_servico & "',
                                    val_total_nota  ='" & val_total_nota & "',
                                    val_troco  ='" & val_troco & "' ,
                                    des_observacao  ='" & des_observacao & "',
                                    cod_usuario_cancelamento     ='" & cod_usuario_cancelamento & "',
                                    dta_cancelamento  ='" & dta_cancelamento & "' ,
                                    seq_fechamento ='" & seq_fechamento & "',
                                    cod_pdv       =" & cod_pdv & ",
                                    seq_turno      =" & seq_turno & ",
                                    val_desconto = " & val_desconto & ",
                                    val_acrescimo= " & val_acrescimo & "
                                  
                                   Where seq_nota   =" & seq_nota & ""
        con.Operar(sql)
    End Sub

    Public Sub Excluir()
        sql = " Delete from tab_nota_fiscal_saida Where seq_nota =" & seq_nota & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(busca As String)
        sql = "Select * From tab_nota_fiscal_saida 
               where cod_empresa like ('%" & busca & "%')
                 and cod_pdv = 'S'
               order by cod_empresa"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarBusca(seq_nota_OLD As Integer, cod_empresa_OLD As String, num_nota_OLD As String, hra_emissao_OLD As String,
                                         dta_emissao_OLD As String, dta_saida_OLD As String, cod_pessoa_cliente_OLD As String,
                                         cod_usuario_OLD As String, val_desconto_produto_OLD As String, val_total_produto_OLD As String,
                                         val_total_servico_OLD As String, val_total_nota_OLD As String, val_troco_OLD As String,
                                         des_observacao_OLD As String, cod_usuario_cancelamento_OLD As String,
                                         dta_cancelamento_OLD As String, seq_fechamento_OLD As String, cod_pdv_OLD As String,
                                         seq_turno_OLD As String, IND_PE As String, COD_FUNCAO_FUNCIONARIO_OLD As String)

        Dim indCliente, indFornecedor, indFuncionario, indAtivo As String
        indCliente = ""
        indFornecedor = ""
        indFuncionario = ""
        indAtivo = ""
        If IND_PE = "S" Then
            If cod_usuario_cancelamento_OLD = "S" Then
                indCliente = " and a.cod_usuario_cancelamento = 'S' "
            End If
            If dta_cancelamento_OLD = "S" Then
                indFornecedor = " and a.dta_cancelamento = 'S' "
            End If
            If seq_fechamento_OLD = "S" Then
                indFuncionario = " and a.seq_fechamento = 'S' "
            End If
            If cod_pdv_OLD = "S" Then
                indAtivo = " and a.cod_pdv = 'S' "
            End If
        End If

        If cod_usuario_OLD = "" Then
            cod_usuario_OLD = Convert.ToInt16("0")
        Else
            cod_usuario_OLD = Convert.ToInt16(cod_usuario_OLD)
        End If
        If COD_FUNCAO_FUNCIONARIO_OLD = "" Then
            COD_FUNCAO_FUNCIONARIO_OLD = Convert.ToInt16("0")
        Else
            COD_FUNCAO_FUNCIONARIO_OLD = Convert.ToInt16(COD_FUNCAO_FUNCIONARIO_OLD)
        End If
        If IsDate(hra_emissao_OLD) = False Then
            hra_emissao_OLD = ""
        End If

        sql = "select  a.seq_nota   ,
                        a.cod_empresa     ,
                        a.num_nota   ,
                        a.dta_emissao   ,
                        a.dta_saida      ,
                        a.hra_emissao ,
                        a.cod_pessoa_cliente ,
                        a.cod_cod_pessoa_representante,
                        a.cod_usuario     ,
                        d.nom_cidade,
                        a.val_desconto_produto     ,
                        a.val_acrescimo_produto     ,
                        a.val_total_produto        ,
                        a.val_total_servico ,
                        a.val_total_nota ,
                        a.val_troco ,
                        a.NOM_CONTATO    ,
                        a.des_observacao ,
                        a.ind_status   ,
                        a.cod_usuario_cancelamento    ,
                        a.dta_cancelamento ,
                        a.seq_fechamento,
                        a.cod_pdv      ,
                        a.seq_turno ,
                        b.cod_funcao_funcionario, 
                        c.des_funcao_funcionario,
                        b.val_salario,
                        b.val_custo_hora,
                        b.ind_tipo_salario,
                        b.dta_admissao,
                        b.dta_demissao,
                        b.dta_ultimo_reajuste,
                        b.des_observacao as des_observacao_func,
                        b.ind_agenda_servico,
                        a.val_acrescimo,
                        a.val_desconto 
               from tab_nota_fiscal_saida a
              join tab_cidade d on (a.cod_usuario = d.cod_usuario)
               left  Join tab_nota_fiscal_saida_funcionario b on (a.seq_nota = b.seq_nota)
               left join tab_funcao_funcionario c on (c.cod_funcao_funcionario = b.cod_funcao_funcionario)


               where a.cod_empresa like ('%" & cod_empresa_OLD & "%') 
                 and ((a.seq_nota = " & seq_nota_OLD & " )or (0 = " & seq_nota_OLD & "))
                 and a.num_nota like ('%" & num_nota_OLD & "%') " & vbCrLf
        If hra_emissao_OLD <> "" Then
            sql = sql & "  and a.hra_emissao = '" & CDate(hra_emissao_OLD).ToShortDateString & "'"
        End If
        sql = sql & " and ((a.dta_emissao = '" & dta_emissao_OLD & "') or ('' = '" & dta_emissao_OLD & "' ))
                 and ((a.dta_saida = '" & dta_saida_OLD & "') or ('' = '" & dta_saida_OLD & "' ))
                 and a.cod_pessoa_cliente like ('%" & cod_pessoa_cliente_OLD & "%')
                 and ((a.cod_usuario = " & cod_usuario_OLD & " )or (0 = " & cod_usuario_OLD & "))
                 and a.val_desconto_produto like ('%" & val_desconto_produto_OLD & "%')
                 and ((a.val_total_produto = '" & val_total_produto_OLD & "') or ('' = '" & val_total_produto_OLD & "' ))
                 and ((a.val_total_servico = '" & val_total_servico_OLD & "') or ('' = '" & val_total_servico_OLD & "' ))
                 and ((a.val_total_nota = '" & val_total_nota_OLD & "') or ('' = '" & val_total_nota_OLD & "' ))
                 and ((a.val_troco = '" & val_troco_OLD & "') or ('' = '" & val_troco_OLD & "' ))
                 and a.des_observacao like ('%" & des_observacao_OLD & "%') 
                 and a.seq_turno like ('%" & seq_turno_OLD & "%') 
                 and ((c.cod_funcao_funcionario = " & COD_FUNCAO_FUNCIONARIO_OLD & " )or (0 = " & COD_FUNCAO_FUNCIONARIO_OLD & "))
                
                 " & indCliente & indFornecedor & indFuncionario & indAtivo & "
                                                                         
               order by cod_empresa"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function Consultar()
        sql = "Select  c.nom_fantasia,
        c.num_cnpj,
        c.num_ie,
        c.des_logradouro,
        c.nom_bairro,
        cast('Documento nao fiscal' as varchar(200))as des_documento,
        d.cod_item,
        d.des_item,
        d.qtd_item ,
        (select sum(qtd_item)from tab_item_nfs g where g.seq_nota = a.seq_nota)as qtd_total,
        e.sgl_unidade,
        d.val_unitario,
        d.val_bruto_item,
        (select sum(val_bruto_item) from tab_item_nfs g where g.seq_nota = a.seq_nota)as val_total,
        (select sum(val_bruto_item) from tab_item_nfs g where g.seq_nota = a.seq_nota)-
           (a.val_desconto_produto + a.val_desconto)+ 
           (a.val_acrescimo_produto + a.val_acrescimo) as val_pagar,
        a.val_desconto_produto + a.val_desconto as val_desconto,
        a.val_acrescimo_produto + a.val_acrescimo as val_acrescimo,
        f.nom_usuario as nom_operador,
        b.cod_pessoa,
        b.nom_pessoa ,
        a.seq_nota,
        a.num_nota,
        a.dta_emissao,
        a.hra_emissao ,
        a.val_desconto,
        a.val_acrescimo,
        a.val_troco
        
From tab_nota_fiscal_saida a 
join tab_item_nfs d on (d.seq_nota = a.seq_nota)
join tab_empresa c on (c.cod_empresa = a.cod_empresa)
join tab_pessoa b on (a.cod_pessoa_cliente = b.cod_pessoa)
join tab_unidade e on (e.cod_unidade = d.cod_unidade)
join tab_usuario f on (f.cod_usuario = a.cod_usuario)
where a.seq_nota = " & seq_nota & ""

        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function Consultar1()
        sql = "Select * From tab_nota_fiscal_saida
               order by cod_empresa"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarFuncionario(busca As String)
        sql = "Select * From tab_nota_fiscal_saida
                where seq_fechamento = 'S' 
                  and cod_pdv = 'S'
                  and cod_empresa like ('%" & busca & "%')
               order by cod_empresa"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarFuncionarioAgenda(busca As String)
        sql = "Select a.seq_nota,
                      a.cod_empresa 
               From tab_nota_fiscal_saida a
               join tab_nota_fiscal_saida_funcionario b on (a.seq_nota = b.seq_nota)
                where a.seq_fechamento = 'S' 
                  and a.cod_pdv = 'S'
                  and b.ind_agenda_servico = 'S'
                  and a.cod_empresa like ('%" & busca & "%')
               order by a.cod_empresa"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarFornecedor(busca As String)
        sql = "Select * From tab_nota_fiscal_saida
                where dta_cancelamento = 'S' 
                  and cod_pdv = 'S'
                  and cod_empresa like ('%" & busca & "%')
               order by cod_empresa"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCliente(busca As String)
        sql = "Select seq_nota,cod_empresa From tab_nota_fiscal_saida
                where   cod_pdv = 'S'
                  and cod_empresa like ('%" & busca & "%')
               order by cod_empresa"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo(busca As String)
        sql = "Select seq_nota,cod_empresa From tab_nota_fiscal_saida
                where   cod_pdv = 'S'
                  and seq_nota = " & busca & "
               order by cod_empresa"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarCodigo()
        sql = "Select * From tab_nota_fiscal_saida Where cod_seq_nota =" & seq_nota & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarVenda()
        sql = "Select seq_nota, cod_empresa From tab_nota_fiscal_saida"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function UltimaCadastrado()
        sql = "Select coalesce( max(seq_nota),0)as ultimo From tab_nota_fiscal_saida"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function

End Class
