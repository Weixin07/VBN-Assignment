<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _22ChgUsername
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
        Me.components = New System.ComponentModel.Container()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtNewUsername = New System.Windows.Forms.TextBox()
        Me.lblNewUsernameIpt = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblCurrentUsername = New System.Windows.Forms.Label()
        Me.cboCurrentUsername = New System.Windows.Forms.ComboBox()
        Me.Cafeteria_Management_SystemDataSet1 = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.StaffTableAdapter()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(177, 433)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(162, 38)
        Me.btnConfirm.TabIndex = 11
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'txtNewUsername
        '
        Me.txtNewUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUsername.Location = New System.Drawing.Point(177, 316)
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.Size = New System.Drawing.Size(485, 38)
        Me.txtNewUsername.TabIndex = 9
        '
        'lblNewUsernameIpt
        '
        Me.lblNewUsernameIpt.AutoSize = True
        Me.lblNewUsernameIpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewUsernameIpt.Location = New System.Drawing.Point(53, 229)
        Me.lblNewUsernameIpt.Name = "lblNewUsernameIpt"
        Me.lblNewUsernameIpt.Size = New System.Drawing.Size(286, 32)
        Me.lblNewUsernameIpt.TabIndex = 7
        Me.lblNewUsernameIpt.Text = "Input New Username:"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(500, 433)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(162, 38)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblCurrentUsername
        '
        Me.lblCurrentUsername.AutoSize = True
        Me.lblCurrentUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentUsername.Location = New System.Drawing.Point(53, 49)
        Me.lblCurrentUsername.Name = "lblCurrentUsername"
        Me.lblCurrentUsername.Size = New System.Drawing.Size(324, 32)
        Me.lblCurrentUsername.TabIndex = 13
        Me.lblCurrentUsername.Text = "Input Current Username:"
        '
        'cboCurrentUsername
        '
        Me.cboCurrentUsername.DataSource = Me.StaffBindingSource
        Me.cboCurrentUsername.DisplayMember = "Username"
        Me.cboCurrentUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCurrentUsername.FormattingEnabled = True
        Me.cboCurrentUsername.Location = New System.Drawing.Point(177, 136)
        Me.cboCurrentUsername.Name = "cboCurrentUsername"
        Me.cboCurrentUsername.Size = New System.Drawing.Size(485, 39)
        Me.cboCurrentUsername.TabIndex = 15
        '
        'Cafeteria_Management_SystemDataSet1
        '
        Me.Cafeteria_Management_SystemDataSet1.DataSetName = "Cafeteria_Management_SystemDataSet1"
        Me.Cafeteria_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        '_22ChgUsername
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 512)
        Me.Controls.Add(Me.cboCurrentUsername)
        Me.Controls.Add(Me.lblCurrentUsername)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtNewUsername)
        Me.Controls.Add(Me.lblNewUsernameIpt)
        Me.Name = "_22ChgUsername"
        Me.Text = "Change Username"
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtNewUsername As TextBox
    Friend WithEvents lblNewUsernameIpt As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblCurrentUsername As Label
    Friend WithEvents cboCurrentUsername As ComboBox
    Friend WithEvents Cafeteria_Management_SystemDataSet1 As Cafeteria_Management_SystemDataSet1
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As Cafeteria_Management_SystemDataSet1TableAdapters.StaffTableAdapter
End Class
