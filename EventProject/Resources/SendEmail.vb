Imports System.Net.Mail
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class SendEmail
    'Inherits GenerateQR

    ' This will be called when btnSendEmail is clicked in GenerateQR.vb
    Public Sub PrepareEmailData(studentID As String)
        ' Get student info (including email) and QR code from the database
        Dim studentInfo As (String, String) = GetStudentInfoAndQRCode(studentID)

        ' Set the email properties
        txtWhereTo.Text = studentInfo.Item1  ' Student's email
        txtMessageBox.Text = "Dear Student, Please find your QR code attached."
        ' You can set the subject here or allow the user to edit
        txtSubject.Text = "Your QR Code"
        ' Attach the QR code
        btnAttachFile.Tag = studentInfo.Item2 ' Attach QR image blob as tag
    End Sub

    ' Retrieves student info and QR code (as a byte array) from the database
    Private Function GetStudentInfoAndQRCode(studentID As String) As (String, String)
        Try
            Using conn As New MySqlConnection("your_connection_string_here")
                conn.Open()
                Dim sqlQuery As String = "SELECT Email, QRCodeData FROM StudentInformation WHERE StudentID = @StudentID"
                Using cmd As New MySqlCommand(sqlQuery, conn)
                    cmd.Parameters.AddWithValue("@StudentID", studentID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Assuming QRCodeData is stored as a blob
                            Dim email As String = reader("Email").ToString()
                            Dim qrCodeData As Byte() = CType(reader("QRCodeData"), Byte())
                            ' Convert the blob QR code into a base64 string for easier attachment
                            Dim qrCodeBase64 As String = Convert.ToBase64String(qrCodeData)
                            Return (email, qrCodeBase64)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving student info or QR code: " & ex.Message)
        End Try
        Return ("", "")
    End Function

    ' Send email with QR code as attachment
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim mail As New MailMessage()
        Try
            ' Set email properties from the form
            mail.From = New MailAddress("youremail@example.com")  ' Sender's email address
            mail.To.Add(txtWhereTo.Text)
            mail.Subject = txtSubject.Text
            mail.Body = txtMessageBox.Text

            ' Attach QR code file
            If btnAttachFile.Tag IsNot Nothing Then
                Dim qrCodeData As String = btnAttachFile.Tag.ToString()
                Dim qrCodeBytes As Byte() = Convert.FromBase64String(qrCodeData)
                Dim ms As New MemoryStream(qrCodeBytes)
                mail.Attachments.Add(New Attachment(ms, "QRCode.png", "image/png"))
            End If

            ' Set up SMTP client and send email
            Using smtp As New SmtpClient("smtp.example.com", 587)  ' Use your SMTP server
                smtp.Credentials = New System.Net.NetworkCredential("youremail@example.com", "yourpassword")
                smtp.EnableSsl = True
                smtp.Send(mail)
            End Using

            MessageBox.Show("Email sent successfully!")
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message)
        End Try
    End Sub
End Class