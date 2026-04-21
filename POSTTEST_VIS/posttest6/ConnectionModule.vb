Imports MySqlConnector

Module ConnectionModule
    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=dbkafe1")
        Return conn
    End Function
End Module
