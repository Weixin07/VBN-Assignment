<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _20MessageBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.lblClockInTime = New System.Windows.Forms.Label()
        Me.lblClocktime2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblAttendance_ID = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txtAttendanceID = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblDate2 = New System.Windows.Forms.Label()
        Me.txtClockInTime = New System.Windows.Forms.TextBox()
        Me.txtClockOutTime = New System.Windows.Forms.TextBox()
        Me.lblClockOutTime = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLog
        '
        Me.btnLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.Location = New System.Drawing.Point(151, 247)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(102, 34)
        Me.btnLog.TabIndex = 16
        Me.btnLog.Text = "Log"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'lblClockInTime
        '
        Me.lblClockInTime.AutoSize = True
        Me.lblClockInTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClockInTime.Location = New System.Drawing.Point(32, 106)
        Me.lblClockInTime.Name = "lblClockInTime"
        Me.lblClockInTime.Size = New System.Drawing.Size(167, 29)
        Me.lblClockInTime.TabIndex = 15
        Me.lblClockInTime.Text = "Clock In TIme:"
        '
        'lblClocktime2
        '
        Me.lblClocktime2.AutoSize = True
        Me.lblClocktime2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClocktime2.Location = New System.Drawing.Point(424, 230)
        Me.lblClocktime2.Name = "lblClocktime2"
        Me.lblClocktime2.Size = New System.Drawing.Size(116, 20)
        Me.lblClocktime2.TabIndex = 17
        Me.lblClocktime2.Text = "Current Time_"
        '
        'Timer1
        '
        '
        'lblAttendance_ID
        '
        Me.lblAttendance_ID.AutoSize = True
        Me.lblAttendance_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendance_ID.Location = New System.Drawing.Point(31, 28)
        Me.lblAttendance_ID.Name = "lblAttendance_ID"
        Me.lblAttendance_ID.Size = New System.Drawing.Size(168, 29)
        Me.lblAttendance_ID.TabIndex = 19
        Me.lblAttendance_ID.Text = "Attendance ID:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(424, 259)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(45, 20)
        Me.lblDate.TabIndex = 20
        Me.lblDate.Text = "Date"
        '
        'Timer2
        '
        '
        'txtAttendanceID
        '
        Me.txtAttendanceID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttendanceID.Location = New System.Drawing.Point(224, 32)
        Me.txtAttendanceID.Name = "txtAttendanceID"
        Me.txtAttendanceID.Size = New System.Drawing.Size(136, 27)
        Me.txtAttendanceID.TabIndex = 84
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(224, 71)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(136, 27)
        Me.txtDate.TabIndex = 86
        '
        'lblDate2
        '
        Me.lblDate2.AutoSize = True
        Me.lblDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate2.Location = New System.Drawing.Point(31, 67)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Size = New System.Drawing.Size(69, 29)
        Me.lblDate2.TabIndex = 85
        Me.lblDate2.Text = "Date:"
        '
        'txtClockInTime
        '
        Me.txtClockInTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClockInTime.Location = New System.Drawing.Point(224, 110)
        Me.txtClockInTime.Name = "txtClockInTime"
        Me.txtClockInTime.Size = New System.Drawing.Size(136, 27)
        Me.txtClockInTime.TabIndex = 87
        '
        'txtClockOutTime
        '
        Me.txtClockOutTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClockOutTime.Location = New System.Drawing.Point(224, 149)
        Me.txtClockOutTime.Name = "txtClockOutTime"
        Me.txtClockOutTime.Size = New System.Drawing.Size(136, 27)
        Me.txtClockOutTime.TabIndex = 89
        '
        'lblClockOutTime
        '
        Me.lblClockOutTime.AutoSize = True
        Me.lblClockOutTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClockOutTime.Location = New System.Drawing.Point(32, 145)
        Me.lblClockOutTime.Name = "lblClockOutTime"
        Me.lblClockOutTime.Size = New System.Drawing.Size(186, 29)
        Me.lblClockOutTime.TabIndex = 88
        Me.lblClockOutTime.Text = "Clock Out TIme:"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(224, 188)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(136, 27)
        Me.txtUsername.TabIndex = 91
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(32, 184)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(130, 29)
        Me.lblUsername.TabIndex = 90
        Me.lblUsername.Text = "Username:"
        '
        '_20MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 295)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtClockOutTime)
        Me.Controls.Add(Me.lblClockOutTime)
        Me.Controls.Add(Me.txtClockInTime)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblDate2)
        Me.Controls.Add(Me.txtAttendanceID)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblAttendance_ID)
        Me.Controls.Add(Me.lblClocktime2)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.lblClockInTime)
        Me.Name = "_20MessageBox"
        Me.Text = "Attendance Confirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLog As Button
    Friend WithEvents lblClockInTime As Label
    Friend WithEvents lblClocktime2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblAttendance_ID As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents txtAttendanceID As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents lblDate2 As Label
    Friend WithEvents txtClockInTime As TextBox
    Friend WithEvents txtClockOutTime As TextBox
    Friend WithEvents lblClockOutTime As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
End Class
