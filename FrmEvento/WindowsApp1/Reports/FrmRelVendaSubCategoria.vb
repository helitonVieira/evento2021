Public Class FrmRelVendaSubCategoria
    Dim subCategoria As New ClRelSubCategoria
    Dim tabRel As New DataTable
    Dim dsRel As New DataSet
    Dim codEvento As Integer
    Public dtaInicio, dtaFinal As String
    Public codEmpresa, codSubcategoria, codCategoria, codItem, codEmpresa1 As Integer

    Private Sub FrmRelSubCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            dsRel = subCategoria.ConsultarRel(codEmpresa, codSubcategoria, codCategoria, codItem, dtaInicio, dtaFinal)
            tabRel = dsRel.Tables(0)
            If tabRel Is Nothing Then
                MsgBox("Não existe dados para gerar o relatório!")
                Exit Sub
            End If
            Dim x As Integer = 0
            Dim linhas = New List(Of ClRelSubCategoria)()
            For index = 0 To tabRel.Rows.Count - 1
                linhas.Add(New ClRelSubCategoria(tabRel.Rows(x).Item("cod_subcategoria"),
                tabRel.Rows(x).Item("des_subcategoria"),
                tabRel.Rows(x).Item("cod_categoria"),
                tabRel.Rows(x).Item("des_categoria"),
                tabRel.Rows(x).Item("cod_item"),
                tabRel.Rows(x).Item("des_item"),
                tabRel.Rows(x).Item("val_unitario"),
                tabRel.Rows(x).Item("qtd_venda"),
                tabRel.Rows(x).Item("val_venda"),
                tabRel.Rows(x).Item("val_acrescimo"),
                tabRel.Rows(x).Item("val_desconto"),
                tabRel.Rows(x).Item("val_total")))
                x = x + 1
            Next
            Dim empresa As String = ModParametroSistema.nom_empresa
            Dim dSource As New Microsoft.Reporting.WinForms.ReportDataSource("dsRel", linhas)
            ' Me.ReportViewer1.LocalReport.ReportPath = "RelVendaSubCategoria.rdlc"
            Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("codEmpresa", ModParametroSistema.nom_fantasia))
            Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("dtaInicio", dtaInicio))
            Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("dtaFinal", dtaFinal))
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(dSource)
            dSource.Value = linhas

            Me.ReportViewer1.LocalReport.Refresh()
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
        End Try
    End Sub
End Class
