Public Class ClSecaoItem
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_secao_ As Integer
    Public Property cod_secao() As Integer
        Get
            Return cod_secao_
        End Get
        Set(ByVal value As Integer)
            cod_secao_ = value
        End Set
    End Property

    Private des_secao_ As String
    Public Property des_secao() As String
        Get
            Return des_secao_
        End Get
        Set(ByVal value As String)
            des_secao_ = value
        End Set
    End Property

    Private cod_almoxarifado_ As Integer
    Public Property cod_almoxarifado() As Integer
        Get
            Return cod_almoxarifado_
        End Get
        Set(ByVal value As Integer)
            cod_almoxarifado_ = value
        End Set
    End Property

    Public Sub Cadastrar()
        sql = "Insert Into tab_secao_item( cod_secao ,des_secao,cod_almoxarifado) 
                    Values (" & cod_secao & ",'" & des_secao & "'," & cod_almoxarifado & ")"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_secao_item Set des_secao = '" & des_secao & "' , 
                                  cod_almoxarifado = " & cod_almoxarifado & "
                                    Where cod_secao = " & cod_secao
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_secao_item Where cod_secao =" & cod_secao & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String, cod_almoxarifado As Integer)
        sql = "Select a.cod_secao,
                      a.des_secao,
                      a.cod_almoxarifado,
                      b.des_almoxarifado
               From tab_secao_item a
               Join tab_almoxarifado b on (a.cod_almoxarifado = b.cod_almoxarifado)
               where ((a.des_secao like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((a.cod_secao = " & cod & " )or (0 = " & cod & "))
                 and ((a.cod_almoxarifado = " & cod_almoxarifado & " )or (0 = " & cod_almoxarifado & "))
              order by a.des_secao"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_secao_item Where cod_secao =" & cod_secao & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_secao,
                      des_secao 
              From tab_secao_item
              where des_secao like ('%" & busca & "%')               
              order by des_secao"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(cod_secao),0)as ultimo From tab_secao_item"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
