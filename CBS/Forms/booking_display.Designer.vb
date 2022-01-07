<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class booking_display
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(booking_display))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.listGroupBox = New System.Windows.Forms.GroupBox()
        Me.Labelshow = New System.Windows.Forms.Label()
        Me.usrGroupBox = New System.Windows.Forms.GroupBox()
        Me.bk_reason = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bk_dept = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bk_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.start_conv = New System.Windows.Forms.TextBox()
        Me.end_conv = New System.Windows.Forms.TextBox()
        Me.bk_loctogo = New System.Windows.Forms.TextBox()
        Me.IsApprtxt = New System.Windows.Forms.TextBox()
        Me.bk_start = New System.Windows.Forms.TextBox()
        Me.bk_end = New System.Windows.Forms.TextBox()
        Me.uButton4 = New System.Windows.Forms.Button()
        Me.uButton2 = New System.Windows.Forms.Button()
        Me.uButton3 = New System.Windows.Forms.Button()
        Me.Bk_model = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bk_brand = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bk_plateno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.vhcGroupBox = New System.Windows.Forms.GroupBox()
        Me.PBX1 = New System.Windows.Forms.PictureBox()
        Me.bk_vhcIDtext = New System.Windows.Forms.TextBox()
        Me.vhcinfolabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bk_ID_label = New System.Windows.Forms.TextBox()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bk_vhccategory = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ButtonApprove = New System.Windows.Forms.Button()
        Me.ButtonDecline = New System.Windows.Forms.Button()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.LabelEmpID = New System.Windows.Forms.Label()
        Me.bk_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_bdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_approva_text = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_vhcID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_complete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bk_empID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usr_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.listGroupBox.SuspendLayout()
        Me.usrGroupBox.SuspendLayout()
        Me.vhcGroupBox.SuspendLayout()
        CType(Me.PBX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bk_ID, Me.bk_bdate, Me.bk_approva_text, Me.bk_vhcID, Me.bk_complete, Me.bk_empID, Me.usr_name})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(415, 296)
        Me.DataGridView1.TabIndex = 0
        '
        'listGroupBox
        '
        Me.listGroupBox.Controls.Add(Me.Labelshow)
        Me.listGroupBox.Controls.Add(Me.DataGridView1)
        Me.listGroupBox.Location = New System.Drawing.Point(22, 57)
        Me.listGroupBox.Name = "listGroupBox"
        Me.listGroupBox.Size = New System.Drawing.Size(427, 354)
        Me.listGroupBox.TabIndex = 2
        Me.listGroupBox.TabStop = False
        Me.listGroupBox.Text = "Choose your Booking No :"
        '
        'Labelshow
        '
        Me.Labelshow.AutoSize = True
        Me.Labelshow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelshow.Location = New System.Drawing.Point(3, 329)
        Me.Labelshow.Name = "Labelshow"
        Me.Labelshow.Size = New System.Drawing.Size(201, 13)
        Me.Labelshow.TabIndex = 1
        Me.Labelshow.Text = "** Select Booking No. to view the record."
        '
        'usrGroupBox
        '
        Me.usrGroupBox.Controls.Add(Me.bk_reason)
        Me.usrGroupBox.Controls.Add(Me.Label11)
        Me.usrGroupBox.Controls.Add(Me.Label10)
        Me.usrGroupBox.Controls.Add(Me.Label5)
        Me.usrGroupBox.Controls.Add(Me.Label4)
        Me.usrGroupBox.Controls.Add(Me.bk_dept)
        Me.usrGroupBox.Controls.Add(Me.Label3)
        Me.usrGroupBox.Controls.Add(Me.bk_name)
        Me.usrGroupBox.Controls.Add(Me.Label2)
        Me.usrGroupBox.Controls.Add(Me.DateTimePicker2)
        Me.usrGroupBox.Controls.Add(Me.uButton2)
        Me.usrGroupBox.Controls.Add(Me.uButton3)
        Me.usrGroupBox.Controls.Add(Me.uButton4)
        Me.usrGroupBox.Controls.Add(Me.DateTimePicker1)
        Me.usrGroupBox.Controls.Add(Me.start_conv)
        Me.usrGroupBox.Controls.Add(Me.end_conv)
        Me.usrGroupBox.Controls.Add(Me.bk_loctogo)
        Me.usrGroupBox.Controls.Add(Me.IsApprtxt)
        Me.usrGroupBox.Controls.Add(Me.bk_start)
        Me.usrGroupBox.Controls.Add(Me.bk_end)
        Me.usrGroupBox.Location = New System.Drawing.Point(455, 66)
        Me.usrGroupBox.Name = "usrGroupBox"
        Me.usrGroupBox.Size = New System.Drawing.Size(359, 326)
        Me.usrGroupBox.TabIndex = 3
        Me.usrGroupBox.TabStop = False
        Me.usrGroupBox.Text = "User Info :"
        '
        'bk_reason
        '
        Me.bk_reason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_reason.Location = New System.Drawing.Point(125, 202)
        Me.bk_reason.Multiline = True
        Me.bk_reason.Name = "bk_reason"
        Me.bk_reason.Size = New System.Drawing.Size(217, 99)
        Me.bk_reason.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 205)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Reason :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Location :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "End Time :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Start Time :"
        '
        'bk_dept
        '
        Me.bk_dept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_dept.Location = New System.Drawing.Point(125, 74)
        Me.bk_dept.Name = "bk_dept"
        Me.bk_dept.Size = New System.Drawing.Size(217, 26)
        Me.bk_dept.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Department"
        '
        'bk_name
        '
        Me.bk_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_name.Location = New System.Drawing.Point(125, 42)
        Me.bk_name.Name = "bk_name"
        Me.bk_name.Size = New System.Drawing.Size(217, 26)
        Me.bk_name.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy HH:mm:ss"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(125, 138)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(217, 26)
        Me.DateTimePicker2.TabIndex = 27
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy HH:mm:ss"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(125, 106)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(217, 26)
        Me.DateTimePicker1.TabIndex = 26
        '
        'start_conv
        '
        Me.start_conv.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_conv.Location = New System.Drawing.Point(125, 211)
        Me.start_conv.Name = "start_conv"
        Me.start_conv.ReadOnly = True
        Me.start_conv.Size = New System.Drawing.Size(61, 17)
        Me.start_conv.TabIndex = 28
        Me.start_conv.TabStop = False
        '
        'end_conv
        '
        Me.end_conv.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.end_conv.Location = New System.Drawing.Point(125, 234)
        Me.end_conv.Name = "end_conv"
        Me.end_conv.Size = New System.Drawing.Size(61, 17)
        Me.end_conv.TabIndex = 29
        Me.end_conv.TabStop = False
        '
        'bk_loctogo
        '
        Me.bk_loctogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_loctogo.Location = New System.Drawing.Point(125, 170)
        Me.bk_loctogo.Name = "bk_loctogo"
        Me.bk_loctogo.Size = New System.Drawing.Size(217, 26)
        Me.bk_loctogo.TabIndex = 23
        '
        'IsApprtxt
        '
        Me.IsApprtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsApprtxt.Location = New System.Drawing.Point(142, 270)
        Me.IsApprtxt.Name = "IsApprtxt"
        Me.IsApprtxt.Size = New System.Drawing.Size(61, 17)
        Me.IsApprtxt.TabIndex = 30
        Me.IsApprtxt.TabStop = False
        Me.IsApprtxt.Text = "1"
        '
        'bk_start
        '
        Me.bk_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_start.Location = New System.Drawing.Point(157, 109)
        Me.bk_start.Name = "bk_start"
        Me.bk_start.Size = New System.Drawing.Size(77, 18)
        Me.bk_start.TabIndex = 8
        '
        'bk_end
        '
        Me.bk_end.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_end.Location = New System.Drawing.Point(157, 141)
        Me.bk_end.Name = "bk_end"
        Me.bk_end.Size = New System.Drawing.Size(77, 18)
        Me.bk_end.TabIndex = 10
        '
        'uButton4
        '
        Me.uButton4.Location = New System.Drawing.Point(267, 303)
        Me.uButton4.Name = "uButton4"
        Me.uButton4.Size = New System.Drawing.Size(75, 23)
        Me.uButton4.TabIndex = 21
        Me.uButton4.Text = "CANCEL"
        Me.uButton4.UseVisualStyleBackColor = True
        '
        'uButton2
        '
        Me.uButton2.Location = New System.Drawing.Point(267, 303)
        Me.uButton2.Name = "uButton2"
        Me.uButton2.Size = New System.Drawing.Size(75, 23)
        Me.uButton2.TabIndex = 11
        Me.uButton2.Text = "EDIT"
        Me.uButton2.UseVisualStyleBackColor = True
        '
        'uButton3
        '
        Me.uButton3.Location = New System.Drawing.Point(186, 303)
        Me.uButton3.Name = "uButton3"
        Me.uButton3.Size = New System.Drawing.Size(75, 23)
        Me.uButton3.TabIndex = 20
        Me.uButton3.Text = "SAVE"
        Me.uButton3.UseVisualStyleBackColor = True
        '
        'Bk_model
        '
        Me.Bk_model.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bk_model.Location = New System.Drawing.Point(127, 96)
        Me.Bk_model.Name = "Bk_model"
        Me.Bk_model.ReadOnly = True
        Me.Bk_model.Size = New System.Drawing.Size(233, 26)
        Me.Bk_model.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Model :"
        '
        'bk_brand
        '
        Me.bk_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_brand.Location = New System.Drawing.Point(127, 64)
        Me.bk_brand.Name = "bk_brand"
        Me.bk_brand.ReadOnly = True
        Me.bk_brand.Size = New System.Drawing.Size(233, 26)
        Me.bk_brand.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Brand :"
        '
        'bk_plateno
        '
        Me.bk_plateno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_plateno.Location = New System.Drawing.Point(127, 32)
        Me.bk_plateno.Name = "bk_plateno"
        Me.bk_plateno.ReadOnly = True
        Me.bk_plateno.Size = New System.Drawing.Size(233, 26)
        Me.bk_plateno.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Reg./ Plate No:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(114, 406)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(144, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Show Completed Record"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(282, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 22)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'vhcGroupBox
        '
        Me.vhcGroupBox.Controls.Add(Me.Label6)
        Me.vhcGroupBox.Controls.Add(Me.Bk_model)
        Me.vhcGroupBox.Controls.Add(Me.PBX1)
        Me.vhcGroupBox.Controls.Add(Me.vhcinfolabel)
        Me.vhcGroupBox.Controls.Add(Me.bk_plateno)
        Me.vhcGroupBox.Controls.Add(Me.Label8)
        Me.vhcGroupBox.Controls.Add(Me.Label7)
        Me.vhcGroupBox.Controls.Add(Me.bk_brand)
        Me.vhcGroupBox.Controls.Add(Me.bk_vhcIDtext)
        Me.vhcGroupBox.Location = New System.Drawing.Point(22, 428)
        Me.vhcGroupBox.Name = "vhcGroupBox"
        Me.vhcGroupBox.Size = New System.Drawing.Size(706, 193)
        Me.vhcGroupBox.TabIndex = 17
        Me.vhcGroupBox.TabStop = False
        Me.vhcGroupBox.Text = "Vehicle Info :"
        '
        'PBX1
        '
        Me.PBX1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBX1.Location = New System.Drawing.Point(366, 19)
        Me.PBX1.Name = "PBX1"
        Me.PBX1.Size = New System.Drawing.Size(324, 165)
        Me.PBX1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBX1.TabIndex = 1
        Me.PBX1.TabStop = False
        '
        'bk_vhcIDtext
        '
        Me.bk_vhcIDtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_vhcIDtext.Location = New System.Drawing.Point(127, 35)
        Me.bk_vhcIDtext.Name = "bk_vhcIDtext"
        Me.bk_vhcIDtext.Size = New System.Drawing.Size(56, 18)
        Me.bk_vhcIDtext.TabIndex = 20
        Me.bk_vhcIDtext.TabStop = False
        '
        'vhcinfolabel
        '
        Me.vhcinfolabel.AutoSize = True
        Me.vhcinfolabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.vhcinfolabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vhcinfolabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhcinfolabel.ForeColor = System.Drawing.Color.Red
        Me.vhcinfolabel.Location = New System.Drawing.Point(6, 148)
        Me.vhcinfolabel.Name = "vhcinfolabel"
        Me.vhcinfolabel.Size = New System.Drawing.Size(356, 36)
        Me.vhcinfolabel.TabIndex = 21
        Me.vhcinfolabel.Text = "Vehicle Information are not allow to change" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please CANCEL this Booking, and crea" &
    "te new Booking."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(19, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Booking No :"
        '
        'bk_ID_label
        '
        Me.bk_ID_label.BackColor = System.Drawing.SystemColors.Control
        Me.bk_ID_label.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bk_ID_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk_ID_label.ForeColor = System.Drawing.Color.Navy
        Me.bk_ID_label.Location = New System.Drawing.Point(114, 3)
        Me.bk_ID_label.Name = "bk_ID_label"
        Me.bk_ID_label.Size = New System.Drawing.Size(217, 46)
        Me.bk_ID_label.TabIndex = 28
        Me.bk_ID_label.TabStop = False
        '
        'cancelbtn
        '
        Me.cancelbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cancelbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancelbtn.Location = New System.Drawing.Point(553, 12)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(83, 37)
        Me.cancelbtn.TabIndex = 31
        Me.cancelbtn.Tag = "Cancel Booking"
        Me.cancelbtn.Text = "&Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'bk_vhccategory
        '
        Me.bk_vhccategory.Location = New System.Drawing.Point(114, 20)
        Me.bk_vhccategory.Name = "bk_vhccategory"
        Me.bk_vhccategory.Size = New System.Drawing.Size(33, 20)
        Me.bk_vhccategory.TabIndex = 33
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(332, 402)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 23)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Show &All Record"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Image = CType(resources.GetObject("PrintButton.Image"), System.Drawing.Image)
        Me.PrintButton.Location = New System.Drawing.Point(359, 11)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(66, 37)
        Me.PrintButton.TabIndex = 32
        Me.PrintButton.Tag = "Approve"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ButtonApprove
        '
        Me.ButtonApprove.Image = CType(resources.GetObject("ButtonApprove.Image"), System.Drawing.Image)
        Me.ButtonApprove.Location = New System.Drawing.Point(441, 11)
        Me.ButtonApprove.Name = "ButtonApprove"
        Me.ButtonApprove.Size = New System.Drawing.Size(37, 37)
        Me.ButtonApprove.TabIndex = 30
        Me.ButtonApprove.Tag = "Approve"
        Me.ButtonApprove.UseVisualStyleBackColor = True
        '
        'ButtonDecline
        '
        Me.ButtonDecline.Image = CType(resources.GetObject("ButtonDecline.Image"), System.Drawing.Image)
        Me.ButtonDecline.Location = New System.Drawing.Point(487, 11)
        Me.ButtonDecline.Name = "ButtonDecline"
        Me.ButtonDecline.Size = New System.Drawing.Size(37, 37)
        Me.ButtonDecline.TabIndex = 29
        Me.ButtonDecline.Tag = "Decline"
        Me.ButtonDecline.UseVisualStyleBackColor = True
        '
        'closebtn
        '
        Me.closebtn.Image = CType(resources.GetObject("closebtn.Image"), System.Drawing.Image)
        Me.closebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closebtn.Location = New System.Drawing.Point(657, 12)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(87, 37)
        Me.closebtn.TabIndex = 5
        Me.closebtn.Text = "       &CLOSE"
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'LabelEmpID
        '
        Me.LabelEmpID.AutoSize = True
        Me.LabelEmpID.Location = New System.Drawing.Point(689, 412)
        Me.LabelEmpID.Name = "LabelEmpID"
        Me.LabelEmpID.Size = New System.Drawing.Size(39, 13)
        Me.LabelEmpID.TabIndex = 35
        Me.LabelEmpID.Text = "Label1"
        '
        'bk_ID
        '
        Me.bk_ID.DataPropertyName = "bk_ID"
        Me.bk_ID.HeaderText = "Booking NO:"
        Me.bk_ID.Name = "bk_ID"
        Me.bk_ID.ReadOnly = True
        Me.bk_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bk_ID.Width = 90
        '
        'bk_bdate
        '
        Me.bk_bdate.DataPropertyName = "bk_bdate"
        Me.bk_bdate.HeaderText = "Date"
        Me.bk_bdate.Name = "bk_bdate"
        Me.bk_bdate.ReadOnly = True
        Me.bk_bdate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bk_bdate.Width = 80
        '
        'bk_approva_text
        '
        Me.bk_approva_text.DataPropertyName = "bk_approva_text"
        Me.bk_approva_text.HeaderText = "Approval"
        Me.bk_approva_text.Name = "bk_approva_text"
        Me.bk_approva_text.ReadOnly = True
        Me.bk_approva_text.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bk_approva_text.Width = 120
        '
        'bk_vhcID
        '
        Me.bk_vhcID.DataPropertyName = "bk_vhcID"
        Me.bk_vhcID.HeaderText = "vhcID"
        Me.bk_vhcID.Name = "bk_vhcID"
        Me.bk_vhcID.ReadOnly = True
        Me.bk_vhcID.Visible = False
        '
        'bk_complete
        '
        Me.bk_complete.DataPropertyName = "bk_complete"
        Me.bk_complete.HeaderText = "Complete"
        Me.bk_complete.Name = "bk_complete"
        Me.bk_complete.ReadOnly = True
        Me.bk_complete.Visible = False
        '
        'bk_empID
        '
        Me.bk_empID.DataPropertyName = "bk_empID"
        Me.bk_empID.HeaderText = "Emp ID"
        Me.bk_empID.Name = "bk_empID"
        Me.bk_empID.ReadOnly = True
        Me.bk_empID.Visible = False
        '
        'usr_name
        '
        Me.usr_name.DataPropertyName = "usr_name"
        Me.usr_name.HeaderText = "Approve User"
        Me.usr_name.Name = "usr_name"
        Me.usr_name.ReadOnly = True
        '
        'booking_display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 633)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LabelEmpID)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.bk_ID_label)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.ButtonApprove)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonDecline)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.vhcGroupBox)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.usrGroupBox)
        Me.Controls.Add(Me.bk_vhccategory)
        Me.Controls.Add(Me.listGroupBox)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "booking_display"
        Me.Text = "Vehicle Booking Display"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.listGroupBox.ResumeLayout(False)
        Me.listGroupBox.PerformLayout()
        Me.usrGroupBox.ResumeLayout(False)
        Me.usrGroupBox.PerformLayout()
        Me.vhcGroupBox.ResumeLayout(False)
        Me.vhcGroupBox.PerformLayout()
        CType(Me.PBX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected WithEvents DataGridView1 As DataGridView
    Friend WithEvents PBX1 As PictureBox
    Friend WithEvents listGroupBox As GroupBox
    Friend WithEvents Labelshow As Label
    Friend WithEvents usrGroupBox As GroupBox
    Friend WithEvents bk_dept As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bk_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Bk_model As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents bk_brand As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents bk_plateno As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bk_end As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents bk_start As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents closebtn As Button
    Friend WithEvents vhcGroupBox As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents uButton2 As Button
    Friend WithEvents bk_reason As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents bk_loctogo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents uButton4 As Button
    Friend WithEvents uButton3 As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents bk_ID_label As TextBox
    Friend WithEvents start_conv As TextBox
    Friend WithEvents end_conv As TextBox
    Friend WithEvents bk_vhcIDtext As TextBox
    Friend WithEvents IsApprtxt As TextBox
    Friend WithEvents ButtonDecline As Button
    Friend WithEvents ButtonApprove As Button
    Friend WithEvents cancelbtn As Button
    Friend WithEvents vhcinfolabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PrintButton As Button
    Friend WithEvents bk_vhccategory As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LabelEmpID As Label
    Friend WithEvents bk_ID As DataGridViewTextBoxColumn
    Friend WithEvents bk_bdate As DataGridViewTextBoxColumn
    Friend WithEvents bk_approva_text As DataGridViewTextBoxColumn
    Friend WithEvents bk_vhcID As DataGridViewTextBoxColumn
    Friend WithEvents bk_complete As DataGridViewTextBoxColumn
    Friend WithEvents bk_empID As DataGridViewTextBoxColumn
    Friend WithEvents usr_name As DataGridViewTextBoxColumn
End Class
