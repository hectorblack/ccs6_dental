Imports IBM.Data.DB2
Public Class FrmUpdateTreatmentPlan
    Private Conn As Common.DbConnection
    Private Sub FrmUpdateTreatmentPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()
        Call Me.populateTreatmentCB()
        Call Me.populate()

    End Sub

    Private Sub populate()
        Try
            Dim RdrDrg As DB2DataReader
            Dim SelectStr As String
            Dim cmdRetrieve As DB2Command
            Dim tooth As Integer
            Dim tempTP As String

            tempTP = Me.txtTPNum.Text

            'FrmTreatmentPlan.txtPName.Text = Me.txtPatientNum.Text

            SelectStr = "select tooth, diagnosis, treatmentname,amount from treatment_plan where tpnumber = '" & tempTP & "'"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader
            While RdrDrg.Read
                CBTooth.Text = RdrDrg.GetDB2String(0).ToString
                txtDiagnosis.Text = RdrDrg.GetDB2String(1).ToString
                CBTreatmentName.Text = RdrDrg.GetDB2String(2).ToString
                txtAmount.Text = RdrDrg.GetDB2String(3).ToString
            End While

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            Dim StrUpdate As String
            Dim CmdUpdate As DB2Command

            Dim tpnumber As String
            Dim tdiagnosis As String
            Dim ttreatmentname As String
            Dim tamount As String
            Dim tooth As Integer

            tpnumber = txtTPNum.Text
            tdiagnosis = Me.txtDiagnosis.Text
            ttreatmentname = Me.CBTreatmentName.Text
            tamount = Me.txtAmount.Text
            tooth = CBTooth.Text

            StrUpdate = "update treatment_plan set diagnosis = '" & tdiagnosis & "',tooth='" & tooth & "', treatmentname = '" & ttreatmentname & "', amount = '" & tamount & "' where tpnumber='" & tpnumber & "'"
            CmdUpdate = New DB2Command(StrUpdate, Conn)
            CmdUpdate.ExecuteNonQuery()
            MsgBox("Record was updated successfully...")

            If Application.OpenForms().OfType(Of FrmTreatmentPlan).Any Then
                Call FrmTreatmentPlan.Refresh_Datagrid()
            End If

            Me.Close()
            FrmHome.switchPanel(FrmTreatmentPlan)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        FrmHome.switchPanel(FrmTreatmentPlan)
    End Sub

    
    Public Sub populateTreatmentCB()
        Try
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

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

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