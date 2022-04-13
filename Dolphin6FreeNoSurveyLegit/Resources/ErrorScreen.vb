Public Class ErrorScreen


    Private Sub ErrorScreen_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources._Error, AudioPlayMode.Background)
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class