<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _31MenuMod
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
        Me.btnReturnSet = New System.Windows.Forms.Button()
        Me.btnAddCategory = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.btnUpdateItem = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReturnSet
        '
        Me.btnReturnSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnSet.Location = New System.Drawing.Point(372, 504)
        Me.btnReturnSet.Name = "btnReturnSet"
        Me.btnReturnSet.Size = New System.Drawing.Size(347, 44)
        Me.btnReturnSet.TabIndex = 67
        Me.btnReturnSet.Text = "Return to Settings"
        Me.btnReturnSet.UseVisualStyleBackColor = True
        '
        'btnAddCategory
        '
        Me.btnAddCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCategory.Location = New System.Drawing.Point(632, 82)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(347, 42)
        Me.btnAddCategory.TabIndex = 66
        Me.btnAddCategory.Text = "Add New Category"
        Me.btnAddCategory.UseVisualStyleBackColor = True
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(124, 226)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(347, 42)
        Me.btnAddItem.TabIndex = 64
        Me.btnAddItem.Text = "Add New Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteItem.Location = New System.Drawing.Point(124, 370)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(347, 42)
        Me.btnDeleteItem.TabIndex = 63
        Me.btnDeleteItem.Text = "Delete Item"
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'btnUpdateItem
        '
        Me.btnUpdateItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateItem.Location = New System.Drawing.Point(124, 82)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.Size = New System.Drawing.Size(347, 42)
        Me.btnUpdateItem.TabIndex = 62
        Me.btnUpdateItem.Text = "Update Item"
        Me.btnUpdateItem.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(632, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(347, 42)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Delete Category"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '_31MenuMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 593)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnReturnSet)
        Me.Controls.Add(Me.btnAddCategory)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnUpdateItem)
        Me.Name = "_31MenuMod"
        Me.Text = "Menu Items Modification"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReturnSet As Button
    Friend WithEvents btnAddCategory As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents btnUpdateItem As Button
    Friend WithEvents Button1 As Button
End Class
