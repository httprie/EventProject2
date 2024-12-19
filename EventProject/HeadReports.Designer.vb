<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HeadReports
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
        Me.timedate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSearchRep = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportEnd = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.ReportStart = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.ReportData = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.cbFilter = New System.Windows.Forms.ComboBox()
        Me.cbData = New System.Windows.Forms.ComboBox()
        Me.btnAttendance = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.ReportData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timedate
        '
        Me.timedate.AutoSize = True
        Me.timedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timedate.ForeColor = System.Drawing.Color.Black
        Me.timedate.Location = New System.Drawing.Point(13, 26)
        Me.timedate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.timedate.Name = "timedate"
        Me.timedate.Size = New System.Drawing.Size(150, 25)
        Me.timedate.TabIndex = 41
        Me.timedate.Text = "                       "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 22)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "FILTER BY:"
        '
        'Timer1
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(284, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 22)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "-"
        '
        'btnSearchRep
        '
        Me.btnSearchRep.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchRep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchRep.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearchRep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchRep.FillColor = System.Drawing.Color.White
        Me.btnSearchRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearchRep.ForeColor = System.Drawing.Color.Black
        Me.btnSearchRep.Location = New System.Drawing.Point(718, 90)
        Me.btnSearchRep.Name = "btnSearchRep"
        Me.btnSearchRep.Size = New System.Drawing.Size(123, 28)
        Me.btnSearchRep.TabIndex = 54
        Me.btnSearchRep.Text = "Search"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 22)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "START DATE:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(386, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 22)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "END DATE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(368, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 22)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "-"
        '
        'ReportEnd
        '
        Me.ReportEnd.AutoRoundedCorners = True
        Me.ReportEnd.BackColor = System.Drawing.SystemColors.Control
        Me.ReportEnd.BorderColor = System.Drawing.Color.White
        Me.ReportEnd.BorderRadius = 18
        Me.ReportEnd.Checked = True
        Me.ReportEnd.FillColor = System.Drawing.Color.White
        Me.ReportEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ReportEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.ReportEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.ReportEnd.Location = New System.Drawing.Point(391, 150)
        Me.ReportEnd.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ReportEnd.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ReportEnd.Name = "ReportEnd"
        Me.ReportEnd.Size = New System.Drawing.Size(425, 38)
        Me.ReportEnd.TabIndex = 61
        Me.ReportEnd.Value = New Date(2024, 12, 31, 0, 0, 0, 0)
        '
        'ReportStart
        '
        Me.ReportStart.AutoRoundedCorners = True
        Me.ReportStart.BackColor = System.Drawing.SystemColors.Control
        Me.ReportStart.BorderColor = System.Drawing.Color.White
        Me.ReportStart.BorderRadius = 18
        Me.ReportStart.Checked = True
        Me.ReportStart.FillColor = System.Drawing.Color.White
        Me.ReportStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ReportStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.ReportStart.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.ReportStart.Location = New System.Drawing.Point(12, 150)
        Me.ReportStart.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ReportStart.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ReportStart.Name = "ReportStart"
        Me.ReportStart.Size = New System.Drawing.Size(350, 38)
        Me.ReportStart.TabIndex = 60
        Me.ReportStart.Value = New Date(2024, 12, 1, 0, 0, 0, 0)
        '
        'ReportData
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.ReportData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReportData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ReportData.ColumnHeadersHeight = 4
        Me.ReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ReportData.DefaultCellStyle = DataGridViewCellStyle3
        Me.ReportData.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReportData.Location = New System.Drawing.Point(12, 214)
        Me.ReportData.Name = "ReportData"
        Me.ReportData.RowHeadersVisible = False
        Me.ReportData.RowHeadersWidth = 62
        Me.ReportData.RowTemplate.Height = 28
        Me.ReportData.Size = New System.Drawing.Size(987, 481)
        Me.ReportData.TabIndex = 62
        Me.ReportData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.ReportData.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ReportData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ReportData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ReportData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ReportData.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ReportData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReportData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReportData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ReportData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ReportData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ReportData.ThemeStyle.HeaderStyle.Height = 4
        Me.ReportData.ThemeStyle.ReadOnly = False
        Me.ReportData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.ReportData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ReportData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ReportData.ThemeStyle.RowsStyle.Height = 28
        Me.ReportData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReportData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnPrint
        '
        Me.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrint.FillColor = System.Drawing.Color.White
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Location = New System.Drawing.Point(832, 145)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(157, 35)
        Me.btnPrint.TabIndex = 63
        Me.btnPrint.Text = "Print"
        '
        'cbFilter
        '
        Me.cbFilter.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilter.FormattingEnabled = True
        Me.cbFilter.Location = New System.Drawing.Point(18, 90)
        Me.cbFilter.Name = "cbFilter"
        Me.cbFilter.Size = New System.Drawing.Size(240, 28)
        Me.cbFilter.TabIndex = 64
        '
        'cbData
        '
        Me.cbData.Font = New System.Drawing.Font("Ubuntu", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbData.FormattingEnabled = True
        Me.cbData.Location = New System.Drawing.Point(264, 90)
        Me.cbData.Name = "cbData"
        Me.cbData.Size = New System.Drawing.Size(448, 28)
        Me.cbData.TabIndex = 65
        '
        'btnAttendance
        '
        Me.btnAttendance.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAttendance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAttendance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAttendance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAttendance.FillColor = System.Drawing.Color.White
        Me.btnAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAttendance.ForeColor = System.Drawing.Color.Black
        Me.btnAttendance.Location = New System.Drawing.Point(847, 90)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(142, 28)
        Me.btnAttendance.TabIndex = 66
        Me.btnAttendance.Text = "Attendance"
        '
        'HeadReports
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1011, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAttendance)
        Me.Controls.Add(Me.cbData)
        Me.Controls.Add(Me.cbFilter)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.ReportData)
        Me.Controls.Add(Me.ReportEnd)
        Me.Controls.Add(Me.ReportStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSearchRep)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.timedate)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HeadReports"
        Me.Text = "HeadReports"
        CType(Me.ReportData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timedate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSearchRep As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ReportEnd As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents ReportStart As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents ReportData As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbFilter As ComboBox
    Friend WithEvents cbData As ComboBox
    Friend WithEvents btnAttendance As Guna.UI2.WinForms.Guna2Button
End Class