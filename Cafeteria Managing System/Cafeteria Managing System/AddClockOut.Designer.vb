<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClockOut
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
        Me.components = New System.ComponentModel.Container()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblAttendance_ID = New System.Windows.Forms.Label()
        Me.lblClocktime2 = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.lblClockTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(389, 127)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(19, 29)
        Me.lblUsername.TabIndex = 27
        Me.lblUsername.Text = "."
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(389, 147)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(19, 29)
        Me.lblDate.TabIndex = 26
        Me.lblDate.Text = "."
        '
        'lblAttendance_ID
        '
        Me.lblAttendance_ID.AutoSize = True
        Me.lblAttendance_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendance_ID.Location = New System.Drawing.Point(9, 147)
        Me.lblAttendance_ID.Name = "lblAttendance_ID"
        Me.lblAttendance_ID.Size = New System.Drawing.Size(19, 29)
        Me.lblAttendance_ID.TabIndex = 25
        Me.lblAttendance_ID.Text = "."
        '
        'lblClocktime2
        '
        Me.lblClocktime2.AutoSize = True
        Me.lblClocktime2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClocktime2.Location = New System.Drawing.Point(260, 27)
        Me.lblClocktime2.Name = "lblClocktime2"
        Me.lblClocktime2.Size = New System.Drawing.Size(167, 29)
        Me.lblClocktime2.TabIndex = 24
        Me.lblClocktime2.Text = "Current Time_"
        '
        'btnOkay
        '
        Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(189, 109)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(102, 34)
        Me.btnOkay.TabIndex = 23
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblClockTime
        '
        Me.lblClockTime.AutoSize = True
        Me.lblClockTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClockTime.Location = New System.Drawing.Point(68, 27)
        Me.lblClockTime.Name = "lblClockTime"
        Me.lblClockTime.Size = New System.Drawing.Size(186, 29)
        Me.lblClockTime.TabIndex = 22
        Me.lblClockTime.Text = "Clock Out TIme:"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'AddClockOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 217)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblAttendance_ID)
        Me.Controls.Add(Me.lblClocktime2)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lblClockTime)
        Me.Name = "AddClockOut"
        Me.Text = "Attendance Confirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblAttendance_ID As Label
    Friend WithEvents lblClocktime2 As Label
    Friend WithEvents btnOkay As Button
    Friend WithEvents lblClockTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
