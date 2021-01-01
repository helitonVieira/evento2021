Public Class ClLicencia
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoSQL
    Public dataVectoLicencia As String

    ' Dim ultimoItem As Integer

    Private des_chave_ As String
    Public Property des_chave() As String
        Get
            Return des_chave_
        End Get
        Set(ByVal value As String)
            des_chave_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_licencia( des_chave) Values ('" & des_chave & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_licencia Set des_chave = '" & des_chave & "'"
        con.Operar(sql)
    End Sub
    Public Function buscaLicencia()
        sql = "Select des_chave From tab_licencia"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function verificarLicencia()
        Try
            Dim ds1 As New DataSet
            '  Dim lbLicencia As String

            '  Dim tabela As New DataTable
            ds1 = buscaLicencia()
            ' tabela = ds1.Tables(0)
            Dim linha As DataRow
            linha = ds1.Tables(0).Rows(0)
            Dim chave As String = linha.Item(0).ToString

            FrmPrincipal.lbLicencia.Text = ((Convert.ToInt32(chave.Chars(16) & chave.Chars(17) & chave.Chars(18) & chave.Chars(19)) / 83).ToString & "/" &
                                            (Convert.ToInt32(chave.Chars(10) & chave.Chars(11) & chave.Chars(12)) / 83).ToString & "/20" &
                                            (Convert.ToInt32(chave.Chars(2) & chave.Chars(3) & chave.Chars(4) & chave.Chars(5)) / 83).ToString)
            'quantidade de mes que valera a licencia 
            FrmPrincipal.lbLicencia.Text = (Convert.ToDateTime(FrmPrincipal.lbLicencia.Text).AddMonths(1)).ToString
            dataVectoLicencia = FrmPrincipal.lbLicencia.Text
            FrmPdv1.lbLicencia.Text = FrmPrincipal.lbLicencia.Text

            If Today.AddDays(9) > dataVectoLicencia Then
                MsgBox("LICENCIA VÁLIDA ATE " & dataVectoLicencia & "ENTRE EM CONTATO COM ADMINISTRADOR PARA RENOVAR A LICENCIA", MsgBoxStyle.Information, "Informação")
            End If
            If Today > dataVectoLicencia Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception

        End Try
    End Function
End Class
