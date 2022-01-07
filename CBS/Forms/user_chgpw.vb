Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class user_chgpw
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim loginsucess As Boolean = False

    Private Sub user_chgpw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CBSDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.CBSDataSet.users)
        conn.ConnectionString = ServerString
    End Sub

    'Private Sub LabelusrID_Click(sender As Object, e As EventArgs) Handles LabelusrID.TextChanged
    '    conn.ConnectionString = ServerString
    '    conn.Open()
    '    Dim upquery As String = "SELECT usr_username FROM users WHERE usr_ID = '" & LabelusrID.Text & "'"

    '    cmd = New MySqlCommand(upquery, conn)
    '    db = cmd.ExecuteReader
    '    Try
    '        While db.Read
    '            loginsucess = True
    '            Usr_usernameTextBox.Text = db.Item("usr_username")
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    conn.Close()
    '    conn.Dispose()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NewPass.Text <> VeNewPass.Text Then
            MsgBox("New Password didn't match")
            NewPass.Text = ""
            VeNewPass.Text = ""
            NewPass.Focus()
        Else
            If Not NewPass.Text = "" Or Not VeNewPass.Text = "" Then
                Dim updateUsr As String
                updateUsr = "UPDATE users SET usr_password = '" & NewPass.Text & "' WHERE usr_ID = '" & LabelusrID.Text & "'"
                savepass(updateUsr)
                MsgBox("Password sucessful change, please use new password on next login")
                Me.Close()
            Else
                MsgBox("Please fill all require field.")
            End If
        End If
    End Sub
    Public Sub savepass(ByRef SQLStatement As String)
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


End Class