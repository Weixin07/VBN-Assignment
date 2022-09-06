Public Class AddUserSettings
    Private Sub AddUserSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        _20MessageBox.Show()
        Me.Hide()
    End Sub

    Private Sub btnChgPassword_Click(sender As Object, e As EventArgs) Handles btnChgPassword.Click
        _25ChgPassword.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        _28NewUserReg.Show()
        Me.Hide()
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        AddDeleteUser.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturnSet_Click(sender As Object, e As EventArgs) Handles btnReturnSet.Click
        _18Settings.Show()
        Me.Hide()
    End Sub
End Class