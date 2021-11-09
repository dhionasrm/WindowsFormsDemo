Public Class Calculadora

    Private operacao As Operacao
    Public Function somar(ByVal v1 As Integer, ByVal v2 As Integer) As Integer
        operacao = New Adicao
        operacao.Valor1 = v1
        operacao.Valor2 = v2
        Return operacao.Calcular()
    End Function
    Public Function subtrair(ByVal v1 As Integer, ByVal v2 As Integer)
        operacao = New Subtracao
        operacao.Valor1 = v1
        operacao.Valor2 = v2
        Return operacao.Calcular()
    End Function
    Public Function multiplicar(ByVal v1 As Integer, ByVal v2 As Integer)
        operacao = New Multiplicacao
        operacao.Valor1 = v1
        operacao.Valor2 = v2
        Return operacao.Calcular()
    End Function
    Public Function dividir(ByVal v1 As Integer, ByVal v2 As Integer)
        operacao = New Divisao
        operacao.Valor1 = v1
        operacao.Valor2 = v2
        Return operacao.Calcular()
    End Function
    Public Function raizQuadrada(ByVal v1 As Integer)
        operacao = New RaizQuadrada
        operacao.Valor1 = v1
        Return operacao.Calcular()
    End Function

End Class
