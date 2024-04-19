Imports System.Data.OleDb
Imports System.Diagnostics.Eventing

Public Class Home
    Public New_g As Boolean = False
    Public level As Integer = 1
    Public Res_g As Boolean = False
    Private Sub resume_game_Click(sender As Object, e As EventArgs) Handles resume_game.Click
        Res_g = True
        game.Show()
        Me.Hide()
    End Sub

    Private Sub New_game_Click(sender As Object, e As EventArgs) Handles New_game.Click
        New_g = True
        game.Show()
        Me.Hide()

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim User = login.uname
        Dim pass = login.pass


        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\athar\OneDrive\Documents\New Game Database.accdb")
        con.Open()
        Dim query As String = "SELECT [Level] FROM Login WHERE username=@user AND password=@pass"
        Dim cmd As New OleDbCommand(query, con)
        cmd.Parameters.AddWithValue("@user", User)
        cmd.Parameters.AddWithValue("@pass", pass)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        While dr.Read()
            level = dr("Level")
        End While
        dr.Close()
    End Sub
End Class