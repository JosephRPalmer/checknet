Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Pending"
        logwindow.writetolog("SYSTEM STARTED")
        'Put here any message boxes about current errors
        MsgBox("Network status detection is intermittent on Windows 8. Please restart if you recieve connection problems prompt!", MsgBoxStyle.Exclamation, "Current App Update - 1.1.3.2")
        'Move window to bottom left
        Dim working_area As Rectangle = _
    SystemInformation.WorkingArea
        Dim x As Integer = _
            working_area.Left + _
            working_area.Width - _
            Me.Width
        Dim y As Integer = _
            working_area.Top + _
            working_area.Height - _
            Me.Height
        Me.Location = New Point(x, y)
        TopMost = True
    End Sub
    Function IsConnected() As Boolean
        Try
            Return My.Computer.Network.Ping("74.125.132.94")
        Catch
            Return False
        End Try
    End Function
    Function connected()
        Label1.Text = "Connected"
        logwindow.writetolog("Connected as of now")
        Return 1
    End Function
    Function connectionproblems()
        Label1.Text = "Connection Problems Detected"
        logwindow.writetolog("Connection Problems Detected")
        Return 1
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If IsConnected() = True Then
            connected()
        Else
            connectionproblems()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        logwindow.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        aboutapp.Show()
    End Sub
End Class
