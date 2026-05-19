Imports System.Data.OleDb
Public Class AddUser

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub AddUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
    Private Sub addstaff()
        Try
            Dim cn As New OleDbConnection
            cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Billing System\BillingData.mdb;"
            cn.Open()

            Dim cmd As New OleDbCommand
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO staff([username],[password],[staffname],[position],[department]) VALUES(" & _
            "'" & Me.txtNewUser.Text & "'," & _
            "'" & Me.txtNewPass.Text & "'," & _
            "'" & Me.txtName.Text & "'," & _
            "'" & Me.txtPosition.Text & "'," & _
            "'" & Me.txtDept.Text & "')"
            'cmd.CommandText = "INSERT INTO staff([username],[password]) VALUES('armand','123')"
            txtNewPass.Text = ""
            txtConfirmPass.Text = ""
            txtNewUser.Text = ""
            txtName.Text = ""
            txtPosition.Text = ""
            txtDept.Text = ""
            MessageBox.Show("Successfully Save!", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub chkstaffusername()
        Try
            sqL = "SELECT username FROM staff WHERE [username] = '" & Trim(txtNewUser.Text) & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.HasRows Then
                MessageBox.Show("User Name Already Exist, Try Another One", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'MessageBox.Show("Save mo Na", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                addstaff()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please enter your Name.", "No Name", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtName.Focus()
        ElseIf txtPosition.Text = "" Then
            MessageBox.Show("Please enter your Position.", "No Position", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtPosition.Focus()
        ElseIf txtDept.Text = "" Then
            MessageBox.Show("Please enter your Department.", "No Department", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtDept.Focus()
        ElseIf txtNewUser.Text = "" Then
            MessageBox.Show("Please enter your username.", "No Username", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtNewUser.Focus()
        ElseIf txtNewPass.Text = "" Then
            MessageBox.Show("Please enter your password.", "No Password", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtNewPass.Focus()
        ElseIf txtNewPass.TextLength < 5 Then
            MessageBox.Show("Your password must be at least 5 characters", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNewPass.Focus()
        ElseIf txtConfirmPass.Text = "" Then
            MessageBox.Show("Please Re-enter your password", "Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtConfirmPass.Focus()
        ElseIf txtNewPass.Text <> txtConfirmPass.Text Then
            MessageBox.Show("Password does not match", "Different Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirmPass.Focus()
        Else
            'MessageBox.Show("Successful Add User", "New User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            chkstaffusername()
        End If
    End Sub

    Private Sub StayLogin_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub
End Class