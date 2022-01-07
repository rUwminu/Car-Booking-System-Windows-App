<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vehicle_bty_history
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
        Me.btyh_vhcPlate = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.vhcacc_btyh_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcacc_btyh_wrty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btyh_vhcID = New System.Windows.Forms.TextBox()
        Me.LabelLorry = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registration NO:"
        '
        'btyh_vhcPlate
        '
        Me.btyh_vhcPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btyh_vhcPlate.Location = New System.Drawing.Point(144, 41)
        Me.btyh_vhcPlate.Name = "btyh_vhcPlate"
        Me.btyh_vhcPlate.ReadOnly = True
        Me.btyh_vhcPlate.Size = New System.Drawing.Size(116, 26)
        Me.btyh_vhcPlate.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeight = 33
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vhcacc_btyh_date, Me.vhcacc_btyh_wrty})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 22
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(300, 383)
        Me.DataGridView1.TabIndex = 3
        '
        'vhcacc_btyh_date
        '
        Me.vhcacc_btyh_date.DataPropertyName = "vhcacc_btyh_date"
        Me.vhcacc_btyh_date.HeaderText = "Date Change"
        Me.vhcacc_btyh_date.Name = "vhcacc_btyh_date"
        Me.vhcacc_btyh_date.ReadOnly = True
        Me.vhcacc_btyh_date.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'vhcacc_btyh_wrty
        '
        Me.vhcacc_btyh_wrty.DataPropertyName = "vhcacc_btyh_wrty"
        Me.vhcacc_btyh_wrty.HeaderText = "Warranty Period (Month)"
        Me.vhcacc_btyh_wrty.Name = "vhcacc_btyh_wrty"
        Me.vhcacc_btyh_wrty.ReadOnly = True
        Me.vhcacc_btyh_wrty.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.vhcacc_btyh_wrty.Width = 190
        '
        'btyh_vhcID
        '
        Me.btyh_vhcID.Location = New System.Drawing.Point(159, 41)
        Me.btyh_vhcID.Name = "btyh_vhcID"
        Me.btyh_vhcID.Size = New System.Drawing.Size(24, 20)
        Me.btyh_vhcID.TabIndex = 4
        '
        'LabelLorry
        '
        Me.LabelLorry.AutoSize = True
        Me.LabelLorry.Location = New System.Drawing.Point(24, 15)
        Me.LabelLorry.Name = "LabelLorry"
        Me.LabelLorry.Size = New System.Drawing.Size(0, 13)
        Me.LabelLorry.TabIndex = 9
        '
        'vehicle_bty_history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelLorry)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btyh_vhcPlate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btyh_vhcID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "vehicle_bty_history"
        Me.Text = "vehicle Battery Change History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btyh_vhcPlate As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents vhcacc_btyh_date As DataGridViewTextBoxColumn
    Friend WithEvents vhcacc_btyh_wrty As DataGridViewTextBoxColumn
    Friend WithEvents btyh_vhcID As TextBox
    Friend WithEvents LabelLorry As Label
End Class
