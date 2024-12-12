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
        Me.cmbTables = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFilter = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateTimePickerEnd = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dateTimePickerStart = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.ReportData = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbFilterData = New System.Windows.Forms.ComboBox()
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
        Me.timedate.Size = New System.Drawing.Size(147, 20)
        Me.timedate.TabIndex = 41
        Me.timedate.Text = "                       "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 18)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "FILTER BY:"
        '
        'Timer1
        '
        '
        'cmbTables
        '
        Me.cmbTables.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTables.ForeColor = System.Drawing.Color.Black
        Me.cmbTables.FormattingEnabled = True
        Me.cmbTables.Items.AddRange(New Object() {"STUDENT ID", "FIRST NAME", "LAST NAME", "VENUE", "DEPARTMENT", "FACILITATOR", "EVENT ID", "COURSE", "YEAR", "SECTION", ""})
        Me.cmbTables.Location = New System.Drawing.Point(20, 90)
        Me.cmbTables.Name = "cmbTables"
        Me.cmbTables.Size = New System.Drawing.Size(343, 28)
        Me.cmbTables.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(284, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 18)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "-"
        '
        'btnFilter
        '
        Me.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFilter.FillColor = System.Drawing.Color.White
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnFilter.ForeColor = System.Drawing.Color.Black
        Me.btnFilter.Location = New System.Drawing.Point(842, 159)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(157, 38)
        Me.btnFilter.TabIndex = 54
        Me.btnFilter.Text = "PRINT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 18)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "START DATE:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(386, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 18)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "END DATE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(369, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 18)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "-"
        '
        'dateTimePickerEnd
        '
        Me.dateTimePickerEnd.AutoRoundedCorners = True
        Me.dateTimePickerEnd.BackColor = System.Drawing.SystemColors.Control
        Me.dateTimePickerEnd.BorderColor = System.Drawing.Color.White
        Me.dateTimePickerEnd.BorderRadius = 18
        Me.dateTimePickerEnd.Checked = True
        Me.dateTimePickerEnd.FillColor = System.Drawing.Color.White
        Me.dateTimePickerEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.dateTimePickerEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateTimePickerEnd.Location = New System.Drawing.Point(391, 159)
        Me.dateTimePickerEnd.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateTimePickerEnd.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateTimePickerEnd.Name = "dateTimePickerEnd"
        Me.dateTimePickerEnd.Size = New System.Drawing.Size(425, 38)
        Me.dateTimePickerEnd.TabIndex = 61
        Me.dateTimePickerEnd.Value = New Date(2024, 11, 8, 16, 4, 40, 702)
        '
        'dateTimePickerStart
        '
        Me.dateTimePickerStart.AutoRoundedCorners = True
        Me.dateTimePickerStart.BackColor = System.Drawing.SystemColors.Control
        Me.dateTimePickerStart.BorderColor = System.Drawing.Color.White
        Me.dateTimePickerStart.BorderRadius = 18
        Me.dateTimePickerStart.Checked = True
        Me.dateTimePickerStart.FillColor = System.Drawing.Color.White
        Me.dateTimePickerStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.dateTimePickerStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateTimePickerStart.Location = New System.Drawing.Point(12, 159)
        Me.dateTimePickerStart.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateTimePickerStart.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateTimePickerStart.Name = "dateTimePickerStart"
        Me.dateTimePickerStart.Size = New System.Drawing.Size(350, 38)
        Me.dateTimePickerStart.TabIndex = 60
        Me.dateTimePickerStart.Value = New Date(2024, 11, 8, 16, 4, 40, 702)
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
        Me.ReportData.Location = New System.Drawing.Point(12, 228)
        Me.ReportData.Name = "ReportData"
        Me.ReportData.RowHeadersVisible = False
        Me.ReportData.RowHeadersWidth = 62
        Me.ReportData.RowTemplate.Height = 28
        Me.ReportData.Size = New System.Drawing.Size(987, 434)
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
        'btnSearch
        '
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.White
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(842, 79)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(157, 39)
        Me.btnSearch.TabIndex = 63
        Me.btnSearch.Text = "SEARCH"
        '
        'cmbFilterData
        '
        Me.cmbFilterData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilterData.ForeColor = System.Drawing.Color.Black
        Me.cmbFilterData.FormattingEnabled = True
        Me.cmbFilterData.Items.AddRange(New Object() {"STUDENT ID", "FIRST NAME", "LAST NAME", "VENUE", "DEPARTMENT", "FACILITATOR", "EVENT ID", "COURSE", "YEAR", "SECTION", ""})
        Me.cmbFilterData.Location = New System.Drawing.Point(391, 90)
        Me.cmbFilterData.Name = "cmbFilterData"
        Me.cmbFilterData.Size = New System.Drawing.Size(425, 28)
        Me.cmbFilterData.TabIndex = 64
        '
        'HeadReports
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1011, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbFilterData)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.ReportData)
        Me.Controls.Add(Me.dateTimePickerEnd)
        Me.Controls.Add(Me.dateTimePickerStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbTables)
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
    Friend WithEvents cmbTables As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFilter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dateTimePickerEnd As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dateTimePickerStart As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ReportData As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmbFilterData As ComboBox
End Class