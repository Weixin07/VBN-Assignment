<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _19UserSettings
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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.btnModUser = New System.Windows.Forms.Button()
        Me.btnClock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(441, 383)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(347, 43)
        Me.btnReturn.TabIndex = 67
        Me.btnReturn.Text = "Return to Tables"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.Location = New System.Drawing.Point(58, 53)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(119, 32)
        Me.lblSettings.TabIndex = 65
        Me.lblSettings.Text = "Settings"
        '
        'btnModUser
        '
        Me.btnModUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModUser.Location = New System.Drawing.Point(675, 223)
        Me.btnModUser.Name = "btnModUser"
        Me.btnModUser.Size = New System.Drawing.Size(347, 42)
        Me.btnModUser.TabIndex = 63
        Me.btnModUser.Text = "Modify User Information"
        Me.btnModUser.UseVisualStyleBackColor = True
        '
        'btnClock
        '
        Me.btnClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClock.Location = New System.Drawing.Point(162, 223)
        Me.btnClock.Name = "btnClock"
        Me.btnClock.Size = New System.Drawing.Size(347, 43)
        Me.btnClock.TabIndex = 62
        Me.btnClock.Text = "Clock In"
        Me.btnClock.UseVisualStyleBackColor = True
        '
        '_19UserSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 589)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.btnModUser)
        Me.Controls.Add(Me.btnClock)
        Me.Name = "_19UserSettings"
        Me.Text = "Managing System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReturn As Button
    Friend WithEvents lblSettings As Label
    Friend WithEvents btnModUser As Button
    Friend WithEvents btnClock As Button
End Class
