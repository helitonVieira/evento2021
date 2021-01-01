Imports PetSystem.FrmControleParasita
Public Class FrmPrincipal
    Dim ClLicencia As New ClLicencia
    Dim frmContoleParasita As New PetSystem.FrmControleParasita
    Dim frmVacina As New PetSystem.FrmVacina
    Dim frmPelagem As New PetSystem.FrmPelagem
    Dim frmRaca As New PetSystem.FrmRaca
    Dim frmEspecie As New PetSystem.FrmEspecie
    Dim frmAnimal As New PetSystem.FrmAnimal
    Public codEvento, nomEmpresa, nomEvento As String
    Dim despesa As New ClDespesa
    Public Sub licenciaVerifica()
        ClLicencia.verificarLicencia()
    End Sub
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModParametroSistema.permissaoUsuario = "MASTER" Then
            ModPermissaoUsuario.habilitarTodasPermissaoAcesso()
            Exit Sub
        End If
        ModPermissaoUsuario.limparPermissaoAcesso()
        'carrega permissao usuario
        ModPermissaoUsuario.permissaoAcesso("usuario")
        'carrega permissao grupo
        If Not IsNothing(ModPermissaoUsuario.codGrupo) Then
            If ModPermissaoUsuario.codGrupo > 0 Then
                ModPermissaoUsuario.permissaoAcesso("grupo")
            End If
        End If
    End Sub
    Public Sub carregaPermissaoUsuario()
        '------------------------------------------------------------------Sistema
        Me.GrupoUsuarioTSMI.Enabled = ModPermissaoUsuario.t100101
        Me.UsuarioTSMI.Enabled = ModPermissaoUsuario.t100102
        Me.ControleDeAcessoTSMI.Enabled = ModPermissaoUsuario.t100103
        btnControleacesso.Enabled = ModPermissaoUsuario.t100103
        Me.ParametrosSistemaTSMI.Enabled = ModPermissaoUsuario.t1002
        btnParametroSistema.Enabled = ModPermissaoUsuario.t1002
        Me.LicencaTSMI.Enabled = ModPermissaoUsuario.t1003
        '-------------------------------------------------------------------Pessoa
        Me.PessoaTSMI.Enabled = ModPermissaoUsuario.t110101
        btnPessoa.Enabled = ModPermissaoUsuario.t110101
        Me.FuncaoFuncionarioTSMI.Enabled = ModPermissaoUsuario.t110102
        Me.CidadeTSMI.Enabled = ModPermissaoUsuario.t1102
        '-------------------------------------------------------------------Estoque
        Me.AlmoxarifadoTSMI.Enabled = ModPermissaoUsuario.t120101
        Me.SecaoTSMI.Enabled = ModPermissaoUsuario.t120102
        Me.CategoriaTSMI.Enabled = ModPermissaoUsuario.t120103
        Me.SubCategoriaTSMI.Enabled = ModPermissaoUsuario.t120104
        Me.ItemTSMI.Enabled = ModPermissaoUsuario.t120105
        BtnItem.Enabled = ModPermissaoUsuario.t120105
        Me.UnidadeTSMI.Enabled = ModPermissaoUsuario.t120106
        Me.MarcaTSMI.Enabled = ModPermissaoUsuario.t120107
        Me.RelItensTSMI.Enabled = ModPermissaoUsuario.t12010801
        Me.InventarioRapidoToolStripMenuItem.Enabled = ModPermissaoUsuario.t1202
        '---------------------------------------------------------------------Administrativo 13
        Me.TipoDespesaTSMI.Enabled = ModPermissaoUsuario.t130101
        Me.DespesaTSMI.Enabled = ModPermissaoUsuario.t130102
        btnDespesa.Enabled = ModPermissaoUsuario.t130102
        Me.RelDespesasTSMI.Enabled = ModPermissaoUsuario.t13010301
        Me.TipoReceitaTSMI.Enabled = ModPermissaoUsuario.t130201
        Me.ReceitaTSMI.Enabled = ModPermissaoUsuario.t130202
        btnReceita.Enabled = ModPermissaoUsuario.t130202
        Me.RelReceitasTSMI.Enabled = ModPermissaoUsuario.t13020301

        '---------------------------------------------------------------------PDV 14
        Me.CadastroPdvTSMI.Enabled = ModPermissaoUsuario.t140101
        Me.PDV1TSMI.Enabled = ModPermissaoUsuario.t140102
        Me.PDV2TSMI.Enabled = ModPermissaoUsuario.t140103
        btnPdv2.Enabled = ModPermissaoUsuario.t140103
        Me.AgendaServicoTSMI.Enabled = ModPermissaoUsuario.t140201
        Me.RelComissaoAgendaServicoTSMI.Enabled = ModPermissaoUsuario.t14020201
        Me.RelVendasPorSubCategoriaTSMI.Enabled = ModPermissaoUsuario.t140301
        Me.FechamentoDeCaixaTSMI.Enabled = ModPermissaoUsuario.t140401
        Me.AberturaDeCaixaTSMI.Enabled = ModPermissaoUsuario.t140402
        '--------------------------------------------------------------------financeiro
        Me.EspecieTSMI.Enabled = ModPermissaoUsuario.t150101
        Me.BancosTSMI.Enabled = ModPermissaoUsuario.t150201
        Me.TipoParcelamentoTSMI.Enabled = ModPermissaoUsuario.t1503
        Me.TitulosAPagarTSMI.Enabled = ModPermissaoUsuario.t150401
        btnContapagar.Enabled = ModPermissaoUsuario.t150401
        Me.RelTitulosAPagarTSMI.Enabled = ModPermissaoUsuario.t15040201
        Me.TitulosReceberTSMI.Enabled = ModPermissaoUsuario.t150501
        btnContaReceber.Enabled = ModPermissaoUsuario.t150501
        Me.RelTituloReceberTSMI.Enabled = ModPermissaoUsuario.t15050201
        Me.TipoCobrançaToolStripMenuItem.Enabled = ModPermissaoUsuario.t1506
        '--------------------------------------------------------------------relatorios
        Me.RRelDespesaTSMI.Enabled = ModPermissaoUsuario.t160101
        Me.RRelVendaPorSubCategoriaTSMI.Enabled = ModPermissaoUsuario.t160201
        Me.RelVendaPorClienteToolStripMenuItem.Enabled = ModPermissaoUsuario.t160202
        Me.RRelMovimentoDeEstoqueTSMI.Enabled = ModPermissaoUsuario.t160301

        '----------------------------------------------------------------------Pets
        Me.EspecieTSMI.Enabled = ModPermissaoUsuario.t170101
        Me.RacaTSMI.Enabled = ModPermissaoUsuario.t170102
        Me.PelagemTSMI.Enabled = ModPermissaoUsuario.t170103
        Me.AnimalTSMI.Enabled = ModPermissaoUsuario.t170104
        btnAnimal.Enabled = ModPermissaoUsuario.t170104
        Me.ControleVacinaTSMI.Enabled = ModPermissaoUsuario.t1702
        Me.ControleParasitaTSMI.Enabled = ModPermissaoUsuario.t1703
        '----------------------------------------------------------------------Eventos
        Me.EventoTSMI.Enabled = ModPermissaoUsuario.t180101
        btnEvento.Enabled = ModPermissaoUsuario.t180101
        Me.ImprimirIngressoTSMI.Enabled = ModPermissaoUsuario.t180102
        Me.RelIngressoImpressoTSMI.Enabled = ModPermissaoUsuario.t180201
    End Sub
    Private Sub FrmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        For intIndex As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms.Item(intIndex) IsNot Me Then
                My.Application.OpenForms.Item(intIndex).Close()
            End If
        Next

        FrmLogin.Close()
    End Sub
    Private Sub ParametrosSistemaTSMI_Click(sender As Object, e As EventArgs) Handles ParametrosSistemaTSMI.Click
        If FrmParametroSistema.WindowState = FormWindowState.Minimized Then
            FrmParametroSistema.WindowState = FormWindowState.Normal
            FrmParametroSistema.Activate()
        Else
            FrmParametroSistema.Show()
        End If
    End Sub
    Private Sub LicençaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicencaTSMI.Click
        If FrmLicencia.WindowState = FormWindowState.Minimized Then
            FrmLicencia.WindowState = FormWindowState.Normal
            FrmLicencia.Activate()
        Else
            FrmLicencia.Show()
        End If

    End Sub
    Private Sub UsuárioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuarioTSMI.Click
        If FrmUsuario.WindowState = FormWindowState.Minimized Then
            FrmUsuario.WindowState = FormWindowState.Normal
            FrmUsuario.Activate()
        Else
            FrmUsuario.Show()
        End If
    End Sub
    Private Sub GrupoUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrupoUsuarioTSMI.Click
        If FrmGrupoUsuario.WindowState = FormWindowState.Minimized Then
            FrmGrupoUsuario.WindowState = FormWindowState.Normal
            FrmGrupoUsuario.Activate()
        Else
            FrmGrupoUsuario.Show()
        End If
    End Sub
    Private Sub CidadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CidadeTSMI.Click
        If FrmCidade.WindowState = FormWindowState.Minimized Then
            FrmCidade.WindowState = FormWindowState.Normal
            FrmCidade.Activate()
        Else
            FrmCidade.Show()
        End If
    End Sub
    Private Sub VendasToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles PdvTSMI2.MouseEnter, BarToolStripMenuItem.MouseEnter
        PdvTSMI2.ForeColor = BackColor
    End Sub
    Private Sub BarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarToolStripMenuItem.Click
        Exit Sub
        licenciaVerifica()
        Try
            If Today > ClLicencia.dataVectoLicencia Then
                MsgBox("LICENCIA VENCIDA " & ClLicencia.dataVectoLicencia & "ENTRE EM CONTATO COM ADMINISTRADOR PARA RENOVAR A LICENCIA")
                Exit Sub
            End If
            If FrmEscolherEvento.WindowState = FormWindowState.Minimized Then
                FrmEscolherEvento.WindowState = FormWindowState.Normal
                FrmEscolherEvento.Activate()
            Else
                FrmEscolherEvento.ShowDialog()
            End If
            If codEvento = "" Then
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PDV1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PDV1TSMI.Click
        licenciaVerifica()
        Try
            If Today > ClLicencia.dataVectoLicencia Then
                MsgBox("LICENCIA VENCIDA " & ClLicencia.dataVectoLicencia & "ENTRE EM CONTATO COM ADMINISTRADOR PARA RENOVAR A LICENCIA")
                Exit Sub
            End If
            If FrmEscolherEvento.WindowState = FormWindowState.Minimized Then
                FrmEscolherEvento.WindowState = FormWindowState.Normal
                FrmEscolherEvento.Activate()
            Else
                FrmEscolherEvento.ShowDialog()
            End If
            If codEvento = "" Then
                Exit Sub
            End If
            If FrmPdv1.WindowState = FormWindowState.Minimized Then
                FrmPdv1.WindowState = FormWindowState.Normal
                FrmPdv1.Activate()
            Else
                FrmPdv1.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PDV2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PDV2TSMI.Click
        licenciaVerifica()
        Try
            If Today > ClLicencia.dataVectoLicencia Then
                MsgBox("LICENCIA VENCIDA " & ClLicencia.dataVectoLicencia & "ENTRE EM CONTATO COM ADMINISTRADOR PARA RENOVAR A LICENCIA")
                Exit Sub
            End If
            If FrmEscolherEvento.WindowState = FormWindowState.Minimized Then
                FrmEscolherEvento.WindowState = FormWindowState.Normal
                FrmEscolherEvento.Activate()
            Else
                FrmEscolherEvento.ShowDialog()
            End If
            If codEvento = "" Then
                Exit Sub
            End If
            If FrmPDV2.WindowState = FormWindowState.Minimized Then
                FrmPDV2.WindowState = FormWindowState.Normal
                FrmPDV2.Activate()
            Else
                FrmPDV2.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub AlmoxarifadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlmoxarifadoTSMI.Click
        If FrmAlmoxarifado.WindowState = FormWindowState.Minimized Then
            FrmAlmoxarifado.WindowState = FormWindowState.Normal
            FrmAlmoxarifado.Activate()
        Else
            FrmAlmoxarifado.ShowDialog()
        End If

    End Sub
    Private Sub SeçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecaoTSMI.Click
        If FrmSecao.WindowState = FormWindowState.Minimized Then
            FrmSecao.WindowState = FormWindowState.Normal
            FrmSecao.Activate()
        Else
            FrmSecao.Show()
        End If
    End Sub
    Private Sub InventarioRapidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioRapidoToolStripMenuItem.Click
        If FrmInventarioRapido.WindowState = FormWindowState.Minimized Then
            FrmInventarioRapido.WindowState = FormWindowState.Normal
            FrmInventarioRapido.Activate()
        Else
            FrmInventarioRapido.Show()
        End If
    End Sub
    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaTSMI.Click
        If FrmCategoria.WindowState = FormWindowState.Minimized Then
            FrmCategoria.WindowState = FormWindowState.Normal
            FrmCategoria.Activate()
        Else
            FrmCategoria.Show()
        End If
    End Sub
    Private Sub UnidadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadeTSMI.Click
        If FrmUnidade.WindowState = FormWindowState.Minimized Then
            FrmUnidade.WindowState = FormWindowState.Normal
            FrmUnidade.Activate()
        Else
            FrmUnidade.ShowDialog()
        End If
    End Sub
    Private Sub MarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcaTSMI.Click
        If FrmMarca.WindowState = FormWindowState.Minimized Then
            FrmMarca.WindowState = FormWindowState.Normal
            FrmMarca.Activate()
        Else
            FrmMarca.ShowDialog()
        End If
    End Sub
    Private Sub ItemToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ItemTSMI.Click
        If FrmItem.WindowState = FormWindowState.Minimized Then
            FrmItem.WindowState = FormWindowState.Normal
            FrmItem.Activate()
        Else
            FrmItem.Show()
        End If

    End Sub

    Private Sub DespesaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DespesaTSMI.Click
        If FrmDespesas.WindowState = FormWindowState.Minimized Then
            FrmDespesas.WindowState = FormWindowState.Normal
            FrmDespesas.Activate()
        Else
            FrmDespesas.Show()
        End If
    End Sub
    Private Sub TipoDespesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDespesaTSMI.Click
        If FrmTipoDespesa.WindowState = FormWindowState.Minimized Then
            FrmTipoDespesa.WindowState = FormWindowState.Normal
            FrmTipoDespesa.Activate()
        Else
            FrmTipoDespesa.Show()
        End If
    End Sub
    Private Sub ReceitaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReceitaTSMI.Click
        If FrmReceita.WindowState = FormWindowState.Minimized Then
            FrmReceita.WindowState = FormWindowState.Normal
            FrmReceita.Activate()
        Else
            FrmReceita.Show()
        End If
    End Sub
    Private Sub RelReceitasTSMI_Click(sender As Object, e As EventArgs) Handles RelReceitasTSMI.Click

    End Sub
    Private Sub TipoReceitaTSMI_Click(sender As Object, e As EventArgs) Handles TipoReceitaTSMI.Click
        If FrmTipoReceita.WindowState = FormWindowState.Minimized Then
            FrmTipoReceita.WindowState = FormWindowState.Normal
            FrmTipoReceita.Activate()
        Else
            FrmTipoReceita.Show()
        End If
    End Sub
    Private Sub BancoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BancosTSMI.Click
        If FrmBanco.WindowState = FormWindowState.Minimized Then
            FrmBanco.WindowState = FormWindowState.Normal
            FrmBanco.Activate()
        Else
            FrmBanco.Show()
        End If
    End Sub
    Private Sub RelItensToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelItensTSMI.Click
        If FrmRelItem.WindowState = FormWindowState.Minimized Then
            FrmRelItem.WindowState = FormWindowState.Normal
            FrmRelItem.Activate()
        Else
            FrmRelItem.Show()
        End If
    End Sub

    Private Sub RelDespesasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelDespesasTSMI.Click
        If FrmFiltroRelDespesa.WindowState = FormWindowState.Minimized Then
            FrmFiltroRelDespesa.WindowState = FormWindowState.Normal
            FrmFiltroRelDespesa.Activate()
        Else
            FrmFiltroRelDespesa.Show()
        End If
    End Sub

    Private Sub RelComissãoAgendaServiçoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If FrmRelComissaoServ.WindowState = FormWindowState.Minimized Then
            FrmRelComissaoServ.WindowState = FormWindowState.Normal
            FrmRelComissaoServ.Activate()
        Else
            FrmRelComissaoServ.Show()
        End If
    End Sub


    Private Sub RelComissãoAgendaServiçoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RelComissaoAgendaServicoTSMI.Click
        If FrmFiltroRelComissaoAgendaServ.WindowState = FormWindowState.Minimized Then
            FrmFiltroRelComissaoAgendaServ.WindowState = FormWindowState.Normal
            FrmFiltroRelComissaoAgendaServ.Activate()
        Else
            FrmFiltroRelComissaoAgendaServ.Show()
        End If
    End Sub

    Private Sub AgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendaServicoTSMI.Click
        If FrmAgendaServico.WindowState = FormWindowState.Minimized Then
            FrmAgendaServico.WindowState = FormWindowState.Normal
            FrmAgendaServico.Activate()
        Else
            FrmAgendaServico.Show()
        End If
    End Sub

    Private Sub VendaPorSubCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RRelVendaPorSubCategoriaTSMI.Click
        If FrmFiltroVendaSubCategoria.WindowState = FormWindowState.Minimized Then
            FrmFiltroVendaSubCategoria.WindowState = FormWindowState.Normal
            FrmFiltroVendaSubCategoria.Activate()
        Else
            FrmFiltroVendaSubCategoria.Show()
        End If
    End Sub

    Private Sub RelDespesaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RRelDespesaTSMI.Click
        If FrmFiltroRelDespesa.WindowState = FormWindowState.Minimized Then
            FrmFiltroRelDespesa.WindowState = FormWindowState.Normal
            FrmFiltroRelDespesa.Activate()
        Else
            FrmFiltroRelDespesa.Show()
        End If
    End Sub

    Private Sub RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RRelMovimentoDeEstoqueTSMI.Click
        If FrmFiltroEntradaSaidaEstoque.WindowState = FormWindowState.Minimized Then
            FrmFiltroEntradaSaidaEstoque.WindowState = FormWindowState.Normal
            FrmFiltroEntradaSaidaEstoque.Activate()
        Else
            FrmFiltroEntradaSaidaEstoque.Show()
        End If
    End Sub


    Private Sub ParcelamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoParcelamentoTSMI.Click
        If FrmTipoParcelamento.WindowState = FormWindowState.Minimized Then
            FrmTipoParcelamento.WindowState = FormWindowState.Normal
            FrmTipoParcelamento.Activate()
        Else
            FrmTipoParcelamento.Show()
        End If
    End Sub

    Private Sub SubCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubCategoriaTSMI.Click
        If FrmSubCategoria.WindowState = FormWindowState.Minimized Then
            FrmSubCategoria.WindowState = FormWindowState.Normal
            FrmSubCategoria.Activate()
        Else
            FrmSubCategoria.Show()
        End If
    End Sub
    '******************************************************************************************************************************
    'Evento
    '******************************************************************************************************************************
    Private Sub RelIngressoImpressoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelIngressoImpressoTSMI.Click
        If FrmRelIngressosImpresso.WindowState = FormWindowState.Minimized Then
            FrmRelIngressosImpresso.WindowState = FormWindowState.Normal
            FrmRelIngressosImpresso.Activate()
        Else
            FrmRelIngressosImpresso.Show()
        End If
    End Sub
    Private Sub EventoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EventoTSMI.Click
        If FrmEvento.WindowState = FormWindowState.Minimized Then
            FrmEvento.WindowState = FormWindowState.Normal
            FrmEvento.Activate()
        Else
            FrmEvento.Show()
        End If
    End Sub
    Private Sub ImprimirIngressoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImprimirIngressoTSMI.Click
        imprimirIngresso()
    End Sub
    Public Sub imprimirIngresso()
        Try
            licenciaVerifica()
            If Today > ClLicencia.dataVectoLicencia Then
                MsgBox("LICENCIA VENCIDA " & ClLicencia.dataVectoLicencia & " PRECISA ENTRAR EM CONTATO COM ADMINISTRADOR PARA RENOVAR A LICENCIA")
                Exit Sub
            End If
            If FrmImprimirIngressos.WindowState = FormWindowState.Minimized Then
                FrmImprimirIngressos.WindowState = FormWindowState.Normal
                FrmImprimirIngressos.Activate()
            Else
                FrmImprimirIngressos.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub
    '******************************************************************************************************************************
    'PEts
    '******************************************************************************************************************************
    Private Sub EspécieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspecieTSMI.Click
        If frmEspecie.WindowState = FormWindowState.Minimized Then
            frmEspecie.WindowState = FormWindowState.Normal
            frmEspecie.Activate()
        Else
            frmEspecie.ShowDialog()
        End If
    End Sub
    Private Sub PelagemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelagemTSMI.Click
        If frmPelagem.WindowState = FormWindowState.Minimized Then
            frmPelagem.WindowState = FormWindowState.Normal
            frmPelagem.Activate()
        Else
            frmPelagem.ShowDialog()
        End If
    End Sub
    Private Sub AnimalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnimalTSMI.Click
        If frmAnimal.WindowState = FormWindowState.Minimized Then
            frmAnimal.WindowState = FormWindowState.Normal
            frmAnimal.Activate()
        Else
            frmAnimal.Show()
        End If
    End Sub

    Private Sub RaçaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RacaTSMI.Click
        If frmRaca.WindowState = FormWindowState.Minimized Then
            frmRaca.WindowState = FormWindowState.Normal
            frmRaca.Activate()
        Else
            frmRaca.ShowDialog()
        End If
    End Sub
    Private Sub VacinaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ControleVacinaTSMI.Click
        If frmVacina.WindowState = FormWindowState.Minimized Then
            frmVacina.WindowState = FormWindowState.Normal
            frmVacina.Activate()
        Else
            frmVacina.ShowDialog()
        End If
    End Sub
    Private Sub ParasitaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ControleParasitaTSMI.Click
        If frmContoleParasita.WindowState = FormWindowState.Minimized Then
            frmContoleParasita.WindowState = FormWindowState.Normal
            frmContoleParasita.Activate()
        Else
            frmContoleParasita.ShowDialog()
        End If
    End Sub

    Private Sub ControleDeAcessoTSMI_Click(sender As Object, e As EventArgs) Handles ControleDeAcessoTSMI.Click
        If FrmControleAcesso.WindowState = FormWindowState.Minimized Then
            FrmControleAcesso.WindowState = FormWindowState.Normal
            FrmControleAcesso.Activate()
        Else
            FrmControleAcesso.ShowDialog()
        End If
    End Sub
    Private Sub btnSistema_Click(sender As Object, e As EventArgs) Handles btnParametroSistema.Click
        If FrmParametroSistema.WindowState = FormWindowState.Minimized Then
            FrmParametroSistema.WindowState = FormWindowState.Normal
            FrmParametroSistema.Activate()
        Else
            FrmParametroSistema.ShowDialog()
        End If
    End Sub

    Private Sub btnPessoa_Click(sender As Object, e As EventArgs) Handles btnPessoa.Click
        If FrmPessoa.WindowState = FormWindowState.Minimized Then
            FrmPessoa.WindowState = FormWindowState.Normal
            FrmPessoa.Activate()
        Else
            FrmPessoa.Show()
        End If
    End Sub

    Private Sub BtnItem_Click(sender As Object, e As EventArgs) Handles BtnItem.Click
        If FrmItem.WindowState = FormWindowState.Minimized Then
            FrmItem.WindowState = FormWindowState.Normal
            FrmItem.Activate()
        Else
            FrmItem.Show()
        End If
    End Sub

    Private Sub btnAdministrativo_Click(sender As Object, e As EventArgs) Handles btnDespesa.Click
        If FrmDespesas.WindowState = FormWindowState.Minimized Then
            FrmDespesas.WindowState = FormWindowState.Normal
            FrmDespesas.Activate()
        Else
            FrmDespesas.Show()
        End If
    End Sub

    Private Sub btnReceita_Click(sender As Object, e As EventArgs) Handles btnReceita.Click
        If FrmReceita.WindowState = FormWindowState.Minimized Then
            FrmReceita.WindowState = FormWindowState.Normal
            FrmReceita.Activate()
        Else
            FrmReceita.Show()
        End If
    End Sub

    Private Sub btnPdv_Click(sender As Object, e As EventArgs) Handles btnPdv2.Click
        If FrmPDV2.WindowState = FormWindowState.Minimized Then
            FrmPDV2.WindowState = FormWindowState.Normal
            FrmPDV2.Activate()
        Else
            FrmPDV2.Show()
        End If
    End Sub

    Private Sub btnAnimal_Click(sender As Object, e As EventArgs) Handles btnAnimal.Click
        If frmAnimal.WindowState = FormWindowState.Minimized Then
            frmAnimal.WindowState = FormWindowState.Normal
            frmAnimal.Activate()
        Else
            frmAnimal.Show()
        End If
    End Sub

    Private Sub btnEvento_Click(sender As Object, e As EventArgs) Handles btnEvento.Click
        If FrmEvento.WindowState = FormWindowState.Minimized Then
            FrmEvento.WindowState = FormWindowState.Normal
            FrmEvento.Activate()
        Else
            FrmEvento.Show()
        End If
    End Sub

    Private Sub btnControleacesso_Click(sender As Object, e As EventArgs) Handles btnControleacesso.Click
        If FrmControleAcesso.WindowState = FormWindowState.Minimized Then
            FrmControleAcesso.WindowState = FormWindowState.Normal
            FrmControleAcesso.Activate()
        Else
            FrmControleAcesso.ShowDialog()
        End If
    End Sub

    Private Sub FunçãoFuncionárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncaoFuncionarioTSMI.Click
        If FrmFuncaoFuncionario.WindowState = FormWindowState.Minimized Then
            FrmFuncaoFuncionario.WindowState = FormWindowState.Normal
            FrmFuncaoFuncionario.Activate()
        Else
            FrmFuncaoFuncionario.ShowDialog()
        End If
    End Sub

    Private Sub PessoaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PessoaTSMI.Click
        If FrmPessoa.WindowState = FormWindowState.Minimized Then
            FrmPessoa.WindowState = FormWindowState.Normal
            FrmPessoa.Activate()
        Else
            FrmPessoa.Show()
        End If
    End Sub
    Private Sub btnFechamentocaixa_Click(sender As Object, e As EventArgs) Handles btnFechamentocaixa.Click
        If FrmFechamentoCaixaPdv.WindowState = FormWindowState.Minimized Then
            FrmFechamentoCaixaPdv.WindowState = FormWindowState.Normal
            FrmFechamentoCaixaPdv.Activate()
        Else
            FrmFechamentoCaixaPdv.Show()
        End If
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        FrmLogin.logout = 2
        If FrmLogin.WindowState = FormWindowState.Minimized Then
            FrmLogin.WindowState = FormWindowState.Normal
            FrmLogin.Activate()
        Else
            FrmLogin.ShowDialog()
        End If
        If ModParametroSistema.permissaoUsuario = "MASTER" Then
            ModPermissaoUsuario.habilitarTodasPermissaoAcesso()
            carregaPermissaoUsuario()
            Exit Sub
        End If
        'Limpar permissões do user
        ModPermissaoUsuario.limparPermissaoAcesso()
        carregaPermissaoUsuario()
        'carrega permissao usuario
        ModPermissaoUsuario.permissaoAcesso("usuario")
        'carrega permissao grupo
        If Not IsNothing(ModPermissaoUsuario.codGrupo) Then
            If ModPermissaoUsuario.codGrupo > 0 Then
                ModPermissaoUsuario.permissaoAcesso("grupo")
            End If
        End If
    End Sub
    Private Sub btntrocaUser_MouseLeave(sender As Object, e As EventArgs) Handles btnTrocaUsuario.MouseLeave
        Label1.Visible = False
    End Sub

    Private Sub btnTrocaUsuario_MouseHover(sender As Object, e As EventArgs) Handles btnTrocaUsuario.MouseHover
        Label1.Text = "Logout"
        Label1.Visible = True
    End Sub
    Private Sub btnParametro_MouseLeave(sender As Object, e As EventArgs) Handles btnParametroSistema.MouseLeave
        Label1.Visible = False
    End Sub
    Private Sub btnParametro_MouseHover(sender As Object, e As EventArgs) Handles btnParametroSistema.MouseHover
        Label1.Text = "Parametro Sistema"
        Label1.Visible = True
    End Sub
    Private Sub btnControleAcesso_MouseLeave(sender As Object, e As EventArgs) Handles btnControleacesso.MouseLeave
        Label2.Visible = False
    End Sub
    Private Sub btnControleAcesso_MouseHover(sender As Object, e As EventArgs) Handles btnControleacesso.MouseHover
        Label2.Text = "Controle Acesso"
        Label2.Visible = True
    End Sub
    Private Sub btnPessoa_MouseLeave(sender As Object, e As EventArgs) Handles btnPessoa.MouseLeave
        Label2.Visible = False
    End Sub
    Private Sub btnPessoa_MouseHover(sender As Object, e As EventArgs) Handles btnPessoa.MouseHover
        Label2.Text = "Pessoa"
        Label2.Visible = True
    End Sub
    Private Sub btnItem_MouseLeave(sender As Object, e As EventArgs) Handles BtnItem.MouseLeave
        Label3.Visible = False
    End Sub
    Private Sub btnItem_MouseHover(sender As Object, e As EventArgs) Handles BtnItem.MouseHover
        Label3.Text = "Item"
        Label3.Visible = True
    End Sub

    Private Sub btnDespesa_MouseLeave(sender As Object, e As EventArgs) Handles btnDespesa.MouseLeave
        Label3.Visible = False
    End Sub

    Private Sub btnDespesa_MouseHover(sender As Object, e As EventArgs) Handles btnDespesa.MouseHover
        Label3.Text = "Despesa"
        Label3.Visible = True
    End Sub
    Private Sub btnReceita_MouseLeave(sender As Object, e As EventArgs) Handles btnReceita.MouseLeave
        Label4.Visible = False
    End Sub

    Private Sub btnReceita_MouseHover(sender As Object, e As EventArgs) Handles btnReceita.MouseHover
        Label4.Text = "Receita"
        Label4.Visible = True
    End Sub
    Private Sub btnFechamentoCaixa_MouseLeave(sender As Object, e As EventArgs) Handles btnFechamentocaixa.MouseLeave
        Label4.Visible = False
    End Sub
    Private Sub btnFechamentoCaixa_MouseHover(sender As Object, e As EventArgs) Handles btnFechamentocaixa.MouseHover
        Label4.Text = "Fechamento Caixa"
        Label4.Visible = True
    End Sub
    Private Sub btnPdv_MouseLeave(sender As Object, e As EventArgs) Handles btnPdv2.MouseLeave
        Label5.Visible = False
    End Sub
    Private Sub btnPdv_MouseHover(sender As Object, e As EventArgs) Handles btnPdv2.MouseHover
        Label5.Text = "PDV"
        Label5.Visible = True
    End Sub
    Private Sub btnContasPagar_MouseLeave(sender As Object, e As EventArgs) Handles btnContapagar.MouseLeave
        Label5.Visible = False
    End Sub

    Private Sub btnContaPagar_MouseHover(sender As Object, e As EventArgs) Handles btnContapagar.MouseHover
        Label5.Text = "Contas a Pagar"
        Label5.Visible = True
    End Sub
    Private Sub btnContaReceber_MouseLeave(sender As Object, e As EventArgs) Handles btnContaReceber.MouseLeave
        Label6.Visible = False
    End Sub

    Private Sub btnContaReceber_MouseHover(sender As Object, e As EventArgs) Handles btnContaReceber.MouseHover
        Label6.Text = "Contas a Receber"
        Label6.Visible = True
    End Sub
    Private Sub btnAnimal_MouseLeave(sender As Object, e As EventArgs) Handles btnAnimal.MouseLeave
        Label6.Visible = False
    End Sub

    Private Sub btnAnimal_MouseHover(sender As Object, e As EventArgs) Handles btnAnimal.MouseHover
        Label6.Text = "Animal"
        Label6.Visible = True
    End Sub
    Private Sub btnEvento_MouseLeave(sender As Object, e As EventArgs) Handles btnEvento.MouseLeave
        Label7.Visible = False
    End Sub

    Private Sub btnEvento_MouseHover(sender As Object, e As EventArgs) Handles btnEvento.MouseHover
        Label7.Text = "Evento"
        Label7.Visible = True
    End Sub
    Private Sub btnDre_MouseLeave(sender As Object, e As EventArgs) Handles btnRelatorio.MouseLeave
        Label7.Visible = False
    End Sub
    Private Sub btnAgenda_MouseLeave(sender As Object, e As EventArgs) Handles btnAgenda.MouseLeave
        Label9.Visible = False
    End Sub

    Private Sub btnAgenda_MouseHover(sender As Object, e As EventArgs) Handles btnAgenda.MouseHover
        Label9.Text = "Agenda"
        Label9.Visible = True
    End Sub
    Private Sub btnCadastroEmpresa_MouseLeave(sender As Object, e As EventArgs) Handles btnCadastroEmpresa.MouseLeave
        Label9.Visible = False
    End Sub

    Private Sub btnCadastroEmpresa_MouseHover(sender As Object, e As EventArgs) Handles btnCadastroEmpresa.MouseHover
        Label9.Text = "Escolha Empresa"
        Label9.Visible = True
    End Sub
    Private Sub btnTrocaUsuario_Click(sender As Object, e As EventArgs) Handles btnTrocaUsuario.Click
        FrmLogin.logout = 2
        FrmLogin.ShowDialog()
        If ModParametroSistema.permissaoUsuario = "MASTER" Then
            ModPermissaoUsuario.habilitarTodasPermissaoAcesso()
            carregaPermissaoUsuario()
            Exit Sub
        End If
        'Limpar permissões do user
        ModPermissaoUsuario.limparPermissaoAcesso()
        carregaPermissaoUsuario()
        'carrega permissao usuario
        ModPermissaoUsuario.permissaoAcesso("usuario")
        'carrega permissao grupo
        If Not IsNothing(ModPermissaoUsuario.codGrupo) Then
            If ModPermissaoUsuario.codGrupo > 0 Then
                ModPermissaoUsuario.permissaoAcesso("grupo")
            End If
        End If
    End Sub

    Private Sub btnAgenda_Click(sender As Object, e As EventArgs) Handles btnAgenda.Click
        If FrmAgendaServico.WindowState = FormWindowState.Minimized Then
            FrmAgendaServico.WindowState = FormWindowState.Maximized
            FrmAgendaServico.Activate()
        Else
            FrmAgendaServico.Show()
        End If
    End Sub

    Private Sub btnCadastroEmpresa_Click(sender As Object, e As EventArgs) Handles btnCadastroEmpresa.Click
        If FrmEscolhaEmpresa.WindowState = FormWindowState.Minimized Then
            FrmEscolhaEmpresa.WindowState = FormWindowState.Normal
            FrmEscolhaEmpresa.Activate()
        Else
            FrmEscolhaEmpresa.Show()
        End If

    End Sub

    Private Sub RelVendaPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelVendaPorClienteToolStripMenuItem.Click
        If FrmFiltroVendaPorCliente.WindowState = FormWindowState.Minimized Then
            FrmFiltroVendaPorCliente.WindowState = FormWindowState.Normal
            FrmFiltroVendaPorCliente.Activate()
        Else
            FrmFiltroVendaPorCliente.Show()
        End If
    End Sub

    Private Sub RelVendasPorSubCategoriaTSMI_Click(sender As Object, e As EventArgs) Handles RelVendasPorSubCategoriaTSMI.Click
        If FrmFiltroVendaSubCategoria.WindowState = FormWindowState.Minimized Then
            FrmFiltroVendaSubCategoria.WindowState = FormWindowState.Normal
            FrmFiltroVendaSubCategoria.Activate()
        Else
            FrmFiltroVendaSubCategoria.Show()
        End If
    End Sub

    Private Sub CadastroPdvTSMI_Click(sender As Object, e As EventArgs) Handles CadastroPdvTSMI.Click
        If FrmPdv.WindowState = FormWindowState.Minimized Then
            FrmPdv.WindowState = FormWindowState.Normal
            FrmPdv.Activate()
        Else
            FrmPdv.Show()
        End If
    End Sub

    Private Sub AberturaDeCaixaTSMI_Click(sender As Object, e As EventArgs) Handles AberturaDeCaixaTSMI.Click
        If FrmAberturaCaixa.WindowState = FormWindowState.Minimized Then
            FrmAberturaCaixa.WindowState = FormWindowState.Normal
            FrmAberturaCaixa.Activate()
        Else
            FrmAberturaCaixa.Show()
        End If
    End Sub

    Private Sub TipoCobrançaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoCobrançaToolStripMenuItem.Click
        If FrmTipoCobranca.WindowState = FormWindowState.Minimized Then
            FrmTipoCobranca.WindowState = FormWindowState.Normal
            FrmTipoCobranca.Activate()
        Else
            FrmTipoCobranca.Show()
        End If
    End Sub

    Private Sub EspecíeCaixaTSMI_Click(sender As Object, e As EventArgs) Handles EspecíeCaixaTSMI.Click
        If FrmEspecieCaixa.WindowState = FormWindowState.Minimized Then
            FrmEspecieCaixa.WindowState = FormWindowState.Normal
            FrmEspecieCaixa.Activate()
        Else
            FrmEspecieCaixa.Show()
        End If
    End Sub

    Private Sub TitulosReceberTSMI_Click(sender As Object, e As EventArgs) Handles TitulosReceberTSMI.Click
        If FrmTituloReceber.WindowState = FormWindowState.Minimized Then
            FrmTituloReceber.WindowState = FormWindowState.Normal
            FrmTituloReceber.Activate()
        Else
            FrmTituloReceber.Show()
        End If
    End Sub

    Private Sub btnContaReceber_Click(sender As Object, e As EventArgs) Handles btnContaReceber.Click
        If FrmTituloReceber.WindowState = FormWindowState.Minimized Then
            FrmTituloReceber.WindowState = FormWindowState.Normal
            FrmTituloReceber.Activate()
        Else
            FrmTituloReceber.Show()
        End If
    End Sub

    Private Sub btnDre_MouseHover(sender As Object, e As EventArgs) Handles btnRelatorio.MouseHover
        Label7.Text = "DRE"
        Label7.Visible = True
    End Sub
    Public Sub ModeloParaImprimirRelatorio(e As Printing.PrintPageEventArgs, codEvento As String, nomEvento As String)

        Dim reportFont2 As Font = New Drawing.Font("Time New Roman", 8)
        Dim reportFont10 As Font = New Drawing.Font("Time New Roman", 10)
        Dim reportFont12 As Font = New Drawing.Font("Time New Roman", 12)
        '   despesa.cod_evento = codEvento
        Dim tabela As DataTable
        Dim dsDespesa As New DataSet
        '   dsDespesa = despesa.ConsultaRelDespesa()

        tabela = dsDespesa.Tables(0)
        Dim Row As DataRow
        Dim x As Integer = 0
        If tabela.Rows.Count > 0 Then

            e.Graphics.DrawString("RESUMO DESPESA ", reportFont12, Brushes.Black, 0, x)
            x = x + 20

            x = 40
            Dim nome As String = ""
            Dim qtd_pessoa, qtd_total, val_pessoa, val_total As Double
            qtd_pessoa = 0
            qtd_total = 0
            val_pessoa = 0
            val_total = 0
            For Each Row In dsDespesa.Tables(0).Rows

                If x = 40 Then
                    e.Graphics.DrawString("DESPESA", reportFont2, Brushes.Black, 0, x)
                    e.Graphics.DrawString("VALOR", reportFont2, Brushes.Black, 230, x)
                    x = x + 15
                End If

                If nome <> Row.Item(2) Then
                    If val_pessoa <> 0 Then
                        x = x + 20
                        e.Graphics.DrawString("TOTAL:", reportFont10, Brushes.Black, 0, x)
                        e.Graphics.DrawString(val_pessoa, reportFont10, Brushes.Black, 250, x)
                        val_pessoa = 0
                    End If
                    x = x + 20
                    e.Graphics.DrawString(Row.Item(2), reportFont12, Brushes.Black, 90, x)
                    nome = Row.Item(2)
                End If


                x = x + 20
                e.Graphics.DrawString(Row.Item(0), reportFont2, Brushes.Black, 0, x)
                e.Graphics.DrawString(Row.Item(3), reportFont2, Brushes.Black, 250, x)
                val_pessoa = val_pessoa + Row.Item(3)
                val_total = val_total + Row.Item(3)

            Next
            x = x + 15
            e.Graphics.DrawString("TOTAL:", reportFont10, Brushes.Black, 0, x)
            e.Graphics.DrawString(val_pessoa, reportFont10, Brushes.Black, 250, x)

            x = x + 40
            e.Graphics.DrawString("TOTAL GERAL:", reportFont10, Brushes.Black, 0, x)
            e.Graphics.DrawString(val_total, reportFont10, Brushes.Black, 250, x)
        End If
    End Sub
End Class