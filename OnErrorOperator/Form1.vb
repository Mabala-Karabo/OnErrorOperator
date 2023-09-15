Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userInput As String
        Dim numericValue As Double

        ' Enable error handling
        On Error GoTo ErrorHandler

        ' Prompt the user for input
        Console.Write("Enter a value: ")
        userInput = txtNum.Text

        ' Attempt to convert the user input to a numeric value
        numericValue = Double.Parse(userInput)

        ' If no error occurred, display the numeric value
        MsgBox("The numeric value is: " & numericValue)

ExitProgram:
        ' Disable error handling
        On Error Resume Next

        ' Optional: Include cleanup or other code that runs after error handling

        Console.ReadLine() ' Pause to see the result (optional)
        Exit Sub

ErrorHandler:
        ' Handle the error when user input is not numeric
        MsgBox("Error: Input is not numeric.")

        ' Resume normal execution after handling the error
        Resume ExitProgram
    End Sub
End Class
