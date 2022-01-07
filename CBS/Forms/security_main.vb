Imports MySql.Data.MySqlClient
Public Class security_main
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Public Sub BindGrid()
        Dim query As String
        query = "Select bk_ID,bk_vhccollect,vhc_PlateNo,bk_outtime,bk_intime,bk_outmeter,bk_vhcID,bk_OUTcheckbyID, bk_name, bk_empID, bk_INOUTstatus from booking LEFT OUTER JOIN vehicle ON (booking.bk_vhcID = vehicle.vhc_ID) WHERE bk_approval = '1' AND bk_complete = '0' AND bk_outmeter IS NULL ORDER BY bk_ID"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.ColumnCount = 11
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "bk_ID"
                        DataGridView1.Columns(0).HeaderText = "Booking No"
                        DataGridView1.Columns(0).DataPropertyName = "bk_ID"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "bk_vhccollect"
                        DataGridView1.Columns(1).HeaderText = "Date"
                        DataGridView1.Columns(1).DataPropertyName = "bk_vhccollect"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False
                        DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy"

                        DataGridView1.Columns(2).Name = "vhc_PlateNo"
                        DataGridView1.Columns(2).HeaderText = "Plate No"
                        DataGridView1.Columns(2).DataPropertyName = "vhc_PlateNo"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "bk_INOUTstatus"
                        DataGridView1.Columns(3).HeaderText = "IN OUT Status"
                        DataGridView1.Columns(3).DataPropertyName = "bk_INOUTstatus"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False

                        DataGridView1.Columns(4).Name = "bk_outtime"
                        DataGridView1.Columns(4).HeaderText = "Out Time"
                        DataGridView1.Columns(4).DataPropertyName = "bk_outtime"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False
                        DataGridView1.Columns(4).Visible = False

                        DataGridView1.Columns(5).Name = "bk_intime"
                        DataGridView1.Columns(5).HeaderText = "In Time"
                        DataGridView1.Columns(5).DataPropertyName = "bk_intime"
                        DataGridView1.Columns(5).ReadOnly = True
                        DataGridView1.Columns(5).Resizable = False
                        DataGridView1.Columns(5).Visible = False

                        DataGridView1.Columns(6).Name = "bk_outmeter"
                        DataGridView1.Columns(6).HeaderText = "Out Meter"
                        DataGridView1.Columns(6).DataPropertyName = "bk_outmeter"
                        DataGridView1.Columns(6).ReadOnly = True
                        DataGridView1.Columns(6).Resizable = False
                        DataGridView1.Columns(6).Visible = False

                        DataGridView1.Columns(7).Name = "bk_vhcID"
                        DataGridView1.Columns(7).HeaderText = "vehicle ID"
                        DataGridView1.Columns(7).DataPropertyName = "bk_vhcID"
                        DataGridView1.Columns(7).ReadOnly = True
                        DataGridView1.Columns(7).Resizable = False
                        DataGridView1.Columns(7).Visible = False

                        DataGridView1.Columns(8).Name = "bk_OUTcheckbyID"
                        DataGridView1.Columns(8).HeaderText = "check by"
                        DataGridView1.Columns(8).DataPropertyName = "bk_OUTcheckbyID"
                        DataGridView1.Columns(8).ReadOnly = True
                        DataGridView1.Columns(8).Resizable = False
                        DataGridView1.Columns(8).Visible = False

                        DataGridView1.Columns(9).Name = "bk_name"
                        DataGridView1.Columns(9).HeaderText = "emp name"
                        DataGridView1.Columns(9).DataPropertyName = "bk_name"
                        DataGridView1.Columns(9).ReadOnly = True
                        DataGridView1.Columns(9).Resizable = False
                        DataGridView1.Columns(9).Visible = False

                        DataGridView1.Columns(10).Name = "bk_empID"
                        DataGridView1.Columns(10).HeaderText = "emp ID"
                        DataGridView1.Columns(10).DataPropertyName = "bk_empID"
                        DataGridView1.Columns(10).ReadOnly = True
                        DataGridView1.Columns(10).Resizable = False
                        DataGridView1.Columns(10).Visible = False
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub security_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString

        DataGridView2.CurrentCell = Nothing
        BindGrid0()

        Dim findguard As String
        findguard = "SELECT usr_name FROM users WHERE usr_level = '0' AND usr_active = '1' "
        conn.Open()
        cmd = New MySqlCommand(findguard, conn)
        db = cmd.ExecuteReader()
        While db.Read()
            sc_name.Items.Add(db.Item("usr_name"))
        End While
        conn.Close()

        DataGridView1.CurrentCell = Nothing
        BindGrid()

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Focus()
    End Sub


    Public Sub BindGrid0()
        Dim query As String
        query = "SELECT vehicle.vhc_PlateNo, vehicle.vhc_brand, vehicle.vhc_model, vehicle.vhc_key_status FROM vehicle INNER JOIN vehicle_acce_info ON vehicle_acce_info.vhcacc_vhcID = vehicle.vhc_ID WHERE vehicle_acce_info.vhcacc_repairstatus = '0' AND NOT vehicle.vhc_type = 'Lorry'"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView2.AutoGenerateColumns = False
                        DataGridView2.ColumnCount = 4
                        DataGridView1.ReadOnly = True

                        DataGridView2.Columns(0).Name = "vhc_PlateNo"
                        DataGridView2.Columns(0).HeaderText = "Plate No"
                        DataGridView2.Columns(0).DataPropertyName = "vhc_PlateNo"
                        DataGridView2.Columns(0).ReadOnly = True
                        DataGridView2.Columns(0).Resizable = False

                        DataGridView2.Columns(1).Name = "vhc_brand"
                        DataGridView2.Columns(1).HeaderText = "Brand"
                        DataGridView2.Columns(1).DataPropertyName = "vhc_brand"
                        DataGridView2.Columns(1).ReadOnly = True
                        DataGridView2.Columns(1).Resizable = False

                        DataGridView2.Columns(2).Name = "vhc_model"
                        DataGridView2.Columns(2).HeaderText = "Model"
                        DataGridView2.Columns(2).DataPropertyName = "vhc_model"
                        DataGridView2.Columns(2).ReadOnly = True
                        DataGridView2.Columns(2).Width = "100"
                        DataGridView2.Columns(2).Resizable = False

                        DataGridView2.Columns(3).Name = "vhc_key_status"
                        DataGridView2.Columns(3).HeaderText = "Key Status"
                        DataGridView2.Columns(3).DataPropertyName = "vhc_key_status"
                        DataGridView2.Columns(3).ReadOnly = True
                        DataGridView2.Columns(3).Resizable = False

                        DataGridView2.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub ' A

    Private Sub sc_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sc_name.SelectedIndexChanged
        Dim GetguardID As String
        GetguardID = "SELECT usr_ID FROM users WHERE usr_name = '" & sc_name.Text & "'"
        conn.Open()
        cmd = New MySqlCommand(GetguardID, conn)
        db = cmd.ExecuteReader()
        While db.Read()
            sec_ID.Text = db.Item("usr_ID")
        End While
        conn.Close()
    End Sub

    Public Sub InsertRcd(ByRef SQLStatement As String)
        Try
            conn.Open()
            With cmd
                .CommandText = SQLStatement
                .CommandType = CommandType.Text
                .Connection = conn
                .ExecuteNonQuery()
            End With
            conn.Close()
            conn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            sc_bkIDtext.Text = row.Cells("bk_ID").Value.ToString
            sc_bkintime.Text = row.Cells("bk_intime").Value.ToString
            sc_bkouttime.Text = row.Cells("bk_outtime").Value.ToString
            sc_bkoutmeter.Text = row.Cells("bk_outmeter").Value.ToString
            bkvhcIDtext.Text = row.Cells("bk_vhcID").Value.ToString ' Take vhc id here
            Outby_usrID.Text = row.Cells("bk_OUTcheckbyID").Value.ToString
            sc_bkdate.Text = row.Cells("bk_vhccollect").Value.ToString

            ' Assign needed value here for key status record
            LabelPN.Text = row.Cells("vhc_PlateNo").Value.ToString
            LabelEmpID.Text = row.Cells("bk_empID").Value.ToString
            LabelEmpName.Text = row.Cells("bk_name").Value.ToString

            If sc_bkintime.Text = "" And sc_bkouttime.Text = "" Then
                Button1.Enabled = True
                Button2.Enabled = False
            Else
                Button1.Enabled = False
                Button2.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checkout As New security_checkOUT
        checkout.MdiParent = MainMDI
        Dim todaydate As Date
        todaydate = Date.Today.ToShortDateString

        LabelDate.Text = DateTime.Now.ToString()

        If sc_name.Text = "" Then
            MsgBox("Please select - CHECK BY - before processed.")
        ElseIf sc_bkdate.Text > todaydate Then
            If MsgBox("Outing date for booking NO :" & sc_bkIDtext.Text & " is on " & sc_bkdate.Text & "." & vbNewLine & "Confirm to processed?", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.Yes Then
                checkout.secName.Text = sc_name.Text
                checkout.secID.Text = sec_ID.Text
                checkout.sec_bkID.Text = sc_bkIDtext.Text
                checkout.sec_vhcID.Text = bkvhcIDtext.Text
                ' --------------------------------------------------------
                checkout.LabelEmpID.Text = LabelEmpID.Text
                checkout.LabelEmpName.Text = LabelEmpName.Text
                checkout.LabelDate.Text = LabelDate.Text
                checkout.LabelPN.Text = LabelPN.Text
                checkout.Show()
            End If
        Else
            checkout.secName.Text = sc_name.Text
            checkout.secID.Text = sec_ID.Text
            checkout.sec_bkID.Text = sc_bkIDtext.Text
            checkout.sec_vhcID.Text = bkvhcIDtext.Text 'here
            ' --------------------------------------------------------
            checkout.LabelEmpID.Text = LabelEmpID.Text
            checkout.LabelEmpName.Text = LabelEmpName.Text
            checkout.LabelDate.Text = LabelDate.Text
            checkout.LabelPN.Text = LabelPN.Text
            checkout.Show()
        End If

        LabelDate.Text = ""

        LabelPN.Text = ""

        DataGridView2.DataSource = Nothing ' Clear Data Bind data before re-assign data.. *! importtant
        BindGrid0()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim checkin As New security_checkIN
        checkin.MdiParent = MainMDI

        LabelDate.Text = DateTime.Now.ToString()

        If sc_name.Text = "" Then
            MsgBox("Please select - CHECK BY - before processed.")
        Else
            checkin.secName.Text = sc_name.Text
            checkin.secID.Text = sec_ID.Text
            checkin.sec_bkID.Text = sc_bkIDtext.Text
            checkin.outmeter.Text = sc_bkoutmeter.Text
            checkin.sec_vhcID.Text = bkvhcIDtext.Text
            '-----------------------------------------------------------------
            checkin.LabelEmpID.Text = LabelEmpID.Text
            checkin.LabelEmpName.Text = LabelEmpName.Text
            checkin.LabelDate.Text = LabelDate.Text
            checkin.LabelPN.Text = LabelPN.Text
            checkin.Show()
        End If

        LabelDate.Text = ""

        LabelPN.Text = ""

        DataGridView2.DataSource = Nothing ' Clear Data Bind data before re-assign data.. *! importtant
        BindGrid0()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Public Sub BindGrid1()
        Dim query As String
        query = "Select bk_ID,bk_vhccollect,vhc_PlateNo,bk_outtime,bk_intime,bk_outmeter,bk_vhcID,bk_OUTcheckbyID, bk_name, bk_empID, bk_INOUTstatus from booking LEFT OUTER JOIN vehicle ON (booking.bk_vhcID = vehicle.vhc_ID) WHERE bk_approval = '1' AND bk_complete = '0' AND NOT bk_outmeter IS null ORDER BY bk_ID"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.ColumnCount = 11
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "bk_ID"
                        DataGridView1.Columns(0).HeaderText = "Booking No"
                        DataGridView1.Columns(0).DataPropertyName = "bk_ID"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "bk_vhccollect"
                        DataGridView1.Columns(1).HeaderText = "Date"
                        DataGridView1.Columns(1).DataPropertyName = "bk_vhccollect"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False
                        DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy"

                        DataGridView1.Columns(2).Name = "vhc_PlateNo"
                        DataGridView1.Columns(2).HeaderText = "Plate No"
                        DataGridView1.Columns(2).DataPropertyName = "vhc_PlateNo"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "bk_INOUTstatus"
                        DataGridView1.Columns(3).HeaderText = "IN OUT Status"
                        DataGridView1.Columns(3).DataPropertyName = "bk_INOUTstatus"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False

                        DataGridView1.Columns(4).Name = "bk_outtime"
                        DataGridView1.Columns(4).HeaderText = "Out Time"
                        DataGridView1.Columns(4).DataPropertyName = "bk_outtime"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False
                        DataGridView1.Columns(4).Visible = False

                        DataGridView1.Columns(5).Name = "bk_intime"
                        DataGridView1.Columns(5).HeaderText = "In Time"
                        DataGridView1.Columns(5).DataPropertyName = "bk_intime"
                        DataGridView1.Columns(5).ReadOnly = True
                        DataGridView1.Columns(5).Resizable = False
                        DataGridView1.Columns(5).Visible = False

                        DataGridView1.Columns(6).Name = "bk_outmeter"
                        DataGridView1.Columns(6).HeaderText = "Out Meter"
                        DataGridView1.Columns(6).DataPropertyName = "bk_outmeter"
                        DataGridView1.Columns(6).ReadOnly = True
                        DataGridView1.Columns(6).Resizable = False
                        DataGridView1.Columns(6).Visible = False

                        DataGridView1.Columns(7).Name = "bk_vhcID"
                        DataGridView1.Columns(7).HeaderText = "vehicle ID"
                        DataGridView1.Columns(7).DataPropertyName = "bk_vhcID"
                        DataGridView1.Columns(7).ReadOnly = True
                        DataGridView1.Columns(7).Resizable = False
                        DataGridView1.Columns(7).Visible = False

                        DataGridView1.Columns(8).Name = "bk_OUTcheckbyID"
                        DataGridView1.Columns(8).HeaderText = "check by"
                        DataGridView1.Columns(8).DataPropertyName = "bk_OUTcheckbyID"
                        DataGridView1.Columns(8).ReadOnly = True
                        DataGridView1.Columns(8).Resizable = False
                        DataGridView1.Columns(8).Visible = False

                        DataGridView1.Columns(9).Name = "bk_name"
                        DataGridView1.Columns(9).HeaderText = "emp name"
                        DataGridView1.Columns(9).DataPropertyName = "bk_name"
                        DataGridView1.Columns(9).ReadOnly = True
                        DataGridView1.Columns(9).Resizable = False
                        DataGridView1.Columns(9).Visible = False

                        DataGridView1.Columns(10).Name = "bk_empID"
                        DataGridView1.Columns(10).HeaderText = "emp ID"
                        DataGridView1.Columns(10).DataPropertyName = "bk_empID"
                        DataGridView1.Columns(10).ReadOnly = True
                        DataGridView1.Columns(10).Resizable = False
                        DataGridView1.Columns(10).Visible = False
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.DataSource = Nothing
        BindGrid1()
        Button1.Enabled = False
        Button2.Enabled = False
        'Button2.Visible = False
        Outby_usrName.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView1.DataSource = Nothing
        BindGrid()
        DataGridView2.DataSource = Nothing
        BindGrid0()
        Button1.Enabled = False
        'Button1.Visible = False
        Button2.Enabled = False
        Outby_usrName.Text = ""
    End Sub

    Private Sub Outby_usrID_TextChanged(sender As Object, e As EventArgs) Handles Outby_usrID.TextChanged
        Dim findname As String
        findname = "SELECT usr_name FROM users WHERE usr_ID = '" & Outby_usrID.Text & "' "
        conn.Open()
        cmd = New MySqlCommand(findname, conn)
        db = cmd.ExecuteReader()
        While db.Read()
            Outby_usrName.Text = db.Item("usr_name")
        End While
        conn.Close()
    End Sub

    Private Sub ButtonShowList_Click(sender As Object, e As EventArgs) Handles ButtonShowList.Click
        Dim viewrecord As New key_borrow_list
        'viewrecord.MdiParent = Me
        viewrecord.Show()
    End Sub ' A

    Private Sub RefreshButton3_Click(sender As Object, e As EventArgs) Handles RefreshButton3.Click
        DataGridView1.DataSource = Nothing
        BindGrid()
        DataGridView2.DataSource = Nothing
        BindGrid0()
    End Sub ' A

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class