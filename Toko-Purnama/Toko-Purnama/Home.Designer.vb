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
        ButtonKasir = New Button()
        Button2 = New Button()
        ButtonPengguna = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' ButtonKasir
        ' 
        ButtonKasir.Location = New Point(31, 99)
        ButtonKasir.Name = "ButtonKasir"
        ButtonKasir.Size = New Size(294, 55)
        ButtonKasir.TabIndex = 0
        ButtonKasir.Text = "KASIR"
        ButtonKasir.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(388, 176)
        Button2.Name = "Button2"
        Button2.Size = New Size(294, 55)
        Button2.TabIndex = 1
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ButtonPengguna
        ' 
        ButtonPengguna.Location = New Point(1057, 99)
        ButtonPengguna.Name = "ButtonPengguna"
        ButtonPengguna.Size = New Size(294, 55)
        ButtonPengguna.TabIndex = 2
        ButtonPengguna.Text = "Pengguna"
        ButtonPengguna.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(721, 99)
        Button4.Name = "Button4"
        Button4.Size = New Size(294, 55)
        Button4.TabIndex = 3
        Button4.Text = "BARANG"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(388, 99)
        Button5.Name = "Button5"
        Button5.Size = New Size(294, 55)
        Button5.TabIndex = 4
        Button5.Text = "LAPORAN KEUANGAN"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(776, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 27)
        Label1.TabIndex = 5
        Label1.Text = "SELAMAT DATANG "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(129, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 21)
        Label2.TabIndex = 6
        Label2.Text = "TRANSAKSI"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Showcard Gothic", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(776, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(216, 27)
        Label3.TabIndex = 7
        Label3.Text = "DI TOKO PURNAMA"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(1149, 75)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 21)
        Label4.TabIndex = 8
        Label4.Text = "Data"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cyan
        ClientSize = New Size(1508, 607)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(ButtonPengguna)
        Controls.Add(Button2)
        Controls.Add(ButtonKasir)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonKasir As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ButtonPengguna As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
