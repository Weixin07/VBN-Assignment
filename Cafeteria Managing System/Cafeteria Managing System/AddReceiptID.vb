Imports System.Data.SqlClient
Public Class AddReceiptID
    Private Sub AddReceiptID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cafeteria_Management_SystemDataSet1.Receipts' table. You can move, or remove it, as needed.
        Me.ReceiptsTableAdapter.Fill(Me.Cafeteria_Management_SystemDataSet1.Receipts)

        Dim Digit As Integer
        Dim Result As String

        Using con As SqlConnection = New SqlConnection("Data Source = MSI\WEIXIN07; Initial Catalog = Cafeteria_Management_System;Integrated Security = True")
            con.Open()

            Dim cmd = New SqlCommand("Select Max(Receipt_ID) from Receipts", con)
            Result = cmd.ExecuteScalar().ToString()

            If String.IsNullOrEmpty(Result) Then
                Result = "R000000"
                txtReceiptID.Text = Result
            End If

            Result = Result.Substring(3)
            Int32.TryParse(Result, Digit)
            Digit = Digit + 1
            Result = "R" + Digit.ToString("D6")
            txtReceiptID.Text = Result
        End Using

        Dim Digit1 As Integer
        Dim Result1 As String

        Using con1 As SqlConnection = New SqlConnection("Data Source = MSI\WEIXIN07; Initial Catalog = Cafeteria_Management_System;Integrated Security = True")
            con1.Open()

            Dim cmd1 = New SqlCommand("Select Max(RD_ID) from Receipt_Details", con1)
            Result1 = cmd1.ExecuteScalar().ToString()

            If String.IsNullOrEmpty(Result1) Then
                Result1 = "RD000000"
                txtRICode.Text = Result1
            End If

            Result1 = Result1.Substring(3)
            Int32.TryParse(Result1, Digit1)
            Digit1 = Digit1 + 1
            Result1 = "RD" + Digit1.ToString("D6")
            txtRICode.Text = Result1
        End Using

    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        Dim mySQL As String = String.Empty

        mySQL &= "INSERT INTO Receipts (Receipt_ID, RD_ID)"
        mySQL &= " VALUES ('" & txtReceiptID.Text & "', '" & txtRICode.Text & "')"

        'ExecuteSQL(mySQL)

        _14Pay.Show()
        Me.Hide()
    End Sub
End Class