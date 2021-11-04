Namespace macoratti
    Module Calculos
        Public Function Soma(ByVal v1 As Integer, ByVal v2 As Integer) As Integer
            Dim resultado As Integer
            resultado = v1 + v2
            Return resultado
        End Function
        Public Function Subtracao(ByVal v1 As Integer, ByVal v2 As Integer) As Integer
            If v1 >= v2 Then
                Return v1 - v2
            Else
                Return v2 - v1
            End If
        End Function
        Public Function Multiplicacao(ByVal v1 As Integer, ByVal v2 As Integer) As Integer
            Dim resultado As Integer
            resultado = v1 * v2
            Return resultado
        End Function
        Public Function Divisao(ByVal v1 As Single, ByVal v2 As Single) As Single
            Dim resultado As Single
            resultado = v1 / v2
            Return resultado
        End Function
    End Module
End Namespace