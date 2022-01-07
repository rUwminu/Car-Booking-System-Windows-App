<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_display
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
        Dim Usr_levelLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim Usr_IDLabel As System.Windows.Forms.Label
        Dim Usr_nameLabel As System.Windows.Forms.Label
        Dim Usr_shortnameLabel As System.Windows.Forms.Label
        Dim Usr_usernameLabel As System.Windows.Forms.Label
        Dim Usr_datecreateLabel As System.Windows.Forms.Label
        Dim Usr_employeeIDLabel As System.Windows.Forms.Label
        Dim Usr_departmentLabel As System.Windows.Forms.Label
        Dim Usr_emailLabel As System.Windows.Forms.Label
        Dim Usr_activeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_display))
        Me.Usr_levelTextBox = New System.Windows.Forms.TextBox()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBSDataSet = New CBS.CBSDataSet()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2ID = New System.Windows.Forms.Label()
        Me.Label2Usrn = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Usr_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Usr_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Usr_shortnameTextBox = New System.Windows.Forms.TextBox()
        Me.Usr_usernameTextBox = New System.Windows.Forms.TextBox()
        Me.Usr_datecreateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Usr_employeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.Usr_emailTextBox = New System.Windows.Forms.TextBox()
        Me.Usr_activeCheckBox = New System.Windows.Forms.CheckBox()
        Me.category = New System.Windows.Forms.TextBox()
        Me.usr_catselect = New System.Windows.Forms.ComboBox()
        Me.Usr_categoryTextBox = New System.Windows.Forms.TextBox()
        Me.Usr_departmentTextBox1 = New System.Windows.Forms.TextBox()
        Me.Usr_departmentTextBox = New System.Windows.Forms.ComboBox()
        Me.lvldisplay = New System.Windows.Forms.TextBox()
        Me.usr_lvlselect = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UsersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripchgpass = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UsrusernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsrnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsrdepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usr_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersTableAdapter = New CBS.CBSDataSetTableAdapters.usersTableAdapter()
        Me.TableAdapterManager = New CBS.CBSDataSetTableAdapters.TableAdapterManager()
        Usr_levelLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        Usr_IDLabel = New System.Windows.Forms.Label()
        Usr_nameLabel = New System.Windows.Forms.Label()
        Usr_shortnameLabel = New System.Windows.Forms.Label()
        Usr_usernameLabel = New System.Windows.Forms.Label()
        Usr_datecreateLabel = New System.Windows.Forms.Label()
        Usr_employeeIDLabel = New System.Windows.Forms.Label()
        Usr_departmentLabel = New System.Windows.Forms.Label()
        Usr_emailLabel = New System.Windows.Forms.Label()
        Usr_activeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsersBindingNavigator.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Usr_levelLabel
        '
        Usr_levelLabel.AutoSize = True
        Usr_levelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usr_levelLabel.Location = New System.Drawing.Point(13, 187)
        Usr_levelLabel.Name = "Usr_levelLabel"
        Usr_levelLabel.Size = New System.Drawing.Size(111, 20)
        Usr_levelLabel.TabIndex = 21
        Usr_levelLabel.Text = "Security Level:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoteLabel.Location = New System.Drawing.Point(21, 265)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(47, 20)
        NoteLabel.TabIndex = 25
        NoteLabel.Text = "Note:"
        '
        'Usr_IDLabel
        '
        Usr_IDLabel.AutoSize = True
        Usr_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usr_IDLabel.Location = New System.Drawing.Point(13, 22)
        Usr_IDLabel.Name = "Usr_IDLabel"
        Usr_IDLabel.Size = New System.Drawing.Size(30, 20)
        Usr_IDLabel.TabIndex = 22
        Usr_IDLabel.Text = "ID:"
        '
        'Usr_nameLabel
        '
        Usr_nameLabel.AutoSize = True
        Usr_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usr_nameLabel.Location = New System.Drawing.Point(13, 86)
        Usr_nameLabel.Name = "Usr_nameLabel"
        Usr_nameLabel.Size = New System.Drawing.Size(55, 20)
        Usr_nameLabel.TabIndex = 24
        Usr_nameLabel.Text = "Name:"
        '
        'Usr_shortnameLabel
        '
        Usr_shortnameLabel.AutoSize = True
        Usr_shortnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usr_shortnameLabel.Location = New System.Drawing.Point(310, 54)
        Usr_shortnameLabel.Name = "Usr_shortnameLabel"
        Usr_shortnameLabel.Size = New System.Drawing.Size(98, 20)
        Usr_shortnameLabel.TabIndex = 26
        Usr_shortnameLabel.Text = "Short Name:"
        '
        'Usr_usernameLabel
        '
        Usr_usernameLabel.AutoSize = True
        Usr_usernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usr_usernameLabel.Location = New System.Drawing.Point(13, 54)
        Usr_usernameLabel.Name = "Usr_usernameLabel"
        Usr_usernameLabel.Size = New System.Drawing.Size(87, 20)
        Usr_usernameLabel.TabIndex = 28
        Usr_usernameLabel.Text = "Username:"
        '
        'Usr_datecreateLabel
        '
        Usr_datecreateLabel.AutoSize = True
        Usr_datecreateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usr_datecreateLabel.Location = New System.Drawing.Point(307, 19)
        Usr_datecreateLabel.Name = "Usr_datecreateLabel"
        Usr_datecreateLabel.Size = New System.Drawing.Size(109, 20)
        Usr_datecreateLabel.TabIndex = 30
        Usr_datecreateLabel.Text = "Date Created:"
        '
        'Usr_employeeIDLabel
        '
        Usr_employeeIDLabel.AutoSize = True
        Usr_employeeIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usr_employeeIDLabel.Location = New System.Drawing.Point(13, 121)
        Usr_employeeIDLabel.Name = "Usr_employeeIDLabel"
        Usr_employeeIDLabel.Size = New System.Drawing.Size(104, 20)
        Usr_employeeIDLabel.TabIndex = 32
        Usr_employeeIDLabel.Text = "Employee ID:"
        '
        'Usr_departmentLabel
        '
        Usr_departmentLabel.AutoSize = True
        Usr_departmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usr_departmentLabel.Location = New System.Drawing.Point(264, 121)
        Usr_departmentLabel.Name = "Usr_departmentLabel"
        Usr_departmentLabel.Size = New System.Drawing.Size(98, 20)
        Usr_departmentLabel.TabIndex = 34
        Usr_departmentLabel.Text = "Department:"
        '
        'Usr_emailLabel
        '
        Usr_emailLabel.AutoSize = True
        Usr_emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usr_emailLabel.Location = New System.Drawing.Point(13, 152)
        Usr_emailLabel.Name = "Usr_emailLabel"
        Usr_emailLabel.Size = New System.Drawing.Size(57, 20)
        Usr_emailLabel.TabIndex = 36
        Usr_emailLabel.Text = "E-mail:"
        '
        'Usr_activeLabel
        '
        Usr_activeLabel.AutoSize = True
        Usr_activeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usr_activeLabel.Location = New System.Drawing.Point(369, 187)
        Usr_activeLabel.Name = "Usr_activeLabel"
        Usr_activeLabel.Size = New System.Drawing.Size(64, 20)
        Usr_activeLabel.TabIndex = 38
        Usr_activeLabel.Text = "Status :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(13, 221)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(77, 20)
        Label1.TabIndex = 44
        Label1.Text = "Category:"
        '
        'Usr_levelTextBox
        '
        Me.Usr_levelTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Usr_levelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "usr_level", True))
        Me.Usr_levelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UsersBindingSource, "usr_level", True))
        Me.Usr_levelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_levelTextBox.Location = New System.Drawing.Point(170, 267)
        Me.Usr_levelTextBox.Name = "Usr_levelTextBox"
        Me.Usr_levelTextBox.ReadOnly = True
        Me.Usr_levelTextBox.Size = New System.Drawing.Size(29, 20)
        Me.Usr_levelTextBox.TabIndex = 6
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.AllowNew = False
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.CBSDataSet
        '
        'CBSDataSet
        '
        Me.CBSDataSet.DataSetName = "CBSDataSet"
        Me.CBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "note", True))
        Me.NoteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteTextBox.Location = New System.Drawing.Point(124, 262)
        Me.NoteTextBox.Multiline = True
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(429, 72)
        Me.NoteTextBox.TabIndex = 8
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(602, 459)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Label2ID)
        Me.TabPage1.Controls.Add(Me.Label2Usrn)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.UsersBindingNavigator)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(594, 430)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detail"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2ID
        '
        Me.Label2ID.AutoSize = True
        Me.Label2ID.Location = New System.Drawing.Point(360, 396)
        Me.Label2ID.Name = "Label2ID"
        Me.Label2ID.Size = New System.Drawing.Size(54, 13)
        Me.Label2ID.TabIndex = 46
        Me.Label2ID.Text = "Trigger ID"
        Me.Label2ID.Visible = False
        '
        'Label2Usrn
        '
        Me.Label2Usrn.AutoSize = True
        Me.Label2Usrn.Location = New System.Drawing.Point(250, 396)
        Me.Label2Usrn.Name = "Label2Usrn"
        Me.Label2Usrn.Size = New System.Drawing.Size(91, 13)
        Me.Label2Usrn.TabIndex = 45
        Me.Label2Usrn.Text = "Trigger Username"
        Me.Label2Usrn.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(504, 384)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 37)
        Me.Button4.TabIndex = 44
        Me.Button4.Text = "&Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(NoteLabel)
        Me.GroupBox1.Controls.Add(Me.NoteTextBox)
        Me.GroupBox1.Controls.Add(Usr_IDLabel)
        Me.GroupBox1.Controls.Add(Usr_levelLabel)
        Me.GroupBox1.Controls.Add(Me.Usr_IDTextBox)
        Me.GroupBox1.Controls.Add(Usr_nameLabel)
        Me.GroupBox1.Controls.Add(Me.Usr_nameTextBox)
        Me.GroupBox1.Controls.Add(Usr_shortnameLabel)
        Me.GroupBox1.Controls.Add(Me.Usr_shortnameTextBox)
        Me.GroupBox1.Controls.Add(Usr_usernameLabel)
        Me.GroupBox1.Controls.Add(Me.Usr_usernameTextBox)
        Me.GroupBox1.Controls.Add(Usr_datecreateLabel)
        Me.GroupBox1.Controls.Add(Me.Usr_datecreateDateTimePicker)
        Me.GroupBox1.Controls.Add(Usr_employeeIDLabel)
        Me.GroupBox1.Controls.Add(Me.Usr_employeeIDTextBox)
        Me.GroupBox1.Controls.Add(Usr_departmentLabel)
        Me.GroupBox1.Controls.Add(Usr_emailLabel)
        Me.GroupBox1.Controls.Add(Me.Usr_emailTextBox)
        Me.GroupBox1.Controls.Add(Me.Usr_activeCheckBox)
        Me.GroupBox1.Controls.Add(Usr_activeLabel)
        Me.GroupBox1.Controls.Add(Me.Usr_levelTextBox)
        Me.GroupBox1.Controls.Add(Me.category)
        Me.GroupBox1.Controls.Add(Me.usr_catselect)
        Me.GroupBox1.Controls.Add(Me.Usr_categoryTextBox)
        Me.GroupBox1.Controls.Add(Me.Usr_departmentTextBox1)
        Me.GroupBox1.Controls.Add(Me.Usr_departmentTextBox)
        Me.GroupBox1.Controls.Add(Me.lvldisplay)
        Me.GroupBox1.Controls.Add(Me.usr_lvlselect)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 347)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'Usr_IDTextBox
        '
        Me.Usr_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "usr_ID", True))
        Me.Usr_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_IDTextBox.Location = New System.Drawing.Point(124, 19)
        Me.Usr_IDTextBox.Name = "Usr_IDTextBox"
        Me.Usr_IDTextBox.ReadOnly = True
        Me.Usr_IDTextBox.Size = New System.Drawing.Size(66, 26)
        Me.Usr_IDTextBox.TabIndex = 23
        '
        'Usr_nameTextBox
        '
        Me.Usr_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "usr_name", True))
        Me.Usr_nameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_nameTextBox.Location = New System.Drawing.Point(124, 83)
        Me.Usr_nameTextBox.Name = "Usr_nameTextBox"
        Me.Usr_nameTextBox.Size = New System.Drawing.Size(429, 26)
        Me.Usr_nameTextBox.TabIndex = 2
        '
        'Usr_shortnameTextBox
        '
        Me.Usr_shortnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "usr_shortname", True))
        Me.Usr_shortnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_shortnameTextBox.Location = New System.Drawing.Point(414, 50)
        Me.Usr_shortnameTextBox.Name = "Usr_shortnameTextBox"
        Me.Usr_shortnameTextBox.Size = New System.Drawing.Size(139, 26)
        Me.Usr_shortnameTextBox.TabIndex = 1
        '
        'Usr_usernameTextBox
        '
        Me.Usr_usernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "usr_username", True))
        Me.Usr_usernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_usernameTextBox.Location = New System.Drawing.Point(124, 51)
        Me.Usr_usernameTextBox.Name = "Usr_usernameTextBox"
        Me.Usr_usernameTextBox.ReadOnly = True
        Me.Usr_usernameTextBox.Size = New System.Drawing.Size(122, 26)
        Me.Usr_usernameTextBox.TabIndex = 0
        '
        'Usr_datecreateDateTimePicker
        '
        Me.Usr_datecreateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UsersBindingSource, "usr_datecreate", True))
        Me.Usr_datecreateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_datecreateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Usr_datecreateDateTimePicker.Location = New System.Drawing.Point(422, 15)
        Me.Usr_datecreateDateTimePicker.Name = "Usr_datecreateDateTimePicker"
        Me.Usr_datecreateDateTimePicker.Size = New System.Drawing.Size(131, 26)
        Me.Usr_datecreateDateTimePicker.TabIndex = 31
        '
        'Usr_employeeIDTextBox
        '
        Me.Usr_employeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "usr_employeeID", True))
        Me.Usr_employeeIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_employeeIDTextBox.Location = New System.Drawing.Point(124, 117)
        Me.Usr_employeeIDTextBox.Name = "Usr_employeeIDTextBox"
        Me.Usr_employeeIDTextBox.Size = New System.Drawing.Size(122, 26)
        Me.Usr_employeeIDTextBox.TabIndex = 3
        '
        'Usr_emailTextBox
        '
        Me.Usr_emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "usr_email", True))
        Me.Usr_emailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_emailTextBox.Location = New System.Drawing.Point(124, 149)
        Me.Usr_emailTextBox.Name = "Usr_emailTextBox"
        Me.Usr_emailTextBox.Size = New System.Drawing.Size(427, 26)
        Me.Usr_emailTextBox.TabIndex = 5
        '
        'Usr_activeCheckBox
        '
        Me.Usr_activeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "usr_active", True))
        Me.Usr_activeCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_activeCheckBox.Location = New System.Drawing.Point(430, 186)
        Me.Usr_activeCheckBox.Name = "Usr_activeCheckBox"
        Me.Usr_activeCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.Usr_activeCheckBox.TabIndex = 7
        Me.Usr_activeCheckBox.Text = "CheckBox1"
        Me.Usr_activeCheckBox.UseVisualStyleBackColor = True
        '
        'category
        '
        Me.category.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category.Location = New System.Drawing.Point(124, 219)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(241, 26)
        Me.category.TabIndex = 50
        '
        'usr_catselect
        '
        Me.usr_catselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.usr_catselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usr_catselect.FormattingEnabled = True
        Me.usr_catselect.Items.AddRange(New Object() {"Office", "Management", "Production"})
        Me.usr_catselect.Location = New System.Drawing.Point(124, 218)
        Me.usr_catselect.Name = "usr_catselect"
        Me.usr_catselect.Size = New System.Drawing.Size(238, 28)
        Me.usr_catselect.TabIndex = 45
        '
        'Usr_categoryTextBox
        '
        Me.Usr_categoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "usr_category", True))
        Me.Usr_categoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UsersBindingSource, "usr_category", True))
        Me.Usr_categoryTextBox.Location = New System.Drawing.Point(137, 267)
        Me.Usr_categoryTextBox.Name = "Usr_categoryTextBox"
        Me.Usr_categoryTextBox.Size = New System.Drawing.Size(27, 20)
        Me.Usr_categoryTextBox.TabIndex = 47
        '
        'Usr_departmentTextBox1
        '
        Me.Usr_departmentTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "usr_department", True))
        Me.Usr_departmentTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UsersBindingSource, "usr_department", True))
        Me.Usr_departmentTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_departmentTextBox1.Location = New System.Drawing.Point(370, 118)
        Me.Usr_departmentTextBox1.Name = "Usr_departmentTextBox1"
        Me.Usr_departmentTextBox1.Size = New System.Drawing.Size(183, 26)
        Me.Usr_departmentTextBox1.TabIndex = 46
        '
        'Usr_departmentTextBox
        '
        Me.Usr_departmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "usr_department", True))
        Me.Usr_departmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.UsersBindingSource, "usr_department", True))
        Me.Usr_departmentTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Usr_departmentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_departmentTextBox.FormattingEnabled = True
        Me.Usr_departmentTextBox.Items.AddRange(New Object() {"", "Account", "Admin", "EDP", "Costing", "Customer Service", "Design", "Maintenance", "Management", "Marketing", "Planning", "Purchasing", "QAQC", "Research & Development", "Safety", "Warehouse", "Others (Not in List)"})
        Me.Usr_departmentTextBox.Location = New System.Drawing.Point(370, 117)
        Me.Usr_departmentTextBox.Name = "Usr_departmentTextBox"
        Me.Usr_departmentTextBox.Size = New System.Drawing.Size(185, 28)
        Me.Usr_departmentTextBox.TabIndex = 42
        '
        'lvldisplay
        '
        Me.lvldisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvldisplay.Location = New System.Drawing.Point(125, 185)
        Me.lvldisplay.Name = "lvldisplay"
        Me.lvldisplay.Size = New System.Drawing.Size(241, 26)
        Me.lvldisplay.TabIndex = 49
        '
        'usr_lvlselect
        '
        Me.usr_lvlselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.usr_lvlselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usr_lvlselect.FormattingEnabled = True
        Me.usr_lvlselect.Items.AddRange(New Object() {"Administrator", "User", "Approval - Management", "Approval - Admin", "Approval - Production", "Supervisor (Vehicle Manage)", "Security / Guard", "Admin(Card Control)"})
        Me.usr_lvlselect.Location = New System.Drawing.Point(125, 184)
        Me.usr_lvlselect.Name = "usr_lvlselect"
        Me.usr_lvlselect.Size = New System.Drawing.Size(238, 28)
        Me.usr_lvlselect.TabIndex = 43
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(504, 384)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 37)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "&Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(28, 384)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 37)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "&Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 37)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UsersBindingNavigator
        '
        Me.UsersBindingNavigator.AddNewItem = Nothing
        Me.UsersBindingNavigator.BindingSource = Me.UsersBindingSource
        Me.UsersBindingNavigator.CountItem = Nothing
        Me.UsersBindingNavigator.DeleteItem = Nothing
        Me.UsersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripchgpass, Me.ToolStripSeparator1, Me.UsersBindingNavigatorSaveItem})
        Me.UsersBindingNavigator.Location = New System.Drawing.Point(3, 3)
        Me.UsersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsersBindingNavigator.Name = "UsersBindingNavigator"
        Me.UsersBindingNavigator.PositionItem = Nothing
        Me.UsersBindingNavigator.Size = New System.Drawing.Size(588, 25)
        Me.UsersBindingNavigator.TabIndex = 21
        Me.UsersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripchgpass
        '
        Me.ToolStripchgpass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripchgpass.Image = CType(resources.GetObject("ToolStripchgpass.Image"), System.Drawing.Image)
        Me.ToolStripchgpass.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripchgpass.Name = "ToolStripchgpass"
        Me.ToolStripchgpass.Size = New System.Drawing.Size(92, 22)
        Me.ToolStripchgpass.Text = "&Reset Password"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'UsersBindingNavigatorSaveItem
        '
        Me.UsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsersBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsersBindingNavigatorSaveItem.Name = "UsersBindingNavigatorSaveItem"
        Me.UsersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UsersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(594, 430)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lists"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsrusernameDataGridViewTextBoxColumn, Me.UsrnameDataGridViewTextBoxColumn, Me.UsrdepartmentDataGridViewTextBoxColumn, Me.usr_ID})
        Me.DataGridView1.DataSource = Me.UsersBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 22
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(588, 424)
        Me.DataGridView1.TabIndex = 0
        '
        'UsrusernameDataGridViewTextBoxColumn
        '
        Me.UsrusernameDataGridViewTextBoxColumn.DataPropertyName = "usr_username"
        Me.UsrusernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsrusernameDataGridViewTextBoxColumn.Name = "UsrusernameDataGridViewTextBoxColumn"
        Me.UsrusernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsrusernameDataGridViewTextBoxColumn.Width = 140
        '
        'UsrnameDataGridViewTextBoxColumn
        '
        Me.UsrnameDataGridViewTextBoxColumn.DataPropertyName = "usr_name"
        Me.UsrnameDataGridViewTextBoxColumn.HeaderText = "Full Name"
        Me.UsrnameDataGridViewTextBoxColumn.Name = "UsrnameDataGridViewTextBoxColumn"
        Me.UsrnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsrnameDataGridViewTextBoxColumn.Width = 240
        '
        'UsrdepartmentDataGridViewTextBoxColumn
        '
        Me.UsrdepartmentDataGridViewTextBoxColumn.DataPropertyName = "usr_department"
        Me.UsrdepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.UsrdepartmentDataGridViewTextBoxColumn.Name = "UsrdepartmentDataGridViewTextBoxColumn"
        Me.UsrdepartmentDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsrdepartmentDataGridViewTextBoxColumn.Width = 200
        '
        'usr_ID
        '
        Me.usr_ID.DataPropertyName = "usr_ID"
        Me.usr_ID.HeaderText = "usr_ID"
        Me.usr_ID.Name = "usr_ID"
        Me.usr_ID.ReadOnly = True
        Me.usr_ID.Visible = False
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bookingTableAdapter = Nothing
        Me.TableAdapterManager.lorry_rt_historyTableAdapter = Nothing
        Me.TableAdapterManager.lorryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CBS.CBSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Me.UsersTableAdapter
        Me.TableAdapterManager.vehicle_rt_historyTableAdapter = Nothing
        Me.TableAdapterManager.vehicleTableAdapter = Nothing
        '
        'user_display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 471)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "user_display"
        Me.Text = "User Information"
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsersBindingNavigator.ResumeLayout(False)
        Me.UsersBindingNavigator.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CBSDataSet As CBSDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As CBSDataSetTableAdapters.usersTableAdapter
    Friend WithEvents TableAdapterManager As CBSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Usr_levelTextBox As TextBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Usr_IDTextBox As TextBox
    Friend WithEvents Usr_nameTextBox As TextBox
    Friend WithEvents Usr_shortnameTextBox As TextBox
    Friend WithEvents Usr_usernameTextBox As TextBox
    Friend WithEvents Usr_datecreateDateTimePicker As DateTimePicker
    Friend WithEvents Usr_employeeIDTextBox As TextBox
    Friend WithEvents Usr_emailTextBox As TextBox
    Friend WithEvents Usr_activeCheckBox As CheckBox
    Friend WithEvents UsersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents UsersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ToolStripchgpass As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Usr_departmentTextBox As ComboBox
    Friend WithEvents UsrusernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsrnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsrdepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents usr_ID As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents usr_lvlselect As ComboBox
    Friend WithEvents usr_catselect As ComboBox
    Friend WithEvents Usr_departmentTextBox1 As TextBox
    Friend WithEvents Usr_categoryTextBox As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents category As TextBox
    Friend WithEvents lvldisplay As TextBox
    Friend WithEvents Label2Usrn As Label
    Friend WithEvents Label2ID As Label
End Class
