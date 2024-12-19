Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class AdminDashboard
    Inherits Form

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                        ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr
    End Function

    ' Define the MySQL connection
    Private conn As New MySqlConnection("server=localhost;userid=root;password=admin;database=EventRegistrationSystem")
    Private dt As New DataTable()
    Private da As New MySqlDataAdapter()

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        LoadEventsData() ' Load data into the DataGridView
        PopulateEventCounts() ' Update the event counts
        PopulateUpcomingEventsTable() ' Populate the upcoming events table

        ' Apply rounded corners to the panels
        Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, Width, Height, 20, 20))
        pnlCurrEveDay.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnlCurrEveDay.Width, pnlCurrEveDay.Height, 40, 40))
        pnlupcoming.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnlupcoming.Width, pnlupcoming.Height, 40, 40))
        pnlPendingReq.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnlPendingReq.Width, pnlPendingReq.Height, 40, 40))
        pnlUpEvtbl.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnlUpEvtbl.Width, pnlUpEvtbl.Height, 40, 40))
        pnlCurrEvetbl.Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, pnlCurrEvetbl.Width, pnlCurrEvetbl.Height, 40, 40))
    End Sub

    ' Method to populate event counts
    Private Sub PopulateEventCounts()
        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim sqlCurrEve As String = "SELECT COUNT(*) FROM events WHERE eventStart_date = @currentDate"
        Dim sqlUpcoming As String = "SELECT COUNT(*) FROM events WHERE eventStart_date > @currentDate"
        Dim sqlPending As String = "SELECT COUNT(*) FROM events WHERE event_status = 'Pending'"

        Try
            conn.Open()

            ' Query for current events of the day
            Dim cmd As New MySqlCommand(sqlCurrEve, conn)
            cmd.Parameters.AddWithValue("@currentDate", currentDate)
            Dim currentEventCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Query for upcoming events
            cmd.CommandText = sqlUpcoming
            Dim upcomingEventCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Query for pending requests
            cmd.CommandText = sqlPending
            Dim pendingRequestCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Update the labels with the counts
            lblTotalEvent.Text = currentEventCount.ToString()
            lblUpcomingEvents.Text = upcomingEventCount.ToString()
            lbltotalPend.Text = pendingRequestCount.ToString()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close() ' Ensure the connection is always closed
        End Try
    End Sub

    ' Method to populate the DataGridView
    Public Sub LoadEventsData()
        Try
            ' Clear existing data
            tblCurrEve.Columns.Clear()
            dt = New DataTable()

            ' Define the query
            Dim sqlQuery As String = "SELECT eventname AS 'EventName', venue AS 'Venue', eventdepartment AS 'Dept', " &
                                      "eventStart_date AS 'startDate', eventEnd_date AS 'endDate', starttime AS 'StartTime', endtime AS 'EndTime', facilitator AS 'Facilitator' FROM events"

            ' Set up the data adapter
            da = New MySqlDataAdapter(sqlQuery, conn)

            ' Open connection and fill the DataTable
            conn.Open()
            da.Fill(dt)

            ' Bind the DataTable to the DataGridView
            tblCurrEve.DataSource = dt

            ' Automatically resize columns
            tblCurrEve.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Method to populate the upcoming events table (ID, Name)
    Private Sub PopulateUpcomingEventsTable()
        Try
            ' Define the query
            Dim sqlQuery As String = "SELECT eventid AS 'eveID', eventname AS 'eveName' FROM events WHERE eventStart_date > @currentDate"

            ' Clear existing data
            tblUpcomEve.Columns.Clear()
            dt = New DataTable()

            ' Set up the data adapter
            Dim cmd As New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@currentDate", DateTime.Now.ToString("yyyy-MM-dd"))

            ' Open connection and fill the DataTable
            da = New MySqlDataAdapter(cmd)
            conn.Open()
            da.Fill(dt)

            ' Bind the DataTable to the DataGridView
            tblUpcomEve.DataSource = dt

            ' Automatically resize columns
            tblUpcomEve.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("Error populating upcoming events: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Timer to update the date and time
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim timer As String = Date.Now.ToString()
        timedate.Text = timer
    End Sub

End Class
