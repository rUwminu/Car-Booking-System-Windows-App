Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class key_borrow_list
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub Key_borrow_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = ServerString

        ComboBox1.Items.Add("All")

        If MainMDI.display_lvl.Text = "0" Or MainMDI.display_lvl.Text = "2" Or MainMDI.display_lvl.Text = "5" Or MainMDI.display_lvl.Text = "6" Then
            BindGrid0()
        End If

        Dim getID As String
        getID = "SELECT vhc_PlateNo FROM vehicle WHERE NOT vhc_type = 'Lorry'"
        conn.Open()
        cmd = New MySqlCommand(getID, conn)
        db = cmd.ExecuteReader()
        While db.Read()
            ComboBox1.Items.Add(db.Item("vhc_PlateNo"))
        End While
        conn.Close()
    End Sub

    Public Sub BindGrid0()
        Dim query As String
        query = " SELECT * FROM key_take_record ORDER BY ktr_ID DESC"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.ColumnCount = 5
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "employee_name"
                        DataGridView1.Columns(0).HeaderText = "Name"
                        DataGridView1.Columns(0).DataPropertyName = "employee_name"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "employee_id"
                        DataGridView1.Columns(1).HeaderText = "ID"
                        DataGridView1.Columns(1).DataPropertyName = "employee_id"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "date_take"
                        DataGridView1.Columns(2).HeaderText = "Take Date"
                        DataGridView1.Columns(2).DataPropertyName = "date_take"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "date_return"
                        DataGridView1.Columns(3).HeaderText = "Return Date"
                        DataGridView1.Columns(3).DataPropertyName = "date_return"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False

                        DataGridView1.Columns(4).Name = "Plate_No"
                        DataGridView1.Columns(4).HeaderText = "Plate No"
                        DataGridView1.Columns(4).DataPropertyName = "Plate_No"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False

                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub BindGridA()
        Dim query2 As String
        query2 = " SELECT * FROM key_take_record WHERE Plate_No = '" & ComboBox1.Text & "' ORDER BY ktr_ID DESC"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query2, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dta As New DataTable()
                        sda.Fill(dta)
                        DataGridView1.AutoGenerateColumns = False
                        DataGridView1.ColumnCount = 5
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "employee_name"
                        DataGridView1.Columns(0).HeaderText = "Name"
                        DataGridView1.Columns(0).DataPropertyName = "employee_name"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "employee_id"
                        DataGridView1.Columns(1).HeaderText = "ID"
                        DataGridView1.Columns(1).DataPropertyName = "employee_id"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "date_take"
                        DataGridView1.Columns(2).HeaderText = "Take Date"
                        DataGridView1.Columns(2).DataPropertyName = "date_take"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "date_return"
                        DataGridView1.Columns(3).HeaderText = "Return Date"
                        DataGridView1.Columns(3).DataPropertyName = "date_return"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False

                        DataGridView1.Columns(4).Name = "Plate_No"
                        DataGridView1.Columns(4).HeaderText = "Plate No"
                        DataGridView1.Columns(4).DataPropertyName = "Plate_No"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False

                        DataGridView1.DataSource = dta
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub ButtonS_Click(sender As Object, e As EventArgs) Handles ButtonS.Click
        If (ComboBox1.Text = "All") Then
            DataGridView1.DataSource = Nothing
            BindGrid0()
        Else
            DataGridView1.DataSource = Nothing
            BindGridA()
        End If
        DataGridView1.CurrentCell = Nothing
    End Sub

    Private Sub ButtonR_Click(sender As Object, e As EventArgs) Handles ButtonR.Click
        DataGridView1.DataSource = Nothing
        BindGrid0()
        DataGridView1.CurrentCell = Nothing
    End Sub
End Class