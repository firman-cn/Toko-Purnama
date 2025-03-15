Imports MySql.Data.MySqlClient
Public Class Kasir
    Dim koneksi As New MySqlConnection("server=localhost;user=root;password=;database=toko-purnama")
    Private txtKodeBarang As Object
    Private txtNamaBarang As Object

    Private Sub Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        disabledAtributte()
        SetupDataGridView()
    End Sub

    Private Sub disabledAtributte()
        RichTextBoxKembalian.Text = "Rp. 0"
        RichTextBoxTotal.Text = "Rp. 0"
        RichTextBoxKembalian.ReadOnly = True
        RichTextBoxTotal.ReadOnly = True

    End Sub
    Private Sub Kasir_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            ' Buka form pencarian barang
            Dim formCari As New CariBarang
            formCari.StartPosition = FormStartPosition.CenterScreen
            formCari.Size = New Size(400, 300)

            ' Tampilkan form dalam mode dialog
            If formCari.ShowDialog() = DialogResult.OK Then
                ' Cek apakah nilai tidak null sebelum diakses
                If Not String.IsNullOrEmpty(formCari.KodeBarang) AndAlso Not String.IsNullOrEmpty(formCari.NamaBarang) Then
                    TextBoxKodeBarang.Text = formCari.KodeBarang
                    TextBoxNamaBarang.Text = formCari.NamaBarang
                Else
                    MessageBox.Show("Barang belum dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        ElseIf e.KeyCode = Keys.F3 Then
            TambahKeDataGrid()
        End If

    End Sub

    Private Sub SetupDataGridView()
        With DGVBarangDipilih
            .Columns.Clear()
            .Columns.Add("No", "No") ' Kolom nomor urut
            .Columns.Add("KodeBarang", "Kode Barang")
            .Columns.Add("NamaBarang", "Nama Barang")
            .Columns.Add("Qty", "Qty") ' Tambahan kolom Qty
            .Columns.Add("HargaJual", "Harga Jual") ' Tambahan kolom Harga Jual
            .Columns.Add("SubTotal", "Sub Total") ' Tambahan kolom Sub Total
        End With
    End Sub

    Private Sub TambahKeDataGrid()
        If DGVBarangDipilih.Columns.Count = 0 Then
            DGVBarangDipilih.Columns.Add("No", "No") ' Kolom Nomor
            DGVBarangDipilih.Columns.Add("KodeBarang", "Kode Barang")
            DGVBarangDipilih.Columns.Add("NamaBarang", "Nama Barang")
            DGVBarangDipilih.Columns.Add("Stok", "Stok Barang")
        End If

        ' Cek apakah txtKodeBarang dan txtNamaBarang tidak kosong
        If TextBoxKodeBarang.Text = "" Or TextBoxNamaBarang.Text = "" Then
            MessageBox.Show("Silakan pilih barang terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each row As DataGridViewRow In DGVBarangDipilih.Rows
            If Not row.IsNewRow AndAlso row.Cells("KodeBarang").Value.ToString() = TextBoxKodeBarang.Text Then
                MessageBox.Show("Barang sudah ada dalam daftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Next


        'Tentukan Nomor Urut (Jumlah Baris + 1)
        Dim nomorUrut As Integer = DGVBarangDipilih.Rows.Count + 1
        ' Tambahkan barang ke DataGridView

        ' Tambahkan barang ke DataGridView
        Dim hargaJual As Integer = 10000 ' Gantilah dengan harga sesuai database
        Dim qty As Integer = 1
        Dim subTotal As Integer = hargaJual * qty

        DGVBarangDipilih.Rows.Add(nomorUrut, TextBoxKodeBarang.Text, TextBoxNamaBarang.Text, qty, hargaJual, subTotal)

        ' Kosongkan kembali text setelah ditambahkan
        TextBoxKodeBarang.Clear()
        TextBoxNamaBarang.Clear()

        ' Fokus kembali ke txtKodeBarang
        TextBoxKodeBarang.Focus()
    End Sub


End Class