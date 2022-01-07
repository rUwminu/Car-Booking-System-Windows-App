<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class card_new
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
        Me.card_no = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.card_type_combo = New System.Windows.Forms.ComboBox()
        Me.card_remark = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.card_ID = New System.Windows.Forms.TextBox()
        Me.datecreatetext = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Card No"
        '
        'card_no
        '
        Me.card_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.card_no.Location = New System.Drawing.Point(118, 95)
        Me.card_no.Name = "card_no"
        Me.card_no.Size = New System.Drawing.Size(271, 26)
        Me.card_no.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Card Type"
        '
        'card_type_combo
        '
        Me.card_type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.card_type_combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.card_type_combo.FormattingEnabled = True
        Me.card_type_combo.Items.AddRange(New Object() {"Petrol", "Touch & GO"})
        Me.card_type_combo.Location = New System.Drawing.Point(118, 60)
        Me.card_type_combo.Name = "card_type_combo"
        Me.card_type_combo.Size = New System.Drawing.Size(271, 28)
        Me.card_type_combo.TabIndex = 3
        '
        'card_remark
        '
        Me.card_remark.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.card_remark.Location = New System.Drawing.Point(118, 127)
        Me.card_remark.Multiline = True
        Me.card_remark.Name = "card_remark"
        Me.card_remark.Size = New System.Drawing.Size(271, 74)
        Me.card_remark.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Remark"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 39)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Create New Card"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(261, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(342, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'card_ID
        '
        Me.card_ID.Location = New System.Drawing.Point(122, 181)
        Me.card_ID.Name = "card_ID"
        Me.card_ID.Size = New System.Drawing.Size(26, 20)
        Me.card_ID.TabIndex = 9
        Me.card_ID.Text = "1"
        '
        'datecreatetext
        '
        Me.datecreatetext.Location = New System.Drawing.Point(163, 181)
        Me.datecreatetext.Name = "datecreatetext"
        Me.datecreatetext.Size = New System.Drawing.Size(100, 20)
        Me.datecreatetext.TabIndex = 10
        Me.datecreatetext.TabStop = False
        '
        'card_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 262)
        Me.Controls.Add(Me.card_remark)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.card_type_combo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.card_no)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.datecreatetext)
        Me.Controls.Add(Me.card_ID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "card_new"
        Me.Text = "Add New Card"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents card_no As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents card_type_combo As ComboBox
    Friend WithEvents card_remark As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents card_ID As TextBox
    Friend WithEvents datecreatetext As TextBox
End Class
