Imports IBM.Data.DB2
Imports System.Drawing.Drawing2D

Public Class FrmHome
    'Inherits FrmLogin
    Public isDentist As Boolean
    Private Conn As Common.DbConnection
        Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If isDentist = False Then
        'MsgBox("is dentist")
        ' Else
        'MsgBox("is not dentist")
        'End If

        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()

        formRoundCorners(Me)
 
        'gradientPanel(Me.PanelNavigation)
        'panelRound(Me.PanelNavigation)

        'PanelLogout.Visible = False
        'buttonRound(Me.btnLogout)

        'PanelReports.Visible = False

        If isDentist = False Then
            btnReports.Visible = False
            btnSettings.Visible = False
            FrmViewPatient.BtnViewTreatmentPlan.Visible = False
            FrmViewPatient.BtnNewProcedure.Visible = False
            FrmViewPatient.BtnPrescriptions.Visible = False
        End If

    End Sub

    Private Sub PicBtnLogout_click(sender As Object, e As EventArgs) Handles PicBtnLogout.Click
        'Call showPanel(PanelLogout)
        Conn.Close()
        Me.Close()
        FrmLogin.Show()
    End Sub

    Public Sub switchPanel(ByVal panel As Form)
        Me.Panel.Controls.Clear()
        panel.TopLevel = False
        Me.Panel.Controls.Add(panel)
        panel.Show()
    End Sub
    

    Public Sub MsgBox(Text As String)
        MessageBox.Show(Text)
    End Sub


    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        ClearColors()
        btnAppointment.BackColor = Color.FromArgb(51, 224, 196)
        btnAppointment.ForeColor = Color.Black
        Call Me.switchPanel(FrmAppointmentGraphical)

    End Sub

    Private Sub btnPatients_Click(sender As Object, e As EventArgs) Handles btnPatients.Click
        ClearColors()
        btnPatients.BackColor = Color.FromArgb(51, 224, 196)
        btnPatients.ForeColor = Color.Black
        Call Me.switchPanel(FrmPatientMain)
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        ClearColors()
        btnBilling.BackColor = Color.FromArgb(51, 224, 196)
        btnBilling.ForeColor = Color.Black
        Call Me.switchPanel(FrmBillingMain)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ClearColors()
        btnReports.BackColor = Color.FromArgb(51, 224, 196)
        btnReports.ForeColor = Color.Black
        Call Me.switchPanel(FrmWeeklyReports)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        ClearColors()
        btnSettings.BackColor = Color.FromArgb(51, 224, 196)
        btnSettings.ForeColor = Color.Black
        Call Me.switchPanel(FrmSettingsMain)
    End Sub
    '
    Private Sub ClearColors()
        btnAppointment.BackColor = Color.FromArgb(53, 58, 64)
        btnAppointment.ForeColor = Color.White

        btnPatients.BackColor = Color.FromArgb(53, 58, 64)
        btnPatients.ForeColor = Color.White

        btnBilling.BackColor = Color.FromArgb(53, 58, 64)
        btnBilling.ForeColor = Color.White

        btnReports.BackColor = Color.FromArgb(53, 58, 64)
        btnReports.ForeColor = Color.White

        btnSettings.BackColor = Color.FromArgb(53, 58, 64)
        btnSettings.ForeColor = Color.White
    End Sub


End Class