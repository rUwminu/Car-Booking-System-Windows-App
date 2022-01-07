Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class vehicle_bty_history
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub vehicle_bty_history_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        BindGrid()
        Button1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub BindGrid()
        Dim query As String

        query = "Select * from vhcacc_bty_history WHERE vhcacc_btyh_vhcID = '" & btyh_vhcID.Text & "'"
            Using conn As New MySqlConnection(ServerString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.CommandType = CommandType.Text
                    Using sda As New MySqlDataAdapter(cmd)
                        Using dt As New DataTable()
                            sda.Fill(dt)
                            DataGridView1.AutoGenerateColumns = False
                            'DataGridView1.ColumnCount = 2
                            DataGridView1.ReadOnly = True

                            DataGridView1.Columns(0).Name = "vhcacc_btyh_date"
                            DataGridView1.Columns(0).HeaderText = "Date Change"
                            DataGridView1.Columns(0).DataPropertyName = "vhcacc_btyh_date"
                            DataGridView1.Columns(0).ReadOnly = True
                            DataGridView1.Columns(0).Resizable = False

                            DataGridView1.Columns(1).Name = "vhcacc_btyh_wrty"
                            DataGridView1.Columns(1).HeaderText = "Warranty Period (Month)"
                            DataGridView1.Columns(1).DataPropertyName = "vhcacc_btyh_wrty"
                            DataGridView1.Columns(1).ReadOnly = True
                            DataGridView1.Columns(1).Resizable = False
                            DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                            DataGridView1.DataSource = dt
                        End Using
                    End Using
                End Using
            End Using

    End Sub

    Private Sub btyh_vhcID_TextChanged(sender As Object, e As EventArgs) Handles btyh_vhcID.TextChanged
        BindGrid()
    End Sub
End Class