<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _40MessageBox
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
        Me.lblCatAddSuccess2 = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.lblCatAddSuccess = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCatAddSuccess2
        '
        Me.lblCatAddSuccess2.AutoSize = True
        Me.lblCatAddSuccess2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatAddSuccess2.Location = New System.Drawing.Point(49, 86)
        Me.lblCatAddSuccess2.Name = "lblCatAddSuccess2"
        Me.lblCatAddSuccess2.Size = New System.Drawing.Size(343, 29)
        Me.lblCatAddSuccess2.TabIndex = 31
        Me.lblCatAddSuccess2.Text = "has been added into the menu!"
        '
        'btnOkay
        '
        Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(259, 152)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(102, 34)
        Me.btnOkay.TabIndex = 30
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblCatAddSuccess
        '
        Me.lblCatAddSuccess.AutoSize = True
        Me.lblCatAddSuccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatAddSuccess.Location = New System.Drawing.Point(49, 42)
        Me.lblCatAddSuccess.Name = "lblCatAddSuccess"
        Me.lblCatAddSuccess.Size = New System.Drawing.Size(167, 29)
        Me.lblCatAddSuccess.TabIndex = 29
        Me.lblCatAddSuccess.Text = "New category "
        '
        '_40MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 224)
        Me.Controls.Add(Me.lblCatAddSuccess2)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lblCatAddSuccess)
        Me.Name = "_40MessageBox"
        Me.Text = "Category Added"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCatAddSuccess2 As Label
    Friend WithEvents btnOkay As Button
    Friend WithEvents lblCatAddSuccess As Label
End Class
