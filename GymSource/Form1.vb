Public Class LoginScreen
    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim formmenu As New Menu()
        formmenu.Show()
        Me.Hide()

    End Sub
End Class
