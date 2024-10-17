Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click


        MsgBox("hello world")
        MsgBox("how are you?")
        MsgBox("i hope you are well")



    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        MsgBox("welcome to vb .net prog course")

        'sequence
        MsgBox("welcome")
        MsgBox("to")
        MsgBox("vb")
        MsgBox(".net")

        MessageBox.Show("welcome to vb.net") 'object oriented approach

    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        'st comes from string (name convention)
        'dim = dimension (amount of memory set aside

        stFirstName = "Kevin" '5 bytes

        MsgBox(stFirstName)

        MsgBox("Hello and welcome " & stFirstName) 'string concatenation with &

        MsgBox("Hello and welcome  " & stFirstName & " 'The Boss'") 'string concatenation with &

        stFirstName = "Marc"
        MsgBox("Hello and welcome " & stFirstName)


    End Sub
End Class
