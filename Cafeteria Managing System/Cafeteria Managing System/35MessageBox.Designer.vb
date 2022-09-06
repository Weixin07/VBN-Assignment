<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _35MessageBox
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
        Me.lblItemAddSuccess2 = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.lblItemAddSuccess = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblItemAddSuccess2
        '
        Me.lblItemAddSuccess2.AutoSize = True
        Me.lblItemAddSuccess2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemAddSuccess2.Location = New System.Drawing.Point(39, 85)
        Me.lblItemAddSuccess2.Name = "lblItemAddSuccess2"
        Me.lblItemAddSuccess2.Size = New System.Drawing.Size(238, 29)
        Me.lblItemAddSuccess2.TabIndex = 25
        Me.lblItemAddSuccess2.Text = "added into the menu!"
        '
        'btnOkay
        '
        Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(244, 154)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(102, 34)
        Me.btnOkay.TabIndex = 24
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblItemAddSuccess
        '
        Me.lblItemAddSuccess.AutoSize = True
        Me.lblItemAddSuccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemAddSuccess.Location = New System.Drawing.Point(39, 41)
        Me.lblItemAddSuccess.Name = "lblItemAddSuccess"
        Me.lblItemAddSuccess.Size = New System.Drawing.Size(164, 29)
        Me.lblItemAddSuccess.TabIndex = 23
        Me.lblItemAddSuccess.Text = "Item has been"
        '
        '_35MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 230)
        Me.Controls.Add(Me.lblItemAddSuccess2)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lblItemAddSuccess)
        Me.Name = "_35MessageBox"
        Me.Text = "Item Added"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblItemAddSuccess2 As Label
    Friend WithEvents btnOkay As Button
    Friend WithEvents lblItemAddSuccess As Label
End Class
