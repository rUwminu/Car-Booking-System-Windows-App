Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class vehicle_engineOil
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub vehicle_engineOil_Load(sender As Object, e As EventArgs) Handles Me.Load
        vehicle_display.Enabled = False
        DateTimePicker1.Value = Date.Today.ToShortDateString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        vehicle_display.Enabled = True
        MsgBox("Cancel, all record will not save.")
        vehicle_display.Button6.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.ConnectionString = ServerString
        Dim vhcacceoil As String
        vhcacceoil = "UPDATE vehicle_acce_info SET vhcacc_eng_datechg = '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "',vhcacc_eng_oilmeter = '" & newMeter.Text & "' WHERE vhcacc_vhcID = '" & engoil_vhcID.Text & "'"
        InsertRcd(vhcacceoil)

        Dim oilhistory As String
        oilhistory = "INSERT INTO vhcacc_oil_history(vhcacc_oil_date,vhcacc_oil_meter,vhcacc_oil_vhcID)VALUE('" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & vhcinfo_oilmeter.Text & "','" & engoil_vhcID.Text & "');"
        InsertRcd(oilhistory)

        Dim updateMeter As String
        updateMeter = "UPDATE vehicle_acce_info SET vhcacc_crmeter='" & vhcinfo_oilmeter.Text & "' WHERE vhcacc_vhcID = '" & engoil_vhcID.Text & "'"
        'If vhcinfo_oilmeter.ReadOnly = False Then
        InsertRcd(updateMeter)
        'End If

        DateTimePicker1.Text = vehicle_display.oilchangedate.Text
        newMeter.Text = vehicle_display.vhc_ChgMeter.Text

        Me.Close()
        vehicle_display.Enabled = True
        vehicle_display.Button6.Focus()
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

    Private Sub Label2_DoubleClick(sender As Object, e As EventArgs) Handles Label2.DoubleClick
        vhcinfo_oilmeter.ReadOnly = False
    End Sub
End Class