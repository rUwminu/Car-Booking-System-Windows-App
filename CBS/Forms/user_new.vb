Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class user_new
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim usrstatus As Integer

    Private Sub user_new_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        DateTimePicker1.Text = Date.Now.ToShortDateString
        cr_date.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        usrstatus = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FullName.Text = "" Or ShortName.Text = "" Or emp_ID.Text = "" Or dept.Text = "" Or lvl_text.Text = "" Then
            MsgBox("Please complete all required fields.(*)")
        Else
            Dim savercd As String
            savercd = "INSERT INTO users(usr_name,usr_shortname,usr_username,usr_password,usr_datecreate,usr_employeeID,usr_department,usr_email,usr_active,usr_level,note)" _
                + "VALUES('" & FullName.Text & "','" & ShortName.Text & "','" & UsrName.Text & "','" & passwrd.Text & "','" & cr_date.Text & "','" & emp_ID.Text & "','" & dept.Text & "','" & email.Text & "','" & usrstatus & "','" & usr_lvl.Text & "','" & usr_note.Text & "');"
            insertRcd(savercd)
            MsgBox("Record have been added.")
            GroupBox1.Enabled = False
            Me.Close()
        End If
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

    Private Sub user_new_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If GroupBox1.Enabled = False Then
            e.Cancel = False
        Else
            If MsgBox("Your Record still not save, are your sure to exit?", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub lvl_text_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvl_text.SelectedIndexChanged
        If lvl_text.Text = "Administrator" Then
            usr_lvl.Text = 0
        Else
            If lvl_text.Text = "User" Then
                usr_lvl.Text = 2
            Else
                If lvl_text.Text = "Approval - Management" Then
                    usr_lvl.Text = 1
                ElseIf lvl_text.Text = "Approval - Admin" Then
                    usr_lvl.Text = 1
                ElseIf lvl_text.Text = "Approval - Production" Then
                    usr_lvl.Text = 1
                End If
            End If
        End If
    End Sub

    Private Sub usr_catselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles usr_catselect.SelectedIndexChanged
        If usr_catselect.Text = "Office" Then
            usr_category.Text = "1"
        Else
            If usr_catselect.Text = "Management" Then
                usr_category.Text = "1"
            Else
                If usr_catselect.Text = "Production" Then
                    usr_category.Text = "1"
                End If
            End If
        End If
    End Sub
End Class