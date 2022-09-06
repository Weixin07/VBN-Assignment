<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _36DeleteItem
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.cboCode = New System.Windows.Forms.ComboBox()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cafeteria_Management_SystemDataSet1 = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1()
        Me.ItemsTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.ItemsTableAdapter()
        Me.Final_DataSet = New Cafeteria_Managing_System.Final_DataSet()
        Me.ItemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter1 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.ItemsTableAdapter()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(360, 167)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(144, 41)
        Me.btnCancel.TabIndex = 61
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(116, 167)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(144, 41)
        Me.btnConfirm.TabIndex = 58
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(89, 66)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(91, 32)
        Me.lblCode.TabIndex = 56
        Me.lblCode.Text = "Code:"
        '
        'cboCode
        '
        Me.cboCode.DataSource = Me.ItemsBindingSource1
        Me.cboCode.DisplayMember = "Item_Code"
        Me.cboCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCode.FormattingEnabled = True
        Me.cboCode.Location = New System.Drawing.Point(186, 66)
        Me.cboCode.Name = "cboCode"
        Me.cboCode.Size = New System.Drawing.Size(318, 39)
        Me.cboCode.TabIndex = 62
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'Cafeteria_Management_SystemDataSet1
        '
        Me.Cafeteria_Management_SystemDataSet1.DataSetName = "Cafeteria_Management_SystemDataSet1"
        Me.Cafeteria_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'Final_DataSet
        '
        Me.Final_DataSet.DataSetName = "Final_DataSet"
        Me.Final_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsBindingSource1
        '
        Me.ItemsBindingSource1.DataMember = "Items"
        Me.ItemsBindingSource1.DataSource = Me.Final_DataSet
        '
        'ItemsTableAdapter1
        '
        Me.ItemsTableAdapter1.ClearBeforeFill = True
        '
        '_36DeleteItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 263)
        Me.Controls.Add(Me.cboCode)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblCode)
        Me.Name = "_36DeleteItem"
        Me.Text = "Delete Item"
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblCode As Label
    Friend WithEvents cboCode As ComboBox
    Friend WithEvents Cafeteria_Management_SystemDataSet1 As Cafeteria_Management_SystemDataSet1
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As Cafeteria_Management_SystemDataSet1TableAdapters.ItemsTableAdapter
    Friend WithEvents Final_DataSet As Final_DataSet
    Friend WithEvents ItemsBindingSource1 As BindingSource
    Friend WithEvents ItemsTableAdapter1 As Final_DataSetTableAdapters.ItemsTableAdapter
End Class
