<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMonthlyReports
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
        Me.chartColumn = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnWeeklyReports = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnYearly = New System.Windows.Forms.Button()
        Me.DGVMonthly = New System.Windows.Forms.DataGridView()
        Me.CBYear = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.chartColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chartColumn
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartColumn.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartColumn.Legends.Add(Legend1)
        Me.chartColumn.Location = New System.Drawing.Point(49, 136)
        Me.chartColumn.Name = "chartColumn"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartColumn.Series.Add(Series1)
        Me.chartColumn.Size = New System.Drawing.Size(1027, 434)
        Me.chartColumn.TabIndex = 3
        Me.chartColumn.Text = "Chart2"
        '
        'btnWeeklyReports
        '
        Me.btnWeeklyReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeeklyReports.Location = New System.Drawing.Point(692, 7)
        Me.btnWeeklyReports.Name = "btnWeeklyReports"
        Me.btnWeeklyReports.Size = New System.Drawing.Size(136, 40)
        Me.btnWeeklyReports.TabIndex = 4
        Me.btnWeeklyReports.Text = "WEEKLY"
        Me.btnWeeklyReports.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(834, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 40)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "MONTHLY"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnYearly
        '
        Me.btnYearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYearly.Location = New System.Drawing.Point(976, 7)
        Me.btnYearly.Name = "btnYearly"
        Me.btnYearly.Size = New System.Drawing.Size(136, 40)
        Me.btnYearly.TabIndex = 6
        Me.btnYearly.Text = "YEARLY"
        Me.btnYearly.UseVisualStyleBackColor = True
        '
        'DGVMonthly
        '
        Me.DGVMonthly.AllowUserToAddRows = False
        Me.DGVMonthly.AllowUserToDeleteRows = False
        Me.DGVMonthly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVMonthly.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVMonthly.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(196, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVMonthly.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVMonthly.GridColor = System.Drawing.Color.Black
        Me.DGVMonthly.Location = New System.Drawing.Point(49, 609)
        Me.DGVMonthly.Name = "DGVMonthly"
        Me.DGVMonthly.ReadOnly = True
        Me.DGVMonthly.RowHeadersVisible = False
        Me.DGVMonthly.RowTemplate.Height = 24
        Me.DGVMonthly.Size = New System.Drawing.Size(1027, 65)
        Me.DGVMonthly.TabIndex = 7
        '
        'CBYear
        '
        Me.CBYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBYear.FormattingEnabled = True
        Me.CBYear.Location = New System.Drawing.Point(484, 84)
        Me.CBYear.Name = "CBYear"
        Me.CBYear.Size = New System.Drawing.Size(121, 28)
        Me.CBYear.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(420, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "YEAR:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(255, 29)
        Me.Label17.TabIndex = 107
        Me.Label17.Text = "MONTHLY REPORTS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Revenue in PHP"
        '
        'FrmMonthlyReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1124, 777)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBYear)
        Me.Controls.Add(Me.DGVMonthly)
        Me.Controls.Add(Me.btnYearly)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnWeeklyReports)
        Me.Controls.Add(Me.chartColumn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMonthlyReports"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMonthlyReports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.chartColumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVMonthly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chartColumn As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnWeeklyReports As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnYearly As System.Windows.Forms.Button
    Friend WithEvents DGVMonthly As System.Windows.Forms.DataGridView
    Friend WithEvents CBYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
