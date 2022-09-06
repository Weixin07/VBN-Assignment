<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add2ConfirmationChangeMsg
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblChangeStatusConfirmation = New System.Windows.Forms.Label()
        Me.lblChangeStatusConfirmation2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(284, 169)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 39)
        Me.btnCancel.TabIndex = 66
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(91, 169)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(109, 39)
        Me.btnConfirm.TabIndex = 65
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblChangeStatusConfirmation
        '
        Me.lblChangeStatusConfirmation.AutoSize = True
        Me.lblChangeStatusConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeStatusConfirmation.Location = New System.Drawing.Point(45, 45)
        Me.lblChangeStatusConfirmation.Name = "lblChangeStatusConfirmation"
        Me.lblChangeStatusConfirmation.Size = New System.Drawing.Size(388, 29)
        Me.lblChangeStatusConfirmation.TabIndex = 64
        Me.lblChangeStatusConfirmation.Text = "Change status of _Item Code_ from"
        '
        'lblChangeStatusConfirmation2
        '
        Me.lblChangeStatusConfirmation2.AutoSize = True
        Me.lblChangeStatusConfirmation2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeStatusConfirmation2.Location = New System.Drawing.Point(54, 93)
        Me.lblChangeStatusConfirmation2.Name = "lblChangeStatusConfirmation2"
        Me.lblChangeStatusConfirmation2.Size = New System.Drawing.Size(371, 29)
        Me.lblChangeStatusConfirmation2.TabIndex = 67
        Me.lblChangeStatusConfirmation2.Text = "_Order ID_ to _Changed Status_?"
        '
        'Add2ConfirmationChangeMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 243)
        Me.Controls.Add(Me.lblChangeStatusConfirmation2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblChangeStatusConfirmation)
        Me.Name = "Add2ConfirmationChangeMsg"
        Me.Text = "Change Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblChangeStatusConfirmation As Label
    Friend WithEvents lblChangeStatusConfirmation2 As Label
End Class
