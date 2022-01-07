Imports MySql.Data.MySqlClient
Public Class card_manage
    Dim ServerString As String = "server=192.168.1.32;user id=root;port=3306;database=CBS;logging=True;allowbatch=False;allowuservariables=True;password=edp#8888;persistsecurityinfo=True;Convert Zero Datetime=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub card_manage_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        DateTimePicker1.Text = Date.Now.ToString
        bkc_issueby_text.Text = MainMDI.display_name.Text
        BindGrid0()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.ConnectionString = ServerString
        DataGridView1.DataSource = Nothing
        cardNo_ComboBox.SelectedItem = Nothing
        bkc_ID_text.Text = ""
        bkc_bkID_text.Text = ""
        bkc_PlateNo_text.Text = ""
        bkc_Type_text.Text = ""
        BindGrid0()
    End Sub

    Private Sub bkc_Type_TextChanged(sender As Object, e As EventArgs) Handles bkc_Type_text.TextChanged

        Dim findcard As String
        findcard = "SELECT card_no FROM cards LEFT OUTER JOIN cards_status ON (card_ID = cstatus_cardID) WHERE card_type = '" & bkc_Type_text.Text & "' AND cstatus_status = '0'"

        Using conn2 As MySqlConnection = New MySqlConnection(ServerString)
                conn2.Open()
                Using cmd2 As MySqlCommand = New MySqlCommand(findcard, conn2)
                    Dim db2 As MySqlDataReader = cmd2.ExecuteReader
                    Dim dt2 As DataTable = New DataTable
                dt2.Load(db2)
                If bkc_Type_text.Text = "" Then
                    cardNo_ComboBox.DataSource = Nothing
                Else
                    cardNo_ComboBox.ValueMember = "card_no"
                    cardNo_ComboBox.DisplayMember = "card_no"
                    cardNo_ComboBox.DataSource = dt2
                End If
            End Using
                conn2.Close()
            End Using

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim updcardbooking As String
        Dim updcardstatus As String
        updcardbooking = "UPDATE booking_card SET bkc_cID='" & card_ID.Text & "',bkc_issueby='" & bkc_issueby_text.Text & "', bkc_collected ='1', bkc_taken='" & DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") & "' WHERE bkc_ID = '" & bkc_ID_text.Text & "'"
        updcardstatus = "UPDATE cards_status SET cstatus_status='1' WHERE cstatus_cardID = '" & card_ID.Text & "'"

        If cardNo_ComboBox.Text = Nothing Then
            MsgBox("Please select and Card No to processed.")
        Else
            If MsgBox("Confirm issue " & bkc_Type_text.Text & " card(no:" & cardNo_ComboBox.Text & ") for Booking no : " & bkc_bkID_text.Text & "", MsgBoxStyle.YesNo, "Confirm Save") = MsgBoxResult.Yes Then
                updatercd(updcardbooking)
                updatercd(updcardstatus)
                MsgBox("Card booking Save.")
                Button1.PerformClick()
            End If
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Public Sub BindGrid0()
        Dim query As String
        query = "SELECT * FROM booking_card WHERE bkc_collected='0'"
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
        Dim connB As New MySqlConnection
        connB.ConnectionString = ServerString
        Dim dbB As MySqlDataReader
        Dim cmdB As MySqlCommand = New MySqlCommand
        Dim loadbkcard As String
        loadbkcard = "SELECT * FROM booking_card WHERE bkc_id = '" & bkc_ID_text.Text & "'"
        connB.Open()
        cmdB = New MySqlCommand(loadbkcard, connB)
        dbB = cmdB.ExecuteReader

        While dbB.Read()
            bkc_bkID_text.Text = dbB.Item("bkc_bkid")
            bkc_PlateNo_text.Text = dbB.Item("bkc_vhcplate")
            bkc_Type_text.Text = dbB.Item("bkc_bkctype")
        End While
        connB.Close()
    End Sub

    Private Sub cardNo_ComboBox_TextChanged(sender As Object, e As EventArgs) Handles cardNo_ComboBox.TextChanged
        Dim connA As New MySqlConnection
        connA.ConnectionString = ServerString

        Dim getcardID As String
        getcardID = "SELECT card_ID FROM cards WHERE card_no='" & cardNo_ComboBox.Text & "'"

        connA.Open()
        Try
            cmd = New MySqlCommand(getcardID, connA)
            db = cmd.ExecuteReader

            While db.Read()
                card_ID.Text = db.Item("card_ID")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        connA.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim updcancelcard As String
        updcancelcard = "UPDATE booking_card SET bkc_collected ='3',bkc_complete='2',bkc_rejectby='" & bkc_issueby_text.Text & "' WHERE bkc_ID = '" & bkc_ID_text.Text & "'"

        If MsgBox("Confirm update card request for Booking no : " & bkc_bkID_text.Text & " as 'No Card'?", MsgBoxStyle.YesNo, "Confirm Save") = MsgBoxResult.Yes Then
            updatercd(updcancelcard)
            MsgBox("Card booking request Canceled. Reason='No Card'")
            Button1.PerformClick()
        End If

    End Sub

End Class