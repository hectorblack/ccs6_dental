Imports IBM.Data.DB2
Public Class FrmDentistUpdate
    Private Conn As Common.DbConnection
    Private Sub FrmDentistUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()

        Call Me.textbox()
    End Sub
    Private Sub textbox()
        Try
            Dim RdrDrg As DB2DataReader
            Dim SelectStr As String
            Dim cmdRetrieve As DB2Command
            Dim textid As String

            SelectStr = "select * from dentist where dentistid =  '" & textid & "'"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader

            While RdrDrg.Read
                DentID.Text = RdrDrg.GetDB2String(0).ToString
                DentName.Text = RdrDrg.GetDB2String(1).ToString
                DentPass.Text = RdrDrg.GetDB2String(2).ToString
                LicNum.Text = RdrDrg.GetDB2String(3).ToString
                PTRNum.Text = RdrDrg.GetDB2String(4).ToString
                DentAdd.Text = RdrDrg.GetDB2String(5).ToString
                DentPhone.Text = RdrDrg.GetDB2String(6).ToString
            End While

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub BttnClose_Click(sender As Object, e As EventArgs) Handles BttnClose.Click
        Me.Close()
        FrmHome.switchPanel(FrmDentistMain)
    End Sub

    Private Sub BttnUpdate_Click(sender As Object, e As EventArgs) Handles BttnUpdate.Click
        Try
            Dim StrUpdate As String
            Dim CmdUpdate As DB2Command

            Dim DentistID As String
            Dim DentistName As String
            Dim DentistPass As String
            Dim DentistAddress As String
            Dim DentistPhone As String

            DentistID = Me.DentID.Text
            DentistName = Me.DentName.Text
            DentistPass = Me.DentPass.Text
            DentistAddress = Me.DentAdd.Text
            DentistPhone = Me.DentPhone.Text

            StrUpdate = "update dentist set dentistname = '" & DentistName & "', dentistpass = '" & DentistPass & "', dentaddress= '" & DentistAddress & "', dentphonenumber= '" & DentistPhone & "'where dentistid='" & DentistID & "'"
            CmdUpdate = New DB2Command(StrUpdate, Conn)
            CmdUpdate.ExecuteNonQuery()
            MsgBox("Record was updated successfully...")

            '   Call FrmDentistMain.Refresh_Datagrid()
            Me.Close()
            FrmHome.switchPanel(FrmDentistMain)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSave_MouseEnter(sender As Object, e As EventArgs) Handles BttnUpdate.MouseEnter
        BttnUpdate.BackColor = Color.FromArgb(51, 224, 196)
        BttnUpdate.ForeColor = Color.White
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles BttnUpdate.MouseLeave
        BttnUpdate.BackColor = Color.White
        BttnUpdate.ForeColor = Color.Black
    End Sub
End Class