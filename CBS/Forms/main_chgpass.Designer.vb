<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_chgpass
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Usr_usernameLabel As System.Windows.Forms.Label
        Dim Usr_passwordLabel As System.Windows.Forms.Label
        Me.VeNewPass = New System.Windows.Forms.TextBox()
        Me.NewPass = New System.Windows.Forms.TextBox()
        Me.CurrPass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Usr_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Usr_usernameTextBox = New System.Windows.Forms.TextBox()
        Me.Usr_passwordTextBox = New System.Windows.Forms.TextBox()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Usr_usernameLabel = New System.Windows.Forms.Label()
        Usr_passwordLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(18, 121)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(161, 20)
        Label2.TabIndex = 24
        Label2.Text = "Verify New Password:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(18, 89)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(117, 20)
        Label1.TabIndex = 23
        Label1.Text = "New Password:"
        '
        'Usr_usernameLabel
        '
        Usr_usernameLabel.AutoSize = True
        Usr_usernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usr_usernameLabel.Location = New System.Drawing.Point(18, 25)
        Usr_usernameLabel.Name = "Usr_usernameLabel"
        Usr_usernameLabel.Size = New System.Drawing.Size(87, 20)
        Usr_usernameLabel.TabIndex = 19
        Usr_usernameLabel.Text = "Username:"
        '
        'Usr_passwordLabel
        '
        Usr_passwordLabel.AutoSize = True
        Usr_passwordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usr_passwordLabel.Location = New System.Drawing.Point(18, 57)
        Usr_passwordLabel.Name = "Usr_passwordLabel"
        Usr_passwordLabel.Size = New System.Drawing.Size(139, 20)
        Usr_passwordLabel.TabIndex = 21
        Usr_passwordLabel.Text = "Current Password:"
        '
        'VeNewPass
        '
        Me.VeNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VeNewPass.Location = New System.Drawing.Point(186, 121)
        Me.VeNewPass.Name = "VeNewPass"
        Me.VeNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.VeNewPass.Size = New System.Drawing.Size(200, 26)
        Me.VeNewPass.TabIndex = 2
        '
        'NewPass
        '
        Me.NewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPass.Location = New System.Drawing.Point(186, 89)
        Me.NewPass.Name = "NewPass"
        Me.NewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPass.Size = New System.Drawing.Size(200, 26)
        Me.NewPass.TabIndex = 1
        '
        'CurrPass
        '
        Me.CurrPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrPass.Location = New System.Drawing.Point(186, 54)
        Me.CurrPass.Name = "CurrPass"
        Me.CurrPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CurrPass.Size = New System.Drawing.Size(200, 26)
        Me.CurrPass.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(317, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Usr_IDTextBox
        '
        Me.Usr_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_IDTextBox.Location = New System.Drawing.Point(217, 129)
        Me.Usr_IDTextBox.Name = "Usr_IDTextBox"
        Me.Usr_IDTextBox.ReadOnly = True
        Me.Usr_IDTextBox.Size = New System.Drawing.Size(16, 12)
        Me.Usr_IDTextBox.TabIndex = 18
        Me.Usr_IDTextBox.TabStop = False
        '
        'Usr_usernameTextBox
        '
        Me.Usr_usernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_usernameTextBox.Location = New System.Drawing.Point(186, 22)
        Me.Usr_usernameTextBox.Name = "Usr_usernameTextBox"
        Me.Usr_usernameTextBox.ReadOnly = True
        Me.Usr_usernameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Usr_usernameTextBox.TabIndex = 20
        Me.Usr_usernameTextBox.TabStop = False
        '
        'Usr_passwordTextBox
        '
        Me.Usr_passwordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usr_passwordTextBox.Location = New System.Drawing.Point(200, 129)
        Me.Usr_passwordTextBox.Name = "Usr_passwordTextBox"
        Me.Usr_passwordTextBox.Size = New System.Drawing.Size(11, 12)
        Me.Usr_passwordTextBox.TabIndex = 22
        Me.Usr_passwordTextBox.TabStop = False
        '
        'main_chgpass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 220)
        Me.Controls.Add(Me.VeNewPass)
        Me.Controls.Add(Me.NewPass)
        Me.Controls.Add(Me.CurrPass)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Usr_IDTextBox)
        Me.Controls.Add(Usr_usernameLabel)
        Me.Controls.Add(Me.Usr_usernameTextBox)
        Me.Controls.Add(Usr_passwordLabel)
        Me.Controls.Add(Me.Usr_passwordTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "main_chgpass"
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VeNewPass As TextBox
    Friend WithEvents NewPass As TextBox
    Friend WithEvents CurrPass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Usr_IDTextBox As TextBox
    Friend WithEvents Usr_usernameTextBox As TextBox
    Friend WithEvents Usr_passwordTextBox As TextBox
End Class
