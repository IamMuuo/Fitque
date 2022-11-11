Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms

Public Class Form1
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        If Not Regex.IsMatch(txtUname.Texts, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase) Then
            MsgBox("Please enter a valid username", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub cmdSignUp_Click(sender As Object, e As EventArgs) Handles cmdSignUp.Click
        panSignUp.Visible = True
        panForm.Visible = False

    End Sub

    Private Sub cmdSignIn_Click(sender As Object, e As EventArgs) Handles cmdSignIn.Click
        panSignUp.Visible = False
        panForm.Visible = True
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        If Not Regex.IsMatch(txtEmail.Texts, "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase) Then
            MsgBox("Please enter a valid username", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub cmdFinish_Click(sender As Object, e As EventArgs) Handles cmdFinish.Click

        If Not txtPass.Texts = txtConfirm.Texts Then
            MsgBox("Please check your password and try agian!", MsgBoxStyle.Critical, "Form Validation Error")
        End If
    End Sub
End Class
