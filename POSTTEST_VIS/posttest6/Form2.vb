
Imports MySqlConnector

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadJenis()
        LoadProduk()
    End Sub

    Sub LoadJenis()
        cmbJenis.DataSource = GetAllJenis()
        cmbJenis.DisplayMember = "jenis"
        cmbJenis.ValueMember = "kodeJenis"
    End Sub

    Sub LoadProduk()
        Dim query As String = "
            SELECT p.kodeProduk, p.namaProduk, j.jenis, p.harga
            FROM tbproduk p
            JOIN tbjenis j ON p.kodeJenis = j.kodeJenis"

        Dim dt As New DataTable()

        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using

        dgvProduk.DataSource = dt
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim query As String = "INSERT INTO tbproduk VALUES (@kode, @nama, @jenis, @harga)"

        Using conn = GetConnection()
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", txtKodeProduk.Text)
                cmd.Parameters.AddWithValue("@nama", txtNamaProduk.Text)
                cmd.Parameters.AddWithValue("@jenis", cmbJenis.SelectedValue)
                cmd.Parameters.AddWithValue("@harga", txtHarga.Text)

                cmd.ExecuteNonQuery()
            End Using
        End Using

        LoadProduk()
    End Sub

End Class