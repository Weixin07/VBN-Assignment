Public Class _40MessageBox
    Public Property Pass As String
    Private Sub _40MessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pass = lblCatAddSuccess.Text
    End Sub
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        _31MenuMod.Show()
        Me.Hide()
    End Sub
End Class