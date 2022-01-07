Imports MySql.Data.MySqlClient
Public Class security_checkOUT
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True;Convert Zero Datetime=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        outtime.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub security_checkOUT_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        DateTimePicker1.Value = Date.Now.ToString("dd-MM-yyyy HH:mm:ss")
        DateTimePicker2.Value = Date.Now.ToString("dd-MM-yyyy HH:mm:ss")
        Timer1.Start()
        'sc_OutMeter.Focus()

        'Dim getcurrentmeter As String
        'getcurrentmeter = "SELECT vhcacc_eng_oilmeter FROM vehicle_acce_info WHERE vhcacc_vhcID = '" & sec_vhcID.Text & "'"
        'conn.Open()
        'cmd = New MySqlCommand(getcurrentmeter, conn)
        'db = cmd.ExecuteReader()
        'While db.Read()
        '    sc_OutMeter.Text = db.Item("vhcacc_eng_oilmeter")
        'End While
        'conn.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = Date.Now.ToString("dd-MM-yyyy HH:mm:ss")
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        outtime.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Dim addouttime As String
        Dim addsecrcd As String
        Dim updvhcinfometer As String
        Dim savecd As String

        ' Update booking out time and meter
        addouttime = "UPDATE booking SET bk_outtime='" & actouttime.Text & "',bk_OUTcheckbyName='" & secName.Text & "',bk_OUTcheckbyID='" & secID.Text & "', bk_INOUTstatus = 'OUT' WHERE bk_ID = '" & sec_bkID.Text & "'"
        InsertRcd(addouttime)
        ' Add record to security check for tracing purpose
        addsecrcd = "INSERT INTO security_check(sc_bkID,sc_outtimeupd,sc_bkouttime) VALUE('" & sec_bkID.Text & "','" & outtime.Text & "','" & actouttime.Text & "');"
        InsertRcd(addsecrcd)
        MsgBox("Out Time updated.")
        updvhcinfometer = "UPDATE vehicle SET vhc_key_status = 'No' WHERE vhc_ID = '" & sec_vhcID.Text & "'"
        InsertRcd(updvhcinfometer)
        conn.Open()
        savecd = "INSERT INTO key_take_record (employee_name, employee_id, date_take, Plate_No) VALUES (@employee_name, @employee_id, @date_take, @Plate_No)"
        cmd = New MySqlCommand(savecd, conn)
        cmd.Parameters.AddWithValue("@employee_name", LabelEmpName.Text)
        cmd.Parameters.AddWithValue("@employee_id", LabelEmpID.Text)
        cmd.Parameters.AddWithValue("@date_take", LabelDate.Text)
        cmd.Parameters.AddWithValue("@Plate_No", LabelPN.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        conn.Dispose()
        Me.Close()

        security_main.DataGridView1.DataSource = Nothing
        security_main.BindGrid()
        security_main.DataGridView1.CurrentCell = Nothing

        security_main.DataGridView2.DataSource = Nothing
        security_main.BindGrid0()
        security_main.DataGridView1.CurrentCell = Nothing
        ' ---------------------------------------------------------------------------
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

    Private Sub Label1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Label1.MouseDoubleClick
        Me.Close()
    End Sub

    Private Sub sc_OutMeter_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        Else
            If e.KeyChar = Chr(13) Then
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        actouttime.Text = DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub sec_vhcID_TextChanged(sender As Object, e As EventArgs) Handles sec_vhcID.TextChanged
        Dim ServerString2 As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
        Dim conn2 As MySqlConnection = New MySqlConnection
        Dim db2 As MySqlDataReader
        Dim cmd2 As MySqlCommand = New MySqlCommand
        conn2.ConnectionString = ServerString2

        Dim checkcrmeter As String
        checkcrmeter = "SELECT vhcacc_crmeter FROM vehicle_acce_info WHERE vhcacc_vhcID = '" & sec_vhcID.Text & "'"
        conn2.Open()
        cmd2 = New MySqlCommand(checkcrmeter, conn2)
        db2 = cmd2.ExecuteReader()
        While db2.Read()
            crmeter.Text = db2.Item("vhcacc_crmeter").ToString
        End While
        conn2.Close()
    End Sub
End Class