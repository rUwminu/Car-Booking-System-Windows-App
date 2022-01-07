<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehicle_Insurance
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dateToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.expiredNotetoolstips = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VehiclerthistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBSDataSet = New CBS.CBSDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Vehicle_rt_historyTableAdapter = New CBS.CBSDataSetTableAdapters.vehicle_rt_historyTableAdapter()
        Me.vhc_platetext = New System.Windows.Forms.TextBox()
        Me.vhc_IDtextbox = New System.Windows.Forms.TextBox()
        Me.vhc_rt_date = New System.Windows.Forms.TextBox()
        Me.vhci_vhcID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhci_expdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhci_note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VrthIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiclerthistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(310, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "&Quit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.dateToolStripStatusLabel, Me.expiredNotetoolstips})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 566)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(406, 26)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(57, 21)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Registration / Plate No :"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vhci_vhcID, Me.vhci_expdate, Me.vhci_note, Me.VrthIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VehiclerthistoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 22
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(385, 483)
        Me.DataGridView1.TabIndex = 11
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Renew"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Vehicle_rt_historyTableAdapter
        '
        Me.Vehicle_rt_historyTableAdapter.ClearBeforeFill = True
        '
        'vhc_platetext
        '
        Me.vhc_platetext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhc_platetext.Location = New System.Drawing.Point(205, 12)
        Me.vhc_platetext.Name = "vhc_platetext"
        Me.vhc_platetext.ReadOnly = True
        Me.vhc_platetext.Size = New System.Drawing.Size(179, 26)
        Me.vhc_platetext.TabIndex = 12
        Me.vhc_platetext.TabStop = False
        '
        'vhc_IDtextbox
        '
        Me.vhc_IDtextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhc_IDtextbox.Location = New System.Drawing.Point(205, 16)
        Me.vhc_IDtextbox.Name = "vhc_IDtextbox"
        Me.vhc_IDtextbox.ReadOnly = True
        Me.vhc_IDtextbox.Size = New System.Drawing.Size(46, 14)
        Me.vhc_IDtextbox.TabIndex = 10
        Me.vhc_IDtextbox.TabStop = False
        '
        'vhc_rt_date
        '
        Me.vhc_rt_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhc_rt_date.Location = New System.Drawing.Point(257, 15)
        Me.vhc_rt_date.Name = "vhc_rt_date"
        Me.vhc_rt_date.ReadOnly = True
        Me.vhc_rt_date.Size = New System.Drawing.Size(46, 14)
        Me.vhc_rt_date.TabIndex = 15
        Me.vhc_rt_date.TabStop = False
        '
        'vhci_vhcID
        '
        Me.vhci_vhcID.DataPropertyName = "vhci_vhcID"
        Me.vhci_vhcID.HeaderText = "vhci_vhcID"
        Me.vhci_vhcID.Name = "vhci_vhcID"
        Me.vhci_vhcID.ReadOnly = True
        Me.vhci_vhcID.Visible = False
        '
        'vhci_expdate
        '
        Me.vhci_expdate.DataPropertyName = "vhci_expdate"
        Me.vhci_expdate.HeaderText = "Road Tax Expired On"
        Me.vhci_expdate.Name = "vhci_expdate"
        Me.vhci_expdate.ReadOnly = True
        Me.vhci_expdate.Width = 132
        '
        'vhci_note
        '
        Me.vhci_note.DataPropertyName = "vhci_note"
        Me.vhci_note.HeaderText = "Remark"
        Me.vhci_note.Name = "vhci_note"
        Me.vhci_note.ReadOnly = True
        Me.vhci_note.Width = 225
        '
        'VrthIDDataGridViewTextBoxColumn
        '
        Me.VrthIDDataGridViewTextBoxColumn.DataPropertyName = "vhci_ID"
        Me.VrthIDDataGridViewTextBoxColumn.HeaderText = "vrth_ID"
        Me.VrthIDDataGridViewTextBoxColumn.Name = "VrthIDDataGridViewTextBoxColumn"
        '
        'Vehicle_Insurance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 592)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.vhc_platetext)
        Me.Controls.Add(Me.vhc_IDtextbox)
        Me.Controls.Add(Me.vhc_rt_date)
        Me.Name = "Vehicle_Insurance"
        Me.Text = "Vehicle_Insurance"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiclerthistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents dateToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents expiredNotetoolstips As ToolStripStatusLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents vhci_ID As DataGridViewTextBoxColumn
    Friend WithEvents VehiclerthistoryBindingSource As BindingSource
    Friend WithEvents CBSDataSet As CBSDataSet
    Friend WithEvents Button1 As Button
    Friend WithEvents Vehicle_rt_historyTableAdapter As CBSDataSetTableAdapters.vehicle_rt_historyTableAdapter
    Friend WithEvents vhc_platetext As TextBox
    Friend WithEvents vhc_IDtextbox As TextBox
    Friend WithEvents vhc_rt_date As TextBox
    Friend WithEvents vhci_vhcID As DataGridViewTextBoxColumn
    Friend WithEvents vhci_expdate As DataGridViewTextBoxColumn
    Friend WithEvents vhci_note As DataGridViewTextBoxColumn
    Friend WithEvents VrthIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
