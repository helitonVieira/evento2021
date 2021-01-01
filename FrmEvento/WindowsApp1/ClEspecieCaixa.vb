Public Class ClEspecieCaixa
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_especie_ As Integer
    Public Property cod_especie() As Integer
        Get
            Return cod_especie_
        End Get
        Set(ByVal value As Integer)
            cod_especie_ = value
        End Set
    End Property

    Private des_especie_ As String
    Public Property des_especie() As String
        Get
            Return des_especie_
        End Get
        Set(ByVal value As String)
            des_especie_ = value
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
        sql = "Insert Into tab_especie_caixa( cod_especie ,des_especie,ind_ativo) 
                    Values (" & cod_especie & ",'" & des_especie & "','" & ind_ativo & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_especie_caixa Set des_especie = '" & des_especie & "' , 
                                  ind_ativo = '" & ind_ativo & "'
                                    Where cod_especie = " & cod_especie
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_especie_caixa Where cod_especie =" & cod_especie & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String, ind_ativo As String)

        sql = "Select a.cod_especie,
                      a.des_especie,
                      a.ind_ativo
               From tab_especie_caixa a
                where ((a.des_especie like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((a.cod_especie = " & cod & " )or (0 = " & cod & "))
                 and ((a.ind_ativo = '" & ind_ativo & "')or ('' = '" & ind_ativo & "'))
              order by a.des_especie"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_especie_caixa Where cod_especie =" & cod_especie & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_especie,
                      des_especie 
              From tab_especie_caixa
              where des_especie like ('%" & busca & "%')               
              order by des_especie"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(cod_especie),0)as ultimo From tab_especie_caixa"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
