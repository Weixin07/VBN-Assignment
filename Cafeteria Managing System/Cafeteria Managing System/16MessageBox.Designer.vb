<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _16MessageBox
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
        Me.lblQuantityMsg2 = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.lblReceiptMsg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblQuantityMsg2
        '
        Me.lblQuantityMsg2.AutoSize = True
        Me.lblQuantityMsg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityMsg2.Location = New System.Drawing.Point(36, 81)
        Me.lblQuantityMsg2.Name = "lblQuantityMsg2"
        Me.lblQuantityMsg2.Size = New System.Drawing.Size(143, 29)
        Me.lblQuantityMsg2.TabIndex = 14
        Me.lblQuantityMsg2.Text = "Please wait."
        '
        'btnOkay
        '
        Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(245, 150)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(102, 34)
        Me.btnOkay.TabIndex = 13
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblReceiptMsg
        '
        Me.lblReceiptMsg.AutoSize = True
        Me.lblReceiptMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptMsg.Location = New System.Drawing.Point(36, 35)
        Me.lblReceiptMsg.Name = "lblReceiptMsg"
        Me.lblReceiptMsg.Size = New System.Drawing.Size(211, 29)
        Me.lblReceiptMsg.TabIndex = 12
        Me.lblReceiptMsg.Text = "Printing receipt......"
        '
        '_16MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 207)
        Me.Controls.Add(Me.lblQuantityMsg2)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lblReceiptMsg)
        Me.Name = "_16MessageBox"
        Me.Text = "Receipt Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuantityMsg2 As Label
    Friend WithEvents btnOkay As Button
    Friend WithEvents lblReceiptMsg As Label
End Class
