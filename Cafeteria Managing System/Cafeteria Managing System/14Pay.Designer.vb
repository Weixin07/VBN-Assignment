<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _14Pay
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
        Dim Item_CodeLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTableCode = New System.Windows.Forms.Label()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Cafeteria_Management_SystemDataSet1 = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1()
        Me.OrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_DetailsTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.Order_DetailsTableAdapter()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.OrdersTableAdapter()
        Me.OrderDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.ReceiptDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Receipt_DetailsTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.Receipt_DetailsTableAdapter()
        Me.OrderDetailsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiptDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTPA = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblReceived = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblRICode = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtTPA = New System.Windows.Forms.TextBox()
        Me.txtReceived = New System.Windows.Forms.TextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.DataGridViewOrderDetails = New System.Windows.Forms.DataGridView()
        Me.ODIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDetailsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Final_DataSet = New Cafeteria_Managing_System.Final_DataSet()
        Me.btnAddToReceipt = New System.Windows.Forms.Button()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.ItemsTableAdapter()
        Me.TableAdapterManager = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.TableAdapterManager()
        Me.Item_CodeComboBox = New System.Windows.Forms.ComboBox()
        Me.ItemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCalculateTotal = New System.Windows.Forms.TextBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnCalculate2 = New System.Windows.Forms.Button()
        Me.btnCalculate3 = New System.Windows.Forms.Button()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.cboOrderID = New System.Windows.Forms.ComboBox()
        Me.OrderDetailsBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiptDetailsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_DetailsTableAdapter1 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.Order_DetailsTableAdapter()
        Me.ItemsTableAdapter1 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.ItemsTableAdapter()
        Me.TableAdapterManager1 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.TableAdapterManager()
        Me.Receipt_DetailsTableAdapter1 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.Receipt_DetailsTableAdapter()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.OrderDetailsBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiptDetailsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtRD_ID = New System.Windows.Forms.TextBox()
        Item_CodeLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptDetailsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptDetailsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Item_CodeLabel
        '
        Item_CodeLabel.AutoSize = True
        Item_CodeLabel.Location = New System.Drawing.Point(232, 276)
        Item_CodeLabel.Name = "Item_CodeLabel"
        Item_CodeLabel.Size = New System.Drawing.Size(75, 17)
        Item_CodeLabel.TabIndex = 82
        Item_CodeLabel.Text = "Item Code:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(232, 306)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(44, 17)
        PriceLabel.TabIndex = 94
        PriceLabel.Text = "Price:"
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(19, 483)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(167, 36)
        Me.btnReturn.TabIndex = 54
        Me.btnReturn.Text = "Return to Tables"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(758, 499)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(107, 20)
        Me.lblTime.TabIndex = 53
        Me.lblTime.Text = "Current Time"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(758, 469)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(106, 20)
        Me.lblDate.TabIndex = 52
        Me.lblDate.Text = "Current Date"
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(11, 100)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(73, 29)
        Me.lblMenu.TabIndex = 50
        Me.lblMenu.Text = "Menu"
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPay.Location = New System.Drawing.Point(11, 190)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(88, 44)
        Me.lblPay.TabIndex = 49
        Me.lblPay.Text = "Pay"
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(11, 145)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(76, 29)
        Me.lblOrder.TabIndex = 48
        Me.lblOrder.Text = "Order"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Location = New System.Drawing.Point(2, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 151)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'lblTableCode
        '
        Me.lblTableCode.AutoSize = True
        Me.lblTableCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableCode.Location = New System.Drawing.Point(12, 9)
        Me.lblTableCode.Name = "lblTableCode"
        Me.lblTableCode.Size = New System.Drawing.Size(167, 29)
        Me.lblTableCode.TabIndex = 46
        Me.lblTableCode.Text = "_Table Code_"
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(188, 95)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(77, 29)
        Me.lblItems.TabIndex = 59
        Me.lblItems.Text = "Items:"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Cafeteria_Management_SystemDataSet1
        '
        Me.Cafeteria_Management_SystemDataSet1.DataSetName = "Cafeteria_Management_SystemDataSet1"
        Me.Cafeteria_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderDetailsBindingSource
        '
        Me.OrderDetailsBindingSource.DataMember = "Order_Details"
        Me.OrderDetailsBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'Order_DetailsTableAdapter
        '
        Me.Order_DetailsTableAdapter.ClearBeforeFill = True
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'OrderDetailsBindingSource1
        '
        Me.OrderDetailsBindingSource1.DataMember = "Order_Details"
        Me.OrderDetailsBindingSource1.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'btnAddition
        '
        Me.btnAddition.Location = New System.Drawing.Point(231, 340)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(76, 28)
        Me.btnAddition.TabIndex = 64
        Me.btnAddition.Text = "Add"
        Me.btnAddition.UseVisualStyleBackColor = True
        '
        'ReceiptDetailsBindingSource
        '
        Me.ReceiptDetailsBindingSource.DataMember = "Receipt_Details"
        Me.ReceiptDetailsBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'Receipt_DetailsTableAdapter
        '
        Me.Receipt_DetailsTableAdapter.ClearBeforeFill = True
        '
        'OrderDetailsBindingSource2
        '
        Me.OrderDetailsBindingSource2.DataMember = "Order_Details"
        Me.OrderDetailsBindingSource2.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'ReceiptDetailsBindingSource1
        '
        Me.ReceiptDetailsBindingSource1.DataMember = "Receipt_Details"
        Me.ReceiptDetailsBindingSource1.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(514, 167)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(74, 29)
        Me.lblTotal.TabIndex = 66
        Me.lblTotal.Text = "Total:"
        '
        'lblTPA
        '
        Me.lblTPA.AutoSize = True
        Me.lblTPA.BackColor = System.Drawing.SystemColors.Control
        Me.lblTPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTPA.Location = New System.Drawing.Point(514, 239)
        Me.lblTPA.Name = "lblTPA"
        Me.lblTPA.Size = New System.Drawing.Size(254, 29)
        Me.lblTPA.TabIndex = 67
        Me.lblTPA.Text = "Total Payable Amount:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.BackColor = System.Drawing.SystemColors.Control
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(514, 203)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(59, 29)
        Me.lblTax.TabIndex = 68
        Me.lblTax.Text = "Tax:"
        '
        'lblReceived
        '
        Me.lblReceived.AutoSize = True
        Me.lblReceived.BackColor = System.Drawing.SystemColors.Control
        Me.lblReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceived.Location = New System.Drawing.Point(514, 275)
        Me.lblReceived.Name = "lblReceived"
        Me.lblReceived.Size = New System.Drawing.Size(121, 29)
        Me.lblReceived.TabIndex = 69
        Me.lblReceived.Text = "Received:"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.BackColor = System.Drawing.SystemColors.Control
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(514, 311)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(103, 29)
        Me.lblChange.TabIndex = 70
        Me.lblChange.Text = "Change:"
        '
        'lblRICode
        '
        Me.lblRICode.AutoSize = True
        Me.lblRICode.BackColor = System.Drawing.SystemColors.Control
        Me.lblRICode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRICode.Location = New System.Drawing.Point(518, 131)
        Me.lblRICode.Name = "lblRICode"
        Me.lblRICode.Size = New System.Drawing.Size(107, 29)
        Me.lblRICode.TabIndex = 73
        Me.lblRICode.Text = "RI Code:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(594, 171)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(136, 27)
        Me.txtTotal.TabIndex = 75
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(572, 207)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(136, 27)
        Me.txtTax.TabIndex = 76
        '
        'txtTPA
        '
        Me.txtTPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTPA.Location = New System.Drawing.Point(774, 243)
        Me.txtTPA.Name = "txtTPA"
        Me.txtTPA.Size = New System.Drawing.Size(90, 27)
        Me.txtTPA.TabIndex = 77
        '
        'txtReceived
        '
        Me.txtReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceived.Location = New System.Drawing.Point(632, 279)
        Me.txtReceived.Name = "txtReceived"
        Me.txtReceived.Size = New System.Drawing.Size(136, 27)
        Me.txtReceived.TabIndex = 78
        '
        'txtChange
        '
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(620, 314)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(136, 27)
        Me.txtChange.TabIndex = 79
        '
        'DataGridViewOrderDetails
        '
        Me.DataGridViewOrderDetails.AllowUserToAddRows = False
        Me.DataGridViewOrderDetails.AllowUserToDeleteRows = False
        Me.DataGridViewOrderDetails.AutoGenerateColumns = False
        Me.DataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrderDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ODIDDataGridViewTextBoxColumn, Me.OrderIDDataGridViewTextBoxColumn, Me.ItemCodeDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridViewOrderDetails.DataSource = Me.OrderDetailsBindingSource3
        Me.DataGridViewOrderDetails.Location = New System.Drawing.Point(193, 128)
        Me.DataGridViewOrderDetails.Name = "DataGridViewOrderDetails"
        Me.DataGridViewOrderDetails.ReadOnly = True
        Me.DataGridViewOrderDetails.RowHeadersWidth = 51
        Me.DataGridViewOrderDetails.RowTemplate.Height = 24
        Me.DataGridViewOrderDetails.Size = New System.Drawing.Size(292, 118)
        Me.DataGridViewOrderDetails.TabIndex = 65
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
        'OrderDetailsBindingSource3
        '
        Me.OrderDetailsBindingSource3.DataMember = "Order_Details"
        Me.OrderDetailsBindingSource3.DataSource = Me.Final_DataSet
        '
        'Final_DataSet
        '
        Me.Final_DataSet.DataSetName = "Final_DataSet"
        Me.Final_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAddToReceipt
        '
        Me.btnAddToReceipt.Location = New System.Drawing.Point(235, 431)
        Me.btnAddToReceipt.Name = "btnAddToReceipt"
        Me.btnAddToReceipt.Size = New System.Drawing.Size(187, 28)
        Me.btnAddToReceipt.TabIndex = 82
        Me.btnAddToReceipt.Text = "Add to Receipt"
        Me.btnAddToReceipt.UseVisualStyleBackColor = True
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AttendanceTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Me.ItemsTableAdapter
        Me.TableAdapterManager.Order_DetailsTableAdapter = Me.Order_DetailsTableAdapter
        Me.TableAdapterManager.OrdersTableAdapter = Me.OrdersTableAdapter
        Me.TableAdapterManager.Receipt_DetailsTableAdapter = Me.Receipt_DetailsTableAdapter
        Me.TableAdapterManager.ReceiptsTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Item_CodeComboBox
        '
        Me.Item_CodeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Item_Code", True))
        Me.Item_CodeComboBox.DataSource = Me.ItemsBindingSource1
        Me.Item_CodeComboBox.DisplayMember = "Item_Code"
        Me.Item_CodeComboBox.FormattingEnabled = True
        Me.Item_CodeComboBox.Location = New System.Drawing.Point(313, 273)
        Me.Item_CodeComboBox.Name = "Item_CodeComboBox"
        Me.Item_CodeComboBox.Size = New System.Drawing.Size(115, 24)
        Me.Item_CodeComboBox.TabIndex = 83
        '
        'ItemsBindingSource1
        '
        Me.ItemsBindingSource1.DataMember = "Items"
        Me.ItemsBindingSource1.DataSource = Me.Final_DataSet
        '
        'txtCalculateTotal
        '
        Me.txtCalculateTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalculateTotal.Location = New System.Drawing.Point(266, 385)
        Me.txtCalculateTotal.Name = "txtCalculateTotal"
        Me.txtCalculateTotal.Size = New System.Drawing.Size(136, 27)
        Me.txtCalculateTotal.TabIndex = 85
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(346, 340)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(76, 28)
        Me.btnTotal.TabIndex = 86
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(388, 300)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(76, 28)
        Me.btnNext.TabIndex = 87
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(714, 206)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(91, 28)
        Me.btnCalculate.TabIndex = 88
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnCalculate2
        '
        Me.btnCalculate2.Location = New System.Drawing.Point(805, 273)
        Me.btnCalculate2.Name = "btnCalculate2"
        Me.btnCalculate2.Size = New System.Drawing.Size(86, 28)
        Me.btnCalculate2.TabIndex = 89
        Me.btnCalculate2.Text = "Calculate"
        Me.btnCalculate2.UseVisualStyleBackColor = True
        '
        'btnCalculate3
        '
        Me.btnCalculate3.Location = New System.Drawing.Point(765, 314)
        Me.btnCalculate3.Name = "btnCalculate3"
        Me.btnCalculate3.Size = New System.Drawing.Size(97, 28)
        Me.btnCalculate3.TabIndex = 90
        Me.btnCalculate3.Text = "Calculate"
        Me.btnCalculate3.UseVisualStyleBackColor = True
        '
        'btnProceed
        '
        Me.btnProceed.Location = New System.Drawing.Point(552, 365)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(187, 28)
        Me.btnProceed.TabIndex = 91
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.BackColor = System.Drawing.SystemColors.Control
        Me.lblOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderID.Location = New System.Drawing.Point(518, 95)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(111, 29)
        Me.lblOrderID.TabIndex = 92
        Me.lblOrderID.Text = "Order ID:"
        '
        'cboOrderID
        '
        Me.cboOrderID.DataSource = Me.OrderDetailsBindingSource4
        Me.cboOrderID.DisplayMember = "OD_ID"
        Me.cboOrderID.FormattingEnabled = True
        Me.cboOrderID.Location = New System.Drawing.Point(635, 100)
        Me.cboOrderID.Name = "cboOrderID"
        Me.cboOrderID.Size = New System.Drawing.Size(121, 24)
        Me.cboOrderID.TabIndex = 93
        '
        'OrderDetailsBindingSource4
        '
        Me.OrderDetailsBindingSource4.DataMember = "Order_Details"
        Me.OrderDetailsBindingSource4.DataSource = Me.Final_DataSet
        '
        'OrdersBindingSource1
        '
        Me.OrdersBindingSource1.DataMember = "Orders"
        Me.OrdersBindingSource1.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'ReceiptDetailsBindingSource2
        '
        Me.ReceiptDetailsBindingSource2.DataMember = "Receipt_Details"
        Me.ReceiptDetailsBindingSource2.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'Order_DetailsTableAdapter1
        '
        Me.Order_DetailsTableAdapter1.ClearBeforeFill = True
        '
        'ItemsTableAdapter1
        '
        Me.ItemsTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AttendanceTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CategoryTableAdapter = Nothing
        Me.TableAdapterManager1.CustomersTableAdapter = Nothing
        Me.TableAdapterManager1.ItemsTableAdapter = Me.ItemsTableAdapter1
        Me.TableAdapterManager1.Order_DetailsTableAdapter = Me.Order_DetailsTableAdapter1
        Me.TableAdapterManager1.OrdersTableAdapter = Nothing
        Me.TableAdapterManager1.Receipt_DetailsTableAdapter = Me.Receipt_DetailsTableAdapter1
        Me.TableAdapterManager1.StaffTableAdapter = Nothing
        Me.TableAdapterManager1.StatusTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Cafeteria_Managing_System.Final_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Receipt_DetailsTableAdapter1
        '
        Me.Receipt_DetailsTableAdapter1.ClearBeforeFill = True
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource1, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(313, 303)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(69, 22)
        Me.PriceTextBox.TabIndex = 95
        '
        'OrderDetailsBindingSource5
        '
        Me.OrderDetailsBindingSource5.DataMember = "Order_Details"
        Me.OrderDetailsBindingSource5.DataSource = Me.Final_DataSet
        '
        'ReceiptDetailsBindingSource3
        '
        Me.ReceiptDetailsBindingSource3.DataMember = "Receipt_Details"
        Me.ReceiptDetailsBindingSource3.DataSource = Me.Final_DataSet
        '
        'txtRD_ID
        '
        Me.txtRD_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRD_ID.Location = New System.Drawing.Point(631, 135)
        Me.txtRD_ID.Name = "txtRD_ID"
        Me.txtRD_ID.Size = New System.Drawing.Size(136, 27)
        Me.txtRD_ID.TabIndex = 96
        '
        '_14Pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 539)
        Me.Controls.Add(Me.txtRD_ID)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.cboOrderID)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.btnCalculate3)
        Me.Controls.Add(Me.btnCalculate2)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.txtCalculateTotal)
        Me.Controls.Add(Item_CodeLabel)
        Me.Controls.Add(Me.Item_CodeComboBox)
        Me.Controls.Add(Me.btnAddToReceipt)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.txtReceived)
        Me.Controls.Add(Me.txtTPA)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblRICode)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblReceived)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTPA)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.DataGridViewOrderDetails)
        Me.Controls.Add(Me.btnAddition)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTableCode)
        Me.Name = "_14Pay"
        Me.Text = "Managing System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptDetailsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptDetailsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents lblPay As Label
    Friend WithEvents lblOrder As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTableCode As Label
    Friend WithEvents lblItems As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Cafeteria_Management_SystemDataSet1 As Cafeteria_Management_SystemDataSet1
    Friend WithEvents OrderDetailsBindingSource As BindingSource
    Friend WithEvents Order_DetailsTableAdapter As Cafeteria_Management_SystemDataSet1TableAdapters.Order_DetailsTableAdapter
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As Cafeteria_Management_SystemDataSet1TableAdapters.OrdersTableAdapter
    Friend WithEvents OrderDetailsBindingSource1 As BindingSource
    Friend WithEvents btnAddition As Button
    Friend WithEvents ReceiptDetailsBindingSource As BindingSource
    Friend WithEvents Receipt_DetailsTableAdapter As Cafeteria_Management_SystemDataSet1TableAdapters.Receipt_DetailsTableAdapter
    Friend WithEvents OrderDetailsBindingSource2 As BindingSource
    Friend WithEvents ReceiptDetailsBindingSource1 As BindingSource
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTPA As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblReceived As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents lblRICode As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtTPA As TextBox
    Friend WithEvents txtReceived As TextBox
    Friend WithEvents txtChange As TextBox
    Friend WithEvents DataGridViewOrderDetails As DataGridView
    Friend WithEvents btnAddToReceipt As Button
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As Cafeteria_Management_SystemDataSet1TableAdapters.ItemsTableAdapter
    Friend WithEvents TableAdapterManager As Cafeteria_Management_SystemDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Item_CodeComboBox As ComboBox
    Friend WithEvents txtCalculateTotal As TextBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnCalculate2 As Button
    Friend WithEvents btnCalculate3 As Button
    Friend WithEvents btnProceed As Button
    Friend WithEvents lblOrderID As Label
    Friend WithEvents cboOrderID As ComboBox
    Friend WithEvents OrdersBindingSource1 As BindingSource
    Friend WithEvents ReceiptDetailsBindingSource2 As BindingSource
    Friend WithEvents Final_DataSet As Final_DataSet
    Friend WithEvents OrderDetailsBindingSource3 As BindingSource
    Friend WithEvents Order_DetailsTableAdapter1 As Final_DataSetTableAdapters.Order_DetailsTableAdapter
    Friend WithEvents ODIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemsBindingSource1 As BindingSource
    Friend WithEvents ItemsTableAdapter1 As Final_DataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents TableAdapterManager1 As Final_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents OrderDetailsBindingSource4 As BindingSource
    Friend WithEvents OrderDetailsBindingSource5 As BindingSource
    Friend WithEvents Receipt_DetailsTableAdapter1 As Final_DataSetTableAdapters.Receipt_DetailsTableAdapter
    Friend WithEvents ReceiptDetailsBindingSource3 As BindingSource
    Friend WithEvents txtRD_ID As TextBox
End Class
