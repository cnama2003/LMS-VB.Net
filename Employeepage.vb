Public Class Employeepage
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Homepage.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Employeeinformation.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Employeeexistinformation.Show()
        Me.Hide()

    End Sub
End Class