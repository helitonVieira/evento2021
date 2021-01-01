Public Class ClPelagem
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New Controles.ConexaoSQL
    Dim ultimo As Integer

    Private cod_pelagem_ As Integer
    Public Property cod_pelagem() As Integer
        Get
            Return cod_pelagem_
        End Get
        Set(ByVal value As Integer)
            cod_pelagem_ = value
        End Set
    End Property

    Private des_pelagem_ As String
    Public Property des_pelagem() As String
        Get
            Return des_pelagem_
        End Get
        Set(ByVal value As String)
            des_pelagem_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_pelagem( cod_pelagem ,des_pelagem) Values (" & cod_pelagem & ",'" & des_pelagem & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_pelagem Set des_pelagem = '" & des_pelagem & "'  Where cod_pelagem = " & cod_pelagem & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_pelagem Where cod_pelagem =" & cod_pelagem & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String)
        sql = "Select cod_pelagem,
                      des_pelagem
               From tab_pelagem
               where ((des_pelagem like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((cod_pelagem = " & cod & " )or (0 = " & cod & "))
              order by des_pelagem"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_pelagem Where cod_pelagem =" & cod_pelagem & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select * 
              From tab_pelagem
              where des_pelagem like ('%" & busca & "%')               
              order by des_pelagem"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(cast( max(cod_pelagem) as varchar(5)),0)as ultimo From tab_pelagem"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
