Imports System.Data.OleDb
Imports System.Security.Cryptography.Xml
Imports System.Threading

Public Class login
    Public uname As String
    Public pass As String


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub userTextBox_Leave(sender As Object, e As EventArgs) Handles userTextBox.Leave
        If String.IsNullOrEmpty(userTextBox.Text) = True Then
            userTextBox.Focus()
            ErrorProvider1.SetError(Me.userTextBox, "Please Fill UserName ")
        Else
            ErrorProvider1.Clear()

        End If
    End Sub

    Private Sub passwordTextBox_Leave(sender As Object, e As EventArgs) Handles passwordTextBox.Leave
        If String.IsNullOrEmpty(passwordTextBox.Text) = True Then
            passwordTextBox.Focus()
            ErrorProvider2.SetError(Me.passwordTextBox, "Please Fill Password ")
        Else
            ErrorProvider2.Clear()

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            passwordTextBox.PasswordChar = ""
        Else
            passwordTextBox.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        uname = userTextBox.Text
        pass = passwordTextBox.Text
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\athar\OneDrive\Documents\New Game Database.accdb")
        con.Open()
        Dim query As String = "SELECT * FROM Login WHERE username=@user AND password=@pass"
        Dim cmd As New OleDbCommand(query, con)
        cmd.Parameters.AddWithValue("@user", userTextBox.Text)
        cmd.Parameters.AddWithValue("@pass", passwordTextBox.Text)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        If dr.HasRows Then
            MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Home.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        End If

        con.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        registration.Show()
        Me.Hide()
    End Sub
End Class