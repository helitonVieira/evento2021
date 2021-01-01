'Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports Npgsql
Imports System.Windows.Forms

Public Class ConexaoSQL
    'sqlServer retitar o 1
    'Private con1 As SqlConnection
    'Private adpt1 As SqlDataAdapter
    Public ds As New DataSet
    'Public cmd1 As SqlCommand
    'postgres 

    Private con As New NpgsqlConnection
    Private adpt As New NpgsqlDataAdapter
    Public cmd As New NpgsqlCommand
    Public caminhoBanco As String
    Public strCon As String
    ' Private strCon As String = "Data Source=localhost\SQLEXPRESS01;Initial catalog=evento;User Id =sa;Password=851213"
    ' Private strCon As String = "Data Source=DESKTOP-GMITBN3\SQLEXPRESS;Initial catalog=evento;User Id =sa;Password=851213"
    'Private strCon As String = ="Server=localhost;Port=5432;User Id=postgres;Password=851213;Database=VSystem"
    Public Sub pegarCaminhoArqTexto()
        Using sr As New StreamReader("c:\evento\caminhoBancoDados.txt")
            caminhoBanco = sr.ReadLine
            strCon = caminhoBanco
        End Using
    End Sub
    Public Sub Conectar()
        Try
            pegarCaminhoArqTexto()
            ' con = New SqlConnection(strCon)
            ' con.Open()
            con.ConnectionString = strCon
            con.Open()
            cmd.Connection = con
            MsgBox("Sucesso")
        Catch ex As Exception
            MsgBox("Erro ao tentar conectar", MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub
    Public Sub Operar(ByVal sql As String)
        pegarCaminhoArqTexto()
        ' con = New SqlConnection(strCon)
        con.ConnectionString = strCon
        Try
            con.Open()
            ' cmd = New SqlCommand(sql, con)
            '  cmd.ExecuteNonQuery()
            cmd = New NpgsqlCommand(sql, con)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox("Erro ao Gravar SQL" & ex.Message, MsgBoxStyle.Critical, "ERRO")
            ModParametroSistema.erro = True
        Finally
            con.Close()
        End Try
    End Sub

    Public Function Listar(ByVal sql As String)
        pegarCaminhoArqTexto()
        '  con = New SqlConnection(strCon)
        con.ConnectionString = strCon
        Try
            con.Open()
            ' adpt = New SqlDataAdapter(sql, con)
            adpt = New NpgsqlDataAdapter(sql, con)
            ds.Clear()
            adpt.Fill(ds)

        Catch ex As Exception
            MsgBox("Erro ao listar busca SQL" & ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            con.Close()
        End Try
        Return ds
    End Function
End Class
