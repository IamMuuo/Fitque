<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.panForm = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmdSignUp = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmdLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPwd = New Sipaa.Framework.STextBox()
        Me.txtUname = New Sipaa.Framework.STextBox()
        Me.panSignUp = New Guna.UI2.WinForms.Guna2Panel()
        Me.grpFinishing = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtConfirm = New Sipaa.Framework.STextBox()
        Me.txtPass = New Sipaa.Framework.STextBox()
        Me.grpContact = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtPhone = New Sipaa.Framework.STextBox()
        Me.txtEmail = New Sipaa.Framework.STextBox()
        Me.grpBioData = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cboWeight = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboHeight = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtOther = New Sipaa.Framework.STextBox()
        Me.txtLast = New Sipaa.Framework.STextBox()
        Me.txtFirst = New Sipaa.Framework.STextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmdSignIn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmdFinish = New Guna.UI2.WinForms.Guna2Button()
        Me.cmdClose = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.panForm.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panSignUp.SuspendLayout()
        Me.grpFinishing.SuspendLayout()
        Me.grpContact.SuspendLayout()
        Me.grpBioData.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_NEGATIVE
        Me.Guna2BorderlessForm1.BorderRadius = 12
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'panForm
        '
        Me.panForm.BackColor = System.Drawing.Color.White
        Me.panForm.BorderColor = System.Drawing.Color.Transparent
        Me.panForm.Controls.Add(Me.PictureBox1)
        Me.panForm.Controls.Add(Me.Guna2HtmlLabel2)
        Me.panForm.Controls.Add(Me.cmdSignUp)
        Me.panForm.Controls.Add(Me.Guna2HtmlLabel1)
        Me.panForm.Controls.Add(Me.cmdLogin)
        Me.panForm.Controls.Add(Me.txtPwd)
        Me.panForm.Controls.Add(Me.txtUname)
        Me.panForm.Location = New System.Drawing.Point(1, 0)
        Me.panForm.Name = "panForm"
        Me.panForm.Size = New System.Drawing.Size(306, 598)
        Me.panForm.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(68, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(17, 255)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(138, 27)
        Me.Guna2HtmlLabel2.TabIndex = 5
        Me.Guna2HtmlLabel2.Text = "Welcome Back!"
        '
        'cmdSignUp
        '
        Me.cmdSignUp.Animated = True
        Me.cmdSignUp.BorderRadius = 8
        Me.cmdSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdSignUp.FillColor = System.Drawing.Color.Salmon
        Me.cmdSignUp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdSignUp.ForeColor = System.Drawing.Color.White
        Me.cmdSignUp.HoverState.FillColor = System.Drawing.Color.Tomato
        Me.cmdSignUp.Location = New System.Drawing.Point(145, 543)
        Me.cmdSignUp.Name = "cmdSignUp"
        Me.cmdSignUp.ShadowDecoration.BorderRadius = 10
        Me.cmdSignUp.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.cmdSignUp.Size = New System.Drawing.Size(126, 45)
        Me.cmdSignUp.TabIndex = 3
        Me.cmdSignUp.Text = "Sign Up"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 70.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(13, 164)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(208, 85)
        Me.Guna2HtmlLabel1.TabIndex = 3
        Me.Guna2HtmlLabel1.Text = "Fitque"
        '
        'cmdLogin
        '
        Me.cmdLogin.Animated = True
        Me.cmdLogin.BorderRadius = 8
        Me.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdLogin.FillColor = System.Drawing.Color.CornflowerBlue
        Me.cmdLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdLogin.ForeColor = System.Drawing.Color.White
        Me.cmdLogin.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.cmdLogin.Location = New System.Drawing.Point(13, 542)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.ShadowDecoration.BorderRadius = 10
        Me.cmdLogin.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.cmdLogin.Size = New System.Drawing.Size(126, 45)
        Me.cmdLogin.TabIndex = 2
        Me.cmdLogin.Text = "Login"
        '
        'txtPwd
        '
        Me.txtPwd.BackColor = System.Drawing.SystemColors.Window
        Me.txtPwd.BorderColor = System.Drawing.Color.Lavender
        Me.txtPwd.BorderFocusColor = System.Drawing.Color.RoyalBlue
        Me.txtPwd.BorderRadius = 8
        Me.txtPwd.BorderSize = 2
        Me.txtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPwd.Location = New System.Drawing.Point(13, 397)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPwd.Multiline = False
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtPwd.PasswordChar = True
        Me.txtPwd.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtPwd.PlaceholderText = "Password"
        Me.txtPwd.Size = New System.Drawing.Size(250, 31)
        Me.txtPwd.TabIndex = 1
        Me.txtPwd.Texts = ""
        Me.txtPwd.UnderlinedStyle = False
        '
        'txtUname
        '
        Me.txtUname.BackColor = System.Drawing.SystemColors.Window
        Me.txtUname.BorderColor = System.Drawing.Color.Lavender
        Me.txtUname.BorderFocusColor = System.Drawing.Color.RoyalBlue
        Me.txtUname.BorderRadius = 8
        Me.txtUname.BorderSize = 2
        Me.txtUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUname.Location = New System.Drawing.Point(13, 341)
        Me.txtUname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUname.Multiline = False
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtUname.PasswordChar = False
        Me.txtUname.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtUname.PlaceholderText = "Username"
        Me.txtUname.Size = New System.Drawing.Size(250, 31)
        Me.txtUname.TabIndex = 0
        Me.txtUname.Texts = ""
        Me.txtUname.UnderlinedStyle = False
        '
        'panSignUp
        '
        Me.panSignUp.BackColor = System.Drawing.Color.White
        Me.panSignUp.BorderColor = System.Drawing.Color.Transparent
        Me.panSignUp.Controls.Add(Me.grpFinishing)
        Me.panSignUp.Controls.Add(Me.grpContact)
        Me.panSignUp.Controls.Add(Me.grpBioData)
        Me.panSignUp.Controls.Add(Me.Guna2HtmlLabel3)
        Me.panSignUp.Controls.Add(Me.cmdSignIn)
        Me.panSignUp.Controls.Add(Me.Guna2HtmlLabel4)
        Me.panSignUp.Controls.Add(Me.cmdFinish)
        Me.panSignUp.Location = New System.Drawing.Point(313, 0)
        Me.panSignUp.Name = "panSignUp"
        Me.panSignUp.Size = New System.Drawing.Size(541, 598)
        Me.panSignUp.TabIndex = 5
        Me.panSignUp.Visible = False
        '
        'grpFinishing
        '
        Me.grpFinishing.Controls.Add(Me.txtConfirm)
        Me.grpFinishing.Controls.Add(Me.txtPass)
        Me.grpFinishing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpFinishing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpFinishing.Location = New System.Drawing.Point(13, 438)
        Me.grpFinishing.Name = "grpFinishing"
        Me.grpFinishing.Size = New System.Drawing.Size(455, 99)
        Me.grpFinishing.TabIndex = 9
        Me.grpFinishing.Text = "Finishing Up"
        '
        'txtConfirm
        '
        Me.txtConfirm.BackColor = System.Drawing.SystemColors.Window
        Me.txtConfirm.BorderColor = System.Drawing.Color.Lavender
        Me.txtConfirm.BorderFocusColor = System.Drawing.Color.RoyalBlue
        Me.txtConfirm.BorderRadius = 8
        Me.txtConfirm.BorderSize = 2
        Me.txtConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtConfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtConfirm.Location = New System.Drawing.Point(254, 47)
        Me.txtConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirm.Multiline = False
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtConfirm.PasswordChar = True
        Me.txtConfirm.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtConfirm.PlaceholderText = "Confirm Password"
        Me.txtConfirm.Size = New System.Drawing.Size(180, 31)
        Me.txtConfirm.TabIndex = 3
        Me.txtConfirm.Texts = ""
        Me.txtConfirm.UnderlinedStyle = False
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.SystemColors.Window
        Me.txtPass.BorderColor = System.Drawing.Color.Lavender
        Me.txtPass.BorderFocusColor = System.Drawing.Color.RoyalBlue
        Me.txtPass.BorderRadius = 8
        Me.txtPass.BorderSize = 2
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPass.Location = New System.Drawing.Point(11, 47)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Multiline = False
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtPass.PasswordChar = True
        Me.txtPass.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtPass.PlaceholderText = "New Password"
        Me.txtPass.Size = New System.Drawing.Size(180, 31)
        Me.txtPass.TabIndex = 4
        Me.txtPass.Texts = ""
        Me.txtPass.UnderlinedStyle = False
        '
        'grpContact
        '
        Me.grpContact.Controls.Add(Me.txtPhone)
        Me.grpContact.Controls.Add(Me.txtEmail)
        Me.grpContact.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpContact.Location = New System.Drawing.Point(13, 327)
        Me.grpContact.Name = "grpContact"
        Me.grpContact.Size = New System.Drawing.Size(455, 100)
        Me.grpContact.TabIndex = 8
        Me.grpContact.Text = "Contact Information"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhone.BorderColor = System.Drawing.Color.Lavender
        Me.txtPhone.BorderFocusColor = System.Drawing.Color.RoyalBlue
        Me.txtPhone.BorderRadius = 8
        Me.txtPhone.BorderSize = 2
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPhone.Location = New System.Drawing.Point(243, 59)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.Multiline = False
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtPhone.PasswordChar = False
        Me.txtPhone.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtPhone.PlaceholderText = "Phone Number"
        Me.txtPhone.Size = New System.Drawing.Size(205, 31)
        Me.txtPhone.TabIndex = 2
        Me.txtPhone.Texts = ""
        Me.txtPhone.UnderlinedStyle = False
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.BorderColor = System.Drawing.Color.Lavender
        Me.txtEmail.BorderFocusColor = System.Drawing.Color.RoyalBlue
        Me.txtEmail.BorderRadius = 8
        Me.txtEmail.BorderSize = 2
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(11, 59)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Multiline = False
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtEmail.PasswordChar = False
        Me.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtEmail.PlaceholderText = "Email"
        Me.txtEmail.Size = New System.Drawing.Size(180, 31)
        Me.txtEmail.TabIndex = 1
        Me.txtEmail.Texts = ""
        Me.txtEmail.UnderlinedStyle = False
        '
        'grpBioData
        '
        Me.grpBioData.BorderColor = System.Drawing.Color.Silver
        Me.grpBioData.Controls.Add(Me.cboWeight)
        Me.grpBioData.Controls.Add(Me.cboHeight)
        Me.grpBioData.Controls.Add(Me.cboGender)
        Me.grpBioData.Controls.Add(Me.txtOther)
        Me.grpBioData.Controls.Add(Me.txtLast)
        Me.grpBioData.Controls.Add(Me.txtFirst)
        Me.grpBioData.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpBioData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grpBioData.Location = New System.Drawing.Point(13, 133)
        Me.grpBioData.Name = "grpBioData"
        Me.grpBioData.Size = New System.Drawing.Size(455, 172)
        Me.grpBioData.TabIndex = 7
        Me.grpBioData.Text = "BioData"
        '
        'cboWeight
        '
        Me.cboWeight.BackColor = System.Drawing.Color.Transparent
        Me.cboWeight.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboWeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWeight.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboWeight.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboWeight.IntegralHeight = False
        Me.cboWeight.ItemHeight = 25
        Me.cboWeight.Items.AddRange(New Object() {"Weight", "30", "50", "70", "90", "100", "110", "120", "150"})
        Me.cboWeight.Location = New System.Drawing.Point(326, 112)
        Me.cboWeight.Name = "cboWeight"
        Me.cboWeight.Size = New System.Drawing.Size(122, 31)
        Me.cboWeight.StartIndex = 0
        Me.cboWeight.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cboWeight.TabIndex = 5
        '
        'cboHeight
        '
        Me.cboHeight.BackColor = System.Drawing.Color.Transparent
        Me.cboHeight.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHeight.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboHeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboHeight.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboHeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboHeight.IntegralHeight = False
        Me.cboHeight.ItemHeight = 25
        Me.cboHeight.Items.AddRange(New Object() {"Height", "1.0", "1.5", "1.8", "2.0", "2.2", "2.4"})
        Me.cboHeight.Location = New System.Drawing.Point(179, 112)
        Me.cboHeight.Name = "cboHeight"
        Me.cboHeight.Size = New System.Drawing.Size(125, 31)
        Me.cboHeight.StartIndex = 0
        Me.cboHeight.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cboHeight.TabIndex = 4
        '
        'cboGender
        '
        Me.cboGender.BackColor = System.Drawing.Color.Transparent
        Me.cboGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboGender.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboGender.IntegralHeight = False
        Me.cboGender.ItemHeight = 25
        Me.cboGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cboGender.Location = New System.Drawing.Point(12, 112)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(140, 31)
        Me.cboGender.StartIndex = 0
        Me.cboGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cboGender.TabIndex = 3
        '
        'txtOther
        '
        Me.txtOther.BackColor = System.Drawing.SystemColors.Window
        Me.txtOther.BorderColor = System.Drawing.Color.Lavender
        Me.txtOther.BorderFocusColor = System.Drawing.Color.RoyalBlue
        Me.txtOther.BorderRadius = 8
        Me.txtOther.BorderSize = 2
        Me.txtOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtOther.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOther.Location = New System.Drawing.Point(160, 60)
        Me.txtOther.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOther.Multiline = False
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtOther.PasswordChar = False
        Me.txtOther.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtOther.PlaceholderText = "Other Name"
        Me.txtOther.Size = New System.Drawing.Size(144, 31)
        Me.txtOther.TabIndex = 2
        Me.txtOther.Texts = ""
        Me.txtOther.UnderlinedStyle = False
        '
        'txtLast
        '
        Me.txtLast.BackColor = System.Drawing.SystemColors.Window
        Me.txtLast.BorderColor = System.Drawing.Color.Lavender
        Me.txtLast.BorderFocusColor = System.Drawing.Color.RoyalBlue
        Me.txtLast.BorderRadius = 8
        Me.txtLast.BorderSize = 2
        Me.txtLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLast.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLast.Location = New System.Drawing.Point(312, 60)
        Me.txtLast.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLast.Multiline = False
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtLast.PasswordChar = False
        Me.txtLast.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtLast.PlaceholderText = "Last Name"
        Me.txtLast.Size = New System.Drawing.Size(136, 31)
        Me.txtLast.TabIndex = 1
        Me.txtLast.Texts = ""
        Me.txtLast.UnderlinedStyle = False
        '
        'txtFirst
        '
        Me.txtFirst.BackColor = System.Drawing.SystemColors.Window
        Me.txtFirst.BorderColor = System.Drawing.Color.Lavender
        Me.txtFirst.BorderFocusColor = System.Drawing.Color.RoyalBlue
        Me.txtFirst.BorderRadius = 8
        Me.txtFirst.BorderSize = 2
        Me.txtFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFirst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFirst.Location = New System.Drawing.Point(11, 60)
        Me.txtFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirst.Multiline = False
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtFirst.PasswordChar = False
        Me.txtFirst.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtFirst.PlaceholderText = "First name"
        Me.txtFirst.Size = New System.Drawing.Size(141, 31)
        Me.txtFirst.TabIndex = 0
        Me.txtFirst.Texts = ""
        Me.txtFirst.UnderlinedStyle = False
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(3, 85)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(183, 27)
        Me.Guna2HtmlLabel3.TabIndex = 5
        Me.Guna2HtmlLabel3.Text = "Lets get you sorted.."
        '
        'cmdSignIn
        '
        Me.cmdSignIn.Animated = True
        Me.cmdSignIn.BorderRadius = 8
        Me.cmdSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdSignIn.FillColor = System.Drawing.Color.Salmon
        Me.cmdSignIn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmdSignIn.ForeColor = System.Drawing.Color.White
        Me.cmdSignIn.HoverState.FillColor = System.Drawing.Color.Tomato
        Me.cmdSignIn.Location = New System.Drawing.Point(145, 543)
        Me.cmdSignIn.Name = "cmdSignIn"
        Me.cmdSignIn.ShadowDecoration.BorderRadius = 10
        Me.cmdSignIn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.cmdSignIn.Size = New System.Drawing.Size(126, 45)
        Me.cmdSignIn.TabIndex = 3
        Me.cmdSignIn.Text = "Bck to login"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Century Gothic", 55.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(3, 11)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(162, 68)
        Me.Guna2HtmlLabel4.TabIndex = 3
        Me.Guna2HtmlLabel4.Text = "Fitque"
        '
        'cmdFinish
        '
        Me.cmdFinish.Animated = True
        Me.cmdFinish.BorderRadius = 8
        Me.cmdFinish.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdFinish.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdFinish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdFinish.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdFinish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdFinish.FillColor = System.Drawing.Color.CornflowerBlue
        Me.cmdFinish.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmdFinish.ForeColor = System.Drawing.Color.White
        Me.cmdFinish.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.cmdFinish.Location = New System.Drawing.Point(13, 542)
        Me.cmdFinish.Name = "cmdFinish"
        Me.cmdFinish.ShadowDecoration.BorderRadius = 10
        Me.cmdFinish.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.cmdFinish.Size = New System.Drawing.Size(126, 45)
        Me.cmdFinish.TabIndex = 2
        Me.cmdFinish.Text = "Get Started"
        '
        'cmdClose
        '
        Me.cmdClose.Animated = True
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdClose.FillColor = System.Drawing.Color.IndianRed
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.HoverState.FillColor = System.Drawing.Color.Firebrick
        Me.cmdClose.Location = New System.Drawing.Point(748, 12)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdClose.Size = New System.Drawing.Size(40, 40)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "x"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.panSignUp)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.panForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.panForm.ResumeLayout(False)
        Me.panForm.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panSignUp.ResumeLayout(False)
        Me.panSignUp.PerformLayout()
        Me.grpFinishing.ResumeLayout(False)
        Me.grpContact.ResumeLayout(False)
        Me.grpBioData.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents panForm As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtPwd As Sipaa.Framework.STextBox
    Friend WithEvents txtUname As Sipaa.Framework.STextBox
    Friend WithEvents cmdLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmdSignUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmdClose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents panSignUp As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmdSignIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmdFinish As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtFirst As Sipaa.Framework.STextBox
    Friend WithEvents grpBioData As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtOther As Sipaa.Framework.STextBox
    Friend WithEvents txtLast As Sipaa.Framework.STextBox
    Friend WithEvents cboGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboWeight As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboHeight As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents grpFinishing As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtConfirm As Sipaa.Framework.STextBox
    Friend WithEvents txtPass As Sipaa.Framework.STextBox
    Friend WithEvents grpContact As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtPhone As Sipaa.Framework.STextBox
    Friend WithEvents txtEmail As Sipaa.Framework.STextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
