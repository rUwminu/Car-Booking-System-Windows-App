Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class user_newchk
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim user_found As Boolean = False

    Private Sub user_newchk_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If usrname.Text = "" Or pass1.Text = "" Or pass2.Text = "" Then
            MsgBox("Please complete all field.")
        ElseIf pass1.Text <> pass2.Text Then
            MsgBox("Password not match, please try again")
            pass1.Text = ""
            pass2.Text = ""
            pass1.Focus()
        Else
            user_found = userexist(usrname.Text)
            If user_found = False Then
                user_new.MdiParent = MainMDI
                user_new.Show()
                user_new.UsrName.Text = usrname.Text
                user_new.passwrd.Text = pass1.Text
                Me.Hide()
            Else
                MsgBox("User Name exist, please try another Name")
            End If
        End If
    End Sub

    Public Function userexist(ByVal usr As String) As Boolean
        conn.Open()
        Dim flag2 As Integer = 0
        Dim query2 As String = "select usr_username from users"
        cmd = New MySqlCommand(query2, conn)
        db = cmd.ExecuteReader
        While db.Read
            If usr = db.Item("usr_username") Then
                flag2 = 1
            End If
        End While
        conn.Close()
        conn.Dispose()
        If flag2 = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class