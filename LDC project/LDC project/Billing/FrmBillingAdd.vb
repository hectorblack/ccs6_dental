Imports IBM.Data.DB2
Public Class FrmBillingAdd
    Private Conn As Common.DbConnection
    Private Sub FrmBillingAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
            Conn.Open()

            Call Me.PopulateTreatmentBox()
            Call Me.PopulatePatientBox()

            BillingDTP.CustomFormat = "MM/dd/yyyy"
            BillingDTP.Format = DateTimePickerFormat.Custom

            Call Me.IDGenerate()



            DGVServiceHistory.ColumnCount = 5

            With DGVServiceHistory
                .Columns(0).Name = "PTNO"
                .Columns(1).Name = "Date"
                .Columns(2).Name = "Patient Number"
                .Columns(3).Name = "Treatment Number"
                .Columns(4).Name = "Service Description"



                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            Call Refresh_ServiceHistory()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

       
    End Sub

    Public Sub Refresh_ServiceHistory()
        Try
            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim row As String()

            SelectStr = "select ptno,date,patientnumber,treatmentnumber,servicedesc from dentist_treat_patient order by date desc"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader
            Me.DGVServiceHistory.Rows.Clear()

            While RdrDrg.Read
                Dim servicedesc As String
                If RdrDrg.IsDBNull(4) Then
                    servicedesc = ""
                Else
                    servicedesc = RdrDrg.GetString(4)
                End If

                row = New String() {RdrDrg.GetString(0), RdrDrg.GetString(1), RdrDrg.GetString(2), RdrDrg.GetString(3), servicedesc}
                DGVServiceHistory.Rows.Add(row)
            End While

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Public Sub PopulateTreatmentBox()

        CBTreatmentName.Items.Clear()

        Dim RdrDrg As DB2DataReader
        Dim cmdRetrieve As DB2Command
        Dim SelectStr As String
        Dim row As String

        SelectStr = "select * from treatment"
        cmdRetrieve = New DB2Command(SelectStr, Conn)
        RdrDrg = cmdRetrieve.ExecuteReader

        While RdrDrg.Read
            row = RdrDrg.GetString(1).ToString
            CBTreatmentName.Items.Add(row)
        End While

        RdrDrg.Close()

    End Sub

    Public Sub PopulatePatientBox()
        Try
            CBPatientID.Items.Clear()
            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim row As String
            Dim first As String
            Dim last As String

            SelectStr = "select patientnumber from patient"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader


            While RdrDrg.Read
                row = RdrDrg.GetString(0).ToString
 
                CBPatientID.Items.Add(row)
            End While

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try

            Dim TransactionNumber As String
            Dim TreatmentName As String
            Dim DateSched As String
            Dim PatientName As String
            Dim PaymentMethod As String
            Dim Amount As Decimal
            Dim Status As String
            Dim Rembal As Decimal

            TransactionNumber = Me.TransNo.Text()
            TreatmentName = Me.CBTreatmentName.Text()
            PatientName = Me.txtPatientName.Text()
            PaymentMethod = Me.CBPayMethod.Text()
            Amount = Me.Amount.Text()
            Status = Me.CBStatus.Text()
            Rembal = Me.RemBal.Text()
            DateSched = Me.BillingDTP.Text()

            Dim InsertStr As String
            Dim CmdInsert As DB2Command


            InsertStr = "insert into billing values('" & TransactionNumber & "','" & TreatmentName & "', '" & DateSched & "','" & PatientName & "','" & PaymentMethod & "','" & Amount & "','" & Status & "','" & Rembal & "')"


            CmdInsert = New DB2Command(InsertStr, Conn)
            CmdInsert.ExecuteNonQuery()

            MsgBox("The record was successfully added...")


            If Application.OpenForms().OfType(Of FrmBillingMain).Any Then
                Call FrmBillingMain.Refresh_Datagrid()
            End If


            Me.Close()
            FrmHome.switchPanel(FrmBillingMain)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub IDGenerate()
        Try
            Dim first2 As String = "05"
            Dim last2yr As String = Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Substring(Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Length - 2, 2)

            Dim Billnew As String
            Dim Billentry As String
            Dim Billnum As Integer

            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String


            SelectStr = "select transactionnumber from billing order by transactionnumber desc fetch first row only"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader


            While RdrDrg.Read()

                Billentry = RdrDrg.GetString(0)

            End While

            Billnew = Billentry.Substring(Billentry.Length - 4)
            Billnum = Convert.ToInt32(Billnew) + 1

            Dim Billstring = Convert.ToString(Billnum)

            If (Billstring.Length = 1) Then
                Billstring = "000" & Billnum

            ElseIf (Billstring.Length = 2) Then
                Billstring = "00" & Billnum

            ElseIf (Billstring.Length = 3) Then
                Billstring = "0" & Billnum

            ElseIf (Billstring.Length = 4) Then
                Billstring = Billnum

            End If


            Dim Billid As String = (first2 & last2yr & Billstring)

            Me.TransNo.Text = Billid

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
        FrmHome.switchPanel(FrmBillingMain)
    End Sub

    Private Sub SaveButton_MouseEnter(sender As Object, e As EventArgs) Handles SaveButton.MouseEnter
        SaveButton.BackColor = Color.FromArgb(51, 224, 196)
        SaveButton.ForeColor = Color.White
    End Sub

    Private Sub SaveButton_MouseLeave(sender As Object, e As EventArgs) Handles SaveButton.MouseLeave
        SaveButton.BackColor = Color.White
        SaveButton.ForeColor = Color.Black
    End Sub



    Private Sub CBPatientName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPatientID.SelectedIndexChanged
        Try
            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim temp As String
            Dim first As String
            Dim last As String
            Dim row As String
            temp = Me.CBPatientID.Text

            SelectStr = "select firstname,lastname from patient where patientnumber=" + temp

            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader


            While RdrDrg.Read
                first = RdrDrg.GetString(0).ToString
                last = RdrDrg.GetString(1).ToString
                row = first + " " + last
                txtPatientName.Text = row
            End While

            RdrDrg.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DGVServiceHistory_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVServiceHistory.MouseUp
        Try
            Me.BillingDTP.Text = Me.DGVServiceHistory.CurrentRow.Cells(1).Value()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class