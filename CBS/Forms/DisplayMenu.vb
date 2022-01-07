Public Class DisplayMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        booking_new.MdiParent = MainMDI
        booking_new.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        booking_display.MdiParent = MainMDI
        booking_display.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class