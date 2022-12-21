Imports IBM.Data.DB2
Public Class FrmTreatmentMain
    Private Conn As Common.DbConnection
    Private Sub FrmTreatmentMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()
        Try

            DGVTreat.EnableHeadersVisualStyles = False
            DGVTreat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 58, 64)
            DGVTreat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DGVTreat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGVTreat.ColumnCount = 2

            With DGVTreat
                .Columns(0).Name = "Treatment Number"
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).Name = "Treatment Name"
            End With
            Call Refresh_Datagrid()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub Refresh_Datagrid()
        Dim RdrDrg As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select * from treatment"
        cmdRetrieve = New DB2Command(SelectStr, Conn)
        RdrDrg = cmdRetrieve.ExecuteReader
        Me.DGVTreat.Rows.Clear()

        While RdrDrg.Read
            row = New String() {RdrDrg.GetString(0), RdrDrg.GetString(1)}
            DGVTreat.Rows.Add(row)
        End While

        RdrDrg.Close()

    End Sub

    Private Sub BttnClose_Click(sender As Object, e As EventArgs) Handles BttnClose.Click
        FrmHome.switchPanel(FrmSettingsMain)
        Me.Close()
    End Sub

    Private Sub BttnDelete_Click(sender As Object, e As EventArgs) Handles BttnDelete.Click
        Try

            Dim DeleteStr As String
            Dim CmdDelete As DB2Command

            If String.IsNullOrEmpty(TxtID.Text) Then
                MsgBox("Please select an item from the table first...")
            Else
                DeleteStr = "delete from treatment where treatmentnumber = '" & Me.TxtID.Text & "'"

                If MsgBox("Are you sure you want to remove '" & Me.TxtID.Text & "'?", MsgBoxStyle.YesNo, Title:="Confirm Delete?") = vbYes Then

                    CmdDelete = New DB2Command(DeleteStr, Conn)
                    CmdDelete.ExecuteNonQuery()

                    MsgBox("Remove Successful...")
                Else
                    MsgBox("Remove Aborted")
                End If
                Call Refresh_Datagrid()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub DGVTreat_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVTreat.MouseUp
        Me.TxtID.Text = Me.DGVTreat.CurrentRow.Cells(0).Value()
        Me.txtname.Text = Me.DGVTreat.CurrentRow.Cells(1).Value()
    End Sub

    Private Sub BttnEdit_Click(sender As Object, e As EventArgs) Handles BttnEdit.Click

        If String.IsNullOrEmpty(TxtID.Text) Then
            MsgBox("Please select an item from the table first...")
        Else
            FrmTreatmentUpdate.TreatNumBox.Text = Me.TxtID.Text
            FrmTreatmentUpdate.TreatNameBox.Text = Me.txtname.Text
            ' FrmTreatmentUpdate.Show()
            FrmHome.switchPanel(FrmTreatmentUpdate)
        End If
    End Sub

    Private Sub BttnAdd_Click(sender As Object, e As EventArgs) Handles BttnAdd.Click
        Me.Close()
        FrmHome.switchPanel(FrmTreatmentAdd)
    End Sub

End Class