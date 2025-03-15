Imports MySql.Data.MySqlClient
Public Class CariBarang
    Public Property KodeBarang As String
    Public Property StokBarang As String
    Public Property HargaJualbarang As String

    Public Property NamaBarang As String


    Dim koneksi As New MySqlConnection("server=localhost;user=root;password=;database=toko-purnama")
    Dim adapter As MySqlDataAdapter
    Dim data As DataTable
    Private Sub CariBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' Tampilkan semua barang saat form pertama kali dibuka
        TampilBarang("")
    End Sub

    Sub TampilBarang(keyword As String)
        Try
            koneksi.Open()
            Dim query As String = "SELECT kode_barang, nama_barang, stok,harga_beli,harga_jual FROM barang WHERE nama_barang LIKE @keyword"
            adapter = New MySqlDataAdapter(query, koneksi)
            adapter.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
            data = New DataTable
            adapter.Fill(data)
            DataGridViewHasilCari.DataSource = data
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data barang: " & ex.Message)
        Finally
            koneksi.Close()
        End Try
    End Sub

    ' Ketika user mengetik di TextBox, langsung cari data
    'Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCariBarang.TextChanged
    '    TampilBarang(TextBoxCariBarang.Text)
    'End Sub

    Private Sub DataGridViewHasilCari_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewHasilCari.CellDoubleClick

        If e.RowIndex >= 0 Then
            KodeBarang = DataGridViewHasilCari.Rows(e.RowIndex).Cells(0).Value.ToString()
            NamaBarang = DataGridViewHasilCari.Rows(e.RowIndex).Cells(1).Value.ToString()
            StokBarang = DataGridViewHasilCari.Rows(e.RowIndex).Cells(2).Value.ToString()
            HargaJualBarang = DataGridViewHasilCari.Rows(e.RowIndex).Cells(3).Value.ToString()

            DialogResult = DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub TextBoxCariBarang_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCariBarang.TextChanged
        TampilBarang(TextBoxCariBarang.Text)

    End Sub


End Class