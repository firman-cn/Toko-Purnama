<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kasir
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
        TextBoxKodeBarang = New TextBox()
        TextBoxNamaBarang = New TextBox()
        TextBox4 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        DGVBarangDipilih = New DataGridView()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        RichTextBoxTotal = New RichTextBox()
        RichTextBoxKembalian = New RichTextBox()
        CType(DGVBarangDipilih, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxKodeBarang
        ' 
        TextBoxKodeBarang.Location = New Point(158, 28)
        TextBoxKodeBarang.Name = "TextBoxKodeBarang"
        TextBoxKodeBarang.Size = New Size(235, 23)
        TextBoxKodeBarang.TabIndex = 0
        ' 
        ' TextBoxNamaBarang
        ' 
        TextBoxNamaBarang.Location = New Point(158, 68)
        TextBoxNamaBarang.Name = "TextBoxNamaBarang"
        TextBoxNamaBarang.Size = New Size(235, 23)
        TextBoxNamaBarang.TabIndex = 1
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(1026, 25)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(289, 23)
        TextBox4.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 5
        Label1.Text = "Kode Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 6
        Label2.Text = "Nama Barang"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(922, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 15)
        Label4.TabIndex = 8
        Label4.Text = "Tanggal Transaski"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' DGVBarangDipilih
        ' 
        DGVBarangDipilih.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVBarangDipilih.Location = New Point(50, 126)
        DGVBarangDipilih.Name = "DGVBarangDipilih"
        DGVBarangDipilih.Size = New Size(1221, 150)
        DGVBarangDipilih.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 543)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 15)
        Label3.TabIndex = 10
        Label3.Text = "F2|CARI BARANG"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(127, 543)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 15)
        Label5.TabIndex = 11
        Label5.Text = "F3|TAMBAH BARANG"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(640, 502)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 12
        Label6.Text = "TOTAL:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1065, 502)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 15)
        Label7.TabIndex = 13
        Label7.Text = "KEMBALIAN"
        ' 
        ' RichTextBoxTotal
        ' 
        RichTextBoxTotal.Location = New Point(688, 484)
        RichTextBoxTotal.Name = "RichTextBoxTotal"
        RichTextBoxTotal.Size = New Size(279, 53)
        RichTextBoxTotal.TabIndex = 14
        RichTextBoxTotal.Text = ""
        ' 
        ' RichTextBoxKembalian
        ' 
        RichTextBoxKembalian.Location = New Point(1143, 484)
        RichTextBoxKembalian.Name = "RichTextBoxKembalian"
        RichTextBoxKembalian.Size = New Size(279, 53)
        RichTextBoxKembalian.TabIndex = 15
        RichTextBoxKembalian.Text = ""
        ' 
        ' Kasir
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cyan
        ClientSize = New Size(1509, 567)
        Controls.Add(RichTextBoxKembalian)
        Controls.Add(RichTextBoxTotal)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(DGVBarangDipilih)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox4)
        Controls.Add(TextBoxNamaBarang)
        Controls.Add(TextBoxKodeBarang)
        Name = "Kasir"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kasir"
        WindowState = FormWindowState.Maximized
        CType(DGVBarangDipilih, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxKodeBarang As TextBox
    Friend WithEvents TextBoxNamaBarang As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents DataGridViewBarangSelect As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVBarangDipilih As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RichTextBoxTotal As RichTextBox
    Friend WithEvents RichTextBoxKembalian As RichTextBox
End Class
