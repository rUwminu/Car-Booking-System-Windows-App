<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class security_main
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
        Me.sc_name = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sec_ID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bk_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_vhccollect = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_Plate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_INOUTstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_outtime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_intime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_outmeter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_vhcID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_OUTcheckbyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_empID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.sc_bkIDtext = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.sc_bkintime = New System.Windows.Forms.TextBox()
        Me.sc_bkouttime = New System.Windows.Forms.TextBox()
        Me.sc_bkoutmeter = New System.Windows.Forms.TextBox()
        Me.bkvhcIDtext = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Outby_usrName = New System.Windows.Forms.TextBox()
        Me.Outby_usrID = New System.Windows.Forms.TextBox()
        Me.sc_bkdate = New System.Windows.Forms.TextBox()
        Me.listGroupBox = New System.Windows.Forms.GroupBox()
        Me.ButtonShowList = New System.Windows.Forms.Button()
        Me.LabelPN = New System.Windows.Forms.Label()
        Me.LabelEmpID = New System.Windows.Forms.Label()
        Me.LabelEmpName = New System.Windows.Forms.Label()
        Me.RefreshButton3 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.vhc_PLateNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_key_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.listGroupBox.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'sc_name
        '
        Me.sc_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sc_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_name.FormattingEnabled = True
        Me.sc_name.Location = New System.Drawing.Point(108, 17)
        Me.sc_name.Name = "sc_name"
        Me.sc_name.Size = New System.Drawing.Size(298, 28)
        Me.sc_name.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Check by :"
        '
        'sec_ID
        '
        Me.sec_ID.Location = New System.Drawing.Point(356, 22)
        Me.sec_ID.Name = "sec_ID"
        Me.sec_ID.Size = New System.Drawing.Size(30, 20)
        Me.sec_ID.TabIndex = 2
        Me.sec_ID.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bk_ID, Me.bk_vhccollect, Me.vhc_Plate, Me.bk_INOUTstatus, Me.bk_outtime, Me.bk_intime, Me.bk_outmeter, Me.bk_vhcID, Me.bk_OUTcheckbyID, Me.bk_name, Me.bk_empID})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 22
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(415, 333)
        Me.DataGridView1.TabIndex = 3
        '
        'bk_ID
        '
        Me.bk_ID.DataPropertyName = "bk_ID"
        Me.bk_ID.HeaderText = "Booking No"
        Me.bk_ID.Name = "bk_ID"
        Me.bk_ID.ReadOnly = True
        Me.bk_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'bk_vhccollect
        '
        Me.bk_vhccollect.DataPropertyName = "bk_vhccollect"
        Me.bk_vhccollect.HeaderText = "Date"
        Me.bk_vhccollect.Name = "bk_vhccollect"
        Me.bk_vhccollect.ReadOnly = True
        Me.bk_vhccollect.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'vhc_Plate
        '
        Me.vhc_Plate.DataPropertyName = "vhc_PlateNo"
        Me.vhc_Plate.HeaderText = "Plate No"
        Me.vhc_Plate.Name = "vhc_Plate"
        Me.vhc_Plate.ReadOnly = True
        Me.vhc_Plate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'bk_INOUTstatus
        '
        Me.bk_INOUTstatus.DataPropertyName = "bk_INOUTstatus"
        Me.bk_INOUTstatus.HeaderText = "IN OUT Status"
        Me.bk_INOUTstatus.Name = "bk_INOUTstatus"
        Me.bk_INOUTstatus.ReadOnly = True
        '
        'bk_outtime
        '
        Me.bk_outtime.DataPropertyName = "bk_outtime"
        Me.bk_outtime.HeaderText = "Out Time"
        Me.bk_outtime.Name = "bk_outtime"
        Me.bk_outtime.ReadOnly = True
        Me.bk_outtime.Visible = False
        '
        'bk_intime
        '
        Me.bk_intime.DataPropertyName = "bk_intime"
        Me.bk_intime.HeaderText = "In Time"
        Me.bk_intime.Name = "bk_intime"
        Me.bk_intime.ReadOnly = True
        Me.bk_intime.Visible = False
        '
        'bk_outmeter
        '
        Me.bk_outmeter.DataPropertyName = "bk_outmeter"
        Me.bk_outmeter.HeaderText = "Out Meter"
        Me.bk_outmeter.Name = "bk_outmeter"
        Me.bk_outmeter.ReadOnly = True
        Me.bk_outmeter.Visible = False
        '
        'bk_vhcID
        '
        Me.bk_vhcID.DataPropertyName = "bk_vhc_ID"
        Me.bk_vhcID.HeaderText = "vehicle ID"
        Me.bk_vhcID.Name = "bk_vhcID"
        Me.bk_vhcID.ReadOnly = True
        Me.bk_vhcID.Visible = False
        '
        'bk_OUTcheckbyID
        '
        Me.bk_OUTcheckbyID.DataPropertyName = "bk_OUTcheckbyID"
        Me.bk_OUTcheckbyID.HeaderText = "check by"
        Me.bk_OUTcheckbyID.Name = "bk_OUTcheckbyID"
        Me.bk_OUTcheckbyID.ReadOnly = True
        Me.bk_OUTcheckbyID.Visible = False
        '
        'bk_name
        '
        Me.bk_name.DataPropertyName = "bk_name"
        Me.bk_name.HeaderText = "emp name"
        Me.bk_name.Name = "bk_name"
        Me.bk_name.ReadOnly = True
        Me.bk_name.Visible = False
        '
        'bk_empID
        '
        Me.bk_empID.DataPropertyName = "bk_empID"
        Me.bk_empID.HeaderText = "emp ID"
        Me.bk_empID.Name = "bk_empID"
        Me.bk_empID.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "OUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 41)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "IN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'sc_bkIDtext
        '
        Me.sc_bkIDtext.Location = New System.Drawing.Point(91, 153)
        Me.sc_bkIDtext.Name = "sc_bkIDtext"
        Me.sc_bkIDtext.Size = New System.Drawing.Size(63, 20)
        Me.sc_bkIDtext.TabIndex = 6
        Me.sc_bkIDtext.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(287, 66)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "CLOSE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'sc_bkintime
        '
        Me.sc_bkintime.Location = New System.Drawing.Point(168, 179)
        Me.sc_bkintime.Name = "sc_bkintime"
        Me.sc_bkintime.Size = New System.Drawing.Size(63, 20)
        Me.sc_bkintime.TabIndex = 14
        Me.sc_bkintime.TabStop = False
        '
        'sc_bkouttime
        '
        Me.sc_bkouttime.Location = New System.Drawing.Point(237, 179)
        Me.sc_bkouttime.Name = "sc_bkouttime"
        Me.sc_bkouttime.Size = New System.Drawing.Size(63, 20)
        Me.sc_bkouttime.TabIndex = 15
        Me.sc_bkouttime.TabStop = False
        '
        'sc_bkoutmeter
        '
        Me.sc_bkoutmeter.Location = New System.Drawing.Point(168, 153)
        Me.sc_bkoutmeter.Name = "sc_bkoutmeter"
        Me.sc_bkoutmeter.Size = New System.Drawing.Size(63, 20)
        Me.sc_bkoutmeter.TabIndex = 16
        Me.sc_bkoutmeter.TabStop = False
        '
        'bkvhcIDtext
        '
        Me.bkvhcIDtext.Location = New System.Drawing.Point(200, 22)
        Me.bkvhcIDtext.Name = "bkvhcIDtext"
        Me.bkvhcIDtext.Size = New System.Drawing.Size(48, 20)
        Me.bkvhcIDtext.TabIndex = 17
        Me.bkvhcIDtext.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 448)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(207, 31)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Show "" OUTING "" vehicle / CAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(339, 456)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 23)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "&Reset"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Outby_usrName
        '
        Me.Outby_usrName.BackColor = System.Drawing.SystemColors.Menu
        Me.Outby_usrName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Outby_usrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Outby_usrName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Outby_usrName.Location = New System.Drawing.Point(24, 496)
        Me.Outby_usrName.Name = "Outby_usrName"
        Me.Outby_usrName.Size = New System.Drawing.Size(145, 16)
        Me.Outby_usrName.TabIndex = 20
        '
        'Outby_usrID
        '
        Me.Outby_usrID.Location = New System.Drawing.Point(130, 459)
        Me.Outby_usrID.Name = "Outby_usrID"
        Me.Outby_usrID.Size = New System.Drawing.Size(24, 20)
        Me.Outby_usrID.TabIndex = 21
        '
        'sc_bkdate
        '
        Me.sc_bkdate.Location = New System.Drawing.Point(237, 153)
        Me.sc_bkdate.Name = "sc_bkdate"
        Me.sc_bkdate.Size = New System.Drawing.Size(63, 20)
        Me.sc_bkdate.TabIndex = 22
        Me.sc_bkdate.TabStop = False
        '
        'listGroupBox
        '
        Me.listGroupBox.Controls.Add(Me.ButtonShowList)
        Me.listGroupBox.Controls.Add(Me.LabelPN)
        Me.listGroupBox.Controls.Add(Me.LabelEmpID)
        Me.listGroupBox.Controls.Add(Me.LabelEmpName)
        Me.listGroupBox.Controls.Add(Me.RefreshButton3)
        Me.listGroupBox.Controls.Add(Me.DataGridView2)
        Me.listGroupBox.Controls.Add(Me.LabelDate)
        Me.listGroupBox.Location = New System.Drawing.Point(21, 15)
        Me.listGroupBox.Name = "listGroupBox"
        Me.listGroupBox.Size = New System.Drawing.Size(399, 409)
        Me.listGroupBox.TabIndex = 23
        Me.listGroupBox.TabStop = False
        Me.listGroupBox.Text = "Vehicle key status :"
        '
        'ButtonShowList
        '
        Me.ButtonShowList.Location = New System.Drawing.Point(6, 18)
        Me.ButtonShowList.Name = "ButtonShowList"
        Me.ButtonShowList.Size = New System.Drawing.Size(159, 23)
        Me.ButtonShowList.TabIndex = 25
        Me.ButtonShowList.Text = "View Record"
        Me.ButtonShowList.UseVisualStyleBackColor = True
        '
        'LabelPN
        '
        Me.LabelPN.AutoSize = True
        Me.LabelPN.Location = New System.Drawing.Point(6, 381)
        Me.LabelPN.Name = "LabelPN"
        Me.LabelPN.Size = New System.Drawing.Size(22, 13)
        Me.LabelPN.TabIndex = 27
        Me.LabelPN.Text = "PN"
        Me.LabelPN.Visible = False
        '
        'LabelEmpID
        '
        Me.LabelEmpID.AutoSize = True
        Me.LabelEmpID.Location = New System.Drawing.Point(67, 381)
        Me.LabelEmpID.Name = "LabelEmpID"
        Me.LabelEmpID.Size = New System.Drawing.Size(39, 13)
        Me.LabelEmpID.TabIndex = 28
        Me.LabelEmpID.Text = "EmpID"
        Me.LabelEmpID.Visible = False
        '
        'LabelEmpName
        '
        Me.LabelEmpName.AutoSize = True
        Me.LabelEmpName.Location = New System.Drawing.Point(112, 381)
        Me.LabelEmpName.Name = "LabelEmpName"
        Me.LabelEmpName.Size = New System.Drawing.Size(59, 13)
        Me.LabelEmpName.TabIndex = 29
        Me.LabelEmpName.Text = "Emp Name"
        Me.LabelEmpName.Visible = False
        '
        'RefreshButton3
        '
        Me.RefreshButton3.Location = New System.Drawing.Point(318, 18)
        Me.RefreshButton3.Name = "RefreshButton3"
        Me.RefreshButton3.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton3.TabIndex = 26
        Me.RefreshButton3.Text = "Refresh"
        Me.RefreshButton3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeight = 30
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vhc_PLateNo, Me.vhc_brand, Me.vhc_model, Me.vhc_key_status})
        Me.DataGridView2.Location = New System.Drawing.Point(6, 47)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 25
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(387, 331)
        Me.DataGridView2.TabIndex = 0
        '
        'vhc_PLateNo
        '
        Me.vhc_PLateNo.DataPropertyName = "vhc_PLateNo"
        Me.vhc_PLateNo.HeaderText = "Plate No"
        Me.vhc_PLateNo.Name = "vhc_PLateNo"
        Me.vhc_PLateNo.ReadOnly = True
        Me.vhc_PLateNo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.vhc_PLateNo.Width = 80
        '
        'vhc_brand
        '
        Me.vhc_brand.DataPropertyName = "vhc_brand"
        Me.vhc_brand.HeaderText = "Brand"
        Me.vhc_brand.Name = "vhc_brand"
        Me.vhc_brand.ReadOnly = True
        Me.vhc_brand.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'vhc_model
        '
        Me.vhc_model.DataPropertyName = "vhc_model"
        Me.vhc_model.HeaderText = "Model"
        Me.vhc_model.Name = "vhc_model"
        Me.vhc_model.ReadOnly = True
        Me.vhc_model.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'vhc_key_status
        '
        Me.vhc_key_status.DataPropertyName = "vhc_key_status"
        Me.vhc_key_status.HeaderText = "Key Status"
        Me.vhc_key_status.Name = "vhc_key_status"
        Me.vhc_key_status.ReadOnly = True
        Me.vhc_key_status.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.vhc_key_status.Width = 80
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(177, 381)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(30, 13)
        Me.LabelDate.TabIndex = 26
        Me.LabelDate.Text = "Date"
        Me.LabelDate.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(445, 518)
        Me.TabControl1.TabIndex = 30
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.sc_name)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Outby_usrID)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.bkvhcIDtext)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.sec_ID)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.sc_bkIDtext)
        Me.TabPage1.Controls.Add(Me.sc_bkoutmeter)
        Me.TabPage1.Controls.Add(Me.sc_bkintime)
        Me.TabPage1.Controls.Add(Me.sc_bkdate)
        Me.TabPage1.Controls.Add(Me.sc_bkouttime)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(437, 492)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Check IN OUT"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.listGroupBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(437, 492)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Key Status"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'security_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 527)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Outby_usrName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "security_main"
        Me.Text = "Security Check List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.listGroupBox.ResumeLayout(False)
        Me.listGroupBox.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sc_name As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents sec_ID As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents sc_bkIDtext As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents sc_bkintime As TextBox
    Friend WithEvents sc_bkouttime As TextBox
    Friend WithEvents sc_bkoutmeter As TextBox
    Friend WithEvents bkvhcIDtext As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Outby_usrName As TextBox
    Friend WithEvents Outby_usrID As TextBox
    Friend WithEvents sc_bkdate As TextBox
    Friend WithEvents listGroupBox As GroupBox
    Friend WithEvents vhc_PLateNo As DataGridViewTextBoxColumn
    Friend WithEvents vhc_brand As DataGridViewTextBoxColumn
    Friend WithEvents vhc_model As DataGridViewTextBoxColumn
    Friend WithEvents vhc_key_status As DataGridViewTextBoxColumn
    Friend WithEvents RefreshButton3 As Button
    Friend WithEvents ButtonShowList As Button
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelPN As Label
    Friend WithEvents LabelEmpID As Label
    Friend WithEvents LabelEmpName As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents bk_ID As DataGridViewTextBoxColumn
    Friend WithEvents bk_vhccollect As DataGridViewTextBoxColumn
    Friend WithEvents vhc_Plate As DataGridViewTextBoxColumn
    Friend WithEvents bk_INOUTstatus As DataGridViewTextBoxColumn
    Friend WithEvents bk_outtime As DataGridViewTextBoxColumn
    Friend WithEvents bk_intime As DataGridViewTextBoxColumn
    Friend WithEvents bk_outmeter As DataGridViewTextBoxColumn
    Friend WithEvents bk_vhcID As DataGridViewTextBoxColumn
    Friend WithEvents bk_OUTcheckbyID As DataGridViewTextBoxColumn
    Friend WithEvents bk_name As DataGridViewTextBoxColumn
    Friend WithEvents bk_empID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
End Class
