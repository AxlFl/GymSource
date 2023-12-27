Public Class newmember



    Private Sub check_male_CheckedChanged(sender As Object, e As EventArgs) Handles check_male.CheckedChanged
        If check_male.Checked Then
            check_female.Checked = False

        End If

    End Sub


    Private Sub check_female_CheckedChanged(sender As Object, e As EventArgs) Handles check_female.CheckedChanged
        If check_female.Checked Then
            check_male.Checked = False
        End If

    End Sub

    Private Sub txt_names_TextChanged(sender As Object, e As EventArgs) Handles txt_names.TextChanged

    End Sub

    Private Sub txt_lastname_TextChanged(sender As Object, e As EventArgs) Handles txt_lastname.TextChanged

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub check_morning_CheckedChanged(sender As Object, e As EventArgs) Handles check_morning.CheckedChanged
        If check_morning.Checked Then
            check_night.Checked = False
        End If
    End Sub

    Private Sub check_night_CheckedChanged(sender As Object, e As EventArgs) Handles check_night.CheckedChanged
        If check_night.Checked Then
            check_morning.Checked = False
        End If
    End Sub
End Class