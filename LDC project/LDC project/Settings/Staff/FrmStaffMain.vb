Imports IBM.Data.DB2
Public Class FrmStaffMain
    Private Conn As Common.DbConnection
    Private Sub FrmStaffMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()

        Try
            DGVUserDet.EnableHeadersVisualStyles = False
            DGVUserDet.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 58, 64)
            DGVUserDet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DGVUserDet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGVUserDet.ColumnCount = 5

            With DGVUserDet
                .Columns(0).Name = "Staff ID"
                .Columns(1).Name = "Staff Name"
                .Columns(2).Name = "Staff Password"
                .Columns(3).Name = "Staff PhoneNumber"
                .Columns(4).Name = "Staff Address"
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
        Dim textid As String

        textid = Me.TxtID.Text

        SelectStr = "select * from staff "
        cmdRetrieve = New DB2Command(SelectStr, Conn)
        RdrDrg = cmdRetrieve.ExecuteReader
        Me.DGVUserDet.Rows.Clear()

        While RdrDrg.Read
            row = New String() {RdrDrg.GetString(0), RdrDrg.GetString(1), RdrDrg.GetString(2), RdrDrg.GetString(3), RdrDrg.GetString(4)}
            DGVUserDet.Rows.Add(row)
        End While

        RdrDrg.Close()

    End Sub

    Private Sub BttnClose_Click(sender As Object, e As EventArgs) Handles BttnClose.Click
        Me.Close()
        FrmHome.switchPanel(FrmSettingsMain)
    End Sub

    Private Sub BttnDelete_Click(sender As Object, e As EventArgs) Handles BttnDelete.Click
        Try

            Dim DeleteStr As String
            Dim CmdDelete As DB2Command

            If String.IsNullOrEmpty(TxtID.Text) Then
                MsgBox("Please select an item from the table first...")
            Else
                DeleteStr = "delete from staff where staffid = '" & Me.TxtID.Text & "'"

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
    Private Sub DGVUserDet_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVUserDet.Click
        Me.TxtID.Text = Me.DGVUserDet.CurrentRow.Cells(0).Value()
    End Sub

    Private Sub BttnEdit_Click(sender As Object, e As EventArgs) Handles BttnEdit.Click

        If String.IsNullOrEmpty(TxtID.Text) Then
            MsgBox("Please select an item from the table first...")
        Else
            FrmStaffUpdate.StaffIDBox.Text = Me.TxtID.Text

            Me.Close()
            FrmHome.switchPanel(FrmStaffUpdate)
        End If


    End Sub

    Private Sub BttnAdd_Click(sender As Object, e As EventArgs) Handles BttnAdd.Click
        Me.Close()
        FrmHome.switchPanel(FrmStaffAdd)
    End Sub

    
End Class