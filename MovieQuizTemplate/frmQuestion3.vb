Public Class frmQuestion3
    Private Sub btnNext22_Click(sender As Object, e As EventArgs) Handles btnNext22.Click
        If (btnAnswer22.Checked) Then
            playerScore = playerScore + 1
        End If
        frmHighScore.Show()
        frmHighScore.doScore()
        Me.Hide()

    End Sub
End Class