Public Class ClInventarioRapido
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL

    Private seq_inventario_ As Integer
    Public Property seq_inventario() As Integer
        Get
            Return seq_inventario_
        End Get
        Set(ByVal value As Integer)
            seq_inventario_ = value
        End Set
    End Property
    Private cod_almoxarifado_ As Integer
    Public Property cod_almoxarifado() As Integer
        Get
            Return cod_almoxarifado_
        End Get
        Set(ByVal value As Integer)
            cod_almoxarifado_ = value
        End Set
    End Property
    Private cod_tipo_movimento_ As Integer
    Public Property cod_tipo_movimento() As Integer
        Get
            Return cod_tipo_movimento_
        End Get
        Set(ByVal value As Integer)
            cod_tipo_movimento_ = value
        End Set
    End Property
    Private cod_item_ As Integer
    Public Property cod_item() As Integer
        Get
            Return cod_item_
        End Get
        Set(ByVal value As Integer)
            cod_item_ = value
        End Set
    End Property
    Private qtd_item_ As String
    Public Property qtd_item() As String
        Get
            Return qtd_item_
        End Get
        Set(ByVal value As String)
            qtd_item_ = value
        End Set
    End Property
    Private val_custo_unitario_ As String
    Public Property val_custo_unitario() As String
        Get
            Return val_custo_unitario_
        End Get
        Set(ByVal value As String)
            val_custo_unitario_ = value
        End Set
    End Property
    Private val_custo_total_ As String
    Public Property val_custo_total() As String
        Get
            Return val_custo_total_
        End Get
        Set(ByVal value As String)
            val_custo_total_ = value
        End Set
    End Property
    Private dta_inventario_ As String
    Public Property dta_inventario() As String
        Get
            Return dta_inventario_
        End Get
        Set(ByVal value As String)
            dta_inventario_ = value
        End Set
    End Property

    Private cod_empresa_ As Integer
    Public Property cod_empresa() As Integer
        Get
            Return cod_empresa_
        End Get
        Set(ByVal value As Integer)
            cod_empresa_ = value
        End Set
    End Property
    Private num_inventario_ As String
    Public Property num_inventario() As String
        Get
            Return num_inventario_
        End Get
        Set(ByVal value As String)
            num_inventario_ = value
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
    Private ind_tipo_inventario_ As String
    Public Property ind_tipo_inventario() As String
        Get
            Return ind_tipo_inventario_
        End Get
        Set(ByVal value As String)
            ind_tipo_inventario_ = value
        End Set
    End Property
    Public Sub CadastrarInventario()
        sql = "Insert Into tab_inventario_rapido(seq_inventario, cod_tipo_movimento,cod_item,qtd_item, val_custo_unitario,
                 val_custo_total,dta_inventario,cod_empresa,num_inventario,des_observacao,ind_tipo_inventario,cod_almoxarifado) 
              Values (" & seq_inventario & ", '" & cod_tipo_movimento & "','" & cod_item & "','" & Replace(Replace(qtd_item, ".", ""), ",", ".") & "',
                     '" & Replace(Replace(val_custo_unitario, ".", ""), ",", ".") & "','" & Replace(Replace(val_custo_total, ".", ""), ",", ".") & "','" & dta_inventario & "',
                      " & ModParametroSistema.cod_empresa & ",'" & num_inventario & "','" & des_observacao & "',
                    '" & ind_tipo_inventario & "'," & cod_almoxarifado & ")"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarInventario()
        sql = "Update tab_inventario_rapido Set cod_almoxarifado = " & cod_almoxarifado & " ,
                            cod_tipo_movimento = " & cod_tipo_movimento & ",
                            cod_item =" & cod_item & ",
                            qtd_item =" & qtd_item & ",
                            val_custo_unitario =" & val_custo_unitario & ",
                            val_custo_total =" & val_custo_total & ",
                            dta_inventario ='" & dta_inventario & "',
                            num_inventario ='" & num_inventario & "',
                            des_observacao ='" & des_observacao & "',
                            ind_tipo_inventario ='" & ind_tipo_inventario & "'
              Where seq_inventario = " & seq_inventario & ""
        con.Operar(sql)
    End Sub

    Public Sub ExcluirInventario()
        sql = " Delete from tab_movimento_estoque Where seq_inventario =" & seq_inventario & ""
        con.Operar(sql)
        sql = " Delete from tab_inventario_rapido Where seq_inventario =" & seq_inventario & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarInventario(ByVal codTipoMov As String, ByVal numInventario As String, ByVal dtaInicio As String,
                                        ByVal dtaFinal As String, ByVal codAlmoxarifado As String)
        If codTipoMov = "" Then
            codTipoMov = "0"
        End If

        If codAlmoxarifado = "" Then
            codAlmoxarifado = "0"
        End If
        If dtaFinal = "" Then
            dtaFinal = dtaInicio
        End If

        sql = "Select a.seq_inventario,  
                     a.dta_inventario,
                     a.cod_item,
                     b.des_item,
                     a.cod_tipo_movimento,
                     c.des_tipo_movimento,
                     a.qtd_item,
                     a.val_custo_unitario,
                     a.val_custo_total,
                     a.cod_almoxarifado,
                     d.des_almoxarifado,
                     a.cod_empresa,
                     a.num_inventario,
                     a.ind_tipo_inventario,
                     a.des_observacao                   
                    
               From tab_inventario_rapido a
               Join tab_item b on (a.cod_item = b.cod_item)
               join tab_tipo_movimento c on (a.cod_tipo_movimento = c.cod_tipo_movimento)
               join tab_almoxarifado d on (d.cod_almoxarifado = a.cod_almoxarifado)
                
               Where ((a.cod_tipo_movimento = " & codTipoMov & " ) or (" & codTipoMov & " = 0))
                 and a.cod_empresa = " & ModParametroSistema.cod_empresa & "
                 and ((a.num_inventario = '" & numInventario & "' ) or ('" & numInventario & "' = ''))    
                 and ((a.cod_almoxarifado = " & codAlmoxarifado & " ) or (" & codAlmoxarifado & " = 0)) "
        If dtaInicio <> "" Then
            sql = sql & vbCrLf & "and a.dta_inventario BETWEEN '" & dtaInicio & "' and '" & dtaFinal & "'"
        End If

        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce( max(seq_inventario),0)as ultimo From tab_inventario_rapido"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
