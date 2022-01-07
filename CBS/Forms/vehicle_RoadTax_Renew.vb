Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class vehicle_RoadTax_Renew
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim todaydate As String
    Dim edate As Date
    Dim ndate As Date

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        newDate.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub vehicle_RoadTax_Renew_Load(sender As Object, e As EventArgs) Handles Me.Load
        newDate.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        todaydate = Date.Now.ToShortDateString
        vhc_rt_note.Text = "RoadTax renew on " & todaydate & ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addrcd As String
        Dim updrcd As String
        conn.ConnectionString = ServerString
        ndate = DateTimePicker1.Text.ToString
        edate = vhc_roadtax.Text
        addrcd = "INSERT INTO vehicle_rt_history(vrth_vhcID,vrth_expdate,vrth_note) VALUE(@vrth_vhcID,@vrth_expdate,@vrth_note);"
        updrcd = "UPDATE vehicle SET vhc_roadtax ='" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' WHERE vhc_ID = '" & vhc_ID.Text & "'"

        If ndate < edate Then
            MsgBox("Invalid date, new expired date (" & ndate & ") should not early than expired date (" & edate & ")")
        Else
            Try
                cmd = New MySqlCommand(addrcd, conn)

                cmd.Parameters.AddWithValue("@vrth_vhcID", vhc_ID.Text)
                cmd.Parameters.AddWithValue("@vrth_expdate", newDate.Text)
                cmd.Parameters.AddWithValue("@vrth_note", vhc_rt_note.Text)

                conn.Open()
                Dim RowEffected As Integer = cmd.ExecuteNonQuery()
                If (RowEffected > 0) Then
                    MsgBox("Record save sucessfully.")
                    conn.Close()
                End If
                updatercd(updrcd)

                'vehicle_display.Vhc_roadtaxDateTimePicker.Value = DateTimePicker1.Value.ToShortDateString
                Vehicle_RoadTax.vhc_rt_date.Text = DateTimePicker1.Text

                Me.Close()
                Me.Dispose()

                Vehicle_RoadTax.DataGridView1.DataSource = Nothing
                Vehicle_RoadTax.BindGrid()

            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub
    Public Sub updatercd(ByRef SQLStatement As String)
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

    Private Sub vhc_roadtax_TextChanged(sender As Object, e As EventArgs) Handles vhc_roadtax.TextChanged
        Dim newrtdate As Date
        newrtdate = vhc_roadtax.Text
        DateTimePicker1.Text = newrtdate.AddYears(1).ToShortDateString
    End Sub
End Class