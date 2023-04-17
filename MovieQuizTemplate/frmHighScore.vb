Public Class frmHighScore
    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Public Sub doScore()
        If (playerScore < 1) Then
            lblMessage.Text = "sorry yoour Score was not good enough"
        Else
            lblMessage.Text = "Congratulations your score will be added to the hall of fame!!"
            IstHighScore.Items.Add(playerName & vbTab & vbTab & playerScore)


            Application.Exit()

        End If
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click

    End Sub

    Private Sub IstHighScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IstHighScore.SelectedIndexChanged

    End Sub
End Class