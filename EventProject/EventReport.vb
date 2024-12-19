Imports System.Runtime.InteropServices
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class EventReport
    Public ReportPath As String
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")> Private Shared Function roundcorner(ByVal leftcorner As Integer, ByVal topcorner As Integer, ByVal rightcorner As Integer,
                                        ByVal bottomcorner As Integer, ByVal widthellipse As Integer, ByVal heightellipse As Integer) As IntPtr

    End Function
    Private Sub EventReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(roundcorner(0, 0, Width, Height, 20, 20))

        Try
            Dim reportDocument As New ReportDocument()
            reportDocument.Load(ReportPath)
            CrystalReportViewer2.ReportSource = reportDocument
            CrystalReportViewer2.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class