<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTreatmentUpdate
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
        Me.BttnSave = New System.Windows.Forms.Button()
        Me.BttnClose = New System.Windows.Forms.Button()
        Me.TreatNameBox = New System.Windows.Forms.TextBox()
        Me.TreatNumBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(375, 29)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "UPDATE TREATMENT RECORD"
        '
        'BttnSave
        '
        Me.BttnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnSave.Location = New System.Drawing.Point(436, 342)
        Me.BttnSave.Name = "BttnSave"
        Me.BttnSave.Size = New System.Drawing.Size(245, 43)
        Me.BttnSave.TabIndex = 88
        Me.BttnSave.Text = "UPDATE RECORD"
        Me.BttnSave.UseVisualStyleBackColor = True
        '
        'BttnClose
        '
        Me.BttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnClose.Location = New System.Drawing.Point(171, 342)
        Me.BttnClose.Name = "BttnClose"
        Me.BttnClose.Size = New System.Drawing.Size(245, 43)
        Me.BttnClose.TabIndex = 87
        Me.BttnClose.Text = "CANCEL"
        Me.BttnClose.UseVisualStyleBackColor = True
        '
        'TreatNameBox
        '
        Me.TreatNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreatNameBox.Location = New System.Drawing.Point(319, 215)
        Me.TreatNameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TreatNameBox.MaxLength = 20
        Me.TreatNameBox.Name = "TreatNameBox"
        Me.TreatNameBox.Size = New System.Drawing.Size(318, 30)
        Me.TreatNameBox.TabIndex = 86
        '
        'TreatNumBox
        '
        Me.TreatNumBox.Enabled = False
        Me.TreatNumBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreatNumBox.Location = New System.Drawing.Point(319, 158)
        Me.TreatNumBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TreatNumBox.Name = "TreatNumBox"
        Me.TreatNumBox.Size = New System.Drawing.Size(255, 30)
        Me.TreatNumBox.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 215)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 25)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Treatment Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(136, 158)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 25)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Treatment Number"
        '
        'FrmTreatmentUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1124, 777)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BttnSave)
        Me.Controls.Add(Me.BttnClose)
        Me.Controls.Add(Me.TreatNameBox)
        Me.Controls.Add(Me.TreatNumBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTreatmentUpdate"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTreatmentUpdate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BttnSave As System.Windows.Forms.Button
    Friend WithEvents BttnClose As System.Windows.Forms.Button
    Friend WithEvents TreatNameBox As System.Windows.Forms.TextBox
    Friend WithEvents TreatNumBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
