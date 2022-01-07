Imports MySql.Data.MySqlClient
Public Class Report_Security
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Public Sub BindGrid0()
        Dim query As String
        query = "SELECT * FROM booking LEFT OUTER JOIN vehicle ON (booking.bk_vhcID = vehicle.vhc_ID) LEFT OUTER JOIN security_check ON (booking.bk_ID = security_check.sc_bkID) WHERE bk_approval = '1' AND bk_bdate BETWEEN '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & DateTimePicker2.Value.ToString("yyyy-<MM-dd") & "' ORDER BY bk_ID"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        'DataGridView1.ColumnCount = 10
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "bk_ID"
                        DataGridView1.Columns(0).HeaderText = "Booking No"
                        DataGridView1.Columns(0).DataPropertyName = "bk_ID"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "vhc_PlateNo"
                        DataGridView1.Columns(1).HeaderText = "Registration No"
                        DataGridView1.Columns(1).DataPropertyName = "vhc_PlateNo"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False
                        DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy"

                        DataGridView1.Columns(2).Name = "bk_name"
                        DataGridView1.Columns(2).HeaderText = "Name"
                        DataGridView1.Columns(2).DataPropertyName = "bk_name"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "bk_OUTcheckbyName"
                        DataGridView1.Columns(3).HeaderText = "Out Check By"
                        DataGridView1.Columns(3).DataPropertyName = "bk_OUTcheckbyName"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False

                        DataGridView1.Columns(4).Name = "sc_bkouttime"
                        DataGridView1.Columns(4).HeaderText = "Out Time"
                        DataGridView1.Columns(4).DataPropertyName = "sc_bkouttime"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False
                        DataGridView1.Columns(4).DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss"

                        DataGridView1.Columns(5).Name = "sc_outtimeupd"
                        DataGridView1.Columns(5).HeaderText = "Update on (Out)"
                        DataGridView1.Columns(5).DataPropertyName = "sc_outtimeupd"
                        DataGridView1.Columns(5).ReadOnly = True
                        DataGridView1.Columns(5).Resizable = False
                        DataGridView1.Columns(5).DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss"

                        DataGridView1.Columns(6).Name = "bk_INcheckbyName"
                        DataGridView1.Columns(6).HeaderText = "In Check By"
                        DataGridView1.Columns(6).DataPropertyName = "bk_INcheckbyName"
                        DataGridView1.Columns(6).ReadOnly = True
                        DataGridView1.Columns(6).Resizable = False


                        DataGridView1.Columns(7).Name = "sc_bkintime"
                        DataGridView1.Columns(7).HeaderText = "In Time"
                        DataGridView1.Columns(7).DataPropertyName = "sc_bkintime"
                        DataGridView1.Columns(7).ReadOnly = True
                        DataGridView1.Columns(7).Resizable = False
                        DataGridView1.Columns(7).DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss"

                        DataGridView1.Columns(8).Name = "sc_intimeupd"
                        DataGridView1.Columns(8).HeaderText = "Update On (In)"
                        DataGridView1.Columns(8).DataPropertyName = "sc_intimeupd"
                        DataGridView1.Columns(8).ReadOnly = True
                        DataGridView1.Columns(8).Resizable = False
                        DataGridView1.Columns(8).DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss"

                        DataGridView1.Columns(9).Name = "bk_complete"
                        DataGridView1.Columns(9).HeaderText = "complete"
                        DataGridView1.Columns(9).DataPropertyName = "bk_complete"
                        DataGridView1.Columns(9).ReadOnly = True
                        DataGridView1.Columns(9).Resizable = False
                        DataGridView1.Columns(9).Visible = False

                        DataGridView1.DataSource = dt
                        If dt.Rows.Count = 0 Then
                            MsgBox("No Record Found!")
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DateTimePicker1.Value > DateTimePicker2.Value Then
            MsgBox("Invalid Date Range.")
        Else
            BindGrid0()
        End If
    End Sub

    Private Sub Report_Security_Load(sender As Object, e As EventArgs) Handles Me.Load
        DateTimePicker1.Value = Date.Today.ToShortDateString
        DateTimePicker2.Value = Date.Today.AddMonths(1)
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting

        For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
            If Me.DataGridView1.Rows(i).Cells("bk_complete").Value = 1 Then
                Me.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class