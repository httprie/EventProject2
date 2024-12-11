Imports MySql.Data.MySqlClient
Imports MessagingToolkit.QRCode.Codec
Imports System.IO
Imports System.Drawing
Imports System.Text.RegularExpressions

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
        Dim course As String = txtCourse.Text
        Dim year As String = txtYear.Text
        Dim section As String = txtSection.Text
        Dim studID As String = txtStudID.Text
        Dim email As String = txtEmail.Text

        If String.IsNullOrWhiteSpace(firstname) OrElse String.IsNullOrWhiteSpace(lastname) OrElse String.IsNullOrWhiteSpace(course) OrElse String.IsNullOrWhiteSpace(year) OrElse String.IsNullOrWhiteSpace(section) OrElse String.IsNullOrWhiteSpace(studID) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.")
            Return
        End If

        If RecordExists("StudentID", studID) OrElse RecordExists("ContactNo", contactno) OrElse RecordExists("Email", email) Then
            MessageBox.Show("Duplicate Student ID, Contact Number, or Email detected. Cannot generate QR code.")
            Return
        End If

        Dim qrData As String = $"{firstname},{middlename},{lastname},{suffix},{messenger},{contactno},{course},{year},{section},{studID},{email}"
        Dim gen As New QRCodeEncoder()
        gen.QRCodeScale = 6

        Try
            Dim qr As Bitmap = gen.Encode(qrData)
            If qr IsNot Nothing Then
                QRCode.Image = qr
                SaveQRCodeToDatabase(firstname, middlename, lastname, suffix, messenger, contactno, course, year, section, studID, email, qr)
                LoadStudentInfo()
            Else
                MessageBox.Show("Failed to generate QR Code.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, emailPattern)
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

    Private Sub SaveQRCodeToDatabase(firstname As String, middlename As String, lastname As String, suffix As String, messenger As String, contactno As String, course As String, year As String, section As String, studID As String, email As String, qrImage As Bitmap)
        Try
            Using ms As New MemoryStream()
                qrImage.Save(ms, Imaging.ImageFormat.Png)
                Dim qrCodeData As Byte() = ms.ToArray()

                Dim sqlQuery As String = "INSERT INTO StudentInformation (First_Name, Middle_Name, Last_Name, Suffix, MessengerName, ContactNo, Course, Year, Section, StudentID, Email, QRCodeData) VALUES (@First_Name, @Middle_Name, @Last_Name, @Suffix, @MessengerName, @ContactNo, @Course, @Year, @Section, @StudentID, @Email, @QRCodeData)"
                Dim cmd As New MySqlCommand(sqlQuery, conn)
                cmd.Parameters.AddWithValue("@First_Name", firstname)
                cmd.Parameters.AddWithValue("@Middle_Name", middlename)
                cmd.Parameters.AddWithValue("@Last_Name", lastname)
                cmd.Parameters.AddWithValue("@Suffix", suffix)
                cmd.Parameters.AddWithValue("@MessengerName", messenger)
                cmd.Parameters.AddWithValue("@ContactNo", contactno)
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
            Dim sqlQuery As String = "SELECT StudNo, First_Name, Middle_Name, Last_Name, Suffix, MessengerName, ContactNo, Course, Year, Section, StudentID, Email FROM StudentInformation"
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

    Private Sub GenerateQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddButtonsToDataGridView()
        LoadStudentInfo()
    End Sub
End Class
