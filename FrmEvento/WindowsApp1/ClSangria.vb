Public Class ClSangria
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private seq_sangria_ As Integer
    Public Property seq_sangria() As Integer
        Get
            Return seq_sangria_
        End Get
        Set(ByVal value As Integer)
            seq_sangria_ = value
        End Set
    End Property

    Private val_sangria_ As String
    Public Property val_sangria() As String
        Get
            Return val_sangria_
        End Get
        Set(ByVal value As String)
            val_sangria_ = value
        End Set
    End Property

    Private seq_fechamento_ As Integer
    Public Property seq_fechamento() As Integer
        Get
            Return seq_fechamento_
        End Get
        Set(ByVal value As Integer)
            seq_fechamento_ = value
        End Set
    End Property

    Private des_observacao_ As String
    Public Property des_observacao() As String
        Get
            Return des_observacao_
        End Get
        Set(ByVal value As String)
            des_observacao_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_sangria( seq_sangria ,val_sangria,seq_fechamento,des_observacao) 
                    Values ((select coalesce(max(seq_sangria),0)+1 from tab_sangria),
                           '" & Replace(Replace(val_sangria, ".", ""), ",", ".") & "',
                            " & seq_fechamento & ",
                           '" & des_observacao & "')"
        con.Operar(sql)
    End Sub
    Public Sub Atualizar()
        sql = "Update tab_sangria Set val_sangria = '" & Replace(Replace(val_sangria, ".", ""), ",", ".") & "' , 
                                    seq_fechamento = " & seq_fechamento & ",
                                    des_observacao = '" & des_observacao & "' , 
                                    Where seq_sangria = " & seq_sangria
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_sangria Where seq_sangria =" & seq_sangria & ""
        con.Operar(sql)
    End Sub
    Public Function Consultar(cod As Integer, desc As String, seq_fechamento As Integer)
        sql = "Select a.seq_sangria,
                      a.val_sangria,
                      a.seq_fechamento,
                      a.des_observacao
               From tab_sangria a
               Join tab_fechamento_caixa_pdv b on (a.seq_fechamento = b.seq_fechamento)
               where ((a.val_sangria like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((a.seq_sangria = " & cod & " )or (0 = " & cod & "))
                 and ((a.seq_fechamento = " & seq_fechamento & " )or (0 = " & seq_fechamento & "))
              order by a.val_sangria"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_sangria Where seq_sangria =" & seq_sangria & ""
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarPesquisa(busca As String)
        sql = "Select seq_sangria,
                      val_sangria 
              From tab_sangria
              where val_sangria like ('%" & busca & "%')               
              order by val_sangria"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(seq_sangria),0)as ultimo From tab_sangria"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
