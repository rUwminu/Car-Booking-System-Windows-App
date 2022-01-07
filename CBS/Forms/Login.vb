Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Login
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim user_exist As Boolean = False

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        Login_pcnameTextBox.Text = System.Windows.Forms.SystemInformation.ComputerName
        Login_pcusrTextBox.Text = getUserName()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim shortname As String = ""
        Dim usrlvl As String = ""
        Dim usrID As String = ""
        Dim usrEmpID As String = ""
        Dim loginsucess As Boolean = False
        If usrtext.Text = "" Or passtext.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conn.Open()
            Dim useractive As String = 0
            Dim upquery As String = "SELECT * FROM users WHERE (usr_username = '" & usrtext.Text & "') AND (BINARY usr_password = '" & passtext.Text & "')"
            cmd = New MySqlCommand(upquery, conn)
            db = cmd.ExecuteReader

            Try
                While db.Read
                    loginsucess = True
                    Login_usrnameTextBox.Text = db("usr_username").ToString
                    shortname = db("usr_shortname").ToString
                    usrID = db("usr_ID").ToString
                    usrlvl = db("usr_level").ToString
                    usrEmpID = db("usr_employeeID").ToString
                    If useractive = db.Item("usr_active") Then
                        MsgBox("Sorry, User deactivated, please contact EDP", MsgBoxStyle.OkOnly, "Invalid Login")
                        loginsucess = False
                    Else
                        Continue While
                    End If
                End While

                'User Level Here
                If loginsucess = True Then
                    MainMDI.Show()
                    MainMDI.display_lvl.Text = usrlvl
                    MainMDI.display_name.Text = shortname
                    MainMDI.usr_id_label.Text = usrID
                    MainMDI.LabelEmpID.Text = usrEmpID

                    conn.Close()
                    Me.Hide()

                    Dim savercd As String
                    savercd = "INSERT INTO login_log(login_usrname,login_pcusr,login_pcname) VALUES('" & Login_usrnameTextBox.Text & "','" & Login_pcusrTextBox.Text & "','" & Login_pcnameTextBox.Text & "');"
                    insertlog(savercd)

                    'Item hide base on User lvl
                    'User lvl 0 and 1 have every permission
                    If usrlvl = 3 Then
                        MainMDI.NewUserToolStripMenuItem.Visible = False
                        MainMDI.EditUserToolStripMenuItem.Visible = False
                        MainMDI.CardControlToolStripMenuItem.Visible = False
                        MainMDI.ManageCardToolStripMenuItem.Visible = False
                        MainMDI.VehicalToolStripMenuItem.Visible = False
                        MainMDI.SecurityCheckToolStripMenuItem.Visible = False
                        MainMDI.ReportToolStripMenuItem.Visible = False
                        MainMDI.KeyStatusToolStripMenuItem.Visible = False
                    End If

                Else
                    MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Login")
                    usrtext.Text = ""
                    passtext.Text = ""
                    usrtext.Focus()
                    conn.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Function getUserName() As String
        If TypeOf My.User.CurrentPrincipal Is
      Security.Principal.WindowsPrincipal Then
            ' The application is using Windows authentication.
            ' The name format is DOMAIN\USERNAME.
            Dim parts() As String = Split(My.User.Name, "\")
            Dim username As String = parts(1)
            Return username
        Else
            ' The application is using custom authentication.
            Return My.User.Name
        End If
    End Function
    Public Sub insertlog(ByRef SQLStatement As String)
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

    Private Sub passtext_KeyDown(sender As Object, e As KeyEventArgs) Handles passtext.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub usrtext_KeyDown(sender As Object, e As KeyEventArgs) Handles usrtext.KeyDown
        If e.KeyCode = Keys.Enter Then
            passtext.Focus()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim filereader As String
        filereader = My.Computer.FileSystem.ReadAllText("\\192.168.1.32\cbs\CBS\ReleaseNote.txt")
        MsgBox(filereader)
    End Sub
End Class