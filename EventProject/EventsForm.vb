Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Module1

Public Class EventsForm
    Dim sqlQuery As String
    Dim da As MySqlDataAdapter
    Dim dtMain As DataTable
    Dim dt As DataTable
    Dim cmd As New MySqlCommand

    Private Sub EventsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        LoadEventsData()
        LoadEventFilters()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timedate.Text = Date.Now.ToString()
    End Sub

    Public Sub LoadEventsData()
        Try
            ' Clear existing columns
            dgvEvents.Columns.Clear()

            ' Main events DataTable
            dtMain = New DataTable()
            sqlQuery = "SELECT eventID, eventName, venue, eventStart_date, eventEnd_date, starttime, endtime, department, facilitator, contactPerson, ConP_messenger, ConP_contactNo, " &
                       "CASE " &
                           "WHEN event_Status = 'Cancelled' THEN 'Cancelled' " &
                           "WHEN NOW() BETWEEN CONCAT(eventStart_date, ' ', starttime) AND CONCAT(eventEnd_date, ' ', endtime) THEN 'In Progress' " &
                           "WHEN NOW() > CONCAT(eventEnd_date, ' ', endtime) THEN 'Completed' " &
                           "ELSE 'Scheduled' " &
                       "END AS event_Status " &
                       "FROM events"
            da = New MySqlDataAdapter(sqlQuery, Module1.conn)
            conn.Open()
            da.Fill(dtMain)
            conn.Close()

            ' Bind main events to DataGridViewEvents
            dgvEvents.DataSource = dtMain

            ' Add buttons: Edit, Delete, and Cancel
            AddButtonColumn("Edit", "Edit")
            AddButtonColumn("Delete", "Delete")
            AddButtonColumn("Cancel", "Cancel")

            ' Load Cancelled Events into dgvCE
            dt = New DataTable()
            sqlQuery = "SELECT * FROM events WHERE event_Status = 'Cancelled'"
            da = New MySqlDataAdapter(sqlQuery, conn)
            conn.Open()
            da.Fill(dt)
            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub AddButtonColumn(buttonName As String, buttonText As String)
        Dim buttonColumn As New DataGridViewButtonColumn()
        buttonColumn.Name = buttonName
        buttonColumn.HeaderText = buttonName
        buttonColumn.Text = buttonText
        buttonColumn.UseColumnTextForButtonValue = True
        dgvEvents.Columns.Add(buttonColumn)
    End Sub

    Private Sub MoveEventToCancelled(eventId As String, rowIndex As Integer)
        Try
            sqlQuery = "UPDATE events SET event_Status = 'Cancelled' WHERE eventid = @eventId"
            Dim cmd As New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@eventId", eventId)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            LoadEventsData()
            MessageBox.Show("Event has been cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error cancelling event: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub DeleteEvent(eventid As String, rowIndex As Integer)
        Try
            Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this event?", "Delete Event", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirmDelete = DialogResult.Yes Then
                sqlQuery = "DELETE FROM events WHERE eventid = @eventId"
                Dim cmd As New MySqlCommand(sqlQuery, conn)
                cmd.Parameters.AddWithValue("@eventId", eventid)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()

                dgvEvents.Rows.RemoveAt(rowIndex)

                MessageBox.Show("Event deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting event: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub EditEvent(eventid As String)
        Try
            sqlQuery = "SELECT * FROM events WHERE eventID = @eventid"
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@eventid", eventid)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            conn.Open()
            da.Fill(dt)
            conn.Close()

            If dt.Rows.Count > 0 Then
                Dim editForm As New AddEventsForm()

                editForm.IsEditMode = True
                editForm.EventID = Convert.ToInt32(dt.Rows(0)("eventID"))
                editForm.EventName = dt.Rows(0)("eventName").ToString()
                editForm.Venue = dt.Rows(0)("venue").ToString()
                editForm.EventStartDate = Convert.ToDateTime(dt.Rows(0)("eventStart_date"))
                editForm.EventEndDate = Convert.ToDateTime(dt.Rows(0)("eventEnd_date"))

                If Not IsDBNull(dt.Rows(0)("starttime")) AndAlso Not String.IsNullOrWhiteSpace(dt.Rows(0)("starttime").ToString()) Then
                    Dim startTimeString As String = dt.Rows(0)("starttime").ToString().Trim()
                    Dim startDateTime As DateTime
                    If DateTime.TryParse("01/01/2000 " & startTimeString, startDateTime) Then
                        editForm.StartTime = startDateTime
                    Else
                        editForm.StartTime = DateTime.MinValue
                    End If
                Else
                    editForm.StartTime = DateTime.MinValue
                End If

                If Not IsDBNull(dt.Rows(0)("endtime")) AndAlso Not String.IsNullOrWhiteSpace(dt.Rows(0)("endtime").ToString()) Then
                    Dim endTimeString As String = dt.Rows(0)("endtime").ToString().Trim()
                    Dim endDateTime As DateTime
                    If DateTime.TryParse("01/01/2000 " & endTimeString, endDateTime) Then
                        editForm.EndTime = endDateTime
                    Else
                        editForm.EndTime = DateTime.MinValue
                    End If
                Else
                    editForm.EndTime = DateTime.MinValue
                End If

                editForm.Department = dt.Rows(0)("department").ToString()
                editForm.Facilitator = dt.Rows(0)("facilitator").ToString()
                editForm.ContactPerson = dt.Rows(0)("contactPerson").ToString()
                editForm.ContactMessenger = dt.Rows(0)("ConP_messenger").ToString()
                editForm.ContactNo = dt.Rows(0)("ConP_contactNo").ToString()

                editForm.ParentFormInstance = Me
                editForm.ShowDialog()
            Else
                MessageBox.Show("Event not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error editing event: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub LoadEventFilters()
        cbEventFilter.Items.Clear()
        cbEventFilter.Items.AddRange(New String() {"eventname", "venue", "department", "facilitator", "contactPerson", "ConP_messenger", "ConP_contactNo"})
        cbEventFilter.SelectedIndex = -1
    End Sub

    Private Sub DataGridViewEvents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEvents.CellContentClick
        If e.RowIndex >= 0 Then
            Dim clickedColumn As String = dgvEvents.Columns(e.ColumnIndex).Name

            Dim eventid As String = ""
            If dgvEvents.Rows(e.RowIndex).Cells("eventid").Value IsNot Nothing Then
                eventid = dgvEvents.Rows(e.RowIndex).Cells("eventid").Value.ToString()
            Else
                MessageBox.Show("Event ID is missing or invalid.")
                Exit Sub
            End If

            Select Case clickedColumn
                Case "Edit"
                    EditEvent(eventid)
                Case "Delete"
                    DeleteEvent(eventid, e.RowIndex)
                Case "Cancel"
                    MoveEventToCancelled(eventid, e.RowIndex)
            End Select
        End If
    End Sub

    Private Sub cbEventFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEventFilter.SelectedIndexChanged
        If cbEventFilter.SelectedItem IsNot Nothing Then
            LoadComboBoxValues(cbEventFilter.SelectedItem.ToString())
        End If
    End Sub

    Private Sub LoadComboBoxValues(selectedColumn As String)
        Try
            sqlQuery = $"SELECT DISTINCT {selectedColumn} FROM events WHERE {selectedColumn} IS NOT NULL"
            Dim dt As New DataTable()
            da = New MySqlDataAdapter(sqlQuery, conn)

            conn.Open()
            da.Fill(dt)
            conn.Close()

            cbEventData.Items.Clear()
            For Each row As DataRow In dt.Rows
                cbEventData.Items.Add(row(0).ToString())
            Next
            cbEventData.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error loading ComboBox values: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        Dim addEventForm As New AddEventsForm()
        addEventForm.ParentFormInstance = Me
        addEventForm.ShowDialog()
    End Sub

    Private Sub btnSearchEvent_Click(sender As Object, e As EventArgs) Handles btnSearchEvent.Click
        ' Validate user input
        If cbEventFilter.SelectedItem Is Nothing OrElse cbEventData.SelectedItem Is Nothing Then
            MessageBox.Show("Please select both a filter column and a value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedColumn As String = cbEventFilter.SelectedItem.ToString()
        Dim selectedValue As String = cbEventData.SelectedItem.ToString()

        Dim query As String = $"SELECT * FROM events WHERE {selectedColumn} = @value"
        Dim dt As New DataTable()

        Try
            ' Use MySqlConnection for MySQL databases
            Using conn As New MySqlConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    ' Add parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@value", selectedValue)

                    ' Execute query and fill the DataTable
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            ' Bind the filtered results to the DataGridView
            dgvEvents.DataSource = dt
            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No matching events found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error filtering events: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrintEvent_Click(sender As Object, e As EventArgs) Handles btnPrintEvent.Click
        Dim reportForm As New EventReport()
        reportForm.ReportPath = "C:\Users\user\source\repos\httprie\ERS-FinalProject\EventProject\Event.rpt"
        reportForm.ShowDialog()
    End Sub
End Class