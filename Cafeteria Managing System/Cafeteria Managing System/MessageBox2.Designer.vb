<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _2MessageBox
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
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.lblIncorrect2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIncorrect
        '
        Me.lblIncorrect.AutoSize = True
        Me.lblIncorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect.Location = New System.Drawing.Point(39, 39)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(425, 32)
        Me.lblIncorrect.TabIndex = 3
        Me.lblIncorrect.Text = "Incorrect username or password,"
        '
        'btnOkay
        '
        Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(338, 167)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(162, 49)
        Me.btnOkay.TabIndex = 7
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblIncorrect2
        '
        Me.lblIncorrect2.AutoSize = True
        Me.lblIncorrect2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect2.Location = New System.Drawing.Point(39, 100)
        Me.lblIncorrect2.Name = "lblIncorrect2"
        Me.lblIncorrect2.Size = New System.Drawing.Size(224, 32)
        Me.lblIncorrect2.TabIndex = 8
        Me.lblIncorrect2.Text = "please try again."
        '
        '_2MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 260)
        Me.Controls.Add(Me.lblIncorrect2)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lblIncorrect)
        Me.Name = "_2MessageBox"
        Me.Text = "Managing System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIncorrect As Label
    Friend WithEvents btnOkay As Button
    Friend WithEvents lblIncorrect2 As Label
End Class
