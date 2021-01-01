Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmPdv
    Dim conectar As New ConexaoSQL
    Dim ds, dsUltimo As New DataSet
    Dim pdv, pdv2 As New ClPdv
    Dim atualizar As Integer = 1
    Dim cod_old, desc_old, cod_empresa_old, ind_ativo_old, des_hostname_old As String
    Dim i As Integer = 0
    Private Sub Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            If t140101 = False Then
                MsgBox("Usuário sem permissão para acessar o Cadastro PDV!", MsgBoxStyle.Critical, "Usuário sem permissão de acesso!")
                Me.Close()
            End If
            BtnSalvar.Enabled = ModPermissaoUsuario.t1401011
            BtnExcluir.Enabled = ModPermissaoUsuario.t1401012
        End If
        limpar()
        Label18.Text = "Categoria:"
        'Me.Width = Me.Width + 200
        tab_control1Selelct()
        Dgv.DataSource = Nothing
    End Sub
    Public Sub tab_control1Selelct()
        TabControl1.SelectedIndex = 0
        Me.Height = 175
    End Sub
    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        carregaOld()
        atualizaDados()
    End Sub
    Public Sub atualizaDados()
        Dim ativo As String
        If cod_empresa_old = "" Then
            cod_empresa_old = "0"
        End If
        If cod_old = "" Then
            cod_old = 0
        End If
        If CkbPE.Checked = False Then
            ativo = "T"
        Else
            If CkbAtivo.Checked = True Then
                ativo = "S"
            Else
                ativo = "N"
            End If
        End If
        Dim tabela As DataTable
        ds = pdv.Consultar(cod_old, desc_old, ativo, cod_empresa_old)
        tabela = ds.Tables(0)

        If tabela.Rows.Count > 0 Then
            Dgv.DataSource = Nothing
            Dgv.DataSource = ds.Tables(0)
            formatarGrid()
            carregaFormulario()
        End If
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
            If ModParametroSistema.erro Then
                ModParametroSistema.erro = False
                Exit Sub
            End If
            If TxbCodEmpresa.Text = "" Then
                MsgBox("INFORME O ALMOXARIFADO")
                TxbCodEmpresa.Select()
                Exit Sub
            End If

            pdv.des_pdv = TxbDescricao.Text
            pdv.cod_empresa = TxbCodEmpresa.Text
            desc_old = TxbDescricao.Text
            If CkbAtivo.Checked = True Then
                pdv.ind_ativo = "S"
            Else
                pdv.ind_ativo = "N"
            End If
            pdv.des_hostname = TxbHostName.Text
            If atualizar = 1 Then
                'pegar o ultimo registro
                Try
                    Dim ultimo As New DataSet
                    ultimo = pdv2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    pdv.cod_pdv = Convert.ToInt16(ult) + 1

                    ultimo.Clear()
                Catch ex As Exception
                    pdv.cod_pdv = 1
                End Try
                pdv.Cadastrar()
                If ModParametroSistema.erro Then
                    ModParametroSistema.erro = False
                    Exit Sub
                End If

                MsgBox(" cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            Else
                pdv.cod_pdv = TxbCodigo.Text
                pdv.Atualizar()
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
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a :   " & TxbDescricao.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                pdv.cod_pdv = TxbCodigo.Text
                pdv.Excluir()
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
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        verificarAuteracao()
        limpar()
        Dgv.DataSource = Nothing
        TxbCodigo.Enabled = True
        TabControl1.SelectedIndex = 0
        Me.Height = 175
    End Sub
    Public Sub limpar()
        TxbCodigo.Text = ""
        TxbDescricao.Text = ""
        TxbCodEmpresa.Text = ""
        txbNomEmpresa.Text = ""
        TxbHostName.Text = ""
        CkbAtivo.Checked = True
        CkbPE.Checked = False
        cod_old = 0
        desc_old = ""
        cod_empresa_old = ""
        atualizar = 1
    End Sub
    Public Sub formatarGrid()
        Try
            With Dgv
                .Columns(0).HeaderText = "PDV"
                .Columns(1).HeaderText = ""
                .Columns(2).HeaderText = "Empresa"
                .Columns(3).HeaderText = ""
                .Columns(4).HeaderText = "HostName"
                .Columns(5).HeaderText = "Ativo"
                .Columns(0).Width = 40
                .Columns(1).Width = 110
                .Columns(2).Width = 40
                .Columns(3).Width = 110
                .Columns(4).Width = 60
                .Columns(5).Width = 40
            End With

        Catch ex As Exception

        End Try
    End Sub
    Public Sub carregaFormulario()
        Try
            limpar()
            If ds.Tables(0).Rows.Count > 0 Then
                atualizar = 2
                TxbCodigo.Text = ds.Tables(0).Rows(i)("cod_pdv").ToString
                TxbDescricao.Text = ds.Tables(0).Rows(i)("des_pdv").ToString
                TxbCodEmpresa.Text = ds.Tables(0).Rows(i)("cod_empresa").ToString
                txbNomEmpresa.Text = ds.Tables(0).Rows(i)("nom_fantasia").ToString
                TxbHostName.Text = ds.Tables(0).Rows(i)("des_hostname").ToString
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
    Private Sub carregaOld()
        cod_old = TxbCodigo.Text
        desc_old = TxbDescricao.Text
        cod_empresa_old = TxbCodEmpresa.Text
        If CkbAtivo.Checked = True Then
            ind_ativo_old = "S"
        Else
            ind_ativo_old = "N"
        End If
        des_hostname_old = TxbHostName.Text
    End Sub
    Public Sub verificarAuteracao()
        Dim msg As String = ""
        If TxbCodigo.Text = "" Then
            Exit Sub
        End If
        If desc_old <> TxbDescricao.Text Then
            msg = "Descrição PDV" & vbCrLf & "Anterior: " & desc_old & vbCrLf & " Nova : " & TxbDescricao.Text
        End If
        If cod_empresa_old <> TxbCodEmpresa.Text Then
            msg = msg & vbCrLf & "Empresa" & vbCrLf & "Anterior: " & cod_empresa_old & vbCrLf & " Nova : " & TxbCodEmpresa.Text & " " & txbNomEmpresa.Text
        End If
        If des_hostname_old <> TxbHostName.Text Then
            msg = msg & vbCrLf & "Host Name" & vbCrLf & "Anterior: " & des_hostname_old & vbCrLf & " Nova : " & TxbHostName.Text
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
            Me.Height = 175
        Else
            TabControl1.SelectedIndex = 1
            Me.Height = 322
        End If
    End Sub
    Private Sub BtnPrimeiroReg_Click(sender As Object, e As EventArgs) Handles BtnPrimeiroReg.Click
        verificarAuteracao()
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                i = 0
                carregaFormulario()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        verificarAuteracao()
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                If i = 0 Then
                    i = ds.Tables(0).Rows.Count - 1
                Else
                    i = i - 1
                End If
            End If
        Catch ex As Exception

        End Try
        carregaFormulario()
    End Sub
    Private Sub BtnUltimoReg_Click(sender As Object, e As EventArgs) Handles BtnUltimoReg.Click
        verificarAuteracao()
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                i = ds.Tables(0).Rows.Count - 1
            End If
        Catch ex As Exception

        End Try
        carregaFormulario()
    End Sub

    Private Sub BtnCadSubCategoria_Click(sender As Object, e As EventArgs) Handles BtnCadEmpresa.Click
        'FrmEmpresa.Show()
    End Sub

    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        verificarAuteracao()
        Try

            If ds.Tables(0).Rows.Count > 0 Then
                If i < ds.Tables(0).Rows.Count - 1 Then
                    i = i + 1
                Else
                    i = 0
                End If
            End If
        Catch ex As Exception

        End Try
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
    Private Sub BtSecao_Click(sender As Object, e As EventArgs) Handles BtEmpresa.Click
        FrmPesquisa.tabela = "tab_empresa"
        FrmPesquisa.ShowDialog()
        TxbCodEmpresa.Text = ModVariavelGlobal.pesquisaCodigo
        txbNomEmpresa.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub
    Private Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        Try
            TxbCodigo.Text = Dgv.CurrentRow.Cells(0).Value
            TxbDescricao.Text = Dgv.CurrentRow.Cells(1).Value
            TxbCodEmpresa.Text = Dgv.CurrentRow.Cells(2).Value
            txbNomEmpresa.Text = Dgv.CurrentRow.Cells(3).Value
            TxbHostName.Text = Dgv.CurrentRow.Cells(4).Value
            If Dgv.CurrentRow.Cells(5).Value.ToString = "S" Then
                CkbAtivo.Checked = True
            Else
                CkbAtivo.Checked = False
            End If
            TabControl1.SelectedIndex = 0
            carregaOld()
            Me.Height = 175
            Me.TxbCodigo.Select()
        Catch ex As Exception
        End Try
    End Sub


End Class
