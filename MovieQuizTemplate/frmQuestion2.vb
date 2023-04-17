Public Class frmQuestion2
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer11.CheckedChanged

    End Sub

    Private Sub btnNext15_Click(sender As Object, e As EventArgs) Handles btnNext15.Click
        If (BtnAnswer13.Checked) Then
            playerScore = playerScore + 1
        End If
        frmQuestion3.Show()
        Me.Hide()

    End Sub
End Class