Public Class ClTipoMovimento
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL

    Private cod_tipo_movimento_ As Integer
    Public Property cod_tipo_movimento() As Integer
        Get
            Return cod_tipo_movimento_
        End Get
        Set(ByVal value As Integer)
            cod_tipo_movimento_ = value
        End Set
    End Property
    Private des_tipo_movimento_ As String
    Public Property des_tipo_movimento() As String
        Get
            Return des_tipo_movimento_
        End Get
        Set(ByVal value As String)
            des_tipo_movimento_ = value
        End Set
    End Property
    Private ind_entrada_ As String
    Public Property ind_entrada() As String
        Get
            Return ind_entrada_
        End Get
        Set(ByVal value As String)
            ind_entrada_ = value
        End Set
    End Property
    Public Sub CadastrarTipoMovimento()
        sql = "Insert Into tab_tipo_movimento(cod_tipo_movimento,	des_tipo_movimento,	ind_entrada) Values ('" & cod_tipo_movimento & "' , '" & des_tipo_movimento & "','" & ind_entrada & "')"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarTipoMovimento()
        sql = "Update tab_tipo_movimento Set des_tipo_movimento = '" & des_tipo_movimento & "',ind_entrada ='" & ind_entrada & "'  Where cod_tipo_movimento = " & cod_tipo_movimento & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirTipoMovimento()
        sql = " Delete from tab_tipo_movimento Where cod_tipo_movimento =" & cod_tipo_movimento & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarTipoMovimento()
        sql = "Select * From tab_tipo_movimento 
               order by des_tipo_movimento"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarTipoMovimentoCodigo()
        sql = "Select * From tab_tipo_movimento
               Where cod_tipo_movimento =" & cod_tipo_movimento & ""
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarTipoMovtoPesquisa(busca As String)
        sql = "Select cod_tipo_movimento, 
                      des_tipo_movimento  
               From tab_tipo_movimento
               where des_tipo_movimento like ('%" & busca & "%')
               order by des_tipo_movimento"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(cod_tipo_movimento),0)as ultimo From tab_tipo_movimento"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
