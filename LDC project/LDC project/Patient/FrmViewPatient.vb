Imports IBM.Data.DB2
Public Class FrmViewPatient
    Private Conn As Common.DbConnection
    Private Sub FrmViewPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()
        Try
            Me.TxtId.Text = FrmPatientMain.TxtID.Text
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

            Lock()

            Call Me.Refresh_Datagrid()
            Call Me.different()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub Refresh_Datagrid()
        Try
            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim temp As String
            temp = Me.TxtId.Text

            SelectStr = "select * from patient where patientnumber=" + temp

            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader


            While RdrDrg.Read
                Me.txtfirstname.Text = RdrDrg.GetString(1).ToString
                Me.txtmiddlename.Text = RdrDrg.GetString(2).ToString
                Me.txtlastname.Text = RdrDrg.GetString(3).ToString
                Me.CBS.Text = RdrDrg.GetString(4).ToString
                Me.txtEmail.Text = RdrDrg.GetDB2String(5).ToString
                Me.txtPhone.Text = RdrDrg.GetString(6).ToString
                Me.CBMS.Text = RdrDrg.GetString(7).ToString
                Me.DTPBD.Text = RdrDrg.GetString(8).ToString
                Me.txtNationality.Text = RdrDrg.GetString(9).ToString
                Me.txtCitizenship.Text = RdrDrg.GetString(10).ToString
                Me.txtAddress.Text = RdrDrg.GetString(11).ToString
                Me.txtAllergies.Text = RdrDrg.GetDB2String(12).ToString
                Me.txtEmergency.Text = RdrDrg.GetDB2String(13).ToString


            End While

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub different()
        Try
            Dim secondRdrDrg As DB2DataReader
            Dim secondcmdRetrieve As DB2Command
            Dim secondSelectStr As String
            Dim temp As String
            temp = Me.TxtId.Text

            'SelectStr = "select firstname,middlename,lastname,sex,email,phonenumber,civilstatus,birthdate,nationality,citizenship,address,allergies from patient where patientnumber=" + temp
            secondSelectStr = "select disorders,systemicdisease,smoker,alcoholhistory,pregnant,fammedicalhistory,tolerance,dentisteval from patient where patientnumber=" + temp

            secondcmdRetrieve = New DB2Command(secondSelectStr, Conn)
            secondRdrDrg = secondcmdRetrieve.ExecuteReader

            Dim tempsmoker As String
            Dim temppreg As String
            Dim x As String
            x = "0"
            While secondRdrDrg.Read

                Me.txtDisorders.Text = secondRdrDrg.GetDB2String(0).ToString
                Me.txtDisease.Text = secondRdrDrg.GetDB2String(1).ToString

                tempsmoker = secondRdrDrg.GetString(2).ToString

                If tempsmoker = x Then
                    Me.CBSmoker.Text = "False"
                Else
                    Me.CBSmoker.Text = "True"
                End If


                Me.txtAlcohol.Text = secondRdrDrg.GetString(3).ToString

                temppreg = secondRdrDrg.GetString(4).ToString
                If temppreg = x Then
                    Me.CBPregnant.Text = "False"
                Else
                    Me.CBPregnant.Text = "True"
                End If

                Me.txtFamHistory.Text = secondRdrDrg.GetDB2String(5).ToString
                Me.txtTolerance.Text = secondRdrDrg.GetDB2String(6).ToString
                Me.txtEvaluation.Text = secondRdrDrg.GetDB2String(7).ToString

            End While

            secondRdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        FrmHome.switchPanel(FrmPatientMain)
    End Sub


    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        EditCancel.Visible = True
        BtnSave.Visible = True
        Unlock()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Dim patientid As String
            Dim Fname As String
            Dim Mname As String
            Dim Lname As String

            Dim Marital As String

            Dim tCitizenship As String
            Dim Phonenum As String
            Dim Email As String
            Dim Emergency As String

            Dim tAddress As String

            Dim tAllergies As String
            Dim Alcohol As String
            Dim tSmoker As Boolean
            Dim tDisorders As String
            Dim Disease As String
            Dim tPregnant As Boolean
            Dim FamHistory As String
            Dim tTolerance As String
            Dim Evaluation As String

            Dim StrUpdate As String
            Dim CmdUpdate As DB2Command

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            patientid = Me.TxtId.Text
            Fname = Me.txtfirstname.Text
            Mname = Me.txtmiddlename.Text
            Lname = Me.txtlastname.Text

            Marital = Me.CBMS.Text
            tCitizenship = Me.txtCitizenship.Text
            Phonenum = Me.txtPhone.Text
            Email = Me.txtEmail.Text
            Emergency = Me.txtEmergency.Text

            tAddress = Me.txtAddress.Text

            tAllergies = Me.txtAllergies.Text
            Alcohol = Me.txtAlcohol.Text
            tSmoker = Me.CBSmoker.Text
            tDisorders = Me.txtDisorders.Text
            Disease = Me.txtDisease.Text
            tPregnant = Me.CBPregnant.Text
            FamHistory = Me.txtFamHistory.Text
            tTolerance = Me.txtTolerance.Text
            Evaluation = Me.txtEvaluation.Text


            StrUpdate = "update patient set firstname = '" & Fname & "', middlename = '" & Mname & "' , lastname = '" & Lname & "',civilstatus = '" & Marital & "', citizenship = '" & tCitizenship & "',phonenumber = '" & Phonenum & "',email = '" & Email & "',emergencycontact = '" & Emergency & "',address = '" & tAddress & "',allergies = '" & tAllergies & "',alcoholhistory = '" & Alcohol & "' ,smoker = '" & tSmoker & "',disorders = '" & tDisorders & "',systemicdisease = '" & Disease & "',pregnant = '" & tPregnant & "',fammedicalhistory = '" & FamHistory & "',tolerance = '" & tTolerance & "',dentisteval = '" & Evaluation & "' where patientnumber='" & patientid & "'"


            CmdUpdate = New DB2Command(StrUpdate, Conn)
            CmdUpdate.ExecuteNonQuery()
            MsgBox("Record was updated successfully...")

            Call FrmPatientMain.Refresh_Datagrid()
            Call Me.Refresh_Datagrid()
            Call Me.different()
            BtnSave.Visible = False
            EditCancel.Visible = False
            Lock()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Unlock()
        Me.BtnSave.Enabled = True
        Me.txtfirstname.ReadOnly = False
        Me.txtmiddlename.ReadOnly = False
        Me.txtlastname.ReadOnly = False
        'Me.DTPBD.Enabled = True
        Me.CBMS.Enabled = True
        Me.txtCitizenship.ReadOnly = False
        Me.txtPhone.ReadOnly = False
        Me.txtEmail.ReadOnly = False
        Me.txtEmergency.ReadOnly = False
        'Me.CBS.Enabled = True
        ' Me.txtNationality.Enabled = True
        Me.txtAddress.ReadOnly = False

        Me.txtAllergies.ReadOnly = False
        Me.txtAlcohol.ReadOnly = False
        Me.CBSmoker.Enabled = True
        Me.txtDisorders.ReadOnly = False
        Me.txtDisease.ReadOnly = False
        Me.CBPregnant.Enabled = True
        Me.txtFamHistory.ReadOnly = False
        Me.txtTolerance.ReadOnly = False
        Me.txtEvaluation.ReadOnly = False
        Me.TxtStatus.ReadOnly = False
    End Sub

    Private Sub Lock()
        Me.BtnSave.Enabled = True
        Me.txtfirstname.ReadOnly = True
        Me.txtmiddlename.ReadOnly = True
        Me.txtlastname.ReadOnly = True
        Me.DTPBD.Enabled = False
        Me.CBS.Enabled = False
        Me.CBMS.Enabled = False
        Me.txtCitizenship.ReadOnly = True
        Me.txtPhone.ReadOnly = True
        Me.txtEmail.ReadOnly = True
        Me.txtEmergency.ReadOnly = True
        Me.txtNationality.ReadOnly = True
        Me.txtAddress.ReadOnly = True


        Me.txtAllergies.ReadOnly = True
        Me.txtAlcohol.ReadOnly = True
        Me.CBSmoker.Enabled = False
        Me.txtDisorders.ReadOnly = True
        Me.txtDisease.ReadOnly = True
        Me.CBPregnant.Enabled = False
        Me.txtFamHistory.ReadOnly = True
        Me.txtTolerance.ReadOnly = True
        Me.txtEvaluation.ReadOnly = True
        Me.TxtStatus.ReadOnly = True
    End Sub
    

    Private Sub BtnNewProcedure_Click(sender As Object, e As EventArgs) Handles BtnNewProcedure.Click
        FrmNewProcedure.txtPatientID.Text = Me.TxtId.Text
        Me.Close()
        FrmHome.switchPanel(FrmNewProcedure)
    End Sub

    Private Sub BtnPrescriptions_Click(sender As Object, e As EventArgs) Handles BtnPrescriptions.Click

        FrmPrescriptionHistory.txtPatientID.Text = Me.TxtId.Text
        Me.Close()
        'FrmHome.switchPanel(FrmPrescription)
        FrmHome.switchPanel(FrmPrescriptionHistory)


    End Sub

    Private Sub BtnViewTreatmentPlan_Click(sender As Object, e As EventArgs) Handles BtnViewTreatmentPlan.Click
        FrmTreatmentPlan.TxtId.Text = Me.TxtId.Text

        FrmTreatmentPlan.txtPName.Text = Me.txtfirstname.Text & " " & Me.txtmiddlename.Text & " " & Me.txtlastname.Text

        Me.Close()
        FrmHome.switchPanel(FrmTreatmentPlan)
    End Sub

    Private Sub EditCancel_Click(sender As Object, e As EventArgs) Handles EditCancel.Click
        Lock()
        EditCancel.Visible = False
        BtnSave.Visible = False
        Call Refresh_Datagrid()
    End Sub
End Class