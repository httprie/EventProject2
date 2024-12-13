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

    Private attendeeid As String
    Private department As String
    Private yr As Integer
    Private sc As Integer

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
    Private cooldownInterval As Integer = 5000 ' 

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

            sqlQuery = "SELECT eventid, eventname FROM events WHERE eventStart_Date = @currentDate"
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

            sqlQuery = "SELECT attendeeid, studno, First_Name, Last_Name, year, Section, eventname, eventdate, timein_time, timeout_time FROM attendancelog WHERE eventid = @eventid"
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@eventid", eventID)

            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)

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

    Private Sub SaveAttendanceLog(studno As String, first_name As String, Last_Name As String, department As String, course As String, year As String, Section As String,
                                  eventid As String, eventname As String, eventdate As String, timein As String, timeout As String)

        conn.Open()

        ' Check if the student has already timed in but not timed out
        sqlQuery = "SELECT * FROM attendancelog WHERE studno = @studno AND eventid = @eventid AND timein_time IS NOT NULL AND timeout_time IS NULL"
        cmd = New MySqlCommand(sqlQuery, conn)
        cmd.Parameters.AddWithValue("@studno", studno)
        cmd.Parameters.AddWithValue("@eventid", eventid)

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            ' Update existing record with timeout
            dr.Close()
            sqlQuery = "UPDATE attendancelog SET timeout_time = @timeout_time WHERE studno = @studno AND eventid = @eventid AND timeout_time IS NULL"
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@timeout_time", timeout)
            cmd.Parameters.AddWithValue("@studno", studno)
            cmd.Parameters.AddWithValue("@eventid", eventid)
            cmd.ExecuteNonQuery()

        Else
            ' Insert a new record for time-in
            dr.Close()
            sqlQuery = "INSERT INTO attendancelog (studno, First_Name, Last_Name, department, course, year, Section, eventid, eventname, eventdate, timein_time) " &
                   "VALUES (@attendeeid, @studno, @First_Name, @Last_Name, @department, course, @year, @Section, @eventid, @eventname, @eventdate
