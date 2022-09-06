Imports System.Data.SqlClient
Public Class _25ChgPassword
    Dim Connection As New SqlConnection("Data Source=MSI\WEIXIN07;Initial Catalog=Cafeteria_Management_System_Remake;Integrated Security=True")
    Private Sub _25ChgPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Final_DataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter1.Fill(Me.Final_DataSet.Staff)

    End Sub
    Public Sub ExecuteQuery(Query As String)

        Dim Command As New SqlCommand(Query, Connection)
        Connection.Open()
        Command.ExecuteNonQuery()

        Connection.Close()

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        'If Not String.IsNullOrEmpty(cboUsername.Text) And
        '   Not String.IsNullOrEmpty(txtCurrentPasswordIpt.Text) And
        '  Not String.IsNullOrEmpty(txtNewPasswordIpt.Text) And
        ' Not String.IsNullOrEmpty(txtNewPasswordReIpt.Text) Then

        'Dim SQL As String = String.Empty
        'Sql &= "SELECT * FROM Staff "
        'Sql &= " WHERE Password = '" & txtCurrentPasswordIpt.Text & "'"

        'Dim UserData As DataTable = ExecuteSQL(SQL)

        'If UserData.Rows.Count > 0 Then

        'If txtNewPasswordIpt.Text = txtNewPasswordReIpt.Text Then

        'Dim UpdateQuery As String = "Update Staff Set Password = " & txtNewPasswordReIpt.Text & " WHERE Username = " & cboUsername.Text & ""
        'ExecuteQuery(UpdateQuery)

        'Dim SQL1 As String = String.Empty
        'SQL1 &= "SELECT * FROM Staff "
        'SQL1 &= " WHERE Password = '" & txtNewPasswordReIpt.Text & "'"

        'Dim UserData1 As DataTable = ExecuteSQL(SQL)

        'If UserData1.Rows.Count > 0 Then
        '_27MessageBox.Show()
        'Me.Hide()
        '            End If
        'Else
        'MessageBox.Show("The passwords do not match, please try again.")
        'End If
        'Else
        '_26MessageBox.Show()
        'Me.Hide()
        'End If
        'Else
        'MessageBox.Show("Please enter username and password.")
        'End If

        If Not String.IsNullOrEmpty(cboUsername.Text) And
           Not String.IsNullOrEmpty(txtCurrentPasswordIpt.Text) And
              Not String.IsNullOrEmpty(txtNewPasswordIpt.Text) And
             Not String.IsNullOrEmpty(txtNewPasswordReIpt.Text) Then

            Dim SQL As String = String.Empty
            SQL &= "SELECT * FROM Staff "
            Sql &= " WHERE Password = '" & txtCurrentPasswordIpt.Text & "'"

            Dim UserData As DataTable = ExecuteSQL(Sql)

            If UserData.Rows.Count > 0 Then

                If txtNewPasswordIpt.Text = txtNewPasswordReIpt.Text Then

                    Dim Command As New SqlCommand("Update Staff SET Password = @Password WHERE Username = @username", Connection)

                    Command.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtNewPasswordReIpt.Text
                    Command.Parameters.Add("@username", SqlDbType.VarChar).Value = cboUsername.Text

                    Connection.Open()

                    If Command.ExecuteNonQuery() = 1 Then

                        _27MessageBox.Show()
                        Me.Hide()

                    End If

                Else
                    MessageBox.Show("The passwords do not match, please try again.")
                End If

            Else
                _26MessageBox.Show()
                Me.Hide()

                Connection.Close()
            End If

        Else
                MessageBox.Show("Please enter username and password.")
            End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        AddUserSettings.Show()
        Me.Hide()
    End Sub
End Class