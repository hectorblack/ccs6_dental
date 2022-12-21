Imports IBM.Data.DB2
Public Class FrmAddPatient
    Private Conn As Common.DbConnection
    Private Sub AddPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        DTPBD.CustomFormat = "MM/dd/yyyy"
        DTPBD.Format = DateTimePickerFormat.Custom

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Call Me.IDGenerate()

        CBS.Items.Add("Male")
        CBS.Items.Add("Female")

        CBMS.Items.Add("Single")
        CBMS.Items.Add("Married")
        CBMS.Items.Add("Divorced")
        CBMS.Items.Add("Separated")
        CBMS.Items.Add("Widowed")

        CBSmoker.Items.Add("True")
        CBSmoker.Items.Add("False")

        CBPregnant.Items.Add("True")
        CBPregnant.Items.Add("False")

    End Sub

    Private Sub IDGenerate()
        Try
            Dim first2 As String = "01"
            Dim last2yr As String = Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Substring(Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Length - 2, 2)

            Dim patnew As String
            Dim patiententry As String
            Dim pnum As Integer

            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String

            SelectStr = "select PATIENTNUMBER from PATIENT order by PATIENTNUMBER desc fetch first row only"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader


            While RdrDrg.Read()
                patiententry = RdrDrg.GetString(0)

            End While

            patnew = patiententry.Substring(patiententry.Length - 4)
            pnum = Convert.ToInt32(patnew) + 1

            Dim patientstring = Convert.ToString(pnum)

            If (patientstring.Length = 1) Then
                patientstring = "000" & pnum

            ElseIf (patientstring.Length = 2) Then
                patientstring = "00" & pnum

            ElseIf (patientstring.Length = 3) Then
                patientstring = "0" & pnum

            ElseIf (patientstring.Length = 4) Then
                patientstring = pnum

            End If


            Dim patientid As String = (first2 & last2yr & patientstring)

            Me.TxtId.Text = patientid

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Dim PatientID As String
            Dim Fname As String
            Dim Mname As String
            Dim Lname As String
            Dim Bday As String
            Dim Sex As String
            Dim Marital As String
            Dim Nationality As String
            Dim Citizenship As String
            Dim Phonenum As String
            Dim Email As String
            Dim Emergency As String

            Dim Address As String
            Dim street As String
            Dim city As String
            Dim region As String
            Dim zip As String

            Dim Allergies As String
            Dim Alcohol As String
            Dim Smoker As Boolean
            Dim Disorders As String
            Dim Disease As String
            Dim Pregnant As Boolean
            Dim FamHistory As String
            Dim Tolerance As String
            Dim Evaluation As String
            Dim Status As String

            Dim InsertStr As String
            Dim CmdInsert As DB2Command

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            PatientID = Me.TxtId.Text
            Fname = Me.txtfirstname.Text
            Mname = Me.txtmiddlename.Text
            Lname = Me.txtlastname.Text

            DTPBD.CustomFormat = "MM/dd/yyyy"
            DTPBD.Format = DateTimePickerFormat.Custom

            Bday = Me.DTPBD.Text
            Sex = Me.CBS.Text
            Marital = Me.CBMS.Text
            Nationality = Me.txtNationality.Text
            Citizenship = Me.txtCitizenship.Text
            Phonenum = Me.txtPhone.Text
            Email = Me.txtEmail.Text
            Emergency = Me.txtEmergency.Text


            street = Me.txtStreet.Text
            region = Me.txtRegion.Text
            city = Me.txtCity.Text
            region = Me.txtRegion.Text
            zip = Me.txtZip.Text
            Address = street + "-" + region + "-" + city + "-" + region + "-" + zip

            Allergies = Me.txtAllergies.Text
            Alcohol = Me.txtAlcohol.Text
            Smoker = Me.CBSmoker.Text
            Disorders = Me.txtDisorders.Text
            Disease = Me.txtDisease.Text
            Pregnant = Me.CBPregnant.Text
            FamHistory = Me.txtFamHistory.Text
            Tolerance = Me.txtTolerance.Text
            Evaluation = Me.txtEvaluation.Text
            Status = Me.TxtStatus.Text


            InsertStr = "insert into patient values('" & PatientID & "','" & Fname & "', '" & Mname & "','" & Lname & "','" & Sex & "','" & Email & "','" & Phonenum & "','" & Marital & "','" & Bday & "','" & Nationality & "','" & Citizenship & "','" & Address & "','" & Allergies & "','" & Emergency & "','" & Disorders & "','" & Disease & "','" & Smoker & "','" & Alcohol & "','" & Pregnant & "','" & FamHistory & "','" & Tolerance & "','" & Status & "','" & Evaluation & "')"


            CmdInsert = New DB2Command(InsertStr, Conn)
            CmdInsert.ExecuteNonQuery()

            MsgBox("The record was successfully added...")
            '
            If Application.OpenForms().OfType(Of FrmPatientMain).Any Then
                Call FrmPatientMain.Refresh_Datagrid()
                Call FrmBillingAdd.PopulatePatientBox()
            End If

            Me.Close()
            FrmHome.switchPanel(FrmPatientMain)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

  

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        FrmHome.switchPanel(FrmPatientMain)

    End Sub


End Class