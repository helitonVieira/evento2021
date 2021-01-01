Public Class ClAnimal
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private cod_animal_ As Integer
    Public Property cod_animal() As Integer
        Get
            Return cod_animal_
        End Get
        Set(ByVal value As Integer)
            cod_animal_ = value
        End Set
    End Property

    Private nom_animal_ As String
    Public Property nom_animal() As String
        Get
            Return nom_animal_
        End Get
        Set(ByVal value As String)
            nom_animal_ = value
        End Set
    End Property

    Private cod_pessoa_proprietario_ As Integer
    Public Property cod_pessoa_proprietario() As Integer
        Get
            Return cod_pessoa_proprietario_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_proprietario_ = value
        End Set
    End Property

    Private ind_sexo_ As String
    Public Property ind_sexo() As String
        Get
            Return ind_sexo_
        End Get
        Set(ByVal value As String)
            ind_sexo_ = value
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

    Private cod_especie_ As Integer
    Public Property cod_especie() As Integer
        Get
            Return cod_especie_
        End Get
        Set(ByVal value As Integer)
            cod_especie_ = value
        End Set
    End Property

    Private cod_raca_ As Integer
    Public Property cod_raca() As Integer
        Get
            Return cod_raca_
        End Get
        Set(ByVal value As Integer)
            cod_raca_ = value
        End Set
    End Property

    Private cod_pelagem_ As Integer
    Public Property cod_pelagem() As Integer
        Get
            Return cod_pelagem_
        End Get
        Set(ByVal value As Integer)
            cod_pelagem_ = value
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

    Public Sub Cadastrar()
        sql = "Insert Into tab_animal( cod_animal ,
                                       nom_animal,
                                       cod_pessoa_proprietario,
                                       ind_sexo,dta_nascimento,
                                       cod_especie,
                                       cod_raca, 
                                       cod_pelagem,
                                       des_observacao)
                               Values (" & cod_animal & ",
                                        '" & nom_animal & "',
                                         " & cod_pessoa_proprietario & ",
                                        '" & ind_sexo & "',
                                        '" & dta_nascimento & "',
                                         " & cod_especie & ",
                                         " & cod_raca & ",
                                         " & cod_pelagem & ",
                                        '" & des_observacao & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_animal Set nom_animal = '" & nom_animal & "' , 
                                cod_pessoa_proprietario = " & cod_pessoa_proprietario & ",
                                ind_sexo = '" & ind_sexo & "',
                                dta_nascimento = '" & dta_nascimento & "',
                                cod_especie = " & cod_especie & ",
                                cod_raca = " & cod_raca & ",
                                cod_pelagem = " & cod_pelagem & ",
                                des_observacao = '" & des_observacao & "' 
                               Where cod_animal = " & cod_animal & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_animal Where cod_animal =" & cod_animal & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod_animal_old As Integer, nom_animal_old As String, cod_pessoa_old As Integer, ind_sexo_old As String,
                               dta_nascimento_old As String, cod_especie_old As Integer, cod_raca_old As Integer,
                              cod_pelagem_old As Integer, des_observacao_old As String)
        sql = "Select a.cod_animal ,
                   a.nom_animal,
                   a.cod_pessoa_proprietario,
            	   b.nom_pessoa,
                   a.ind_sexo,
            	   a.dta_nascimento,
                   a.cod_especie,
            	   c.des_especie ,
                   a.cod_raca, 
            	   d.des_raca ,
                   a.cod_pelagem,
            	   e.des_pelagem ,
                   a.des_observacao
            From tab_animal a
            join tab_pessoa b on (a.cod_pessoa_proprietario = b.cod_pessoa)
            join tab_especie c on (c.cod_especie = a.cod_animal )
            join tab_raca d on (d.cod_raca = a.cod_raca )
            join tab_pelagem e on (e.cod_pelagem = a.cod_pelagem )
               where ((a.nom_animal like ('%" & nom_animal_old & "%') )or ('' = '" & nom_animal_old & "' ))  
                 and ((a.cod_animal = " & cod_animal_old & " )or (0 = " & cod_animal_old & "))
                 and ((b.cod_pessoa = " & cod_pessoa_old & " )or (0 = " & cod_pessoa_old & "))
                 and ind_sexo = '" & ind_sexo_old & "'
                 and ((a.dta_nascimento = '" & dta_nascimento_old & "' )or ( '' = '" & dta_nascimento_old & "'))
                 and ((a.cod_especie = " & cod_especie_old & " )or (0 = " & cod_especie_old & "))
                 and ((a.cod_raca = " & cod_raca_old & " )or (0 = " & cod_raca_old & "))
                 and ((a.cod_pelagem = " & cod_pelagem_old & " )or (0 = " & cod_pelagem_old & "))
                 and ((a.des_observacao like ('%" & des_observacao_old & "%') )or ('' = '" & des_observacao_old & "' ))  
              order by nom_animal"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_animal Where cod_animal =" & cod_animal & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_animal,
                      nom_animal 
              From tab_animal
              where nom_animal like ('%" & busca & "%')               
              order by nom_animal"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(cast( max(cod_animal) as varchar(5)),0)as ultimo From tab_animal"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
