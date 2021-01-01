Public Class ClPessoaDependente
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimoDependente As Integer

    Private cod_dependente_ As Integer
    Public Property cod_dependente() As Integer
        Get
            Return cod_dependente_
        End Get
        Set(ByVal value As Integer)
            cod_dependente_ = value
        End Set
    End Property

    Private nom_dependente_ As String
    Public Property nom_dependente() As String
        Get
            Return nom_dependente_
        End Get
        Set(ByVal value As String)
            nom_dependente_ = value
        End Set
    End Property

    Private cod_pessoa_ As Integer
    Public Property cod_pessoa() As Integer
        Get
            Return cod_pessoa_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_ = value
        End Set
    End Property

    Private num_telefone_ As String
    Public Property num_telefone() As String
        Get
            Return num_telefone_
        End Get
        Set(ByVal value As String)
            num_telefone_ = value
        End Set
    End Property

    Private nom_apelido_ As String
    Public Property nom_apelido() As String
        Get
            Return nom_apelido_
        End Get
        Set(ByVal value As String)
            nom_apelido_ = value
        End Set
    End Property

    Private dta_nascimento_ As String
    Public Property dta_nascimento() As String
        Get
            Return dta_nascimento_
        End Get
        Set(ByVal value As String)
            dta_nascimento_ = value
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

    Public Sub CadastrarDependente()
        sql = "Insert Into tab_pessoa_dependente( cod_dependente ,nom_dependente,cod_pessoa,nom_apelido,
                                                  num_telefone,dta_nascimento,des_observacao) 
               Values (" & cod_dependente & ",'" & nom_dependente & "'," & cod_pessoa & ",
                      '" & nom_apelido & "', '" & num_telefone & "','" & dta_nascimento & "','" & des_observacao & "')"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarDependente()
        sql = "Update tab_pessoa_dependente Set  nom_dependente ='" & nom_dependente & "' ,
                                      cod_pessoa ='" & cod_pessoa & "',
                                      num_telefone ='" & num_telefone & "',
                                      des_observacao ='" & des_observacao & "',
                                      dta_nascimento ='" & dta_nascimento & "' ,
                                      nom_apelido ='" & nom_apelido & "'                                  
                                   Where cod_dependente =" & cod_dependente & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirDependente()
        sql = " Delete from tab_pessoa_dependente Where cod_dependente =" & cod_dependente & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarDependente(cod As Integer)
        sql = "SELECT *
               FROM tab_pessoa_dependente 
               WHERE cod_pessoa = " & cod &
               "ORDER BY nom_dependente"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoDependenteCadastrado()
        sql = "Select coalesce( max(cod_dependente) ,0)as ultimo From tab_pessoa_dependente"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
