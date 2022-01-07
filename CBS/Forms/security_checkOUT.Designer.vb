<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class security_checkOUT
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.secID = New System.Windows.Forms.TextBox()
        Me.secName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.outtime = New System.Windows.Forms.TextBox()
        Me.actouttime = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.crmeter = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.sec_bkID = New System.Windows.Forms.TextBox()
        Me.sec_vhcID = New System.Windows.Forms.TextBox()
        Me.LabelEmpName = New System.Windows.Forms.Label()
        Me.LabelEmpID = New System.Windows.Forms.Label()
        Me.LabelPN = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(18, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(302, 83)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy HH:mm:ss"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(178, 195)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(141, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'secID
        '
        Me.secID.Location = New System.Drawing.Point(123, 17)
        Me.secID.Name = "secID"
        Me.secID.Size = New System.Drawing.Size(35, 20)
        Me.secID.TabIndex = 7
        Me.secID.TabStop = False
        '
        'secName
        '
        Me.secName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secName.Location = New System.Drawing.Point(103, 9)
        Me.secName.Name = "secName"
        Me.secName.ReadOnly = True
        Me.secName.Size = New System.Drawing.Size(215, 29)
        Me.secName.TabIndex = 6
        Me.secName.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Check By :"
        '
        'Timer1
        '
        '
        'outtime
        '
        Me.outtime.Location = New System.Drawing.Point(164, 17)
        Me.outtime.Name = "outtime"
        Me.outtime.Size = New System.Drawing.Size(35, 20)
        Me.outtime.TabIndex = 12
        Me.outtime.TabStop = False
        '
        'actouttime
        '
        Me.actouttime.Location = New System.Drawing.Point(205, 17)
        Me.actouttime.Name = "actouttime"
        Me.actouttime.Size = New System.Drawing.Size(35, 20)
        Me.actouttime.TabIndex = 13
        Me.actouttime.TabStop = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy HH:mm:ss"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(15, 55)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(305, 41)
        Me.DateTimePicker2.TabIndex = 14
        '
        'crmeter
        '
        Me.crmeter.BackColor = System.Drawing.SystemColors.Menu
        Me.crmeter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.crmeter.Location = New System.Drawing.Point(20, 198)
        Me.crmeter.Name = "crmeter"
        Me.crmeter.Size = New System.Drawing.Size(100, 13)
        Me.crmeter.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(22, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(300, 31)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Vehicle Condition Check List"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'sec_bkID
        '
        Me.sec_bkID.Location = New System.Drawing.Point(283, 15)
        Me.sec_bkID.Name = "sec_bkID"
        Me.sec_bkID.Size = New System.Drawing.Size(35, 20)
        Me.sec_bkID.TabIndex = 19
        Me.sec_bkID.TabStop = False
        '
        'sec_vhcID
        '
        Me.sec_vhcID.Location = New System.Drawing.Point(242, 15)
        Me.sec_vhcID.Name = "sec_vhcID"
        Me.sec_vhcID.Size = New System.Drawing.Size(35, 20)
        Me.sec_vhcID.TabIndex = 20
        '
        'LabelEmpName
        '
        Me.LabelEmpName.AutoSize = True
        Me.LabelEmpName.Location = New System.Drawing.Point(111, 226)
        Me.LabelEmpName.Name = "LabelEmpName"
        Me.LabelEmpName.Size = New System.Drawing.Size(59, 13)
        Me.LabelEmpName.TabIndex = 33
        Me.LabelEmpName.Text = "Emp Name"
        Me.LabelEmpName.Visible = False
        '
        'LabelEmpID
        '
        Me.LabelEmpID.AutoSize = True
        Me.LabelEmpID.Location = New System.Drawing.Point(57, 226)
        Me.LabelEmpID.Name = "LabelEmpID"
        Me.LabelEmpID.Size = New System.Drawing.Size(39, 13)
        Me.LabelEmpID.TabIndex = 32
        Me.LabelEmpID.Text = "EmpID"
        Me.LabelEmpID.Visible = False
        '
        'LabelPN
        '
        Me.LabelPN.AutoSize = True
        Me.LabelPN.Location = New System.Drawing.Point(16, 226)
        Me.LabelPN.Name = "LabelPN"
        Me.LabelPN.Size = New System.Drawing.Size(22, 13)
        Me.LabelPN.TabIndex = 31
        Me.LabelPN.Text = "PN"
        Me.LabelPN.Visible = False
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(207, 226)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(30, 13)
        Me.LabelDate.TabIndex = 30
        Me.LabelDate.Text = "Date"
        '
        'security_checkOUT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 245)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelEmpName)
        Me.Controls.Add(Me.LabelEmpID)
        Me.Controls.Add(Me.LabelPN)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.crmeter)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.secName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.outtime)
        Me.Controls.Add(Me.secID)
        Me.Controls.Add(Me.actouttime)
        Me.Controls.Add(Me.sec_bkID)
        Me.Controls.Add(Me.sec_vhcID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "security_checkOUT"
        Me.Text = "vehicle OUT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents secID As TextBox
    Friend WithEvents secName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents outtime As TextBox
    Friend WithEvents actouttime As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents crmeter As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents sec_bkID As TextBox
    Friend WithEvents sec_vhcID As TextBox
    Friend WithEvents LabelEmpName As Label
    Friend WithEvents LabelEmpID As Label
    Friend WithEvents LabelPN As Label
    Friend WithEvents LabelDate As Label
End Class
