Public Class FrmRelEntradaSaidaEstoque
    Dim clRel As New ClRelEntradaSaidaEstoque
    Dim tabRel As New DataTable
    Dim dsRel As New DataSet
    Dim codEvento As Integer
    Public dtaInicio, dtaFinal As String
    Public codEmpresa, codSubcategoria, codCategoria, codItem, codEmpresa1 As Integer
    Private Sub FrmRelSubCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            dsRel = clRel.ConsultarRel(dtaInicio, dtaFinal, codEmpresa1, codItem, codSubcategoria, codCategoria)
            tabRel = dsRel.Tables(0)
            If tabRel Is Nothing Then
                MsgBox("Não existe dados para gerar o relatório!")
                Exit Sub
            End If
            Dim x As Integer = 0
            Dim linhas = New List(Of ClRelEntradaSaidaEstoque)()
            For index = 0 To tabRel.Rows.Count - 1
                linhas.Add(New ClRelEntradaSaidaEstoque(tabRel.Rows(x).Item("cod_item"),
            tabRel.Rows(x).Item("des_item"),
            tabRel.Rows(x).Item("cod_subcategoria"),
            tabRel.Rows(x).Item("des_subcategoria"),
            tabRel.Rows(x).Item("cod_categoria"),
            tabRel.Rows(x).Item("des_categoria"),
            tabRel.Rows(x).Item("qtd_entrada"),
            tabRel.Rows(x).Item("qtd_vendida"),
            tabRel.Rows(x).Item("qtd_devolucao"),
            tabRel.Rows(x).Item("qtd_perda_roubo_consumo"),
            tabRel.Rows(x).Item("qtd_final"),
            tabRel.Rows(x).Item("val_entrada"),
            tabRel.Rows(x).Item("val_vendida"),
            tabRel.Rows(x).Item("val_devolucao"),
            tabRel.Rows(x).Item("val_perda_roubo_consumo"),
            tabRel.Rows(x).Item("val_final")))
                x = x + 1
            Next
            Dim empresa As String = ModParametroSistema.nom_empresa
            Dim dSource As New Microsoft.Reporting.WinForms.ReportDataSource("dsRel", linhas)
            ' Me.ReportViewer1.LocalReport.ReportPath = "D:\source\trunk\FrmEvento\WindowsApp1\Reports\RelEntradaSaidaEstoque.rdlc"
            Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("codEmpresa", ModParametroSistema.nom_fantasia))
            Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("periodo", "Peridodo de: " & dtaInicio & " ate " & dtaFinal))
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(dSource)
            dSource.Value = linhas

            Me.ReportViewer1.LocalReport.Refresh()
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
        End Try
    End Sub
End Class
