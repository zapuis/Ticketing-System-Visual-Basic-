Imports System.Data.OleDb
Public Class ViewUser

    Private Sub ViewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

        Try
            sqL = "SELECT * FROM staff"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridViewUser.Rows.Clear()
            Do While dr.Read = True
                DataGridViewUser.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Main.Show()
    End Sub
    Private Sub deleteitem()
        Try
            sqL = "DELETE * FROM staff WHERE username = '" & DataGridViewUser.SelectedRows(0).Cells("username").Value & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Do While dr.Read = True
                DataGridViewUser.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub refreshdata()
        Try
            sqL = "SELECT * FROM staff"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridViewUser.Rows.Clear()
            Do While dr.Read = True
                DataGridViewUser.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim ans As DialogResult = MessageBox.Show("Are you sure you want to delete?", "Remove User", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.Yes Then
            deleteitem()
            refreshdata()
        End If
    End Sub

    Private Sub DataGridViewUser_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewUser.CellContentClick

    End Sub
End Class