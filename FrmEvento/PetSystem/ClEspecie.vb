Public Class ClEspecie
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private cod_especie_ As Integer
    Public Property cod_especie() As Integer
        Get
            Return cod_especie_
        End Get
        Set(ByVal value As Integer)
            cod_especie_ = value
        End Set
    End Property

    Private des_especie_ As String
    Public Property des_especie() As String
        Get
            Return des_especie_
        End Get
        Set(ByVal value As String)
            des_especie_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_especie( cod_especie ,des_especie) Values (" & cod_especie & ",'" & des_especie & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_especie Set des_especie = '" & des_especie & "'  Where cod_especie = " & cod_especie & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_especie Where cod_especie =" & cod_especie & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String)
        sql = "Select cod_especie,
                      des_especie
               From tab_especie
               where ((des_especie like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((cod_especie = " & cod & " )or (0 = " & cod & "))
              order by des_especie"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_especie Where cod_especie =" & cod_especie & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select * 
              From tab_especie
              where des_especie like ('%" & busca & "%')               
              order by des_especie"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(cast( max(cod_especie) as varchar(5)),0)as ultimo From tab_especie"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
