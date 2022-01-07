Imports MySql.Data.MySqlClient
Public Class card_manage_return
    Dim ServerString As String = "server=192.168.1.32;user id=root;port=3306;database=CBS;logging=True;allowbatch=False;allowuservariables=True;password=edp#8888;persistsecurityinfo=True;Convert Zero Datetime=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim datetaken As Date


    Private Sub card_manage_return_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        DateTimePicker1.Text = DateTime.Now.ToString
        bkc_receiveby_text.Text = MainMDI.display_name.Text
        BindGrid0()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.ConnectionString = ServerString
        DataGridView1.DataSource = Nothing
        bkc_ID_text.Text = ""
        bkc_bkID_text.Text = ""
        bkc_PlateNo_text.Text = ""
        bkc_Type_text.Text = ""
        bkc_datetaken_text.Text = ""
        bkc_cardno_text.Text = ""
        BindGrid0()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim updcardbooking As String
        Dim updcardstatus As String
        updcardbooking = "UPDATE booking_card SET bkc_collected='2', bkc_receiveby='" & bkc_receiveby_text.Text & "', bkc_complete='1', bkc_return='" & DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") & "' WHERE bkc_ID = '" & bkc_ID_text.Text & "'"
        updcardstatus = "UPDATE cards_status SET cstatus_status='0' WHERE cstatus_cardID = '" & card_ID.Text & "'"

        If MsgBox("Confirm card received for Booking no : " & bkc_bkID_text.Text & "", MsgBoxStyle.YesNo, "Confirm Save") = MsgBoxResult.Yes Then
            updatercd(updcardbooking)
            updatercd(updcardstatus)
            Button1.PerformClick()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Public Sub BindGrid0()
        Dim query As String
        query = "SELECT * FROM booking_card WHERE bkc_collected='1'"
        Using conn As New MySqlConnection(ServerString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.CommandType = CommandType.Text
                Using sda As New MySqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.AutoGenerateColumns = False
                        'DataGridView1.ColumnCount = 3
                        DataGridView1.ReadOnly = True

                        DataGridView1.Columns(0).Name = "bkc_bkid"
                        DataGridView1.Columns(0).HeaderText = "Booking"
                        DataGridView1.Columns(0).DataPropertyName = "bkc_bkid"
                        DataGridView1.Columns(0).ReadOnly = True
                        DataGridView1.Columns(0).Resizable = False

                        DataGridView1.Columns(1).Name = "bkc_bkctype"
                        DataGridView1.Columns(1).HeaderText = "Card Type"
                        DataGridView1.Columns(1).DataPropertyName = "bkc_bkctype"
                        DataGridView1.Columns(1).ReadOnly = True
                        DataGridView1.Columns(1).Resizable = False

                        DataGridView1.Columns(2).Name = "bkc_id"
                        DataGridView1.Columns(2).HeaderText = "ID"
                        DataGridView1.Columns(2).DataPropertyName = "bkc_id"
                        DataGridView1.Columns(2).ReadOnly = True
                        DataGridView1.Columns(2).Resizable = False
                        DataGridView1.Columns(2).Visible = False

                        DataGridView1.DataSource = dt
                        'If dt.Rows.Count = 0 Then
                        'MsgBox("No Record Found!")
                        'End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            bkc_ID_text.Text = row.Cells("bkc_id").Value.ToString
        End If

    End Sub

    Private Sub bkc_ID_text_TextChanged(sender As Object, e As EventArgs) Handles bkc_ID_text.TextChanged
        Dim loadbkcard As String
        loadbkcard = "SELECT * FROM booking_card WHERE bkc_id = '" & bkc_ID_text.Text & "'"
        conn.Open()
        cmd = New MySqlCommand(loadbkcard, conn)
        db = cmd.ExecuteReader

        While db.Read
            bkc_bkID_text.Text = db.Item("bkc_bkid")
            bkc_PlateNo_text.Text = db.Item("bkc_vhcplate")
            bkc_Type_text.Text = db.Item("bkc_bkctype")
            datetaken = db.Item("bkc_taken")
            card_ID.Text = db.Item("bkc_cID")
        End While
        conn.Close()
    End Sub

    Private Sub card_ID_TextChanged(sender As Object, e As EventArgs) Handles card_ID.TextChanged
        Dim conn2 As MySqlConnection = New MySqlConnection
        Dim db2 As MySqlDataReader
        Dim cmd2 As MySqlCommand = New MySqlCommand
        conn2.ConnectionString = ServerString
        Dim findcard As String
        findcard = "SELECT card_no FROM cards WHERE card_ID = '" & card_ID.Text & "'"

        conn2.Open()
        Try
            cmd2 = New MySqlCommand(findcard, conn2)
            db2 = cmd2.ExecuteReader

            While db2.Read()
                bkc_cardno_text.Text = db2.Item("card_no")
            End While
            conn2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bkc_datetaken_text.Text = datetaken.ToString("dd/MM/yyyy hh:mm tt")
    End Sub
End Class