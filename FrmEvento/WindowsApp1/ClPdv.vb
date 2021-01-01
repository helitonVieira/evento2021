Public Class ClPdv
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_pdv_ As Integer
    Public Property cod_pdv() As Integer
        Get
            Return cod_pdv_
        End Get
        Set(ByVal value As Integer)
            cod_pdv_ = value
        End Set
    End Property

    Private cod_empresa_ As Integer
    Public Property cod_empresa() As Integer
        Get
            Return cod_empresa_
        End Get
        Set(ByVal value As Integer)
            cod_empresa_ = value
        End Set
    End Property

    Private des_pdv_ As String
    Public Property des_pdv() As String
        Get
            Return des_pdv_
        End Get
        Set(ByVal value As String)
            des_pdv_ = value
        End Set
    End Property

    Private des_hostname_ As String
    Public Property des_hostname() As String
        Get
            Return des_hostname_
        End Get
        Set(ByVal value As String)
            des_hostname_ = value
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
        sql = "Insert Into tab_pdv( cod_pdv ,cod_empresa ,des_pdv,ind_ativo, des_hostname) 
                    Values ((select coalesce(max(cod_pdv),0)+1 from tab_pdv)," & ModParametroSistema.cod_empresa & ",'" & des_pdv & "','" & ind_ativo & "','" & des_hostname & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_pdv Set des_pdv = '" & des_pdv & "' , 
                                ind_ativo = '" & ind_ativo & "',
                                des_hostname = '" & des_hostname & "'
                            Where cod_pdv = " & cod_pdv
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_pdv Where cod_pdv =" & cod_pdv & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String, ind_ativo As String, cod_empresa As Double)
        sql = "Select a.cod_pdv,
                      a.des_pdv,
                      a.cod_empresa,
                      b.nom_fantasia,
                      a.des_hostname,  
                      a.ind_ativo
                      
               From tab_pdv a
               join tab_empresa b on (a.cod_empresa = b.cod_empresa)    
               where a.des_pdv like ('%" & desc & "%')  
                 and ((a.cod_pdv = " & cod & " )or (0 = " & cod & "))
                 and ((a.ind_ativo = '" & ind_ativo & "' )or ('T' = '" & ind_ativo & "'))
                 and ((a.cod_empresa = " & cod_empresa & " )or (0 = " & cod_empresa & "))
              order by a.des_pdv"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_pdv Where cod_pdv =" & cod_pdv & ""
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_pdv,
                      des_pdv 
              From tab_pdv
              where des_pdv like ('%" & busca & "%')               
              order by des_pdv"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(cod_pdv) ,0)as ultimo From tab_pdv"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
