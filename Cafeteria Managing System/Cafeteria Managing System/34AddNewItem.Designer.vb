<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _34AddNewItem
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
        Me.components = New System.ComponentModel.Container()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblNewCode = New System.Windows.Forms.Label()
        Me.lblSelfCode = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Final_DataSet = New Cafeteria_Managing_System.Final_DataSet()
        Me.ItemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CafeteriaManagementSystemDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cafeteria_Management_SystemDataSet = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSetTableAdapters.ItemsTableAdapter()
        Me.FKOrderDetItem34C8D9D1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_DetailsTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSetTableAdapters.Order_DetailsTableAdapter()
        Me.ItemsTableAdapter1 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.ItemsTableAdapter()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryTableAdapter = New Cafeteria_Managing_System.Final_DataSetTableAdapters.CategoryTableAdapter()
        Me.CategoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CafeteriaManagementSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cafeteria_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKOrderDetItem34C8D9D1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(454, 385)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(144, 41)
        Me.btnCancel.TabIndex = 61
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(267, 278)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(436, 38)
        Me.txtPrice.TabIndex = 60
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(267, 212)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(436, 38)
        Me.txtName.TabIndex = 59
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(210, 385)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(144, 41)
        Me.btnConfirm.TabIndex = 58
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(97, 281)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(88, 32)
        Me.lblPrice.TabIndex = 57
        Me.lblPrice.Text = "Price:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(97, 215)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(98, 32)
        Me.lblName.TabIndex = 56
        Me.lblName.Text = "Name:"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(97, 83)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(138, 32)
        Me.lblCategory.TabIndex = 55
        Me.lblCategory.Text = "Category:"
        '
        'lblNewCode
        '
        Me.lblNewCode.AutoSize = True
        Me.lblNewCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewCode.Location = New System.Drawing.Point(97, 149)
        Me.lblNewCode.Name = "lblNewCode"
        Me.lblNewCode.Size = New System.Drawing.Size(91, 32)
        Me.lblNewCode.TabIndex = 63
        Me.lblNewCode.Text = "Code:"
        '
        'lblSelfCode
        '
        Me.lblSelfCode.AutoSize = True
        Me.lblSelfCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelfCode.Location = New System.Drawing.Point(261, 149)
        Me.lblSelfCode.Name = "lblSelfCode"
        Me.lblSelfCode.Size = New System.Drawing.Size(312, 32)
        Me.lblSelfCode.TabIndex = 64
        Me.lblSelfCode.Text = "_Self Generated Code_"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCodeDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemsBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(745, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(553, 346)
        Me.DataGridView1.TabIndex = 66
        '
        'ItemCodeDataGridViewTextBoxColumn
        '
        Me.ItemCodeDataGridViewTextBoxColumn.DataPropertyName = "Item_Code"
        Me.ItemCodeDataGridViewTextBoxColumn.HeaderText = "Item_Code"
        Me.ItemCodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemCodeDataGridViewTextBoxColumn.Name = "ItemCodeDataGridViewTextBoxColumn"
        Me.ItemCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemCodeDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Width = 125
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryDataGridViewTextBoxColumn.Width = 125
        '
        'ItemsBindingSource2
        '
        Me.ItemsBindingSource2.DataMember = "Items"
        Me.ItemsBindingSource2.DataSource = Me.Final_DataSet
        '
        'Final_DataSet
        '
        Me.Final_DataSet.DataSetName = "Final_DataSet"
        Me.Final_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsBindingSource1
        '
        Me.ItemsBindingSource1.DataMember = "Items"
        Me.ItemsBindingSource1.DataSource = Me.CafeteriaManagementSystemDataSetBindingSource
        '
        'CafeteriaManagementSystemDataSetBindingSource
        '
        Me.CafeteriaManagementSystemDataSetBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet
        Me.CafeteriaManagementSystemDataSetBindingSource.Position = 0
        '
        'Cafeteria_Management_SystemDataSet
        '
        Me.Cafeteria_Management_SystemDataSet.DataSetName = "Cafeteria_Management_SystemDataSet"
        Me.Cafeteria_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'FKOrderDetItem34C8D9D1BindingSource
        '
        Me.FKOrderDetItem34C8D9D1BindingSource.DataMember = "FK__Order_Det__Item___34C8D9D1"
        Me.FKOrderDetItem34C8D9D1BindingSource.DataSource = Me.ItemsBindingSource
        '
        'Order_DetailsTableAdapter
        '
        Me.Order_DetailsTableAdapter.ClearBeforeFill = True
        '
        'ItemsTableAdapter1
        '
        Me.ItemsTableAdapter1.ClearBeforeFill = True
        '
        'cboCategory
        '
        Me.cboCategory.DataSource = Me.CategoryBindingSource2
        Me.cboCategory.DisplayMember = "Category"
        Me.cboCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(267, 80)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(436, 39)
        Me.cboCategory.TabIndex = 67
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.Final_DataSet
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'CategoryBindingSource1
        '
        Me.CategoryBindingSource1.DataMember = "Category"
        Me.CategoryBindingSource1.DataSource = Me.Final_DataSet
        '
        'CategoryBindingSource2
        '
        Me.CategoryBindingSource2.DataMember = "Category"
        Me.CategoryBindingSource2.DataSource = Me.Final_DataSet
        '
        '_34AddNewItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 485)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblSelfCode)
        Me.Controls.Add(Me.lblNewCode)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCategory)
        Me.Name = "_34AddNewItem"
        Me.Text = "Add New Item"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CafeteriaManagementSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cafeteria_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKOrderDetItem34C8D9D1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblNewCode As Label
    Friend WithEvents lblSelfCode As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cafeteria_Management_SystemDataSet As Cafeteria_Management_SystemDataSet
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As Cafeteria_Management_SystemDataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents FKOrderDetItem34C8D9D1BindingSource As BindingSource
    Friend WithEvents Order_DetailsTableAdapter As Cafeteria_Management_SystemDataSetTableAdapters.Order_DetailsTableAdapter
    Friend WithEvents ItemsBindingSource1 As BindingSource
    Friend WithEvents CafeteriaManagementSystemDataSetBindingSource As BindingSource
    Friend WithEvents Final_DataSet As Final_DataSet
    Friend WithEvents ItemsBindingSource2 As BindingSource
    Friend WithEvents ItemsTableAdapter1 As Final_DataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents CategoryTableAdapter As Final_DataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents CategoryBindingSource2 As BindingSource
    Friend WithEvents CategoryBindingSource1 As BindingSource
End Class
