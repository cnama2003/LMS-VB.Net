Imports System.Data.SqlClient
Public Class StudentExistingRecord
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\library.mdf;Integrated Security=True;Connect Timeout=30")
        If Txt1.Text IsNot "" Then
            Dim cmd As New SqlCommand("Select *from Studentinformation Where Studentid = @Studentid", Conn)
            cmd.Parameters.AddWithValue("@Studentid", Txt1.Text)


            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.Visible = True

        Else
            Dim cmd1 As New SqlCommand("Select *from Studentinformation", Conn)
            Dim adapter1 As New SqlDataAdapter(cmd1)

            Dim table1 As New DataTable()
            adapter1.Fill(table1)
            DataGridView1.DataSource = table1
            DataGridView1.Visible = True



        End If
    End Sub

    Private Sub Txt1_TextChanged(sender As Object, e As EventArgs) Handles Txt1.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Studentpage.Show()
        Me.Hide()

    End Sub
End Class