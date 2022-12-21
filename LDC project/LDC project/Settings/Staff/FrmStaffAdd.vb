Imports IBM.Data.DB2
Public Class FrmStaffAdd
    Private Conn As Common.DbConnection
    Private Sub FrmStaffAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        Conn.Open()

        Call Me.IDGenerate()
    End Sub
    Private Sub IDGenerate()
        Try
            Dim first2 As String = "02"
            Dim last2yr As String = Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Substring(Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Length - 2, 2)

            Dim StaffNew As String
            Dim StaffEntry As String
            Dim StaffNum As Integer

            Dim RdrDrg As DB2DataReader
            Dim cmdRetrieve As DB2Command
            Dim SelectStr As String

            SelectStr = "select staffid from staff"
            cmdRetrieve = New DB2Command(SelectStr, Conn)
            RdrDrg = cmdRetrieve.ExecuteReader


            While RdrDrg.Read()
                StaffEntry = RdrDrg.GetString(0)

            End While

            StaffNew = StaffEntry.Substring(StaffEntry.Length - 4)
            StaffNum = Convert.ToInt32(StaffNew) + 1

            Dim staffstring = Convert.ToString(StaffNum)

            If (staffstring.Length = 1) Then
                staffstring = "000" & StaffNum

            ElseIf (staffstring.Length = 2) Then
                staffstring = "00" & StaffNum

            ElseIf (staffstring.Length = 3) Then
                staffstring = "0" & StaffNum

            ElseIf (staffstring.Length = 4) Then
                staffstring = StaffNum

            End If


            Dim staffid As String = (first2 & last2yr & staffstring)

            Me.StaffIDBox.Text = staffid

            RdrDrg.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BttnSave_Click(sender As Object, e As EventArgs) Handles BttnSave.Click
        Try

            If Me.StaffNameBox.Text Is String.Empty Or Me.StaffPassBox.Text Is String.Empty Or Me.StaffPhoneBox.Text Is String.Empty Or Me.StaffAddressBox.Text Is String.Empty Then
                MsgBox("Input all fields")
            Else

                Dim StaffID As String
                Dim StaffName As String
                Dim StaffPass As String
                Dim StaffPhone As String
                Dim StaffAddress As String

                Dim InsertStr As String
                Dim CmdInsert As DB2Command

                StaffID = Me.StaffIDBox.Text
                StaffName = Me.StaffNameBox.Text
                StaffPass = Me.StaffPassBox.Text
                StaffPhone = Me.StaffPhoneBox.Text
                StaffAddress = Me.StaffAddressBox.Text

                InsertStr = "insert into staff values('" & StaffID & "', '" & StaffName & "', '" & StaffPass & "','" & StaffPhone & "','" & StaffAddress & "')"

                CmdInsert = New DB2Command(InsertStr, Conn)
                CmdInsert.ExecuteNonQuery()

                MsgBox("The record was successfully added...")

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

    Private Sub BttnClose_Click(sender As Object, e As EventArgs) Handles BttnClose.Click
        Me.Close()
        FrmHome.switchPanel(FrmStaffMain)
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