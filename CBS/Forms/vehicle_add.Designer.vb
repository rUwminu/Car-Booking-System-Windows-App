<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vehicle_add
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
        Me.plateNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.vbrand = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vmodel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.vyear = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.inspectdate = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.insdate = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LabelLeftDate = New System.Windows.Forms.Label()
        Me.vhc_catselect = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.vtype = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LBP1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.vnote = New System.Windows.Forms.TextBox()
        Me.picloc = New System.Windows.Forms.TextBox()
        Me.vrddate = New System.Windows.Forms.TextBox()
        Me.vhc_category = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.vdate = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lastID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LBP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'plateNo
        '
        Me.plateNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.plateNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plateNo.Location = New System.Drawing.Point(202, 66)
        Me.plateNo.Name = "plateNo"
        Me.plateNo.Size = New System.Drawing.Size(157, 26)
        Me.plateNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registration / Plate No. :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Brand :"
        '
        'vbrand
        '
        Me.vbrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vbrand.Location = New System.Drawing.Point(109, 37)
        Me.vbrand.Name = "vbrand"
        Me.vbrand.Size = New System.Drawing.Size(276, 26)
        Me.vbrand.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Model :"
        '
        'vmodel
        '
        Me.vmodel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vmodel.Location = New System.Drawing.Point(109, 69)
        Me.vmodel.Name = "vmodel"
        Me.vmodel.Size = New System.Drawing.Size(276, 26)
        Me.vmodel.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Type :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Year :"
        '
        'vyear
        '
        Me.vyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vyear.Location = New System.Drawing.Point(109, 135)
        Me.vyear.Name = "vyear"
        Me.vyear.Size = New System.Drawing.Size(93, 26)
        Me.vyear.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 36)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Add New Vehicle"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox1.Controls.Add(Me.inspectdate)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox1.Controls.Add(Me.insdate)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.LabelLeftDate)
        Me.GroupBox1.Controls.Add(Me.vhc_catselect)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.vtype)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.LBP1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.vnote)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.vbrand)
        Me.GroupBox1.Controls.Add(Me.vmodel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.vyear)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.picloc)
        Me.GroupBox1.Controls.Add(Me.vrddate)
        Me.GroupBox1.Controls.Add(Me.vhc_category)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(819, 430)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(243, 275)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 20)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "*"
        Me.Label18.Visible = False
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(109, 276)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(128, 26)
        Me.DateTimePicker4.TabIndex = 40
        Me.DateTimePicker4.Visible = False
        '
        'inspectdate
        '
        Me.inspectdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inspectdate.Location = New System.Drawing.Point(111, 282)
        Me.inspectdate.Name = "inspectdate"
        Me.inspectdate.Size = New System.Drawing.Size(93, 15)
        Me.inspectdate.TabIndex = 41
        Me.inspectdate.TabStop = False
        Me.inspectdate.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(18, 262)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 40)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Insusrans " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exp. Date :"
        Me.Label19.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(243, 228)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 20)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "*"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(109, 228)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(128, 26)
        Me.DateTimePicker3.TabIndex = 36
        '
        'insdate
        '
        Me.insdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insdate.Location = New System.Drawing.Point(111, 232)
        Me.insdate.Name = "insdate"
        Me.insdate.Size = New System.Drawing.Size(93, 15)
        Me.insdate.TabIndex = 37
        Me.insdate.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 212)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 40)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Insusrans " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exp. Date :"
        '
        'LabelLeftDate
        '
        Me.LabelLeftDate.AutoSize = True
        Me.LabelLeftDate.Location = New System.Drawing.Point(277, 181)
        Me.LabelLeftDate.Name = "LabelLeftDate"
        Me.LabelLeftDate.Size = New System.Drawing.Size(45, 13)
        Me.LabelLeftDate.TabIndex = 30
        Me.LabelLeftDate.Text = "Label16"
        Me.LabelLeftDate.Visible = False
        '
        'vhc_catselect
        '
        Me.vhc_catselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vhc_catselect.Enabled = False
        Me.vhc_catselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhc_catselect.FormattingEnabled = True
        Me.vhc_catselect.Items.AddRange(New Object() {"Admin", "Management", "Production"})
        Me.vhc_catselect.Location = New System.Drawing.Point(774, 360)
        Me.vhc_catselect.Name = "vhc_catselect"
        Me.vhc_catselect.Size = New System.Drawing.Size(33, 28)
        Me.vhc_catselect.TabIndex = 28
        Me.vhc_catselect.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(243, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 20)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(391, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Enabled = False
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(687, 363)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 20)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Category :"
        Me.Label15.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(391, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(391, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "*"
        '
        'vtype
        '
        Me.vtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vtype.FormattingEnabled = True
        Me.vtype.Items.AddRange(New Object() {"CAR", "Multi-Purpose Vehicle (MPV)", "Motorcycle", "Luxury Vehicle", "Van", "Lorry"})
        Me.vtype.Location = New System.Drawing.Point(109, 101)
        Me.vtype.Name = "vtype"
        Me.vtype.Size = New System.Drawing.Size(276, 28)
        Me.vtype.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 40)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "RoadTax " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exp. Date :"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(619, 279)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(109, 172)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(128, 26)
        Me.DateTimePicker2.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(538, 279)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Load"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LBP1
        '
        Me.LBP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBP1.Location = New System.Drawing.Point(419, 50)
        Me.LBP1.Name = "LBP1"
        Me.LBP1.Size = New System.Drawing.Size(389, 223)
        Me.LBP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LBP1.TabIndex = 12
        Me.LBP1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Note :"
        '
        'vnote
        '
        Me.vnote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vnote.Location = New System.Drawing.Point(109, 328)
        Me.vnote.Multiline = True
        Me.vnote.Name = "vnote"
        Me.vnote.Size = New System.Drawing.Size(276, 93)
        Me.vnote.TabIndex = 10
        '
        'picloc
        '
        Me.picloc.Location = New System.Drawing.Point(440, 253)
        Me.picloc.Name = "picloc"
        Me.picloc.Size = New System.Drawing.Size(100, 20)
        Me.picloc.TabIndex = 15
        '
        'vrddate
        '
        Me.vrddate.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vrddate.Location = New System.Drawing.Point(111, 183)
        Me.vrddate.Name = "vrddate"
        Me.vrddate.Size = New System.Drawing.Size(93, 15)
        Me.vrddate.TabIndex = 20
        Me.vrddate.TabStop = False
        '
        'vhc_category
        '
        Me.vhc_category.Location = New System.Drawing.Point(354, 333)
        Me.vhc_category.Name = "vhc_category"
        Me.vhc_category.Size = New System.Drawing.Size(31, 20)
        Me.vhc_category.TabIndex = 29
        Me.vhc_category.Text = "1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(386, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Check"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(701, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 26)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(643, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Date :"
        '
        'vdate
        '
        Me.vdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vdate.Location = New System.Drawing.Point(736, 69)
        Me.vdate.Name = "vdate"
        Me.vdate.Size = New System.Drawing.Size(50, 15)
        Me.vdate.TabIndex = 15
        Me.vdate.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(612, 534)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 36)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(729, 534)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 36)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "CANCEL"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'OFD1
        '
        Me.OFD1.FileName = "OpenFileDialog1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(365, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 20)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "*"
        '
        'lastID
        '
        Me.lastID.Location = New System.Drawing.Point(337, 69)
        Me.lastID.Name = "lastID"
        Me.lastID.Size = New System.Drawing.Size(22, 20)
        Me.lastID.TabIndex = 27
        Me.lastID.Text = "1"
        '
        'vehicle_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 582)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.plateNo)
        Me.Controls.Add(Me.vdate)
        Me.Controls.Add(Me.lastID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "vehicle_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add new vehicle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LBP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents plateNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents vbrand As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents vmodel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents vyear As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents vdate As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LBP1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents vnote As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents picloc As TextBox
    Friend WithEvents OFD1 As OpenFileDialog
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents vrddate As TextBox
    Friend WithEvents vtype As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents vhc_catselect As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents vhc_category As TextBox
    Friend WithEvents lastID As TextBox
    Friend WithEvents LabelLeftDate As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents insdate As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents inspectdate As TextBox
    Friend WithEvents Label19 As Label
End Class
