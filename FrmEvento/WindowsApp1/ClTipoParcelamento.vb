Public Class ClTipoParcelamento
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_tipo_parcela_ As Integer
    Public Property cod_tipo_parcela() As Integer
        Get
            Return cod_tipo_parcela_
        End Get
        Set(ByVal value As Integer)
            cod_tipo_parcela_ = value
        End Set
    End Property

    Private des_tipo_parcela_ As String
    Public Property des_tipo_parcela() As String
        Get
            Return des_tipo_parcela_
        End Get
        Set(ByVal value As String)
            des_tipo_parcela_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_tipo_parcela( cod_tipo_parcela ,des_tipo_parcela) Values (" & cod_tipo_parcela & ",'" & des_tipo_parcela & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_tipo_parcela Set des_tipo_parcela = '" & des_tipo_parcela & "'  Where cod_tipo_parcela = " & cod_tipo_parcela & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_tipo_parcela Where cod_tipo_parcela =" & cod_tipo_parcela & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String)
        sql = "Select cod_tipo_parcela,
                      des_tipo_parcela
               From tab_tipo_parcela
               where ((des_tipo_parcela like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((cod_tipo_parcela = " & cod & " )or (0 = " & cod & "))
              order by des_tipo_parcela"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_tipo_parcela Where cod_tipo_parcela =" & cod_tipo_parcela & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_tipo_parcela,
                      des_tipo_parcela
              From tab_tipo_parcela
              where des_tipo_parcela like ('%" & busca & "%')               
              order by des_tipo_parcela"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(cod_tipo_parcela),0)as ultimo From tab_tipo_parcela"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
