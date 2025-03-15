<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CariBarang
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
        TextBoxCariBarang = New TextBox()
        DataGridViewHasilCari = New DataGridView()
        CType(DataGridViewHasilCari, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxCariBarang
        ' 
        TextBoxCariBarang.Location = New Point(12, 42)
        TextBoxCariBarang.Name = "TextBoxCariBarang"
        TextBoxCariBarang.Size = New Size(347, 23)
        TextBoxCariBarang.TabIndex = 0
        ' 
        ' DataGridViewHasilCari
        ' 
        DataGridViewHasilCari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewHasilCari.Location = New Point(-1, 164)
        DataGridViewHasilCari.MultiSelect = False
        DataGridViewHasilCari.Name = "DataGridViewHasilCari"
        DataGridViewHasilCari.ReadOnly = True
        DataGridViewHasilCari.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewHasilCari.Size = New Size(800, 261)
        DataGridViewHasilCari.TabIndex = 1
        ' 
        ' CariBarang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridViewHasilCari)
        Controls.Add(TextBoxCariBarang)
        Name = "CariBarang"
        Text = "CariBarang"
        CType(DataGridViewHasilCari, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxCariBarang As TextBox
    Friend WithEvents DataGridViewHasilCari As DataGridView
End Class
