<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class key_status_view
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
        Me.listGroupBox = New System.Windows.Forms.GroupBox()
        Me.Labelshow = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.vhc_PLateNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_key_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PlateNoLabel1 = New System.Windows.Forms.Label()
        Me.ChgStatusLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.ButtonShowList = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.RefreshButton3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listGroupBox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listGroupBox
        '
        Me.listGroupBox.Controls.Add(Me.Labelshow)
        Me.listGroupBox.Controls.Add(Me.DataGridView1)
        Me.listGroupBox.Location = New System.Drawing.Point(22, 12)
        Me.listGroupBox.Name = "listGroupBox"
        Me.listGroupBox.Size = New System.Drawing.Size(399, 354)
        Me.listGroupBox.TabIndex = 3
        Me.listGroupBox.TabStop = False
        Me.listGroupBox.Text = "Vehicle key status :"
        '
        'Labelshow
        '
        Me.Labelshow.AutoSize = True
        Me.Labelshow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelshow.Location = New System.Drawing.Point(3, 329)
        Me.Labelshow.Name = "Labelshow"
        Me.Labelshow.Size = New System.Drawing.Size(311, 13)
        Me.Labelshow.TabIndex = 1
        Me.Labelshow.Text = "** Select a record and change key status, *Return or Take Key*."
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vhc_PLateNo, Me.vhc_brand, Me.vhc_model, Me.vhc_key_status})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(387, 296)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(531, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Take Key"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PlateNoLabel1
        '
        Me.PlateNoLabel1.AutoSize = True
        Me.PlateNoLabel1.Location = New System.Drawing.Point(25, 381)
        Me.PlateNoLabel1.Name = "PlateNoLabel1"
        Me.PlateNoLabel1.Size = New System.Drawing.Size(0, 13)
        Me.PlateNoLabel1.TabIndex = 5
        '
        'ChgStatusLabel
        '
        Me.ChgStatusLabel.AutoSize = True
        Me.ChgStatusLabel.Location = New System.Drawing.Point(567, 381)
        Me.ChgStatusLabel.Name = "ChgStatusLabel"
        Me.ChgStatusLabel.Size = New System.Drawing.Size(39, 13)
        Me.ChgStatusLabel.TabIndex = 6
        Me.ChgStatusLabel.Text = "Label1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(531, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Return Key"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(444, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(444, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Employee ID :"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(567, 407)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(0, 13)
        Me.LabelDate.TabIndex = 12
        '
        'ButtonShowList
        '
        Me.ButtonShowList.Location = New System.Drawing.Point(447, 343)
        Me.ButtonShowList.Name = "ButtonShowList"
        Me.ButtonShowList.Size = New System.Drawing.Size(159, 23)
        Me.ButtonShowList.TabIndex = 13
        Me.ButtonShowList.Text = "View Record"
        Me.ButtonShowList.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(447, 120)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(159, 21)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.Text = "Select Employee ID -------->>"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(447, 70)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.ReadOnly = True
        Me.TextBoxName.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxName.TabIndex = 10
        '
        'RefreshButton3
        '
        Me.RefreshButton3.Location = New System.Drawing.Point(531, 314)
        Me.RefreshButton3.Name = "RefreshButton3"
        Me.RefreshButton3.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton3.TabIndex = 15
        Me.RefreshButton3.Text = "Refresh"
        Me.RefreshButton3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(444, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Pick A Key First"
        Me.Label3.Visible = False
        '
        'key_status_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RefreshButton3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonShowList)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ChgStatusLabel)
        Me.Controls.Add(Me.PlateNoLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.listGroupBox)
        Me.Name = "key_status_view"
        Me.Text = "Key Management List"
        Me.listGroupBox.ResumeLayout(False)
        Me.listGroupBox.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listGroupBox As GroupBox
    Friend WithEvents Labelshow As Label
    Protected WithEvents DataGridView1 As DataGridView
    Friend WithEvents vhc_PLateNo As DataGridViewTextBoxColumn
    Friend WithEvents vhc_brand As DataGridViewTextBoxColumn
    Friend WithEvents vhc_model As DataGridViewTextBoxColumn
    Friend WithEvents vhc_key_status As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents PlateNoLabel1 As Label
    Friend WithEvents ChgStatusLabel As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents ButtonShowList As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents RefreshButton3 As Button
    Friend WithEvents Label3 As Label
End Class
