<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _8OrderAmount_Remake_
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ODIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Final_DataSet = New Cafeteria_Managing_System.Final_DataSet()
        Me.OrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cafeteria_Management_SystemDataSet1 = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1()
        Me.lblItem_Code = New System.Windows.Forms.Label()
        Me.txtOD_ID = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.lblOD_ID = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Order_DetailsTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.Order_DetailsTableAdapter()
        Me.cboorderID = New System.Windows.Forms.ComboBox()
        Me.OrdersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.OrdersTableAdapter()
        Me.cboItemCode = New System.Windows.Forms.ComboBox()
        Me.ItemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemsTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.ItemsTableAdapter()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.StatusBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.StatusTableAdapter()
        Me.OrdersTableAdapter1 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.OrdersTableAdapter()
        Me.ItemsTableAdapter1 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.ItemsTableAdapter()
        Me.StatusTableAdapter1 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.StatusTableAdapter()
        Me.Order_DetailsTableAdapter1 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.Order_DetailsTableAdapter()
        Me.StatusBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ODIDDataGridViewTextBoxColumn, Me.OrderIDDataGridViewTextBoxColumn, Me.ItemCodeDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrderDetailsBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(485, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(661, 248)
        Me.DataGridView1.TabIndex = 46
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
        'OrderDetailsBindingSource1
        '
        Me.OrderDetailsBindingSource1.DataMember = "Order_Details"
        Me.OrderDetailsBindingSource1.DataSource = Me.Final_DataSet
        '
        'Final_DataSet
        '
        Me.Final_DataSet.DataSetName = "Final_DataSet"
        Me.Final_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderDetailsBindingSource
        '
        Me.OrderDetailsBindingSource.DataMember = "Order_Details"
        Me.OrderDetailsBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'Cafeteria_Management_SystemDataSet1
        '
        Me.Cafeteria_Management_SystemDataSet1.DataSetName = "Cafeteria_Management_SystemDataSet1"
        Me.Cafeteria_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblItem_Code
        '
        Me.lblItem_Code.AutoSize = True
        Me.lblItem_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem_Code.Location = New System.Drawing.Point(32, 241)
        Me.lblItem_Code.Name = "lblItem_Code"
        Me.lblItem_Code.Size = New System.Drawing.Size(152, 32)
        Me.lblItem_Code.TabIndex = 43
        Me.lblItem_Code.Text = "Item Code:"
        '
        'txtOD_ID
        '
        Me.txtOD_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOD_ID.Location = New System.Drawing.Point(214, 184)
        Me.txtOD_ID.Name = "txtOD_ID"
        Me.txtOD_ID.Size = New System.Drawing.Size(229, 38)
        Me.txtOD_ID.TabIndex = 42
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(31, 349)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(104, 32)
        Me.lblStatus.TabIndex = 40
        Me.lblStatus.Text = "Status:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(1090, 23)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(56, 25)
        Me.lblTime.TabIndex = 39
        Me.lblTime.Text = "Time"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(1090, 55)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(53, 25)
        Me.lblDate.TabIndex = 38
        Me.lblDate.Text = "Date"
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderID.Location = New System.Drawing.Point(30, 133)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(129, 32)
        Me.lblOrderID.TabIndex = 37
        Me.lblOrderID.Text = "Order ID:"
        '
        'lblOD_ID
        '
        Me.lblOD_ID.AutoSize = True
        Me.lblOD_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOD_ID.Location = New System.Drawing.Point(31, 187)
        Me.lblOD_ID.Name = "lblOD_ID"
        Me.lblOD_ID.Size = New System.Drawing.Size(99, 32)
        Me.lblOD_ID.TabIndex = 36
        Me.lblOD_ID.Text = "OD ID:"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1042, 464)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(162, 41)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(1042, 417)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(162, 41)
        Me.btnConfirm.TabIndex = 34
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(214, 292)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(229, 38)
        Me.txtQuantity.TabIndex = 33
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(31, 295)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(130, 32)
        Me.lblQuantity.TabIndex = 32
        Me.lblQuantity.Text = "Quantity:"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Order_DetailsTableAdapter
        '
        Me.Order_DetailsTableAdapter.ClearBeforeFill = True
        '
        'cboorderID
        '
        Me.cboorderID.DataSource = Me.OrdersBindingSource1
        Me.cboorderID.DisplayMember = "Order_ID"
        Me.cboorderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboorderID.FormattingEnabled = True
        Me.cboorderID.Location = New System.Drawing.Point(214, 133)
        Me.cboorderID.Name = "cboorderID"
        Me.cboorderID.Size = New System.Drawing.Size(229, 39)
        Me.cboorderID.TabIndex = 47
        '
        'OrdersBindingSource1
        '
        Me.OrdersBindingSource1.DataMember = "Orders"
        Me.OrdersBindingSource1.DataSource = Me.Final_DataSet
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
        'cboItemCode
        '
        Me.cboItemCode.DataSource = Me.ItemsBindingSource1
        Me.cboItemCode.DisplayMember = "Item_Code"
        Me.cboItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItemCode.FormattingEnabled = True
        Me.cboItemCode.Location = New System.Drawing.Point(214, 238)
        Me.cboItemCode.Name = "cboItemCode"
        Me.cboItemCode.Size = New System.Drawing.Size(229, 39)
        Me.cboItemCode.TabIndex = 48
        '
        'ItemsBindingSource1
        '
        Me.ItemsBindingSource1.DataMember = "Items"
        Me.ItemsBindingSource1.DataSource = Me.Final_DataSet
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
        'cboStatus
        '
        Me.cboStatus.DataSource = Me.StatusBindingSource2
        Me.cboStatus.DisplayMember = "Status"
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(214, 346)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(229, 39)
        Me.cboStatus.TabIndex = 49
        '
        'StatusBindingSource1
        '
        Me.StatusBindingSource1.DataMember = "Status"
        Me.StatusBindingSource1.DataSource = Me.Final_DataSet
        '
        'StatusBindingSource
        '
        Me.StatusBindingSource.DataMember = "Status"
        Me.StatusBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'OrdersTableAdapter1
        '
        Me.OrdersTableAdapter1.ClearBeforeFill = True
        '
        'ItemsTableAdapter1
        '
        Me.ItemsTableAdapter1.ClearBeforeFill = True
        '
        'StatusTableAdapter1
        '
        Me.StatusTableAdapter1.ClearBeforeFill = True
        '
        'Order_DetailsTableAdapter1
        '
        Me.Order_DetailsTableAdapter1.ClearBeforeFill = True
        '
        'StatusBindingSource2
        '
        Me.StatusBindingSource2.DataMember = "Status"
        Me.StatusBindingSource2.DataSource = Me.Final_DataSet
        '
        '_8OrderAmount_Remake_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 517)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.cboItemCode)
        Me.Controls.Add(Me.cboorderID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblItem_Code)
        Me.Controls.Add(Me.txtOD_ID)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.lblOD_ID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Name = "_8OrderAmount_Remake_"
        Me.Text = "Order"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblItem_Code As Label
    Friend WithEvents txtOD_ID As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblOrderID As Label
    Friend WithEvents lblOD_ID As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Cafeteria_Management_SystemDataSet1 As Cafeteria_Management_SystemDataSet1
    Friend WithEvents OrderDetailsBindingSource As BindingSource
    Friend WithEvents Order_DetailsTableAdapter As Cafeteria_Management_SystemDataSet1TableAdapters.Order_DetailsTableAdapter
    Friend WithEvents cboorderID As ComboBox
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As Cafeteria_Management_SystemDataSet1TableAdapters.OrdersTableAdapter
    Friend WithEvents cboItemCode As ComboBox
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As Cafeteria_Management_SystemDataSet1TableAdapters.ItemsTableAdapter
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As Cafeteria_Management_SystemDataSet1TableAdapters.StatusTableAdapter
    Friend WithEvents Final_DataSet As Final_DataSet
    Friend WithEvents OrdersBindingSource1 As BindingSource
    Friend WithEvents OrdersTableAdapter1 As Final_DataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents ItemsBindingSource1 As BindingSource
    Friend WithEvents ItemsTableAdapter1 As Final_DataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents StatusBindingSource1 As BindingSource
    Friend WithEvents StatusTableAdapter1 As Final_DataSetTableAdapters.StatusTableAdapter
    Friend WithEvents OrderDetailsBindingSource1 As BindingSource
    Friend WithEvents Order_DetailsTableAdapter1 As Final_DataSetTableAdapters.Order_DetailsTableAdapter
    Friend WithEvents ODIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusBindingSource2 As BindingSource
End Class
