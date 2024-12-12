Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Login
    Inherits Form

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                      ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr
    End Function

    Public Shared LoggedInUserID As Integer
    Public Shared PasswordResetSuccessful As Boolean = False

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, Width, Height, 20, 20))
        AcceptButton = btnSignIn
        Timer1.Enabled = True
    End Sub

    Public Sub ResetFields()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            DbConnect()

            ' Combine all checks into a single query
            Dim query As String = "SELECT UserID, LoginAttempts, PasswordReset, FullName, Role, HashedPassword 
                                    FROM Accounts 
                                    WHERE UserName = @Username"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)

                ' Use ExecuteScalar or ExecuteNonQuery instead of DataReader
                Dim userDetails As DataTable = New DataTable()
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(userDetails)
                End Using

                ' Check if user exists
                If userDetails.Rows.Count = 0 Then
                    MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim userRow As DataRow = userDetails.Rows(0)
                Dim userId As Integer = Convert.ToInt32(userRow("UserID"))
                Dim loginAttempts As Integer = Convert.ToInt32(userRow("LoginAttempts"))
                Dim passwordReset As Integer = Convert.ToInt32(userRow("PasswordReset"))
                Dim storedPasswordHash As String = userRow("HashedPassword").ToString()

                ' Check account lockout
                If loginAttempts <= 0 Then
                    MessageBox.Show("Account is locked. Please reset your password.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Dim resetForm As New ResetPassword()
                    resetForm.LoggedInUserID = userId
                    resetForm.Show()
                    Me.Hide()
                    Return
                End If

                ' Check if password reset is required
                If passwordReset = 0 Then
                    Dim resetPasswordForm As New ResetPassword()
                    resetPasswordForm.LoggedInUserID = userId
                    resetPasswordForm.Show()
                    Me.Hide()
                    Return
                End If

                ' Verify password
                Dim inputPasswordHash As String = HashPassword(password)
                Dim isPasswordCorrect As Boolean = (inputPasswordHash = storedPasswordHash) OrElse PasswordResetSuccessful

                If isPasswordCorrect Then
                    ' Reset login attempts
                    UpdateLoginAttempts(username, 3)

                    ' Proceed to home form
                    Dim fullName As String = userRow("FullName").ToString()
                    Dim role As String = userRow("Role").ToString()

                    Dim homeForm As New HomeForm(fullName, role)
                    PasswordResetSuccessful = False
                    Me.Hide()
                    homeForm.Show()
                Else
                    ' Decrease login attempts
                    loginAttempts -= 1
                    UpdateLoginAttempts(username, loginAttempts)

                    If loginAttempts <= 0 Then
                        MessageBox.Show("Account is locked. Please reset your password.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Dim resetForm As New ResetPassword()
                        resetForm.LoggedInUserID = userId
                        resetForm.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show($"Incorrect password. {loginAttempts} attempts remaining.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub UpdateLoginAttempts(username As String, attempts As Integer)
        Try
            DbConnect()
            Dim updateQuery As String = "UPDATE Accounts SET LoginAttempts = @Attempts WHERE UserName = @Username"

            Using cmd As New MySqlCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@Attempts", attempts)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating login attempts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Function HashPassword(password As String) As String
        Using sha256 As Security.Cryptography.SHA256 = Security.Cryptography.SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password))
            Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        End
    End Sub
End Class