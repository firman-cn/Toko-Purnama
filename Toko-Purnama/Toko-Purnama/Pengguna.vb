Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Pengguna
    Private Sub Pengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        ComboBoxRole.Items.Add("admin")
        ComboBoxRole.Items.Add("kasir")
        TextBoxPassword.PasswordChar = "*"
        TextBoxConfirmPassword.PasswordChar = "*"
    End Sub

    Private Sub ButtonPilihFoto_Click(sender As Object, e As EventArgs) Handles ButtonPilihFoto.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"
        If ofd.ShowDialog = DialogResult.OK Then
            PictureBoxFotoProfil.Image = Image.FromFile(ofd.FileName)
            PictureBoxFotoProfil.Tag = ofd.FileName
        End If
    End Sub

    Private Sub ButtonSimpanPengguna_Click(sender As Object, e As EventArgs) Handles ButtonSimpanPengguna.Click
        If TextBoxNama.Text = "" Or TextBoxUsername.Text = "" Or TextBoxPassword.Text = "" Or TextBoxConfirmPassword.Text = "" Or ComboBoxRole.Text = "Pilih Role" Then
            MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ' Validasi password
        If TextBoxPassword.Text <> TextBoxConfirmPassword.Text Then
            MessageBox.Show("Konfirmasi password tidak sesuai!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ' Hash password (opsional - bisa gunakan enkripsi sederhana)
        Dim password As String = TextBoxPassword.Text ' Bisa gunakan hashing seperti BCrypt

        ' Simpan foto
        Dim fotoPath As String = ""
        If PictureBoxFotoProfil.Tag IsNot Nothing Then
            Dim fileName As String = "foto_" & TextBoxUsername.Text & Path.GetExtension(PictureBoxFotoProfil.Tag.ToString())
            fotoPath = Application.StartupPath & "\uploads\" & fileName
            Directory.CreateDirectory(Application.StartupPath & "\uploads") ' Buat folder jika belum ada
            File.Copy(PictureBoxFotoProfil.Tag.ToString(), fotoPath, True)
        End If
        ' Simpan ke database
        Try
            Dim sql As String = "INSERT INTO user (nama, username, password, role, foto_profil) VALUES (@nama, @username, @password, @role, @foto_profil)"
            Cmd = New MySqlCommand(sql, Conn)
            Cmd.Parameters.AddWithValue("@nama", TextBoxNama.Text)
            Cmd.Parameters.AddWithValue("@username", TextBoxUsername.Text)
            Cmd.Parameters.AddWithValue("@password", password)
            Cmd.Parameters.AddWithValue("@role", ComboBoxRole.Text)
            Cmd.Parameters.AddWithValue("@foto_profil", fotoPath)

            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset form
            ResetForm()
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data! " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    ' Fungsi reset form setelah menyimpan
    Private Sub ResetForm()
        TextBoxNama.Clear()
        TextBoxUsername.Clear()
        TextBoxPassword.Clear()
        TextBoxConfirmPassword.Clear()
        ComboBoxRole.SelectedIndex = -1
        PictureBoxFotoProfil.Image = Nothing
        PictureBoxFotoProfil.Tag = Nothing
    End Sub

End Class