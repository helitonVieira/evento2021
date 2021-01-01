Public Class FrmLogin
    Dim conectar As New ConexaoSQL
    Dim ds As New DataSet
    Dim clUsuario As New ClUsuario
    Public logout As Integer = 0
    Dim geral As New ClGeral


    Private Sub CbExibirSenha_CheckedChanged(sender As Object, e As EventArgs) Handles CbExibirSenha.CheckedChanged
        If CbExibirSenha.Checked = False Then
            TxtSenha.PasswordChar = "*"
        Else
            TxtSenha.PasswordChar = ""
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsuario.Text = ""
        TxtSenha.Text = ""
        TxtUsuario.Select()
    End Sub

    Private Sub TxtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            TxtSenha.Select()
        End If
    End Sub

    Private Sub TxtSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSenha.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            BtEntrar.Select()
        End If
    End Sub
    Private Sub BtEntrar_Click(sender As Object, e As EventArgs) Handles BtEntrar.Click
        verificacao()
    End Sub
    Public Sub verificacao()
        Try
            If TxtUsuario.Text = "" Then
                MsgBox("Informe o Usuário", MsgBoxStyle.Information, "INFORMAÇÃO")
                TxtUsuario.Select()
            End If
            If TxtSenha.Text = "" Then
                MsgBox("Informe o SENHA", MsgBoxStyle.Information, "INFORMAÇÃO")
                TxtSenha.Select()
            End If
            clUsuario.nom_usuario = TxtUsuario.Text
            clUsuario.des_senha = TxtSenha.Text
            ds = clUsuario.ConsultarGeral()
            Dim linha As DataRow
            For x As Integer = 0 To ds.Tables(0).Rows.Count
                linha = ds.Tables(0).Rows(x)

                ' linha = ds.Tables(0).Rows(1)
                ' MsgBox(linha.Item(1))
                If linha.Item(1).ToString.ToUpper = TxtUsuario.Text.ToUpper And linha.Item(2).ToString.ToUpper = TxtSenha.Text.ToUpper Then
                    If logout <> 2 Then
                        FrmEscolhaEmpresa.ShowDialog()
                    End If
                    FrmPrincipal.LbNomeUsuario.Text = linha.Item(1).ToString.ToUpper
                    FrmPrincipal.LbPermissaoUsuario.Text = linha.Item(3).ToString.ToUpper
                    ModParametroSistema.codUsuario = CUInt(linha.Item(0).ToString)
                    ModParametroSistema.nom_usuario = linha.Item(1)
                    ModParametroSistema.permissaoUsuario = linha.Item(3)
                    ModPermissaoUsuario.codUsuario = linha.Item(0)
                    ModParametroSistema.cod_pdv = geral.sqlBuscaDescricao("coalesce(cod_pdv,0)", "tab_pdv", "des_hostname = '" & System.Net.Dns.GetHostName & "' and 0", 0)
                    ' MsgBox("codigo pdv : " & ModParametroSistema.cod_pdv.ToString)
                    If IsNumeric(linha.Item(5)) Then
                        If linha.Item(5) > 0 Then
                            ModParametroSistema.codGrupoUsuario = linha.Item(5)
                            ModPermissaoUsuario.codGrupo = linha.Item(5)
                        Else
                            ModParametroSistema.codGrupoUsuario = 0
                            ModPermissaoUsuario.codGrupo = 0
                        End If
                    Else
                        ModParametroSistema.codGrupoUsuario = 0
                            ModPermissaoUsuario.codGrupo = 0
                        End If

                        Me.Hide()
                        If logout <> 2 Then
                            FrmPrincipal.ShowDialog()
                        End If
                        Exit Sub
                    End If
            Next

            MsgBox("USUÁRIO OU SENHA incorretos", MsgBoxStyle.Information, "INFORMAÇÃO")

        Catch ex As Exception
            MsgBox("Usuario ou senha incorreto!" & vbCrLf & "Erro ao tentar fazer login" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub BtEntrar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BtEntrar.KeyPress
        verificacao()
    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Me.Close()
    End Sub

End Class