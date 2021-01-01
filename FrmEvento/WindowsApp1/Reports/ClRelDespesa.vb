Public Class ClRelDespesa
    Dim sql As String
    Dim ds, dsUltimo As New DataSet
    Dim con As New ConexaoSQL

    Public Property seq_despesa As Integer
    Public Property num_documento As String
    Public Property dta_despesa As String
    Public Property dta_liquidacao As String
    Public Property cod_pessoa As Integer
    Public Property nom_pessoa As String
    Public Property cod_tipo_despesa As Integer
    Public Property des_tipo_despesa As String
    Public Property val_despesa As Double
    Public Property des_observacao As String

    Public Sub New()
    End Sub
    Public Sub New(ByVal seq_despesa As Integer, ByVal num_documento As String, ByVal dta_despesa As String,
ByVal dta_liquidacao As String, ByVal cod_pessoa As Integer, ByVal nom_pessoa As String,
ByVal cod_tipo_despesa As Integer, ByVal des_tipo_despesa As String, ByVal val_despesa As Double, ByVal des_observacao As String)

        Me.seq_despesa = seq_despesa
        Me.num_documento = num_documento
        Me.dta_despesa = dta_despesa
        Me.dta_liquidacao = dta_liquidacao
        Me.cod_pessoa = cod_pessoa
        Me.nom_pessoa = nom_pessoa
        Me.cod_tipo_despesa = cod_tipo_despesa
        Me.des_tipo_despesa = des_tipo_despesa
        Me.val_despesa = val_despesa
        Me.des_observacao = des_observacao
    End Sub
    Public Function ConsultarRel(dtaInicio As String, dtaFinal As String, cod_empresa As Integer,
                              cod_tipo_despesa As Integer, cod_pessoa As Integer)
        sql = "select a.seq_despesa,
                      a.num_documento,
                      a.dta_despesa,
                      a.dta_liquidacao,
                      b.cod_pessoa,
                      b.nom_pessoa,
                      a.cod_tipo_despesa,
                      c.des_tipo_despesa,
                      a.val_despesa,
                      a.des_observacao 
            from tab_despesa a 
            join tab_pessoa b on (a.cod_pessoa_favorecido = b.cod_pessoa)
            join tab_tipo_despesa c on (c.cod_tipo_despesa = a.cod_tipo_despesa)
            where a.dta_despesa  BETWEEN '" & dtaInicio & "' and  '" & dtaFinal & "'
              and ((a.cod_empresa = " & cod_empresa & " )or(" & cod_empresa & " = 0))
              and ((c.cod_tipo_despesa = " & cod_tipo_despesa & " )or(" & cod_tipo_despesa & " = 0))
              and ((b.cod_pessoa = " & cod_pessoa & " )or(" & cod_pessoa & " = 0))
            order by c.des_tipo_despesa,
                     a.dta_despesa,
                     b.nom_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function

End Class
