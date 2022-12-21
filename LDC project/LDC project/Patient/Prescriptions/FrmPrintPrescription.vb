Imports IBM.Data.DB2
Public Class FrmPrintPrescription
    Private Conn As Common.DbConnection

    Private Sub FrmPrintPrescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin")
        Conn.Open()

        Call Me.PrintLay()
    End Sub

    Private Sub PrintLay()
        Try
            Dim Rdr As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String

            Dim PresNum As String
            Dim PatientID As String

            Dim fname As String
            Dim mname As String
            Dim lname As String
            Dim sex As String
            Dim address As String
            Dim bday As String
            Dim wdate As String
            Dim edate As String
            Dim drugtype As String
            Dim drugname As String
            Dim dispense As String
            Dim refill As String
            Dim rxins As String
            Dim patins As String
            Dim dentname As String
            Dim dlicense As String
            Dim ptr As String
            Dim dentadd As String
            Dim dentphone As String

            Dim age As String

            PresNum = Me.txtPrescriptNumber.Text
            PatientID = Me.txtPatientID.Text
            'PresNum = "03210003"
            'PatientID = "01210004"

            SelectStr = "select firstname,middlename,lastname,sex,address,birthdate,writtendate,expiredate,drugtype,drugname,dispense,refills,rxins,patientins,dentistname,licensenumber,ptrnumber,dentaddress,dentphonenumber from patient,prescription, dentist where dentist.dentistid=prescription.dentistid and prescription.prescriptnumber = '" & PresNum & "' and patient.patientnumber='" & PatientID & "' "
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            Rdr = cmdRetrieve.ExecuteReader

            Dim isNull As Boolean
            Dim valtemp10 As String
            Dim valtemp11 As String
            Dim valtemp12 As String
            Dim valtemp13 As String

            While Rdr.Read

                isNull = Rdr.IsDBNull(10)
                If (isNull) Then
                    valtemp10 = " "
                Else
                    valtemp10 = Rdr.GetString(10)
                End If

                isNull = Rdr.IsDBNull(11)
                If (isNull) Then
                    valtemp11 = " "
                Else
                    valtemp11 = Rdr.GetString(11)
                End If

                isNull = Rdr.IsDBNull(12)
                If (isNull) Then
                    valtemp12 = " "
                Else
                    valtemp12 = Rdr.GetString(12)
                End If

                isNull = Rdr.IsDBNull(13)
                If (isNull) Then
                    valtemp13 = " "
                Else
                    valtemp13 = Rdr.GetString(13)
                End If

                fname = Rdr.GetString(0)
                mname = Rdr.GetString(1)
                lname = Rdr.GetString(2)
                sex = Rdr.GetString(3)
                address = Rdr.GetString(4)
                bday = Rdr.GetString(5)
                wdate = Rdr.GetString(6)
                edate = Rdr.GetString(7)
                drugtype = Rdr.GetString(8)
                drugname = Rdr.GetString(9)
                dispense = valtemp10
                refill = valtemp11
                rxins = valtemp12
                patins = valtemp13
                dentname = Rdr.GetString(14)
                dlicense = Rdr.GetString(15)
                ptr = Rdr.GetString(16)
                dentadd = Rdr.GetString(17)
                dentphone = Rdr.GetString(18)
            End While

            Dim PaName As String
            PaName = fname + " " + mname + " " + lname

            Rdr.Close()

            TxtPrint.Text = ""
            TxtPrint.AppendText(vbTab + vbTab + vbTab & dentname & "'s clinic" + vbNewLine)
            TxtPrint.AppendText(vbTab + vbTab & dentadd + vbNewLine)
            TxtPrint.AppendText(vbTab + vbTab & vbTab & "   " & dentphone + vbNewLine)
            TxtPrint.AppendText("" + vbNewLine)
            TxtPrint.AppendText(vbTab + "---------------------------------------------------------------------" + vbNewLine)
            TxtPrint.AppendText("" + vbNewLine)
            TxtPrint.AppendText(" Patient Name : " & PaName + vbNewLine)
            TxtPrint.AppendText(" Sex : " & sex + vbNewLine)
            TxtPrint.AppendText(" Age : " + vbNewLine)
            TxtPrint.AppendText(" Address : " & address + vbNewLine)

            TxtPrint.AppendText("" + vbNewLine + vbNewLine)
            TxtPrint.AppendText(vbTab & drugtype + vbNewLine)
            TxtPrint.AppendText(vbTab & drugname + vbNewLine)
            TxtPrint.AppendText(vbTab & dispense + vbNewLine)
            TxtPrint.AppendText(vbTab & refill + vbNewLine)

            TxtPrint.AppendText(vbTab & rxins + vbNewLine)
            TxtPrint.AppendText(vbTab & patins + vbNewLine)


            TxtPrint.AppendText(vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            TxtPrint.AppendText(vbTab & vbTab & vbTab & vbTab & "    " & dentname + vbNewLine)
            TxtPrint.AppendText(vbTab & vbTab & vbTab & vbTab & "    " & "  License No. : " & dlicense + vbNewLine)
            TxtPrint.AppendText(vbTab & vbTab & vbTab & vbTab & "    " & "  PTR No. : " & ptr + vbNewLine)
            TxtPrint.AppendText(vbTab & vbTab & vbTab & vbTab & "    " & "  Written Date : " & wdate + vbNewLine)
            TxtPrint.AppendText(vbTab & vbTab & vbTab & vbTab & "    " & "  Expiry Date : " & edate + vbNewLine)


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub



    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim mickey As String

        mickey = TxtPrint.Text

        Dim font As New Font("arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(mickey, font, Brushes.Black, 200, 200)
    End Sub

    Private Sub BtnPageSetup_Click(sender As Object, e As EventArgs) Handles BtnPageSetup.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub BtnPrintPreview_Click(sender As Object, e As EventArgs) Handles BtnPrintPreview.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click

        Me.Close()
        FrmHome.switchPanel(FrmPrescriptionHistory)
    End Sub
End Class