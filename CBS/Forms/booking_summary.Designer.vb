<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class booking_summary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(booking_summary))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PlateNo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bk_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_dateBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_dept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_loctogo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_PlateNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_outtime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_intime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_reason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FROM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TO"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(74, 13)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 26)
        Me.DateTimePicker1.TabIndex = 2
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(241, 13)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(128, 26)
        Me.DateTimePicker2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(196, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(173, 28)
        Me.ComboBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Vehicle Registration NO"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Beige
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bk_ID, Me.bk_dateBook, Me.bk_name, Me.bk_dept, Me.bk_loctogo, Me.vhc_PlateNo, Me.bk_outtime, Me.bk_intime, Me.bk_reason})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 20
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(952, 371)
        Me.DataGridView1.TabIndex = 6
        Me.DataGridView1.TabStop = False
        '
        'PlateNo
        '
        Me.PlateNo.Location = New System.Drawing.Point(278, 53)
        Me.PlateNo.Name = "PlateNo"
        Me.PlateNo.Size = New System.Drawing.Size(61, 20)
        Me.PlateNo.TabIndex = 7
        Me.PlateNo.TabStop = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(694, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 50)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&SEARCH"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(958, 390)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(824, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 50)
        Me.Button2.TabIndex = 10
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bk_ID
        '
        Me.bk_ID.DataPropertyName = "bk_ID"
        Me.bk_ID.HeaderText = "Booking No"
        Me.bk_ID.Name = "bk_ID"
        Me.bk_ID.ReadOnly = True
        Me.bk_ID.Width = 60
        '
        'bk_dateBook
        '
        Me.bk_dateBook.DataPropertyName = "bk_dateBook"
        Me.bk_dateBook.HeaderText = "Date"
        Me.bk_dateBook.Name = "bk_dateBook"
        Me.bk_dateBook.ReadOnly = True
        Me.bk_dateBook.Width = 90
        '
        'bk_name
        '
        Me.bk_name.DataPropertyName = "bk_name"
        Me.bk_name.HeaderText = "Name"
        Me.bk_name.Name = "bk_name"
        Me.bk_name.ReadOnly = True
        Me.bk_name.Width = 140
        '
        'bk_dept
        '
        Me.bk_dept.DataPropertyName = "bk_dept"
        Me.bk_dept.HeaderText = "Department"
        Me.bk_dept.Name = "bk_dept"
        Me.bk_dept.ReadOnly = True
        Me.bk_dept.Width = 120
        '
        'bk_loctogo
        '
        Me.bk_loctogo.DataPropertyName = "bk_loctogo"
        Me.bk_loctogo.HeaderText = "Place/Location"
        Me.bk_loctogo.Name = "bk_loctogo"
        Me.bk_loctogo.ReadOnly = True
        Me.bk_loctogo.Width = 160
        '
        'vhc_PlateNo
        '
        Me.vhc_PlateNo.HeaderText = "Registration NO"
        Me.vhc_PlateNo.Name = "vhc_PlateNo"
        Me.vhc_PlateNo.ReadOnly = True
        '
        'bk_outtime
        '
        Me.bk_outtime.DataPropertyName = "bk_outtime"
        Me.bk_outtime.HeaderText = "Actual Out Time"
        Me.bk_outtime.Name = "bk_outtime"
        Me.bk_outtime.ReadOnly = True
        Me.bk_outtime.Width = 130
        '
        'bk_intime
        '
        Me.bk_intime.DataPropertyName = "bk_intime"
        Me.bk_intime.HeaderText = "Actual In Time"
        Me.bk_intime.Name = "bk_intime"
        Me.bk_intime.ReadOnly = True
        Me.bk_intime.Width = 130
        '
        'bk_reason
        '
        Me.bk_reason.HeaderText = "Reason"
        Me.bk_reason.Name = "bk_reason"
        Me.bk_reason.ReadOnly = True
        Me.bk_reason.Visible = False
        '
        'booking_summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(966, 478)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PlateNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "booking_summary"
        Me.Text = "Booking Summary"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PlateNo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents bk_ID As DataGridViewTextBoxColumn
    Friend WithEvents bk_dateBook As DataGridViewTextBoxColumn
    Friend WithEvents bk_name As DataGridViewTextBoxColumn
    Friend WithEvents bk_dept As DataGridViewTextBoxColumn
    Friend WithEvents bk_loctogo As DataGridViewTextBoxColumn
    Friend WithEvents vhc_PlateNo As DataGridViewTextBoxColumn
    Friend WithEvents bk_outtime As DataGridViewTextBoxColumn
    Friend WithEvents bk_intime As DataGridViewTextBoxColumn
    Friend WithEvents bk_reason As DataGridViewTextBoxColumn
End Class
