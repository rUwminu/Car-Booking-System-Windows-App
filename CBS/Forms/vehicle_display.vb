Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class vehicle_display
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True;Convert Zero Datetime=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim vhcobs As String
    Dim picpath As String
    Dim todaydate As Date
    Dim roadtxdate As Date
    Dim timeexpired As String
    Dim instimeexpired As String
    Dim vsstatus As String
    Dim wrtymonth As Integer
    Dim insurancedate As Date

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "Yes"
            vhcobs = 1
            vobsolete.Text = vhcobs
            vsstatus = 2
        Else
            CheckBox1.Text = "No"
            vhcobs = 0
            vobsolete.Text = vhcobs
            vsstatus = 0
        End If
    End Sub

    Private Sub vhc_display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CBSDataSet.vehicle' table. You can move, or remove it, as needed.

        'Using cnn As MySqlConnection = New MySqlConnection(ServerString)
        '    Me.VehicleTableAdapter.Fill(Me.CBSDataSet.vehicle)
        'End Using
        Try
            Me.VehicleTableAdapter.Fill(Me.CBSDataSet.vehicle)
            conn.ConnectionString = ServerString

            If CheckBox1.Checked = True Then
                CheckBox1.Text = "Yes"
                vhcobs = 1
                vobsolete.Text = vhcobs
                vsstatus = 2
            Else
                CheckBox1.Text = "No"
                vhcobs = 0
                vobsolete.Text = vhcobs
                vsstatus = 0
            End If

            GroupBox1.Enabled = False
            chgpix.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            vrrdate.Text = Vhc_roadtaxDateTimePicker.Value.ToString("yyyy-MM-dd")
            VehicleBindingNavigatorSaveItem.Enabled = False
            SplitContainer1.Panel2Collapsed = True
            categoryComboBox.Visible = False
            'BindGridVehicle()

            If Vhc_categoryTextBox.Text = "1" Then
                categoryComboBox.Text = "Admin"
                vhc_cattext.Text = "Admin"
            Else
                If Vhc_categoryTextBox.Text = "2" Then
                    categoryComboBox.Text = "Management"
                    vhc_cattext.Text = "Management"
                Else
                    If Vhc_categoryTextBox.Text = "3" Then
                        categoryComboBox.Text = "Production"
                        vhc_cattext.Text = "Production"
                    End If
                End If
            End If
        Catch ex As Exception
            'MsgBox("Please Update This Vehicle Detail")
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            TabControl1.SelectedTab = TabPage1
            Vhc_IDTextBox.Text = row.Cells("vhc_ID").Value.ToString
        End If
    End Sub

    Private Sub Vhc_IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles Vhc_IDTextBox.TextChanged

        conn.Close()
        conn.Dispose()

        Try
            conn.ConnectionString = ServerString

            Dim query2 As String
            Dim lastoilchg As Date
            Dim fltyredate As Date
            Dim rltyredate As Date
            Dim frtyredate As Date
            Dim rrtyredate As Date

            Dim rlityredate As Date
            Dim rrityredate As Date
            Dim btychange As Date
            Dim insurancedate As Date
            query2 = "SELECT * FROM vehicle LEFT OUTER JOIN vehicle_acce_info ON (vhc_ID = vhcacc_vhcID) WHERE vhc_ID = '" & Vhc_IDTextBox.Text & "'"

            conn.Open()
            cmd = New MySqlCommand(query2, conn)
            db = cmd.ExecuteReader()
            While db.Read()
                insurancedate = db.Item("vhc_insurance")

                vhc_CurrMeter.Text = db.Item("vhcacc_crmeter").ToString
                lastoilchg = db.Item("vhcacc_eng_datechg")
                'Meter Here-------------------------------------------------------------
                vhc_ChgMeter.Text = db.Item("vhcacc_eng_oilmeter").ToString
                vhc_CurrMeter.Text = db.Item("vhcacc_crmeter").ToString
                '-----------------------------------------------------------------------
                fltype.Text = db.Item("vhcacc_tyre_fltype").ToString
                rltype.Text = db.Item("vhcacc_tyre_rltype").ToString
                frtype.Text = db.Item("vhcacc_tyre_frtype").ToString
                rrtype.Text = db.Item("vhcacc_tyre_rrtype").ToString
                rlitype.Text = db.Item("vhcacc_tyre_rlitype").ToString
                rritype.Text = db.Item("vhcacc_tyre_rritype").ToString
                fltyredate = db.Item("vhcacc_tyre_fldate")
                rltyredate = db.Item("vhcacc_tyre_rldate")
                frtyredate = db.Item("vhcacc_tyre_frdate")
                rrtyredate = db.Item("vhcacc_tyre_rrdate")
                rlityredate = db.Item("vhcacc_tyre_rlidate")
                rrityredate = db.Item("vhcacc_tyre_rridate")
                btychange = db.Item("vhcacc_btydate")
                btywarranty.Text = db.Item("vhcacc_btywrty").ToString
                wrtymonth = db.Item("vhcacc_btywrty").ToString

                Dim img As Byte()
                img = CType(db("vhc_img"), Byte())
                Using ms As New MemoryStream(img)
                    If ms.Length = 0 Then
                        LBP1.Image = Nothing
                    Else
                        LBP1.Image = Image.FromStream(ms)
                    End If
                End Using

            End While
            conn.Close()
            conn.Dispose()

            'Dim LeftMeter
            'Dim a = vhc_ChgMeter.Text
            'Dim b = vhc_CurrMeter.Text

            'If a = "" Then
            '    a = 0
            'Else
            '    a = Double.Parse(vhc_ChgMeter.Text)
            'End If

            'If b = "" Then
            '    b = 0
            'Else
            '    b = Double.Parse(vhc_CurrMeter.Text)
            'End If

            'LeftMeter = Double.Parse(a) - Double.Parse(b)

            'If (LeftMeter <= 0) Then
            '    MeterLeftLabel.Text = "Service Meter Reached..."
            '    MeterLeftLabel.ForeColor = Color.Red
            'Else
            '    MeterLeftLabel.Text = LeftMeter.ToString()
            'End If

            '----------------------------------------------------------------------
            If lastoilchg.ToString = "0000-00-00" Then
                oilchangedate.Text = ""
            Else
                oilchangedate.Text = lastoilchg.ToString("yyyy-MM-dd")
            End If

            If fltyredate.ToString = "0000-00-00" Then
                fltyredatetext.Text = ""
            Else
                fltyredatetext.Text = fltyredate.ToString("yyyy-MM-dd")
            End If

            If rltyredate.ToString = "0000-00-00" Then
                rltyredatetext.Text = ""
            Else
                rltyredatetext.Text = rltyredate.ToString("yyyy-MM-dd")
            End If

            If frtyredate.ToString = "0000-00-00" Then
                frtyredatetext.Text = ""
            Else
                frtyredatetext.Text = frtyredate.ToString("yyyy-MM-dd")
            End If

            If rrtyredate.ToString = "0000-00-00" Then
                rrtyredatetext.Text = ""
            Else
                rrtyredatetext.Text = rrtyredate.ToString("yyyy-MM-dd")
            End If

            If rrityredate.ToString = "0000-00-00" Then
                rrityredatetext.Text = ""
            Else
                rrityredatetext.Text = rrityredate.ToString("yyyy-MM-dd")
            End If

            If rlityredate.ToString = "0000-00-00" Then
                rlityredatetext.Text = ""
            Else
                rlityredatetext.Text = rlityredate.ToString("yyyy-MM-dd")
            End If

            If btychange.ToString = "0000-00-00" Then
                btychgdate.Text = ""
            Else
                btychgdate.Text = btychange.ToString("yyyy-MM-dd")
            End If

            If insurancedate.ToString = "0000-00-00" Then
                TextBoxIns.Text = ""
            Else
                TextBoxIns.Text = insurancedate.ToString("yyyy-MM-dd")
            End If

            DataGridView2.DataSource = Nothing
            BindGridRepairStatus()

            Dim warrantydate As Date
            Dim todaydate As Date

            If btychgdate.Text = "" Then
                batterydate.Value = todaydate.AddDays(1)
            Else
                batterydate.Value = btychgdate.Text
            End If

            warrantydate = batterydate.Value.AddMonths(wrtymonth)
            todaydate = Date.Today.ToShortDateString

            If btywarranty.Text = 0 Then
                btyexp.Visible = False
            Else
                If warrantydate > todaydate Then
                    btyexp.Visible = False
                Else
                    btyexp.Visible = True
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Enabled = True
        TabControl1.TabPages(1).Enabled = False
        chgpix.Visible = True
        Button1.Visible = False
        Button3.Visible = True
        Button4.Visible = True
        Button8.Visible = True
        VehicleBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorMoveFirstItem.Enabled = False
        BindingNavigatorMoveLastItem.Enabled = False
        BindingNavigatorMoveNextItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
        vhc_cattext.Visible = False
        categoryComboBox.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fs As FileStream
        Dim br As BinaryReader

        If Vhc_brandTextBox.Text = "" Or Vhc_modelTextBox.Text = "" Or Vhc_typeTextBox.Text = "" Or Vhc_roadtaxDateTimePicker.Value = Nothing Then
            MsgBox("Field cannot be blank. Please complete all required fields. (*)")
        Else
            If picloc.Text.Length = 0 Then
                Dim savercd As String
                savercd = "UPDATE vehicle SET " _
            + "vhc_PlateNo=@vhc_PlateNo," _
            + "vhc_brand=@vhc_brand," _
            + "vhc_model=@vhc_model," _
            + "vhc_type=@vhc_type," _
            + "vhc_year=@vhc_year," _
            + "vhc_note=@vhc_note," _
            + "vhc_category=@vhc_category," _
            + "vhc_obsolete=@vhc_obsolete WHERE vhc_ID = '" & Vhc_IDTextBox.Text & "'"

                Try
                    cmd = New MySqlCommand(savercd, conn)
                    cmd.Parameters.AddWithValue("@vhc_plateNo", Vhc_PlateNoTextBox.Text)
                    cmd.Parameters.AddWithValue("@vhc_brand", Vhc_brandTextBox.Text)
                    cmd.Parameters.AddWithValue("@vhc_model", Vhc_modelTextBox.Text)
                    cmd.Parameters.AddWithValue("@vhc_type", Vhc_typeTextBox.Text)
                    cmd.Parameters.AddWithValue("@vhc_year", Vhc_yearTextBox.Text)
                    cmd.Parameters.AddWithValue("@vhc_note", Vhc_noteTextBox.Text)
                    cmd.Parameters.AddWithValue("@vhc_obsolete", vobsolete.Text)
                    cmd.Parameters.AddWithValue("@vhc_category", Vhc_categoryTextBox.Text)

                    conn.Open()
                    Dim RowEffected As Integer = cmd.ExecuteNonQuery()
                    If (RowEffected > 0) Then
                        MsgBox("Record save sucessfully.")
                        conn.Close()
                        Dim vhcstatus As String
                        vhcstatus = "UPDATE vehicle_status SET vhcstatus_status = '" & vsstatus & "' WHERE vhcstatus_vhcID = '" & Vhc_IDTextBox.Text & "'"
                        InsertRcd(vhcstatus)
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString())
                Finally
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            Else
                Dim savercd2 As String
                savercd2 = "UPDATE vehicle SET " _
            + "vhc_PlateNo=@vhc_PlateNo," _
            + "vhc_brand=@vhc_brand," _
            + "vhc_model=@vhc_model," _
            + "vhc_type=@vhc_type," _
            + "vhc_img=@vhc_img," _
            + "vhc_year=@vhc_year," _
            + "vhc_note=@vhc_note," _
            + "vhc_category=@vhc_category," _
            + "vhc_obsolete=@vhc_obsolete WHERE vhc_ID = '" & Vhc_IDTextBox.Text & "'"
                Dim FileName As String = picloc.Text
                Dim imgdata() As Byte

                fs = New FileStream(FileName, FileMode.Open, FileAccess.Read)
                br = New BinaryReader(fs)
                imgdata = br.ReadBytes(CType(fs.Length, Integer))
                br.Close()
                fs.Close()

                Try
                    cmd = New MySqlCommand(savercd2, conn)
                    cmd.Parameters.AddWithValue("@vhc_plateNo", Vhc_PlateNoTextBox.Text)
                    cmd.Parameters.AddWithValue("@vhc_brand", Vhc_brandTextBox.Text)
                    cmd.Parameters.AddWithValue("@vhc_model", Vhc_modelTextBox.Text)
                    cmd.Parameters.AddWithValue("@vhc_type", Vhc_typeTextBox.Text)
                    cmd.Parameters.AddWithValue("@vhc_img", imgdata)
                    cmd.Parameters.AddWithValue("@vhc_year", Vhc_yearTextBox.Text)
                    cmd.Parameters.AddWithValue("@vhc_note", Vhc_noteTextBox.Text)
                    cmd.Parameters.AddWithValue("@vhc_obsolete", vobsolete.Text)
                    cmd.Parameters.AddWithValue("@vhc_category", Vhc_categoryTextBox.Text)

                    conn.Open()
                    Dim RowEffected As Integer = cmd.ExecuteNonQuery()
                    If (RowEffected > 0) Then
                        MsgBox("Record save sucessfully.")
                        conn.Close()
                        Dim vhcstatus As String
                        vhcstatus = "UPDATE vehicle_status SET vhcstatus_status = '" & vsstatus & "' WHERE vhcstatus_vhcID = '" & Vhc_IDTextBox.Text & "'"
                        InsertRcd(vhcstatus)
                    End If

                Catch ex As Exception
                    MsgBox(ex.ToString())
                Finally
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End If
            VehicleBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorMoveFirstItem.Enabled = True
            BindingNavigatorMoveLastItem.Enabled = True
            BindingNavigatorMoveNextItem.Enabled = True
            BindingNavigatorMovePreviousItem.Enabled = True
            GroupBox1.Enabled = False
            TabControl1.TabPages(1).Enabled = True
            chgpix.Visible = False
            Button3.Visible = False
            Button1.Visible = True
            Button8.Visible = False
            picloc.Text = ""
            vhc_cattext.Visible = True
            categoryComboBox.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If GroupBox1.Enabled = False Then
            Me.Close()
        Else
            If MsgBox("Your Record still not save, are your sure to exit?", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.Yes Then
                GroupBox1.Enabled = False
                Me.Close()
            End If
        End If
    End Sub

    Private Sub vhc_display_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If GroupBox1.Enabled = False Then
            e.Cancel = False
        Else
            If MsgBox("Your Record still not save, are your sure to exit?", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Vhc_roadtaxDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Vhc_roadtaxDateTimePicker.ValueChanged
        vrrdate.Text = Vhc_roadtaxDateTimePicker.Value.ToString("yyyy-MM-dd")
        insurancedate = TextBoxIns.Text

        ToolsDate.Text = Date.Now.ToShortDateString
        todaydate = ToolsDate.Text
        roadtxdate = Vhc_roadtaxDateTimePicker.Value.ToShortDateString

        instimeexpired = DateDiff(DateInterval.Day, todaydate, insurancedate)
        timeexpired = DateDiff(DateInterval.Day, todaydate, roadtxdate)

        If timeexpired < 30 Then
            Label5.Text = "Road Tax expired in " & timeexpired & " Day(s)."
        ElseIf instimeexpired < 30 And instimeexpired < 0 Then
            Label5.Text = "Insurance expired Renew If Needed Or Not Inserted"
        ElseIf instimeexpired < 30 Then
            Label5.Text = "Insurance expired in " & instimeexpired & " Day(s)."
        Else
            Label5.Text = Nothing
        End If
    End Sub

    Private Sub chgpix_Click(sender As Object, e As EventArgs) Handles chgpix.Click
        OFD1.InitialDirectory = "c:\"
        OFD1.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png"
        OFD1.ShowDialog()
        picpath = OFD1.FileName
        picloc.Text = picpath
        LBP1.ImageLocation = picpath
        Button7.Visible = True
        Button3.Enabled = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim vhcroadtax As New Vehicle_RoadTax
        vhcroadtax.MdiParent = MainMDI
        vhcroadtax.Show()
        vhcroadtax.vhc_IDtextbox.Text = Vhc_IDTextBox.Text
        vhcroadtax.vhc_platetext.Text = Vhc_PlateNoTextBox.Text
        vhcroadtax.vhc_rt_date.Text = Vhc_roadtaxDateTimePicker.Value.ToShortDateString
    End Sub

    Private Sub VehicleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VehicleBindingNavigatorSaveItem.Click
        Me.Button3.PerformClick()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Controls.Clear()
        InitializeComponent()
        vhc_display_Load(e, e)
        'DataGridView1.DataSource = Nothing
        'BindGridVehicle()
        DataGridView2.DataSource = Nothing
        BindGridRepairStatus()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LBP1.Image = Nothing
        picloc.Text = ""
        Button3.Enabled = False
        Button7.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SplitContainer1.Panel2Collapsed = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub oilButton_Click(sender As Object, e As EventArgs) Handles oilButton.Click
        Dim engineoil As New vehicle_engineOil
        engineoil.MdiParent = MainMDI
        engineoil.Show()
        engineoil.vhcoil_vhcplateno.Text = Vhc_PlateNoTextBox.Text
        engineoil.vhcinfo_oilmeter.Text = vhc_CurrMeter.Text
        engineoil.engoil_vhcID.Text = Vhc_IDTextBox.Text
    End Sub

    Private Sub engoilshi_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles engoilshi.LinkClicked
        Dim engoilhistory As New vehicle_engOil_History
        engoilhistory.MdiParent = MainMDI
        engoilhistory.Show()
        engoilhistory.vhcoil_vhcplateno.Text = Vhc_PlateNoTextBox.Text
        engoilhistory.engoil_vhcID.Text = Vhc_IDTextBox.Text
    End Sub

    Private Sub tyreButton_Click(sender As Object, e As EventArgs) Handles tyreButton.Click
        Dim showtyre As New vehicle_tyre
        showtyre.MdiParent = MainMDI
        showtyre.Show()

        showtyre.vhctyre_vhcplate.Text = Vhc_PlateNoTextBox.Text
        showtyre.tyre_vhcID.Text = Vhc_IDTextBox.Text

    End Sub

    Private Sub TyreHistory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TyreHistory.LinkClicked
        Dim tyrehistory As New vehicle_tyreHistory
        tyrehistory.MdiParent = MainMDI
        tyrehistory.Show()
        tyrehistory.tyreh_vhcPlate.Text = Vhc_PlateNoTextBox.Text
        tyrehistory.tyre_vhcID.Text = Vhc_IDTextBox.Text
    End Sub

    Private Sub btywarranty_TextChanged(sender As Object, e As EventArgs) Handles btywarranty.TextChanged
        Dim warrantydate As Date
        Dim todaydate As Date


        If btychgdate.Text = "" Then
            batterydate.Value = Date.Today.AddDays(1)
        Else
            batterydate.Value = btychgdate.Text
        End If

        warrantydate = batterydate.Value.AddMonths(wrtymonth)
        todaydate = Date.Today.ToShortDateString

        If btywarranty.Text = "" Then
            btyexp.Visible = False
        Else
            If btywarranty.Text = 0 Then
                btyexp.Visible = True
            Else
                If warrantydate > todaydate Then
                    btyexp.Visible = False
                Else
                    btyexp.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub BtyHistory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BtyHistory.LinkClicked
        Dim btyhistory As New vehicle_bty_history
        btyhistory.MdiParent = MainMDI
        btyhistory.Show()
        btyhistory.btyh_vhcPlate.Text = Vhc_PlateNoTextBox.Text
        btyhistory.btyh_vhcID.Text = Vhc_IDTextBox.Text
    End Sub

    Public Sub BindGridRepairStatus()
        Dim query1 As String
        query1 = " Select vhcrp_date,vhcrp_faultpart01,vhcrp_remark,vhcrp_status,vhcrp_IsUpdate,vhcrp_ID from vehicle_repair_status WHERE vhcrp_vhcID = '" & Vhc_IDTextBox.Text & "' ORDER BY vhcrp_date DESC LIMIT 3 "
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query1, conn)
                cmd.CommandType = CommandType.Text
                Using rps As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        rps.Fill(dt)
                        DataGridView2.AutoGenerateColumns = True
                        DataGridView2.ColumnCount = 6
                        DataGridView2.ReadOnly = True

                        DataGridView2.Columns(0).Name = "vhcrp_date"
                        DataGridView2.Columns(0).HeaderText = "Date"
                        DataGridView2.Columns(0).DataPropertyName = "vhcrp_date"
                        DataGridView2.Columns(0).ReadOnly = True
                        DataGridView2.Columns(0).Resizable = False

                        DataGridView2.Columns(1).Name = "vhcrp_faultpart01"
                        DataGridView2.Columns(1).HeaderText = "Faulty Part"
                        DataGridView2.Columns(1).DataPropertyName = "vhcrp_faultpart01"
                        DataGridView2.Columns(1).ReadOnly = True
                        DataGridView2.Columns(1).Resizable = False

                        DataGridView2.Columns(2).Name = "vhcrp_remark"
                        DataGridView2.Columns(2).HeaderText = "Faulty Part"
                        DataGridView2.Columns(2).DataPropertyName = "vhcrp_remark"
                        DataGridView2.Columns(2).ReadOnly = True
                        DataGridView2.Columns(2).Resizable = False

                        DataGridView2.Columns(3).Name = "vhcrp_status"
                        DataGridView2.Columns(3).HeaderText = "Status"
                        DataGridView2.Columns(3).DataPropertyName = "vhcrp_status"
                        DataGridView2.Columns(3).ReadOnly = True
                        DataGridView2.Columns(3).Resizable = False

                        DataGridView2.Columns(4).Name = "vhcrp_IsUpdate"
                        DataGridView2.Columns(4).HeaderText = "Update"
                        DataGridView2.Columns(4).DataPropertyName = "vhcrp_IsUpdate"
                        DataGridView2.Columns(4).ReadOnly = True
                        DataGridView2.Columns(4).Resizable = False
                        DataGridView2.Columns(4).Visible = False

                        DataGridView2.Columns(5).Name = "vhcrp_ID"
                        DataGridView2.Columns(5).HeaderText = "ID"
                        DataGridView2.Columns(5).DataPropertyName = "vhcrp_ID"
                        DataGridView2.Columns(5).ReadOnly = True
                        DataGridView2.Columns(5).Resizable = False
                        DataGridView2.Columns(5).Visible = False
                        DataGridView2.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub DataGridView2_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDoubleClick
        Dim checkrepairdone As String
        Dim donerepair As New vehicle_RepairDone
        donerepair.MdiParent = MainMDI

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView2.Rows(e.RowIndex)
            vhcrpID.Text = row.Cells("vhcrp_ID").Value.ToString
            checkrepairdone = row.Cells("vhcrp_IsUpdate").Value.ToString

            If checkrepairdone = 1 Then
                MsgBox("Record have been update.")
            Else
                donerepair.Show()
                donerepair.vhcrpID.Text = vhcrpID.Text
                donerepair.vhcrp_plateno.Text = Vhc_PlateNoTextBox.Text
                donerepair.rp_vhcID.Text = Vhc_IDTextBox.Text
            End If

        End If
    End Sub

    Private Sub statushistory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles statushistory.LinkClicked
        Dim repairhistory As New vehicle_repair_History
        repairhistory.MdiParent = MainMDI
        repairhistory.Show()
        repairhistory.vhcrph_vhcplate.Text = Vhc_PlateNoTextBox.Text
        repairhistory.repairh_vhcID.Text = Vhc_IDTextBox.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Not picloc.Text = "" Then
            Button7.Visible = False
            Button3.Enabled = True
        Else
            Dim updpicture As String
            updpicture = "UPDATE vehicle SET vhc_img = '' WHERE vhc_ID = '" & Vhc_IDTextBox.Text & "'"
            InsertRcd(updpicture)
            Button3.Enabled = True
            Button7.Visible = False
        End If
    End Sub

    Public Sub BindGridVehicle()
        Dim query As String
        query = "Select vhc_PlateNo,vhc_brand,vhc_model,vhc_type,vhc_ID from vehicle"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.ColumnCount = 5
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "vhc_PlateNo"
                        DataGridView1.Columns(0).HeaderText = "Registration No"
                        DataGridView1.Columns(0).DataPropertyName = "vhc_PlateNo"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "vhc_brand"
                        DataGridView1.Columns(1).HeaderText = "Brand"
                        DataGridView1.Columns(1).DataPropertyName = "hc_brand"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "vhc_model"
                        DataGridView1.Columns(2).HeaderText = "Model"
                        DataGridView1.Columns(2).DataPropertyName = "vhc_model"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "vhc_type"
                        DataGridView1.Columns(3).HeaderText = "Type"
                        DataGridView1.Columns(3).DataPropertyName = "vhc_type"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False

                        DataGridView1.Columns(4).Name = "vhc_ID"
                        DataGridView1.Columns(4).HeaderText = "vhc_ID"
                        DataGridView1.Columns(4).DataPropertyName = "vhc_ID"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False
                        DataGridView1.Columns(4).Visible = False

                        DataGridView2.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button3.Visible = False
        Button1.Visible = True
        Button8.Visible = False
        GroupBox1.Enabled = False
        TabControl1.TabPages(1).Enabled = True
        categoryComboBox.Visible = False
        vhc_cattext.Visible = True

        Me.Controls.Clear()
        InitializeComponent()
        vhc_display_Load(e, e)
        DataGridView2.DataSource = Nothing
        BindGridRepairStatus()
    End Sub

    Private Sub categoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles categoryComboBox.SelectedIndexChanged
        If categoryComboBox.Text = "Admin" Then
            Vhc_categoryTextBox.Text = "1"
        Else
            If categoryComboBox.Text = "Management" Then
                Vhc_categoryTextBox.Text = "2"
            Else
                If categoryComboBox.Text = "Production" Then
                    Vhc_categoryTextBox.Text = "3"
                End If
            End If
        End If
    End Sub

    Private Sub Vhc_categoryTextBox_TextChanged(sender As Object, e As EventArgs) Handles Vhc_categoryTextBox.TextChanged
        If Vhc_categoryTextBox.Text = "1" Then
            categoryComboBox.Text = "Admin"
            vhc_cattext.Text = "Admin"
        Else
            If Vhc_categoryTextBox.Text = "2" Then
                categoryComboBox.Text = "Management"
                vhc_cattext.Text = "Management"
            Else
                If Vhc_categoryTextBox.Text = "3" Then
                    categoryComboBox.Text = "Production"
                    vhc_cattext.Text = "Production"
                End If
            End If
        End If
    End Sub

    Private Sub BtyButton_Click(sender As Object, e As EventArgs) Handles btyButton.Click
        Dim vhcbattery As New vehicle_battery
        vhcbattery.MdiParent = MainMDI
        vhcbattery.Show()
        vhcbattery.bty_vhcPlate.Text = Vhc_PlateNoTextBox.Text
        vhcbattery.bty_vhcID.Text = Vhc_IDTextBox.Text
    End Sub

    Private Sub StatusButton_Click(sender As Object, e As EventArgs) Handles statusButton.Click
        Dim vhcrepair As New Vehicle_repair
        vhcrepair.MdiParent = MainMDI
        vhcrepair.Show()
        vhcrepair.vhcrp_vhcPlate.Text = Vhc_PlateNoTextBox.Text
        vhcrepair.repair_vhcID.Text = Vhc_IDTextBox.Text
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim vhcinsurance As New Vehicle_Insurance
        vhcinsurance.MdiParent = MainMDI
        vhcinsurance.Show()
        vhcinsurance.vhc_IDtextbox.Text = Vhc_IDTextBox.Text
        vhcinsurance.vhc_platetext.Text = Vhc_PlateNoTextBox.Text
        vhcinsurance.vhc_rt_date.Text = TextBoxIns.Text
    End Sub

    Private Sub vhc_ChgMeter_TextChanged(sender As Object, e As EventArgs) Handles vhc_ChgMeter.TextChanged
        Dim LeftMeter
        Dim a = vhc_ChgMeter.Text
        Dim b = vhc_CurrMeter.Text

        If a = "" Then
            a = 0
        Else
            a = Double.Parse(vhc_ChgMeter.Text)
        End If

        If b = "" Then
            b = 0
        Else
            b = Double.Parse(vhc_CurrMeter.Text)
        End If

        LeftMeter = Double.Parse(a) - Double.Parse(b)

        If (LeftMeter <= 0) Then
            MeterLeftLabel.Text = "Service Meter Reached..."
            MeterLeftLabel.ForeColor = Color.Red
        Else
            MeterLeftLabel.Text = LeftMeter.ToString()
        End If
    End Sub
End Class