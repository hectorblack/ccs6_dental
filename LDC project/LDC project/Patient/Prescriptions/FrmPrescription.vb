Imports IBM.Data.DB2
Public Class FrmPrescription
    Private Conn As Common.DbConnection

    Private Sub FrmPrescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()

        Call Me.populatePatientInfos()
        Call Me.GetDentistID()
        Call Me.PopulateDrugs()
        Call Me.PrescriptionNumberGenerate()

        DTPWritten.CustomFormat = "MM/dd/yyyy"
        DTPWritten.Format = DateTimePickerFormat.Custom
        DTPWritten.Text = Today

        DTPExpiry.CustomFormat = "MM/dd/yyyy"
        DTPExpiry.Format = DateTimePickerFormat.Custom
        DTPExpiry.Text = DTPExpiry.Value.AddDays(14)

        'Me.txtPatientID.Text = FrmViewPatient.TxtId.Text

    End Sub

    Private Sub PopulateDrugs()
        CBDrugName.Items.Add("Mefenamic acid")
        CBDrugName.Items.Add("Penicillin")
        CBDrugName.Items.Add("Tranexamic acid")

        CBDrugType.Items.Add("Analgesic")
        CBDrugType.Items.Add("Antibiotic")
        CBDrugType.Items.Add("Antifibrinolytics")
    End Sub

    Private Sub populatePatientInfos()
        Dim RdrDrg As DB2DataReader
        Dim SelectStr As String
        Dim cmdRetrieve As DB2Command
        Dim PID As String
        Dim tempAge As String
        Dim bage As String
        Dim age As Integer
        Dim nage As Integer

        PID = Me.txtPatientID.Text

        SelectStr = "select firstname, middlename, lastname,sex,birthdate from patient where patientnumber = '" & PID & "'"
        cmdRetrieve = New DB2Command(SelectStr, Conn)
        RdrDrg = cmdRetrieve.ExecuteReader
        While RdrDrg.Read
            txtFirstName.Text = RdrDrg.GetDB2String(0).ToString
            txtMiddleName.Text = RdrDrg.GetDB2String(1).ToString
            txtLastName.Text = RdrDrg.GetDB2String(2).ToString
            txtSex.Text = RdrDrg.GetDB2String(3).ToString
            tempAge = RdrDrg.GetDB2String(4).ToString
        End While

       
        bage = tempAge.Substring(tempAge.Length - 4)
        nage = Convert.ToInt32(bage)
        age = (Today.Year) - nage
        txtAge.Text = age

        RdrDrg.Close()

    End Sub

    Private Sub GetDentistID()
        Dim RdrDrg As DB2DataReader
        Dim SelectStr As String
        Dim cmdRetrieve As DB2Command
        Dim DID As String

        SelectStr = "select dentistid from dentist "
        cmdRetrieve = New DB2Command(SelectStr, Conn)
        RdrDrg = cmdRetrieve.ExecuteReader

        While RdrDrg.Read
            DID = RdrDrg.GetDB2String(0).ToString
        End While

        txtDentistID.Text = DID

        RdrDrg.Close()
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        FrmPrintPrescription.txtPrescriptNumber.Text = Me.txtPrescriptionNum.Text
        FrmPrintPrescription.txtPatientID.Text = Me.txtPatientID.Text
        Me.Hide()
        FrmHome.switchPanel(FrmPrintPrescription)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try

                Dim InsertStr As String
                Dim CmdInsert As DB2Command


                Dim Prescriptnumber As String
                Dim Patientid As String
                Dim WriDate As String
                Dim ExpDate As String
                Dim DentID As String
                Dim DType As String
                Dim DName As String
                Dim DDispense As String
                Dim PRefil As String
                Dim RXinst As String
                Dim Patins As String

                Prescriptnumber = Me.txtPrescriptionNum.Text
                Patientid = Me.txtPatientID.Text
                WriDate = Me.DTPWritten.Text
                ExpDate = Me.DTPExpiry.Text
                DentID = Me.txtDentistID.Text
                DType = Me.CBDrugType.Text
                DName = Me.CBDrugName.Text
                DDispense = Me.txtDispense.Text
                PRefil = Me.txtRefill.Text
                RXinst = Me.txtRXins.Text
                Patins = Me.txtPatientIns.Text

                ''''''''''

                InsertStr = "insert into prescription values('" & Prescriptnumber & "','" & Patientid & "','" & WriDate & "','" & ExpDate & "','" & DentID & "','" & DType & "','" & DName & "','" & DDispense & "','" & PRefil & "','" & RXinst & "','" & Patins & "')"

                CmdInsert = New DB2Command(InsertStr, Conn)
                CmdInsert.ExecuteNonQuery()

                MsgBox("The record was successfully added...")

                If Application.OpenForms().OfType(Of FrmPrescriptionHistory).Any Then
                    Call FrmPrescriptionHistory.Refresh_Datagrid()
                End If

                Call Me.ReturnAfter()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ReturnAfter()
        If MsgBox("Do You want to return to patient details?", MsgBoxStyle.YesNo, Title:="Confirm Delete?") = vbYes Then
            Me.Close()
            FrmHome.switchPanel(FrmViewPatient)
        Else
            MsgBox("Remove Aborted")
        End If
    End Sub

    Private Sub PrescriptionNumberGenerate()
        Dim first2 As String = "03"

        Dim last2yr As String = Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Substring(Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Length - 2, 2)

        Dim presnew As String
        Dim Prescriptentry As String
        Dim presum As Integer

        Dim RdrDrg As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String


        SelectStr = "select prescriptnumber from prescription order by prescriptnumber desc fetch first row only"
        cmdRetrieve = New DB2Command(SelectStr, Conn)
        RdrDrg = cmdRetrieve.ExecuteReader


        While RdrDrg.Read()

            Prescriptentry = RdrDrg.GetString(0)
        End While


        presnew = Prescriptentry.Substring(Prescriptentry.Length - 4)
        presum = Convert.ToInt32(presnew) + 1

        Dim Presstring = Convert.ToString(presum)


        If (Presstring.Length = 1) Then
            Presstring = "000" & presum

        ElseIf (Presstring.Length = 2) Then
            Presstring = "00" & presum

        ElseIf (Presstring.Length = 3) Then
            Presstring = "0" & presum

        ElseIf (Presstring.Length = 4) Then
            Presstring = presum

        End If


        Dim presid As String = (first2 & last2yr & Presstring)

        Me.txtPrescriptionNum.Text = presid

        RdrDrg.Close()
    End Sub


    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        FrmHome.switchPanel(FrmPrescriptionHistory)
    End Sub


  
End Class