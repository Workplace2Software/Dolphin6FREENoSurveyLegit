Public Class FPopUpAds

    Private Sub FPopUpAds_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
        End
    End Sub


    Private Sub FPopUpAds_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Ad, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button1.Click
        My.Computer.Audio.Play(My.Resources._2000, AudioPlayMode.WaitToComplete)
        Application.Exit()
        End
    End Sub
End Class