<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenerateQR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.btngenerate = New Guna.UI2.WinForms.Guna2Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.timedate = New System.Windows.Forms.Label()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.lblQRCode = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlQRCode = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlInfo = New Guna.UI2.WinForms.Guna2Panel()
        Me.cbSection = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbDepartment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbStudentID = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblStudID = New System.Windows.Forms.Label()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPrintGen = New Guna.UI2.WinForms.Guna2Button()
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
        Me.txtMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiddleName.Location = New System.Drawing.Point(324, 36)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(4)
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
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(34, 73)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
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
        Me.txtExtension.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtExtension.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtExtension.Location = New System.Drawing.Point(324, 74)
        Me.txtExtension.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtExtension.PlaceholderText = "Suffix"
        Me.txtExtension.SelectedText = ""
        Me.txtExtension.Size = New System.Drawing.Size(125, 30)
        Me.txtExtension.TabIndex = 61
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.BackColor = System.Drawing.Color.Transparent
        Me.lblSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.ForeColor = System.Drawing.Color.Black
        Me.lblSection.Location = New System.Drawing.Point(332, 168)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(62, 18)
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
        Me.txtMessenger.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessenger.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMessenger.Location = New System.Drawing.Point(131, 324)
        Me.txtMessenger.Margin = New System.Windows.Forms.Padding(4)
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
        Me.lblMessenger.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessenger.ForeColor = System.Drawing.Color.Black
        Me.lblMessenger.Location = New System.Drawing.Point(54, 333)
        Me.lblMessenger.Name = "lblMessenger"
        Me.lblMessenger.Size = New System.Drawing.Size(86, 18)
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
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContact.Location = New System.Drawing.Point(131, 286)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(4)
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
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.Black
        Me.lblContact.Location = New System.Drawing.Point(70, 295)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(64, 18)
        Me.lblContact.TabIndex = 54
        Me.lblContact.Text = "Contact:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.Black
        Me.lblYear.Location = New System.Drawing.Point(99, 168)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(42, 18)
        Me.lblYear.TabIndex = 53
        Me.lblYear.Text = "Year:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(13, 7)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(79, 18)
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.StudentData.Location = New System.Drawing.Point(0, 532)
        Me.StudentData.Name = "StudentData"
        Me.StudentData.ReadOnly = True
        Me.StudentData.RowHeadersVisible = False
        Me.StudentData.RowHeadersWidth = 62
        Me.StudentData.RowTemplate.Height = 28
        Me.StudentData.Size = New System.Drawing.Size(1011, 256)
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
        Me.StudentData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.StudentData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.StudentData.ThemeStyle.HeaderStyle.Height = 42
        Me.StudentData.ThemeStyle.ReadOnly = True
        Me.StudentData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.StudentData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StudentData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtStudID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtStudID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudID.Location = New System.Drawing.Point(131, 205)
        Me.txtStudID.Margin = New System.Windows.Forms.Padding(4)
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
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(34, 36)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderText = "First Name"
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(269, 30)
        Me.txtFirstName.TabIndex = 40
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.BackColor = System.Drawing.Color.Transparent
        Me.lblCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.ForeColor = System.Drawing.Color.Black
        Me.lblCourse.Location = New System.Drawing.Point(334, 121)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(61, 18)
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
        Me.btngenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngenerate.ForeColor = System.Drawing.Color.Black
        Me.btngenerate.Location = New System.Drawing.Point(242, 377)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(176, 35)
        Me.btngenerate.TabIndex = 37
        Me.btngenerate.Text = "Generate"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(86, 252)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(49, 18)
        Me.lblEmail.TabIndex = 39
        Me.lblEmail.Text = "Email:"
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.ForeColor = System.Drawing.Color.Black
        Me.lblStudentID.Location = New System.Drawing.Point(54, 214)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(80, 18)
        Me.lblStudentID.TabIndex = 32
        Me.lblStudentID.Text = "Student ID:"
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.ForeColor = System.Drawing.Color.Black
        Me.timedate.Location = New System.Drawing.Point(8, 9)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(147, 20)
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
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(131, 243)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblQRCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQRCode.ForeColor = System.Drawing.Color.Black
        Me.lblQRCode.Location = New System.Drawing.Point(144, 17)
        Me.lblQRCode.Name = "lblQRCode"
        Me.lblQRCode.Size = New System.Drawing.Size(96, 24)
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
        Me.pnlQRCode.Size = New System.Drawing.Size(403, 426)
        Me.pnlQRCode.TabIndex = 60
        '
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlInfo.BorderColor = System.Drawing.Color.Gray
        Me.pnlInfo.BorderThickness = 1
        Me.pnlInfo.Controls.Add(Me.cbSection)
        Me.pnlInfo.Controls.Add(Me.cbYear)
        Me.pnlInfo.Controls.Add(Me.cbCourse)
        Me.pnlInfo.Controls.Add(Me.cbDepartment)
        Me.pnlInfo.Controls.Add(Me.Label1)
        Me.pnlInfo.Controls.Add(Me.txtMiddleName)
        Me.pnlInfo.Controls.Add(Me.txtLastName)
        Me.pnlInfo.Controls.Add(Me.txtExtension)
        Me.pnlInfo.Controls.Add(Me.lblSection)
        Me.pnlInfo.Controls.Add(Me.txtMessenger)
        Me.pnlInfo.Controls.Add(Me.lblMessenger)
        Me.pnlInfo.Controls.Add(Me.txtContact)
        Me.pnlInfo.Controls.Add(Me.lblContact)
        Me.pnlInfo.Controls.Add(Me.txtFirstName)
        Me.pnlInfo.Controls.Add(Me.lblCourse)
        Me.pnlInfo.Controls.Add(Me.lblYear)
        Me.pnlInfo.Controls.Add(Me.btngenerate)
        Me.pnlInfo.Controls.Add(Me.txtEmail)
        Me.pnlInfo.Controls.Add(Me.btnClear)
        Me.pnlInfo.Controls.Add(Me.lblName)
        Me.pnlInfo.Controls.Add(Me.txtStudID)
        Me.pnlInfo.Controls.Add(Me.lblEmail)
        Me.pnlInfo.Controls.Add(Me.lblStudentID)
        Me.pnlInfo.Location = New System.Drawing.Point(405, 52)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(606, 426)
        Me.pnlInfo.TabIndex = 59
        '
        'cbSection
        '
        Me.cbSection.AutoRoundedCorners = True
        Me.cbSection.BackColor = System.Drawing.Color.Transparent
        Me.cbSection.BorderRadius = 17
        Me.cbSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSection.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbSection.ItemHeight = 30
        Me.cbSection.Location = New System.Drawing.Point(412, 153)
        Me.cbSection.Name = "cbSection"
        Me.cbSection.Size = New System.Drawing.Size(141, 36)
        Me.cbSection.TabIndex = 70
        '
        'cbYear
        '
        Me.cbYear.AutoRoundedCorners = True
        Me.cbYear.BackColor = System.Drawing.Color.Transparent
        Me.cbYear.BorderRadius = 17
        Me.cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbYear.ItemHeight = 30
        Me.cbYear.Location = New System.Drawing.Point(162, 153)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(141, 36)
        Me.cbYear.TabIndex = 69
        '
        'cbCourse
        '
        Me.cbCourse.AutoRoundedCorners = True
        Me.cbCourse.BackColor = System.Drawing.Color.Transparent
        Me.cbCourse.BorderRadius = 17
        Me.cbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCourse.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cbCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbCourse.ItemHeight = 30
        Me.cbCourse.Location = New System.Drawing.Point(412, 111)
        Me.cbCourse.Name = "cbCourse"
        Me.cbCourse.Size = New System.Drawing.Size(141, 36)
        Me.cbCourse.TabIndex = 68
        '
        'cbDepartment
        '
        Me.cbDepartment.AutoRoundedCorners = True
        Me.cbDepartment.BackColor = System.Drawing.Color.Transparent
        Me.cbDepartment.BorderRadius = 17
        Me.cbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartment.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cbDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbDepartment.ItemHeight = 30
        Me.cbDepartment.Location = New System.Drawing.Point(162, 111)
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.Size = New System.Drawing.Size(141, 36)
        Me.cbDepartment.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(43, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Department:"
        '
        'cbStudentID
        '
        Me.cbStudentID.AutoRoundedCorners = True
        Me.cbStudentID.BackColor = System.Drawing.Color.Transparent
        Me.cbStudentID.BorderRadius = 17
        Me.cbStudentID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbStudentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStudentID.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbStudentID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbStudentID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbStudentID.ItemHeight = 30
        Me.cbStudentID.Location = New System.Drawing.Point(110, 490)
        Me.cbStudentID.Name = "cbStudentID"
        Me.cbStudentID.Size = New System.Drawing.Size(214, 36)
        Me.cbStudentID.TabIndex = 71
        '
        'lblStudID
        '
        Me.lblStudID.AutoSize = True
        Me.lblStudID.BackColor = System.Drawing.Color.Transparent
        Me.lblStudID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudID.ForeColor = System.Drawing.Color.Black
        Me.lblStudID.Location = New System.Drawing.Point(5, 498)
        Me.lblStudID.Name = "lblStudID"
        Me.lblStudID.Size = New System.Drawing.Size(80, 18)
        Me.lblStudID.TabIndex = 71
        Me.lblStudID.Text = "Student ID:"
        '
        'btnSearch
        '
        Me.btnSearch.AutoRoundedCorners = True
        Me.btnSearch.BorderRadius = 16
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.White
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(338, 491)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(129, 35)
        Me.btnSearch.TabIndex = 71
        Me.btnSearch.Text = "Search"
        '
        'btnPrintGen
        '
        Me.btnPrintGen.AutoRoundedCorners = True
        Me.btnPrintGen.BorderRadius = 16
        Me.btnPrintGen.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrintGen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrintGen.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrintGen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrintGen.FillColor = System.Drawing.Color.White
        Me.btnPrintGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrintGen.ForeColor = System.Drawing.Color.Black
        Me.btnPrintGen.Location = New System.Drawing.Point(477, 490)
        Me.btnPrintGen.Name = "btnPrintGen"
        Me.btnPrintGen.Size = New System.Drawing.Size(129, 35)
        Me.btnPrintGen.TabIndex = 72
        Me.btnPrintGen.Text = "Print"
        '
        'GenerateQR
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1011, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrintGen)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblStudID)
        Me.Controls.Add(Me.cbStudentID)
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
    Friend WithEvents lblCourse As Label
    Friend WithEvents btngenerate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
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
    Friend WithEvents cbSection As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbDepartment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblStudID As Label
    Friend WithEvents cbStudentID As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnPrintGen As Guna.UI2.WinForms.Guna2Button
End Class