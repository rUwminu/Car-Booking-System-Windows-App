<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class booking_new
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(booking_new))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bk_usr_fullname = New System.Windows.Forms.TextBox()
        Me.UsrGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.bk_usr_dept = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bk_usr_empID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bk_usr_ID = New System.Windows.Forms.TextBox()
        Me.usr_category = New System.Windows.Forms.TextBox()
        Me.BookTimeGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.bk_reason = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bk_loctogo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.vehicleGroupBox = New System.Windows.Forms.GroupBox()
        Me.tngo_Checkbox = New System.Windows.Forms.CheckBox()
        Me.petrol_checkbox = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.bt_vhc_type = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.bt_vhc_brand = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bt_vhc_model = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PBX1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.vhc_plate_list = New System.Windows.Forms.ListBox()
        Me.bk_vhcIDno = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.rtdatecheck = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.vhc_category = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.bk_ID = New System.Windows.Forms.TextBox()
        Me.nowDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.nowToday = New System.Windows.Forms.TextBox()
        Me.nowdate2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.UsrGroupBox.SuspendLayout()
        Me.BookTimeGroupBox.SuspendLayout()
        Me.vehicleGroupBox.SuspendLayout()
        CType(Me.PBX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(12, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(350, 52)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vehicle Booking"
        '
        'bk_usr_fullname
        '
        Me.bk_usr_fullname.Enabled = False
        Me.bk_usr_fullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_usr_fullname.Location = New System.Drawing.Point(129, 21)
        Me.bk_usr_fullname.Name = "bk_usr_fullname"
        Me.bk_usr_fullname.ReadOnly = True
        Me.bk_usr_fullname.Size = New System.Drawing.Size(255, 26)
        Me.bk_usr_fullname.TabIndex = 3
        '
        'UsrGroupBox
        '
        Me.UsrGroupBox.Controls.Add(Me.Label17)
        Me.UsrGroupBox.Controls.Add(Me.Label16)
        Me.UsrGroupBox.Controls.Add(Me.Label15)
        Me.UsrGroupBox.Controls.Add(Me.bk_usr_dept)
        Me.UsrGroupBox.Controls.Add(Me.Button4)
        Me.UsrGroupBox.Controls.Add(Me.Button3)
        Me.UsrGroupBox.Controls.Add(Me.Button2)
        Me.UsrGroupBox.Controls.Add(Me.bk_usr_empID)
        Me.UsrGroupBox.Controls.Add(Me.Label4)
        Me.UsrGroupBox.Controls.Add(Me.Label1)
        Me.UsrGroupBox.Controls.Add(Me.Label2)
        Me.UsrGroupBox.Controls.Add(Me.bk_usr_fullname)
        Me.UsrGroupBox.Controls.Add(Me.bk_usr_ID)
        Me.UsrGroupBox.Controls.Add(Me.usr_category)
        Me.UsrGroupBox.Location = New System.Drawing.Point(12, 81)
        Me.UsrGroupBox.Name = "UsrGroupBox"
        Me.UsrGroupBox.Size = New System.Drawing.Size(400, 163)
        Me.UsrGroupBox.TabIndex = 5
        Me.UsrGroupBox.TabStop = False
        Me.UsrGroupBox.Text = "User Detail :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(6, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(11, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(6, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(6, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "*"
        '
        'bk_usr_dept
        '
        Me.bk_usr_dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bk_usr_dept.Enabled = False
        Me.bk_usr_dept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_usr_dept.FormattingEnabled = True
        Me.bk_usr_dept.Items.AddRange(New Object() {"Account", "Admin", "EDP", "Convertor", "Corrugator", "Costing", "Customer Service", "Design", "Maintenance", "Management", "Marketing", "Planning", "Purchasing", "QAQC", "Research & Development", "Safety", "Warehouse"})
        Me.bk_usr_dept.Location = New System.Drawing.Point(129, 86)
        Me.bk_usr_dept.Name = "bk_usr_dept"
        Me.bk_usr_dept.Size = New System.Drawing.Size(254, 28)
        Me.bk_usr_dept.TabIndex = 11
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(100, 126)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(227, 126)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Confirm"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(308, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Not Me!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bk_usr_empID
        '
        Me.bk_usr_empID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_usr_empID.Location = New System.Drawing.Point(129, 53)
        Me.bk_usr_empID.Name = "bk_usr_empID"
        Me.bk_usr_empID.ReadOnly = True
        Me.bk_usr_empID.Size = New System.Drawing.Size(255, 26)
        Me.bk_usr_empID.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Employee ID"
        '
        'bk_usr_ID
        '
        Me.bk_usr_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_usr_ID.Location = New System.Drawing.Point(141, 32)
        Me.bk_usr_ID.Name = "bk_usr_ID"
        Me.bk_usr_ID.ReadOnly = True
        Me.bk_usr_ID.Size = New System.Drawing.Size(28, 12)
        Me.bk_usr_ID.TabIndex = 8
        Me.bk_usr_ID.TabStop = False
        '
        'usr_category
        '
        Me.usr_category.Location = New System.Drawing.Point(129, 90)
        Me.usr_category.Name = "usr_category"
        Me.usr_category.Size = New System.Drawing.Size(28, 20)
        Me.usr_category.TabIndex = 15
        '
        'BookTimeGroupBox
        '
        Me.BookTimeGroupBox.Controls.Add(Me.Label20)
        Me.BookTimeGroupBox.Controls.Add(Me.Label19)
        Me.BookTimeGroupBox.Controls.Add(Me.Label18)
        Me.BookTimeGroupBox.Controls.Add(Me.bk_reason)
        Me.BookTimeGroupBox.Controls.Add(Me.Label9)
        Me.BookTimeGroupBox.Controls.Add(Me.bk_loctogo)
        Me.BookTimeGroupBox.Controls.Add(Me.Label8)
        Me.BookTimeGroupBox.Controls.Add(Me.DateTimePicker2)
        Me.BookTimeGroupBox.Controls.Add(Me.DateTimePicker1)
        Me.BookTimeGroupBox.Controls.Add(Me.Label7)
        Me.BookTimeGroupBox.Controls.Add(Me.Label6)
        Me.BookTimeGroupBox.Location = New System.Drawing.Point(12, 262)
        Me.BookTimeGroupBox.Name = "BookTimeGroupBox"
        Me.BookTimeGroupBox.Size = New System.Drawing.Size(397, 230)
        Me.BookTimeGroupBox.TabIndex = 6
        Me.BookTimeGroupBox.TabStop = False
        Me.BookTimeGroupBox.Text = "Booking Detail :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(6, 127)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 13)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(6, 95)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 13)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(6, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(11, 13)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "*"
        '
        'bk_reason
        '
        Me.bk_reason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_reason.Location = New System.Drawing.Point(141, 127)
        Me.bk_reason.Multiline = True
        Me.bk_reason.Name = "bk_reason"
        Me.bk_reason.Size = New System.Drawing.Size(243, 80)
        Me.bk_reason.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 40)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Reason /" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Purpose"
        '
        'bk_loctogo
        '
        Me.bk_loctogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_loctogo.Location = New System.Drawing.Point(141, 95)
        Me.bk_loctogo.Name = "bk_loctogo"
        Me.bk_loctogo.Size = New System.Drawing.Size(243, 26)
        Me.bk_loctogo.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Location to go"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy hh:mm tt"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(188, 63)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(196, 24)
        Me.DateTimePicker2.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm tt"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(188, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 24)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Estimate Return Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Booking Time"
        '
        'vehicleGroupBox
        '
        Me.vehicleGroupBox.Controls.Add(Me.tngo_Checkbox)
        Me.vehicleGroupBox.Controls.Add(Me.petrol_checkbox)
        Me.vehicleGroupBox.Controls.Add(Me.Label21)
        Me.vehicleGroupBox.Controls.Add(Me.bt_vhc_type)
        Me.vehicleGroupBox.Controls.Add(Me.Label12)
        Me.vehicleGroupBox.Controls.Add(Me.bt_vhc_brand)
        Me.vehicleGroupBox.Controls.Add(Me.Label11)
        Me.vehicleGroupBox.Controls.Add(Me.bt_vhc_model)
        Me.vehicleGroupBox.Controls.Add(Me.Label10)
        Me.vehicleGroupBox.Controls.Add(Me.PBX1)
        Me.vehicleGroupBox.Controls.Add(Me.Button1)
        Me.vehicleGroupBox.Controls.Add(Me.vhc_plate_list)
        Me.vehicleGroupBox.Controls.Add(Me.bk_vhcIDno)
        Me.vehicleGroupBox.Controls.Add(Me.TextBox2)
        Me.vehicleGroupBox.Controls.Add(Me.rtdatecheck)
        Me.vehicleGroupBox.Controls.Add(Me.TextBox1)
        Me.vehicleGroupBox.Controls.Add(Me.vhc_category)
        Me.vehicleGroupBox.Location = New System.Drawing.Point(432, 81)
        Me.vehicleGroupBox.Name = "vehicleGroupBox"
        Me.vehicleGroupBox.Size = New System.Drawing.Size(585, 360)
        Me.vehicleGroupBox.TabIndex = 7
        Me.vehicleGroupBox.TabStop = False
        Me.vehicleGroupBox.Text = "Vehicle Detail"
        '
        'tngo_Checkbox
        '
        Me.tngo_Checkbox.AutoSize = True
        Me.tngo_Checkbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tngo_Checkbox.Location = New System.Drawing.Point(18, 315)
        Me.tngo_Checkbox.Name = "tngo_Checkbox"
        Me.tngo_Checkbox.Size = New System.Drawing.Size(151, 24)
        Me.tngo_Checkbox.TabIndex = 25
        Me.tngo_Checkbox.Text = "Touch && Go Card"
        Me.tngo_Checkbox.UseVisualStyleBackColor = True
        Me.tngo_Checkbox.Visible = False
        '
        'petrol_checkbox
        '
        Me.petrol_checkbox.AutoSize = True
        Me.petrol_checkbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.petrol_checkbox.Location = New System.Drawing.Point(18, 289)
        Me.petrol_checkbox.Name = "petrol_checkbox"
        Me.petrol_checkbox.Size = New System.Drawing.Size(107, 24)
        Me.petrol_checkbox.TabIndex = 24
        Me.petrol_checkbox.Text = "Petrol Card"
        Me.petrol_checkbox.UseVisualStyleBackColor = True
        Me.petrol_checkbox.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(6, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(11, 13)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "*"
        '
        'bt_vhc_type
        '
        Me.bt_vhc_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_vhc_type.Location = New System.Drawing.Point(287, 312)
        Me.bt_vhc_type.Name = "bt_vhc_type"
        Me.bt_vhc_type.ReadOnly = True
        Me.bt_vhc_type.Size = New System.Drawing.Size(273, 26)
        Me.bt_vhc_type.TabIndex = 8
        Me.bt_vhc_type.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(198, 315)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 20)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Type :"
        '
        'bt_vhc_brand
        '
        Me.bt_vhc_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_vhc_brand.Location = New System.Drawing.Point(287, 248)
        Me.bt_vhc_brand.Name = "bt_vhc_brand"
        Me.bt_vhc_brand.ReadOnly = True
        Me.bt_vhc_brand.Size = New System.Drawing.Size(273, 26)
        Me.bt_vhc_brand.TabIndex = 6
        Me.bt_vhc_brand.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(198, 251)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 20)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Brand :"
        '
        'bt_vhc_model
        '
        Me.bt_vhc_model.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_vhc_model.Location = New System.Drawing.Point(287, 280)
        Me.bt_vhc_model.Name = "bt_vhc_model"
        Me.bt_vhc_model.ReadOnly = True
        Me.bt_vhc_model.Size = New System.Drawing.Size(273, 26)
        Me.bt_vhc_model.TabIndex = 4
        Me.bt_vhc_model.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(198, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Model :"
        '
        'PBX1
        '
        Me.PBX1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBX1.Location = New System.Drawing.Point(202, 27)
        Me.PBX1.Name = "PBX1"
        Me.PBX1.Size = New System.Drawing.Size(358, 210)
        Me.PBX1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBX1.TabIndex = 2
        Me.PBX1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Show Available Cars"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'vhc_plate_list
        '
        Me.vhc_plate_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhc_plate_list.FormattingEnabled = True
        Me.vhc_plate_list.ItemHeight = 20
        Me.vhc_plate_list.Location = New System.Drawing.Point(18, 24)
        Me.vhc_plate_list.Name = "vhc_plate_list"
        Me.vhc_plate_list.Size = New System.Drawing.Size(172, 224)
        Me.vhc_plate_list.TabIndex = 0
        '
        'bk_vhcIDno
        '
        Me.bk_vhcIDno.Location = New System.Drawing.Point(94, 163)
        Me.bk_vhcIDno.Name = "bk_vhcIDno"
        Me.bk_vhcIDno.Size = New System.Drawing.Size(8, 20)
        Me.bk_vhcIDno.TabIndex = 19
        Me.bk_vhcIDno.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(53, 118)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(49, 15)
        Me.TextBox2.TabIndex = 20
        '
        'rtdatecheck
        '
        Me.rtdatecheck.Location = New System.Drawing.Point(151, 219)
        Me.rtdatecheck.Name = "rtdatecheck"
        Me.rtdatecheck.Size = New System.Drawing.Size(39, 20)
        Me.rtdatecheck.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(53, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(49, 15)
        Me.TextBox1.TabIndex = 18
        '
        'vhc_category
        '
        Me.vhc_category.Location = New System.Drawing.Point(223, 197)
        Me.vhc_category.Name = "vhc_category"
        Me.vhc_category.Size = New System.Drawing.Size(35, 20)
        Me.vhc_category.TabIndex = 23
        '
        'Timer1
        '
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(715, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Date/Time :"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(781, 459)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 43)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "CONFIRM"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(921, 459)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 43)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "CANCEL"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(715, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 20)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Booking No :"
        '
        'bk_ID
        '
        Me.bk_ID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bk_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_ID.Location = New System.Drawing.Point(825, 12)
        Me.bk_ID.Name = "bk_ID"
        Me.bk_ID.ReadOnly = True
        Me.bk_ID.Size = New System.Drawing.Size(192, 19)
        Me.bk_ID.TabIndex = 12
        Me.bk_ID.TabStop = False
        Me.bk_ID.Text = "1000"
        '
        'nowDateTimePicker
        '
        Me.nowDateTimePicker.CustomFormat = "dd-MM-yyyy hh:mm tt"
        Me.nowDateTimePicker.Enabled = False
        Me.nowDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nowDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.nowDateTimePicker.Location = New System.Drawing.Point(811, 49)
        Me.nowDateTimePicker.Name = "nowDateTimePicker"
        Me.nowDateTimePicker.Size = New System.Drawing.Size(192, 26)
        Me.nowDateTimePicker.TabIndex = 18
        Me.nowDateTimePicker.TabStop = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(921, 459)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 43)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "CLOSE"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'nowToday
        '
        Me.nowToday.Location = New System.Drawing.Point(825, 54)
        Me.nowToday.Name = "nowToday"
        Me.nowToday.Size = New System.Drawing.Size(20, 20)
        Me.nowToday.TabIndex = 21
        Me.nowToday.TabStop = False
        '
        'nowdate2
        '
        Me.nowdate2.Location = New System.Drawing.Point(877, 54)
        Me.nowdate2.Name = "nowdate2"
        Me.nowdate2.Size = New System.Drawing.Size(20, 20)
        Me.nowdate2.TabIndex = 22
        Me.nowdate2.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(437, 470)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 17)
        Me.Label14.TabIndex = 23
        '
        'booking_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 514)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.nowDateTimePicker)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.bk_ID)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.vehicleGroupBox)
        Me.Controls.Add(Me.BookTimeGroupBox)
        Me.Controls.Add(Me.UsrGroupBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nowToday)
        Me.Controls.Add(Me.nowdate2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "booking_new"
        Me.Text = "New Booking"
        Me.UsrGroupBox.ResumeLayout(False)
        Me.UsrGroupBox.PerformLayout()
        Me.BookTimeGroupBox.ResumeLayout(False)
        Me.BookTimeGroupBox.PerformLayout()
        Me.vehicleGroupBox.ResumeLayout(False)
        Me.vehicleGroupBox.PerformLayout()
        CType(Me.PBX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bk_usr_fullname As TextBox
    Friend WithEvents UsrGroupBox As GroupBox
    Friend WithEvents bk_usr_ID As TextBox
    Friend WithEvents bk_usr_empID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BookTimeGroupBox As GroupBox
    Friend WithEvents vehicleGroupBox As GroupBox
    Friend WithEvents bk_reason As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents bk_loctogo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents vhc_plate_list As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents bk_usr_dept As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PBX1 As PictureBox
    Friend WithEvents bt_vhc_brand As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents bt_vhc_model As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents bt_vhc_type As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents bk_ID As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents nowDateTimePicker As DateTimePicker
    Friend WithEvents bk_vhcIDno As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents nowToday As TextBox
    Friend WithEvents nowdate2 As TextBox
    Friend WithEvents vhc_category As TextBox
    Friend WithEvents usr_category As TextBox
    Friend WithEvents tngo_Checkbox As CheckBox
    Friend WithEvents petrol_checkbox As CheckBox
    Friend WithEvents rtdatecheck As TextBox
    Friend WithEvents Label14 As Label
End Class
