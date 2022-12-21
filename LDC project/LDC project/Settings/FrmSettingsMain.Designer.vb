<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettingsMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettingsMain))
        Me.btnDentist = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnTreatment = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDentist
        '
        Me.btnDentist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDentist.FlatAppearance.BorderSize = 0
        Me.btnDentist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDentist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDentist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDentist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDentist.Image = CType(resources.GetObject("btnDentist.Image"), System.Drawing.Image)
        Me.btnDentist.Location = New System.Drawing.Point(291, 170)
        Me.btnDentist.Name = "btnDentist"
        Me.btnDentist.Size = New System.Drawing.Size(186, 202)
        Me.btnDentist.TabIndex = 0
        Me.btnDentist.Text = "Account Details"
        Me.btnDentist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDentist.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStaff.FlatAppearance.BorderSize = 0
        Me.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.Image = CType(resources.GetObject("btnStaff.Image"), System.Drawing.Image)
        Me.btnStaff.Location = New System.Drawing.Point(474, 170)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(361, 202)
        Me.btnStaff.TabIndex = 1
        Me.btnStaff.Text = "Manage User Details"
        Me.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnTreatment
        '
        Me.btnTreatment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTreatment.FlatAppearance.BorderSize = 0
        Me.btnTreatment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTreatment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTreatment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTreatment.Image = CType(resources.GetObject("btnTreatment.Image"), System.Drawing.Image)
        Me.btnTreatment.Location = New System.Drawing.Point(433, 378)
        Me.btnTreatment.Name = "btnTreatment"
        Me.btnTreatment.Size = New System.Drawing.Size(186, 202)
        Me.btnTreatment.TabIndex = 2
        Me.btnTreatment.Text = "Treatment List"
        Me.btnTreatment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTreatment.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 29)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "SETTINGS"
        '
        'FrmSettingsMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1124, 777)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnTreatment)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.btnDentist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSettingsMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSettings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDentist As System.Windows.Forms.Button
    Friend WithEvents btnStaff As System.Windows.Forms.Button
    Friend WithEvents btnTreatment As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
