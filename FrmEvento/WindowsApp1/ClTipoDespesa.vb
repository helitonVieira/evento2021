Public Class ClTipoDespesa
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL

    Private cod_tipo_despesa_ As Integer
    Public Property cod_tipo_despesa() As Integer
        Get
            Return cod_tipo_despesa_
        End Get
        Set(ByVal value As Integer)
            cod_tipo_despesa_ = value
        End Set
    End Property
    Private des_tipo_despesa_ As String
    Public Property des_tipo_despesa() As String
        Get
            Return des_tipo_despesa_
        End Get
        Set(ByVal value As String)
            des_tipo_despesa_ = value
        End Set
    End Property
    Private ind_tipo_ As String
    Public Property ind_tipo() As String
        Get
            Return ind_tipo_
        End Get
        Set(ByVal value As String)
            ind_tipo_ = value
        End Set
    End Property

    Private ind_ativo_ As String
    Public Property ind_ativo() As String
        Get
            Return ind_ativo_
        End Get
        Set(ByVal value As String)
            ind_ativo_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_tipo_despesa Values (" & cod_tipo_despesa & " , '" & des_tipo_despesa & "','" & ind_tipo & "' , '" & ind_ativo & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_tipo_despesa Set des_tipo_despesa = '" & des_tipo_despesa & "' ,
                                           ind_tipo = '" & ind_tipo & "',
                                           ind_ativo = '" & ind_ativo & "'  
                                     Where cod_tipo_despesa = " & cod_tipo_despesa & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_tipo_despesa Where cod_tipo_despesa =" & cod_tipo_despesa & ""
        con.Operar(sql)
    End Sub
    Public Function Consultar(cod As Integer, desc As String, ind_tipo As String, ind_ativo As String)

        sql = "Select a.cod_tipo_despesa,
                      a.des_tipo_despesa,
                      a.ind_tipo, 
                      a.ind_ativo
               From tab_tipo_despesa a
                where ((a.des_tipo_despesa like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((a.cod_tipo_despesa = " & cod & " )or (0 = " & cod & "))
                 and ((a.ind_tipo = '" & ind_tipo & "' )or ('' = '" & ind_tipo & "'))
                 and ((a.ind_ativo = '" & ind_ativo & "' )or ('' = '" & ind_ativo & "'))
              order by a.des_tipo_despesa"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select * From tab_tipo_despesa
                where des_tipo_despesa like ('%" & busca & "%')
                 order by des_tipo_despesa"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_tipo_despesa Where cod_tipo_despesa =" & cod_tipo_despesa & ""
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(cod_tipo_despesa),0)as ultimo From tab_tipo_despesa"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function

End Class
