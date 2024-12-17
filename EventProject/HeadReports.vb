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
        Dim eventColumns As String() = {"venue", "facilitator"}

        ' Add valid columns to cbFilter
        cbFilter.Items.Clear()
        cbFilter.Items.AddRange(studentColumns)
        cbFilter.Items.AddRange(eventColumns)
    End Sub

    Private Sub cbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilter.SelectedIndexChanged
        Dim selectedFilter As String = cbFilter.Text
        If String.IsNullOrEmpty(selectedFilter) Then Return

        Dim sqlQuery As String
        Dim isStudentColumn As Boolean = {"First_Name", "Last_Name", "Department", "Course", "Year", "Section", "StudentID"}.Contains(selectedFilter)
        Dim isEventColumn As Boolean = {"venue", "facilitator"}.Contains(selectedFilter)

        If isStudentColumn Then
            sqlQuery = $"SELECT DISTINCT {selectedFilter} FROM StudentInformation"
        ElseIf isEventColumn Then
            sqlQuery = $"SELECT DISTINCT {selectedFilter} FROM events"
        Else
            MessageBox.Show("Invalid column selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            cmd = New MySqlCommand(sqlQuery, conn)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()

            If conn.State = ConnectionState.Closed Then conn.Open()

            da.Fill(dt)

            cbData.Items.Clear()

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No data found for the selected filter.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            For Each row As DataRow In dt.Rows
                cbData.Items.Add(row(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show($"Error loading filter data: {ex.Message}" & vbCrLf & $"SQL Query: {sqlQuery}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        ' Check if the filter is from the StudentInformation table
        Dim studentColumns As String() = {"First_Name", "Last_Name", "Department", "Course", "Year", "Section", "StudentID"}
        If studentColumns.Contains(filterColumn) Then
            targetTable = "StudentInformation"
            sqlQuery = $"SELECT * FROM {targetTable} WHERE {filterColumn} = @FilterValue"

            ' Check if the filter is from the events table
        ElseIf filterColumn = "venue" OrElse filterColumn = "facilitator" Then
            targetTable = "events"
            sqlQuery = $"SELECT * FROM {targetTable} WHERE {filterColumn} = @FilterValue"

            ' If the filter is invalid
        Else
            MessageBox.Show("Invalid filter selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Execute the query
        dt = New DataTable()

        Try
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@FilterValue", filterValue)

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

End Class