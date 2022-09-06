Imports System.Data.SqlClient
Public Class _32UpdateItem
    Dim Connection As New SqlConnection("Data Source=MSI\WEIXIN07;Initial Catalog=Cafeteria_Management_System_Remake;Integrated Security=True")
    Public Sub ExecuteQuery(Query As String)

        Dim Command As New SqlCommand(Query, Connection)
        Connection.Open()
        Command.ExecuteNonQuery()

        Connection.Close()

    End Sub
    Private Sub _32UpdateItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Final_DataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter2.Fill(Me.Final_DataSet.Items)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        _31MenuMod.Show()
        Me.Hide()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'Dim UpdateQuery As String = "Update Items Set Name = " & txtNewName.Text & " WHERE Item_Code = " & cboItemCode.Text & "" And "Update Items Set Price = " & txtNewPrice.Text & " WHERE Item_Code = " & cboItemCode.Text & ""
        'ExecuteQuery(UpdateQuery)

        'Dim SQL As String = String.Empty
        'Sql &= "SELECT * FROM Items "
        'Sql &= " WHERE Item_Code = '" & cboItemCode.Text & "'"

        'Dim UserData As DataTable = ExecuteSQL(SQL)

        'If UserData.Rows.Count > 0 Then
        '_33MessageBox.Show()
        'Me.Hide()
        'End If

        Dim Command As New SqlCommand("Update Items SET Name = @Name, Price = @Price WHERE Item_Code = @ItemCode", Connection)

        Command.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtNewName.Text
        Command.Parameters.Add("@Price", SqlDbType.VarChar).Value = txtNewPrice.Text
        Command.Parameters.Add("@ItemCode", SqlDbType.VarChar).Value = cboItemCode.Text

        Connection.Open()

        If Command.ExecuteNonQuery() = 1 Then

            _33MessageBox.Show()
            Me.Hide()

        End If

        Connection.Close()

    End Sub
End Class