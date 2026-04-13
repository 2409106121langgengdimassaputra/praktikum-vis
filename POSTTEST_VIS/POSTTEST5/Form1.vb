Imports System.Data

Public Class Form1

    ' =========================
    ' FUNGSI KOSONGKAN INPUT
    ' =========================
    Private Sub Kosong()
        txtKodeJenis.Clear()
        txtJenis.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        label1.Focus()
    End Sub

    ' =========================
    ' TAMPIL DATA KE GRID
    ' =========================
    Private Sub TampilData()
        dgvJenis.DataSource = GetAllJenis()
    End Sub

    ' =========================
    ' LOAD FORM
    ' =========================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    ' =========================
    ' SIMPAN DATA (CREATE)
    ' =========================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        ' Validasi input kosong
        If label1.Text.Trim() = "" Then
            ErrorProvider1.SetError(label1, "Kode tidak boleh kosong")
            label1.Focus()
            Exit Sub
        End If

        If Me.txtJenis.Text.Trim() = "" Then
            ErrorProvider1.SetError(Me.txtJenis, "Jenis tidak boleh kosong")
            Me.txtJenis.Focus()
            Exit Sub
        End If

        Dim kode As String = txtKodeJenis.Text.Trim()
        Dim jenis As String = Me.txtJenis.Text.Trim()

        ' Cek kode sudah ada
        If KodeSudahAda(kode) Then
            MessageBox.Show("Kode sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Simpan
        If SimpanJenis(kode, jenis) Then
            MessageBox.Show("Data berhasil disimpan", "Info")
            TampilData()
            Kosong()
        End If
    End Sub

    ' =========================
    ' UPDATE DATA
    ' =========================
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If label1.Text.Trim() = "" Then
            MessageBox.Show("Pilih data dulu!")
            Exit Sub
        End If

        If UbahJenis(label1.Text.Trim(), txtJenis.Text.Trim()) Then
            MessageBox.Show("Data berhasil diubah")
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan")
        End If
    End Sub

    ' =========================
    ' HAPUS DATA
    ' =========================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If label1.Text.Trim() = "" Then
            MessageBox.Show("Pilih data dulu!")
            Exit Sub
        End If

        Dim konfirmasi As DialogResult
        konfirmasi = MessageBox.Show("Yakin hapus data?", "Konfirmasi", MessageBoxButtons.YesNo)

        If konfirmasi = DialogResult.Yes Then
            If HapusJenis(label1.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus")
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    ' =========================
    ' RESET / BATAL
    ' =========================
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    ' =========================
    ' SEARCH DATA
    ' =========================
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvJenis.DataSource = SearchJenis(txtSearch.Text.Trim())
        End If
    End Sub

    ' =========================
    ' KLIK DATA DI GRID
    ' =========================
    Private Sub dgvJenis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJenis.CellClick
        If e.RowIndex >= 0 Then
            label1.Text = dgvJenis.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtJenis.Text = dgvJenis.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If
    End Sub

End Class