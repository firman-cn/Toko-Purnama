Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Dashboard - Selamat Datang"
    End Sub
    ' Event klik tombol Pengguna
    Private Sub ButtonPengguna_Click(sender As Object, e As EventArgs) Handles ButtonPengguna.Click
        Me.Hide() ' Menyembunyikan form Home
        Pengguna.Show() ' Menampilkan form Pengguna
    End Sub

    Private Sub ButtonKasir_Click(sender As Object, e As EventArgs) Handles ButtonKasir.Click
        Me.Hide() ' Menyembunyikan form Home
        Kasir.Show()

    End Sub
End Class