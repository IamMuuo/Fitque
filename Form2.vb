Public Class Form2
    Public Shared username As String
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub cmdDashBoard_Click(sender As Object, e As EventArgs) Handles cmdDashBoard.Click
        panHome.Visible = True
    End Sub

    Private Sub cmdSettings_Click(sender As Object, e As EventArgs) Handles cmdSettings.Click
        panSettings.Visible = True
        panHome.Visible = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        panHome.Visible = True
        panSettings.Visible = False
    End Sub
End Class