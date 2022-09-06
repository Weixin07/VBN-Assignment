Imports System.Data.SqlClient
Public Class _28NewUserReg
    Dim Connection As New SqlConnection("Data Source=MSI\WEIXIN07;Initial Catalog=Cafeteria_Management_System_Remake;Integrated Security=True")
    Private Sub _28NewUserReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewUser.Select()
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim mySQL As String = String.Empty

        mySQL &= "INSERT INTO Staff (Username, Password)"
        mySQL &= " VALUES ('" & txtNewUser.Text & "', '" & txtNewPassword.Text & "')"

        ExecuteSQL(mySQL)

        _30MessageBox.Show()
        Me.Hide()

        'If Not String.IsNullOrEmpty(txtNewUser.Text) And
        'Not String.IsNullOrEmpty(txtNewPassword.Text) Then

        'Dim SQL As String = String.Empty
        'SQL &= "SELECT * FROM Staff "
        'SQL &= " WHERE Username = '" & txtNewUser.Text & "', '" & txtNewPassword.Text & "')"

        'Dim UserData As DataTable = ExecuteSQL(SQL)

        'If UserData.Rows.Count > 0 Then
        '_30MessageBox.Show()
        'Me.Hide()
        'Else
        '_29MessageBox.Show()
        'Me.Hide()
        'End If
        'End If


        'txtNewUser.Clear()
        'txtNewPassword.Clear()

        'Dim Command As New SqlCommand("INSERT INTO Staff(Username, Password) VALUES('" & txtNewUser.Text & "','" & txtNewPassword.Text & ")", Connection)


        'Connection.Open()
        'If Command.ExecuteNonQuery() = 1 Then
        ' _30MessageBox.Show()
        ' Me.Hide()

        'Else
        '  _29MessageBox.Show()
        '   Me.Hide()
        'End If

        'Connection.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        AddUserSettings.Show()
        Me.Hide()
    End Sub
    Private Sub CheckBoxShow_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShow.CheckedChanged
        With CheckBoxShow

            If .Checked Then
                txtNewPassword.UseSystemPasswordChar = False
            Else
                txtNewPassword.UseSystemPasswordChar = True
            End If
        End With
    End Sub
End Class