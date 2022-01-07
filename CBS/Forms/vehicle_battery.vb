Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class vehicle_battery
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub vehicle_battery_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        vehicle_display.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        vehicle_display.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vhcaccbty As String
        vhcaccbty = "UPDATE vehicle_acce_info SET vhcacc_btydate = '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "',vhcacc_btywrty = '" & bty_month.Text & "' WHERE vhcacc_vhcID = '" & bty_vhcID.Text & "'"
        Dim btyhistory As String
        btyhistory = "INSERT INTO vhcacc_bty_history(vhcacc_btyh_date,vhcacc_btyh_wrty,vhcacc_btyh_vhcID)VALUE('" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & bty_month.Text & "','" & bty_vhcID.Text & "');"

        If bty_month.Text = "" Then
            MsgBox("Please input warranty month" + vbCrLf + "Please use 0, if no warranty")
        Else
            InsertRcd(vhcaccbty)
            InsertRcd(btyhistory)

            DateTimePicker1.Text = vehicle_display.batterydate.Text
            bty_month.Text = vehicle_display.btywarranty.Text

            Me.Close()
            vehicle_display.Enabled = True
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

    Private Sub bty_month_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bty_month.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        Else
            If e.KeyChar = Chr(13) Then
                Button1.Focus()
            End If
        End If
    End Sub
End Class