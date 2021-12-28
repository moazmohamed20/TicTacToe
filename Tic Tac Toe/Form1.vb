Public Class Form1

    Private Counter As Integer
    Private ComputerFirst As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComputerPlay()
    End Sub

    Private Sub Button_Click(Button As Button, e As EventArgs) Handles B1.Click, B2.Click, B3.Click, B4.Click, B5.Click, B6.Click, B7.Click, B8.Click, B9.Click
        ' Put O On The Button
        Button.Text = "O"
        Counter += 1

        ' Check For Winner
        CheckForWinner()

        ' Computer Turn To play
        ComputerPlay()
    End Sub

    Private Sub Button_TextChanged(Button As Button, e As EventArgs) Handles B1.TextChanged, B2.TextChanged, B3.TextChanged, B4.TextChanged, B5.TextChanged, B6.TextChanged, B7.TextChanged, B8.TextChanged, B9.TextChanged
        Button.Enabled = (Button.Text = "")
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ResetButtons()
        If ComputerFirst Then ComputerPlay()
        ComputerFirst = Not ComputerFirst
    End Sub



    Private Function Button(index As Integer) As String
        Return Grid.Controls(index).Text
    End Function

    Private Sub CheckForWinner()
        Dim Winner As Char

        ' Check Diagonals
        If (Button(0) = Button(4) AndAlso Button(4) = Button(8)) OrElse
            (Button(2) = Button(4) AndAlso Button(4) = Button(6)) Then
            Winner = Button(4)
        End If

        If Winner = Nothing Then
            ' Check Columns
            For C As Integer = 0 To 2
                If Button(C) = Button(C + 3) AndAlso Button(C + 3) = Button(C + 6) Then
                    Winner = Button(C)
                    Exit For
                End If
            Next
        End If

        If Winner = Nothing Then
            ' Check Rows
            For R As Integer = 0 To 6 Step 3
                If Button(R) = Button(R + 1) AndAlso Button(R + 1) = Button(R + 2) Then
                    Winner = Button(R)
                    Exit For
                End If
            Next
        End If

        If Winner <> Nothing Then
            UpdateScore(Winner)
            MsgBox("The Winner Is: " & Winner, MsgBoxStyle.Information)
            ResetButtons()
        ElseIf Counter = 9 Then
            ResetButtons()
        End If
    End Sub

    Private Sub UpdateScore(Winner As Char)
        If Winner = "X" Then
            XLabel.Text = Val(XLabel.Text) + 1
        Else
            OLabel.Text = Val(OLabel.Text) + 1
        End If

        If Val(XLabel.Text) > Val(OLabel.Text) Then
            XLabel.ForeColor = Color.Green
            OLabel.ForeColor = Color.Red
        ElseIf Val(XLabel.Text) < Val(OLabel.Text) Then
            XLabel.ForeColor = Color.Red
            OLabel.ForeColor = Color.Green
        Else
            XLabel.ForeColor = Color.Indigo
            OLabel.ForeColor = Color.Indigo
        End If
    End Sub

    Private Sub ResetButtons()
        Counter = 0
        For Each B As Button In Grid.Controls
            B.Text = ""
        Next
    End Sub



    Private Sub ComputerPlay()
        Dim MarkPosition As Integer = -1

        ' Check If X Can Win
        If Button(0) = "" AndAlso CanWin("X", {{1, 2}, {3, 6}, {4, 8}}) Then
            MarkPosition = 0

        ElseIf Button(1) = "" AndAlso CanWin("X", {{0, 2}, {4, 7}}) Then
            MarkPosition = 1

        ElseIf Button(2) = "" AndAlso CanWin("X", {{0, 1}, {5, 8}, {4, 6}}) Then
            MarkPosition = 2

        ElseIf Button(3) = "" AndAlso CanWin("X", {{4, 5}, {0, 6}}) Then
            MarkPosition = 3

        ElseIf Button(4) = "" AndAlso CanWin("X", {{3, 5}, {1, 7}, {0, 8}, {2, 6}}) Then
            MarkPosition = 4

        ElseIf Button(5) = "" AndAlso CanWin("X", {{3, 4}, {2, 8}}) Then
            MarkPosition = 5

        ElseIf Button(6) = "" AndAlso CanWin("X", {{7, 8}, {0, 3}, {2, 4}}) Then
            MarkPosition = 6

        ElseIf Button(7) = "" AndAlso CanWin("X", {{6, 8}, {1, 4}}) Then
            MarkPosition = 7

        ElseIf Button(8) = "" AndAlso CanWin("X", {{6, 7}, {2, 5}, {0, 4}}) Then
            MarkPosition = 8


            ' Check If O Can Win
        ElseIf Button(0) = "" AndAlso CanWin("O", {{1, 2}, {3, 6}, {4, 8}}) Then
            MarkPosition = 0

        ElseIf Button(1) = "" AndAlso CanWin("O", {{0, 2}, {4, 7}}) Then
            MarkPosition = 1

        ElseIf Button(2) = "" AndAlso CanWin("O", {{0, 1}, {5, 8}, {4, 6}}) Then
            MarkPosition = 2

        ElseIf Button(3) = "" AndAlso CanWin("O", {{4, 5}, {0, 6}}) Then
            MarkPosition = 3

        ElseIf Button(4) = "" AndAlso CanWin("O", {{3, 5}, {1, 7}, {0, 8}, {2, 6}}) Then
            MarkPosition = 4

        ElseIf Button(5) = "" AndAlso CanWin("O", {{3, 4}, {2, 8}}) Then
            MarkPosition = 5

        ElseIf Button(6) = "" AndAlso CanWin("O", {{7, 8}, {0, 3}, {2, 4}}) Then
            MarkPosition = 6

        ElseIf Button(7) = "" AndAlso CanWin("O", {{6, 8}, {1, 4}}) Then
            MarkPosition = 7

        ElseIf Button(8) = "" AndAlso CanWin("O", {{6, 7}, {2, 5}, {0, 4}}) Then
            MarkPosition = 8


            ' X Start First
        ElseIf Counter = 0 Then
            MarkPosition = 0
        ElseIf Counter = 2 Then
            If Button(4) = "O" Then
                MarkPosition = 8
            ElseIf Button(1) = "" AndAlso Button(2) = "" Then
                MarkPosition = 2
            ElseIf Button(3) = "" AndAlso Button(6) = "" Then
                MarkPosition = 6
            End If
        ElseIf Counter = 4 Then
            If Button(1) = "O" AndAlso Button(5) = "O" Then
                MarkPosition = 6
            ElseIf Button(1) = "O" AndAlso Button(3) = "O" Then
                MarkPosition = 8
            ElseIf Button(6) = "" Then
                MarkPosition = 6
            ElseIf Button(8) = "" Then
                MarkPosition = 8
            End If


            ' O Started First
        ElseIf Counter = 1 Then
            If Button(4) = "" Then
                MarkPosition = 4
            Else
                MarkPosition = 0
            End If
        ElseIf Counter = 3 Then
            If Button(0) = "X" Then
                MarkPosition = GetPosition(2, 6)

            ElseIf (Button(0) = "O" AndAlso Button(8) = "O") OrElse (Button(2) = "O" AndAlso Button(6) = "O") Then
                MarkPosition = GetPosition(1, 3, 5, 7)

            ElseIf (Button(3) = "O" AndAlso Button(5) = "O") OrElse (Button(1) = "O" AndAlso Button(7) = "O") Then
                MarkPosition = GetPosition(0, 2)

            ElseIf Button(1) = "O" AndAlso (Button(3) = "O" OrElse Button(5) = "O") Then
                MarkPosition = GetPosition(0, 2)
            ElseIf Button(7) = "O" AndAlso (Button(3) = "O" OrElse Button(5) = "O") Then
                MarkPosition = GetPosition(6, 8)

            ElseIf (Button(1) = "O" OrElse Button(7) = "O") Then
                MarkPosition = GetPosition(3, 5)
            ElseIf (Button(3) = "O" OrElse Button(5) = "O") Then
                MarkPosition = GetPosition(1, 7)
            End If
        ElseIf Counter = 5 Then
            If Button(0) = "O" OrElse Button(2) = "O" OrElse Button(6) = "O" OrElse Button(8) = "O" Then
                MarkPosition = GetPosition(6, 8)
            End If

            ' Random Play
        Else
            MarkPosition = GetPosition(0, 1, 2, 3, 4, 5, 6, 7, 8)
        End If


        ' Put X On A Button
        Grid.Controls(MarkPosition).Text = "X"
        Counter += 1

        ' Check For Winner
        CheckForWinner()
    End Sub

    Private Function CanWin(Player As Char, Index(,) As Integer) As Boolean
        For R As Integer = 0 To Index.GetLength(0) - 1
            If Player = Button(Index(R, 0)) AndAlso Button(Index(R, 0)) = Button(Index(R, 1)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function GetPosition(ParamArray Posibilities() As Integer) As Integer
        Randomize()

        Dim Position As Integer
        Do
            Dim Index As Integer = Posibilities(Rnd() * (Posibilities.Length - 1))
            Position = Index
        Loop Until (Button(Position) = "")

        Return Position
    End Function

End Class
