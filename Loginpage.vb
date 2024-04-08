Public Class Loginpage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As String
        Dim pass As Integer
        id = TextBox1.Text
        pass = Integer.Parse(TextBox2.Text)
        If (id = "Chandan" And pass = 1234) Then
            Homepage.Show()
            Me.Hide()

        Else
            MsgBox("You have Entered Wrong Password")

        End If


    End Sub
End Class
