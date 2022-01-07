Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class key_status_view
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub Key_status_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.VehicleTableAdapter.Fill(Me.CBSDataSet.vehicle)
        conn.ConnectionString = ServerString

        If MainMDI.display_lvl.Text = "0" Or MainMDI.display_lvl.Text = "2" Or MainMDI.display_lvl.Text = "5" Or MainMDI.display_lvl.Text = "6" Then
            BindGrid0()
        End If

        Label1.Visible = False
        Label2.Visible = False
        TextBoxName.Visible = False
        ComboBox1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Label3.Visible = True

        Dim getID As String
        getID = "SELECT usr_employeeID FROM users"
        conn.Open()
        cmd = New MySqlCommand(getID, conn)
        db = cmd.ExecuteReader()
        While db.Read()
            ComboBox1.Items.Add(db.Item("usr_employeeID"))
        End While
        conn.Close()
    End Sub

    Public Sub BindGrid0()
        Dim query As String
        'query = "SELECT * FROM vehicle"
        query = "SELECT vehicle.vhc_PlateNo, vehicle.vhc_brand, vehicle.vhc_model, vehicle.vhc_key_status FROM vehicle INNER JOIN vehicle_acce_info ON vehicle_acce_info.vhcacc_vhcID = vehicle.vhc_ID WHERE vehicle_acce_info.vhcacc_repairstatus = '0' "
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
                        DataGridView1.Columns(0).HeaderText = "Plate No"
                        DataGridView1.Columns(0).DataPropertyName = "vhc_PlateNo"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "vhc_brand"
                        DataGridView1.Columns(1).HeaderText = "Brand"
                        DataGridView1.Columns(1).DataPropertyName = "vhc_brand"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "vhc_model"
                        DataGridView1.Columns(2).HeaderText = "Model"
                        DataGridView1.Columns(2).DataPropertyName = "vhc_model"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Width = "100"
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "vhc_key_status"
                        DataGridView1.Columns(3).HeaderText = "Key Status"
                        DataGridView1.Columns(3).DataPropertyName = "vhc_key_status"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub updateBookingRcd(ByRef SQLStatement As String)
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

    Private Sub PlateNoLabel1_TextChanged(sender As Object, e As EventArgs) Handles PlateNoLabel1.TextChanged
        '' Get plate num from data grid and get the key status and assign to label
        'conn.ConnectionString = ServerString

        'If PlateNoLabel1.Text = Nothing Then

        '    Dim a As Control
        '    For Each a In Me.Controls
        '        If TypeOf a Is TextBox Then
        '            a.Text = Nothing
        '        End If
        '    Next

        'Else
        '    Dim query As String
        '    query = "SELECT * FROM vehicle WHERE vhc_PlateNo = '" & PlateNoLabel1.Text & "'"

        '    conn.Open()
        '    cmd = New MySqlCommand(query, conn)
        '    db = cmd.ExecuteReader()

        '    If (db.Read()) Then
        '        ChgStatusLabel.Text = db("vhc_key_status").ToString()
        '    End If
        'End If

        'conn.Close()

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
        Dim keystatus As String

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            PlateNoLabel1.Text = row.Cells("vhc_PlateNo").Value.ToString
            ChgStatusLabel.Text = row.Cells("vhc_key_status").Value.ToString
            keystatus = row.Cells("vhc_key_status").Value.ToString

            If keystatus = "True" Then
                Button1.Visible = True
                Button2.Visible = False
                Label1.Visible = True
                Label2.Visible = True
                TextBoxName.Visible = True
                ComboBox1.Visible = True
                Label3.Visible = False
            Else
                Button1.Visible = False
                Button2.Visible = True
                Label1.Visible = False
                Label2.Visible = False
                TextBoxName.Visible = False
                ComboBox1.Visible = False
                Label3.Visible = False
            End If

            LabelDate.Text = DateTime.Now.ToString()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Confirm take key?" + vbCrLf + "Plate No : " & PlateNoLabel1.Text & "", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.Yes Then
            Dim yesappr As String
            Dim savecd As String

            If TextBoxName.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Please Insert All Needed Field")
            Else
                yesappr = "UPDATE vehicle SET vhc_key_status = 'False' WHERE vhc_PlateNo = '" & PlateNoLabel1.Text & "'"
                InsertRcd(yesappr)

                conn.Open()
                savecd = "INSERT INTO key_take_record (employee_name, employee_id, date_take, Plate_No) VALUES (@employee_name, @employee_id, @date_take, @Plate_No)"
                cmd = New MySqlCommand(savecd, conn)

                cmd.Parameters.AddWithValue("@employee_name", TextBoxName.Text)
                cmd.Parameters.AddWithValue("@employee_id", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@date_take", LabelDate.Text)
                cmd.Parameters.AddWithValue("@Plate_No", PlateNoLabel1.Text)
                cmd.ExecuteNonQuery()

                conn.Close()
                conn.Dispose()

                Dim saveBookingOut As String
                saveBookingOut = "UPDATE booking SET bk_outtime='" & LabelDate.Text & "' WHERE bk_empID = '" & ComboBox1.Text & "' ORDER BY ktr_ID DESC LIMIT 1"
                updateBookingRcd(saveBookingOut)
            End If

            DataGridView1.DataSource = Nothing ' Clear Data Bind data before reassign data.. *! importtant
            BindGrid0()

            PlateNoLabel1.Text = ""
            Button1.Visible = False
            Button2.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            TextBoxName.Visible = False
            ComboBox1.Visible = False
            Label3.Visible = True
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Confirm return key?" + vbCrLf + "Plate No : " & PlateNoLabel1.Text & "", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.Yes Then
            Dim yesappr As String
            yesappr = "UPDATE vehicle SET vhc_key_status ='True' WHERE vhc_PlateNo = '" & PlateNoLabel1.Text & "'"
            InsertRcd(yesappr)

            conn.Open()

            Dim savecd As String = "UPDATE key_take_record SET date_return = '" & LabelDate.Text & "' WHERE Plate_No = '" & PlateNoLabel1.Text & "' ORDER BY ktr_ID DESC LIMIT 1 "
            cmd = New MySqlCommand(savecd, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            conn.Dispose()

            Dim saveBookingOut As String
            saveBookingOut = "UPDATE booking SET bk_intime='" & LabelDate.Text & "' ORDER BY ktr_ID DESC LIMIT 1"
            updateBookingRcd(saveBookingOut)

            PlateNoLabel1.Text = ""

            DataGridView1.DataSource = Nothing ' Clear Data Bind data before reassign data.. *! importtant
            BindGrid0()

            Button1.Visible = False
            Button2.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            TextBoxName.Visible = False
            ComboBox1.Visible = False
            Label3.Visible = True
        End If
    End Sub

    Private Sub ButtonShowList_Click(sender As Object, e As EventArgs) Handles ButtonShowList.Click
        Dim viewrecord As New key_borrow_list
        'viewrecord.MdiParent = Me
        viewrecord.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim getName As String
        getName = "SELECT usr_name FROM users WHERE usr_employeeID = '" & ComboBox1.Text & "'"

        conn.Open()
        cmd = New MySqlCommand(getName, conn)
        db = cmd.ExecuteReader()

        While db.Read()
            TextBoxName.Text = db.Item("usr_name")
        End While

        conn.Close()
    End Sub

    Private Sub RefreshButton3_Click(sender As Object, e As EventArgs) Handles RefreshButton3.Click
        DataGridView1.DataSource = Nothing
        BindGrid0()
    End Sub
End Class