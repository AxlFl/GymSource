Public Class Menu

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        LoginScreen.Show()
        Me.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        LoginScreen.Close()
    End Sub

    Private Sub btn_newmember_Click(sender As Object, e As EventArgs) Handles btn_newmember.Click
        OpenChildForm(New newmember())
    End Sub

    Private currentform As Form = Nothing
    Private Sub OpenChildForm(childform As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = childform
        childform.TopLevel = False
        childform.Dock = DockStyle.Fill
        panelholder.Controls.Add(childform)
        panelholder.Tag = childform
        childform.Show()
    End Sub

    Private Sub btn_memberlist_Click(sender As Object, e As EventArgs) Handles btn_memberlist.Click
        OpenChildForm(New MemberList())
    End Sub

    Private Sub btn_payment_Click(sender As Object, e As EventArgs) Handles btn_payment.Click
        OpenChildForm(New paymentsinfo())
    End Sub
End Class