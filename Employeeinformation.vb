Imports System.Data.SqlClient

Public Class Employeeinformation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Employeepage.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim doj As Date
        doj = Convert.ToDateTime(DateTimePicker3.Value)


        Dim connectionstring As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\library.mdf;Integrated Security=True;Connect Timeout=30"
        Dim connection As New SqlConnection(connectionstring)
        connection.Open()
        Dim insert As String = "insert into Employeeinformation(Employeeid,Employeename,Contactno,Gender,DOJ,Salary) values(@Employeeid,@Emplyeename,@contactno,@Gender,@DOJ,@Salary)"
        Dim insertcommand As New SqlCommand(insert, connection)
        insertcommand.Parameters.AddWithValue("@Employeeid", Txt1.Text)
        insertcommand.Parameters.AddWithValue("@Emplyeename", Txt2.Text)
        insertcommand.Parameters.AddWithValue("@Contactno", Txt3.Text)
        insertcommand.Parameters.AddWithValue("@Gender", Txt4.Text)
        insertcommand.Parameters.AddWithValue("@DOJ", doj.Date)
        insertcommand.Parameters.AddWithValue("@Salary", Txt5.Text)
        insertcommand.ExecuteNonQuery()
        connection.Close()
        MsgBox("Data Added Successfully")

    End Sub
End Class