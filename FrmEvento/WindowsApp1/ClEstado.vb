Public Class ClEstado
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_estado_ As Integer
    Public Property cod_estado() As Integer
        Get
            Return cod_estado_
        End Get
        Set(ByVal value As Integer)
            cod_estado_ = value
        End Set
    End Property

    Private nom_estado_ As String
    Public Property nom_estado() As String
        Get
            Return nom_estado_
        End Get
        Set(ByVal value As String)
            nom_estado_ = value
        End Set
    End Property

    Private sgl_estado_ As String
    Public Property sgl_estado() As String
        Get
            Return sgl_estado_
        End Get
        Set(ByVal value As String)
            sgl_estado_ = value
        End Set
    End Property
 Private nom_pais_ As String
    Public Property nom_pais() As String
        Get
            Return nom_pais_
        End Get
        Set(ByVal value As String)
            nom_pais_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_estado( cod_estado ,nom_estado,sgl_estado, nom_pais) 
                    Values (" & cod_estado & ",'" & nom_estado & "','" & sgl_estado & "','" & nom_pais & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_estado Set nom_estado = '" & nom_estado & "' , 
                                  sgl_estado = '" & sgl_estado & "',
                                   nom_pais = '" & nom_pais & "'
                                    Where cod_estado = " & cod_estado
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_estado Where cod_estado =" & cod_estado & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String, cod_estado As Integer)
        sql = "Select a.cod_estado,
                      a.nom_estado,
                      a.sgl_estado,
                      a.nom_pais
               From tab_estado a
               where ((a.nom_estado like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((a.cod_estado = " & cod & " )or (0 = " & cod & "))
                 and ((a.cod_estado = " & cod_estado & " )or (0 = " & cod_estado & "))
              order by a.nom_estado"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_estado Where cod_estado =" & cod_estado & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_estado,
                      nom_estado 
              From tab_estado
              where nom_estado like ('%" & busca & "%')               
              order by nom_estado"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(cod_estado) ,0)as ultimo From tab_estado"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
