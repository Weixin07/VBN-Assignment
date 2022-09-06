<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUserSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnReturnSet = New System.Windows.Forms.Button()
        Me.btnChgPassword = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReturnSet
        '
        Me.btnReturnSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnSet.Location = New System.Drawing.Point(313, 495)
        Me.btnReturnSet.Name = "btnReturnSet"
        Me.btnReturnSet.Size = New System.Drawing.Size(347, 44)
        Me.btnReturnSet.TabIndex = 72
        Me.btnReturnSet.Text = "Return to Settings"
        Me.btnReturnSet.UseVisualStyleBackColor = True
        '
        'btnChgPassword
        '
        Me.btnChgPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChgPassword.Location = New System.Drawing.Point(94, 72)
        Me.btnChgPassword.Name = "btnChgPassword"
        Me.btnChgPassword.Size = New System.Drawing.Size(368, 45)
        Me.btnChgPassword.TabIndex = 75
        Me.btnChgPassword.Text = "Change Password"
        Me.btnChgPassword.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Location = New System.Drawing.Point(94, 215)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(368, 45)
        Me.btnAddUser.TabIndex = 74
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnAttendance
        '
        Me.btnAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.Location = New System.Drawing.Point(551, 72)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(368, 45)
        Me.btnAttendance.TabIndex = 73
        Me.btnAttendance.Text = "Attendance"
        Me.btnAttendance.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.Location = New System.Drawing.Point(94, 358)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(368, 45)
        Me.btnDeleteUser.TabIndex = 76
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'AddUserSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 605)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnChgPassword)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.btnAttendance)
        Me.Controls.Add(Me.btnReturnSet)
        Me.Name = "AddUserSettings"
        Me.Text = "AddUserSettings"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReturnSet As Button
    Friend WithEvents btnChgPassword As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnAttendance As Button
    Friend WithEvents btnDeleteUser As Button
End Class
