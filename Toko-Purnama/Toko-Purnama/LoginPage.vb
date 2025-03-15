Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class LoginPage
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi() ' Memanggil fungsi koneksi

        System.Threading.Thread.CurrentThread.CurrentCulture = New CultureInfo("id-ID")
        LabelDateTime.Text = Format(DateTime.Now, "dddd, d MMMM yyyy HH.mm") & " WIB"
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        ' Ambil nilai dari TextBox
        Dim username As String = TextBoxUsername.Text
        Dim password As String = TextBoxPassword.Text

        Dim query As String = "SELECT nama, role FROM user WHERE username=@username AND password=@password"
        Cmd = New MySqlCommand(query, Conn)

        Cmd.Parameters.AddWithValue("@username", username)
        Cmd.Parameters.AddWithValue("@password", password)
        Rd = Cmd.ExecuteReader()

        ' Cek apakah user ditemukan
        If Rd.HasRows Then
            Rd.Read()
            Dim namaUser As String = Rd("nama").ToString()
            Dim roleUser As String = Rd("role").ToString()
            Rd.Close()

            MsgBox("Login Berhasil! Selamat datang, " & namaUser & " (" & roleUser & ")", MsgBoxStyle.Information, "Sukses")

            ' Sembunyikan Form Login dan tampilkan Form2
            Me.Hide()
            'Form2.LabelNama.Text = namaUser
            'Form2.LabelRole.Text = "Role: " & roleUser
            Home.Show()
        Else
            MsgBox("Username atau Password salah!", MsgBoxStyle.Critical, "Error")
            Rd.Close()
        End If
    End Sub
End Class
