<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_Security
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report_Security))
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bk_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_PlateNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_OUTcheckbyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sc_bkouttime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sc_outtimeupd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_INcheckbyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sc_bkintime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sc_intimeupd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_complete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(241, 21)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(128, 26)
        Me.DateTimePicker2.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(74, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 26)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FROM"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeight = 32
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bk_ID, Me.vhc_PlateNo, Me.bk_name, Me.bk_OUTcheckbyName, Me.sc_bkouttime, Me.sc_outtimeupd, Me.bk_INcheckbyName, Me.sc_bkintime, Me.sc_intimeupd, Me.bk_complete})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 22
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(955, 328)
        Me.DataGridView1.TabIndex = 8
        '
        'bk_ID
        '
        Me.bk_ID.DataPropertyName = "bk_ID"
        Me.bk_ID.HeaderText = "Booking ID"
        Me.bk_ID.Name = "bk_ID"
        Me.bk_ID.ReadOnly = True
        Me.bk_ID.Width = 80
        '
        'vhc_PlateNo
        '
        Me.vhc_PlateNo.DataPropertyName = "vhc_PlateNo"
        Me.vhc_PlateNo.HeaderText = "Registration No"
        Me.vhc_PlateNo.Name = "vhc_PlateNo"
        Me.vhc_PlateNo.ReadOnly = True
        Me.vhc_PlateNo.Width = 90
        '
        'bk_name
        '
        Me.bk_name.DataPropertyName = "bk_name"
        Me.bk_name.HeaderText = "Booking Name"
        Me.bk_name.Name = "bk_name"
        Me.bk_name.ReadOnly = True
        Me.bk_name.Width = 120
        '
        'bk_OUTcheckbyName
        '
        Me.bk_OUTcheckbyName.DataPropertyName = "bk_OUTcheckbyName"
        Me.bk_OUTcheckbyName.HeaderText = "Out Check By"
        Me.bk_OUTcheckbyName.Name = "bk_OUTcheckbyName"
        Me.bk_OUTcheckbyName.ReadOnly = True
        Me.bk_OUTcheckbyName.Width = 80
        '
        'sc_bkouttime
        '
        Me.sc_bkouttime.DataPropertyName = "sc_bkouttime"
        Me.sc_bkouttime.HeaderText = "Out Time"
        Me.sc_bkouttime.Name = "sc_bkouttime"
        Me.sc_bkouttime.ReadOnly = True
        Me.sc_bkouttime.Width = 120
        '
        'sc_outtimeupd
        '
        Me.sc_outtimeupd.DataPropertyName = "sc_outtimeupd"
        Me.sc_outtimeupd.HeaderText = "Update On (Out)"
        Me.sc_outtimeupd.Name = "sc_outtimeupd"
        Me.sc_outtimeupd.ReadOnly = True
        Me.sc_outtimeupd.Width = 120
        '
        'bk_INcheckbyName
        '
        Me.bk_INcheckbyName.DataPropertyName = "bk_INcheckbyName"
        Me.bk_INcheckbyName.HeaderText = "In Check By"
        Me.bk_INcheckbyName.Name = "bk_INcheckbyName"
        Me.bk_INcheckbyName.ReadOnly = True
        Me.bk_INcheckbyName.Width = 80
        '
        'sc_bkintime
        '
        Me.sc_bkintime.DataPropertyName = "sc_bkintime"
        Me.sc_bkintime.HeaderText = "In Time"
        Me.sc_bkintime.Name = "sc_bkintime"
        Me.sc_bkintime.ReadOnly = True
        Me.sc_bkintime.Width = 120
        '
        'sc_intimeupd
        '
        Me.sc_intimeupd.DataPropertyName = "sc_intimeupd"
        Me.sc_intimeupd.HeaderText = "Update On (In)"
        Me.sc_intimeupd.Name = "sc_intimeupd"
        Me.sc_intimeupd.ReadOnly = True
        Me.sc_intimeupd.Width = 120
        '
        'bk_complete
        '
        Me.bk_complete.HeaderText = "complete"
        Me.bk_complete.Name = "bk_complete"
        Me.bk_complete.ReadOnly = True
        Me.bk_complete.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(794, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 50)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&SEARCH"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Report_Security
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 396)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Report_Security"
        Me.Text = "Security Check Report"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents bk_ID As DataGridViewTextBoxColumn
    Friend WithEvents vhc_PlateNo As DataGridViewTextBoxColumn
    Friend WithEvents bk_name As DataGridViewTextBoxColumn
    Friend WithEvents bk_OUTcheckbyName As DataGridViewTextBoxColumn
    Friend WithEvents sc_bkouttime As DataGridViewTextBoxColumn
    Friend WithEvents sc_outtimeupd As DataGridViewTextBoxColumn
    Friend WithEvents bk_INcheckbyName As DataGridViewTextBoxColumn
    Friend WithEvents sc_bkintime As DataGridViewTextBoxColumn
    Friend WithEvents sc_intimeupd As DataGridViewTextBoxColumn
    Friend WithEvents bk_complete As DataGridViewTextBoxColumn
End Class
