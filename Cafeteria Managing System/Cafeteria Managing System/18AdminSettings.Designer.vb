<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _18Settings
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
        Me.btnModMenu = New System.Windows.Forms.Button()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnModMenu
        '
        Me.btnModMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModMenu.Location = New System.Drawing.Point(621, 189)
        Me.btnModMenu.Name = "btnModMenu"
        Me.btnModMenu.Size = New System.Drawing.Size(368, 45)
        Me.btnModMenu.TabIndex = 30
        Me.btnModMenu.Text = "Menu Settings"
        Me.btnModMenu.UseVisualStyleBackColor = True
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.Location = New System.Drawing.Point(41, 54)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(135, 38)
        Me.lblSettings.TabIndex = 26
        Me.lblSettings.Text = "Settings"
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(405, 399)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(347, 42)
        Me.btnReturn.TabIndex = 61
        Me.btnReturn.Text = "Return to Tables"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(137, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(368, 45)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "User Settings"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '_18Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 516)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnModMenu)
        Me.Controls.Add(Me.lblSettings)
        Me.Name = "_18Settings"
        Me.Text = "Managing System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModMenu As Button
    Friend WithEvents lblSettings As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents Button1 As Button
End Class
