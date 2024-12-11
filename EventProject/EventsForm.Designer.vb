<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EventsForm
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSearchEvent = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddEvent = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridViewEvents = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.eventid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.venue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.eventdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.starttime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endtime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timedate = New System.Windows.Forms.Label()
        Me.dtpStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbEventFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbxEvent = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpEndTime = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpStartTime = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearchEvent
        '
        Me.btnSearchEvent.AutoRoundedCorners = True
        Me.btnSearchEvent.BorderRadius = 17
        Me.btnSearchEvent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchEvent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearchEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchEvent.FillColor = System.Drawing.Color.White
        Me.btnSearchEvent.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearchEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnSearchEvent.Location = New System.Drawing.Point(808, 59)
        Me.btnSearchEvent.Name = "btnSearchEvent"
        Me.btnSearchEvent.Size = New System.Drawing.Size(168, 36)
        Me.btnSearchEvent.TabIndex = 2
        Me.btnSearchEvent.Text = "Search"
        '
        'btnAddEvent
        '
        Me.btnAddEvent.AutoRoundedCorners = True
        Me.btnAddEvent.BorderRadius = 19
        Me.btnAddEvent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddEvent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddEvent.FillColor = System.Drawing.Color.White
        Me.btnAddEvent.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnAddEvent.Location = New System.Drawing.Point(820, 529)
        Me.btnAddEvent.Name = "btnAddEvent"
        Me.btnAddEvent.Size = New System.Drawing.Size(168, 41)
        Me.btnAddEvent.TabIndex = 3
        Me.btnAddEvent.Text = "Add New Event"
        '
        'DataGridViewEvents
        '
        Me.DataGridViewEvents.AllowUserToResizeColumns = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.DataGridViewEvents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewEvents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewEvents.ColumnHeadersHeight = 42
        Me.DataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridViewEvents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eventid, Me.eventname, Me.venue, Me.department, Me.eventdate, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column3, Me.starttime, Me.endtime, Me.edit, Me.delete})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewEvents.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewEvents.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewEvents.Location = New System.Drawing.Point(0, 178)
        Me.DataGridViewEvents.Name = "DataGridViewEvents"
        Me.DataGridViewEvents.ReadOnly = True
        Me.DataGridViewEvents.RowHeadersVisible = False
        Me.DataGridViewEvents.RowHeadersWidth = 62
        Me.DataGridViewEvents.RowTemplate.Height = 28
        Me.DataGridViewEvents.Size = New System.Drawing.Size(1009, 336)
        Me.DataGridViewEvents.TabIndex = 13
        Me.DataGridViewEvents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewEvents.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridViewEvents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridViewEvents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridViewEvents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridViewEvents.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewEvents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewEvents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewEvents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewEvents.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewEvents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewEvents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridViewEvents.ThemeStyle.HeaderStyle.Height = 42
        Me.DataGridViewEvents.ThemeStyle.ReadOnly = True
        Me.DataGridViewEvents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewEvents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridViewEvents.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewEvents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewEvents.ThemeStyle.RowsStyle.Height = 28
        Me.DataGridViewEvents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue
        Me.DataGridViewEvents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'eventid
        '
        Me.eventid.HeaderText = "Event ID"
        Me.eventid.MinimumWidth = 8
        Me.eventid.Name = "eventid"
        Me.eventid.ReadOnly = True
        '
        'eventname
        '
        Me.eventname.HeaderText = "Event Name"
        Me.eventname.MinimumWidth = 8
        Me.eventname.Name = "eventname"
        Me.eventname.ReadOnly = True
        '
        'venue
        '
        Me.venue.HeaderText = "Venue"
        Me.venue.MinimumWidth = 8
        Me.venue.Name = "venue"
        Me.venue.ReadOnly = True
        '
        'department
        '
        Me.department.HeaderText = "Department"
        Me.department.MinimumWidth = 8
        Me.department.Name = "department"
        Me.department.ReadOnly = True
        '
        'eventdate
        '
        Me.eventdate.HeaderText = "Start Date"
        Me.eventdate.MinimumWidth = 8
        Me.eventdate.Name = "eventdate"
        Me.eventdate.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Facilitator"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Contact Person"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Messenger"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Contact No."
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "End Date"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'starttime
        '
        Me.starttime.HeaderText = "Start Time"
        Me.starttime.MinimumWidth = 8
        Me.starttime.Name = "starttime"
        Me.starttime.ReadOnly = True
        '
        'endtime
        '
        Me.endtime.HeaderText = "End TIme"
        Me.endtime.MinimumWidth = 8
        Me.endtime.Name = "endtime"
        Me.endtime.ReadOnly = True
        '
        'edit
        '
        Me.edit.HeaderText = "Edit"
        Me.edit.MinimumWidth = 8
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        '
        'delete
        '
        Me.delete.HeaderText = "Delete"
        Me.delete.MinimumWidth = 8
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        '
        'Timer1
        '
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.Location = New System.Drawing.Point(12, 22)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(150, 25)
        Me.timedate.TabIndex = 16
        Me.timedate.Text = "                       "
        '
        'dtpStartDate
        '
        Me.dtpStartDate.AutoRoundedCorners = True
        Me.dtpStartDate.BackColor = System.Drawing.SystemColors.Control
        Me.dtpStartDate.BorderColor = System.Drawing.Color.White
        Me.dtpStartDate.BorderRadius = 15
        Me.dtpStartDate.Checked = True
        Me.dtpStartDate.FillColor = System.Drawing.Color.White
        Me.dtpStartDate.Font = New System.Drawing.Font("Ubuntu", 9.0!)
        Me.dtpStartDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpStartDate.Location = New System.Drawing.Point(11, 129)
        Me.dtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(2023, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(262, 33)
        Me.dtpStartDate.TabIndex = 18
        Me.dtpStartDate.Value = New Date(2024, 11, 8, 16, 4, 40, 702)
        '
        'dtpEndDate
        '
        Me.dtpEndDate.AutoRoundedCorners = True
        Me.dtpEndDate.BackColor = System.Drawing.SystemColors.Control
        Me.dtpEndDate.BorderColor = System.Drawing.Color.White
        Me.dtpEndDate.BorderRadius = 15
        Me.dtpEndDate.Checked = True
        Me.dtpEndDate.FillColor = System.Drawing.Color.White
        Me.dtpEndDate.Font = New System.Drawing.Font("Ubuntu", 9.0!)
        Me.dtpEndDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpEndDate.Location = New System.Drawing.Point(311, 126)
        Me.dtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEndDate.MinDate = New Date(2023, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(263, 33)
        Me.dtpEndDate.TabIndex = 19
        Me.dtpEndDate.Value = New Date(2024, 11, 8, 16, 4, 40, 702)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(307, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 21)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "End Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(7, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 21)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Start Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 21)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "FILTER BY:"
        '
        'cbEventFilter
        '
        Me.cbEventFilter.AutoRoundedCorners = True
        Me.cbEventFilter.BackColor = System.Drawing.Color.Transparent
        Me.cbEventFilter.BorderRadius = 17
        Me.cbEventFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbEventFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEventFilter.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbEventFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbEventFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbEventFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbEventFilter.ItemHeight = 30
        Me.cbEventFilter.Location = New System.Drawing.Point(16, 65)
        Me.cbEventFilter.Name = "cbEventFilter"
        Me.cbEventFilter.Size = New System.Drawing.Size(202, 36)
        Me.cbEventFilter.TabIndex = 62
        '
        'cbxEvent
        '
        Me.cbxEvent.AutoRoundedCorners = True
        Me.cbxEvent.BackColor = System.Drawing.Color.Transparent
        Me.cbxEvent.BorderRadius = 17
        Me.cbxEvent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEvent.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxEvent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxEvent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbxEvent.ItemHeight = 30
        Me.cbxEvent.Location = New System.Drawing.Point(240, 65)
        Me.cbxEvent.Name = "cbxEvent"
        Me.cbxEvent.Size = New System.Drawing.Size(551, 36)
        Me.cbxEvent.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 539)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 21)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Pending Events"
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToResizeColumns = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.Guna2DataGridView1.ColumnHeadersHeight = 42
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Column1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.Column2, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle12
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(0, 579)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.ReadOnly = True
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowHeadersWidth = 62
        Me.Guna2DataGridView1.RowTemplate.Height = 28
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(1009, 190)
        Me.Guna2DataGridView1.TabIndex = 65
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 42
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = True
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Request ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Event Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Venue"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Start Date"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "End Date"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Start Time"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "End TIme"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Facilitator/Requester"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Accept"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Reject"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'dtpEndTime
        '
        Me.dtpEndTime.AutoRoundedCorners = True
        Me.dtpEndTime.BorderColor = System.Drawing.Color.White
        Me.dtpEndTime.BorderRadius = 15
        Me.dtpEndTime.Checked = True
        Me.dtpEndTime.FillColor = System.Drawing.Color.White
        Me.dtpEndTime.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime.Location = New System.Drawing.Point(808, 126)
        Me.dtpEndTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpEndTime.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEndTime.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(171, 33)
        Me.dtpEndTime.TabIndex = 67
        Me.dtpEndTime.Value = New Date(2024, 10, 23, 11, 44, 33, 549)
        '
        'dtpStartTime
        '
        Me.dtpStartTime.AutoRoundedCorners = True
        Me.dtpStartTime.BackColor = System.Drawing.Color.Transparent
        Me.dtpStartTime.BorderColor = System.Drawing.Color.White
        Me.dtpStartTime.BorderRadius = 15
        Me.dtpStartTime.Checked = True
        Me.dtpStartTime.FillColor = System.Drawing.Color.White
        Me.dtpStartTime.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartTime.Location = New System.Drawing.Point(633, 126)
        Me.dtpStartTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpStartTime.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartTime.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.ShowUpDown = True
        Me.dtpStartTime.Size = New System.Drawing.Size(158, 33)
        Me.dtpStartTime.TabIndex = 66
        Me.dtpStartTime.Value = New Date(2024, 10, 23, 11, 52, 35, 469)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(804, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "End Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(629, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 21)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Start Time:"
        '
        'EventsForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1011, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpEndTime)
        Me.Controls.Add(Me.dtpStartTime)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxEvent)
        Me.Controls.Add(Me.cbEventFilter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.timedate)
        Me.Controls.Add(Me.DataGridViewEvents)
        Me.Controls.Add(Me.btnAddEvent)
        Me.Controls.Add(Me.btnSearchEvent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EventsForm"
        Me.Text = "Event"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridViewEvents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearchEvent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddEvent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridViewEvents As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timedate As Label
    Friend WithEvents dtpStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbEventFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbxEvent As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents eventid As DataGridViewTextBoxColumn
    Friend WithEvents eventname As DataGridViewTextBoxColumn
    Friend WithEvents venue As DataGridViewTextBoxColumn
    Friend WithEvents department As DataGridViewTextBoxColumn
    Friend WithEvents eventdate As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents starttime As DataGridViewTextBoxColumn
    Friend WithEvents endtime As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents dtpEndTime As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpStartTime As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
