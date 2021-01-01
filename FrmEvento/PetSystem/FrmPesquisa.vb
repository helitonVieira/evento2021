Public Class FrmPesquisa

    Dim conectar As New Controles.ConexaoSQL
    Dim clAnimalVacina As New ClVacina
    Dim clAnimaControleParasita As New ClControleParasita
    Dim clAnimalraca As New ClRaca
    Dim clAnimalPelagem As New ClPelagem
    Dim clAnimalEspecie As New ClEspecie
    Dim clPessoa As New ClPessoa

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
        carrega(tabela, "")
    End Sub
    Public Sub carrega(tabela As String, busca As String)
        Try
            Dim ds As New DataSet
            ds.Clear()

            cbBusca.Items.Clear()
            cbBusca.Items.Add("Codigo")
            cbBusca.Items.Add("Descricao")
            Dim tab As DataTable

            If tabela = "tab_pessoa_animal" Then
                ds = clPessoa.ConsultarPessoaCliente(busca)
            ElseIf tabela = "tab_parasita_animal" Then
                ds = clAnimaControleParasita.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_vacina_animal" Then
                ds = clAnimalVacina.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_raca_animal" Then
                ds = clAnimalraca.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_especie_animal" Then
                ds = clAnimalEspecie.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_pelagem_animal" Then
                ds = clAnimalPelagem.ConsultarPesquisa(busca)
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
            'MsgBox(ex)
        End Try
    End Sub
    Private Sub dgvBusca_Click(sender As Object, e As EventArgs) Handles dgvBusca.Click
        'Criado um modulo de variavel global para armazenar por jogando direto nao estava funcionando 
        ModuleVariavelGlobal.pesquisaCodigo = dgvBusca.CurrentRow.Cells(0).Value.ToString
        ModuleVariavelGlobal.pesquisaNome = dgvBusca.CurrentRow.Cells(1).Value.ToString
        ' 
        Me.Close()

    End Sub

End Class