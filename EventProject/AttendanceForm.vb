Imports MySql.Data.MySqlClient
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports System.Collections.Generic

Public Class AttendanceForm
    ' Class-level variables
    Private cmd As MySqlCommand
    Private dr As MySqlDataReader
    Private sqlQuery As String
    Private eventID As Integer

    ' Database connection
    Dim connectionString As String = "Server=localhost;Database=EventRegistrationSystem;Uid=root;Pwd=admin;"
    Dim conn As New MySqlConnection(connectionString)

    ' Webcam variables
    Private videoSource As VideoCaptureDevice
    Private webcamRunning As Boolean = False
    Private qrReader As New ZXing.BarcodeReader()

    ' Attendance Tracking
    Private attendanceStatus As New Dictionary(Of String, String) ' "in" or "out"

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        pbwebcam.SizeMode = PictureBoxSizeMode.StretchImage
        StartWebcam()
        LoadEventsForToday()
    End Sub

    ' Load Events Happening Today
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

    ' Stop Webcam
    Private Sub StopWebcam()
        If webcamRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
            webcamRunning = False
            pbwebcam.Image = Nothing
        End If
    End Sub

    ' Process Webcam Frame for QR Code
    Private Sub VideoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        pbwebcam.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)

        ' Try to decode QR code from the frame
        Dim result = qrReader.Decode(eventArgs.Frame)
        If result IsNot Nothing Then
            Dim qrData As String = result.Text.Trim()
            ProcessQRCode(qrData)
        End If
    End Sub

    ' Process QR Code Data
    Private Sub ProcessQRCode(qrData As String)
        Dim studentInfo() As String = qrData.Split(","c)

        ' Ensure the QR code has the correct number of parts
        If studentInfo.Length >= 12 Then
            Dim studentID As String = studentInfo(8)
            If cbevent.SelectedItem Is Nothing Then
                MessageBox.Show("Please select an event first.")
                Return
            End If

            Dim selectedEvent As EventData = CType(cbevent.SelectedItem, EventData)
            eventID = selectedEvent.ID

            ' Handle attendance status
            If Not attendanceStatus.ContainsKey(studentID) OrElse attendanceStatus(studentID) = "out" Then
                attendanceStatus(studentID) = "in"
                AddStudentToDataGridView(studentInfo)
                SaveTimeInAttendance(studentID)
            ElseIf attendanceStatus(studentID) = "in" Then
                attendanceStatus(studentID) = "out"
                UpdateTimeOutInDataGridView(studentID)
                SaveTimeOutAttendance(studentID)
            End If
        Else
            MessageBox.Show("Invalid QR code format. Please ensure it contains all student details.")
        End If
    End Sub

    ' Add Student Details to DataGridView
    Private Sub AddStudentToDataGridView(studentInfo() As String)
        For Each row As DataGridViewRow In AttendanceData.Rows
            If row.Cells("AttendeeID").Value.ToString() = studentInfo(8) Then Return
        Next

        AttendanceData.Rows.Add(studentInfo(8), studentInfo(0), studentInfo(2), studentInfo(3), studentInfo(4), studentInfo(5),
                                studentInfo(6), studentInfo(7), DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH:mm:ss"), Nothing)
    End Sub

    ' Update Time Out in DataGridView
    Private Sub UpdateTimeOutInDataGridView(studentID As String)
        For Each row As DataGridViewRow In AttendanceData.Rows
            If row.Cells("AttendeeID").Value.ToString() = studentID Then
                row.Cells("Time Out").Value = DateTime.Now.ToString("HH:mm:ss")
                Exit For
            End If
        Next
    End Sub

    ' Save Time In to Database
    Private Sub SaveTimeInAttendance(studentID As String)
        Try
            Dim query As String = "INSERT INTO attendancelog (StudNo, eventid, timein_time) VALUES (@StudNo, @eventid, @timein_time)"
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@StudNo", studentID)
                cmd.Parameters.AddWithValue("@eventid", eventID)
                cmd.Parameters.AddWithValue("@timein_time", DateTime.Now)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving time-in: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Save Time Out to Database
    Private Sub SaveTimeOutAttendance(studentID As String)
        Try
            Dim query As String = "UPDATE attendancelog SET timeout_time = @timeout_time WHERE StudNo = @StudNo AND eventid = @eventid AND timeout_time IS NULL"
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                cmd.Parameters.AddWithValue("@StudNo", studentID)
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

    ' Update Clock Timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timedate.Text = DateTime.Now.ToString()
    End Sub

    ' Stop Webcam When Form Hidden
    Private Sub AttendanceForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Not Me.Visible Then StopWebcam()
    End Sub

    Private Sub cbevent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbevent.SelectedIndexChanged
        If cbevent.SelectedItem IsNot Nothing Then
            eventID = CType(cbevent.SelectedItem, EventData).ID
        End If
    End Sub
End Class

' EventData class for ComboBox
Public Class EventData
    Public Property ID As Integer
    Public Property Name As String
    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
