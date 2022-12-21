Imports IBM.Data.DB2
Public Class FrmServiceHistory
    Private Conn As Common.DbConnection
    Private Sub FrmServiceHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()
        Try

            DGVServiceHistory.EnableHeadersVisualStyles = False
            DGVServiceHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 58, 64)
            DGVServiceHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DGVServiceHistory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGVServiceHistory.ColumnCount = 5

            With DGVServiceHistory

                .Columns(0).Name = "Service ID"
                .Columns(1).Name = "Treatment Number"
                .Columns(2).Name = "Patient Number"
                .Columns(3).Name = "Service Description"
                .Columns(4).Name = "Date"


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

        SelectStr = "select * from dentist_treat_patient"
        cmdRetrieve = New DB2Command(SelectStr, Conn)
        RdrDrg = cmdRetrieve.ExecuteReader
        Me.DGVServiceHistory.Rows.Clear()

        While RdrDrg.Read
            Dim servicedesc As String
            If RdrDrg.IsDBNull(3) Then
                servicedesc = ""
            Else
                servicedesc = RdrDrg.GetString(3)
            End If
            row = New String() {RdrDrg.GetString(0), RdrDrg.GetString(1), RdrDrg.GetString(2), servicedesc, RdrDrg.GetString(4)}
            DGVServiceHistory.Rows.Add(row)
        End While

        RdrDrg.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        FrmHome.switchPanel(FrmPatientMain)
    End Sub

 
End Class