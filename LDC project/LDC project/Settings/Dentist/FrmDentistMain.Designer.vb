<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDentistMain
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DentPhone = New System.Windows.Forms.TextBox()
        Me.DentAdd = New System.Windows.Forms.TextBox()
        Me.PTRNum = New System.Windows.Forms.TextBox()
        Me.DentName = New System.Windows.Forms.TextBox()
        Me.DentPass = New System.Windows.Forms.TextBox()
        Me.LicNum = New System.Windows.Forms.TextBox()
        Me.DentID = New System.Windows.Forms.TextBox()
        Me.BttnClose = New System.Windows.Forms.Button()
        Me.BttnUpdate = New System.Windows.Forms.Button()
        Me.open = New System.Windows.Forms.Button()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 29)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "DENTIST"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(117, 343)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 25)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Dentist Phone Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(117, 257)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 25)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Dentist Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(648, 195)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 25)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "PTR Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(648, 147)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 25)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "License Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 400)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 25)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Dentist Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 200)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Dentist Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 149)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 25)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Dentist ID"
        '
        'DentPhone
        '
        Me.DentPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DentPhone.Location = New System.Drawing.Point(333, 343)
        Me.DentPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.DentPhone.Name = "DentPhone"
        Me.DentPhone.ReadOnly = True
        Me.DentPhone.Size = New System.Drawing.Size(221, 30)
        Me.DentPhone.TabIndex = 94
        '
        'DentAdd
        '
        Me.DentAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DentAdd.Location = New System.Drawing.Point(275, 254)
        Me.DentAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.DentAdd.Multiline = True
        Me.DentAdd.Name = "DentAdd"
        Me.DentAdd.ReadOnly = True
        Me.DentAdd.Size = New System.Drawing.Size(279, 63)
        Me.DentAdd.TabIndex = 93
        '
        'PTRNum
        '
        Me.PTRNum.Enabled = False
        Me.PTRNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PTRNum.Location = New System.Drawing.Point(781, 195)
        Me.PTRNum.Margin = New System.Windows.Forms.Padding(4)
        Me.PTRNum.Name = "PTRNum"
        Me.PTRNum.ReadOnly = True
        Me.PTRNum.Size = New System.Drawing.Size(221, 30)
        Me.PTRNum.TabIndex = 92
        '
        'DentName
        '
        Me.DentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DentName.Location = New System.Drawing.Point(254, 200)
        Me.DentName.Margin = New System.Windows.Forms.Padding(4)
        Me.DentName.Name = "DentName"
        Me.DentName.ReadOnly = True
        Me.DentName.Size = New System.Drawing.Size(300, 30)
        Me.DentName.TabIndex = 91
        '
        'DentPass
        '
        Me.DentPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DentPass.Location = New System.Drawing.Point(288, 397)
        Me.DentPass.Margin = New System.Windows.Forms.Padding(4)
        Me.DentPass.Name = "DentPass"
        Me.DentPass.ReadOnly = True
        Me.DentPass.Size = New System.Drawing.Size(221, 30)
        Me.DentPass.TabIndex = 90
        '
        'LicNum
        '
        Me.LicNum.Enabled = False
        Me.LicNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicNum.Location = New System.Drawing.Point(810, 144)
        Me.LicNum.Margin = New System.Windows.Forms.Padding(4)
        Me.LicNum.Name = "LicNum"
        Me.LicNum.ReadOnly = True
        Me.LicNum.Size = New System.Drawing.Size(221, 30)
        Me.LicNum.TabIndex = 89
        '
        'DentID
        '
        Me.DentID.Enabled = False
        Me.DentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DentID.Location = New System.Drawing.Point(221, 146)
        Me.DentID.Margin = New System.Windows.Forms.Padding(4)
        Me.DentID.Name = "DentID"
        Me.DentID.ReadOnly = True
        Me.DentID.Size = New System.Drawing.Size(221, 30)
        Me.DentID.TabIndex = 88
        '
        'BttnClose
        '
        Me.BttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnClose.Location = New System.Drawing.Point(548, 511)
        Me.BttnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BttnClose.Name = "BttnClose"
        Me.BttnClose.Size = New System.Drawing.Size(245, 43)
        Me.BttnClose.TabIndex = 87
        Me.BttnClose.Text = "CANCEL"
        Me.BttnClose.UseVisualStyleBackColor = True
        Me.BttnClose.Visible = False
        '
        'BttnUpdate
        '
        Me.BttnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnUpdate.Location = New System.Drawing.Point(810, 511)
        Me.BttnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.BttnUpdate.Name = "BttnUpdate"
        Me.BttnUpdate.Size = New System.Drawing.Size(245, 43)
        Me.BttnUpdate.TabIndex = 86
        Me.BttnUpdate.Text = "UPDATE"
        Me.BttnUpdate.UseVisualStyleBackColor = True
        '
        'open
        '
        Me.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.open.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.open.Location = New System.Drawing.Point(810, 511)
        Me.open.Margin = New System.Windows.Forms.Padding(4)
        Me.open.Name = "open"
        Me.open.Size = New System.Drawing.Size(245, 43)
        Me.open.TabIndex = 103
        Me.open.Text = "UPDATE."
        Me.open.UseVisualStyleBackColor = True
        '
        'btnreturn
        '
        Me.btnreturn.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn.ForeColor = System.Drawing.Color.White
        Me.btnreturn.Location = New System.Drawing.Point(46, 78)
        Me.btnreturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(116, 35)
        Me.btnreturn.TabIndex = 104
        Me.btnreturn.Text = "CLOSE"
        Me.btnreturn.UseVisualStyleBackColor = False
        '
        'FrmDentistMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1124, 777)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.open)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DentPhone)
        Me.Controls.Add(Me.DentAdd)
        Me.Controls.Add(Me.PTRNum)
        Me.Controls.Add(Me.DentName)
        Me.Controls.Add(Me.DentPass)
        Me.Controls.Add(Me.LicNum)
        Me.Controls.Add(Me.DentID)
        Me.Controls.Add(Me.BttnClose)
        Me.Controls.Add(Me.BttnUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDentistMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDentistMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DentPhone As System.Windows.Forms.TextBox
    Friend WithEvents DentAdd As System.Windows.Forms.TextBox
    Friend WithEvents PTRNum As System.Windows.Forms.TextBox
    Friend WithEvents DentName As System.Windows.Forms.TextBox
    Friend WithEvents DentPass As System.Windows.Forms.TextBox
    Friend WithEvents LicNum As System.Windows.Forms.TextBox
    Friend WithEvents DentID As System.Windows.Forms.TextBox
    Friend WithEvents BttnClose As System.Windows.Forms.Button
    Friend WithEvents BttnUpdate As System.Windows.Forms.Button
    Friend WithEvents open As System.Windows.Forms.Button
    Friend WithEvents btnreturn As System.Windows.Forms.Button
End Class
