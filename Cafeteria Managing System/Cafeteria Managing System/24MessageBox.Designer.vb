<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _24MessageBox
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
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.lblUsernameFail = New System.Windows.Forms.Label()
        Me.lblUsernameFail2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOkay
        '
        Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(328, 144)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(102, 34)
        Me.btnOkay.TabIndex = 18
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblUsernameFail
        '
        Me.lblUsernameFail.AutoSize = True
        Me.lblUsernameFail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameFail.Location = New System.Drawing.Point(34, 31)
        Me.lblUsernameFail.Name = "lblUsernameFail"
        Me.lblUsernameFail.Size = New System.Drawing.Size(298, 29)
        Me.lblUsernameFail.TabIndex = 17
        Me.lblUsernameFail.Text = "Username exists in record,"
        '
        'lblUsernameFail2
        '
        Me.lblUsernameFail2.AutoSize = True
        Me.lblUsernameFail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameFail2.Location = New System.Drawing.Point(34, 75)
        Me.lblUsernameFail2.Name = "lblUsernameFail2"
        Me.lblUsernameFail2.Size = New System.Drawing.Size(188, 29)
        Me.lblUsernameFail2.TabIndex = 19
        Me.lblUsernameFail2.Text = "please try again."
        '
        '_24MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 207)
        Me.Controls.Add(Me.lblUsernameFail2)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lblUsernameFail)
        Me.Name = "_24MessageBox"
        Me.Text = "Change Failed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOkay As Button
    Friend WithEvents lblUsernameFail As Label
    Friend WithEvents lblUsernameFail2 As Label
End Class
