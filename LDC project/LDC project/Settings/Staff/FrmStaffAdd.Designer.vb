<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStaffAdd
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StaffPhoneBox = New System.Windows.Forms.TextBox()
        Me.StaffAddressBox = New System.Windows.Forms.TextBox()
        Me.StaffPassBox = New System.Windows.Forms.TextBox()
        Me.StaffNameBox = New System.Windows.Forms.TextBox()
        Me.StaffIDBox = New System.Windows.Forms.TextBox()
        Me.BttnSave = New System.Windows.Forms.Button()
        Me.BttnClose = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(227, 363)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 25)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Staff Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(227, 302)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 25)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Staff Phone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(227, 243)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 25)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Staff Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(227, 178)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Staff Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 122)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Staff ID"
        '
        'StaffPhoneBox
        '
        Me.StaffPhoneBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffPhoneBox.Location = New System.Drawing.Point(380, 299)
        Me.StaffPhoneBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StaffPhoneBox.MaxLength = 13
        Me.StaffPhoneBox.Name = "StaffPhoneBox"
        Me.StaffPhoneBox.Size = New System.Drawing.Size(263, 30)
        Me.StaffPhoneBox.TabIndex = 30
        '
        'StaffAddressBox
        '
        Me.StaffAddressBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffAddressBox.Location = New System.Drawing.Point(380, 363)
        Me.StaffAddressBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StaffAddressBox.MaxLength = 50
        Me.StaffAddressBox.Name = "StaffAddressBox"
        Me.StaffAddressBox.Size = New System.Drawing.Size(263, 30)
        Me.StaffAddressBox.TabIndex = 29
        '
        'StaffPassBox
        '
        Me.StaffPassBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffPassBox.Location = New System.Drawing.Point(380, 240)
        Me.StaffPassBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StaffPassBox.MaxLength = 20
        Me.StaffPassBox.Name = "StaffPassBox"
        Me.StaffPassBox.Size = New System.Drawing.Size(263, 30)
        Me.StaffPassBox.TabIndex = 28
        '
        'StaffNameBox
        '
        Me.StaffNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffNameBox.Location = New System.Drawing.Point(380, 175)
        Me.StaffNameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StaffNameBox.MaxLength = 30
        Me.StaffNameBox.Name = "StaffNameBox"
        Me.StaffNameBox.Size = New System.Drawing.Size(263, 30)
        Me.StaffNameBox.TabIndex = 27
        '
        'StaffIDBox
        '
        Me.StaffIDBox.Enabled = False
        Me.StaffIDBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffIDBox.Location = New System.Drawing.Point(380, 117)
        Me.StaffIDBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StaffIDBox.MaxLength = 8
        Me.StaffIDBox.Name = "StaffIDBox"
        Me.StaffIDBox.Size = New System.Drawing.Size(263, 30)
        Me.StaffIDBox.TabIndex = 26
        '
        'BttnSave
        '
        Me.BttnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnSave.Location = New System.Drawing.Point(459, 501)
        Me.BttnSave.Name = "BttnSave"
        Me.BttnSave.Size = New System.Drawing.Size(245, 43)
        Me.BttnSave.TabIndex = 83
        Me.BttnSave.Text = "ADD NEW STAFF"
        Me.BttnSave.UseVisualStyleBackColor = True
        '
        'BttnClose
        '
        Me.BttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnClose.Location = New System.Drawing.Point(208, 501)
        Me.BttnClose.Name = "BttnClose"
        Me.BttnClose.Size = New System.Drawing.Size(245, 43)
        Me.BttnClose.TabIndex = 82
        Me.BttnClose.Text = "CANCEL"
        Me.BttnClose.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(207, 29)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "ADD NEW STAFF"
        '
        'FrmStaffAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1124, 777)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BttnSave)
        Me.Controls.Add(Me.BttnClose)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StaffPhoneBox)
        Me.Controls.Add(Me.StaffAddressBox)
        Me.Controls.Add(Me.StaffPassBox)
        Me.Controls.Add(Me.StaffNameBox)
        Me.Controls.Add(Me.StaffIDBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmStaffAdd"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmStaffAdd"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StaffPhoneBox As System.Windows.Forms.TextBox
    Friend WithEvents StaffAddressBox As System.Windows.Forms.TextBox
    Friend WithEvents StaffPassBox As System.Windows.Forms.TextBox
    Friend WithEvents StaffNameBox As System.Windows.Forms.TextBox
    Friend WithEvents StaffIDBox As System.Windows.Forms.TextBox
    Friend WithEvents BttnSave As System.Windows.Forms.Button
    Friend WithEvents BttnClose As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
