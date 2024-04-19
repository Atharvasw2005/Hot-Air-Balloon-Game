Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class game


    Dim level As Integer
    Dim speed As Integer
    Dim sky(7) As PictureBox
    Dim score As Integer
    Dim new_game As Boolean
    Dim res_game As Boolean

    Private Sub game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        new_game = Home.New_g
        res_game = Home.Res_g

        If (res_game) Then
            Dim lev As Integer = Home.level
            level = lev

            If (level = 1) Then
                speed = 3
                score = 0

            End If

            If (level = 2) Then
                speed = 5
                score = 11

            End If

            If (level = 3) Then
                speed = 6
                score = 31
            End If
            If (level = 4) Then
                speed = 7
                score = 51

            End If
            If (level = 5) Then
                speed = 10
                score = 101
            End If

        End If


        If (new_game) Then
            level = 1
            speed = 3
        End If
        sky(0) = PictureBox1
        sky(1) = PictureBox2
        sky(2) = PictureBox3
        sky(3) = PictureBox4
        sky(4) = PictureBox5
        sky(5) = PictureBox6
        sky(6) = PictureBox7
        sky(7) = PictureBox8

        ' Start the timer controls for obstacle movement
        skyMovers1.Start()
        skyMovers2.Start()
        skyMovers3.Start()
    End Sub

    Private Sub skyMover_Tick(sender As Object, e As EventArgs) Handles skyMover.Tick

        For x As Integer = 0 To 7
            sky(x).Top += speed
            If sky(x).Top >= Me.Height Then
                sky(x).Top = -sky(x).Height
            End If
        Next
        If score > 10 And score < 30 Then
            speed = 5
            level = 2
        End If
        If score > 30 And score < 50 Then
            speed = 6
            level = 3
        End If
        If score > 50 And score < 70 Then
            speed = 7
            level = 4
        End If
        If score > 100 Then
            speed = 10
            level = 5
        End If
        Label2.Text = level
        If (Balloon.Bounds.IntersectsWith(race1.Bounds)) Then
            endgame()
        End If
        If (Balloon.Bounds.IntersectsWith(race2.Bounds)) Then
            endgame()
        End If
        If (Balloon.Bounds.IntersectsWith(race3.Bounds)) Then
            endgame()
        End If
    End Sub

    Private Sub endgame()
        Button1.Visible = True
        Label4.Visible = True
        skyMover.Stop()
        skyMovers1.Stop()
        skyMovers2.Stop()
        skyMovers3.Stop()
        Dim User = login.uname
        Dim pass = login.pass


        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\athar\OneDrive\Documents\New Game Database.accdb")
        con.Open()

        If (new_game) Then
            Dim query As String = "UPDATE Login Set [Level] = @lev WHERE username=@user AND password=@pass"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("@lev", level)
            cmd.Parameters.AddWithValue("@user", User)
            cmd.Parameters.AddWithValue("@pass", pass)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()


        End If
        If (res_game) Then
            Dim lev As Integer = Home.level
            If (lev < level) Then
                Dim query As String = "UPDATE Login Set [Level] = @lev WHERE username=@user AND password=@pass"
                Dim cmd As New OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("@lev", level)
                cmd.Parameters.AddWithValue("@user", User)
                cmd.Parameters.AddWithValue("@pass", pass)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()
            End If
        End If

    End Sub

    Private Sub game_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            RightSide.Start()
        End If
        If e.KeyCode = Keys.Left Then
            LeftSide.Start()
        End If
    End Sub

    Private Sub RightSide_Tick(sender As Object, e As EventArgs) Handles RightSide.Tick
        If (Balloon.Location.X < 295) Then
            Balloon.Left += 5
        End If
    End Sub

    Private Sub LeftSide_Tick(sender As Object, e As EventArgs) Handles LeftSide.Tick
        If (Balloon.Location.X > 0) Then
            Balloon.Left -= 5
        End If
    End Sub

    Private Sub game_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        RightSide.Stop()
        LeftSide.Stop()
    End Sub

    Private Sub skyMover1_Tick(sender As Object, e As EventArgs) Handles skyMovers1.Tick
        race1.Top += speed / 2
        If race1.Top >= Height Then
            score += 1
            Label1.Text = score

            race1.Top = -(Math.Ceiling(Rnd() * 200) + race1.Height)
            race1.Left = CInt(Math.Ceiling(Rnd() * 50)) + 0
        End If
    End Sub

    Private Sub skyMovers2_Tick(sender As Object, e As EventArgs) Handles skyMovers2.Tick
        race2.Top += speed / 3
        If race2.Top >= Height Then
            score += 1
            Label1.Text = score

            race2.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + race2.Height)
            race2.Left = CInt(Math.Ceiling(Rnd() * 50)) + 100
        End If
    End Sub

    Private Sub skyMovers3_Tick(sender As Object, e As EventArgs) Handles skyMovers3.Tick
        race3.Top += speed * 1 / 2
        If race3.Top >= Height Then
            score += 1
            Label1.Text = score

            race3.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + race3.Height)
            race3.Left = CInt(Math.Ceiling(Rnd() * 120)) + 180
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        game_Load(e, e)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
