<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTreatmentMain
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
        Me.BttnClose = New System.Windows.Forms.Button()
        Me.BttnDelete = New System.Windows.Forms.Button()
        Me.BttnEdit = New System.Windows.Forms.Button()
        Me.BttnAdd = New System.Windows.Forms.Button()
        Me.DGVTreat = New System.Windows.Forms.DataGridView()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        CType(Me.DGVTreat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BttnClose
        '
        Me.BttnClose.BackColor = System.Drawing.Color.DarkOrchid
        Me.BttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnClose.ForeColor = System.Drawing.Color.White
        Me.BttnClose.Location = New System.Drawing.Point(138, 85)
        Me.BttnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BttnClose.Name = "BttnClose"
        Me.BttnClose.Size = New System.Drawing.Size(133, 39)
        Me.BttnClose.TabIndex = 10
        Me.BttnClose.Text = "CLOSE"
        Me.BttnClose.UseVisualStyleBackColor = False
        '
        'BttnDelete
        '
        Me.BttnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BttnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnDelete.ForeColor = System.Drawing.Color.White
        Me.BttnDelete.Location = New System.Drawing.Point(791, 224)
        Me.BttnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BttnDelete.Name = "BttnDelete"
        Me.BttnDelete.Size = New System.Drawing.Size(133, 39)
        Me.BttnDelete.TabIndex = 9
        Me.BttnDelete.Text = "DELETE"
        Me.BttnDelete.UseVisualStyleBackColor = False
        '
        'BttnEdit
        '
        Me.BttnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BttnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnEdit.ForeColor = System.Drawing.Color.White
        Me.BttnEdit.Location = New System.Drawing.Point(791, 177)
        Me.BttnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.BttnEdit.Name = "BttnEdit"
        Me.BttnEdit.Size = New System.Drawing.Size(133, 39)
        Me.BttnEdit.TabIndex = 8
        Me.BttnEdit.Text = "EDIT"
        Me.BttnEdit.UseVisualStyleBackColor = False
        '
        'BttnAdd
        '
        Me.BttnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnAdd.ForeColor = System.Drawing.Color.White
        Me.BttnAdd.Location = New System.Drawing.Point(791, 130)
        Me.BttnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.BttnAdd.Name = "BttnAdd"
        Me.BttnAdd.Size = New System.Drawing.Size(133, 39)
        Me.BttnAdd.TabIndex = 7
        Me.BttnAdd.Text = "ADD"
        Me.BttnAdd.UseVisualStyleBackColor = False
        '
        'DGVTreat
        '
        Me.DGVTreat.AllowUserToAddRows = False
        Me.DGVTreat.AllowUserToDeleteRows = False
        Me.DGVTreat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVTreat.BackgroundColor = System.Drawing.Color.White
        Me.DGVTreat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVTreat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVTreat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(196, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVTreat.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVTreat.GridColor = System.Drawing.Color.Black
        Me.DGVTreat.Location = New System.Drawing.Point(190, 130)
        Me.DGVTreat.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVTreat.Name = "DGVTreat"
        Me.DGVTreat.ReadOnly = True
        Me.DGVTreat.RowHeadersVisible = False
        Me.DGVTreat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVTreat.Size = New System.Drawing.Size(580, 550)
        Me.DGVTreat.TabIndex = 6
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(846, 485)
        Me.TxtID.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(132, 22)
        Me.TxtID.TabIndex = 11
        Me.TxtID.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(220, 29)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "TREATMENT LIST"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(819, 378)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(132, 22)
        Me.txtname.TabIndex = 99
        Me.txtname.Visible = False
        '
        'FrmTreatmentMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1124, 777)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BttnClose)
        Me.Controls.Add(Me.BttnDelete)
        Me.Controls.Add(Me.BttnEdit)
        Me.Controls.Add(Me.BttnAdd)
        Me.Controls.Add(Me.DGVTreat)
        Me.Controls.Add(Me.TxtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTreatmentMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTreatmentMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVTreat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BttnClose As System.Windows.Forms.Button
    Friend WithEvents BttnDelete As System.Windows.Forms.Button
    Friend WithEvents BttnEdit As System.Windows.Forms.Button
    Friend WithEvents BttnAdd As System.Windows.Forms.Button
    Friend WithEvents DGVTreat As System.Windows.Forms.DataGridView
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
End Class
