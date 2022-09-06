<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _15TotalPay
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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnPrn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReceiptDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cafeteria_Management_SystemDataSet1 = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1()
        Me.Receipt_DetailsTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.Receipt_DetailsTableAdapter()
        Me.Final_DataSet = New Cafeteria_Managing_System.Final_DataSet()
        Me.ReceiptDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Receipt_DetailsTableAdapter1 = New Cafeteria_Managing_System.Final_DataSetTableAdapters.Receipt_DetailsTableAdapter()
        Me.RDIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPayableAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceivedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChangeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(201, 349)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(202, 36)
        Me.btnReturn.TabIndex = 60
        Me.btnReturn.Text = "Return to Tables"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnPrn
        '
        Me.btnPrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrn.Location = New System.Drawing.Point(480, 292)
        Me.btnPrn.Name = "btnPrn"
        Me.btnPrn.Size = New System.Drawing.Size(135, 36)
        Me.btnPrn.TabIndex = 61
        Me.btnPrn.Text = "Print Receipt"
        Me.btnPrn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RDIDDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.TaxDataGridViewTextBoxColumn, Me.TotalPayableAmountDataGridViewTextBoxColumn, Me.ReceivedDataGridViewTextBoxColumn, Me.ChangeDataGridViewTextBoxColumn, Me.OrderIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReceiptDetailsBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(31, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(584, 260)
        Me.DataGridView1.TabIndex = 62
        '
        'ReceiptDetailsBindingSource
        '
        Me.ReceiptDetailsBindingSource.DataMember = "Receipt_Details"
        Me.ReceiptDetailsBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'Cafeteria_Management_SystemDataSet1
        '
        Me.Cafeteria_Management_SystemDataSet1.DataSetName = "Cafeteria_Management_SystemDataSet1"
        Me.Cafeteria_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Receipt_DetailsTableAdapter
        '
        Me.Receipt_DetailsTableAdapter.ClearBeforeFill = True
        '
        'Final_DataSet
        '
        Me.Final_DataSet.DataSetName = "Final_DataSet"
        Me.Final_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceiptDetailsBindingSource1
        '
        Me.ReceiptDetailsBindingSource1.DataMember = "Receipt_Details"
        Me.ReceiptDetailsBindingSource1.DataSource = Me.Final_DataSet
        '
        'Receipt_DetailsTableAdapter1
        '
        Me.Receipt_DetailsTableAdapter1.ClearBeforeFill = True
        '
        'RDIDDataGridViewTextBoxColumn
        '
        Me.RDIDDataGridViewTextBoxColumn.DataPropertyName = "RD_ID"
        Me.RDIDDataGridViewTextBoxColumn.HeaderText = "RD_ID"
        Me.RDIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RDIDDataGridViewTextBoxColumn.Name = "RDIDDataGridViewTextBoxColumn"
        Me.RDIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.RDIDDataGridViewTextBoxColumn.Width = 125
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Width = 125
        '
        'TaxDataGridViewTextBoxColumn
        '
        Me.TaxDataGridViewTextBoxColumn.DataPropertyName = "Tax"
        Me.TaxDataGridViewTextBoxColumn.HeaderText = "Tax"
        Me.TaxDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TaxDataGridViewTextBoxColumn.Name = "TaxDataGridViewTextBoxColumn"
        Me.TaxDataGridViewTextBoxColumn.ReadOnly = True
        Me.TaxDataGridViewTextBoxColumn.Width = 125
        '
        'TotalPayableAmountDataGridViewTextBoxColumn
        '
        Me.TotalPayableAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Payable_Amount"
        Me.TotalPayableAmountDataGridViewTextBoxColumn.HeaderText = "Total_Payable_Amount"
        Me.TotalPayableAmountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalPayableAmountDataGridViewTextBoxColumn.Name = "TotalPayableAmountDataGridViewTextBoxColumn"
        Me.TotalPayableAmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalPayableAmountDataGridViewTextBoxColumn.Width = 125
        '
        'ReceivedDataGridViewTextBoxColumn
        '
        Me.ReceivedDataGridViewTextBoxColumn.DataPropertyName = "Received"
        Me.ReceivedDataGridViewTextBoxColumn.HeaderText = "Received"
        Me.ReceivedDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReceivedDataGridViewTextBoxColumn.Name = "ReceivedDataGridViewTextBoxColumn"
        Me.ReceivedDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReceivedDataGridViewTextBoxColumn.Width = 125
        '
        'ChangeDataGridViewTextBoxColumn
        '
        Me.ChangeDataGridViewTextBoxColumn.DataPropertyName = "Change"
        Me.ChangeDataGridViewTextBoxColumn.HeaderText = "Change"
        Me.ChangeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ChangeDataGridViewTextBoxColumn.Name = "ChangeDataGridViewTextBoxColumn"
        Me.ChangeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ChangeDataGridViewTextBoxColumn.Width = 125
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
        '_15TotalPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 411)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnPrn)
        Me.Controls.Add(Me.btnReturn)
        Me.Name = "_15TotalPay"
        Me.Text = "Total Pay"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnPrn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cafeteria_Management_SystemDataSet1 As Cafeteria_Management_SystemDataSet1
    Friend WithEvents ReceiptDetailsBindingSource As BindingSource
    Friend WithEvents Receipt_DetailsTableAdapter As Cafeteria_Management_SystemDataSet1TableAdapters.Receipt_DetailsTableAdapter
    Friend WithEvents Final_DataSet As Final_DataSet
    Friend WithEvents ReceiptDetailsBindingSource1 As BindingSource
    Friend WithEvents Receipt_DetailsTableAdapter1 As Final_DataSetTableAdapters.Receipt_DetailsTableAdapter
    Friend WithEvents RDIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPayableAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceivedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChangeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
