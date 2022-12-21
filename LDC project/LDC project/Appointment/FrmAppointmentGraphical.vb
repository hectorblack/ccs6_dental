Imports IBM.Data.DB2
Imports System.Data

Public Class FrmAppointmentGraphical

    Private Conn As Common.DbConnection

    Private Sub FrmAppointmentGraphical_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
            Conn.Open()

            DGVPatient.EnableHeadersVisualStyles = False
            DGVPatient.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 58, 64)
            DGVPatient.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DGVPatient.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGVreminders.EnableHeadersVisualStyles = False
            DGVreminders.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 58, 64)
            DGVreminders.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DGVreminders.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Call refresh_DGV()
            Call PopulateTreatmentBox()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub PopulateTreatmentBox()

        treatmenttextbox.Items.Clear()
        Dim RdrDrg As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String

        SelectStr = "select * from treatment"
        cmdRetrieve = New DB2Command(SelectStr, Conn)
        RdrDrg = cmdRetrieve.ExecuteReader

        While RdrDrg.Read
            row = RdrDrg.GetString(1).ToString
            treatmenttextbox.Items.Add(row)
        End While

        RdrDrg.Close()

    End Sub

    Private Sub Graphviewbutton_Click(sender As Object, e As EventArgs) Handles Graphviewbutton.Click
        Editbutton.Visible = False
        Graphviewbutton.BackColor = Color.Gray
        Graphviewbutton.ForeColor = Color.White
        addwindow.Visible = False
        Graphview.Visible = True

        Listviewbutton.ForeColor = Color.White
        Listviewbutton.BackColor = Color.Indigo
        DGVPatient.Visible = False

        Call refreshDGVreminders()
    End Sub

    Private Sub Listviewbutton_Click(sender As Object, e As EventArgs) Handles Listviewbutton.Click
        Editbutton.Visible = True

        DGVPatient.Visible = True

        Listviewbutton.BackColor = Color.Gray
        Listviewbutton.ForeColor = Color.White

        addwindow.Visible = False
        Graphview.Visible = False

        Graphviewbutton.BackColor = Color.White
        Graphviewbutton.BackColor = Color.Indigo

        Call refresh_DGV()
    End Sub

    Private Sub Addbutton_Click(sender As Object, e As EventArgs) Handles Addbutton.Click
        Try
            Editbutton.Visible = False
            Addbutton.Visible = False
            Graphviewbutton.Visible = False
            Listviewbutton.Visible = False

            Graphview.Visible = False
            DGVPatient.Visible = False

            Patientname.AllowDrop = True
            Patientname.Enabled = True
            addeditlabel.Text = "Add Appointment"
            addwindow.Visible = True
            Patientname.Text = ""
            Timebox.Text = ""
            treatmenttextbox.Text = ""

            Call PopulateName()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub PopulateName()

        Try
            Patientname.Items.Clear()
            Dim editRdr As DB2DataReader
            Dim editcmdRetrieve As DB2Command
            Dim camand As String

            camand = "select lastname,firstname from patient"
            editcmdRetrieve = New DB2Command(camand, Conn)
            editRdr = editcmdRetrieve.ExecuteReader

            While editRdr.Read
                Patientname.Items.Add(editRdr.GetDB2String(0).ToString & " " & editRdr.GetDB2String(1).ToString)
            End While

            editRdr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub Editbutton_Click(sender As Object, e As EventArgs) Handles Editbutton.Click
        Try
            If Listviewbutton.Visible = True Then
                addeditlabel.Text = "Edit Appointment"
                addwindow.Visible = True
                DGVPatient.Visible = False

                Listviewbutton.Visible = False
                Graphviewbutton.Visible = False

                Dim editRdr As DB2DataReader
                Dim editcmdRetrieve As DB2Command
                Dim camand As String
                Dim updatecamand As String

                Patientname.AllowDrop = False
                Patientname.Enabled = False
                camand = "select lastname, firstname, aptime, treatment from appoint_patient, patient where appoint_patient.patientnumber=patient.patientnumber and apid='" & apptboxid.Text & "'"
                editcmdRetrieve = New DB2Command(camand, Conn)
                editRdr = editcmdRetrieve.ExecuteReader

                While editRdr.Read
                    temptext.Visible = True
                    temptext.Text = editRdr.GetDB2String(0).ToString & " " & editRdr.GetDB2String(1).ToString
                    Timebox.Text = editRdr.GetDB2String(2).ToString
                    treatmenttextbox.Text = editRdr.GetDB2String(3).ToString
                End While

                editRdr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cancelbutton_Click(sender As Object, e As EventArgs) Handles cancelbutton.Click
        addwindow.Visible = False
        Listviewbutton.BackColor = Color.Gray
        Listviewbutton.ForeColor = Color.White
        Graphview.Visible = False


        Graphviewbutton.BackColor = Color.White
        Graphviewbutton.BackColor = Color.Indigo
        DGVPatient.Visible = True
        addwindow.Visible = False

        Addbutton.Visible = True
        Graphviewbutton.Visible = True
        Listviewbutton.Visible = True
        Editbutton.Visible = True
    End Sub

    Private Sub refresh_DGV()
        Try

            Dim Rdr As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim listviewcomm As String
            Dim row As String()

            DGVPatient.ColumnCount = 6

            With DGVPatient
                .Columns(0).Name = "Appointment ID"
                .Columns(1).Name = "Lastname"
                .Columns(2).Name = "Firstname"
                .Columns(3).Name = "Date"
                .Columns(4).Name = "Time"
                .Columns(5).Name = "Treatment"
            End With
            listviewcomm = "select apid,lastname,firstname, apdate, aptime, treatment  from  appointment,appoint_patient,patient where appointment.appointmentid=appoint_patient.appointmentid and appoint_patient.patientnumber=patient.patientnumber"
            cmdRetrieve = New DB2Command(listviewcomm, Conn)
            Rdr = cmdRetrieve.ExecuteReader

            Me.DGVPatient.Rows.Clear()

            While Rdr.Read
                row = New String() {Rdr.GetString(0), Rdr.GetString(1), Rdr.GetString(2), Rdr.GetString(3), Rdr.GetString(4), Rdr.GetString(5)}
                DGVPatient.Rows.Add(row)
            End While
            Rdr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DGVPatient_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVPatient.MouseUp
        Me.apptboxid.Text = DGVPatient.CurrentRow.Cells(0).Value()
        Editbutton.Enabled = True
    End Sub

    Private Sub savebutton_Click(sender As Object, e As EventArgs) Handles savebutton.Click
        Try
            Dim StrUpdate As String
            Dim cammand As String
            Dim CmdUpdate As DB2Command
            Dim appid As String
            Dim Rdr As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim times As String
            Dim treatmert As String
            Dim app2id As String
            Dim patientid As String



            If addeditlabel.Text = "Edit Appointment" Then
                appid = apptboxid.Text
                StrUpdate = "update appoint_patient set aptime = '" & Timebox.Text & "', treatment = '" & treatmenttextbox.Text & "' where apid='" & appid & "'"
                CmdUpdate = New DB2Command(StrUpdate, Conn)
                CmdUpdate.ExecuteNonQuery()
                MsgBox("Record was updated successfully...")
            End If

            If addeditlabel.Text = "Add Appointment" Then
                cammand = "select * from appoint_patient where appointmentid = (select max(appointmentid) from appoint_patient)"
                CmdUpdate = New DB2Command(cammand, Conn)
                Rdr = CmdUpdate.ExecuteReader
                While Rdr.Read
                    appid = Rdr.GetDB2String(0).ToString
                    app2id = Rdr.GetDB2String(1).ToString
                End While
                Rdr.Close()
                Dim lastnem As String = Patientname.Text.Substring(0, Patientname.Text.IndexOf(" "))
                Dim firstnem As String = Patientname.Text.Substring(Patientname.Text.IndexOf(" ") + 1)
                cammand = "select patientnumber from patient where lastname='" & lastnem & "' and firstname='" & firstnem & "'"
                CmdUpdate = New DB2Command(cammand, Conn)
                Rdr = CmdUpdate.ExecuteReader
                While Rdr.Read
                    patientid = Rdr.GetDB2String(0).ToString
                End While
                Rdr.Close()
                appid = "0" & Convert.ToString(Convert.ToInt32(appid) + 1)
                app2id = "0" & Convert.ToString(Convert.ToInt32(app2id) + 1)

                cammand = "insert into appointment values ('" & app2id & "')"
                CmdUpdate = New DB2Command(cammand, Conn)
                CmdUpdate.ExecuteNonQuery()
                cammand = "insert into appoint_patient values ('" & appid & "', '" & app2id & "', '" & patientid & "', '" & MonthCalendar2.SelectionRange.Start.ToString("yyyy-MM-dd") & "', '" & Timebox.Text & "', '" & treatmenttextbox.Text & "')"
                CmdUpdate = New DB2Command(cammand, Conn)
                CmdUpdate.ExecuteNonQuery()
                MsgBox("Successfully added Appointment!")
                addwindow.Visible = False
            End If

            Call refresh_DGV()



            Listviewbutton.BackColor = Color.Gray
            Listviewbutton.ForeColor = Color.White
            Graphview.Visible = False

            Graphviewbutton.BackColor = Color.White
            Graphviewbutton.BackColor = Color.Indigo
            DGVPatient.Visible = True
            addwindow.Visible = False
            temptext.Visible = False

            Addbutton.Visible = True
            Graphviewbutton.Visible = True
            Listviewbutton.Visible = True
            Editbutton.Visible = True

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub refreshDGVreminders()
        Try
            Dim Rdr As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim listviewcomm As String
            Dim row As String()
            Dim selecteddate As String = GVcalendar.SelectionRange.Start.ToString("yyyy-MM-dd")

            listviewcomm = "select apid, aptime, treatment  from  appoint_patient where appoint_patient.apdate='" & selecteddate & "'"
            cmdRetrieve = New DB2Command(listviewcomm, Conn)
            Rdr = cmdRetrieve.ExecuteReader

            Me.DGVreminders.Rows.Clear()

            If Rdr.HasRows Then
                While Rdr.Read
                    row = New String() {Rdr.GetString(0), Rdr.GetString(1), Rdr.GetString(2)}
                    DGVreminders.Rows.Add(row)
                End While
                Rdr.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GVcalendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles GVcalendar.DateChanged
        Call refreshDGVreminders()
    End Sub

    Private Sub DGVreminders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVreminders.CellContentClick
        Try
            Dim Rdr As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim listviewcomm As String
            Dim name As String
            Dim treatment As String
            Dim time As String

            listviewcomm = "select firstname, lastname, aptime, apdate, treatment  from  appoint_patient, patient where patient.patientnumber=appoint_patient.patientnumber and appoint_patient.apid='" & DGVreminders.CurrentRow.Cells(0).Value() & "'"
            cmdRetrieve = New DB2Command(listviewcomm, Conn)
            Rdr = cmdRetrieve.ExecuteReader

            Me.DGVreminders.Rows.Clear()

            If Rdr.HasRows Then
                While Rdr.Read
                    reminderboxgraph.Text = "Reminders:" & vbNewLine & "Name: " & Rdr.GetString(1) & " " & Rdr.GetString(0) & vbNewLine & "Time and Date: " & Rdr.GetString(3) & " " & Rdr.GetString(2) & vbNewLine & "Treatment: " & Rdr.GetString(4)
                End While
                Rdr.Close()
            End If
            Call refreshDGVreminders()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    

End Class
