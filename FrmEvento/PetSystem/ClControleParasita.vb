Public Class ClControleParasita
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private cod_controle_parasita_ As Integer
    Public Property cod_controle_parasita() As Integer
        Get
            Return cod_controle_parasita_
        End Get
        Set(ByVal value As Integer)
            cod_controle_parasita_ = value
        End Set
    End Property

    Private nom_controle_parasita_ As String
    Public Property nom_controle_parasita() As String
        Get
            Return nom_controle_parasita_
        End Get
        Set(ByVal value As String)
            nom_controle_parasita_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_controle_parasita( cod_controle_parasita ,nom_controle_parasita) Values (" & cod_controle_parasita & ",'" & nom_controle_parasita & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_controle_parasita Set nom_controle_parasita = '" & nom_controle_parasita & "'  Where cod_controle_parasita = " & cod_controle_parasita & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_controle_parasita Where cod_controle_parasita =" & cod_controle_parasita & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String)
        sql = "Select cod_controle_parasita,
                      nom_controle_parasita
               From tab_controle_parasita
               where ((nom_controle_parasita like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((cod_controle_parasita = " & cod & " )or (0 = " & cod & "))
              order by nom_controle_parasita"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_controle_parasita Where cod_controle_parasita =" & cod_controle_parasita & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select * 
              From tab_controle_parasita
              where nom_controle_parasita like ('%" & busca & "%')               
              order by nom_controle_parasita"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(cast( max(cod_controle_parasita) as varchar(5)),0)as ultimo From tab_controle_parasita"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
