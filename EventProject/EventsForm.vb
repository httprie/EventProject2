Imports MySql.Data.MySqlClient

Public Class EventsForm
    Dim sqlQuery As String
    Dim da As MySqlDataAdapter
    Public dt As DataTable

    Private Sub EventsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        LoadEventsData()
        LoadPendingEvents()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timedate.Text = Date.Now.ToString()
    End Sub

    Public Sub LoadEventsData()
        Try
            DataGridViewEvents.Columns.Clear()

            dt = New DataTable()
            sqlQuery = "SELECT * FROM Events"
            da = New MySqlDataAdapter(sqlQuery, conn)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            da.Fill(dt)

            conn.Close()

            DataGridViewEvents.DataSource = dt

            DataGridViewEvents.Columns("eventid").HeaderText = "Event ID"
            DataGridViewEvents.Columns("eventname").HeaderText = "Name"
            DataGridViewEvents.Columns("venue").HeaderText = "Venue"
            DataGridViewEvents.Columns("eventStart").HeaderText = "Start Date"
            DataGridViewEvents.Columns("eventEnd").HeaderText = "End Date"
            DataGridViewEvents.Columns("department").HeaderText = "Department"
            DataGridViewEvents.Columns("starttime").HeaderText = "Start Time"
            DataGridViewEvents.Columns("endtime").HeaderText = "End Time"

            Dim editColumn As New DataGridViewButtonColumn()
            editColumn.Name = "Edit"
            editColumn.HeaderText = "Edit"
            editColumn.Text = "Edit"
            editColumn.UseColumnTextForButtonValue = True
            DataGridViewEvents.Columns.Add(editColumn)

            Dim deleteColumn As New DataGridViewButtonColumn()
            deleteColumn.Name = "Delete"
            deleteColumn.HeaderText = "Delete"
            deleteColumn.Text = "Delete"
            deleteColumn.UseColumnTextForButtonValue = True
            DataGridViewEvents.Columns.Add(deleteColumn)

            DataGridViewEvents.AutoResizeColumns()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Public Sub LoadPendingEvents()
        Try
            Guna2DataGridView1.Columns.Clear()

            Dim pendingDt As New DataTable()
            sqlQuery = "SELECT * FROM Events WHERE status = 'Pending'"
            da = New MySqlDataAdapter(sqlQuery, conn)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            da.Fill(pendingDt)

            conn.Close()

            Guna2DataGridView1.DataSource = pendingDt

            Guna2DataGridView1.Columns("eventid").HeaderText = "Request ID"
            Guna2DataGridView1.Columns("eventname").HeaderText = "Event Name"
            Guna2DataGridView1.Columns("venue").HeaderText = "Venue"
            Guna2DataGridView1.Columns("department").HeaderText = "Department"
            Guna2DataGridView1.Columns("eventStart_date").HeaderText = "Start Date"
            Guna2DataGridView1.Columns("eventEnd_date").HeaderText = "End Date"

            Dim acceptColumn As New DataGridViewButtonColumn()
            acceptColumn.Name = "Accept"
            acceptColumn.HeaderText = "Accept"
            acceptColumn.Text = "Accept"
            acceptColumn.UseColumnTextForButtonValue = True
            Guna2DataGridView1.Columns.Add(acceptColumn)

            Dim rejectColumn As New DataGridViewButtonColumn()
            rejectColumn.Name = "Reject"
            rejectColumn.HeaderText = "Reject"
            rejectColumn.Text = "Reject"
            rejectColumn.UseColumnTextForButtonValue = True
            Guna2DataGridView1.Columns.Add(rejectColumn)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        Dim addNewEventFormInstance As New AddEventsForm()
        addNewEventFormInstance.ParentFormInstance = Me
        addNewEventFormInstance.Show()
    End Sub

    Private Sub DataGridViewEvents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewEvents.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = DataGridViewEvents.Rows(e.RowIndex)

                If DataGridViewEvents.Columns(e.ColumnIndex).Name = "Edit" Then
                    Dim addNewEventFormInstance As New AddEventsForm() With {
                        .ParentFormInstance = Me,
                        .IsEditMode = True,
                        .EventID = Convert.ToInt32(selectedRow.Cells("eventid").Value),
                        .EventName = selectedRow.Cells("eventname").Value.ToString(),
                        .Venue = selectedRow.Cells("venue").Value.ToString(),
                        .EventStartDate = DateTime.Parse(selectedRow.Cells("eventStart_date").Value.ToString()),
                        .EventEndDate = DateTime.Parse(selectedRow.Cells("eventEnd_date").Value.ToString()),
                        .Department = selectedRow.Cells("department").Value.ToString(),
                        .StartTime = DateTime.Parse(selectedRow.Cells("starttime").Value.ToString()),
                        .EndTime = DateTime.Parse(selectedRow.Cells("endtime").Value.ToString())
                    }
                    addNewEventFormInstance.Show()
                    LoadEventsData()

                ElseIf DataGridViewEvents.Columns(e.ColumnIndex).Name = "Delete" Then
                    Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this event?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                    If result = DialogResult.Yes Then
                        Try
                            Dim eventid As Integer = Convert.ToInt32(selectedRow.Cells("eventid").Value)

                            If conn IsNot Nothing AndAlso conn.State <> ConnectionState.Open Then
                                conn.Open()
                            End If

                            Dim sqlDelete As String = "DELETE FROM events WHERE eventid = @eventid"
                            Using cmd As New MySqlCommand(sqlDelete, conn)
                                cmd.Parameters.AddWithValue("@eventid", eventid)
                                cmd.ExecuteNonQuery()
                            End Using

                            MessageBox.Show("Event deleted successfully.")
                            LoadEventsData()
                        Catch ex As MySqlException
                            MessageBox.Show("MySQL Error: " & ex.Message)
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.Message)
                        Finally
                            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                                conn.Close()
                            End If
                        End Try
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewPendingEvents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)

                If Guna2DataGridView1.Columns(e.ColumnIndex).Name = "Accept" Then
                    Dim eventID As Integer = Convert.ToInt32(selectedRow.Cells("eventid").Value)
                    AcceptEvent(eventID)
                    LoadPendingEvents()

                ElseIf Guna2DataGridView1.Columns(e.ColumnIndex).Name = "Reject" Then
                    Dim eventID As Integer = Convert.ToInt32(selectedRow.Cells("eventid").Value)
                    RejectEvent(eventID)
                    LoadPendingEvents()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub AcceptEvent(eventID As Integer)
        Try
            If conn IsNot Nothing AndAlso conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            Dim sqlUpdate As String = "UPDATE events SET status = 'Accepted' WHERE eventid = @eventid"
            Using cmd As New MySqlCommand(sqlUpdate, conn)
                cmd.Parameters.AddWithValue("@eventid", eventID)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Event accepted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub RejectEvent(eventID As Integer)
        Try
            If conn IsNot Nothing AndAlso conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            Dim sqlUpdate As String = "UPDATE events SET status = 'Rejected' WHERE eventid = @eventid"
            Using cmd As New MySqlCommand(sqlUpdate, conn)
                cmd.Parameters.AddWithValue("@eventid", eventID)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Event rejected successfully.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSearchEvent_Click(sender As Object, e As EventArgs) Handles btnSearchEvent.Click
        Dim startDate As DateTime = dtpStartDate.Value
        Dim endDate As DateTime = dtpEndDate.Value
        Dim startTime As TimeSpan = dtpStartTime.Value.TimeOfDay
        Dim endTime As TimeSpan = dtpEndTime.Value.TimeOfDay
        Dim searchText As String = btnSearchEvent.Text.Trim().ToLower()

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Dim dataView As New DataView(dt)

            Dim filterString As String = String.Format("eventname LIKE '%{0}%' OR " &
                                                       "venue LIKE '%{0}%' OR " &
                                                       "department LIKE '%{0}%'", searchText)

            filterString &= String.Format(" AND eventStart_date >= #{0}# AND eventEnd_date <= #{1}#", startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"))
            filterString &= String.Format(" AND starttime >= #{0}# AND endtime <= #{1}#", startTime.ToString(), endTime.ToString())

            dataView.RowFilter = filterString
            DataGridViewEvents.DataSource = dataView

            If dataView.Count = 0 Then
                MessageBox.Show("No data found matching your search criteria.")
            End If
        Else
            MessageBox.Show("No data available to search.")
        End If
    End Sub

End Class
