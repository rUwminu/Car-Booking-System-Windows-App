Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.IO
Imports VB = Microsoft.VisualBasic

Public Class Show_Expiry
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private WithEvents clock As New Timers.Timer

    Private Sub Show_Expiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MainMDI.display_lvl.Text = "0" Or MainMDI.display_lvl.Text = "2" Or MainMDI.display_lvl.Text = "5" Or MainMDI.display_lvl.Text = "6" Then
            DataGridView2.DataSource = Nothing
            BindGrid()
            DataGridView2.CurrentCell = Nothing
            Label2.Text = "TriggerCount"
            Label3Page.Text = "1"
        End If

        With clock
            .Interval = 20000 ' Refresh every 20 sec
            .AutoReset = True
            .Enabled = True
            .Start()
        End With
    End Sub

    Private Sub clock_tick() Handles clock.Elapsed
        Try
            Me.BeginInvoke(Sub()

                               If Label3Page.Text = "1" Then
                                   Label3Page.Text = "" ' Clear the label text
                                   Label3Page.Text = "1" ' Assign the text again to trigger text change
                               ElseIf Label3Page.Text = "2" Then
                                   Label3Page.Text = ""
                                   Label3Page.Text = "2"
                               ElseIf Label3Page.Text = "3" Then
                                   Label3Page.Text = ""
                                   Label3Page.Text = "3"
                               End If
                               Me.Refresh()
                           End Sub)
        Catch ex As Exception
            ' There are error, use try to escape the error and re-run this code
        End Try
    End Sub

    Public Sub BindGrid0()
        Dim query As String
        'query = "SELECT * FROM vehicle"
        query = "SELECT vhc_ID, vhc_PlateNo, vhc_brand, vhc_model, vhc_roadtax, DATEDIFF(vhc_roadtax, NOW())+1 AS leftdate FROM vehicle "
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.ColumnCount = 6
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

                        DataGridView1.Columns(3).Name = "vhc_expire_date"
                        DataGridView1.Columns(3).HeaderText = "Expire Date"
                        DataGridView1.Columns(3).DataPropertyName = "vhc_roadtax"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False

                        DataGridView1.Columns(4).Name = "leftdate"
                        DataGridView1.Columns(4).HeaderText = "Expire In"
                        DataGridView1.Columns(4).DataPropertyName = "leftdate"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False

                        DataGridView1.Columns(5).Name = "vhc_ID"
                        DataGridView1.Columns(5).HeaderText = "vhc_ID"
                        DataGridView1.Columns(5).DataPropertyName = "vhc_ID"
                        DataGridView1.Columns(5).ReadOnly = True
                        DataGridView1.Columns(5).Resizable = False

                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub BindGrid()
        Dim query As String
        query = "SELECT vehicle.vhc_PlateNo, vehicle.vhc_brand, vehicle.vhc_model, vehicle.vhc_key_status FROM vehicle INNER JOIN vehicle_acce_info ON vehicle_acce_info.vhcacc_vhcID = vehicle.vhc_ID WHERE vehicle_acce_info.vhcacc_repairstatus = '0' AND NOT vehicle.vhc_type = 'Lorry'"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView2.AutoGenerateColumns = False
                        DataGridView2.ColumnCount = 4
                        DataGridView2.ReadOnly = True

                        DataGridView2.Columns(0).Name = "vhc_PlateNo"
                        DataGridView2.Columns(0).HeaderText = "Plate No"
                        DataGridView2.Columns(0).DataPropertyName = "vhc_PlateNo"
                        DataGridView2.Columns(0).ReadOnly = True
                        DataGridView2.Columns(0).Resizable = False

                        DataGridView2.Columns(1).Name = "vhc_brand"
                        DataGridView2.Columns(1).HeaderText = "Brand"
                        DataGridView2.Columns(1).DataPropertyName = "vhc_brand"
                        DataGridView2.Columns(1).ReadOnly = True
                        DataGridView2.Columns(1).Resizable = False

                        DataGridView2.Columns(2).Name = "vhc_model"
                        DataGridView2.Columns(2).HeaderText = "Model"
                        DataGridView2.Columns(2).DataPropertyName = "vhc_model"
                        DataGridView2.Columns(2).ReadOnly = True
                        DataGridView2.Columns(2).Width = "100"
                        DataGridView2.Columns(2).Resizable = False

                        DataGridView2.Columns(3).Name = "vhc_key_status"
                        DataGridView2.Columns(3).HeaderText = "Key Status"
                        DataGridView2.Columns(3).DataPropertyName = "vhc_key_status"
                        DataGridView2.Columns(3).ReadOnly = True
                        DataGridView2.Columns(3).Resizable = False

                        DataGridView2.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub ' A

    Public Sub BindGrid3()
        Dim query As String
        'query = "SELECT * FROM vehicle"
        query = "SELECT vhc_ID, vhc_PlateNo, vhc_brand, vhc_model, vhc_insurance, DATEDIFF(vhc_insurance, NOW())+1 AS leftdate FROM vehicle "
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.ColumnCount = 6
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

                        DataGridView1.Columns(3).Name = "vhc_expire_date"
                        DataGridView1.Columns(3).HeaderText = "Insurance Date"
                        DataGridView1.Columns(3).DataPropertyName = "vhc_insurance"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False

                        DataGridView1.Columns(4).Name = "leftdate"
                        DataGridView1.Columns(4).HeaderText = "Expire In"
                        DataGridView1.Columns(4).DataPropertyName = "leftdate"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False

                        DataGridView1.Columns(5).Name = "vhc_ID"
                        DataGridView1.Columns(5).HeaderText = "vhc_ID"
                        DataGridView1.Columns(5).DataPropertyName = "vhc_ID"
                        DataGridView1.Columns(5).ReadOnly = True
                        DataGridView1.Columns(5).Resizable = False

                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub BindGrid4()
        Dim query As String
        'query = "SELECT * FROM vehicle"
        query = "SELECT vehicle.vhc_ID, vehicle.vhc_PlateNo, vehicle.vhc_brand, vehicle.vhc_model, lorry_inspection.vhcinsp_inspection, DATEDIFF(lorry_inspection.vhcinsp_inspection, NOW())+1 AS leftdate FROM vehicle INNER JOIN lorry_inspection on lorry_inspection.vhcinsp_vhcID=vehicle.vhc_ID WHERE vehicle.vhc_type = 'Lorry'"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.ColumnCount = 6
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

                        DataGridView1.Columns(3).Name = "vhc_expire_date"
                        DataGridView1.Columns(3).HeaderText = "Inspection Date"
                        DataGridView1.Columns(3).DataPropertyName = "vhcinsp_inspection"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False

                        DataGridView1.Columns(4).Name = "leftdate"
                        DataGridView1.Columns(4).HeaderText = "Expire In"
                        DataGridView1.Columns(4).DataPropertyName = "leftdate"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False

                        DataGridView1.Columns(5).Name = "vhc_ID"
                        DataGridView1.Columns(5).HeaderText = "vhc_ID"
                        DataGridView1.Columns(5).DataPropertyName = "vhc_ID"
                        DataGridView1.Columns(5).ReadOnly = True
                        DataGridView1.Columns(5).Resizable = False

                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView2.DataSource = Nothing
        BindGrid()
    End Sub

    Private Sub ButtonShowList_Click_1(sender As Object, e As EventArgs) Handles ButtonShowList.Click
        Dim viewrecord As New key_borrow_list
        viewrecord.Show()
    End Sub

    Private Sub RefreshButton3_Click(sender As Object, e As EventArgs) Handles RefreshButton3.Click
        If Label3Page.Text = "1" Then
            DataGridView1.DataSource = Nothing
            BindGrid0()
            DataGridView1.CurrentCell = Nothing
        ElseIf Label3Page.Text = "2" Then
            DataGridView1.DataSource = Nothing
            BindGrid3()
            DataGridView1.CurrentCell = Nothing
        ElseIf Label3Page.Text = "3" Then
            DataGridView1.DataSource = Nothing
            BindGrid4()
            DataGridView1.CurrentCell = Nothing
        End If

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim val As Integer = Integer.Parse(row.Cells("leftdate").Value.ToString())
            If val <= 30 Then
                row.DefaultCellStyle.BackColor = Color.Pink
            End If
        Next
    End Sub

    Private Sub Label2_TC(sender As Object, e As EventArgs) Handles Label2.TextChanged
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim val As Integer = Integer.Parse(row.Cells("leftdate").Value.ToString())
            If val <= 30 Then
                row.DefaultCellStyle.BackColor = Color.Pink
            End If
        Next
    End Sub

    Private Sub UpdateRoadTax_Click_1(sender As Object, e As EventArgs) Handles UpdateText.Click
        If Label3Page.Text = "1" Then
            If (Label1.Text = "Label1" Or Label1.Text = "") Then
                MsgBox("Please Pick A record to make changes")
            Else
                Dim addroadtax As New Vehicle_RoadTax
                addroadtax.MdiParent = MainMDI
                addroadtax.Show()
                addroadtax.vhc_platetext.Text = Label1.Text
                addroadtax.vhc_IDtextbox.Text = LabelvhcID.Text
                addroadtax.vhc_rt_date.Text = getdate.Text
            End If
        ElseIf Label3Page.Text = "2" Then
            If (Label1.Text = "") Then
                MsgBox("Please Pick A record to make changes")
            Else
                Dim addins As New Vehicle_Insurance
                addins.MdiParent = MainMDI
                addins.Show()
                addins.vhc_platetext.Text = Label1.Text
                addins.vhc_IDtextbox.Text = LabelvhcID.Text
                addins.vhc_rt_date.Text = getdate.Text
            End If
        ElseIf Label3Page.Text = "3" Then
            If (Label1.Text = "") Then
                MsgBox("Please Pick A record to make changes")
            Else
                Dim addins As New Vehicle_Inspect
                addins.MdiParent = MainMDI
                addins.Show()
                addins.vhc_platetext.Text = Label1.Text
                addins.vhc_IDtextbox.Text = LabelvhcID.Text
                addins.vhc_rt_date.Text = getdate.Text
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If Label3Page.Text = "1" Then
                If e.RowIndex >= 0 Then
                    Dim row As DataGridViewRow
                    row = Me.DataGridView1.Rows(e.RowIndex)
                    Label1.Text = row.Cells("vhc_PlateNo").Value.ToString
                    getdate.Text = row.Cells("vhc_expire_date").Value.ToShortDateString
                    LabelvhcID.Text = row.Cells("vhc_ID").Value.ToString
                End If
            Else
                If e.RowIndex >= 0 Then
                    Dim row As DataGridViewRow
                    row = Me.DataGridView1.Rows(e.RowIndex)
                    Label1.Text = row.Cells("vhc_PlateNo").Value.ToString
                    getdate.Text = row.Cells("vhc_expire_date").Value.ToShortDateString
                    LabelvhcID.Text = row.Cells("vhc_ID").Value.ToString
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try
            If Label3Page.Text = "1" Then
                If e.RowIndex >= 0 Then
                    Dim row As DataGridViewRow
                    row = Me.DataGridView1.Rows(e.RowIndex)
                    Label1.Text = row.Cells("vhc_PlateNo").Value.ToString
                    getdate.Text = row.Cells("vhc_expire_date").Value.ToShortDateString
                    LabelvhcID.Text = row.Cells("vhc_ID").Value.ToString
                End If
            Else
                If e.RowIndex >= 0 Then
                    Dim row As DataGridViewRow
                    row = Me.DataGridView1.Rows(e.RowIndex)
                    Label1.Text = row.Cells("vhc_PlateNo").Value.ToString
                    getdate.Text = row.Cells("vhc_expire_date").Value.ToShortDateString
                    LabelvhcID.Text = row.Cells("vhc_ID").Value.ToString
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2RT_Click(sender As Object, e As EventArgs) Handles Button2RT.Click
        Label3Page.Text = "1"
        UpdateText.Text = "Update RoadTax"

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim val As Integer = Integer.Parse(row.Cells("leftdate").Value.ToString())
            If val <= 30 Then
                row.DefaultCellStyle.BackColor = Color.Pink
            End If
        Next

        ' Clear pass value
        Label1.Text = ""
        LabelvhcID.Text = ""
        getdate.Text = ""
    End Sub

    Private Sub Button3INS_Click(sender As Object, e As EventArgs) Handles Button3INS.Click
        Label3Page.Text = "2"
        UpdateText.Text = "Update Insurance"

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim val As Integer = Integer.Parse(row.Cells("leftdate").Value.ToString())
            If val <= 30 Then
                row.DefaultCellStyle.BackColor = Color.Pink
            End If
        Next

        ' Clear pass value
        Label1.Text = ""
        LabelvhcID.Text = ""
        getdate.Text = ""
    End Sub

    Private Sub Button4INSPECT_Click(sender As Object, e As EventArgs) Handles Button4INSPECT.Click
        Label3Page.Text = "3"
        UpdateText.Text = "Update Inspection"

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim val As Integer = Integer.Parse(row.Cells("leftdate").Value.ToString())
            If val <= 30 Then
                row.DefaultCellStyle.BackColor = Color.Pink
            End If
        Next

        ' Clear pass value
        Label1.Text = ""
        LabelvhcID.Text = ""
        getdate.Text = ""
    End Sub

    Private Sub Label3Page_TC(sender As Object, e As EventArgs) Handles Label3Page.TextChanged
        If Label3Page.Text = "1" Then
            UpdateText.Text = "Update RoadTax"
            DataGridView1.DataSource = Nothing
            BindGrid0()
            DataGridView1.CurrentCell = Nothing
        ElseIf Label3Page.Text = "2" Then
            DataGridView1.DataSource = Nothing
            BindGrid3()
            DataGridView1.CurrentCell = Nothing
        ElseIf Label3Page.Text = "3" Then
            DataGridView1.DataSource = Nothing
            BindGrid4()
            DataGridView1.CurrentCell = Nothing
        End If

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim val As Integer = Integer.Parse(row.Cells("leftdate").Value.ToString())
            If val <= 30 Then
                row.DefaultCellStyle.BackColor = Color.Pink
            End If
        Next
    End Sub
End Class