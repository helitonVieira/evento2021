Module ModPermissaoUsuario

    '-----------------------Sistema
    Public t1001 As Boolean = False
    Public t10011 As Boolean = False
    Public t10012 As Boolean = False
    Public t100101 As Boolean = False
    Public t1001011 As Boolean = False
    Public t1001012 As Boolean = False
    Public t100102 As Boolean = False
    Public t1001021 As Boolean = False
    Public t1001022 As Boolean = False
    Public t100103 As Boolean = False
    Public t1001031 As Boolean = False
    Public t1001032 As Boolean = False
    Public t1002 As Boolean = False
    Public t10021 As Boolean = False
    Public t10022 As Boolean = False
    Public t1003 As Boolean = False
    Public t10031 As Boolean = False
    Public t10032 As Boolean = False
    '-----------------Pessoa  '-----------------Pessoa   	'-----------------Pessoa
    Public t110101 As Boolean = False
    Public t1101011 As Boolean = False
    Public t1101012 As Boolean = False
    Public t110102 As Boolean = False
    Public t1101021 As Boolean = False
    Public t1101022 As Boolean = False
    Public t1102 As Boolean = False
    Public t11021 As Boolean = False
    Public t11022 As Boolean = False
    '----------------Estoque               '----------------Estoque              '----------------Estoque
    Public t120101 As Boolean = False
    Public t1201011 As Boolean = False
    Public t1201012 As Boolean = False
    Public t120102 As Boolean = False
    Public t1201021 As Boolean = False
    Public t1201022 As Boolean = False
    Public t120103 As Boolean = False
    Public t1201031 As Boolean = False
    Public t1201032 As Boolean = False
    Public t120104 As Boolean = False
    Public t1201041 As Boolean = False
    Public t1201042 As Boolean = False
    Public t120105 As Boolean = False
    Public t1201051 As Boolean = False
    Public t1201052 As Boolean = False
    Public t120106 As Boolean = False
    Public t1201061 As Boolean = False
    Public t1201062 As Boolean = False
    Public t120107 As Boolean = False
    Public t1201071 As Boolean = False
    Public t1201072 As Boolean = False
    Public t12010801 As Boolean = False
    Public t120108011 As Boolean = False
    Public t120108012 As Boolean = False
    Public t1202 As Boolean = False
    Public t12021 As Boolean = False
    Public t12022 As Boolean = False
    '-------------Administrativo           '-------------Administrativo          '-------------Administrativo
    Public t130101 As Boolean = False
    Public t1301011 As Boolean = False
    Public t1301012 As Boolean = False
    Public t130102 As Boolean = False
    Public t1301021 As Boolean = False
    Public t1301022 As Boolean = False
    Public t13010301 As Boolean = False
    Public t130103011 As Boolean = False
    Public t130103012 As Boolean = False
    Public t130201 As Boolean = False
    Public t1302011 As Boolean = False
    Public t1302012 As Boolean = False
    Public t130202 As Boolean = False
    Public t1302021 As Boolean = False
    Public t1302022 As Boolean = False
    Public t13020301 As Boolean = False
    Public t130203011 As Boolean = False
    Public t130203012 As Boolean = False
    '--------PDV                           '--------PDV                          '--------PDV
    Public t140101 As Boolean = False
    Public t1401011 As Boolean = False
    Public t1401012 As Boolean = False
    Public t140102 As Boolean = False
    Public t1401021 As Boolean = False
    Public t1401022 As Boolean = False
    Public t140103 As Boolean = False
    Public t1401031 As Boolean = False
    Public t1401032 As Boolean = False
    Public t140201 As Boolean = False
    Public t1402011 As Boolean = False
    Public t1402012 As Boolean = False
    Public t14020201 As Boolean = False
    Public t140202011 As Boolean = False
    Public t140202012 As Boolean = False
    Public t140301 As Boolean = False
    Public t1403011 As Boolean = False
    Public t1403012 As Boolean = False
    Public t140401 As Boolean = False
    Public t1404011 As Boolean = False
    Public t1404012 As Boolean = False
    Public t140402 As Boolean = False
    Public t1404021 As Boolean = False
    Public t1404022 As Boolean = False
    '--------Financeiro                    '--------Financeiro                   '--------Financeiro
    Public t150101 As Boolean = False
    Public t1501011 As Boolean = False
    Public t1501012 As Boolean = False
    Public t150201 As Boolean = False
    Public t1502011 As Boolean = False
    Public t1502012 As Boolean = False
    Public t1503 As Boolean = False
    Public t15031 As Boolean = False
    Public t15032 As Boolean = False
    Public t150401 As Boolean = False
    Public t1504011 As Boolean = False
    Public t1504012 As Boolean = False
    Public t15040201 As Boolean = False
    Public t150402011 As Boolean = False
    Public t150402012 As Boolean = False
    Public t150501 As Boolean = False
    Public t1505011 As Boolean = False
    Public t1505012 As Boolean = False
    Public t15050201 As Boolean = False
    Public t150502011 As Boolean = False
    Public t150502012 As Boolean = False
    Public t1506 As Boolean = False
    Public t15061 As Boolean = False
    Public t15062 As Boolean = False
    '----------relatorios                  '----------relatorios                 '----------relatorios
    Public t160101 As Boolean = False
    Public t1601011 As Boolean = False
    Public t1601012 As Boolean = False
    Public t160201 As Boolean = False
    Public t1602011 As Boolean = False
    Public t1602012 As Boolean = False
    Public t160202 As Boolean = False
    Public t1602021 As Boolean = False
    Public t1602022 As Boolean = False
    Public t160301 As Boolean = False
    Public t1603011 As Boolean = False
    Public t1603012 As Boolean = False
    '----------Pets                        '----------Pets                       '----------Pets
    Public t170101 As Boolean = False
    Public t1701011 As Boolean = False
    Public t1701012 As Boolean = False
    Public t170102 As Boolean = False
    Public t1701021 As Boolean = False
    Public t1701022 As Boolean = False
    Public t170103 As Boolean = False
    Public t1701031 As Boolean = False
    Public t1701032 As Boolean = False
    Public t170104 As Boolean = False
    Public t1701041 As Boolean = False
    Public t1701042 As Boolean = False
    Public t1702 As Boolean = False
    Public t17021 As Boolean = False
    Public t17022 As Boolean = False
    Public t1703 As Boolean = False
    Public t17031 As Boolean = False
    Public t17032 As Boolean = False
    '------------Eventos                   '------------Eventos                  '------------Eventos
    Public t180101 As Boolean = False
    Public t1801011 As Boolean = False
    Public t1801012 As Boolean = False
    Public t180102 As Boolean = False
    Public t1801021 As Boolean = False
    Public t1801022 As Boolean = False
    Public t180201 As Boolean = False
    Public t1802011 As Boolean = False
    Public t1802012 As Boolean = False
    Public codUsuario, codGrupo As Integer
    Private codTela As Integer
    Public Sub permissaoAcesso(usuarioOuGrupo As String)
        If ModParametroSistema.permissaoUsuario = "MASTER" Then
            Exit Sub
        End If
        Dim ds As DataSet
        Dim dt As DataTable
        Dim userTela As New ClUsuarioTela
        Dim grupoTela As New ClGrupoUsuarioTela
        If usuarioOuGrupo = "usuario" Then
            ds = userTela.ConsultarPesquisa(codUsuario.ToString)
            dt = ds.Tables(0)
        Else
            ds = grupoTela.ConsultarPesquisa(codGrupo.ToString)
            dt = ds.Tables(0)
        End If


        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                codTela = row.Item("cod_tela_acesso")
                Select Case codTela    '------------------------------------------sistema
                    Case 1001010 'Grupo usuario
                        t100101 = True
                    Case 1001011
                        t1001011 = True
                    Case 1001012
                        t1001012 = True
                    Case 1001020   'Usuaria
                        t100102 = True
                    Case 1001021
                        t1001021 = True
                    Case 1001022
                        t1001022 = True
                    Case 1001030 'controle acesso 
                        t100103 = True
                    Case 1001031
                        t1001031 = True
                    Case 1001032
                        t1001032 = True
                    Case 10020 'parametro sistema acesso 
                        t1002 = True
                    Case 10021
                        t10021 = True
                    Case 10022
                        t10022 = True
                    Case 10030 'licencia acesso 
                        t1003 = True
                    Case 10031
                        t10031 = True
                    Case 10032
                        t10032 = True
                    Case 1101010 'Pessoa  '------------------------------------------Pessoa
                        t110101 = True
                    Case 1101011
                        t1101011 = True
                    Case 1101012
                        t1101012 = True
                    Case 1101020 'Funcao funcionario 
                        t110102 = True
                    Case 1101021
                        t1101021 = True
                    Case 1101022
                        t1101022 = True
                    Case 11020 'cidade
                        t1102 = True
                    Case 11021
                        t11021 = True
                    Case 11022
                        t11022 = True
                    Case 1201010 'almoxarifado  '------------------------------------------estoque
                        t120101 = True
                    Case 1201011
                        t1201011 = True
                    Case 1201012
                        t1201012 = True
                    Case 1201020 'secao
                        t120102 = True
                    Case 1201021
                        t1201021 = True
                    Case 1201022
                        t1201022 = True
                    Case 1201030 'categoria
                        t120103 = True
                    Case 1201031
                        t1201031 = True
                    Case 1201032
                        t1201032 = True
                    Case 1201040 'subcategoria
                        t120104 = True
                    Case 1201041
                        t1201041 = True
                    Case 1201042
                        t1201042 = True
                    Case 1201050 'item
                        t120105 = True
                    Case 1201051
                        t1201051 = True
                    Case 1201052
                        t1201052 = True
                    Case 1201060 'unidade
                        t120106 = True
                    Case 1201061
                        t1201061 = True
                    Case 1201062
                        t1201062 = True
                    Case 1201070 'marca
                        t120107 = True
                    Case 1201071
                        t1201071 = True
                    Case 1201072
                        t1201072 = True
                    Case 120108010 'rel item
                        t12010801 = True
                    Case 120108011
                        t120108011 = True
                    Case 120108012
                        t120108012 = True
                    Case 12020 'inventario rapido
                        t1202 = True
                    Case 12021
                        t12021 = True
                    Case 12022
                        t12022 = True
                    Case 1301010 'Tipo despesa    '------------------------------------------administrativo
                        t130101 = True
                    Case 1301011
                        t1301011 = True
                    Case 1301012
                        t1301012 = True
                    Case 1301020 'despesa
                        t130102 = True
                    Case 1301021
                        t1301021 = True
                    Case 1301022
                        t1301022 = True
                    Case 130103010 'rel despesa
                        t13010301 = True
                    Case 130103011
                        t130103011 = True
                    Case 130103012
                        t130103012 = True
                    Case 1302010 'Tipo receita
                        t130201 = True
                    Case 1302011
                        t1302011 = True
                    Case 1302012
                        t1302012 = True
                    Case 1302020 'receita
                        t130202 = True
                    Case 1302021
                        t1302021 = True
                    Case 1302022
                        t1302022 = True
                    Case 130203010 'rel receita
                        t13020301 = True
                    Case 130203011
                        t130203011 = True
                    Case 130203012
                        t130203012 = True
                         '-----------------------------------------PDV
                    Case 1401010 'Cadastro pdv
                        t140101 = True
                    Case 1401011
                        t1401011 = True
                    Case 1401012
                        t1401012 = True
                    Case 1401020 'pdv1
                        t140102 = True
                    Case 1401021
                        t1401021 = True
                    Case 1401022
                        t1401022 = True

                    Case 1401030 'pdv2
                        t140103 = True
                    Case 1401031
                        t1401031 = True
                    Case 1401032
                        t1401032 = True

                    Case 1402010 'agenda servico
                        t140201 = True
                    Case 1402011
                        t1402011 = True
                    Case 1402012
                        t1402012 = True
                    Case 140202010 'rel comissao agenda servico
                        t14020201 = True
                    Case 140202011
                        t140202011 = True
                    Case 140202012
                        t140202012 = True
                    Case 1403010 ' rel vendas por sub categoria
                        t140301 = True
                    Case 1403011
                        t1403011 = True
                    Case 1403012
                        t1403012 = True
                    Case 1404010 ' Fechamento de caixa 
                        t140401 = True
                    Case 1404011
                        t1404011 = True
                    Case 1404012
                        t1404012 = True
                    Case 1404020 ' Abertura de caixa 
                        t140402 = True
                    Case 1404021
                        t1404021 = True
                    Case 1404022
                        t1404022 = True
                         '------------------------------------------financeiro
                    Case 1501010 ' especie 
                        t150101 = True
                    Case 1501011
                        t1501011 = True
                    Case 1501012
                        t1501012 = True
                    Case 1502010 ' banco 
                        t150201 = True
                    Case 1502011
                        t1502011 = True
                    Case 1502012
                        t1502012 = True
                    Case 15030 ' tipo parcelamento 
                        t1503 = True
                    Case 15031
                        t15031 = True
                    Case 15032
                        t15032 = True
                    Case 1504010 ' titulo pagar 
                        t150401 = True
                    Case 1504011
                        t1504011 = True
                    Case 1504012
                        t1504012 = True
                    Case 150402010 ' relatorio titulo a pagar 
                        t15040201 = True
                    Case 150402011
                        t150402011 = True
                    Case 150402012
                        t150402012 = True
                    Case 1505010 ' titulo receber 
                        t150501 = True
                    Case 1505011
                        t1505011 = True
                    Case 1505012
                        t1505012 = True
                    Case 150502010 ' relatorio titulo a receber 
                        t15050201 = True
                    Case 150502011
                        t150502011 = True
                    Case 150502012
                        t150502012 = True
                    Case 15060 ' Tipo Cobranca
                        t1506 = True
                    Case 15061
                        t15061 = True
                    Case 15062
                        t15062 = True

                    Case 1601010 ' rel despesa  ------------------------relatorios                   
                        t160101 = True
                    Case 1601011
                        t1601011 = True
                    Case 1601012
                        t1601012 = True
                    Case 1602010 ' relatorio vendas por subcategoria 
                        t160201 = True
                    Case 1602011
                        t1602011 = True
                    Case 1602012
                        t1602012 = True
                    Case 1602020 ' relatorio venda por cliente
                        t160202 = True
                    Case 1602021
                        t1602021 = True
                    Case 1602022
                        t1602022 = True
                    Case 1603010 ' relatorio movimento estoque
                        t160301 = True
                    Case 1603011
                        t1603011 = True
                    Case 1603012
                        t1603012 = True
                    Case 1701010 ' especie ------------------------------pet
                        t170101 = True
                    Case 1701011
                        t1701011 = True
                    Case 1701012
                        t1701012 = True
                    Case 1701020 ' raca 
                        t170102 = True
                    Case 1701021
                        t1701021 = True
                    Case 1701022
                        t1701022 = True
                    Case 1701030 ' pelagem 
                        t170103 = True
                    Case 1701031
                        t1701031 = True
                    Case 1701032
                        t1701032 = True
                    Case 1701040 ' animal 
                        t170104 = True
                    Case 1701041
                        t1701041 = True
                    Case 1701042
                        t1701042 = True
                    Case 17020 ' controle vacina 
                        t1702 = True
                    Case 17021
                        t17021 = True
                    Case 17022
                        t17022 = True
                    Case 17030 ' controle parasita 
                        t1703 = True
                    Case 17031
                        t17031 = True
                    Case 17032
                        t17032 = True
                    Case 1801010 ' evento ----------------------------eventos
                        t180101 = True
                    Case 1801011
                        t1801011 = True
                    Case 1801012
                        t1801011 = True
                    Case 1801020 ' imprimir ingresso
                        t180102 = True
                    Case 1801022
                        t1801021 = True
                    Case 1801022
                        t1801021 = True
                    Case 1802010 ' rel ingresso impresso
                        t180201 = True
                    Case 1802011
                        t1802011 = True
                    Case 1802012
                        t1802012 = True
                End Select
            Next
        End If
        FrmPrincipal.carregaPermissaoUsuario()
    End Sub
    Public Sub limparPermissaoAcesso()
        If ModParametroSistema.permissaoUsuario = "MASTER" Then
            Exit Sub
        End If
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t10011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t10012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t100101 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1001011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1001012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t100102 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1001021 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1001022 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t100103 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1001031 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1001032 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1002 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t10021 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t10022 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1003 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t10031 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t10032 = False
        ModPermissaoUsuario.t1001 = False

        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t110101 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1101011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1101012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t110102 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1101021 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1101022 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1102 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t11021 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t11022 = False
        ModPermissaoUsuario.t1001 = False

        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t120101 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1201011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1201012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t120102 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1201021 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1201022 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t120103 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1201031 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1201032 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t120104 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1201041 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1201042 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t120105 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1201051 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1201052 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t120106 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1201061 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1201062 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t120107 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1201071 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1201072 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t12010801 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t120108011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t120108012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1202 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t12021 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t12022 = False
        ModPermissaoUsuario.t1001 = False

        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t130101 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1301011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1301012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t130102 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1301021 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1301022 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t13010301 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t130103011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t130103012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t130201 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1302011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1302012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t130202 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1302021 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1302022 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t13020301 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t130203011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t130203012 = False
        ModPermissaoUsuario.t1001 = False

        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t140101 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1401011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1401012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t140102 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1401021 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1401022 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t140103 = False
        ModPermissaoUsuario.t1401031 = False
        ModPermissaoUsuario.t1401032 = False
        ModPermissaoUsuario.t140201 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1402011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1402012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t14020201 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t140202011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t140202012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t140301 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1403011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1403012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t140401 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1404011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1404012 = False
        ModPermissaoUsuario.t140402 = False
        ModPermissaoUsuario.t1404021 = False
        ModPermissaoUsuario.t1404022 = False

        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t150101 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1501011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1501012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t150201 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1502011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1502012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1503 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t15031 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t15032 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t150401 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1504011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1504012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t15040201 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t150402011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t150402012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t150501 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1505011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1505012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t15050201 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t150502011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t150502012 = False
        ModPermissaoUsuario.t1506 = False
        ModPermissaoUsuario.t15061 = False
        ModPermissaoUsuario.t15062 = False

        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t160101 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1601011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1601012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t160201 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1602011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1602012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t160202 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1602021 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1602022 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t160301 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1603011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1603012 = False
        ModPermissaoUsuario.t1001 = False

        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t170101 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1701011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1701012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t170102 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1701021 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1701022 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t170103 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1701031 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1701032 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t170104 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1701041 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1701042 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1702 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t17021 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t17022 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1703 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t17031 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t17032 = False
        ModPermissaoUsuario.t1001 = False

        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t180101 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1801011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1801012 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t180102 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1801021 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1801022 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t180201 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1802011 = False
        ModPermissaoUsuario.t1001 = False
        ModPermissaoUsuario.t1802012 = False
    End Sub
    Public Sub habilitarTodasPermissaoAcesso()
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t10011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t10012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t100101 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1001011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1001012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t100102 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1001021 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1001022 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t100103 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1001031 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1001032 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1002 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t10021 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t10022 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1003 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t10031 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t10032 = True
        ModPermissaoUsuario.t1001 = True

        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t110101 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1101011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1101012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t110102 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1101021 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1101022 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1102 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t11021 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t11022 = True
        ModPermissaoUsuario.t1001 = True

        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t120101 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1201011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1201012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t120102 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1201021 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1201022 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t120103 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1201031 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1201032 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t120104 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1201041 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1201042 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t120105 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1201051 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1201052 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t120106 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1201061 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1201062 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t120107 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1201071 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1201072 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t12010801 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t120108011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t120108012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1202 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t12021 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t12022 = True
        ModPermissaoUsuario.t1001 = True

        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t130101 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1301011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1301012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t130102 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1301021 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1301022 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t13010301 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t130103011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t130103012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t130201 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1302011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1302012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t130202 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1302021 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1302022 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t13020301 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t130203011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t130203012 = True
        ModPermissaoUsuario.t1001 = True

        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t140101 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1401011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1401012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t140102 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1401021 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1401022 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t140103 = True
        ModPermissaoUsuario.t1401031 = True
        ModPermissaoUsuario.t1401032 = True
        ModPermissaoUsuario.t140201 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1402011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1402012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t14020201 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t140202011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t140202012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t140301 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1403011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1403012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t140401 = True
        ModPermissaoUsuario.t1404011 = True
        ModPermissaoUsuario.t1404012 = True
        ModPermissaoUsuario.t140402 = True
        ModPermissaoUsuario.t1404021 = True
        ModPermissaoUsuario.t1404022 = True

        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t150101 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1501011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1501012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t150201 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1502011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1502012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1503 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t15031 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t15032 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t150401 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1504011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1504012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t15040201 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t150402011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t150402012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t150501 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1505011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1505012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t15050201 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t150502011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t150502012 = True
        ModPermissaoUsuario.t1506 = True
        ModPermissaoUsuario.t15061 = True
        ModPermissaoUsuario.t15062 = True

        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t160101 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1601011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1601012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t160201 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1602011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1602012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t160202 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1602021 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1602022 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t160301 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1603011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1603012 = True
        ModPermissaoUsuario.t1001 = True

        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t170101 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1701011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1701012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t170102 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1701021 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1701022 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t170103 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1701031 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1701032 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t170104 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1701041 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1701042 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1702 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t17021 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t17022 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1703 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t17031 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t17032 = True
        ModPermissaoUsuario.t1001 = True

        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t180101 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1801011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1801012 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t180102 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1801021 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1801022 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t180201 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1802011 = True
        ModPermissaoUsuario.t1001 = True
        ModPermissaoUsuario.t1802012 = True
    End Sub
End Module
