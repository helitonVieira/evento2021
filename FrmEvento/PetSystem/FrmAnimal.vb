Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms

Public Class FrmAnimal
    Dim conectar As New Controles.ConexaoSQL
    Dim ds, dsUltimo, dsAnimalVacina, dsContParasitario As New DataSet
    Dim animal, animal2 As New ClAnimal
    Dim animalVacina, animalVacina2 As New ClAnimalVacina
    Dim animalContParasitario, animalContParasitario2 As New ClAnimalControleParasita
    Dim atualizar As Integer = 1
    Dim atualizarVacina As Integer = 1
    Dim atualizarParasitario As Integer = 1
    Dim cod_animal_old, nom_animal_old, cod_pessoa_proprietario_old, nom_pessoa_old,
        ind_sexo_old, dta_nascimento_old, cod_especie_old, des_especie_old,
        cod_raca_old, des_raca_old, cod_pelagem_old, des_pelagem_old, des_observacao_old As String
    Dim i As Integer = 0
    Dim frmPesquisa As New FrmPesquisa

    Public Sub pesquisaNew(codigo As Integer, descricao As String)
        TxbCodProprietario.Text = codigo.ToString
        TxbNomProprietario.Text = descricao
    End Sub
    Private Sub BtnPrincipal_Click(sender As Object, e As EventArgs) Handles BtnPrincipal.Click
        TabControl1.SelectedIndex = 0
        TxbCodProprietario.Select()
        GbNavegador.Enabled = True
    End Sub

    Private Sub BtnVacina_Click(sender As Object, e As EventArgs) Handles BtnVacina.Click
        TabControl1.SelectedIndex = 2
        DgvVacina.DataSource = Nothing
        TxbCodVacina.Select()
        GbNavegador.Enabled = False
        atualizaDadosVacina()
        limparVacina()
        BtnPrincipal.Enabled = True
    End Sub

    Private Sub BtnControleParasitario_Click(sender As Object, e As EventArgs) Handles BtnControleParasitario.Click
        TabControl1.SelectedIndex = 3
        DgvContParasitario.DataSource = Nothing
        TxbCodParasita.Select()
        GbNavegador.Enabled = False
        BtnPrincipal.Enabled = True
        atualizaDadosParasitario()
        limparParasitario()
    End Sub

    Private Sub DtpDtaNasc_TextChanged(sender As Object, e As EventArgs) Handles DtpDtaNasc.TextChanged
        TxbDtaNasc.Text = DtpDtaNasc.Value
    End Sub

    Private Sub DateTimePicker2_TextChanged(sender As Object, e As EventArgs) Handles DtpProximaParasita.TextChanged
        TxbDtaProximaParasita.Text = DtpProximaParasita.Value
    End Sub

    Private Sub DtpDtaParasita_TextChanged(sender As Object, e As EventArgs) Handles DtpDtaParasita.TextChanged
        TxbDtaParasita.Text = DtpDtaParasita.Value
    End Sub

    Private Sub Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar()
        'Me.Width = Me.Width + 200
        tab_control1Selelct()
        Dgv.DataSource = Nothing
        RbMacho.Checked = True
        GbNavegador.Enabled = True
        BtnVacina.Enabled = False
        BtnControleParasitario.Enabled = False
        BtnPrincipal.Enabled = False
    End Sub
    Public Sub tab_control1Selelct()
        TabControl1.SelectedIndex = 0
        'Me.Height = 320
        TxbNomAnimal.Select()
    End Sub
    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click

        carrega_old()
        atualizaDados()

    End Sub

    Public Sub carrega_old()
        If TxbCodAnimal.Text = "" Then
            cod_animal_old = 0
        Else
            cod_animal_old = TxbCodAnimal.Text
        End If
        nom_animal_old = TxbNomAnimal.Text

        If TxbCodProprietario.Text = "" Then
            cod_pessoa_proprietario_old = 0
        Else
            cod_pessoa_proprietario_old = TxbCodProprietario.Text
        End If

        nom_pessoa_old = TxbNomProprietario.Text

        If RbFemea.Checked = True Then
            ind_sexo_old = "F"
        Else
            ind_sexo_old = "M"
        End If
        If TxbDtaNasc.Text = "" Then
            dta_nascimento_old = Nothing
        Else
            dta_nascimento_old = TxbDtaNasc.Text
        End If
        dta_nascimento_old = TxbDtaNasc.Text

        If TxbCodEspecie.Text = "" Then
            cod_especie_old = 0
        Else
            cod_especie_old = TxbCodEspecie.Text
        End If
        des_especie_old = TxbDesEspecie.Text

        If txbcodRaca.Text = "" Then
            cod_raca_old = 0
        Else
            cod_raca_old = txbcodRaca.Text
        End If
        des_raca_old = TxbDesRaca.Text

        If TxbCodPelagem.Text = "" Then
            cod_pelagem_old = 0
        Else
            cod_pelagem_old = TxbCodPelagem.Text
        End If
        des_pelagem_old = TxbDesPelagem.Text

        des_observacao_old = TxbObservacao.Text
    End Sub
    Public Sub atualizaDados()
        Try
            Dim tabela As DataTable
            ds = animal.Consultar(cod_animal_old, nom_animal_old, cod_pessoa_proprietario_old, ind_sexo_old,
                                   dta_nascimento_old, cod_especie_old, cod_raca_old,
                                  cod_pelagem_old, des_observacao_old)
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
            If TxbNomAnimal.Text = "" Then
                MsgBox("INFORME NOME DO ANIMAL")
                TxbNomAnimal.Select()
                Exit Sub
            End If
            If TxbCodProprietario.Text = "" Then
                MsgBox("INFORME NOME DO PROPRIETARIO")
                TxbCodProprietario.Select()
                Exit Sub
            End If
            If TxbDtaNasc.Text = "" Then
                MsgBox("INFORME DATA NASCIMENTO")
                TxbDtaNasc.Select()
                Exit Sub
            End If

            If TxbCodEspecie.Text = "" Then
                MsgBox("INFORME ESPECIE")
                TxbCodEspecie.Select()
                Exit Sub
            End If
            If txbcodRaca.Text = "" Then
                MsgBox("INFORME A RAÇA")
                txbcodRaca.Select()
                Exit Sub
            End If
            If TxbCodPelagem.Text = "" Then
                MsgBox("INFORME A PELAGEM")
                TxbCodPelagem.Select()
                Exit Sub
            End If
            carrega_old()

            animal.nom_animal = nom_animal_old
            animal.cod_pessoa_proprietario = cod_pessoa_proprietario_old
            animal.ind_sexo = ind_sexo_old
            animal.dta_nascimento = dta_nascimento_old
            animal.cod_especie = cod_especie_old
            animal.cod_raca = cod_raca_old
            animal.cod_pelagem = cod_pelagem_old
            animal.des_observacao = des_observacao_old


            If atualizar = 1 Then
                'pegar o ultimo registro
                Try
                    Dim ultimo As New DataSet
                    ultimo = animal2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    animal.cod_animal = Convert.ToInt16(ult) + 1

                    ultimo.Clear()
                Catch ex As Exception
                    animal.cod_animal = 1
                End Try
                animal.Cadastrar()
                MsgBox(" cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            Else
                animal.cod_animal = TxbCodAnimal.Text
                animal.Atualizar()
                MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            End If

        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
            Exit Sub
        End Try
        atualizaDados()
    End Sub
    Private Sub BtnProprietario_Click(sender As Object, e As EventArgs) Handles BtnProprietario.Click
        frmPesquisa.tabela = "tab_pessoa_animal"
        frmPesquisa.ShowDialog()
        TxbCodProprietario.Text = ModuleVariavelGlobal.pesquisaCodigo
        TxbNomProprietario.Text = ModuleVariavelGlobal.pesquisaNome
        ModuleVariavelGlobal.pesquisaCodigo = ""
        ModuleVariavelGlobal.pesquisaNome = ""

    End Sub

    Private Sub BtnPesquisaEspecie_Click(sender As Object, e As EventArgs) Handles BtnPesquisaEspecie.Click

        frmPesquisa.tabela = "tab_especie_animal"
        frmPesquisa.ShowDialog()
        TxbCodEspecie.Text = ModuleVariavelGlobal.pesquisaCodigo
        TxbDesEspecie.Text = ModuleVariavelGlobal.pesquisaNome
        ModuleVariavelGlobal.pesquisaCodigo = ""
        ModuleVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnPesquisaRaca_Click(sender As Object, e As EventArgs) Handles BtnPesquisaRaca.Click
        FrmPesquisa.tabela = "tab_raca_animal"
        frmPesquisa.ShowDialog()
        txbcodRaca.Text = ModuleVariavelGlobal.pesquisaCodigo
        TxbDesRaca.Text = ModuleVariavelGlobal.pesquisaNome
        ModuleVariavelGlobal.pesquisaCodigo = ""
        ModuleVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnPesquisaPelagem_Click(sender As Object, e As EventArgs) Handles BtnPesquisaPelagem.Click
        FrmPesquisa.tabela = "tab_pelagem_animal"
        frmPesquisa.ShowDialog()
        TxbCodPelagem.Text = ModuleVariavelGlobal.pesquisaCodigo
        TxbDesPelagem.Text = ModuleVariavelGlobal.pesquisaNome
        ModuleVariavelGlobal.pesquisaCodigo = ""
        ModuleVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnPesquisaVacina_Click(sender As Object, e As EventArgs) Handles BtnPesquisaVacina.Click
        FrmPesquisa.tabela = "tab_vacina_animal"
        frmPesquisa.ShowDialog()
        TxbCodVacina.Text = ModuleVariavelGlobal.pesquisaCodigo
        TxbDesVacina.Text = ModuleVariavelGlobal.pesquisaNome
        ModuleVariavelGlobal.pesquisaCodigo = ""
        ModuleVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnPesquisaParasita_Click(sender As Object, e As EventArgs) Handles BtnPesquisaParasita.Click
        FrmPesquisa.tabela = "tab_parasita_animal"
        frmPesquisa.ShowDialog()
        TxbCodParasita.Text = ModuleVariavelGlobal.pesquisaCodigo
        TxbDesParasita.Text = ModuleVariavelGlobal.pesquisaNome
        ModuleVariavelGlobal.pesquisaCodigo = ""
        ModuleVariavelGlobal.pesquisaNome = ""
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbCodAnimal.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a :   " & TxbNomAnimal.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                animal.cod_animal = TxbCodAnimal.Text
                animal.Excluir()
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
        TxbCodAnimal.Enabled = True
        TabControl1.SelectedIndex = 0
        TxbCodAnimal.Select()
        BtnVacina.Enabled = False
        BtnControleParasitario.Enabled = False
        BtnPrincipal.Enabled = False
    End Sub
    Public Sub limpar()
        TxbCodAnimal.Text = ""
        TxbNomAnimal.Text = ""
        TxbCodProprietario.Text = ""
        TxbNomProprietario.Text = ""
        RbMacho.Checked = True
        TxbDtaNasc.Text = ""
        TxbCodEspecie.Text = ""
        TxbDesEspecie.Text = ""
        txbcodRaca.Text = ""
        TxbDesRaca.Text = ""
        TxbCodPelagem.Text = ""
        TxbDesPelagem.Text = ""
        TxbObservacao.Text = ""

        cod_animal_old = ""
        nom_animal_old = ""
        cod_pessoa_proprietario_old = ""
        nom_pessoa_old = ""
        ind_sexo_old = ""
        dta_nascimento_old = ""
        cod_especie_old = ""
        des_especie_old = ""
        cod_raca_old = ""
        des_raca_old = ""
        cod_pelagem_old = ""
        des_pelagem_old = ""
        des_observacao_old = ""
        atualizar = 1
    End Sub
    Public Sub formatarGrid()
        Try
            With Dgv
                .Columns(0).HeaderText = "Cód.Animal"
                .Columns(1).HeaderText = "Nome"
                .Columns(2).HeaderText = "Cód.Proprietário"
                .Columns(3).HeaderText = "Nom.Proprietário"
                .Columns(4).HeaderText = "Sexo"
                .Columns(5).HeaderText = "Nascimento"
                .Columns(6).HeaderText = "Cód.Especie"
                .Columns(7).HeaderText = "Des.Especie"
                .Columns(8).HeaderText = "Cód.Raça"
                .Columns(9).HeaderText = "Des.Raça"
                .Columns(10).HeaderText = "Cód.Pelagem"
                .Columns(11).HeaderText = "Des.Pelagem"
                .Columns(12).HeaderText = "Observação"
                .Columns(0).Width = 40
                .Columns(1).Width = 150
                .Columns(2).Width = 40
                .Columns(3).Width = 150
                .Columns(4).Width = 40
                .Columns(5).Width = 150
                .Columns(6).Width = 40
                .Columns(7).Width = 150
                .Columns(8).Width = 40
                .Columns(9).Width = 150
                .Columns(10).Width = 40
                .Columns(11).Width = 150
                .Columns(12).Width = 150

            End With

        Catch ex As Exception

        End Try
    End Sub


    Public Sub carregaFormulario()
        Try
            limpar()
            If ds.Tables(0).Rows.Count > 0 Then
                atualizar = 2
                TxbCodAnimal.Text = ds.Tables(0).Rows(i)("cod_animal").ToString
                TxbNomAnimal.Text = ds.Tables(0).Rows(i)("nom_animal").ToString
                TxbCodProprietario.Text = ds.Tables(0).Rows(i)("cod_pessoa_proprietario").ToString
                TxbNomProprietario.Text = ds.Tables(0).Rows(i)("nom_pessoa").ToString
                If ds.Tables(0).Rows(i)("ind_sexo").ToString = "M" Or ds.Tables(0).Rows(i)("ind_sexo").ToString = "M " Then
                    RbMacho.Checked = True
                Else
                    RbFemea.Checked = True
                End If

                TxbDtaNasc.Text = ds.Tables(0).Rows(i)("dta_nascimento").ToString
                TxbCodEspecie.Text = ds.Tables(0).Rows(i)("cod_especie").ToString
                TxbDesEspecie.Text = ds.Tables(0).Rows(i)("des_especie").ToString
                txbcodRaca.Text = ds.Tables(0).Rows(i)("cod_raca").ToString
                TxbDesRaca.Text = ds.Tables(0).Rows(i)("des_raca").ToString
                TxbCodPelagem.Text = ds.Tables(0).Rows(i)("cod_pelagem").ToString
                TxbDesPelagem.Text = ds.Tables(0).Rows(i)("des_pelagem").ToString
                TxbObservacao.Text = ds.Tables(0).Rows(i)("des_observacao").ToString

                TxbCodAnimal.Enabled = False
            Else
                atualizar = 1
                TxbCodAnimal.Enabled = True
            End If
            cod_animal_old = TxbCodAnimal.Text
            nom_animal_old = TxbNomAnimal.Text
            cod_pessoa_proprietario_old = TxbCodProprietario.Text
            nom_pessoa_old = TxbNomProprietario.Text
            ind_sexo_old = ds.Tables(0).Rows(i)("ind_sexo").ToString
            dta_nascimento_old = TxbDtaNasc.Text
            cod_especie_old = TxbCodEspecie.Text
            des_especie_old = TxbDesEspecie.Text
            cod_raca_old = txbcodRaca.Text
            des_raca_old = TxbDesRaca.Text
            cod_pelagem_old = TxbCodPelagem.Text
            des_pelagem_old = TxbDesPelagem.Text
            des_observacao_old = TxbObservacao.Text

            BtnVacina.Enabled = True
            BtnControleParasitario.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub verificarAuteracao()
        Dim msg As String = ""
        If TxbCodAnimal.Text = "" Then
            Exit Sub
        End If
        If nom_animal_old <> TxbNomAnimal.Text Then
            msg = "Descrição Seção" & vbCrLf & "Anterior: " & nom_animal_old & vbCrLf & " Nova : " & TxbNomAnimal.Text
        End If
        If cod_pessoa_proprietario_old <> TxbCodProprietario.Text Then
            msg = msg & vbCrLf & "Almoxarifado" & vbCrLf & "Anterior: " & cod_pessoa_proprietario_old & vbCrLf & " Nova : " & TxbCodProprietario.Text & " " & TxbNomProprietario.Text
        End If
        If dta_nascimento_old <> TxbDtaNasc.Text Then
            msg = "Data nascimento" & vbCrLf & "Anterior: " & dta_nascimento_old & vbCrLf & " Nova : " & TxbDtaNasc.Text
        End If
        If cod_especie_old <> TxbCodEspecie.Text Then
            msg = msg & vbCrLf & "Especie" & vbCrLf & "Anterior: " & cod_especie_old & vbCrLf & " Nova : " & TxbCodEspecie.Text & " " & TxbDesEspecie.Text
        End If
        If cod_raca_old <> txbcodRaca.Text Then
            msg = msg & vbCrLf & "Raça" & vbCrLf & "Anterior: " & cod_raca_old & vbCrLf & " Nova : " & txbcodRaca.Text & " " & TxbDesRaca.Text
        End If
        If cod_pelagem_old <> TxbCodPelagem.Text Then
            msg = msg & vbCrLf & "Pelagem" & vbCrLf & "Anterior: " & cod_pelagem_old & vbCrLf & " Nova : " & TxbCodPelagem.Text & " " & TxbDesPelagem.Text
        End If
        If des_observacao_old <> TxbObservacao.Text Then
            msg = msg & vbCrLf & "Observação" & vbCrLf & "Anterior: " & des_observacao_old & vbCrLf & " Nova : " & TxbObservacao.Text & " " & TxbObservacao.Text
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
            ' Me.Height = 162
        Else
            TabControl1.SelectedIndex = 1
            '  Me.Height = 322
        End If
    End Sub
    Private Sub BtnPrimeiroReg_Click(sender As Object, e As EventArgs) Handles BtnPrimeiroReg.Click
        verificarAuteracao()
        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            carregaFormulario()
        End If
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

    Private Sub Dgv_CellClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles Dgv.CellClick
        Me.TxbCodAnimal.Text = Dgv.CurrentRow.Cells(0).Value
        Me.TxbNomAnimal.Text = Dgv.CurrentRow.Cells(1).Value
        Me.TxbCodProprietario.Text = Dgv.CurrentRow.Cells(2).Value
        Me.TxbNomProprietario.Text = Dgv.CurrentRow.Cells(3).Value
        If Dgv.CurrentRow.Cells(4).Value.ToString = "M " Or Dgv.CurrentRow.Cells(4).Value.ToString = "M" Then
            RbMacho.Checked = True
        Else
            RbFemea.Checked = True
        End If
        TxbDtaNasc.Text = Dgv.CurrentRow.Cells(5).Value
        TxbCodEspecie.Text = Dgv.CurrentRow.Cells(6).Value
        TxbDesEspecie.Text = Dgv.CurrentRow.Cells(7).Value
        txbcodRaca.Text = Dgv.CurrentRow.Cells(8).Value
        TxbDesRaca.Text = Dgv.CurrentRow.Cells(9).Value
        TxbCodPelagem.Text = Dgv.CurrentRow.Cells(10).Value
        TxbDesPelagem.Text = Dgv.CurrentRow.Cells(11).Value
        TxbObservacao.Text = Dgv.CurrentRow.Cells(12).Value

        TabControl1.SelectedIndex = 0

        Me.TxbNomAnimal.Select()
    End Sub
    Private Sub Dgv_CellEnter(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles Dgv.CellEnter
        i = Dgv.CurrentRow.Index
        carregaFormulario()
    End Sub
    '#####################################################
    'VACINA
    '####################################################

    Private Sub DgvVacina_CellClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DgvVacina.CellClick
        Try
            LbSeqVacina.Text = DgvVacina.CurrentRow.Cells(0).Value
            Me.TxbCodVacina.Text = DgvVacina.CurrentRow.Cells(1).Value
            Me.TxbDesVacina.Text = DgvVacina.CurrentRow.Cells(2).Value
            Me.TxbDtaVacina.Text = DgvVacina.CurrentRow.Cells(3).Value
            If DgvVacina.CurrentRow.Cells(4).Value.ToString = "S" Then
                RbVacSim.Checked = True
            Else
                RbVacNao.Checked = True
            End If
            Me.TxbCodVacina.Select()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub DgvVacina_CellEnter(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DgvVacina.CellEnter
        '    carregaFormularioVacina()
    End Sub
    Public Sub atualizaDadosVacina()
        If TxbCodAnimal.Text = "" Then
            Exit Sub
        End If
        Try
            Dim tabela As DataTable
            dsAnimalVacina = animalVacina.Consultar(TxbCodAnimal.Text)
            tabela = dsAnimalVacina.Tables(0)

            If tabela.Rows.Count > 0 Then
                DgvVacina.DataSource = Nothing
                DgvVacina.DataSource = dsAnimalVacina.Tables(0)
                formatarGridVacina()
                carregaFormularioVacina()

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnSalvaVacina_Click(sender As Object, e As EventArgs) Handles BtnSalvaVacina.Click
        salvaRegistroVacina()
        limparVacina()
    End Sub
    Public Sub salvaRegistroVacina()
        Try
            If TxbCodVacina.Text = "" Then
                MsgBox("INFORME VACINA")
                TxbCodVacina.Select()
                Exit Sub
            End If
            If TxbDtaVacina.Text = "" Then
                MsgBox("INFORME DATA VACINA")
                TxbDtaVacina.Select()
                Exit Sub
            End If
            animalVacina.cod_vacina = TxbCodVacina.Text
            animalVacina.cod_animal = TxbCodAnimal.Text
            animalVacina.dta_vacina = TxbDtaVacina.Text
            If RbVacNao.Checked = True Then
                animalVacina.ind_vacinado = "N"
            Else
                animalVacina.ind_vacinado = "S"
            End If


            If atualizarVacina = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                Try
                    ultimo = animalVacina2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    animalVacina.seq_vacina = Convert.ToInt16(ult) + 1

                    animalVacina.Cadastrar()
                    ultimo.Clear()
                Catch ex As Exception
                    animalVacina.seq_vacina = 1
                End Try
                MsgBox(" Cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            Else
                animalVacina.seq_vacina = LbSeqVacina.Text
                animalVacina.Atualizar()
                MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
        atualizaDadosVacina()
    End Sub
    Private Sub BtnExcluirVacina_Click(sender As Object, e As EventArgs) Handles BtnExcluirVacina.Click
        If LbSeqVacina.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a :   " & TxbCodVacina.Text & " Data:" & TxbDtaVacina.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                animalVacina.seq_vacina = LbSeqVacina.Text
                animalVacina.Excluir()
                MsgBox(" Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDadosVacina()
                limparVacina()
            Catch ex As Exception
                MsgBox("Erro ao excluir , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub
    Public Sub limparVacina()
        TxbCodVacina.Text = ""
        TxbDesVacina.Text = ""
        TxbDtaVacina.Text = ""
        LbSeqVacina.Text = ""
        RbVacNao.Checked = True
        atualizarVacina = 1
    End Sub
    Private Sub BtnLimpaVacina_Click(sender As Object, e As EventArgs) Handles BtnLimpaVacina.Click
        limparVacina()
    End Sub
    Public Sub formatarGridVacina()
        Try
            With DgvVacina
                .Columns(0).HeaderText = "Seq."
                .Columns(1).HeaderText = "Cod."
                .Columns(2).HeaderText = "Descrição"
                .Columns(3).HeaderText = "Data"
                .Columns(4).HeaderText = "Vacinado"

                .Columns(0).Width = 40
                .Columns(1).Width = 40
                .Columns(2).Width = 233
                .Columns(3).Width = 70
                .Columns(4).Width = 55
                .Columns(0).Visible = False
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub carregaFormularioVacina()
        Try
            limparVacina()
            If dsAnimalVacina.Tables(0).Rows.Count > 0 Then
                atualizarVacina = 2
                LbSeqVacina.Text = dsAnimalVacina.Tables(0).Rows(i)("seq_vacina").ToString
                TxbCodVacina.Text = dsAnimalVacina.Tables(0).Rows(i)("cod_vacina").ToString
                TxbDesVacina.Text = dsAnimalVacina.Tables(0).Rows(i)("nom_vacina").ToString
                TxbDtaVacina.Text = dsAnimalVacina.Tables(0).Rows(i)("dta_vacina").ToString
                If dsAnimalVacina.Tables(0).Rows(i)("ind_vacinado").ToString = "S" Then
                    RbVacSim.Checked = True
                Else
                    RbVacNao.Checked = True
                End If
            Else
                atualizarVacina = 1
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DtpDtaVacina_Click(sender As Object, e As EventArgs) Handles DtpDtaVacina.Click
        TxbDtaVacina.Text = DtpDtaVacina.Value.ToShortDateString
    End Sub
    '****************************************************
    'CONTROLE PARASITA
    '****************************************************
    Private Sub DtpDtaParasita_Click(sender As Object, e As EventArgs) Handles DtpDtaParasita.Click
        TxbDtaParasita.Text = DtpDtaParasita.Value.ToShortDateString
    End Sub

    Private Sub DtpProximaParasita_Click(sender As Object, e As EventArgs) Handles DtpProximaParasita.Click
        TxbDtaProximaParasita.Text = DtpProximaParasita.Value.ToShortDateString
    End Sub

    Private Sub DgvContParasitario_DoubleClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DgvContParasitario.DoubleClick
        Try
            LbSeqParasita.Text = DgvContParasitario.CurrentRow.Cells(0).Value
            Me.TxbCodParasita.Text = DgvContParasitario.CurrentRow.Cells(1).Value
            Me.TxbDesParasita.Text = DgvContParasitario.CurrentRow.Cells(2).Value
            Me.TxbDtaParasita.Text = DgvContParasitario.CurrentRow.Cells(3).Value
            TxbPesoParasita.Text = DgvContParasitario.CurrentRow.Cells(4).Value
            TxbDoseParasita.Text = DgvContParasitario.CurrentRow.Cells(5).Value
            TxbDtaProximaParasita.Text = DgvContParasitario.CurrentRow.Cells(6).Value
            Me.TxbCodParasita.Select()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub DgvContParasitario_CellEnter(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DgvContParasitario.CellEnter
        '    carregaFormularioParasitario()
    End Sub
    Public Sub atualizaDadosParasitario()
        If TxbCodAnimal.Text = "" Then
            Exit Sub
        End If
        Try
            Dim tabela As DataTable
            dsContParasitario = animalContParasitario.Consultar(TxbCodAnimal.Text)
            tabela = dsContParasitario.Tables(0)

            If tabela.Rows.Count > 0 Then
                DgvContParasitario.DataSource = Nothing
                DgvContParasitario.DataSource = dsContParasitario.Tables(0)
                formatarGridParasitario()
                carregaFormularioParasitario()

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnSalvaParasita.Click
        salvaRegistroParasitario()
        limparParasitario()
    End Sub
    Public Sub salvaRegistroParasitario()
        Try
            If TxbCodParasita.Text = "" Then
                MsgBox("INFORME CONTROLE PARASITÁRIO")
                TxbCodParasita.Select()
                Exit Sub
            End If
            If TxbDtaParasita.Text = "" Then
                MsgBox("INFORME DATA")
                TxbDtaParasita.Select()
                Exit Sub
            End If
            animalContParasitario.cod_controle_parasita = TxbCodParasita.Text
            animalContParasitario.cod_animal = TxbCodAnimal.Text
            animalContParasitario.dta_controle = TxbDtaParasita.Text
            animalContParasitario.qtd_peso = TxbPesoParasita.Text
            animalContParasitario.des_dose = TxbDoseParasita.Text
            animalContParasitario.dta_proxima = TxbDtaProximaParasita.Text


            If atualizarParasitario = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                Try
                    ultimo = animalContParasitario2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    animalContParasitario.seq_controle = Convert.ToInt16(ult) + 1
                Catch ex As Exception
                    animalContParasitario.seq_controle = 1
                End Try
                animalContParasitario.Cadastrar()
                ultimo.Clear()
                MsgBox(" Cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            Else
                animalContParasitario.seq_controle = LbSeqParasita.Text
                animalContParasitario.Atualizar()
                MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
        atualizaDadosParasitario()
    End Sub
    Private Sub BtnExcluirParasita_Click(sender As Object, e As EventArgs) Handles BtnExcluirParasita.Click
        If LbSeqParasita.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a :   " & TxbCodParasita.Text & " Data:" & TxbDtaParasita.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                animalContParasitario.seq_controle = LbSeqParasita.Text
                animalContParasitario.Excluir()
                MsgBox(" Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDadosParasitario()
                limparParasitario()
            Catch ex As Exception
                MsgBox("Erro ao excluir , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub
    Public Sub limparParasitario()
        TxbCodParasita.Text = ""
        TxbDesParasita.Text = ""
        TxbDtaParasita.Text = ""
        LbSeqParasita.Text = ""
        TxbPesoParasita.Text = ""
        TxbDoseParasita.Text = ""
        TxbDtaProximaParasita.Text = ""
        atualizarParasitario = 1
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnLimparParasita.Click
        limparParasitario()
    End Sub
    Public Sub formatarGridParasitario()
        Try
            With DgvContParasitario
                .Columns(0).HeaderText = "Seq."
                .Columns(1).HeaderText = "Cod."
                .Columns(2).HeaderText = "Descrição"
                .Columns(3).HeaderText = "Data"
                .Columns(4).HeaderText = "peso"
                .Columns(5).HeaderText = "Dose"
                .Columns(6).HeaderText = "Proxima"
                .Columns(0).Width = 30
                .Columns(1).Width = 40
                .Columns(2).Width = 120
                .Columns(3).Width = 67
                .Columns(4).Width = 41
                .Columns(5).Width = 70
                .Columns(6).Width = 67
                .Columns(0).Visible = False
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub carregaFormularioParasitario()
        Try
            limparParasitario()
            If dsContParasitario.Tables(0).Rows.Count > 0 Then
                atualizarParasitario = 2
                LbSeqParasita.Text = dsContParasitario.Tables(0).Rows(i)("seq_controle").ToString
                TxbCodParasita.Text = dsContParasitario.Tables(0).Rows(i)("cod_controle_parasita").ToString
                TxbDesParasita.Text = dsContParasitario.Tables(0).Rows(i)("nom_controle_parasita").ToString
                TxbDtaParasita.Text = dsContParasitario.Tables(0).Rows(i)("dta_controle").ToString
                TxbPesoParasita.Text = dsContParasitario.Tables(0).Rows(i)("qtd_peso").ToString
                TxbDoseParasita.Text = dsContParasitario.Tables(0).Rows(i)("des_dose").ToString
                TxbDtaProximaParasita.Text = dsContParasitario.Tables(0).Rows(i)("dta_proxima").ToString
            Else
                atualizar = 1
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class