Imports MySql.Data.MySqlClient
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports System.Collections.Generic

Public Class AttendanceForm
    Private cmd As MySqlCommand
    Private dr As MySqlDataReader
    Private sqlQuery As String
    Private eventID As Integer

    Private lastScanTime As DateTime = DateTime.MinValue
    Private cooldownPeriod As TimeSpan = TimeSpan.FromSeconds(2)

    Dim connectionString As String = "Server=localhost;Database=EventRegistrationSystem;Uid=root;Pwd=admin;"
    Dim conn As New MySqlConnection(connectionString)

    Private videoSource As VideoCaptureDevice
    Private webcamRunning As Boolean = False
    Private qrReader As New ZXing.BarcodeReader()

    Private attendanceStatus As New Dictionary(Of String, String) ' "in" or "out"

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        pbwebcam.SizeMode = PictureBoxSizeMode.StretchImage
        StartWebcam()
        LoadEventsForToday()
    End Sub

    Private Sub LoadEventsForToday()
        Try
            Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")
            sqlQuery = "SELECT eventid, eventname FROM events WHERE eventStart_date <= @currentDate AND eventEnd_date >= @currentDate"

            Using cmd = New MySqlCommand(sqlQuery, conn)
                cmd.Parameters.AddWithValue("@currentDate", currentDate)

                conn.Open()
                dr = cmd.ExecuteReader()

                cbevent.Items.Clear()
                Dim eventList As New List(Of EventData)()
                While dr.Read()
                    eventList.Add(New EventData With {.ID = dr("eventid"), .Name = dr("eventname")})
                End While
                cbevent.DataSource = eventList
                cbevent.DisplayMember = "Name"
                cbevent.ValueMember = "ID"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading events: " & ex.Message)
        Finally
            dr?.Close()
            conn.Close()
        End Try
    End Sub

    ' Start Webcam
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

    Private Sub VideoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        pbwebcam.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)

        Dim result = qrReader.Decode(eventArgs.Frame)
        If result IsNot Nothing Then
            Dim qrData As String = result.Text.Trim()
            ProcessQRCode(qrData)
        End If
    End Sub
    Private Sub ProcessQRCode(qrData As String)
        If DateTime.Now - lastScanTime < cooldownPeriod Then
            Return
        End If

        lastScanTime = DateTime.Now

        Dim studentInfo() As String = qrData.Split(","c)

        If studentInfo.Length >= 11 Then
            Dim studentID As String = studentInfo(8)

            If cbevent.InvokeRequired Then
                cbevent.Invoke(Sub()
                                   If cbevent.SelectedItem Is Nothing Then
                                       MessageBox.Show("Please select an event first.")
                                       Return
                                   End If

                                   Dim selectedEvent As EventData = CType(cbevent.SelectedItem, EventData)
                                   eventID = selectedEvent.ID

                                   ' Handle attendance status
                                   If Not attendanceStatus.ContainsKey(studentID) Then
                                       ' If not yet checked in, mark as in
                                       attendanceStatus(studentID) = "in"
                                       AddStudentToDataGridView(studentInfo)
                                       SaveTimeInAttendance(studentInfo)
                                   ElseIf attendanceStatus(studentID) = "in" Then
                                       ' If student is checked in, process the timeout
                                       attendanceStatus(studentID) = "out"
                                       UpdateTimeOutInDataGridView(studentID)
                                       SaveTimeOutAttendance(studentID)
                                   ElseIf attendanceStatus(studentID) = "out" Then
                                       ' If student is already checked out, don't allow checking in again
                                       MessageBox.Show("This student has already checked out.")
                                   End If
                               End Sub)
            Else
                If cbevent.SelectedItem Is Nothing Then
                    MessageBox.Show("Please select an event first.")
                    Return
                End If

                Dim selectedEvent As EventData = CType(cbevent.SelectedItem, EventData)
                eventID = selectedEvent.ID

                If Not attendanceStatus.ContainsKey(studentID) Then
                    attendanceStatus(studentID) = "in"
                    AddStudentToDataGridView(studentInfo)
                    SaveTimeInAttendance(studentInfo)
                ElseIf attendanceStatus(studentID) = "in" Then
                    attendanceStatus(studentID) = "out"
                    UpdateTimeOutInDataGridView(studentID)
                    SaveTimeOutAttendance(studentID)
                ElseIf attendanceStatus(studentID) = "out" Then
                    MessageBox.Show("This student has already checked out.")
                End If
            End If
        Else
            MessageBox.Show("Invalid QR code format. Please ensure it contains all student details.")
        End If
    End Sub

    Private attendeeCounter As Integer = 1

    Private Sub AddStudentToDataGridView(studentInfo() As String)
        For Each row As DataGridViewRow In AttendanceData.Rows
            If row.Cells(1).Value IsNot Nothing Then
                If row.Cells(1).Value.ToString() = studentInfo(8) Then
                    MessageBox.Show("This student has already checked in.")
                    Return
                End If
            End If
        Next
        AttendanceData.Rows.Add(attendeeCounter, studentInfo(8), studentInfo(0), studentInfo(2), studentInfo(4), studentInfo(5),
                            studentInfo(6), studentInfo(7), DateTime.Now.ToString("yyyy-MM-dd"),
                            DateTime.Now.ToString("HH:mm:ss"), Nothing)

        attendeeCounter += 1
    End Sub

    Private Sub UpdateTimeOutInDataGridView(studentID As String)
        For Each row As DataGridViewRow In AttendanceData.Rows
            If row.Cells(1) IsNot Nothing AndAlso row.Cells(1).Value IsNot Nothing Then
                If row.Cells(1).Value.ToString() = studentID Then
                    If row.Cells(10) IsNot Nothing Then
                        row.Cells(10).Value = DateTime.Now.ToString("HH:mm:ss")
                        Exit For
                    Else
                        MessageBox.Show("Time Out column not found.")
                        Exit For
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub SaveTimeInAttendance(studentInfo() As String)
        Try
            Dim query As String = "INSERT INTO attendancelog (eventid, eventname, eventdate, StudentID, First_Name, Last_Name, Department, Course, Year, Section, timein_time) " &
                              "VALUES (@eventid, @eventname, @eventdate, @StudentID, @First_Name, @Last_Name, @Department, @Course, @Year, @Section, @timein_time)"

            Using cmd As New MySqlCommand(query, conn)
                conn.Open()

                cmd.Parameters.AddWithValue("@eventid", eventID)
                cmd.Parameters.AddWithValue("@eventname", cbevent.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@eventdate", DateTime.Now.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@StudentID", studentInfo(8))
                cmd.Parameters.AddWithValue("@First_Name", studentInfo(0))
                cmd.Parameters.AddWithValue("@Last_Name", studentInfo(2))
                cmd.Parameters.AddWithValue("@Department", studentInfo(4))
                cmd.Parameters.AddWithValue("@Course", studentInfo(5))
                cmd.Parameters.AddWithValue("@Year", studentInfo(6))
                cmd.Parameters.AddWithValue("@Section", studentInfo(7))
                cmd.Parameters.AddWithValue("@timein_time", DateTime.Now)

                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving time-in: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub SaveTimeOutAttendance(studentID As String)
        Try
            Dim query As String = "UPDATE attendancelog SET timeout_time = @timeout_time WHERE StudentID = @StudentID AND eventid = @eventid AND timeout_time IS NULL"
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@StudentID", studentID)
                cmd.Parameters.AddWithValue("@eventid", eventID)
                cmd.Parameters.AddWithValue("@timeout_time", DateTime.Now)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving time-out: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timedate.Text = DateTime.Now.ToString()
    End Sub

    Private Sub AttendanceForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Not Me.Visible Then StopWebcam()
    End Sub

    Private Sub cbevent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbevent.SelectedIndexChanged
        If cbevent.SelectedItem IsNot Nothing Then
            eventID = CType(cbevent.SelectedItem, EventData).ID
        End If
    End Sub
End Class

Public Class EventData
    Public Property ID As Integer
    Public Property Name As String
    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
