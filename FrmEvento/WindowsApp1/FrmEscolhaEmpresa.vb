Public Class FrmEscolhaEmpresa
    Dim conectar As New Controles.ConexaoSQL
    Dim ds As New DataSet
    Dim empresa As New ClEmpresa
    Private Sub FrmEscolhaEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim tabela As DataTable
            ds = empresa.ConsultarEmpresaFantasia()
            tabela = ds.Tables(0)

            If tabela.Rows.Count > 1 Then
                Dgv.DataSource = Nothing
                Dgv.DataSource = ds.Tables(0)
            Else
                ModParametroSistema.cod_empresa = ds.Tables(0).Rows(0)("cod_empresa")
                ModParametroSistema.nom_fantasia = ds.Tables(0).Rows(0)("nom_fantasia")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Dgv_doubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        Try
            ModParametroSistema.cod_empresa = Dgv.CurrentRow.Cells(0).Value
            ModParametroSistema.nom_fantasia = Dgv.CurrentRow.Cells(1).Value
        Catch ex As Exception
            Me.Close()
            Exit Sub
        End Try
        Me.Close()
    End Sub
End Class