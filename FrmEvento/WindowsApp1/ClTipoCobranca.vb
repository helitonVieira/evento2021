Public Class ClTipoCobranca
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_tipo_cobranca_ As Integer
    Public Property cod_tipo_cobranca() As Integer
        Get
            Return cod_tipo_cobranca_
        End Get
        Set(ByVal value As Integer)
            cod_tipo_cobranca_ = value
        End Set
    End Property

    Private des_tipo_cobranca_ As String
    Public Property des_tipo_cobranca() As String
        Get
            Return des_tipo_cobranca_
        End Get
        Set(ByVal value As String)
            des_tipo_cobranca_ = value
        End Set
    End Property

    Private ind_status_ As String
    Public Property ind_status() As String
        Get
            Return ind_status_
        End Get
        Set(ByVal value As String)
            ind_status_ = value
        End Set
    End Property

    Public Sub Cadastrar()
        sql = "Insert Into tab_tipo_cobranca( cod_tipo_cobranca ,
                                              des_tipo_cobranca,
                                              ind_status) 
                    Values (" & cod_tipo_cobranca & ",
                           '" & des_tipo_cobranca & "',
                           '" & ind_status & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_tipo_cobranca Set des_tipo_cobranca = '" & des_tipo_cobranca & "' , 
                                  ind_status = '" & ind_status & "'
                                    Where cod_tipo_cobranca = " & cod_tipo_cobranca
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_tipo_cobranca Where cod_tipo_cobranca =" & cod_tipo_cobranca & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String, ind_status As String)

        sql = "Select a.cod_tipo_cobranca,
                      a.des_tipo_cobranca,
                      a.ind_status
               From tab_tipo_cobranca a
                where a.des_tipo_cobranca like ('%" & desc & "%') 
                 and ((a.cod_tipo_cobranca = " & cod & " )or (0 = " & cod & "))
                 and ((a.ind_status = '" & ind_status & "' )or ('' = '" & ind_status & "'))
              order by a.des_tipo_cobranca"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_tipo_cobranca Where cod_tipo_cobranca =" & cod_tipo_cobranca & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_tipo_cobranca,
                      des_tipo_cobranca 
              From tab_tipo_cobranca
              where des_tipo_cobranca like ('%" & busca & "%')               
              order by des_tipo_cobranca"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(cod_tipo_cobranca),0)as ultimo From tab_tipo_cobranca"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
