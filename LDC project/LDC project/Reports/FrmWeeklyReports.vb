Imports IBM.Data.DB2
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FrmWeeklyReports
    Private Conn As Common.DbConnection
    Private Sub FrmWeeklyReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
            Conn.Open()

            Call Me.populateCBYEAR()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub populateCBYEAR()
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

    Private Sub populateCBMonth()
        Try
            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim temp As String

            CBMonth.Items.Clear()
            Dim year As String
            year = Me.CBYear.Text

            SelectStr = "select date_part('MONTH',date) from billing where date_part('YEAR',date)= '" & year & "' group by date_part('MONTH',date)"

            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader


            While RdrDrg.Read
                CBMonth.Items.Add(RdrDrg.GetString(0))
            End While

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMonthlyReports.Click
        FrmHome.switchPanel(FrmMonthlyReports)
    End Sub

    Private Sub btnYearly_Click(sender As Object, e As EventArgs) Handles btnYearly.Click
        FrmHome.switchPanel(FrmYearlyReports)
    End Sub


    Private Sub CBYear_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBYear.SelectedValueChanged
        CBMonth.Enabled = True
        Call Me.populateCBMonth()
    End Sub


    Public Sub Refresh_Chart()
        Try

            'Dim year As Integer
            'Dim month As Integer

            Dim tempyear As String
            Dim tempmonth As String
            Dim kani As Integer

            tempmonth = CBMonth.Text
            tempyear = CBYear.Text


            If (tempmonth = "1") Then
                kani = 1
            ElseIf (tempmonth = "2") Then
                kani = 2
            ElseIf (tempmonth = "3") Then
                kani = 3
            ElseIf (tempmonth = "4") Then
                kani = 4
            ElseIf (tempmonth = "5") Then
                kani = 5
            ElseIf (tempmonth = "6") Then
                kani = 6
            ElseIf (tempmonth = "7") Then
                kani = 7
            ElseIf (tempmonth = "8") Then
                kani = 8
            ElseIf (tempmonth = "9") Then
                kani = 9
            ElseIf (tempmonth = "10") Then
                kani = 10
            ElseIf (tempmonth = "11") Then
                kani = 11
            ElseIf (tempmonth = "12") Then
                kani = 12
            End If

            ' month = CInt(tempmonth)
            ' year = CInt(tempyear)
            '
            With chartColumn
                .Series.Clear()
                .Series.Add("Series1")
            End With


            'Dim da As New DB2DataAdapter(" select date_part('WEEK',date) as week,sum(amount) as Revenue_by_Week from billing where date_part('MONTH',date)=10 AND date_part('YEAR',date)=2021 group by date_part('WEEK',date)", Conn)

            Dim da As New DB2DataAdapter(" select date_part('WEEK',date) as week,sum(amount) as Revenue_by_Week from billing where date_part('MONTH',date)='" & kani & "'  AND date_part('YEAR',date)='" & tempyear & "' group by date_part('WEEK',date)", Conn)
            Dim ds As New DataSet

            da.Fill(ds, "week")
            chartColumn.DataSource = ds.Tables("week")
            Dim series1 As Series = chartColumn.Series("Series1")
            series1.ChartType = SeriesChartType.Column
            series1.Name = ""


            With chartColumn
                .Series(0)("ColumnLabelStyle") = "disabled"
                .Series(0).BorderWidth = 1

                .Series(series1.Name).XValueMember = "week"
                .Series(series1.Name).YValueMembers = "Revenue_by_Week"

                '.Series("Series1").Points.AddY("JANUARY")


                .Series(0).LabelFormat = "{#,##0}"
                .Series(0).IsValueShownAsLabel = True

                '   .Series(0).LegendText = "#VALX (#PERCENT)"
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub CBMonth_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBMonth.SelectedValueChanged
        Call Me.Refresh_Chart()
    End Sub


    Private Sub CBYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBYear.SelectedIndexChanged
        Call Me.Refresh_Chart()
    End Sub


End Class