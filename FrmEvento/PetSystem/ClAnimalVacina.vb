Public Class ClAnimalVacina
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private seq_vacina_ As Integer
    Public Property seq_vacina() As Integer
        Get
            Return seq_vacina_
        End Get
        Set(ByVal value As Integer)
            seq_vacina_ = value
        End Set
    End Property

    Private cod_vacina_ As Integer
    Public Property cod_vacina() As Integer
        Get
            Return cod_vacina_
        End Get
        Set(ByVal value As Integer)
            cod_vacina_ = value
        End Set
    End Property

    Private cod_animal_ As Integer
    Public Property cod_animal() As Integer
        Get
            Return cod_animal_
        End Get
        Set(ByVal value As Integer)
            cod_animal_ = value
        End Set
    End Property

    Private dta_vacina_ As String
    Public Property dta_vacina() As String
        Get
            Return dta_vacina_
        End Get
        Set(ByVal value As String)
            dta_vacina_ = value
        End Set
    End Property

    Private ind_vacinado_ As String
    Public Property ind_vacinado() As String
        Get
            Return ind_vacinado_
        End Get
        Set(ByVal value As String)
            ind_vacinado_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_animal_vacina( seq_vacina,
                                              cod_vacina,
                                              cod_animal,
                                              dta_vacina,
                                              ind_vacinado)
                                     Values (" & seq_vacina & ",
                                             " & cod_vacina & ",
                                             " & cod_animal & ",
                                            '" & dta_vacina & "',
                                            '" & ind_vacinado & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_animal_vacina Set cod_vacina = " & cod_vacina & ",
                                            dta_vacina = '" & dta_vacina & "',
                                            ind_vacinado = '" & ind_vacinado & "'
                                      Where seq_vacina = " & seq_vacina & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_animal_vacina Where seq_vacina =" & seq_vacina & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer)
        sql = "Select a.seq_vacina,
                      a.cod_vacina,
                      b.nom_vacina,
                      a.dta_vacina,
                      a.ind_vacinado
               From tab_animal_vacina a 
               join tab_vacina b on (a.cod_vacina = b.cod_vacina)     
               where cod_animal = " & cod & " 
              order by a.dta_vacina desc"
        ds = con.Listar(sql)

        Return ds
    End Function

    Public Function UltimoCadastrado()
        sql = "Select coalesce(cast( max(seq_vacina) as varchar(5)),0)as ultimo From tab_animal_vacina"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
