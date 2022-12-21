
Imports IBM.Data.DB2
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FrmMonthlyReports
    Private Conn As Common.DbConnection
    Private Sub FrmMonthlyReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
            Conn.Open()

            Call Me.populateCB()

            '


            DGVMonthly.ColumnCount = 12

            With DGVMonthly

                .Columns(0).Name = "January"
                .Columns(0).Width = 60

                .Columns(1).Name = "February"
                .Columns(1).Width = 60

                .Columns(2).Name = "March"
                .Columns(2).Width = 60

                .Columns(3).Name = "April"
                .Columns(3).Width = 60

                .Columns(4).Name = "May"
                .Columns(4).Width = 60

                .Columns(5).Name = "June"
                .Columns(5).Width = 60

                .Columns(6).Name = "July"
                .Columns(6).Width = 60

                .Columns(7).Name = "August"
                .Columns(7).Width = 60

                .Columns(8).Name = "September"
                .Columns(8).Width = 60

                .Columns(9).Name = "October"
                .Columns(9).Width = 60

                .Columns(10).Name = "November"
                .Columns(10).Width = 60

                .Columns(11).Name = "December"
                .Columns(11).Width = 60



            End With



            ' Call Me.Refresh_Datagrid()

            ' Call Me.loadColumnChart()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub populateCB()
        Try
            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim temp As String



            SelectStr = "select date_part('YEAR',date) from billing group by date_part('YEAR',date)"

            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader


            While RdrDrg.Read
                CBYear.Items.Add(RdrDrg.GetString(0))
            End While

            RdrDrg.Close()
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
            Dim year As String

            Dim temp0 As String
            Dim temp1 As String
            Dim temp2 As String
            Dim temp3 As String
            Dim temp4 As String
            Dim temp5 As String
            Dim temp6 As String
            Dim temp7 As String
            Dim temp8 As String
            Dim temp9 As String
            Dim temp10 As String
            Dim temp11 As String


            year = Me.CBYear.Text


            'SelectStr = "select * from table(GetAllMonthRevenuebyYear('" & year & "')) as udf"
            SelectStr = "SELECT	(select sum(amount) as JANUARY_REVENUE from billing where date_part('YEAR',date)='" & year & "' AND date_part('month',date)=1), (select sum(amount) as FEBRUARY_REVENUE from billing where date_part('YEAR',date)='" & year & "' AND date_part('month',date)=2), (select sum(amount) as MARCH_REVENUE from billing where date_part('YEAR',date)='" & year & "' AND date_part('month',date)=3), (select sum(amount) as APRIL_REVENUE from billing where date_part('YEAR',date)='" & year & "' AND date_part('month',date)=4), (select sum(amount) as MAY_REVENUE from billing where date_part('YEAR',date)='" & year & "' AND date_part('month',date)=5),(select sum(amount) as JUNE_REVENUE from billing where date_part('YEAR',date)='" & year & "' AND date_part('month',date)=6),(select sum(amount) as JULY_REVENUE from billing where date_part('YEAR',date)='" & year & "' AND date_part('month',date)=7), (select sum(amount) as AUGUST_REVENUE from billing where date_part('YEAR',date)='" & year & "' AND date_part('month',date)=8),(select sum(amount) as SEPTEMBER_REVENUE from billing where date_part('YEAR',date)='" & year & "' AND date_part('month',date)=9), (select sum(amount) as OCTOBER_REVENUE from billing where date_part('YEAR',date)='" & year & "' AND date_part('month',date)=10), (select sum(amount) as NOVEMBER_REVENUE from billing where date_part('YEAR',date)='" & year & "' AND date_part('month',date)=11), (select sum(amount) as DECEMBER_REVENUE from billing where date_part('YEAR',date)='" & year & "' AND date_part('month',date)=12) from billing where date_part('YEAR',date)='" & year & "' fetch first row only"


            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader
            Me.DGVMonthly.Rows.Clear()



            While RdrDrg.Read

                If RdrDrg.IsDBNull(0) Then
                    temp0 = ""
                Else
                    temp0 = RdrDrg.GetValue(0)
                End If

                ''''''''''''
                If RdrDrg.IsDBNull(1) Then
                    temp1 = ""
                Else
                    temp1 = RdrDrg.GetValue(1)
                End If
                ''''''''''''''''''''''
                If RdrDrg.IsDBNull(2) Then
                    temp2 = ""
                Else
                    temp2 = RdrDrg.GetValue(2)
                End If
                '''''''''''''''''''
                If RdrDrg.IsDBNull(3) Then
                    temp3 = ""
                Else
                    temp3 = RdrDrg.GetValue(3)
                End If
                ''''''''''''''''''''''
                If RdrDrg.IsDBNull(4) Then
                    temp4 = ""
                Else
                    temp4 = RdrDrg.GetValue(4)
                End If
                '''''''''''''''''''''
                If RdrDrg.IsDBNull(5) Then
                    temp5 = ""
                Else
                    temp5 = RdrDrg.GetValue(5)
                End If
                '''''''''''''''''''''
                If RdrDrg.IsDBNull(6) Then
                    temp6 = ""
                Else
                    temp6 = RdrDrg.GetValue(6)
                End If
                '''''''''''''''''''''
                If RdrDrg.IsDBNull(7) Then
                    temp7 = ""
                Else
                    temp7 = RdrDrg.GetValue(7)
                End If
                '''''''''''''''''''''
                If RdrDrg.IsDBNull(8) Then
                    temp8 = ""
                Else
                    temp8 = RdrDrg.GetValue(8)
                End If
                '''''''''''''''''''''
                If RdrDrg.IsDBNull(9) Then
                    temp9 = ""
                Else
                    temp9 = RdrDrg.GetValue(9)
                End If
                '''''''''''''''''''''
                If RdrDrg.IsDBNull(10) Then
                    temp10 = ""
                Else
                    temp10 = RdrDrg.GetValue(10)
                End If
                '''''''''''''''''''''
                If RdrDrg.IsDBNull(11) Then
                    temp11 = ""
                Else
                    temp11 = RdrDrg.GetValue(11)
                End If
                '''''''''''''''''''''

                '''''''''''''''''''''


                row = New String() {temp0, temp1, temp2, temp3, temp4, temp5, temp6, temp7, temp8, temp9, temp10, temp11} ' RdrDrg.GetString(1), RdrDrg.GetString(2), RdrDrg.GetString(3), RdrDrg.GetString(4)} ' RdrDrg.GetString(5), RdrDrg.GetString(6)}  RdrDrg.GetString(7), RdrDrg.GetString(8)} RdrDrg.GetString(9), RdrDrg.GetString(10), RdrDrg.GetString(11)}
                DGVMonthly.Rows.Add(row)
            End While

            Me.chartColumn.Series("Series1").Points.Clear()

            Me.chartColumn.Series("Series1").Points.AddXY("JANUARY", temp0)
            Me.chartColumn.Series("Series1").Points.AddXY("FEBRUARY", temp1)
            Me.chartColumn.Series("Series1").Points.AddXY("MARCH", temp2)
            Me.chartColumn.Series("Series1").Points.AddXY("APRIL", temp3)
            Me.chartColumn.Series("Series1").Points.AddXY("MAY", temp4)
            Me.chartColumn.Series("Series1").Points.AddXY("JUNE", temp5)
            Me.chartColumn.Series("Series1").Points.AddXY("JULY", temp6)
            Me.chartColumn.Series("Series1").Points.AddXY("AUGUST", temp7)
            Me.chartColumn.Series("Series1").Points.AddXY("SEPTEMBER", temp8)
            Me.chartColumn.Series("Series1").Points.AddXY("OCTOBER", temp9)
            Me.chartColumn.Series("Series1").Points.AddXY("NOVEMBER", temp10)
            Me.chartColumn.Series("Series1").Points.AddXY("DECEMBER", temp11)


            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub btnWeeklyReports_Click(sender As Object, e As EventArgs) Handles btnWeeklyReports.Click
        FrmHome.switchPanel(FrmWeeklyReports)
    End Sub

    Private Sub btnYearly_Click(sender As Object, e As EventArgs) Handles btnYearly.Click
        FrmHome.switchPanel(FrmYearlyReports)
    End Sub


    Private Sub CBYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBYear.SelectedIndexChanged

    End Sub

    Private Sub CBYear_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBYear.SelectedValueChanged
        Call Me.Refresh_Datagrid()
        '   Call Me.loadColumnChart()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class