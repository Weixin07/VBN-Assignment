Public Class _17Receipt
    Private Sub _17Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Total As Integer
        Dim Tax As Integer
        Dim TPA As Integer
        Dim Received As Integer
        Dim Change As Integer

        Total = lblTotal2.Text
        Tax = lblTax2.Text
        TPA = lblTPA2.Text
        Received = lblReceived2.Text
        Change = lblChange2.Text

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        _2Tables.Show()
        Me.Hide()
    End Sub
End Class