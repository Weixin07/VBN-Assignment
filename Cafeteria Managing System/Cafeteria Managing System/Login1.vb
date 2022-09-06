Imports System.Data.SqlClient
Public Class _1Login
    Dim Connection As New SqlConnection("Data Source=MSI\WEIXIN07;Initial Catalog=Cafeteria_Management_System_Remake;Integrated Security=True")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Final_DataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter1.Fill(Me.Final_DataSet.Staff)

        Timer1.Enabled = True
        Timer2.Enabled = True

        cboUsername.Select()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblTime.Text = Date.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub CheckBoxShow_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShow.CheckedChanged

        With CheckBoxShow

            If .Checked Then
                txtPassword.UseSystemPasswordChar = False
            Else
                txtPassword.UseSystemPasswordChar = True
            End If
        End With
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If Not String.IsNullOrEmpty(cboUsername.Text) And
    Not String.IsNullOrEmpty(txtPassword.Text) Then

            Dim SQL As String = String.Empty
            SQL &= "SELECT * FROM Staff "
            SQL &= " WHERE Username = '" & cboUsername.Text & "'"
            SQL &= " AND Password = '" & txtPassword.Text & "'"

            Dim UserData As DataTable = ExecuteSQL(SQL)

            If UserData.Rows.Count > 0 Then

                txtPassword.Clear()
                CheckBoxShow.Checked = False

                _2Tables.Show()
                Me.Hide()

            Else
                _2MessageBox.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Please enter username and password.")
        End If

        'Dim Object_Pass As New _2Tables

        'Object_Pass.String_Pass2 = txtUsername.Text

        'Object_Pass.Show()
        'Me.Hide()

        'Dim Object_Pass2 As New _3Registration

        'Object_Pass2.String_Pass2 = txtUsername.Text

        'Dim Object_Pass5 As New _5Menu

        'Object_Pass5.String_Pass6 = txtUsername.Text

        'Dim Object_Pass6 As New _21ModUser

        'Object_Pass6.String_Pass6 = txtUsername.Text

        ';Dim Object_Pass7 As New _21ModUser

        'Object_Pass7.String_Pass7 = txtPassword.Text
    End Sub
End Class
