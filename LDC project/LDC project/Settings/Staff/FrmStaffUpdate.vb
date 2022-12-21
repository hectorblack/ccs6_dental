Imports IBM.Data.DB2
Public Class FrmStaffUpdate
    Private Conn As Common.DbConnection
    Private Sub FrmStaffUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            textid = Me.StaffIDBox.Text
            SelectStr = "select * from staff where staffid =  '" & textid & "'"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader
            While RdrDrg.Read
                StaffIDBox.Text = RdrDrg.GetDB2String(0).ToString
                StaffNameBox.Text = RdrDrg.GetDB2String(1).ToString
                StaffPassBox.Text = RdrDrg.GetDB2String(2).ToString
                StaffPhoneBox.Text = RdrDrg.GetDB2String(3).ToString
                StaffAddressBox.Text = RdrDrg.GetDB2String(4).ToString
            End While

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BttnClose_Click(sender As Object, e As EventArgs) Handles BttnClose.Click
        Me.Close()
        FrmHome.switchPanel(FrmStaffMain)
    End Sub

    Private Sub BttnUpdate_Click(sender As Object, e As EventArgs) Handles BttnSave.Click
        Try
            If Me.StaffNameBox.Text Is String.Empty Or Me.StaffPassBox.Text Is String.Empty Or Me.StaffPhoneBox.Text Is String.Empty Or Me.StaffAddressBox.Text Is String.Empty Then
                MsgBox("Input all fields")
            Else
                Dim StrUpdate As String
                Dim CmdUpdate As DB2Command

                Dim StaffID As String
                Dim StaffName As String
                Dim StaffPass As String
                Dim StaffPhone As String
                Dim StaffAddress As String

                StaffID = Me.StaffIDBox.Text
                StaffName = Me.StaffNameBox.Text
                StaffPass = Me.StaffPassBox.Text
                StaffPhone = Me.StaffPhoneBox.Text
                StaffAddress = Me.StaffAddressBox.Text

                StrUpdate = "update staff set staffname = '" & StaffName & "', staffpassword = '" & StaffPass & "', staffphone = '" & StaffPhone & "', staffaddress= '" & StaffAddress & "'where staffid='" & StaffID & "'"
                CmdUpdate = New DB2Command(StrUpdate, Conn)
                CmdUpdate.ExecuteNonQuery()
                MsgBox("Record was updated successfully...")

                If Application.OpenForms().OfType(Of FrmStaffMain).Any Then
                    Call FrmStaffMain.Refresh_Datagrid()
                End If

                Me.Close()
                FrmHome.switchPanel(FrmStaffMain)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSave_MouseEnter(sender As Object, e As EventArgs) Handles BttnSave.MouseEnter
        BttnSave.BackColor = Color.FromArgb(51, 224, 196)
        BttnSave.ForeColor = Color.White
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles BttnSave.MouseLeave
        BttnSave.BackColor = Color.White
        BttnSave.ForeColor = Color.Black
    End Sub
 
End Class