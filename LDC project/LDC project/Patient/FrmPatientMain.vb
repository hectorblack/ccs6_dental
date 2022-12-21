Imports IBM.Data.DB2
Public Class FrmPatientMain
    Private LoginConn As Common.DbConnection
    Private Sub FrmPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginConn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        LoginConn.Open()

        Try

            DGVPatientList.EnableHeadersVisualStyles = False
            DGVPatientList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 58, 64)
            DGVPatientList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DGVPatientList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGVPatientList.ColumnCount = 5

            With DGVPatientList
                .Columns(0).Name = "Patient ID"
                .Columns(1).Name = "Last Name"
                .Columns(2).Name = "First Name"
                .Columns(3).Name = "Phone #"
                .Columns(4).Name = "Active Status"
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
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

        SelectStr = "select patientnumber, lastname, firstname,phonenumber,activestatus from patient"
        cmdRetrieve = New DB2Command(SelectStr, LoginConn)
        RdrDrg = cmdRetrieve.ExecuteReader
        Me.DGVPatientList.Rows.Clear()

        While RdrDrg.Read
            row = New String() {RdrDrg.GetString(0), RdrDrg.GetString(1), RdrDrg.GetString(2), RdrDrg.GetString(3), RdrDrg.GetValue(4)}
            DGVPatientList.Rows.Add(row)
        End While

        RdrDrg.Close()

    End Sub





    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try

            Dim DeleteStr As String
            Dim CmdDelete As DB2Command

            If String.IsNullOrEmpty(TxtID.Text) Then
                MsgBox("Please select an item from the table first...")
            Else
                DeleteStr = "delete from patient where patientnumber = '" & Me.TxtID.Text & "'"

                If MsgBox("Are you sure you want to remove '" & Me.TxtID.Text & "'?", MsgBoxStyle.YesNo, Title:="Confirm Delete?") = vbYes Then

                    CmdDelete = New DB2Command(DeleteStr, LoginConn)
                    CmdDelete.ExecuteNonQuery()

                    MsgBox("Remove Successful...")
                Else
                    MsgBox("Remove Aborted")
                End If
                Call Refresh_Datagrid()
                'Call ClearEntry()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub DGVPatientList_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVPatientList.MouseUp
        Me.TxtID.Text = Me.DGVPatientList.CurrentRow.Cells(0).Value()
    End Sub

    Private Sub btnServiceHistory_Click(sender As Object, e As EventArgs) Handles btnServiceHistory.Click
        Me.Close()
        FrmHome.switchPanel(FrmServiceHistory)
    End Sub

    Private Sub btnViewPatient_Click_1(sender As Object, e As EventArgs) Handles btnViewPatient.Click
        Try
            TxtID.Text = DGVPatientList.CurrentRow.Cells(0).Value()

            If String.IsNullOrEmpty(TxtID.Text) Then
                MsgBox("Please select an item from the table first...")
            Else
                FrmViewPatient.TxtId.Text = Me.TxtID.Text
                'Me.Hide()
                FrmHome.switchPanel(FrmViewPatient)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAdd_Click_1(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Me.Close()
        FrmHome.switchPanel(FrmAddPatient)
  
    End Sub

   
End Class