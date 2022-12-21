Imports IBM.Data.DB2
Public Class FrmPrescriptionHistory
    Private Conn As Common.DbConnection
    Private Sub FrmPrescriptionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()

        Try

            DGVPresHis.EnableHeadersVisualStyles = False
            DGVPresHis.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 58, 86)
            DGVPresHis.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DGVPresHis.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGVPresHis.ColumnCount = 11

            With DGVPresHis
                .Columns(0).Name = "Prescript number"
                .Columns(1).Name = "Patient number"
                .Columns(2).Name = "Written date"
                .Columns(3).Name = "Expire date"
                .Columns(4).Name = "Dentist ID"
                .Columns(5).Name = "Drug type"
                .Columns(6).Name = "Drug Name"
                .Columns(7).Name = "Dispense"

                .Columns(8).Name = "Refills"
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                .Columns(9).Name = "RX Instructions"
                .Columns(10).Name = "Patient Instructions"

                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With
            Call Refresh_Datagrid()
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
            Dim temp As String
            temp = Me.txtPatientID.Text

            Dim isNull As Boolean

            Dim valtemp7 As String
            Dim valtemp8 As String
            Dim valtemp9 As String
            Dim valtemp10 As String



            SelectStr = "select * from prescription where  patientnumber = '" & temp & "'"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader
            Me.DGVPresHis.Rows.Clear()

            While RdrDrg.Read

                isNull = RdrDrg.IsDBNull(7)
                If (isNull) Then
                    valtemp7 = " "
                Else
                    valtemp7 = RdrDrg.GetString(7)
                End If
                ''''''''''''''''''''''''''''''''''
                isNull = RdrDrg.IsDBNull(8)
                If (isNull) Then
                    valtemp8 = " "
                Else
                    valtemp8 = RdrDrg.GetString(8)
                End If
                '''''''''''''''''''''''''''''''''
                isNull = RdrDrg.IsDBNull(9)
                If (isNull) Then
                    valtemp9 = " "
                Else
                    valtemp9 = RdrDrg.GetString(9)
                End If
                '''''''''''''''''''''''''''''
                isNull = RdrDrg.IsDBNull(10)
                If (isNull) Then
                    valtemp10 = " "
                Else
                    valtemp10 = RdrDrg.GetString(10)
                End If
   


                row = New String() {RdrDrg.GetString(0), RdrDrg.GetString(1), RdrDrg.GetString(2), RdrDrg.GetString(3), RdrDrg.GetString(4), RdrDrg.GetString(5), RdrDrg.GetString(6), valtemp7, valtemp8, valtemp9, valtemp10}
                DGVPresHis.Rows.Add(row)
            End While

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        FrmHome.switchPanel(FrmViewPatient)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try

            If String.IsNullOrEmpty(txtpresno.Text) Then
                MsgBox("Please select an item from the table first...")
            Else
                FrmPrintPrescription.txtPatientID.Text = Me.txtPatientID.Text
                FrmPrintPrescription.txtPrescriptNumber.Text = Me.txtpresno.Text
                Me.Hide()
                FrmHome.switchPanel(FrmPrintPrescription)

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnGeneratePres_Click(sender As Object, e As EventArgs) Handles btnGeneratePres.Click
        FrmPrescription.txtPatientID.Text = Me.txtPatientID.Text
        Me.Hide()
        FrmHome.switchPanel(FrmPrescription)
    End Sub

    Private Sub DGVPresHis_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVPresHis.MouseUp

        Try
            If DGVPresHis.CurrentCell.Value Is Nothing Then

            Else
                Me.txtpresno.Text = Me.DGVPresHis.CurrentRow.Cells(0).Value()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
End Class