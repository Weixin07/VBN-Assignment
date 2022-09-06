Imports System.Data.SqlClient
Public Class _34AddNewItem
    Private Sub _34AddNewItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Final_DataSet.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.Final_DataSet.Category)
        'TODO: This line of code loads data into the 'Final_DataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter1.Fill(Me.Final_DataSet.Items)

        Dim Digit As Integer
        Dim Result As String

        Using con As SqlConnection = New SqlConnection("Data Source=MSI\WEIXIN07;Initial Catalog=Cafeteria_Management_System_Remake;Integrated Security=True")
            con.Open()

            Dim cmd = New SqlCommand("Select Max(Item_Code) from Items", con)
            Result = cmd.ExecuteScalar().ToString()

            If String.IsNullOrEmpty(Result) Then
                Result = "NF000000"
                lblSelfCode.Text = Result
            End If

            Result = Result.Substring(3)
            Int32.TryParse(Result, Digit)
            Digit = Digit + 1
            Result = "NF" + Digit.ToString("D6")
            lblSelfCode.Text = Result

        End Using
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If String.IsNullOrEmpty(cboCategory.Text) Then
            MessageBox.Show("Please enter the category.")
            Return
        End If

        If String.IsNullOrEmpty(txtName.Text) Then
            MessageBox.Show("Please enter the name.")
            Return
        End If

        If String.IsNullOrEmpty(txtPrice.Text) Then
            MessageBox.Show("Please enter the price.")
            Return
        End If

        Dim mySQL As String = String.Empty

        mySQL &= "INSERT INTO Items (Item_Code, Category, Name, Price)"
        mySQL &= " VALUES ('" & lblSelfCode.Text & "', '" & cboCategory.Text & "','" & txtName.Text & "','" & txtPrice.Text & "')"

        ExecuteSQL(mySQL)

        txtName.Clear()
        txtPrice.Clear()

        _35MessageBox.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        _31MenuMod.Show()
        Me.Hide()
    End Sub
End Class