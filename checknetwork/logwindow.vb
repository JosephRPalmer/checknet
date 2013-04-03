Public Class logwindow

    Private Sub logwindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Shared Function writetolog(write As String)
        Dim writelog As String
        Dim time As String = Date.Now
        writelog = time + " : " + write + vbCrLf
        logwindow.logwindo.Text = logwindow.logwindo.Text + writelog
        logwindow.logwindo.SelectionStart = logwindow.logwindo.Text.Length
        logwindow.logwindo.ScrollToCaret()
        Return 1
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Clearlog_Click(sender As Object, e As EventArgs) Handles Clearlog.Click
        logwindo.Clear()
    End Sub
End Class