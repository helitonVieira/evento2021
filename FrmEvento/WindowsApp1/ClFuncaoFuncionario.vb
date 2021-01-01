Public Class ClFuncaoFuncionario
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL
    Dim ultimoFuncaoFuncionario As Integer

    Private cod_funcao_funcionario_ As Integer
    Public Property cod_funcao_funcionario() As Integer
        Get
            Return cod_funcao_funcionario_
        End Get
        Set(ByVal value As Integer)
            cod_funcao_funcionario_ = value
        End Set
    End Property
    Private des_funcao_funcionario_ As String
    Public Property des_funcao_funcionario() As String
        Get
            Return des_funcao_funcionario_
        End Get
        Set(ByVal value As String)
            des_funcao_funcionario_ = value
        End Set
    End Property
    Public Sub CadastrarFuncaoFuncionario()
        sql = "Insert Into tab_funcao_funcionario( cod_funcao_funcionario ,des_funcao_funcionario) Values (" & cod_funcao_funcionario & ",'" & des_funcao_funcionario & "')"
        con.Operar(sql)
    End Sub
    Public Sub AtualizarFuncaoFuncionario()
        sql = "Update tab_funcao_funcionario Set des_funcao_funcionario = '" & des_funcao_funcionario & "'  Where cod_funcao_funcionario = " & cod_funcao_funcionario & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirFuncaoFuncionario()
        sql = " Delete from tab_funcao_funcionario Where cod_funcao_funcionario =" & cod_funcao_funcionario & ""
        con.Operar(sql)
    End Sub
    Public Function ConsultarFuncaoFuncionario(cod As Integer, desc As String)
        sql = "Select cod_funcao_funcionario,
                      des_funcao_funcionario
               From tab_funcao_funcionario
               where ((des_funcao_funcionario like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((cod_funcao_funcionario = " & cod & " )or (0 = " & cod & "))
              order by des_funcao_funcionario"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarFuncaoFuncionarioCodigo()
        sql = "Select * From tab_funcao_funcionario Where cod_funcao_funcionario =" & cod_funcao_funcionario & ""
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarFuncaoFuncionarioPesquisa(busca As String)
        sql = "Select * 
              From tab_funcao_funcionario
              where des_funcao_funcionario like ('%" & busca & "%')               
              order by des_funcao_funcionario"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoFuncaoFuncionarioCadastrado()
        sql = "Select coalesce( max(cod_funcao_funcionario),0)as ultimo From tab_funcao_funcionario"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
