Imports MySql.Data.MySqlClient

Module Connection
    ' Deklarasi variabel koneksi
    Public Conn As MySqlConnection
    Public Cmd As MySqlCommand
    Public Da As MySqlDataAdapter
    Public Rd As MySqlDataReader
    Public Ds As DataSet
    Public Str As String

    ' Fungsi untuk menghubungkan ke database
    Public Sub Koneksi()
        Try
            Str = "server=localhost;user id=root;password=;database=toko-purnama"
            Conn = New MySqlConnection(Str)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
                MsgBox("Koneksi Berhasil!", MsgBoxStyle.Information, "Informasi")
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal! " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Module
