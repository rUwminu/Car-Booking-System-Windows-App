<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vehicle_tyreHistory
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
        Me.tyreh_vhcPlate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.vhcacc_tyreh_tyreChg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcacc_tyreh_brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcacc_tyreh_mfgdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcacc_tyreh_tyreloc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tyre_vhcID = New System.Windows.Forms.TextBox()
        Me.LabelLorry = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tyreh_vhcPlate
        '
        Me.tyreh_vhcPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tyreh_vhcPlate.Location = New System.Drawing.Point(148, 27)
        Me.tyreh_vhcPlate.Name = "tyreh_vhcPlate"
        Me.tyreh_vhcPlate.ReadOnly = True
        Me.tyreh_vhcPlate.Size = New System.Drawing.Size(157, 26)
        Me.tyreh_vhcPlate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registration NO :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeight = 26
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vhcacc_tyreh_tyreChg, Me.vhcacc_tyreh_brand, Me.vhcacc_tyreh_mfgdt, Me.vhcacc_tyreh_tyreloc})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 22
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(531, 373)
        Me.DataGridView1.TabIndex = 2
        Me.DataGridView1.TabStop = False
        '
        'vhcacc_tyreh_tyreChg
        '
        Me.vhcacc_tyreh_tyreChg.DataPropertyName = "vhcacc_tyreh_tyreChg"
        Me.vhcacc_tyreh_tyreChg.HeaderText = "Change Date"
        Me.vhcacc_tyreh_tyreChg.Name = "vhcacc_tyreh_tyreChg"
        Me.vhcacc_tyreh_tyreChg.ReadOnly = True
        Me.vhcacc_tyreh_tyreChg.Width = 120
        '
        'vhcacc_tyreh_brand
        '
        Me.vhcacc_tyreh_brand.DataPropertyName = "vhcacc_tyreh_brand"
        Me.vhcacc_tyreh_brand.HeaderText = "Tyre Brand"
        Me.vhcacc_tyreh_brand.Name = "vhcacc_tyreh_brand"
        Me.vhcacc_tyreh_brand.ReadOnly = True
        Me.vhcacc_tyreh_brand.Width = 140
        '
        'vhcacc_tyreh_mfgdt
        '
        Me.vhcacc_tyreh_mfgdt.DataPropertyName = "vhcacc_tyreh_mfgdt"
        Me.vhcacc_tyreh_mfgdt.HeaderText = "Tyre MfgDate"
        Me.vhcacc_tyreh_mfgdt.Name = "vhcacc_tyreh_mfgdt"
        Me.vhcacc_tyreh_mfgdt.ReadOnly = True
        '
        'vhcacc_tyreh_tyreloc
        '
        Me.vhcacc_tyreh_tyreloc.DataPropertyName = "vhcacc_tyreh_tyreloc"
        Me.vhcacc_tyreh_tyreloc.HeaderText = "Tyre Place"
        Me.vhcacc_tyreh_tyreloc.Name = "vhcacc_tyreh_tyreloc"
        Me.vhcacc_tyreh_tyreloc.ReadOnly = True
        Me.vhcacc_tyreh_tyreloc.Width = 150
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(445, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tyre_vhcID
        '
        Me.tyre_vhcID.Location = New System.Drawing.Point(148, 27)
        Me.tyre_vhcID.Name = "tyre_vhcID"
        Me.tyre_vhcID.Size = New System.Drawing.Size(33, 20)
        Me.tyre_vhcID.TabIndex = 4
        '
        'LabelLorry
        '
        Me.LabelLorry.AutoSize = True
        Me.LabelLorry.Location = New System.Drawing.Point(13, 9)
        Me.LabelLorry.Name = "LabelLorry"
        Me.LabelLorry.Size = New System.Drawing.Size(0, 13)
        Me.LabelLorry.TabIndex = 8
        '
        'vehicle_tyreHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 449)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelLorry)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tyreh_vhcPlate)
        Me.Controls.Add(Me.tyre_vhcID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "vehicle_tyreHistory"
        Me.Text = "Tyre change History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tyreh_vhcPlate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents vhcacc_tyreh_tyreChg As DataGridViewTextBoxColumn
    Friend WithEvents vhcacc_tyreh_brand As DataGridViewTextBoxColumn
    Friend WithEvents vhcacc_tyreh_mfgdt As DataGridViewTextBoxColumn
    Friend WithEvents vhcacc_tyreh_tyreloc As DataGridViewTextBoxColumn
    Friend WithEvents tyre_vhcID As TextBox
    Friend WithEvents LabelLorry As Label
End Class
