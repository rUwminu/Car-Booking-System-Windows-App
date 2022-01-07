Imports MySql.Data.MySqlClient
Imports System.IO

Public Class booking_display
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim bkstarttime As Date
    Dim bkendtime As Date


    Private Sub booking_display_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'CBSDataSet.booking' table. You can move, or remove it, as needed.
        'Me.BookingTableAdapter.Fill(Me.CBSDataSet.booking)
        conn.ConnectionString = ServerString
        uButton2.Visible = False
        uButton3.Visible = False
        uButton4.Visible = False
        ButtonApprove.Visible = False
        ButtonApprove.Visible = False
        cancelbtn.Visible = False
        usrGroupBox.Enabled = False
        vhcGroupBox.Enabled = False
        vhcinfolabel.Visible = False
        PrintButton.Visible = False

        ' Add more bind here!!!
        If MainMDI.display_lvl.Text = "0" Or MainMDI.display_lvl.Text = "1" Then
            BindGrid0()
        ElseIf MainMDI.display_lvl.Text = "2" Then
            BindGrid3()
            'Button2.Visible = False
        Else
            BindGrid1()
        End If

        If MainMDI.display_lvl.Text = "0" Or MainMDI.display_lvl.Text = "1" Then
            Button2.Visible = True
        Else
            Button2.Visible = False
        End If

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim approveprint As String
        Dim iscompletestatus As String
        Dim bkID As String
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            bk_ID_label.Text = row.Cells("bk_ID").Value.ToString
            bk_vhcIDtext.Text = row.Cells("bk_vhcID").Value.ToString
            approveprint = row.Cells("bk_approva_text").Value.ToString
            iscompletestatus = row.Cells("bk_complete").Value.ToString
            LabelEmpID.Text = row.Cells("bk_empID").Value.ToString ' Here Get Emp ID, assign to label to hold data

            If approveprint = "Approved" And iscompletestatus = 0 Then
                PrintButton.Visible = True
            Else
                PrintButton.Visible = False
            End If

            If MainMDI.LabelEmpID.Text = LabelEmpID.Text Then
                ButtonApprove.Visible = False
                ButtonDecline.Visible = False
            Else
                ButtonApprove.Visible = True
                ButtonDecline.Visible = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then

            DataGridView1.DataSource = Nothing
            bk_ID_label.Text = Nothing
            BindGridB()
            DataGridView1.CurrentCell = Nothing
        Else
            DataGridView1.DataSource = Nothing
            bk_ID_label.Text = Nothing

            If MainMDI.display_lvl.Text = "1" Then
                BindGrid0()
            ElseIf MainMDI.display_lvl.Text = "0" Then
                BindGrid3()
            Else
                BindGrid1()
            End If
            DataGridView1.CurrentCell = Nothing

        End If

    End Sub

    Private Sub bk_ID_label_TextChanged(sender As Object, e As EventArgs) Handles bk_ID_label.TextChanged
        conn.ConnectionString = ServerString
        If bk_ID_label.Text = Nothing Then

            Dim a As Control
            For Each a In Me.Controls
                If TypeOf a Is TextBox Then
                    a.Text = Nothing
                End If
            Next

        Else
            Dim query As String
            query = "Select * from booking LEFT OUTER JOIN vehicle ON (booking.bk_vhcID = vehicle.vhc_ID) WHERE bk_ID = '" & bk_ID_label.Text & "'"

            conn.Open()
            cmd = New MySqlCommand(query, conn)
            db = cmd.ExecuteReader()
            db.Read()
            bk_name.Text = db("bk_name").ToString
            bk_dept.Text = db("bk_dept").ToString
            DateTimePicker1.Value = db("bk_vhccollect").ToString
            DateTimePicker2.Value = db("bk_vhcreturn").ToString
            bk_loctogo.Text = db("bk_loctogo").ToString
            bk_reason.Text = db("bk_reason").ToString
            IsApprtxt.Text = db("bk_approval_1lvl").ToString
            bk_plateno.Text = db("vhc_PlateNo").ToString
            Bk_model.Text = db("vhc_model").ToString
            bk_brand.Text = db("vhc_brand").ToString
            bk_vhccategory.Text = db("vhc_category").ToString

            Dim img As Byte()
            img = CType(db("vhc_img"), Byte())
            Using ms As New MemoryStream(img)
                If ms.Length = 0 Then
                    PBX1.Image = Nothing
                Else
                    PBX1.Image = Image.FromStream(ms)
                End If
            End Using
            conn.Close()
        End If
        conn.Close()
        conn.Dispose()
    End Sub

    Public Sub BindGrid0()
        Dim query As String
        query = " SELECT bk_ID, bk_bdate, bk_approva_text, bk_vhcID, bk_complete, bk_empID, usr_name FROM booking " +
                " LEFT JOIN users ON bk_approveby = usr_ID " +
                " WHERE bk_approval_1lvl = '0' AND NOT bk_approva_text = 'Declined' AND NOT bk_approva_text = 'Cancel' " +
                " ORDER BY bk_ID DESC "

        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.ColumnCount = 7
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "bk_ID"
                        DataGridView1.Columns(0).HeaderText = "Booking No"
                        DataGridView1.Columns(0).DataPropertyName = "bk_ID"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "bk_bdate"
                        DataGridView1.Columns(1).HeaderText = "Date"
                        DataGridView1.Columns(1).DataPropertyName = "bk_bdate"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "bk_approva_text"
                        DataGridView1.Columns(2).HeaderText = "Approval"
                        DataGridView1.Columns(2).DataPropertyName = "bk_approva_text"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "bk_vhcID"
                        DataGridView1.Columns(3).HeaderText = "vehicle ID"
                        DataGridView1.Columns(3).DataPropertyName = "bk_vhcID"
                        DataGridView1.Columns(3).Visible = False
                        DataGridView1.Columns(3).ReadOnly = True

                        DataGridView1.Columns(4).Name = "bk_complete"
                        DataGridView1.Columns(4).HeaderText = "Complete"
                        DataGridView1.Columns(4).DataPropertyName = "bk_complete"
                        DataGridView1.Columns(4).Visible = False
                        DataGridView1.Columns(4).ReadOnly = True

                        DataGridView1.Columns(5).Name = "bk_empID"
                        DataGridView1.Columns(5).HeaderText = "Emp ID"
                        DataGridView1.Columns(5).DataPropertyName = "bk_empID"
                        DataGridView1.Columns(5).Visible = False
                        DataGridView1.Columns(5).ReadOnly = True

                        DataGridView1.Columns(6).Name = "usr_name"
                        DataGridView1.Columns(6).HeaderText = "Approval User"
                        DataGridView1.Columns(6).DataPropertyName = "usr_name"
                        DataGridView1.Columns(6).ReadOnly = True
                        DataGridView1.Columns(6).Resizable = False

                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub BindGrid1()
        Dim query As String
        'query = " SELECT * FROM booking WHERE bk_complete = '0' AND bk_createbyID = '" & MainMDI.usr_id_label.Text & "' ORDER BY bk_ID DESC "

        query = " SELECT bk_ID, bk_bdate, bk_approva_text, bk_vhcID, bk_complete, bk_empID, usr_name FROM booking " +
                " LEFT JOIN users ON bk_approveby = usr_ID " +
                " WHERE bk_complete = '0' AND bk_createbyID = '" & MainMDI.usr_id_label.Text & "' " +
                " ORDER BY bk_ID DESC "

        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.ColumnCount = 7
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "bk_ID"
                        DataGridView1.Columns(0).HeaderText = "Booking No"
                        DataGridView1.Columns(0).DataPropertyName = "bk_ID"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "bk_bdate"
                        DataGridView1.Columns(1).HeaderText = "Date"
                        DataGridView1.Columns(1).DataPropertyName = "bk_bdate"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "bk_approva_text"
                        DataGridView1.Columns(2).HeaderText = "Approval"
                        DataGridView1.Columns(2).DataPropertyName = "bk_approva_text"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "bk_vhcID"
                        DataGridView1.Columns(3).HeaderText = "vehicle ID"
                        DataGridView1.Columns(3).DataPropertyName = "bk_vhcID"
                        DataGridView1.Columns(3).Visible = False
                        DataGridView1.Columns(3).ReadOnly = True

                        DataGridView1.Columns(4).Name = "bk_complete"
                        DataGridView1.Columns(4).HeaderText = "Complete"
                        DataGridView1.Columns(4).DataPropertyName = "bk_complete"
                        DataGridView1.Columns(4).Visible = False
                        DataGridView1.Columns(4).ReadOnly = True

                        DataGridView1.Columns(5).Name = "bk_empID"
                        DataGridView1.Columns(5).HeaderText = "Emp ID"
                        DataGridView1.Columns(5).DataPropertyName = "bk_empID"
                        DataGridView1.Columns(5).Visible = False
                        DataGridView1.Columns(5).ReadOnly = True

                        DataGridView1.Columns(6).Name = "usr_name"
                        DataGridView1.Columns(6).HeaderText = "Approval User"
                        DataGridView1.Columns(6).DataPropertyName = "usr_name"
                        DataGridView1.Columns(6).ReadOnly = True
                        DataGridView1.Columns(6).Resizable = False

                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub BindGrid3()
        Dim query As String
        query = " SELECT * FROM booking WHERE bk_approval = '0' AND bk_approval_1lvl = '1' ORDER BY bk_ID DESC "


        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.ColumnCount = 7
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "bk_ID"
                        DataGridView1.Columns(0).HeaderText = "Booking No"
                        DataGridView1.Columns(0).DataPropertyName = "bk_ID"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "bk_bdate"
                        DataGridView1.Columns(1).HeaderText = "Date"
                        DataGridView1.Columns(1).DataPropertyName = "bk_bdate"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "bk_approva_text"
                        DataGridView1.Columns(2).HeaderText = "Approval"
                        DataGridView1.Columns(2).DataPropertyName = "bk_approva_text"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "bk_vhcID"
                        DataGridView1.Columns(3).HeaderText = "vehicle ID"
                        DataGridView1.Columns(3).DataPropertyName = "bk_vhcID"
                        DataGridView1.Columns(3).Visible = False
                        DataGridView1.Columns(3).ReadOnly = True

                        DataGridView1.Columns(4).Name = "bk_complete"
                        DataGridView1.Columns(4).HeaderText = "Complete"
                        DataGridView1.Columns(4).DataPropertyName = "bk_complete"
                        DataGridView1.Columns(4).Visible = False
                        DataGridView1.Columns(4).ReadOnly = True

                        DataGridView1.Columns(5).Name = "bk_empID"
                        DataGridView1.Columns(5).HeaderText = "Emp ID"
                        DataGridView1.Columns(5).DataPropertyName = "bk_empID"
                        DataGridView1.Columns(5).Visible = False
                        DataGridView1.Columns(5).ReadOnly = True

                        DataGridView1.Columns(6).Name = "usr_name"
                        DataGridView1.Columns(6).HeaderText = "Approval User"
                        DataGridView1.Columns(6).DataPropertyName = "usr_name"
                        DataGridView1.Columns(6).ReadOnly = True
                        DataGridView1.Columns(6).Resizable = False

                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub BindGridA()
        Dim query2 As String
        'query2 = " SELECT * FROM booking ORDER BY bk_ID DESC"

        query2 = " SELECT bk_ID, bk_bdate, bk_approva_text, bk_vhcID, bk_complete, bk_empID, usr_name FROM booking " +
                 " LEFT JOIN users ON bk_approveby = usr_ID " +
                 " ORDER BY bk_ID DESC "

        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query2, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.ColumnCount = 7
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "bk_ID"
                        DataGridView1.Columns(0).HeaderText = "Booking No"
                        DataGridView1.Columns(0).DataPropertyName = "bk_ID"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "bk_bdate"
                        DataGridView1.Columns(1).HeaderText = "Date"
                        DataGridView1.Columns(1).DataPropertyName = "bk_bdate"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "bk_approva_text"
                        DataGridView1.Columns(2).HeaderText = "Approval"
                        DataGridView1.Columns(2).DataPropertyName = "bk_approva_text"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "bk_vhcID"
                        DataGridView1.Columns(3).HeaderText = "vehicle ID"
                        DataGridView1.Columns(3).DataPropertyName = "bk_vhcID"
                        DataGridView1.Columns(3).Visible = False
                        DataGridView1.Columns(3).ReadOnly = True

                        DataGridView1.Columns(4).Name = "bk_complete"
                        DataGridView1.Columns(4).HeaderText = "Complete"
                        DataGridView1.Columns(4).DataPropertyName = "bk_complete"
                        DataGridView1.Columns(4).Visible = False
                        DataGridView1.Columns(4).ReadOnly = True

                        DataGridView1.Columns(5).Name = "bk_empID"
                        DataGridView1.Columns(5).HeaderText = "Emp ID"
                        DataGridView1.Columns(5).DataPropertyName = "bk_empID"
                        DataGridView1.Columns(5).Visible = False
                        DataGridView1.Columns(5).ReadOnly = True

                        DataGridView1.Columns(6).Name = "usr_name"
                        DataGridView1.Columns(6).HeaderText = "Approval User"
                        DataGridView1.Columns(6).DataPropertyName = "usr_name"
                        DataGridView1.Columns(6).ReadOnly = True
                        DataGridView1.Columns(6).Resizable = False

                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub BindGridB()
        Dim query As String
        'query = " SELECT * FROM booking WHERE bk_createbyID = '" & MainMDI.usr_id_label.Text & "' ORDER BY bk_ID DESC "

        query = " SELECT bk_ID, bk_bdate, bk_approva_text, bk_vhcID, bk_complete, bk_empID, usr_name FROM booking " +
                " LEFT JOIN users ON bk_approveby = usr_ID " +
                " WHERE bk_createbyID = '" & MainMDI.usr_id_label.Text & "' " +
                " ORDER BY bk_ID DESC "

        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.ColumnCount = 7
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "bk_ID"
                        DataGridView1.Columns(0).HeaderText = "Booking No"
                        DataGridView1.Columns(0).DataPropertyName = "bk_ID"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "bk_bdate"
                        DataGridView1.Columns(1).HeaderText = "Date"
                        DataGridView1.Columns(1).DataPropertyName = "bk_bdate"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "bk_approva_text"
                        DataGridView1.Columns(2).HeaderText = "Approval"
                        DataGridView1.Columns(2).DataPropertyName = "bk_approva_text"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "bk_vhcID"
                        DataGridView1.Columns(3).HeaderText = "vehicle ID"
                        DataGridView1.Columns(3).DataPropertyName = "bk_vhcID"
                        DataGridView1.Columns(3).Visible = False
                        DataGridView1.Columns(3).ReadOnly = True

                        DataGridView1.Columns(4).Name = "bk_complete"
                        DataGridView1.Columns(4).HeaderText = "Complete"
                        DataGridView1.Columns(4).DataPropertyName = "bk_complete"
                        DataGridView1.Columns(4).Visible = False
                        DataGridView1.Columns(4).ReadOnly = True

                        DataGridView1.Columns(5).Name = "bk_empID"
                        DataGridView1.Columns(5).HeaderText = "Emp ID"
                        DataGridView1.Columns(5).DataPropertyName = "bk_empID"
                        DataGridView1.Columns(5).Visible = False
                        DataGridView1.Columns(5).ReadOnly = True

                        DataGridView1.Columns(6).Name = "usr_name"
                        DataGridView1.Columns(6).HeaderText = "Approval User"
                        DataGridView1.Columns(6).DataPropertyName = "usr_name"
                        DataGridView1.Columns(6).ReadOnly = True
                        DataGridView1.Columns(6).Resizable = False

                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub BindGridAmanger()
        Dim query2 As String
        'query2 = " SELECT * FROM booking WHERE bk_approva_text = 'Approved' OR bk_approva_text = 'Declined' ORDER BY bk_ID DESC"

        query2 = " SELECT bk_ID, bk_bdate, bk_approva_text, bk_vhcID, bk_complete, bk_empID, usr_name FROM booking " +
                 " LEFT JOIN users ON bk_approveby = usr_ID " +
                 " WHERE bk_approva_text = 'Approved' OR bk_approva_text = 'Declined' " +
                 " ORDER BY bk_ID DESC "

        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query2, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.ColumnCount = 7
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "bk_ID"
                        DataGridView1.Columns(0).HeaderText = "Booking No"
                        DataGridView1.Columns(0).DataPropertyName = "bk_ID"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "bk_bdate"
                        DataGridView1.Columns(1).HeaderText = "Date"
                        DataGridView1.Columns(1).DataPropertyName = "bk_bdate"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "bk_approva_text"
                        DataGridView1.Columns(2).HeaderText = "Approval"
                        DataGridView1.Columns(2).DataPropertyName = "bk_approva_text"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "bk_vhcID"
                        DataGridView1.Columns(3).HeaderText = "vehicle ID"
                        DataGridView1.Columns(3).DataPropertyName = "bk_vhcID"
                        DataGridView1.Columns(3).Visible = False
                        DataGridView1.Columns(3).ReadOnly = True

                        DataGridView1.Columns(4).Name = "bk_complete"
                        DataGridView1.Columns(4).HeaderText = "Complete"
                        DataGridView1.Columns(4).DataPropertyName = "bk_complete"
                        DataGridView1.Columns(4).Visible = False
                        DataGridView1.Columns(4).ReadOnly = True

                        DataGridView1.Columns(5).Name = "bk_empID"
                        DataGridView1.Columns(5).HeaderText = "Emp ID"
                        DataGridView1.Columns(5).DataPropertyName = "bk_empID"
                        DataGridView1.Columns(5).Visible = False
                        DataGridView1.Columns(5).ReadOnly = True

                        DataGridView1.Columns(6).Name = "usr_name"
                        DataGridView1.Columns(6).HeaderText = "Approval User"
                        DataGridView1.Columns(6).DataPropertyName = "usr_name"
                        DataGridView1.Columns(6).ReadOnly = True
                        DataGridView1.Columns(6).Resizable = False

                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub IsApprtxt_TextChanged(sender As Object, e As EventArgs) Handles IsApprtxt.TextChanged
        If IsApprtxt.Text = "0" Then
            uButton2.Visible = True
            cancelbtn.Visible = True
        Else
            uButton2.Visible = False
            ButtonApprove.Visible = False
            ButtonDecline.Visible = False
            cancelbtn.Visible = False
        End If
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

    ' The Approval Query Here
    Private Sub ButtonApprove_Click(sender As Object, e As EventArgs) Handles ButtonApprove.Click
        If MainMDI.display_lvl.Text = "1" Then
            If vhcGroupBox.Enabled = True Or usrGroupBox.Enabled = True Then
                MsgBox("Please save / cancel your changes before approve.")
            Else

                If MsgBox("Confirm to Aprrove?" + vbCrLf + "Booking No : " & bk_ID_label.Text & "", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.Yes Then
                    Dim yesappr As String
                    yesappr = "UPDATE booking SET bk_approval_1lvl ='1',bk_approveby='" & MainMDI.usr_id_label.Text & "' WHERE bk_ID = '" & bk_ID_label.Text & "'"
                    InsertRcd(yesappr)

                    bk_ID_label.Text = ""
                    DataGridView1.DataSource = Nothing
                    CheckBox1.Checked = False
                    BindGrid0()
                    ButtonApprove.Visible = False
                    ButtonDecline.Visible = False
                    cancelbtn.Visible = False
                    uButton2.Visible = False
                End If
            End If
        ElseIf MainMDI.display_lvl.Text = "0" Then
            If vhcGroupBox.Enabled = True Or usrGroupBox.Enabled = True Then
                MsgBox("Please save / cancel your changes before approve.")
            Else
                If MsgBox("Confirm to Aprrove?" + vbCrLf + "Booking No : " & bk_ID_label.Text & "", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.Yes Then
                    Dim yesappr As String
                    yesappr = "UPDATE booking SET bk_approval ='1',bk_approveby='" & MainMDI.usr_id_label.Text & "',bk_approva_text ='Approved' WHERE bk_ID = '" & bk_ID_label.Text & "'"
                    InsertRcd(yesappr)

                    bk_ID_label.Text = ""
                    DataGridView1.DataSource = Nothing
                    CheckBox1.Checked = False
                    BindGrid0()
                    ButtonApprove.Visible = False
                    ButtonDecline.Visible = False
                    cancelbtn.Visible = False
                    uButton2.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub ButtonDecline_Click(sender As Object, e As EventArgs) Handles ButtonDecline.Click
        If MainMDI.display_lvl.Text = "1" Then
            If vhcGroupBox.Enabled = True Or usrGroupBox.Enabled = True Then
                MsgBox("Please save / cancel your changes before approve.")
            Else

                If MsgBox("Confirm to Decline?" + vbCrLf + "Booking No : " & bk_ID_label.Text & "", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.Yes Then
                    Dim noappr As String
                    Dim chgstatus As String
                    noappr = "UPDATE booking SET bk_approval_1lvl='2',bk_complete='1',bk_approveby='" & MainMDI.usr_id_label.Text & "',bk_approva_text ='Declined' WHERE bk_ID = '" & bk_ID_label.Text & "'"
                    InsertRcd(noappr)
                    chgstatus = "UPDATE vehicle_status SET vhcstatus_status = '0' WHERE vhcstatus_bookingID = '" & bk_ID_label.Text & "'"
                    InsertRcd(chgstatus)
                    bk_ID_label.Text = ""

                    DataGridView1.DataSource = Nothing
                    CheckBox1.Checked = False
                    BindGrid0()
                    DataGridView1.CurrentCell = Nothing
                    ButtonApprove.Visible = False
                    ButtonDecline.Visible = False
                    cancelbtn.Visible = False
                    uButton2.Visible = False
                End If
            End If
        ElseIf MainMDI.display_lvl.Text = "0" Then
            If vhcGroupBox.Enabled = True Or usrGroupBox.Enabled = True Then
                MsgBox("Please save / cancel your changes before approve.")
            Else

                If MsgBox("Confirm to Decline?" + vbCrLf + "Booking No : " & bk_ID_label.Text & "", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.Yes Then
                    Dim noappr As String
                    Dim chgstatus As String
                    noappr = "UPDATE booking SET bk_approval='2',bk_complete='1',bk_approveby='" & MainMDI.usr_id_label.Text & "',bk_approva_text ='Declined' WHERE bk_ID = '" & bk_ID_label.Text & "'"
                    InsertRcd(noappr)
                    chgstatus = "UPDATE vehicle_status SET vhcstatus_status = '0' WHERE vhcstatus_bookingID = '" & bk_ID_label.Text & "'"
                    InsertRcd(chgstatus)
                    bk_ID_label.Text = ""

                    DataGridView1.DataSource = Nothing
                    CheckBox1.Checked = False
                    BindGrid0()
                    DataGridView1.CurrentCell = Nothing
                    ButtonApprove.Visible = False
                    ButtonDecline.Visible = False
                    cancelbtn.Visible = False
                    uButton2.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub uButton2_Click(sender As Object, e As EventArgs) Handles uButton2.Click
        uButton2.Visible = False
        usrGroupBox.Enabled = True
        uButton3.Visible = True
        uButton4.Visible = True
        vhcinfolabel.Visible = True
        Timer1.Start()
        closebtn.Enabled = False
    End Sub

    Private Sub uButton4_Click(sender As Object, e As EventArgs) Handles uButton4.Click
        uButton3.Visible = False
        uButton4.Visible = False
        usrGroupBox.Enabled = False
        uButton2.Visible = True
        vhcinfolabel.Visible = False
        Timer1.Stop()
        closebtn.Enabled = True
    End Sub

    Private Sub uButton3_Click(sender As Object, e As EventArgs) Handles uButton3.Click
        bkstarttime = DateTimePicker1.Value.ToString
        bkendtime = DateTimePicker2.Value.ToString

        If bkstarttime > bkendtime Then
            MsgBox("Wrong date select, estimate return time should not early then booking time !")
        ElseIf bkendtime < Date.Today Then
            MsgBox("Please check your date, previous date selected!")
        Else
            If bk_name.Text = "" Or bk_dept.Text = "" Or bk_reason.Text = "" Or bk_loctogo.Text = "" Then
                MsgBox("PLease complete all field before save.")
            Else
                Dim updusr As String
                updusr = "UPDATE booking SET " _
                    + "bk_name='" & bk_name.Text & "'," _
                    + "bk_dept='" & bk_dept.Text & "'," _
                    + "bk_vhccollect='" & bk_start.Text & "'," _
                    + "bk_vhcreturn='" & bk_end.Text & "'," _
                    + "bk_loctogo='" & bk_loctogo.Text & "'," _
                    + "bk_reason='" & bk_reason.Text & "' WHERE bk_ID='" & bk_ID_label.Text & "'"
                InsertRcd(updusr)
                MsgBox("Booking Detail Updated.")
                uButton3.Visible = False
                uButton4.Visible = False
                usrGroupBox.Enabled = False
                uButton2.Visible = True
                vhcinfolabel.Visible = False
                Timer1.Stop()
                closebtn.Enabled = True
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        vhcinfolabel.Visible = Not vhcinfolabel.Visible
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        If vhcGroupBox.Enabled = True Or usrGroupBox.Enabled = True Then
            MsgBox("Please save / cancel your changes before CANCEL.")
        Else
            If MsgBox("Confirm to CANCEL this Booking?" + vbCrLf + "Booking No : " & bk_ID_label.Text & "", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.Yes Then
                Dim Cancelbk As String
                Dim chgstatus As String
                Cancelbk = "UPDATE booking SET bk_approval='3',bk_complete='1',bk_approva_text ='Cancel' WHERE bk_ID = '" & bk_ID_label.Text & "'"
                InsertRcd(Cancelbk)
                chgstatus = "UPDATE vehicle_status SET vhcstatus_status = '0' WHERE vhcstatus_bookingID = '" & bk_ID_label.Text & "'"
                InsertRcd(chgstatus)

                bk_ID_label.Text = ""
                DataGridView1.DataSource = Nothing
                CheckBox1.Checked = False
                If MainMDI.display_lvl.Text = 0 Or MainMDI.display_lvl.Text = 1 Then
                    BindGrid0()
                Else
                    BindGrid1()
                End If
                DataGridView1.CurrentCell = Nothing
                ButtonApprove.Visible = False
                ButtonDecline.Visible = False
                cancelbtn.Visible = False
                uButton2.Visible = False
            End If
        End If
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        bookingprint.GetbookingSlip(bk_ID_label.Text)
        bookingprint.MdiParent = MainMDI
        bookingprint.Show()
    End Sub

    Private Sub bk_vhccategory_TextChanged(sender As Object, e As EventArgs) Handles bk_vhccategory.TextChanged

        If bk_vhccategory.Text = "1" And (MainMDI.display_lvl.Text = "0" Or MainMDI.display_lvl.Text = "1") Then
            If LabelEmpID.Text = MainMDI.LabelEmpID.Text Then
                ButtonApprove.Visible = False
                ButtonDecline.Visible = False
            Else
                ButtonApprove.Visible = True
                ButtonDecline.Visible = True
            End If
        ElseIf bk_vhccategory.Text = "2" And (MainMDI.display_lvl.Text = "0" Or MainMDI.display_lvl.Text = "1") Then
            If LabelEmpID.Text = MainMDI.LabelEmpID.Text Then
                ButtonApprove.Visible = False
                ButtonDecline.Visible = False
            Else
                ButtonApprove.Visible = True
                ButtonDecline.Visible = True
            End If
        ElseIf bk_vhccategory.Text = "3" And (MainMDI.display_lvl.Text = "0" Or MainMDI.display_lvl.Text = "1") Then
            If LabelEmpID.Text = MainMDI.LabelEmpID.Text Then
                ButtonApprove.Visible = False
                ButtonDecline.Visible = False
            Else
                ButtonApprove.Visible = True
                ButtonDecline.Visible = True
            End If
        Else
            ButtonApprove.Visible = False
            ButtonDecline.Visible = False
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.DataSource = Nothing
        bk_ID_label.Text = Nothing

        If MainMDI.display_lvl.Text = "0" Or MainMDI.display_lvl.Text = "1" Then
            BindGridA()
        ElseIf MainMDI.display_lvl.Text = "2" Then
            BindGridB()
        End If
        DataGridView1.CurrentCell = Nothing
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        bk_start.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        bk_end.Text = DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub
End Class