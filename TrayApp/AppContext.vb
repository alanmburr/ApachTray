
Public Class AppContext
    Inherits ApplicationContext

#Region " Storage "

    Private WithEvents Tray As NotifyIcon
    Private WithEvents MainMenu As ContextMenuStrip
    Private WithEvents mnuDisplayForm As ToolStripMenuItem
    Private WithEvents mnuWSL As ToolStripMenuItem
    Private WithEvents mnuLocalhost As ToolStripMenuItem
    Private WithEvents mnuStopApache As ToolStripMenuItem
    Private WithEvents mnuStartApache As ToolStripMenuItem
    Private WithEvents mnuRestartApache As ToolStripMenuItem
    Private WithEvents mnuReloadApache As ToolStripMenuItem
    Private WithEvents mnuSep1 As ToolStripSeparator
    Private WithEvents mnuSep2 As ToolStripSeparator
    Private WithEvents mnuSep3 As ToolStripSeparator
    Private WithEvents mnuExit As ToolStripMenuItem

#End Region

#Region " Constructor "

    Public Sub New()
        'Initialize the menus
        mnuDisplayForm = New ToolStripMenuItem("Open App")
        mnuSep2 = New ToolStripSeparator()
        mnuWSL = New ToolStripMenuItem("Open WSL Default Distro")
        mnuLocalhost = New ToolStripMenuItem("Open http://localhost")
        mnuSep3 = New ToolStripSeparator()
        mnuStartApache = New ToolStripMenuItem("Start Apache")
        mnuStopApache = New ToolStripMenuItem("Stop Apache")
        mnuRestartApache = New ToolStripMenuItem("Restart Apache")
        mnuReloadApache = New ToolStripMenuItem("Reload Apache")
        mnuSep1 = New ToolStripSeparator()
        mnuExit = New ToolStripMenuItem("Exit")
        MainMenu = New ContextMenuStrip
        MainMenu.Items.AddRange(New ToolStripItem() {mnuDisplayForm, mnuSep2, mnuWSL, mnuLocalhost, mnuSep3, mnuStartApache, mnuStopApache, mnuRestartApache, mnuReloadApache, mnuSep1, mnuExit})

        'Initialize the tray
        Tray = New NotifyIcon
        Tray.Icon = My.Resources.TrayIcon
        Tray.ContextMenuStrip = MainMenu
        Tray.Text = "WSL Apache2 Backend Tray"

        'Display
        Tray.Visible = True
        Shell("wsl -u root exec -- sudo service apache2 restart")
    End Sub

#End Region

#Region " Event handlers "

    Private Sub AppContext_ThreadExit(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles Me.ThreadExit
        'Guarantees that the icon will not linger.
        Tray.Visible = False
    End Sub

    Private Sub mnuDisplayForm_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles mnuDisplayForm.Click
        ShowDialog()
    End Sub

    Private Sub mnuWSL_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuWSL.Click
        Shell("wsl")
    End Sub

    Private Sub mnuLocalhost_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuLocalhost.Click
        Shell("cmd /c start http://localhost")
    End Sub

    Private Sub mnuStopApache_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuStopApache.Click
        Shell("wsl -u root exec -- sudo service apache2 stop")
        ExitApplication()
    End Sub

    Private Sub mnuStartApache_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuStartApache.Click
        Shell("wsl -u root exec -- sudo service apache2 start")
    End Sub

    Private Sub mnuRestartApache_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRestartApache.Click
        Shell("wsl -u root exec -- sudo service apache2 restart")
    End Sub

    Private Sub mnuReloadApache_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuReloadApache.Click
        Shell("wsl -u root exec -- sudo service apache2 reload")
    End Sub

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles mnuExit.Click
        ExitApplication()
    End Sub

    Private Sub Tray_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles Tray.DoubleClick
        ShowDialog()
    End Sub

#End Region

End Class
