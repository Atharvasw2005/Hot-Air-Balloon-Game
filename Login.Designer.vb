<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        GroupBox1 = New GroupBox()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        passwordTextBox = New TextBox()
        userTextBox = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        LinkLabel1 = New LinkLabel()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaption
        GroupBox1.Controls.Add(LinkLabel1)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(passwordTextBox)
        GroupBox1.Controls.Add(userTextBox)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(359, 256)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(192, 39)
        CheckBox1.TabIndex = 8
        CheckBox1.Text = "SHOW PASSWORD"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Location = New Point(390, 301)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 51)
        Button1.TabIndex = 6
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(31, 86)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(231, 225)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' passwordTextBox
        ' 
        passwordTextBox.Location = New Point(490, 201)
        passwordTextBox.Name = "passwordTextBox"
        passwordTextBox.PasswordChar = "*"c
        passwordTextBox.Size = New Size(184, 40)
        passwordTextBox.TabIndex = 4
        ' 
        ' userTextBox
        ' 
        userTextBox.Location = New Point(490, 136)
        userTextBox.Name = "userTextBox"
        userTextBox.Size = New Size(184, 40)
        userTextBox.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(314, 206)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 35)
        Label2.TabIndex = 2
        Label2.Text = "PASSWORD"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(314, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 35)
        Label1.TabIndex = 1
        Label1.Text = "USERNAME"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(424, 14)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(113, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(334, 355)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(237, 35)
        LinkLabel1.TabIndex = 9
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Not Register? Click Here"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(728, 450)
        Controls.Add(GroupBox1)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents userTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
