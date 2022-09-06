<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _29MessageBox
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
        Me.lblUserFail2 = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.lblUserFail = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUserFail2
        '
        Me.lblUserFail2.AutoSize = True
        Me.lblUserFail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserFail2.Location = New System.Drawing.Point(43, 83)
        Me.lblUserFail2.Name = "lblUserFail2"
        Me.lblUserFail2.Size = New System.Drawing.Size(188, 29)
        Me.lblUserFail2.TabIndex = 25
        Me.lblUserFail2.Text = "please try again."
        '
        'btnOkay
        '
        Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(239, 146)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(102, 34)
        Me.btnOkay.TabIndex = 24
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblUserFail
        '
        Me.lblUserFail.AutoSize = True
        Me.lblUserFail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserFail.Location = New System.Drawing.Point(43, 39)
        Me.lblUserFail.Name = "lblUserFail"
        Me.lblUserFail.Size = New System.Drawing.Size(298, 29)
        Me.lblUserFail.TabIndex = 23
        Me.lblUserFail.Text = "Username exists in record,"
        '
        '_29MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 217)
        Me.Controls.Add(Me.lblUserFail2)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lblUserFail)
        Me.Name = "_29MessageBox"
        Me.Text = "New User Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserFail2 As Label
    Friend WithEvents btnOkay As Button
    Friend WithEvents lblUserFail As Label
End Class
