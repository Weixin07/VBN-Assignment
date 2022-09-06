<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _21ModUser
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
        Me.lblUserInformation = New System.Windows.Forms.Label()
        Me.btnChgPassword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReturnSet
        '
        Me.btnReturnSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnSet.Location = New System.Drawing.Point(328, 311)
        Me.btnReturnSet.Name = "btnReturnSet"
        Me.btnReturnSet.Size = New System.Drawing.Size(268, 36)
        Me.btnReturnSet.TabIndex = 35
        Me.btnReturnSet.Text = "Return to Settings"
        Me.btnReturnSet.UseVisualStyleBackColor = True
        '
        'lblUserInformation
        '
        Me.lblUserInformation.AutoSize = True
        Me.lblUserInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInformation.Location = New System.Drawing.Point(28, 28)
        Me.lblUserInformation.Name = "lblUserInformation"
        Me.lblUserInformation.Size = New System.Drawing.Size(231, 32)
        Me.lblUserInformation.TabIndex = 66
        Me.lblUserInformation.Text = "User Information:"
        '
        'btnChgPassword
        '
        Me.btnChgPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChgPassword.Location = New System.Drawing.Point(283, 160)
        Me.btnChgPassword.Name = "btnChgPassword"
        Me.btnChgPassword.Size = New System.Drawing.Size(368, 45)
        Me.btnChgPassword.TabIndex = 67
        Me.btnChgPassword.Text = "Change Password"
        Me.btnChgPassword.UseVisualStyleBackColor = True
        '
        '_21ModUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 450)
        Me.Controls.Add(Me.btnChgPassword)
        Me.Controls.Add(Me.lblUserInformation)
        Me.Controls.Add(Me.btnReturnSet)
        Me.Name = "_21ModUser"
        Me.Text = "Managing System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReturnSet As Button
    Friend WithEvents lblUserInformation As Label
    Friend WithEvents btnChgPassword As Button
End Class
