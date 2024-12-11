Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class ResetPassword
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                      ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr
    End Function

    Public Property LoggedInUserID As String

    Dim sqlQuery As String
    Dim da As MySqlDataAdapter
    Dim newPassword As String
    Dim confirmPassword As String

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        newPassword = txtNewPassword.Text
        confirmPassword = txtConfirmPassword.Text

        If String.IsNullOrWhiteSpace(newPassword) OrElse String.IsNullOrWhiteSpace(confirmPassword) Then
            MessageBox.Show("Please fill in both password fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If newPassword <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim checkUserQuery As String = "SELECT COUNT(*) FROM Accounts WHERE UserID = @UserID"
            Dim checkCmd As New MySqlCommand(checkUserQuery, conn)
            checkCmd.Parameters.AddWithValue("@UserID", LoggedInUserID)

            conn.Open()
            Dim userExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
            conn.Close()

            If userExists = 0 Then
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim hashedPassword As String = HashPassword(newPassword)

            sqlQuery = "UPDATE Accounts SET HashedPassword = @Password, PasswordReset = 1, LoginAttempts = 3 WHERE UserID = @UserID"
            Dim cmd As New MySqlCommand(sqlQuery, conn)
            cmd.Parameters.AddWithValue("@Password", hashedPassword)
            cmd.Parameters.AddWithValue("@UserID", LoggedInUserID)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Password has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtNewPassword.Clear()
            txtConfirmPassword.Clear()

            Login.ResetFields()
            Login.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function HashPassword(password As String) As String
        Using sha256 As Security.Cryptography.SHA256 = Security.Cryptography.SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password))
            Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub ResetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
