Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmTipoDespesa

    Dim conectar As New ConexaoSQL
        Dim ds, dsUltimo As New DataSet
    Dim tipoDespesa, tipoDespesa2 As New ClTipoDespesa
    Dim atualizar As Integer = 1
    Dim cod_old, desc_old, ind_tipo_old, ind_ativo_old As String
    Dim i As Integer = 0
    Private Sub Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t130101 = False Then
                MsgBox("Usuário sem permissão para acessar a Cidade!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
            BtnSalvar.Enabled = ModPermissaoUsuario.t1301011
            BtnExcluir.Enabled = ModPermissaoUsuario.t1301012
        End If


        limpar()
        Label18.Text = "Especíe:"
        'Me.Width = Me.Width + 200
        tab_control1Selelct()
        Dgv.DataSource = Nothing
    End Sub
    Public Sub tab_control1Selelct()
        TabControl1.SelectedIndex = 0
        Me.Height = 195
    End Sub
    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click

        carregaOld()
        atualizaDados()
        carregaOld()

    End Sub
    Private Sub carregaOld()
        If TxbCodigo.Text = "" Then
            cod_old = 0
        Else
            cod_old = TxbCodigo.Text
        End If

        If RbAdministrativa.Checked = True Then
            ind_tipo_old = "A"
        ElseIf RbFinanceira.Checked = True Then
            ind_tipo_old = "F"
        ElseIf RbImpostoVenda.Checked = True Then
            ind_tipo_old = "I"
        End If

        If CkbAtivo.Checked = True Then
            ind_ativo_old = "S"
        Else
            ind_ativo_old = "N"
        End If
        desc_old = TxbDescricao.Text
    End Sub
    Public Sub atualizaDados()
        If CkbPe.Checked = False Then
            ind_ativo_old = ""
            ind_tipo_old = ""
        End If
        If cod_old = "" Then
            cod_old = 0
        End If
        Try

            Dim tabela As DataTable
            ds = tipoDespesa.Consultar(cod_old, desc_old, ind_tipo_old, ind_ativo_old)
            tabela = ds.Tables(0)

            If tabela.Rows.Count > 0 Then
                Dgv.DataSource = Nothing
                Dgv.DataSource = ds.Tables(0)
                formatarGrid()
                carregaFormulario()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaRegistro()

    End Sub
    Public Sub salvaRegistro()
        Try
            If TxbDescricao.Text = "" Then
                MsgBox("INFORME NOME DO ITEM")
                TxbDescricao.Select()
                Exit Sub
            End If
            carregaOld()

            tipoDespesa.des_tipo_despesa = TxbDescricao.Text
            tipoDespesa.ind_tipo = ind_tipo_old
            tipoDespesa.ind_ativo = ind_ativo_old

            If atualizar = 1 Then
                'pegar o ultimo registro
                Try
                    Dim ultimo As New DataSet
                    ultimo = tipoDespesa2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    tipoDespesa.cod_tipo_despesa = Convert.ToInt16(ult) + 1

                    ultimo.Clear()
                Catch ex As Exception
                    tipoDespesa.cod_tipo_despesa = 1
                End Try
                tipoDespesa.ind_ativo = "S"
                tipoDespesa.Cadastrar()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            Else
                tipoDespesa.cod_tipo_despesa = TxbCodigo.Text
                tipoDespesa.Atualizar()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            End If
            i = 0
            atualizaDados()
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a :   " & TxbDescricao.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                tipoDespesa.cod_tipo_despesa = TxbCodigo.Text
                tipoDespesa.Excluir()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If
                MsgBox(" Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()
                limpar()
            Catch ex As Exception
                MsgBox("Erro ao excluir , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        verificarAuteracao()
        limpar()
        Dgv.DataSource = Nothing
        TxbCodigo.Enabled = True
        TabControl1.SelectedIndex = 0
    End Sub
    Public Sub limpar()
        TxbCodigo.Text = ""
        TxbDescricao.Text = ""
        CkbAtivo.Checked = True
        CkbPe.Checked = False
        RbAdministrativa.Checked = True
        carregaOld()
        atualizar = 1
    End Sub
    Public Sub formatarGrid()
        Try
            With Dgv
                .Columns(0).HeaderText = "Cód."
                .Columns(1).HeaderText = "Descrição"
                .Columns(2).HeaderText = "Tipo"
                .Columns(3).HeaderText = "Ativo"
                .Columns(0).Width = 80
                .Columns(1).Width = 230
                .Columns(2).Width = 80
                .Columns(3).Width = 80

            End With

        Catch ex As Exception

        End Try
    End Sub


    Public Sub carregaFormulario()
        Try
            limpar()
            If ds.Tables(0).Rows.Count > 0 Then
                atualizar = 2
                TxbCodigo.Text = ds.Tables(0).Rows(i)("cod_tipo_despesa").ToString
                TxbDescricao.Text = ds.Tables(0).Rows(i)("des_tipo_despesa").ToString
                If ds.Tables(0).Rows(i)("ind_tipo").ToString = "A" Then
                    RbAdministrativa.Checked = True
                ElseIf ds.Tables(0).Rows(i)("ind_tipo").ToString = "F" Then
                    RbFinanceira.Checked = True
                Else
                    RbImpostoVenda.Checked = True
                End If

                If ds.Tables(0).Rows(i)("ind_ativo").ToString = "S" Then
                    CkbAtivo.Checked = True
                Else
                    CkbAtivo.Checked = False
                End If

                TxbCodigo.Enabled = False
            Else
                atualizar = 1
                TxbCodigo.Enabled = True
            End If
            carregaOld()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub verificarAuteracao()
        Dim msg As String = ""
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        If desc_old <> TxbDescricao.Text Then
            msg = "Descrição Seção" & vbCrLf & "Anterior: " & desc_old & vbCrLf & " Nova : " & TxbDescricao.Text
        End If
        Dim tipo As String
        If RbAdministrativa.Checked = True Then
            tipo = "A"
        ElseIf RbFinanceira.Checked = True Then
            tipo = "F"
        Else
            tipo = "I"
        End If
        If ind_tipo_old <> tipo Then
            msg = msg & vbCrLf & "Tipo" & vbCrLf & "Anterior: " & ind_tipo_old & vbCrLf & " Nova : " & tipo & " " & ind_tipo_old
        End If

        Dim ativo As String
        If CkbAtivo.Checked = True Then
            ativo = "S"
        Else
            ativo = "N"
        End If
        If ind_ativo_old <> ativo Then
            msg = msg & vbCrLf & "Ativo" & vbCrLf & "Anterior: " & ind_ativo_old & vbCrLf & " Nova : " & ativo & " " & ind_ativo_old
        End If
        If msg <> "" Then
            If MsgBox("Deseja salvar a alteraçã em:" & vbCrLf & msg & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                salvaRegistro()
            End If
        End If

    End Sub
    Private Sub BtnGrid_Click(sender As Object, e As EventArgs) Handles BtnGrid.Click
        If TabControl1.SelectedIndex = 1 Then
            TabControl1.SelectedIndex = 0
            Me.Height = 195
        Else
            TabControl1.SelectedIndex = 1
            Me.Height = 322
        End If
    End Sub
    Private Sub BtnPrimeiroReg_Click(sender As Object, e As EventArgs) Handles BtnPrimeiroReg.Click
        verificarAuteracao()
        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            carregaFormulario()
        End If

    End Sub


    Private Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        Try
            TxbCodigo.Text = Dgv.CurrentRow.Cells(0).Value
            TxbDescricao.Text = Dgv.CurrentRow.Cells(1).Value

            If Dgv.CurrentRow.Cells(2).Value = "A" Then
                RbAdministrativa.Checked = True
            ElseIf Dgv.CurrentRow.Cells(2).Value = "F" Then
                RbFinanceira.Checked = True
            Else
                RbImpostoVenda.Checked = True
            End If

            If Dgv.CurrentRow.Cells(3).Value = "S" Then
                CkbAtivo.Checked = True
            Else
                CkbAtivo.Checked = False
            End If
            tab_control1Selelct()
            Me.TxbCodigo.Select()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
            verificarAuteracao()

            If ds.Tables(0).Rows.Count > 0 Then
                If i = 0 Then
                    i = ds.Tables(0).Rows.Count - 1
                Else
                    i = i - 1
                End If
            End If
            carregaFormulario()
        End Sub
        Private Sub BtnUltimoReg_Click(sender As Object, e As EventArgs) Handles BtnUltimoReg.Click
            verificarAuteracao()

            If ds.Tables(0).Rows.Count > 0 Then
                i = ds.Tables(0).Rows.Count - 1
            End If
            carregaFormulario()
        End Sub
        Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
            verificarAuteracao()

            If ds.Tables(0).Rows.Count > 0 Then
                If i < ds.Tables(0).Rows.Count - 1 Then
                    i = i + 1
                Else
                    i = 0
                End If
            End If
            carregaFormulario()
        End Sub
        Private Sub BtnCsv_Click(sender As Object, e As EventArgs) Handles BtnCsv.Click
            Try
                If ds.Tables(0).Rows.Count < 1 Then
                    Exit Sub
                End If

                'My.Computer.FileSystem.CreateDirectory("C:\\CashMonitor")
                Dim nomArquivo As String
                Dim dataAtual As String
                Dim nomPasta As String

                'localizar a pasta
                Dim pasta As New FolderBrowserDialog
                Dim dr As DialogResult = pasta.ShowDialog()
                If dr = System.Windows.Forms.DialogResult.OK Then
                    nomPasta = pasta.SelectedPath
                End If

                Dim horaMin As String
                dataAtual = Format(Today, "ddmmyyyy")
                dataAtual = Replace(dataAtual, "00", "10")
                horaMin = Format(Now, "hhmm")

                nomArquivo = Me.Text & "_" & dataAtual & "_" & horaMin

                Dim CSV As System.IO.StreamWriter = New System.IO.StreamWriter(nomPasta & nomArquivo & ".csv")
                Dim i As Integer, x As Integer

                Dim QtdColunas As Integer = Dgv.ColumnCount - 1

                For i = 0 To QtdColunas
                    If Dgv.Columns(i).HeaderText.Substring(0, 6) <> "Column" Then
                        CSV.Write(Dgv.Columns(i).HeaderText)

                        If (i < QtdColunas) Then

                            CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                        End If
                    End If
                Next i

                ' CSV.Write(CSV.NewLine)

                Dim QtdRows As Integer = Dgv.Rows.Count - 1

                For i = 0 To QtdRows

                    For x = 0 To QtdColunas

                        If (Not Dgv.Rows(i).Cells(x).Value Is Nothing) Then
                            CSV.Write(Dgv.Rows(i).Cells(x).Value.ToString())

                        End If

                        If (x < QtdColunas) Then
                            CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                        End If

                    Next x
                    CSV.Write(CSV.NewLine)
                Next i
                MsgBox("Arquivo criado com sucesso em   " & nomPasta & "\" & nomArquivo)

                CSV.Close()
            Catch ex As Exception
                MsgBox("Erro ao Salvar o arquivo " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")
            End Try

        End Sub

    End Class
