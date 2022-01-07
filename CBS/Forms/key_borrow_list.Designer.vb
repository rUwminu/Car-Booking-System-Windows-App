<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class key_borrow_list
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.employee_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_take = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_return = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Plate_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ButtonS = New System.Windows.Forms.Button()
        Me.ButtonR = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.employee_name, Me.employee_id, Me.date_take, Me.date_return, Me.Plate_No})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(588, 296)
        Me.DataGridView1.TabIndex = 1
        '
        'employee_name
        '
        Me.employee_name.DataPropertyName = "employee_name"
        Me.employee_name.HeaderText = "Name"
        Me.employee_name.MinimumWidth = 20
        Me.employee_name.Name = "employee_name"
        Me.employee_name.ReadOnly = True
        Me.employee_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.employee_name.Width = 140
        '
        'employee_id
        '
        Me.employee_id.DataPropertyName = "employee_id"
        Me.employee_id.HeaderText = "ID"
        Me.employee_id.MinimumWidth = 10
        Me.employee_id.Name = "employee_id"
        Me.employee_id.ReadOnly = True
        Me.employee_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'date_take
        '
        Me.date_take.DataPropertyName = "date_take"
        Me.date_take.HeaderText = "Take Date"
        Me.date_take.MinimumWidth = 20
        Me.date_take.Name = "date_take"
        Me.date_take.ReadOnly = True
        Me.date_take.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.date_take.Width = 120
        '
        'date_return
        '
        Me.date_return.DataPropertyName = "date_return"
        Me.date_return.HeaderText = "Return Date"
        Me.date_return.MinimumWidth = 20
        Me.date_return.Name = "date_return"
        Me.date_return.ReadOnly = True
        Me.date_return.Width = 120
        '
        'Plate_No
        '
        Me.Plate_No.DataPropertyName = "Plate_No"
        Me.Plate_No.HeaderText = "Plate_No"
        Me.Plate_No.MinimumWidth = 10
        Me.Plate_No.Name = "Plate_No"
        Me.Plate_No.ReadOnly = True
        Me.Plate_No.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Plate_No.Width = 80
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'ButtonS
        '
        Me.ButtonS.Location = New System.Drawing.Point(169, 12)
        Me.ButtonS.Name = "ButtonS"
        Me.ButtonS.Size = New System.Drawing.Size(75, 23)
        Me.ButtonS.TabIndex = 3
        Me.ButtonS.Text = "Search"
        Me.ButtonS.UseVisualStyleBackColor = True
        '
        'ButtonR
        '
        Me.ButtonR.Location = New System.Drawing.Point(525, 12)
        Me.ButtonR.Name = "ButtonR"
        Me.ButtonR.Size = New System.Drawing.Size(75, 23)
        Me.ButtonR.TabIndex = 4
        Me.ButtonR.Text = "Refresh"
        Me.ButtonR.UseVisualStyleBackColor = True
        '
        'key_borrow_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 373)
        Me.Controls.Add(Me.ButtonR)
        Me.Controls.Add(Me.ButtonS)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "key_borrow_list"
        Me.Text = "Key Tracking Record"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ButtonS As Button
    Friend WithEvents ButtonR As Button
    Friend WithEvents employee_name As DataGridViewTextBoxColumn
    Friend WithEvents employee_id As DataGridViewTextBoxColumn
    Friend WithEvents date_take As DataGridViewTextBoxColumn
    Friend WithEvents date_return As DataGridViewTextBoxColumn
    Friend WithEvents Plate_No As DataGridViewTextBoxColumn
End Class
