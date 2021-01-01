Public Class FrmRelDespesa
    Dim despesa As New ClRelDespesa
    Dim tabRel As New DataTable
    Dim dsRel As New DataSet
    Dim codEvento As Integer
    Public dtaInicio, dtaFinal As String
    Public codEmpresa1, codTipoDespesa, codPessoa As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        geraRel()
    End Sub

    Private Sub FrmRelDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        geraRel()
    End Sub
    Private Sub geraRel()

        Try
            dsRel = despesa.ConsultarRel(dtaInicio, dtaFinal, codEmpresa1,
                                 codTipoDespesa, codPessoa)
            tabRel = dsRel.Tables(0)
            If tabRel Is Nothing Then
                MsgBox("Não existe dados para gerar o relatório!")
                Exit Sub
            End If
            Dim x As Integer = 0
            Dim dtaLiquidacao As String
            Dim linhas = New List(Of ClRelDespesa)()
            For index = 0 To tabRel.Rows.Count - 1
                If IsDBNull(tabRel.Rows(x).Item("dta_liquidacao")) = True Then
                    dtaLiquidacao = ""
                Else
                    dtaLiquidacao = tabRel.Rows(x).Item("dta_liquidacao")
                End If
                linhas.Add(New ClRelDespesa(tabRel.Rows(x).Item("seq_despesa"),
              tabRel.Rows(x).Item("num_documento"),
              tabRel.Rows(x).Item("dta_despesa"),
              dtaLiquidacao,
              tabRel.Rows(x).Item("cod_pessoa"),
              tabRel.Rows(x).Item("nom_pessoa"),
              tabRel.Rows(x).Item("cod_tipo_despesa"),
              tabRel.Rows(x).Item("des_tipo_despesa"),
              tabRel.Rows(x).Item("val_despesa"),
              tabRel.Rows(x).Item("des_observacao")))
                x = x + 1
            Next
            Dim empresa As String = ModParametroSistema.nom_empresa
            Dim dSource As New Microsoft.Reporting.WinForms.ReportDataSource("dsRel", linhas)
            'Me.ReportViewer1.LocalReport.ReportPath = "RelDespesa.rdlc"
            Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("codEmpresa", ModParametroSistema.nom_fantasia))
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(dSource)
            dSource.Value = linhas
            Me.ReportViewer1.LocalReport.Refresh()
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class

