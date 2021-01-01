Public Class ClRaca
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private cod_raca_ As Integer
    Public Property cod_raca() As Integer
        Get
            Return cod_raca_
        End Get
        Set(ByVal value As Integer)
            cod_raca_ = value
        End Set
    End Property

    Private des_raca_ As String
    Public Property des_raca() As String
        Get
            Return des_raca_
        End Get
        Set(ByVal value As String)
            des_raca_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_raca( cod_raca ,des_raca) Values (" & cod_raca & ",'" & des_raca & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_raca Set des_raca = '" & des_raca & "'  Where cod_raca = " & cod_raca & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_raca Where cod_raca =" & cod_raca & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String)
        sql = "Select cod_raca,
                      des_raca
               From tab_raca
               where ((des_raca like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((cod_raca = " & cod & " )or (0 = " & cod & "))
              order by des_raca"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_raca Where cod_raca =" & cod_raca & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select * 
              From tab_raca
              where des_raca like ('%" & busca & "%')               
              order by des_raca"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(cast( max(cod_raca) as varchar(5)),0)as ultimo From tab_raca"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
