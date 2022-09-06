Imports System.Data.SqlClient
Public Class AddNewDeleteCategory
    Dim Connection As SqlConnection = New SqlConnection("Data Source=MSI\WEIXIN07;Initial Catalog=Cafeteria_Management_System_Remake;Integrated Security=True")
    Private Sub AddNewDeleteCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Final_DataSet.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.Final_DataSet.Category)

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim Command As New SqlCommand("DELETE FROM Category WHERE Category = @Category", Connection)

        Command.Parameters.Add("@Category", SqlDbType.VarChar).Value = cboCategory.Text

        Connection.Open()

        If Command.ExecuteNonQuery() = 1 Then

            AddCatMes.Show()
            Me.Hide()

        End If

        Connection.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        _31MenuMod.Show()
        Me.Hide()
    End Sub
End Class