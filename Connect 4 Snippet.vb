  //Something I made for a final project in a class.
  //This snippit is the code I used for checking for win conditions
  
  Private Sub CheckForWinConditions(ByVal ChipColor, ByVal x, ByVal y)
        'Checks to see if one the win conditions have been activated.
        For CheckWinCondition As Integer = 0 To 7 Step 1
            Try
                Select Case CheckWinCondition
                    Case 0
                        If PanelArray(x, y).BackColor = ChipColor And PanelArray(x + 1, y).BackColor = ChipColor And PanelArray(x + 2, y).BackColor = ChipColor And PanelArray(x + 3, y).BackColor = ChipColor Then
                            GetWinCount(GetPlayer())
                            MessageBox.Show(GetPlayer() + " Wins")
                            ClearBoard()
                        End If
                    Case 1
                        If PanelArray(x, y).BackColor = ChipColor And PanelArray(x - 1, y).BackColor = ChipColor And PanelArray(x - 2, y).BackColor = ChipColor And PanelArray(x - 3, y).BackColor = ChipColor Then
                            GetWinCount(GetPlayer())
                            MessageBox.Show(GetPlayer() + " Wins")
                            ClearBoard()
                        End If
                    Case 2
                        If PanelArray(x, y).BackColor = ChipColor And PanelArray(x, y + 1).BackColor = ChipColor And PanelArray(x, y + 2).BackColor = ChipColor And PanelArray(x, y + 3).BackColor = ChipColor Then
                            GetWinCount(GetPlayer())
                            MessageBox.Show(GetPlayer() + " Wins")
                            ClearBoard()
                        End If
                    Case 3
                        If PanelArray(x, y).BackColor = ChipColor And PanelArray(x, y - 1).BackColor = ChipColor And PanelArray(x, y - 2).BackColor = ChipColor And PanelArray(x, y - 3).BackColor = ChipColor Then
                            GetWinCount(GetPlayer())
                            MessageBox.Show(GetPlayer() + " Wins")
                            ClearBoard()
                        End If
                    Case 4
                        If PanelArray(x, y).BackColor = ChipColor And PanelArray(x + 1, y - 1).BackColor = ChipColor And PanelArray(x + 2, y - 2).BackColor = ChipColor And PanelArray(x + 3, y - 3).BackColor = ChipColor Then
                            GetWinCount(GetPlayer())
                            MessageBox.Show(GetPlayer() + " Wins")
                            ClearBoard()
                        End If
                    Case 5
                        If PanelArray(x, y).BackColor = ChipColor And PanelArray(x - 1, y + 1).BackColor = ChipColor And PanelArray(x - 2, y + 2).BackColor = ChipColor And PanelArray(x - 3, y + 3).BackColor = ChipColor Then
                            GetWinCount(GetPlayer())
                            MessageBox.Show(GetPlayer() + " Wins")
                            ClearBoard()
                        End If
                    Case 6
                        If PanelArray(x, y).BackColor = ChipColor And PanelArray(x - 1, y - 1).BackColor = ChipColor And PanelArray(x - 2, y - 2).BackColor = ChipColor And PanelArray(x - 3, y - 3).BackColor = ChipColor Then
                            GetWinCount(GetPlayer())
                            MessageBox.Show(GetPlayer() + " Wins")
                            ClearBoard()
                        End If
                    Case 7
                        If PanelArray(x, y).BackColor = ChipColor And PanelArray(x + 1, y + 1).BackColor = ChipColor And PanelArray(x + 2, y + 2).BackColor = ChipColor And PanelArray(x + 3, y + 3).BackColor = ChipColor Then
                            GetWinCount(GetPlayer())
                            MessageBox.Show(GetPlayer() + " Wins")
                            ClearBoard()
                        End If
                End Select
            Catch ex As Exception
            End Try
        Next
        CheckForDraw()
        SwitchPlayer()
    End Sub