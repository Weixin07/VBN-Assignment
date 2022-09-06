Public Class _39AddNewCategory
    Dim Pass As String
    Private Sub _39AddNewCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        _31MenuMod.Show()
        Me.Hide()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim mySQL As String = String.Empty

        mySQL &= "INSERT INTO Category (Category)"
        mySQL &= " VALUES ('" & txtNewName.Text & "')"

        ExecuteSQL(mySQL)

        txtNewName.Text = Pass

        _40MessageBox.Show()
        Me.Hide()
    End Sub





End Class