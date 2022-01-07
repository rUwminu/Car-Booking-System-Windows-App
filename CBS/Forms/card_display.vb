Imports MySql.Data.MySqlClient
Public Class card_display
    Dim ServerString As String = "server=localhost;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=CBS12345678.;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub card_display_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        ComboBox1.Text = "All"
        DataGridView1.DataSource = Nothing
        BindGrid0()
    End Sub

    Public Sub BindGrid0()
        Dim query As String
        query = "SELECT * FROM cards WHERE card_active='1'"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        'DataGridView1.ColumnCount = 5
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "card_type"
                        DataGridView1.Columns(0).HeaderText = "Card Type"
                        DataGridView1.Columns(0).DataPropertyName = "card_type"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "card_no"
                        DataGridView1.Columns(1).HeaderText = "Card No."
                        DataGridView1.Columns(1).DataPropertyName = "card_no"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "card_remark"
                        DataGridView1.Columns(2).HeaderText = "Remark"
                        DataGridView1.Columns(2).DataPropertyName = "card_remark"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "card_ID"
                        DataGridView1.Columns(3).HeaderText = "ID"
                        DataGridView1.Columns(3).DataPropertyName = "card_ID"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False
                        DataGridView1.Columns(3).Visible = False

                        DataGridView1.Columns(4).Name = "card_active"
                        DataGridView1.Columns(4).HeaderText = "Active"
                        DataGridView1.Columns(4).DataPropertyName = "card_active"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False
                        DataGridView1.Columns(4).Visible = False

                        DataGridView1.DataSource = dt
                        If dt.Rows.Count = 0 Then
                            MsgBox("No Record Found!")
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub BindGrid1()
        Dim query As String
        query = "SELECT * FROM cards WHERE card_type='" & ComboBox1.Text & "' AND card_active='1'"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        'DataGridView1.ColumnCount = 5
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "card_type"
                        DataGridView1.Columns(0).HeaderText = "Card Type"
                        DataGridView1.Columns(0).DataPropertyName = "bcard_type"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "card_no"
                        DataGridView1.Columns(1).HeaderText = "Card No."
                        DataGridView1.Columns(1).DataPropertyName = "card_no"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "card_remark"
                        DataGridView1.Columns(2).HeaderText = "Remark"
                        DataGridView1.Columns(2).DataPropertyName = "card_remark"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "card_ID"
                        DataGridView1.Columns(3).HeaderText = "ID"
                        DataGridView1.Columns(3).DataPropertyName = "card_ID"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False
                        DataGridView1.Columns(3).Visible = False

                        DataGridView1.Columns(4).Name = "card_active"
                        DataGridView1.Columns(4).HeaderText = "Active"
                        DataGridView1.Columns(4).DataPropertyName = "card_active"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False
                        DataGridView1.Columns(4).Visible = False

                        DataGridView1.DataSource = dt
                        If dt.Rows.Count = 0 Then
                            MsgBox("No Record Found!")
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub BindGrid2()
        Dim query As String
        query = "SELECT * FROM cards"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        'DataGridView1.ColumnCount = 5
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "card_type"
                        DataGridView1.Columns(0).HeaderText = "Card Type"
                        DataGridView1.Columns(0).DataPropertyName = "card_type"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "card_no"
                        DataGridView1.Columns(1).HeaderText = "Card No."
                        DataGridView1.Columns(1).DataPropertyName = "card_no"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "card_remark"
                        DataGridView1.Columns(2).HeaderText = "Remark"
                        DataGridView1.Columns(2).DataPropertyName = "card_remark"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "card_ID"
                        DataGridView1.Columns(3).HeaderText = "ID"
                        DataGridView1.Columns(3).DataPropertyName = "card_ID"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False
                        DataGridView1.Columns(3).Visible = False

                        DataGridView1.Columns(4).Name = "card_active"
                        DataGridView1.Columns(4).HeaderText = "Active"
                        DataGridView1.Columns(4).DataPropertyName = "card_active"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False
                        DataGridView1.Columns(4).Visible = False

                        DataGridView1.DataSource = dt
                        If dt.Rows.Count = 0 Then
                            MsgBox("No Record Found!")
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub BindGrid3()
        Dim query As String
        query = "SELECT * FROM cards WHERE card_type='" & ComboBox1.Text & "'"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        'DataGridView1.ColumnCount = 5
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "card_type"
                        DataGridView1.Columns(0).HeaderText = "Card Type"
                        DataGridView1.Columns(0).DataPropertyName = "bcard_type"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "card_no"
                        DataGridView1.Columns(1).HeaderText = "Card No."
                        DataGridView1.Columns(1).DataPropertyName = "card_no"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "card_remark"
                        DataGridView1.Columns(2).HeaderText = "Remark"
                        DataGridView1.Columns(2).DataPropertyName = "card_remark"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False

                        DataGridView1.Columns(3).Name = "card_ID"
                        DataGridView1.Columns(3).HeaderText = "ID"
                        DataGridView1.Columns(3).DataPropertyName = "card_ID"
                        DataGridView1.Columns(3).ReadOnly = True
                        DataGridView1.Columns(3).Resizable = False
                        DataGridView1.Columns(3).Visible = False

                        DataGridView1.Columns(4).Name = "card_active"
                        DataGridView1.Columns(4).HeaderText = "Active"
                        DataGridView1.Columns(4).DataPropertyName = "card_active"
                        DataGridView1.Columns(4).ReadOnly = True
                        DataGridView1.Columns(4).Resizable = False
                        DataGridView1.Columns(4).Visible = False

                        DataGridView1.DataSource = dt
                        If dt.Rows.Count = 0 Then
                            MsgBox("No Record Found!")
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.ConnectionString = ServerString
        If CheckBox1.Checked = False Then
            If ComboBox1.Text = "All" Then
                DataGridView1.DataSource = Nothing
                BindGrid0()
            Else
                DataGridView1.DataSource = Nothing
                BindGrid1()
            End If
        Else
            If ComboBox1.Text = "All" Then
                DataGridView1.DataSource = Nothing
                BindGrid2()
            Else
                DataGridView1.DataSource = Nothing
                BindGrid3()
            End If
        End If

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim editcard As New card_edit
        editcard.MdiParent = MainMDI

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            If editcard Is Nothing Then
                editcard = New card_edit
            Else
                editcard.Close()
                editcard = New card_edit
            End If
            editcard.Card_ID.Text = row.Cells("card_ID").Value.ToString
            editcard.MdiParent = MainMDI
            editcard.Show()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting

        For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
            If Me.DataGridView1.Rows(i).Cells("card_active").Value = 0 Then
                Me.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed
            End If
        Next

    End Sub
End Class