<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(game))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        race3 = New PictureBox()
        race1 = New PictureBox()
        Balloon = New PictureBox()
        skyMover = New Timer(components)
        RightSide = New Timer(components)
        LeftSide = New Timer(components)
        skyMovers1 = New Timer(components)
        skyMovers2 = New Timer(components)
        skyMovers3 = New Timer(components)
        Label4 = New Label()
        Button1 = New Button()
        race2 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(race3, ComponentModel.ISupportInitialize).BeginInit()
        CType(race1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Balloon, ComponentModel.ISupportInitialize).BeginInit()
        CType(race2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonHighlight
        PictureBox1.Location = New Point(-8, -49)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(14, 86)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.ButtonHighlight
        PictureBox2.Location = New Point(387, -63)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(10, 118)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ButtonHighlight
        PictureBox3.Location = New Point(387, 97)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(10, 118)
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.ButtonHighlight
        PictureBox4.Location = New Point(-6, 92)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(12, 118)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.ButtonHighlight
        PictureBox5.Location = New Point(387, 237)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(10, 118)
        PictureBox5.TabIndex = 5
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.ButtonHighlight
        PictureBox6.Location = New Point(-6, 245)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(12, 118)
        PictureBox6.TabIndex = 4
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = SystemColors.ButtonHighlight
        PictureBox7.Location = New Point(387, 371)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(10, 118)
        PictureBox7.TabIndex = 7
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = SystemColors.ButtonHighlight
        PictureBox8.Location = New Point(-6, 394)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(12, 118)
        PictureBox8.TabIndex = 6
        PictureBox8.TabStop = False
        ' 
        ' race3
        ' 
        race3.Image = CType(resources.GetObject("race3.Image"), Image)
        race3.Location = New Point(29, 211)
        race3.Name = "race3"
        race3.Size = New Size(53, 47)
        race3.SizeMode = PictureBoxSizeMode.StretchImage
        race3.TabIndex = 10
        race3.TabStop = False
        ' 
        ' race1
        ' 
        race1.Image = CType(resources.GetObject("race1.Image"), Image)
        race1.Location = New Point(274, 211)
        race1.Name = "race1"
        race1.Size = New Size(53, 41)
        race1.SizeMode = PictureBoxSizeMode.StretchImage
        race1.TabIndex = 12
        race1.TabStop = False
        ' 
        ' Balloon
        ' 
        Balloon.Image = CType(resources.GetObject("Balloon.Image"), Image)
        Balloon.Location = New Point(144, 319)
        Balloon.Name = "Balloon"
        Balloon.Size = New Size(46, 87)
        Balloon.SizeMode = PictureBoxSizeMode.StretchImage
        Balloon.TabIndex = 13
        Balloon.TabStop = False
        ' 
        ' skyMover
        ' 
        skyMover.Enabled = True
        skyMover.Interval = 10
        ' 
        ' RightSide
        ' 
        RightSide.Interval = 10
        ' 
        ' LeftSide
        ' 
        LeftSide.Interval = 10
        ' 
        ' skyMovers1
        ' 
        skyMovers1.Enabled = True
        skyMovers1.Interval = 10
        ' 
        ' skyMovers2
        ' 
        skyMovers2.Enabled = True
        skyMovers2.Interval = 10
        ' 
        ' skyMovers3
        ' 
        skyMovers3.Enabled = True
        skyMovers3.Interval = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonFace
        Label4.Font = New Font("Agency FB", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(94, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(179, 50)
        Label4.TabIndex = 15
        Label4.Text = "GAME OVER"
        Label4.Visible = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightCoral
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.Font = New Font("Agency FB", 21F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(118, 237)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 51)
        Button1.TabIndex = 16
        Button1.Text = "REPLAY"
        Button1.UseVisualStyleBackColor = False
        Button1.Visible = False
        ' 
        ' race2
        ' 
        race2.Image = CType(resources.GetObject("race2.Image"), Image)
        race2.Location = New Point(144, 44)
        race2.Name = "race2"
        race2.Size = New Size(58, 38)
        race2.SizeMode = PictureBoxSizeMode.StretchImage
        race2.TabIndex = 11
        race2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AllowDrop = True
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Label2.Font = New Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(418, 297)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 48)
        Label2.TabIndex = 9
        Label2.Text = "0"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Label1.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(418, 169)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 46)
        Label1.TabIndex = 8
        Label1.Text = "0"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        Label1.UseCompatibleTextRendering = True
        Label1.UseWaitCursor = True
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(412, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 36)
        Label3.TabIndex = 9
        Label3.Text = "SCORE"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(446, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 36)
        Label5.TabIndex = 10
        Label5.Text = "Level"
        ' 
        ' game
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(582, 453)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(PictureBox7)
        Controls.Add(Label3)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(PictureBox3)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Balloon)
        Controls.Add(race1)
        Controls.Add(race2)
        Controls.Add(race3)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox1)
        MaximumSize = New Size(600, 500)
        MinimumSize = New Size(600, 500)
        Name = "game"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hot Air Balloon Game"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(race3, ComponentModel.ISupportInitialize).EndInit()
        CType(race1, ComponentModel.ISupportInitialize).EndInit()
        CType(Balloon, ComponentModel.ISupportInitialize).EndInit()
        CType(race2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents race3 As PictureBox
    Friend WithEvents race1 As PictureBox
    Friend WithEvents Balloon As PictureBox
    Friend WithEvents skyMover As Timer
    Friend WithEvents RightSide As Timer
    Friend WithEvents LeftSide As Timer
    Friend WithEvents skyMovers1 As Timer
    Friend WithEvents skyMovers2 As Timer
    Friend WithEvents skyMovers3 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button



    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles race2.Click

    End Sub

    Friend WithEvents race2 As PictureBox
    Friend WithEvents Label2 As Label
    Public WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
