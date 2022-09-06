Imports System.Data.SqlClient
Public Class _22ChgUsername
    Dim Connection As New SqlConnection("Data Source = MSI\WEIXIN07; Initial Catalog = Cafeteria_Management_System;Integrated Security = True")
    Private Sub _22ChgUsername_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cafeteria_Management_SystemDataSet1.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.Cafeteria_Management_SystemDataSet1.Staff)
    End Sub
    Public Sub ExecuteQuery(Query As String)

        Dim Command As New SqlCommand(Query, Connection)
        Connection.Open()
        Command.ExecuteNonQuery()

        Connection.Close()

    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'Dim UpdateQuery As String = "Update Staff Set Username = " & txtNewUsername.Text & " WHERE Username = " & cboCurrentUsername.Text & ""
        'ExecuteQuery(UpdateQuery)

        'Dim SQL As String = String.Empty
        'SQL &= "SELECT Username FROM Staff "
        'SQL &= " WHERE Username = '" & txtNewUsername.Text & "'"

        'Dim UserData As DataTable = ExecuteSQL(SQL)

        'If UserData.Rows.Count > 0 Then
        _23MessageBox.Show()
            Me.Hide()
        'Else
        '_24MessageBox.Show()
        'Me.Hide()
        'End If
    End Sub
End Class