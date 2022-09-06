<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add1CurrentStatus
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
        Me.cboNewStatus = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblNewStatus = New System.Windows.Forms.Label()
        Me.lblCurrentStatus = New System.Windows.Forms.Label()
        Me.lblCurrentStatus1 = New System.Windows.Forms.Label()
        Me.Cafeteria_Management_SystemDataSet = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet()
        Me.CafeteriaManagementSystemDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSetTableAdapters.ItemsTableAdapter()
        CType(Me.Cafeteria_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CafeteriaManagementSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboNewStatus
        '
        Me.cboNewStatus.DataSource = Me.ItemsBindingSource
        Me.cboNewStatus.DisplayMember = "Category"
        Me.cboNewStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNewStatus.FormattingEnabled = True
        Me.cboNewStatus.Location = New System.Drawing.Point(260, 108)
        Me.cboNewStatus.Name = "cboNewStatus"
        Me.cboNewStatus.Size = New System.Drawing.Size(221, 39)
        Me.cboNewStatus.TabIndex = 69
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(320, 212)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(144, 41)
        Me.btnCancel.TabIndex = 67
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(76, 212)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(144, 41)
        Me.btnConfirm.TabIndex = 66
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblNewStatus
        '
        Me.lblNewStatus.AutoSize = True
        Me.lblNewStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewStatus.Location = New System.Drawing.Point(49, 111)
        Me.lblNewStatus.Name = "lblNewStatus"
        Me.lblNewStatus.Size = New System.Drawing.Size(163, 32)
        Me.lblNewStatus.TabIndex = 65
        Me.lblNewStatus.Text = "Change To:"
        '
        'lblCurrentStatus
        '
        Me.lblCurrentStatus.AutoSize = True
        Me.lblCurrentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentStatus.Location = New System.Drawing.Point(49, 47)
        Me.lblCurrentStatus.Name = "lblCurrentStatus"
        Me.lblCurrentStatus.Size = New System.Drawing.Size(205, 32)
        Me.lblCurrentStatus.TabIndex = 64
        Me.lblCurrentStatus.Text = "Current Status:"
        '
        'lblCurrentStatus1
        '
        Me.lblCurrentStatus1.AutoSize = True
        Me.lblCurrentStatus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentStatus1.Location = New System.Drawing.Point(254, 47)
        Me.lblCurrentStatus1.Name = "lblCurrentStatus1"
        Me.lblCurrentStatus1.Size = New System.Drawing.Size(227, 32)
        Me.lblCurrentStatus1.TabIndex = 70
        Me.lblCurrentStatus1.Text = "_Current Status_"
        '
        'Cafeteria_Management_SystemDataSet
        '
        Me.Cafeteria_Management_SystemDataSet.DataSetName = "Cafeteria_Management_SystemDataSet"
        Me.Cafeteria_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CafeteriaManagementSystemDataSetBindingSource
        '
        Me.CafeteriaManagementSystemDataSetBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet
        Me.CafeteriaManagementSystemDataSetBindingSource.Position = 0
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.CafeteriaManagementSystemDataSetBindingSource
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'Add1CurrentStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 285)
        Me.Controls.Add(Me.lblCurrentStatus1)
        Me.Controls.Add(Me.cboNewStatus)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblNewStatus)
        Me.Controls.Add(Me.lblCurrentStatus)
        Me.Name = "Add1CurrentStatus"
        Me.Text = "Change Status"
        CType(Me.Cafeteria_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CafeteriaManagementSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboNewStatus As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblNewStatus As Label
    Friend WithEvents lblCurrentStatus As Label
    Friend WithEvents lblCurrentStatus1 As Label
    Friend WithEvents CafeteriaManagementSystemDataSetBindingSource As BindingSource
    Friend WithEvents Cafeteria_Management_SystemDataSet As Cafeteria_Management_SystemDataSet
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As Cafeteria_Management_SystemDataSetTableAdapters.ItemsTableAdapter
End Class
