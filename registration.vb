Imports System.Data.OleDb
Public Class registration

    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\athar\OneDrive\Documents\New Game Database.accdb")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\athar\OneDrive\Documents\New Game Database.accdb")
        con.Open()
        Dim query As String = "INSERT INTO Login ([username], [Level], [password]) VALUES (@user, @lev, @pass)"
        Dim cmd As New OleDbCommand(query, con)
        cmd.Parameters.AddWithValue("@user", user.Text)
        cmd.Parameters.AddWithValue("@lev", 1) ' Assuming the default level is 1
        cmd.Parameters.AddWithValue("@pass", pass.Text)
        cmd.ExecuteNonQuery() ' Execute the INSERT query
        MessageBox.Show("Register Successful", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Me.Close()
        login.Show()
    End Sub

    Private Sub pass_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub user_TextChanged(sender As Object, e As EventArgs) Handles user.TextChanged

    End Sub
End Class