, @timein_time)"
            cmd = New MySqlCommand(sqlQuery, conn)

            cmd.Parameters.AddWithValue("@studno", studno)
            cmd.Parameters.AddWithValue("@First_Name", first_name)
            cmd.Parameters.AddWithValue("@Last_Name", Last_Name)
            cmd.Parameters.AddWithValue("@department", department)
            cmd.Parameters.AddWithValue("@course", course)
            cmd.Parameters.AddWithValue("@year", year)
            cmd.Parameters.AddWithValue("@Sectiontion", Section)
            cmd.Parameters.AddWithValue("@eventid", eventid)
            cmd.Parameters.AddWithValue("@eventname", eventname)
            cmd.Parameters.AddWithValue("@eventdate", eventdate.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@timein_time", timein)
            cmd.ExecuteNonQuery()
        End If


        Try
            ' SQL query to insert attendance log
            sqlQuery = "INSERT INTO attendancelog (studno, First_name, Last_Name, department, course, year, Section, eventid, eventname, eventdate, timein_time) " &
                       "VALUES (@studno, @First_Name, @Last_Name, @department, @course, @year, @Section, @eventid, @eventname, @eventdate, @timein_time)"

            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@studno", studno)
            cmd.Parameters.AddWithValue("@First_Name", first_name)
            cmd.Parameters.AddWithValue("@Last_Name", Last_Name)
            cmd.Parameters.AddWithValue("@department", department)
            cmd.Parameters.AddWithValue("@course", course)
            cmd.Parameters.AddWithValue("@year", year)
            cmd.Parameters.AddWithValue("@Section", Section)
            cmd.Parameters.AddWithValue("@eventid", eventid)
            cmd.Parameters.AddWithValue("@eventname", eventname)
            cmd.Parameters.AddWithValue("@eventdate", eventdate)
            cmd.Parameters.AddWithValue("@timein_time", timein)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Attendance successfully logged.")

        Catch ex As Exception
            MessageBox.Show("Error saving attendance: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub SaveAttendanceLog(attendeeid As String, studno As String, first_name As String, last_name As String, department As String, yr As Integer, sc As Integer, currentTime As DateTime)
        Try
            conn.Open()

            sqlQuery = "SELECT attendeeid FROM attendancelog WHERE studno = @studno AND eventid = @eventid AND timein_time IS NOT NULL AND timeout_time IS NULL"
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@studno", studno)
            cmd.Parameters.AddWithValue("@eventid", eventID)

            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Close()
                sqlQuery = "UPDATE attendancelog SET timeout_time = @timeout_time WHERE studno = @studno AND eventid = @eventid AND timeout_time IS NULL"
                cmd = New MySqlCommand(sqlQuery, conn)
                cmd.Parameters.AddWithValue("@timeout_time", currentTime)
                cmd.Parameters.AddWithValue("@studno", studno)
                cmd.Parameters.AddWithValue("@eventid", eventID)  ' Pass eventID as needed
                cmd.ExecuteNonQuery()

            Else
                ' Insert a new attendance record (time-in)
                dr.Close()
                sqlQuery = "INSERT INTO attendancelog (attendeeid, studno, first_name, last_name, department, yr, sc, eventid, eventname, date, timein_time) " &
                       "VALUES (@AttenddeeID, @First_Name, @Last_Name, @Department, @yr, @sc, @eventid, @eventname, @date, @timein_time)"
                cmd = New MySqlCommand(sqlQuery, conn)
                cmd.Parameters.AddWithValue("@AttenddeeID", attendeeid)
                cmd.Parameters.AddWithValue("@studno", studno)
                cmd.Parameters.AddWithValue("@First_Name", first_name)
                cmd.Parameters.AddWithValue("@Last_Name", last_name)
                cmd.Parameters.AddWithValue("@Department", department)
                cmd.Parameters.AddWithValue("@yr", yr)
                cmd.Parameters.AddWithValue("@sc", sc)
                cmd.Parameters.AddWithValue("@eventid", eventID)
                cmd.Parameters.AddWithValue("@eventname", cbevent.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@date", currentTime.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@timein_time", currentTime)
                cmd.ExecuteNonQuery()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Function GetEventEndTime(eventID As Integer) As DateTime
        Try
            sqlQuery = "SELECT endtime FROM events WHERE eventid = @eventid"
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@eventid", eventID)

            conn.Open()
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                ' Assuming eventendtime is of type datetime
                Return Convert.ToDateTime(dr("endtime"))
            Else
                Return DateTime.MinValue ' Return a default value if not found
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return DateTime.MinValue
        Finally
            conn.Close()
        End Try
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
        End If
    End Sub

    Private Sub VideoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        If pbwebcam.Image IsNot Nothing Then
            pbwebcam.Image.Dispose()
        End If
        pbwebcam.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)

        ' Process QR code from frame
        Try
            Dim result = qrReader.Decode(DirectCast(eventArgs.Frame.Clone(), Bitmap))
            If result IsNot Nothing Then
                ' Handle QR code result here
                ProcessQRCode(result.Text)
            End If
        Catch ex As Exception
            ' Handle any errors in QR processing
        End Try
    End Sub

    Private Sub SaveAttendanceLog(studno As String, First_Name As String, Last_Name As String, department As String, course As String, year As Integer, Section As String,
                              eventid As Integer, eventname As String, eventdate As Date, timein As DateTime)
        Try
            ' SQL query to insert attendance log
            sqlQuery = "INSERT INTO attendancelog (studno, First_Name, Last_Name, department, course, year, Section, eventid, eventname, eventdate, timein_time) " &
                   "VALUES (@studno, @First_Name, @Last_Name, @department, @course, @year, @Section, @eventid, @eventname, @eventdate, @timein_time)"

            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@studno", studno)
            cmd.Parameters.AddWithValue("@First_Name", First_Name)
            cmd.Parameters.AddWithValue("@Last_Name", Last_Name)
            cmd.Parameters.AddWithValue("@department", department)
            cmd.Parameters.AddWithValue("@course", course)
            cmd.Parameters.AddWithValue("@year", year)
            cmd.Parameters.AddWithValue("@Section", Section)
            cmd.Parameters.AddWithValue("@eventid", eventid)
            cmd.Parameters.AddWithValue("@eventname", eventname)
            cmd.Parameters.AddWithValue("@eventdate", eventdate)
            cmd.Parameters.AddWithValue("@timein_time", timein)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Attendance successfully logged.")

        Catch ex As Exception
            MessageBox.Show("Error saving attendance: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub ProcessQRCode(qrData As String)
        Try
            conn.Open()

            ' Query to get student details
            sqlQuery = "SELECT First_Name, Last_Name, department, course, year, Section FROM StudentInformation WHERE studno = @studno"
            cmd = New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@studno", qrData)

            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                Dim First_Name As String = dr("First_Name").ToString()
                Dim Last_Name As String = dr("Last_Name").ToString()
                Dim department As String = dr("department").ToString()
                Dim course As String = dr("course").ToString()
                Dim year As Integer = Convert.ToInt32(dr("year"))
                Dim Section As String = dr("Section").ToString()

                dr.Close()

                ' Retrieve event details
                Dim selectedEvent As EventData = CType(cbevent.SelectedItem, EventData)

                If selectedEvent IsNot Nothing Then
                    Dim eventID As Integer = selectedEvent.ID
                    Dim eventName As String = selectedEvent.Name
                    Dim eventDate As Date = DateTime.Now.Date

                    ' Save attendance log
                    SaveAttendanceLog(qrData, First_Name, Last_Name, department, course, year, Section, eventID, eventName, eventDate, DateTime.Now)
                Else
                    MessageBox.Show("Please select an event before scanning QR codes.")
                End If
            Else
                MessageBox.Show("Student record not found.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error processing QR code: " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            conn.Close()
        End Try
    End Sub


    Private Sub pbwebcam_Click(sender As Object, e As EventArgs) Handles pbwebcam.Click

    End Sub
End Class