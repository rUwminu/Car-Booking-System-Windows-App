<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_chgpw
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
        Dim Usr_usernameLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.CBSDataSet = New CBS.CBSDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New CBS.CBSDataSetTableAdapters.usersTableAdapter()
        Me.TableAdapterManager = New CBS.CBSDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NewPass = New System.Windows.Forms.TextBox()
        Me.VeNewPass = New System.Windows.Forms.TextBox()
        Me.LabelusrID = New System.Windows.Forms.Label()
        Me.Usr_usernameTextBox = New System.Windows.Forms.TextBox()
        Usr_usernameLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.CBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Usr_usernameLabel
        '
        Usr_usernameLabel.AutoSize = True
        Usr_usernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usr_usernameLabel.Location = New System.Drawing.Point(18, 25)
        Usr_usernameLabel.Name = "Usr_usernameLabel"
        Usr_usernameLabel.Size = New System.Drawing.Size(87, 20)
        Usr_usernameLabel.TabIndex = 7
        Usr_usernameLabel.Text = "Username:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(18, 57)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(117, 20)
        Label1.TabIndex = 11
        Label1.Text = "New Password:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(18, 89)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(161, 20)
        Label2.TabIndex = 13
        Label2.Text = "Verify New Password:"
        '
        'CBSDataSet
        '
        Me.CBSDataSet.DataSetName = "CBSDataSet"
        Me.CBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.CBSDataSet
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(311, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 38)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NewPass
        '
        Me.NewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPass.Location = New System.Drawing.Point(186, 54)
        Me.NewPass.Name = "NewPass"
        Me.NewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPass.Size = New System.Drawing.Size(200, 26)
        Me.NewPass.TabIndex = 1
        '
        'VeNewPass
        '
        Me.VeNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VeNewPass.Location = New System.Drawing.Point(186, 86)
        Me.VeNewPass.Name = "VeNewPass"
        Me.VeNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.VeNewPass.Size = New System.Drawing.Size(200, 26)
        Me.VeNewPass.TabIndex = 2
        '
        'LabelusrID
        '
        Me.LabelusrID.AutoSize = True
        Me.LabelusrID.Location = New System.Drawing.Point(183, 25)
        Me.LabelusrID.Name = "LabelusrID"
        Me.LabelusrID.Size = New System.Drawing.Size(39, 13)
        Me.LabelusrID.TabIndex = 14
        Me.LabelusrID.Text = "Label3"
        '
        'Usr_usernameTextBox
        '
        Me.Usr_usernameTextBox.Enabled = False
        Me.Usr_usernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_usernameTextBox.Location = New System.Drawing.Point(186, 19)
        Me.Usr_usernameTextBox.Name = "Usr_usernameTextBox"
        Me.Usr_usernameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Usr_usernameTextBox.TabIndex = 15
        '
        'user_chgpw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 184)
        Me.Controls.Add(Me.Usr_usernameTextBox)
        Me.Controls.Add(Me.LabelusrID)
        Me.Controls.Add(Me.VeNewPass)
        Me.Controls.Add(Me.NewPass)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Usr_usernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "user_chgpw"
        Me.Text = "Change Password"
        CType(Me.CBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBSDataSet As CBSDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As CBSDataSetTableAdapters.usersTableAdapter
    Friend WithEvents TableAdapterManager As CBSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents NewPass As TextBox
    Friend WithEvents VeNewPass As TextBox
    Friend WithEvents LabelusrID As Label
    Friend WithEvents Usr_usernameTextBox As TextBox
End Class
