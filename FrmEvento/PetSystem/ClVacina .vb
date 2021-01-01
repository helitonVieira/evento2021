Public Class ClVacina
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private cod_vacina_ As Integer
    Public Property cod_vacina() As Integer
        Get
            Return cod_vacina_
        End Get
        Set(ByVal value As Integer)
            cod_vacina_ = value
        End Set
    End Property

    Private nom_vacina_ As String
    Public Property nom_vacina() As String
        Get
            Return nom_vacina_
        End Get
        Set(ByVal value As String)
            nom_vacina_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_vacina( cod_vacina ,nom_vacina) Values (" & cod_vacina & ",'" & nom_vacina & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_vacina Set nom_vacina = '" & nom_vacina & "'  Where cod_vacina = " & cod_vacina & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_vacina Where cod_vacina =" & cod_vacina & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String)
        sql = "Select cod_vacina,
                      nom_vacina
               From tab_vacina
               where ((nom_vacina like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((cod_vacina = " & cod & " )or (0 = " & cod & "))
              order by nom_vacina"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_vacina Where cod_vacina =" & cod_vacina & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select * 
              From tab_vacina
              where nom_vacina like ('%" & busca & "%')               
              order by nom_vacina"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(cast( max(cod_vacina) as varchar(5)),0)as ultimo From tab_vacina"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
