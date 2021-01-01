Public Class ClParametroSistema
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoSQL

    Private dimFontProduto_ As String
    Public Property dimFontProduto() As Double
        Get
            Return dimFontProduto_
        End Get
        Set(ByVal value As Double)
            dimFontProduto_ = value
        End Set
    End Property

    Private dimFontIngresso_ As Double
    Public Property dimFontIngresso() As Double
        Get
            Return dimFontIngresso_
        End Get
        Set(ByVal value As Double)
            dimFontIngresso_ = value
        End Set
    End Property

    Private val_img_ingresso_tamanho_altura_ As Integer
    Public Property val_img_ingresso_tamanho_altura() As Integer
        Get
            Return val_img_ingresso_tamanho_altura_
        End Get
        Set(ByVal value As Integer)
            val_img_ingresso_tamanho_altura_ = value
        End Set
    End Property

    Private val_img_ingresso_tamanho_largura_ As Integer
    Public Property val_img_ingresso_tamanho_largura() As Integer
        Get
            Return val_img_ingresso_tamanho_largura_
        End Get
        Set(ByVal value As Integer)
            val_img_ingresso_tamanho_largura_ = value
        End Set
    End Property

    Private val_img_ingresso_margem_esquerda_ As Integer
    Public Property val_img_ingresso_margem_esquerda() As Integer
        Get
            Return val_img_ingresso_margem_esquerda_
        End Get
        Set(ByVal value As Integer)
            val_img_ingresso_margem_esquerda_ = value
        End Set
    End Property

    Private val_img_ingresso_margem_cabecalho_ As Integer
    Public Property val_img_ingresso_margem_cabecalho() As Integer
        Get
            Return val_img_ingresso_margem_cabecalho_
        End Get
        Set(ByVal value As Integer)
            val_img_ingresso_margem_cabecalho_ = value
        End Set
    End Property

    Private hra_inicio_agenda_servico_ As Integer
    Public Property hra_inicio_agenda_servico() As Integer
        Get
            Return hra_inicio_agenda_servico_
        End Get
        Set(ByVal value As Integer)
            hra_inicio_agenda_servico_ = value
        End Set
    End Property


    Public Sub Cadastrar()
        sql = "Insert Into tab_parametro_sistema(val_dimFontProduto,
                                                 val_dimFontIngresso,
                                                 val_img_ingresso_tamanho_altura 
                                                 val_img_ingresso_tamanho_largura
                                                 val_img_ingresso_margem_esquerda
                                                 val_img_ingresso_margem_cabecalho,
                                                 hra_inicio_agenda_servico )

                                         Values ('" & dimFontProduto & "',
                                                 '" & dimFontIngresso & "',
                                                  " & val_img_ingresso_tamanho_altura & ",
                                                  " & val_img_ingresso_tamanho_largura & ",
                                                  " & val_img_ingresso_margem_esquerda & ",
                                                  " & val_img_ingresso_margem_cabecalho & ",
                                                  " & hra_inicio_agenda_servico & ")"

        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_parametro_sistema 
                Set val_dimFontProduto = '" & dimFontProduto & "', 
                    val_dimFontIngresso = '" & dimFontIngresso & "',
                    val_img_ingresso_tamanho_altura = " & val_img_ingresso_tamanho_altura & ",
                    val_img_ingresso_tamanho_largura = " & val_img_ingresso_tamanho_largura & ",
                    val_img_ingresso_margem_esquerda = " & val_img_ingresso_margem_esquerda & ",
                    val_img_ingresso_margem_cabecalho = " & val_img_ingresso_margem_cabecalho & ",
                    hra_inicio_agenda_servico = " & hra_inicio_agenda_servico
        con.Operar(sql)
    End Sub
    Public Function consultarParametro()
        sql = "Select * From tab_parametro_sistema"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function posicaoTamanho20(ByVal x As Integer) As Integer
        If x = 1 Then
            Return 135
        ElseIf x = 2 Then
            Return 130
        ElseIf x = 3 Then
            Return 125
        ElseIf x = 4 Then
            Return 112
        ElseIf x = 5 Then
            Return 100
        ElseIf x = 6 Then
            Return 90
        ElseIf x = 7 Then
            Return 80
        ElseIf x = 8 Then
            Return 70
        ElseIf x = 9 Then
            Return 65
        ElseIf x = 10 Then
            Return 55
        ElseIf x = 11 Then
            Return 45
        ElseIf x = 12 Then
            Return 40
        ElseIf x = 13 Then
            Return 35
        ElseIf x = 14 Then
            Return 30
        ElseIf x = 15 Then
            Return 25
        ElseIf x = 16 Then
            Return 20
        ElseIf x = 17 Then
            Return 15
        ElseIf x = 18 Then
            Return 10
        ElseIf x >= 19 Then
            Return 0

        End If
    End Function
    Public Function posicaoTamanho14(ByVal x As Integer) As Integer
        If x = 1 Then
            Return 125
        ElseIf x = 2 Then
            Return 120
        ElseIf x = 3 Then
            Return 115
        ElseIf x = 4 Then
            Return 110
        ElseIf x = 5 Then
            Return 105
        ElseIf x = 6 Then
            Return 100
        ElseIf x = 7 Then
            Return 95
        ElseIf x = 8 Then
            Return 90
        ElseIf x = 9 Then
            Return 85
        ElseIf x = 10 Then
            Return 80
        ElseIf x = 11 Then
            Return 75
        ElseIf x = 12 Then
            Return 70
        ElseIf x = 13 Then
            Return 65
        ElseIf x = 14 Then
            Return 60
        ElseIf x = 15 Then
            Return 55
        ElseIf x = 16 Then
            Return 50
        ElseIf x = 17 Then
            Return 45
        ElseIf x = 18 Then
            Return 40
        ElseIf x = 19 Then
            Return 35
        ElseIf x = 20 Then
            Return 30
        ElseIf x >= 21 Then
            Return 25
        End If
    End Function

End Class
