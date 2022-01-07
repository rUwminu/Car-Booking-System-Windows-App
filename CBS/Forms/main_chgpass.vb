Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class main_chgpass
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub main_chgpass_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString

        Dim loginsucess As Boolean = False
        conn.Open()
        Dim upquery As String = "SELECT * FROM users WHERE (usr_ID = '" & MainMDI.usr_id_label.Text & "')"
        cmd = New MySqlCommand(upquery, conn)
        db = cmd.ExecuteReader
        Try
            While db.Read
                loginsucess = True
                Usr_passwordTextBox.Text = db.Item("usr_password")
                Usr_usernameTextBox.Text = db.Item("usr_username")
                Usr_IDTextBox.Text = db.Item("usr_ID")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CurrPass.Text <> Usr_passwordTextBox.Text Then
            MsgBox("Invalid Current Password")
            CurrPass.Text = ""
            NewPass.Text = ""
            VeNewPass.Text = ""
            CurrPass.Focus()
        Else
            If NewPass.Text <> VeNewPass.Text Then
                MsgBox("New Password didn't match")
                NewPass.Text = ""
                VeNewPass.Text = ""
                NewPass.Focus()
            Else
                If Not CurrPass.Text = "" Or Not NewPass.Text = "" Or Not VeNewPass.Text = "" Then
                    Dim updateUsr As String
                    updateUsr = "UPDATE CBS.users SET usr_password = '" & NewPass.Text & "' WHERE usr_ID = '" & Usr_IDTextBox.Text & "'"
                    savepass(updateUsr)
                    MsgBox("Password sucessful change, please use new password on next login")
                    Me.Close()
                End If
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