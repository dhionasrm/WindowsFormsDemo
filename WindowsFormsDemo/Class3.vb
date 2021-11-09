Public Class Adicao
    Inherits Operacao


    Public Overrides Function Calcular() As Integer
        Return MyBase.Valor1 + MyBase.Valor2
    End Function
End Class
Public Class Subtracao
    Inherits Operacao

    Public Overrides Function Calcular() As Integer
        If Valor1 > Valor2 Then
            Return Valor1 - Valor2
        Else
            Return Valor1 - Valor2
        End If
    End Function
End Class
Public Class Multiplicacao
    Inherits Operacao

    Public Overrides Function Calcular() As Integer
        Return MyBase.Valor1 * MyBase.Valor2
    End Function
End Class
Public Class Divisao
    Inherits Operacao

    Public Overrides Function Calcular() As Integer
        Return Valor1 / Valor2
    End Function
End Class
Public Class RaizQuadrada
    Inherits Operacao
    Public Overrides Function Calcular() As Integer
        Return Math.Sqrt(Valor1)
    End Function
End Class
