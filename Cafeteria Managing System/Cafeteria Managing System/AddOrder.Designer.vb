<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOrder
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
        Me.txtOrder_ID = New System.Windows.Forms.TextBox()
        Me.lblTableCode = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Cafeteria_Management_SystemDataSet = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSetTableAdapters.OrdersTableAdapter()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSetTableAdapters.CustomersTableAdapter()
        Me.CustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CustomersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cafeteria_Management_SystemDataSet1 = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1()
        Me.CafeteriaManagementSystemDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter1 = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.CustomersTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OrdersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter1 = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.OrdersTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.CustomersBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboUsername = New System.Windows.Forms.ComboBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.StaffTableAdapter()
        Me.txtTableCode = New System.Windows.Forms.TextBox()
        Me.Final_DataSet = New Cafeteria_Managing_System.Final_DataSet()
        Me.OrdersBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter2 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.OrdersTableAdapter()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter2 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.CustomersTableAdapter()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter1 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.StaffTableAdapter()
        CType(Me.Cafeteria_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CafeteriaManagementSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOrder_ID
        '
        Me.txtOrder_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrder_ID.Location = New System.Drawing.Point(239, 133)
        Me.txtOrder_ID.Name = "txtOrder_ID"
        Me.txtOrder_ID.Size = New System.Drawing.Size(229, 38)
        Me.txtOrder_ID.TabIndex = 48
        '
        'lblTableCode
        '
        Me.lblTableCode.AutoSize = True
        Me.lblTableCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableCode.Location = New System.Drawing.Point(33, 245)
        Me.lblTableCode.Name = "lblTableCode"
        Me.lblTableCode.Size = New System.Drawing.Size(170, 32)
        Me.lblTableCode.TabIndex = 44
        Me.lblTableCode.Text = "Table Code:"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerID.Location = New System.Drawing.Point(33, 192)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(179, 32)
        Me.lblCustomerID.TabIndex = 41
        Me.lblCustomerID.Text = "Customer ID:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(33, 298)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(153, 32)
        Me.lblUsername.TabIndex = 40
        Me.lblUsername.Text = "Username:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(893, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(56, 25)
        Me.lblTime.TabIndex = 38
        Me.lblTime.Text = "Time"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(893, 41)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(53, 25)
        Me.lblDate.TabIndex = 37
        Me.lblDate.Text = "Date"
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderID.Location = New System.Drawing.Point(33, 139)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(129, 32)
        Me.lblOrderID.TabIndex = 36
        Me.lblOrderID.Text = "Order ID:"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(898, 406)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(162, 41)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(898, 359)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(162, 41)
        Me.btnConfirm.TabIndex = 33
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
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
        'OrdersBindingSource1
        '
        Me.OrdersBindingSource1.DataMember = "Orders"
        Me.OrdersBindingSource1.DataSource = Me.Cafeteria_Management_SystemDataSet
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.TableCodeDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.CustomersBindingSource4
        Me.DataGridView2.Location = New System.Drawing.Point(526, 242)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(534, 91)
        Me.DataGridView2.TabIndex = 51
        '
        'CustomersBindingSource2
        '
        Me.CustomersBindingSource2.DataMember = "Customers"
        Me.CustomersBindingSource2.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'Cafeteria_Management_SystemDataSet1
        '
        Me.Cafeteria_Management_SystemDataSet1.DataSetName = "Cafeteria_Management_SystemDataSet1"
        Me.Cafeteria_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CafeteriaManagementSystemDataSetBindingSource
        '
        Me.CafeteriaManagementSystemDataSetBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet
        Me.CafeteriaManagementSystemDataSetBindingSource.Position = 0
        '
        'CustomersTableAdapter1
        '
        Me.CustomersTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIDDataGridViewTextBoxColumn, Me.TableCodeDataGridViewTextBoxColumn1, Me.CustomerIDDataGridViewTextBoxColumn1, Me.UsernameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrdersBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(526, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(534, 91)
        Me.DataGridView1.TabIndex = 52
        '
        'OrdersBindingSource2
        '
        Me.OrdersBindingSource2.DataMember = "Orders"
        Me.OrdersBindingSource2.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'OrdersTableAdapter1
        '
        Me.OrdersTableAdapter1.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'cboCustomer
        '
        Me.cboCustomer.DataSource = Me.CustomersBindingSource5
        Me.cboCustomer.DisplayMember = "Customer_ID"
        Me.cboCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(239, 192)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(229, 39)
        Me.cboCustomer.TabIndex = 53
        '
        'CustomersBindingSource3
        '
        Me.CustomersBindingSource3.DataMember = "Customers"
        Me.CustomersBindingSource3.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'cboUsername
        '
        Me.cboUsername.DataSource = Me.StaffBindingSource1
        Me.cboUsername.DisplayMember = "Username"
        Me.cboUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsername.FormattingEnabled = True
        Me.cboUsername.Location = New System.Drawing.Point(239, 295)
        Me.cboUsername.Name = "cboUsername"
        Me.cboUsername.Size = New System.Drawing.Size(229, 39)
        Me.cboUsername.TabIndex = 55
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
        'txtTableCode
        '
        Me.txtTableCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTableCode.Location = New System.Drawing.Point(239, 242)
        Me.txtTableCode.Name = "txtTableCode"
        Me.txtTableCode.Size = New System.Drawing.Size(229, 38)
        Me.txtTableCode.TabIndex = 56
        '
        'Final_DataSet
        '
        Me.Final_DataSet.DataSetName = "Final_DataSet"
        Me.Final_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersBindingSource3
        '
        Me.OrdersBindingSource3.DataMember = "Orders"
        Me.OrdersBindingSource3.DataSource = Me.Final_DataSet
        '
        'OrdersTableAdapter2
        '
        Me.OrdersTableAdapter2.ClearBeforeFill = True
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
        'TableCodeDataGridViewTextBoxColumn1
        '
        Me.TableCodeDataGridViewTextBoxColumn1.DataPropertyName = "Table_Code"
        Me.TableCodeDataGridViewTextBoxColumn1.HeaderText = "Table_Code"
        Me.TableCodeDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.TableCodeDataGridViewTextBoxColumn1.Name = "TableCodeDataGridViewTextBoxColumn1"
        Me.TableCodeDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TableCodeDataGridViewTextBoxColumn1.Width = 125
        '
        'CustomerIDDataGridViewTextBoxColumn1
        '
        Me.CustomerIDDataGridViewTextBoxColumn1.DataPropertyName = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn1.HeaderText = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.CustomerIDDataGridViewTextBoxColumn1.Name = "CustomerIDDataGridViewTextBoxColumn1"
        Me.CustomerIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CustomerIDDataGridViewTextBoxColumn1.Width = 125
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsernameDataGridViewTextBoxColumn.Width = 125
        '
        'CustomersBindingSource4
        '
        Me.CustomersBindingSource4.DataMember = "Customers"
        Me.CustomersBindingSource4.DataSource = Me.Final_DataSet
        '
        'CustomersTableAdapter2
        '
        Me.CustomersTableAdapter2.ClearBeforeFill = True
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 125
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
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "Contact_Number"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "Contact_Number"
        Me.ContactNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        Me.ContactNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContactNumberDataGridViewTextBoxColumn.Width = 125
        '
        'TableCodeDataGridViewTextBoxColumn
        '
        Me.TableCodeDataGridViewTextBoxColumn.DataPropertyName = "Table_Code"
        Me.TableCodeDataGridViewTextBoxColumn.HeaderText = "Table_Code"
        Me.TableCodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TableCodeDataGridViewTextBoxColumn.Name = "TableCodeDataGridViewTextBoxColumn"
        Me.TableCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TableCodeDataGridViewTextBoxColumn.Width = 125
        '
        'CustomersBindingSource5
        '
        Me.CustomersBindingSource5.DataMember = "Customers"
        Me.CustomersBindingSource5.DataSource = Me.Final_DataSet
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
        'AddOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 469)
        Me.Controls.Add(Me.txtTableCode)
        Me.Controls.Add(Me.cboUsername)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.txtOrder_ID)
        Me.Controls.Add(Me.lblTableCode)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Name = "AddOrder"
        Me.Text = "AddOrder"
        CType(Me.Cafeteria_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CafeteriaManagementSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOrder_ID As TextBox
    Friend WithEvents lblTableCode As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblOrderID As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Cafeteria_Management_SystemDataSet As Cafeteria_Management_SystemDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As Cafeteria_Management_SystemDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As Cafeteria_Management_SystemDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents CustomersBindingSource1 As BindingSource
    Friend WithEvents OrdersBindingSource1 As BindingSource
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents CafeteriaManagementSystemDataSetBindingSource As BindingSource
    Friend WithEvents Cafeteria_Management_SystemDataSet1 As Cafeteria_Management_SystemDataSet1
    Friend WithEvents CustomersBindingSource2 As BindingSource
    Friend WithEvents CustomersTableAdapter1 As Cafeteria_Management_SystemDataSet1TableAdapters.CustomersTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OrdersBindingSource2 As BindingSource
    Friend WithEvents OrdersTableAdapter1 As Cafeteria_Management_SystemDataSet1TableAdapters.OrdersTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents CustomersBindingSource3 As BindingSource
    Friend WithEvents cboUsername As ComboBox
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As Cafeteria_Management_SystemDataSet1TableAdapters.StaffTableAdapter
    Friend WithEvents txtTableCode As TextBox
    Friend WithEvents Final_DataSet As Final_DataSet
    Friend WithEvents OrdersBindingSource3 As BindingSource
    Friend WithEvents OrdersTableAdapter2 As Final_DataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableCodeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomersBindingSource4 As BindingSource
    Friend WithEvents CustomersTableAdapter2 As Final_DataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomersBindingSource5 As BindingSource
    Friend WithEvents StaffBindingSource1 As BindingSource
    Friend WithEvents StaffTableAdapter1 As Final_DataSetTableAdapters.StaffTableAdapter
End Class
