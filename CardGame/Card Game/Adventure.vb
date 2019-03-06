Public Class Adventure

    '.------..------..------..------..------..------..------..------..------.
    '|A.--. ||D.--. ||V.--. ||E.--. ||N.--. ||T.--. ||U.--. ||R.--. ||E.--. |
    '| (\/) || :/\: || :(): || (\/) || :(): || :/\: || (\/) || :(): || (\/) |
    '| :\/: || (__) || ()() || :\/: || ()() || (__) || :\/: || ()() || :\/: |
    '| '--'A|| '--'D|| '--'V|| '--'E|| '--'N|| '--'T|| '--'U|| '--'R|| '--'E|
    '`------'`------'`------'`------'`------'`------'`------'`------'`------'
    'Alexander Massin 11a


    Dim compHealth As Integer
    Dim playHealth As Integer


    Private Sub btnShuffle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShuffle.Click
        Dim playerTotal As Integer
        Dim compTotal As Integer
        Static compWins As Integer
        Static playWins As Integer
        Static drawScore As Integer

        Call DealCard(picPlayerCard1, playerTotal)          'I wont add all the comments I did for probability here because it is pretty much the same except for this special feature
        Call DealCard(picPlayerCard2, playerTotal)
        Call DealCard(picPlayerCard3, playerTotal)
        Call DealCard(picCompCard1, compTotal)
        Call DealCard(picCompCard2, compTotal)
        Call DealCard(picCompCard3, compTotal)

        Me.lblCCount.Text = compTotal
        Me.lblPCount.Text = playerTotal
        If winner(playerTotal, compTotal) = "Player" Then
            compHealth += 1
            Call UpdateScore(playWins)
            Call ShowScore(playWins, compWins, drawScore)
        ElseIf winner(playerTotal, compTotal) = "Computer" Then
            playHealth += 1
            Call UpdateScore(compWins)
            Call ShowScore(playWins, compWins, drawScore)
        Else
            drawScore += 1
            Call ShowScore(playWins, compWins, drawScore)
        End If
        Select Case compHealth
            Case 1
                Me.lblCHealth.Text = "Health: ŒŒŒŒ"           'So down here I added health to each character so it adds a bit more fun to the game
            Case 2
                Me.lblCHealth.Text = "Health: ŒŒŒ"            'I use that symbol seen to the left because with the font I'm using, it creates a heart.
            Case 3
                Me.lblCHealth.Text = "Health: ŒŒ"
            Case 4
                Me.lblCHealth.Text = "Health: Œ"
            Case 5
                Me.lblCHealth.Text = "Health: "                'This one deals with computer's health and the other case statement deals with the player's health
                MsgBox("You win")

                compHealth = -1


        End Select

        Select Case playHealth
            Case 1
                Me.lblPHealth.Text = "Health: ŒŒŒŒ"              'You can see that each time the other person wins, your health decreases by one heart until it hits 0 hearts.
            Case 2
                Me.lblPHealth.Text = "Health: ŒŒŒ"
            Case 3
                Me.lblPHealth.Text = "Health: ŒŒ"
            Case 4
                Me.lblPHealth.Text = "Health: Œ"
            Case 5
                Me.lblPHealth.Text = "Health: "
                MsgBox("You lose")

                playHealth = -1

        End Select
        If compHealth = -1 Or playHealth = -1 Then            'This makes it so that it will reset the hearts once someone loses so you do not need to restart
            Me.lblPHealth.Text = "Health: ŒŒŒŒŒ"
            Me.lblCHealth.Text = "Health: ŒŒŒŒŒ"


            playHealth = 0
            compHealth = 0                                 'This just makes all the values back to 0 so yet again there is no buggy restart function
            compTotal = 0
            playerTotal = 0
            playWins = 0
            compWins = 0
            drawScore = 0
            Me.Hide()
            Modes.Show()
        End If
    End Sub



    Sub DealCard(ByRef picCard As PictureBox, ByRef intTotal As Integer)
        Randomize()
        Dim randomNumber As Integer = RndInt(1, 9)

        intTotal += randomNumber
        picCard.Image = My.Resources.ResourceManager.GetObject("card" & randomNumber)
    End Sub

    Function RndInt(ByVal lowNumber As Integer, ByVal highNumber As Integer) As Integer
        Return Int(highNumber - lowNumber + 1) * Rnd() + lowNumber
    End Function

    Function winner(ByVal player As Integer, ByVal computer As Integer)
        If player > computer Then
            winner = "Player"

        ElseIf computer > player Then
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
        Me.lblPWins.Text = "Wins:" & playerScore
        Me.lblTies.Text = "Ties:" & drawScore
    End Sub


End Class
