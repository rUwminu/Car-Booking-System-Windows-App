<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class card_display
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.card_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.card_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.card_remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.card_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.card_active = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"All", "Petrol", "Touch & GO"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(199, 28)
        Me.ComboBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Load"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.card_type, Me.card_no, Me.card_remark, Me.card_ID, Me.card_active})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 22
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(721, 279)
        Me.DataGridView1.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 46)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(140, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Include obsolete record."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(637, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 28)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "&Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'card_type
        '
        Me.card_type.DataPropertyName = "card_type"
        Me.card_type.HeaderText = "Card Type"
        Me.card_type.Name = "card_type"
        Me.card_type.ReadOnly = True
        Me.card_type.Width = 150
        '
        'card_no
        '
        Me.card_no.DataPropertyName = "card_no"
        Me.card_no.HeaderText = "Card No."
        Me.card_no.Name = "card_no"
        Me.card_no.ReadOnly = True
        Me.card_no.Width = 250
        '
        'card_remark
        '
        Me.card_remark.DataPropertyName = "card_remark"
        Me.card_remark.HeaderText = "Remark"
        Me.card_remark.Name = "card_remark"
        Me.card_remark.ReadOnly = True
        Me.card_remark.Width = 300
        '
        'card_ID
        '
        Me.card_ID.DataPropertyName = "card_ID"
        Me.card_ID.HeaderText = "ID"
        Me.card_ID.Name = "card_ID"
        Me.card_ID.ReadOnly = True
        Me.card_ID.Visible = False
        '
        'card_active
        '
        Me.card_active.DataPropertyName = "card_active"
        Me.card_active.HeaderText = "Active"
        Me.card_active.Name = "card_active"
        Me.card_active.ReadOnly = True
        Me.card_active.Visible = False
        '
        'card_display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 348)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "card_display"
        Me.Text = "Display Card"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents card_type As DataGridViewTextBoxColumn
    Friend WithEvents card_no As DataGridViewTextBoxColumn
    Friend WithEvents card_remark As DataGridViewTextBoxColumn
    Friend WithEvents card_ID As DataGridViewTextBoxColumn
    Friend WithEvents card_active As DataGridViewTextBoxColumn
End Class
