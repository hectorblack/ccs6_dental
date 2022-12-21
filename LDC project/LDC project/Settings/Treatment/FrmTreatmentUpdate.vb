Imports IBM.Data.DB2
Public Class FrmTreatmentUpdate
    Private Conn As Common.DbConnection
    Private Sub FrmTreatmentUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()

        Call Me.textbox()
    End Sub

    Private Sub textbox()
        Try
            Dim RdrDrg As DB2DataReader
            Dim SelectStr As String
            Dim cmdRetrieve As DB2Command
            Dim textid As String

            SelectStr = "select * from treatment where treatmentnumber =  '" & textid & "'"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader
            While RdrDrg.Read
                TreatNumBox.Text = RdrDrg.GetDB2String(0).ToString
                TreatNameBox.Text = RdrDrg.GetDB2String(1).ToString
            End While

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BttnSave_Click(sender As Object, e As EventArgs) Handles BttnSave.Click
        Try
            If Me.TreatNameBox.Text Is String.Empty Then
                MsgBox("Input all fields")
            Else

                Dim StrUpdate As String
                Dim CmdUpdate As DB2Command

                Dim TreatNum As String
                Dim TreatName As String

                TreatNum = Me.TreatNumBox.Text
                TreatName = Me.TreatNameBox.Text

                StrUpdate = "update treatment set treatmentname = '" & TreatName & "'where treatmentnumber='" & TreatNum & "'"
                CmdUpdate = New DB2Command(StrUpdate, Conn)
                CmdUpdate.ExecuteNonQuery()
                MsgBox("Record was updated successfully...")

                If Application.OpenForms().OfType(Of FrmTreatmentMain).Any Then
                    Call FrmTreatmentMain.Refresh_Datagrid()
                End If

                Me.Close()
                FrmHome.switchPanel(FrmTreatmentMain)

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BttnClose_Click(sender As Object, e As EventArgs) Handles BttnClose.Click
        Me.Close()
        FrmHome.switchPanel(FrmTreatmentMain)
    End Sub

    Private Sub btnSave_MouseEnter(sender As Object, e As EventArgs) Handles BttnSave.MouseEnter
        BttnSave.BackColor = Color.FromArgb(51, 224, 196)
        BttnSave.ForeColor = Color.White
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles BttnSave.MouseLeave
        BttnSave.BackColor = Color.White
        BttnSave.ForeColor = Color.Black
    End Sub
End Class