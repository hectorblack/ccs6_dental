Imports IBM.Data.DB2
Public Class FrmSettingsMain
    Private Conn As Common.DbConnection
    Private Sub FrmSettingsMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()

    End Sub

    Private Sub btnTreatment_Click(sender As Object, e As EventArgs) Handles btnTreatment.Click
        Me.Close()
        FrmHome.switchPanel(FrmTreatmentMain)
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Me.Close()
        FrmHome.switchPanel(FrmStaffMain)
    End Sub

    Private Sub btnDentist_Click(sender As Object, e As EventArgs) Handles btnDentist.Click
        Me.Close()
        FrmHome.switchPanel(FrmDentistMain)
    End Sub

    Private Sub btnBackupRestore_Click(sender As Object, e As EventArgs)
        Me.Close()
        FrmHome.switchPanel(FrmBackupRestore)
    End Sub


  
End Class