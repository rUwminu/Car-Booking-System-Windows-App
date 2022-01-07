<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehicle_repair
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
        Me.vhcrp_vhcPlate = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.vhcrp_fault01 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vhcrp_fault02 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.vhcrp_fault03 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.vhcrp_desc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.repair_vhcID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Tag = ""
        Me.Label1.Text = "Registration NO:"
        '
        'vhcrp_vhcPlate
        '
        Me.vhcrp_vhcPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhcrp_vhcPlate.Location = New System.Drawing.Point(144, 22)
        Me.vhcrp_vhcPlate.Name = "vhcrp_vhcPlate"
        Me.vhcrp_vhcPlate.ReadOnly = True
        Me.vhcrp_vhcPlate.Size = New System.Drawing.Size(128, 26)
        Me.vhcrp_vhcPlate.TabIndex = 8
        Me.vhcrp_vhcPlate.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(343, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(125, 26)
        Me.DateTimePicker1.TabIndex = 4
        Me.DateTimePicker1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(289, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Tag = ""
        Me.Label2.Text = "Date:"
        '
        'vhcrp_fault01
        '
        Me.vhcrp_fault01.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhcrp_fault01.Location = New System.Drawing.Point(171, 81)
        Me.vhcrp_fault01.Name = "vhcrp_fault01"
        Me.vhcrp_fault01.Size = New System.Drawing.Size(249, 26)
        Me.vhcrp_fault01.TabIndex = 0
        Me.vhcrp_fault01.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Tag = ""
        Me.Label3.Text = "Faulty Parts 01:"
        '
        'vhcrp_fault02
        '
        Me.vhcrp_fault02.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhcrp_fault02.Location = New System.Drawing.Point(171, 113)
        Me.vhcrp_fault02.Name = "vhcrp_fault02"
        Me.vhcrp_fault02.Size = New System.Drawing.Size(249, 26)
        Me.vhcrp_fault02.TabIndex = 1
        Me.vhcrp_fault02.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Tag = ""
        Me.Label4.Text = "Faulty Parts 02:"
        '
        'vhcrp_fault03
        '
        Me.vhcrp_fault03.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhcrp_fault03.Location = New System.Drawing.Point(171, 145)
        Me.vhcrp_fault03.Name = "vhcrp_fault03"
        Me.vhcrp_fault03.Size = New System.Drawing.Size(249, 26)
        Me.vhcrp_fault03.TabIndex = 2
        Me.vhcrp_fault03.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Tag = ""
        Me.Label5.Text = "Faulty Parts 03:"
        '
        'vhcrp_desc
        '
        Me.vhcrp_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhcrp_desc.Location = New System.Drawing.Point(171, 179)
        Me.vhcrp_desc.Multiline = True
        Me.vhcrp_desc.Name = "vhcrp_desc"
        Me.vhcrp_desc.Size = New System.Drawing.Size(249, 81)
        Me.vhcrp_desc.TabIndex = 3
        Me.vhcrp_desc.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Tag = ""
        Me.Label6.Text = "Fault Description:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(309, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(400, 283)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 35)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "&CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Tag = ""
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Tag = ""
        Me.Label8.Text = "*"
        '
        'repair_vhcID
        '
        Me.repair_vhcID.Location = New System.Drawing.Point(144, 25)
        Me.repair_vhcID.Name = "repair_vhcID"
        Me.repair_vhcID.Size = New System.Drawing.Size(32, 20)
        Me.repair_vhcID.TabIndex = 16
        '
        'Vehicle_repair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 334)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.vhcrp_desc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.vhcrp_fault03)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.vhcrp_fault02)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.vhcrp_fault01)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.vhcrp_vhcPlate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.repair_vhcID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Vehicle_repair"
        Me.Text = "Vehicle Repair"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents vhcrp_vhcPlate As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents vhcrp_fault01 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents vhcrp_fault02 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents vhcrp_fault03 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents vhcrp_desc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents repair_vhcID As TextBox
End Class
