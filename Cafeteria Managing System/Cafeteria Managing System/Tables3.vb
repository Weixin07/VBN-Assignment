Public Class _2Tables
    Public Property String_Pass2 As String
    Public Property String_Pass6 As String
    Public Property String_Pass7 As String

    Private Sub _2Tables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True

        lblUsername.Text = String_Pass2
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblTime.Text = Date.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        _1Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim Object_Pass As New _18Settings

        Object_Pass.String_Pass6 = lblUsername.Text

        'Object_Pass.Show()
        'Me.Hide()

        _18Settings.Show()
        Me.Hide()
    End Sub

    Private Sub btnA01_Click(sender As Object, e As EventArgs) Handles btnA01.Click

        Dim Object_Pass As New _3Registration

        Object_Pass.String_Pass = btnA01.Text

        Object_Pass.Show()
        Me.Hide()
    End Sub

    Private Sub btnB01_Click(sender As Object, e As EventArgs) Handles btnB01.Click
        Dim Object_Pass As New _3Registration

        Object_Pass.String_Pass = btnB01.Text

        Object_Pass.Show()
        Me.Hide()
    End Sub

    Private Sub btnC01_Click(sender As Object, e As EventArgs) Handles btnC01.Click
        Dim Object_Pass As New _3Registration

        Object_Pass.String_Pass = btnC01.Text

        Object_Pass.Show()
        Me.Hide()
    End Sub

    Private Sub btnD01_Click(sender As Object, e As EventArgs) Handles btnD01.Click
        Dim Object_Pass As New _3Registration

        Object_Pass.String_Pass = btnD01.Text

        Object_Pass.Show()
        Me.Hide()
    End Sub

    Private Sub btnA02_Click(sender As Object, e As EventArgs) Handles btnA02.Click
        Dim Object_Pass As New _3Registration

        Object_Pass.String_Pass = btnA02.Text

        Object_Pass.Show()
        Me.Hide()
    End Sub

    Private Sub btnB02_Click(sender As Object, e As EventArgs) Handles btnB02.Click
        Dim Object_Pass As New _3Registration

        Object_Pass.String_Pass = btnB02.Text

        Object_Pass.Show()
        Me.Hide()
    End Sub

    Private Sub btnC02_Click(sender As Object, e As EventArgs) Handles btnC02.Click
        Dim Object_Pass As New _3Registration

        Object_Pass.String_Pass = btnC02.Text

        Object_Pass.Show()
        Me.Hide()
    End Sub

    Private Sub btnD02_Click(sender As Object, e As EventArgs) Handles btnD02.Click
        Dim Object_Pass As New _3Registration

        Object_Pass.String_Pass = btnD02.Text

        Object_Pass.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        _5Menu.Show()
        Me.Hide()
    End Sub
End Class