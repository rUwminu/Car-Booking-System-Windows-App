<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vehicle_engOil_History
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vhcoil_vhcplateno = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.vhcacc_oil_meter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcacc_oil_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.engoil_vhcID = New System.Windows.Forms.TextBox()
        Me.LabelLorry = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Registration No :"
        '
        'vhcoil_vhcplateno
        '
        Me.vhcoil_vhcplateno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhcoil_vhcplateno.Location = New System.Drawing.Point(145, 39)
        Me.vhcoil_vhcplateno.Name = "vhcoil_vhcplateno"
        Me.vhcoil_vhcplateno.ReadOnly = True
        Me.vhcoil_vhcplateno.Size = New System.Drawing.Size(120, 26)
        Me.vhcoil_vhcplateno.TabIndex = 2
        Me.vhcoil_vhcplateno.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeight = 33
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vhcacc_oil_meter, Me.vhcacc_oil_date})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 22
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(315, 393)
        Me.DataGridView1.TabIndex = 4
        '
        'vhcacc_oil_meter
        '
        Me.vhcacc_oil_meter.DataPropertyName = "vhcacc_oil_meter"
        Me.vhcacc_oil_meter.HeaderText = "Oil Change (KM)"
        Me.vhcacc_oil_meter.Name = "vhcacc_oil_meter"
        Me.vhcacc_oil_meter.ReadOnly = True
        Me.vhcacc_oil_meter.Width = 140
        '
        'vhcacc_oil_date
        '
        Me.vhcacc_oil_date.DataPropertyName = "vhcacc_oil_date"
        Me.vhcacc_oil_date.HeaderText = "Date Change"
        Me.vhcacc_oil_date.Name = "vhcacc_oil_date"
        Me.vhcacc_oil_date.ReadOnly = True
        Me.vhcacc_oil_date.Width = 150
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'engoil_vhcID
        '
        Me.engoil_vhcID.Location = New System.Drawing.Point(145, 42)
        Me.engoil_vhcID.Name = "engoil_vhcID"
        Me.engoil_vhcID.Size = New System.Drawing.Size(26, 20)
        Me.engoil_vhcID.TabIndex = 6
        '
        'LabelLorry
        '
        Me.LabelLorry.AutoSize = True
        Me.LabelLorry.Location = New System.Drawing.Point(22, 16)
        Me.LabelLorry.Name = "LabelLorry"
        Me.LabelLorry.Size = New System.Drawing.Size(0, 13)
        Me.LabelLorry.TabIndex = 7
        Me.LabelLorry.Visible = False
        '
        'vehicle_engOil_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 468)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelLorry)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vhcoil_vhcplateno)
        Me.Controls.Add(Me.engoil_vhcID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "vehicle_engOil_History"
        Me.Text = "History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents vhcoil_vhcplateno As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents vhcacc_oil_meter As DataGridViewTextBoxColumn
    Friend WithEvents vhcacc_oil_date As DataGridViewTextBoxColumn
    Friend WithEvents engoil_vhcID As TextBox
    Friend WithEvents LabelLorry As Label
End Class
