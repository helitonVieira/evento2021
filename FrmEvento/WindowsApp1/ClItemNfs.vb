Public Class ClItemNfs
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private seq_nota_ As Integer
    Public Property seq_nota() As Integer
        Get
            Return seq_nota_
        End Get
        Set(ByVal value As Integer)
            seq_nota_ = value
        End Set
    End Property

    Private seq_item_nota_ As Integer
    Public Property seq_item_nota() As Integer
        Get
            Return seq_item_nota_
        End Get
        Set(ByVal value As Integer)
            seq_item_nota_ = value
        End Set
    End Property

    Private cod_item_ As String
    Public Property cod_item() As String
        Get
            Return cod_item_
        End Get
        Set(ByVal value As String)
            cod_item_ = value
        End Set
    End Property

    Private des_item_ As String
    Public Property des_item() As String
        Get
            Return des_item_
        End Get
        Set(ByVal value As String)
            des_item_ = value
        End Set
    End Property
    Private qtd_item_ As Integer
    Public Property qtd_item() As Integer
        Get
            Return qtd_item_
        End Get
        Set(ByVal value As Integer)
            qtd_item_ = value
        End Set
    End Property

    Private cod_unidade_ As Integer
    Public Property cod_unidade() As Integer
        Get
            Return cod_unidade_
        End Get
        Set(ByVal value As Integer)
            cod_unidade_ = value
        End Set
    End Property

    Private qtd_item_convertido_ As String
    Public Property qtd_item_convertido() As String
        Get
            Return qtd_item_convertido_
        End Get
        Set(ByVal value As String)
            qtd_item_convertido_ = value
        End Set
    End Property

    Private val_unitario_ As String
    Public Property val_unitario() As String
        Get
            Return val_unitario_
        End Get
        Set(ByVal value As String)
            val_unitario_ = value
        End Set
    End Property
    Private val_bruto_item_ As String
    Public Property val_bruto_item() As String
        Get
            Return val_bruto_item_
        End Get
        Set(ByVal value As String)
            val_bruto_item_ = value
        End Set
    End Property

    Private val_desconto_ As String
    Public Property val_desconto() As String
        Get
            Return val_desconto_
        End Get
        Set(ByVal value As String)
            val_desconto_ = value
        End Set
    End Property
    Private val_acrescimo_ As String
    Public Property val_acrescimo() As String
        Get
            Return val_acrescimo_
        End Get
        Set(ByVal value As String)
            val_acrescimo_ = value
        End Set
    End Property


    Public Sub Cadastrar()

        sql = "Insert Into tab_item_nfs( seq_nota ,seq_item_nota ,cod_item,des_item,qtd_item ,cod_unidade ,
                                      qtd_item_convertido,val_unitario, val_bruto_item, val_desconto, val_acrescimo) 
                    Values ( " & seq_nota & "," & seq_item_nota & "," & cod_item & ",
                            '" & des_item & "'," & Replace(Replace(qtd_item, ".", ""), ",", ".") & "," & cod_unidade & "," & Replace(Replace(qtd_item_convertido, ".", ""), ",", ".") & ",
                            " & Replace(Replace(val_unitario, ".", ""), ",", ".") & ", " & Replace(Replace(val_bruto_item, ".", ""), ",", ".") & ", 
                            " & Replace(Replace(val_desconto, ".", ""), ",", ".") & ", 
                            " & Replace(Replace(val_acrescimo, ".", ""), ",", ".") & ")"

        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_item_nfs Set cod_item            = " & cod_item & " ,
                                       des_item            = '" & des_item & "' ,
                                       qtd_item            = " & CDbl(qtd_item) & " ,
                                       cod_unidade         = " & cod_unidade & " ,
                                       qtd_item_convertido = " & CDbl(qtd_item_convertido) & " ,
                                       val_unitario        = " & CDbl(val_unitario) & " ,
                                       val_bruto_item      = " & CDbl(val_bruto_item) & " ,
                                       val_desconto        = " & CDbl(val_desconto) & " ,
                                       val_acrescimo       = " & CDbl(val_acrescimo) & " 
                                       
                                     Where seq_nota = " & seq_nota & " seq_item_nota = " & seq_item_nota

        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_item_nfs Where seq_nota =" & seq_nota & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(seq_nota As Integer, des_item As String, cod_item As Double)
        sql = "Select a.seq_nota              ,
                      a.seq_item_nota         ,
                      a.cod_item              ,
                      a.des_item              ,
                      a.qtd_item              ,
                      a.cod_unidade           ,
                      a.qtd_item_convertido   ,
                      a.val_unitario          ,
                      a.val_bruto_item        ,
                      a.val_desconto          ,
                      a.val_acrescimo 
             From tab_item_nfs a
               where ((a.des_item like ('%" & des_item & "%') )or ('' = '" & des_item & "' ))  
                 and ((a.seq_nota = " & seq_nota & " )or (0 = " & seq_nota & "))
                 and ((a.cod_item = " & cod_item & " )or (0 = " & cod_item & "))
              order by a.seq_nota, a.des_item"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_item_nfs Where seq_nota =" & seq_nota & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select seq_nota,
                      cod_item 
              From tab_item_nfs
              where cod_item like ('%" & busca & "%')               
              order by cod_item"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(seq_nota) ,0)as ultimo From tab_item_nfs"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
