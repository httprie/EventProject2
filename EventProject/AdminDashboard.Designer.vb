﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.timedate = New System.Windows.Forms.Label()
        Me.pnlrecentevent = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.UpcomingEvents = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlrecentatt = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.RecentAttendees = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnltotalqr = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalQR = New System.Windows.Forms.Label()
        Me.pnlupcoming = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblUpcomingEvents = New System.Windows.Forms.Label()
        Me.pnltotalatt = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalAttendees = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.pnlrecentevent.SuspendLayout()
        CType(Me.UpcomingEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlrecentatt.SuspendLayout()
        CType(Me.RecentAttendees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnltotalqr.SuspendLayout()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlupcoming.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnltotalatt.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.timedate)
        Me.Panel1.Controls.Add(Me.pnlrecentevent)
        Me.Panel1.Controls.Add(Me.pnlrecentatt)
        Me.Panel1.Controls.Add(Me.pnltotalqr)
        Me.Panel1.Controls.Add(Me.pnlupcoming)
        Me.Panel1.Controls.Add(Me.pnltotalatt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1011, 800)
        Me.Panel1.TabIndex = 2
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.Location = New System.Drawing.Point(14, 30)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(150, 25)
        Me.timedate.TabIndex = 16
        Me.timedate.Text = "                       "
        '
        'pnlrecentevent
        '
        Me.pnlrecentevent.BackColor = System.Drawing.Color.Transparent
        Me.pnlrecentevent.Controls.Add(Me.UpcomingEvents)
        Me.pnlrecentevent.Controls.Add(Me.Label10)
        Me.pnlrecentevent.FillColor = System.Drawing.Color.White
        Me.pnlrecentevent.Location = New System.Drawing.Point(674, 308)
        Me.pnlrecentevent.Name = "pnlrecentevent"
        Me.pnlrecentevent.ShadowColor = System.Drawing.Color.Silver
        Me.pnlrecentevent.ShadowShift = 7
        Me.pnlrecentevent.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.pnlrecentevent.Size = New System.Drawing.Size(327, 470)
        Me.pnlrecentevent.TabIndex = 16
        '
        'UpcomingEvents
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.UpcomingEvents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UpcomingEvents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.UpcomingEvents.ColumnHeadersHeight = 42
        Me.UpcomingEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.UpcomingEvents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UpcomingEvents.DefaultCellStyle = DataGridViewCellStyle9
        Me.UpcomingEvents.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpcomingEvents.Location = New System.Drawing.Point(3, 76)
        Me.UpcomingEvents.Name = "UpcomingEvents"
        Me.UpcomingEvents.ReadOnly = True
        Me.UpcomingEvents.RowHeadersVisible = False
        Me.UpcomingEvents.RowHeadersWidth = 62
        Me.UpcomingEvents.RowTemplate.Height = 28
        Me.UpcomingEvents.Size = New System.Drawing.Size(311, 391)
        Me.UpcomingEvents.TabIndex = 13
        Me.UpcomingEvents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.UpcomingEvents.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.UpcomingEvents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.UpcomingEvents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.UpcomingEvents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.UpcomingEvents.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.UpcomingEvents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpcomingEvents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.UpcomingEvents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.UpcomingEvents.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpcomingEvents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.UpcomingEvents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.UpcomingEvents.ThemeStyle.HeaderStyle.Height = 42
        Me.UpcomingEvents.ThemeStyle.ReadOnly = True
        Me.UpcomingEvents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.UpcomingEvents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.UpcomingEvents.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpcomingEvents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.UpcomingEvents.ThemeStyle.RowsStyle.Height = 28
        Me.UpcomingEvents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue
        Me.UpcomingEvents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Ubuntu", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(6, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(248, 33)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Upcoming Events"
        '
        'pnlrecentatt
        '
        Me.pnlrecentatt.BackColor = System.Drawing.Color.Transparent
        Me.pnlrecentatt.Controls.Add(Me.RecentAttendees)
        Me.pnlrecentatt.Controls.Add(Me.Label9)
        Me.pnlrecentatt.FillColor = System.Drawing.Color.White
        Me.pnlrecentatt.Location = New System.Drawing.Point(16, 308)
        Me.pnlrecentatt.Name = "pnlrecentatt"
        Me.pnlrecentatt.ShadowColor = System.Drawing.Color.Silver
        Me.pnlrecentatt.ShadowShift = 7
        Me.pnlrecentatt.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.pnlrecentatt.Size = New System.Drawing.Size(632, 470)
        Me.pnlrecentatt.TabIndex = 14
        '
        'RecentAttendees
        '
        Me.RecentAttendees.AllowUserToResizeColumns = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.RecentAttendees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RecentAttendees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.RecentAttendees.ColumnHeadersHeight = 42
        Me.RecentAttendees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.RecentAttendees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RecentAttendees.DefaultCellStyle = DataGridViewCellStyle12
        Me.RecentAttendees.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RecentAttendees.Location = New System.Drawing.Point(3, 76)
        Me.RecentAttendees.Name = "RecentAttendees"
        Me.RecentAttendees.ReadOnly = True
        Me.RecentAttendees.RowHeadersVisible = False
        Me.RecentAttendees.RowHeadersWidth = 62
        Me.RecentAttendees.RowTemplate.Height = 28
        Me.RecentAttendees.Size = New System.Drawing.Size(619, 391)
        Me.RecentAttendees.TabIndex = 12
        Me.RecentAttendees.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.RecentAttendees.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.RecentAttendees.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.RecentAttendees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.RecentAttendees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.RecentAttendees.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.RecentAttendees.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RecentAttendees.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.RecentAttendees.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.RecentAttendees.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecentAttendees.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.RecentAttendees.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.RecentAttendees.ThemeStyle.HeaderStyle.Height = 42
        Me.RecentAttendees.ThemeStyle.ReadOnly = True
        Me.RecentAttendees.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.RecentAttendees.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.RecentAttendees.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecentAttendees.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.RecentAttendees.ThemeStyle.RowsStyle.Height = 28
        Me.RecentAttendees.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue
        Me.RecentAttendees.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "Event Name"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Venue"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Department"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Start Time"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "End Time"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Facilitator"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Ubuntu", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(17, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(215, 33)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Current Events"
        '
        'pnltotalqr
        '
        Me.pnltotalqr.BackColor = System.Drawing.Color.Transparent
        Me.pnltotalqr.Controls.Add(Me.Guna2PictureBox4)
        Me.pnltotalqr.Controls.Add(Me.Label4)
        Me.pnltotalqr.Controls.Add(Me.lblTotalQR)
        Me.pnltotalqr.FillColor = System.Drawing.Color.White
        Me.pnltotalqr.Location = New System.Drawing.Point(731, 104)
        Me.pnltotalqr.Name = "pnltotalqr"
        Me.pnltotalqr.ShadowColor = System.Drawing.Color.Silver
        Me.pnltotalqr.ShadowShift = 7
        Me.pnltotalqr.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.pnltotalqr.Size = New System.Drawing.Size(270, 135)
        Me.pnltotalqr.TabIndex = 15
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox4.Image = Global.EventProject.My.Resources.Resources.totalqr
        Me.Guna2PictureBox4.ImageRotate = 0!
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(177, 15)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(90, 90)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox4.TabIndex = 14
        Me.Guna2PictureBox4.TabStop = False
        Me.Guna2PictureBox4.UseTransparentBackground = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(18, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(239, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Current Event of the Day"
        '
        'lblTotalQR
        '
        Me.lblTotalQR.AutoSize = True
        Me.lblTotalQR.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalQR.Font = New System.Drawing.Font("Ubuntu", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.lblTotalQR.Location = New System.Drawing.Point(21, 32)
        Me.lblTotalQR.Name = "lblTotalQR"
        Me.lblTotalQR.Size = New System.Drawing.Size(55, 39)
        Me.lblTotalQR.TabIndex = 16
        Me.lblTotalQR.Text = "82"
        '
        'pnlupcoming
        '
        Me.pnlupcoming.BackColor = System.Drawing.Color.Transparent
        Me.pnlupcoming.Controls.Add(Me.Guna2PictureBox3)
        Me.pnlupcoming.Controls.Add(Me.Label5)
        Me.pnlupcoming.Controls.Add(Me.lblUpcomingEvents)
        Me.pnlupcoming.FillColor = System.Drawing.Color.White
        Me.pnlupcoming.Location = New System.Drawing.Point(378, 104)
        Me.pnlupcoming.Name = "pnlupcoming"
        Me.pnlupcoming.ShadowColor = System.Drawing.Color.Silver
        Me.pnlupcoming.ShadowShift = 7
        Me.pnlupcoming.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.pnlupcoming.Size = New System.Drawing.Size(270, 135)
        Me.pnlupcoming.TabIndex = 14
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = Global.EventProject.My.Resources.Resources.upcoming
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(177, 15)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(80, 80)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 11
        Me.Guna2PictureBox3.TabStop = False
        Me.Guna2PictureBox3.UseTransparentBackground = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(19, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Upcoming Events"
        '
        'lblUpcomingEvents
        '
        Me.lblUpcomingEvents.AutoSize = True
        Me.lblUpcomingEvents.BackColor = System.Drawing.Color.Transparent
        Me.lblUpcomingEvents.Font = New System.Drawing.Font("Ubuntu", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpcomingEvents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.lblUpcomingEvents.Location = New System.Drawing.Point(17, 32)
        Me.lblUpcomingEvents.Name = "lblUpcomingEvents"
        Me.lblUpcomingEvents.Size = New System.Drawing.Size(36, 39)
        Me.lblUpcomingEvents.TabIndex = 13
        Me.lblUpcomingEvents.Text = "9"
        '
        'pnltotalatt
        '
        Me.pnltotalatt.BackColor = System.Drawing.Color.Transparent
        Me.pnltotalatt.Controls.Add(Me.Guna2PictureBox2)
        Me.pnltotalatt.Controls.Add(Me.Label7)
        Me.pnltotalatt.Controls.Add(Me.lblTotalAttendees)
        Me.pnltotalatt.FillColor = System.Drawing.Color.White
        Me.pnltotalatt.Location = New System.Drawing.Point(16, 104)
        Me.pnltotalatt.Name = "pnltotalatt"
        Me.pnltotalatt.ShadowColor = System.Drawing.Color.Silver
        Me.pnltotalatt.ShadowShift = 7
        Me.pnltotalatt.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.pnltotalatt.Size = New System.Drawing.Size(270, 135)
        Me.pnltotalatt.TabIndex = 13
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.EventProject.My.Resources.Resources.totalattendance
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(177, 15)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(90, 90)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 10
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(14, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Pending Request"
        '
        'lblTotalAttendees
        '
        Me.lblTotalAttendees.AutoSize = True
        Me.lblTotalAttendees.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAttendees.Font = New System.Drawing.Font("Ubuntu", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAttendees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.lblTotalAttendees.Location = New System.Drawing.Point(17, 32)
        Me.lblTotalAttendees.Name = "lblTotalAttendees"
        Me.lblTotalAttendees.Size = New System.Drawing.Size(36, 39)
        Me.lblTotalAttendees.TabIndex = 10
        Me.lblTotalAttendees.Text = "5"
        '
        'Timer1
        '
        '
        'AdminDashboard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1011, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminDashboard"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlrecentevent.ResumeLayout(False)
        Me.pnlrecentevent.PerformLayout()
        CType(Me.UpcomingEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlrecentatt.ResumeLayout(False)
        Me.pnlrecentatt.PerformLayout()
        CType(Me.RecentAttendees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnltotalqr.ResumeLayout(False)
        Me.pnltotalqr.PerformLayout()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlupcoming.ResumeLayout(False)
        Me.pnlupcoming.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnltotalatt.ResumeLayout(False)
        Me.pnltotalatt.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlrecentevent As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents pnlrecentatt As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents pnltotalqr As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalQR As Label
    Friend WithEvents pnlupcoming As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblUpcomingEvents As Label
    Friend WithEvents pnltotalatt As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalAttendees As Label
    Friend WithEvents UpcomingEvents As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents RecentAttendees As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents timedate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
