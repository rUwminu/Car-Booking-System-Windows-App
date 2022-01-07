<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vehicle_RepairDone
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
        Me.vhcrp_plateno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DoneRpNote = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.vhcrpID = New System.Windows.Forms.TextBox()
        Me.rp_vhcID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'vhcrp_plateno
        '
        Me.vhcrp_plateno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhcrp_plateno.Location = New System.Drawing.Point(144, 22)
        Me.vhcrp_plateno.Name = "vhcrp_plateno"
        Me.vhcrp_plateno.ReadOnly = True
        Me.vhcrp_plateno.Size = New System.Drawing.Size(128, 26)
        Me.vhcrp_plateno.TabIndex = 6
        Me.vhcrp_plateno.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Registration NO:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(144, 54)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 26)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Done ON:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 40)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Done Repair " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remark :"
        '
        'DoneRpNote
        '
        Me.DoneRpNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoneRpNote.Location = New System.Drawing.Point(144, 89)
        Me.DoneRpNote.Multiline = True
        Me.DoneRpNote.Name = "DoneRpNote"
        Me.DoneRpNote.Size = New System.Drawing.Size(128, 77)
        Me.DoneRpNote.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 41)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'vhcrpID
        '
        Me.vhcrpID.Location = New System.Drawing.Point(177, 123)
        Me.vhcrpID.Name = "vhcrpID"
        Me.vhcrpID.Size = New System.Drawing.Size(38, 20)
        Me.vhcrpID.TabIndex = 7
        Me.vhcrpID.TabStop = False
        '
        'rp_vhcID
        '
        Me.rp_vhcID.Location = New System.Drawing.Point(177, 97)
        Me.rp_vhcID.Name = "rp_vhcID"
        Me.rp_vhcID.Size = New System.Drawing.Size(38, 20)
        Me.rp_vhcID.TabIndex = 8
        Me.rp_vhcID.TabStop = False
        '
        'vehicle_RepairDone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DoneRpNote)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vhcrp_plateno)
        Me.Controls.Add(Me.vhcrpID)
        Me.Controls.Add(Me.rp_vhcID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "vehicle_RepairDone"
        Me.Text = "vehicle_RepairDone"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vhcrp_plateno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DoneRpNote As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents vhcrpID As TextBox
    Friend WithEvents rp_vhcID As TextBox
End Class
