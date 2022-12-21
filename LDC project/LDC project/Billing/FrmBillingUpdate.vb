Imports IBM.Data.DB2
Public Class FrmBillingUpdate
    Private Conn As Common.DbConnection
    Private Sub FrmBillingUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
            Conn.Open()

            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim row As String()
            Dim Transnumber As String

            Transnumber = TransNo.Text

            SelectStr = "select * from billing where transactionnumber = '" & Transnumber & "'"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader


            While RdrDrg.Read
                Me.TreatName.Text = RdrDrg.GetString(1).ToString
                Me.BillingDate.Text = RdrDrg.GetString(2).ToString
                Me.PatName.Text = RdrDrg.GetString(3).ToString
                Me.PayMeth.Text = RdrDrg.GetString(4).ToString
                Me.Amount.Text = RdrDrg.GetDecimal(5).ToString
                Me.Status.Text = RdrDrg.GetString(6).ToString
                Me.RemBal.Text = RdrDrg.GetDB2String(7).ToString

            End While

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            Dim StrUpdate As String
            Dim CmdUpdate As DB2Command

            Dim TransactionNumber As String
            Dim TreatmentName As String
            Dim PatientName As String
            Dim PaymentMethod As String
            Dim Amount As Decimal
            Dim Status As String
            Dim Rembal As Decimal

            TransactionNumber = Me.TransNo.Text()
            TreatmentName = Me.TreatName.Text()
            PatientName = Me.PatName.Text()
            PaymentMethod = Me.PayMeth.Text()
            Amount = Me.Amount.Text()
            Status = Me.Status.Text()
            Rembal = Me.RemBal.Text()

            StrUpdate = "update billing set amount='" & Amount & "', status= '" & Status & "', rembal='" & Rembal & "' where transactionnumber='" & TransactionNumber & "'"
            CmdUpdate = New DB2Command(StrUpdate, Conn)
            CmdUpdate.ExecuteNonQuery()
            MsgBox("Record was updated successfully...")

            If Application.OpenForms().OfType(Of FrmBillingMain).Any Then
                Call FrmBillingMain.Refresh_Datagrid()
            End If

            Me.Close()
            FrmHome.switchPanel(FrmBillingMain)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
        FrmHome.switchPanel(FrmBillingMain)
    End Sub

    Private Sub btnSave_MouseEnter(sender As Object, e As EventArgs) Handles UpdateButton.MouseEnter
        UpdateButton.BackColor = Color.FromArgb(51, 224, 196)
        UpdateButton.ForeColor = Color.White
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles UpdateButton.MouseLeave
        UpdateButton.BackColor = Color.White
        UpdateButton.ForeColor = Color.Black
    End Sub

  
End Class