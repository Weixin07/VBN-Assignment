<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add3MessageBox
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
        Me.lblChangeStatusMsg2 = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.lblChangeStatusMsg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblChangeStatusMsg2
        '
        Me.lblChangeStatusMsg2.AutoSize = True
        Me.lblChangeStatusMsg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeStatusMsg2.Location = New System.Drawing.Point(21, 78)
        Me.lblChangeStatusMsg2.Name = "lblChangeStatusMsg2"
        Me.lblChangeStatusMsg2.Size = New System.Drawing.Size(341, 29)
        Me.lblChangeStatusMsg2.TabIndex = 71
        Me.lblChangeStatusMsg2.Text = "_Order ID_ has been changed."
        '
        'btnOkay
        '
        Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(363, 132)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(109, 39)
        Me.btnOkay.TabIndex = 69
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblChangeStatusMsg
        '
        Me.lblChangeStatusMsg.AutoSize = True
        Me.lblChangeStatusMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeStatusMsg.Location = New System.Drawing.Point(21, 30)
        Me.lblChangeStatusMsg.Name = "lblChangeStatusMsg"
        Me.lblChangeStatusMsg.Size = New System.Drawing.Size(289, 29)
        Me.lblChangeStatusMsg.TabIndex = 68
        Me.lblChangeStatusMsg.Text = "Status of _Item Code from"
        '
        'Add3MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 186)
        Me.Controls.Add(Me.lblChangeStatusMsg2)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lblChangeStatusMsg)
        Me.Name = "Add3MessageBox"
        Me.Text = "Change Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChangeStatusMsg2 As Label
    Friend WithEvents btnOkay As Button
    Friend WithEvents lblChangeStatusMsg As Label
End Class
