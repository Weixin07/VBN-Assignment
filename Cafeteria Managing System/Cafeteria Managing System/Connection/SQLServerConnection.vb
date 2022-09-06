Imports System.Data.SqlClient

Module SQLServerConnection

    Public StringConnection As String = "Data Source=MSI\WEIXIN07;Initial Catalog=Cafeteria_Management_System_Remake;Integrated Security=True"

    Function ExecuteSQL(Sql As String) As DataTable

        Try

            Dim Connection As New SqlConnection
            Dim Adapter As SqlDataAdapter
            Dim dt As New DataTable

            Connection.ConnectionString = StringConnection
            Connection.Open()

            Adapter = New SqlDataAdapter(Sql, Connection)
            Adapter.Fill(dt)

            Connection.Close()
            Connection = Nothing

            Return dt

        Catch ex As Exception

        End Try

    End Function

End Module
