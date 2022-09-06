Imports System.Data.SqlClient
Public Class AddOrder
    Private Sub AddOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Final_DataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter1.Fill(Me.Final_DataSet.Staff)
        'TODO: This line of code loads data into the 'Final_DataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter2.Fill(Me.Final_DataSet.Customers)
        'TODO: This line of code loads data into the 'Final_DataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter2.Fill(Me.Final_DataSet.Orders)

        Timer1.Enabled = True
        Timer2.Enabled = True

        Dim Digit As Integer
        Dim Result As String

        Using con As SqlConnection = New SqlConnection("Data Source=MSI\WEIXIN07;Initial Catalog=Cafeteria_Management_System_Remake;Integrated Security=True")
            con.Open()

            Dim cmd = New SqlCommand("Select Max(Order_ID) from Orders", con)
            Result = cmd.ExecuteScalar().ToString()

            If String.IsNullOrEmpty(Result) Then
                Result = "OR000000"
                txtOrder_ID.Text = Result
            End If

            Result = Result.Substring(3)
            Int32.TryParse(Result, Digit)
            Digit = Digit + 1
            Result = "OR" + Digit.ToString("D6")
            txtOrder_ID.Text = Result

        End Using

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim mySQL3 As String = String.Empty

        mySQL3 &= "INSERT INTO Orders (Order_ID, Table_Code, Customer_ID, Username)"
        mySQL3 &= " VALUES ('" & txtOrder_ID.Text & "', '" & txtTableCode.Text & "','" & cboCustomer.Text & "', '" & cboUsername.Text & " ')"

        ExecuteSQL(mySQL3)

        _8OrderAmount_Remake_.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblTime.Text = Date.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        _5Menu.Show()
        Me.Hide()
    End Sub
End Class