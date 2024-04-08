Imports System.Data.SqlClient

Public Class Bookreturnexistinformation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\library.mdf;Integrated Security=True;Connect Timeout=30")
        If Txt1.Text IsNot "" Then
            Dim cmd As New SqlCommand("Select *from Bookreturninformation Where Bookid = @Bookid", Conn)
            cmd.Parameters.AddWithValue("@Bookid", Txt1.Text)


            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.Visible = True

        Else
            Dim cmd1 As New SqlCommand("Select *from Bookreturninformation", Conn)
            Dim adapter1 As New SqlDataAdapter(cmd1)

            Dim table1 As New DataTable()
            adapter1.Fill(table1)
            DataGridView1.DataSource = table1
            DataGridView1.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BookReturnpage.Show()
        Me.Hide()
    End Sub
End Class