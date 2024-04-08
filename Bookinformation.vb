Imports System.Data.SqlClient


Public Class Bookinformation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Bookrecordpage.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connecionstring As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\library.mdf;Integrated Security=True;Connect Timeout=30"
        Dim connection As New SqlConnection(connecionstring)
        connection.Open()
        Dim insert As String = "insert into Bookinformation(Bookid,Booktittle,Bookedition,Copiesofbook,Bookauthorname,Course,Branch) values(@Bookid,@Booktittle,@Bookedition,@Copiesofbook,@Bookauthorname,@Course,@Branch)"
        Dim insertcommand As New SqlCommand(insert, connection)
        insertcommand.Parameters.AddWithValue("@Bookid", Txt1.Text)
        insertcommand.Parameters.AddWithValue("@Booktittle", Txt2.Text)
        insertcommand.Parameters.AddWithValue("@Bookedition", Txt3.Text)
        insertcommand.Parameters.AddWithValue("@Copiesofbook", Integer.Parse(Txt4.Text))
        insertcommand.Parameters.AddWithValue("@Bookauthorname", Txt5.Text)
        insertcommand.Parameters.AddWithValue("@Course", Txt6.Text)
        insertcommand.Parameters.AddWithValue("@Branch", Txt7.Text)
        insertcommand.ExecuteNonQuery()
        connection.Close()
        MsgBox("Data Added Successfully")



    End Sub
End Class