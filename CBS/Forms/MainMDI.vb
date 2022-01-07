Imports System.ComponentModel
Imports System.Windows.Forms
Public Class MainMDI
    Dim mdichildsec As New security_main
    Dim mdichild As New DisplayMenu
    Dim rightchild As New Show_Expiry

    Private Sub MainMDI_Load(sender As Object, e As EventArgs) Handles Me.Load
        mdichildsec.MdiParent = Me
        mdichild.MdiParent = Me
        rightchild.MdiParent = Me
        mdichild.Show()

        Application.DoEvents()
        mdichild.Location = New Point(Me.Width / 3.5 - mdichild.Width / 3.5, Me.Height / 2 - mdichild.Height / 2)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Are you comfirm to Exit", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Dim newlogin As New Login
        newlogin.Show()
    End Sub

    Private Sub EditUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUserToolStripMenuItem.Click
        Dim mdichild As New user_display
        mdichild.MdiParent = Me
        mdichild.Show()
        'Application.DoEvents()
        'mdichild.Location = New Point(Me.Width / 2 - mdichild.Width / 2, Me.Height / 2 - mdichild.Height / 2)
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim changepass As New main_chgpass
        changepass.MdiParent = Me
        changepass.Show()
    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        Dim newuser As New user_newchk
        newuser.MdiParent = Me
        newuser.Show()
    End Sub

    Private Sub NewVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewVehicleToolStripMenuItem.Click
        Dim newvehicle As New vehicle_add
        newvehicle.MdiParent = Me
        newvehicle.Show()
    End Sub

    Private Sub EditVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditVehicleToolStripMenuItem.Click
        Dim viewvehicle As New vehicle_display
        viewvehicle.MdiParent = Me
        viewvehicle.Show()
    End Sub

    Private Sub SecurityCheckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecurityCheckToolStripMenuItem.Click
        Dim securitychk As New security_main
        securitychk.MdiParent = Me
        securitychk.Show()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click

        DisplayMenu.MdiParent = Me
        DisplayMenu.Show()

        Application.DoEvents()
        DisplayMenu.Location = New Point(Me.Width / 2 - DisplayMenu.Width / 2, Me.Height / 2 - DisplayMenu.Height / 2)

    End Sub

    Private Sub display_lvl_TextChanged(sender As Object, e As EventArgs) Handles display_lvl.TextChanged
        If display_lvl.Text = "4" Then
            mdichildsec.Show()
            mdichild.Hide()
        End If
    End Sub

    Private Sub BookingSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingSummaryToolStripMenuItem.Click
        Dim bookingsum As New booking_summary
        bookingsum.MdiParent = Me
        bookingsum.Show()
    End Sub

    Private Sub SecurityCheckReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecurityCheckReportToolStripMenuItem.Click
        Dim secreport As New Report_Security
        secreport.MdiParent = Me
        secreport.Show()
    End Sub

    Private Sub AddNewCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewCardToolStripMenuItem.Click
        Dim newcard As New card_new
        newcard.MdiParent = Me
        newcard.Show()
    End Sub

    Private Sub IssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueToolStripMenuItem.Click
        Dim issuecard As New card_manage
        issuecard.MdiParent = Me
        issuecard.Show()
    End Sub

    Private Sub RetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetToolStripMenuItem.Click
        Dim returncard As New card_manage_return
        returncard.MdiParent = Me
        returncard.Show()
    End Sub

    Private Sub DisplayCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayCardToolStripMenuItem.Click
        Dim showcard As New card_display
        showcard.MdiParent = Me
        showcard.Show()
    End Sub

    Private Sub KeyStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeyStatusToolStripMenuItem.Click
        Dim viewkeystatus As New key_status_view
        viewkeystatus.MdiParent = Me
        viewkeystatus.Show()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub KeyRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeyRecordToolStripMenuItem.Click
        Dim viewkeyrecord As New key_borrow_list
        viewkeyrecord.MdiParent = Me
        viewkeyrecord.Show()
    End Sub

    Private Sub Display_lvl_TxtChange(sender As Object, e As EventArgs) Handles display_lvl.TextChanged
        If (display_lvl.Text = "0" Or display_lvl.Text = "1") Then
            rightchild.Show()
            rightchild.Label2.Text = display_lvl.Text
            rightchild.Location = New Point(Me.Width / 1.5 - mdichild.Width / 1.5, Me.Height / 3.2 - mdichild.Height / 3)
        End If
    End Sub
End Class
