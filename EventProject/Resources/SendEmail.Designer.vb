<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendEmail
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSubject = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtWhereTo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAttachFile = New Guna.UI2.WinForms.Guna2Button()
        Me.txtMessageBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSend = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(49, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Email Attachment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(80, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Subject:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(116, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "To:"
        '
        'txtSubject
        '
        Me.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubject.DefaultText = ""
        Me.txtSubject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSubject.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubject.Location = New System.Drawing.Point(155, 126)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubject.PlaceholderText = ""
        Me.txtSubject.SelectedText = ""
        Me.txtSubject.Size = New System.Drawing.Size(274, 30)
        Me.txtSubject.TabIndex = 37
        '
        'txtWhereTo
        '
        Me.txtWhereTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWhereTo.DefaultText = ""
        Me.txtWhereTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtWhereTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtWhereTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtWhereTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtWhereTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWhereTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtWhereTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWhereTo.Location = New System.Drawing.Point(155, 69)
        Me.txtWhereTo.Name = "txtWhereTo"
        Me.txtWhereTo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWhereTo.PlaceholderText = ""
        Me.txtWhereTo.SelectedText = ""
        Me.txtWhereTo.Size = New System.Drawing.Size(274, 30)
        Me.txtWhereTo.TabIndex = 36
        '
        'btnAttachFile
        '
        Me.btnAttachFile.Animated = True
        Me.btnAttachFile.BorderRadius = 1
        Me.btnAttachFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAttachFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAttachFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAttachFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAttachFile.FillColor = System.Drawing.Color.White
        Me.btnAttachFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAttachFile.ForeColor = System.Drawing.Color.Black
        Me.btnAttachFile.Location = New System.Drawing.Point(119, 181)
        Me.btnAttachFile.Name = "btnAttachFile"
        Me.btnAttachFile.Size = New System.Drawing.Size(113, 32)
        Me.btnAttachFile.TabIndex = 38
        Me.btnAttachFile.Text = "Attach File"
        '
        'txtMessageBox
        '
        Me.txtMessageBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMessageBox.DefaultText = ""
        Me.txtMessageBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMessageBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMessageBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMessageBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMessageBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMessageBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtMessageBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMessageBox.Location = New System.Drawing.Point(155, 247)
        Me.txtMessageBox.Name = "txtMessageBox"
        Me.txtMessageBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMessageBox.PlaceholderText = ""
        Me.txtMessageBox.SelectedText = ""
        Me.txtMessageBox.Size = New System.Drawing.Size(337, 115)
        Me.txtMessageBox.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(68, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Message:"
        '
        'btnSend
        '
        Me.btnSend.Animated = True
        Me.btnSend.BorderRadius = 1
        Me.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSend.FillColor = System.Drawing.Color.White
        Me.btnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSend.ForeColor = System.Drawing.Color.Black
        Me.btnSend.Location = New System.Drawing.Point(396, 395)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(131, 32)
        Me.btnSend.TabIndex = 41
        Me.btnSend.Text = "SEND EMAIL"
        '
        'SendEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(604, 450)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtMessageBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAttachFile)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtWhereTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SendEmail"
        Me.Text = "SendEmail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSubject As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtWhereTo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSend As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtMessageBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAttachFile As Guna.UI2.WinForms.Guna2Button
End Class
