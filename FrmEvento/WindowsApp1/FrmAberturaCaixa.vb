Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmAberturaCaixa
    Dim conectar As New ConexaoSQL
    Dim ds As New DataSet
    Dim fechaCaixa As New ClFechamentoCaixaPdv
    Dim geral As New ClGeral
    Private Sub FrmAberturaCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t140402 = False Then
                MsgBox("Usuário sem permissão para Abertura de Caixa!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
            BtnSalvar.Enabled = ModPermissaoUsuario.t1404021
            ' BtnExcluir.Enabled = ModPermissaoUsuario.t1404022
        End If
        limpar()
    End Sub
    Private Sub limpar()
        TxbCodOperador.Text = ""
        TxbCodPdv.Text = ""
        txbNomOperador.Text = ""
        TxbDesPdv.Text = ""
        TxbSaldo.Text = "0,00"
    End Sub
    Private Sub BtnPdv_Click(sender As Object, e As EventArgs) Handles BtnPdv.Click
        FrmPesquisa.tabela = "tab_pdv"
        FrmPesquisa.ShowDialog()
        TxbCodPdv.Text = ModVariavelGlobal.pesquisaCodigo
        TxbDesPdv.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnOperador_Click(sender As Object, e As EventArgs) Handles BtnOperador.Click
        FrmPesquisa.tabela = "tab_operador"
        FrmPesquisa.ShowDialog()
        TxbCodOperador.Text = ModVariavelGlobal.pesquisaCodigo
        txbNomOperador.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        limpar()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        If TxbCodPdv.Text = "" Then
            MsgBox("Informe o PDV!", MsgBoxStyle.Information, "Informação")
            TxbCodPdv.Select()
            Exit Sub
        End If

        If TxbCodOperador.Text = "" Then
            MsgBox("Informe o Operador!", MsgBoxStyle.Information, "Informação")
            TxbCodOperador.Select()
            Exit Sub
        End If
        Try
            Dim aberto As Integer = geral.sqlBuscaDescricao("coalesce(count(num_fechamento),0) ", "tab_fechamento_caixa_pdv", "dta_fechamento = 'today' and ind_status = 'A' and cod_pdv = " & TxbCodPdv.Text & "")
            If aberto > 0 Then
                MsgBox("Já existe um caixa aberto para este pdv antes de abrir um novo deve fechar o caixa que esta em aberto!", MsgBoxStyle.Information, "Informação")
                Exit Sub
            End If
            fechaCaixa.cod_pdv = TxbCodPdv.Text
            fechaCaixa.cod_operador = TxbCodOperador.Text
            fechaCaixa.dta_fechamento = Today.ToShortDateString
            fechaCaixa.num_fechamento = geral.sqlBuscaDescricao("coalesce(max(num_fechamento),0)+1", "tab_fechamento_caixa_pdv", "dta_fechamento = 'today' and cod_pdv = " & TxbCodPdv.Text & " and  0 ", 0)
            fechaCaixa.hra_abertura = Now.ToShortTimeString
            fechaCaixa.nom_operador = txbNomOperador.Text
            fechaCaixa.val_troco_inicial = TxbSaldo.Text
            fechaCaixa.Cadastrar()
            If ModParametroSistema.erro Then
                ModParametroSistema.erro = False
                Exit Sub
            End If
            MsgBox("Caixa Aberto com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            limpar()
        Catch ex As Exception

        End Try

    End Sub
End Class
