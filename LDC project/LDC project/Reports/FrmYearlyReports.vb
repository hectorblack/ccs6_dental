Imports IBM.Data.DB2
Imports System.Windows.Forms.DataVisualization.Charting
Public Class FrmYearlyReports
    Private Conn As Common.DbConnection
    Private Sub FrmYearlyReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
            Conn.Open()


            DGYearly.EnableHeadersVisualStyles = False
            DGYearly.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 58, 64)
            DGYearly.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DGYearly.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            DGYearly.ColumnCount = 2

            With DGYearly
                .Columns(0).Name = "YEAR"
                .Columns(0).Width = 150

                .Columns(1).Name = "REVENUE AMOUNT"
                .Columns(1).Width = 140
     

                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With


            DGVTreatmentTotal.EnableHeadersVisualStyles = False
            DGVTreatmentTotal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 58, 64)
            DGVTreatmentTotal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DGVTreatmentTotal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DGVTreatmentTotal.ColumnCount = 2
            With DGVTreatmentTotal
                .Columns(0).Name = "TREATMENT NAME"
                .Columns(0).Width = 150
                .Columns(1).Name = "TOTAL REVENUE"
                .Columns(1).Width = 130


                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            Call Me.PopulateYearlyRevenue()
            ' Call Me.PopulatetTreatmentRev()
            Call Me.loadPieChart()
            Call Me.populateCB()
            '   Call Me.loadColumnChart()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub PopulateYearlyRevenue()
        Try
            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim row As String()

            SelectStr = "select date_part('YEAR',date) as YEAR, sum(amount) as REVENUE from db2admin.billing group by date_part('YEAR',date)"
            'SelectStr = "select * from billing"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader

            Me.DGYearly.Rows.Clear()

            While RdrDrg.Read
                row = New String() {RdrDrg.GetDB2String(0), RdrDrg.GetDB2String(1)}
                DGYearly.Rows.Add(row)
            End While

            RdrDrg.Close()
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

    Public Sub PopulatetTreatmentRev()
        Try
            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String
            Dim row As String()

            Dim year As String
            year = CBYEAR.Text

            SelectStr = "select treatmentname,sum(amount) as total from billing where date_part('YEAR',date)='" & year & "' group by treatmentname"
            'SelectStr = "select * from billing"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader

            Me.DGVTreatmentTotal.Rows.Clear()

            While RdrDrg.Read
                row = New String() {RdrDrg.GetDB2String(0), RdrDrg.GetDB2String(1)}
                DGVTreatmentTotal.Rows.Add(row)
            End While

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnMonthlyReports_Click(sender As Object, e As EventArgs) Handles btnMonthlyReports.Click
        FrmHome.switchPanel(FrmMonthlyReports)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnWeekly.Click
        FrmHome.switchPanel(FrmWeeklyReports)
    End Sub

    Public Sub loadPieChart()
        Try
            With chartPie
                .Series.Clear()
                .Series.Add("Series1")
            End With

            Dim da As New DB2DataAdapter(" select treatmentname,count(patientname) as total from billing group by treatmentname", Conn)
            Dim ds As New DataSet

            da.Fill(ds, "treatmentname")
            chartPie.DataSource = ds.Tables("treatmentname")
            Dim series1 As Series = chartPie.Series("Series1")
            series1.ChartType = SeriesChartType.Pie
            series1.Name = "treatmentname"

            With chartPie
                .Series(0)("PieLabelStyle") = "disabled"
                .Series(0).BorderWidth = 1
                '.Series(0).BorderColor = System.Drawing.Color.Black
                '  .ChartAreas(0).Area3DStyle.Enable3D = True
                .Series(series1.Name).XValueMember = "treatmentname"
                .Series(series1.Name).YValueMembers = "total"
                .Series(0).LabelFormat = "{#,##0}"
                .Series(0).IsValueShownAsLabel = True

                .Series(0).LegendText = "#VALX (#PERCENT)"
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub



    Private Sub CBYEAR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBYEAR.SelectedIndexChanged
        Call Me.PopulatetTreatmentRev()
    End Sub
End Class