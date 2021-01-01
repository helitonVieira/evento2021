Public Class ClUnidade
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_unidade_ As Integer
    Public Property cod_unidade() As Integer
        Get
            Return cod_unidade_
        End Get
        Set(ByVal value As Integer)
            cod_unidade_ = value
        End Set
    End Property

    Private des_unidade_ As String
    Public Property des_unidade() As String
        Get
            Return des_unidade_
        End Get
        Set(ByVal value As String)
            des_unidade_ = value
        End Set
    End Property

    Private sgl_unidade_ As String
    Public Property sgl_unidade() As String
        Get
            Return sgl_unidade_
        End Get
        Set(ByVal value As String)
            sgl_unidade_ = value
        End Set
    End Property

    Private num_fator_conversao_ As String
    Public Property num_fator_conversao() As String
        Get
            Return num_fator_conversao_
        End Get
        Set(ByVal value As String)
            num_fator_conversao_ = value
        End Set
    End Property

    Public Sub Cadastrar()
        sql = "Insert Into tab_unidade( cod_unidade ,des_unidade,sgl_unidade, num_fator_conversao) 
                    Values (" & cod_unidade & ",'" & des_unidade & "','" & sgl_unidade & "','" & num_fator_conversao & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_unidade Set des_unidade = '" & des_unidade & "' , 
                                           sgl_unidade = '" & sgl_unidade & "' ,
                                           num_fator_conversao = '" & num_fator_conversao & "'
                                     Where cod_unidade = " & cod_unidade
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_unidade Where cod_unidade =" & cod_unidade & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String, sgl_unidade As String, num_fator_conversao As Double)
        sql = "Select a.cod_unidade,
                      a.des_unidade,
                      a.sgl_unidade,
                      a.num_fator_conversao
               From tab_unidade a
               where ((a.des_unidade like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((a.cod_unidade = " & cod & " )or (0 = " & cod & "))
                 and ((a.sgl_unidade = '" & sgl_unidade & "' )or ('' = '" & sgl_unidade & "'))
                 and ((a.num_fator_conversao = " & num_fator_conversao & " )or (0 = " & num_fator_conversao & "))
              order by a.des_unidade"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_unidade Where cod_unidade =" & cod_unidade & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select cod_unidade,
                      des_unidade 
              From tab_unidade
              where des_unidade like ('%" & busca & "%')               
              order by des_unidade"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(cod_unidade) ,0)as ultimo From tab_unidade"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
