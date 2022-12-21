Imports IBM.Data.DB2
Public Class FrmBillingMain
    Private Conn As Common.DbConnection
    Private Sub FrmBillingMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()
        Try

            TransDGV.ColumnCount = 8

            TransDGV.EnableHeadersVisualStyles = False
            TransDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 58, 64)
            TransDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            TransDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            With TransDGV

                .Columns(0).Name = "Transaction number"
                .Columns(1).Name = "Treatment name"
                .Columns(2).Name = "Date"
                .Columns(3).Name = "Patient name"
                .Columns(4).Name = "Payment method"
                .Columns(5).Name = "Amount"
                .Columns(6).Name = "Status"
                .Columns(7).Name = "Remaining balance"

                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With
            Call Refresh_Datagrid()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Me.Close()
        FrmHome.switchPanel(FrmBillingAdd)
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click


        If String.IsNullOrEmpty(TransID.Text) Then
            MsgBox("Please select an item from the table first...")
        Else
            FrmBillingUpdate.TransNo.Text = Me.TransID.Text()
            Me.Close()
            FrmHome.switchPanel(FrmBillingUpdate)
        End If



    End Sub



    Public Sub Refresh_Datagrid()
        Dim RdrDrg As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String()

        SelectStr = "select transactionnumber, treatmentname, date, patientname, paymentmethod, amount, status, rembal from billing"
        cmdRetrieve = New DB2Command(SelectStr, Conn)
        RdrDrg = cmdRetrieve.ExecuteReader
        Me.TransDGV.Rows.Clear()

        While RdrDrg.Read
            Dim RemBalance As String
            If RdrDrg.IsDBNull(7) Then
                RemBalance = ""
            Else
                RemBalance = RdrDrg.GetString(7)
            End If
            row = New String() {RdrDrg.GetString(0), RdrDrg.GetString(1), RdrDrg.GetString(2), RdrDrg.GetString(3), RdrDrg.GetString(4), RdrDrg.GetString(5), RdrDrg.GetString(6), RemBalance}
            TransDGV.Rows.Add(row)
        End While

        RdrDrg.Close()

    End Sub

    Private Sub TransDGV_MouseUp(sender As Object, e As MouseEventArgs) Handles TransDGV.MouseUp
        Me.TransID.Text = Me.TransDGV.CurrentRow.Cells(0).Value()
    End Sub


End Class