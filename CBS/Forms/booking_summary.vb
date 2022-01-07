Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class booking_summary
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub booking_summary_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        DateTimePicker1.Value = Date.Today.AddMonths(-1)
        DateTimePicker2.Value = Date.Today.ToString

        ComboBox1.Items.Add("All")

        Dim getvhcPlate As String
        getvhcPlate = "SELECT vhc_PlateNo FROM vehicle WHERE vhc_obsolete = '0'"
        conn.Open()
        cmd = New MySqlCommand(getvhcPlate, conn)
        db = cmd.ExecuteReader()
        While db.Read()
            ComboBox1.Items.Add(db.Item("vhc_PlateNo"))
        End While
        conn.Close()

        Button2.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "All" Then
            PlateNo.Text = "ALL"
        Else
            PlateNo.Text = ComboBox1.SelectedItem.ToString
        End If
    End Sub

    Public Sub BindGrid0()
        Dim query As String
        query = "Select * from booking LEFT OUTER JOIN vehicle ON (booking.bk_vhcID = vehicle.vhc_ID) WHERE vhc_PlateNo = '" & PlateNo.Text & "' AND bk_approval = '1' AND bk_bdate BETWEEN '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & DateTimePicker2.Value.ToString("yyyy-<MM-dd") & "' ORDER BY bk_ID"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        'DataGridView1.ColumnCount = 8
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "bk_ID"
                        DataGridView1.Columns(0).HeaderText = "Booking No"
                        DataGridView1.Columns(0).DataPropertyName = "bk_ID"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "bk_dateBook"
                        DataGridView1.Columns(1).HeaderText = "Date"
                        DataGridView1.Columns(1).DataPropertyName = "bk_dateBook"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False
                        DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy"

                        DataGridView1.Columns(2).Name = "bk_name"
                        DataGridView1.Columns(2).HeaderText = "Name"
                        DataGridView1.Columns(2).DataPropertyName = "bk_name"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "bk_dept"
                        DataGridView1.Columns(3).HeaderText = "Department"
                        DataGridView1.Columns(3).DataPropertyName = "bk_dept"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False

                        DataGridView1.Columns(4).Name = "bk_loctogo"
                        DataGridView1.Columns(4).HeaderText = "Place/Location"
                        DataGridView1.Columns(4).DataPropertyName = "bk_loctogo"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False

                        DataGridView1.Columns(5).Name = "vhc_PlateNo"
                        DataGridView1.Columns(5).HeaderText = "Registration No"
                        DataGridView1.Columns(5).DataPropertyName = "vhc_PlateNo"
                        DataGridView1.Columns(5).ReadOnly = True
                        DataGridView1.Columns(5).Resizable = False

                        DataGridView1.Columns(6).Name = "bk_outtime"
                        DataGridView1.Columns(6).HeaderText = "Actual Time Out"
                        DataGridView1.Columns(6).DataPropertyName = "bk_outtime"
                        DataGridView1.Columns(6).ReadOnly = True
                        DataGridView1.Columns(6).Resizable = False
                        DataGridView1.Columns(6).DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss"

                        DataGridView1.Columns(7).Name = "bk_intime"
                        DataGridView1.Columns(7).HeaderText = "Actual Time In"
                        DataGridView1.Columns(7).DataPropertyName = "bk_intime"
                        DataGridView1.Columns(7).ReadOnly = True
                        DataGridView1.Columns(7).Resizable = False
                        DataGridView1.Columns(7).DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss"

                        DataGridView1.Columns(8).Name = "bk_reason"
                        DataGridView1.Columns(8).HeaderText = "Reason"
                        DataGridView1.Columns(8).DataPropertyName = "bk_reason"
                        DataGridView1.Columns(8).ReadOnly = True
                        DataGridView1.Columns(8).Resizable = False
                        DataGridView1.Columns(8).Visible = False

                        DataGridView1.DataSource = dt
                        Button2.Enabled = True
                        If dt.Rows.Count = 0 Then
                            MsgBox("No Record Found!")
                            Button2.Enabled = False
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub BindGrid1()
        Dim query As String
        query = "Select * from booking LEFT OUTER JOIN vehicle ON (booking.bk_vhcID = vehicle.vhc_ID) WHERE bk_approval = '1' AND bk_bdate BETWEEN '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & DateTimePicker2.Value.ToString("yyyy-<MM-dd") & "' ORDER BY bk_ID"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        'DataGridView1.ColumnCount = 8
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "bk_ID"
                        DataGridView1.Columns(0).HeaderText = "Booking No"
                        DataGridView1.Columns(0).DataPropertyName = "bk_ID"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "bk_dateBook"
                        DataGridView1.Columns(1).HeaderText = "Date"
                        DataGridView1.Columns(1).DataPropertyName = "bk_dateBook"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False
                        DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy"

                        DataGridView1.Columns(2).Name = "bk_name"
                        DataGridView1.Columns(2).HeaderText = "Name"
                        DataGridView1.Columns(2).DataPropertyName = "bk_name"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "bk_dept"
                        DataGridView1.Columns(3).HeaderText = "Department"
                        DataGridView1.Columns(3).DataPropertyName = "bk_dept"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False

                        DataGridView1.Columns(4).Name = "bk_loctogo"
                        DataGridView1.Columns(4).HeaderText = "Place/Location"
                        DataGridView1.Columns(4).DataPropertyName = "bk_loctogo"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False

                        DataGridView1.Columns(5).Name = "vhc_PlateNo"
                        DataGridView1.Columns(5).HeaderText = "Registration No"
                        DataGridView1.Columns(5).DataPropertyName = "vhc_PlateNo"
                        DataGridView1.Columns(5).ReadOnly = True
                        DataGridView1.Columns(5).Resizable = False

                        DataGridView1.Columns(6).Name = "bk_outtime"
                        DataGridView1.Columns(6).HeaderText = "Actual Time Out"
                        DataGridView1.Columns(6).DataPropertyName = "bk_outtime"
                        DataGridView1.Columns(6).ReadOnly = True
                        DataGridView1.Columns(6).Resizable = False
                        DataGridView1.Columns(6).DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss"

                        DataGridView1.Columns(7).Name = "bk_intime"
                        DataGridView1.Columns(7).HeaderText = "Actual Time In"
                        DataGridView1.Columns(7).DataPropertyName = "bk_intime"
                        DataGridView1.Columns(7).ReadOnly = True
                        DataGridView1.Columns(7).Resizable = False
                        DataGridView1.Columns(7).DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss"

                        DataGridView1.Columns(8).Name = "bk_reason"
                        DataGridView1.Columns(8).HeaderText = "Reason"
                        DataGridView1.Columns(8).DataPropertyName = "bk_reason"
                        DataGridView1.Columns(8).ReadOnly = True
                        DataGridView1.Columns(8).Resizable = False
                        DataGridView1.Columns(8).Visible = False

                        DataGridView1.DataSource = dt
                        Button2.Enabled = True
                        If dt.Rows.Count = 0 Then
                            MsgBox("No Record Found!")
                            Button2.Enabled = False
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DateTimePicker1.Value > DateTimePicker2.Value Then
            MsgBox("Invalid Date Range.")
        ElseIf PlateNo.Text = "" Then
            MsgBox("No Vehicle Selected !" + vbCrLf + "Please select vehicle registration NO to procced.")
        Else
            If PlateNo.Text = "ALL" Then
                DataGridView1.DataSource = Nothing
                BindGrid1()
            Else
                DataGridView1.DataSource = Nothing
                BindGrid0()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GridtoExcel(DataGridView1)
    End Sub

    Public Sub GridtoExcel(ByVal ddgv As DataGridView)
        Dim exapp As New Microsoft.Office.Interop.Excel.Application
        Dim newwb As Microsoft.Office.Interop.Excel.Workbook
        Dim newws As Microsoft.Office.Interop.Excel.Worksheet
        Dim col As Integer = ddgv.ColumnCount
        Dim row As Integer = ddgv.RowCount
        newwb = exapp.Workbooks.Add
        newws = exapp.Worksheets.Add()

        For i As Integer = 1 To col
            newws.Cells.Item(1, i) = ddgv.Columns(i - 1).Name.ToString
        Next

        For fila As Integer = 0 To row - 1
            For e As Integer = 0 To col - 1
                newws.Cells.Item(fila + 2, e + 1) = ddgv.Rows(fila).Cells(e).Value
            Next
        Next

        newws.Rows.Item(1).Font.Bold = 1
        newws.Rows.Item(1).HorizontalAlignment = 3
        newws.Columns.AutoFit()
        exapp.Application.Visible = True
        exapp.Application.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized
        newws = Nothing
        newwb = Nothing
        exapp = Nothing

    End Sub
End Class