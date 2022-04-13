Public Class DumpedFrames

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub DumpedFrames_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.DumpFramesmusic, AudioPlayMode.Background)
    End Sub
End Class