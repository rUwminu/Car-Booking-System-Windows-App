Imports MySql.Data.MySqlClient
Public Class card_new
    Dim ServerString As String = "server=192.168.1.32;user id=root;port=3306;database=CBS;logging=True;allowbatch=False;allowuservariables=True;password=edp#8888;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim datecreate As Date = Date.Today.ToString
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.ConnectionString = ServerString
        Dim savecard As String
        Dim addcstatus As String
        savecard = "INSERT INTO cards(card_ID,card_type,card_no,card_remark,card_datecreate)VALUES('" & card_ID.Text & "','" & card_type_combo.Text & "','" & card_no.Text & "','" & card_remark.Text & "','" & datecreatetext.Text & "');"
        addcstatus = "INSERT INTO cards_status(cstatus_cardID)VALUES('" & card_ID.Text & "');"
        If card_type_combo.Text = Nothing Or card_no.Text = "" Then
            MsgBox("Card type or Card No cannot BLANK")
        Else
            insertRcd(savecard)
            insertRcd(addcstatus)
            MsgBox("New " & card_type_combo.Text & " Card have been save.")

            card_type_combo.Text = Nothing
            card_no.Text = Nothing
            card_remark.Text = Nothing
            CardID()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Sub insertRcd(ByRef SQLStatement As String)
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

    Public Sub CardID()

        conn.Open()
        Dim query As String
        query = "SELECT card_ID FROM cards ORDER BY card_ID"
        cmd = New MySqlCommand(query, conn)
        db = cmd.ExecuteReader

        While db.Read

            card_ID.Text = db.Item("card_ID") + 1

        End While
        conn.Close()

    End Sub

    Private Sub card_new_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        CardID()
        datecreatetext.Text = datecreate.ToString("yyyy-MM-dd")
    End Sub
End Class