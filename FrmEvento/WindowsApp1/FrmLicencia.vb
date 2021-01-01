Public Class FrmLicencia
    Dim data1 As Date = Today
    Dim ano, mes, dia As String
    Dim anoI, mesI, diaI As Integer
    Dim principal As New FrmPrincipal

    Private Sub FrmLicencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Permissao acesso
        If ModParametroSistema.permissaoUsuario <> "MASTER" Then
            BtnSalvar.Enabled = ModPermissaoUsuario.t10031

        End If
        TxtChave.Text = ""
        TxtChave.Select()
    End Sub

    Dim anoDigitado, mesDigitado, diaDigitado As String
    Dim clLicencia As New ClLicencia
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Me.Close()
    End Sub
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Try

            If TxtChave.Text.Chars(0) <> "H" Then
                MsgBox("CHAVE ESTA INCORRETA")
                Exit Sub
            End If
            If TxtChave.Text.Chars(1) <> "E" Then
                MsgBox("CHAVE ESTA INCORRETA")
                Exit Sub
            End If
            'data de hoje separando
            ano = data1.ToString.Chars(8) & data1.ToString.Chars(9)
            mes = data1.ToString.Chars(3) & data1.ToString.Chars(4)
            dia = data1.ToString.Chars(0) & data1.ToString.Chars(1)
            ' MsgBox(data1 & "dia" & dia & "mes" & mes & "ano" & ano)
            anoDigitado = TxtChave.Text.Chars(2) & TxtChave.Text.Chars(3) & TxtChave.Text.Chars(4) & TxtChave.Text.Chars(5)
            anoI = Convert.ToInt32(ano) * 83
            ano = anoI.ToString
            If ano <> anoDigitado Then
                MsgBox("CHAVE ESTA INCORRETA")
                Exit Sub
            End If
            If TxtChave.Text.Chars(6) <> "-" Then
                MsgBox("CHAVE ESTA INCORRETA")
                Exit Sub
            End If
            If TxtChave.Text.Chars(7) <> "L" Then
                MsgBox("CHAVE ESTA INCORRETA")
                Exit Sub
            End If
            If TxtChave.Text.Chars(8) <> "I" Then
                MsgBox("CHAVE ESTA INCORRETA")
                Exit Sub
            End If
            If TxtChave.Text.Chars(9) <> "0" Then
                MsgBox("CHAVE ESTA INCORRETA")
                Exit Sub
            End If
            'mes
            mesDigitado = TxtChave.Text.Chars(10) & TxtChave.Text.Chars(11) & TxtChave.Text.Chars(12)
            mesI = Convert.ToInt32(mes) * 83
            If mesI.ToString = "83" Then
                mes = "083"
            Else
                mes = mesI.ToString
            End If

            If mes <> mesDigitado Then
                MsgBox("CHAVE ESTA INCORRETA")
                Exit Sub
            End If

            If TxtChave.Text.Chars(13) <> "-" Then
                MsgBox("CHAVE ESTA INCORRETA")
                Exit Sub
            End If
            If TxtChave.Text.Chars(14) <> "T" Then
                MsgBox("CHAVE ESTA INCORRETA")
                Exit Sub
            End If
            If TxtChave.Text.Chars(15) <> "O" Then
                MsgBox("CHAVE ESTA INCORRETA")
                Exit Sub
            End If
            diaI = Convert.ToInt32(dia) * 83
            dia = diaI.ToString
            If dia.Count = 3 Then
                If TxtChave.Text.Chars(16) <> "0" Then
                    MsgBox("CHAVE ESTA INCORRETA")
                    Exit Sub
                End If
                diaDigitado = TxtChave.Text.Chars(17) & TxtChave.Text.Chars(18) & TxtChave.Text.Chars(19)
            Else
                diaDigitado = TxtChave.Text.Chars(16) & TxtChave.Text.Chars(17) & TxtChave.Text.Chars(18) & TxtChave.Text.Chars(19)
            End If
            ' diaDigitado = TxtChave.Text.Chars(17) & TxtChave.Text.Chars(18) & TxtChave.Text.Chars(19)

            If dia <> diaDigitado Then
                MsgBox("CHAVE ESTA INCORRETA")
                Exit Sub
            End If
            clLicencia.des_chave = TxtChave.Text
            clLicencia.Atualizar()
            If ModParametroSistema.erro Then
                ModParametroSistema.erro = False
                Exit Sub
            End If
            MsgBox("Licencia atualizada com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            principal.licenciaVerifica()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class