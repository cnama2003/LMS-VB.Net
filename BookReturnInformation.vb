Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class BookReturnInformation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BookReturnpage.Show()
        Me.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim issue As Date
        Dim subdate As Date
        issue = Convert.ToDateTime(DateTimePicker3.Value)
        subdate = Convert.ToDateTime(DateTimePicker4.Value)



        Dim connectionstring As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\library.mdf;Integrated Security=True;Connect Timeout=30"
        Dim connection As New SqlConnection(connectionstring)
        connection.Open()
        Dim insert As String = "insert into Bookreturninformation(Bookid,Studentid,Studentname,Dateofissue,Submissiondate,course) values(@Bookid,@Studentid,@Studentname,@Dateofissue,@Submissiondate,@Course)"
        Dim insertcommand As New SqlCommand(insert, connection)
        insertcommand.Parameters.AddWithValue("@Bookid", Txt1.Text)
        insertcommand.Parameters.AddWithValue("@Studentid", Txt2.Text)
        insertcommand.Parameters.AddWithValue("@Studentname", Txt3.Text)
        insertcommand.Parameters.AddWithValue("@Dateofissue", issue.Date)
        insertcommand.Parameters.AddWithValue("@Submissiondate", subdate.Date)
        insertcommand.Parameters.AddWithValue("@Course", Txt4.Text)
        insertcommand.ExecuteNonQuery()
        connection.Close()
        MsgBox("Data added Successfully")

    End Sub
End Class