Imports MySql.Data.MySqlClient
Public Class Form1
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vb")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New MySqlCommand("SELECT `username`, `password` FROM `login` WHERE `username` = @username AND `password` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBox2.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid Username Or Password")

        Else

            MessageBox.Show("Logged In")



        End If

    End Sub
End Class
