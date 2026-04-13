Imports MySqlConnector

Module DataModule

    Public Function GetAllJenis() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM tbjenis"

        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

    Public Function SimpanJenis(kode As String, jenis As String) As Boolean
        Dim query As String = "INSERT INTO tbjenis (kodeJenis, jenis) VALUES (@kode, @jenis)"

        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@jenis", jenis)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Return True
    End Function

    Public Function UbahJenis(kode As String, jenis As String) As Boolean
        Dim query As String = "UPDATE tbjenis SET jenis=@jenis WHERE kodeJenis=@kode"

        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@jenis", jenis)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Return True
    End Function

    Public Function HapusJenis(kode As String) As Boolean
        Dim query As String = "DELETE FROM tbjenis WHERE kodeJenis=@kode"

        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Return True
    End Function

    Public Function SearchJenis(keyword As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM tbjenis WHERE kodeJenis LIKE @key OR jenis LIKE @key"

        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function
    Public Function KodeSudahAda(kode As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM tbjenis WHERE kodeJenis=@kode"

        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return jumlah > 0
            End Using
        End Using
    End Function

End Module
