Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class vehicle_add
    Dim ServerString As String = "server=192.168.98.253;user id=root;port=3306;database=cbsbak;logging=True;allowbatch=False;allowuservariables=True;password=teo788;persistsecurityinfo=True"
    Dim conn As MySqlConnection = New MySqlConnection
    Dim db As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim picpath As String
    Dim vehicle_found As Boolean = False

    Dim getDate = Date.Now.ToShortDateString
    Dim roadtxdate As Date
    Dim insuransdate As Date
    Dim timeexpired As String

    Public Sub NewvhcID()
        conn.Open()
        Dim dbquery As String
        dbquery = "SELECT vhc_ID FROM vehicle ORDER BY vhc_ID"
        cmd = New MySqlCommand(dbquery, conn)
        db = cmd.ExecuteReader
        While db.Read
            lastID.Text = db.Item("vhc_ID") + 1
        End While
        conn.Close()
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

    Private Sub vehicle_add_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn.ConnectionString = ServerString
        DateTimePicker1.Text = Date.Now.ToShortDateString
        vdate.Text = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        GroupBox1.Enabled = False
        NewvhcID() 'get current vehicle ID and add info to other table
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OFD1.InitialDirectory = "c:\"
        OFD1.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png"
        OFD1.ShowDialog()
        picpath = OFD1.FileName
        picloc.Text = picpath
        LBP1.ImageLocation = picpath
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LBP1.Image = Nothing
        picloc.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim fs As FileStream
        Dim br As BinaryReader
        Try

            If vbrand.Text = "" Or vmodel.Text = "" Or vrddate.Text = "" Or vtype.Text = "" Or insdate.Text = "" Then
                MsgBox("Please complete all required fields. (*)")
            Else
                If Not picloc.Text = "" Then
                    Dim FileName As String = picloc.Text
                    Dim imgdata() As Byte

                    fs = New FileStream(FileName, FileMode.Open, FileAccess.Read)
                    br = New BinaryReader(fs)
                    imgdata = br.ReadBytes(CType(fs.Length, Integer))
                    br.Close()
                    fs.Close()

                    Dim savercd As String
                    savercd = "INSERT INTO vehicle(vhc_PlateNo,vhc_brand,vhc_model,vhc_type,vhc_img,vhc_year,vhc_roadtax,vhc_insurance,vhc_note,vhc_datecreate)" _
                + "VALUES(@vhc_PlateNo,@vhc_brand,@vhc_model,@vhc_type,@vhc_img,@vhc_year,@vhc_roadtax,@vhc_insurance,@vhc_note,@vhc_datecreate);"

                    cmd = New MySqlCommand(savercd, conn)

                    cmd.Parameters.Add("@vhc_PlateNo", MySqlDbType.VarChar, 10)
                    cmd.Parameters.Add("@vhc_brand", MySqlDbType.VarChar, 20)
                    cmd.Parameters.Add("@vhc_model", MySqlDbType.VarChar, 30)
                    cmd.Parameters.Add("@vhc_type", MySqlDbType.VarChar, 30)
                    cmd.Parameters.Add("@vhc_img", MySqlDbType.LongBlob)
                    cmd.Parameters.Add("@vhc_year", MySqlDbType.VarChar, 10)
                    cmd.Parameters.Add("@vhc_roadtax", MySqlDbType.Date)
                    cmd.Parameters.Add("@vhc_insurance", MySqlDbType.Date)
                    cmd.Parameters.Add("@vhc_note", MySqlDbType.Text)
                    cmd.Parameters.Add("@vhc_datecreate", MySqlDbType.Date)

                    cmd.Parameters("@vhc_PlateNo").Value = plateNo.Text
                    cmd.Parameters("@vhc_brand").Value = vbrand.Text
                    cmd.Parameters("@vhc_model").Value = vmodel.Text
                    cmd.Parameters("@vhc_type").Value = vtype.Text
                    cmd.Parameters("@vhc_img").Value = imgdata
                    cmd.Parameters("@vhc_year").Value = vyear.Text
                    cmd.Parameters("@vhc_roadtax").Value = vrddate.Text
                    cmd.Parameters("@vhc_insurance").Value = insdate.Text
                    cmd.Parameters("@vhc_note").Value = vnote.Text
                    cmd.Parameters("@vhc_datecreate").Value = vdate.Text

                    conn.Open()
                    Dim RowEffected As Integer = cmd.ExecuteNonQuery()
                    If (RowEffected >= 0) Then
                        MsgBox("Record save sucessfully.")
                        conn.Close()
                        'Insert vhcID record into vehicle_status
                        Dim addrcd As String
                        addrcd = "INSERT INTO vehicle_status(vhcstatus_vhcID) VALUES ('" & lastID.Text & "');"
                        InsertRcd(addrcd)

                        'Insert vhcID record into vehicle_accessories
                        Dim addacceinfo As String
                        addacceinfo = "INSERT INTO vehicle_acce_info(vhcacc_vhcID) VALUES ('" & lastID.Text & "');"
                        InsertRcd(addacceinfo)

                        If vtype.Text = "Lorry" Then
                            Dim addinspect As String
                            addinspect = "INSERT INTO lorry_inspection(vhcinsp_vhcID, vhcinsp_inspection) VALUES ('" & lastID.Text & "', '" & inspectdate.Text & "');"
                            InsertRcd(addinspect)
                        End If

                        cls(GroupBox1)
                        LBP1.Image = Nothing
                        GroupBox1.Enabled = False
                        plateNo.ReadOnly = False
                        plateNo.Text = ""
                        plateNo.Focus()
                    End If
                Else
                    Dim savercd As String
                    savercd = "INSERT INTO vehicle(vhc_PlateNo,vhc_brand,vhc_model,vhc_type,vhc_year,vhc_roadtax,vhc_insurance,vhc_note,vhc_datecreate,vhc_category)" _
                + "VALUES(@vhc_PlateNo,@vhc_brand,@vhc_model,@vhc_type,@vhc_year,@vhc_roadtax,@vhc_insurance,@vhc_note,@vhc_datecreate,@vhc_category);"

                    cmd = New MySqlCommand(savercd, conn)

                    cmd.Parameters.Add("@vhc_PlateNo", MySqlDbType.VarChar, 10)
                    cmd.Parameters.Add("@vhc_brand", MySqlDbType.VarChar, 20)
                    cmd.Parameters.Add("@vhc_model", MySqlDbType.VarChar, 30)
                    cmd.Parameters.Add("@vhc_type", MySqlDbType.VarChar, 30)
                    cmd.Parameters.Add("@vhc_year", MySqlDbType.VarChar, 10)
                    cmd.Parameters.Add("@vhc_roadtax", MySqlDbType.Date)
                    cmd.Parameters.Add("@vhc_insurance", MySqlDbType.Date)
                    cmd.Parameters.Add("@vhc_note", MySqlDbType.Text)
                    cmd.Parameters.Add("@vhc_datecreate", MySqlDbType.Date)
                    cmd.Parameters.Add("@vhc_category", MySqlDbType.VarChar, 3)


                    cmd.Parameters("@vhc_PlateNo").Value = plateNo.Text
                    cmd.Parameters("@vhc_brand").Value = vbrand.Text
                    cmd.Parameters("@vhc_model").Value = vmodel.Text
                    cmd.Parameters("@vhc_type").Value = vtype.Text
                    cmd.Parameters("@vhc_year").Value = vyear.Text
                    cmd.Parameters("@vhc_roadtax").Value = vrddate.Text
                    cmd.Parameters("@vhc_insurance").Value = insdate.Text
                    cmd.Parameters("@vhc_note").Value = vnote.Text
                    cmd.Parameters("@vhc_datecreate").Value = vdate.Text
                    cmd.Parameters("@vhc_category").Value = vhc_category.Text


                    conn.Open()
                    Dim RowEffected As Integer = cmd.ExecuteNonQuery()
                    If (RowEffected >= 0) Then
                        MsgBox("Record save sucessfully.")
                        conn.Close()


                        'Insert vhcID record into vehicle_status
                        Dim addrcd As String
                        addrcd = "INSERT INTO vehicle_status(vhcstatus_vhcID) VALUES ('" & lastID.Text & "');"
                        InsertRcd(addrcd)

                        'Insert vhcID record into vehicle_accessories
                        Dim addacceinfo As String
                        addacceinfo = "INSERT INTO vehicle_acce_info(vhcacc_vhcID) VALUES ('" & lastID.Text & "');"
                        InsertRcd(addacceinfo)

                        If vtype.Text = "Lorry" Then
                            Dim addinspect As String
                            addinspect = "INSERT INTO lorry_inspection(vhcinsp_vhcID, vhcinsp_inspection) VALUES ('" & lastID.Text & "', '" & inspectdate.Text & "');"
                            InsertRcd(addinspect)
                        End If

                        cls(GroupBox1) 'clear all textbox
                        LBP1.Image = Nothing
                        GroupBox1.Enabled = False
                        plateNo.ReadOnly = False
                        plateNo.Text = ""
                        plateNo.Focus()
                        vhc_catselect.SelectedItem = Nothing
                        vtype.SelectedItem = Nothing
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        vrddate.Text = DateTimePicker2.Value.ToString("yyyy-MM-dd")
        roadtxdate = DateTimePicker2.Value.ToShortDateString

        ''-----------------------------------------------------------
        timeexpired = DateDiff(DateInterval.Day, getDate, roadtxdate)
        LabelLeftDate.Text = timeexpired.ToString()
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        insdate.Text = DateTimePicker3.Value.ToString("yyyy-MM-dd")
        insuransdate = DateTimePicker3.Value.ToShortDateString
    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker4.ValueChanged
        inspectdate.Text = DateTimePicker4.Value.ToString("yyyy-MM-dd")
    End Sub

    Public Function vhcexist(ByVal usr As String) As Boolean
        conn.Open()
        Dim flag2 As Integer = 0
        Dim query2 As String = "select vhc_PlateNo from vehicle"
        cmd = New MySqlCommand(query2, conn)
        db = cmd.ExecuteReader
        While db.Read
            If usr = db.Item("vhc_PlateNo") Then
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If plateNo.Text = "" Then
            MsgBox("Please fill up your Vehicle Registration / Plate No.")
            plateNo.Focus()
        Else
            vehicle_found = vhcexist(plateNo.Text)
            If vehicle_found = False Then
                GroupBox1.Enabled = True
                plateNo.ReadOnly = True
                NewvhcID() 'get current vehicle ID and add info to other table
            Else
                MsgBox("Registration/Plate No. exist, please try another no.")
                plateNo.Text = ""
                plateNo.Focus()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If GroupBox1.Enabled = False Then
            Me.Close()
        Else
            If MsgBox("Your Record still not save, are your sure to cancel?", MsgBoxStyle.YesNo, "Confirm Exit") = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Public Sub cls(ByRef obj As Control)
        Dim obj1 As Control
        For Each obj1 In obj.Controls
            If TypeOf obj1 Is TextBox Then
                obj1.Text = ""
            End If
        Next
    End Sub

    Private Sub vhc_catselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vhc_catselect.SelectedIndexChanged
        If vhc_catselect.Text = "Admin" Then
            vhc_category.Text = "1"
        Else
            If vhc_catselect.Text = "Management" Then
                vhc_category.Text = "2"
            Else
                If vhc_catselect.Text = "Production" Then
                    vhc_category.Text = "3"
                End If
            End If
        End If
    End Sub

    Private Sub Vtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vtype.SelectedIndexChanged
        If vtype.Text = "Lorry" Then
            Label18.Visible = True
            Label19.Visible = True
            DateTimePicker4.Visible = True
            inspectdate.Visible = True
        Else
            Label18.Visible = False
            Label19.Visible = False
            DateTimePicker4.Visible = False
            inspectdate.Visible = False
        End If
    End Sub
End Class