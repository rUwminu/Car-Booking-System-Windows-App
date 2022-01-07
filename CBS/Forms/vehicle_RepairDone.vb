Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class vehicle_RepairDone
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub vehicle_RepairDone_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        vehicle_display.Enabled = False
        Button1.Enabled = False
        DateTimePicker1.Value = Date.Today.ToShortDateString
        DoneRpNote.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim updaterepair As String
        updaterepair = "UPDATE vehicle_repair_status SET Vhcrp_DoneRpDate='" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "',vhcrp_DoneRpNote='" & DoneRpNote.Text & "',vhcrp_status='DONE',vhcrp_IsUpdate='1',vhcrp_repairstatus='0' WHERE vhcrp_ID ='" & vhcrpID.Text & "'"
        InsertRcd(updaterepair)

        Dim updatevhcaccrepair As String
        updatevhcaccrepair = "UPDATE vehicle_acce_info SET vhcacc_repairstatus = '0' WHERE vhcacc_vhcID ='" & rp_vhcID.Text & "'"
        InsertRcd(updatevhcaccrepair)

        Me.Close()
        vehicle_display.Enabled = True
        vehicle_display.ToolStripButton1.PerformClick()
    End Sub

    Private Sub DoneRpNote_TextChanged(sender As Object, e As EventArgs) Handles DoneRpNote.TextChanged
        If DoneRpNote.Text = "" Then
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

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        Me.Close()
        vehicle_display.Enabled = True
        vehicle_display.Button6.Focus()
    End Sub
End Class