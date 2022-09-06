<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCatMes
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
        Me.lblItemDelSuccess2 = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.lblItemDelSuccess = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblItemDelSuccess2
        '
        Me.lblItemDelSuccess2.AutoSize = True
        Me.lblItemDelSuccess2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDelSuccess2.Location = New System.Drawing.Point(33, 78)
        Me.lblItemDelSuccess2.Name = "lblItemDelSuccess2"
        Me.lblItemDelSuccess2.Size = New System.Drawing.Size(273, 29)
        Me.lblItemDelSuccess2.TabIndex = 31
        Me.lblItemDelSuccess2.Text = "removed from the menu!"
        '
        'btnOkay
        '
        Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(317, 133)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(102, 34)
        Me.btnOkay.TabIndex = 30
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblItemDelSuccess
        '
        Me.lblItemDelSuccess.AutoSize = True
        Me.lblItemDelSuccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemDelSuccess.Location = New System.Drawing.Point(33, 34)
        Me.lblItemDelSuccess.Name = "lblItemDelSuccess"
        Me.lblItemDelSuccess.Size = New System.Drawing.Size(215, 29)
        Me.lblItemDelSuccess.TabIndex = 29
        Me.lblItemDelSuccess.Text = "Category has been"
        '
        'AddCatMes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 186)
        Me.Controls.Add(Me.lblItemDelSuccess2)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lblItemDelSuccess)
        Me.Name = "AddCatMes"
        Me.Text = "AddCatMes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblItemDelSuccess2 As Label
    Friend WithEvents btnOkay As Button
    Friend WithEvents lblItemDelSuccess As Label
End Class
