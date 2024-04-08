Imports System.Data.SqlClient
Public Class Studentinformation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Studentpage.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionstring As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\library.mdf;Integrated Security=True;Connect Timeout=30"
        Dim connection As New SqlConnection(connectionstring)
        connection.Open()
        Dim insert As String = "insert into Studentinformation(Studentid,Studentname,Studentcontactno,Gender,Course,Branch) values(@Studentid,@Studentname,@Studentcontactno,@Gender,@Course,@Branch)"
        Dim insertcommand As New SqlCommand(insert, connection)
        insertcommand.Parameters.AddWithValue("@Studentid", Txt1.Text)
        insertcommand.Parameters.AddWithValue("@Studentname", Txt2.Text)
        insertcommand.Parameters.AddWithValue("@Studentcontactno", Txt3.Text)
        insertcommand.Parameters.AddWithValue("@Gender", Txt4.Text)
        insertcommand.Parameters.AddWithValue("@Course", Txt5.Text)
        insertcommand.Parameters.AddWithValue("@Branch", Txt6.Text)
        insertcommand.ExecuteNonQuery()
        connection.Close()
        MsgBox("Data Added Successfully")
    End Sub

End Class