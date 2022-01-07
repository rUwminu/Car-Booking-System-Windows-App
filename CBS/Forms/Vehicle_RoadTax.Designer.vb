<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vehicle_RoadTax
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.vhc_platetext = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dateToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.expiredNotetoolstips = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.vhc_IDtextbox = New System.Windows.Forms.TextBox()
        Me.vhc_rt_date = New System.Windows.Forms.TextBox()
        Me.VehiclerthistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBSDataSet = New CBS.CBSDataSet()
        Me.Vehicle_rt_historyTableAdapter = New CBS.CBSDataSetTableAdapters.vehicle_rt_historyTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VrthIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VrthvhcIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VrthexpdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VrthnoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.VehiclerthistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vhc_platetext
        '
        Me.vhc_platetext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhc_platetext.Location = New System.Drawing.Point(193, 14)
        Me.vhc_platetext.Name = "vhc_platetext"
        Me.vhc_platetext.ReadOnly = True
        Me.vhc_platetext.Size = New System.Drawing.Size(179, 26)
        Me.vhc_platetext.TabIndex = 2
        Me.vhc_platetext.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Registration / Plate No :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.dateToolStripStatusLabel, Me.expiredNotetoolstips})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 568)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(385, 26)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(59, 21)
        Me.ToolStripStatusLabel1.Text = "Today :"
        '
        'dateToolStripStatusLabel
        '
        Me.dateToolStripStatusLabel.Name = "dateToolStripStatusLabel"
        Me.dateToolStripStatusLabel.Size = New System.Drawing.Size(42, 21)
        Me.dateToolStripStatusLabel.Text = "Date"
        '
        'expiredNotetoolstips
        '
        Me.expiredNotetoolstips.ForeColor = System.Drawing.Color.Red
        Me.expiredNotetoolstips.Name = "expiredNotetoolstips"
        Me.expiredNotetoolstips.Size = New System.Drawing.Size(61, 21)
        Me.expiredNotetoolstips.Text = "expired"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Renew"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'vhc_IDtextbox
        '
        Me.vhc_IDtextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhc_IDtextbox.Location = New System.Drawing.Point(193, 18)
        Me.vhc_IDtextbox.Name = "vhc_IDtextbox"
        Me.vhc_IDtextbox.ReadOnly = True
        Me.vhc_IDtextbox.Size = New System.Drawing.Size(46, 14)
        Me.vhc_IDtextbox.TabIndex = 1
        Me.vhc_IDtextbox.TabStop = False
        '
        'vhc_rt_date
        '
        Me.vhc_rt_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhc_rt_date.Location = New System.Drawing.Point(245, 17)
        Me.vhc_rt_date.Name = "vhc_rt_date"
        Me.vhc_rt_date.ReadOnly = True
        Me.vhc_rt_date.Size = New System.Drawing.Size(46, 14)
        Me.vhc_rt_date.TabIndex = 7
        Me.vhc_rt_date.TabStop = False
        '
        'VehiclerthistoryBindingSource
        '
        Me.VehiclerthistoryBindingSource.DataMember = "vehicle_rt_history"
        Me.VehiclerthistoryBindingSource.DataSource = Me.CBSDataSet
        '
        'CBSDataSet
        '
        Me.CBSDataSet.DataSetName = "CBSDataSet"
        Me.CBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vehicle_rt_historyTableAdapter
        '
        Me.Vehicle_rt_historyTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VrthIDDataGridViewTextBoxColumn, Me.VrthvhcIDDataGridViewTextBoxColumn, Me.VrthexpdateDataGridViewTextBoxColumn, Me.VrthnoteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VehiclerthistoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 22
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(385, 483)
        Me.DataGridView1.TabIndex = 2
        '
        'VrthIDDataGridViewTextBoxColumn
        '
        Me.VrthIDDataGridViewTextBoxColumn.DataPropertyName = "vrth_ID"
        Me.VrthIDDataGridViewTextBoxColumn.HeaderText = "vrth_ID"
        Me.VrthIDDataGridViewTextBoxColumn.Name = "VrthIDDataGridViewTextBoxColumn"
        Me.VrthIDDataGridViewTextBoxColumn.Visible = False
        '
        'VrthvhcIDDataGridViewTextBoxColumn
        '
        Me.VrthvhcIDDataGridViewTextBoxColumn.DataPropertyName = "vrth_vhcID"
        Me.VrthvhcIDDataGridViewTextBoxColumn.HeaderText = "vrth_vhcID"
        Me.VrthvhcIDDataGridViewTextBoxColumn.Name = "VrthvhcIDDataGridViewTextBoxColumn"
        Me.VrthvhcIDDataGridViewTextBoxColumn.Visible = False
        '
        'VrthexpdateDataGridViewTextBoxColumn
        '
        Me.VrthexpdateDataGridViewTextBoxColumn.DataPropertyName = "vrth_expdate"
        Me.VrthexpdateDataGridViewTextBoxColumn.HeaderText = "Road Tax Exipred On"
        Me.VrthexpdateDataGridViewTextBoxColumn.Name = "VrthexpdateDataGridViewTextBoxColumn"
        Me.VrthexpdateDataGridViewTextBoxColumn.ReadOnly = True
        Me.VrthexpdateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.VrthexpdateDataGridViewTextBoxColumn.Width = 132
        '
        'VrthnoteDataGridViewTextBoxColumn
        '
        Me.VrthnoteDataGridViewTextBoxColumn.DataPropertyName = "vrth_note"
        Me.VrthnoteDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.VrthnoteDataGridViewTextBoxColumn.Name = "VrthnoteDataGridViewTextBoxColumn"
        Me.VrthnoteDataGridViewTextBoxColumn.ReadOnly = True
        Me.VrthnoteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.VrthnoteDataGridViewTextBoxColumn.Width = 230
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(298, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "&Quit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Vehicle_RoadTax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 594)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.vhc_platetext)
        Me.Controls.Add(Me.vhc_IDtextbox)
        Me.Controls.Add(Me.vhc_rt_date)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Vehicle_RoadTax"
        Me.Text = "Road Tax Management"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.VehiclerthistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vhc_platetext As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents dateToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents vhc_IDtextbox As TextBox
    Friend WithEvents expiredNotetoolstips As ToolStripStatusLabel
    Friend WithEvents vhc_rt_date As TextBox
    Friend WithEvents CBSDataSet As CBSDataSet
    Friend WithEvents VehiclerthistoryBindingSource As BindingSource
    Friend WithEvents Vehicle_rt_historyTableAdapter As CBSDataSetTableAdapters.vehicle_rt_historyTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents VrthIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VrthvhcIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VrthexpdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VrthnoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
