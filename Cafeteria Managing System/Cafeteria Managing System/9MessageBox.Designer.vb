<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _9MessageBox
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
        Me.lblQuantityMsg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblQuantityMsg2
        '
        Me.lblQuantityMsg2.AutoSize = True
        Me.lblQuantityMsg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityMsg2.Location = New System.Drawing.Point(27, 71)
        Me.lblQuantityMsg2.Name = "lblQuantityMsg2"
        Me.lblQuantityMsg2.Size = New System.Drawing.Size(321, 29)
        Me.lblQuantityMsg2.TabIndex = 11
        Me.lblQuantityMsg2.Text = "into _Table Code_ order tab!"
        '
        'btnOkay
        '
        Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(338, 141)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(162, 39)
        Me.btnOkay.TabIndex = 10
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblQuantityMsg
        '
        Me.lblQuantityMsg.AutoSize = True
        Me.lblQuantityMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityMsg.Location = New System.Drawing.Point(27, 25)
        Me.lblQuantityMsg.Name = "lblQuantityMsg"
        Me.lblQuantityMsg.Size = New System.Drawing.Size(473, 29)
        Me.lblQuantityMsg.TabIndex = 9
        Me.lblQuantityMsg.Text = "You have added _Quantity_ X _Item Code_"
        '
        '_9MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 192)
        Me.Controls.Add(Me.lblQuantityMsg2)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lblQuantityMsg)
        Me.Name = "_9MessageBox"
        Me.Text = "Confirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuantityMsg2 As Label
    Friend WithEvents btnOkay As Button
    Friend WithEvents lblQuantityMsg As Label
End Class
