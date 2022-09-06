Public Class _5Menu
    Public Property String_Pass As String
    Public Property String_Pass2 As String
    Public Property String_Pass4 As String
    Public Property String_Pass5 As String
    Public Property String_Pass6 As String

    Private Sub _5Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True

        lblTableCode.Text = String_Pass
        lblUsername.Text = String_Pass5
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblTime.Text = Date.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        _2Tables.Show()
        Me.Hide()
    End Sub

    Private Sub lblOrder_Click(sender As Object, e As EventArgs) Handles lblOrder.Click
        _10Order.Show()
        Me.Hide()
    End Sub

    Private Sub lblPay_Click(sender As Object, e As EventArgs) Handles lblPay.Click
        _14Pay.Show()
        Me.Hide()
    End Sub

    Private Sub btnS01_Click(sender As Object, e As EventArgs) Handles btnS01.Click
        AddOrder.Show()
        Me.Hide()

        'Dim Object_Pass As New _8_Order_Amount

        'Object_Pass.String_Pass3 = btnS01.Text

        'Object_Pass.Show()
        'Me.Hide()
    End Sub

    Private Sub btnS02_Click(sender As Object, e As EventArgs) Handles btnS02.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnS03_Click(sender As Object, e As EventArgs) Handles btnS03.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnS04_Click(sender As Object, e As EventArgs) Handles btnS04.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnS05_Click(sender As Object, e As EventArgs) Handles btnS05.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnS06_Click(sender As Object, e As EventArgs) Handles btnS06.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnS07_Click(sender As Object, e As EventArgs) Handles btnS07.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnS08_Click(sender As Object, e As EventArgs) Handles btnS08.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnS09_Click(sender As Object, e As EventArgs) Handles btnS09.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnS10_Click(sender As Object, e As EventArgs) Handles btnS10.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnS11_Click(sender As Object, e As EventArgs) Handles btnS11.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnS12_Click(sender As Object, e As EventArgs) Handles btnS12.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnS13_Click(sender As Object, e As EventArgs) Handles btnS13.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnS14_Click(sender As Object, e As EventArgs) Handles btnS14.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnS15_Click(sender As Object, e As EventArgs) Handles btnS15.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY01_Click(sender As Object, e As EventArgs) Handles btnY01.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY02_Click(sender As Object, e As EventArgs) Handles btnY02.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY03_Click(sender As Object, e As EventArgs) Handles btnY03.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY04_Click(sender As Object, e As EventArgs) Handles btnY04.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY05_Click(sender As Object, e As EventArgs) Handles btnY05.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY06_Click(sender As Object, e As EventArgs) Handles btnY06.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY07_Click(sender As Object, e As EventArgs) Handles btnY07.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY08_Click(sender As Object, e As EventArgs) Handles btnY08.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY09_Click(sender As Object, e As EventArgs) Handles btnY09.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY10_Click(sender As Object, e As EventArgs) Handles btnY10.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY11_Click(sender As Object, e As EventArgs) Handles btnY11.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY12_Click(sender As Object, e As EventArgs) Handles btnY12.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY13_Click(sender As Object, e As EventArgs) Handles btnY13.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY14_Click(sender As Object, e As EventArgs) Handles btnY14.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnY15_Click(sender As Object, e As EventArgs) Handles btnY15.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnT01_Click(sender As Object, e As EventArgs) Handles btnT01.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnT02_Click(sender As Object, e As EventArgs) Handles btnT02.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnT03_Click(sender As Object, e As EventArgs) Handles btnT03.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnT04_Click(sender As Object, e As EventArgs) Handles btnT04.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnT05_Click(sender As Object, e As EventArgs) Handles btnT05.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnT06_Click(sender As Object, e As EventArgs) Handles btnT06.Click
        AddOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnT07_Click(sender As Object, e As EventArgs) Handles btnT07.Click
        AddOrder.Show()
        Me.Hide()

    End Sub
End Class