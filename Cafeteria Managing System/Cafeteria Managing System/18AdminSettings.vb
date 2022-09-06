Imports System.Data.SqlClient

Public Class _18Settings
    Public Property String_Pass6 As String
    Private Sub _18Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        _2Tables.Show()
        Me.Hide()
    End Sub

    Private Sub btnModMenu_Click(sender As Object, e As EventArgs) Handles btnModMenu.Click
        _31MenuMod.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddUserSettings.Show()
        Me.Hide()
    End Sub
End Class