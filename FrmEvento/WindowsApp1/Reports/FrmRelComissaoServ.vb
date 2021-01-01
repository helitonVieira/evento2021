Public Class FrmRelComissaoServ
    Dim relAgenda As New ClRelAgendaServico
    Dim tabRel As New DataTable
    Dim dsRel As New DataSet
    Public dtaInicio, dtaFinal As String
    Public perComissao As Double
    Public codFuncionario, codCliente, codEmpresa1 As Integer
    Private Sub FrmRelComissaoServico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            dsRel = relAgenda.ConsultarComissao(dtaInicio, dtaFinal, Replace(Replace(perComissao, ".", ""), ",", "."), codFuncionario, codCliente)
            tabRel = dsRel.Tables(0)
            If tabRel Is Nothing Then
                MsgBox("Não existe dados para gerar o relatório!")
                Exit Sub
            End If
            Dim x As Integer = 0
            Dim linhas = New List(Of ClRelAgendaServico)()
            For index = 0 To tabRel.Rows.Count - 1
                linhas.Add(New ClRelAgendaServico(tabRel.Rows(x).Item("seq_agenda"),
                tabRel.Rows(x).Item("cod_pessoa_cliente"),
                tabRel.Rows(x).Item("nom_pessoa_cliente"),
                tabRel.Rows(x).Item("cod_pessoa_funcionario"),
                tabRel.Rows(x).Item("nom_pessoa_funcionario"),
                tabRel.Rows(x).Item("dta_agenda"),
                tabRel.Rows(x).Item("hra_agenda"),
                tabRel.Rows(x).Item("min_agenda"),
                tabRel.Rows(x).Item("val_servico"),
                 tabRel.Rows(x).Item("des_observacao"),
                tabRel.Rows(x).Item("ind_executado"),
                 tabRel.Rows(x).Item("val_comissao")))
                x = x + 1
            Next
            Dim empresa As String = ModParametroSistema.nom_empresa
            Dim dSource As New Microsoft.Reporting.WinForms.ReportDataSource("dsRel", linhas)
            '  Me.ReportViewer1.LocalReport.ReportPath = "c:\evento\Relatorio\RelComissaoAgendaServico.rdlc"
            Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("codEmpresa", ModParametroSistema.nom_fantasia))
            Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("perComissao", perComissao))
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(dSource)
            dSource.Value = linhas

            Me.ReportViewer1.LocalReport.Refresh()
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
        End Try
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class
