<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class security_checkIN
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.secName = New System.Windows.Forms.TextBox()
        Me.secID = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.sc_InMeter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.intime = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.actintime = New System.Windows.Forms.TextBox()
        Me.crmeter = New System.Windows.Forms.TextBox()
        Me.sec_bkID = New System.Windows.Forms.TextBox()
        Me.outmeter = New System.Windows.Forms.TextBox()
        Me.sec_vhcID = New System.Windows.Forms.TextBox()
        Me.LabelEmpName = New System.Windows.Forms.Label()
        Me.LabelEmpID = New System.Windows.Forms.Label()
        Me.LabelPN = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Check By :"
        '
        'secName
        '
        Me.secName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secName.Location = New System.Drawing.Point(107, 9)
        Me.secName.Name = "secName"
        Me.secName.ReadOnly = True
        Me.secName.Size = New System.Drawing.Size(215, 29)
        Me.secName.TabIndex = 1
        Me.secName.TabStop = False
        '
        'secID
        '
        Me.secID.Location = New System.Drawing.Point(137, 17)
        Me.secID.Name = "secID"
        Me.secID.Size = New System.Drawing.Size(35, 20)
        Me.secID.TabIndex = 2
        Me.secID.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy HH:mm:ss"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(177, 239)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(141, 20)
        Me.DateTimePicker1.TabIndex = 3
        Me.DateTimePicker1.TabStop = False
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(17, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(302, 83)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'sc_InMeter
        '
        Me.sc_InMeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_InMeter.Location = New System.Drawing.Point(104, 53)
        Me.sc_InMeter.Name = "sc_InMeter"
        Me.sc_InMeter.Size = New System.Drawing.Size(215, 35)
        Me.sc_InMeter.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Meter :"
        '
        'intime
        '
        Me.intime.Location = New System.Drawing.Point(178, 17)
        Me.intime.Name = "intime"
        Me.intime.Size = New System.Drawing.Size(35, 20)
        Me.intime.TabIndex = 7
        Me.intime.TabStop = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy HH:mm:ss"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(14, 99)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(305, 41)
        Me.DateTimePicker2.TabIndex = 8
        Me.DateTimePicker2.TabStop = False
        '
        'actintime
        '
        Me.actintime.Location = New System.Drawing.Point(219, 17)
        Me.actintime.Name = "actintime"
        Me.actintime.Size = New System.Drawing.Size(35, 20)
        Me.actintime.TabIndex = 9
        Me.actintime.TabStop = False
        '
        'crmeter
        '
        Me.crmeter.BackColor = System.Drawing.SystemColors.Menu
        Me.crmeter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.crmeter.Location = New System.Drawing.Point(17, 243)
        Me.crmeter.Name = "crmeter"
        Me.crmeter.Size = New System.Drawing.Size(100, 13)
        Me.crmeter.TabIndex = 16
        '
        'sec_bkID
        '
        Me.sec_bkID.Location = New System.Drawing.Point(260, 15)
        Me.sec_bkID.Name = "sec_bkID"
        Me.sec_bkID.Size = New System.Drawing.Size(35, 20)
        Me.sec_bkID.TabIndex = 18
        Me.sec_bkID.TabStop = False
        '
        'outmeter
        '
        Me.outmeter.Location = New System.Drawing.Point(118, 63)
        Me.outmeter.Name = "outmeter"
        Me.outmeter.Size = New System.Drawing.Size(25, 20)
        Me.outmeter.TabIndex = 19
        '
        'sec_vhcID
        '
        Me.sec_vhcID.Location = New System.Drawing.Point(149, 63)
        Me.sec_vhcID.Name = "sec_vhcID"
        Me.sec_vhcID.Size = New System.Drawing.Size(25, 20)
        Me.sec_vhcID.TabIndex = 20
        '
        'LabelEmpName
        '
        Me.LabelEmpName.AutoSize = True
        Me.LabelEmpName.Location = New System.Drawing.Point(115, 262)
        Me.LabelEmpName.Name = "LabelEmpName"
        Me.LabelEmpName.Size = New System.Drawing.Size(59, 13)
        Me.LabelEmpName.TabIndex = 37
        Me.LabelEmpName.Text = "Emp Name"
        Me.LabelEmpName.Visible = False
        '
        'LabelEmpID
        '
        Me.LabelEmpID.AutoSize = True
        Me.LabelEmpID.Location = New System.Drawing.Point(61, 262)
        Me.LabelEmpID.Name = "LabelEmpID"
        Me.LabelEmpID.Size = New System.Drawing.Size(39, 13)
        Me.LabelEmpID.TabIndex = 36
        Me.LabelEmpID.Text = "EmpID"
        Me.LabelEmpID.Visible = False
        '
        'LabelPN
        '
        Me.LabelPN.AutoSize = True
        Me.LabelPN.Location = New System.Drawing.Point(20, 262)
        Me.LabelPN.Name = "LabelPN"
        Me.LabelPN.Size = New System.Drawing.Size(22, 13)
        Me.LabelPN.TabIndex = 35
        Me.LabelPN.Text = "PN"
        Me.LabelPN.Visible = False
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(211, 262)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(30, 13)
        Me.LabelDate.TabIndex = 34
        Me.LabelDate.Text = "Date"
        Me.LabelDate.Visible = False
        '
        'security_checkIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 282)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelEmpName)
        Me.Controls.Add(Me.LabelEmpID)
        Me.Controls.Add(Me.LabelPN)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.crmeter)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sc_InMeter)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.secName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.intime)
        Me.Controls.Add(Me.secID)
        Me.Controls.Add(Me.actintime)
        Me.Controls.Add(Me.sec_bkID)
        Me.Controls.Add(Me.outmeter)
        Me.Controls.Add(Me.sec_vhcID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "security_checkIN"
        Me.Text = "Vehicle IN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents secName As TextBox
    Friend WithEvents secID As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents sc_InMeter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents intime As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents actintime As TextBox
    Friend WithEvents crmeter As TextBox
    Friend WithEvents sec_bkID As TextBox
    Friend WithEvents outmeter As TextBox
    Friend WithEvents sec_vhcID As TextBox
    Friend WithEvents LabelEmpName As Label
    Friend WithEvents LabelEmpID As Label
    Friend WithEvents LabelPN As Label
    Friend WithEvents LabelDate As Label
End Class
