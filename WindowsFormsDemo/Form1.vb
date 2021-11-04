Public Class Form1

    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        Try
            Dim valor1 As Integer = 0
            Dim valor2 As Integer = 0
            valor1 = CInt(txtValor1.Text)
            valor2 = CInt(txtValor2.Text)
            txtResultado.Text = macoratti.Soma(valor1, valor2)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nome As String = "Calculadora Natural "
        Const COPYRIGHT As String = "(powered by Macoratti)"
        lblAviso.Text = nome.ToUpper & " " & COPYRIGHT.ToLower
    End Sub

    Private Sub txtValor1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor1.KeyPress, txtSub1.KeyPress, txtMult1.KeyPress, txtDiv1.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnSubtrair_Click(sender As Object, e As EventArgs) Handles btnSubtrair.Click
        Dim valor1 As Integer = 0
        Dim valor2 As Integer = 0
        Try
            valor1 = CInt(txtSub1.Text)
            valor2 = CInt(txtSub2.Text)
            txtSubResultado.Text = macoratti.Subtracao(valor1, valor2)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub
    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        Dim valor1 As Integer = 0
        Dim valor2 As Integer = 0
        Try
            valor1 = CInt(txtMult1.Text)
            valor2 = CInt(txtMult2.Text)
            txtMultResultado.Text = macoratti.Multiplicacao(valor1, valor2)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        Dim valor1 As Single = 0
        Dim valor2 As Single = 0
        Try
            valor1 = CSng(txtDiv1.Text)
            valor2 = CSng(txtDiv2.Text)
            txtDivResultado.Text = macoratti.Divisao(valor1, valor2)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub
End Class
