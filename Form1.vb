Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms
Imports System.Data.OleDb


Public Class Form1
    'Dim connection As New OleDb.oDBConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Erick\source\repos\Fitque\DB\GYM.accdb")
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

        ElseIf Not txtPass.Texts.Equals(txtConfirm.Texts) Then
            MsgBox("Please check your password and try agian!", MsgBoxStyle.Critical, "Form Validation Error")

        ElseIf cboHeight.Text = "Height" Then
            MsgBox("Please enter your height to continue", )


        ElseIf cboWeight.Text = "Weight" Then
            MsgBox("Please enter your weight to continue", MsgBoxStyle.Critical, "Form validation error")

        ElseIf Not Regex.IsMatch(txtEmail.Texts, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase) Then
            MsgBox("Please enter a valid username", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
