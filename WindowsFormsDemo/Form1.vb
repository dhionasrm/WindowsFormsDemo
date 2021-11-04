Public Class Form1

    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        Try
            Dim valor1 As Integer = 0
            Dim valor2 As Integer = 0
            valor1 = CInt(txtValor1.Text)
            valor2 = CInt(txtValor2.Text)
            txtResultado.Text = Soma(valor1, valor2)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const COPYRIGHT As String = "Calculadora Natural (powered by Macoratti)"
        lblAviso.Text = COPYRIGHT
    End Sub

    Private Sub txtValor1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor1.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
