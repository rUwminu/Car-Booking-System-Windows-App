<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMDI))
        Me.SecurityCheckReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecurityCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisplayCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CardControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditVehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewVehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehicalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.usr_id_label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.display_name = New System.Windows.Forms.ToolStripStatusLabel()
        Me.display_lvl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LabelEmpID = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SecurityCheckReportToolStripMenuItem
        '
        Me.SecurityCheckReportToolStripMenuItem.Name = "SecurityCheckReportToolStripMenuItem"
        Me.SecurityCheckReportToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.SecurityCheckReportToolStripMenuItem.Text = "&Security Check Report"
        Me.SecurityCheckReportToolStripMenuItem.Visible = False
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookingSummaryToolStripMenuItem, Me.SecurityCheckReportToolStripMenuItem, Me.KeyRecordToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'BookingSummaryToolStripMenuItem
        '
        Me.BookingSummaryToolStripMenuItem.Name = "BookingSummaryToolStripMenuItem"
        Me.BookingSummaryToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.BookingSummaryToolStripMenuItem.Text = "Booking &Summary"
        '
        'KeyRecordToolStripMenuItem
        '
        Me.KeyRecordToolStripMenuItem.Name = "KeyRecordToolStripMenuItem"
        Me.KeyRecordToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.KeyRecordToolStripMenuItem.Text = "Key Record"
        '
        'SecurityCheckToolStripMenuItem
        '
        Me.SecurityCheckToolStripMenuItem.Name = "SecurityCheckToolStripMenuItem"
        Me.SecurityCheckToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.SecurityCheckToolStripMenuItem.Text = "Security Check"
        '
        'RetToolStripMenuItem
        '
        Me.RetToolStripMenuItem.Name = "RetToolStripMenuItem"
        Me.RetToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.RetToolStripMenuItem.Text = "&Return"
        '
        'IssueToolStripMenuItem
        '
        Me.IssueToolStripMenuItem.Name = "IssueToolStripMenuItem"
        Me.IssueToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.IssueToolStripMenuItem.Text = "&Issue"
        '
        'ManageCardToolStripMenuItem
        '
        Me.ManageCardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IssueToolStripMenuItem, Me.RetToolStripMenuItem})
        Me.ManageCardToolStripMenuItem.Name = "ManageCardToolStripMenuItem"
        Me.ManageCardToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ManageCardToolStripMenuItem.Text = "Manage Card"
        Me.ManageCardToolStripMenuItem.Visible = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'DisplayCardToolStripMenuItem
        '
        Me.DisplayCardToolStripMenuItem.Name = "DisplayCardToolStripMenuItem"
        Me.DisplayCardToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.DisplayCardToolStripMenuItem.Text = "&Display Card"
        '
        'AddNewCardToolStripMenuItem
        '
        Me.AddNewCardToolStripMenuItem.Name = "AddNewCardToolStripMenuItem"
        Me.AddNewCardToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.AddNewCardToolStripMenuItem.Text = "&Add Card"
        '
        'CardControlToolStripMenuItem
        '
        Me.CardControlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewCardToolStripMenuItem, Me.DisplayCardToolStripMenuItem})
        Me.CardControlToolStripMenuItem.Name = "CardControlToolStripMenuItem"
        Me.CardControlToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CardControlToolStripMenuItem.Text = "&Card"
        Me.CardControlToolStripMenuItem.Visible = False
        '
        'KeyStatusToolStripMenuItem
        '
        Me.KeyStatusToolStripMenuItem.Name = "KeyStatusToolStripMenuItem"
        Me.KeyStatusToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.KeyStatusToolStripMenuItem.Text = "Key Status"
        Me.KeyStatusToolStripMenuItem.Visible = False
        '
        'EditVehicleToolStripMenuItem
        '
        Me.EditVehicleToolStripMenuItem.Name = "EditVehicleToolStripMenuItem"
        Me.EditVehicleToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.EditVehicleToolStripMenuItem.Text = "&Manage Vehicle"
        '
        'NewVehicleToolStripMenuItem
        '
        Me.NewVehicleToolStripMenuItem.Name = "NewVehicleToolStripMenuItem"
        Me.NewVehicleToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NewVehicleToolStripMenuItem.Text = "&New Vehicle"
        '
        'VehicalToolStripMenuItem
        '
        Me.VehicalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewVehicleToolStripMenuItem, Me.EditVehicleToolStripMenuItem, Me.KeyStatusToolStripMenuItem})
        Me.VehicalToolStripMenuItem.Name = "VehicalToolStripMenuItem"
        Me.VehicalToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.VehicalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VehicalToolStripMenuItem.Text = "&Vehicle"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "&Change Password"
        '
        'EditUserToolStripMenuItem
        '
        Me.EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem"
        Me.EditUserToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.EditUserToolStripMenuItem.Text = "&Display User"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NewUserToolStripMenuItem.Text = "&New User"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewUserToolStripMenuItem, Me.EditUserToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UserToolStripMenuItem.Text = "&User"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ToolStripSeparator2, Me.UserToolStripMenuItem, Me.VehicalToolStripMenuItem, Me.CardControlToolStripMenuItem, Me.ToolStripSeparator1, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.FileToolStripMenuItem.Text = "Management"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SecurityCheckToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ManageCardToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(944, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'usr_id_label
        '
        Me.usr_id_label.ForeColor = System.Drawing.SystemColors.Control
        Me.usr_id_label.Name = "usr_id_label"
        Me.usr_id_label.Size = New System.Drawing.Size(18, 17)
        Me.usr_id_label.Text = "ID"
        '
        'display_name
        '
        Me.display_name.Name = "display_name"
        Me.display_name.Size = New System.Drawing.Size(39, 17)
        Me.display_name.Text = "Name"
        '
        'display_lvl
        '
        Me.display_lvl.Name = "display_lvl"
        Me.display_lvl.Size = New System.Drawing.Size(19, 17)
        Me.display_lvl.Text = "lvl"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.display_lvl, Me.display_name, Me.usr_id_label})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 480)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(944, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LabelEmpID
        '
        Me.LabelEmpID.AutoSize = True
        Me.LabelEmpID.Location = New System.Drawing.Point(893, 489)
        Me.LabelEmpID.Name = "LabelEmpID"
        Me.LabelEmpID.Size = New System.Drawing.Size(39, 13)
        Me.LabelEmpID.TabIndex = 8
        Me.LabelEmpID.Text = "Label1"
        Me.LabelEmpID.Visible = False
        '
        'MainMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CBS.My.Resources.Resources.background3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(944, 502)
        Me.Controls.Add(Me.LabelEmpID)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MainMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vehicle Booking System v1.2.6"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SecurityCheckReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingSummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SecurityCheckToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IssueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DisplayCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CardControlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeyStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditVehicleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewVehicleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VehicalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents usr_id_label As ToolStripStatusLabel
    Friend WithEvents display_name As ToolStripStatusLabel
    Friend WithEvents display_lvl As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents KeyRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelEmpID As Label
End Class
