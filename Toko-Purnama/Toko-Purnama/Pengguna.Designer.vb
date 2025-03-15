<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pengguna
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
        PictureBoxFotoProfil = New PictureBox()
        ComboBoxRole = New ComboBox()
        ButtonSimpanPengguna = New Button()
        TextBoxNama = New TextBox()
        TextBoxUsername = New TextBox()
        TextBoxPassword = New TextBox()
        TextBoxConfirmPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        ButtonPilihFoto = New Button()
        CType(PictureBoxFotoProfil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxFotoProfil
        ' 
        PictureBoxFotoProfil.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        PictureBoxFotoProfil.Image = My.Resources.Resources.user1
        PictureBoxFotoProfil.Location = New Point(509, 45)
        PictureBoxFotoProfil.Name = "PictureBoxFotoProfil"
        PictureBoxFotoProfil.Size = New Size(205, 262)
        PictureBoxFotoProfil.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBoxFotoProfil.TabIndex = 0
        PictureBoxFotoProfil.TabStop = False
        ' 
        ' ComboBoxRole
        ' 
        ComboBoxRole.FormattingEnabled = True
        ComboBoxRole.Location = New Point(157, 243)
        ComboBoxRole.Name = "ComboBoxRole"
        ComboBoxRole.Size = New Size(225, 23)
        ComboBoxRole.TabIndex = 1
        ComboBoxRole.Text = "Pilih Role"
        ' 
        ' ButtonSimpanPengguna
        ' 
        ButtonSimpanPengguna.Location = New Point(157, 320)
        ButtonSimpanPengguna.Name = "ButtonSimpanPengguna"
        ButtonSimpanPengguna.Size = New Size(75, 23)
        ButtonSimpanPengguna.TabIndex = 2
        ButtonSimpanPengguna.Text = "Simpan"
        ButtonSimpanPengguna.UseVisualStyleBackColor = True
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Location = New Point(157, 59)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(225, 23)
        TextBoxNama.TabIndex = 4
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Location = New Point(157, 103)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(225, 23)
        TextBoxUsername.TabIndex = 5
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(157, 148)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(225, 23)
        TextBoxPassword.TabIndex = 6
        ' 
        ' TextBoxConfirmPassword
        ' 
        TextBoxConfirmPassword.Location = New Point(157, 196)
        TextBoxConfirmPassword.Name = "TextBoxConfirmPassword"
        TextBoxConfirmPassword.Size = New Size(225, 23)
        TextBoxConfirmPassword.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 8
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 9
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 10
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(39, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 15)
        Label4.TabIndex = 11
        Label4.Text = "Confirm Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(39, 246)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 15)
        Label6.TabIndex = 13
        Label6.Text = "Role"
        ' 
        ' ButtonPilihFoto
        ' 
        ButtonPilihFoto.Location = New Point(575, 320)
        ButtonPilihFoto.Name = "ButtonPilihFoto"
        ButtonPilihFoto.Size = New Size(75, 23)
        ButtonPilihFoto.TabIndex = 14
        ButtonPilihFoto.Text = "Pilih Foto"
        ButtonPilihFoto.UseVisualStyleBackColor = True
        ' 
        ' Pengguna
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1036, 817)
        Controls.Add(ButtonPilihFoto)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBoxConfirmPassword)
        Controls.Add(TextBoxPassword)
        Controls.Add(TextBoxUsername)
        Controls.Add(TextBoxNama)
        Controls.Add(ButtonSimpanPengguna)
        Controls.Add(ComboBoxRole)
        Controls.Add(PictureBoxFotoProfil)
        Name = "Pengguna"
        Text = "Pengguna"
        CType(PictureBoxFotoProfil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBoxFotoProfil As PictureBox
    Friend WithEvents ComboBoxRole As ComboBox
    Friend WithEvents ButtonSimpanPengguna As Button
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxConfirmPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonPilihFoto As Button
End Class
