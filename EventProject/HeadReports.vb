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
        Dim studentColumns As String() = {"StudentID", "First_Name", "Last_Name", "Department", "Course", "Year", "Section"}
        Dim eventColumns As String() = {"Venue", "Facilitator", "EventID"}

        cbFilter.Items.Clear()
        cbFilter.Items.AddRange(studentColumns)
        cbFilter.Items.AddRange(eventColumns)
    End Sub

    Private Sub cbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilter.SelectedIndexChanged
        Dim selectedFilter As String = cbFilter.Text
        If String.IsNullOrEmpty(selectedFilter) Then Return

        Dim sqlQuery As String = $"SELECT DISTINCT {selectedFilter} FROM StudentInformation UNION SELECT DISTINCT {selectedFilter} FROM events"
        dt = New DataTable()

        Try
            cmd = New MySqlCommand(sqlQuery, conn)
            da = New MySqlDataAdapter(cmd)

            If conn.State = ConnectionState.Closed Then conn.Open()

            da.Fill(dt)
            cbData.Items.Clear()

            For Each row As DataRow In dt.Rows
                cbData.Items.Add(row(selectedFilter).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading filter data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim filterColumn As String = cbFilter.Text
        Dim filterValue As String = cbData.Text

        If String.IsNullOrEmpty(filterColumn) OrElse String.IsNullOrEmpty(filterValue) Then
            MessageBox.Show("Please select a filter and a value from the comboboxes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        sqlQuery = $"SELECT * FROM StudentInformation WHERE {filterColumn} = @FilterValue"
        dt = New DataTable()

        Try
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@FilterValue", filterValue)

            da = New MySqlDataAdapter(cmd)
            If conn.State = ConnectionState.Closed Then conn.Open()

            da.Fill(dt)
            ReportData.DataSource = dt
            ReportData.ColumnHeadersHeight = 30
            ReportData.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("Error loading student information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim startDate As Date = ReportStart.Value.Date
        Dim endDate As Date = ReportEnd.Value.Date

        sqlQuery = $"
            SELECT 
                events.EventID,
                events.EventName,
                events.Venue,
                events.Facilitator,
                attendancelog.studno AS StudentID,
                StudentInformation.First_Name,
                StudentInformation.Last_Name,
                StudentInformation.Course,
                StudentInformation.Year,
                StudentInformation.Section,
                attendancelog.timein_time,
                attendancelog.timeout_time
            FROM 
                events
            LEFT JOIN 
                attendancelog ON attendancelog.eventid = events.EventID
            LEFT JOIN 
                StudentInformation ON attendancelog.studno = StudentInformation.StudentID
            WHERE 
                events.eventstart >= @StartDate AND events.eventend <= @EndDate"

        dt = New DataTable()

        Try
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@StartDate", startDate)
            cmd.Parameters.AddWithValue("@EndDate", endDate)

            da = New MySqlDataAdapter(cmd)
            If conn.State = ConnectionState.Closed Then conn.Open()

            da.Fill(dt)
            ReportData.DataSource = dt
            ReportData.ColumnHeadersHeight = 30
            ReportData.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("Error loading data for the selected date range: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
