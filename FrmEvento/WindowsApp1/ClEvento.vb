Public Class ClEvento

    Dim sql As String
        Dim ds, dsUtimo As New DataSet
    Dim con As New ConexaoSQL
    Dim ultimoEvento As Integer

    Private cod_evento_ As Integer
    Public Property cod_evento() As Integer
        Get
            Return cod_evento_
        End Get
        Set(ByVal value As Integer)
            cod_evento_ = value
        End Set
    End Property

    Private nom_evento_ As String
    Public Property nom_evento() As String
        Get
            Return nom_evento_
        End Get
        Set(ByVal value As String)
            nom_evento_ = value
        End Set
    End Property

    Private dta_evento_ As Date
    Public Property dta_evento() As Date
        Get
            Return dta_evento_
        End Get
        Set(ByVal value As Date)
            dta_evento_ = value
        End Set
    End Property

    Private ind_aberto_ As String
        Public Property ind_aberto() As String
            Get
                Return ind_aberto_
            End Get
            Set(ByVal value As String)
                ind_aberto_ = value
            End Set
        End Property

    Public Sub CadastrarEvento()
        sql = "Insert Into tab_evento Values (" & cod_evento & ",'" & nom_evento & "' ,'" & dta_evento & "','" & ind_aberto & "')"
        con.Operar(sql)
        End Sub

        Public Sub AtualizarEvento()
        sql = "Update tab_evento Set nom_evento = '" & nom_evento & "' ,dta_evento ='" & dta_evento & "', ind_aberto ='" & ind_aberto & "' Where cod_evento = " & cod_evento & ""
        con.Operar(sql)
        End Sub
        Public Sub ExcluirEvento()
            sql = " Delete from tab_evento Where cod_evento =" & cod_evento & ""
            con.Operar(sql)
        End Sub

    Public Function ConsultarEvento()
        sql = "Select * From tab_evento order by cod_evento desc"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarEventoAberto()
        sql = "Select a.cod_evento,
               a.nom_evento,
               b.des_ingresso,
               b.des_ingresso1,
               a.dta_evento,
               b.des_lote,
               a.ind_aberto,
               b.des_observacao1,
               b.des_observacao2 
               From tab_evento a  
               Join tab_ingresso b  on (a.cod_evento = b.cod_evento)
               where b.ind_aberto = 'S'"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarEventoCodigo()
        sql = "Select * From tab_evento where  cod_evento =" & cod_evento & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarEventoCodNom()
        sql = "Select cod_evento,nom_evento From tab_evento Where ind_aberto = 'S'"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoEventoCadastrado()
        sql = "Select max(cod_evento) + 1 as ultimo From tab_evento"
        dsUtimo = con.Listar(sql)
        Return dsUtimo
    End Function

    End Class
