Public Class Add2ConfirmationChangeMsg
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Add3MessageBox.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        _10Order.Show()
        Me.Hide()
    End Sub
End Class