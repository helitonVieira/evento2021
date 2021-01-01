Public Class ClGeral
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL
    Dim ultimoFuncaoFuncionario As Integer
    Public Sub somenteNumero(e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
    Public Function somar(x As Double, y As Double)
        Dim s As Double
        s = x + y
        Return (s)
    End Function
    Public Function mutiplicar(x As Double, y As Double)
        Dim s As Double
        s = x * y
        Return (s)
    End Function
    Public Function Porcentagem(valor As Double, porcentage As Double)
        Dim total As Double
        total = (valor * porcentage) / 100
        Return (total)
    End Function
    Public Function JurosSimples(valor As Double, porcentagem As Double, qtdParcela As Double)
        Dim total As Double
        total = valor * (1 + ((porcentagem / 100) * qtdParcela))
        Return (total)
    End Function
    Public Function sqlBuscaDescricao(nomCampoDescricao As String, tabela As String, nomCampoCodigo As String, numCodigo As Integer)
        Dim tab As DataTable
        Try
            sql = "Select " & nomCampoDescricao & " as descricao From " & tabela & " where " & nomCampoCodigo & " =" & numCodigo & ""
            ds = con.Listar(sql)
            tab = ds.Tables(0)
            Return ds.Tables(0).Rows(0).Item("descricao")
        Catch ex As Exception
        End Try
    End Function
    Public Function sqlBuscaDescricao(nomCampoDescricao As String, tabela As String, desWhere As String)
        Dim tab As DataTable
        Try
            sql = "Select " & nomCampoDescricao & " as descricao From " & tabela & " where " & desWhere & ""
            ds = con.Listar(sql)
            tab = ds.Tables(0)
            Return ds.Tables(0).Rows(0).Item("descricao")
        Catch ex As Exception
        End Try
    End Function
End Class
