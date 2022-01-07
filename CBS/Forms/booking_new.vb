Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net.Mail

Public Class booking_new
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim bk_vhcplateno As String
    Dim startdate As Date
    Dim enddate As Date
    Dim rtdate As Date
    Dim todaydate As Date
    Dim roadtaxdate As Date
    Dim timeexpired As String

    Private Sub booking_new_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        bookingID()

        TextBox2.Text = DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss")
        TextBox1.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
        nowDateTimePicker.Text = Date.Now.ToString("dd-MM-yyyy HH:mm")
        nowdate2.Text = nowDateTimePicker.Value.ToString("yyyy-MM-dd")

        Timer1.Start()

        DateTimePicker1.Text = Date.Now
        DateTimePicker2.Text = Date.Now.AddDays(1)

        bk_usr_ID.Text = MainMDI.usr_id_label.Text

        Button3.Visible = False
        Button4.Visible = False
        Button7.Visible = False
        vehicleGroupBox.Enabled = False
        Button5.Enabled = False

    End Sub

    Private Sub bk_usr_ID_TextChanged(sender As Object, e As EventArgs) Handles bk_usr_ID.TextChanged
        Dim finduser As String
        finduser = "SELECT * FROM users WHERE usr_ID = '" & bk_usr_ID.Text & "'"
        conn.Open()
        cmd = New MySqlCommand(finduser, conn)
        db = cmd.ExecuteReader()

        db.Read()
        bk_usr_fullname.Text = db.Item("usr_name")
        bk_usr_dept.Text = db.Item("usr_department")
        bk_usr_empID.Text = db.Item("usr_employeeID")
        usr_category.Text = db.Item("usr_category")
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bk_usr_fullname.Enabled = True
        bk_usr_fullname.ReadOnly = False
        bk_usr_dept.Enabled = True
        bk_usr_empID.ReadOnly = False
        bk_usr_fullname.Text = "That Person Name"
        bk_usr_empID.Text = ""
        bk_usr_dept.Text = Nothing
        'bk_usr_empID.Text = ""
        BookTimeGroupBox.Enabled = False
        vehicleGroupBox.Enabled = False
        Button3.Visible = True
        Button4.Visible = True
        Button2.Visible = False
        Button1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        bk_usr_fullname.Text = ""
        bk_usr_fullname.Enabled = False
        bk_usr_dept.Text = Nothing
        bk_usr_empID.Text = ""

        Dim finduser As String
        finduser = "SELECT * FROM users WHERE usr_ID = '" & bk_usr_ID.Text & "'"
        conn.Open()
        cmd = New MySqlCommand(finduser, conn)
        db = cmd.ExecuteReader()

        db.Read()
        bk_usr_fullname.Text = db.Item("usr_name")
        bk_usr_dept.Text = db.Item("usr_department")
        bk_usr_empID.Text = db.Item("usr_employeeID")
        usr_category.Text = db.Item("usr_category")
        conn.Close()

        bk_usr_fullname.ReadOnly = True
        bk_usr_dept.Enabled = False
        bk_usr_empID.ReadOnly = True

        Button3.Visible = False
        Button4.Visible = False
        Button2.Visible = True
        Button1.Visible = True

        BookTimeGroupBox.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bk_usr_fullname.ReadOnly = True
        bk_usr_dept.Enabled = True
        bk_usr_empID.ReadOnly = True

        Button3.Visible = False
        Button4.Visible = False
        Button2.Visible = True
        Button1.Visible = True

        BookTimeGroupBox.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        nowDateTimePicker.Text = Date.Now.ToString("dd-MM-yyyy HH:mm:ss")
        Timer1.Start()
    End Sub

    Public Sub showfreeVhcMgmt()
        Dim choosevhc As String
        choosevhc = "SELECT vhc_ID,vhc_PlateNo FROM vehicle WHERE NOT vhc_key_status = 'False' AND NOT vhc_type = 'Lorry' AND vhc_ID NOT IN (SELECT vhc_ID FROM vehicle LEFT OUTER JOIN vehicle_status ON ( vehicle.vhc_ID = vehicle_status.vhcstatus_vhcID ) LEFT OUTER JOIN vehicle_acce_info ON (vehicle.vhc_ID = vehicle_acce_info.vhcacc_vhcID) WHERE " _
        + " vhc_key_status = 'True' AND vhc_obsolete = '1' OR vhcacc_repairstatus = '1' OR (('" & TextBox1.Text & "' AND '" & TextBox2.Text & "' BETWEEN vhcstatus_start AND vhcstatus_end) OR (vhcstatus_start AND vhcstatus_end BETWEEN '" & TextBox1.Text & "' AND '" & TextBox2.Text & "')) AND vhcstatus_status = '1')"
        conn.Open()
        cmd = New MySqlCommand(choosevhc, conn)
        db = cmd.ExecuteReader
        Try
            While db.Read
                vhc_plate_list.Items.Add(db.Item("vhc_PlateNo"))
            End While
        Catch ex As Exception
            MsgBox("No Vehicle Available")
        End Try
        conn.Close()
    End Sub

    Public Sub showfreeVhcOffice()
        Dim choosevhc As String
        choosevhc = "SELECT vhc_ID,vhc_PlateNo FROM vehicle WHERE NOT vhc_key_status = 'False' AND NOT vhc_type = 'Lorry' AND vhc_ID NOT IN (SELECT vhc_ID FROM vehicle LEFT OUTER JOIN vehicle_status ON ( vehicle.vhc_ID = vehicle_status.vhcstatus_vhcID ) LEFT OUTER JOIN vehicle_acce_info ON (vehicle.vhc_ID = vehicle_acce_info.vhcacc_vhcID) WHERE " _
        + " (vhc_key_status = 'True' OR vhc_obsolete = '1' OR vhcacc_repairstatus = '1') OR (('" & TextBox1.Text & "' AND '" & TextBox2.Text & "' BETWEEN vhcstatus_start AND vhcstatus_end) OR (vhcstatus_start AND vhcstatus_end BETWEEN '" & TextBox1.Text & "' AND '" & TextBox2.Text & "')) AND vhcstatus_status = '1')"
        conn.Open()
        cmd = New MySqlCommand(choosevhc, conn)
        db = cmd.ExecuteReader
        Try
            While db.Read
                vhc_plate_list.Items.Add(db.Item("vhc_PlateNo"))
            End While
        Catch ex As Exception
            MsgBox("No Vehicle Available")
        End Try
        conn.Close()
    End Sub

    Public Sub showfreeVhcProd()
        Dim choosevhc As String
        choosevhc = "SELECT vhc_ID,vhc_PlateNo FROM vehicle WHERE NOT vhc_key_status = 'False' AND NOT vhc_type = 'Lorry' AND vhc_ID NOT IN (SELECT vhc_ID FROM vehicle LEFT OUTER JOIN vehicle_status ON ( vehicle.vhc_ID = vehicle_status.vhcstatus_vhcID ) LEFT OUTER JOIN vehicle_acce_info ON (vehicle.vhc_ID = vehicle_acce_info.vhcacc_vhcID) WHERE " _
        + "(vhc_category = '1' OR vhc_category = '2' OR vhc_obsolete = '1' OR vhcacc_repairstatus = '1') OR (('" & TextBox1.Text & "' AND '" & TextBox2.Text & "' BETWEEN vhcstatus_start AND vhcstatus_end) OR (vhcstatus_start AND vhcstatus_end BETWEEN '" & TextBox1.Text & "' AND '" & TextBox2.Text & "')) AND vhcstatus_status = '1')"
        conn.Open()
        cmd = New MySqlCommand(choosevhc, conn)
        db = cmd.ExecuteReader
        Try
            While db.Read
                vhc_plate_list.Items.Add(db.Item("vhc_PlateNo"))
            End While
        Catch ex As Exception
            MsgBox("No Vehicle Available")
        End Try
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vhc_plate_list.Items.Clear()

        If usr_category.Text = "1" Then
            showfreeVhcOffice()
            'Else
            '    If usr_category.Text = "2" Then
            '        showfreeVhcMgmt()
            '    Else
            '        If usr_category.Text = "3" Then
            '            showfreeVhcProd()
            '        End If
            '    End If
        End If

        Dim items(vhc_plate_list.Items.Count - 1) As Object
        vhc_plate_list.Items.CopyTo(items, 0)
        vhc_plate_list.Items.Clear()
        vhc_plate_list.Items.AddRange(items.AsEnumerable().Distinct().ToArray())

    End Sub

    Public Sub loadvhcList()
        Dim loadvhc As String
        loadvhc = "SELECT * FROM vehicle"
        conn.Open()
        cmd = New MySqlCommand(loadvhc, conn)
        db = cmd.ExecuteReader()
        Try
            While db.Read
                If vhc_plate_list.SelectedItem = db.Item("vhc_PlateNo") Then
                    bt_vhc_brand.Text = db.Item("vhc_brand")
                    bt_vhc_model.Text = db.Item("vhc_model")
                    bt_vhc_type.Text = db.Item("vhc_type")
                    bk_vhcIDno.Text = db.Item("vhc_ID")
                    vhc_category.Text = db.Item("vhc_category")
                    rtdate = db.Item("vhc_roadtax")

                    Dim img As Byte()
                    img = CType(db("vhc_img"), Byte())
                    Using ms As New MemoryStream(img)
                        If ms.Length = 0 Then
                            PBX1.Image = Nothing
                        Else
                            PBX1.Image = Image.FromStream(ms)
                        End If
                    End Using
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        conn.Close()
    End Sub

    Private Sub vhc_plate_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vhc_plate_list.SelectedIndexChanged
        loadvhcList()
        rtdatecheck.Text = rtdate.ToString("dd-MM-yyyy")
        Button5.Enabled = True
    End Sub

    Public Sub bookingID()

        conn.Open()
        Dim query As String
        Dim dt As New DataTable
        query = "SELECT bk_ID FROM booking ORDER BY bk_ID"
        cmd = New MySqlCommand(query, conn)
        db = cmd.ExecuteReader

        While db.Read

            bk_ID.Text = db.Item("bk_ID") + 1

        End While
        conn.Close()

    End Sub

    Private Sub bk_reason_TextChanged(sender As Object, e As EventArgs) Handles bk_reason.TextChanged
        If Not bk_loctogo.Text = "" Then
            vehicleGroupBox.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If vehicleGroupBox.Enabled = False Then
            Me.Close()
        Else
            If MsgBox("Your Record still not save, are your sure to exit?", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.Yes Then
                vehicleGroupBox.Enabled = False
                Me.Close()
            End If
        End If
    End Sub

    Private Sub booking_new_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If vehicleGroupBox.Enabled = False Then
            e.Cancel = False
        Else
            If MsgBox("Your Record still not save, are your sure to exit?", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        bk_vhcplateno = vhc_plate_list.SelectedItem.ToString
        startdate = DateTimePicker1.Value.ToString
        enddate = DateTimePicker2.Value.ToString

        If startdate > enddate Then
            MsgBox("Wrong date select, estimate return time should not early then booking time !")
        ElseIf enddate < Date.Today Then
            MsgBox("Please check your date, previous date selected!")
        Else
            If MsgBox("Are you confirm to booking " & bk_vhcplateno & "?", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.Yes Then
                nowToday.Text = nowDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")
                Dim savercd As String
                savercd = "INSERT INTO booking (bk_ID,bk_vhcID,bk_createbyID,bk_name,bk_empID,bk_dept,bk_dateBook,bk_vhccollect,bk_vhcreturn,bk_loctogo,bk_reason,bk_bdate,bk_approva_text)" _
                + "VALUES(@bk_ID,@bk_vhcID,@bk_createbyID,@bk_name,@bk_empID,@bk_dept,@bk_dateBook,@bk_vhccollect,@bk_vhcreturn,@bk_loctogo,@bk_reason,@bk_bdate,'Pending Approval')"

                cmd = New MySqlCommand(savercd, conn)

                cmd.Parameters.AddWithValue("@bk_ID", bk_ID.Text)
                cmd.Parameters.AddWithValue("@bk_vhcID", bk_vhcIDno.Text)
                cmd.Parameters.AddWithValue("@bk_createbyID", bk_usr_ID.Text)
                cmd.Parameters.AddWithValue("@bk_name", bk_usr_fullname.Text)
                cmd.Parameters.AddWithValue("@bk_empID", bk_usr_empID.Text)
                cmd.Parameters.AddWithValue("@bk_dept", bk_usr_dept.Text)
                cmd.Parameters.AddWithValue("@bk_dateBook", nowToday.Text)
                cmd.Parameters.AddWithValue("@bk_vhccollect", TextBox1.Text)
                cmd.Parameters.AddWithValue("@bk_vhcreturn", TextBox2.Text)
                cmd.Parameters.AddWithValue("@bk_loctogo", bk_loctogo.Text)
                cmd.Parameters.AddWithValue("@bk_reason", bk_reason.Text)
                cmd.Parameters.AddWithValue("@bk_bdate", nowdate2.Text)

                conn.Open()
                Dim RowEffected As Integer = cmd.ExecuteNonQuery()
                If (RowEffected > 0) Then
                    MsgBox("Your request have been process. Your booking number is " & bk_ID.Text & "")
                    BookTimeGroupBox.Enabled = False
                    vehicleGroupBox.Enabled = False
                    Button5.Visible = False
                    Button6.Visible = False
                    Button7.Visible = True
                    Button2.Enabled = False
                    conn.Close()

                    Dim addrcd As String
                    addrcd = "INSERT INTO vehicle_status(vhcstatus_vhcID,vhcstatus_bookingID,vhcstatus_start,vhcstatus_end,vhcstatus_status)VALUE('" & bk_vhcIDno.Text & "','" & bk_ID.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','1');"
                    InsertRcd(addrcd)

                    ' This line of code trigger send mail to admin and manager
                    'If vhc_category.Text = "1" Then
                    '    sendMailMgmt()
                    'Else
                    '    If vhc_category.Text = "1" Then
                    '        sendMailAdmin()
                    '    End If
                    'End If

                    Dim addpetrocard As String
                    addpetrocard = "INSERT INTO booking_card(bkc_bkid,bkc_vhcplate,bkc_bkctype)VALUE('" & bk_ID.Text & "','" & bk_vhcplateno & "','Petrol');"

                    If petrol_checkbox.Checked = True Then
                        InsertRcd(addpetrocard)
                    End If

                    Dim addtouchngo As String
                    addtouchngo = "INSERT INTO booking_card(bkc_bkid,bkc_vhcplate,bkc_bkctype)VALUE('" & bk_ID.Text & "','" & bk_vhcplateno & "','Touch & GO');"
                    If tngo_Checkbox.Checked = True Then
                        InsertRcd(addtouchngo)
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox1.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        TextBox2.Text = DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss")
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

    'Send email to personal who can approve the booking, admin and maneger 'Update the email address to use the function
    Public Sub sendMailMgmt()
        Dim List_emails As ArrayList = New ArrayList()
        Dim i As Integer = 0
        Dim email As String = Nothing
        Dim query As String
        query = "SELECT usr_email FROM users WHERE usr_level ='0' OR usr_level='2' ORDER BY usr_email DESC "
        conn.Open()
        cmd = New MySqlCommand(query, conn)
        db = cmd.ExecuteReader()

        While db.Read()
            email = db.GetValue(i).ToString
            List_emails.Add(email)
            i = i + 1 - 1
        End While
        db.Close()
        conn.Close()

        Try
            Dim sendto As String
            Dim smtpsvr As New SmtpClient()
            Dim mail As New MailMessage()

            For Each sendto In List_emails

                smtpsvr.Credentials = New _
                Net.NetworkCredential("edp@hartasel.com", "Hpi#123456")
                smtpsvr.Port = 587
                smtpsvr.Host = "outlook.office365.com"
                smtpsvr.EnableSsl = True
                mail = New MailMessage()
                mail.From = New MailAddress("webadmin@hartasel.com")
                mail.To.Add(sendto)
                mail.Subject = "New vehicle booking Awaiting Approval, booking No: " & bk_ID.Text & " ,vehicle Registration No: " & bk_vhcplateno & ""
                mail.Body = "Work Item in Vehicle Booking System (CBS)" & vbNewLine & "Please log on to CBS and approve new booking, No: " & bk_ID.Text & "."
                smtpsvr.Send(mail)
            Next
            MsgBox("Your booking request have been sent to all authorized persons to seek for approval.")
        Catch ex As Exception
            'MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub sendMailAdmin()
        Dim List_emails As ArrayList = New ArrayList()
        Dim i As Integer = 0
        Dim email As String = Nothing
        Dim query As String
        query = "SELECT usr_email FROM users WHERE usr_level ='0' OR usr_level='2' OR usr_level='5' ORDER BY usr_email DESC "
        conn.Open()
        cmd = New MySqlCommand(query, conn)
        db = cmd.ExecuteReader()

        While db.Read()
            email = db.GetValue(i).ToString
            List_emails.Add(email)
            i = i + 1 - 1
        End While
        db.Close()
        conn.Close()

        Try
            Dim sendto As String
            Dim smtpsvr As New SmtpClient()
            Dim mail As New MailMessage()

            For Each sendto In List_emails

                smtpsvr.Credentials = New _
                Net.NetworkCredential("edp@hartasel.com", "Hpi#123456")
                smtpsvr.Port = 587
                smtpsvr.Host = "outlook.office365.com"
                smtpsvr.EnableSsl = True
                mail = New MailMessage()
                mail.From = New MailAddress("webadmin@hartasel.com")
                mail.To.Add(sendto)
                mail.Subject = "New vehicle booking Awaiting Approval, booking No: " & bk_ID.Text & " ,vehicle Registration No: " & bk_vhcplateno & ""
                mail.Body = "Work Item in Vehicle Booking System (CBS)" & vbNewLine & "Please log on to CBS and approve new booking, No: " & bk_ID.Text & "."
                smtpsvr.Send(mail)
            Next
            MsgBox("Your booking request have been sent to all authorized persons to seek for approval.")
        Catch ex As Exception
            'MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub sendMailProd()
        Dim List_emails As ArrayList = New ArrayList()
        Dim i As Integer = 0
        Dim email As String = Nothing
        Dim query As String
        query = "SELECT usr_email FROM users WHERE usr_level ='0' OR usr_level='2' OR usr_level='6' ORDER BY usr_email DESC "
        conn.Open()
        cmd = New MySqlCommand(query, conn)
        db = cmd.ExecuteReader()

        While db.Read()
            email = db.GetValue(i).ToString
            List_emails.Add(email)
            i = i + 1 - 1
        End While
        db.Close()
        conn.Close()

        Try
            Dim sendto As String
            Dim smtpsvr As New SmtpClient()
            Dim mail As New MailMessage()

            For Each sendto In List_emails

                smtpsvr.Credentials = New _
                Net.NetworkCredential("edp@hartasel.com", "Hpi#123456")
                smtpsvr.Port = 587
                smtpsvr.Host = "outlook.office365.com"
                smtpsvr.EnableSsl = True
                mail = New MailMessage()
                mail.From = New MailAddress("webadmin@hartasel.com")
                mail.To.Add(sendto)
                mail.Subject = "New vehicle booking Awaiting Approval, booking No: " & bk_ID.Text & " ,vehicle Registration No: " & bk_vhcplateno & ""
                mail.Body = "Work Item in Vehicle Booking System (CBS)" & vbNewLine & "Please log on to CBS and approve new booking, No: " & bk_ID.Text & "."
                smtpsvr.Send(mail)
            Next
            MsgBox("Your booking request have been sent to all authorized persons to seek for approval.")
        Catch ex As Exception
            'MsgBox(ex.ToString)

        End Try
    End Sub
    '-----------------------------------------------------------------------------------------------------
    Private Sub rtdatecheck_TextChanged(sender As Object, e As EventArgs) Handles rtdatecheck.TextChanged
        todaydate = Date.Now.ToString("dd-MM-yyyy")
        roadtaxdate = rtdatecheck.Text

        timeexpired = DateDiff(DateInterval.Day, todaydate, roadtaxdate)

        If timeexpired < 1 Then
            Label14.Text = "Found Road Tax expired, please verified with Admin Departments."
            Button5.Visible = False
        Else
            Label14.Text = Nothing
            Button5.Visible = True
        End If

    End Sub

    Private Sub Bk_usr_fullname_TextChanged(sender As Object, e As EventArgs) Handles bk_usr_fullname.Click

        bk_usr_fullname.Text = ""
    End Sub
End Class

