Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        txtName.Text = "Hello" & txtName.Text ' hello concatenated with txtbox value


    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click

        'first option
        'MsgBox("Hello " & txtName.Text)

        'second option
        MessageBox.Show("Hello " & txtName.Text, "Hello " & txtName.Text)
        MessageBox.Show("Hello " & txtName.Text) 'message box without title (caption)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'close the app
        Me.Close()

    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click

        'Integer -2147483648 -> 2147483647
        'Long    very big
        'Decimal very very big (floating point numbers)
        'Double  very very very big
        'Boolean true/false

        'CDec converts to decimal 
        'CBoolconverts to boolean
        'CDbl converts to double

        Try
            Dim iFirstNum As Integer = CInt(txtAddValue1.Text)      'anything -> int (converts to int)
            Dim iSecondNum As Integer = CInt(txtAddValue2.Text)     'anything -> int

            Dim iSum = iFirstNum + iSecondNum

            txtSumAnswear.Text = CStr(iSum)                         'anything -> str

        Catch ee As InvalidCastException
            MessageBox.Show("Please enter numbers to sum",
                            "Error")

            'print to console for debugging purposes
            Console.WriteLine("user not entered numbers - might entered something else (character, symbol etc)")

        Catch ex As Exception
            MessageBox.Show("An unknown error occured",
                            "Error")
        End Try


    End Sub
End Class
