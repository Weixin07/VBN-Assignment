<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _25ChgPassword
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
        Me.txtNewPasswordReIpt = New System.Windows.Forms.TextBox()
        Me.txtNewPasswordIpt = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblCurrentPasswordIpt = New System.Windows.Forms.Label()
        Me.lblNewPasswordIpt = New System.Windows.Forms.Label()
        Me.lblNewPasswordReIpt = New System.Windows.Forms.Label()
        Me.txtCurrentPasswordIpt = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.cboUsername = New System.Windows.Forms.ComboBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cafeteria_Management_SystemDataSet1 = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1()
        Me.StaffTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.StaffTableAdapter()
        Me.Final_DataSet = New Cafeteria_Managing_System.Final_DataSet()
        Me.StaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter1 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.StaffTableAdapter()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNewPasswordReIpt
        '
        Me.txtNewPasswordReIpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPasswordReIpt.Location = New System.Drawing.Point(403, 244)
        Me.txtNewPasswordReIpt.Name = "txtNewPasswordReIpt"
        Me.txtNewPasswordReIpt.Size = New System.Drawing.Size(320, 38)
        Me.txtNewPasswordReIpt.TabIndex = 35
        '
        'txtNewPasswordIpt
        '
        Me.txtNewPasswordIpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPasswordIpt.Location = New System.Drawing.Point(403, 173)
        Me.txtNewPasswordIpt.Name = "txtNewPasswordIpt"
        Me.txtNewPasswordIpt.Size = New System.Drawing.Size(320, 38)
        Me.txtNewPasswordIpt.TabIndex = 34
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(199, 339)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(144, 41)
        Me.btnConfirm.TabIndex = 33
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblCurrentPasswordIpt
        '
        Me.lblCurrentPasswordIpt.AutoSize = True
        Me.lblCurrentPasswordIpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPasswordIpt.Location = New System.Drawing.Point(70, 105)
        Me.lblCurrentPasswordIpt.Name = "lblCurrentPasswordIpt"
        Me.lblCurrentPasswordIpt.Size = New System.Drawing.Size(309, 32)
        Me.lblCurrentPasswordIpt.TabIndex = 32
        Me.lblCurrentPasswordIpt.Text = "Input current password:"
        '
        'lblNewPasswordIpt
        '
        Me.lblNewPasswordIpt.AutoSize = True
        Me.lblNewPasswordIpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPasswordIpt.Location = New System.Drawing.Point(70, 176)
        Me.lblNewPasswordIpt.Name = "lblNewPasswordIpt"
        Me.lblNewPasswordIpt.Size = New System.Drawing.Size(273, 32)
        Me.lblNewPasswordIpt.TabIndex = 31
        Me.lblNewPasswordIpt.Text = "Input new password:"
        '
        'lblNewPasswordReIpt
        '
        Me.lblNewPasswordReIpt.AutoSize = True
        Me.lblNewPasswordReIpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPasswordReIpt.Location = New System.Drawing.Point(70, 247)
        Me.lblNewPasswordReIpt.Name = "lblNewPasswordReIpt"
        Me.lblNewPasswordReIpt.Size = New System.Drawing.Size(300, 32)
        Me.lblNewPasswordReIpt.TabIndex = 30
        Me.lblNewPasswordReIpt.Text = "Retype new password:"
        '
        'txtCurrentPasswordIpt
        '
        Me.txtCurrentPasswordIpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPasswordIpt.Location = New System.Drawing.Point(403, 102)
        Me.txtCurrentPasswordIpt.Name = "txtCurrentPasswordIpt"
        Me.txtCurrentPasswordIpt.Size = New System.Drawing.Size(320, 38)
        Me.txtCurrentPasswordIpt.TabIndex = 36
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(443, 339)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(144, 41)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(70, 34)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(223, 32)
        Me.lblUsername.TabIndex = 38
        Me.lblUsername.Text = "Input Username:"
        '
        'cboUsername
        '
        Me.cboUsername.DataSource = Me.StaffBindingSource1
        Me.cboUsername.DisplayMember = "Username"
        Me.cboUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsername.FormattingEnabled = True
        Me.cboUsername.Location = New System.Drawing.Point(403, 31)
        Me.cboUsername.Name = "cboUsername"
        Me.cboUsername.Size = New System.Drawing.Size(320, 39)
        Me.cboUsername.TabIndex = 39
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'Cafeteria_Management_SystemDataSet1
        '
        Me.Cafeteria_Management_SystemDataSet1.DataSetName = "Cafeteria_Management_SystemDataSet1"
        Me.Cafeteria_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'Final_DataSet
        '
        Me.Final_DataSet.DataSetName = "Final_DataSet"
        Me.Final_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource1
        '
        Me.StaffBindingSource1.DataMember = "Staff"
        Me.StaffBindingSource1.DataSource = Me.Final_DataSet
        '
        'StaffTableAdapter1
        '
        Me.StaffTableAdapter1.ClearBeforeFill = True
        '
        '_25ChgPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cboUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtCurrentPasswordIpt)
        Me.Controls.Add(Me.txtNewPasswordReIpt)
        Me.Controls.Add(Me.txtNewPasswordIpt)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblCurrentPasswordIpt)
        Me.Controls.Add(Me.lblNewPasswordIpt)
        Me.Controls.Add(Me.lblNewPasswordReIpt)
        Me.Name = "_25ChgPassword"
        Me.Text = "Change Password"
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewPasswordReIpt As TextBox
    Friend WithEvents txtNewPasswordIpt As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblCurrentPasswordIpt As Label
    Friend WithEvents lblNewPasswordIpt As Label
    Friend WithEvents lblNewPasswordReIpt As Label
    Friend WithEvents txtCurrentPasswordIpt As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents cboUsername As ComboBox
    Friend WithEvents Cafeteria_Management_SystemDataSet1 As Cafeteria_Management_SystemDataSet1
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As Cafeteria_Management_SystemDataSet1TableAdapters.StaffTableAdapter
    Friend WithEvents Final_DataSet As Final_DataSet
    Friend WithEvents StaffBindingSource1 As BindingSource
    Friend WithEvents StaffTableAdapter1 As Final_DataSetTableAdapters.StaffTableAdapter
End Class
