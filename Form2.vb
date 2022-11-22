Imports System.Data.OleDb

Public Class Form2
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Erick\source\repos\Fitque\DB\GYM.accdb")
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

    Private Sub Guna2GradientCircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton1.Click
        panSettings.Visible = False
        panHome.Visible = True
    End Sub

    Private Sub cmdChangePwd_Click(sender As Object, e As EventArgs) Handles cmdChangePwd.Click
        If txtConfPwd.Texts = Nothing And txtNewPwd.Texts = Nothing Then
            MsgBox("Passwords Cannot be empty", MsgBoxStyle.Critical, "Error")
            Return
        End If

        If Not txtNewPwd.Texts = txtConfPwd.Texts Then
            MsgBox("Passwords Don't Match.", MsgBoxStyle.Exclamation, "Mismatch Error")
            Return
        End If

        Try
            con.Open()
            Dim cmd As New OleDbCommand("UPDATE Members SET [Password]=? WHERE Email=?", con)
            cmd.Parameters.AddWithValue("@1", OleDb.OleDbType.VarChar).Value = txtNewPwd.Texts.Trim
            cmd.Parameters.AddWithValue("@2", OleDb.OleDbType.VarChar).Value = username



            Dim i = Convert.ToInt32(cmd.ExecuteNonQuery())

            If i > 0 Then
                MsgBox("Password Changed Successfully", MsgBoxStyle.Information, Title:="Success")
            Else
                MsgBox("Something Went Wrong", MsgBoxStyle.Critical, "Internal Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub panSettings_VisibleChanged(sender As Object, e As EventArgs) Handles panSettings.VisibleChanged
        lblEmail.Text = username
        Try
            con.Open()
            Dim cmd As New OleDbCommand("SELECT [First] From Members Where Email=?", con)
            cmd.Parameters.AddWithValue("@1", OleDb.OleDbType.VarChar).Value = username
            Dim i = cmd.ExecuteScalar

            lblFirst.Text = i

            cmd = New OleDbCommand("SELECT [Last] From Members Where Email=?", con)
            cmd.Parameters.AddWithValue("@1", OleDb.OleDbType.VarChar).Value = username
            i = cmd.ExecuteScalar
            lblLast.Text = i

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class