<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.timedate = New System.Windows.Forms.Label()
        Me.pnlUpEvtbl = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.tblUpcomEve = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlCurrEvetbl = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.tblCurrEve = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlPendingReq = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbltotalPend = New System.Windows.Forms.Label()
        Me.pnlupcoming = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblUpcomingEvents = New System.Windows.Forms.Label()
        Me.pnlCurrEveDay = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalEvent = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eveID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.evename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.venue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.startDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.startTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.facilititator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.pnlUpEvtbl.SuspendLayout()
        CType(Me.tblUpcomEve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCurrEvetbl.SuspendLayout()
        CType(Me.tblCurrEve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPendingReq.SuspendLayout()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlupcoming.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCurrEveDay.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.timedate)
        Me.Panel1.Controls.Add(Me.pnlUpEvtbl)
        Me.Panel1.Controls.Add(Me.pnlCurrEvetbl)
        Me.Panel1.Controls.Add(Me.pnlPendingReq)
        Me.Panel1.Controls.Add(Me.pnlupcoming)
        Me.Panel1.Controls.Add(Me.pnlCurrEveDay)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1011, 800)
        Me.Panel1.TabIndex = 2
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.Location = New System.Drawing.Point(14, 30)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(147, 20)
        Me.timedate.TabIndex = 16
        Me.timedate.Text = "                       "
        '
        'pnlUpEvtbl
        '
        Me.pnlUpEvtbl.BackColor = System.Drawing.Color.Transparent
        Me.pnlUpEvtbl.Controls.Add(Me.tblUpcomEve)
        Me.pnlUpEvtbl.Controls.Add(Me.Label10)
        Me.pnlUpEvtbl.FillColor = System.Drawing.Color.White
        Me.pnlUpEvtbl.Location = New System.Drawing.Point(674, 308)
        Me.pnlUpEvtbl.Name = "pnlUpEvtbl"
        Me.pnlUpEvtbl.ShadowColor = System.Drawing.Color.Silver
        Me.pnlUpEvtbl.ShadowShift = 7
        Me.pnlUpEvtbl.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.pnlUpEvtbl.Size = New System.Drawing.Size(327, 470)
        Me.pnlUpEvtbl.TabIndex = 16
        '
        'tblUpcomEve
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.tblUpcomEve.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblUpcomEve.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tblUpcomEve.ColumnHeadersHeight = 42
        Me.tblUpcomEve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.tblUpcomEve.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eveID, Me.evename})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblUpcomEve.DefaultCellStyle = DataGridViewCellStyle3
        Me.tblUpcomEve.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblUpcomEve.Location = New System.Drawing.Point(3, 76)
        Me.tblUpcomEve.Name = "tblUpcomEve"
        Me.tblUpcomEve.ReadOnly = True
        Me.tblUpcomEve.RowHeadersVisible = False
        Me.tblUpcomEve.RowHeadersWidth = 62
        Me.tblUpcomEve.RowTemplate.Height = 28
        Me.tblUpcomEve.Size = New System.Drawing.Size(311, 391)
        Me.tblUpcomEve.TabIndex = 13
        Me.tblUpcomEve.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.tblUpcomEve.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.tblUpcomEve.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.tblUpcomEve.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.tblUpcomEve.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.tblUpcomEve.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.tblUpcomEve.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblUpcomEve.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.tblUpcomEve.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.tblUpcomEve.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblUpcomEve.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.tblUpcomEve.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.tblUpcomEve.ThemeStyle.HeaderStyle.Height = 42
        Me.tblUpcomEve.ThemeStyle.ReadOnly = True
        Me.tblUpcomEve.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.tblUpcomEve.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.tblUpcomEve.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblUpcomEve.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.tblUpcomEve.ThemeStyle.RowsStyle.Height = 28
        Me.tblUpcomEve.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue
        Me.tblUpcomEve.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(6, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(216, 29)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Upcoming Events"
        '
        'pnlCurrEvetbl
        '
        Me.pnlCurrEvetbl.BackColor = System.Drawing.Color.Transparent
        Me.pnlCurrEvetbl.Controls.Add(Me.tblCurrEve)
        Me.pnlCurrEvetbl.Controls.Add(Me.Label9)
        Me.pnlCurrEvetbl.FillColor = System.Drawing.Color.White
        Me.pnlCurrEvetbl.Location = New System.Drawing.Point(16, 308)
        Me.pnlCurrEvetbl.Name = "pnlCurrEvetbl"
        Me.pnlCurrEvetbl.ShadowColor = System.Drawing.Color.Silver
        Me.pnlCurrEvetbl.ShadowShift = 7
        Me.pnlCurrEvetbl.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.pnlCurrEvetbl.Size = New System.Drawing.Size(632, 470)
        Me.pnlCurrEvetbl.TabIndex = 14
        '
        'tblCurrEve
        '
        Me.tblCurrEve.AllowUserToOrderColumns = True
        Me.tblCurrEve.AllowUserToResizeColumns = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.tblCurrEve.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblCurrEve.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.tblCurrEve.ColumnHeadersHeight = 42
        Me.tblCurrEve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.tblCurrEve.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EventName, Me.venue, Me.startDate, Me.endDate, Me.dept, Me.startTime, Me.endTime, Me.facilititator})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblCurrEve.DefaultCellStyle = DataGridViewCellStyle6
        Me.tblCurrEve.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblCurrEve.Location = New System.Drawing.Point(3, 76)
        Me.tblCurrEve.Name = "tblCurrEve"
        Me.tblCurrEve.ReadOnly = True
        Me.tblCurrEve.RowHeadersVisible = False
        Me.tblCurrEve.RowHeadersWidth = 62
        Me.tblCurrEve.RowTemplate.Height = 28
        Me.tblCurrEve.Size = New System.Drawing.Size(619, 391)
        Me.tblCurrEve.TabIndex = 12
        Me.tblCurrEve.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.tblCurrEve.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.tblCurrEve.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.tblCurrEve.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.tblCurrEve.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.tblCurrEve.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.tblCurrEve.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblCurrEve.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.tblCurrEve.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.tblCurrEve.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblCurrEve.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.tblCurrEve.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.tblCurrEve.ThemeStyle.HeaderStyle.Height = 42
        Me.tblCurrEve.ThemeStyle.ReadOnly = True
        Me.tblCurrEve.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.tblCurrEve.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.tblCurrEve.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblCurrEve.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.tblCurrEve.ThemeStyle.RowsStyle.Height = 28
        Me.tblCurrEve.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightBlue
        Me.tblCurrEve.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(17, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 29)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Current Events"
        '
        'pnlPendingReq
        '
        Me.pnlPendingReq.BackColor = System.Drawing.Color.Transparent
        Me.pnlPendingReq.Controls.Add(Me.Guna2PictureBox4)
        Me.pnlPendingReq.Controls.Add(Me.Label4)
        Me.pnlPendingReq.Controls.Add(Me.lbltotalPend)
        Me.pnlPendingReq.FillColor = System.Drawing.Color.White
        Me.pnlPendingReq.Location = New System.Drawing.Point(731, 104)
        Me.pnlPendingReq.Name = "pnlPendingReq"
        Me.pnlPendingReq.ShadowColor = System.Drawing.Color.Silver
        Me.pnlPendingReq.ShadowShift = 7
        Me.pnlPendingReq.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.pnlPendingReq.Size = New System.Drawing.Size(270, 135)
        Me.pnlPendingReq.TabIndex = 15
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(14, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Pending Request"
        '
        'lbltotalPend
        '
        Me.lbltotalPend.AutoSize = True
        Me.lbltotalPend.BackColor = System.Drawing.Color.Transparent
        Me.lbltotalPend.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalPend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.lbltotalPend.Location = New System.Drawing.Point(21, 32)
        Me.lbltotalPend.Name = "lbltotalPend"
        Me.lbltotalPend.Size = New System.Drawing.Size(46, 31)
        Me.lbltotalPend.TabIndex = 16
        Me.lbltotalPend.Text = "82"
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
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(19, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Upcoming Events"
        '
        'lblUpcomingEvents
        '
        Me.lblUpcomingEvents.AutoSize = True
        Me.lblUpcomingEvents.BackColor = System.Drawing.Color.Transparent
        Me.lblUpcomingEvents.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpcomingEvents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.lblUpcomingEvents.Location = New System.Drawing.Point(17, 32)
        Me.lblUpcomingEvents.Name = "lblUpcomingEvents"
        Me.lblUpcomingEvents.Size = New System.Drawing.Size(30, 31)
        Me.lblUpcomingEvents.TabIndex = 13
        Me.lblUpcomingEvents.Text = "9"
        '
        'pnlCurrEveDay
        '
        Me.pnlCurrEveDay.BackColor = System.Drawing.Color.Transparent
        Me.pnlCurrEveDay.Controls.Add(Me.Guna2PictureBox2)
        Me.pnlCurrEveDay.Controls.Add(Me.Label7)
        Me.pnlCurrEveDay.Controls.Add(Me.lblTotalEvent)
        Me.pnlCurrEveDay.FillColor = System.Drawing.Color.White
        Me.pnlCurrEveDay.Location = New System.Drawing.Point(16, 104)
        Me.pnlCurrEveDay.Name = "pnlCurrEveDay"
        Me.pnlCurrEveDay.ShadowColor = System.Drawing.Color.Silver
        Me.pnlCurrEveDay.ShadowShift = 7
        Me.pnlCurrEveDay.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.pnlCurrEveDay.Size = New System.Drawing.Size(270, 135)
        Me.pnlCurrEveDay.TabIndex = 13
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(18, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Current Event of the Day"
        '
        'lblTotalEvent
        '
        Me.lblTotalEvent.AutoSize = True
        Me.lblTotalEvent.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEvent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.lblTotalEvent.Location = New System.Drawing.Point(17, 32)
        Me.lblTotalEvent.Name = "lblTotalEvent"
        Me.lblTotalEvent.Size = New System.Drawing.Size(30, 31)
        Me.lblTotalEvent.TabIndex = 10
        Me.lblTotalEvent.Text = "5"
        '
        'Timer1
        '
        '
        'eveID
        '
        Me.eveID.HeaderText = "ID"
        Me.eveID.MinimumWidth = 8
        Me.eveID.Name = "eveID"
        Me.eveID.ReadOnly = True
        '
        'evename
        '
        Me.evename.HeaderText = "Name"
        Me.evename.MinimumWidth = 8
        Me.evename.Name = "evename"
        Me.evename.ReadOnly = True
        '
        'EventName
        '
        Me.EventName.HeaderText = "Event Name"
        Me.EventName.MinimumWidth = 8
        Me.EventName.Name = "EventName"
        Me.EventName.ReadOnly = True
        '
        'venue
        '
        Me.venue.HeaderText = "Venue"
        Me.venue.MinimumWidth = 8
        Me.venue.Name = "venue"
        Me.venue.ReadOnly = True
        '
        'startDate
        '
        Me.startDate.HeaderText = "Start Date"
        Me.startDate.MinimumWidth = 6
        Me.startDate.Name = "startDate"
        Me.startDate.ReadOnly = True
        '
        'endDate
        '
        Me.endDate.HeaderText = "End Date"
        Me.endDate.MinimumWidth = 6
        Me.endDate.Name = "endDate"
        Me.endDate.ReadOnly = True
        '
        'dept
        '
        Me.dept.HeaderText = "Department"
        Me.dept.MinimumWidth = 8
        Me.dept.Name = "dept"
        Me.dept.ReadOnly = True
        '
        'startTime
        '
        Me.startTime.HeaderText = "Start Time"
        Me.startTime.MinimumWidth = 8
        Me.startTime.Name = "startTime"
        Me.startTime.ReadOnly = True
        '
        'endTime
        '
        Me.endTime.HeaderText = "End Time"
        Me.endTime.MinimumWidth = 8
        Me.endTime.Name = "endTime"
        Me.endTime.ReadOnly = True
        '
        'facilititator
        '
        Me.facilititator.HeaderText = "Facilitator"
        Me.facilititator.MinimumWidth = 8
        Me.facilititator.Name = "facilititator"
        Me.facilititator.ReadOnly = True
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
        Me.pnlUpEvtbl.ResumeLayout(False)
        Me.pnlUpEvtbl.PerformLayout()
        CType(Me.tblUpcomEve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCurrEvetbl.ResumeLayout(False)
        Me.pnlCurrEvetbl.PerformLayout()
        CType(Me.tblCurrEve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPendingReq.ResumeLayout(False)
        Me.pnlPendingReq.PerformLayout()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlupcoming.ResumeLayout(False)
        Me.pnlupcoming.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCurrEveDay.ResumeLayout(False)
        Me.pnlCurrEveDay.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlUpEvtbl As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents pnlCurrEvetbl As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents pnlPendingReq As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbltotalPend As Label
    Friend WithEvents pnlupcoming As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblUpcomingEvents As Label
    Friend WithEvents pnlCurrEveDay As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalEvent As Label
    Friend WithEvents tblUpcomEve As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents tblCurrEve As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents timedate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents eveID As DataGridViewTextBoxColumn
    Friend WithEvents evename As DataGridViewTextBoxColumn
    Friend WithEvents EventName As DataGridViewTextBoxColumn
    Friend WithEvents venue As DataGridViewTextBoxColumn
    Friend WithEvents startDate As DataGridViewTextBoxColumn
    Friend WithEvents endDate As DataGridViewTextBoxColumn
    Friend WithEvents dept As DataGridViewTextBoxColumn
    Friend WithEvents startTime As DataGridViewTextBoxColumn
    Friend WithEvents endTime As DataGridViewTextBoxColumn
    Friend WithEvents facilititator As DataGridViewTextBoxColumn
End Class
