<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmYearlyReports
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.chartPie = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DGYearly = New System.Windows.Forms.DataGridView()
        Me.btnYearly = New System.Windows.Forms.Button()
        Me.btnWeekly = New System.Windows.Forms.Button()
        Me.btnMonthlyReports = New System.Windows.Forms.Button()
        Me.DGVTreatmentTotal = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBYEAR = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.chartPie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGYearly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVTreatmentTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chartPie
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartPie.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartPie.Legends.Add(Legend1)
        Me.chartPie.Location = New System.Drawing.Point(12, 113)
        Me.chartPie.Name = "chartPie"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartPie.Series.Add(Series1)
        Me.chartPie.Size = New System.Drawing.Size(685, 541)
        Me.chartPie.TabIndex = 5
        Me.chartPie.Text = "Chart1"
        '
        'DGYearly
        '
        Me.DGYearly.AllowUserToAddRows = False
        Me.DGYearly.AllowUserToDeleteRows = False
        Me.DGYearly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGYearly.BackgroundColor = System.Drawing.Color.White
        Me.DGYearly.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGYearly.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGYearly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(196, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGYearly.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGYearly.GridColor = System.Drawing.Color.Black
        Me.DGYearly.Location = New System.Drawing.Point(703, 134)
        Me.DGYearly.Name = "DGYearly"
        Me.DGYearly.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGYearly.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGYearly.RowHeadersVisible = False
        Me.DGYearly.RowTemplate.Height = 24
        Me.DGYearly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGYearly.Size = New System.Drawing.Size(377, 143)
        Me.DGYearly.TabIndex = 7
        '
        'btnYearly
        '
        Me.btnYearly.Enabled = False
        Me.btnYearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYearly.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYearly.Location = New System.Drawing.Point(976, 6)
        Me.btnYearly.Name = "btnYearly"
        Me.btnYearly.Size = New System.Drawing.Size(136, 40)
        Me.btnYearly.TabIndex = 10
        Me.btnYearly.Text = "YEARLY"
        Me.btnYearly.UseVisualStyleBackColor = True
        '
        'btnWeekly
        '
        Me.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeekly.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeekly.Location = New System.Drawing.Point(692, 6)
        Me.btnWeekly.Name = "btnWeekly"
        Me.btnWeekly.Size = New System.Drawing.Size(136, 40)
        Me.btnWeekly.TabIndex = 9
        Me.btnWeekly.Text = "WEEKLY"
        Me.btnWeekly.UseVisualStyleBackColor = True
        '
        'btnMonthlyReports
        '
        Me.btnMonthlyReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonthlyReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonthlyReports.Location = New System.Drawing.Point(834, 6)
        Me.btnMonthlyReports.Name = "btnMonthlyReports"
        Me.btnMonthlyReports.Size = New System.Drawing.Size(136, 40)
        Me.btnMonthlyReports.TabIndex = 8
        Me.btnMonthlyReports.Text = "MONTHLY"
        Me.btnMonthlyReports.UseVisualStyleBackColor = True
        '
        'DGVTreatmentTotal
        '
        Me.DGVTreatmentTotal.AllowUserToAddRows = False
        Me.DGVTreatmentTotal.AllowUserToDeleteRows = False
        Me.DGVTreatmentTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVTreatmentTotal.BackgroundColor = System.Drawing.Color.White
        Me.DGVTreatmentTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVTreatmentTotal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVTreatmentTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(196, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVTreatmentTotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGVTreatmentTotal.GridColor = System.Drawing.Color.Black
        Me.DGVTreatmentTotal.Location = New System.Drawing.Point(692, 388)
        Me.DGVTreatmentTotal.Name = "DGVTreatmentTotal"
        Me.DGVTreatmentTotal.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVTreatmentTotal.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVTreatmentTotal.RowHeadersVisible = False
        Me.DGVTreatmentTotal.RowTemplate.Height = 24
        Me.DGVTreatmentTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVTreatmentTotal.Size = New System.Drawing.Size(377, 294)
        Me.DGVTreatmentTotal.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(229, 29)
        Me.Label17.TabIndex = 108
        Me.Label17.Text = "YEARLY REPORTS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 20)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Total Weighted Revenue per Treatment"
        '
        'CBYEAR
        '
        Me.CBYEAR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBYEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBYEAR.FormattingEnabled = True
        Me.CBYEAR.Location = New System.Drawing.Point(821, 340)
        Me.CBYEAR.Name = "CBYEAR"
        Me.CBYEAR.Size = New System.Drawing.Size(165, 30)
        Me.CBYEAR.TabIndex = 110
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(767, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Year:"
        '
        'FrmYearlyReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1124, 777)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBYEAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DGVTreatmentTotal)
        Me.Controls.Add(Me.btnYearly)
        Me.Controls.Add(Me.btnWeekly)
        Me.Controls.Add(Me.btnMonthlyReports)
        Me.Controls.Add(Me.DGYearly)
        Me.Controls.Add(Me.chartPie)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmYearlyReports"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmYearlyReports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.chartPie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGYearly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVTreatmentTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chartPie As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents DGYearly As System.Windows.Forms.DataGridView
    Friend WithEvents btnYearly As System.Windows.Forms.Button
    Friend WithEvents btnWeekly As System.Windows.Forms.Button
    Friend WithEvents btnMonthlyReports As System.Windows.Forms.Button
    Friend WithEvents DGVTreatmentTotal As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBYEAR As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
