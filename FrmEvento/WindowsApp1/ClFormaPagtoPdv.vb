Public Class ClFormaPagtoPdv
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL

    Private cod_forma_pagto_ As Integer
    Public Property cod_forma_pagto() As Integer
        Get
            Return cod_forma_pagto_
        End Get
        Set(ByVal value As Integer)
            cod_forma_pagto_ = value
        End Set
    End Property
    Private des_forma_pagto_ As String
    Public Property des_forma_pagto() As String
        Get
            Return des_forma_pagto_
        End Get
        Set(ByVal value As String)
            des_forma_pagto_ = value
        End Set
    End Property
    Private cod_pessoa_sacado_ As Integer
    Public Property cod_pessoa_sacado() As Integer
        Get
            Return cod_pessoa_sacado_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_sacado_ = value
        End Set
    End Property
    Public Sub CadastrarFormaPagtoPdv()
        sql = "Insert Into tab_forma_pagto_pdv(	des_forma_pagto,	cod_pessoa_sacado) Values ( '" & des_forma_pagto & "'," & cod_pessoa_sacado & ")"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarFormaPagtoPdv()
        sql = "Update tab_forma_pagto_pdv Set des_forma_pagto = '" & des_forma_pagto & "',cod_pessoa_sacado ='" & cod_pessoa_sacado & "'  Where cod_forma_pagto = " & cod_forma_pagto & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirFormaPagtoPdv()
        sql = " Delete from tab_forma_pagto_pdv Where cod_forma_pagto =" & cod_forma_pagto & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarFormaPagtoPdv()
        sql = "Select COD_FORMA_PAGTO,
                      DES_FORMA_PAGTO
               From tab_forma_pagto_pdv 
               order by des_forma_pagto"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarFormaPagtoPdvCodigo()
        sql = "Select * From tab_forma_pagto_pdv
               Where cod_forma_pagto =" & cod_forma_pagto & ""
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarFormaPagtoPdvPesquisa(busca As String)
        sql = "Select cod_forma_pagto, 
                      des_forma_pagto  
               From tab_forma_pagto_pdv
               where des_forma_pagto like ('%" & busca & "%')
               order by des_forma_pagto"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(max(cod_forma_pagto) ,0)as ultimo From tab_forma_pagto_pdv"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
