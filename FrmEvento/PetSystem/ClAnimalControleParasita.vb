Public Class ClAnimalControleParasita
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private seq_controle_ As Integer
    Public Property seq_controle() As Integer
        Get
            Return seq_controle_
        End Get
        Set(ByVal value As Integer)
            seq_controle_ = value
        End Set
    End Property

    Private cod_controle_parasita_ As Integer
    Public Property cod_controle_parasita() As Integer
        Get
            Return cod_controle_parasita_
        End Get
        Set(ByVal value As Integer)
            cod_controle_parasita_ = value
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

    Private dta_controle_ As String
    Public Property dta_controle() As String
        Get
            Return dta_controle_
        End Get
        Set(ByVal value As String)
            dta_controle_ = value
        End Set
    End Property

    Private qtd_peso_ As String
    Public Property qtd_peso() As String
        Get
            Return qtd_peso_
        End Get
        Set(ByVal value As String)
            qtd_peso_ = value
        End Set
    End Property

    Private des_dose_ As String
    Public Property des_dose() As String
        Get
            Return des_dose_
        End Get
        Set(ByVal value As String)
            des_dose_ = value
        End Set
    End Property

    Private dta_proxima_ As String
    Public Property dta_proxima() As String
        Get
            Return dta_proxima_
        End Get
        Set(ByVal value As String)
            dta_proxima_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_animal_controle_parasita( seq_controle,
                                              cod_controle_parasita,
                                              cod_animal,
                                              dta_controle,
                                              qtd_peso,
                                              des_dose,
                                              dta_proxima)
                                     Values (" & seq_controle & ",
                                             " & cod_controle_parasita & ",
                                             " & cod_animal & ",
                                            '" & dta_controle & "',
                                            '" & Replace(qtd_peso, ",", ".") & "',
                                            '" & des_dose & "',
                                            '" & dta_proxima & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_animal_controle_parasita Set cod_controle_parasita = " & cod_controle_parasita & ",
                                            dta_controle = '" & dta_controle & "',
                                            qtd_peso = '" & qtd_peso & "',
                                            dta_proxima = '" & des_dose & "',
                                            dta_proxima = '" & dta_proxima & "'
                                      Where seq_controle = " & seq_controle & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_animal_controle_parasita Where seq_controle =" & seq_controle & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer)
        sql = "Select a.seq_controle,
                      a.cod_controle_parasita,
                      b.nom_controle_parasita,
                      a.dta_controle,
                      a.qtd_peso,
                      a.des_dose,
                      a.dta_proxima
               From tab_animal_controle_parasita a 
               join tab_controle_parasita b on (a.cod_controle_parasita = b.cod_controle_parasita)     
               where cod_animal = " & cod & " 
              order by a.dta_controle desc"
        ds = con.Listar(sql)

        Return ds
    End Function

    Public Function UltimoCadastrado()
        sql = "Select coalesce(cast( max(seq_controle) as varchar(5)),0)as ultimo From tab_animal_controle_parasita"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
