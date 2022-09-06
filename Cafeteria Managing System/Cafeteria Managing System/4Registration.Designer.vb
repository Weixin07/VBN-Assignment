<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _3Registration
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
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblTableCode2 = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTableCode = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txtCustomer_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cafeteria_Management_SystemDataSet = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSet()
        Me.CustomersTableAdapter = New Cafeteria_Managing_System.Cafeteria_Management_SystemDataSetTableAdapters.CustomersTableAdapter()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cafeteria_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(1028, 549)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(107, 20)
        Me.lblTime.TabIndex = 18
        Me.lblTime.Text = "Current Time"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(1028, 519)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(106, 20)
        Me.lblDate.TabIndex = 17
        Me.lblDate.Text = "Current Date"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(1028, 489)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(104, 20)
        Me.lblUsername.TabIndex = 16
        Me.lblUsername.Text = "_Username_"
        '
        'lblTableCode2
        '
        Me.lblTableCode2.AutoSize = True
        Me.lblTableCode2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableCode2.Location = New System.Drawing.Point(382, 145)
        Me.lblTableCode2.Name = "lblTableCode2"
        Me.lblTableCode2.Size = New System.Drawing.Size(192, 32)
        Me.lblTableCode2.TabIndex = 19
        Me.lblTableCode2.Text = "_Table Code_"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.Location = New System.Drawing.Point(281, 337)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(228, 32)
        Me.lblContactNumber.TabIndex = 20
        Me.lblContactNumber.Text = "Contact Number:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(281, 273)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(98, 32)
        Me.lblName.TabIndex = 21
        Me.lblName.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(281, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 32)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Table:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(312, 69)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(500, 44)
        Me.lblTitle.TabIndex = 23
        Me.lblTitle.Text = "Customer Registration Form"
        '
        'lblTableCode
        '
        Me.lblTableCode.AutoSize = True
        Me.lblTableCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableCode.Location = New System.Drawing.Point(12, 9)
        Me.lblTableCode.Name = "lblTableCode"
        Me.lblTableCode.Size = New System.Drawing.Size(112, 20)
        Me.lblTableCode.TabIndex = 24
        Me.lblTableCode.Text = "_Table Code_"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(486, 421)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(144, 43)
        Me.btnSubmit.TabIndex = 25
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(16, 533)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(200, 36)
        Me.btnReturn.TabIndex = 26
        Me.btnReturn.Text = "Return to Tables"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(385, 270)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(514, 38)
        Me.txtName.TabIndex = 27
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Location = New System.Drawing.Point(515, 331)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(384, 38)
        Me.txtContactNumber.TabIndex = 28
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'txtCustomer_ID
        '
        Me.txtCustomer_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer_ID.Location = New System.Drawing.Point(466, 206)
        Me.txtCustomer_ID.Name = "txtCustomer_ID"
        Me.txtCustomer_ID.Size = New System.Drawing.Size(433, 38)
        Me.txtCustomer_ID.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 32)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Customer ID:"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.Cafeteria_Management_SystemDataSet
        '
        'Cafeteria_Management_SystemDataSet
        '
        Me.Cafeteria_Management_SystemDataSet.DataSetName = "Cafeteria_Management_SystemDataSet"
        Me.Cafeteria_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        '_3Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 584)
        Me.Controls.Add(Me.txtCustomer_ID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblTableCode)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblContactNumber)
        Me.Controls.Add(Me.lblTableCode2)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "_3Registration"
        Me.Text = "Registration"
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cafeteria_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblTableCode2 As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTableCode As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents txtCustomer_ID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cafeteria_Management_SystemDataSet As Cafeteria_Management_SystemDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As Cafeteria_Management_SystemDataSetTableAdapters.CustomersTableAdapter
End Class
