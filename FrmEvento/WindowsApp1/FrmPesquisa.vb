Public Class FrmPesquisa
    Dim conectar As New ConexaoSQL
    Dim ds As New DataSet
    'EMPRESA SISTEMA
    Dim empresa As New ClEmpresa
    Dim grupoUsuario As New ClGrupoUsuario
    Dim usuario As New ClUsuario
    'ITEM ESTOQUE
    Dim clAlmoxarifado As New ClAlmoxarifado
    Dim clSecao As New ClSecaoItem
    Dim clCategoria As New ClCategoriaItem
    Dim clSubCategoria As New ClSubCategoriaItem
    Dim item As New ClItem1
    Dim clUnidade As New ClUnidade
    Dim clMarca As New ClMarca
    Dim inventario As New FrmInventarioRapido
    Dim clTipoMovto As New ClTipoMovimento
    Dim clTipoDespesa As New ClTipoDespesa
    'PESSOA
    Dim pessoa As New ClPessoa
    Dim clCidade As New ClCidade
    Dim clEstado As New ClEstado
    Dim clFuncao As New ClFuncaoFuncionario
    Dim clFuncao_func As New ClFuncaoFuncionario
    Dim clOperador As New ClPessoaFuncionario
    'PETSYSTEM
    Dim clAnimalVacina As PetSystem.ClVacina
    Dim clAnimaControleParasita As PetSystem.ClControleParasita
    Dim clAnimalraca As PetSystem.ClRaca
    Dim clAnimalPelagem As PetSystem.ClPelagem
    Dim clAnimalEspecie As PetSystem.ClEspecie
    'EVENTO
    Dim ingressoImpresso As New ClIngressoImpresso
    Dim evento As New ClEvento
    'FINANCEIRO
    Dim clEspecieCaixa As New ClEspecieCaixa
    Dim clBanco As New ClBanco
    Dim clTipoParcelamento As New ClTipoParcelamento
    Dim clTipoCobranca As New ClTipoCobranca
    'Vendas
    Dim clPdv As New ClPdv
    Private cod_evento_ As Integer


    Public Property cod_evento() As Integer
        Get
            Return cod_evento_
        End Get
        Set(ByVal value As Integer)
            cod_evento_ = value
        End Set
    End Property

    Private tabela_ As String
    Public Property tabela() As String
        Get
            Return tabela_
        End Get
        Set(ByVal value As String)
            tabela_ = value
        End Set
    End Property
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carrega(tabela, txbBusca.Text)
        txbBusca.Select()
    End Sub
    Public Sub carrega(tabela As String, busca As String)
        Try

            '    ds.Tables(0).Rows.Clear()


            Dim tab As DataTable
            If tabela = "tab_item" Then
                ds = item.ConsultarItemPesquisa(busca)

            ElseIf tabela = "tab_grupo_usuario" Then
                ds = grupoUsuario.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_usuario" Then
                ds = usuario.ConsultarPesquisa(busca)


            ElseIf tabela = "tab_pessoa" Then
                ds = pessoa.ConsultarPessoa(busca)
            ElseIf tabela = "tab_pessoa_funcionario" Then
                ds = pessoa.ConsultarPessoaFuncionario(busca)
            ElseIf tabela = "tab_pessoa_funcionario_agenda" Then
                ds = pessoa.ConsultarPessoaFuncionarioAgenda(busca)
            ElseIf tabela = "tab_funcao_funcionario" Then
                ds = clFuncao_func.ConsultarFuncaoFuncionarioPesquisa(busca)
            ElseIf tabela = "tab_pessoa_fornecedor" Then
                ds = pessoa.ConsultarPessoaFornecedor(busca)
            ElseIf tabela = "tab_operador" Then
                ds = clOperador.ConsultarOperador(busca)

            ElseIf tabela = "tab_tipo_despesa" Then
                ds = clTipoDespesa.ConsultarPesquisa(busca)

            ElseIf tabela = "tab_almoxarifado" Then
                ds = clAlmoxarifado.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_secao_item" Then
                ds = clSecao.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_categoria_item" Then
                ds = clCategoria.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_subcategoria_item" Then
                ds = clSubCategoria.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_unidade" Then
                ds = clUnidade.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_marca" Then
                ds = clMarca.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_tipo_movimento" Then
                ds = clTipoMovto.ConsultarTipoMovtoPesquisa(busca)
            ElseIf tabela = "tab_pdv" Then
                ds = clPdv.ConsultarPesquisa(busca)

            ElseIf tabela = "tab_cidade" Then
                ds = clCidade.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_estado" Then
                ds = clEstado.ConsultarPesquisa(busca)
                '------------------------------------------------- Financeiro 
            ElseIf tabela = "tab_especie_caixa" Then
                ds = clEspecieCaixa.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_banco" Then
                ds = clBanco.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_tipo_parcela" Then
                ds = clTipoParcelamento.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_tipo_cobranca" Then
                ds = clTipoCobranca.ConsultarPesquisa(busca)

            ElseIf tabela = "tab_ingresso_impresso" Then
                ingressoImpresso.cod_evento = cod_evento
                ds = ingressoImpresso.ConsultarIngressoImpressoAberto()
            ElseIf tabela = "tab_evento" Then
                ds = evento.ConsultarEvento()
            ElseIf tabela = "tab_empresa" Then
                ds = empresa.ConsultarEmpresa()
            End If
            tab = ds.Tables(0)
            If tab.Rows.Count > 0 Then
                dgvBusca.DataSource = ds.Tables(0)
                With dgvBusca
                    .Columns(0).HeaderText = "Código"
                    .Columns(1).HeaderText = "Descrição"
                    .Columns(0).Width = 60
                    .Columns(1).Width = 240
                End With
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txbBusca.TextChanged
        carrega(tabela, txbBusca.Text)
    End Sub
    Private Sub dgvBusca_DobleClick(sender As Object, e As EventArgs) Handles dgvBusca.DoubleClick
        Try
            ModVariavelGlobal.pesquisaCodigo = dgvBusca.CurrentRow.Cells(0).Value
            ModVariavelGlobal.pesquisaNome = dgvBusca.CurrentRow.Cells(1).Value
        Catch ex As Exception
        End Try
        txbBusca.Text = ""
        ds.Tables(0).Clear()
        Me.Close()
    End Sub

    Private Sub dgvBusca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvBusca.KeyPress
        ' If e.KeyChar. = 153 Then

        ' End If
    End Sub
End Class