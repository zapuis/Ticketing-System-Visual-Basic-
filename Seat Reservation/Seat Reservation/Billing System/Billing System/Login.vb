Imports System.Data.OleDb
Public Class Login
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        End
    End Sub
    Private Sub login()
        Try
            sqL = "SELECT * FROM staff WHERE username = '" & txtUsername.Text & "' AND password = '" & txtPassword.Text & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                Me.Hide()
                Main.Show()
                MessageBox.Show("Successful Login", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MsgBox("Welcome", MsgBoxStyle.Information, "Login Report")
            Else
                MessageBox.Show("Incorrect Username or Password", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
            conn.Dispose()
        End Try
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Login()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        AddUser.Show()
    End Sub
End Class
