<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAppointmentGraphical
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.apptboxid = New System.Windows.Forms.TextBox()
        Me.cancelbutton = New System.Windows.Forms.Button()
        Me.savebutton = New System.Windows.Forms.Button()
        Me.Timebox = New System.Windows.Forms.ComboBox()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Patientname = New System.Windows.Forms.ComboBox()
        Me.addeditlabel = New System.Windows.Forms.Label()
        Me.addwindow = New System.Windows.Forms.Panel()
        Me.temptext = New System.Windows.Forms.TextBox()
        Me.treatmenttextbox = New System.Windows.Forms.ComboBox()
        Me.reminderboxgraph = New System.Windows.Forms.TextBox()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appointID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Listviewbutton = New System.Windows.Forms.Button()
        Me.Editbutton = New System.Windows.Forms.Button()
        Me.Graphviewbutton = New System.Windows.Forms.Button()
        Me.Addbutton = New System.Windows.Forms.Button()
        Me.Graphview = New System.Windows.Forms.Panel()
        Me.DGVreminders = New System.Windows.Forms.DataGridView()
        Me.GVcalendar = New System.Windows.Forms.MonthCalendar()
        Me.DGVPatient = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.addwindow.SuspendLayout()
        Me.Graphview.SuspendLayout()
        CType(Me.DGVreminders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'apptboxid
        '
        Me.apptboxid.Enabled = False
        Me.apptboxid.Location = New System.Drawing.Point(377, 12)
        Me.apptboxid.Name = "apptboxid"
        Me.apptboxid.Size = New System.Drawing.Size(220, 22)
        Me.apptboxid.TabIndex = 14
        Me.apptboxid.Visible = False
        '
        'cancelbutton
        '
        Me.cancelbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.cancelbutton.FlatAppearance.BorderSize = 0
        Me.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelbutton.ForeColor = System.Drawing.Color.White
        Me.cancelbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cancelbutton.Location = New System.Drawing.Point(757, 3)
        Me.cancelbutton.Name = "cancelbutton"
        Me.cancelbutton.Size = New System.Drawing.Size(133, 39)
        Me.cancelbutton.TabIndex = 12
        Me.cancelbutton.Text = "CANCEL"
        Me.cancelbutton.UseVisualStyleBackColor = False
        '
        'savebutton
        '
        Me.savebutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.savebutton.FlatAppearance.BorderSize = 0
        Me.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.savebutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebutton.ForeColor = System.Drawing.Color.White
        Me.savebutton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.savebutton.Location = New System.Drawing.Point(895, 3)
        Me.savebutton.Name = "savebutton"
        Me.savebutton.Size = New System.Drawing.Size(132, 39)
        Me.savebutton.TabIndex = 11
        Me.savebutton.Text = "SAVE"
        Me.savebutton.UseVisualStyleBackColor = False
        '
        'Timebox
        '
        Me.Timebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Timebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timebox.FormattingEnabled = True
        Me.Timebox.Items.AddRange(New Object() {"09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00"})
        Me.Timebox.Location = New System.Drawing.Point(510, 120)
        Me.Timebox.Name = "Timebox"
        Me.Timebox.Size = New System.Drawing.Size(150, 33)
        Me.Timebox.TabIndex = 10
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MonthCalendar2.Location = New System.Drawing.Point(174, 181)
        Me.MonthCalendar2.MaxSelectionCount = 1
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(505, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Treatment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(171, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Patient Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(505, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(175, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date:"
        '
        'Patientname
        '
        Me.Patientname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Patientname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patientname.FormattingEnabled = True
        Me.Patientname.Location = New System.Drawing.Point(174, 120)
        Me.Patientname.Name = "Patientname"
        Me.Patientname.Size = New System.Drawing.Size(249, 33)
        Me.Patientname.TabIndex = 1
        '
        'addeditlabel
        '
        Me.addeditlabel.AutoSize = True
        Me.addeditlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addeditlabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.addeditlabel.Location = New System.Drawing.Point(19, 8)
        Me.addeditlabel.Name = "addeditlabel"
        Me.addeditlabel.Size = New System.Drawing.Size(136, 20)
        Me.addeditlabel.TabIndex = 0
        Me.addeditlabel.Text = "Add Appointment"
        '
        'addwindow
        '
        Me.addwindow.BackColor = System.Drawing.Color.White
        Me.addwindow.Controls.Add(Me.temptext)
        Me.addwindow.Controls.Add(Me.treatmenttextbox)
        Me.addwindow.Controls.Add(Me.cancelbutton)
        Me.addwindow.Controls.Add(Me.savebutton)
        Me.addwindow.Controls.Add(Me.Timebox)
        Me.addwindow.Controls.Add(Me.MonthCalendar2)
        Me.addwindow.Controls.Add(Me.Label5)
        Me.addwindow.Controls.Add(Me.Label4)
        Me.addwindow.Controls.Add(Me.Label3)
        Me.addwindow.Controls.Add(Me.Label2)
        Me.addwindow.Controls.Add(Me.Patientname)
        Me.addwindow.Controls.Add(Me.addeditlabel)
        Me.addwindow.Location = New System.Drawing.Point(64, 79)
        Me.addwindow.Name = "addwindow"
        Me.addwindow.Size = New System.Drawing.Size(1048, 532)
        Me.addwindow.TabIndex = 7
        Me.addwindow.Visible = False
        '
        'temptext
        '
        Me.temptext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.temptext.Location = New System.Drawing.Point(174, 120)
        Me.temptext.Multiline = True
        Me.temptext.Name = "temptext"
        Me.temptext.ReadOnly = True
        Me.temptext.Size = New System.Drawing.Size(249, 33)
        Me.temptext.TabIndex = 14
        Me.temptext.Visible = False
        '
        'treatmenttextbox
        '
        Me.treatmenttextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treatmenttextbox.FormattingEnabled = True
        Me.treatmenttextbox.Location = New System.Drawing.Point(510, 200)
        Me.treatmenttextbox.Name = "treatmenttextbox"
        Me.treatmenttextbox.Size = New System.Drawing.Size(300, 33)
        Me.treatmenttextbox.TabIndex = 13
        '
        'reminderboxgraph
        '
        Me.reminderboxgraph.Enabled = False
        Me.reminderboxgraph.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reminderboxgraph.Location = New System.Drawing.Point(181, 279)
        Me.reminderboxgraph.Multiline = True
        Me.reminderboxgraph.Name = "reminderboxgraph"
        Me.reminderboxgraph.Size = New System.Drawing.Size(262, 119)
        Me.reminderboxgraph.TabIndex = 1
        Me.reminderboxgraph.Text = "Reminders:"
        '
        'Column2
        '
        Me.Column2.FillWeight = 155.0898!
        Me.Column2.HeaderText = "Reminder"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 259
        '
        'Column1
        '
        Me.Column1.FillWeight = 44.91018!
        Me.Column1.HeaderText = "Time"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 75
        '
        'appointID
        '
        Me.appointID.HeaderText = "id"
        Me.appointID.MinimumWidth = 6
        Me.appointID.Name = "appointID"
        Me.appointID.ReadOnly = True
        Me.appointID.Visible = False
        Me.appointID.Width = 125
        '
        'Listviewbutton
        '
        Me.Listviewbutton.BackColor = System.Drawing.Color.DarkOrchid
        Me.Listviewbutton.FlatAppearance.BorderSize = 0
        Me.Listviewbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Listviewbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Listviewbutton.ForeColor = System.Drawing.Color.White
        Me.Listviewbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Listviewbutton.Location = New System.Drawing.Point(960, 79)
        Me.Listviewbutton.Name = "Listviewbutton"
        Me.Listviewbutton.Size = New System.Drawing.Size(131, 39)
        Me.Listviewbutton.TabIndex = 12
        Me.Listviewbutton.Text = "LIST VIEW"
        Me.Listviewbutton.UseVisualStyleBackColor = False
        '
        'Editbutton
        '
        Me.Editbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Editbutton.Enabled = False
        Me.Editbutton.FlatAppearance.BorderSize = 0
        Me.Editbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Editbutton.ForeColor = System.Drawing.Color.White
        Me.Editbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Editbutton.Location = New System.Drawing.Point(168, 79)
        Me.Editbutton.Name = "Editbutton"
        Me.Editbutton.Size = New System.Drawing.Size(98, 35)
        Me.Editbutton.TabIndex = 11
        Me.Editbutton.Text = "EDIT"
        Me.Editbutton.UseVisualStyleBackColor = False
        '
        'Graphviewbutton
        '
        Me.Graphviewbutton.BackColor = System.Drawing.Color.DarkOrchid
        Me.Graphviewbutton.FlatAppearance.BorderSize = 0
        Me.Graphviewbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Graphviewbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graphviewbutton.ForeColor = System.Drawing.Color.White
        Me.Graphviewbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Graphviewbutton.Location = New System.Drawing.Point(778, 79)
        Me.Graphviewbutton.Name = "Graphviewbutton"
        Me.Graphviewbutton.Size = New System.Drawing.Size(176, 39)
        Me.Graphviewbutton.TabIndex = 10
        Me.Graphviewbutton.Text = "GRAPHICAL VIEW"
        Me.Graphviewbutton.UseVisualStyleBackColor = False
        '
        'Addbutton
        '
        Me.Addbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Addbutton.FlatAppearance.BorderSize = 0
        Me.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addbutton.ForeColor = System.Drawing.Color.White
        Me.Addbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Addbutton.Location = New System.Drawing.Point(64, 79)
        Me.Addbutton.Name = "Addbutton"
        Me.Addbutton.Size = New System.Drawing.Size(98, 35)
        Me.Addbutton.TabIndex = 8
        Me.Addbutton.Text = "ADD"
        Me.Addbutton.UseVisualStyleBackColor = False
        '
        'Graphview
        '
        Me.Graphview.Controls.Add(Me.DGVreminders)
        Me.Graphview.Controls.Add(Me.reminderboxgraph)
        Me.Graphview.Controls.Add(Me.GVcalendar)
        Me.Graphview.Location = New System.Drawing.Point(64, 157)
        Me.Graphview.Name = "Graphview"
        Me.Graphview.Size = New System.Drawing.Size(1018, 587)
        Me.Graphview.TabIndex = 13
        Me.Graphview.Visible = False
        '
        'DGVreminders
        '
        Me.DGVreminders.AllowUserToAddRows = False
        Me.DGVreminders.AllowUserToDeleteRows = False
        Me.DGVreminders.AllowUserToResizeColumns = False
        Me.DGVreminders.AllowUserToResizeRows = False
        Me.DGVreminders.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVreminders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVreminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVreminders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.appointID, Me.Column1, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(196, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVreminders.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVreminders.Location = New System.Drawing.Point(473, 60)
        Me.DGVreminders.MultiSelect = False
        Me.DGVreminders.Name = "DGVreminders"
        Me.DGVreminders.ReadOnly = True
        Me.DGVreminders.RowHeadersVisible = False
        Me.DGVreminders.RowHeadersWidth = 51
        Me.DGVreminders.RowTemplate.Height = 24
        Me.DGVreminders.Size = New System.Drawing.Size(337, 338)
        Me.DGVreminders.TabIndex = 2
        '
        'GVcalendar
        '
        Me.GVcalendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVcalendar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GVcalendar.Location = New System.Drawing.Point(181, 60)
        Me.GVcalendar.MaxSelectionCount = 1
        Me.GVcalendar.Name = "GVcalendar"
        Me.GVcalendar.TabIndex = 0
        '
        'DGVPatient
        '
        Me.DGVPatient.AllowUserToAddRows = False
        Me.DGVPatient.AllowUserToDeleteRows = False
        Me.DGVPatient.AllowUserToResizeColumns = False
        Me.DGVPatient.AllowUserToResizeRows = False
        Me.DGVPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVPatient.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPatient.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(196, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPatient.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGVPatient.GridColor = System.Drawing.Color.Black
        Me.DGVPatient.Location = New System.Drawing.Point(64, 135)
        Me.DGVPatient.Name = "DGVPatient"
        Me.DGVPatient.ReadOnly = True
        Me.DGVPatient.RowHeadersVisible = False
        Me.DGVPatient.RowHeadersWidth = 51
        Me.DGVPatient.RowTemplate.Height = 24
        Me.DGVPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPatient.Size = New System.Drawing.Size(1027, 609)
        Me.DGVPatient.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(189, 29)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "APPOINTMENT"
        '
        'FrmAppointmentGraphical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1124, 777)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.apptboxid)
        Me.Controls.Add(Me.Listviewbutton)
        Me.Controls.Add(Me.Editbutton)
        Me.Controls.Add(Me.Graphviewbutton)
        Me.Controls.Add(Me.Addbutton)
        Me.Controls.Add(Me.Graphview)
        Me.Controls.Add(Me.DGVPatient)
        Me.Controls.Add(Me.addwindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAppointmentGraphical"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAppointmentGraphical"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.addwindow.ResumeLayout(False)
        Me.addwindow.PerformLayout()
        Me.Graphview.ResumeLayout(False)
        Me.Graphview.PerformLayout()
        CType(Me.DGVreminders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents apptboxid As System.Windows.Forms.TextBox
    Friend WithEvents cancelbutton As System.Windows.Forms.Button
    Friend WithEvents savebutton As System.Windows.Forms.Button
    Friend WithEvents Timebox As System.Windows.Forms.ComboBox
    Friend WithEvents MonthCalendar2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Patientname As System.Windows.Forms.ComboBox
    Friend WithEvents addeditlabel As System.Windows.Forms.Label
    Friend WithEvents addwindow As System.Windows.Forms.Panel
    Friend WithEvents reminderboxgraph As System.Windows.Forms.TextBox
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents appointID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Listviewbutton As System.Windows.Forms.Button
    Friend WithEvents Editbutton As System.Windows.Forms.Button
    Friend WithEvents Graphviewbutton As System.Windows.Forms.Button
    Friend WithEvents Addbutton As System.Windows.Forms.Button
    Friend WithEvents Graphview As System.Windows.Forms.Panel
    Friend WithEvents DGVreminders As System.Windows.Forms.DataGridView
    Friend WithEvents GVcalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents DGVPatient As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents treatmenttextbox As System.Windows.Forms.ComboBox
    Friend WithEvents temptext As System.Windows.Forms.TextBox
End Class
