Public Class Form1
    Dim r As New Random()
    Dim myDate As Date = Date.Now
    Dim someMonth As Integer = 4

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        FPopUpAds.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If myDate.Month = someMonth Then
            HappyEaster.ShowDialog()
        End If
        My.Computer.Audio.Play(My.Resources.Welcome, AudioPlayMode.Background)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ErrorScreen.Show()
    End Sub


    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick, Label1.DoubleClick
        Explorer1.Show()
    End Sub

    Private Sub Form1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources._2000, AudioPlayMode.Background)
    End Sub

    Private Sub Form1_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        If r.Next(1, 15) = 7 Then
            CataloniaOSPopUp.ShowDialog()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click, Label1.DoubleClick
        Explorer1.ShowDialog()
    End Sub

    Private Sub DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DToolStripMenuItem.Click
        Process.Start("explorer")
    End Sub

    Private Sub AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AToolStripMenuItem.Click
        Process.Start("explorer")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.Play, AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub DumpAudioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DumpAudioToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.Dump_Audio, AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub DumpFramesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DumpFramesToolStripMenuItem.Click
        DumpedFrames.ShowDialog()
    End Sub

    Private Sub ShowLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowLogToolStripMenuItem.Click
        Process.Start("eventvwr")
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Try
            Process.Start("shell:::{2559a1f8-21d7-11d4-bdaf-00c04f60b9f0}")
        Catch ex As Exception
            ErrorScreen.ShowDialog()
        End Try
    End Sub

    Private Sub ConnectWiiWiiRemote1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectWiiWiiRemote1ToolStripMenuItem.Click, ConnectWiiWiiRemote2ToolStripMenuItem.Click, ConnectWiiWiiRemote3ToolStripMenuItem.Click, ConnectWiiWiiRemote4ToolStripMenuItem.Click, ConnectBalanceBoardToolStripMenuItem.Click
        Process.Start("shell:::{28803F59-3A75-4058-995F-4EE5503B023C}")
    End Sub

    Private Sub ResourcePackManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResourcePackManagerToolStripMenuItem.Click
        Process.Start("https://resourcepack.net/")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ErrorScreen.ShowDialog()
    End Sub

    Private Sub FIFOPlayerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FIFOPlayerToolStripMenuItem.Click
        Player.Show()
    End Sub

    Private Sub BootFromDVDBackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BootFromDVDBackupToolStripMenuItem.Click
        My.Computer.Audio.Stop()
        Process.Start("https://www.youtube.com/embed/RhEvsnGOYe4")
    End Sub

    Private Sub TASInputToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TASInputToolStripMenuItem.Click, HotkeySettingsToolStripMenuItem.Click
        Dim p As New ProcessStartInfo
        p.FileName = "main.cpl"
        p.Arguments = "keyboard"
        Process.Start(p)
    End Sub

    Private Sub ControllerSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControllerSettingsToolStripMenuItem.Click
        Process.Start("joy.cpl")
    End Sub

    Private Sub AudioSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AudioSettingsToolStripMenuItem.Click
        Process.Start("mmsys.cpl")
    End Sub

    Private Sub GraphicsSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GraphicsSettingsToolStripMenuItem.Click
        Process.Start("dxdiag")
    End Sub

    Private Sub ConfigurationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigurationToolStripMenuItem.Click
        Process.Start("control")
    End Sub

    Private Sub FreeLookSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FreeLookSettingsToolStripMenuItem.Click
        Process.Start("https://www.bing.com/search?q=Free+Look")
    End Sub

    Private Sub CheatsManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheatsManagerToolStripMenuItem.Click
        Try
            Process.Start("C:\Program Files\Cheat Engine 7.4\Cheat Engine.exe")
        Catch ex As Exception
            ErrorScreen.ShowDialog()
        End Try
    End Sub

    Private Sub InstallWADToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstallWADToolStripMenuItem.Click
        Explorer1.ShowDialog()
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click

    End Sub
End Class
