Public Class PopupForm

    Public Sub New()
        InitializeComponent()
        Icon = My.Resources.TrayIcon
    End Sub

    Private Sub HttpLocalhost_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles httpLocalhost.Click
        Shell("cmd /c start http://localhost")
        Me.Close()
    End Sub

    Private Sub WSL_Click(sender As Object, e As EventArgs) Handles WSL.Click
        Shell("cmd /c wsl")
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class