<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_Expiry
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
        Me.BkslipTableAdapter1 = New CBS.CBSDataSetTableAdapters.bkslipTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.listGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.vhc_PLateNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_expire_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.leftdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateText = New System.Windows.Forms.Button()
        Me.RefreshButton3 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonShowList = New System.Windows.Forms.Button()
        Me.LabelPN = New System.Windows.Forms.Label()
        Me.LabelEmpID = New System.Windows.Forms.Label()
        Me.LabelEmpName = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.getdate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelvhcID = New System.Windows.Forms.Label()
        Me.Button2RT = New System.Windows.Forms.Button()
        Me.Button3INS = New System.Windows.Forms.Button()
        Me.Button4INSPECT = New System.Windows.Forms.Button()
        Me.Label3Page = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.listGroupBox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BkslipTableAdapter1
        '
        Me.BkslipTableAdapter1.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(509, 446)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.listGroupBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(501, 420)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Expiry View"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'listGroupBox
        '
        Me.listGroupBox.Controls.Add(Me.Label2)
        Me.listGroupBox.Controls.Add(Me.DataGridView1)
        Me.listGroupBox.Controls.Add(Me.UpdateText)
        Me.listGroupBox.Controls.Add(Me.RefreshButton3)
        Me.listGroupBox.Location = New System.Drawing.Point(6, 6)
        Me.listGroupBox.Name = "listGroupBox"
        Me.listGroupBox.Size = New System.Drawing.Size(489, 408)
        Me.listGroupBox.TabIndex = 25
        Me.listGroupBox.TabStop = False
        Me.listGroupBox.Text = "Expiry status :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(348, 391)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "NoCount"
        Me.Label2.Visible = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vhc_PLateNo, Me.vhc_brand, Me.vhc_model, Me.vhc_expire_date, Me.leftdate, Me.vhc_ID})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(477, 331)
        Me.DataGridView1.TabIndex = 0
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
        Me.vhc_brand.Width = 80
        '
        'vhc_model
        '
        Me.vhc_model.DataPropertyName = "vhc_model"
        Me.vhc_model.HeaderText = "Model"
        Me.vhc_model.Name = "vhc_model"
        Me.vhc_model.ReadOnly = True
        Me.vhc_model.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.vhc_model.Width = 80
        '
        'vhc_expire_date
        '
        Me.vhc_expire_date.HeaderText = "Expire Date"
        Me.vhc_expire_date.Name = "vhc_expire_date"
        Me.vhc_expire_date.ReadOnly = True
        Me.vhc_expire_date.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.vhc_expire_date.Width = 120
        '
        'leftdate
        '
        Me.leftdate.DataPropertyName = "leftdate"
        Me.leftdate.HeaderText = "Expire In"
        Me.leftdate.Name = "leftdate"
        Me.leftdate.ReadOnly = True
        Me.leftdate.Width = 70
        '
        'vhc_ID
        '
        Me.vhc_ID.DataPropertyName = "vhc_ID"
        Me.vhc_ID.HeaderText = "vhc_ID"
        Me.vhc_ID.Name = "vhc_ID"
        Me.vhc_ID.ReadOnly = True
        Me.vhc_ID.Visible = False
        '
        'UpdateText
        '
        Me.UpdateText.Location = New System.Drawing.Point(6, 18)
        Me.UpdateText.Name = "UpdateText"
        Me.UpdateText.Size = New System.Drawing.Size(159, 23)
        Me.UpdateText.TabIndex = 25
        Me.UpdateText.Text = "Some text"
        Me.UpdateText.UseVisualStyleBackColor = True
        '
        'RefreshButton3
        '
        Me.RefreshButton3.Location = New System.Drawing.Point(408, 19)
        Me.RefreshButton3.Name = "RefreshButton3"
        Me.RefreshButton3.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton3.TabIndex = 26
        Me.RefreshButton3.Text = "Refresh"
        Me.RefreshButton3.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(501, 420)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Key Status"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonShowList)
        Me.GroupBox1.Controls.Add(Me.LabelPN)
        Me.GroupBox1.Controls.Add(Me.LabelEmpID)
        Me.GroupBox1.Controls.Add(Me.LabelEmpName)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.LabelDate)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 399)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle key status :"
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(318, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "vhc_PLateNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Plate No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "vhc_brand"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Brand"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "vhc_model"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "vhc_key_status"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Key Status"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn4.Width = 80
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
        'getdate
        '
        Me.getdate.AutoSize = True
        Me.getdate.Location = New System.Drawing.Point(170, 461)
        Me.getdate.Name = "getdate"
        Me.getdate.Size = New System.Drawing.Size(43, 13)
        Me.getdate.TabIndex = 27
        Me.getdate.Text = "getdate"
        Me.getdate.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 461)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Label1"
        '
        'LabelvhcID
        '
        Me.LabelvhcID.AutoSize = True
        Me.LabelvhcID.Location = New System.Drawing.Point(85, 461)
        Me.LabelvhcID.Name = "LabelvhcID"
        Me.LabelvhcID.Size = New System.Drawing.Size(62, 13)
        Me.LabelvhcID.TabIndex = 26
        Me.LabelvhcID.Text = "LabelvhcID"
        Me.LabelvhcID.Visible = False
        '
        'Button2RT
        '
        Me.Button2RT.Location = New System.Drawing.Point(527, 34)
        Me.Button2RT.Name = "Button2RT"
        Me.Button2RT.Size = New System.Drawing.Size(75, 67)
        Me.Button2RT.TabIndex = 27
        Me.Button2RT.Text = "RoadTax"
        Me.Button2RT.UseVisualStyleBackColor = True
        '
        'Button3INS
        '
        Me.Button3INS.Location = New System.Drawing.Point(527, 118)
        Me.Button3INS.Name = "Button3INS"
        Me.Button3INS.Size = New System.Drawing.Size(75, 67)
        Me.Button3INS.TabIndex = 28
        Me.Button3INS.Text = "Insurance"
        Me.Button3INS.UseVisualStyleBackColor = True
        '
        'Button4INSPECT
        '
        Me.Button4INSPECT.Location = New System.Drawing.Point(527, 204)
        Me.Button4INSPECT.Name = "Button4INSPECT"
        Me.Button4INSPECT.Size = New System.Drawing.Size(75, 67)
        Me.Button4INSPECT.TabIndex = 29
        Me.Button4INSPECT.Text = "Inspection"
        Me.Button4INSPECT.UseVisualStyleBackColor = True
        '
        'Label3Page
        '
        Me.Label3Page.AutoSize = True
        Me.Label3Page.Location = New System.Drawing.Point(564, 431)
        Me.Label3Page.Name = "Label3Page"
        Me.Label3Page.Size = New System.Drawing.Size(0, 13)
        Me.Label3Page.TabIndex = 30
        '
        'Show_Expiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 497)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3Page)
        Me.Controls.Add(Me.getdate)
        Me.Controls.Add(Me.Button4INSPECT)
        Me.Controls.Add(Me.Button3INS)
        Me.Controls.Add(Me.Button2RT)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.LabelvhcID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Show_Expiry"
        Me.Text = "Show Roadtax Expiry"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.listGroupBox.ResumeLayout(False)
        Me.listGroupBox.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BkslipTableAdapter1 As CBSDataSetTableAdapters.bkslipTableAdapter
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents listGroupBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelvhcID As Label
    Friend WithEvents getdate As Label
    Friend WithEvents UpdateText As Button
    Friend WithEvents RefreshButton3 As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonShowList As Button
    Friend WithEvents LabelPN As Label
    Friend WithEvents LabelEmpID As Label
    Friend WithEvents LabelEmpName As Label
    Friend WithEvents Button1 As Button
    Protected WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents LabelDate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2RT As Button
    Friend WithEvents Button3INS As Button
    Friend WithEvents Button4INSPECT As Button
    Friend WithEvents Label3Page As Label
    Friend WithEvents vhc_PLateNo As DataGridViewTextBoxColumn
    Friend WithEvents vhc_brand As DataGridViewTextBoxColumn
    Friend WithEvents vhc_model As DataGridViewTextBoxColumn
    Friend WithEvents vhc_expire_date As DataGridViewTextBoxColumn
    Friend WithEvents leftdate As DataGridViewTextBoxColumn
    Friend WithEvents vhc_ID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
End Class
