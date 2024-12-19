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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSearchEvent = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddEvent = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvEvents = New Guna.UI2.WinForms.Guna2DataGridView()
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
        Me.dtpEndTime = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpStartTime = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPrintEvent = New Guna.UI2.WinForms.Guna2Button()
        Me.cbEventData = New System.Windows.Forms.ComboBox()
        Me.cbEventFilter = New System.Windows.Forms.ComboBox()
        CType(Me.dgvEvents, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnSearchEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearchEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnSearchEvent.Location = New System.Drawing.Point(562, 65)
        Me.btnSearchEvent.Name = "btnSearchEvent"
        Me.btnSearchEvent.Size = New System.Drawing.Size(128, 36)
        Me.btnSearchEvent.TabIndex = 2
        Me.btnSearchEvent.Text = "Search"
        '
        'btnAddEvent
        '
        Me.btnAddEvent.AutoRoundedCorners = True
        Me.btnAddEvent.BorderRadius = 16
        Me.btnAddEvent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddEvent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddEvent.FillColor = System.Drawing.Color.White
        Me.btnAddEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnAddEvent.Location = New System.Drawing.Point(696, 65)
        Me.btnAddEvent.Name = "btnAddEvent"
        Me.btnAddEvent.Size = New System.Drawing.Size(168, 34)
        Me.btnAddEvent.TabIndex = 3
        Me.btnAddEvent.Text = "Add New Event"
        '
        'dgvEvents
        '
        Me.dgvEvents.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvEvents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEvents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEvents.ColumnHeadersHeight = 42
        Me.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvEvents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eventid, Me.eventname, Me.venue, Me.department, Me.eventdate, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column3, Me.starttime, Me.endtime, Me.edit, Me.delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEvents.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEvents.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEvents.Location = New System.Drawing.Point(0, 187)
        Me.dgvEvents.Name = "dgvEvents"
        Me.dgvEvents.ReadOnly = True
        Me.dgvEvents.RowHeadersVisible = False
        Me.dgvEvents.RowHeadersWidth = 62
        Me.dgvEvents.RowTemplate.Height = 28
        Me.dgvEvents.Size = New System.Drawing.Size(1009, 572)
        Me.dgvEvents.TabIndex = 13
        Me.dgvEvents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvEvents.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvEvents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvEvents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvEvents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvEvents.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvEvents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEvents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvEvents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvEvents.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEvents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvEvents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvEvents.ThemeStyle.HeaderStyle.Height = 42
        Me.dgvEvents.ThemeStyle.ReadOnly = True
        Me.dgvEvents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvEvents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvEvents.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEvents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvEvents.ThemeStyle.RowsStyle.Height = 28
        Me.dgvEvents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue
        Me.dgvEvents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.timedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dtpStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.dtpStartDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpStartDate.Location = New System.Drawing.Point(11, 129)
        Me.dtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(2023, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(262, 33)
        Me.dtpStartDate.TabIndex = 18
        Me.dtpStartDate.Value = New Date(2024, 12, 1, 0, 0, 0, 0)
        '
        'dtpEndDate
        '
        Me.dtpEndDate.AutoRoundedCorners = True
        Me.dtpEndDate.BackColor = System.Drawing.SystemColors.Control
        Me.dtpEndDate.BorderColor = System.Drawing.Color.White
        Me.dtpEndDate.BorderRadius = 15
        Me.dtpEndDate.Checked = True
        Me.dtpEndDate.FillColor = System.Drawing.Color.White
        Me.dtpEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.dtpEndDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpEndDate.Location = New System.Drawing.Point(311, 126)
        Me.dtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEndDate.MinDate = New Date(2023, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(263, 33)
        Me.dtpEndDate.TabIndex = 19
        Me.dtpEndDate.Value = New Date(2024, 12, 31, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(307, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 22)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "End Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(7, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 22)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Start Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 22)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "FILTER BY:"
        '
        'dtpEndTime
        '
        Me.dtpEndTime.AutoRoundedCorners = True
        Me.dtpEndTime.BorderColor = System.Drawing.Color.White
        Me.dtpEndTime.BorderRadius = 15
        Me.dtpEndTime.Checked = True
        Me.dtpEndTime.FillColor = System.Drawing.Color.White
        Me.dtpEndTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dtpEndTime.Value = New Date(2024, 12, 19, 0, 0, 0, 0)
        '
        'dtpStartTime
        '
        Me.dtpStartTime.AutoRoundedCorners = True
        Me.dtpStartTime.BackColor = System.Drawing.Color.Transparent
        Me.dtpStartTime.BorderColor = System.Drawing.Color.White
        Me.dtpStartTime.BorderRadius = 15
        Me.dtpStartTime.Checked = True
        Me.dtpStartTime.FillColor = System.Drawing.Color.White
        Me.dtpStartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dtpStartTime.Value = New Date(2024, 12, 19, 6, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(804, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 22)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "End Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(629, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 22)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Start Time:"
        '
        'btnPrintEvent
        '
        Me.btnPrintEvent.AutoRoundedCorners = True
        Me.btnPrintEvent.BorderRadius = 16
        Me.btnPrintEvent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrintEvent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrintEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrintEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrintEvent.FillColor = System.Drawing.Color.White
        Me.btnPrintEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrintEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnPrintEvent.Location = New System.Drawing.Point(870, 65)
        Me.btnPrintEvent.Name = "btnPrintEvent"
        Me.btnPrintEvent.Size = New System.Drawing.Size(109, 34)
        Me.btnPrintEvent.TabIndex = 70
        Me.btnPrintEvent.Text = "Print"
        '
        'cbEventData
        '
        Me.cbEventData.FormattingEnabled = True
        Me.cbEventData.Location = New System.Drawing.Point(179, 65)
        Me.cbEventData.Name = "cbEventData"
        Me.cbEventData.Size = New System.Drawing.Size(365, 28)
        Me.cbEventData.TabIndex = 71
        '
        'cbEventFilter
        '
        Me.cbEventFilter.FormattingEnabled = True
        Me.cbEventFilter.Location = New System.Drawing.Point(16, 64)
        Me.cbEventFilter.Name = "cbEventFilter"
        Me.cbEventFilter.Size = New System.Drawing.Size(146, 28)
        Me.cbEventFilter.TabIndex = 72
        '
        'EventsForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1011, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbEventFilter)
        Me.Controls.Add(Me.cbEventData)
        Me.Controls.Add(Me.btnPrintEvent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpEndTime)
        Me.Controls.Add(Me.dtpStartTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.timedate)
        Me.Controls.Add(Me.dgvEvents)
        Me.Controls.Add(Me.btnAddEvent)
        Me.Controls.Add(Me.btnSearchEvent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EventsForm"
        Me.Text = "Event"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearchEvent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddEvent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvEvents As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timedate As Label
    Friend WithEvents dtpStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
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
    Friend WithEvents dtpEndTime As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpStartTime As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPrintEvent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbEventData As ComboBox
    Friend WithEvents cbEventFilter As ComboBox
End Class
