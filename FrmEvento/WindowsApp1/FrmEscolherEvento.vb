Public Class FrmEscolherEvento
    Dim conectar As New ConexaoSQL
    Dim ds As New DataSet
    Dim evento As New ClEvento
    Dim principal As New FrmPrincipal
    Private Sub FrmEscolherEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim tabela As DataTable
            ds = evento.ConsultarEventoCodNom()
            tabela = ds.Tables(0)

            If tabela.Rows.Count > 0 Then
                DgvEvento.DataSource = ds.Tables(0)
                formatarGrid()
            Else
                MsgBox("Para efetuar vendas devera cadastrar um evento")
                Me.Close()
                FrmEvento.ShowDialog()
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub formatarGrid()
        With DgvEvento
            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Nome1"

            .Columns(0).Width = 70
            .Columns(1).Width = 210

        End With
    End Sub

    Private Sub DgvEvento_DoubleClick(sender As Object, e As EventArgs) Handles DgvEvento.DoubleClick
        Try
            FrmPrincipal.codEvento = DgvEvento.CurrentRow.Cells(0).Value
            FrmPdv1.LbCodEvento.Text = DgvEvento.CurrentRow.Cells(0).Value

            Dim nome1, nome2, nome3 As String
            nome1 = DgvEvento.CurrentRow.Cells(1).Value
            nome2 = DgvEvento.CurrentRow.Cells(2).Value
            nome3 = DgvEvento.CurrentRow.Cells(3).Value
            If nome1 = "Null" Then
                nome1 = ""
            End If
            If nome2 = "Null" Then
                nome2 = ""
            End If
            If nome3 = "Null" Then
                nome3 = ""
            End If
            FrmPrincipal.nomEvento = nome1 & " " & nome2 & " " & nome3
            FrmPdv1.LbNomEvento.Text = nome1 & " " & nome2 & " " & nome3
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DgvEvento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEvento.CellClick
        Try
            carregaEvento()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub carregaEvento()
        FrmPDV2.LbCodPdv.Text = DgvEvento.CurrentRow.Cells(0).Value
        FrmPdv1.LbCodEvento.Text = DgvEvento.CurrentRow.Cells(0).Value
        FrmPrincipal.codEvento = DgvEvento.CurrentRow.Cells(0).Value
        Dim nome1 As String
        nome1 = DgvEvento.CurrentRow.Cells(1).Value

        If nome1 = "Null" Then
            nome1 = ""
        End If

        FrmPDV2.LbDesPdv.Text = nome1
        FrmPdv1.LbNomEvento.Text = nome1
        FrmPrincipal.nomEvento = nome1
        Me.Close()

    End Sub

End Class