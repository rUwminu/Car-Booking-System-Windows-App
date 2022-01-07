<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vehicle_repair_History
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.vhcrp_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcrp_faultpart01 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcrp_faultpart02 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcrp_faultpart03 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcrp_remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcrp_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vhcrp_DoneRpDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcrp_DoneRpNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.vhcrph_vhcplate = New System.Windows.Forms.TextBox()
        Me.repairh_vhcID = New System.Windows.Forms.TextBox()
        Me.LabelLorry = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registration NO:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vhcrp_date, Me.vhcrp_faultpart01, Me.vhcrp_faultpart02, Me.vhcrp_faultpart03, Me.vhcrp_remark, Me.vhcrp_status, Me.Vhcrp_DoneRpDate, Me.vhcrp_DoneRpNote})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 22
        Me.DataGridView1.Size = New System.Drawing.Size(873, 330)
        Me.DataGridView1.TabIndex = 2
        '
        'vhcrp_date
        '
        Me.vhcrp_date.DataPropertyName = "vhcrp_date"
        Me.vhcrp_date.HeaderText = "Date"
        Me.vhcrp_date.Name = "vhcrp_date"
        Me.vhcrp_date.ReadOnly = True
        Me.vhcrp_date.Width = 90
        '
        'vhcrp_faultpart01
        '
        Me.vhcrp_faultpart01.DataPropertyName = "vhcrp_faultpart01"
        Me.vhcrp_faultpart01.HeaderText = "Fault Part 01"
        Me.vhcrp_faultpart01.Name = "vhcrp_faultpart01"
        Me.vhcrp_faultpart01.ReadOnly = True
        '
        'vhcrp_faultpart02
        '
        Me.vhcrp_faultpart02.DataPropertyName = "vhcrp_faultpart02"
        Me.vhcrp_faultpart02.HeaderText = "Fault Part 02"
        Me.vhcrp_faultpart02.Name = "vhcrp_faultpart02"
        Me.vhcrp_faultpart02.ReadOnly = True
        '
        'vhcrp_faultpart03
        '
        Me.vhcrp_faultpart03.DataPropertyName = "vhcrp_faultpart03"
        Me.vhcrp_faultpart03.HeaderText = "Fault Part 03"
        Me.vhcrp_faultpart03.Name = "vhcrp_faultpart03"
        Me.vhcrp_faultpart03.ReadOnly = True
        '
        'vhcrp_remark
        '
        Me.vhcrp_remark.DataPropertyName = "vhcrp_remark"
        Me.vhcrp_remark.HeaderText = "Fault Description"
        Me.vhcrp_remark.Name = "vhcrp_remark"
        Me.vhcrp_remark.ReadOnly = True
        Me.vhcrp_remark.Width = 150
        '
        'vhcrp_status
        '
        Me.vhcrp_status.DataPropertyName = "vhcrp_status"
        Me.vhcrp_status.HeaderText = "Status"
        Me.vhcrp_status.Name = "vhcrp_status"
        Me.vhcrp_status.ReadOnly = True
        Me.vhcrp_status.Width = 60
        '
        'Vhcrp_DoneRpDate
        '
        Me.Vhcrp_DoneRpDate.DataPropertyName = "Vhcrp_DoneRpDate"
        Me.Vhcrp_DoneRpDate.HeaderText = "Repaired Date"
        Me.Vhcrp_DoneRpDate.Name = "Vhcrp_DoneRpDate"
        Me.Vhcrp_DoneRpDate.ReadOnly = True
        Me.Vhcrp_DoneRpDate.Width = 90
        '
        'vhcrp_DoneRpNote
        '
        Me.vhcrp_DoneRpNote.DataPropertyName = "vhcrp_DoneRpNote"
        Me.vhcrp_DoneRpNote.HeaderText = "Repaired Note"
        Me.vhcrp_DoneRpNote.Name = "vhcrp_DoneRpNote"
        Me.vhcrp_DoneRpNote.ReadOnly = True
        Me.vhcrp_DoneRpNote.Width = 200
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(792, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'vhcrph_vhcplate
        '
        Me.vhcrph_vhcplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhcrph_vhcplate.Location = New System.Drawing.Point(144, 22)
        Me.vhcrph_vhcplate.Name = "vhcrph_vhcplate"
        Me.vhcrph_vhcplate.ReadOnly = True
        Me.vhcrph_vhcplate.Size = New System.Drawing.Size(147, 26)
        Me.vhcrph_vhcplate.TabIndex = 0
        '
        'repairh_vhcID
        '
        Me.repairh_vhcID.Location = New System.Drawing.Point(144, 25)
        Me.repairh_vhcID.Name = "repairh_vhcID"
        Me.repairh_vhcID.Size = New System.Drawing.Size(29, 20)
        Me.repairh_vhcID.TabIndex = 4
        '
        'LabelLorry
        '
        Me.LabelLorry.AutoSize = True
        Me.LabelLorry.Location = New System.Drawing.Point(312, 28)
        Me.LabelLorry.Name = "LabelLorry"
        Me.LabelLorry.Size = New System.Drawing.Size(0, 13)
        Me.LabelLorry.TabIndex = 8
        Me.LabelLorry.Visible = False
        '
        'vehicle_repair_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelLorry)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vhcrph_vhcplate)
        Me.Controls.Add(Me.repairh_vhcID)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "vehicle_repair_History"
        Me.Text = "Repair History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents vhcrp_date As DataGridViewTextBoxColumn
    Friend WithEvents vhcrp_faultpart01 As DataGridViewTextBoxColumn
    Friend WithEvents vhcrp_faultpart02 As DataGridViewTextBoxColumn
    Friend WithEvents vhcrp_faultpart03 As DataGridViewTextBoxColumn
    Friend WithEvents vhcrp_remark As DataGridViewTextBoxColumn
    Friend WithEvents vhcrp_status As DataGridViewTextBoxColumn
    Friend WithEvents Vhcrp_DoneRpDate As DataGridViewTextBoxColumn
    Friend WithEvents vhcrp_DoneRpNote As DataGridViewTextBoxColumn
    Friend WithEvents vhcrph_vhcplate As TextBox
    Friend WithEvents repairh_vhcID As TextBox
    Friend WithEvents LabelLorry As Label
End Class
