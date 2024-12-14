Imports MySql.Data.MySqlClient

Public Class EventsForm
    Dim sqlQuery As String
    Dim da As MySqlDataAdapter
    Public dt As DataTable

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
            DataGridViewEvents.Columns.Clear()

            dt = New DataTable()
            sqlQuery = "SELECT * FROM events"
            da = New MySqlDataAdapter(sqlQuery, conn)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            da.Fill(dt)

            conn.Close()

            DataGridViewEvents.DataSource = dt

            ' Set column headers
            DataGridViewEvents.Columns("eventid").HeaderText = "Event ID"
            DataGridViewEvents.Columns("eventname").HeaderText = "Name"
            DataGridViewEvents.Columns("venue").HeaderText = "Venue"
            DataGridViewEvents.Columns("eventStart_date").HeaderText = "Start Date"
            DataGridViewEvents.Columns("eventEnd_date").HeaderText = "End Date"
            DataGridViewEvents.Columns("department").HeaderText = "Department"
            DataGridViewEvents.Columns("starttime").HeaderText = "Start Time"
            DataGridViewEvents.Columns("endtime").HeaderText = "End Time"

            ' Add Edit and Delete button columns
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

            ' Set AutoSize modes for the DataGridView
            DataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            DataGridViewEvents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub LoadEventFilters()
        ' Load column names into cbEventFilter
        cbEventFilter.Items.Clear()
        cbEventFilter.Items.AddRange(New String() {"eventname", "venue", "department", "facilitator", "contactPerson", "ConP_messenger", "ConP_contactNo"})
        cbEventFilter.SelectedIndex = -1
    End Sub

    Private Sub cbEventFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEventFilter.SelectedIndexChanged
        ' Populate cbxEvent based on the selected column in cbEventFilter
        If cbEventFilter.SelectedItem IsNot Nothing Then
            Dim selectedColumn As String = cbEventFilter.SelectedItem.ToString()
            PopulateCbxEvent(selectedColumn)
        End If
    End Sub

    Private Sub PopulateCbxEvent(columnName As String)
        Try
            Dim dtValues As New DataTable()
            sqlQuery = $"SELECT DISTINCT {columnName} FROM events WHERE {columnName} IS NOT NULL"
            da = New MySqlDataAdapter(sqlQuery, conn)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            da.Fill(dtValues)
            conn.Close()

            cbxEvent.Items.Clear()
            For Each row As DataRow In dtValues.Rows
                cbxEvent.Items.Add(row(columnName).ToString())
            Next

        Catch ex As Exception
            MessageBox.Show("Error populating cbxEvent: " & ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub cbxEvent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEvent.SelectedIndexChanged
        ' Filter DataGridView based on the selected value in cbxEvent
        If cbxEvent.SelectedItem IsNot Nothing AndAlso cbEventFilter.SelectedItem IsNot Nothing Then
            Dim selectedColumn As String = cbEventFilter.SelectedItem.ToString()
            Dim selectedValue As String = cbxEvent.SelectedItem.ToString()
            FilterDataGridView(selectedColumn, selectedValue)
        End If
    End Sub

    Private Sub FilterDataGridView(columnName As String, filterValue As String)
        Try
            Dim filteredDt As New DataTable()
            sqlQuery = $"SELECT * FROM events WHERE {columnName} = @filterValue"
            da = New MySqlDataAdapter(sqlQuery, conn)
            da.SelectCommand.Parameters.AddWithValue("@filterValue", filterValue)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            da.Fill(filteredDt)
            conn.Close()

            DataGridViewEvents.DataSource = filteredDt

        Catch ex As Exception
            MessageBox.Show("Error filtering DataGridView: " & ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        AddEventsForm.Show()
    End Sub
End Class
