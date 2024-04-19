<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        user = New TextBox()
        pass = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Agency FB", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(163, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 36)
        Label1.TabIndex = 0
        Label1.Text = "Registration"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Agency FB", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(68, 197)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 36)
        Label2.TabIndex = 1
        Label2.Text = "PASSWORD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Agency FB", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(68, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 36)
        Label3.TabIndex = 2
        Label3.Text = "USERNAME"
        ' 
        ' user
        ' 
        user.Location = New Point(236, 121)
        user.Name = "user"
        user.Size = New Size(193, 40)
        user.TabIndex = 3
        ' 
        ' pass
        ' 
        pass.Location = New Point(236, 193)
        pass.Name = "pass"
        pass.Size = New Size(193, 40)
        pass.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button1.Location = New Point(163, 261)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 43)
        Button1.TabIndex = 5
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button2.Location = New Point(163, 310)
        Button2.Name = "Button2"
        Button2.Size = New Size(153, 43)
        Button2.TabIndex = 6
        Button2.Text = "Back To Login"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' registration
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 34.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(480, 365)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(pass)
        Controls.Add(user)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Agency FB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 5, 4, 5)
        Name = "registration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents user As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
