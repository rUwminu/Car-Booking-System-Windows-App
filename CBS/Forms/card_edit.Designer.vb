<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class card_edit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.card_type = New System.Windows.Forms.TextBox()
        Me.Card_no = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Card_remark = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Card_ID = New System.Windows.Forms.TextBox()
        Me.card_active = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Card Type"
        '
        'card_type
        '
        Me.card_type.BackColor = System.Drawing.SystemColors.Window
        Me.card_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.card_type.Location = New System.Drawing.Point(99, 28)
        Me.card_type.Name = "card_type"
        Me.card_type.ReadOnly = True
        Me.card_type.Size = New System.Drawing.Size(178, 26)
        Me.card_type.TabIndex = 1
        '
        'Card_no
        '
        Me.Card_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Card_no.Location = New System.Drawing.Point(99, 60)
        Me.Card_no.Name = "Card_no"
        Me.Card_no.Size = New System.Drawing.Size(178, 26)
        Me.Card_no.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Card No"
        '
        'Card_remark
        '
        Me.Card_remark.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Card_remark.Location = New System.Drawing.Point(99, 95)
        Me.Card_remark.Multiline = True
        Me.Card_remark.Name = "Card_remark"
        Me.Card_remark.Size = New System.Drawing.Size(178, 70)
        Me.Card_remark.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Remark"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(99, 175)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(109, 24)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Status"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(135, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 36)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(216, 214)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 36)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Card_ID
        '
        Me.Card_ID.Location = New System.Drawing.Point(216, 142)
        Me.Card_ID.Name = "Card_ID"
        Me.Card_ID.Size = New System.Drawing.Size(27, 20)
        Me.Card_ID.TabIndex = 10
        Me.Card_ID.TabStop = False
        '
        'card_active
        '
        Me.card_active.Location = New System.Drawing.Point(172, 142)
        Me.card_active.Name = "card_active"
        Me.card_active.Size = New System.Drawing.Size(27, 20)
        Me.card_active.TabIndex = 11
        Me.card_active.TabStop = False
        '
        'card_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 262)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Card_remark)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Card_no)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.card_type)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Card_ID)
        Me.Controls.Add(Me.card_active)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "card_edit"
        Me.Text = "Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents card_type As TextBox
    Friend WithEvents Card_no As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Card_remark As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Card_ID As TextBox
    Friend WithEvents card_active As TextBox
End Class
