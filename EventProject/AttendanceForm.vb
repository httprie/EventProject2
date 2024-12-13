Imports MySql.Data.MySqlClient
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports System.Collections.Generic

Public Class AttendanceForm
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim dt As New DataTable
    Dim sqlQuery As String
    Dim eventID As Integer

    Public Class EventData
        Public Property ID As Integer
        Public Property Name As String

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Private videoSource As VideoCaptureDevice
    Private webcamRunning As Boolean = False
    Private qrReader As New ZXing.BarcodeReader()
    Private processedStudentIDs As New Dictionary(Of String, Integer)()
    Private lastScanTime As New Dictionary(Of String, DateTime)
    Private cooldownTimer As New Timer With {.Interval = 2000}
    Private cooldownInterval As Integer = 5000 ' 5 seconds

    Private attendanceStatus As New Dictionary(Of String, String)

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        pbwebcam.SizeMode = PictureBoxSizeMode.StretchImage
        StartWebcam()
        LoadEventsForToday()

        AddHandler cooldownTimer.Tick, AddressOf ClearCooldownStatus
    End Sub

    Private Sub LoadEventsForToday()
        Try
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")

            sqlQuery = "SELECT eventid, eventname FROM events WHERE eventStart_date <= @currentDate AND eventEnd_date >= @currentDate"
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@currentDate", currentDate)

            conn.Open()

            dr = cmd.ExecuteReader()

            cbevent.Items.Clear()

            Dim eventList As New List(Of EventData)()

            If dr.HasRows Then
                While dr.Read()
                    eventList.Add(New EventData With {.ID = dr("eventid"), .Name = dr("eventname")})
                End While

                cbevent.DataSource = eventList
                cbevent.DisplayMember = "Name"
                cbevent.ValueMember = "ID"
            Else
                MessageBox.Show("No events found for today.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dr.Close()
            conn.Close()
        End Try
    End Sub

    Private Sub DisplayAttendanceLogs()
        Try
            conn.Open()

            ' Query to fetch the attendance logs for the event
            sqlQuery = "SELECT studno, FirstName,  LastName, department, course, year, Sec, timein_time, timeout_time FROM attendancelog WHERE eventid = @eventid"
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@eventid", eventID)  ' Pass eventID as needed

            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)

            ' Bind the DataTable to the DataGridView
            AttendanceData.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ClearCooldownStatus(sender As Object, e As EventArgs)
        attendanceStatus.Clear()
        cooldownTimer.Stop()
    End Sub

    Private Sub StartWebcam()
        Dim videoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)

        If videoDevices.Count > 0 Then
            videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)
            AddHandler videoSource.NewFrame, AddressOf VideoSource_NewFrame
            videoSource.Start()
            webcamRunning = True
        Else
            MessageBox.Show("No webcam found.")
        End If
    End Sub

    Private Sub StopWebcam()
        If webcamRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
            webcamRunning = False
            pbwebcam.Image = Nothing
        End If
    End Sub

    Private Sub ClearProcessedIDs()
        processedStudentIDs.Clear()
    End Sub

    Private Sub VideoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        pbwebcam.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)

        ' Debug to show when the frame is captured
        Dim timestamp As String = DateTime.Now.ToString("HH:mm:ss.fff")
        Debug.WriteLine("Frame Captured: " & timestamp)

        ' Try to decode QR code from the current frame
        Dim result = qrReader.Decode(eventArgs.Frame)
        If result IsNot Nothing Then
            MessageBox.Show("QR Code Detected: " & result.Text) ' Debug message

            ' Your existing logic to process the QR code
            Dim dataParts As String() = result.Text.Split(","c)
            If dataParts.Length >= 4 Then
                Dim studentID As String = dataParts(0)
                Dim firstname As String = dataParts(1)
                Dim middlename As String = dataParts(2)
                Dim lastname As String = dataParts(3)
                Dim messenger As String = dataParts(4)
                Dim contactno As String = dataParts(5)
                Dim department As String = dataParts(6)
                Dim course As String = dataParts(7)
                Dim year As String = dataParts(8)
                Dim section As String = dataParts(9)
                Dim email As String = dataParts(10)
                Dim currentDate As String = DateTime.Now.ToShortDateString()
                Dim currentTime As String = DateTime.Now.ToShortTimeString()

                If IsEventEnded(eventID) Then
                    MessageBox.Show("This event has already ended. No further attendance is allowed.")
                    Return
                End If

                If lastScanTime.ContainsKey(studentID) AndAlso
               (DateTime.Now - lastScanTime(studentID)).TotalMilliseconds < cooldownInterval Then
                    MessageBox.Show("Cooldown: Waiting before scanning again.")
                    Return
                End If

                lastScanTime(studentID) = DateTime.Now

                If Not attendanceStatus.ContainsKey(studentID) OrElse attendanceStatus(studentID) = "out" Then
                    Me.Invoke(Sub()
                                  Dim row As String() = New String() {studentID, firstname, middlename, lastname, messenger, contactno, department, course, year, section, email, currentDate, currentTime}
                                  Dim rowIndex As Integer = AttendanceData.Rows.Add(row)
                                  processedStudentIDs(studentID) = rowIndex
                                  attendanceStatus(studentID) = "in"
                                  'SaveAttendanceLog(studentID, firstname, lastname, messenger, contactno, department, course, year, section, email, currentDate, currentTime, "time_in")

                              End Sub)
                ElseIf attendanceStatus(studentID) = "in" Then
                    Dim rowIndex As Integer = processedStudentIDs(studentID)
                    Me.Invoke(Sub()
                                  AttendanceData.Rows(rowIndex).Cells(5).Value = currentTime
                              End Sub)
                    attendanceStatus(studentID) = "out"
                    'SaveAttendanceLog(studentID, firstname, lastname, messenger, contactno, department, course, year, section, email, currentDate, currentTime, "time_in")
                End If
            End If
        End If
    End Sub


    Private Sub SaveAttendanceLog(studentID As String, firstname As String, lastname As String, messenger As String, contactno As String, department As String, course As String, year As String, section As String, email As String, currentDate As String, currentTime As String, action As String)

        Try
            ' Open the connection
            conn.Open()

            ' Prepare the SQL query to insert the attendance log
            Dim query As String = "INSERT INTO attendancelog (studno, firstname, middlename, lastname, messenger, contactno, department, course, year, section, email, date, time, action) " &
                                  "VALUES (@studno, @firstname, @middlename, @lastname, @messenger, @contactno, @department, @course, @year, @section, @email, @currentDate, @currentTime, @action)"

            ' Create the command object
            Using command As New MySqlCommand(query, conn)
                ' Add the parameters to the command
                command.Parameters.AddWithValue("@studno", studentID)
                command.Parameters.AddWithValue("@firstname", firstname)
                command.Parameters.AddWithValue("@lastname", lastname)
                command.Parameters.AddWithValue("@messenger", messenger)
                command.Parameters.AddWithValue("@contactno", contactno)
                command.Parameters.AddWithValue("@department", department)
                command.Parameters.AddWithValue("@course", course)
                command.Parameters.AddWithValue("@year", year)
                command.Parameters.AddWithValue("@section", section)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@currentDate", currentDate)
                command.Parameters.AddWithValue("@currentTime", currentTime)
                command.Parameters.AddWithValue("@action", action) ' "time-in" or "time-out"

                ' Execute the query to insert the data
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' Handle any errors that might occur
            MessageBox.Show("Error saving attendance log: " & ex.Message)
        End Try
    End Sub

    Private Function IsEventEnded(eventID As Integer) As Boolean
        Try
            ' Query to get the event start and end dates for the selected event
            sqlQuery = "SELECT eventStart_date, eventEnd_date FROM events WHERE eventid = @eventid"
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@eventid", eventID)

            conn.Open()
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                Dim eventStartDate As DateTime = Convert.ToDateTime(dr("eventStart_date"))
                Dim eventEndDate As DateTime = Convert.ToDateTime(dr("eventEnd_date"))

                ' Check if the event has ended
                If eventEndDate < DateTime.Now.Date OrElse (eventEndDate = DateTime.Now.Date AndAlso eventEndDate < DateTime.Now) Then
                    Return True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try

        Return False
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim s As String
        s = Date.Now.ToString()
        timedate.Text = s
    End Sub

    Private Sub AttendanceForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Not Me.Visible Then
            StopWebcam()
        End If
    End Sub

    Private Sub cbevent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbevent.SelectedIndexChanged
        If cbevent.SelectedItem IsNot Nothing Then
            Dim selectedEvent As EventData = CType(cbevent.SelectedItem, EventData)
            Dim selectedEventID As Integer = selectedEvent.ID
            ' You can now use selectedEventID for further processing
        End If
    End Sub

End Class
