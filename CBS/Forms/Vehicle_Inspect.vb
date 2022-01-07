Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Vehicle_Inspect
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"

    Private Sub Vehicle_RoadTax_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'CBSDataSet.vehicle_rt_history' table. You can move, or remove it, as needed.    
        'Me.Vehicle_rt_historyTableAdapter.Fill(Me.CBSDataSet.vehicle_rt_history)
        'conn.ConnectionString = ServerString
        dateToolStripStatusLabel.Text = Date.Today.ToShortDateString
        vehicle_display.Enabled = False
        Me.BindGrid()
    End Sub

    Private Sub vhc_rt_date_TextChanged(sender As Object, e As EventArgs) Handles vhc_rt_date.TextChanged
        Dim todaydate As Date
        Dim rtdate As Date
        Dim timeexpired As String
        todaydate = Date.Today.ToShortDateString
        rtdate = vhc_rt_date.Text

        timeexpired = DateDiff(DateInterval.Day, todaydate, rtdate)

        If timeexpired < 30 Then
            expiredNotetoolstips.Text = "" & timeexpired & " Day(s) left."
        Else
            expiredNotetoolstips.Text = Nothing
        End If
    End Sub

    Private Sub Vehicle_RoadTax_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        vehicle_display.Enabled = True
    End Sub

    Public Sub BindGrid()
        Dim query As String
        query = " SELECT * FROM lorry_inspection_history WHERE vhcinsp_vhcID = '" & vhc_IDtextbox.Text & "'"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                'cmd.Parameters.AddWithValue("@vhcID", vhc_IDtextbox.Text)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addroadtax As New vehicle_inspect_Renew
        addroadtax.MdiParent = MainMDI
        addroadtax.Show()
        addroadtax.vhc_ID.Text = vhc_IDtextbox.Text
        addroadtax.vhc_plateNo.Text = vhc_platetext.Text
        addroadtax.vhc_roadtax.Text = vhc_rt_date.Text
    End Sub

    Private Sub vhc_IDtextbox_TextChanged(sender As Object, e As EventArgs) Handles vhc_IDtextbox.TextChanged
        Me.BindGrid()
    End Sub
End Class