Imports MySql.Data.MySqlClient
Public Class HeadReports
    Dim sqlQuery As String
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable

    Private Sub HeadReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        PopulateFilters()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timedate.Text = DateTime.Now.ToString()
    End Sub

    Private Sub PopulateFilters()
        ' Columns from StudentInformation table
        Dim studentColumns As String() = {"First_Name", "Last_Name", "Department", "Course", "Year", "Section", "StudentID"}
        ' Columns from events table
        Dim eventColumns As String() = {"venue", "facilitator", "eventname"}

        ' Add valid columns to cbFilter
        cbFilter.Items.Clear()
        cbFilter.Items.AddRange(studentColumns)
        cbFilter.Items.AddRange(eventColumns)
    End Sub

    Private Sub cbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilter.SelectedIndexChanged
        Dim selectedFilter As String = cbFilter.Text
        If String.IsNullOrEmpty(selectedFilter) Then Return

        Dim sqlQuery As String
        Dim isStudentColumn As Boolean = {"First_Name", "Last_Name", "Course", "Year", "Section", "StudentID"}.Contains(selectedFilter)
        Dim isEventColumn As Boolean = {"venue", "facilitator", "eventname"}.Contains(selectedFilter)
        Dim isDepartmentColumn As Boolean = selectedFilter = "Department"

        If isStudentColumn Then
            ' Make sure the query selects from StudentInformation table based on the selected column
            sqlQuery = $"SELECT DISTINCT {selectedFilter} FROM StudentInformation"
        ElseIf isEventColumn Then
            sqlQuery = $"SELECT DISTINCT {selectedFilter} FROM events"
        ElseIf isDepartmentColumn Then
            ' Handle the case where the filter is "Department" and join StudentInformation and events
            sqlQuery = $"SELECT DISTINCT si.{selectedFilter} FROM StudentInformation si " &
                   "INNER JOIN events e ON si.StudentID = e.StudentID"
        Else
            MessageBox.Show("Invalid column selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            cmd = New MySqlCommand(sqlQuery, conn)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()

            ' Open the connection if it's not already open
            If conn.State = ConnectionState.Closed Then conn.Open()

            da.Fill(dt)

            cbData.Items.Clear()

            ' Check if the query returned any results
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No data found for the selected filter.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Populate the combobox with the distinct values from the query result
            For Each row As DataRow In dt.Rows
                cbData.Items.Add(row(0).ToString()) ' Add the first column value to cbData
            Next
        Catch ex As Exception
            MessageBox.Show($"Error loading filter data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btnSearchRep_Click(sender As Object, e As EventArgs) Handles btnSearchRep.Click
        Dim filterColumn As String = cbFilter.Text
        Dim filterValue As String = cbData.Text

        If String.IsNullOrEmpty(filterColumn) OrElse String.IsNullOrEmpty(filterValue) Then
            MessageBox.Show("Please select a filter and a value from the comboboxes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Initialize the query and target table
        Dim sqlQuery As String = ""
        Dim targetTable As String = ""
        Dim hasDateRange As Boolean = False ' Flag to check if date range is set

        ' Check if the filter is from the StudentInformation table
        Dim studentColumns As String() = {"First_Name", "Last_Name", "Department", "Course", "Year", "Section", "StudentID"}
        If studentColumns.Contains(filterColumn) Then
            targetTable = "StudentInformation"
            sqlQuery = $"SELECT * FROM {targetTable} WHERE {filterColumn} = @FilterValue"

            ' Check if the filter is from the events table
        ElseIf filterColumn = "venue" OrElse filterColumn = "facilitator" OrElse filterColumn = "eventname" Then
            targetTable = "events"
            sqlQuery = $"SELECT * FROM {targetTable} WHERE {filterColumn} = @FilterValue"
        Else
            MessageBox.Show("Invalid filter selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the date pickers have values (only then apply date filtering)
        If Not ReportStart.Value = Nothing AndAlso Not ReportEnd.Value = Nothing Then
            hasDateRange = True
            If targetTable = "events" Then
                ' If filtering on events, apply the date range directly
                sqlQuery = $"SELECT * FROM events WHERE (eventStart_date BETWEEN @StartDate AND @EndDate) " &
                       "OR (eventEnd_date BETWEEN @StartDate AND @EndDate) " &
                       "OR (eventStart_date <= @StartDate AND eventEnd_date >= @EndDate)"
            ElseIf targetTable = "StudentInformation" Then
                ' If filtering on StudentInformation, join with the attendancelog table and events table to apply the date range filter
                sqlQuery &= " AND EXISTS (SELECT 1 FROM attendancelog al " &
                        "INNER JOIN events e ON al.eventid = e.eventid " &
                        "WHERE al.StudentID = StudentInformation.StudentID " &
                        "AND (e.eventStart_date BETWEEN @StartDate AND @EndDate " &
                        "OR e.eventEnd_date BETWEEN @StartDate AND @EndDate " &
                        "OR e.eventStart_date <= @StartDate AND e.eventEnd_date >= @EndDate))"
            End If
        End If

        ' Execute the query
        dt = New DataTable()

        Try
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@FilterValue", filterValue)

            ' If date range is specified, add parameters for the start and end date
            If hasDateRange Then
                cmd.Parameters.AddWithValue("@StartDate", ReportStart.Value)
                cmd.Parameters.AddWithValue("@EndDate", ReportEnd.Value)
            End If

            da = New MySqlDataAdapter(cmd)

            If conn.State = ConnectionState.Closed Then conn.Open()

            da.Fill(dt)

            ' Set the data source for the report grid
            ReportData.DataSource = dt
            ReportData.ColumnHeadersHeight = 30
            ReportData.AutoResizeColumns()

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        Dim filterColumn As String = cbFilter.Text
        Dim filterValue As String = cbData.Text

        If String.IsNullOrEmpty(filterColumn) OrElse String.IsNullOrEmpty(filterValue) Then
            MessageBox.Show("Please select a filter and a value from the comboboxes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Initialize variables for the query
        Dim sqlQuery As String = ""
        Dim studentColumns As String() = {"First_Name", "Last_Name", "Department", "Course", "Year", "Section", "StudentID"}

        Try
            ' Build query based on filter type
            If studentColumns.Contains(filterColumn) Then
                sqlQuery = "SELECT attendeeid, eventid, eventname, eventdate, StudentID, " &
                      "First_Name, Last_Name, Department, Course, Year, Section, " &
                      "timein_time, timeout_time " &
                      "FROM attendancelog " &
                      $"WHERE {filterColumn} = @FilterValue " &
                      "ORDER BY eventdate DESC, timein_time DESC"
            ElseIf {"venue", "facilitator", "eventname"}.Contains(filterColumn) Then
                ' For event-related filters, we need to join with events table since these columns are not in attendancelog
                If filterColumn = "eventname" Then
                    sqlQuery = "SELECT attendeeid, eventid, eventname, eventdate, StudentID, " &
                          "First_Name, Last_Name, Department, Course, Year, Section, " &
                          "timein_time, timeout_time " &
                          "FROM attendancelog " &
                          "WHERE eventname = @FilterValue " &
                          "ORDER BY eventdate DESC, timein_time DESC"
                Else
                    sqlQuery = "SELECT al.attendeeid, al.eventid, al.eventname, al.eventdate, " &
                          "al.StudentID, al.First_Name, al.Last_Name, al.Department, " &
                          "al.Course, al.Year, al.Section, al.timein_time, al.timeout_time " &
                          "FROM attendancelog al " &
                          "INNER JOIN events e ON al.eventid = e.eventid " &
                          $"WHERE e.{filterColumn} = @FilterValue " &
                          "ORDER BY al.eventdate DESC, al.timein_time DESC"
                End If
            Else
                MessageBox.Show("Invalid filter selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Execute the query
            dt = New DataTable()
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@FilterValue", filterValue)
            da = New MySqlDataAdapter(cmd)

            If conn.State = ConnectionState.Closed Then conn.Open()
            da.Fill(dt)

            ' Format datetime columns for better display
            If dt.Rows.Count > 0 Then
                If dt.Columns.Contains("timein_time") Then
                    For Each row As DataRow In dt.Rows
                        If Not IsDBNull(row("timein_time")) Then
                            row("timein_time") = Convert.ToDateTime(row("timein_time")).ToString("yyyy-MM-dd HH:mm:ss")
                        End If
                    Next
                End If
                If dt.Columns.Contains("timeout_time") Then
                    For Each row As DataRow In dt.Rows
                        If Not IsDBNull(row("timeout_time")) Then
                            row("timeout_time") = Convert.ToDateTime(row("timeout_time")).ToString("yyyy-MM-dd HH:mm:ss")
                        End If
                    Next
                End If
            End If

            ' Display results in the grid
            ReportData.DataSource = dt
            ReportData.ColumnHeadersHeight = 30
            ReportData.AutoResizeColumns()

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No attendance records found for the selected filter.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show($"Error loading attendance data: {ex.Message}" & vbCrLf & $"SQL Query: {sqlQuery}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim reportForm As New GenerateReport()
        reportForm.ReportPath = "C:\Users\user\source\repos\httprie\ERS-FinalProject\EventProject\ERSReport.rpt"
        reportForm.ShowDialog()
    End Sub
End Class