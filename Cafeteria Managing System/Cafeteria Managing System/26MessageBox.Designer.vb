<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _26MessageBox
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
        Me.lblPasswordFail2 = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.lblPasswordFail = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPasswordFail2
        '
        Me.lblPasswordFail2.AutoSize = True
        Me.lblPasswordFail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordFail2.Location = New System.Drawing.Point(45, 84)
        Me.lblPasswordFail2.Name = "lblPasswordFail2"
        Me.lblPasswordFail2.Size = New System.Drawing.Size(188, 29)
        Me.lblPasswordFail2.TabIndex = 22
        Me.lblPasswordFail2.Text = "please try again."
        '
        'btnOkay
        '
        Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(423, 154)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(102, 34)
        Me.btnOkay.TabIndex = 21
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblPasswordFail
        '
        Me.lblPasswordFail.AutoSize = True
        Me.lblPasswordFail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordFail.Location = New System.Drawing.Point(45, 40)
        Me.lblPasswordFail.Name = "lblPasswordFail"
        Me.lblPasswordFail.Size = New System.Drawing.Size(480, 29)
        Me.lblPasswordFail.TabIndex = 20
        Me.lblPasswordFail.Text = "Sorry the password you've input is incorrect,"
        '
        '_26MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 220)
        Me.Controls.Add(Me.lblPasswordFail2)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lblPasswordFail)
        Me.Name = "_26MessageBox"
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPasswordFail2 As Label
    Friend WithEvents btnOkay As Button
    Friend WithEvents lblPasswordFail As Label
End Class
