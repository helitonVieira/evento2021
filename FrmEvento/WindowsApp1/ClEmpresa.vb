Public Class ClEmpresa

    Dim sql As String
        Dim ds As New DataSet
    Dim con As New ConexaoSQL
    Dim ultimoEmpresa As Integer

    Private cod_empresa_ As Integer
    Public Property cod_empresa() As Integer
        Get
            Return cod_empresa_
        End Get
        Set(ByVal value As Integer)
            cod_empresa_ = value
        End Set
    End Property

    Private nom_fantasia_ As String
    Public Property nom_fantasia() As String
        Get
            Return nom_fantasia_
        End Get
        Set(ByVal value As String)
            nom_fantasia_ = value
        End Set
    End Property

    Private num_cnpj_ As String
    Public Property num_cnpj() As String
        Get
            Return num_cnpj_
        End Get
        Set(ByVal value As String)
            num_cnpj_ = value
        End Set
    End Property

    Private num_ie_ As String
    Public Property num_ie() As String
        Get
            Return num_ie_
        End Get
        Set(ByVal value As String)
            num_ie_ = value
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

    Private des_logradouro_ As String
    Public Property des_logradouro() As String
        Get
            Return des_logradouro_
        End Get
        Set(ByVal value As String)
            des_logradouro_ = value
        End Set
    End Property

    Private nom_bairro_ As String
    Public Property nom_bairro() As String
        Get
            Return nom_bairro_
        End Get
        Set(ByVal value As String)
            nom_bairro_ = value
        End Set
    End Property

    Private des_complemento_ As String
    Public Property des_complemento() As String
        Get
            Return des_complemento_
        End Get
        Set(ByVal value As String)
            des_complemento_ = value
        End Set
    End Property

    Private cod_cidade_ As Integer

    Public Property cod_cidade() As Integer
        Get
            Return cod_cidade_
        End Get
        Set(ByVal value As Integer)
            cod_cidade_ = value
        End Set
    End Property

    Public Sub CadastrarEmpresa()
        '   sql = "Insert Into tab_empresa( nom_evento1,nom_evento2,nom_evento3, dta_evento, val_entrada, des_lote , ind_aberto, des_observacao1, des_observacao2) Values ('" & nom_evento1 & "' ,'" & nom_evento2 & "' ,'" & nom_evento3 & "' ,'" & dta_evento & "', '" & val_entrada & "','" & des_lote & "' ,'" & ind_aberto & "','" & des_observacao1 & "' ,'" & des_observacao2 & "')"
        '   con.Operar(sql)
    End Sub

    Public Sub AtualizarEvento()
        '     sql = "Update tab_evento Set nom_evento1 = '" & nom_evento1 & "' ,nom_evento2 = '" & nom_evento2 & "', nom_evento3 = '" & nom_evento3 & "', val_entrada = " & val_entrada & ",dta_evento ='" & dta_evento & "',des_lote = '" & des_lote & "', ind_aberto ='" & ind_aberto & "', des_observacao1 = '" & des_observacao1 & "',des_observacao2 = '" & des_observacao2 & "' Where cod_evento = " & cod_evento & ""
        ' con.Operar(sql)
    End Sub
        Public Sub ExcluirEvento()
        '   sql = " Delete from tab_evento Where cod_evento =" & cod_evento & ""
        'con.Operar(sql)
    End Sub

    Public Function ConsultarEmpresa()
        sql = "Select * From tab_empresa"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarEmpresaFantasia()
        sql = "Select cod_empresa, nom_fantasia From tab_empresa"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarEmpresaCodigo()
        sql = "Select * From tab_evento where  cod_evento =" & cod_empresa & ""
        ds = con.Listar(sql)
        Return ds
    End Function



End Class
