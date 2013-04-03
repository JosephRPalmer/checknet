Public Class aboutapp

    Private Sub aboutapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = String.Format("Version {0}", My.Application.Deployment.CurrentVersion.ToString)

    End Sub
End Class