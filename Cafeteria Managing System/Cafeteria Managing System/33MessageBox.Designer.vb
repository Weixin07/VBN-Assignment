<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _33MessageBox
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
        Me.lblUpdateSuccess = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOkay
        '
        Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(132, 119)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(102, 34)
        Me.btnOkay.TabIndex = 20
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblUpdateSuccess
        '
        Me.lblUpdateSuccess.AutoSize = True
        Me.lblUpdateSuccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateSuccess.Location = New System.Drawing.Point(59, 49)
        Me.lblUpdateSuccess.Name = "lblUpdateSuccess"
        Me.lblUpdateSuccess.Size = New System.Drawing.Size(264, 29)
        Me.lblUpdateSuccess.TabIndex = 19
        Me.lblUpdateSuccess.Text = "Item has been updated!"
        '
        '_33MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 183)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lblUpdateSuccess)
        Me.Name = "_33MessageBox"
        Me.Text = "Item Updated"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOkay As Button
    Friend WithEvents lblUpdateSuccess As Label
End Class
