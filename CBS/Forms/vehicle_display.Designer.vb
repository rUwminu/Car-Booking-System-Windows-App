<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vehicle_display
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
        Dim Vhc_modelLabel As System.Windows.Forms.Label
        Dim Vhc_noteLabel As System.Windows.Forms.Label
        Dim Vhc_brandLabel As System.Windows.Forms.Label
        Dim Vhc_typeLabel As System.Windows.Forms.Label
        Dim Vhc_PlateNoLabel As System.Windows.Forms.Label
        Dim Vhc_yearLabel As System.Windows.Forms.Label
        Dim Vhc_obsoleteLabel As System.Windows.Forms.Label
        Dim Vhc_IDLabel As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vehicle_display))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBoxIns = New System.Windows.Forms.TextBox()
        Me.LabelAlertInsurance = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.MeterLeftLabel = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Vhc_typeTextBox = New System.Windows.Forms.ComboBox()
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBSDataSet = New CBS.CBSDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chgpix = New System.Windows.Forms.Button()
        Me.LBP1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Vhc_yearTextBox = New System.Windows.Forms.TextBox()
        Me.Vhc_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Vhc_PlateNoTextBox = New System.Windows.Forms.TextBox()
        Me.Vhc_noteTextBox = New System.Windows.Forms.TextBox()
        Me.Vhc_brandTextBox = New System.Windows.Forms.TextBox()
        Me.Vhc_modelTextBox = New System.Windows.Forms.TextBox()
        Me.vrrdate = New System.Windows.Forms.TextBox()
        Me.vobsolete = New System.Windows.Forms.TextBox()
        Me.picloc = New System.Windows.Forms.TextBox()
        Me.vhc_cattext = New System.Windows.Forms.TextBox()
        Me.categoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Vhc_categoryTextBox = New System.Windows.Forms.TextBox()
        Me.VehicleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VehicleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Vhc_roadtaxDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VhcPlateNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VhcmodelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VhctypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhc_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolsDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btyButton = New System.Windows.Forms.Button()
        Me.statusButton = New System.Windows.Forms.Button()
        Me.statusgroup = New System.Windows.Forms.GroupBox()
        Me.statushistory = New System.Windows.Forms.LinkLabel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.vhcrp_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcrp_faultpart01 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcrp_remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcrp_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcrp_IsUpdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcrp_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vhcrpID = New System.Windows.Forms.TextBox()
        Me.tyreButton = New System.Windows.Forms.Button()
        Me.oilButton = New System.Windows.Forms.Button()
        Me.batterygroup = New System.Windows.Forms.GroupBox()
        Me.btychgdate = New System.Windows.Forms.TextBox()
        Me.BtyHistory = New System.Windows.Forms.LinkLabel()
        Me.btyexp = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btywarranty = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.batterydate = New System.Windows.Forms.DateTimePicker()
        Me.tyregroup = New System.Windows.Forms.GroupBox()
        Me.rrityredatetext = New System.Windows.Forms.TextBox()
        Me.rlityredatetext = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.rritype = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.rlitype = New System.Windows.Forms.TextBox()
        Me.rrtyredatetext = New System.Windows.Forms.TextBox()
        Me.frtyredatetext = New System.Windows.Forms.TextBox()
        Me.rltyredatetext = New System.Windows.Forms.TextBox()
        Me.fltyredatetext = New System.Windows.Forms.TextBox()
        Me.TyreHistory = New System.Windows.Forms.LinkLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rrtype = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.frtype = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rltype = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.fltype = New System.Windows.Forms.TextBox()
        Me.oilgroup = New System.Windows.Forms.GroupBox()
        Me.oilchangedate = New System.Windows.Forms.TextBox()
        Me.engoilshi = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.vhc_ChgMeter = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.vhc_CurrMeter = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.VehicleTableAdapter = New CBS.CBSDataSetTableAdapters.vehicleTableAdapter()
        Me.TableAdapterManager = New CBS.CBSDataSetTableAdapters.TableAdapterManager()
        Vhc_modelLabel = New System.Windows.Forms.Label()
        Vhc_noteLabel = New System.Windows.Forms.Label()
        Vhc_brandLabel = New System.Windows.Forms.Label()
        Vhc_typeLabel = New System.Windows.Forms.Label()
        Vhc_PlateNoLabel = New System.Windows.Forms.Label()
        Vhc_yearLabel = New System.Windows.Forms.Label()
        Vhc_obsoleteLabel = New System.Windows.Forms.Label()
        Vhc_IDLabel = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VehicleBindingNavigator.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.statusgroup.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.batterygroup.SuspendLayout()
        Me.tyregroup.SuspendLayout()
        Me.oilgroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'Vhc_modelLabel
        '
        Vhc_modelLabel.AutoSize = True
        Vhc_modelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Vhc_modelLabel.Location = New System.Drawing.Point(6, 115)
        Vhc_modelLabel.Name = "Vhc_modelLabel"
        Vhc_modelLabel.Size = New System.Drawing.Size(56, 20)
        Vhc_modelLabel.TabIndex = 26
        Vhc_modelLabel.Text = "Model:"
        '
        'Vhc_noteLabel
        '
        Vhc_noteLabel.AutoSize = True
        Vhc_noteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Vhc_noteLabel.Location = New System.Drawing.Point(6, 216)
        Vhc_noteLabel.Name = "Vhc_noteLabel"
        Vhc_noteLabel.Size = New System.Drawing.Size(47, 20)
        Vhc_noteLabel.TabIndex = 32
        Vhc_noteLabel.Text = "Note:"
        '
        'Vhc_brandLabel
        '
        Vhc_brandLabel.AutoSize = True
        Vhc_brandLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Vhc_brandLabel.Location = New System.Drawing.Point(6, 83)
        Vhc_brandLabel.Name = "Vhc_brandLabel"
        Vhc_brandLabel.Size = New System.Drawing.Size(56, 20)
        Vhc_brandLabel.TabIndex = 24
        Vhc_brandLabel.Text = "Brand:"
        '
        'Vhc_typeLabel
        '
        Vhc_typeLabel.AutoSize = True
        Vhc_typeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Vhc_typeLabel.Location = New System.Drawing.Point(6, 147)
        Vhc_typeLabel.Name = "Vhc_typeLabel"
        Vhc_typeLabel.Size = New System.Drawing.Size(47, 20)
        Vhc_typeLabel.TabIndex = 38
        Vhc_typeLabel.Text = "Type:"
        '
        'Vhc_PlateNoLabel
        '
        Vhc_PlateNoLabel.AutoSize = True
        Vhc_PlateNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Vhc_PlateNoLabel.Location = New System.Drawing.Point(6, 51)
        Vhc_PlateNoLabel.Name = "Vhc_PlateNoLabel"
        Vhc_PlateNoLabel.Size = New System.Drawing.Size(111, 20)
        Vhc_PlateNoLabel.TabIndex = 22
        Vhc_PlateNoLabel.Text = "Reg./Plate No:"
        '
        'Vhc_yearLabel
        '
        Vhc_yearLabel.AutoSize = True
        Vhc_yearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Vhc_yearLabel.Location = New System.Drawing.Point(6, 185)
        Vhc_yearLabel.Name = "Vhc_yearLabel"
        Vhc_yearLabel.Size = New System.Drawing.Size(142, 20)
        Vhc_yearLabel.TabIndex = 40
        Vhc_yearLabel.Text = "Vehicle Build Year:"
        '
        'Vhc_obsoleteLabel
        '
        Vhc_obsoleteLabel.AutoSize = True
        Vhc_obsoleteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Vhc_obsoleteLabel.Location = New System.Drawing.Point(6, 333)
        Vhc_obsoleteLabel.Name = "Vhc_obsoleteLabel"
        Vhc_obsoleteLabel.Size = New System.Drawing.Size(77, 20)
        Vhc_obsoleteLabel.TabIndex = 42
        Vhc_obsoleteLabel.Text = "Obsolete:"
        '
        'Vhc_IDLabel
        '
        Vhc_IDLabel.AutoSize = True
        Vhc_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Vhc_IDLabel.Location = New System.Drawing.Point(6, 19)
        Vhc_IDLabel.Name = "Vhc_IDLabel"
        Vhc_IDLabel.Size = New System.Drawing.Size(30, 20)
        Vhc_IDLabel.TabIndex = 20
        Vhc_IDLabel.Text = "ID:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.Location = New System.Drawing.Point(6, 307)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(133, 20)
        Label15.TabIndex = 54
        Label15.Text = "Vehicle Category:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(872, 567)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.TextBoxIns)
        Me.TabPage1.Controls.Add(Me.LabelAlertInsurance)
        Me.TabPage1.Controls.Add(Me.LinkLabel2)
        Me.TabPage1.Controls.Add(Me.MeterLeftLabel)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Button8)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.LinkLabel1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.VehicleBindingNavigator)
        Me.TabPage1.Controls.Add(Me.Vhc_roadtaxDateTimePicker)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(864, 538)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detail"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TextBoxIns
        '
        Me.TextBoxIns.Enabled = False
        Me.TextBoxIns.Location = New System.Drawing.Point(168, 449)
        Me.TextBoxIns.Name = "TextBoxIns"
        Me.TextBoxIns.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxIns.TabIndex = 65
        '
        'LabelAlertInsurance
        '
        Me.LabelAlertInsurance.AutoSize = True
        Me.LabelAlertInsurance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlertInsurance.Location = New System.Drawing.Point(165, 456)
        Me.LabelAlertInsurance.Name = "LabelAlertInsurance"
        Me.LabelAlertInsurance.Size = New System.Drawing.Size(201, 16)
        Me.LabelAlertInsurance.TabIndex = 64
        Me.LabelAlertInsurance.Text = "PLEASE UPDATE INSURANCE"
        Me.LabelAlertInsurance.Visible = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(6, 452)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(156, 20)
        Me.LinkLabel2.TabIndex = 63
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Insurance exp. Date:"
        '
        'MeterLeftLabel
        '
        Me.MeterLeftLabel.AutoSize = True
        Me.MeterLeftLabel.Location = New System.Drawing.Point(165, 509)
        Me.MeterLeftLabel.Name = "MeterLeftLabel"
        Me.MeterLeftLabel.Size = New System.Drawing.Size(59, 17)
        Me.MeterLeftLabel.TabIndex = 58
        Me.MeterLeftLabel.Text = "Label17"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 509)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(114, 17)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Next Service In : "
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(779, 414)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(67, 29)
        Me.Button8.TabIndex = 53
        Me.Button8.Text = "&CANCEL"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(681, 377)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(165, 29)
        Me.Button5.TabIndex = 52
        Me.Button5.Text = "Show other Information"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(11, 407)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(153, 20)
        Me.LinkLabel1.TabIndex = 52
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Road Tax exp. Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(19, 479)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 22)
        Me.Label5.TabIndex = 51
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(779, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 29)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(681, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 29)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "&EDIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label15)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Vhc_typeTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chgpix)
        Me.GroupBox1.Controls.Add(Vhc_IDLabel)
        Me.GroupBox1.Controls.Add(Me.LBP1)
        Me.GroupBox1.Controls.Add(Vhc_obsoleteLabel)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Vhc_yearTextBox)
        Me.GroupBox1.Controls.Add(Vhc_yearLabel)
        Me.GroupBox1.Controls.Add(Me.Vhc_IDTextBox)
        Me.GroupBox1.Controls.Add(Vhc_PlateNoLabel)
        Me.GroupBox1.Controls.Add(Vhc_typeLabel)
        Me.GroupBox1.Controls.Add(Me.Vhc_PlateNoTextBox)
        Me.GroupBox1.Controls.Add(Me.Vhc_noteTextBox)
        Me.GroupBox1.Controls.Add(Vhc_brandLabel)
        Me.GroupBox1.Controls.Add(Vhc_noteLabel)
        Me.GroupBox1.Controls.Add(Me.Vhc_brandTextBox)
        Me.GroupBox1.Controls.Add(Vhc_modelLabel)
        Me.GroupBox1.Controls.Add(Me.Vhc_modelTextBox)
        Me.GroupBox1.Controls.Add(Me.vrrdate)
        Me.GroupBox1.Controls.Add(Me.vobsolete)
        Me.GroupBox1.Controls.Add(Me.picloc)
        Me.GroupBox1.Controls.Add(Me.vhc_cattext)
        Me.GroupBox1.Controls.Add(Me.categoryComboBox)
        Me.GroupBox1.Controls.Add(Me.Vhc_categoryTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(838, 363)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(555, 276)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(123, 29)
        Me.Button7.TabIndex = 52
        Me.Button7.Text = "Update Picture"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(700, 276)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 29)
        Me.Button4.TabIndex = 51
        Me.Button4.Text = "Remove Picture"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Vhc_typeTextBox
        '
        Me.Vhc_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "vhc_type", True))
        Me.Vhc_typeTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Vhc_typeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vhc_typeTextBox.FormattingEnabled = True
        Me.Vhc_typeTextBox.Items.AddRange(New Object() {"CAR", "Multi-Purpose Vehicle (MPV)", "Motorcycle", "Luxury Vehicle", "Van"})
        Me.Vhc_typeTextBox.Location = New System.Drawing.Point(163, 144)
        Me.Vhc_typeTextBox.Name = "Vhc_typeTextBox"
        Me.Vhc_typeTextBox.Size = New System.Drawing.Size(233, 28)
        Me.Vhc_typeTextBox.TabIndex = 3
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataMember = "vehicle"
        Me.VehicleBindingSource.DataSource = Me.CBSDataSet
        '
        'CBSDataSet
        '
        Me.CBSDataSet.DataSetName = "CBSDataSet"
        Me.CBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(149, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 17)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(149, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(149, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "*"
        '
        'chgpix
        '
        Me.chgpix.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chgpix.Location = New System.Drawing.Point(413, 276)
        Me.chgpix.Name = "chgpix"
        Me.chgpix.Size = New System.Drawing.Size(123, 29)
        Me.chgpix.TabIndex = 6
        Me.chgpix.Text = "Change Picture"
        Me.chgpix.UseVisualStyleBackColor = True
        '
        'LBP1
        '
        Me.LBP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBP1.Location = New System.Drawing.Point(409, 22)
        Me.LBP1.Name = "LBP1"
        Me.LBP1.Size = New System.Drawing.Size(423, 248)
        Me.LBP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LBP1.TabIndex = 44
        Me.LBP1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VehicleBindingSource, "vhc_obsolete", True))
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(163, 333)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(161, 24)
        Me.CheckBox1.TabIndex = 43
        Me.CheckBox1.Text = "Obsolete The Car?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Vhc_yearTextBox
        '
        Me.Vhc_yearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "vhc_year", True))
        Me.Vhc_yearTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vhc_yearTextBox.Location = New System.Drawing.Point(163, 182)
        Me.Vhc_yearTextBox.Name = "Vhc_yearTextBox"
        Me.Vhc_yearTextBox.Size = New System.Drawing.Size(233, 26)
        Me.Vhc_yearTextBox.TabIndex = 4
        '
        'Vhc_IDTextBox
        '
        Me.Vhc_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "vhc_ID", True))
        Me.Vhc_IDTextBox.Enabled = False
        Me.Vhc_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vhc_IDTextBox.Location = New System.Drawing.Point(163, 16)
        Me.Vhc_IDTextBox.Name = "Vhc_IDTextBox"
        Me.Vhc_IDTextBox.Size = New System.Drawing.Size(49, 26)
        Me.Vhc_IDTextBox.TabIndex = 21
        Me.Vhc_IDTextBox.TabStop = False
        '
        'Vhc_PlateNoTextBox
        '
        Me.Vhc_PlateNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "vhc_PlateNo", True))
        Me.Vhc_PlateNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vhc_PlateNoTextBox.Location = New System.Drawing.Point(163, 48)
        Me.Vhc_PlateNoTextBox.Name = "Vhc_PlateNoTextBox"
        Me.Vhc_PlateNoTextBox.ReadOnly = True
        Me.Vhc_PlateNoTextBox.Size = New System.Drawing.Size(233, 26)
        Me.Vhc_PlateNoTextBox.TabIndex = 0
        '
        'Vhc_noteTextBox
        '
        Me.Vhc_noteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "vhc_note", True))
        Me.Vhc_noteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vhc_noteTextBox.Location = New System.Drawing.Point(163, 213)
        Me.Vhc_noteTextBox.Multiline = True
        Me.Vhc_noteTextBox.Name = "Vhc_noteTextBox"
        Me.Vhc_noteTextBox.Size = New System.Drawing.Size(233, 85)
        Me.Vhc_noteTextBox.TabIndex = 5
        '
        'Vhc_brandTextBox
        '
        Me.Vhc_brandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "vhc_brand", True))
        Me.Vhc_brandTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vhc_brandTextBox.Location = New System.Drawing.Point(163, 80)
        Me.Vhc_brandTextBox.Name = "Vhc_brandTextBox"
        Me.Vhc_brandTextBox.Size = New System.Drawing.Size(233, 26)
        Me.Vhc_brandTextBox.TabIndex = 1
        '
        'Vhc_modelTextBox
        '
        Me.Vhc_modelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "vhc_model", True))
        Me.Vhc_modelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vhc_modelTextBox.Location = New System.Drawing.Point(163, 112)
        Me.Vhc_modelTextBox.Name = "Vhc_modelTextBox"
        Me.Vhc_modelTextBox.Size = New System.Drawing.Size(233, 26)
        Me.Vhc_modelTextBox.TabIndex = 2
        '
        'vrrdate
        '
        Me.vrrdate.Location = New System.Drawing.Point(438, 246)
        Me.vrrdate.Name = "vrrdate"
        Me.vrrdate.Size = New System.Drawing.Size(18, 23)
        Me.vrrdate.TabIndex = 50
        Me.vrrdate.TabStop = False
        '
        'vobsolete
        '
        Me.vobsolete.Location = New System.Drawing.Point(413, 246)
        Me.vobsolete.Name = "vobsolete"
        Me.vobsolete.Size = New System.Drawing.Size(18, 23)
        Me.vobsolete.TabIndex = 47
        Me.vobsolete.TabStop = False
        '
        'picloc
        '
        Me.picloc.Location = New System.Drawing.Point(462, 246)
        Me.picloc.Name = "picloc"
        Me.picloc.Size = New System.Drawing.Size(21, 23)
        Me.picloc.TabIndex = 46
        Me.picloc.TabStop = False
        '
        'vhc_cattext
        '
        Me.vhc_cattext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhc_cattext.Location = New System.Drawing.Point(163, 305)
        Me.vhc_cattext.Name = "vhc_cattext"
        Me.vhc_cattext.Size = New System.Drawing.Size(233, 26)
        Me.vhc_cattext.TabIndex = 56
        '
        'categoryComboBox
        '
        Me.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categoryComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoryComboBox.FormattingEnabled = True
        Me.categoryComboBox.Items.AddRange(New Object() {"Admin", "Management", "Production"})
        Me.categoryComboBox.Location = New System.Drawing.Point(163, 304)
        Me.categoryComboBox.Name = "categoryComboBox"
        Me.categoryComboBox.Size = New System.Drawing.Size(233, 28)
        Me.categoryComboBox.TabIndex = 55
        '
        'Vhc_categoryTextBox
        '
        Me.Vhc_categoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "vhc_category", True))
        Me.Vhc_categoryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vhc_categoryTextBox.Location = New System.Drawing.Point(361, 308)
        Me.Vhc_categoryTextBox.Name = "Vhc_categoryTextBox"
        Me.Vhc_categoryTextBox.Size = New System.Drawing.Size(24, 20)
        Me.Vhc_categoryTextBox.TabIndex = 54
        '
        'VehicleBindingNavigator
        '
        Me.VehicleBindingNavigator.AddNewItem = Nothing
        Me.VehicleBindingNavigator.BindingSource = Me.VehicleBindingSource
        Me.VehicleBindingNavigator.CountItem = Nothing
        Me.VehicleBindingNavigator.DeleteItem = Nothing
        Me.VehicleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.VehicleBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.VehicleBindingNavigator.Location = New System.Drawing.Point(3, 3)
        Me.VehicleBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VehicleBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VehicleBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VehicleBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VehicleBindingNavigator.Name = "VehicleBindingNavigator"
        Me.VehicleBindingNavigator.PositionItem = Nothing
        Me.VehicleBindingNavigator.Size = New System.Drawing.Size(858, 25)
        Me.VehicleBindingNavigator.TabIndex = 0
        Me.VehicleBindingNavigator.Text = "BindingNavigator1"
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
        'VehicleBindingNavigatorSaveItem
        '
        Me.VehicleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VehicleBindingNavigatorSaveItem.Image = CType(resources.GetObject("VehicleBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VehicleBindingNavigatorSaveItem.Name = "VehicleBindingNavigatorSaveItem"
        Me.VehicleBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VehicleBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripButton1.Text = "Refresh"
        Me.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Vhc_roadtaxDateTimePicker
        '
        Me.Vhc_roadtaxDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VehicleBindingSource, "vhc_roadtax", True))
        Me.Vhc_roadtaxDateTimePicker.Enabled = False
        Me.Vhc_roadtaxDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vhc_roadtaxDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Vhc_roadtaxDateTimePicker.Location = New System.Drawing.Point(168, 407)
        Me.Vhc_roadtaxDateTimePicker.Name = "Vhc_roadtaxDateTimePicker"
        Me.Vhc_roadtaxDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Vhc_roadtaxDateTimePicker.TabIndex = 31
        Me.Vhc_roadtaxDateTimePicker.TabStop = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(681, 414)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 29)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "&SAVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(864, 538)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VhcPlateNoDataGridViewTextBoxColumn, Me.vhc_brand, Me.VhcmodelDataGridViewTextBoxColumn, Me.VhctypeDataGridViewTextBoxColumn, Me.vhc_ID})
        Me.DataGridView1.DataSource = Me.VehicleBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 22
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(858, 532)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'VhcPlateNoDataGridViewTextBoxColumn
        '
        Me.VhcPlateNoDataGridViewTextBoxColumn.DataPropertyName = "vhc_PlateNo"
        Me.VhcPlateNoDataGridViewTextBoxColumn.HeaderText = "Plate No"
        Me.VhcPlateNoDataGridViewTextBoxColumn.Name = "VhcPlateNoDataGridViewTextBoxColumn"
        Me.VhcPlateNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.VhcPlateNoDataGridViewTextBoxColumn.Width = 160
        '
        'vhc_brand
        '
        Me.vhc_brand.DataPropertyName = "vhc_brand"
        Me.vhc_brand.HeaderText = "Brand"
        Me.vhc_brand.Name = "vhc_brand"
        Me.vhc_brand.ReadOnly = True
        Me.vhc_brand.Width = 160
        '
        'VhcmodelDataGridViewTextBoxColumn
        '
        Me.VhcmodelDataGridViewTextBoxColumn.DataPropertyName = "vhc_model"
        Me.VhcmodelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.VhcmodelDataGridViewTextBoxColumn.Name = "VhcmodelDataGridViewTextBoxColumn"
        Me.VhcmodelDataGridViewTextBoxColumn.ReadOnly = True
        Me.VhcmodelDataGridViewTextBoxColumn.Width = 290
        '
        'VhctypeDataGridViewTextBoxColumn
        '
        Me.VhctypeDataGridViewTextBoxColumn.DataPropertyName = "vhc_type"
        Me.VhctypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.VhctypeDataGridViewTextBoxColumn.Name = "VhctypeDataGridViewTextBoxColumn"
        Me.VhctypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.VhctypeDataGridViewTextBoxColumn.Width = 250
        '
        'vhc_ID
        '
        Me.vhc_ID.DataPropertyName = "vhc_ID"
        Me.vhc_ID.HeaderText = "vhc_ID"
        Me.vhc_ID.Name = "vhc_ID"
        Me.vhc_ID.ReadOnly = True
        Me.vhc_ID.Visible = False
        '
        'OFD1
        '
        Me.OFD1.FileName = "OpenFileDialog1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 577)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(879, 22)
        Me.StatusStrip1.TabIndex = 53
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolsDate
        '
        Me.ToolsDate.Name = "ToolsDate"
        Me.ToolsDate.Size = New System.Drawing.Size(119, 17)
        Me.ToolsDate.Text = "ToolStripStatusLabel1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer1.Panel2.Controls.Add(Me.btyButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.statusButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.statusgroup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tyreButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.oilButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.batterygroup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tyregroup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.oilgroup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button6)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer1.Size = New System.Drawing.Size(879, 577)
        Me.SplitContainer1.SplitterDistance = 420
        Me.SplitContainer1.TabIndex = 54
        '
        'btyButton
        '
        Me.btyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btyButton.Location = New System.Drawing.Point(363, 318)
        Me.btyButton.Name = "btyButton"
        Me.btyButton.Size = New System.Drawing.Size(74, 32)
        Me.btyButton.TabIndex = 65
        Me.btyButton.Text = "Update"
        Me.btyButton.UseVisualStyleBackColor = True
        '
        'statusButton
        '
        Me.statusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusButton.Location = New System.Drawing.Point(364, 481)
        Me.statusButton.Name = "statusButton"
        Me.statusButton.Size = New System.Drawing.Size(74, 30)
        Me.statusButton.TabIndex = 62
        Me.statusButton.Text = "Update"
        Me.statusButton.UseVisualStyleBackColor = True
        '
        'statusgroup
        '
        Me.statusgroup.Controls.Add(Me.statushistory)
        Me.statusgroup.Controls.Add(Me.DataGridView2)
        Me.statusgroup.Controls.Add(Me.vhcrpID)
        Me.statusgroup.Location = New System.Drawing.Point(7, 348)
        Me.statusgroup.Name = "statusgroup"
        Me.statusgroup.Size = New System.Drawing.Size(434, 150)
        Me.statusgroup.TabIndex = 60
        Me.statusgroup.TabStop = False
        Me.statusgroup.Text = "Status (Last 3 Record)"
        '
        'statushistory
        '
        Me.statushistory.AutoSize = True
        Me.statushistory.Location = New System.Drawing.Point(306, 126)
        Me.statushistory.Name = "statushistory"
        Me.statushistory.Size = New System.Drawing.Size(39, 13)
        Me.statushistory.TabIndex = 18
        Me.statushistory.TabStop = True
        Me.statushistory.Text = "History"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vhcrp_date, Me.vhcrp_faultpart01, Me.vhcrp_remark, Me.vhcrp_status, Me.vhcrp_IsUpdate, Me.vhcrp_ID})
        Me.DataGridView2.Location = New System.Drawing.Point(10, 16)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 22
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(412, 103)
        Me.DataGridView2.TabIndex = 0
        '
        'vhcrp_date
        '
        Me.vhcrp_date.DataPropertyName = "vhcrp_date"
        Me.vhcrp_date.HeaderText = "Date"
        Me.vhcrp_date.Name = "vhcrp_date"
        Me.vhcrp_date.ReadOnly = True
        Me.vhcrp_date.Width = 90
        '
        'vhcrp_faultpart01
        '
        Me.vhcrp_faultpart01.DataPropertyName = "vhcrp_faultpart01"
        Me.vhcrp_faultpart01.HeaderText = "Faulty Part"
        Me.vhcrp_faultpart01.Name = "vhcrp_faultpart01"
        Me.vhcrp_faultpart01.ReadOnly = True
        '
        'vhcrp_remark
        '
        Me.vhcrp_remark.DataPropertyName = "vhcrp_remark"
        Me.vhcrp_remark.HeaderText = "Repair Description"
        Me.vhcrp_remark.Name = "vhcrp_remark"
        Me.vhcrp_remark.ReadOnly = True
        Me.vhcrp_remark.Width = 200
        '
        'vhcrp_status
        '
        Me.vhcrp_status.DataPropertyName = "vhcrp_status"
        Me.vhcrp_status.HeaderText = "Status"
        Me.vhcrp_status.Name = "vhcrp_status"
        Me.vhcrp_status.ReadOnly = True
        Me.vhcrp_status.Width = 80
        '
        'vhcrp_IsUpdate
        '
        Me.vhcrp_IsUpdate.DataPropertyName = "vhcrp_IsUpdate"
        Me.vhcrp_IsUpdate.HeaderText = "Update"
        Me.vhcrp_IsUpdate.Name = "vhcrp_IsUpdate"
        Me.vhcrp_IsUpdate.ReadOnly = True
        Me.vhcrp_IsUpdate.Visible = False
        Me.vhcrp_IsUpdate.Width = 80
        '
        'vhcrp_ID
        '
        Me.vhcrp_ID.DataPropertyName = "vhcrp_ID"
        Me.vhcrp_ID.HeaderText = "ID"
        Me.vhcrp_ID.Name = "vhcrp_ID"
        Me.vhcrp_ID.ReadOnly = True
        Me.vhcrp_ID.Visible = False
        '
        'vhcrpID
        '
        Me.vhcrpID.Location = New System.Drawing.Point(215, 64)
        Me.vhcrpID.Name = "vhcrpID"
        Me.vhcrpID.Size = New System.Drawing.Size(26, 20)
        Me.vhcrpID.TabIndex = 19
        '
        'tyreButton
        '
        Me.tyreButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tyreButton.Location = New System.Drawing.Point(364, 232)
        Me.tyreButton.Name = "tyreButton"
        Me.tyreButton.Size = New System.Drawing.Size(74, 30)
        Me.tyreButton.TabIndex = 58
        Me.tyreButton.Text = "Update"
        Me.tyreButton.UseVisualStyleBackColor = True
        '
        'oilButton
        '
        Me.oilButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oilButton.Location = New System.Drawing.Point(363, 68)
        Me.oilButton.Name = "oilButton"
        Me.oilButton.Size = New System.Drawing.Size(74, 30)
        Me.oilButton.TabIndex = 57
        Me.oilButton.Text = "Update"
        Me.oilButton.UseVisualStyleBackColor = True
        '
        'batterygroup
        '
        Me.batterygroup.Controls.Add(Me.btychgdate)
        Me.batterygroup.Controls.Add(Me.BtyHistory)
        Me.batterygroup.Controls.Add(Me.btyexp)
        Me.batterygroup.Controls.Add(Me.Label14)
        Me.batterygroup.Controls.Add(Me.Label13)
        Me.batterygroup.Controls.Add(Me.btywarranty)
        Me.batterygroup.Controls.Add(Me.Label12)
        Me.batterygroup.Controls.Add(Me.batterydate)
        Me.batterygroup.Location = New System.Drawing.Point(4, 265)
        Me.batterygroup.Name = "batterygroup"
        Me.batterygroup.Size = New System.Drawing.Size(437, 76)
        Me.batterygroup.TabIndex = 56
        Me.batterygroup.TabStop = False
        Me.batterygroup.Text = "Battery"
        '
        'btychgdate
        '
        Me.btychgdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btychgdate.Location = New System.Drawing.Point(86, 23)
        Me.btychgdate.Name = "btychgdate"
        Me.btychgdate.ReadOnly = True
        Me.btychgdate.Size = New System.Drawing.Size(92, 23)
        Me.btychgdate.TabIndex = 22
        '
        'BtyHistory
        '
        Me.BtyHistory.AutoSize = True
        Me.BtyHistory.Location = New System.Drawing.Point(309, 52)
        Me.BtyHistory.Name = "BtyHistory"
        Me.BtyHistory.Size = New System.Drawing.Size(39, 13)
        Me.BtyHistory.TabIndex = 21
        Me.BtyHistory.TabStop = True
        Me.BtyHistory.Text = "History"
        '
        'btyexp
        '
        Me.btyexp.AutoSize = True
        Me.btyexp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btyexp.ForeColor = System.Drawing.Color.Red
        Me.btyexp.Location = New System.Drawing.Point(342, 26)
        Me.btyexp.Name = "btyexp"
        Me.btyexp.Size = New System.Drawing.Size(83, 17)
        Me.btyexp.TabIndex = 20
        Me.btyexp.Text = "** Expired **"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(275, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Month(s)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(190, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Warranty"
        '
        'btywarranty
        '
        Me.btywarranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btywarranty.Location = New System.Drawing.Point(244, 22)
        Me.btywarranty.Name = "btywarranty"
        Me.btywarranty.ReadOnly = True
        Me.btywarranty.Size = New System.Drawing.Size(29, 23)
        Me.btywarranty.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Date Change"
        '
        'batterydate
        '
        Me.batterydate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.batterydate.Location = New System.Drawing.Point(86, 25)
        Me.batterydate.Name = "batterydate"
        Me.batterydate.Size = New System.Drawing.Size(86, 20)
        Me.batterydate.TabIndex = 62
        Me.batterydate.TabStop = False
        '
        'tyregroup
        '
        Me.tyregroup.Controls.Add(Me.rrityredatetext)
        Me.tyregroup.Controls.Add(Me.rlityredatetext)
        Me.tyregroup.Controls.Add(Me.Label17)
        Me.tyregroup.Controls.Add(Me.rritype)
        Me.tyregroup.Controls.Add(Me.Label18)
        Me.tyregroup.Controls.Add(Me.rlitype)
        Me.tyregroup.Controls.Add(Me.rrtyredatetext)
        Me.tyregroup.Controls.Add(Me.frtyredatetext)
        Me.tyregroup.Controls.Add(Me.rltyredatetext)
        Me.tyregroup.Controls.Add(Me.fltyredatetext)
        Me.tyregroup.Controls.Add(Me.TyreHistory)
        Me.tyregroup.Controls.Add(Me.Label10)
        Me.tyregroup.Controls.Add(Me.rrtype)
        Me.tyregroup.Controls.Add(Me.Label11)
        Me.tyregroup.Controls.Add(Me.frtype)
        Me.tyregroup.Controls.Add(Me.Label9)
        Me.tyregroup.Controls.Add(Me.rltype)
        Me.tyregroup.Controls.Add(Me.Label8)
        Me.tyregroup.Controls.Add(Me.fltype)
        Me.tyregroup.Location = New System.Drawing.Point(4, 101)
        Me.tyregroup.Name = "tyregroup"
        Me.tyregroup.Size = New System.Drawing.Size(437, 152)
        Me.tyregroup.TabIndex = 55
        Me.tyregroup.TabStop = False
        Me.tyregroup.Text = "Tyre"
        '
        'rrityredatetext
        '
        Me.rrityredatetext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rrityredatetext.Location = New System.Drawing.Point(332, 98)
        Me.rrityredatetext.Name = "rrityredatetext"
        Me.rrityredatetext.ReadOnly = True
        Me.rrityredatetext.Size = New System.Drawing.Size(92, 23)
        Me.rrityredatetext.TabIndex = 27
        '
        'rlityredatetext
        '
        Me.rlityredatetext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rlityredatetext.Location = New System.Drawing.Point(109, 98)
        Me.rlityredatetext.Name = "rlityredatetext"
        Me.rlityredatetext.ReadOnly = True
        Me.rlityredatetext.Size = New System.Drawing.Size(92, 23)
        Me.rlityredatetext.TabIndex = 26
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(221, 83)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Rear Right Inner"
        '
        'rritype
        '
        Me.rritype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rritype.Location = New System.Drawing.Point(281, 98)
        Me.rritype.Name = "rritype"
        Me.rritype.ReadOnly = True
        Me.rritype.Size = New System.Drawing.Size(45, 23)
        Me.rritype.TabIndex = 24
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(4, 82)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Rear Left Inner"
        '
        'rlitype
        '
        Me.rlitype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rlitype.Location = New System.Drawing.Point(58, 98)
        Me.rlitype.Name = "rlitype"
        Me.rlitype.ReadOnly = True
        Me.rlitype.Size = New System.Drawing.Size(45, 23)
        Me.rlitype.TabIndex = 22
        '
        'rrtyredatetext
        '
        Me.rrtyredatetext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rrtyredatetext.Location = New System.Drawing.Point(332, 48)
        Me.rrtyredatetext.Name = "rrtyredatetext"
        Me.rrtyredatetext.ReadOnly = True
        Me.rrtyredatetext.Size = New System.Drawing.Size(92, 23)
        Me.rrtyredatetext.TabIndex = 21
        '
        'frtyredatetext
        '
        Me.frtyredatetext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frtyredatetext.Location = New System.Drawing.Point(332, 19)
        Me.frtyredatetext.Name = "frtyredatetext"
        Me.frtyredatetext.ReadOnly = True
        Me.frtyredatetext.Size = New System.Drawing.Size(92, 23)
        Me.frtyredatetext.TabIndex = 20
        '
        'rltyredatetext
        '
        Me.rltyredatetext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rltyredatetext.Location = New System.Drawing.Point(109, 47)
        Me.rltyredatetext.Name = "rltyredatetext"
        Me.rltyredatetext.ReadOnly = True
        Me.rltyredatetext.Size = New System.Drawing.Size(92, 23)
        Me.rltyredatetext.TabIndex = 19
        '
        'fltyredatetext
        '
        Me.fltyredatetext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fltyredatetext.Location = New System.Drawing.Point(109, 18)
        Me.fltyredatetext.Name = "fltyredatetext"
        Me.fltyredatetext.ReadOnly = True
        Me.fltyredatetext.Size = New System.Drawing.Size(92, 23)
        Me.fltyredatetext.TabIndex = 8
        '
        'TyreHistory
        '
        Me.TyreHistory.AutoSize = True
        Me.TyreHistory.Location = New System.Drawing.Point(309, 130)
        Me.TyreHistory.Name = "TyreHistory"
        Me.TyreHistory.Size = New System.Drawing.Size(39, 13)
        Me.TyreHistory.TabIndex = 18
        Me.TyreHistory.TabStop = True
        Me.TyreHistory.Text = "History"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(221, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Rear Right"
        '
        'rrtype
        '
        Me.rrtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rrtype.Location = New System.Drawing.Point(281, 48)
        Me.rrtype.Name = "rrtype"
        Me.rrtype.ReadOnly = True
        Me.rrtype.Size = New System.Drawing.Size(45, 23)
        Me.rrtype.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(221, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Front Right"
        '
        'frtype
        '
        Me.frtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frtype.Location = New System.Drawing.Point(281, 19)
        Me.frtype.Name = "frtype"
        Me.frtype.ReadOnly = True
        Me.frtype.Size = New System.Drawing.Size(45, 23)
        Me.frtype.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Rear Left"
        '
        'rltype
        '
        Me.rltype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rltype.Location = New System.Drawing.Point(58, 47)
        Me.rltype.Name = "rltype"
        Me.rltype.ReadOnly = True
        Me.rltype.Size = New System.Drawing.Size(45, 23)
        Me.rltype.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Front Left"
        '
        'fltype
        '
        Me.fltype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fltype.Location = New System.Drawing.Point(58, 18)
        Me.fltype.Name = "fltype"
        Me.fltype.ReadOnly = True
        Me.fltype.Size = New System.Drawing.Size(45, 23)
        Me.fltype.TabIndex = 6
        '
        'oilgroup
        '
        Me.oilgroup.Controls.Add(Me.oilchangedate)
        Me.oilgroup.Controls.Add(Me.engoilshi)
        Me.oilgroup.Controls.Add(Me.Label7)
        Me.oilgroup.Controls.Add(Me.vhc_ChgMeter)
        Me.oilgroup.Controls.Add(Me.Label6)
        Me.oilgroup.Controls.Add(Me.Label4)
        Me.oilgroup.Controls.Add(Me.vhc_CurrMeter)
        Me.oilgroup.Location = New System.Drawing.Point(3, 7)
        Me.oilgroup.Name = "oilgroup"
        Me.oilgroup.Size = New System.Drawing.Size(437, 84)
        Me.oilgroup.TabIndex = 54
        Me.oilgroup.TabStop = False
        Me.oilgroup.Text = "Engine Oil"
        '
        'oilchangedate
        '
        Me.oilchangedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oilchangedate.Location = New System.Drawing.Point(285, 18)
        Me.oilchangedate.Name = "oilchangedate"
        Me.oilchangedate.ReadOnly = True
        Me.oilchangedate.Size = New System.Drawing.Size(92, 23)
        Me.oilchangedate.TabIndex = 7
        '
        'engoilshi
        '
        Me.engoilshi.AutoSize = True
        Me.engoilshi.Location = New System.Drawing.Point(310, 68)
        Me.engoilshi.Name = "engoilshi"
        Me.engoilshi.Size = New System.Drawing.Size(39, 13)
        Me.engoilshi.TabIndex = 6
        Me.engoilshi.TabStop = True
        Me.engoilshi.Text = "History"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 26)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Upcoming " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Meter"
        '
        'vhc_ChgMeter
        '
        Me.vhc_ChgMeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhc_ChgMeter.Location = New System.Drawing.Point(64, 47)
        Me.vhc_ChgMeter.Name = "vhc_ChgMeter"
        Me.vhc_ChgMeter.ReadOnly = True
        Me.vhc_ChgMeter.Size = New System.Drawing.Size(103, 23)
        Me.vhc_ChgMeter.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(194, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Last Engine" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Oil Change Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 26)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Current " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Meter"
        '
        'vhc_CurrMeter
        '
        Me.vhc_CurrMeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhc_CurrMeter.Location = New System.Drawing.Point(64, 18)
        Me.vhc_CurrMeter.Name = "vhc_CurrMeter"
        Me.vhc_CurrMeter.ReadOnly = True
        Me.vhc_CurrMeter.Size = New System.Drawing.Size(103, 23)
        Me.vhc_CurrMeter.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(7, 506)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(74, 29)
        Me.Button6.TabIndex = 53
        Me.Button6.Text = "Close"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'VehicleTableAdapter
        '
        Me.VehicleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bookingTableAdapter = Nothing
        Me.TableAdapterManager.lorry_rt_historyTableAdapter = Nothing
        Me.TableAdapterManager.lorryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CBS.CBSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.vehicle_rt_historyTableAdapter = Nothing
        Me.TableAdapterManager.vehicleTableAdapter = Me.VehicleTableAdapter
        '
        'vehicle_display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 599)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "vehicle_display"
        Me.Text = "Manage Vehicle"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VehicleBindingNavigator.ResumeLayout(False)
        Me.VehicleBindingNavigator.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.statusgroup.ResumeLayout(False)
        Me.statusgroup.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.batterygroup.ResumeLayout(False)
        Me.batterygroup.PerformLayout()
        Me.tyregroup.ResumeLayout(False)
        Me.tyregroup.PerformLayout()
        Me.oilgroup.ResumeLayout(False)
        Me.oilgroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CBSDataSet As CBSDataSet
    Friend WithEvents VehicleBindingSource As BindingSource
    Friend WithEvents VehicleTableAdapter As CBSDataSetTableAdapters.vehicleTableAdapter
    Friend WithEvents TableAdapterManager As CBSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Vhc_ageTextBox As TextBox
    Friend WithEvents Vhc_lastupdateDateTimePicker As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OFD1 As OpenFileDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolsDate As ToolStripStatusLabel
    Friend WithEvents VhcPlateNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents vhc_brand As DataGridViewTextBoxColumn
    Friend WithEvents VhcmodelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VhctypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents vhc_ID As DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button6 As Button
    Friend WithEvents oilButton As Button
    Friend WithEvents batterygroup As GroupBox
    Friend WithEvents tyregroup As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents rrtype As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents frtype As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents rltype As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents fltype As TextBox
    Friend WithEvents oilgroup As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents vhc_ChgMeter As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents vhc_CurrMeter As TextBox
    Friend WithEvents tyreButton As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btywarranty As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btyexp As Label
    Friend WithEvents BtyHistory As LinkLabel
    Friend WithEvents TyreHistory As LinkLabel
    Friend WithEvents engoilshi As LinkLabel
    Friend WithEvents oilchangedate As TextBox
    Friend WithEvents btychgdate As TextBox
    Friend WithEvents rrtyredatetext As TextBox
    Friend WithEvents frtyredatetext As TextBox
    Friend WithEvents rltyredatetext As TextBox
    Friend WithEvents fltyredatetext As TextBox
    Friend WithEvents batterydate As DateTimePicker
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents MeterLeftLabel As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Vhc_typeTextBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chgpix As Button
    Friend WithEvents LBP1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Vhc_yearTextBox As TextBox
    Friend WithEvents Vhc_IDTextBox As TextBox
    Friend WithEvents Vhc_PlateNoTextBox As TextBox
    Friend WithEvents Vhc_noteTextBox As TextBox
    Friend WithEvents Vhc_brandTextBox As TextBox
    Friend WithEvents Vhc_modelTextBox As TextBox
    Friend WithEvents vrrdate As TextBox
    Friend WithEvents vobsolete As TextBox
    Friend WithEvents picloc As TextBox
    Friend WithEvents vhc_cattext As TextBox
    Friend WithEvents categoryComboBox As ComboBox
    Friend WithEvents Vhc_categoryTextBox As TextBox
    Friend WithEvents VehicleBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents VehicleBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Vhc_roadtaxDateTimePicker As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents btyButton As Button
    Friend WithEvents statusButton As Button
    Friend WithEvents statusgroup As GroupBox
    Friend WithEvents statushistory As LinkLabel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents vhcrp_date As DataGridViewTextBoxColumn
    Friend WithEvents vhcrp_faultpart01 As DataGridViewTextBoxColumn
    Friend WithEvents vhcrp_remark As DataGridViewTextBoxColumn
    Friend WithEvents vhcrp_status As DataGridViewTextBoxColumn
    Friend WithEvents vhcrp_IsUpdate As DataGridViewTextBoxColumn
    Friend WithEvents vhcrp_ID As DataGridViewTextBoxColumn
    Friend WithEvents vhcrpID As TextBox
    Friend WithEvents rrityredatetext As TextBox
    Friend WithEvents rlityredatetext As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents rritype As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents rlitype As TextBox
    Friend WithEvents TextBoxIns As TextBox
    Friend WithEvents LabelAlertInsurance As Label
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
