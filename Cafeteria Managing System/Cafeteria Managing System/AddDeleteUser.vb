Imports System.Data.SqlClient
Public Class AddDeleteUser
    Dim Connection As SqlConnection = New SqlConnection("Data Source=MSI\WEIXIN07;Initial Catalog=Cafeteria_Management_System_Remake;Integrated Security=True")
    Private Sub AddDeleteUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Final_DataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter1.Fill(Me.Final_DataSet.Staff)


    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim Command As New SqlCommand("DELETE FROM Staff WHERE Username = @Username", Connection)

        Command.Parameters.Add("@Username", SqlDbType.VarChar).Value = cboUsername.Text

        Connection.Open()

        If Command.ExecuteNonQuery() = 1 Then

            AddUserDeleteMessage.Show()
            Me.Hide()

        End If

        Connection.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        AddUserSettings.Show()
        Me.Hide()
    End Sub
End Class