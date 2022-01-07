<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vehicle_RoadTax_Renew
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.vhc_plateNo = New System.Windows.Forms.TextBox()
        Me.vhc_roadtax = New System.Windows.Forms.TextBox()
        Me.vhc_rt_note = New System.Windows.Forms.TextBox()
        Me.newDate = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.vhc_ID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reisgration/ Plate No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Expired Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Expired Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Remark:"
        '
        'vhc_plateNo
        '
        Me.vhc_plateNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhc_plateNo.Location = New System.Drawing.Point(181, 19)
        Me.vhc_plateNo.Name = "vhc_plateNo"
        Me.vhc_plateNo.ReadOnly = True
        Me.vhc_plateNo.Size = New System.Drawing.Size(216, 26)
        Me.vhc_plateNo.TabIndex = 4
        Me.vhc_plateNo.TabStop = False
        '
        'vhc_roadtax
        '
        Me.vhc_roadtax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhc_roadtax.Location = New System.Drawing.Point(181, 51)
        Me.vhc_roadtax.Name = "vhc_roadtax"
        Me.vhc_roadtax.ReadOnly = True
        Me.vhc_roadtax.Size = New System.Drawing.Size(216, 26)
        Me.vhc_roadtax.TabIndex = 5
        Me.vhc_roadtax.TabStop = False
        '
        'vhc_rt_note
        '
        Me.vhc_rt_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhc_rt_note.Location = New System.Drawing.Point(181, 115)
        Me.vhc_rt_note.Multiline = True
        Me.vhc_rt_note.Name = "vhc_rt_note"
        Me.vhc_rt_note.Size = New System.Drawing.Size(216, 83)
        Me.vhc_rt_note.TabIndex = 1
        '
        'newDate
        '
        Me.newDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newDate.Location = New System.Drawing.Point(193, 83)
        Me.newDate.Name = "newDate"
        Me.newDate.Size = New System.Drawing.Size(41, 20)
        Me.newDate.TabIndex = 6
        Me.newDate.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(181, 80)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(216, 26)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(92, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(193, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 36)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'vhc_ID
        '
        Me.vhc_ID.Location = New System.Drawing.Point(181, 22)
        Me.vhc_ID.Name = "vhc_ID"
        Me.vhc_ID.Size = New System.Drawing.Size(22, 20)
        Me.vhc_ID.TabIndex = 11
        Me.vhc_ID.TabStop = False
        '
        'vehicle_RoadTax_Renew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 273)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.vhc_rt_note)
        Me.Controls.Add(Me.newDate)
        Me.Controls.Add(Me.vhc_roadtax)
        Me.Controls.Add(Me.vhc_plateNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vhc_ID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "vehicle_RoadTax_Renew"
        Me.Text = "RoadTax Date Renew"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents vhc_plateNo As TextBox
    Friend WithEvents vhc_roadtax As TextBox
    Friend WithEvents vhc_rt_note As TextBox
    Friend WithEvents newDate As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents vhc_ID As TextBox
End Class
