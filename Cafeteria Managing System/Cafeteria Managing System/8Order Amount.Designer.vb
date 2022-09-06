<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _8_Order_Amount
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
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblOD_ID = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Cafeteria_Management_SystemDataSet = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSetTableAdapters.OrdersTableAdapter()
        Me.OrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_DetailsTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSetTableAdapters.Order_DetailsTableAdapter()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSetTableAdapters.CustomersTableAdapter()
        Me.CustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtOD_ID = New System.Windows.Forms.TextBox()
        Me.lblItem_Code = New System.Windows.Forms.Label()
        Me.txtItem_Code = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.txtOrder_ID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cafeteria_Management_SystemDataSet1 = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1()
        Me.OrderDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_DetailsTableAdapter1 = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.Order_DetailsTableAdapter()
        Me.ODIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Cafeteria_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(1033, 403)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(162, 41)
        Me.btnConfirm.TabIndex = 9
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(205, 278)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(229, 38)
        Me.txtQuantity.TabIndex = 8
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(22, 281)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(130, 32)
        Me.lblQuantity.TabIndex = 7
        Me.lblQuantity.Text = "Quantity:"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1033, 450)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(162, 41)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblOD_ID
        '
        Me.lblOD_ID.AutoSize = True
        Me.lblOD_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOD_ID.Location = New System.Drawing.Point(22, 173)
        Me.lblOD_ID.Name = "lblOD_ID"
        Me.lblOD_ID.Size = New System.Drawing.Size(99, 32)
        Me.lblOD_ID.TabIndex = 12
        Me.lblOD_ID.Text = "OD ID:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(1081, 41)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(53, 25)
        Me.lblDate.TabIndex = 14
        Me.lblDate.Text = "Date"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(1081, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(56, 25)
        Me.lblTime.TabIndex = 15
        Me.lblTime.Text = "Time"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Cafeteria_Management_SystemDataSet
        '
        Me.Cafeteria_Management_SystemDataSet.DataSetName = "Cafeteria_Management_SystemDataSet"
        Me.Cafeteria_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'OrderDetailsBindingSource
        '
        Me.OrderDetailsBindingSource.DataMember = "Order_Details"
        Me.OrderDetailsBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet
        '
        'Order_DetailsTableAdapter
        '
        Me.Order_DetailsTableAdapter.ClearBeforeFill = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(22, 335)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(104, 32)
        Me.lblStatus.TabIndex = 24
        Me.lblStatus.Text = "Status:"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'CustomersBindingSource1
        '
        Me.CustomersBindingSource1.DataMember = "Customers"
        Me.CustomersBindingSource1.DataSource = Me.Cafeteria_Management_SystemDataSet
        '
        'txtOD_ID
        '
        Me.txtOD_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOD_ID.Location = New System.Drawing.Point(205, 170)
        Me.txtOD_ID.Name = "txtOD_ID"
        Me.txtOD_ID.Size = New System.Drawing.Size(229, 38)
        Me.txtOD_ID.TabIndex = 27
        '
        'lblItem_Code
        '
        Me.lblItem_Code.AutoSize = True
        Me.lblItem_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem_Code.Location = New System.Drawing.Point(23, 227)
        Me.lblItem_Code.Name = "lblItem_Code"
        Me.lblItem_Code.Size = New System.Drawing.Size(152, 32)
        Me.lblItem_Code.TabIndex = 28
        Me.lblItem_Code.Text = "Item Code:"
        '
        'txtItem_Code
        '
        Me.txtItem_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem_Code.Location = New System.Drawing.Point(205, 224)
        Me.txtItem_Code.Name = "txtItem_Code"
        Me.txtItem_Code.Size = New System.Drawing.Size(229, 38)
        Me.txtItem_Code.TabIndex = 29
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(205, 332)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(229, 38)
        Me.txtStatus.TabIndex = 30
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderID.Location = New System.Drawing.Point(21, 119)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(129, 32)
        Me.lblOrderID.TabIndex = 13
        Me.lblOrderID.Text = "Order ID:"
        '
        'txtOrder_ID
        '
        Me.txtOrder_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrder_ID.Location = New System.Drawing.Point(205, 116)
        Me.txtOrder_ID.Name = "txtOrder_ID"
        Me.txtOrder_ID.Size = New System.Drawing.Size(229, 38)
        Me.txtOrder_ID.TabIndex = 25
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ODIDDataGridViewTextBoxColumn, Me.OrderIDDataGridViewTextBoxColumn, Me.ItemCodeDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrderDetailsBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(476, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(661, 248)
        Me.DataGridView1.TabIndex = 31
        '
        'Cafeteria_Management_SystemDataSet1
        '
        Me.Cafeteria_Management_SystemDataSet1.DataSetName = "Cafeteria_Management_SystemDataSet1"
        Me.Cafeteria_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderDetailsBindingSource1
        '
        Me.OrderDetailsBindingSource1.DataMember = "Order_Details"
        Me.OrderDetailsBindingSource1.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'Order_DetailsTableAdapter1
        '
        Me.Order_DetailsTableAdapter1.ClearBeforeFill = True
        '
        'ODIDDataGridViewTextBoxColumn
        '
        Me.ODIDDataGridViewTextBoxColumn.DataPropertyName = "OD_ID"
        Me.ODIDDataGridViewTextBoxColumn.HeaderText = "OD_ID"
        Me.ODIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ODIDDataGridViewTextBoxColumn.Name = "ODIDDataGridViewTextBoxColumn"
        Me.ODIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ODIDDataGridViewTextBoxColumn.Width = 125
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID"
        Me.OrderIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
        Me.OrderIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderIDDataGridViewTextBoxColumn.Width = 125
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
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Width = 125
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Width = 125
        '
        '_8_Order_Amount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 506)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtItem_Code)
        Me.Controls.Add(Me.lblItem_Code)
        Me.Controls.Add(Me.txtOD_ID)
        Me.Controls.Add(Me.txtOrder_ID)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.lblOD_ID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Name = "_8_Order_Amount"
        Me.Text = "Order"
        CType(Me.Cafeteria_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblOD_ID As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Cafeteria_Management_SystemDataSet As Cafeteria_Management_SystemDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As Cafeteria_Management_SystemDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents OrderDetailsBindingSource As BindingSource
    Friend WithEvents Order_DetailsTableAdapter As Cafeteria_Management_SystemDataSetTableAdapters.Order_DetailsTableAdapter
    Friend WithEvents lblStatus As Label
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As Cafeteria_Management_SystemDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents CustomersBindingSource1 As BindingSource
    Friend WithEvents txtOD_ID As TextBox
    Friend WithEvents lblItem_Code As Label
    Friend WithEvents txtItem_Code As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblOrderID As Label
    Friend WithEvents txtOrder_ID As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cafeteria_Management_SystemDataSet1 As Cafeteria_Management_SystemDataSet1
    Friend WithEvents OrderDetailsBindingSource1 As BindingSource
    Friend WithEvents Order_DetailsTableAdapter1 As Cafeteria_Management_SystemDataSet1TableAdapters.Order_DetailsTableAdapter
    Friend WithEvents ODIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
