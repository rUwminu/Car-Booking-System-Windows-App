Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Vehicle_repair
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub Vehicle_repair_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        vehicle_display.Enabled = False
        Button1.Enabled = False
        DateTimePicker1.Value = Date.Today.ToShortDateString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If vhcrp_desc.Text = "" Then
            MsgBox("Fault Description must be fill up before save.")
        Else
            Dim updatevhcacc As String
            updatevhcacc = "UPDATE vehicle_acce_info SET vhcacc_repairstatus = '1' WHERE vhcacc_vhcID= '" & repair_vhcID.Text & "'"
            InsertRcd(updatevhcacc)

            Dim insertrepair As String
            insertrepair = "INSERT INTO vehicle_repair_status(" _
            + "vhcrp_date,vhcrp_faultpart01,vhcrp_faultpart02,vhcrp_faultpart03,vhcrp_remark,vhcrp_repairstatus,vhcrp_vhcID)" _
            + "VALUE('" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & vhcrp_fault01.Text & "','" & vhcrp_fault02.Text & "','" & vhcrp_fault03.Text & "','" & vhcrp_desc.Text & "','1','" & repair_vhcID.Text & "')"
            InsertRcd(insertrepair)

            Me.Close()
            vehicle_display.Enabled = True
            vehicle_display.ToolStripButton1.PerformClick()
        End If
    End Sub

    Private Sub vhcrp_desc_TextChanged(sender As Object, e As EventArgs) Handles vhcrp_desc.TextChanged
        If vhcrp_desc.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        vehicle_display.Enabled = True
        MsgBox("Cancel, all record will not save.")
        vehicle_display.Button6.Focus()
    End Sub
End Class