Imports IBM.Data.DB2
Public Class FrmLogin
    Private LoginConn As Common.DbConnection

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginConn = New DB2Connection("server=localhost;database=dental;" + "uid=db2admin;password=db2admin;")
        LoginConn.Open()
        formRoundCorners(Me)
        buttonRound(btnLogin)
    End Sub

    Public Sub MsgBox(Text As String)
        MessageBox.Show(Text)
    End Sub


    Private Sub BtnLogin_click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            Dim StrLogin As String
            Dim CmdLogin As DB2Command
            Dim RdrLogin As DB2DataReader

            Dim VUserName As String
            Dim VUserPass As String

            Dim first3 As String
            Dim temp As String
            temp = userbox.Text
            first3 = temp.Substring(0, 3)

            If first3 = "020" Then
                StrLogin = "select * from  dentist where dentistid='" & Me.userbox.Text & "' " _
                                           & "And dentistpass ='" & Me.passwordbox.Text & "'"

                CmdLogin = New DB2Command(StrLogin, LoginConn)
                RdrLogin = CmdLogin.ExecuteReader
                RdrLogin.Read()

                If RdrLogin.HasRows Then

                    VUserName = RdrLogin.GetString(0)
                    VUserPass = RdrLogin.GetString(4)
                    MsgBox("Welcome Dr." & RdrLogin.GetString(1).ToString)
                    FrmHome.isDentist = True

                    FrmHome.Show()
                    Me.Hide()
                Else
                    MsgBox("UserID and/or password are invalid...")
                End If

            ElseIf first3 = "025" Then

                StrLogin = "select * from  staff where staffid='" & Me.userbox.Text & "' " _
                                          & "And staffpassword ='" & Me.passwordbox.Text & "'"

                CmdLogin = New DB2Command(StrLogin, LoginConn)
                RdrLogin = CmdLogin.ExecuteReader
                RdrLogin.Read()

                If RdrLogin.HasRows Then

                    VUserName = RdrLogin.GetString(0)
                    VUserPass = RdrLogin.GetString(3)
                    MsgBox("Welcome " & RdrLogin.GetString(1).ToString)

                    FrmHome.isDentist = False

                    FrmHome.Show()
                    Me.Hide()

                Else
                    MsgBox("UserID and/or password are invalid...")

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        LoginConn.Close()
        Me.Close()
    End Sub

    Private Sub userbox_MouseEnter(sender As Object, e As EventArgs) Handles userbox.MouseClick
        userbox.ForeColor = Color.Black
        userbox.Text = ""
    End Sub

    Private Sub passwordbox_MouseEnter(sender As Object, e As EventArgs) Handles passwordbox.MouseClick
        passwordbox.PasswordChar = "*"
        passwordbox.ForeColor = Color.Black
        passwordbox.Text = ""
    End Sub


End Class