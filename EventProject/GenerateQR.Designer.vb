<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateQR
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.QRCode = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtMiddleName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtExtension = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSection = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.txtMessenger = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblMessenger = New System.Windows.Forms.Label()
        Me.txtContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.StudentData = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtStudID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtYear = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.btngenerate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsendEmail = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCourse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.timedate = New System.Windows.Forms.Label()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.lblQRCode = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlQRCode = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlInfo = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDepartment = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.QRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlQRCode.SuspendLayout()
        Me.pnlInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'QRCode
        '
        Me.QRCode.BackColor = System.Drawing.Color.Transparent
        Me.QRCode.FillColor = System.Drawing.Color.Transparent
        Me.QRCode.ImageRotate = 0!
        Me.QRCode.Location = New System.Drawing.Point(13, 62)
        Me.QRCode.Name = "QRCode"
        Me.QRCode.Size = New System.Drawing.Size(376, 302)
        Me.QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.QRCode.TabIndex = 36
        Me.QRCode.TabStop = False
        Me.QRCode.UseTransparentBackground = True
        '
        'txtMiddleName
        '
        Me.txtMiddleName.AutoRoundedCorners = True
        Me.txtMiddleName.BorderRadius = 14
        Me.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiddleName.DefaultText = ""
        Me.txtMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiddleName.Font = New System.Drawing.Font("Ubuntu", 9.0!)
        Me.txtMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiddleName.Location = New System.Drawing.Point(324, 36)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiddleName.PlaceholderText = "Middle Name"
        Me.txtMiddleName.SelectedText = ""
        Me.txtMiddleName.Size = New System.Drawing.Size(229, 30)
        Me.txtMiddleName.TabIndex = 65
        '
        'txtLastName
        '
        Me.txtLastName.AutoRoundedCorners = True
        Me.txtLastName.BorderRadius = 14
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Ubuntu", 9.0!)
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(34, 73)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PlaceholderText = "Last Name"
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(269, 30)
        Me.txtLastName.TabIndex = 63
        '
        'txtExtension
        '
        Me.txtExtension.AutoRoundedCorners = True
        Me.txtExtension.BorderRadius = 14
        Me.txtExtension.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtExtension.DefaultText = ""
        Me.txtExtension.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtExtension.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtExtension.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtExtension.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtExtension.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtExtension.Font = New System.Drawing.Font("Ubuntu", 9.0!)
        Me.txtExtension.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtExtension.Location = New System.Drawing.Point(324, 74)
        Me.txtExtension.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtExtension.PlaceholderText = "Suffix"
        Me.txtExtension.SelectedText = ""
        Me.txtExtension.Size = New System.Drawing.Size(125, 30)
        Me.txtExtension.TabIndex = 61
        '
        'txtSection
        '
        Me.txtSection.AutoRoundedCorners = True
        Me.txtSection.BorderRadius = 14
        Me.txtSection.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSection.DefaultText = ""
        Me.txtSection.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSection.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSection.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSection.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSection.Location = New System.Drawing.Point(132, 221)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSection.PlaceholderText = ""
        Me.txtSection.SelectedText = ""
        Me.txtSection.Size = New System.Drawing.Size(422, 30)
        Me.txtSection.TabIndex = 58
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.BackColor = System.Drawing.Color.Transparent
        Me.lblSection.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.ForeColor = System.Drawing.Color.Black
        Me.lblSection.Location = New System.Drawing.Point(75, 230)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(74, 21)
        Me.lblSection.TabIndex = 59
        Me.lblSection.Text = "Section:"
        '
        'txtMessenger
        '
        Me.txtMessenger.AutoRoundedCorners = True
        Me.txtMessenger.BorderRadius = 14
        Me.txtMessenger.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMessenger.DefaultText = ""
        Me.txtMessenger.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMessenger.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMessenger.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMessenger.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMessenger.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMessenger.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessenger.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMessenger.Location = New System.Drawing.Point(131, 373)
        Me.txtMessenger.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMessenger.Name = "txtMessenger"
        Me.txtMessenger.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMessenger.PlaceholderText = ""
        Me.txtMessenger.SelectedText = ""
        Me.txtMessenger.Size = New System.Drawing.Size(422, 30)
        Me.txtMessenger.TabIndex = 57
        '
        'lblMessenger
        '
        Me.lblMessenger.AutoSize = True
        Me.lblMessenger.BackColor = System.Drawing.Color.Transparent
        Me.lblMessenger.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessenger.ForeColor = System.Drawing.Color.Black
        Me.lblMessenger.Location = New System.Drawing.Point(54, 382)
        Me.lblMessenger.Name = "lblMessenger"
        Me.lblMessenger.Size = New System.Drawing.Size(102, 21)
        Me.lblMessenger.TabIndex = 56
        Me.lblMessenger.Text = "Messenger:"
        '
        'txtContact
        '
        Me.txtContact.AutoRoundedCorners = True
        Me.txtContact.BorderRadius = 14
        Me.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContact.DefaultText = ""
        Me.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContact.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContact.Location = New System.Drawing.Point(131, 335)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContact.PlaceholderText = ""
        Me.txtContact.SelectedText = ""
        Me.txtContact.Size = New System.Drawing.Size(422, 30)
        Me.txtContact.TabIndex = 55
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.BackColor = System.Drawing.Color.Transparent
        Me.lblContact.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.Black
        Me.lblContact.Location = New System.Drawing.Point(70, 344)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(79, 21)
        Me.lblContact.TabIndex = 54
        Me.lblContact.Text = "Contact:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.Black
        Me.lblYear.Location = New System.Drawing.Point(94, 194)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(50, 21)
        Me.lblYear.TabIndex = 53
        Me.lblYear.Text = "Year:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(13, 7)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(93, 21)
        Me.lblName.TabIndex = 33
        Me.lblName.Text = "Full Name:"
        '
        'StudentData
        '
        Me.StudentData.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.StudentData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.StudentData.ColumnHeadersHeight = 42
        Me.StudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.StudentData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column12, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentData.DefaultCellStyle = DataGridViewCellStyle3
        Me.StudentData.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StudentData.Location = New System.Drawing.Point(0, 519)
        Me.StudentData.Name = "StudentData"
        Me.StudentData.ReadOnly = True
        Me.StudentData.RowHeadersVisible = False
        Me.StudentData.RowHeadersWidth = 62
        Me.StudentData.RowTemplate.Height = 28
        Me.StudentData.Size = New System.Drawing.Size(1011, 269)
        Me.StudentData.TabIndex = 58
        Me.StudentData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.StudentData.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.StudentData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.StudentData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.StudentData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.StudentData.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.StudentData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StudentData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.StudentData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.StudentData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.StudentData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.StudentData.ThemeStyle.HeaderStyle.Height = 42
        Me.StudentData.ThemeStyle.ReadOnly = True
        Me.StudentData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.StudentData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StudentData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.StudentData.ThemeStyle.RowsStyle.Height = 28
        Me.StudentData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue
        Me.StudentData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "Student ID"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "First Name"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Middle Name"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Last Name"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Department"
        Me.Column12.MinimumWidth = 8
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Course"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Year"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Section"
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Section"
        Me.Column8.MinimumWidth = 8
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Email"
        Me.Column9.MinimumWidth = 8
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Contact No."
        Me.Column10.MinimumWidth = 8
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Messenger"
        Me.Column11.MinimumWidth = 8
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'txtStudID
        '
        Me.txtStudID.AutoRoundedCorners = True
        Me.txtStudID.BorderRadius = 14
        Me.txtStudID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudID.DefaultText = ""
        Me.txtStudID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudID.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudID.Location = New System.Drawing.Point(131, 259)
        Me.txtStudID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudID.PlaceholderText = ""
        Me.txtStudID.SelectedText = ""
        Me.txtStudID.Size = New System.Drawing.Size(422, 30)
        Me.txtStudID.TabIndex = 43
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'txtFirstName
        '
        Me.txtFirstName.AutoRoundedCorners = True
        Me.txtFirstName.BorderRadius = 14
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Ubuntu", 9.0!)
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(34, 36)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderText = "First Name"
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(269, 30)
        Me.txtFirstName.TabIndex = 40
        '
        'txtYear
        '
        Me.txtYear.AutoRoundedCorners = True
        Me.txtYear.BorderRadius = 14
        Me.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYear.DefaultText = ""
        Me.txtYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtYear.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtYear.Location = New System.Drawing.Point(133, 183)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtYear.PlaceholderText = ""
        Me.txtYear.SelectedText = ""
        Me.txtYear.Size = New System.Drawing.Size(422, 30)
        Me.txtYear.TabIndex = 42
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblCourse.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.Color.Black
        Me.lblCourse.Location = New System.Drawing.Point(77, 154)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(72, 21)
        Me.lblCourse.TabIndex = 35
        Me.lblCourse.Text = "Course:"
        '
        'btngenerate
        '
        Me.btngenerate.AutoRoundedCorners = True
        Me.btngenerate.BorderRadius = 16
        Me.btngenerate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btngenerate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btngenerate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btngenerate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btngenerate.FillColor = System.Drawing.Color.White
        Me.btngenerate.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngenerate.ForeColor = System.Drawing.Color.Black
        Me.btngenerate.Location = New System.Drawing.Point(100, 414)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(120, 35)
        Me.btngenerate.TabIndex = 37
        Me.btngenerate.Text = "Generate"
        '
        'btnsendEmail
        '
        Me.btnsendEmail.AutoRoundedCorners = True
        Me.btnsendEmail.BorderRadius = 16
        Me.btnsendEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsendEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsendEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsendEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsendEmail.FillColor = System.Drawing.Color.White
        Me.btnsendEmail.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsendEmail.ForeColor = System.Drawing.Color.Black
        Me.btnsendEmail.Location = New System.Drawing.Point(383, 414)
        Me.btnsendEmail.Name = "btnsendEmail"
        Me.btnsendEmail.Size = New System.Drawing.Size(122, 35)
        Me.btnsendEmail.TabIndex = 44
        Me.btnsendEmail.Text = "Send"
        '
        'txtCourse
        '
        Me.txtCourse.AutoRoundedCorners = True
        Me.txtCourse.BorderRadius = 14
        Me.txtCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCourse.DefaultText = ""
        Me.txtCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCourse.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCourse.Location = New System.Drawing.Point(133, 145)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCourse.PlaceholderText = ""
        Me.txtCourse.SelectedText = ""
        Me.txtCourse.Size = New System.Drawing.Size(422, 30)
        Me.txtCourse.TabIndex = 41
        '
        'btnsave
        '
        Me.btnsave.AutoRoundedCorners = True
        Me.btnsave.BorderRadius = 16
        Me.btnsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsave.FillColor = System.Drawing.Color.White
        Me.btnsave.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(237, 414)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(128, 35)
        Me.btnsave.TabIndex = 38
        Me.btnsave.Text = "Save"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(86, 306)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(55, 21)
        Me.lblEmail.TabIndex = 39
        Me.lblEmail.Text = "Email:"
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentID.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.ForeColor = System.Drawing.Color.Black
        Me.lblStudentID.Location = New System.Drawing.Point(54, 268)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(101, 21)
        Me.lblStudentID.TabIndex = 32
        Me.lblStudentID.Text = "Student ID:"
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.ForeColor = System.Drawing.Color.Black
        Me.timedate.Location = New System.Drawing.Point(8, 9)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(150, 25)
        Me.timedate.TabIndex = 57
        Me.timedate.Text = "                       "
        '
        'txtEmail
        '
        Me.txtEmail.AutoRoundedCorners = True
        Me.txtEmail.BorderRadius = 14
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(131, 297)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(422, 30)
        Me.txtEmail.TabIndex = 45
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BorderColor = System.Drawing.Color.Transparent
        Me.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClear.FillColor = System.Drawing.Color.Transparent
        Me.btnClear.Font = New System.Drawing.Font("Ubuntu", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(517, 0)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 29)
        Me.btnClear.TabIndex = 47
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseTransparentBackground = True
        '
        'lblQRCode
        '
        Me.lblQRCode.AutoSize = True
        Me.lblQRCode.Font = New System.Drawing.Font("Ubuntu", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQRCode.ForeColor = System.Drawing.Color.Black
        Me.lblQRCode.Location = New System.Drawing.Point(144, 17)
        Me.lblQRCode.Name = "lblQRCode"
        Me.lblQRCode.Size = New System.Drawing.Size(107, 26)
        Me.lblQRCode.TabIndex = 48
        Me.lblQRCode.Text = "QR Code"
        '
        'pnlQRCode
        '
        Me.pnlQRCode.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlQRCode.BorderColor = System.Drawing.Color.Gray
        Me.pnlQRCode.BorderThickness = 1
        Me.pnlQRCode.Controls.Add(Me.QRCode)
        Me.pnlQRCode.Controls.Add(Me.lblQRCode)
        Me.pnlQRCode.Location = New System.Drawing.Point(0, 52)
        Me.pnlQRCode.Name = "pnlQRCode"
        Me.pnlQRCode.Size = New System.Drawing.Size(403, 461)
        Me.pnlQRCode.TabIndex = 60
        '
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlInfo.BorderColor = System.Drawing.Color.Gray
        Me.pnlInfo.BorderThickness = 1
        Me.pnlInfo.Controls.Add(Me.Label1)
        Me.pnlInfo.Controls.Add(Me.txtDepartment)
        Me.pnlInfo.Controls.Add(Me.txtMiddleName)
        Me.pnlInfo.Controls.Add(Me.txtLastName)
        Me.pnlInfo.Controls.Add(Me.txtExtension)
        Me.pnlInfo.Controls.Add(Me.txtSection)
        Me.pnlInfo.Controls.Add(Me.lblSection)
        Me.pnlInfo.Controls.Add(Me.txtMessenger)
        Me.pnlInfo.Controls.Add(Me.lblMessenger)
        Me.pnlInfo.Controls.Add(Me.txtContact)
        Me.pnlInfo.Controls.Add(Me.lblContact)
        Me.pnlInfo.Controls.Add(Me.txtFirstName)
        Me.pnlInfo.Controls.Add(Me.txtYear)
        Me.pnlInfo.Controls.Add(Me.lblCourse)
        Me.pnlInfo.Controls.Add(Me.lblYear)
        Me.pnlInfo.Controls.Add(Me.btngenerate)
        Me.pnlInfo.Controls.Add(Me.txtEmail)
        Me.pnlInfo.Controls.Add(Me.btnsendEmail)
        Me.pnlInfo.Controls.Add(Me.txtCourse)
        Me.pnlInfo.Controls.Add(Me.btnClear)
        Me.pnlInfo.Controls.Add(Me.btnsave)
        Me.pnlInfo.Controls.Add(Me.lblName)
        Me.pnlInfo.Controls.Add(Me.txtStudID)
        Me.pnlInfo.Controls.Add(Me.lblEmail)
        Me.pnlInfo.Controls.Add(Me.lblStudentID)
        Me.pnlInfo.Location = New System.Drawing.Point(405, 52)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(606, 461)
        Me.pnlInfo.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(43, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 21)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Department:"
        '
        'txtDepartment
        '
        Me.txtDepartment.AutoRoundedCorners = True
        Me.txtDepartment.BorderRadius = 14
        Me.txtDepartment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDepartment.DefaultText = ""
        Me.txtDepartment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDepartment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDepartment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDepartment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDepartment.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDepartment.Location = New System.Drawing.Point(131, 112)
        Me.txtDepartment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDepartment.PlaceholderText = ""
        Me.txtDepartment.SelectedText = ""
        Me.txtDepartment.Size = New System.Drawing.Size(422, 30)
        Me.txtDepartment.TabIndex = 67
        '
        'GenerateQR
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1011, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.StudentData)
        Me.Controls.Add(Me.timedate)
        Me.Controls.Add(Me.pnlQRCode)
        Me.Controls.Add(Me.pnlInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GenerateQR"
        Me.Text = "GenerateQR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.QRCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlQRCode.ResumeLayout(False)
        Me.pnlQRCode.PerformLayout()
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QRCode As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtMiddleName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtExtension As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSection As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSection As Label
    Friend WithEvents txtMessenger As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblMessenger As Label
    Friend WithEvents txtContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblContact As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblName As Label
    Friend WithEvents StudentData As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtStudID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents timedate As Label
    Friend WithEvents pnlQRCode As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblQRCode As Label
    Friend WithEvents pnlInfo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtYear As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents btngenerate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnsendEmail As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCourse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDepartment As Guna.UI2.WinForms.Guna2TextBox
End Class