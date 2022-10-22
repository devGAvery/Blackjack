Public Class Form1
    Dim playerCards(10) As Integer
    Dim playerTotal As Integer
    Dim playerCardCount As Integer
    Dim playerSplitCards(10) As Integer
    Dim playerSplitTotal As Integer
    Dim playerSplitCardCount As Integer
    Dim dealerCards(10) As Integer
    Dim dealerTotal As Integer
    Dim dealerCardCount As Integer
    Dim possibleSplit(2) As Integer
    Dim totalCardCount As Integer = dealerCardCount + playerCardCount + playerSplitCardCount

    Dim stack As Double
    Dim bet As Integer
    Dim doubleBet As Double
    Dim splitBet As Integer
    Dim splitDoubleBet As Integer
    Dim insuranceBet As Double
    Dim button As String

    Dim gameCount As Integer
    Dim deckCount As Integer = 1
    Dim deck(52) As Integer
    Dim card As Integer
    Dim cardValue As Integer
    Dim dealerDownCard As Integer

    Dim newPic As PictureBox
    Dim downCardPic As PictureBox
    Dim pictures As New List(Of PictureBox)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label2.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Button1.Text = "Play"
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        TextBox4.Visible = False    'for testing
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox5.Enabled = False
        'MsgBox("You have $1000 in chips. First, place your bet. Second, select your insurance choice.", MsgBoxStyle.Information)
        stack = 1000.0
        Label7.Text = Format(stack, "c")
        'bet = 0
        TextBox1.Text = bet
        gameCount = 1
        dealerCardCount = 0
        playerCardCount = 0
        playerSplitCardCount = 0
        cardValue = 0
    End Sub

    Private Sub Deal_and_Hit_Button(sender As Object, e As EventArgs) Handles Button1.Click

        If (playerCardCount = 0) Then
            'start hand. 'deal' button chng to 'hit'. 'stay' button visible.
            TextBox1.Enabled = True
            If (checkBet(bet, "bet") = False) Then
                Exit Sub
            End If
            Label7.Text = stack
            TextBox1.Enabled = False

            shuffleDeck(deckCount)

            Button1.Text = "Hit"
            Button2.Visible = True
            Button4.Visible = True
            Button7.Visible = False
            TextBox1.Enabled = False
            Label10.Enabled = False

            'deal first card to player
            playerTotal += Deal("player")
            Label2.Visible = True
            Label2.Text = playerTotal

            'deal first card to dealer (up)
            dealerTotal += Deal("dealer")
            Label1.Visible = True
            Label1.Text = dealerTotal

            'deal second card to player
            playerTotal += Deal("player")
            checkBust(playerTotal, "player", playerCards)
            Label2.Text = playerTotal

            'deal second card to dealer (down)
            dealerTotal += Deal("dealer")

            'insurance call if dealer is showing an Ace
            If (dealerCards(0) = 11) Then
                insuranceCall()
                If (checkBlackjack(dealerTotal, dealerCardCount) = True) Then
                    Button2.PerformClick()
                    Exit Sub
                Else
                    MsgBox("Dealer does NOT have Blackjack", MsgBoxStyle.Information)
                End If
            End If

            'check for player blackjack
            checkBust(playerTotal, "player", playerCards)   'for cases of Ace & Ace (22)
            Dim bjBool As Boolean = checkBlackjack(playerTotal, playerCardCount)
            If (bjBool = True) Then
                TextBox4.Text += "Player BlackJack!" + vbNewLine
                Button2.PerformClick()
                Exit Sub
            End If

            'enable HELP, DOUBLE and SPLIT functionality
            Button4.Visible = True
            Button5.Visible = True
            If (playerCards(0) = playerCards(1) Or playerCards(1) = 1) Then
                Dim temp1 As Integer = possibleSplit(0) Mod 13
                Dim temp2 As Integer = possibleSplit(1) Mod 13
                If (temp1 = temp2) Then
                    Button3.Visible = True
                End If
            End If
            TextBox4.Text += "Player cards[0,1]: " + Convert.ToString(possibleSplit(0)) + " " + Convert.ToString(possibleSplit(1)) + vbNewLine

        ElseIf (playerCardCount > 0) Then
            Button3.Visible = False
            Button4.Visible = False

            If (playerCardCount = 1) Then
                Button5.Visible = True
            Else
                Button5.Visible = False
            End If

            'player upcard(s)
            playerTotal += Deal("player")
            Dim bustResult As Boolean = False
            bustResult = checkBust(playerTotal, "player", playerCards)
            If (bustResult = True) Then
                TextBox4.Text += "Player busted!" + vbNewLine
                Button1.Enabled = False
                Button2.PerformClick()
                Exit Sub
            End If
            Label2.Text = playerTotal
            Else
                MsgBox("game error in Deal function", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Stay_Button(sender As Object, e As EventArgs) Handles Button2.Click
        'dealer hand begins
        TextBox4.Text += "Stay_Button" + vbNewLine

        'remove functionality from player
        Button2.Enabled = False
        Button1.Enabled = False
        Button5.Enabled = False
        Button3.Enabled = False

        'show dealer down card
        downCardPic.Image = ImageList1.Images.Item(dealerDownCard)  'Deal() line 288
        Label1.Text = dealerTotal

        If (playerTotal = 21 And playerCardCount = 2) Then
            gameEnd()
        Else
            If (dealerTotal > 21) Then
                checkBust(dealerTotal, "dealer", dealerCards)
                Label1.Text = dealerTotal
            End If

            If (dealerTotal < 17) Then
                Do
                    dealerTotal += Deal("dealer")
                    gamePause(1)
                    checkBust(dealerTotal, "dealer", dealerCards)
                    Label1.Text = dealerTotal
                    checkBlackjack(dealerTotal, dealerCardCount)
                Loop Until (dealerTotal >= 17)
                gameEnd()
            Else
                checkBlackjack(dealerTotal, dealerCardCount)
                gameEnd()
            End If
        End If

    End Sub

    Private Sub Double_Button(sender As Object, e As EventArgs) Handles Button5.Click
        'player double bet for 1 card
        TextBox4.Text += "Double_Button" + vbNewLine
        TextBox2.Enabled = True

        doubleBet = bet
        If (checkBet(doubleBet, "doubleBet") = False) Then
            doubleBet = 0
            TextBox2.Enabled = False
            Exit Sub
        End If

        TextBox2.Text = doubleBet
        TextBox2.Enabled = False
        playerTotal += Deal("player")
        checkBust(playerTotal, "player", playerCards)
        Label2.Text = playerTotal
        Button2.PerformClick()      'buttons 1, 2, 3 & 5 disabled in STAY
    End Sub

    Private Sub Split_Button(sender As Object, e As EventArgs) Handles Button3.Click
        'split player hand
        TextBox4.Text += "Split_Button" + vbNewLine

        If (playerSplitCardCount = 0) Then
            'start split hand
            splitBet = bet
            If (checkBet(splitBet, "splitBet") = False) Then
                splitBet = 0
                Button3.Visible = False
                Exit Sub
            End If
            playerSplitCards(0) = playerCards(1)
            playerCards(1) = 0
            playerTotal -= playerSplitCards(0)
            Label2.Text = playerTotal
            If (playerSplitCards(0) = 1) Then
                playerSplitCards(0) = 11
            End If
            playerSplitTotal = playerSplitCards(0)
            playerSplitCardCount += 1
            playerCardCount -= 1
            Label9.Visible = True
            Label9.Text = playerSplitTotal      'validate playerSplitTotal sum

            'move card
            Dim pic = pictures(2)
            pic.Top = 220
            pic.Left = 557 + ((80 + 6) * (playerSplitCardCount - 1))

            TextBox3.Enabled = True
            TextBox3.Text = splitBet
            TextBox3.Enabled = False
            Button1.Visible = False
            Button2.Visible = False
            Button3.Text = "Hit"
            Button5.Visible = False
            Button6.Visible = True
            Button7.Visible = False

        ElseIf (playerSplitCardCount > 0) Then

            'double available for split hand
            If (playerSplitCardCount = 1) Then
                Button7.Visible = True
            Else
                Button7.Visible = False
            End If

            'deal additional card to playerSplit
            playerSplitTotal += Deal("playerSplit")
            Label9.Text = playerSplitTotal
            TextBox4.Text += "PlayerSplit cards[0,1]: " + Convert.ToString(playerSplitCards(0)) + " " + Convert.ToString(playerSplitCards(1))

            'check for playerSplit bust
            Dim bustResult As Boolean = checkBust(playerSplitTotal, "playerSplit", playerSplitCards)
            If (bustResult = True) Then
                TextBox4.Text += "Split busted!" + vbNewLine
                Button1.Enabled = True
                Button1.Visible = True
                Button6.PerformClick()
                Exit Sub
            End If
            Label9.Text = playerSplitTotal

            'check for playerSplit blackjack
            Dim bjBool As Boolean = checkBlackjack(playerSplitTotal, playerSplitCardCount)
            If (bjBool = True) Then
                TextBox4.Text += "Split BlackJack!" + vbNewLine
                Button1.Enabled = True
                Button1.Visible = True
                Button6.PerformClick()
                Exit Sub
            End If
        Else
            MsgBox("game error in Split() function", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Stay_Split_Button(sender As Object, e As EventArgs) Handles Button6.Click
        'splitPlayer hand ends
        TextBox4.Text += "Stay_Split_Button" + vbNewLine
        Button3.Text = "Split"
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
    End Sub

    Private Sub Double_Split_Button(sender As Object, e As EventArgs) Handles Button7.Click

        TextBox4.Text += "Double_Split_Button" + vbNewLine
        TextBox5.Enabled = True

        splitDoubleBet = bet
        If (checkBet(splitDoubleBet, "splitDoubleBet") = False) Then
            splitDoubleBet = 0
            Exit Sub
        End If
        TextBox5.Text = splitDoubleBet
        TextBox5.Enabled = False

        playerSplitTotal += Deal("playerSplit")
        checkBust(playerSplitTotal, "playerSplit", playerSplitCards)
        Label9.Text = playerSplitTotal
        Button6.PerformClick()


    End Sub

    Private Sub Help_Button(sender As Object, e As EventArgs) Handles Button4.Click

        If (playerCards(0) < 1 And playerCards(1) < 1) Then
            Exit Sub
        End If

        Dim inFile As IO.StreamReader
        If (deckCount = 1) Then
            inFile = IO.File.OpenText("single_deck.csv")
        Else
            inFile = IO.File.OpenText("multiple_decks.csv")
        End If

        'If (file doesn't open code) Then
        '    MsgBox("file read error", MsgBoxStyle.Exclamation)
        'End If

        Dim dealerUpCard As Integer = dealerCards(0)
        Dim helpTotal As String = ""
        Dim helpMsg1 As String = ""
        If (playerCards(0) = 11 Or playerCards(1) = 11 Or playerCards(1) = 1) Then
            'softTotal
            helpTotal = "A"
            If (playerCards(0) = 11) Then
                If (playerCards(1) = 11 Or playerCards(1) = 1) Then
                    helpTotal = "DA"
                    helpMsg1 = "soft 12"
                Else
                    helpTotal += Convert.ToString(playerCards(1))
                    helpMsg1 = "soft " + Convert.ToString((possibleSplit(1) Mod 13) + 11)
                End If
            Else
                helpTotal += Convert.ToString(playerCards(0))
                helpMsg1 = "soft " + Convert.ToString((possibleSplit(0) Mod 13) + 11)
            End If
            TextBox4.Text += "softTotal: " + helpTotal + vbNewLine
        ElseIf (Button3.Visible = True And playerCards(0) <> 11 And playerCards(1) <> 11 And playerCards(1) <> 1) Then
            'hardTotal with split possible
            helpTotal = "D" + Convert.ToString(playerCards(0))
            TextBox4.Text += "splitHardTotal: " + helpTotal + vbNewLine
            helpMsg1 = "" + Convert.ToString(playerCards(0)) + "-" + Convert.ToString(playerCards(0))
        ElseIf (Button3.Visible = False And playerCards(0) <> 11 And playerCards(1) <> 11 And playerCards(1) <> 1) Then
            'hardTotal
            helpTotal = Convert.ToString((playerCards(0) + playerCards(1)))
            TextBox4.Text += "hardTotal: " + helpTotal + vbNewLine
            helpMsg1 = "hard " + helpTotal
        Else
            TextBox4.Text += "helpTotal ERROR in HELP"
        End If

        Dim theBook(25) As String
        Dim line As String = ""
        Do Until inFile.Peek = -1
            line = inFile.ReadLine()
            If (line.Contains(helpTotal)) Then
                TextBox4.Text += line + vbNewLine
                theBook = line.Split(",")
                Exit Do
            End If
        Loop

        Dim advice As String
        If (dealerUpCard <= 10 And dealerUpCard >= 2) Then
            '2 thru 10 as dealerUpCard
            advice = theBook(dealerUpCard - 1)
        Else
            'A as dealerUpCard
            advice = theBook(10)
        End If
        TextBox4.Text += "advice: " + advice + vbNewLine

        line = "The Book says to "
        If (advice = "H") Then
            line += "HIT"
        ElseIf (advice = "S" Or advice = "RS" Or advice = "R") Then
            line += "STAY"
        ElseIf (advice = "D") Then
            line += "DOUBLE"
        ElseIf (advice = "DS") Then
            line += "DOUBLE Or STAY"
        ElseIf (advice = "P") Then
            line += "SPLIT"
        ElseIf (advice = "PD") Then
            line += "SPLIT with possible DOUBLE"
        Else
            line = "ERROR1 in HELP advice"
        End If
        line += " when a player has " + helpMsg1 + " and dealer is showing " + Convert.ToString(dealerUpCard) + ". "
        MsgBox(line, MsgBoxStyle.Information)
    End Sub

    Private Sub Player_Bet_Box(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        'player wager
        Integer.TryParse(TextBox1.Text, bet)

        If (bet > 0 And stack = 0) Then
            Dim stackResult As DialogResult
            stackResult = MessageBox.Show("Would you like to continue playing by adding another $1000 to your stack?", "Cash In", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If (stackResult = DialogResult.Yes) Then
                stack += 1000
            ElseIf (stackResult = DialogResult.No) Then
                Me.Close()
            End If
        End If

        If (bet = 0) Then
            MsgBox("Please place your bet in whole dollars.", MsgBoxStyle.Information)
            TextBox1.Focus()
            TextBox1.Select()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'insurance yes
        Label10.Visible = True

        If (RadioButton2.Checked = True) Then
            insuranceBet = bet / 2.0
            checkBet(insuranceBet, "insuranceBet")
            Label10.Text = insuranceBet
        ElseIf (RadioButton2.Checked = False) Then
            If (insuranceBet > 0.0) Then
                stack += insuranceBet
                Label7.Text = stack
                insuranceBet = 0.0
            ElseIf (insuranceBet = 0.0) Then
                insuranceBet = 0.0
            Else
                MsgBox("Error in insurance selection ")
            End If
            Label10.Visible = False
        End If

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.TextChanged
        Label7.Text = Format(stack, "c")
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.TextChanged
        Label10.Text = Format(insuranceBet, "c")
    End Sub

    Function shuffleDeck(shoot As Integer) As Boolean
        Dim shuffle As Boolean = False

        If (gameCount = 1) Then
            'fill the deck array, default deckCount is 1
            For i As Integer = 1 To 52
                deck(i) = shoot
            Next
            shuffle = True
        End If

        Dim remainingCards As Integer
        For i As Integer = 1 To 52
            remainingCards += deck(i)
        Next

        If (remainingCards <= (0.2 * (52 * deckCount))) Then                'needs an end-of-game argument
            'if deck has less than 80% available cards, then new deck(s)
            For i As Integer = 1 To 52
                deck(i) = deckCount
            Next
            MsgBox("The deck has been reshuffled.", MsgBoxStyle.Information)
            shuffle = True
        End If

        Return shuffle
    End Function

    Function Deal(button As String) As Integer
        'do-until random card draw from deck array is > zero
        Do
            cardValue = 0
            Dim rand As New Random
            card = rand.Next(1, 53)
        Loop Until deck(card) > 0
        TextBox4.Text += "Deal(); card = " + Convert.ToString(card) + " ; "

        'remove card from deck
        deck(card) -= 1

        'determine value of card
        cardValue = card Mod 13
        If (cardValue = 1) Then
            cardValue = 11
        ElseIf (cardValue = 11 Or cardValue = 12 Or cardValue = 0) Then
            cardValue = 10
        End If
        TextBox4.Text += "cardValue =" + Convert.ToString(cardValue) + vbNewLine

        'add cardValue to cards array and increment cardCount
        If (button = "dealer") Then
            dealerCards(dealerCardCount) = cardValue
            dealerCardCount += 1
            If (dealerCardCount = 2) Then
                dealerDownCard = card
            End If
        ElseIf (button = "playerSplit") Then
            playerSplitCards(playerSplitCardCount) = cardValue
            playerSplitCardCount += 1
        ElseIf (button = "player") Then
            playerCards(playerCardCount) = cardValue
            playerCardCount += 1
            If (playerCardCount = 1) Then
                possibleSplit(0) = card
            ElseIf (playerCardCount = 2) Then
                possibleSplit(1) = card
            End If
        Else
            MsgBox("error in Deal() function, cardValue to array", MsgBoxStyle.Exclamation)
        End If

        'produce card image
        placeCardImage(card, button)

        Return cardValue
    End Function

    Function placeCardImage(card As Integer, button As String) As Boolean

        If (button = "dealer" And dealerCardCount = 2) Then
            downCardPic = New PictureBox()
            downCardPic.Image = ImageList1.Images.Item(0)
            Controls.Add(downCardPic)
            pictures.Add(downCardPic)
            downCardPic.Size = New Size(80, 120)
            downCardPic.SizeMode = PictureBoxSizeMode.StretchImage
            downCardPic.Top = 80
            downCardPic.Left = Label1.Left + ((80 + 6) * (dealerCardCount - 1))

        ElseIf (button = "player" Or button = "playerSplit" Or dealerCardCount <> 2) Then
            newPic = New PictureBox()
            newPic.Image = ImageList1.Images.Item(card)
            newPic.Size = New Size(80, 120)
            newPic.SizeMode = PictureBoxSizeMode.StretchImage
            Controls.Add(newPic)
            pictures.Add(newPic)

            If (button = "dealer") Then
                newPic.Top = 80
                newPic.Left = Label1.Left + ((80 + 6) * (dealerCardCount - 1))
            ElseIf (button = "playerSplit") Then
                newPic.Top = 220
                newPic.Left = 557 + ((80 + 6) * (playerSplitCardCount - 1))
            ElseIf (button = "player") Then
                newPic.Top = 220
                newPic.Left = Label1.Left + ((80 + 6) * (playerCardCount - 1))
            Else
                MsgBox("error1 in placeCardImage() function", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("error2 in placeCardImage() function", MsgBoxStyle.Exclamation)
        End If

        Return True
    End Function

    Function checkBet(wager As Double, betType As String) As Boolean
        TextBox4.Text += "checkBet() = "
        Dim validBet As Boolean = True

        If (wager = 0.0) Then
            MsgBox("Place your bet.", MsgBoxStyle.Information)
            validBet = False
        End If

        Dim wagerString As String = Convert.ToString(wager)
        'wagerString.Remove(" ")
        wagerString.Trim()
        If (wagerString = String.Empty) Then
            validBet = False
        End If

        If (wagerString.Contains(".")) Then
            wagerString.Remove(wagerString.IndexOf("."))
            Dim wager2 As Integer = Convert.ToInt32(wagerString)
            'wager2 = Val(wagerString)
            If (betType = "splitBet") Then
                MsgBox("Your split bet has been adjusted to  whole dollars", MsgBoxStyle.Information)
                splitBet = wager2
                TextBox3.Text = splitBet
                validBet = True
            ElseIf (betType = "bet") Then
                MsgBox("Your bet has been adjusted to  whole dollars", MsgBoxStyle.Information)
                bet = wager2
                TextBox1.Text = bet
                validBet = True
            ElseIf (betType = "splitDoubleBet") Then
                MsgBox("Your split double bet has been adjusted to  whole dollars", MsgBoxStyle.Information)
                splitDoubleBet = wager2
                TextBox3.Text = splitDoubleBet
                validBet = True
            Else
                MsgBox("error1 in checkBet() function.", MsgBoxStyle.Exclamation)
            End If
        End If

        If (stack = 0 And wager > 0) Then
            'wager EXCEEDS stack returns FALSE
            validBet = False
            If (betType = "doubleBet") Then
                MsgBox("You don't have addition funds to wager.", MsgBoxStyle.Information)
                doubleBet = 0
                TextBox2.Enabled = False
                Button5.Visible = False
                validBet = False
            ElseIf (betType = "splitBet") Then
                MsgBox("You don't have addition funds to wager.", MsgBoxStyle.Information)
                splitBet = 0
                TextBox3.Enabled = False
                validBet = False
            ElseIf (betType = "insuranceBet") Then
                MsgBox("You don't have addition funds to wager.", MsgBoxStyle.Information)
                insuranceBet = 0
                RadioButton2.Checked = False
                validBet = False
            ElseIf (betType = "splitDoubleBet") Then
                MsgBox("You don't have addition funds to wager.", MsgBoxStyle.Information)
                splitDoubleBet = 0
                TextBox5.Enabled = False
                Button7.Visible = False
                validBet = False
            ElseIf (betType = "bet") Then
                Dim stackResult As DialogResult
                stackResult = MessageBox.Show("Would you like to continue playing by adding another $1000 to your stack?", "Cash In", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                If (stackResult = DialogResult.Yes) Then
                    stack += 1000
                    Label7.Text = stack
                    If (wager <= stack) Then
                        validBet = True
                    Else
                        checkBet(wager, "bet")
                        Exit Function
                    End If
                End If
            End If
        End If

        If (wager > stack And stack > 0) Then
            If (betType = "doubleBet") Then
                MsgBox("Your double bet has been adjusted to the remaining amount in your stack.", MsgBoxStyle.Information)
                doubleBet = stack
                TextBox2.Text = doubleBet
            ElseIf (betType = "splitBet") Then
                MsgBox("Your split bet has been adjusted to the remaining amount in your stack.", MsgBoxStyle.Information)
                splitBet = stack
                TextBox3.Text = splitBet
            ElseIf (betType = "bet") Then
                MsgBox("Your bet has been adjusted to the remaining amount in your stack.", MsgBoxStyle.Information)
                bet = stack
                TextBox1.Text = bet
            ElseIf (betType = "splitDoubleBet") Then
                MsgBox("Your split double bet has been adjusted to the remaining amount in your stack.", MsgBoxStyle.Information)
                splitDoubleBet = stack
                TextBox3.Text = splitDoubleBet
            ElseIf (betType = "insuranceBet") Then
                MsgBox("Your insurance bet has been adjusted to the remaining amount in your stack.", MsgBoxStyle.Information)
                insuranceBet = stack
                Label10.Text = insuranceBet
            Else
                MsgBox("error2 checkBet() function", MsgBoxStyle.Exclamation)
            End If
            wager = stack
            validBet = True
        End If

        If (validBet = True) Then
            stack -= wager
            Label7.Text = Format(stack, "c")
            If (RadioButton2.Checked = True) Then
                Label10.Text = insuranceBet
            End If
        End If
        TextBox4.Text += Convert.ToString(validBet) + vbNewLine
        Return validBet
    End Function

    Function checkBust(buttonTotal As Double, button As String, buttonCards() As Integer) As Boolean
        'check if new handTotal exceeds 21
        Dim busted As Boolean = False
        If (buttonTotal > 21) Then
            If (button = "player") Then
                buttonTotal = checkAce("player", buttonCards)
                playerTotal = buttonTotal
                Label2.Text = playerTotal
                If (buttonTotal > 21) Then
                    busted = True
                End If
            ElseIf (button = "dealer") Then
                buttonTotal = checkAce("dealer", buttonCards)
                dealerTotal = buttonTotal
                Label1.Text = dealerTotal
                If (buttonTotal > 21) Then
                    busted = True
                End If
            ElseIf (button = "playerSplit") Then
                buttonTotal = checkAce("playerSplit", buttonCards)
                playerSplitTotal = buttonTotal
                Label9.Text = playerSplitTotal
                If (buttonTotal > 21) Then
                    busted = True
                End If
            End If
        End If
        Return busted
    End Function

    Function checkBlackjack(handTotal As Double, cardCount As Integer) As Boolean
        TextBox4.Text += "checkBlackjack() = "
        Dim bj As Boolean = False
        If (handTotal = 21 And cardCount = 2) Then
            bj = True
        End If
        TextBox4.Text += Convert.ToString(bj) + vbNewLine
        Return bj
    End Function

    Function checkAce(button As String, buttonCards() As Integer) As Integer
        Dim newTotal As Integer = 0
        Dim counter As Integer = 0
        Dim index As Integer = -1

        For i As Integer = 0 To buttonCards.Length - 1
            If (buttonCards(i) = 11) Then
                counter += 1
                index = i
            End If
        Next
        If (counter <> 0) Then
            buttonCards(index) = 1     'change ace 11 value to 1 value to avoid busting
        End If
        For j As Integer = 0 To buttonCards.Length - 1
            newTotal += buttonCards(j)
        Next

        Return newTotal
    End Function

    Function insuranceCall() As Boolean
        TextBox4.Text += "insuranceCall() "
        Dim result As Boolean = False
        RadioButton2.Enabled = True
        Dim insurResult As DialogResult
        If (RadioButton2.Checked = False) Then
            insurResult = MessageBox.Show("The Dealer is showing an Ace. Would you like purchase insurance?", "Insurance", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If (insurResult = DialogResult.Yes) Then
                RadioButton2.Checked = True
                result = True
            ElseIf (insurResult = DialogResult.No) Then
                RadioButton2.Checked = False
            End If
        ElseIf (RadioButton2.Checked = True) Then
            result = True
        End If
        RadioButton2.Enabled = False
        TextBox4.Text += Convert.ToString(result) + vbNewLine
        Return result
    End Function

    Function gamePause(secs As Integer) As Boolean
        Dim timeInterval As Integer = 100 * secs
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < timeInterval

        Loop
        sw.Stop()
        Return False
    End Function

    Function gameEnd() As Boolean
        TextBox4.Text += "gameEnd()" + vbNewLine
        Dim playerMessage As String = ""
        Dim finalResult As Boolean = False

        If (playerSplitCardCount > 0) Then
            If (playerSplitTotal < 21) Then
                If (playerSplitTotal < dealerTotal And dealerTotal <= 21) Then
                    'dealer beats split
                    TextBox4.Text += "Split loses to Dealer. " + vbNewLine
                    stack += splitBet
                ElseIf (playerSplitTotal > dealerTotal And playerSplitTotal <= 21) Then
                    'split beats dealer
                    TextBox4.Text += "Split beats Dealer. " + vbNewLine
                    stack += splitBet * 2
                ElseIf (playerSplitTotal = dealerTotal And playerSplitTotal <= 21) Then
                    'push
                    TextBox4.Text += "Split pushes with Dealer. " + vbNewLine
                    stack += splitBet
                End If
            ElseIf (checkBlackjack(playerSplitTotal, playerCardCount) = True) Then
                'split blackjack
                stack += splitBet * 2.5
                TextBox4.Text += "Split wins with Blackjack. " + vbNewLine
            ElseIf (playerSplitTotal > 21) Then
                'split bust
                TextBox4.Text += "Split bust. " + vbNewLine
            End If
            splitBet = 0
            TextBox3.Text = ""
        End If

        'player vs dealer result
        If (playerTotal > 21) Then
            'player busts
            Button1.Enabled = False
            Button2.Enabled = False
            playerMessage = "Dealer wins! Player busts."
            finalResult = True
        ElseIf (dealerTotal = playerTotal And dealerTotal <= 21) Then
            'if push
            stack += bet + doubleBet
            doubleBet = 0
            TextBox2.Text = ""
            If (checkBlackjack(dealerTotal, dealerCardCount) = True And checkBlackjack(playerTotal, playerCardCount) = True) Then
                insuranceBet = 0
                Label10.Text = insuranceBet
            End If
            playerMessage = "Push. Play again?"
            finalResult = True
        ElseIf (dealerTotal > playerTotal And dealerTotal <= 21) Then
            'if dealer wins
            playerMessage = "Dealer wins! Beat player hand."
            If (checkBlackjack(dealerTotal, dealerCardCount) = True) Then
                stack += 2 * insuranceBet
                insuranceBet = 0
                Label10.Text = insuranceBet
                RadioButton2.Checked = False
                playerMessage = "Dealer wins with Blackjack. "
            End If
            finalResult = True
        ElseIf (dealerTotal > 21 And playerTotal <= 21) Then
            'if player wins by dealer bust or with blackjack
            If (checkBlackjack(playerTotal, playerCardCount) = True) Then
                stack += ((bet + doubleBet) * 2.5)
                playerMessage = "Blackjack! "
            Else
                stack += (2 * (bet + doubleBet))
            End If
            playerMessage += "Player wins! Dealer bust."
            finalResult = True
        ElseIf (dealerTotal < playerTotal And dealerTotal >= 17 And playerTotal <= 21) Then
            'if player beats dealer with/out blackjack
            If (checkBlackjack(playerTotal, playerCardCount) = True) Then
                stack += ((bet + doubleBet) * 2.5)
                playerMessage = "Blackjack! "
            Else
                stack += ((bet + doubleBet) * 2)
            End If
            playerMessage += "Player wins! Beat dealer."
            finalResult = True
        ElseIf (dealerTotal < playerTotal And checkBlackjack(playerTotal, playerCardCount) = True) Then
            'if player gets blackjack and dealer doesn't
            playerMessage = "Blackjack! Player wins! Beat dealer."
            stack += ((bet + doubleBet) * 2.5)
            finalResult = True
        End If

        TextBox4.Text += playerMessage + vbNewLine
        Label7.Text = stack

        If (finalResult = True) Then
            MsgBox((playerMessage + " Place your bet"), MsgBoxStyle.Information)
            gameCount += 1
            Do
                Dim pic = pictures(pictures.Count - 1)
                Controls.Remove(pic)
                pictures.Remove(pic)
            Loop Until (pictures.Count = 0)
            playerTotal = 0
            Label2.Text = playerTotal
            dealerTotal = 0
            Label1.Text = dealerTotal
            playerSplitTotal = 0
            Label9.Text = playerSplitTotal
            playerCardCount = 0
            dealerCardCount = 0
            playerSplitCardCount = 0
            possibleSplit(0) = 0
            possibleSplit(1) = 0
            For i As Integer = 0 To playerCards.Count - 1
                playerCards(i) = 0
                dealerCards(i) = 0
                playerSplitCards(i) = 0
            Next
            Button1.Enabled = True
            Button1.Text = "Deal"
            Button2.Enabled = True
            Button2.Visible = False
            Button3.Enabled = True
            Button3.Visible = False
            Button5.Enabled = True
            Button5.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            doubleBet = 0
            TextBox5.Text = ""
            TextBox5.Enabled = False
            TextBox3.Enabled = False
            TextBox2.Text = ""
            TextBox2.Enabled = False
            TextBox1.Enabled = True
            TextBox1.Text = bet
            RadioButton2.Checked = False

            shuffleDeck(deckCount)

        End If
        TextBox4.Text += Convert.ToString(finalResult) + vbNewLine
        Return finalResult
    End Function

    Private Sub Exit_Button(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

End Class
