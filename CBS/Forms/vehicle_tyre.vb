Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class vehicle_tyre
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand

    Private Sub vehicle_tyre_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        Dim query
        Dim fltyredate As Date
        Dim rltyredate As Date
        Dim frtyredate As Date
        Dim rrtyredate As Date
        Dim rlityredate As Date
        Dim rrityredate As Date
        vehicle_display.Enabled = False
        Button2.Visible = False

        query = "SELECT * FROM vehicle_acce_info WHERE vhcacc_vhcID = '" & tyre_vhcID.Text & "'"

        conn.Open()
        cmd = New MySqlCommand(query, conn)
        db = cmd.ExecuteReader()
        While db.Read()
            tyre_flbrand.Text = db.Item("vhcacc_tyre_flbrand").ToString
            tyre_frbrand.Text = db.Item("vhcacc_tyre_frbrand").ToString
            tyre_rlbrand.Text = db.Item("vhcacc_tyre_rlbrand").ToString
            tyre_rrbrand.Text = db.Item("vhcacc_tyre_rrbrand").ToString
            '----------------------------------------------------------
            tyre_rlibrand.Text = db.Item("vhcacc_tyre_rlibrand").ToString
            tyre_rribrand.Text = db.Item("vhcacc_tyre_rribrand").ToString

            mfdfltyre.Text = db.Item("vhcacc_tyre_fltyre").ToString
            mfdfrtyre.Text = db.Item("vhcacc_tyre_frtyre").ToString
            mfdrltyre.Text = db.Item("vhcacc_tyre_rltype").ToString
            mfdrrtyre.Text = db.Item("vhcacc_tyre_rrtype").ToString
            '------------------------------------------------------
            mfdrlityre.Text = db.Item("vhcacc_tyre_rlitype").ToString
            mfdrrityre.Text = db.Item("vhcacc_tyre_rritype").ToString

            fltyredate = db.Item("vhcacc_tyre_fldate")
            rltyredate = db.Item("vhcacc_tyre_rldate")
            frtyredate = db.Item("vhcacc_tyre_frdate")
            rrtyredate = db.Item("vhcacc_tyre_rrdate")
            '-----------------------------------------
            rlityredate = db.Item("vhcacc_tyre_rlidate")
            rrityredate = db.Item("vhcacc_tyre_rridate")
        End While
        conn.Close()

        If fltyredate.ToString = "0000-00-00" Then
            flDateTimePicker.Value = Date.Today.ToShortDateString
            'Else
            '    flDateTimePicker.Value = fltyredate.ToString("yyyy-MM-dd")
        End If

        If rltyredate.ToString = "0000-00-00" Then
            rlDateTimePicker.Value = Date.Today.ToShortDateString
            'Else
            '    rlDateTimePicker.Value = rltyredate.ToString("yyyy-MM-dd")
        End If

        If frtyredate.ToString = "0000-00-00" Then
            frDateTimePicker.Value = Date.Today.ToShortDateString
            'Else
            '    frDateTimePicker.Value = frtyredate.ToString("yyyy-MM-dd")
        End If

        If rrtyredate.ToString = "0000-00-00" Then
            rrDateTimePicker.Value = Date.Today.ToShortDateString
            'Else
            '    rrDateTimePicker.Value = rrtyredate.ToString("yyyy-MM-dd")
        End If
        '--------------------------------------------------------------------------
        If rlityredate.ToString = "0000-00-00" Then
            rlDateTimePicker.Value = Date.Today.ToShortDateString
            'Else
            '    rlDateTimePicker.Value = rltyredate.ToString("yyyy-MM-dd")
        End If

        If rrityredate.ToString = "0000-00-00" Then
            rrDateTimePicker.Value = Date.Today.ToShortDateString
            'Else
            '    rrDateTimePicker.Value = rrtyredate.ToString("yyyy-MM-dd")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim updateaccefl As String
        Dim updateaccerl As String
        Dim updateaccefr As String
        Dim updateaccerr As String
        Dim updateaccerli As String
        Dim updateaccerri As String

        updateaccefl = "UPDATE vehicle_acce_info SET vhcacc_tyre_fldate='" & flDateTimePicker.Value.ToString("yyyy-MM-dd") & "',vhcacc_tyre_fltype='" & mfdfltyre.Text & "',vhcacc_tyre_flbrand='" & tyre_flbrand.Text & "' WHERE vhcacc_vhcID= '" & tyre_vhcID.Text & "'"
        updateaccerl = "UPDATE vehicle_acce_info SET vhcacc_tyre_rldate='" & rlDateTimePicker.Value.ToString("yyyy-MM-dd") & "',vhcacc_tyre_rltype='" & mfdrltyre.Text & "',vhcacc_tyre_rlbrand='" & tyre_rlbrand.Text & "' WHERE vhcacc_vhcID= '" & tyre_vhcID.Text & "'"
        updateaccefr = "UPDATE vehicle_acce_info SET vhcacc_tyre_frdate='" & frDateTimePicker.Value.ToString("yyyy-MM-dd") & "',vhcacc_tyre_frtype='" & mfdfrtyre.Text & "',vhcacc_tyre_frbrand='" & tyre_frbrand.Text & "' WHERE vhcacc_vhcID= '" & tyre_vhcID.Text & "'"
        updateaccerr = "UPDATE vehicle_acce_info SET vhcacc_tyre_rrdate='" & rrDateTimePicker.Value.ToString("yyyy-MM-dd") & "',vhcacc_tyre_rrtype='" & mfdrrtyre.Text & "',vhcacc_tyre_rrbrand='" & tyre_rrbrand.Text & "' WHERE vhcacc_vhcID= '" & tyre_vhcID.Text & "'"
        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        updateaccerli = "UPDATE vehicle_acce_info SET vhcacc_tyre_rlidate='" & rliDateTimePicker.Value.ToString("yyyy-MM-dd") & "',vhcacc_tyre_rlitype='" & mfdrlityre.Text & "',vhcacc_tyre_rlibrand='" & tyre_rlibrand.Text & "' WHERE vhcacc_vhcID= '" & tyre_vhcID.Text & "'"
        updateaccerri = "UPDATE vehicle_acce_info SET vhcacc_tyre_rridate='" & rriDateTimePicker.Value.ToString("yyyy-MM-dd") & "',vhcacc_tyre_rritype='" & mfdrrityre.Text & "',vhcacc_tyre_rribrand='" & tyre_rribrand.Text & "' WHERE vhcacc_vhcID= '" & tyre_vhcID.Text & "'"


        If GroupBox1.Enabled = False Then
            InsertRcd(updateaccefl)
        End If
        If GroupBox2.Enabled = False Then
            InsertRcd(updateaccefr)
        End If
        If GroupBox3.Enabled = False Then
            InsertRcd(updateaccerl)
        End If
        If GroupBox4.Enabled = False Then
            InsertRcd(updateaccerr)
        End If
        '----------------------------------------
        If GroupBox5.Enabled = False Then
            InsertRcd(updateaccerri)
        End If
        If GroupBox6.Enabled = False Then
            InsertRcd(updateaccerli)
        End If

        Me.Close()
        vehicle_display.Enabled = True
        vehicle_display.Button6.Focus()
    End Sub

    Public Sub InsertRcd(ByRef SQLStatement As String)
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim updfltyre As String
        updfltyre = "INSERT INTO vhcacc_tyre_history(vhcacc_tyreh_vhcID,vhcacc_tyreh_tyreChg,vhcacc_tyreh_brand,vhcacc_tyreh_mfgdt,	vhcacc_tyreh_tyreloc)" _
        + "VALUE('" & tyre_vhcID.Text & "','" & flDateTimePicker.Value.ToString("yyyy-MM-dd") & "','" & tyre_flbrand.Text & "','" & mfdfltyre.Text & "','Front Left')"
        InsertRcd(updfltyre)
        GroupBox1.Enabled = False
        Button2.Visible = True
        Button6.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim updrltyre As String
        updrltyre = "INSERT INTO vhcacc_tyre_history(vhcacc_tyreh_vhcID,vhcacc_tyreh_tyreChg,vhcacc_tyreh_brand,vhcacc_tyreh_mfgdt,	vhcacc_tyreh_tyreloc)" _
        + "VALUE('" & tyre_vhcID.Text & "','" & rlDateTimePicker.Value.ToString("yyyy-MM-dd") & "','" & tyre_rlbrand.Text & "','" & mfdrltyre.Text & "','Rear Left')"
        InsertRcd(updrltyre)
        GroupBox3.Enabled = False
        Button2.Visible = True
        Button6.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim updfrtyre As String
        updfrtyre = "INSERT INTO vhcacc_tyre_history(vhcacc_tyreh_vhcID,vhcacc_tyreh_tyreChg,vhcacc_tyreh_brand,vhcacc_tyreh_mfgdt,	vhcacc_tyreh_tyreloc)" _
        + "VALUE('" & tyre_vhcID.Text & "','" & frDateTimePicker.Value.ToString("yyyy-MM-dd") & "','" & tyre_frbrand.Text & "','" & mfdfrtyre.Text & "','Front Right')"
        InsertRcd(updfrtyre)
        GroupBox2.Enabled = False
        Button2.Visible = True
        Button6.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim updrrtyre As String
        updrrtyre = "INSERT INTO vhcacc_tyre_history(vhcacc_tyreh_vhcID,vhcacc_tyreh_tyreChg,vhcacc_tyreh_brand,vhcacc_tyreh_mfgdt,	vhcacc_tyreh_tyreloc)" _
        + "VALUE('" & tyre_vhcID.Text & "','" & rrDateTimePicker.Value.ToString("yyyy-MM-dd") & "','" & tyre_rrbrand.Text & "','" & mfdrrtyre.Text & "','Rear Right')"
        InsertRcd(updrrtyre)
        GroupBox4.Enabled = False
        Button2.Visible = True
        Button6.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        vehicle_display.Enabled = True
        vehicle_display.Button6.Focus()
    End Sub

    Private Sub ButtonRLI_Click(sender As Object, e As EventArgs) Handles ButtonRLI.Click
        Dim updrlityre As String
        updrlityre = "INSERT INTO vhcacc_tyre_history(vhcacc_tyreh_vhcID,vhcacc_tyreh_tyreChg,vhcacc_tyreh_brand,vhcacc_tyreh_mfgdt, vhcacc_tyreh_tyreloc)" _
        + "VALUE('" & tyre_vhcID.Text & "','" & rliDateTimePicker.Value.ToString("yyyy-MM-dd") & "','" & tyre_rlibrand.Text & "','" & mfdrlityre.Text & "','Rear Left Inner')"
        InsertRcd(updrlityre)
        GroupBox6.Enabled = False
        Button2.Visible = True
        Button6.Visible = False
    End Sub

    Private Sub ButtonRRI_Click(sender As Object, e As EventArgs) Handles ButtonRRI.Click
        Dim updrrityre As String
        updrrityre = "INSERT INTO vhcacc_tyre_history(vhcacc_tyreh_vhcID,vhcacc_tyreh_tyreChg,vhcacc_tyreh_brand,vhcacc_tyreh_mfgdt,	vhcacc_tyreh_tyreloc)" _
        + "VALUE('" & tyre_vhcID.Text & "','" & rriDateTimePicker.Value.ToString("yyyy-MM-dd") & "','" & tyre_rribrand.Text & "','" & mfdrrityre.Text & "','Rear Right Inner')"
        InsertRcd(updrrityre)
        GroupBox5.Enabled = False
        Button2.Visible = True
        Button6.Visible = False
    End Sub
End Class