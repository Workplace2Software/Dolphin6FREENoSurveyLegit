Public Class CataloniaOSPopUp

    Private Sub CataloniaOSPopUp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub CataloniaOSPopUp_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.Catalonia_Anthem, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Button1.BackColor = Color.Red
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Button1.BackColor = Color.Maroon
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        My.Computer.Audio.Play(My.Resources.Sesteronjes, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        My.Computer.Audio.Play(My.Resources.Catalonia_Anthem, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start("https://web.archive.org/web/20130126025329/http://repositorios.molinux.info/molinux/isos/Molinux_6.2_Merlin_DVD.iso")
        My.Computer.Audio.Play(My.Resources.Si, AudioPlayMode.WaitToComplete)
        Me.Close()
    End Sub
End Class