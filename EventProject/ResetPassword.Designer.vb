<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPassword
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShow = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.txtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblSetPassword = New System.Windows.Forms.Label()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timedate = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Black
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(476, 800)
        Me.Guna2CustomGradientPanel1.TabIndex = 21
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.EventProject.My.Resources.Resources.login
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(472, 797)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtPassword)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnShow)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtConfirmPassword)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnSubmit)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblSetPassword)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(632, 76)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Silver
        Me.Guna2ShadowPanel1.ShadowShift = 9
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(635, 631)
        Me.Guna2ShadowPanel1.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(63, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(484, 50)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "In accordance with the security policy you are " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "required to reset your password"
        '
        'txtPassword
        '
        Me.txtPassword.BorderRadius = 8
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.IconLeft = Global.EventProject.My.Resources.Resources.icons8_password_208
        Me.txtPassword.Location = New System.Drawing.Point(68, 184)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(412, 45)
        Me.txtPassword.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(123, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Show Password"
        '
        'btnShow
        '
        Me.btnShow.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShow.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShow.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.btnShow.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(68, 327)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(49, 24)
        Me.btnShow.TabIndex = 20
        Me.btnShow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnShow.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnShow.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.btnShow.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BorderRadius = 8
        Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPassword.DefaultText = ""
        Me.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Ubuntu", 10.0!)
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.IconLeft = Global.EventProject.My.Resources.Resources.icons8_password_208
        Me.txtConfirmPassword.Location = New System.Drawing.Point(68, 253)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtConfirmPassword.PlaceholderText = "Confirm Password"
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.Size = New System.Drawing.Size(412, 45)
        Me.txtConfirmPassword.TabIndex = 19
        '
        'btnSubmit
        '
        Me.btnSubmit.AutoRoundedCorners = True
        Me.btnSubmit.BorderRadius = 22
        Me.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnSubmit.FillColor2 = System.Drawing.Color.CornflowerBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(150, 400)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(265, 46)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "Submit"
        '
        'lblSetPassword
        '
        Me.lblSetPassword.AutoSize = True
        Me.lblSetPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblSetPassword.Font = New System.Drawing.Font("Ubuntu", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.lblSetPassword.Location = New System.Drawing.Point(60, 29)
        Me.lblSetPassword.Name = "lblSetPassword"
        Me.lblSetPassword.Size = New System.Drawing.Size(249, 43)
        Me.lblSetPassword.TabIndex = 12
        Me.lblSetPassword.Text = "Set Password"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1274, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(55, 35)
        Me.Guna2ControlBox2.TabIndex = 24
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1335, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(55, 35)
        Me.Guna2ControlBox1.TabIndex = 23
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.Location = New System.Drawing.Point(495, 22)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(150, 25)
        Me.timedate.TabIndex = 25
        Me.timedate.Text = "                       "
        '
        'ResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1390, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.timedate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ResetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResetPassword"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShow As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents txtConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblSetPassword As Label
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timedate As Label
End Class
