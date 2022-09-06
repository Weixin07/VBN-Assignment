<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddReceiptID
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
        Me.txtReceiptID = New System.Windows.Forms.TextBox()
        Me.lblReceipt_ID = New System.Windows.Forms.Label()
        Me.txtRICode = New System.Windows.Forms.TextBox()
        Me.lblRICode = New System.Windows.Forms.Label()
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReceiptIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RDIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cafeteria_Management_SystemDataSet1 = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1()
        Me.ReceiptsTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet1TableAdapters.ReceiptsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtReceiptID
        '
        Me.txtReceiptID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptID.Location = New System.Drawing.Point(213, 49)
        Me.txtReceiptID.Name = "txtReceiptID"
        Me.txtReceiptID.Size = New System.Drawing.Size(136, 27)
        Me.txtReceiptID.TabIndex = 83
        '
        'lblReceipt_ID
        '
        Me.lblReceipt_ID.AutoSize = True
        Me.lblReceipt_ID.BackColor = System.Drawing.SystemColors.Control
        Me.lblReceipt_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceipt_ID.Location = New System.Drawing.Point(76, 45)
        Me.lblReceipt_ID.Name = "lblReceipt_ID"
        Me.lblReceipt_ID.Size = New System.Drawing.Size(131, 29)
        Me.lblReceipt_ID.TabIndex = 82
        Me.lblReceipt_ID.Text = "Receipt ID:"
        '
        'txtRICode
        '
        Me.txtRICode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRICode.Location = New System.Drawing.Point(189, 87)
        Me.txtRICode.Name = "txtRICode"
        Me.txtRICode.Size = New System.Drawing.Size(160, 27)
        Me.txtRICode.TabIndex = 85
        '
        'lblRICode
        '
        Me.lblRICode.AutoSize = True
        Me.lblRICode.BackColor = System.Drawing.SystemColors.Control
        Me.lblRICode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRICode.Location = New System.Drawing.Point(76, 83)
        Me.lblRICode.Name = "lblRICode"
        Me.lblRICode.Size = New System.Drawing.Size(107, 29)
        Me.lblRICode.TabIndex = 84
        Me.lblRICode.Text = "RI Code:"
        '
        'btnAddition
        '
        Me.btnAddition.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddition.Location = New System.Drawing.Point(144, 133)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(86, 34)
        Me.btnAddition.TabIndex = 86
        Me.btnAddition.Text = "Add"
        Me.btnAddition.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReceiptIDDataGridViewTextBoxColumn, Me.RDIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReceiptsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(432, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(304, 150)
        Me.DataGridView1.TabIndex = 87
        '
        'ReceiptIDDataGridViewTextBoxColumn
        '
        Me.ReceiptIDDataGridViewTextBoxColumn.DataPropertyName = "Receipt_ID"
        Me.ReceiptIDDataGridViewTextBoxColumn.HeaderText = "Receipt_ID"
        Me.ReceiptIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReceiptIDDataGridViewTextBoxColumn.Name = "ReceiptIDDataGridViewTextBoxColumn"
        Me.ReceiptIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReceiptIDDataGridViewTextBoxColumn.Width = 125
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
        'ReceiptsBindingSource
        '
        Me.ReceiptsBindingSource.DataMember = "Receipts"
        Me.ReceiptsBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet1
        '
        'Cafeteria_Management_SystemDataSet1
        '
        Me.Cafeteria_Management_SystemDataSet1.DataSetName = "Cafeteria_Management_SystemDataSet1"
        Me.Cafeteria_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceiptsTableAdapter
        '
        Me.ReceiptsTableAdapter.ClearBeforeFill = True
        '
        'AddReceiptID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 220)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAddition)
        Me.Controls.Add(Me.txtRICode)
        Me.Controls.Add(Me.lblRICode)
        Me.Controls.Add(Me.txtReceiptID)
        Me.Controls.Add(Me.lblReceipt_ID)
        Me.Name = "AddReceiptID"
        Me.Text = "AddReceiptID"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cafeteria_Management_SystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtReceiptID As TextBox
    Friend WithEvents lblReceipt_ID As Label
    Friend WithEvents txtRICode As TextBox
    Friend WithEvents lblRICode As Label
    Friend WithEvents btnAddition As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cafeteria_Management_SystemDataSet1 As Cafeteria_Management_SystemDataSet1
    Friend WithEvents ReceiptsBindingSource As BindingSource
    Friend WithEvents ReceiptsTableAdapter As Cafeteria_Management_SystemDataSet1TableAdapters.ReceiptsTableAdapter
    Friend WithEvents ReceiptIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RDIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
