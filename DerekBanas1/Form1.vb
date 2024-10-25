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
End Class
