Imports System.Data.OleDb
Imports Guna.Charts.WinForms

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

    Private Sub conBreakfast_VisibleChanged(sender As Object, e As EventArgs) Handles conBreakfast.VisibleChanged
        '' Update the reccomemded diet
        Try
            con.Open()
            Dim cmd As New OleDbCommand("SELECT [Food] From Diet Where Category=?", con)
            cmd.Parameters.AddWithValue("@1", OleDb.OleDbType.VarChar).Value = "Breakfast"
            Dim i = cmd.ExecuteScalar

            lblBreakfast.Text = i

            cmd = New OleDbCommand("SELECT [Food] From Diet Where Category=?", con)
            cmd.Parameters.AddWithValue("@1", OleDb.OleDbType.VarChar).Value = "Lunch"
            i = cmd.ExecuteScalar
            lblLunch.Text = i

            cmd = New OleDbCommand("SELECT [Food] From Diet Where Category=?", con)
            cmd.Parameters.AddWithValue("@1", OleDb.OleDbType.VarChar).Value = "Supper"
            i = cmd.ExecuteScalar
            lblSupper.Text = i

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub workouts_VisibleChanged(sender As Object, e As EventArgs) Handles workouts.VisibleChanged
        con.Open()
        Dim cmd As New OleDbCommand("Select [Workout_Name], [Workout_Type], [When] FROM WorkoutSummary WHERE username=? ORDER BY [When] DESC", con)
        cmd.Parameters.AddWithValue("@1", OleDb.OleDbType.VarChar).Value = username

        Dim da = New OleDbDataAdapter(cmd)
        Dim t = New DataTable
        da.Fill(t)
        grid.DataSource = t


        con.Close()

    End Sub

    Private Sub cmbWorkoutType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWorkoutType.SelectedIndexChanged
        cmbWorkoutName.Items.Clear()
        cmbWorkoutName.Items.Add("Select Workout")

        Try
            con.Open()
            Dim cmd As New OleDbCommand("Select [Workout_Name] FROM Workout WHERE Workout_Type=?", con)
            cmd.Parameters.AddWithValue("@1", OleDb.OleDbType.VarChar).Value = cmbWorkoutType.SelectedItem.ToString

            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                cmbWorkoutName.Items.Add(dr(0).ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class