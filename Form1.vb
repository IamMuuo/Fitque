Imports System.Configuration
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms
Public Class Form1
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Erick\source\repos\Fitque\DB\GYM.accdb")

    Private Sub CmClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        If Not Regex.IsMatch(txtUname.Texts, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase) Then
            MsgBox("Please enter a valid username", MsgBoxStyle.Critical)

        Else

            '' query info from the database and authenticate

            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub CmdSignUp_Click(sender As Object, e As EventArgs) Handles cmdSignUp.Click
        panSignUp.Visible = True
        panForm.Visible = False

    End Sub

    Private Sub CmdSignIn_Click(sender As Object, e As EventArgs) Handles cmdSignIn.Click
        panSignUp.Visible = False
        panForm.Visible = True
    End Sub

    Private Sub CmdFinish_Click(sender As Object, e As EventArgs) Handles cmdFinish.Click
        If String.IsNullOrEmpty(txtFirst.Texts.Trim) Or String.IsNullOrEmpty(txtLast.Texts) Then
            MsgBox("Please confirm your first name and try again", MsgBoxStyle.Critical, "Form Validation Error")
            Return
        ElseIf Not txtPass.Texts.Equals(txtConfirm.Texts) Then
            MsgBox("Please check your password and try agian!", MsgBoxStyle.Critical, "Form Validation Error")
            Return
        ElseIf cboHeight.Text = "Height" Then
            MsgBox("Please enter your height to continue", )
            Return

        ElseIf cboWeight.Text = "Weight" Then
            MsgBox("Please enter your weight to continue", MsgBoxStyle.Critical, "Form validation error")
            Return

        ElseIf Not Regex.IsMatch(txtEmail.Texts, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase) Then
            MsgBox("Please enter a valid username", MsgBoxStyle.Critical)
        End If

        'Try
        Dim sql As String
        sql = "INSERT INTO Members ([First], [Other], [Last], [Gender], [Height],[Weight], [Email], [Phone], [Password]) values('" & txtFirst.Texts.Trim & "','" & txtOther.Texts.Trim & "', '" & txtLast.Texts.Trim & "','" & cboGender.Text & "', '" & cboHeight.Text & "', '" & cboWeight.Text & "','" & txtEmail.Texts.Trim() & "', '" & txtPhone.Texts.Trim & "', '" & txtPass.Texts.Trim & "');"

        Dim cmd As New OleDbCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = sql

            Dim i = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Youre now a registered member!", Title:="Success")
            Else
                MsgBox("Couldn't register you, please check your details and try again", Title:="Registration Error")
            End If
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'Finally
        con.Close()
        'End Try
    End Sub
End Class