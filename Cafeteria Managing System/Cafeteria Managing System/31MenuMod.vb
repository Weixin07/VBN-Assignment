Public Class _31MenuMod
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        _34AddNewItem.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        _32UpdateItem.Show()
        Me.Hide()
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        _36DeleteItem.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        _39AddNewCategory.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturnSet_Click(sender As Object, e As EventArgs) Handles btnReturnSet.Click
        _18Settings.Show()
        Me.Hide()
    End Sub

    Private Sub _31MenuMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddNewDeleteCategory.Show()
        Me.Hide()
    End Sub
End Class