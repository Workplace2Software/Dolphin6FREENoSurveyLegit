Public Class Player
    Dim r As New Random()

    Private Sub Player_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Stop()
        ErrorScreen.ShowDialog()
    End Sub
    Private Sub Player_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Emulation, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        My.Computer.Audio.Play(My.Resources.Emulation, AudioPlayMode.Background)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Select Case r.Next(1, 4)
            Case 1
                Me.Text = "Dolphin 6 FREE No Survey Legit | JIT64 DC | Null | HLE | FPS: 60 - VPS: 60 - 100% | Ronaldinhio Soccer 64"
            Case 2
                Me.Text = "Dolphin 6 FREE No Survey Legit | JIT64 DC | Null | HLE | FPS: 60 - VPS: 60 - 0% | Ronaldinhio Soccer 64"
            Case 3
                Me.Text = "Dolphin 6 FREE No Survey Legit | JIT64 DC | Null | HLE | FPS: 60 - VPS: 60 - 97% | Ronaldinhio Soccer 64"
        End Select
    End Sub

    Private Sub Player_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Select Case r.Next(1, 3)
            Case 1
                Timer1.Start()
            Case 2
                Me.Close()
        End Select
    End Sub
End Class