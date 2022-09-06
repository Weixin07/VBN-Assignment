Public Class AddUserDeleteMessage
    Private Sub AddUserDeleteMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        AddUserSettings.Show()
        Me.Hide()
    End Sub
End Class