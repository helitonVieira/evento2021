Public Class ClAlmoxarifado
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_almoxarifado_ As Integer
    Public Property cod_almoxarifado() As Integer
        Get
            Return cod_almoxarifado_
        End Get
        Set(ByVal value As Integer)
            cod_almoxarifado_ = value
        End Set
    End Property

    Private des_almoxarifado_ As String
    Public Property des_almoxarifado() As String
        Get
            Return des_almoxarifado_
        End Get
        Set(ByVal value As String)
            des_almoxarifado_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_almoxarifado( cod_almoxarifado ,des_almoxarifado) Values (" & cod_almoxarifado & ",'" & des_almoxarifado & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_almoxarifado Set des_almoxarifado = '" & des_almoxarifado & "'  Where cod_almoxarifado = " & cod_almoxarifado & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_almoxarifado Where cod_almoxarifado =" & cod_almoxarifado & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String)
        sql = "Select cod_almoxarifado,
                      des_almoxarifado
               From tab_almoxarifado
               where ((des_almoxarifado like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((cod_almoxarifado = " & cod & " )or (0 = " & cod & "))
              order by des_almoxarifado"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_almoxarifado Where cod_almoxarifado =" & cod_almoxarifado & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select * 
              From tab_almoxarifado
              where des_almoxarifado like ('%" & busca & "%')               
              order by des_almoxarifado"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(cod_almoxarifado) ,0)as ultimo From tab_almoxarifado"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
