Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMessage.Text = "Initializing ..."
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If loadProgress.Value >= 100 Then
            Timer1.Stop()
            Me.Hide()
            Form1.Show()
            Return
        End If

        loadProgress.Value += 1
        progress2.Value += 1

        If loadProgress.Value > 20 And loadProgress.Value <= 25 Then
            lblMessage.Text = "Loading assets ..."
            Return
        End If

        If loadProgress.Value > 85 And loadProgress.Value <= 95 Then
            lblMessage.Text = "Getting ready ..."
            Return
        End If



    End Sub
End Class