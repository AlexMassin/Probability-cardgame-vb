Public Class Modes

    Private Sub lblAdventure_Click(sender As System.Object, e As System.EventArgs) Handles lblAdventure.Click
        Adventure.Show()
        Me.Hide()

    End Sub

    Private Sub lblProbability_Click(sender As System.Object, e As System.EventArgs) Handles lblProbability.Click
        Probability.Show()
        Me.Hide()
    End Sub
End Class