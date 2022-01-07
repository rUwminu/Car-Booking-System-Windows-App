<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class card_manage_return
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bkc_bkid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bkc_bkctype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bkc_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bkc_ID_text = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bkc_cardno_text = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bkc_Type_text = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bkc_PlateNo_text = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bkc_bkID_text = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.card_ID = New System.Windows.Forms.TextBox()
        Me.bkc_datetaken_text = New System.Windows.Forms.TextBox()
        Me.bkc_receiveby_text = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bkc_ID_text)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bkc_cardno_text)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bkc_Type_text)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bkc_PlateNo_text)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bkc_bkID_text)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.card_ID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bkc_datetaken_text)
        Me.SplitContainer1.Panel2.Controls.Add(Me.bkc_receiveby_text)
        Me.SplitContainer1.Size = New System.Drawing.Size(576, 292)
        Me.SplitContainer1.SplitterDistance = 169
        Me.SplitContainer1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Booking No:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeight = 25
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bkc_bkid, Me.bkc_bkctype, Me.bkc_id})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 4
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(161, 208)
        Me.DataGridView1.TabIndex = 5
        '
        'bkc_bkid
        '
        Me.bkc_bkid.HeaderText = "Booking"
        Me.bkc_bkid.Name = "bkc_bkid"
        Me.bkc_bkid.ReadOnly = True
        Me.bkc_bkid.Width = 60
        '
        'bkc_bkctype
        '
        Me.bkc_bkctype.HeaderText = "Card Type"
        Me.bkc_bkctype.Name = "bkc_bkctype"
        Me.bkc_bkctype.ReadOnly = True
        '
        'bkc_id
        '
        Me.bkc_id.HeaderText = "ID"
        Me.bkc_id.Name = "bkc_id"
        Me.bkc_id.ReadOnly = True
        Me.bkc_id.Visible = False
        '
        'bkc_ID_text
        '
        Me.bkc_ID_text.Location = New System.Drawing.Point(118, 215)
        Me.bkc_ID_text.Name = "bkc_ID_text"
        Me.bkc_ID_text.Size = New System.Drawing.Size(20, 20)
        Me.bkc_ID_text.TabIndex = 3
        Me.bkc_ID_text.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(298, 245)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 38)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "&Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Date Taken:"
        '
        'bkc_cardno_text
        '
        Me.bkc_cardno_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkc_cardno_text.Location = New System.Drawing.Point(143, 170)
        Me.bkc_cardno_text.Name = "bkc_cardno_text"
        Me.bkc_cardno_text.ReadOnly = True
        Me.bkc_cardno_text.Size = New System.Drawing.Size(229, 26)
        Me.bkc_cardno_text.TabIndex = 14
        Me.bkc_cardno_text.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(188, 245)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "&Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(143, 42)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(162, 26)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Date Return:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Card No:"
        '
        'bkc_Type_text
        '
        Me.bkc_Type_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkc_Type_text.Location = New System.Drawing.Point(143, 138)
        Me.bkc_Type_text.Name = "bkc_Type_text"
        Me.bkc_Type_text.ReadOnly = True
        Me.bkc_Type_text.Size = New System.Drawing.Size(119, 26)
        Me.bkc_Type_text.TabIndex = 8
        Me.bkc_Type_text.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Card Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Card Request (Return)"
        '
        'bkc_PlateNo_text
        '
        Me.bkc_PlateNo_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkc_PlateNo_text.Location = New System.Drawing.Point(143, 106)
        Me.bkc_PlateNo_text.Name = "bkc_PlateNo_text"
        Me.bkc_PlateNo_text.ReadOnly = True
        Me.bkc_PlateNo_text.Size = New System.Drawing.Size(119, 26)
        Me.bkc_PlateNo_text.TabIndex = 5
        Me.bkc_PlateNo_text.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Registration No:"
        '
        'bkc_bkID_text
        '
        Me.bkc_bkID_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkc_bkID_text.Location = New System.Drawing.Point(143, 74)
        Me.bkc_bkID_text.Name = "bkc_bkID_text"
        Me.bkc_bkID_text.ReadOnly = True
        Me.bkc_bkID_text.Size = New System.Drawing.Size(119, 26)
        Me.bkc_bkID_text.TabIndex = 3
        Me.bkc_bkID_text.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Booking No:"
        '
        'card_ID
        '
        Me.card_ID.Location = New System.Drawing.Point(143, 176)
        Me.card_ID.Name = "card_ID"
        Me.card_ID.Size = New System.Drawing.Size(32, 20)
        Me.card_ID.TabIndex = 15
        Me.card_ID.TabStop = False
        '
        'bkc_datetaken_text
        '
        Me.bkc_datetaken_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkc_datetaken_text.Location = New System.Drawing.Point(142, 202)
        Me.bkc_datetaken_text.Name = "bkc_datetaken_text"
        Me.bkc_datetaken_text.ReadOnly = True
        Me.bkc_datetaken_text.Size = New System.Drawing.Size(230, 26)
        Me.bkc_datetaken_text.TabIndex = 17
        Me.bkc_datetaken_text.TabStop = False
        '
        'bkc_receiveby_text
        '
        Me.bkc_receiveby_text.Location = New System.Drawing.Point(143, 205)
        Me.bkc_receiveby_text.Name = "bkc_receiveby_text"
        Me.bkc_receiveby_text.Size = New System.Drawing.Size(62, 20)
        Me.bkc_receiveby_text.TabIndex = 19
        Me.bkc_receiveby_text.TabStop = False
        '
        'card_manage_return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 292)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "card_manage_return"
        Me.Text = "Manage Card"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bkc_Type_text As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bkc_PlateNo_text As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bkc_bkID_text As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bkc_cardno_text As TextBox
    Friend WithEvents bkc_datetaken_text As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents card_ID As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents bkc_ID_text As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bkc_bkid As DataGridViewTextBoxColumn
    Friend WithEvents bkc_bkctype As DataGridViewTextBoxColumn
    Friend WithEvents bkc_id As DataGridViewTextBoxColumn
    Friend WithEvents bkc_receiveby_text As TextBox
End Class
