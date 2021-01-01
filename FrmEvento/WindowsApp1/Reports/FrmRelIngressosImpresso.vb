Public Class FrmRelIngressosImpresso

    Dim ingresso As New ClRelIngressoImpresso
        Dim tabRel As New DataTable
        Dim dsRel As New DataSet
        Dim codEvento As Integer

    Private Sub FrmRelIngressoImpresso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmPesquisa.tabela = "tab_evento"
        FrmPesquisa.ShowDialog()
        codEvento = ModVariavelGlobal.pesquisaCodigo
        ModVariavelGlobal.pesquisaCodigo = ""
        Try
            dsRel = ingresso.ConsultarRel(codEvento)
            tabRel = dsRel.Tables(0)
            If tabRel Is Nothing Then
                MsgBox("Não existe dados para gerar o relatório!")
                Exit Sub
            End If
            Dim x As Integer = 0
            Dim linhas = New List(Of ClRelIngressoImpresso)()
            For index = 0 To tabRel.Rows.Count - 1
                linhas.Add(New ClRelIngressoImpresso(tabRel.Rows(x).Item("cod_evento"),
                tabRel.Rows(x).Item("nom_evento"),
                tabRel.Rows(x).Item("dta_evento"),
                tabRel.Rows(x).Item("ind_aberto"),
                tabRel.Rows(x).Item("des_ingresso"),
                tabRel.Rows(x).Item("des_lote"),
                tabRel.Rows(x).Item("val_entrada"),
                tabRel.Rows(x).Item("val_total_impresso"),
                tabRel.Rows(x).Item("qtd_impressa"),
                tabRel.Rows(x).Item("cod_pessoa"),
                tabRel.Rows(x).Item("nom_pessoa"),
                tabRel.Rows(x).Item("qtd_entregue"),
                tabRel.Rows(x).Item("qtd_devolvida"),
                tabRel.Rows(x).Item("qtd_total_pessoa"),
                tabRel.Rows(x).Item("val_total_pessoa"),
                tabRel.Rows(x).Item("des_observacao"),
                tabRel.Rows(x).Item("dta_entrega")))
                x = x + 1
            Next
            Dim empresa As String = ModParametroSistema.nom_empresa
            Dim dSource As New Microsoft.Reporting.WinForms.ReportDataSource("dsRel", linhas)
            ' Me.ReportViewer1.LocalReport.ReportPath = "RelIngressoImpresso.rdlc"
            Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("codEmpresa", ModParametroSistema.nom_fantasia))
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(dSource)
            dSource.Value = linhas

            Me.ReportViewer1.LocalReport.Refresh()
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class
