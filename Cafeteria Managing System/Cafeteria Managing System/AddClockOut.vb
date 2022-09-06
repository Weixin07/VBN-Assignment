Imports System.Data.SqlClient

Public Class AddClockOut
    Public Property String_Pass2 As String
    Private Sub AddClockOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True

        lblUsername.Text = String_Pass2
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblClocktime2.Text = Date.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Dim mySQL As String = String.Empty

        mySQL &= "INSERT INTO Attendance (Attendance_ID, Date, Clock_Out, Username)"
        mySQL &= " VALUES ('" & lblAttendance_ID.Text & "', '" & lblDate.Text & "','" & lblClocktime2.Text & "','" & lblUsername.Text & "')"

        'ExecuteSQL(mySQL)

        _18Settings.Show()
        Me.Hide()
    End Sub
End Class