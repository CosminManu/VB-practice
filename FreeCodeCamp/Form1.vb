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

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        Dim stModel As String = "Ford"
        Dim stMake As String = "Escort"
        Dim iDoors As Integer = 5
        Dim stColour As String = "Red"
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer = "1200"
        Dim decPrice As Decimal = 999.99

        Dim dtDateRegistered As Date = #11/2/2024# 'month/day/year

        'concatenating with &
        MsgBox("the car is " &
               stMake & " " &
               stModel & " " &
               iDoors & " " &
               stColour & " " &
               bTaxed & " " &
               iEngineSize & " " &
               decPrice & " " &
               dtDateRegistered)

        'newline
        MsgBox("the car is " & vbNewLine &
               stMake & vbNewLine &
               stModel & vbNewLine &
               iDoors & vbNewLine &
               stColour & vbNewLine &
               bTaxed & vbNewLine &
               iEngineSize & vbNewLine &
               decPrice & vbNewLine &
               dtDateRegistered)

    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        Dim stFirstName As String = InputBox("please enter your name")

        MsgBox("hello " & stFirstName)



    End Sub
End Class
