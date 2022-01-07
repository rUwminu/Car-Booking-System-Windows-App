Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class vehicle_tyreHistory
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub vehicle_tyreHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        Button1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub BindGrid()
        Dim query As String

        query = "Select * from vhcacc_tyre_history WHERE vhcacc_tyreh_vhcID = '" & tyre_vhcID.Text & "' ORDER BY vhcacc_tyreh_ID DESC "
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        'DataGridView1.ColumnCount = 4
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "vhcacc_tyreh_tyreChg"
                        DataGridView1.Columns(0).HeaderText = "Change Date"
                        DataGridView1.Columns(0).DataPropertyName = "vhcacc_tyreh_tyreChg"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "vhcacc_tyreh_brand"
                        DataGridView1.Columns(1).HeaderText = "Tyre Brand"
                        DataGridView1.Columns(1).DataPropertyName = "vhcacc_tyreh_brand"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "vhcacc_tyreh_mfgdt"
                        DataGridView1.Columns(2).HeaderText = "Tyre MfgDate"
                        DataGridView1.Columns(2).DataPropertyName = "vhcacc_tyreh_mfgdt"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "vhcacc_tyreh_tyreloc"
                        DataGridView1.Columns(3).HeaderText = "Tyre Place"
                        DataGridView1.Columns(3).DataPropertyName = "vhcacc_tyreh_tyreloc"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False

                        DataGridView1.DataSource = dt

                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub tyre_vhcID_TextChanged(sender As Object, e As EventArgs) Handles tyre_vhcID.TextChanged
        BindGrid()
    End Sub
End Class