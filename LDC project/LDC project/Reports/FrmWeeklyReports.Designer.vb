<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWeeklyReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnMonthlyReports = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnYearly = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBYear = New System.Windows.Forms.ComboBox()
        Me.chartColumn = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBMonth = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.chartColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMonthlyReports
        '
        Me.btnMonthlyReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonthlyReports.Location = New System.Drawing.Point(834, 7)
        Me.btnMonthlyReports.Name = "btnMonthlyReports"
        Me.btnMonthlyReports.Size = New System.Drawing.Size(136, 40)
        Me.btnMonthlyReports.TabIndex = 2
        Me.btnMonthlyReports.Text = "MONTHLY"
        Me.btnMonthlyReports.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(692, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "WEEKLY"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnYearly
        '
        Me.btnYearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYearly.Location = New System.Drawing.Point(976, 7)
        Me.btnYearly.Name = "btnYearly"
        Me.btnYearly.Size = New System.Drawing.Size(136, 40)
        Me.btnYearly.TabIndex = 4
        Me.btnYearly.Text = "YEARLY"
        Me.btnYearly.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "YEAR:"
        '
        'CBYear
        '
        Me.CBYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBYear.FormattingEnabled = True
        Me.CBYear.Location = New System.Drawing.Point(375, 138)
        Me.CBYear.Name = "CBYear"
        Me.CBYear.Size = New System.Drawing.Size(121, 28)
        Me.CBYear.TabIndex = 11
        '
        'chartColumn
        '
        ChartArea3.Name = "ChartArea1"
        Me.chartColumn.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chartColumn.Legends.Add(Legend3)
        Me.chartColumn.Location = New System.Drawing.Point(114, 247)
        Me.chartColumn.Name = "chartColumn"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.chartColumn.Series.Add(Series3)
        Me.chartColumn.Size = New System.Drawing.Size(892, 457)
        Me.chartColumn.TabIndex = 10
        Me.chartColumn.Text = "Chart2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(534, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "MONTH:"
        '
        'CBMonth
        '
        Me.CBMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMonth.Enabled = False
        Me.CBMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMonth.FormattingEnabled = True
        Me.CBMonth.Location = New System.Drawing.Point(517, 138)
        Me.CBMonth.Name = "CBMonth"
        Me.CBMonth.Size = New System.Drawing.Size(121, 28)
        Me.CBMonth.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(235, 29)
        Me.Label17.TabIndex = 108
        Me.Label17.Text = "WEEKLY REPORTS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Revenue in PHP"
        '
        'FrmWeeklyReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1124, 777)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBMonth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBYear)
        Me.Controls.Add(Me.chartColumn)
        Me.Controls.Add(Me.btnYearly)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnMonthlyReports)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmWeeklyReports"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmWeeklyReports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.chartColumn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMonthlyReports As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnYearly As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBYear As System.Windows.Forms.ComboBox
    Friend WithEvents chartColumn As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
