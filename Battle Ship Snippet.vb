'Code I'm made as the base code for the battle ship game I'm working on for class.
'My teacher also used this code and posted it for the class to use.

Public Class Form1
    Dim ButtonArray(10, 10) As Button
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For x As Integer = 0 To 9 Step 1
            For y As Integer = 0 To 9 Step 1
                ButtonArray(x, y) = New Button
                ButtonArray(x, y).Height = 40
                ButtonArray(x, y).Width = 40
                ButtonArray(x, y).Location = New Point(5 + (x * 40), 10 + (y * 40))
                ButtonArray(x, y).Name = ConvertToLetter(x) + (y + 1).ToString
                ButtonArray(x, y).Text = ConvertToLetter(x) + (y + 1).ToString
                AddHandler ButtonArray(x, y).Click, AddressOf ButtonArray_Click
                Me.Controls.Add(ButtonArray(x, y))
            Next
        Next

    End Sub
    Private Sub ButtonArray_Click(sender As System.Object, e As System.EventArgs)
        Dim btn As Button = CType(sender, Button)
        For x As Integer = 0 To 9 Step 1
            For y As Integer = 0 To 9 Step 1
                If (btn.Text = ButtonArray(x,y).Text) Then
                    ButtonArray(x, y).Text = "HIT"
                End If
            Next
        Next


    End Sub

    Private Function ConvertToLetter(ByVal Number) As String
        Dim Letter As String
        Select Case (Number)
            Case 0
                Letter = "A"
            Case 1
                Letter = "B"
            Case 2
                Letter = "C"
            Case 3
                Letter = "D"
            Case 4
                Letter = "E"
            Case 5
                Letter = "F"
            Case 6
                Letter = "G"
            Case 7
                Letter = "H"
            Case 8
                Letter = "I"
            Case 9
                Letter = "J"
        End Select
        Return Letter
    End Function

    Private Function ConvertToNumber(ByVal Letter) As Integer
        Dim Number As String
        Select Case (Letter)
            Case "A"
                Number = 0
            Case "B"
                Number = 1
            Case "C"
                Number = 2
            Case "D"
                Number = 3
            Case "E"
                Number = 4
            Case "F"
                Number = 5
            Case "G"
                Number = 6
            Case "H"
                Number = 7
            Case "I"
                Number = 8
            Case "J"
                Number = 9
        End Select
        Return Number
    End Function

End Class
