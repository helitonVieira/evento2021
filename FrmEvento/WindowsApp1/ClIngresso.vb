Public Class ClIngresso

    Dim sql As String
    Dim ds, dsUtimo As New DataSet
    Dim con As New ConexaoSQL
    Dim ultimoEvento As Integer

    Private seq_ingresso_ As Integer
    Public Property seq_ingresso() As Integer
        Get
            Return seq_ingresso_
        End Get
        Set(ByVal value As Integer)
            seq_ingresso_ = value
        End Set
    End Property

    Private cod_evento_ As Integer
    Public Property cod_evento() As Integer
        Get
            Return cod_evento_
        End Get
        Set(ByVal value As Integer)
            cod_evento_ = value
        End Set
    End Property

    Private nom_evento1_ As String
    Public Property nom_evento1() As String
        Get
            Return nom_evento1_
        End Get
        Set(ByVal value As String)
            nom_evento1_ = value
        End Set
    End Property

    Private des_ingresso_ As String
    Public Property des_ingresso() As String
        Get
            Return des_ingresso_
        End Get
        Set(ByVal value As String)
            des_ingresso_ = value
        End Set
    End Property

    Private des_ingresso1_ As String
    Public Property des_ingresso1() As String
        Get
            Return des_ingresso1_
        End Get
        Set(ByVal value As String)
            des_ingresso1_ = value
        End Set
    End Property

    Private des_lote_ As String
    Public Property des_lote() As String
        Get
            Return des_lote_
        End Get
        Set(ByVal value As String)
            des_lote_ = value
        End Set
    End Property

    Private des_observacao1_ As String
    Public Property des_observacao1() As String
        Get
            Return des_observacao1_
        End Get
        Set(ByVal value As String)
            des_observacao1_ = value
        End Set
    End Property

    Private des_observacao2_ As String
    Public Property des_observacao2() As String
        Get
            Return des_observacao2_
        End Get
        Set(ByVal value As String)
            des_observacao2_ = value
        End Set
    End Property

    Private val_entrada_ As String
    Public Property val_entrada() As String
        Get
            Return val_entrada_
        End Get
        Set(ByVal value As String)
            val_entrada_ = value
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



    Public Sub CadastrarIngresso()
        sql = "Insert Into tab_ingresso  Values (" & seq_ingresso & ",'" & cod_evento & "' ,'" & des_ingresso & "' ,'" & des_ingresso1 & "' , '" & val_entrada & "','" & des_lote & "' ,'" & des_observacao1 & "' ,'" & des_observacao2 & "', '" & ind_aberto & "')"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarIngresso()
        sql = "Update tab_ingresso Set des_ingresso = '" & des_ingresso & "' ,des_ingresso1 = '" & des_ingresso1 & "',  val_entrada = " & val_entrada & ",des_lote = '" & des_lote & "',  des_observacao1 = '" & des_observacao1 & "',des_observacao2 = '" & des_observacao2 & "',ind_aberto = '" & ind_aberto & "' Where seq_ingresso = " & seq_ingresso & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirIngresso()
        sql = " Delete from tab_ingresso Where seq_ingresso =" & seq_ingresso & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarIngresso()
        sql = "Select * From tab_ingresso where cod_evento =" & cod_evento & ""
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarIngressoEventoAberto()
        sql = "Select b.seq_ingresso,
               a.cod_evento,
               a.nom_evento,
               b.des_ingresso,
               b.des_ingresso1,
               b.val_entrada,
               a.dta_evento,
               b.des_lote,
               a.ind_aberto,
               b.des_observacao1,
               b.des_observacao2 ,
			   coalesce((SELECT sum(i.qtd_impressa) from tab_ingresso_impresso i 
			             where i.cod_evento = a.cod_evento
			               and i.seq_ingresso = b.seq_ingresso ),0) as qtd_impressa,
			   coalesce((SELECT sum(i.qtd_impressa) from tab_ingresso_impresso i 
			   where i.cod_evento = a.cod_evento ),0) as qtd_total_impressa
               From tab_evento a  
               Join tab_ingresso b  on (a.cod_evento = b.cod_evento)
               where a.ind_aberto = 'S'"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultaringressoCodigo()
        sql = "Select * From tab_ingresso where  cod_evento =" & cod_evento & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarEventoCodNom()
        sql = "Select a.cod_evento, a.nom_evento, b.des_ingresso, b.des_ingresso1
                 From tab_evento a
                 join tab_ingresso b on(a.cod_evento = b.cod_evento
                 Where ind_aberto = 'S'"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select max(seq_ingresso) + 1 as ultimo From tab_ingresso"
        dsUtimo = con.Listar(sql)
        Return dsUtimo
    End Function

End Class
