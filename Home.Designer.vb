<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        resume_game = New Button()
        New_game = New Button()
        SuspendLayout()
        ' 
        ' resume_game
        ' 
        resume_game.BackColor = SystemColors.ControlDark
        resume_game.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        resume_game.Location = New Point(184, 97)
        resume_game.Name = "resume_game"
        resume_game.Size = New Size(412, 74)
        resume_game.TabIndex = 0
        resume_game.Text = "Resume Game"
        resume_game.UseVisualStyleBackColor = False
        ' 
        ' New_game
        ' 
        New_game.BackColor = SystemColors.AppWorkspace
        New_game.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        New_game.Location = New Point(184, 193)
        New_game.Name = "New_game"
        New_game.Size = New Size(412, 76)
        New_game.TabIndex = 1
        New_game.Text = "New Game"
        New_game.UseVisualStyleBackColor = False
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ClientSize = New Size(800, 450)
        Controls.Add(New_game)
        Controls.Add(resume_game)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        ResumeLayout(False)
    End Sub

    Friend WithEvents resume_game As Button
    Friend WithEvents New_game As Button
End Class
