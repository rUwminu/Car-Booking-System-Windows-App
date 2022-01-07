<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.usrtext = New System.Windows.Forms.TextBox()
        Me.passtext = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Login_pcnameTextBox = New System.Windows.Forms.TextBox()
        Me.Login_logBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBSDataSet = New CBS.CBSDataSet()
        Me.Login_pcusrTextBox = New System.Windows.Forms.TextBox()
        Me.Login_usrnameTextBox = New System.Windows.Forms.TextBox()
        Me.Login_logTableAdapter = New CBS.CBSDataSetTableAdapters.login_logTableAdapter()
        Me.TableAdapterManager = New CBS.CBSDataSetTableAdapters.TableAdapterManager()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.Login_logBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usrtext
        '
        Me.usrtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrtext.Location = New System.Drawing.Point(114, 24)
        Me.usrtext.Name = "usrtext"
        Me.usrtext.Size = New System.Drawing.Size(162, 26)
        Me.usrtext.TabIndex = 0
        '
        'passtext
        '
        Me.passtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtext.Location = New System.Drawing.Point(114, 60)
        Me.passtext.Name = "passtext"
        Me.passtext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passtext.Size = New System.Drawing.Size(162, 26)
        Me.passtext.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(98, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 45)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Login_pcnameTextBox
        '
        Me.Login_pcnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Login_logBindingSource, "login_pcname", True))
        Me.Login_pcnameTextBox.Location = New System.Drawing.Point(119, 26)
        Me.Login_pcnameTextBox.Name = "Login_pcnameTextBox"
        Me.Login_pcnameTextBox.Size = New System.Drawing.Size(10, 20)
        Me.Login_pcnameTextBox.TabIndex = 7
        Me.Login_pcnameTextBox.TabStop = False
        '
        'Login_logBindingSource
        '
        Me.Login_logBindingSource.DataMember = "login_log"
        Me.Login_logBindingSource.DataSource = Me.CBSDataSet
        '
        'CBSDataSet
        '
        Me.CBSDataSet.DataSetName = "CBSDataSet"
        Me.CBSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Login_pcusrTextBox
        '
        Me.Login_pcusrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Login_logBindingSource, "login_pcusr", True))
        Me.Login_pcusrTextBox.Location = New System.Drawing.Point(135, 26)
        Me.Login_pcusrTextBox.Name = "Login_pcusrTextBox"
        Me.Login_pcusrTextBox.Size = New System.Drawing.Size(10, 20)
        Me.Login_pcusrTextBox.TabIndex = 8
        Me.Login_pcusrTextBox.TabStop = False
        '
        'Login_usrnameTextBox
        '
        Me.Login_usrnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Login_logBindingSource, "login_usrname", True))
        Me.Login_usrnameTextBox.Location = New System.Drawing.Point(151, 26)
        Me.Login_usrnameTextBox.Name = "Login_usrnameTextBox"
        Me.Login_usrnameTextBox.Size = New System.Drawing.Size(10, 20)
        Me.Login_usrnameTextBox.TabIndex = 9
        Me.Login_usrnameTextBox.TabStop = False
        '
        'Login_logTableAdapter
        '
        Me.Login_logTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bookingTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.lorry_rt_historyTableAdapter = Nothing
        Me.TableAdapterManager.lorryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CBS.CBSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.vehicle_rt_historyTableAdapter = Nothing
        Me.TableAdapterManager.vehicleTableAdapter = Nothing
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(275, 153)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(37, 13)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "v1.2.8"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(317, 170)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passtext)
        Me.Controls.Add(Me.usrtext)
        Me.Controls.Add(Me.Login_usrnameTextBox)
        Me.Controls.Add(Me.Login_pcusrTextBox)
        Me.Controls.Add(Me.Login_pcnameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Text = "Vehicle Management System VMS"
        CType(Me.Login_logBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usrtext As TextBox
    Friend WithEvents passtext As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CBSDataSet As CBSDataSet
    Friend WithEvents Login_logBindingSource As BindingSource
    Friend WithEvents Login_logTableAdapter As CBSDataSetTableAdapters.login_logTableAdapter
    Friend WithEvents TableAdapterManager As CBSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Login_pcnameTextBox As TextBox
    Friend WithEvents Login_pcusrTextBox As TextBox
    Friend WithEvents Login_usrnameTextBox As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
