<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _28NewUserReg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtNewUser = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblNewUser = New System.Windows.Forms.Label()
        Me.lblNewPasswordIpt = New System.Windows.Forms.Label()
        Me.CheckBoxShow = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(446, 258)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(144, 41)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtNewUser
        '
        Me.txtNewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUser.Location = New System.Drawing.Point(308, 80)
        Me.txtNewUser.Name = "txtNewUser"
        Me.txtNewUser.Size = New System.Drawing.Size(391, 38)
        Me.txtNewUser.TabIndex = 44
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(308, 158)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(391, 38)
        Me.txtNewPassword.TabIndex = 42
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(202, 258)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(144, 41)
        Me.btnConfirm.TabIndex = 41
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblNewUser
        '
        Me.lblNewUser.AutoSize = True
        Me.lblNewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewUser.Location = New System.Drawing.Point(74, 83)
        Me.lblNewUser.Name = "lblNewUser"
        Me.lblNewUser.Size = New System.Drawing.Size(223, 32)
        Me.lblNewUser.TabIndex = 40
        Me.lblNewUser.Text = "Input Username:"
        '
        'lblNewPasswordIpt
        '
        Me.lblNewPasswordIpt.AutoSize = True
        Me.lblNewPasswordIpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPasswordIpt.Location = New System.Drawing.Point(74, 161)
        Me.lblNewPasswordIpt.Name = "lblNewPasswordIpt"
        Me.lblNewPasswordIpt.Size = New System.Drawing.Size(217, 32)
        Me.lblNewPasswordIpt.TabIndex = 39
        Me.lblNewPasswordIpt.Text = "Input Password:"
        '
        'CheckBoxShow
        '
        Me.CheckBoxShow.AutoSize = True
        Me.CheckBoxShow.Location = New System.Drawing.Point(570, 202)
        Me.CheckBoxShow.Name = "CheckBoxShow"
        Me.CheckBoxShow.Size = New System.Drawing.Size(129, 21)
        Me.CheckBoxShow.TabIndex = 47
        Me.CheckBoxShow.Text = "Show Password"
        Me.CheckBoxShow.UseVisualStyleBackColor = True
        '
        '_28NewUserReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 346)
        Me.Controls.Add(Me.CheckBoxShow)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtNewUser)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblNewUser)
        Me.Controls.Add(Me.lblNewPasswordIpt)
        Me.Name = "_28NewUserReg"
        Me.Text = "New User Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents txtNewUser As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblNewUser As Label
    Friend WithEvents lblNewPasswordIpt As Label
    Friend WithEvents CheckBoxShow As CheckBox
End Class
