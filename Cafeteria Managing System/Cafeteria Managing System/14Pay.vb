Imports System.Data.SqlClient
Public Class _14Pay
    Public Property String_Pass As String
    Public Property String_Pass2 As String

    Dim total1 As Double
    Dim Total2 As Double
    Private Sub _14Pay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Final_DataSet.Receipt_Details' table. You can move, or remove it, as needed.
        Me.Receipt_DetailsTableAdapter1.Fill(Me.Final_DataSet.Receipt_Details)
        'TODO: This line of code loads data into the 'Final_DataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter1.Fill(Me.Final_DataSet.Items)
        'TODO: This line of code loads data into the 'Final_DataSet.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter1.Fill(Me.Final_DataSet.Order_Details)

        Timer1.Enabled = True
        Timer2.Enabled = True

        lblTableCode.Text = String_Pass

        Dim Digit As Integer
        Dim Result As String

        Using con As SqlConnection = New SqlConnection("Data Source=MSI\WEIXIN07;Initial Catalog=Cafeteria_Management_System_Remake;Integrated Security=True")
            con.Open()

            Dim cmd = New SqlCommand("Select Max(RD_ID) from Receipt_Details", con)
            Result = cmd.ExecuteScalar().ToString()

            If String.IsNullOrEmpty(Result) Then
                Result = "RD000000"
                txtRD_ID.Text = Result
            End If

            Result = Result.Substring(3)
            Int32.TryParse(Result, Digit)
            Digit = Digit + 1
            Result = "RD" + Digit.ToString("D6")
            txtRD_ID.Text = Result

        End Using
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

    Private Sub lblOrder_Click(sender As Object, e As EventArgs) Handles lblOrder.Click
        _10Order.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        _2Tables.Show()
        Me.Hide()
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs)
        _15TotalPay.Show()
        Me.Hide()
    End Sub

    'Private Sub btnAddToReceipt_Click(sender As Object, e As EventArgs) Handles btnAddToReceipt.Click
    'Dim Price As String = PriceTextBox.Text
    'Dim Total As Integer = 0

    'For index = 0 To Price.Length - 1
    '       ListBoxPrice.Items.Add(Price(index))
    'Next
    '   txtTotal.Text = Total

    'End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        total1 = total1 + Val(txtCalculateTotal.Text)
        txtCalculateTotal.Clear()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Total2 = total1 + txtCalculateTotal.Text
        txtCalculateTotal.Text = Total2
        total1 = 0
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        txtCalculateTotal.Text = PriceTextBox.Text + txtCalculateTotal.Text
    End Sub

    Private Sub btnAddToReceipt_Click(sender As Object, e As EventArgs) Handles btnAddToReceipt.Click
        txtTotal.Text = txtCalculateTotal.Text
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        txtTax.Text = txtTotal.Text * 0.06
    End Sub

    Private Sub btnCalculate2_Click(sender As Object, e As EventArgs) Handles btnCalculate2.Click
        txtTPA.Text = Val(txtTotal.Text) + Val(txtTax.Text)
    End Sub

    Private Sub btnCalculate3_Click(sender As Object, e As EventArgs) Handles btnCalculate3.Click
        txtChange.Text = Val(txtReceived.Text) - Val(txtTPA.Text)
    End Sub

    Private Sub btnProceed_Click_1(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim mySQL As String = String.Empty

        mySQL &= "INSERT INTO Receipt_Details (RD_ID, Total, Total_Payable_Amount, Received, Change, Order_ID)"
        mySQL &= " VALUES ('" & txtRD_ID.Text & "', '" & txtTotal.Text & "','" & txtTax.Text & "','" & txtTPA.Text & "','" & txtReceived.Text & "','" & txtChange.Text & "','" & cboOrderID.Text & "')"

        ExecuteSQL(mySQL)

        PriceTextBox.Clear()
        txtCalculateTotal.Clear()
        txtChange.Clear()
        txtReceived.Clear()
        txtRD_ID.Clear()
        txtTax.Clear()
        txtTotal.Clear()
        txtTPA.Clear()

        _16MessageBox.Show()
        Me.Hide()

    End Sub


    ' Private Sub btnAddToReceipt_Click(sender As Object, e As EventArgs) Handles btnAddToReceipt.Click
    'Dim mySQL As String = String.Empty

    '   mySQL &= "INSERT INTO Receipt_Details (RD_ID, Total, Total_Payable_Amount_Received, Change, Order_ID, Receipt_ID)"
    '  mySQL &= " VALUES ('" & lblTableCode2.Text & "', '" & txtCustomer_ID.Text & "','" & txtName.Text & "','" & txtContactNumber.Text & "')"

    ' ExecuteSQL(mySQL)

    'txtName.Clear()
    'txtContactNumber.Clear()

    '_5Menu.Show()
    'Me.Hide()
    'End Sub

    'Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
    'Dim mySQL As String = String.Empty

    '   mySQL &= "INSERT INTO Receipt_Details (RD_ID, Total, Total_Payable_Amount_Received, Change, Order_ID, Receipt_ID)"
    '  mySQL &= " VALUES ('" & lblTableCode2.Text & "', '" & txtCustomer_ID.Text & "','" & txtName.Text & "','" & txtContactNumber.Text & "')"

    ' ExecuteSQL(mySQL)

    'txtName.Clear()
    'txtContactNumber.Clear()

    '_5Menu.Show()
    'Me.Hide()
    'End Sub
End Class