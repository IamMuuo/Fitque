Imports System.Data.OleDb
Imports System.Reflection.Emit
Imports System.Threading
Imports Guna.Charts.WinForms

Public Class Form2
    Dim second As Integer
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Erick\source\repos\Fitque\DB\GYM.accdb")
    Public Shared username As String
    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub Guna2GradientCircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton1.Click
        tabControl.SelectedIndex = 0
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
        workoutDescription.Visible = False
        cmdStartWorkout.Visible = False
        progressTimer.Visible = False
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

    Private Sub cmbWorkoutName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWorkoutName.SelectedIndexChanged
        workoutDescription.Visible = True
        Try
            con.Open()
            Dim cmd As New OleDbCommand("Select [Description] FROM Workout WHERE Workout_Name=?", con)
            cmd.Parameters.AddWithValue("@1", OleDb.OleDbType.VarChar).Value = cmbWorkoutName.SelectedItem

            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                workoutDescription.Text = dr(0)
            End While

            cmdStartWorkout.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cmdStartWorkout_Click(sender As Object, e As EventArgs) Handles cmdStartWorkout.Click
        progressTimer.Visible = True
        Timer1.Enabled = True
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If progressTimer.Value >= 100 Then
            Timer1.Stop()
            Try
                con.Open()
                Dim cmd As New OleDbCommand("SELECT Workout_ID FROM Workout WHERE Workout_Name=?", con)
                cmd.Parameters.AddWithValue("@1", OleDb.OleDbType.VarChar).Value = cmbWorkoutName.SelectedItem

                Dim i = cmd.ExecuteScalar

                cmd = New OleDbCommand("INSERT INTO Workouts ([Username], [Workout]) VALUES (?,?)", con)
                cmd.Parameters.AddWithValue("@1", OleDb.OleDbType.VarChar).Value = username
                cmd.Parameters.AddWithValue("@2", OleDb.OleDbType.VarChar).Value = i




                i = Convert.ToInt32(cmd.ExecuteNonQuery())

                If i > 0 Then
                    MsgBox("Workout logged successfully", MsgBoxStyle.Information, Title:="Success")
                Else
                    MsgBox("Something Went Wrong", MsgBoxStyle.Critical, "Internal Error")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
            Return
        End If

        progressTimer.Value += 1
    End Sub
    Private Sub panHome_VisibleChanged(sender As Object, e As EventArgs) Handles panHome.VisibleChanged
        Try
            con.Open()
            Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM WorkoutSummary WHERE  username=?", con)
            cmd.Parameters.AddWithValue("@1", OleDb.OleDbType.VarChar).Value = username

            Dim i = Convert.ToInt32(cmd.ExecuteScalar())

            If i > 0 Then
                progressWorkout.Value = (i) * 10
            Else
                MsgBox("Something Went Wrong", MsgBoxStyle.Critical, "Internal Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        MsgBox("Refreshed successfully", MsgBoxStyle.Information, "Fitque")
    End Sub

    Private Sub cmdDiet_Click(sender As Object, e As EventArgs)
        panHome.Visible = False
        panDiet.Visible = True
    End Sub

    Private Sub Guna2GradientCircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton2.Click
        tabControl.SelectedIndex = 0
    End Sub

    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        tabControl.SelectedIndex = 0
    End Sub

    Private Sub cmdContactTrainer_Click(sender As Object, e As EventArgs) Handles cmdContactTrainer.Click
        MsgBox("Trainer Contact Coming soon!", MsgBoxStyle.Information, "Fitque")
    End Sub

    Private Sub cmdToWorkout_Click(sender As Object, e As EventArgs) Handles cmdToWorkout.Click
        tabControl.SelectedIndex = 1
    End Sub

    Private Sub cmdToMeals_Click(sender As Object, e As EventArgs) Handles cmdToMeals.Click
        tabControl.SelectedIndex = 2
    End Sub

    Private Sub cmdToSettings_Click(sender As Object, e As EventArgs) Handles cmdToSettings.Click
        tabControl.SelectedIndex = 3
    End Sub
End Class