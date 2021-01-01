Public Class ClPessoa
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New Controles.ConexaoSQL
    Dim ultimoItem As Integer

    Private cod_pessoa_ As Integer
    Public Property cod_pessoa() As Integer
        Get
            Return cod_pessoa_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_ = value
        End Set
    End Property

    Private nom_pessoa_ As String
    Public Property nom_pessoa() As String
        Get
            Return nom_pessoa_
        End Get
        Set(ByVal value As String)
            nom_pessoa_ = value
        End Set
    End Property

    Private nom_fantasia_ As String
    Public Property nom_fantasia() As String

        Get
            Return nom_fantasia_
        End Get
        Set(ByVal value As String)
            nom_fantasia_ = value
        End Set
    End Property

    Private num_cnpj_cpf_ As String
    Public Property num_cnpj_cpf() As String
        Get
            Return num_cnpj_cpf_
        End Get
        Set(ByVal value As String)
            num_cnpj_cpf_ = value
        End Set
    End Property

    Private num_ie_rg_ As String
    Public Property num_ie_rg() As String
        Get
            Return num_ie_rg_
        End Get
        Set(ByVal value As String)
            num_ie_rg_ = value
        End Set
    End Property

    Private dta_nascimento_ As Date
    Public Property dta_nascimento() As Date
        Get
            Return dta_nascimento_
        End Get
        Set(ByVal value As Date)
            dta_nascimento_ = value
        End Set
    End Property

    Private des_logradouro_ As String
    Public Property des_logradouro() As String
        Get
            Return des_logradouro_
        End Get
        Set(ByVal value As String)
            des_logradouro_ = value
        End Set
    End Property

    Private des_complemento_ As String
    Public Property des_complemento() As String

        Get
            Return des_complemento_
        End Get
        Set(ByVal value As String)
            des_complemento_ = value
        End Set
    End Property

    Private cod_cidade_ As Integer
    Public Property cod_cidade() As Integer
        Get
            Return cod_cidade_
        End Get
        Set(ByVal value As Integer)
            cod_cidade_ = value
        End Set
    End Property

    Private nom_bairro_ As String
    Public Property nom_bairro() As String
        Get
            Return nom_bairro_
        End Get
        Set(ByVal value As String)
            nom_bairro_ = value
        End Set
    End Property

    Private num_cep_ As String
    Public Property num_cep() As String
        Get
            Return num_cep_
        End Get
        Set(ByVal value As String)
            num_cep_ = value
        End Set
    End Property
    Private num_fone_1_ As String
    Public Property num_fone_1() As String
        Get
            Return num_fone_1_
        End Get
        Set(ByVal value As String)
            num_fone_1_ = value
        End Set
    End Property

    Private num_fone_2_ As String
    Public Property num_fone_2() As String
        Get
            Return num_fone_2_
        End Get
        Set(ByVal value As String)
            num_fone_2_ = value
        End Set
    End Property

    Private num_fone_3_ As String
    Public Property num_fone_3() As String
        Get
            Return num_fone_3_
        End Get
        Set(ByVal value As String)
            num_fone_3_ = value
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

    Private dta_cadastro_ As Date
    Public Property dta_cadastro() As Date
        Get
            Return dta_cadastro_
        End Get
        Set(ByVal value As Date)
            dta_cadastro_ = value
        End Set
    End Property

    Private ind_cliente_ As String
    Public Property ind_cliente() As String
        Get
            Return ind_cliente_
        End Get
        Set(ByVal value As String)
            ind_cliente_ = value
        End Set
    End Property

    Private ind_fornecedor_ As String
    Public Property ind_fornecedor() As String
        Get
            Return ind_fornecedor_
        End Get
        Set(ByVal value As String)
            ind_fornecedor_ = value
        End Set
    End Property

    Private ind_funcionario_ As String
    Public Property ind_funcionario() As String
        Get
            Return ind_funcionario_
        End Get
        Set(ByVal value As String)
            ind_funcionario_ = value
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

    Private des_email_ As String
    Public Property des_email() As String
        Get
            Return des_email_
        End Get
        Set(ByVal value As String)
            des_email_ = value
        End Set
    End Property


    Public Sub CadastrarPessoa()
        sql = "Insert Into tab_pessoa(
                               COD_PESSOA        ,   
                               NOM_PESSOA        ,    
                               NOM_FANTASIA      ,    
                               NUM_CNPJ_CPF      ,    
                               NUM_IE_RG         ,    
                               DTA_NASCIMENTO    ,    
                               DES_LOGRADOURO    ,    
                               DES_COMPLEMENTO   ,    
                               COD_CIDADE        ,    
                               NOM_BAIRRO        ,    
                               NUM_CEP           ,    
                               NUM_TELEFONE_1    ,    
                               NUM_TELEFONE_2    ,    
                               NUM_TELEFONE_3    ,    
                               DES_OBSERVACAO    ,    
                               DTA_CADASTRO      ,    
                               IND_CLIENTE       ,    
                               IND_FORNECEDOR    ,    
                               IND_FUNCIONARIO   ,    
                               IND_ATIVO         ,
                               DES_EMAIL )
                 Values (" & cod_pessoa & ",'" & nom_pessoa & "' , '" & nom_fantasia & "','" & num_cnpj_cpf & "','" & num_ie_rg & "','" & dta_nascimento & "'
                         , '" & des_logradouro & "','" & des_complemento & "','" & cod_cidade & "','" & nom_bairro & "'
                         , '" & num_cep & "','" & num_fone_1 & "','" & num_fone_2 & "','" & num_fone_3 & "' 
                         , '" & des_observacao & "','" & dta_cadastro & "','" & ind_cliente & "','" & ind_fornecedor & "'
                         , '" & ind_funcionario & "','" & ind_ativo & "','" & des_email & "')"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarPessoa()
        sql = "Update tab_pessoa Set  NOM_PESSOA    ='" & nom_pessoa & "' ,
                                    NOM_FANTASIA    ='" & nom_fantasia & "',
                                    NUM_CNPJ_CPF    ='" & num_cnpj_cpf & "',
                                    NUM_IE_RG       ='" & num_ie_rg & "',
                                    DTA_NASCIMENTO  ='" & dta_nascimento & "' ,
                                    DES_LOGRADOURO  ='" & des_logradouro & "',
                                    DES_COMPLEMENTO ='" & des_complemento & "',                                   
                                    NOM_BAIRRO      ='" & nom_bairro & "' ,
                                    NUM_CEP         ='" & num_cep & "',
                                    NUM_TELEFONE_1  ='" & num_fone_1 & "',
                                    NUM_TELEFONE_2  ='" & num_fone_2 & "',
                                    NUM_TELEFONE_3  ='" & num_fone_3 & "' ,
                                    DES_OBSERVACAO  ='" & des_observacao & "',
                                    IND_CLIENTE     ='" & ind_cliente & "',
                                    IND_FORNECEDOR  ='" & ind_fornecedor & "' ,
                                    IND_FUNCIONARIO ='" & ind_funcionario & "',
                                    IND_ATIVO       ='" & ind_ativo & "',
                                    DES_EMAIL      ='" & des_email & "'
                                  
                                   Where cod_pessoa   =" & cod_pessoa & ""
        con.Operar(sql)
    End Sub

    Public Sub ExcluirPessoa()
        sql = " Delete from tab_pessoa Where cod_pessoa =" & cod_pessoa & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarPessoa(busca As String)
        sql = "Select * From tab_pessoa 
               where nom_pessoa like ('%" & busca & "%')
                 and ind_ativo = 'S'
               order by nom_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarPessoaBusca(COD_PESSOA_OLD As Integer, NOM_PESSOA_OLD As String, NOM_FANTASIA_OLD As String,
                                         NUM_CNPJ_CPF_OLD As String, NUM_IE_RG_OLD As String, DES_LOGRADOURO_OLD As String,
                                         COD_CIDADE_OLD As String, NOM_BAIRRO_OLD As String, NUM_CEP_OLD As String,
                                         NUM_TELEFONE_1_OLD As String, NUM_TELEFONE_2_OLD As String, NUM_TELEFONE_3_OLD As String,
                                         DES_OBSERVACAO_OLD As String, IND_CLIENTE_OLD As String,
                                         IND_FORNECEDOR_OLD As String, IND_FUNCIONARIO_OLD As String, IND_ATIVO_OLD As String,
                                         DES_EMAIL_OLD As String, IND_PE As String, COD_FUNCAO_FUNCIONARIO_OLD As String)

        Dim indCliente, indFornecedor, indFuncionario, indAtivo As String
        indCliente = ""
        indFornecedor = ""
        indFuncionario = ""
        indAtivo = ""
        If IND_PE = "S" Then
            If IND_CLIENTE_OLD = "S" Then
                indCliente = " and a.ind_cliente = 'S' "
            End If
            If IND_FORNECEDOR_OLD = "S" Then
                indFornecedor = " and a.ind_fornecedor = 'S' "
            End If
            If IND_FUNCIONARIO_OLD = "S" Then
                indFuncionario = " and a.ind_funcionario = 'S' "
            End If
            If IND_ATIVO_OLD = "S" Then
                indAtivo = " and a.ind_ativo = 'S' "
            End If
        End If

        If COD_CIDADE_OLD = "" Then
            COD_CIDADE_OLD = Convert.ToInt16("0")
        Else
            COD_CIDADE_OLD = Convert.ToInt16(COD_CIDADE_OLD)
        End If
        If COD_FUNCAO_FUNCIONARIO_OLD = "" Then
            COD_FUNCAO_FUNCIONARIO_OLD = Convert.ToInt16("0")
        Else
            COD_FUNCAO_FUNCIONARIO_OLD = Convert.ToInt16(COD_FUNCAO_FUNCIONARIO_OLD)
        End If

        sql = "select   a.*,
                        b.cod_funcao_funcionario, 
                        c.des_funcao_funcionario,
                        b.val_salario,
                        b.val_custo_hora,
                        b.ind_tipo_salario,
                        b.dta_admissao,
                        b.dta_demissao,
                        b.dta_ultimo_reajuste,
                        b.des_observacao as des_observacao_func
               from tab_pessoa a
               left  Join tab_pessoa_funcionario b on (a.cod_pessoa = b.cod_pessoa)
               left join tab_funcao_funcionario c on (c.cod_funcao_funcionario = b.cod_funcao_funcionario)

               where a.nom_pessoa like ('%" & NOM_PESSOA_OLD & "%') 
                 and ((a.cod_pessoa = " & COD_PESSOA_OLD & " )or (0 = " & COD_PESSOA_OLD & "))
                 and a.nom_fantasia like ('%" & NOM_FANTASIA_OLD & "%') 
                 and ((a.num_cnpj_cpf = '" & NUM_CNPJ_CPF_OLD & "') or ('' = '" & NUM_CNPJ_CPF_OLD & "' ))
                 and ((a.num_ie_rg = '" & NUM_IE_RG_OLD & "') or ('' = '" & NUM_IE_RG_OLD & "' ))
                 and a.des_logradouro like ('%" & DES_LOGRADOURO_OLD & "%')
                 and ((a.cod_cidade = " & COD_CIDADE_OLD & " )or (0 = " & COD_CIDADE_OLD & "))
                 and a.nom_bairro like ('%" & NOM_BAIRRO_OLD & "%')
                 and ((a.num_cep = '" & NUM_CEP_OLD & "') or ('' = '" & NUM_CEP_OLD & "' ))
                 and ((a.num_telefone_1 = '" & NUM_TELEFONE_1_OLD & "') or ('' = '" & NUM_TELEFONE_1_OLD & "' ))
                 and ((a.num_telefone_2 = '" & NUM_TELEFONE_2_OLD & "') or ('' = '" & NUM_TELEFONE_2_OLD & "' ))
                 and ((a.num_telefone_3 = '" & NUM_TELEFONE_3_OLD & "') or ('' = '" & NUM_TELEFONE_3_OLD & "' ))
                 and a.des_observacao like ('%" & DES_OBSERVACAO_OLD & "%') 
                 and a.des_email like ('%" & DES_EMAIL_OLD & "%') 
                 and ((c.cod_funcao_funcionario = " & COD_FUNCAO_FUNCIONARIO_OLD & " )or (0 = " & COD_FUNCAO_FUNCIONARIO_OLD & "))
                
                 " & indCliente & indFornecedor & indFuncionario & indAtivo & "
                                                                         
               order by nom_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarPessoa()
        sql = "Select * From tab_pessoa
               order by nom_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPessoaFuncionario(busca As String)
        sql = "Select * From tab_pessoa
                where ind_funcionario = 'S' 
                  and ind_ativo = 'S'
                  and nom_pessoa like ('%" & busca & "%')
               order by nom_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPessoaCliente(busca As String)
        sql = "Select cod_pessoa,nom_pessoa From tab_pessoa
                where ind_cliente = 'S' 
                   and ind_ativo = 'S'
                  and nom_pessoa like ('%" & busca & "%')
               order by nom_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPessoaCodigo()
        sql = "Select * From tab_pessoa Where cod_cod_pessoa =" & cod_pessoa & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPessoaVenda()
        sql = "Select cod_pessoa, nom_pessoa From tab_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function UltimaPessoaCadastrado()
        sql = "Select coalesce(cast( max(cod_pessoa) as varchar(5)),0)as ultimo From tab_pessoa"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function

End Class
