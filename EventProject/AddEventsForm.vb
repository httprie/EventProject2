Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class AddEventsForm
    Inherits Form
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")> Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                        ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr
    End Function

    Dim cmd As New MySqlCommand
    Dim sqlQuery As String
    Dim da As MySqlDataAdapter

    Public Property ParentFormInstance As EventsForm
    Public Property IsEditMode As Boolean = False
    Public Property EventID As Integer
    Public Property EventStartDate As Date
    Public Property EventEndDate As Date
    Public EventIDtoEdit As Integer
    Public EventName As String
    Public Venue As String
    Public Department As String
    Public Facilitator As String
    Public StartTime As DateTime
    Public EndTime As DateTime
    Public ContactPerson As String
    Public ContactMessenger As String
    Public ContactNo As String

    Private Sub AddNewEventsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, Width, Height, 20, 20))

        ' Load departments into ComboBox
        LoadDepartments()

        If IsEditMode Then
            Label7.Text = "Edit Event"
            btnInsertEvent.Text = "Edit Event"
            dtpEventStart.Value = EventStartDate
            dtpEventEnd.Value = EventEndDate
            txtEventName.Text = EventName
            txtVenue.Text = Venue
            cbDepartmentEvent.Text = Department
            txtFacilitator.Text = Facilitator
            txtContactPerson.Text = ContactPerson
            txtContactMessenger.Text = ContactMessenger
            txtContact.Text = ContactNo
            dtpStartTime.Value = StartTime
            dtpEndTime.Value = EndTime
        Else
            Label7.Text = "Add New Event"
            btnInsertEvent.Text = "Add Event"
        End If
    End Sub

    Private Sub LoadDepartments()
        Try
            sqlQuery = "SELECT DepartmentName FROM Departments"
            cmd = New MySqlCommand(sqlQuery, conn)
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            cbDepartmentEvent.Items.Clear()

            While reader.Read()
                cbDepartmentEvent.Items.Add(reader("DepartmentName").ToString())
            End While
            reader.Close()
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnInsertEvent_Click(sender As Object, e As EventArgs) Handles btnInsertEvent.Click
        EventName = txtEventName.Text
        Venue = txtVenue.Text
        Facilitator = txtFacilitator.Text
        Department = cbDepartmentEvent.Text
        ContactPerson = txtContactPerson.Text
        ContactMessenger = txtContactMessenger.Text
        ContactNo = txtContact.Text
        EventStartDate = dtpEventStart.Value
        EventEndDate = dtpEventEnd.Value
        StartTime = dtpStartTime.Value
        EndTime = dtpEndTime.Value

        If IsEditMode Then
            ' Handle Edit Mode logic here (if any)
        Else
            Dim confirmAdd As DialogResult = MessageBox.Show("Do you want to add this event?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmAdd = DialogResult.Yes Then
                If String.IsNullOrWhiteSpace(EventName) OrElse String.IsNullOrWhiteSpace(Venue) OrElse String.IsNullOrWhiteSpace(Department) Then
                    MessageBox.Show("All fields are required. Please fill them out.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Try
                    conn.Open()

                    ' Insert the new event into the database with status "Pending"
                    sqlQuery = "INSERT INTO Events (eventname, venue, eventStart_date, eventEnd_date, starttime, endtime, department, facilitator, contactPerson, ConP_messenger, ConP_contactNo, event_Status) 
                            VALUES (@EventName, @Venue, @EventStartDate, @EventEndDate, @StartTime, @EndTime, @Department, @Facilitator, @ContactPerson, @ContactMessenger, @ContactNo, 'Pending')"
                    cmd = New MySqlCommand(sqlQuery, conn)
                    cmd.Parameters.AddWithValue("@EventName", EventName)
                    cmd.Parameters.AddWithValue("@Venue", Venue)
                    cmd.Parameters.AddWithValue("@EventStartDate", EventStartDate)  ' Correct column name
                    cmd.Parameters.AddWithValue("@EventEndDate", EventEndDate)  ' Correct column name
                    cmd.Parameters.AddWithValue("@Department", Department)
                    cmd.Parameters.AddWithValue("@Facilitator", Facilitator)
                    cmd.Parameters.AddWithValue("@StartTime", StartTime.TimeOfDay)
                    cmd.Parameters.AddWithValue("@EndTime", EndTime.TimeOfDay)
                    cmd.Parameters.AddWithValue("@ContactPerson", ContactPerson)
                    cmd.Parameters.AddWithValue("@ContactMessenger", ContactMessenger)
                    cmd.Parameters.AddWithValue("@ContactNo", ContactNo)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    conn.Close()

                    ' After insertion, reload the events in the parent form's DataGridView
                    If rowsAffected > 0 Then
                        ParentFormInstance.LoadEventsData()  ' Reload the events data in parent form
                    End If
                    Me.Close() ' Close the form after the event is added

                Catch ex As MySqlException
                    ' We no longer show an error message here
                Catch ex As Exception
                    ' We no longer show an error message here
                Finally
                    If conn.State = ConnectionState.Open Then conn.Close()
                End Try
            End If
        End If
    End Sub


    Private Sub ClearTextBoxes()
        txtEventName.Clear()
        txtVenue.Clear()
        cbDepartmentEvent.SelectedItem = Nothing
        txtFacilitator.Clear()
        txtContactPerson.Clear()
        txtContactMessenger.Clear()
        txtContact.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearTextBoxes()
    End Sub
End Class