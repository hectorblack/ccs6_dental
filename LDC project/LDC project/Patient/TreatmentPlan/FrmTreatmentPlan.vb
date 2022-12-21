Imports IBM.Data.DB2
Imports IBM.Data.DB2Types
Public Class FrmTreatmentPlan
    Private Conn As Common.DbConnection

    Private Sub FrmTreatmentPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()

        Try


            DGVTreatPlan.ColumnCount = 5

            DGVTreatPlan.EnableHeadersVisualStyles = False
            DGVTreatPlan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 58, 64)
            DGVTreatPlan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DGVTreatPlan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            With DGVTreatPlan
                .Columns(0).Name = "TPnumber"
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).Name = "Tooth #"
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).Name = "Diagnosis"
                .Columns(3).Name = "Treatment"
                .Columns(4).Name = "Amount"


                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With


            Call Me.Refresh_Datagrid()
            Try
                If DGVTreatPlan.Rows.Count = 0 Then
                    DGVTreatPlan.ReadOnly = True
                    BtnUpdateRow.Enabled = False
                Else
                    DGVTreatPlan.ReadOnly = False
                    BtnUpdateRow.Enabled = True
                    ' Me.txtTPNO.Text = Me.DGVTreatPlan.CurrentRow.Cells(0).Value()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try




        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Refresh_Datagrid()
        Try
            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim row As String()
            Dim pid As String
            pid = TxtId.Text

            SelectStr = "select tpnumber,tooth,diagnosis,treatmentname,amount from treatment_plan where patientnumber='" & pid & "'"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader
            Me.DGVTreatPlan.Rows.Clear()

            While RdrDrg.Read
                row = New String() {RdrDrg.GetString(0), RdrDrg.GetString(1), RdrDrg.GetString(2), RdrDrg.GetString(3), RdrDrg.GetString(4)}
                Me.DGVTreatPlan.Rows.Add(row)
            End While

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DGVTreatPlan_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVTreatPlan.MouseUp
        Try
            'If DGVTreatPlan.RowCount > 0 Then
            If DGVTreatPlan.Rows.Count = 0 Then
                DGVTreatPlan.ReadOnly = True
                BtnUpdateRow.Enabled = False
            Else
                DGVTreatPlan.ReadOnly = False
                BtnUpdateRow.Enabled = True
                Me.txtTPNO.Text = Me.DGVTreatPlan.CurrentRow.Cells(0).Value()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub BtnUpdateRow_Click(sender As Object, e As EventArgs) Handles BtnUpdateRow.Click

        Try

            FrmUpdateTreatmentPlan.txtTPNum.Text = Me.DGVTreatPlan.CurrentRow.Cells(0).Value
            'FrmUpdateTreatmentPlan.CBTooth.Text = Me.DGVTreatPlan.CurrentRow.Cells(1).Value
            FrmUpdateTreatmentPlan.txtPatientNum.Text = Me.txtPName.Text




            FrmHome.switchPanel(FrmUpdateTreatmentPlan)
            Me.Hide()

            Call Refresh_Datagrid()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        FrmHome.switchPanel(FrmUpdateTreatmentPlan)
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        FrmHome.switchPanel(FrmAddTreatmentPlan)
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Me.Close()
        FrmHome.switchPanel(FrmViewPatient)
    End Sub


   
    Private Sub DGVTreatPlan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTreatPlan.CellContentClick
        Try
            If DGVTreatPlan.Rows.Count = 0 Then
                DGVTreatPlan.ReadOnly = True
                BtnUpdateRow.Enabled = False
            Else
                DGVTreatPlan.ReadOnly = False
                BtnUpdateRow.Enabled = True
                Me.txtTPNO.Text = Me.DGVTreatPlan.CurrentRow.Cells(0).Value()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class