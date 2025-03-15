<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TextBoxUsername = New TextBox()
        TextBoxPassword = New TextBox()
        ButtonLogin = New Button()
        Label1 = New Label()
        LabelDateTime = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Anchor = AnchorStyles.Top
        TextBoxUsername.Location = New Point(603, 206)
        TextBoxUsername.Multiline = True
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(360, 28)
        TextBoxUsername.TabIndex = 0
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Anchor = AnchorStyles.Top
        TextBoxPassword.Location = New Point(603, 277)
        TextBoxPassword.Multiline = True
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(364, 24)
        TextBoxPassword.TabIndex = 1
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.Anchor = AnchorStyles.Top
        ButtonLogin.Location = New Point(743, 335)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(75, 23)
        ButtonLogin.TabIndex = 2
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(670, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 32)
        Label1.TabIndex = 3
        Label1.Text = "SELAMAT DATANG"
        ' 
        ' LabelDateTime
        ' 
        LabelDateTime.AutoSize = True
        LabelDateTime.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelDateTime.Location = New Point(1425, 0)
        LabelDateTime.Name = "LabelDateTime"
        LabelDateTime.Size = New Size(77, 30)
        LabelDateTime.TabIndex = 4
        LabelDateTime.Text = "Label2"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(721, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 32)
        Label2.TabIndex = 5
        Label2.Text = "Username"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(721, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 32)
        Label3.TabIndex = 6
        Label3.Text = "Password"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' LoginPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cyan
        ClientSize = New Size(1512, 674)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(LabelDateTime)
        Controls.Add(Label1)
        Controls.Add(ButtonLogin)
        Controls.Add(TextBoxPassword)
        Controls.Add(TextBoxUsername)
        Name = "LoginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelDateTime As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
