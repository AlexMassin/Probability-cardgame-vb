Public Class Probability
    '.------..------..------..------..------..------..------..------..------..------..------.
    '|P.--. ||R.--. ||O.--. ||B.--. ||A.--. ||B.--. ||I.--. ||L.--. ||I.--. ||T.--. ||Y.--. |
    '| :/\: || :(): || :/\: || :(): || (\/) || :(): || (\/) || :/\: || (\/) || :/\: || (\/) |
    '| (__) || ()() || :\/: || ()() || :\/: || ()() || :\/: || (__) || :\/: || (__) || :\/: |
    '| '--'P|| '--'R|| '--'O|| '--'B|| '--'A|| '--'B|| '--'I|| '--'L|| '--'I|| '--'T|| '--'Y|
    '`------'`------'`------'`------'`------'`------'`------'`------'`------'`------'`------'
    'Alex Massin 11a


    Private Sub btnShuffle_Click(sender As System.Object, e As System.EventArgs) Handles btnShuffle.Click
        Dim playerTotal As Integer
        Dim compTotal As Integer
        Static compWins As Integer
        Static playWins As Integer
        Static drawScore As Integer
        Call DealCard(picPlayerCard1, playerTotal)     'This calls upon the DealCard procedure so that we can randomize all six cards on the form
        Call DealCard(picPlayerCard2, playerTotal)     'It does it six times because there are three cards for player and three cards for computer
        Call DealCard(picPlayerCard3, playerTotal)
        Call DealCard(picCompCard1, compTotal)
        Call DealCard(picCompCard2, compTotal)
        Call DealCard(picCompCard3, compTotal)

        Me.lblCCount.Text = compTotal                 'This makes the total that the cards make visible to the player
        Me.lblPCount.Text = playerTotal
        If winner(playerTotal, compTotal) = "Player" Then
            Call UpdateScore(playWins)                       'The next couple if statements deal with using the winner function and calling the procedures called UpdateScore and ShowScore
            Call ShowScore(playWins, compWins, drawScore)
        ElseIf winner(playerTotal, compTotal) = "Computer" Then
            Call UpdateScore(compWins)
            Call ShowScore(playWins, compWins, drawScore)
        Else
            drawScore += 1                                    'This kept breaking so I decided just to put the ties up here
            Call ShowScore(playWins, compWins, drawScore)
        End If


        Me.lblPlayerPercent.Text = Int((playWins) / (playWins + compWins) * 100) & "%"      'This is the function that shows the percentage of the winnings. The top one deals with the players percentage and the bottom one deals with the computers percentage
        Me.lblCompPercent.Text = Int((compWins) / (playWins + compWins) * 100) & "%"
    End Sub

    Sub DealCard(ByRef picCard As PictureBox, ByRef intTotal As Integer)
        Randomize()
        Dim randomNumber As Integer = RndInt(1, 9)           'This helps randomize the cards for DealCard as seen above. The reason its 1,9 is because it adds on 1 to randomNumber later so then it would be 1,10

        intTotal += randomNumber
        picCard.Image = My.Resources.ResourceManager.GetObject("card" & randomNumber)    'This is something found by my classmate Jacob that helps get the image needed by looking  into the resource folder and finding pictures named  card1 or card2 etc.
    End Sub

    Function RndInt(ByVal lowNumber As Integer, ByVal highNumber As Integer) As Integer
        Return Int(highNumber - lowNumber + 1) * Rnd() + lowNumber                   'Randomize function used in the DealCard procedure. Pretty self explanatory
    End Function

    Function winner(ByVal player As Integer, ByVal computer As Integer)
        If player > computer Then
            winner = "Player"

        ElseIf computer > player Then                         'This makes it possible to sort through who gets the point. This is used above.
            winner = "Computer"
        Else
            winner = "Tie"

        End If
    End Function
    Sub UpdateScore(ByRef winner As Integer)
        winner += 1

    End Sub
    Sub ShowScore(ByVal playerScore As Integer, ByVal compScore As Integer, ByVal drawScore As Integer)
        Me.lblCWins.Text = "Wins:" & compScore
        Me.lblPWins.Text = "Wins:" & playerScore                 'This just shows all the scores to the user when playing.
        Me.lblTies.Text = "Ties:" & drawScore
    End Sub


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Application.Restart()
    End Sub
End Class
