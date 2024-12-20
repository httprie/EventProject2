﻿Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports MessagingToolkit.QRCode.Codec
Imports System.Net.Mail
Imports System.Net


Public Class GenerateQR

    ' Class-level variables
    Private firstname As String
    Private middlename As String
    Private lastname As String
    Private suffix As String
    Private messenger As String
    Private contactno As String
    Private department As String
    Private course As String
    Private year As String
    Private section As String
    Private studID As String
    Private email As String
    'for qr
    Private qrImage As Bitmap

    Private isEditMode As Boolean = False
    Private editingStudentID As String = ""


    ' Database connection
    Dim connectionString As String = "Server=localhost;Database=EventRegistrationSystem;Uid=root;Pwd=admin;"

    ' Method to add buttons to the DataGridView
    Private Sub AddButtonsToDataGridView()
        If StudentData.Columns.Contains("Edit") Then StudentData.Columns.Remove("Edit")
        If StudentData.Columns.Contains("Delete") Then StudentData.Columns.Remove("Delete")

        Dim editButton As New DataGridViewButtonColumn()
        editButton.HeaderText = "Edit"
        editButton.Name = "Edit"
        editButton.Text = "Edit"
        editButton.UseColumnTextForButtonValue = True
        StudentData.Columns.Add(editButton)

        Dim deleteButton As New DataGridViewButtonColumn()
        deleteButton.HeaderText = "Delete"
        deleteButton.Name = "Delete"
        deleteButton.Text = "Delete"
        deleteButton.UseColumnTextForButtonValue = True
        StudentData.Columns.Add(deleteButton)
    End Sub

    ' Method to generate QR Code and save to the database
    Private Sub btngenerate_Click(sender As Object, e As EventArgs) Handles btngenerate.Click
        ' Get the input data
        GetInputData()

        ' Validate the fields
        If Not ValidateInput() Then Return

        If isEditMode Then
            ' Update existing record
            UpdateStudentRecord()
        Else
            ' Check for duplicates before adding
            If CheckForDuplicates() Then Return

            ' Generate the QR code
            Dim qrData As String = $"{firstname},{middlename},{lastname},{suffix},{department},{course},{year},{section},{studID},{email},{messenger},{contactno}"
            Dim gen As New QRCodeEncoder()
            gen.QRCodeScale = 6

            Try
                Dim qr As Bitmap = gen.Encode(qrData)
                If qr IsNot Nothing Then
                    QRCode.Image = qr
                    ' Save QR code and data to the database
                    SaveQRCodeToDatabase(firstname, middlename, lastname, suffix, department, course, year, section, studID, email, contactno, messenger, qr)
                    ' Send an email notification
                    sendEmail()
                    ' Reload the student information
                    LoadStudentInfo()

                    clearTextfield()
                Else
                    MessageBox.Show("Failed to generate QR Code.")
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}")
            End Try
        End If
    End Sub

    ' Update an existing student record in the database
    Private Sub UpdateStudentRecord()
        Try
            Dim sqlQuery As String = "UPDATE StudentInformation SET First_Name = @First_Name, Middle_Name = @Middle_Name, " &
                                 "Last_Name = @Last_Name, Suffix = @Suffix, Department = @Department, Course = @Course, " &
                                 "Year = @Year, Section = @Section, Email = @Email, ContactNo = @ContactNo, Messenger = @Messenger " &
                                 "WHERE StudentID = @StudentID"

            ' Regenerate the QR code with updated data
            Dim updatedQRData As String = $"{firstname},{middlename},{lastname},{suffix},{department},{course},{year},{section},{studID},{email},{messenger},{contactno}"
            Dim gen As New QRCodeEncoder()
            gen.QRCodeScale = 6

            Dim updatedQR As Bitmap = gen.Encode(updatedQRData)

            ' Convert the updated QR code image to a byte array for database storage
            Dim qrCodeData As Byte()
            Using ms As New MemoryStream()
                updatedQR.Save(ms, Imaging.ImageFormat.Png)
                qrCodeData = ms.ToArray()
            End Using

            ' Update the record in the database
            Dim cmd As New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@First_Name", firstname)
            cmd.Parameters.AddWithValue("@Middle_Name", middlename)
            cmd.Parameters.AddWithValue("@Last_Name", lastname)
            cmd.Parameters.AddWithValue("@Suffix", suffix)
            cmd.Parameters.AddWithValue("@Department", department)
            cmd.Parameters.AddWithValue("@Course", course)
            cmd.Parameters.AddWithValue("@Year", year)
            cmd.Parameters.AddWithValue("@Section", section)
            cmd.Parameters.AddWithValue("@Email", email)
            cmd.Parameters.AddWithValue("@ContactNo", contactno)
            cmd.Parameters.AddWithValue("@Messenger", messenger)
            cmd.Parameters.AddWithValue("@QRCodeData", qrCodeData)
            cmd.Parameters.AddWithValue("@StudentID", editingStudentID)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            ' Update the displayed QR code on the form
            QRCode.Image = updatedQR

            MessageBox.Show("Record updated successfully!")
            saveData()

            sendEmailUpdate()

            LoadStudentInfo()

            ' Exit edit mode
            clearTextfield()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Reset the form and exit edit mode
    Private Sub ResetForm()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtExtension.Clear()
        cbDepartment.SelectedIndex = -1
        cbCourse.SelectedIndex = -1
        cbYear.SelectedIndex = -1
        cbSection.SelectedIndex = -1
        txtStudID.Clear()
        txtEmail.Clear()
        txtContact.Clear()
        txtMessenger.Clear()
        btngenerate.Text = "Generate"
        isEditMode = False
        editingStudentID = ""
        QRCode.Image = Nothing
    End Sub

    ' Get input data and assign to class variables
    Private Sub GetInputData()
        firstname = txtFirstName.Text
        middlename = txtMiddleName.Text
        lastname = txtLastName.Text
        suffix = txtExtension.Text
        department = cbDepartment.Text
        course = cbCourse.Text
        year = cbYear.Text
        section = cbSection.Text
        studID = txtStudID.Text
        email = txtEmail.Text
        contactno = txtContact.Text
        messenger = txtMessenger.Text
    End Sub

    ' Validate input fields
    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(firstname) OrElse
           String.IsNullOrWhiteSpace(lastname) OrElse
           String.IsNullOrWhiteSpace(department) OrElse
           String.IsNullOrWhiteSpace(course) OrElse
           String.IsNullOrWhiteSpace(year) OrElse
           String.IsNullOrWhiteSpace(section) OrElse
           String.IsNullOrWhiteSpace(studID) Then
            MessageBox.Show("Please fill in all required fields.")
            Return False
        End If

        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.")
            Return False
        End If

        Return True
    End Function

    ' Check for duplicate records in the database
    Private Function CheckForDuplicates() As Boolean
        If RecordExists("StudentID", studID) OrElse
           RecordExists("ContactNo", contactno) OrElse
           RecordExists("Email", email) Then
            MessageBox.Show("Duplicate Student ID, Contact Number, or Email detected. Cannot generate QR code.")
            Return True
        End If
        Return False
    End Function

    Private Sub SaveQRCodeToDatabase(firstname As String, middlename As String, lastname As String,
                               suffix As String, department As String, course As String, year As String,
                               section As String, studID As String, email As String, contactno As String, messenger As String,
                               qrImage As Bitmap)
        Try
            Using ms As New MemoryStream()
                qrImage.Save(ms, Imaging.ImageFormat.Png)
                Dim qrCodeData As Byte() = ms.ToArray()

                ' Modified INSERT query to match exact database schema
                Dim sqlQuery As String = "INSERT INTO StudentInformation (" &
                                   "First_Name, Middle_Name, Last_Name, Suffix, " &
                                   "Department, Course, Year, Section, StudentID, " &
                                   "Email, ContactNo, Messenger, QRCodeData) " &
                                   "VALUES (" &
                                   "@First_Name, @Middle_Name, @Last_Name, @Suffix, " &
                                   "@Department, @Course, @Year, @Section, @StudentID, " &
                                   "@Email, @ContactNo, @Messenger, @QRCodeData)"

                Using cmd As New MySqlCommand(sqlQuery, conn)
                    ' Parameters with correct data types and lengths
                    cmd.Parameters.AddWithValue("@First_Name", If(firstname.Length > 20, firstname.Substring(0, 20), firstname))
                    cmd.Parameters.AddWithValue("@Middle_Name", If(String.IsNullOrEmpty(middlename), DBNull.Value, If(middlename.Length > 20, middlename.Substring(0, 20), middlename)))
                    cmd.Parameters.AddWithValue("@Last_Name", If(lastname.Length > 20, lastname.Substring(0, 20), lastname))
                    cmd.Parameters.AddWithValue("@Suffix", If(String.IsNullOrEmpty(suffix), DBNull.Value, If(suffix.Length > 20, suffix.Substring(0, 20), suffix)))
                    cmd.Parameters.AddWithValue("@Department", If(department.Length > 50, department.Substring(0, 50), department))
                    cmd.Parameters.AddWithValue("@Course", If(course.Length > 10, course.Substring(0, 10), course))
                    cmd.Parameters.AddWithValue("@Year", If(year.Length > 20, year.Substring(0, 20), year))
                    cmd.Parameters.AddWithValue("@Section", If(section.Length > 20, section.Substring(0, 20), section))
                    cmd.Parameters.AddWithValue("@StudentID", If(String.IsNullOrEmpty(studID), DBNull.Value, If(studID.Length > 50, studID.Substring(0, 50), studID)))
                    cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrEmpty(email), DBNull.Value, If(email.Length > 60, email.Substring(0, 60), email)))
                    cmd.Parameters.AddWithValue("@ContactNo", If(contactno.Length > 20, contactno.Substring(0, 20), contactno))
                    cmd.Parameters.AddWithValue("@Messenger", If(String.IsNullOrEmpty(messenger), DBNull.Value, If(messenger.Length > 50, messenger.Substring(0, 50), messenger)))
                    cmd.Parameters.AddWithValue("@QRCodeData", qrCodeData)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    ' Save the QR code image file
                    saveData()

                    ' Reload the student information grid
                    LoadStudentInfo()

                    MessageBox.Show("QR Code and student information saved successfully!")
                End Using
            End Using
        Catch ex As MySqlException When ex.Number = 1406
            MessageBox.Show("One or more fields exceed the maximum allowed length. Please check your input.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    ' Load student data into DataGridView
    Private Sub LoadStudentInfo()
        Try
            Dim sqlQuery As String = "Select StudNo, First_Name, Middle_Name, Last_Name, " &
                                     "Suffix, Department, Course, Year, Section, " &
                                     "StudentID, Email, ContactNo, Messenger FROM StudentInformation"

            Dim da As New MySqlDataAdapter(sqlQuery, conn)
            Dim dt As New DataTable()

            conn.Open()
            da.Fill(dt)
            conn.Close()

            StudentData.DataSource = Nothing
            StudentData.Columns.Clear()

            StudentData.DataSource = dt
            AddButtonsToDataGridView()

            ' Set custom column headers
            StudentData.Columns("First_Name").HeaderText = "First Name"
            StudentData.Columns("Middle_Name").HeaderText = "Middle Name"
            StudentData.Columns("Last_Name").HeaderText = "Last Name"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Check if a record already exists in the database
    Private Function RecordExists(columnName As String, value As String) As Boolean
        Dim exists As Boolean = False
        Try
            Dim sqlQuery As String = $"Select COUNT(*) FROM StudentInformation WHERE {columnName} = @{columnName}"
            Dim cmd As New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue($"@{columnName}", value)

            conn.Open()
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            exists = (count > 0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        Return exists
    End Function

    ' Validate email format using regular expression
    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
            Return Regex.IsMatch(email, emailPattern)
        Catch ex As Exception
            Return False
        End Try
    End Function

    ' Event for handling cell click (edit and delete buttons)
    Private Sub StudentData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentData.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim selectedRow As DataGridViewRow = StudentData.Rows(e.RowIndex)

        ' Edit button functionality
        If e.ColumnIndex = StudentData.Columns("Edit").Index Then
            ' Populate textboxes with selected row data
            txtFirstName.Text = selectedRow.Cells("First_Name").Value.ToString()
            txtMiddleName.Text = selectedRow.Cells("Middle_Name").Value.ToString()
            txtLastName.Text = selectedRow.Cells("Last_Name").Value.ToString()
            txtExtension.Text = selectedRow.Cells("Suffix").Value.ToString()
            cbDepartment.Text = selectedRow.Cells("Department").Value.ToString()
            cbCourse.Text = selectedRow.Cells("Course").Value.ToString()
            cbYear.Text = selectedRow.Cells("Year").Value.ToString()
            cbSection.Text = selectedRow.Cells("Section").Value.ToString()
            txtStudID.Text = selectedRow.Cells("StudentID").Value.ToString()
            txtEmail.Text = selectedRow.Cells("Email").Value.ToString()
            txtContact.Text = selectedRow.Cells("ContactNo").Value.ToString()
            txtMessenger.Text = selectedRow.Cells("Messenger").Value.ToString()

            ' Enter edit mode
            isEditMode = True
            editingStudentID = selectedRow.Cells("StudentID").Value.ToString()
            btngenerate.Text = "Save"

        End If

        ' Delete button functionality
        If e.ColumnIndex = StudentData.Columns("Delete").Index Then
            Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo)
            If confirmDelete = DialogResult.Yes Then
                DeleteRecord(selectedRow.Cells("StudentID").Value.ToString())
            End If
        End If
    End Sub

    ' Delete the selected student record from the database
    Private Sub DeleteRecord(studentID As String)
        Try
            Dim sqlQuery As String = "DELETE FROM StudentInformation WHERE StudentID = @StudentID"
            Dim cmd As New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@StudentID", studentID)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            ' Step 2: Delete the associated QR code image from the folder
            Dim saveFolder As String = "C:\Users\user\source\repos\httprie\ERS-FinalProject\EventProject\ERS-QRCode"
            Dim fileName As String = txtStudID.Text & ".png"
            Dim filePath As String = Path.Combine(saveFolder, fileName)

            If File.Exists(filePath) Then
                File.Delete(filePath) ' Delete the QR Code image file
            End If

            ' Notify success and refresh the grid view
            MessageBox.Show("Record and QR Code image deleted successfully!")
            LoadStudentInfo() ' Refresh the data grid view after deletion
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Populate ComboBoxes on Form Load
    Private Sub GenerateQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentInfo()

        ' Populate Department
        populateComboBoxDept()

        ' Populate Course
        populateComboBoxCourses()

        ' Populate Year
        cbYear.Items.AddRange(New String() {"1", "2", "3", "4", "5"})

        ' Populate Section
        cbSection.Items.AddRange(New String() {"A", "B", "C", "D", "E"})

        'Populate StudentID
        populateComboBoxStudentID()
    End Sub

    Private Sub populateComboBoxDept()
        ' Populate Department ComboBox
        Dim sqlQuery As String = "SELECT DepartmentName FROM Departments"

        ' Create MySQL connection using the connection string
        Using conn As New MySqlConnection(connectionString)
            ' Create a new MySqlDataAdapter
            Dim da As New MySqlDataAdapter(sqlQuery, conn)

            ' Create a DataTable to hold the query results
            Dim dt As New DataTable()

            ' Open the connection and fill the DataTable
            conn.Open()
            da.Fill(dt)
            conn.Close()

            ' Add department names to the ComboBox
            For Each row As DataRow In dt.Rows
                cbDepartment.Items.Add(row("DepartmentName").ToString())
            Next
        End Using
    End Sub

    Private Sub populateComboBoxCourses()
        ' Populate Department ComboBox
        Dim sqlQuery As String = "SELECT CourseName FROM Courses"

        ' Create MySQL connection using the connection string
        Using conn As New MySqlConnection(connectionString)
            ' Create a new MySqlDataAdapter
            Dim da As New MySqlDataAdapter(sqlQuery, conn)

            ' Create a DataTable to hold the query results
            Dim dt As New DataTable()

            ' Open the connection and fill the DataTable
            conn.Open()
            da.Fill(dt)
            conn.Close()

            ' Add department names to the ComboBox
            For Each row As DataRow In dt.Rows
                cbCourse.Items.Add(row("CourseName").ToString())
            Next
        End Using
    End Sub

    Private Sub clearTextfield()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtExtension.Clear()
        cbDepartment.SelectedIndex = -1
        cbCourse.SelectedIndex = -1
        cbYear.SelectedIndex = -1
        cbSection.SelectedIndex = -1
        txtMessenger.Clear()
        txtContact.Clear()
        cbCourse.Items.Clear()
        cbDepartment.Items.Clear()
        cbYear.Items.Clear()
        cbSection.Items.Clear()
        txtStudID.Clear()
        txtEmail.Clear()
        QRCode.Image = Nothing
    End Sub

    Private Sub saveData()
        ' Retrieve user Input
        GetInputData()

        If Not ValidateInput() Then Return

        Dim saveFolder As String = "C:\Users\user\source\repos\httprie\ERS-FinalProject\EventProject\ERS-QRCode"
        Dim fileName As String = txtStudID.Text & ".png"
        Dim filePath As String = Path.Combine(saveFolder, fileName)

        Try
            If Not Directory.Exists(saveFolder) Then
                Directory.CreateDirectory(saveFolder)
            End If

            If isEditMode Then
                If File.Exists(filePath) Then
                    File.Delete(filePath) ' Delete the file to avoid locking issues
                End If
            End If

            If QRCode.Image IsNot Nothing Then
                Using bmp As New Bitmap(QRCode.Image)
                    bmp.Save(filePath, Imaging.ImageFormat.Png)
                End Using
                MessageBox.Show("QR Code saved successfully!")
            Else
                MessageBox.Show("No QR Code Image to save.")
            End If

        Catch ex As Exception
            MessageBox.Show($"An error occurred while saving the QR Code: {ex.Message}")
        End Try
    End Sub

    Private Sub sendEmail()
        GetInputData()

        If String.IsNullOrWhiteSpace(firstname) OrElse String.IsNullOrWhiteSpace(course) OrElse String.IsNullOrWhiteSpace(year) OrElse String.IsNullOrWhiteSpace(studID) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Try
            Using mail As New MailMessage()
                mail.From = New MailAddress("dyci.eventreg@gmail.com")
                mail.To.Add(email)
                mail.Subject = "Attendance QR Code"
                mail.Body = "Attendance QR Code" & vbCrLf &
                       "Name: " & firstname & " " & lastname & vbCrLf &
                       "Course: " & course & vbCrLf &
                       "Year and Section: " & year & section & vbCrLf &
                       "Student ID: " & studID & vbCrLf & vbCrLf &
                       "Please present this at every event you attend. Thank you!"

                Dim saveFolder As String = "C:\Users\user\source\repos\httprie\ERS-FinalProject\EventProject\ERS-QRCode"
                Dim fileName As String = studID & ".png"
                Dim filePath As String = Path.Combine(saveFolder, fileName)

                If File.Exists(filePath) Then
                    mail.Attachments.Add(New Attachment(filePath))
                End If

                Using smtpServer As New SmtpClient("smtp.gmail.com")
                    smtpServer.Port = 587
                    smtpServer.Credentials = New NetworkCredential("dyci.eventreg@gmail.com", "qxfc xvqr amsy wyxe")
                    smtpServer.EnableSsl = True

                    smtpServer.Send(mail)
                    MessageBox.Show("QR Code sent successfully to " & email)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message)
        End Try
    End Sub

    Private Sub sendEmailUpdate()
        Try
            Using mail As New MailMessage()
                mail.From = New MailAddress("dyci.eventreg@gmail.com")
                mail.To.Add(email)
                mail.Subject = "Updated Attendance QR Code"
                mail.Body = "Your Updated Attendance QR Code" & vbCrLf &
                       "Name: " & firstname & " " & lastname & vbCrLf &
                       "Course: " & course & vbCrLf &
                       "Year and Section: " & year & section & vbCrLf &
                       "Student ID: " & studID & vbCrLf & vbCrLf &
                       "Your QR Code has been updated. Please use this new QR Code for future events. Thank you!"

                ' Attach updated QR code
                Dim saveFolder As String = "C:\Users\user\source\repos\httprie\ERS-FinalProject\EventProject\ERS-QRCode"
                Dim fileName As String = studID & ".png"
                Dim filePath As String = Path.Combine(saveFolder, fileName)

                If File.Exists(filePath) Then
                    mail.Attachments.Add(New Attachment(filePath))
                End If

                Using smtpServer As New SmtpClient("smtp.gmail.com")
                    smtpServer.Port = 587
                    smtpServer.Credentials = New NetworkCredential("dyci.eventreg@gmail.com", "qxfc xvqr amsy wyxe")
                    smtpServer.EnableSsl = True
                    smtpServer.Send(mail)
                End Using

                MessageBox.Show("Updated QR Code sent successfully to " & email)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error sending update email: " & ex.Message)
        End Try
    End Sub
    Private Sub populateComboBoxStudentID()
        ' Populate Department ComboBox
        Dim sqlQuery As String = "SELECT StudentID FROM StudentInformation"

        ' Create MySQL connection using the connection string
        Using conn As New MySqlConnection(connectionString)
            ' Create a new MySqlDataAdapter
            Dim da As New MySqlDataAdapter(sqlQuery, conn)

            ' Create a DataTable to hold the query results
            Dim dt As New DataTable()

            ' Open the connection and fill the DataTable
            conn.Open()
            da.Fill(dt)
            conn.Close()

            ' Add department names to the ComboBox
            For Each row As DataRow In dt.Rows
                cbStudentID.Items.Add(row("StudentID").ToString())
            Next
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Check if a StudentID is selected
        If cbStudentID.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a Student ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Retrieve the selected StudentID
        Dim selectedStudentID As String = cbStudentID.SelectedItem.ToString()

        ' Define the SQL query to search for student information
        Dim sqlQuery As String = "SELECT * FROM StudentInformation WHERE StudentID = @StudentID"

        ' Create MySQL connection using the class-level connection string
        Using conn As New MySqlConnection(connectionString)
            ' Create a new MySqlCommand
            Using cmd As New MySqlCommand(sqlQuery, conn)
                ' Add the parameter for StudentID
                cmd.Parameters.AddWithValue("@StudentID", selectedStudentID)

                ' Create a new MySqlDataAdapter
                Dim da As New MySqlDataAdapter(cmd)

                ' Create a DataTable to hold the query results
                Dim dt As New DataTable()

                Try
                    ' Open the connection and fill the DataTable
                    conn.Open()
                    da.Fill(dt)
                    conn.Close()

                    ' Check if any records are found
                    If dt.Rows.Count > 0 Then
                        ' Bind the DataTable to the DataGridView
                        StudentData.DataSource = dt
                    Else
                        MessageBox.Show("No records found for the selected Student ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    ' Handle exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class