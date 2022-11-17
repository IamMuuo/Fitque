<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.cmdClose = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.lblBanner = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmdDashBoard = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.cmdWorkOut = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.cmdDiet = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.cmdSettings = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.panHome = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.Guna2ContainerControl4 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.Guna2ContainerControl2 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.Guna2ContainerControl1 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.Guna2ContainerControl3 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.panHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 12
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'cmdClose
        '
        Me.cmdClose.Animated = True
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "x"
        '
        'lblBanner
        '
        Me.lblBanner.BackColor = System.Drawing.Color.Transparent
        Me.lblBanner.Font = New System.Drawing.Font("Century Gothic", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblBanner.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBanner.Location = New System.Drawing.Point(12, 12)
        Me.lblBanner.Name = "lblBanner"
        Me.lblBanner.Size = New System.Drawing.Size(104, 43)
        Me.lblBanner.TabIndex = 6
        Me.lblBanner.Text = "Fitque"
        '
        'cmdDashBoard
        '
        Me.cmdDashBoard.Animated = True
        Me.cmdDashBoard.BackColor = System.Drawing.Color.Transparent
        Me.cmdDashBoard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDashBoard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdDashBoard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdDashBoard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdDashBoard.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdDashBoard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdDashBoard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdDashBoard.ForeColor = System.Drawing.Color.White
        Me.cmdDashBoard.HoverState.FillColor = System.Drawing.Color.CadetBlue
        Me.cmdDashBoard.HoverState.FillColor2 = System.Drawing.Color.Firebrick
        Me.cmdDashBoard.Image = CType(resources.GetObject("cmdDashBoard.Image"), System.Drawing.Image)
        Me.cmdDashBoard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cmdDashBoard.ImageSize = New System.Drawing.Size(50, 50)
        Me.cmdDashBoard.Location = New System.Drawing.Point(12, 172)
        Me.cmdDashBoard.Name = "cmdDashBoard"
        Me.cmdDashBoard.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdDashBoard.Size = New System.Drawing.Size(60, 60)
        Me.cmdDashBoard.TabIndex = 8
        '
        'cmdWorkOut
        '
        Me.cmdWorkOut.Animated = True
        Me.cmdWorkOut.BackColor = System.Drawing.Color.Transparent
        Me.cmdWorkOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdWorkOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdWorkOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdWorkOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdWorkOut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdWorkOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdWorkOut.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdWorkOut.ForeColor = System.Drawing.Color.White
        Me.cmdWorkOut.HoverState.FillColor = System.Drawing.Color.CadetBlue
        Me.cmdWorkOut.HoverState.FillColor2 = System.Drawing.Color.Firebrick
        Me.cmdWorkOut.Image = CType(resources.GetObject("cmdWorkOut.Image"), System.Drawing.Image)
        Me.cmdWorkOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cmdWorkOut.ImageSize = New System.Drawing.Size(50, 50)
        Me.cmdWorkOut.Location = New System.Drawing.Point(12, 238)
        Me.cmdWorkOut.Name = "cmdWorkOut"
        Me.cmdWorkOut.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdWorkOut.Size = New System.Drawing.Size(60, 60)
        Me.cmdWorkOut.TabIndex = 9
        '
        'cmdDiet
        '
        Me.cmdDiet.Animated = True
        Me.cmdDiet.BackColor = System.Drawing.Color.Transparent
        Me.cmdDiet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdDiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdDiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdDiet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdDiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdDiet.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdDiet.ForeColor = System.Drawing.Color.White
        Me.cmdDiet.HoverState.FillColor = System.Drawing.Color.CadetBlue
        Me.cmdDiet.HoverState.FillColor2 = System.Drawing.Color.Firebrick
        Me.cmdDiet.Image = CType(resources.GetObject("cmdDiet.Image"), System.Drawing.Image)
        Me.cmdDiet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cmdDiet.ImageSize = New System.Drawing.Size(50, 50)
        Me.cmdDiet.Location = New System.Drawing.Point(12, 304)
        Me.cmdDiet.Name = "cmdDiet"
        Me.cmdDiet.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdDiet.Size = New System.Drawing.Size(60, 60)
        Me.cmdDiet.TabIndex = 10
        '
        'cmdSettings
        '
        Me.cmdSettings.Animated = True
        Me.cmdSettings.BackColor = System.Drawing.Color.Transparent
        Me.cmdSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdSettings.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdSettings.ForeColor = System.Drawing.Color.White
        Me.cmdSettings.HoverState.FillColor = System.Drawing.Color.CadetBlue
        Me.cmdSettings.HoverState.FillColor2 = System.Drawing.Color.Firebrick
        Me.cmdSettings.Image = CType(resources.GetObject("cmdSettings.Image"), System.Drawing.Image)
        Me.cmdSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cmdSettings.ImageSize = New System.Drawing.Size(50, 50)
        Me.cmdSettings.Location = New System.Drawing.Point(12, 370)
        Me.cmdSettings.Name = "cmdSettings"
        Me.cmdSettings.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdSettings.Size = New System.Drawing.Size(60, 60)
        Me.cmdSettings.TabIndex = 11
        '
        'panHome
        '
        Me.panHome.BackColor = System.Drawing.Color.DarkSlateGray
        Me.panHome.Controls.Add(Me.Guna2ContainerControl4)
        Me.panHome.Controls.Add(Me.Guna2ContainerControl2)
        Me.panHome.Controls.Add(Me.Guna2ContainerControl1)
        Me.panHome.Controls.Add(Me.Guna2ContainerControl3)
        Me.panHome.FillColor = System.Drawing.Color.Transparent
        Me.panHome.Location = New System.Drawing.Point(78, 61)
        Me.panHome.Name = "panHome"
        Me.panHome.Size = New System.Drawing.Size(710, 527)
        Me.panHome.TabIndex = 12
        '
        'Guna2ContainerControl4
        '
        Me.Guna2ContainerControl4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ContainerControl4.BorderRadius = 10
        Me.Guna2ContainerControl4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ContainerControl4.FillColor = System.Drawing.Color.Coral
        Me.Guna2ContainerControl4.Location = New System.Drawing.Point(485, 268)
        Me.Guna2ContainerControl4.Name = "Guna2ContainerControl4"
        Me.Guna2ContainerControl4.ShadowDecoration.BorderRadius = 10
        Me.Guna2ContainerControl4.ShadowDecoration.Depth = 20
        Me.Guna2ContainerControl4.ShadowDecoration.Enabled = True
        Me.Guna2ContainerControl4.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, -5, 20, 10)
        Me.Guna2ContainerControl4.Size = New System.Drawing.Size(182, 241)
        Me.Guna2ContainerControl4.TabIndex = 6
        '
        'Guna2ContainerControl2
        '
        Me.Guna2ContainerControl2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ContainerControl2.BorderRadius = 10
        Me.Guna2ContainerControl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ContainerControl2.FillColor = System.Drawing.Color.CadetBlue
        Me.Guna2ContainerControl2.Location = New System.Drawing.Point(271, 268)
        Me.Guna2ContainerControl2.Name = "Guna2ContainerControl2"
        Me.Guna2ContainerControl2.ShadowDecoration.BorderRadius = 10
        Me.Guna2ContainerControl2.ShadowDecoration.Depth = 20
        Me.Guna2ContainerControl2.ShadowDecoration.Enabled = True
        Me.Guna2ContainerControl2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, -5, 20, 10)
        Me.Guna2ContainerControl2.Size = New System.Drawing.Size(182, 241)
        Me.Guna2ContainerControl2.TabIndex = 5
        '
        'Guna2ContainerControl1
        '
        Me.Guna2ContainerControl1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ContainerControl1.BorderRadius = 10
        Me.Guna2ContainerControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ContainerControl1.FillColor = System.Drawing.Color.PaleVioletRed
        Me.Guna2ContainerControl1.Location = New System.Drawing.Point(55, 268)
        Me.Guna2ContainerControl1.Name = "Guna2ContainerControl1"
        Me.Guna2ContainerControl1.ShadowDecoration.BorderRadius = 10
        Me.Guna2ContainerControl1.ShadowDecoration.Depth = 20
        Me.Guna2ContainerControl1.ShadowDecoration.Enabled = True
        Me.Guna2ContainerControl1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, -5, 20, 10)
        Me.Guna2ContainerControl1.Size = New System.Drawing.Size(182, 241)
        Me.Guna2ContainerControl1.TabIndex = 4
        '
        'Guna2ContainerControl3
        '
        Me.Guna2ContainerControl3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ContainerControl3.BorderRadius = 10
        Me.Guna2ContainerControl3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ContainerControl3.FillColor = System.Drawing.Color.Tan
        Me.Guna2ContainerControl3.Location = New System.Drawing.Point(55, 3)
        Me.Guna2ContainerControl3.Name = "Guna2ContainerControl3"
        Me.Guna2ContainerControl3.ShadowDecoration.BorderRadius = 10
        Me.Guna2ContainerControl3.ShadowDecoration.Depth = 20
        Me.Guna2ContainerControl3.ShadowDecoration.Enabled = True
        Me.Guna2ContainerControl3.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, -5, 30, 10)
        Me.Guna2ContainerControl3.Size = New System.Drawing.Size(612, 241)
        Me.Guna2ContainerControl3.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.panHome)
        Me.Controls.Add(Me.cmdSettings)
        Me.Controls.Add(Me.cmdDiet)
        Me.Controls.Add(Me.cmdWorkOut)
        Me.Controls.Add(Me.cmdDashBoard)
        Me.Controls.Add(Me.lblBanner)
        Me.Controls.Add(Me.cmdClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fitque | Dashboard"
        Me.panHome.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents cmdClose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents lblBanner As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmdSettings As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents cmdDiet As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents cmdWorkOut As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents cmdDashBoard As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents panHome As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents Guna2ContainerControl4 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents Guna2ContainerControl2 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents Guna2ContainerControl1 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents Guna2ContainerControl3 As Guna.UI2.WinForms.Guna2ContainerControl
End Class
