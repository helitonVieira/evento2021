Public Class ClMarca
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_marca_ As Integer
    Public Property cod_marca() As Integer
        Get
            Return cod_marca_
        End Get
        Set(ByVal value As Integer)
            cod_marca_ = value
        End Set
    End Property

    Private des_marca_ As String
    Public Property des_marca() As String
        Get
            Return des_marca_
        End Get
        Set(ByVal value As String)
            des_marca_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_marca( cod_marca ,des_marca) Values (" & cod_marca & ",'" & des_marca & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_marca Set des_marca = '" & des_marca & "'  Where cod_marca = " & cod_marca & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_marca Where cod_marca =" & cod_marca & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String)
        sql = "Select cod_marca,
                      des_marca
               From tab_marca
               where ((des_marca like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((cod_marca = " & cod & " )or (0 = " & cod & "))
              order by des_marca"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_marca Where cod_marca =" & cod_marca & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select * 
              From tab_marca
              where des_marca like ('%" & busca & "%')               
              order by des_marca"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(cod_marca) ,0)as ultimo From tab_marca"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
