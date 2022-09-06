Public Class _30MessageBox
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        AddUserSettings.Show()
        Me.Hide()
    End Sub

    Private Sub _30MessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class