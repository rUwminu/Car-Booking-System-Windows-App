Imports MySql.Data.MySqlClient
Public Class security_checkIN
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Private Sub security_checkIN_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        DateTimePicker1.Value = Date.Now.ToString("dd-MM-yyyy HH:mm:ss")
        DateTimePicker2.Value = Date.Now.ToString("dd-MM-yyyy HH:mm:ss")
        Timer1.Start()
        sc_InMeter.Focus()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
        Timer1.Start()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        intime.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim addintime As String
        Dim chgstatus As String
        Dim updvhcinfometer As String
        Dim updseccheckin As String
        If sc_InMeter.Text < outmeter.Text Then
            MsgBox("The vehicle meter number you key is invalid, " + vbCrLf + "it should not smaller than meter reading when out (" & outmeter.Text & ")")
        Else
            If sc_InMeter.Text = "" Then
                MsgBox("Vehicle METER cannot be BLANK")
            Else
                'Update to booking table
                addintime = "UPDATE booking SET bk_intime='" & actintime.Text & "',bk_inmeter='" & sc_InMeter.Text & "',bk_INcheckbyName='" & secName.Text & "',bk_INcheckbyID='" & secID.Text & "',bk_complete='1', bk_INOUTstatus = 'COMPLETE' WHERE bk_ID = '" & sec_bkID.Text & "'"
                InsertRcd(addintime)
                MsgBox("In Time updated & Completed.")
                'Update to vehicle status, this car is free 0
                chgstatus = "UPDATE vehicle_status SET vhcstatus_status = '0' WHERE vhcstatus_bookingID = '" & sec_bkID.Text & "'"
                InsertRcd(chgstatus)
                'Update to security check time in for tracing purpose
                updseccheckin = "UPDATE security_check SET sc_intimeupd = '" & intime.Text & "', sc_bkintime = '" & actintime.Text & "' WHERE sc_bkID = '" & sec_bkID.Text & "'"
                InsertRcd(updseccheckin)
                'Update to vehicle accessories current meter is
                updvhcinfometer = "UPDATE vehicle_acce_info SET vhcacc_crmeter = '" & sc_InMeter.Text & "' WHERE vhcacc_vhcID = '" & sec_vhcID.Text & "'"
                InsertRcd(updvhcinfometer)
                Dim yesappr As String
                yesappr = "UPDATE vehicle SET vhc_key_status ='Yes' WHERE vhc_PlateNo = '" & LabelPN.Text & "'"
                InsertRcd(yesappr)
                Dim savecd As String = "UPDATE key_take_record SET date_return = '" & LabelDate.Text & "' WHERE Plate_No = '" & LabelPN.Text & "' ORDER BY ktr_ID DESC LIMIT 1 "
                InsertRcd(savecd)
                Me.Close()
                security_main.DataGridView1.DataSource = Nothing
                security_main.BindGrid()
                security_main.DataGridView1.CurrentCell = Nothing


            End If
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

    Private Sub Label1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Label1.MouseDoubleClick
        Me.Close()
    End Sub

    Private Sub sc_InMeter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sc_InMeter.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        Else
            If e.KeyChar = Chr(13) Then
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        actintime.Text = DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss")
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