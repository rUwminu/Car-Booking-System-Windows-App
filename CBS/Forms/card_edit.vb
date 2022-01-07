Imports MySql.Data.MySqlClient
Public Class card_edit
    Dim ServerString As String = "server=192.168.1.32;user id=root;port=3306;database=CBS;logging=True;allowbatch=False;allowuservariables=True;password=edp#8888;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub card_edit_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "ACTIVE"
            card_active.Text = "1"
        Else
            CheckBox1.Text = "OBSOLETE"
            card_active.Text = "0"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "ACTIVE"
            card_active.Text = "1"
        Else
            CheckBox1.Text = "OBSOLETE"
            card_active.Text = "0"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Card_ID_TextChanged(sender As Object, e As EventArgs) Handles Card_ID.TextChanged
        conn.ConnectionString = ServerString
        Dim loadcard As String
        loadcard = "SELECT * FROM cards WHERE card_ID = '" & Card_ID.Text & "'"
        conn.Open()
        cmd = New MySqlCommand(loadcard, conn)
        db = cmd.ExecuteReader

        While db.Read
            card_type.Text = db.Item("card_type")
            Card_no.Text = db.Item("card_no")
            Card_remark.Text = db.Item("card_remark")
            card_active.Text = db.Item("card_active")
        End While
        conn.Close()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim updcard As String
        updcard = "UPDATE cards SET card_no='" & Card_no.Text & "',card_remark='" & Card_remark.Text & "',card_active='" & card_active.Text & "' WHERE card_ID='" & Card_ID.Text & "'"
        If Card_no.Text = "" Then
            MsgBox("Card Number cannot be BLANK.")
        Else
            updatercd(updcard)
            MsgBox("Record updated.")
            Me.Close()
        End If
    End Sub

    Private Sub card_active_TextChanged(sender As Object, e As EventArgs) Handles card_active.TextChanged
        If card_active.Text = 0 Then
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
        End If
    End Sub
End Class