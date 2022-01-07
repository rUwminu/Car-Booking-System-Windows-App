Imports System.IO
Imports Microsoft.Reporting.WinForms
Public Class bookingprint

    Private Sub bookingprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CBSDataSet.bkslip' table. You can move, or remove it, as needed.
        'Me.bkslipTableAdapter.Fillby(Me.CBSDataSet.bkslip)
        'Me.ReportViewer1.RefreshReport()

    End Sub

    Public Shared Sub GetbookingSlip(ByVal BookingID As String)
        bookingprint.bkslipTableAdapter.Fillby(bookingprint.CBSDataSet.bkslip, BookingID)
        bookingprint.ReportViewer1.RefreshReport()
    End Sub
End Class