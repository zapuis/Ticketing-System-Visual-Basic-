<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUser))
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelConfirmpass = New System.Windows.Forms.Label()
        Me.txtNewUser = New System.Windows.Forms.TextBox()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelPosition = New System.Windows.Forms.Label()
        Me.LabelDept = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDept = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.BackColor = System.Drawing.SystemColors.WindowText
        Me.LabelUsername.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.ForeColor = System.Drawing.SystemColors.Window
        Me.LabelUsername.Location = New System.Drawing.Point(31, 199)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(99, 20)
        Me.LabelUsername.TabIndex = 0
        Me.LabelUsername.Text = "Username"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.BackColor = System.Drawing.SystemColors.WindowText
        Me.LabelPassword.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.SystemColors.Window
        Me.LabelPassword.Location = New System.Drawing.Point(31, 229)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(94, 20)
        Me.LabelPassword.TabIndex = 1
        Me.LabelPassword.Text = "Password"
        '
        'LabelConfirmpass
        '
        Me.LabelConfirmpass.AutoSize = True
        Me.LabelConfirmpass.BackColor = System.Drawing.SystemColors.WindowText
        Me.LabelConfirmpass.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConfirmpass.ForeColor = System.Drawing.SystemColors.Window
        Me.LabelConfirmpass.Location = New System.Drawing.Point(31, 259)
        Me.LabelConfirmpass.Name = "LabelConfirmpass"
        Me.LabelConfirmpass.Size = New System.Drawing.Size(171, 20)
        Me.LabelConfirmpass.TabIndex = 2
        Me.LabelConfirmpass.Text = "Confirm Password"
        '
        'txtNewUser
        '
        Me.txtNewUser.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtNewUser.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUser.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNewUser.Location = New System.Drawing.Point(246, 199)
        Me.txtNewUser.Name = "txtNewUser"
        Me.txtNewUser.Size = New System.Drawing.Size(214, 27)
        Me.txtNewUser.TabIndex = 4
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtConfirmPass.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.ForeColor = System.Drawing.SystemColors.Window
        Me.txtConfirmPass.Location = New System.Drawing.Point(246, 259)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPass.Size = New System.Drawing.Size(214, 27)
        Me.txtConfirmPass.TabIndex = 6
        '
        'txtNewPass
        '
        Me.txtNewPass.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtNewPass.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.ForeColor = System.Drawing.SystemColors.Window
        Me.txtNewPass.Location = New System.Drawing.Point(246, 229)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(214, 27)
        Me.txtNewPass.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Blue
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAdd.Location = New System.Drawing.Point(324, 302)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(150, 95)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Book Seat Reservation"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCancel.Location = New System.Drawing.Point(324, 403)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 95)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.BackColor = System.Drawing.SystemColors.WindowText
        Me.LabelName.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.ForeColor = System.Drawing.SystemColors.Window
        Me.LabelName.Location = New System.Drawing.Point(31, 109)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(60, 20)
        Me.LabelName.TabIndex = 8
        Me.LabelName.Text = "Name"
        '
        'LabelPosition
        '
        Me.LabelPosition.AutoSize = True
        Me.LabelPosition.BackColor = System.Drawing.SystemColors.WindowText
        Me.LabelPosition.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPosition.ForeColor = System.Drawing.SystemColors.Window
        Me.LabelPosition.Location = New System.Drawing.Point(31, 139)
        Me.LabelPosition.Name = "LabelPosition"
        Me.LabelPosition.Size = New System.Drawing.Size(110, 20)
        Me.LabelPosition.TabIndex = 9
        Me.LabelPosition.Text = "Movie Title"
        '
        'LabelDept
        '
        Me.LabelDept.AutoSize = True
        Me.LabelDept.BackColor = System.Drawing.SystemColors.WindowText
        Me.LabelDept.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDept.ForeColor = System.Drawing.SystemColors.Window
        Me.LabelDept.Location = New System.Drawing.Point(31, 169)
        Me.LabelDept.Name = "LabelDept"
        Me.LabelDept.Size = New System.Drawing.Size(126, 20)
        Me.LabelDept.TabIndex = 10
        Me.LabelDept.Text = "Seat Number"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtName.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.SystemColors.Window
        Me.txtName.Location = New System.Drawing.Point(246, 109)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(214, 27)
        Me.txtName.TabIndex = 1
        '
        'txtDept
        '
        Me.txtDept.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtDept.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDept.ForeColor = System.Drawing.SystemColors.Window
        Me.txtDept.Location = New System.Drawing.Point(246, 169)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(214, 27)
        Me.txtDept.TabIndex = 3
        '
        'txtPosition
        '
        Me.txtPosition.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtPosition.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.ForeColor = System.Drawing.SystemColors.Window
        Me.txtPosition.Location = New System.Drawing.Point(246, 139)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(214, 27)
        Me.txtPosition.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.WindowText
        Me.PictureBox1.Location = New System.Drawing.Point(21, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(453, 213)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(508, 522)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.LabelDept)
        Me.Controls.Add(Me.LabelPosition)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.txtNewUser)
        Me.Controls.Add(Me.LabelConfirmpass)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddUser"
        Me.Text = "Add User"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelUsername As System.Windows.Forms.Label
    Friend WithEvents LabelPassword As System.Windows.Forms.Label
    Friend WithEvents LabelConfirmpass As System.Windows.Forms.Label
    Friend WithEvents txtNewUser As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents LabelPosition As System.Windows.Forms.Label
    Friend WithEvents LabelDept As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtDept As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
