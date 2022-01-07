Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class vehicle_engOil_History
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Private Sub vehicle_engOil_History_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        Button1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        vehicle_display.Button6.Focus()
    End Sub

    Public Sub BindGrid()
        Dim query As String

        query = " Select * from vhcacc_oil_history WHERE vhcacc_oil_vhcID = '" & engoil_vhcID.Text & "'"
            Using conn As New MySqlConnection(ServerString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.CommandType = CommandType.Text
                    Using sda As New MySqlDataAdapter(cmd)
                        Using dt As New DataTable()
                            sda.Fill(dt)
                            DataGridView1.AutoGenerateColumns = False
                            'DataGridView1.ColumnCount = 2
                            DataGridView1.ReadOnly = True

                            DataGridView1.Columns(0).Name = "vhcacc_oil_meter"
                            DataGridView1.Columns(0).HeaderText = "Oil Change (KM)"
                            DataGridView1.Columns(0).DataPropertyName = "vhcacc_oil_meter"
                            DataGridView1.Columns(0).ReadOnly = True
                            DataGridView1.Columns(0).Resizable = False

                            DataGridView1.Columns(1).Name = "vhcacc_oil_date"
                            DataGridView1.Columns(1).HeaderText = "Date Change"
                            DataGridView1.Columns(1).DataPropertyName = "vhcacc_oil_date"
                            DataGridView1.Columns(1).ReadOnly = True
                            DataGridView1.Columns(1).Resizable = False
                            DataGridView1.DataSource = dt
                        End Using
                    End Using
                End Using
            End Using

    End Sub

    Private Sub engoil_vhcID_TextChanged(sender As Object, e As EventArgs) Handles engoil_vhcID.TextChanged
        BindGrid()
    End Sub
End Class