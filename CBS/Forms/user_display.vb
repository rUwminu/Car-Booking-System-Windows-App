Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class user_display
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim actvalue As Integer

    Private Sub UsersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Button1.PerformClick()
    End Sub

    Private Sub user_display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CBSDataSet.users' table. You can move, or remove it, as needed.
        Try
            Me.UsersTableAdapter.Fill(Me.CBSDataSet.users)
        Catch ex As Exception

        End Try

        conn.ConnectionString = ServerString
        Usr_datecreateDateTimePicker.Enabled = False
        UsersBindingNavigatorSaveItem.Enabled = False
        ToolStripchgpass.Enabled = False
        Button4.Visible = False
        Button2.Enabled = True
        Button1.Enabled = False
        usr_lvlselect.Visible = False
        usr_catselect.Visible = False
        Usr_departmentTextBox.Visible = False
        GroupBox1.Enabled = False

        If Usr_activeCheckBox.Checked = True Then
            Usr_activeCheckBox.Text = "Active"
            actvalue = 1
        Else
            Usr_activeCheckBox.Text = "Inactive"
            actvalue = 0
        End If

        If Usr_levelTextBox.Text = "0" Then
            lvldisplay.Text = "Administrator"
        Else
            If Usr_levelTextBox.Text = "1" Then
                lvldisplay.Text = "User"
            Else
                If Usr_levelTextBox.Text = "2" Then
                    lvldisplay.Text = "Approval - Management"
                Else
                    If Usr_levelTextBox.Text = "3" Then
                        lvldisplay.Text = "Supervisor (Vehicle Manage)"
                    Else
                        If Usr_levelTextBox.Text = "4" Then
                            lvldisplay.Text = "Security / Guard"
                        Else
                            If Usr_levelTextBox.Text = "5" Then
                                lvldisplay.Text = "Approval - Admin"
                            Else
                                If Usr_levelTextBox.Text = "6" Then
                                    lvldisplay.Text = "Approval - Production"
                                Else
                                    If Usr_levelTextBox.Text = "7" Then
                                        lvldisplay.Text = "Admin(Card Control)"
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If Usr_categoryTextBox.Text = "1" Then
            category.Text = "Office"
        Else
            If Usr_categoryTextBox.Text = "2" Then
                category.Text = "Management"
            Else
                If Usr_categoryTextBox.Text = "3" Then
                    category.Text = "Production"
                End If
            End If
        End If

    End Sub

    Public Sub displayusers()

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            TabControl1.SelectedTab = TabPage1
            Usr_IDTextBox.Text = row.Cells("usr_ID").Value.ToString
        End If
    End Sub

    Private Sub Usr_levelTextBox_TextChanged(sender As Object, e As EventArgs) Handles Usr_levelTextBox.TextChanged
        If Usr_levelTextBox.Text = "0" Then
            lvldisplay.Text = "Administrator"
            usr_lvlselect.Text = "Administrator"
        Else
            If Usr_levelTextBox.Text = "1" Then
                lvldisplay.Text = "User"
                usr_lvlselect.Text = "User"
            Else
                If Usr_levelTextBox.Text = "2" Then
                    lvldisplay.Text = "Approval - Management"
                    usr_lvlselect.Text = "Approval - Management"
                Else
                    If Usr_levelTextBox.Text = "3" Then
                        lvldisplay.Text = "Supervisor (Vehicle Manage)"
                        usr_lvlselect.Text = "Supervisor (Vehicle Manage)"
                    Else
                        If Usr_levelTextBox.Text = "4" Then
                            lvldisplay.Text = "Security / Guard"
                            usr_lvlselect.Text = "Security / Guard"
                        Else
                            If Usr_levelTextBox.Text = "5" Then
                                lvldisplay.Text = "Approval - Admin"
                                usr_lvlselect.Text = "Approval - Admin"
                            Else
                                If Usr_levelTextBox.Text = "6" Then
                                    lvldisplay.Text = "Approval - Production"
                                    usr_lvlselect.Text = "Approval - Production"
                                Else
                                    If Usr_levelTextBox.Text = "7" Then
                                        lvldisplay.Text = "Admin(Card Control)"
                                        usr_lvlselect.Text = "Admin(Card Control)"
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Usr_activeCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles Usr_activeCheckBox.CheckStateChanged

        If Usr_activeCheckBox.Checked = True Then
            Usr_activeCheckBox.Text = "Active"
            actvalue = 1
        Else
            Usr_activeCheckBox.Text = "Inactive"
            actvalue = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        GroupBox1.Enabled = True
        Usr_departmentTextBox.Visible = True
        Usr_departmentTextBox1.Visible = False
        usr_lvlselect.Visible = True
        lvldisplay.Visible = False
        usr_catselect.Visible = True
        category.Visible = False

        UsersBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorMoveFirstItem.Enabled = False
        BindingNavigatorMoveLastItem.Enabled = False
        BindingNavigatorMoveNextItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
        ToolStripchgpass.Enabled = True
        Button4.Visible = True
        Button2.Enabled = False
        Button1.Enabled = True
        TabControl1.TabPages(1).Enabled = False

        Label2Usrn.Text = Usr_usernameTextBox.Text
        Label2ID.Text = Usr_IDTextBox.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim updateUsr As String
        updateUsr = "UPDATE users SET " _
            + "usr_name ='" & Usr_nameTextBox.Text & "'," _
            + "usr_shortname ='" & Usr_shortnameTextBox.Text & "'," _
            + "usr_employeeID ='" & Usr_employeeIDTextBox.Text & "'," _
            + "usr_department ='" & Usr_departmentTextBox.Text & "'," _
            + "usr_email ='" & Usr_emailTextBox.Text & "'," _
            + "usr_active ='" & actvalue & "'," _
            + "usr_level ='" & Usr_levelTextBox.Text & "'," _
            + "usr_category ='" & Usr_categoryTextBox.Text & "'," _
            + "note ='" & NoteTextBox.Text & "' WHERE usr_ID = '" & Usr_IDTextBox.Text & "'"

        updatercd(updateUsr)

        GroupBox1.Enabled = False
        Usr_departmentTextBox.Visible = False
        Usr_departmentTextBox1.Visible = True
        usr_lvlselect.Visible = False
        usr_catselect.Visible = False
        category.Visible = True
        lvldisplay.Visible = True

        UsersBindingNavigatorSaveItem.Enabled = False
        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMoveLastItem.Enabled = True
        BindingNavigatorMoveNextItem.Enabled = True
        BindingNavigatorMovePreviousItem.Enabled = True
        ToolStripchgpass.Enabled = False
        Button2.Enabled = True
        Button1.Enabled = False
        Button4.Visible = False

        TabControl1.TabPages(1).Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If GroupBox1.Enabled = False Then
            Me.Close()
        Else
            If MsgBox("Your Record still not save, are your sure to exit?", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.Yes Then
                GroupBox1.Enabled = False
                Me.Close()
            End If
        End If
    End Sub

    Private Sub user_display_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If GroupBox1.Enabled = False Then
            e.Cancel = False
        Else
            If MsgBox("Your Record still not save, are your sure to exit?", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ToolStripchgpass_Click(sender As Object, e As EventArgs) Handles ToolStripchgpass.Click
        Dim uid As String = Usr_IDTextBox.Text
        Dim chgusrpass As New user_chgpw
        chgusrpass.MdiParent = MainMDI

        If chgusrpass Is Nothing Then
            chgusrpass = New user_chgpw
        Else
            chgusrpass.Close()
            chgusrpass = New user_chgpw
        End If
        chgusrpass.Usr_usernameTextBox.Text = Label2Usrn.Text
        chgusrpass.LabelusrID.Text = Label2ID.Text
        chgusrpass.Show()
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

    Private Sub usr_lvlselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles usr_lvlselect.SelectedIndexChanged
        If usr_lvlselect.Text = "Administrator" Then
            Usr_levelTextBox.Text = "0"
        Else
            If usr_lvlselect.Text = "User" Then
                Usr_levelTextBox.Text = "1"
            Else
                If usr_lvlselect.Text = "Approval - Management" Then
                    Usr_levelTextBox.Text = "2"
                Else
                    If usr_lvlselect.Text = "Supervisor (Vehicle Manage)" Then
                        Usr_levelTextBox.Text = "3"
                    Else
                        If usr_lvlselect.Text = "Security / Guard" Then
                            Usr_levelTextBox.Text = "4"
                        Else
                            If usr_lvlselect.Text = "Approval - Admin" Then
                                Usr_levelTextBox.Text = "5"
                            Else
                                If usr_lvlselect.Text = "Approval - Production" Then
                                    Usr_levelTextBox.Text = "6"
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Usr_categoryTextBox_TextChanged(sender As Object, e As EventArgs) Handles Usr_categoryTextBox.TextChanged
        If Usr_categoryTextBox.Text = "1" Then
            category.Text = "Office"
            usr_catselect.Text = "Office"
        Else
            If Usr_categoryTextBox.Text = "2" Then
                category.Text = "Management"
                usr_catselect.Text = "Management"
            Else
                If Usr_categoryTextBox.Text = "3" Then
                    category.Text = "Production"
                    usr_catselect.Text = "Production"
                End If
            End If
        End If
    End Sub

    Private Sub usr_catselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles usr_catselect.SelectedIndexChanged
        If usr_catselect.Text = "Office" Then
            Usr_categoryTextBox.Text = "1"
        Else
            If usr_catselect.Text = "Management" Then
                Usr_categoryTextBox.Text = "2"
            Else
                If usr_catselect.Text = "Production" Then
                    Usr_categoryTextBox.Text = "3"
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox1.Enabled = False
        TabControl1.TabPages(1).Enabled = True

        Me.Controls.Clear()
        InitializeComponent()
        user_display_Load(e, e)

    End Sub
End Class