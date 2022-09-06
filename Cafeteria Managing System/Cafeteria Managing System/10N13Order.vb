Imports System.Data.SqlClient

Public Class _10Order
    Public Property String_Pass As String


    Private Sub _10Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Final_DataSet.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter1.Fill(Me.Final_DataSet.Order_Details)
        Timer1.Enabled = True
        Timer2.Enabled = True

        lblTableCode.Text = String_Pass

        'yourform1.yourlistbox1.items = yourlistbox.item

        'ListBoxOrder.Items.Add(String_Pass4)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblTime.Text = Date.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub lblMenu_Click(sender As Object, e As EventArgs) Handles lblMenu.Click
        _5Menu.Show()
        Me.Hide()
    End Sub

    Private Sub lblPay_Click(sender As Object, e As EventArgs) Handles lblPay.Click
        _14Pay.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        _2Tables.Show()
        Me.Hide()
    End Sub
End Class