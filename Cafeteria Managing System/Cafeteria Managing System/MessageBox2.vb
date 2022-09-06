Public Class _2MessageBox
    Private Sub _2MessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        _1Login.Show()
        Me.Hide()
    End Sub
End Class