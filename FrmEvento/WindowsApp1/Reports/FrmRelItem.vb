Public Class FrmRelItem
    Dim clItem As New ClItem
    Private Sub FrmRelItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t12010801 = False Then
                MsgBox("Usuário sem permissão para acessar o Relatório!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
        End If
        'TODO: esta linha de código carrega dados na tabela 'DataSet3.tab_item'. Você pode movê-la ou removê-la conforme necessário.
        'Me.tab_itemTableAdapter.Fill(Me.DataSet3.tab_item)
        Me.ReportViewer1.LocalReport.ReportPath = "RelItem.rdlc"
        Me.ReportViewer1.RefreshReport()
        ' Me.ReportViewer1.RefreshReport()

    End Sub

End Class
