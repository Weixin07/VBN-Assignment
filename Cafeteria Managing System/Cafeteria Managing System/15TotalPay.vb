Public Class _15TotalPay
    Private Sub _15TotalPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Final_DataSet.Receipt_Details' table. You can move, or remove it, as needed.
        Me.Receipt_DetailsTableAdapter1.Fill(Me.Final_DataSet.Receipt_Details)

        'Dim Total As Integer
        'Dim Tax As Integer
        'Dim TPA As Integer
        'Dim Received As Integer
        'Dim Change As Integer

        'Total = lblTotal2.Text
        'Tax = lblTax2.Text
        'TPA = lblTPA2.Text
        'Received = txtReceived.Text
        'Received-TPA = Change
        'Change = lblChange2.Text

    End Sub

    Private Sub btnPrn_Click(sender As Object, e As EventArgs) Handles btnPrn.Click
        _16MessageBox.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        _2Tables.Show()
        Me.Hide()
    End Sub
End Class