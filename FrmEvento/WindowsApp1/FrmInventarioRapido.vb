Public Class FrmInventarioRapido
    Dim conectar As New ConexaoSQL
    Dim clGeral As New ClGeral
    Dim atualizar As Integer = 1
    Dim inventario, inventario2 As New ClInventarioRapido
    Dim clAlmoxarifado As New ClAlmoxarifado
    Dim clItem As New ClItem1
    Dim clTipoMovimento As New ClTipoMovimento
    Dim geral As New ClGeral
    Dim ds As New DataSet
    Dim frmDtaFinal As New FrmDataFinal
    Public desItem As String
    Dim dtaFim As String
    'Dim seq_inventarioOld, cod_tipo_movimentoOld, cod_itemOld, qtd_itemOld, val_custo_unitarioOld,
    '     val_custo_totalOld, dta_inventarioOld, cod_empresaOld, num_inventarioOld,
    '     des_observacaoOld, ind_tipo_inventarioOld, cod_almoxarifadoOld As String

    Private codItem_ As String
    Public Property codItem() As String
        Get
            Return codItem_
        End Get
        Set(ByVal value As String)
            codItem_ = value
        End Set
    End Property
    Private Sub FrmInventarioRapido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t1202 = False Then
                MsgBox("Usuário sem permissão para acessar o Inventario Rapido!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
            BtnSalvar.Enabled = ModPermissaoUsuario.t12021
            BtnSalvar2.Enabled = ModPermissaoUsuario.t12021
            BtnExcluir.Enabled = ModPermissaoUsuario.t12022
        End If
        DtpDta.Value = Today.ToShortDateString
        limparGeral()
    End Sub

    Private Sub BtPresquisa_Click(sender As Object, e As EventArgs) Handles BtPresquisa.Click
        atualizaDados()
        atualizaFormulario()
    End Sub
    Private Sub atualizaFormulario()
        Try
            limparGeral()
            atualizar = 1
            TxbDtaInventario.Text = ds.Tables(0).Rows(0)("dta_inventario").ToString
            txtCodTipoMovimento.Text = ds.Tables(0).Rows(0)("cod_tipo_movimento").ToString
            txtDesTipoMovimento.Text = ds.Tables(0).Rows(0)("des_tipo_movimento").ToString
            txtCodAlmoxarifado.Text = ds.Tables(0).Rows(0)("cod_almoxarifado").ToString
            txtDesAlmoxarifado.Text = ds.Tables(0).Rows(0)("des_almoxarifado").ToString
            TxbNumero.Text = ds.Tables(0).Rows(0)("num_inventario").ToString
            If ds.Tables(0).Rows(0)("ind_tipo_inventario").ToString = "T" Then
                rbTotal.Checked = True
            Else
                rbParcial.Checked = True
            End If

            Catch ex As Exception
            End Try

    End Sub
    Public Sub atualizaDados()
        '  conectar.Conectar()
        Dim tabela As DataTable
        ds = inventario.ConsultarInventario(txtCodTipoMovimento.Text, TxbNumero.Text, TxbDtaInventario.Text, dtaFim, txtCodAlmoxarifado.Text)
        tabela = ds.Tables(0)
        If tabela.Rows.Count > 0 Then
            dgvInventario.DataSource = ds.Tables(0)
            formatarGrid()
        End If
        limpar()
    End Sub
    Private Sub limpar()

        txtCodItem.Text = ""
        txtDesItem.Text = ""
        TxbQtde.Text = "0,00"
        txbCustoUn.Text = "0,00"
        txbCustoTotal.Text = "0,00"
        txbObservacao.Text = ""

        atualizar = 1
    End Sub
    Private Sub limparGeral()
        limpar()
        txtCodAlmoxarifado.Text = ""
        txtDesAlmoxarifado.Text = ""
        TxbDtaInventario.Text = ""
        dtaFim = ""
        TxbNumero.Text = ""
        txtCodTipoMovimento.Text = ""
        txtDesTipoMovimento.Text = ""
        rbParcial.Checked = True
        atualizar = 1
    End Sub
    Public Sub formatarGrid()
        With dgvInventario
            .Columns(0).Visible = False ' "Sequencia"
            .Columns(1).HeaderText = "Data"
            .Columns(2).HeaderText = "Item"
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).HeaderText = ""
            .Columns(4).HeaderText = "Tipo Movimento"
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).HeaderText = ""
            .Columns(6).HeaderText = "Qtde"
            .Columns(6).DefaultCellStyle.Format = "N2"
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).HeaderText = "R$ Unitario"
            .Columns(7).DefaultCellStyle.Format = "N2"
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(8).HeaderText = "R$ Total"
            .Columns(8).DefaultCellStyle.Format = "N2"
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(9).HeaderText = "Almoxarifado"
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(10).HeaderText = ""
            .Columns(11).Visible = False '"empresa"
            .Columns(12).HeaderText = "Número"
            .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(13).HeaderText = "Tipo"
            .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(14).HeaderText = "Observação"
            .Columns(1).Width = 70
            .Columns(2).Width = 60
            .Columns(3).Width = 180
            .Columns(4).Width = 60
            .Columns(5).Width = 180
            .Columns(6).Width = 60
            .Columns(7).Width = 60
            .Columns(8).Width = 60
            .Columns(9).Width = 65
            .Columns(10).Width = 150
            .Columns(12).Width = 60
            .Columns(13).Width = 40
            .Columns(14).Width = 400

        End With
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnSalvar2.Click
        salvarRegistro()
        txtCodItem.Select()
    End Sub
    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvarRegistro()
    End Sub
    Private Sub salvarRegistro()
        Try
            ' Dim ultimo As DataSet
            'ultimo = inventario.ConsultarItemVenda
            '  Label7.Text = ultimo.Tables(0).Rows.Item(1).ToString
            If txtCodAlmoxarifado.Text = "" Then
                MsgBox("Informe o Almoxarifado!", MsgBoxStyle.Information, "Informação")
                txtCodAlmoxarifado.Select()
                Exit Sub
            End If

            If txtCodTipoMovimento.Text = "" Then
                MsgBox("Informe o tipo Movimento", MsgBoxStyle.Information, "Informação")
                txtCodTipoMovimento.Select()
                Exit Sub
            End If

            If txtCodItem.Text = "" Then
                MsgBox("Informe o Item", MsgBoxStyle.Information, "Informação")
                txtCodItem.Select()
                Exit Sub
            End If
            If TxbQtde.Text = "" Then
                MsgBox("Informe a quantidade", MsgBoxStyle.Information, "Informação")
                TxbQtde.Select()
                Exit Sub
            End If

            If txbCustoUn.Text = "" Then
                MsgBox("Informe o Custo Unitario", MsgBoxStyle.Information, "Informação")
                txbCustoUn.Select()
                Exit Sub
            End If

            If txbCustoTotal.Text = "" Then
                txbCustoTotal.Text = "0"
            End If

            If TxbDtaInventario.Text = "" Then
                MsgBox("Informe a Data", MsgBoxStyle.Information, "Informação")
                TxbDtaInventario.Select()
                Exit Sub
            End If
            inventario.cod_almoxarifado = txtCodAlmoxarifado.Text
            inventario.cod_tipo_movimento = txtCodTipoMovimento.Text
            inventario.cod_item = txtCodItem.Text
            inventario.qtd_item = CDbl(TxbQtde.Text)
            inventario.val_custo_unitario = CDbl(txbCustoUn.Text)
            inventario.val_custo_total = CDbl(txbCustoTotal.Text)
            inventario.dta_inventario = TxbDtaInventario.Text
            inventario.cod_empresa = ModParametroSistema.cod_empresa
            inventario.num_inventario = TxbNumero.Text
            inventario.des_observacao = txbObservacao.Text
            If rbParcial.Checked Then
                inventario.ind_tipo_inventario = "P"
            Else
                inventario.ind_tipo_inventario = "T"
            End If

            If atualizar = 1 Then
                Try
                    Dim ultimo As New DataSet
                    ultimo = inventario2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    inventario.seq_inventario = Convert.ToInt16(ult) + 1

                    ultimo.Clear()
                Catch ex As Exception
                    inventario.seq_inventario = 1
                End Try
                inventario.CadastrarInventario()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                LbSeq.Text = inventario.seq_inventario
                MsgBox("Inventario cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            Else
                inventario.seq_inventario = LbSeq.Text
                inventario.AtualizarInventario()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox("Inventario Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            End If

        Catch ex As Exception
            MsgBox("Não foi possivel Salvar Registo no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Function StrToFloat(v As String) As String
        Throw New NotImplementedException()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If MsgBox("Deseja excluir o item Inventario" & txtDesItem.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                inventario.seq_inventario = LbSeq.Text
                inventario.ExcluirInventario()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox("Item Inventario excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()

            Catch ex As Exception
                MsgBox("Erro ao excluir Item Inventario, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limparGeral()
        Try
            ds.Tables(0).Rows.Clear()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txbCustoUn_Validated(sender As Object, e As EventArgs) Handles txbCustoUn.Validated
        If TxbQtde.Text = "" Or txbCustoUn.Text = "" Then
            Exit Sub
        End If
        Try
            txbCustoTotal.Text = clGeral.mutiplicar(CDbl(TxbQtde.Text), CDbl(txbCustoUn.Text))
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btMovimento_Click(sender As Object, e As EventArgs) Handles btMovimento.Click
        FrmPesquisa.tabela = "tab_tipo_movimento"
        FrmPesquisa.ShowDialog()
        txtCodTipoMovimento.Text = ModVariavelGlobal.pesquisaCodigo
        txtDesTipoMovimento.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub txtCodAlmoxarifado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodAlmoxarifado.KeyPress
        clGeral.somenteNumero(e)
    End Sub

    Private Sub txtCodTipoMovimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodTipoMovimento.KeyPress
        clGeral.somenteNumero(e)
    End Sub

    Private Sub txtCodItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodItem.KeyPress
        clGeral.somenteNumero(e)
    End Sub
    Private Sub dgvInventario_DoubleClick(sender As Object, e As EventArgs) Handles dgvInventario.DoubleClick
        Try
            limpar()
            atualizar = 2
            LbSeq.Text = dgvInventario.CurrentRow.Cells(0).Value
            TxbDtaInventario.Text = dgvInventario.CurrentRow.Cells(1).Value
            txtCodItem.Text = dgvInventario.CurrentRow.Cells(2).Value
            txtDesItem.Text = dgvInventario.CurrentRow.Cells(3).Value
            txtCodTipoMovimento.Text = dgvInventario.CurrentRow.Cells(4).Value
            txtDesTipoMovimento.Text = dgvInventario.CurrentRow.Cells(5).Value
            TxbQtde.Text = dgvInventario.CurrentRow.Cells(6).Value
            txbCustoUn.Text = dgvInventario.CurrentRow.Cells(7).Value
            txbCustoTotal.Text = dgvInventario.CurrentRow.Cells(8).Value

            txtCodAlmoxarifado.Text = dgvInventario.CurrentRow.Cells(9).Value
            txtDesAlmoxarifado.Text = dgvInventario.CurrentRow.Cells(10).Value

            TxbNumero.Text = dgvInventario.CurrentRow.Cells(12).Value

            If dgvInventario.CurrentRow.Cells(13).Value = "P" Then
                rbParcial.Checked = True
            Else
                rbTotal.Checked = True
            End If

            txbObservacao.Text = dgvInventario.CurrentRow.Cells(14).Value
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txbQtde_TextChanged(sender As Object, e As EventArgs) Handles TxbQtde.TextChanged
        If Not IsNumeric(TxbQtde.Text) Then
            TxbQtde.Text = ""
        End If
    End Sub

    Private Sub txbCustoUn_TextChanged(sender As Object, e As EventArgs) Handles txbCustoUn.TextChanged
        If Not IsNumeric(txbCustoUn.Text) Then
            txbCustoUn.Text = ""
        End If
    End Sub

    Private Sub DtpDta_ValueChanged(sender As Object, e As EventArgs) Handles DtpDta.ValueChanged
        TxbDtaInventario.Text = DtpDta.Value.ToShortDateString
    End Sub

    Private Sub BtnDtaFinal_Click(sender As Object, e As EventArgs) Handles BtnDtaFinal.Click
        frmDtaFinal.tela = "dtaInventario"
        frmDtaFinal.DtpDtaFinal.Value = Today
        frmDtaFinal.TxbDtaFinal.Text = ""
        frmDtaFinal.ShowDialog()
        dtaFim = ModVariavelGlobal.dtaFinal
    End Sub
    Private Sub txbCustoTotal_TextChanged(sender As Object, e As EventArgs) Handles txbCustoTotal.TextChanged
        If Not IsNumeric(txbCustoTotal.Text) Then
            txbCustoTotal.Text = ""
        End If
    End Sub
    Private Sub BtnItem_Click(sender As Object, e As EventArgs) Handles btBuscaItem.Click
        FrmPesquisa.tabela = "tab_item"
        FrmPesquisa.ShowDialog()
        txtCodItem.Text = ModVariavelGlobal.pesquisaCodigo
        txtDesItem.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub
    Private Sub txtCodAlmoxarifado_LostFocus(sender As Object, e As EventArgs) Handles txtCodAlmoxarifado.LostFocus
        If txtCodAlmoxarifado.Text <> "" And IsNumeric(txtCodAlmoxarifado.Text) Then
            txtDesAlmoxarifado.Text = geral.sqlBuscaDescricao("des_almoxarifado", "tab_almoxarifado", "cod_almoxarifado", txtCodAlmoxarifado.Text)
        End If
    End Sub
    Private Sub txtCodTipoMovimento_LostFocus(sender As Object, e As EventArgs) Handles txtCodTipoMovimento.LostFocus
        If txtCodTipoMovimento.Text <> "" And IsNumeric(txtCodTipoMovimento.Text) Then
            txtDesTipoMovimento.Text = geral.sqlBuscaDescricao("des_tipo_movimento", "tab_tipo_movimento", "cod_tipo_movimento", txtCodTipoMovimento.Text)
        End If
    End Sub
    Private Sub txtCodItem_LostFocus(sender As Object, e As EventArgs) Handles txtCodItem.LostFocus
        If txtCodItem.Text <> "" And IsNumeric(txtCodItem.Text) Then
            txtDesItem.Text = geral.sqlBuscaDescricao("des_item", "tab_item", "cod_item", txtCodItem.Text)
        End If
    End Sub
    Private Sub BtnAlmoxarifado_Click(sender As Object, e As EventArgs) Handles btnAlmoxarifado.Click
        FrmPesquisa.tabela = "tab_almoxarifado"
        FrmPesquisa.ShowDialog()
        txtCodAlmoxarifado.Text = ModVariavelGlobal.pesquisaCodigo
        txtDesAlmoxarifado.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub
End Class