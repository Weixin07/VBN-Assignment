Imports System.Data.SqlClient

Public Class _8_Order_Amount
    Public Property String_Pass3 As String
    Public Property String_Pass4 As String
    Private Sub _8_Order_Amount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cafeteria_Management_SystemDataSet1.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter1.Fill(Me.Cafeteria_Management_SystemDataSet1.Order_Details)

        Timer1.Enabled = True
        Timer2.Enabled = True

        'Dim Digit As Integer
        'Dim Result As String

        'Using con As SqlConnection = New SqlConnection("Data Source = MSI\WEIXIN07; Initial Catalog = Cafeteria_Management_System;Integrated Security = True")
        'con.Open()

        'Dim cmd = New SqlCommand("Select Max(OD_ID) from Order_Details", con)
        'Result = cmd.ExecuteScalar().ToString()

        'If String.IsNullOrEmpty(Result) Then
        'Result = "OD000000"
        'lblOD_ID.Text = Result
        'End If

        'Result = Result.Substring(3)
        'Int32.TryParse(Result, Digit)
        'Digit = Digit + 1
        'Result = "OD" + Digit.ToString("D6")
        'lblOD_ID.Text = Result
        'End Using

        'Dim Digit1 As Integer
        'Dim Result1 As String

        'Using con As SqlConnection = New SqlConnection("Data Source = MSI\WEIXIN07; Initial Catalog = Cafeteria_Management_System;Integrated Security = True")
        'con.Open()

        'Dim cmd = New SqlCommand("Select Max(Order_ID) from Orders", con)
        'Result1 = cmd.ExecuteScalar().ToString()

        'If String.IsNullOrEmpty(Result) Then
        'Result1 = "OR000000"
        'lblOrderID.Text = Result1
        'End If

        'Result1 = Result1.Substring(3)
        'Int32.TryParse(Result1, Digit1)
        'Digit1 = Digit1 + 1
        'Result1 = "OR" + Digit1.ToString("D6")
        'lblOrderID.Text = Result1
        'End Using
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblTime.Text = Date.Now.ToString("HH:mm:ss")
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim mySQL2 As String = String.Empty

        mySQL2 &= "INSERT INTO Order_Details (OD_ID, Order_ID, Item_Code, Quantity, Status)"
        mySQL2 &= " VALUES ('" & txtOD_ID.Text & "', '" & txtOrder_ID.Text & "', '" & txtItem_Code.Text & "','" & txtQuantity.Text & "', '" & lblStatus.Text & " ')"

        ExecuteSQL(mySQL2)

        _5Menu.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        _5Menu.Show()
        Me.Hide()
    End Sub
End Class