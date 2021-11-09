Public Class Form1
    Dim calc As Calculos
    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        Try
            Dim valor1_txt As Integer = 0
            Dim valor2_txt As Integer = 0
            valor1_txt = CInt(txtValor1.Text)
            valor2_txt = CInt(txtValor2.Text)
            Dim calc As New Calculadora
            txtResultado.Text = calc.somar(valor1_txt, valor2_txt)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nome As String = "Calculadora Natural "
        Const COPYRIGHT As String = "(powered by Macoratti)"
        lblAviso.Text = nome.ToUpper & " " & COPYRIGHT.ToLower
    End Sub

    Private Sub txtValor1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor1.KeyPress, txtSub1.KeyPress, txtMult1.KeyPress, txtDiv1.KeyPress, txtRaizQuadrada.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnSubtrair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtrair.Click
        Dim valor1 As Integer = 0
        Dim valor2 As Integer = 0
        Try
            valor1 = CInt(txtSub1.Text)
            valor2 = CInt(txtSub2.Text)
            Dim calc As New Calculadora
            txtSubResultado.Text = calc.subtrair(valor1, valor2)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub
    Private Sub btnMultiplicar_Click(ByVal sender As System.Object, e As System.EventArgs) Handles btnMultiplicar.Click
        Dim valor1 As Integer = 0
        Dim valor2 As Integer = 0
        Try
            valor1 = CInt(txtMult1.Text)
            valor2 = CInt(txtMult2.Text)
            Dim calc As New Calculadora
            txtMultResultado.Text = calc.multiplicar(valor1, valor2)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDividir_Click(ByVal sender As System.Object, e As System.EventArgs) Handles btnDividir.Click
        Dim valor1 As Integer = 0
        Dim valor2 As Integer = 0
        Try
            valor1 = CInt(txtDiv1.Text)
            valor2 = CInt(txtDiv2.Text)
            Dim calc As New Calculadora
            txtDivResultado.Text = calc.dividir(valor1, valor2)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub
    Private Sub btnRaiz_Click(ByVal sender As System.Object, e As System.EventArgs) Handles btnRaiz.Click
        Dim valor1 As Single = 0
        Try
            valor1 = CSng(txtRaizQuadrada.Text)
            Dim calc As New Calculadora
            txtRaizResultado.Text = calc.raizQuadrada(valor1)
        Catch ex As Exception
            MsgBox("Ocorreu um erro : " & ex.Message)
        End Try
    End Sub

End Class
