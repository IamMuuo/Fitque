<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.loadProgress = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.progress2 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblLogo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationInterval = 1000
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE
        Me.Guna2BorderlessForm1.BorderRadius = 12
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'loadProgress
        '
        Me.loadProgress.Animated = True
        Me.loadProgress.AnimationSpeed = 0.7!
        Me.loadProgress.BackColor = System.Drawing.Color.Transparent
        Me.loadProgress.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.loadProgress.FillThickness = 10
        Me.loadProgress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.loadProgress.ForeColor = System.Drawing.Color.Transparent
        Me.loadProgress.Location = New System.Drawing.Point(598, 348)
        Me.loadProgress.Minimum = 0
        Me.loadProgress.Name = "loadProgress"
        Me.loadProgress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.loadProgress.ProgressColor2 = System.Drawing.Color.Red
        Me.loadProgress.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.loadProgress.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.loadProgress.ProgressThickness = 10
        Me.loadProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.loadProgress.Size = New System.Drawing.Size(90, 90)
        Me.loadProgress.TabIndex = 2
        Me.loadProgress.Text = "Guna2CircleProgressBar1"
        Me.loadProgress.Value = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'progress2
        '
        Me.progress2.Animated = True
        Me.progress2.AnimationSpeed = 0.9!
        Me.progress2.BackColor = System.Drawing.Color.Transparent
        Me.progress2.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.progress2.FillThickness = 10
        Me.progress2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.progress2.ForeColor = System.Drawing.Color.Transparent
        Me.progress2.Location = New System.Drawing.Point(33, 348)
        Me.progress2.Minimum = 0
        Me.progress2.Name = "progress2"
        Me.progress2.ProgressColor = System.Drawing.Color.Tomato
        Me.progress2.ProgressColor2 = System.Drawing.Color.OrangeRed
        Me.progress2.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round
        Me.progress2.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round
        Me.progress2.ProgressThickness = 10
        Me.progress2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.progress2.Size = New System.Drawing.Size(90, 90)
        Me.progress2.TabIndex = 3
        Me.progress2.Text = "Guna2CircleProgressBar1"
        Me.progress2.Value = 1
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(279, 402)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(40, 15)
        Me.lblMessage.TabIndex = 4
        Me.lblMessage.Text = "Fitque"
        '
        'lblLogo
        '
        Me.lblLogo.BackColor = System.Drawing.Color.Transparent
        Me.lblLogo.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLogo.ForeColor = System.Drawing.Color.White
        Me.lblLogo.Location = New System.Drawing.Point(12, 12)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(112, 52)
        Me.lblLogo.TabIndex = 5
        Me.lblLogo.Text = "Fitque"
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.progress2)
        Me.Controls.Add(Me.loadProgress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(700, 450)
        Me.MinimumSize = New System.Drawing.Size(700, 450)
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents loadProgress As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents lblMessage As Label
    Friend WithEvents progress2 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents lblLogo As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
