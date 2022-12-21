Imports IBM.Data.DB2
Public Class FrmAddTreatmentPlan

    Private Conn As Common.DbConnection
    Private Sub FrmAddTreatmentPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()

        Call Me.TPNumGenerate()

        For index As Integer = 1 To 32
            CBTooth.Items.Add(index)
        Next

        Call Me.populateTreatmentCB()


    End Sub

    Public Sub populateTreatmentCB()

        CBTreatmentName.Items.Clear()

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
            CBTreatmentName.Items.Add(row)
        End While

        RdrDrg.Close()


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim Tpnumber As String
            Dim PatientID As String
            Dim toothnum As Integer
            Dim Diag As String
            Dim TreatmentName As String
            Dim amount As Decimal

            Dim InsertStr As String
            Dim CmdInsert As DB2Command

            Tpnumber = Me.txtTreatmentID.Text
            PatientID = FrmTreatmentPlan.TxtId.Text
            TreatmentName = Me.CBTreatmentName.Text
            toothnum = Me.CBTooth.Text
            amount = Me.txtAmount.Text


            InsertStr = "insert into treatment_plan values('" & Tpnumber & "','" & PatientID & "', '" & toothnum & "','" & Diag & "','" & TreatmentName & "'," & amount & ")"


            CmdInsert = New DB2Command(InsertStr, Conn)
            CmdInsert.ExecuteNonQuery()

            MsgBox("The record was successfully added...")


            If Application.OpenForms().OfType(Of FrmTreatmentPlan).Any Then
                Call FrmTreatmentPlan.Refresh_Datagrid()
            End If

            FrmTreatmentPlan.DGVTreatPlan.ReadOnly = False
            Call Me.ClearEntry()
            Call Me.TPNumGenerate()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ClearEntry()
        Me.txtDiagnosis.Clear()
        Me.txtAmount.Text = 0.0
    End Sub

    Private Sub TPNumGenerate()
        Try
            Dim first2 As String = "04"
            Dim last2yr As String = Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Substring(Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Length - 2, 2)

            Dim tpnew As String
            Dim tpentry As String
            Dim tpnum As Integer

            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String


            SelectStr = "select tpnumber from treatment_plan order by tpnumber desc fetch first row only"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader


            While RdrDrg.Read()
                'TPentry = TPentry + 1
                tpentry = RdrDrg.GetDB2String(0)
            End While

            tpnew = tpentry.Substring(tpentry.Length - 4)
            tpnum = Convert.ToInt16(tpnew) + 1

            Dim TPString = Convert.ToString(tpnum)

            If (TPString.Length = 1) Then
                TPString = "000" & tpnum

            ElseIf (TPString.Length = 2) Then
                TPString = "00" & tpnum

            ElseIf (TPString.Length = 3) Then
                TPString = "0" & tpnum

            ElseIf (TPString.Length = 4) Then
                TPString = tpnum

            End If


            Dim treatmentplanid As String = (first2 & last2yr & TPString)

            Me.txtTreatmentID.Text = treatmentplanid

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        FrmHome.switchPanel(FrmTreatmentPlan)
    End Sub

    Private Sub btnSave_MouseEnter(sender As Object, e As EventArgs) Handles btnSave.MouseEnter
        btnSave.BackColor = Color.FromArgb(51, 224, 196)
        btnSave.ForeColor = Color.White
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        btnSave.BackColor = Color.White
        btnSave.ForeColor = Color.Black
    End Sub

  
End Class