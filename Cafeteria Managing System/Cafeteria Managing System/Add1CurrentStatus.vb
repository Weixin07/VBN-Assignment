Public Class Add1CurrentStatus
    Private Sub Add1CurrentStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cafeteria_Management_SystemDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.Cafeteria_Management_SystemDataSet.Items)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        _10Order.Show()
        Me.Hide()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Add2ConfirmationChangeMsg.Show()
        Me.Hide()
    End Sub
End Class