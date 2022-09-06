Imports System.Data.SqlClient

Public Class _3Registration
    Public Property String_Pass As String
    Public Property String_Pass2 As String
    Private Sub _3Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True

        lblTableCode.Text = String_Pass
        lblTableCode2.Text = String_Pass
        lblUsername.Text = String_Pass2

        Dim Digit As Integer
        Dim Result As String

        Using con As SqlConnection = New SqlConnection("Data Source=MSI\WEIXIN07;Initial Catalog=Cafeteria_Management_System_Remake;Integrated Security=True")
            con.Open()

            Dim cmd = New SqlCommand("Select Max(Customer_ID) from Customers", con)
            Result = cmd.ExecuteScalar().ToString()

            If String.IsNullOrEmpty(Result) Then
                Result = "CI000000"
                txtCustomer_ID.Text = Result
            End If

            Result = Result.Substring(3)
            Int32.TryParse(Result, Digit)
            Digit = Digit + 1
            Result = "CI" + Digit.ToString("D6")
            txtCustomer_ID.Text = Result

        End Using

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblTime.Text = Date.Now.ToString("HH:mm:ss")
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrEmpty(txtName.Text) Then
            MessageBox.Show("Please enter the name.")
            Return
        End If

        If String.IsNullOrEmpty(txtContactNumber.Text) Then
            MessageBox.Show("Please enter the contact number.")
            Return
        End If

        Dim mySQL As String = String.Empty

        mySQL &= "INSERT INTO Customers (Table_Code, Customer_ID, Name, Contact_Number)"
        mySQL &= " VALUES ('" & lblTableCode2.Text & "', '" & txtCustomer_ID.Text & "','" & txtName.Text & "','" & txtContactNumber.Text & "')"

        ExecuteSQL(mySQL)

        txtName.Clear()
        txtContactNumber.Clear()

        _5Menu.Show()
        Me.Hide()

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        _2Tables.Show()
        Me.Hide()
    End Sub
End Class