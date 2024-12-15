Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class AddAccountForm
    Inherits Form
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")> Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                        ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr
    End Function
    Public Event AccountAdded()

    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim UserName As String
    Dim Password As String
    Dim FullName As String
    Dim Role As String

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)

        Dim radius As Integer = 23
        Dim rect As New Rectangle(0, 0, cbRole.Width, cbRole.Height)
        Dim path As New Drawing2D.GraphicsPath()

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)

        path.CloseFigure()

        cbRole.Region = New Region(path)
    End Sub
    Private Sub AddAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, Width, Height, 20, 20))
        DbConnect()

    End Sub


    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click
        UserName = txtUname.Text
        FullName = txtFname.Text

        If cbRole.SelectedItem IsNot Nothing Then
            Role = cbRole.SelectedItem.ToString()
        Else
            MessageBox.Show("Please select a role.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(UserName) OrElse String.IsNullOrWhiteSpace(FullName) Then
            MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Default password, no need to ask the user for it
        Dim defaultPassword As String = "dyci1234"
        Dim hashedPassword As String = ComputeHash(defaultPassword)

        Try
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO Accounts (UserName, HashedPassword, FullName, Role) VALUES (@UserName, @HashedPassword, @FullName, @Role)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@UserName", UserName)
                .Parameters.AddWithValue("@HashedPassword", hashedPassword)
                .Parameters.AddWithValue("@FullName", FullName)
                .Parameters.AddWithValue("@Role", Role)

                result = cmd.ExecuteNonQuery()

                If result > 0 Then
                    Dim confirmResult As DialogResult = MessageBox.Show("Do you really want to add this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If confirmResult = DialogResult.Yes Then
                        MessageBox.Show("Account Added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        RaiseEvent AccountAdded()
                        Me.Hide()
                        ClearTextBoxes()
                    Else
                        cmd.CommandText = "DELETE FROM Accounts WHERE UserName = @UserName"
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Account addition canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Failed to add account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ComputeHash(password As String) As String
        ' Hash the default password (dyci1234) before storing it
        Return Convert.ToBase64String(New System.Security.Cryptography.SHA256Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)))
    End Function

    Private Sub ClearTextBoxes()
        txtUname.Text = ""
        txtFname.Text = ""
        cbRole.SelectedIndex = -1
    End Sub
    Private Sub btnClearTxt_Click(sender As Object, e As EventArgs) Handles btnClearTxt.Click
        ClearTextBoxes()
    End Sub
End Class
