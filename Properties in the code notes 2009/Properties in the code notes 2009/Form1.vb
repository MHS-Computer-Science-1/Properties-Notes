Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'The ASSIGNMENT OPERATOR (=) changes a value

        'Change the text color
        Label1.ForeColor = Color.Blue

        'Change the background color
        Label1.BackColor = Color.Gold

        'The apostrophe ' is a COMMENT. This is a message
        'for the programmer. The computer ignores it

    End Sub





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = "Chemic Pride"

        'Notes:
        'Label1 is the NAME of the label. The name property is 
        'how we refer to the UI in the code

        'Quotes go around the value when we are using words

        '"Chemic Pride" = Label1.text **ERROR**
        'What I want to change on LEFT
        'What I want to change it to goes on RIGHT
    End Sub




    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Change Font
        'When I want to change the font, I must create a new font

        'Specify typeface, size, and style (in that order)
        Label1.Font = New Font("Arial", 24, FontStyle.Underline)
    End Sub






    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        'Change the font, but leave the size alone
        Label1.Font = New Font("Arial", Label1.Font.Size, FontStyle.Bold)
        'Label1.Font.Size is an EXPRESSION and it will be evaluated
        'when the button is clicked
    End Sub











    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        'Make sure you choose "click"
        MsgBox("You clicked me!")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Quit the program
        Me.Close()

    End Sub










    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
