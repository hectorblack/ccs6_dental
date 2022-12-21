<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStaffMain
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
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BttnClose = New System.Windows.Forms.Button()
        Me.BttnDelete = New System.Windows.Forms.Button()
        Me.BttnEdit = New System.Windows.Forms.Button()
        Me.BttnAdd = New System.Windows.Forms.Button()
        Me.DGVUserDet = New System.Windows.Forms.DataGridView()
        CType(Me.DGVUserDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(345, 24)
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
        Me.Label10.Size = New System.Drawing.Size(90, 29)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "STAFF"
        '
        'BttnClose
        '
        Me.BttnClose.BackColor = System.Drawing.Color.DarkOrchid
        Me.BttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnClose.ForeColor = System.Drawing.Color.White
        Me.BttnClose.Location = New System.Drawing.Point(73, 78)
        Me.BttnClose.Name = "BttnClose"
        Me.BttnClose.Size = New System.Drawing.Size(109, 39)
        Me.BttnClose.TabIndex = 88
        Me.BttnClose.Text = "CLOSE"
        Me.BttnClose.UseVisualStyleBackColor = False
        '
        'BttnDelete
        '
        Me.BttnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BttnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnDelete.ForeColor = System.Drawing.Color.White
        Me.BttnDelete.Location = New System.Drawing.Point(778, 78)
        Me.BttnDelete.Name = "BttnDelete"
        Me.BttnDelete.Size = New System.Drawing.Size(89, 39)
        Me.BttnDelete.TabIndex = 87
        Me.BttnDelete.Text = "DELETE"
        Me.BttnDelete.UseVisualStyleBackColor = False
        '
        'BttnEdit
        '
        Me.BttnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BttnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnEdit.ForeColor = System.Drawing.Color.White
        Me.BttnEdit.Location = New System.Drawing.Point(873, 78)
        Me.BttnEdit.Name = "BttnEdit"
        Me.BttnEdit.Size = New System.Drawing.Size(89, 39)
        Me.BttnEdit.TabIndex = 86
        Me.BttnEdit.Text = "EDIT"
        Me.BttnEdit.UseVisualStyleBackColor = False
        '
        'BttnAdd
        '
        Me.BttnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnAdd.ForeColor = System.Drawing.Color.White
        Me.BttnAdd.Location = New System.Drawing.Point(968, 78)
        Me.BttnAdd.Name = "BttnAdd"
        Me.BttnAdd.Size = New System.Drawing.Size(89, 39)
        Me.BttnAdd.TabIndex = 85
        Me.BttnAdd.Text = "ADD"
        Me.BttnAdd.UseVisualStyleBackColor = False
        '
        'DGVUserDet
        '
        Me.DGVUserDet.AllowUserToAddRows = False
        Me.DGVUserDet.AllowUserToDeleteRows = False
        Me.DGVUserDet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVUserDet.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVUserDet.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVUserDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(196, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVUserDet.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVUserDet.GridColor = System.Drawing.Color.Black
        Me.DGVUserDet.Location = New System.Drawing.Point(73, 133)
        Me.DGVUserDet.Name = "DGVUserDet"
        Me.DGVUserDet.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVUserDet.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVUserDet.RowHeadersVisible = False
        Me.DGVUserDet.RowTemplate.Height = 24
        Me.DGVUserDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVUserDet.Size = New System.Drawing.Size(984, 607)
        Me.DGVUserDet.TabIndex = 89
        '
        'FrmStaffMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1124, 777)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVUserDet)
        Me.Controls.Add(Me.BttnClose)
        Me.Controls.Add(Me.BttnDelete)
        Me.Controls.Add(Me.BttnEdit)
        Me.Controls.Add(Me.BttnAdd)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmStaffMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmStaffMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVUserDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BttnClose As System.Windows.Forms.Button
    Friend WithEvents BttnDelete As System.Windows.Forms.Button
    Friend WithEvents BttnEdit As System.Windows.Forms.Button
    Friend WithEvents BttnAdd As System.Windows.Forms.Button
    Friend WithEvents DGVUserDet As System.Windows.Forms.DataGridView
End Class
