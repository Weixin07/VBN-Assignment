Imports System.Data.SqlClient
Public Class _36DeleteItem
    Dim Connection As SqlConnection = New SqlConnection("Data Source=MSI\WEIXIN07;Initial Catalog=Cafeteria_Management_System_Remake;Integrated Security=True")
    Private Sub _36DeleteItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Final_DataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter1.Fill(Me.Final_DataSet.Items)


    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'Dim Connection As SqlConnection = New SqlConnection("Data Source = MSI\WEIXIN07; Initial Catalog = Cafeteria_Management_System;Integrated Security = True")
        'Dim Command As New SqlCommand("DELETE FROM Items WHERE Item_Code = @Item_Code ", Connection)

        'Command.Parameters.Add("@Item_Code", SqlDbType.Int).Value = cboCode.Text

        'Connection.Open()

        'If Command.ExecuteNonQuery() = 1 Then

        '_38MessageBox.Show()
        'Me.Hide()

        'Else
        'MessageBox.Show("This Item does not exist.")
        'End If

        'Connection.Close()

        'Dim Connection As SqlConnection = New SqlConnection("Data Source = MSI\WEIXIN07; Initial Catalog = Cafeteria_Management_System;Integrated Security = True")
        'Dim Reader As SqlDataReader

        'Connection.Open()

        '    Dim Query As String

        '  Query = "DELETE FROM database.Items WHERE Item_Code='" & cboCode.Text & "'"
        '   Dim Command As New SqlCommand(Query, Connection)
        'Reader = Command.ExecuteReader

        '_38MessageBox.Show()
        '   Me.Hide()

        'Connection.Close()

        Dim Command As New SqlCommand("DELETE FROM Items WHERE Item_Code = @ItemCode", Connection)

        Command.Parameters.Add("@ItemCode", SqlDbType.VarChar).Value = cboCode.Text

        Connection.Open()

        If Command.ExecuteNonQuery() = 1 Then

            _38MessageBox.Show()
            Me.Hide()

        End If

        Connection.Close()

        'USE [Cafeteria_Management_System]
        'GO

        'DELETE From [dbo].[Items]
        'Where <Search Conditions,,>
        'GO


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        _31MenuMod.Show()
        Me.Hide()
    End Sub
End Class