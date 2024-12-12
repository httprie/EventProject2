﻿Imports MySql.Data.MySqlClient
Public Class HeadReports
    Dim sqlQuery As String
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Private Sub HeadReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        LoadStudentIDs()
        LoadEventNames()
    End Sub

    Private Sub LoadStudentIDs()
        sqlQuery = "SELECT StudentID FROM StudentInformation"
        cmd = New MySqlCommand(sqlQuery, conn)
        da = New MySqlDataAdapter(cmd)
        dt = New DataTable()

        If conn.State = ConnectionState.Closed Then
            Try
                conn.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return
            End Try
        End If

        Try
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Error filling data: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub LoadEventNames()
        sqlQuery = "SELECT DISTINCT eventname FROM events"
        cmd = New MySqlCommand(sqlQuery, conn)
        da = New MySqlDataAdapter(cmd)
        dt = New DataTable()

        conn.Open()
        da.Fill(dt)
        conn.Close()
    End Sub
    Private Sub LoadStudentInformation()
        sqlQuery = "SELECT * FROM StudentInformation"
        cmd = New MySqlCommand(sqlQuery, conn)
        da = New MySqlDataAdapter(cmd)
        dt = New DataTable()

        Try
            conn.Open()
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

        ReportData.DataSource = dt
        ReportData.ColumnHeadersHeight = 30
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim timer As String
        timer = Date.Now.ToString()
        timedate.Text = timer
    End Sub


    Private Sub LoadStudentActivity()
        ' Get the selected StudentID

        sqlQuery = "
    SELECT 
    s.FullName,
    events.eventname,
    a.timein_time,
    a.timeout_time,
    CASE
        WHEN a.timein_time IS NOT NULL AND a.timeout_time IS NOT NULL THEN 'Complete'
        WHEN a.timein_time IS NOT NULL AND a.timeout_time IS NULL THEN 'Not Complete'
        WHEN a.timein_time IS NOT NULL AND a.timeout_time IS NULL AND a.timein_time > NOW() THEN 'Ongoing'
        ELSE 'No Data'
    END AS status
FROM 
    attendancelog a
JOIN 
    StudentInformation s ON a.studno = s.studentid
JOIN 
    events ON a.eventid = events.eventid
WHERE 
    s.studentid = @StudentId"

        cmd = New MySqlCommand(sqlQuery, conn)
        da = New MySqlDataAdapter(cmd)
        dt = New DataTable()

        Try
            conn.Open()
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

        ' Check if DataTable has columns and data
        If dt.Columns.Count > 0 Then
            ' Display the data in DataGridView
            ReportData.DataSource = dt
            ReportData.ColumnHeadersHeight = 30

            ' Set custom column headers
            ReportData.Columns(0).HeaderText = "Full Name"
            ReportData.Columns(1).HeaderText = "Event Name"
            ReportData.Columns(2).HeaderText = "Time In"
            ReportData.Columns(3).HeaderText = "Time Out"
            ReportData.Columns(4).HeaderText = "Status"

            ' Optional: Adjust column widths if needed
            ReportData.AutoResizeColumns()
        Else
            MessageBox.Show("No data found for the selected student.")
        End If
    End Sub

    Private Sub LoadEventAttendees()

        sqlQuery = "
                    SELECT 
                        a.FullName,
                        e.eventname,
                        a.timein_time,
                        a.timeout_time,
                        e.created_by,  
                        CASE
                            WHEN a.timein_time IS NOT NULL AND a.timeout_time IS NOT NULL THEN 'Complete'
                            WHEN a.timein_time IS NOT NULL AND a.timeout_time IS NULL THEN 'Not Complete'
                            WHEN a.timein_time IS NOT NULL AND a.timeout_time IS NULL AND a.timeout_time > NOW() THEN 'Ongoing'
                            ELSE 'No Data'
                        END AS status
                    FROM 
                        attendancelog a
                    JOIN 
                        events e ON a.eventid = e.eventid
                    WHERE 
                        e.eventname = @EventName"


        cmd = New MySqlCommand(sqlQuery, conn)

        da = New MySqlDataAdapter(cmd)
        dt = New DataTable()

        Try
            conn.Open()
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

        ReportData.DataSource = dt
        ReportData.ColumnHeadersHeight = 30

        ReportData.Columns(0).HeaderText = "Full Name"
        ReportData.Columns(1).HeaderText = "Event Name"
        ReportData.Columns(2).HeaderText = "Time In"
        ReportData.Columns(3).HeaderText = "Time Out"
        ReportData.Columns(4).HeaderText = "Created By" '
        ReportData.Columns(5).HeaderText = "Status"



        ReportData.AutoResizeColumns()
    End Sub

    Private Sub LoadAllActivity()
        sqlQuery = "
            SELECT 
            StudentInformation.FullName, 
            StudentInformation.course, 
            StudentInformation.yearandsection, 
            events.eventname, 
            events.eventdate, 
            attendancelog.timein_time , 
            attendancelog.timeout_time,
            CASE
                WHEN attendancelog.timein_time IS NOT NULL AND attendancelog.timeout_time IS NOT NULL THEN 'Complete'
                WHEN attendancelog.timein_time IS NOT NULL AND attendancelog.timeout_time IS NULL THEN 'Not Complete'
                WHEN attendancelog.timein_time IS NOT NULL AND attendancelog.timeout_time IS NULL AND attendancelog.timein_time > NOW() THEN 'Ongoing'
                ELSE 'No Data'
            END AS status
        FROM 
            attendancelog
        JOIN 
            StudentInformation ON attendancelog.studno = StudentInformation.studentid
        JOIN 
            events ON attendancelog.eventid = events.eventid"

        cmd = New MySqlCommand(sqlQuery, conn)
        da = New MySqlDataAdapter(cmd)
        dt = New DataTable()

        Try
            conn.Open()
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

        If dt.Columns.Count > 0 Then
            ReportData.DataSource = dt
            ReportData.ColumnHeadersHeight = 30

            ReportData.Columns(0).HeaderText = "Full Name"
            ReportData.Columns(1).HeaderText = "Course"
            ReportData.Columns(2).HeaderText = "Year & Section"
            ReportData.Columns(3).HeaderText = "Event Name"
            ReportData.Columns(4).HeaderText = "Date"
            ReportData.Columns(5).HeaderText = "Time In"
            ReportData.Columns(6).HeaderText = "Time Out"
            ReportData.Columns(7).HeaderText = "Status"

            ReportData.AutoResizeColumns()
        Else
            MessageBox.Show("No data found for the selected student.")
        End If
    End Sub
End Class
