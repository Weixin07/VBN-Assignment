Imports System.Data.SqlClient

Public Class _21ModUser
    Public Property String_Pass2 As String
    Public Property String_Pass6 As String
    Public Property String_Pass7 As String
    Private Sub _21ModUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub btnReturnSet_Click(sender As Object, e As EventArgs) Handles btnReturnSet.Click
        _18Settings.Show()
        Me.Hide()
    End Sub

    Private Sub btnChgUsername_Click(sender As Object, e As EventArgs) 
        _22ChgUsername.Show()
        Me.Hide()
    End Sub

    Private Sub btnChgPassword_Click(sender As Object, e As EventArgs) Handles btnChgPassword.Click
        _25ChgPassword.Show()
        Me.Hide()
    End Sub
End Class