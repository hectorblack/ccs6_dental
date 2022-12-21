Imports IBM.Data.DB2
Public Class FrmNewProcedure
    Private Conn As Common.DbConnection

    Private Sub FrmNewProcedure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()
        DTPProcedure.CustomFormat = "MM/dd/yyyy"
        DTPProcedure.Format = DateTimePickerFormat.Custom
        Call Me.PTNOGenerate()
        Call Me.populateCombobox()
        'Me.txtPatientID.Text = FrmViewPatient.TxtId.Text
    End Sub

    Public Sub populateCombobox()
        CBTreatment.Items.Clear()
        Dim RdrDrg As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String

        SelectStr = "select * from treatment"
        cmdRetrieve = New DB2Command(SelectStr, Conn)
        RdrDrg = cmdRetrieve.ExecuteReader
        'Me.CBTreatment.ResetText()

        While RdrDrg.Read
            row = RdrDrg.GetString(1).ToString
            CBTreatment.Items.Add(row)
        End While

        RdrDrg.Close()


    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Dim InsertStr As String
            Dim CmdInsert As DB2Command

            Dim PTNO As String
            Dim Patientid As String
            Dim ProcDate As String
            Dim temptreatment As String
            Dim Treatment As String
            Dim ServiceDesc As String


            DTPProcedure.Text = Today

            PTNO = Me.TxtPTNO.Text
            Patientid = Me.txtPatientID.Text
            ProcDate = Me.DTPProcedure.Text

            ServiceDesc = Me.txtServiceDesc.Text

            Dim RdrDrg2 As DB2DataReader
            Dim SelectStr As String
            Dim cmdRetrieve2 As DB2Command
            temptreatment = Me.CBTreatment.Text
            SelectStr = "select treatmentnumber from treatment where treatmentname = '" & temptreatment & "'"
            cmdRetrieve2 = New DB2Command(SelectStr, Conn)
            RdrDrg2 = cmdRetrieve2.ExecuteReader
            While RdrDrg2.Read
                Treatment = RdrDrg2.GetDB2String(0).ToString
            End While
            RdrDrg2.Close()

            InsertStr = "insert into dentist_treat_patient values('" & PTNO & "','" & Treatment & "','" & Patientid & "','" & ServiceDesc & "','" & ProcDate & "')"

            CmdInsert = New DB2Command(InsertStr, Conn)
            CmdInsert.ExecuteNonQuery()

            MsgBox("The record was successfully added...")

            If Application.OpenForms().OfType(Of FrmServiceHistory).Any Then
                Call FrmServiceHistory.Refresh_Datagrid()

            End If

            If Application.OpenForms().OfType(Of FrmBillingAdd).Any Then

                Call FrmBillingAdd.Refresh_ServiceHistory()
            End If

            Me.Close()
            FrmHome.switchPanel(FrmViewPatient)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub PTNOGenerate()
        Dim first2 As String = "09"
        'Dim PTentry As Integer = 1
        Dim last2yr As String = Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Substring(Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Length - 2, 2)

        Dim ptnnew As String
        Dim PTentry As String
        Dim npnum As Integer

        Dim RdrDrg As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String


        SelectStr = "select ptno from dentist_treat_patient order by ptno desc fetch first row only"
        cmdRetrieve = New DB2Command(SelectStr, Conn)
        RdrDrg = cmdRetrieve.ExecuteReader


        While RdrDrg.Read()
            'PTentry = PTentry + 1
            PTentry = RdrDrg.GetString(0)
        End While

        ptnnew = PTentry.Substring(PTentry.Length - 4)
        npnum = Convert.ToInt32(ptnnew) + 1

        Dim PTstring = Convert.ToString(npnum)

        'Dim PTstring = PTentry.ToString()

        If (PTstring.Length = 1) Then
            PTstring = "000" & npnum

        ElseIf (PTstring.Length = 2) Then
            PTstring = "00" & npnum

        ElseIf (PTstring.Length = 3) Then
            PTstring = "0" & npnum

        ElseIf (PTstring.Length = 4) Then
            PTstring = npnum

        End If


        Dim ptid As String = (first2 & last2yr & PTstring)

        Me.TxtPTNO.Text = ptid

        RdrDrg.Close()
    End Sub

   

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
        FrmHome.switchPanel(FrmViewPatient)
    End Sub

    Private Sub CBTreatment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTreatment.SelectedIndexChanged

        Me.txtServiceDesc.Text = CBTreatment.Text
    End Sub


    Private Sub btnSave_MouseEnter(sender As Object, e As EventArgs) Handles BtnSave.MouseEnter
        BtnSave.BackColor = Color.FromArgb(51, 224, 196)
        BtnSave.ForeColor = Color.White
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles BtnSave.MouseLeave
        BtnSave.BackColor = Color.White
        BtnSave.ForeColor = Color.Black
    End Sub

End Class