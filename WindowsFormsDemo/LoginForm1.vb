Public Class LoginForm1

    ' TODO: Inserir c?digo para realizar autentica??o personalizada utilizando o nome de usu?rio e senha fornecidos 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de seguran?a personalizada pode ser anexada ? entidade de seguran?a da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal ? a implementa??o de IPrincipal usada para realizar a autentica??o. 
    ' Subsequentemente, My.User ir? retornar informa??es de identifica??o encapsuladas num objeto CustomPrincipal
    ' como nome de usu?rio, nome de exibi??o etc.
    Dim contador As Integer = 0
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If txtUsuario.Text = "macoratti" And txtSenha.Text = "123456" Then
            Me.Hide()
            My.Forms.Form1.ShowDialog()
        Else
            contador = contador + 1
            If contador < 4 Then
                MsgBox("Usuario/Senha inv?lido.")
            Else
                MsgBox("N?mero de tentativas excedidos.")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
