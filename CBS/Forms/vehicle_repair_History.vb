Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class vehicle_repair_History
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True;Convert Zero Datetime=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        vehicle_display.Button6.Focus()
    End Sub

    Private Sub vehicle_repair_History_Load(sender As Object, e As EventArgs) Handles Me.Load
        Button1.Focus()
    End Sub

    Public Sub BindGrid()
        Dim query As String

        query = "Select * from vehicle_repair_status WHERE vhcrp_vhcID = '" & repairh_vhcID.Text & "'"
        Using conn As New MySqlConnection(ServerString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.CommandType = CommandType.Text
                    Using sda As New MySqlDataAdapter(cmd)
                        Using dt As New DataTable()
                            sda.Fill(dt)
                            DataGridView1.AutoGenerateColumns = False
                            'DataGridView1.ColumnCount = 8
                            DataGridView1.ReadOnly = True

                            DataGridView1.Columns(0).Name = "vhcrp_date"
                            DataGridView1.Columns(0).HeaderText = "Date"
                        DataGridView1.Columns(0).DataPropertyName = "vhcrp_date"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                            DataGridView1.Columns(1).Name = "vhcrp_faultpart01"
                            DataGridView1.Columns(1).HeaderText = "Fault Part 01"
                            DataGridView1.Columns(1).DataPropertyName = "vhcrp_faultpart01"
                            DataGridView1.Columns(1).ReadOnly = True
                            DataGridView1.Columns(1).Resizable = False

                            DataGridView1.Columns(2).Name = "vhcrp_faultpart02"
                            DataGridView1.Columns(2).HeaderText = "Fault Part 02"
                            DataGridView1.Columns(2).DataPropertyName = "vhcrp_faultpart02"
                            DataGridView1.Columns(2).ReadOnly = True
                            DataGridView1.Columns(2).Resizable = False

                            DataGridView1.Columns(3).Name = "vhcrp_faultpart03"
                            DataGridView1.Columns(3).HeaderText = "Fault Part 03"
                            DataGridView1.Columns(3).DataPropertyName = "vhcrp_faultpart03"
                            DataGridView1.Columns(3).ReadOnly = True
                            DataGridView1.Columns(3).Resizable = False

                            DataGridView1.Columns(4).Name = "vhcrp_remark"
                            DataGridView1.Columns(4).HeaderText = "Fault Description"
                            DataGridView1.Columns(4).DataPropertyName = "vhcrp_remark"
                            DataGridView1.Columns(4).ReadOnly = True
                            DataGridView1.Columns(4).Resizable = False

                            DataGridView1.Columns(5).Name = "vhcrp_status"
                            DataGridView1.Columns(5).HeaderText = "Status"
                            DataGridView1.Columns(5).DataPropertyName = "vhcrp_status"
                            DataGridView1.Columns(5).ReadOnly = True
                            DataGridView1.Columns(5).Resizable = False

                            DataGridView1.Columns(6).Name = "Vhcrp_DoneRpDate"
                            DataGridView1.Columns(6).HeaderText = "Repaired Date"
                            DataGridView1.Columns(6).DataPropertyName = "Vhcrp_DoneRpDate"
                            DataGridView1.Columns(6).ReadOnly = True
                            DataGridView1.Columns(6).Resizable = False

                            DataGridView1.Columns(7).Name = "vhcrp_DoneRpNote"
                            DataGridView1.Columns(7).HeaderText = "Repaired Note"
                            DataGridView1.Columns(7).DataPropertyName = "vhcrp_DoneRpNote"
                            DataGridView1.Columns(7).ReadOnly = True
                            DataGridView1.Columns(7).Resizable = False
                            DataGridView1.DataSource = dt
                        End Using
                    End Using
                End Using
            End Using

    End Sub

    Private Sub repairh_vhcID_TextChanged(sender As Object, e As EventArgs) Handles repairh_vhcID.TextChanged
        BindGrid()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class