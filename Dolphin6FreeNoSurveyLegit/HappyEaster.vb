Public Class HappyEaster

    Private Sub HappyEaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.HappyEaster, AudioPlayMode.Background)
    End Sub
End Class