<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtContador = New System.Windows.Forms.Label()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaGradientTileButton1 = New Guna.UI.WinForms.GunaGradientTileButton()
        Me.btn_acessar = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ProgressBar2 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Guna2ImageCheckBox1 = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_login = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'txtContador
        '
        Me.txtContador.AutoSize = True
        Me.txtContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContador.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtContador.Location = New System.Drawing.Point(141, 380)
        Me.txtContador.Name = "txtContador"
        Me.txtContador.Size = New System.Drawing.Size(16, 13)
        Me.txtContador.TabIndex = 7
        Me.txtContador.Text = "%"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(56, 52)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(186, 19)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "Informe seu usuário e senha!"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 15
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.BackColor = System.Drawing.Color.DarkBlue
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(256, 6)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.RoyalBlue
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(32, 22)
        Me.GunaControlBox1.TabIndex = 3
        '
        'GunaGradientTileButton1
        '
        Me.GunaGradientTileButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientTileButton1.AnimationSpeed = 0.03!
        Me.GunaGradientTileButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientTileButton1.BaseColor1 = System.Drawing.Color.DarkBlue
        Me.GunaGradientTileButton1.BaseColor2 = System.Drawing.Color.DarkBlue
        Me.GunaGradientTileButton1.BorderColor = System.Drawing.Color.Transparent
        Me.GunaGradientTileButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientTileButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientTileButton1.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GunaGradientTileButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientTileButton1.Image = Nothing
        Me.GunaGradientTileButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaGradientTileButton1.Location = New System.Drawing.Point(-8, 0)
        Me.GunaGradientTileButton1.Name = "GunaGradientTileButton1"
        Me.GunaGradientTileButton1.OnHoverBaseColor1 = System.Drawing.Color.DarkBlue
        Me.GunaGradientTileButton1.OnHoverBaseColor2 = System.Drawing.Color.DarkBlue
        Me.GunaGradientTileButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientTileButton1.OnHoverImage = Nothing
        Me.GunaGradientTileButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientTileButton1.Size = New System.Drawing.Size(312, 37)
        Me.GunaGradientTileButton1.TabIndex = 5
        Me.GunaGradientTileButton1.Text = "Seja bem vindo"
        '
        'btn_acessar
        '
        Me.btn_acessar.Animated = True
        Me.btn_acessar.AutoRoundedCorners = True
        Me.btn_acessar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_acessar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btn_acessar.BorderRadius = 15
        Me.btn_acessar.BorderThickness = 1
        Me.btn_acessar.CheckedState.Parent = Me.btn_acessar
        Me.btn_acessar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_acessar.CustomImages.Parent = Me.btn_acessar
        Me.btn_acessar.FillColor = System.Drawing.Color.White
        Me.btn_acessar.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_acessar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_acessar.ForeColor = System.Drawing.Color.Black
        Me.btn_acessar.HoverState.Parent = Me.btn_acessar
        Me.btn_acessar.Location = New System.Drawing.Point(51, 302)
        Me.btn_acessar.Name = "btn_acessar"
        Me.btn_acessar.ShadowDecoration.Parent = Me.btn_acessar
        Me.btn_acessar.Size = New System.Drawing.Size(196, 32)
        Me.btn_acessar.TabIndex = 2
        Me.btn_acessar.Text = "Acessar"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.BorderRadius = 5
        Me.ProgressBar2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBar2.Location = New System.Drawing.Point(51, 352)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.ProgressColor = System.Drawing.Color.CornflowerBlue
        Me.ProgressBar2.ProgressColor2 = System.Drawing.Color.Navy
        Me.ProgressBar2.ShadowDecoration.Parent = Me.ProgressBar2
        Me.ProgressBar2.Size = New System.Drawing.Size(196, 10)
        Me.ProgressBar2.TabIndex = 6
        Me.ProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Guna2ImageCheckBox1
        '
        Me.Guna2ImageCheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageCheckBox1.CheckedState.ImageSize = New System.Drawing.Size(25, 25)
        Me.Guna2ImageCheckBox1.CheckedState.Parent = Me.Guna2ImageCheckBox1
        Me.Guna2ImageCheckBox1.HoverState.Parent = Me.Guna2ImageCheckBox1
        Me.Guna2ImageCheckBox1.Image = Global.Estudo_2022.My.Resources.Resources.icons8_eye_48
        Me.Guna2ImageCheckBox1.ImageSize = New System.Drawing.Size(21, 21)
        Me.Guna2ImageCheckBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Guna2ImageCheckBox1.Location = New System.Drawing.Point(205, 253)
        Me.Guna2ImageCheckBox1.Name = "Guna2ImageCheckBox1"
        Me.Guna2ImageCheckBox1.PressedState.Parent = Me.Guna2ImageCheckBox1
        Me.Guna2ImageCheckBox1.Size = New System.Drawing.Size(34, 27)
        Me.Guna2ImageCheckBox1.TabIndex = 21
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = Global.Estudo_2022.My.Resources.Resources.Login_Elipce
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(102, 89)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(95, 95)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 20
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'txt_password
        '
        Me.txt_password.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txt_password.BorderRadius = 10
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.DefaultText = ""
        Me.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.DisabledState.Parent = Me.txt_password
        Me.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.FocusedState.Parent = Me.txt_password
        Me.txt_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.HoverState.Parent = Me.txt_password
        Me.txt_password.IconLeft = Global.Estudo_2022.My.Resources.Resources.icons8_secure_32
        Me.txt_password.Location = New System.Drawing.Point(51, 252)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_password.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_password.PlaceholderText = "               Senha"
        Me.txt_password.SelectedText = ""
        Me.txt_password.ShadowDecoration.Parent = Me.txt_password
        Me.txt_password.Size = New System.Drawing.Size(196, 32)
        Me.txt_password.TabIndex = 1
        Me.txt_password.UseSystemPasswordChar = True
        '
        'txt_login
        '
        Me.txt_login.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.txt_login.BorderRadius = 10
        Me.txt_login.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_login.DefaultText = ""
        Me.txt_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_login.DisabledState.Parent = Me.txt_login
        Me.txt_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_login.FocusedState.Parent = Me.txt_login
        Me.txt_login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txt_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_login.HoverState.Parent = Me.txt_login
        Me.txt_login.IconLeft = Global.Estudo_2022.My.Resources.Resources.icons8_user_32
        Me.txt_login.Location = New System.Drawing.Point(51, 202)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_login.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txt_login.PlaceholderText = "               Usuário"
        Me.txt_login.SelectedText = ""
        Me.txt_login.ShadowDecoration.Parent = Me.txt_login
        Me.txt_login.Size = New System.Drawing.Size(196, 32)
        Me.txt_login.TabIndex = 0
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(300, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2ImageCheckBox1)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.btn_acessar)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.txtContador)
        Me.Controls.Add(Me.GunaGradientTileButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login cliente"
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtContador As Label
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaGradientTileButton1 As Guna.UI.WinForms.GunaGradientTileButton
    Friend WithEvents txt_login As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_acessar As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ProgressBar2 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2ImageCheckBox1 As Guna.UI2.WinForms.Guna2ImageCheckBox
End Class
