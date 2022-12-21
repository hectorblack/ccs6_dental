Imports IBM.Data.DB2
Public Class FrmTreatmentAdd
    Private Conn As Common.DbConnection
    Private Sub FrmTreatmentAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()

        Call Me.IDGenerate()
    End Sub
    Private Sub IDGenerate()
        Try
            Dim first2 As String = "08"
            Dim last2yr As String = Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Substring(Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Length - 2, 2)

            Dim TreatNew As String
            Dim TreatEntry As String
            Dim TreatNum As Integer

            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String

            SelectStr = "select treatmentnumber from treatment"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader


            While RdrDrg.Read()
                TreatEntry = RdrDrg.GetString(0)

            End While

            TreatNew = TreatEntry.Substring(TreatEntry.Length - 4)
            TreatNum = Convert.ToInt32(TreatNew) + 1

            Dim treatstring = Convert.ToString(TreatNum)

            If (treatstring.Length = 1) Then
                treatstring = "000" & TreatNum

            ElseIf (treatstring.Length = 2) Then
                treatstring = "00" & TreatNum

            ElseIf (treatstring.Length = 3) Then
                treatstring = "0" & TreatNum

            ElseIf (treatstring.Length = 4) Then
                treatstring = TreatNum

            End If


            Dim treatid As String = (first2 & last2yr & treatstring)

            Me.TreatNumBox.Text = treatid

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BttnClose_Click(sender As Object, e As EventArgs) Handles BttnClose.Click
        FrmHome.switchPanel(FrmTreatmentMain)
        Me.Close()
    End Sub

    Private Sub BttnAdd_Click(sender As Object, e As EventArgs) Handles BttnAdd.Click
        Try

            If Me.TreatNameBox.Text Is String.Empty Then
                MsgBox("Input all fields")
            Else

                Dim TreatNum As String
                Dim TreatName As String


                Dim InsertStr As String
                Dim CmdInsert As DB2Command

                TreatNum = Me.TreatNumBox.Text
                TreatName = Me.TreatNameBox.Text


                InsertStr = "insert into treatment values('" & TreatNum & "', '" & TreatName & "')"

                CmdInsert = New DB2Command(InsertStr, Conn)
                CmdInsert.ExecuteNonQuery()

                MsgBox("The record was successfully added...")




                If Application.OpenForms().OfType(Of FrmTreatmentMain).Any Then
                    Call FrmTreatmentMain.Refresh_Datagrid()
                    Call FrmAddTreatmentPlan.populateTreatmentCB()
                    Call FrmUpdateTreatmentPlan.populateTreatmentCB()
                    Call FrmNewProcedure.populateCombobox()
                    Call FrmBillingAdd.PopulateTreatmentBox()
                End If

                Me.Close()
                FrmHome.switchPanel(FrmTreatmentMain)

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSave_MouseEnter(sender As Object, e As EventArgs) Handles BttnAdd.MouseEnter
        BttnAdd.BackColor = Color.FromArgb(51, 224, 196)
        BttnAdd.ForeColor = Color.White
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles BttnAdd.MouseLeave
        BttnAdd.BackColor = Color.White
        BttnAdd.ForeColor = Color.Black
    End Sub
End Class