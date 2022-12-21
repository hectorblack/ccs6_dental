Imports IBM.Data.DB2
Imports System.Data.SqlClient

Public Class FrmBackupRestore

    Private Conn As Common.DbConnection

    Private Sub Forml_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
            Conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            Dim backplace As String
            Dim str As String
            Dim cmd As DB2Command
            backplace = "C:\DentalBackups"

            If Not System.IO.Directory.Exists("C:\DentalBackups") Then
                System.IO.Directory.CreateDirectory("C:\DentalBackups")
            End If

            ' Dim sfd As New SaveFileDialog() With {
            ' .Filter = "Backup File | *.001",
            ' .FileName = ""
            ' }

            ' If sfd.ShowDialog = DialogResult.OK Then
            Cursor = Cursors.WaitCursor
            ' Dim str As String = "backup database dental to disk = {sfd.FileName}"


            str = "select patientnumber from patient "

            cmd = New DB2Command(str, Conn)

            cmd.ExecuteScalar()

            MsgBox("BACKUP COMPLETE")
            Cursor = Cursors.Default
            '  End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnRestore_click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Try
            Dim ofd As New OpenFileDialog With {
            .Filter = "Backup File | *.001",
            .FileName = ""
            }

            If ofd.ShowDialog = DialogResult.OK Then
                Cursor = Cursors.WaitCursor

                Dim str As String = "restore database dental from disk = '{ofd.FileName)'"
                Dim cmd As New DB2Command(str, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Restore complete")
                Cursor = Cursors.Default
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BttnClose_Click(sender As Object, e As EventArgs) Handles BttnClose.Click
        FrmHome.switchPanel(FrmSettingsMain)
    End Sub
End Class