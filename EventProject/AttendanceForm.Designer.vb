<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbevent = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbwebcam = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.AttendanceData = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timedate = New System.Windows.Forms.Label()
        Me.attendeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.section = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateScanned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timein = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timeout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.pbwebcam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbevent
        '
        Me.cbevent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbevent.ForeColor = System.Drawing.Color.Black
        Me.cbevent.FormattingEnabled = True
        Me.cbevent.Location = New System.Drawing.Point(88, 410)
        Me.cbevent.Name = "cbevent"
        Me.cbevent.Size = New System.Drawing.Size(359, 28)
        Me.cbevent.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 415)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 28)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Event:"
        '
        'pbwebcam
        '
        Me.pbwebcam.BackColor = System.Drawing.Color.Transparent
        Me.pbwebcam.FillColor = System.Drawing.Color.Transparent
        Me.pbwebcam.ImageRotate = 0!
        Me.pbwebcam.Location = New System.Drawing.Point(188, 59)
        Me.pbwebcam.Name = "pbwebcam"
        Me.pbwebcam.Size = New System.Drawing.Size(609, 330)
        Me.pbwebcam.TabIndex = 28
        Me.pbwebcam.TabStop = False
        Me.pbwebcam.UseTransparentBackground = True
        '
        'AttendanceData
        '
        Me.AttendanceData.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.AttendanceData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AttendanceData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.AttendanceData.ColumnHeadersHeight = 42
        Me.AttendanceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.AttendanceData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.attendeeID, Me.studID, Me.firstName, Me.lastName, Me.dept, Me.course, Me.year, Me.section, Me.dateScanned, Me.timein, Me.timeout})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AttendanceData.DefaultCellStyle = DataGridViewCellStyle3
        Me.AttendanceData.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AttendanceData.Location = New System.Drawing.Point(-1, 460)
        Me.AttendanceData.Name = "AttendanceData"
        Me.AttendanceData.ReadOnly = True
        Me.AttendanceData.RowHeadersVisible = False
        Me.AttendanceData.RowHeadersWidth = 62
        Me.AttendanceData.RowTemplate.Height = 28
        Me.AttendanceData.Size = New System.Drawing.Size(1011, 343)
        Me.AttendanceData.TabIndex = 53
        Me.AttendanceData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.AttendanceData.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.AttendanceData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.AttendanceData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.AttendanceData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.AttendanceData.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.AttendanceData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AttendanceData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.AttendanceData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AttendanceData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendanceData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.AttendanceData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.AttendanceData.ThemeStyle.HeaderStyle.Height = 42
        Me.AttendanceData.ThemeStyle.ReadOnly = True
        Me.AttendanceData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.AttendanceData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.AttendanceData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendanceData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.AttendanceData.ThemeStyle.RowsStyle.Height = 28
        Me.AttendanceData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue
        Me.AttendanceData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Timer1
        '
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.ForeColor = System.Drawing.Color.Black
        Me.timedate.Location = New System.Drawing.Point(12, 20)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(147, 20)
        Me.timedate.TabIndex = 54
        Me.timedate.Text = "                       "
        '
        'attendeeID
        '
        Me.attendeeID.HeaderText = "Attendee ID"
        Me.attendeeID.MinimumWidth = 8
        Me.attendeeID.Name = "attendeeID"
        Me.attendeeID.ReadOnly = True
        '
        'studID
        '
        Me.studID.HeaderText = "Student ID"
        Me.studID.MinimumWidth = 8
        Me.studID.Name = "studID"
        Me.studID.ReadOnly = True
        '
        'firstName
        '
        Me.firstName.HeaderText = "First Name"
        Me.firstName.MinimumWidth = 8
        Me.firstName.Name = "firstName"
        Me.firstName.ReadOnly = True
        '
        'lastName
        '
        Me.lastName.HeaderText = "Last Name"
        Me.lastName.MinimumWidth = 8
        Me.lastName.Name = "lastName"
        Me.lastName.ReadOnly = True
        '
        'dept
        '
        Me.dept.HeaderText = "Department"
        Me.dept.MinimumWidth = 8
        Me.dept.Name = "dept"
        Me.dept.ReadOnly = True
        '
        'course
        '
        Me.course.HeaderText = "Course"
        Me.course.MinimumWidth = 8
        Me.course.Name = "course"
        Me.course.ReadOnly = True
        '
        'year
        '
        Me.year.HeaderText = "Year"
        Me.year.MinimumWidth = 8
        Me.year.Name = "year"
        Me.year.ReadOnly = True
        '
        'section
        '
        Me.section.HeaderText = "Section"
        Me.section.MinimumWidth = 8
        Me.section.Name = "section"
        Me.section.ReadOnly = True
        '
        'dateScanned
        '
        Me.dateScanned.HeaderText = "Date"
        Me.dateScanned.MinimumWidth = 8
        Me.dateScanned.Name = "dateScanned"
        Me.dateScanned.ReadOnly = True
        '
        'timein
        '
        Me.timein.HeaderText = "Time In"
        Me.timein.MinimumWidth = 8
        Me.timein.Name = "timein"
        Me.timein.ReadOnly = True
        '
        'timeout
        '
        Me.timeout.HeaderText = "Time Out"
        Me.timeout.MinimumWidth = 8
        Me.timeout.Name = "timeout"
        Me.timeout.ReadOnly = True
        '
        'AttendanceForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1011, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.timedate)
        Me.Controls.Add(Me.AttendanceData)
        Me.Controls.Add(Me.cbevent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbwebcam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AttendanceForm"
        Me.Text = "AttendanceForm"
        CType(Me.pbwebcam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbevent As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbwebcam As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents AttendanceData As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timedate As Label
    Friend WithEvents attendeeID As DataGridViewTextBoxColumn
    Friend WithEvents studID As DataGridViewTextBoxColumn
    Friend WithEvents firstName As DataGridViewTextBoxColumn
    Friend WithEvents lastName As DataGridViewTextBoxColumn
    Friend WithEvents dept As DataGridViewTextBoxColumn
    Friend WithEvents course As DataGridViewTextBoxColumn
    Friend WithEvents year As DataGridViewTextBoxColumn
    Friend WithEvents section As DataGridViewTextBoxColumn
    Friend WithEvents dateScanned As DataGridViewTextBoxColumn
    Friend WithEvents timein As DataGridViewTextBoxColumn
    Friend WithEvents timeout As DataGridViewTextBoxColumn
End Class
