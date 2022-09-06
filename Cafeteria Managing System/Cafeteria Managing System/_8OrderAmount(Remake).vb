Imports System.Data.SqlClient
Public Class _8OrderAmount_Remake_
    Private Sub _8OrderAmount_Remake__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Final_DataSet.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter1.Fill(Me.Final_DataSet.Order_Details)
        'TODO: This line of code loads data into the 'Final_DataSet.Status' table. You can move, or remove it, as needed.
        Me.StatusTableAdapter1.Fill(Me.Final_DataSet.Status)
        'TODO: This line of code loads data into the 'Final_DataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter1.Fill(Me.Final_DataSet.Items)
        'TODO: This line of code loads data into the 'Final_DataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter1.Fill(Me.Final_DataSet.Orders)


        Timer1.Enabled = True
        Timer2.Enabled = True

        Dim Digit As Integer
        Dim Result As String

        Using con As SqlConnection = New SqlConnection("Data Source=MSI\WEIXIN07;Initial Catalog=Cafeteria_Management_System_Remake;Integrated Security=True")
            con.Open()

            Dim cmd = New SqlCommand("Select Max(OD_ID) from Order_Details", con)
            Result = cmd.ExecuteScalar().ToString()

            If String.IsNullOrEmpty(Result) Then
                Result = "OD000000"
                txtOD_ID.Text = Result
            End If

            Result = Result.Substring(3)
            Int32.TryParse(Result, Digit)
            Digit = Digit + 1
            Result = "OD" + Digit.ToString("D6")
            txtOD_ID.Text = Result

        End Using

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
        mySQL2 &= " VALUES ('" & txtOD_ID.Text & "', '" & cboorderID.Text & "', '" & cboItemCode.Text & "','" & txtQuantity.Text & "', '" & cboStatus.Text & " ')"

        ExecuteSQL(mySQL2)

        _5Menu.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        _5Menu.Show()
        Me.Hide()
    End Sub
End Class