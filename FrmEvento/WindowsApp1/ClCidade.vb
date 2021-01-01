Public Class ClCidade
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_cidade_ As Integer
    Public Property cod_cidade() As Integer
        Get
            Return cod_cidade_
        End Get
        Set(ByVal value As Integer)
            cod_cidade_ = value
        End Set
    End Property

    Private nom_cidade_ As String
    Public Property nom_cidade() As String
        Get
            Return nom_cidade_
        End Get
        Set(ByVal value As String)
            nom_cidade_ = value
        End Set
    End Property

    Private cod_estado_ As Integer
    Public Property cod_estado() As Integer
        Get
            Return cod_estado_
        End Get
        Set(ByVal value As Integer)
            cod_estado_ = value
        End Set
    End Property

    Public Sub Cadastrar()
        sql = "Insert Into tab_cidade( cod_cidade ,nom_cidade,cod_estado) 
                    Values (" & cod_cidade & ",'" & nom_cidade & "'," & cod_estado & ")"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_cidade Set nom_cidade = '" & nom_cidade & "' , 
                                  cod_estado = " & cod_estado & "
                                    Where cod_cidade = " & cod_cidade
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_cidade Where cod_cidade =" & cod_cidade & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String, cod_estado As Integer)
        sql = "Select a.cod_cidade,
                      a.nom_cidade,
                      a.cod_estado,
                      b.nom_estado
               From tab_cidade a
               Join tab_estado b on (a.cod_estado = b.cod_estado)
               where ((a.nom_cidade like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((a.cod_cidade = " & cod & " )or (0 = " & cod & "))
                 and ((a.cod_estado = " & cod_estado & " )or (0 = " & cod_estado & "))
              order by a.nom_cidade"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_cidade Where cod_cidade =" & cod_cidade & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_cidade,
                      nom_cidade 
              From tab_cidade
              where nom_cidade like ('%" & busca & "%')               
              order by nom_cidade"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(cod_cidade) ,0)as ultimo From tab_cidade"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
