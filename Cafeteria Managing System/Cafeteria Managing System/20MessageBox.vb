Imports System.Data.SqlClient

Public Class _20MessageBox
    Public Property String_Pass2 As String
    Private Sub _20MessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True

        Dim Digit As Integer
        Dim Result As String

        Using con As SqlConnection = New SqlConnection("Data Source=MSI\WEIXIN07;Initial Catalog=Cafeteria_Management_System_Remake;Integrated Security=True")
            con.Open()

            Dim cmd = New SqlCommand("Select Max(Attendance_ID) from Attendance", con)
            Result = cmd.ExecuteScalar().ToString()

            If String.IsNullOrEmpty(Result) Then
                Result = "A000000"
                txtAttendanceID.Text = Result
            End If

            Result = Result.Substring(3)
            Int32.TryParse(Result, Digit)
            Digit = Digit + 1
            Result = "R" + Digit.ToString("D6")
            txtAttendanceID.Text = Result
        End Using
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblClocktime2.Text = Date.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click

        Dim mySQL As String = String.Empty

        mySQL &= "INSERT INTO Attendance (Attendance_ID, Date, Clock_In, Clock_Out, Username)"
        mySQL &= " VALUES ('" & txtAttendanceID.Text & "', '" & txtDate.Text & "','" & txtClockInTime.Text & "','" & txtClockOutTime.Text & "','" & txtUsername.Text & "')"

        ExecuteSQL(mySQL)

        AddUserSettings.Show()
        Me.Hide()
    End Sub
End Class