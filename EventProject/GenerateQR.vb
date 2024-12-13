Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports MessagingToolkit.QRCode.Codec

Public Class GenerateQR
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


    Private Sub btngenerate_Click(sender As Object, e As EventArgs) Handles btngenerate.Click
        Dim firstname As String = txtFirstName.Text
        Dim middlename As String = txtMiddleName.Text
        Dim lastname As String = txtLastName.Text
        Dim suffix As String = txtExtension.Text
        Dim messenger As String = txtMessenger.Text
        Dim contactno As String = txtContact.Text
        Dim department As String = txtDepartment.Text  ' Added department
        Dim course As String = txtCourse.Text
        Dim year As String = txtYear.Text
        Dim section As String = txtSection.Text
        Dim studID As String = txtStudID.Text
        Dim email As String = txtEmail.Text

        ' Update validation to include department
        If String.IsNullOrWhiteSpace(firstname) OrElse
       String.IsNullOrWhiteSpace(lastname) OrElse
       String.IsNullOrWhiteSpace(department) OrElse  ' Added department check
       String.IsNullOrWhiteSpace(course) OrElse
       String.IsNullOrWhiteSpace(year) OrElse
       String.IsNullOrWhiteSpace(section) OrElse
       String.IsNullOrWhiteSpace(studID) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.")
            Return
        End If

        If RecordExists("StudentID", studID) OrElse
       RecordExists("ContactNo", contactno) OrElse
       RecordExists("Email", email) Then
            MessageBox.Show("Duplicate Student ID, Contact Number, or Email detected. Cannot generate QR code.")
            Return
        End If

        ' Update QR data to include department
        Dim qrData As String = $"{firstname},{middlename},{lastname},{suffix},{messenger},{contactno},{department},{course},{year},{section},{studID},{email}"
        Dim gen As New QRCodeEncoder()
        gen.QRCodeScale = 6

        Try
            Dim qr As Bitmap = gen.Encode(qrData)
            If qr IsNot Nothing Then
                QRCode.Image = qr
                SaveQRCodeToDatabase(firstname, middlename, lastname, suffix, messenger, contactno, department, course, year, section, studID, email, qr)
                LoadStudentInfo()
            Else
                MessageBox.Show("Failed to generate QR Code.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SaveQRCodeToDatabase(firstname As String, middlename As String, lastname As String,
                               suffix As String, messenger As String, contactno As String,
                               department As String, course As String, year As String,
                               section As String, studID As String, email As String,
                               qrImage As Bitmap)
        Try
            Using ms As New MemoryStream()
                qrImage.Save(ms, Imaging.ImageFormat.Png)
                Dim qrCodeData As Byte() = ms.ToArray()

                Dim sqlQuery As String = "INSERT INTO StudentInformation (First_Name, Middle_Name, Last_Name, " &
                                   "Suffix, MessengerName, ContactNo, Department, Course, Year, Section, " &
                                   "StudentID, Email, QRCodeData) VALUES (@First_Name, @Middle_Name, " &
                                   "@Last_Name, @Suffix, @MessengerName, @ContactNo, @Department, @Course, " &
                                   "@Year, @Section, @StudentID, @Email, @QRCodeData)"

                Dim cmd As New MySqlCommand(sqlQuery, conn)
                cmd.Parameters.AddWithValue("@First_Name", firstname)
                cmd.Parameters.AddWithValue("@Middle_Name", middlename)
                cmd.Parameters.AddWithValue("@Last_Name", lastname)
                cmd.Parameters.AddWithValue("@Suffix", suffix)
                cmd.Parameters.AddWithValue("@MessengerName", messenger)
                cmd.Parameters.AddWithValue("@ContactNo", contactno)
                cmd.Parameters.AddWithValue("@Department", department)  ' Added department parameter
                cmd.Parameters.AddWithValue("@Course", course)
                cmd.Parameters.AddWithValue("@Year", year)
                cmd.Parameters.AddWithValue("@Section", section)
                cmd.Parameters.AddWithValue("@StudentID", studID)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@QRCodeData", qrCodeData)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()

                MessageBox.Show("QR Code and student information saved successfully!")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub LoadStudentInfo()
        Try
            Dim sqlQuery As String = "SELECT StudNo, First_Name, Middle_Name, Last_Name, " &
                                "Suffix, MessengerName, ContactNo, Department, Course, " &
                                "Year, Section, StudentID, Email FROM StudentInformation"

            Dim da As New MySqlDataAdapter(sqlQuery, conn)
            Dim dt As New DataTable()

            conn.Open()
            da.Fill(dt)
            conn.Close()

            StudentData.DataSource = Nothing
            StudentData.Columns.Clear()

            StudentData.DataSource = dt
            AddButtonsToDataGridView()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub StudentData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentData.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim selectedRow As DataGridViewRow = StudentData.Rows(e.RowIndex)

        ' Edit button
        If e.ColumnIndex = StudentData.Columns("Edit").Index Then
            txtFirstName.Text = selectedRow.Cells("First_Name").Value.ToString()
            txtMiddleName.Text = selectedRow.Cells("Middle_Name").Value.ToString()
            txtLastName.Text = selectedRow.Cells("Last_Name").Value.ToString()
            txtExtension.Text = selectedRow.Cells("Suffix").Value.ToString()
            txtMessenger.Text = selectedRow.Cells("MessengerName").Value.ToString()
            txtContact.Text = selectedRow.Cells("ContactNo").Value.ToString()
            txtDepartment.Text = selectedRow.Cells("Department").Value.ToString()  ' Added department
            txtCourse.Text = selectedRow.Cells("Course").Value.ToString()
            txtYear.Text = selectedRow.Cells("Year").Value.ToString()
            txtSection.Text = selectedRow.Cells("Section").Value.ToString()
            txtStudID.Text = selectedRow.Cells("StudentID").Value.ToString()
            txtEmail.Text = selectedRow.Cells("Email").Value.ToString()
        End If

        ' Delete button functionality remains the same
        If e.ColumnIndex = StudentData.Columns("Delete").Index Then
            Dim confirmResult = MessageBox.Show("Are you sure you want to delete this record?",
                                          "Delete Confirmation", MessageBoxButtons.YesNo)
            If confirmResult = DialogResult.Yes Then
                DeleteRecord(selectedRow.Cells("StudentID").Value.ToString())
            End If
        End If
    End Sub

    Private Sub DeleteRecord(studID As String)
        Try
            Dim sqlQuery As String = "DELETE FROM StudentInformation WHERE StudentID = @StudentID"
            Dim cmd As New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@StudentID", studID)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Record deleted successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Try
            ' Regular expression pattern for email validation
            Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
            Return Regex.IsMatch(email, emailPattern)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function RecordExists(columnName As String, value As String) As Boolean
        Dim exists As Boolean = False
        Try
            Dim sqlQuery As String = $"SELECT COUNT(*) FROM StudentInformation WHERE {columnName} = @{columnName}"
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

    Private Sub SaveUpdatedData(firstname As String, middlename As String, lastname As String,
                          suffix As String, messenger As String, contactno As String,
                          department As String, course As String, year As String,
                          section As String, studID As String, email As String)

        ' Create QR code data string including department
        Dim qrData As String = $"{firstname},{middlename},{lastname},{suffix},{messenger}," &
                          $"{contactno},{department},{course},{year},{section},{studID},{email}"

        Dim gen As New QRCodeEncoder()
        gen.QRCodeScale = 6

        Try
            Dim qr As Bitmap = gen.Encode(qrData)
            Using ms As New MemoryStream()
                qr.Save(ms, Imaging.ImageFormat.Png)
                Dim qrCodeData As Byte() = ms.ToArray()

                Dim sqlQuery As String = "UPDATE StudentInformation SET " &
                                   "First_Name = @First_Name, " &
                                   "Middle_Name = @Middle_Name, " &
                                   "Last_Name = @Last_Name, " &
                                   "Suffix = @Suffix, " &
                                   "MessengerName = @MessengerName, " &
                                   "ContactNo = @ContactNo, " &
                                   "Department = @Department, " &
                                   "Course = @Course, " &
                                   "Year = @Year, " &
                                   "Section = @Section, " &
                                   "Email = @Email, " &
                                   "QRCodeData = @QRCodeData " &
                                   "WHERE StudentID = @StudentID"

                Dim cmd As New MySqlCommand(sqlQuery, conn)
                cmd.Parameters.AddWithValue("@First_Name", firstname)
                cmd.Parameters.AddWithValue("@Middle_Name", middlename)
                cmd.Parameters.AddWithValue("@Last_Name", lastname)
                cmd.Parameters.AddWithValue("@Suffix", suffix)
                cmd.Parameters.AddWithValue("@MessengerName", messenger)
                cmd.Parameters.AddWithValue("@ContactNo", contactno)
                cmd.Parameters.AddWithValue("@Department", department)
                cmd.Parameters.AddWithValue("@Course", course)
                cmd.Parameters.AddWithValue("@Year", year)
                cmd.Parameters.AddWithValue("@Section", section)
                cmd.Parameters.AddWithValue("@StudentID", studID)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@QRCodeData", qrCodeData)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()

                MessageBox.Show("Updated data and QR Code saved successfully!")
                LoadStudentInfo()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Clear input fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtExtension.Clear()
        txtMessenger.Clear()
        txtContact.Clear()
        txtCourse.Clear()
        txtDepartment.Clear()
        txtYear.Clear()
        txtSection.Clear()
        txtStudID.Clear()
        txtEmail.Clear()
        QRCode.Image = Nothing
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim firstname As String = txtFirstName.Text
        Dim middlename As String = txtMiddleName.Text
        Dim lastname As String = txtLastName.Text
        Dim suffix As String = txtExtension.Text
        Dim messenger As String = txtMessenger.Text
        Dim contactno As String = txtContact.Text
        Dim department As String = txtDepartment.Text  ' Added this line
        Dim course As String = txtCourse.Text
        Dim year As String = txtYear.Text
        Dim section As String = txtSection.Text
        Dim studID As String = txtStudID.Text
        Dim email As String = txtEmail.Text

        If String.IsNullOrWhiteSpace(firstname) OrElse
       String.IsNullOrWhiteSpace(lastname) OrElse
       String.IsNullOrWhiteSpace(department) OrElse  ' Added department check
       String.IsNullOrWhiteSpace(course) OrElse
       String.IsNullOrWhiteSpace(year) OrElse
       String.IsNullOrWhiteSpace(section) OrElse
       String.IsNullOrWhiteSpace(studID) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        Dim save As New SaveFileDialog()

        save.InitialDirectory = "C:\Users\user\Documents\BASILIO\QRCode"
        save.FileName = txtLastName.Text
        save.Filter = "PNG|*.png"

        If save.ShowDialog() = DialogResult.OK Then
            If QRCode.Image IsNot Nothing Then
                QRCode.Image.Save(save.FileName, Imaging.ImageFormat.Png)
            Else
                MessageBox.Show("No QR Code Image to save.")
            End If
        End If
    End Sub

    Private Sub btnsendEmail_Click(sender As Object, e As EventArgs) Handles btnsendEmail.Click
        ' Collect student data from the form
        Dim firstname As String = txtFirstName.Text
        Dim middlename As String = txtMiddleName.Text
        Dim lastname As String = txtLastName.Text
        Dim suffix As String = txtExtension.Text
        Dim messenger As String = txtMessenger.Text
        Dim contactno As String = txtContact.Text
        Dim department As String = txtDepartment.Text
        Dim course As String = txtCourse.Text
        Dim year As String = txtYear.Text
        Dim section As String = txtSection.Text
        Dim studID As String = txtStudID.Text
        Dim email As String = txtEmail.Text

        If String.IsNullOrWhiteSpace(firstname) OrElse String.IsNullOrWhiteSpace(course) OrElse String.IsNullOrWhiteSpace(year) OrElse String.IsNullOrWhiteSpace(studID) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim obj As New EmailForm

        obj.email = txtEmail.Text
        obj.message = "Attendance QR Code" & vbCrLf &
               "Name: " & txtFirstName.Text & txtLastName.Text & vbCrLf &
               "Course: " & txtCourse.Text & vbCrLf &
               "Year and Section: " & txtYear.Text & txtSection.Text & vbCrLf &
               "Student ID: " & txtStudID.Text & vbCrLf & vbCrLf &
               "Please present this at every event you attend. Thank you!"

        obj.Show()

    End Sub

    Private Sub GenerateQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pnlInfo_Paint(sender As Object, e As PaintEventArgs) Handles pnlInfo.Paint

    End Sub
End Class
